using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace NetTool
{
    public partial class FormNetTool : Form
    {
        public FormNetTool()
        {
            InitializeComponent();

            cbEnableProxy.Checked = ProxyControl.ProxyEnabled;

            ContextMenu cmenu = new System.Windows.Forms.ContextMenu();
            cmenu.MenuItems.Add(new MenuItem("Set Proxy...", cmSystray_Open));
            cmenu.MenuItems.Add(new MenuItem("Quit", cmSystray_Quit));
            niNetToolMenu.ContextMenu = cmenu;

            //WindowState = FormWindowState.Minimized;
            //niNetToolMenu.Visible = true;
            //ShowInTaskbar = false;
        }

        protected override void OnResize(EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            { 
                niNetToolMenu.Visible = true;
                niNetToolMenu.ShowBalloonTip(500);
                //this.Hide();
                ShowInTaskbar = false;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                niNetToolMenu.Visible = false;
                ShowInTaskbar = true;
            }
        }


        private void bApply_Click(object sender, System.EventArgs e)
        {
            ProxyControl.ConfigureProxy(cbEnableProxy.Checked);
            WindowState = FormWindowState.Minimized;
        }

        private void cmSystray_Quit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmSystray_Open(object sender, EventArgs e)
        {
            //this.Show();
            this.WindowState = FormWindowState.Normal;
            var cpos = Cursor.Position;
            this.Location = new Point(cpos.X - this.Width + 10, cpos.Y - this.Height + 10);
            this.Invalidate();
        }
    }
}
