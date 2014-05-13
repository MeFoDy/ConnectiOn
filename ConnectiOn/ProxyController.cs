using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ConnectiOn
{
    class ProxyController
    {
        [DllImport("wininet.dll", SetLastError = true)]
        private static extern bool InternetSetOption(
            IntPtr hInternet,
            int dwOption,
            IntPtr lpBuffer,
            int lpdwBufferLength);

        public void StartProxy(string host, int port)
        {
            RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            if (registry != null)
            {
                registry.SetValue("ProxyEnable", 1);
                registry.SetValue("ProxyServer", host + ":" + port);
                UpdateInternetOption();
                MessageBox.Show(@"Настройки прокси изменены.");
                registry.Close();
            }
        }

        public void StopProxy()
        {
            RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            if (registry != null)
            {
                registry.SetValue("ProxyEnable", 0);
                UpdateInternetOption();
                MessageBox.Show(@"Прокси отключен.");
                registry.Close();
            }
        }

        private void UpdateInternetOption()
        {
            InternetSetOption(IntPtr.Zero, 39, IntPtr.Zero, 0); //INTERNET_OPTION_SETTINGS_CHANGED
            InternetSetOption(IntPtr.Zero, 37, IntPtr.Zero, 0); //INTERNET_OPTION_REFRESH
        }
    }
}
