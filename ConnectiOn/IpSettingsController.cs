using System.Diagnostics;

namespace ConnectiOn
{
    class IpSettingsController
    {
        public void Set(string ip, string mask, string gateway, string connectionName)
        {
            var processStartInfo = new ProcessStartInfo("cmd.exe")
            {
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                UseShellExecute = false
            };
            var process = Process.Start(processStartInfo);
            process.StandardInput.WriteLine(
                "netsh interface ip set address \"" + connectionName + "\" static " 
                + ip + " " + mask + " " + gateway + " 1"
                );
            process.StandardInput.Close();
        }

        public void Reset(string connectionName)
        {
            var processStartInfo = new ProcessStartInfo("cmd.exe")
            {
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
                UseShellExecute = false
            };
            var process = Process.Start(processStartInfo);
            process.StandardInput.WriteLine("netsh interface ip set address \"" + connectionName + "\" dhcp");
            process.StandardInput.Close();
        }
    }
}
