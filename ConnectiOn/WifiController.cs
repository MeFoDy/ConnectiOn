using System.Diagnostics;

namespace ConnectiOn
{
    class WifiController
    {
        private bool _isWiFiStarted;
        public bool Started
        {
            get { return _isWiFiStarted; }
        }

        private string _ssid = "";
        public string Ssid
        {
            get { return _ssid; }
        }

        public void Start(string ssid, string key)
        {
            _ssid = ssid;
            var processStartInfo = new ProcessStartInfo("cmd.exe")
                {
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    UseShellExecute = false
                };
            var process = Process.Start(processStartInfo);

            if (!_isWiFiStarted)
            {
                process.StandardInput.WriteLine("netsh wlan set hostednetwork mode=allow ssid=\"" + _ssid + "\" key=\"" + key + "\"");
                process.StandardInput.WriteLine("netsh wlan start hosted network");
                process.StandardInput.Close();
                _isWiFiStarted = true;
            }
        }

        public void Stop()
        {
            var processStartInfo = new ProcessStartInfo("cmd.exe")
            {
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                UseShellExecute = false
            };
            var process = Process.Start(processStartInfo);

            if (_isWiFiStarted)
            {
                process.StandardInput.WriteLine("netsh wlan stop hostednetwork");
                process.StandardInput.Close();
                _isWiFiStarted = false;
            }
        }
    }
}
