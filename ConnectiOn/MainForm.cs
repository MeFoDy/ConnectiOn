using System;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;
using IcsManagerLibrary;
using NETCONLib;

namespace ConnectiOn
{
    public partial class MainForm : Form
    {
        readonly WifiController _wifiController = new WifiController();
        readonly ProxyController _proxyController = new ProxyController();
        readonly IpSettingsController _ipSettingsController = new IpSettingsController();
        readonly GraphHelper _graphHelper = new GraphHelper();
        private string _activityGuid = "";

        public MainForm()
        {
            InitializeComponent();
            AddEvents();
        }

        public void AddEvents()
        {
            // Wi-Fi Buttons
            AddPlaceholderToTextBox(wifiNameTextBox, @"SSID");
            AddPlaceholderToTextBox(wifiPassTextBox, @"Ключ");

            // Proxy Buttons
            AddPlaceholderToTextBox(proxyHostTextBox, @"Сервер");
            AddPlaceholderToTextBox(proxyPortTextBox, @"Порт");
        }

        private void AddNic(NetworkInterface nic)
        {
            var connItem = new ConnectionItem(nic);
            shareFromComboBox.Items.Add(connItem);
            shareToComboBox.Items.Add(connItem);
            activityComboBox.Items.Add(connItem);
            var netShareConnection = connItem.Connection;
            if (netShareConnection != null)
            {
                var sc = IcsManager.GetConfiguration(netShareConnection);
                if (sc.SharingEnabled)
                {
                    switch (sc.SharingConnectionType)
                    {
                        case tagSHARINGCONNECTIONTYPE.ICSSHARINGTYPE_PUBLIC:
                            shareFromComboBox.SelectedIndex = shareFromComboBox.Items.Count - 1;
                            break;
                        case tagSHARINGCONNECTIONTYPE.ICSSHARINGTYPE_PRIVATE:
                            shareToComboBox.SelectedIndex = shareToComboBox.Items.Count - 1;
                            break;
                    }
                }
            }
        }

        private void RefreshConnections()
        {
            shareFromComboBox.Items.Clear();
            shareToComboBox.Items.Clear();
            activityComboBox.Items.Clear();
            foreach (var nic in IcsManager.GetIPv4EthernetAndWirelessInterfaces())
            {
                AddNic(nic);
            }
        }

