using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NetTool
{
    public class ProxyControl
    {
        const string proxyKey = @"Software\Microsoft\Windows\CurrentVersion\Internet Settings";

        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;

        public static void ConfigureProxy(bool enabled, string proxyUrl = null) {
            bool ok;
            var registry = Registry.CurrentUser.OpenSubKey(proxyKey, true);
            registry.SetValue("ProxyEnable", enabled ? 1 : 0);
            if (proxyUrl != null)
            {
                registry.SetValue("ProxyServer", proxyUrl);
            }
            registry.Close();
            registry.Dispose();

            // Refresh all running applications with the new proxy settings
            ok = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            if (!ok)
            {
                throw new InvalidOperationException("Failed to change internet settings");
            }
            ok = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
            if (!ok)
            {
                throw new InvalidOperationException("Failed to refresh internet settings");
            }
            
        }

        public static bool ProxyEnabled
        {
            get
            {
                var registry = Registry.CurrentUser.OpenSubKey(proxyKey, false);
                object value = registry.GetValue("ProxyEnable");
                bool enabled = (Int32.Parse(value.ToString()) != 0);
                registry.Close();
                registry.Dispose();
                return enabled;
            }
        }

        public static string ProxyUrl
        {
            get
            {
                var registry = Registry.CurrentUser.OpenSubKey(proxyKey, false);
                object value = registry.GetValue("ProxyServer");
                string proxyUrl = value.ToString();
                registry.Close();
                registry.Dispose();
                return proxyUrl;
            }
        }

    }
}
