using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetTool
{
    public class SysTrayMenu
    {
        public NotifyIcon niNetToolMenu;
        public MenuItem miProxyEnabled;
        public MenuItem miQuit;

        bool proxyEnabled;
        public SysTrayMenu()
        {
            // Borrow FormNetTool's Resource manager
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNetTool));
            niNetToolMenu = new NotifyIcon();

            ContextMenu cmenu = new System.Windows.Forms.ContextMenu();
            miProxyEnabled = new MenuItem("Enable Proxy", cmEnableProxy);
            proxyEnabled = ProxyControl.ProxyEnabled;
            miProxyEnabled.Checked = proxyEnabled;
            miQuit = new MenuItem("Quit", cmQuit);
            cmenu.MenuItems.Add(miProxyEnabled);
            cmenu.MenuItems.Add(miQuit);
            niNetToolMenu.ContextMenu = cmenu;
            niNetToolMenu.BalloonTipText = "NetTool rapidly switches between proxied and unproxied internet access.";
            niNetToolMenu.BalloonTipTitle = "NetTool";
            niNetToolMenu.Icon = ((System.Drawing.Icon)(resources.GetObject("niNetToolMenu.Icon")));
            niNetToolMenu.Text = "NetTool";
            niNetToolMenu.Visible = true;
            Application.ApplicationExit += Application_ApplicationExit;
        }

        void Application_ApplicationExit(object sender, EventArgs e)
        {
 	        niNetToolMenu.Visible = false;
            niNetToolMenu.Dispose();
        }

        private void cmQuit(object sender, EventArgs e)
        {
            niNetToolMenu.Visible = false;
            niNetToolMenu.Dispose();
            Application.Exit();
        }

        private void cmEnableProxy(object sender, EventArgs e)
        {
            proxyEnabled = !proxyEnabled;
            miProxyEnabled.Checked = proxyEnabled;
            ProxyControl.ConfigureProxy(proxyEnabled);
        }
    }
}