        public void AddPlaceholderToTextBox(TextBox textBox, string placeholder)
        {
            textBox.ForeColor = Color.Gray;
            textBox.GotFocus += (sender, args) =>
            {
                if (textBox.Text == placeholder + @"   ")
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };
            textBox.LostFocus += (sender, args) =>
            {
                if (textBox.Text == "")
                {
                    textBox.Text = placeholder + @"   ";
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private void wifiShowPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            wifiPassTextBox.PasswordChar = wifiShowPassCheckBox.Checked ? new char() : '*';
        }

        private void wifiChangeStatusButton_Click(object sender, EventArgs e)
        {
            if (!_wifiController.Started)
            {
                _wifiController.Start(wifiNameTextBox.Text, wifiPassTextBox.Text);
                wifiNameTextBox.ReadOnly = true;
                wifiPassTextBox.ReadOnly = true;
                wifiChangeStatusButton.Text = @"Остановить подключение";
            }
            else
            {

                _wifiController.Stop();
                wifiNameTextBox.ReadOnly = false;
                wifiPassTextBox.ReadOnly = false;
                wifiChangeStatusButton.Text = @"Создать подключение";
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshConnections();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(@"Для работы приложения нужны права администратора. Перезапустите, пожалуйста, приложение.");
            }
            catch (NotImplementedException)
            {
                MessageBox.Show(@"Ваша операционная система не поддерживает работу данного приложения.");
            }
            if (backgroundWorker.IsBusy != true)
            {
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void shareStartButton_Click(object sender, EventArgs e)
        {
            var sharedConnectionItem = shareFromComboBox.SelectedItem as ConnectionItem;
            var homeConnectionItem = shareToComboBox.SelectedItem as ConnectionItem;
            if ((sharedConnectionItem == null) || (homeConnectionItem == null))
            {
                MessageBox.Show(@"Укажите оба подключения.");
                return;
            }
            if (sharedConnectionItem.Nic.Id == homeConnectionItem.Nic.Id)
            {
                MessageBox.Show(@"Выберите разные подключения.");
                return;
            }
            IcsManager.ShareConnection(sharedConnectionItem.Connection, homeConnectionItem.Connection);
            RefreshConnections();
        }

        private void shareStopButton_Click(object sender, EventArgs e)
        {
            IcsManager.ShareConnection(null, null);
            RefreshConnections();
        }

        private void activityRefreshButton_Click(object sender, EventArgs e)
        {
            RefreshConnections();
        }

        private void activityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var activityItem = activityComboBox.SelectedItem as ConnectionItem;
            activityInfoRichTextBox.Text = "";
            if (activityItem != null)
            {
                var nic = activityItem.Nic;
                _activityGuid = nic.Id;
                activityInfoRichTextBox.Text += @"Name .......... : " + nic.Name;
                activityInfoRichTextBox.Text += "\nGUID .......... : " + nic.Id;
                activityInfoRichTextBox.Text += "\nStatus ........ : " + nic.OperationalStatus;
                activityInfoRichTextBox.Text += "\nInterfaceType . : " + nic.NetworkInterfaceType;
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    var ipprops = nic.GetIPProperties();
                    foreach (var a in ipprops.UnicastAddresses)
                    {
                        if (a.Address.AddressFamily == AddressFamily.InterNetwork)
                            activityInfoRichTextBox.Text += "\nUnicast address : " + a.Address + "/" + a.IPv4Mask;
                    }
                    foreach (var a in ipprops.GatewayAddresses)
                    {
                        activityInfoRichTextBox.Text += "\nGateway ....... : " + a.Address;
                    }
                }
                try
                {
                    var connection = IcsManager.GetConnectionById(nic.Id);
                    if (connection != null)
                    {
                        var props = IcsManager.GetProperties(connection);
                        activityInfoRichTextBox.Text += "\nDevice ........ : " + props.DeviceName;
                        var sc = IcsManager.GetConfiguration(connection);
                        if (sc.SharingEnabled)
                            activityInfoRichTextBox.Text += "\nSharingType ... : " + sc.SharingConnectionType;
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void proxyStartButton_Click(object sender, EventArgs e)
        {
            string host;
            int port;
            if (proxyHostTextBox.Text != "" && IsValidIp(proxyHostTextBox.Text))
            {
                host = proxyHostTextBox.Text;
            }
            else
            {
                MessageBox.Show(@"Введите правильный IP-адрес сервера.");
                return;
            }
            int.TryParse(proxyPortTextBox.Text, out port);

            _proxyController.StartProxy(host, port);
        }

        private void proxyStopButton_Click(object sender, EventArgs e)
        {
            _proxyController.StopProxy();
        }

        private void proxyTestButton_Click(object sender, EventArgs e)
        {
            string host;
            int port;
            bool ok = false;

            if (proxyHostTextBox.Text != "" && IsValidIp(proxyHostTextBox.Text))
            {
                host = proxyHostTextBox.Text;
            }
            else
            {
                MessageBox.Show(@"Введите правильный IP-адрес сервера.");
                return;
            }

            int.TryParse(proxyPortTextBox.Text, out port);

            try
            {
                var wc = new WebClient
                    {
                        Proxy = new WebProxy(host, port)
                    };
                wc.DownloadString("http://google.com/ncr");
                ok = true;
            }
            catch
            { }
            if (ok)
            {
                MessageBox.Show(@"Соединение успешно установлено.");
            }
            else
            {
                MessageBox.Show(@"Ошибка соединения. Проверьте введенные данные.");
            }
        }

        public bool IsValidIp(string addr)
        {
            IPAddress ip;
            var valid = !string.IsNullOrEmpty(addr) && IPAddress.TryParse(addr, out ip);
            return valid;
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            _graphHelper.Reset();
            while (true)
            {
                System.Threading.Thread.Sleep(200);
                _graphHelper.Refresh();
                lock (_graphHelper.Synchro)
                {
                    if (_graphHelper.GraphBytesSent.ContainsKey(_activityGuid))
                    {
                        var sent = _graphHelper.GraphBytesSent[_activityGuid];
                        var received = _graphHelper.GraphBytesReceived[_activityGuid];
                        graphChart.Invoke(new MethodInvoker(() =>
                            {
                                graphChart.Series["Sent"].Points.Clear();
                                graphChart.Series["Received"].Points.Clear();
                                for (int i = 0; i < _graphHelper.GraphPointCount; i++)
                                {
                                    graphChart.Series["Sent"].Points.AddXY(i, sent[i] / 1024.0);
                                    graphChart.Series["Received"].Points.AddXY(i, received[i] / 1024.0);
                                }
                            }
                            ));
                    }
                }
            }
        }

    }
}
