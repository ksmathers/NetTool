namespace NetTool
{
    partial class FormNetTool
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNetTool));
            this.niNetToolMenu = new System.Windows.Forms.NotifyIcon(this.components);
            this.cbEnableProxy = new System.Windows.Forms.CheckBox();
            this.bApply = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // niNetToolMenu
            // 
            this.niNetToolMenu.BalloonTipText = "NetTool rapidly switches between proxied and unproxied internet access.";
            this.niNetToolMenu.BalloonTipTitle = "NetTool";
            this.niNetToolMenu.Icon = ((System.Drawing.Icon)(resources.GetObject("niNetToolMenu.Icon")));
            this.niNetToolMenu.Text = "NetTool";
            this.niNetToolMenu.Visible = true;
            // 
            // cbEnableProxy
            // 
            this.cbEnableProxy.AutoSize = true;
            this.cbEnableProxy.Location = new System.Drawing.Point(22, 15);
            this.cbEnableProxy.Name = "cbEnableProxy";
            this.cbEnableProxy.Size = new System.Drawing.Size(88, 17);
            this.cbEnableProxy.TabIndex = 0;
            this.cbEnableProxy.Text = "Enable Proxy";
            this.cbEnableProxy.UseVisualStyleBackColor = true;
            // 
            // bApply
            // 
            this.bApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bApply.Location = new System.Drawing.Point(106, 41);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(75, 23);
            this.bApply.TabIndex = 1;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = true;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FormNetTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 76);
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.cbEnableProxy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNetTool";
            this.Text = "NetTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.NotifyIcon niNetToolMenu;
        private System.Windows.Forms.CheckBox cbEnableProxy;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

