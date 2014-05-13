namespace ConnectiOn
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.wifiGroupBox = new System.Windows.Forms.GroupBox();
            this.wifiShowPassCheckBox = new System.Windows.Forms.CheckBox();
            this.wifiChangeStatusButton = new System.Windows.Forms.Button();
            this.wifiPassTextBox = new System.Windows.Forms.TextBox();
            this.wifiNameTextBox = new System.Windows.Forms.TextBox();
            this.shareGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shareStopButton = new System.Windows.Forms.Button();
            this.shareStartButton = new System.Windows.Forms.Button();
            this.shareToComboBox = new System.Windows.Forms.ComboBox();
            this.shareFromComboBox = new System.Windows.Forms.ComboBox();
            this.proxyGroupBox = new System.Windows.Forms.GroupBox();
            this.proxyTestButton = new System.Windows.Forms.Button();
            this.proxyStopButton = new System.Windows.Forms.Button();
            this.proxyStartButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.proxyPortTextBox = new System.Windows.Forms.TextBox();
            this.proxyHostTextBox = new System.Windows.Forms.TextBox();
            this.ChartGroupBox = new System.Windows.Forms.GroupBox();
            this.activityInfoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.activityRefreshButton = new System.Windows.Forms.Button();
            this.activityComboBox = new System.Windows.Forms.ComboBox();
            this.graphChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.wifiGroupBox.SuspendLayout();
            this.shareGroupBox.SuspendLayout();
            this.proxyGroupBox.SuspendLayout();
            this.ChartGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphChart)).BeginInit();
            this.SuspendLayout();
            // 
            // wifiGroupBox
            // 
            this.wifiGroupBox.Controls.Add(this.wifiShowPassCheckBox);
            this.wifiGroupBox.Controls.Add(this.wifiChangeStatusButton);
            this.wifiGroupBox.Controls.Add(this.wifiPassTextBox);
            this.wifiGroupBox.Controls.Add(this.wifiNameTextBox);
            this.wifiGroupBox.Location = new System.Drawing.Point(12, 13);
            this.wifiGroupBox.Name = "wifiGroupBox";
            this.wifiGroupBox.Size = new System.Drawing.Size(263, 100);
            this.wifiGroupBox.TabIndex = 0;
            this.wifiGroupBox.TabStop = false;
            this.wifiGroupBox.Text = "Wi-Fi";
            // 
            // wifiShowPassCheckBox
            // 
            this.wifiShowPassCheckBox.AutoSize = true;
            this.wifiShowPassCheckBox.Location = new System.Drawing.Point(133, 47);
            this.wifiShowPassCheckBox.Name = "wifiShowPassCheckBox";
            this.wifiShowPassCheckBox.Size = new System.Drawing.Size(114, 17);
            this.wifiShowPassCheckBox.TabIndex = 2;
            this.wifiShowPassCheckBox.Text = "Показать пароль";
            this.wifiShowPassCheckBox.UseVisualStyleBackColor = true;
            this.wifiShowPassCheckBox.CheckedChanged += new System.EventHandler(this.wifiShowPassCheckBox_CheckedChanged);
            // 
            // wifiChangeStatusButton
            // 
            this.wifiChangeStatusButton.Location = new System.Drawing.Point(7, 71);
            this.wifiChangeStatusButton.Name = "wifiChangeStatusButton";
            this.wifiChangeStatusButton.Size = new System.Drawing.Size(246, 23);
            this.wifiChangeStatusButton.TabIndex = 3;
            this.wifiChangeStatusButton.Text = "Создать подключение";
            this.wifiChangeStatusButton.UseVisualStyleBackColor = true;
            this.wifiChangeStatusButton.Click += new System.EventHandler(this.wifiChangeStatusButton_Click);
            // 
            // wifiPassTextBox
            // 
            this.wifiPassTextBox.Location = new System.Drawing.Point(133, 20);
            this.wifiPassTextBox.Name = "wifiPassTextBox";
            this.wifiPassTextBox.PasswordChar = '*';
            this.wifiPassTextBox.Size = new System.Drawing.Size(120, 20);
            this.wifiPassTextBox.TabIndex = 1;
            this.wifiPassTextBox.Text = "Ключ   ";
            // 
            // wifiNameTextBox
            // 
            this.wifiNameTextBox.Location = new System.Drawing.Point(7, 20);
            this.wifiNameTextBox.Name = "wifiNameTextBox";
            this.wifiNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.wifiNameTextBox.TabIndex = 0;
            this.wifiNameTextBox.Text = "SSID   ";
            // 
            // shareGroupBox
            // 
            this.shareGroupBox.Controls.Add(this.label2);
            this.shareGroupBox.Controls.Add(this.label1);
            this.shareGroupBox.Controls.Add(this.shareStopButton);
            this.shareGroupBox.Controls.Add(this.shareStartButton);
            this.shareGroupBox.Controls.Add(this.shareToComboBox);
            this.shareGroupBox.Controls.Add(this.shareFromComboBox);
            this.shareGroupBox.Location = new System.Drawing.Point(12, 119);
            this.shareGroupBox.Name = "shareGroupBox";
            this.shareGroupBox.Size = new System.Drawing.Size(263, 100);
            this.shareGroupBox.TabIndex = 1;
            this.shareGroupBox.TabStop = false;
            this.shareGroupBox.Text = "Общий доступ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "В";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Из";
            // 
            // shareStopButton
            // 
            this.shareStopButton.Location = new System.Drawing.Point(133, 71);
            this.shareStopButton.Name = "shareStopButton";
            this.shareStopButton.Size = new System.Drawing.Size(120, 23);
            this.shareStopButton.TabIndex = 3;
            this.shareStopButton.Text = "Остановить";
            this.shareStopButton.UseVisualStyleBackColor = true;
            this.shareStopButton.Click += new System.EventHandler(this.shareStopButton_Click);
            // 
            // shareStartButton
            // 
            this.shareStartButton.Location = new System.Drawing.Point(7, 71);
            this.shareStartButton.Name = "shareStartButton";
            this.shareStartButton.Size = new System.Drawing.Size(120, 23);
            this.shareStartButton.TabIndex = 2;
            this.shareStartButton.Text = "Расшарить";
            this.shareStartButton.UseVisualStyleBackColor = true;
            this.shareStartButton.Click += new System.EventHandler(this.shareStartButton_Click);
            // 
            // shareToComboBox
            // 
            this.shareToComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shareToComboBox.Location = new System.Drawing.Point(33, 46);
            this.shareToComboBox.Name = "shareToComboBox";
            this.shareToComboBox.Size = new System.Drawing.Size(220, 21);
            this.shareToComboBox.TabIndex = 1;
            // 
            // shareFromComboBox
            // 
            this.shareFromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shareFromComboBox.Location = new System.Drawing.Point(33, 19);
            this.shareFromComboBox.Name = "shareFromComboBox";
            this.shareFromComboBox.Size = new System.Drawing.Size(220, 21);
            this.shareFromComboBox.TabIndex = 0;
            // 
            // proxyGroupBox
            // 
            this.proxyGroupBox.Controls.Add(this.proxyTestButton);
            this.proxyGroupBox.Controls.Add(this.proxyStopButton);
            this.proxyGroupBox.Controls.Add(this.proxyStartButton);
            this.proxyGroupBox.Controls.Add(this.label3);
            this.proxyGroupBox.Controls.Add(this.proxyPortTextBox);
            this.proxyGroupBox.Controls.Add(this.proxyHostTextBox);
            this.proxyGroupBox.Location = new System.Drawing.Point(13, 226);
            this.proxyGroupBox.Name = "proxyGroupBox";
            this.proxyGroupBox.Size = new System.Drawing.Size(262, 77);
            this.proxyGroupBox.TabIndex = 2;
            this.proxyGroupBox.TabStop = false;
            this.proxyGroupBox.Text = "Прокси";
            // 
            // proxyTestButton
            // 
            this.proxyTestButton.Location = new System.Drawing.Point(175, 45);
            this.proxyTestButton.Name = "proxyTestButton";
            this.proxyTestButton.Size = new System.Drawing.Size(77, 23);
            this.proxyTestButton.TabIndex = 7;
            this.proxyTestButton.Text = "Тест";
            this.proxyTestButton.UseVisualStyleBackColor = true;
            this.proxyTestButton.Click += new System.EventHandler(this.proxyTestButton_Click);
            // 
            // proxyStopButton
            // 
            this.proxyStopButton.Location = new System.Drawing.Point(87, 45);
            this.proxyStopButton.Name = "proxyStopButton";
            this.proxyStopButton.Size = new System.Drawing.Size(82, 23);
            this.proxyStopButton.TabIndex = 6;
            this.proxyStopButton.Text = "Отключить";
            this.proxyStopButton.UseVisualStyleBackColor = true;
            this.proxyStopButton.Click += new System.EventHandler(this.proxyStopButton_Click);
            // 
            // proxyStartButton
            // 
            this.proxyStartButton.Location = new System.Drawing.Point(6, 45);
            this.proxyStartButton.Name = "proxyStartButton";
            this.proxyStartButton.Size = new System.Drawing.Size(75, 23);
            this.proxyStartButton.TabIndex = 5;
            this.proxyStartButton.Text = "Включить";
            this.proxyStartButton.UseVisualStyleBackColor = true;
            this.proxyStartButton.Click += new System.EventHandler(this.proxyStartButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = ":";
            // 
            // proxyPortTextBox
            // 
            this.proxyPortTextBox.Location = new System.Drawing.Point(191, 19);
            this.proxyPortTextBox.Name = "proxyPortTextBox";
            this.proxyPortTextBox.Size = new System.Drawing.Size(61, 20);
            this.proxyPortTextBox.TabIndex = 3;
            this.proxyPortTextBox.Text = "Порт   ";
            // 
            // proxyHostTextBox
            // 
            this.proxyHostTextBox.Location = new System.Drawing.Point(6, 19);
            this.proxyHostTextBox.Name = "proxyHostTextBox";
            this.proxyHostTextBox.Size = new System.Drawing.Size(163, 20);
            this.proxyHostTextBox.TabIndex = 2;
            this.proxyHostTextBox.Text = "Сервер   ";
            // 
            // ChartGroupBox
            // 
            this.ChartGroupBox.Controls.Add(this.activityInfoRichTextBox);
            this.ChartGroupBox.Controls.Add(this.activityRefreshButton);
            this.ChartGroupBox.Controls.Add(this.activityComboBox);
            this.ChartGroupBox.Controls.Add(this.graphChart);
            this.ChartGroupBox.Location = new System.Drawing.Point(282, 13);
            this.ChartGroupBox.Name = "ChartGroupBox";
            this.ChartGroupBox.Size = new System.Drawing.Size(367, 420);
            this.ChartGroupBox.TabIndex = 4;
            this.ChartGroupBox.TabStop = false;
            this.ChartGroupBox.Text = "Активность сети";
            // 
            // activityInfoRichTextBox
            // 
            this.activityInfoRichTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.activityInfoRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.activityInfoRichTextBox.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activityInfoRichTextBox.Location = new System.Drawing.Point(7, 47);
            this.activityInfoRichTextBox.Name = "activityInfoRichTextBox";
            this.activityInfoRichTextBox.ReadOnly = true;
            this.activityInfoRichTextBox.Size = new System.Drawing.Size(354, 159);
            this.activityInfoRichTextBox.TabIndex = 8;
            this.activityInfoRichTextBox.Text = "";
            // 
            // activityRefreshButton
            // 
            this.activityRefreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("activityRefreshButton.BackgroundImage")));
            this.activityRefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.activityRefreshButton.Location = new System.Drawing.Point(338, 19);
            this.activityRefreshButton.Name = "activityRefreshButton";
            this.activityRefreshButton.Size = new System.Drawing.Size(23, 21);
            this.activityRefreshButton.TabIndex = 7;
            this.activityRefreshButton.UseVisualStyleBackColor = true;
            this.activityRefreshButton.Click += new System.EventHandler(this.activityRefreshButton_Click);
            // 
            // activityComboBox
            // 
            this.activityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activityComboBox.Location = new System.Drawing.Point(6, 19);
            this.activityComboBox.Name = "activityComboBox";
            this.activityComboBox.Size = new System.Drawing.Size(326, 21);
            this.activityComboBox.TabIndex = 6;
            this.activityComboBox.SelectedIndexChanged += new System.EventHandler(this.activityComboBox_SelectedIndexChanged);
            // 
            // graphChart
            // 
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.graphChart.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.graphChart.Legends.Add(legend1);
            this.graphChart.Location = new System.Drawing.Point(6, 213);
            this.graphChart.Name = "graphChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "Отправлено, Кб";
            series1.Name = "Sent";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "Получено, Кб";
            series2.Name = "Received";
            this.graphChart.Series.Add(series1);
            this.graphChart.Series.Add(series2);
            this.graphChart.Size = new System.Drawing.Size(355, 201);
            this.graphChart.TabIndex = 0;
            this.graphChart.Text = "Активность сети";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(661, 448);
            this.Controls.Add(this.ChartGroupBox);
            this.Controls.Add(this.proxyGroupBox);
            this.Controls.Add(this.shareGroupBox);
            this.Controls.Add(this.wifiGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ConnectiOn";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.wifiGroupBox.ResumeLayout(false);
            this.wifiGroupBox.PerformLayout();
            this.shareGroupBox.ResumeLayout(false);
            this.shareGroupBox.PerformLayout();
            this.proxyGroupBox.ResumeLayout(false);
            this.proxyGroupBox.PerformLayout();
            this.ChartGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graphChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox wifiGroupBox;
        private System.Windows.Forms.GroupBox shareGroupBox;
        private System.Windows.Forms.GroupBox proxyGroupBox;
        private System.Windows.Forms.GroupBox ChartGroupBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart graphChart;
        private System.Windows.Forms.TextBox wifiPassTextBox;
        private System.Windows.Forms.TextBox wifiNameTextBox;
        private System.Windows.Forms.Button wifiChangeStatusButton;
        private System.Windows.Forms.CheckBox wifiShowPassCheckBox;
        private System.Windows.Forms.ComboBox shareFromComboBox;
        private System.Windows.Forms.ComboBox shareToComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button shareStopButton;
        private System.Windows.Forms.Button shareStartButton;
        private System.Windows.Forms.ComboBox activityComboBox;
        private System.Windows.Forms.Button activityRefreshButton;
        private System.Windows.Forms.RichTextBox activityInfoRichTextBox;
        private System.Windows.Forms.TextBox proxyPortTextBox;
        private System.Windows.Forms.TextBox proxyHostTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button proxyTestButton;
        private System.Windows.Forms.Button proxyStopButton;
        private System.Windows.Forms.Button proxyStartButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

