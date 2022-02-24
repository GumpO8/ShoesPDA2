namespace ShoesPDA2
{
    partial class frmConfigServer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigServer));
            this.panelMain = new System.Windows.Forms.Panel();
            this.cboServers = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picBackup = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.cboServers);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.picBackup);
            this.panelMain.Location = new System.Drawing.Point(0, -1);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(235, 290);
            // 
            // cboServers
            // 
            this.cboServers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.cboServers.Items.Add("LF");
            this.cboServers.Items.Add("RX");
            this.cboServers.Items.Add("LQ");
            this.cboServers.Location = new System.Drawing.Point(86, 50);
            this.cboServers.Name = "cboServers";
            this.cboServers.Size = new System.Drawing.Size(127, 27);
            this.cboServers.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(19, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.Text = "数据库";
            // 
            // picBackup
            // 
            this.picBackup.Image = ((System.Drawing.Image)(resources.GetObject("picBackup.Image")));
            this.picBackup.Location = new System.Drawing.Point(5, 5);
            this.picBackup.Name = "picBackup";
            this.picBackup.Size = new System.Drawing.Size(30, 30);
            this.picBackup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackup.Click += new System.EventHandler(this.picBackup_Click);
            // 
            // frmConfigServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.ControlBox = false;
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmConfigServer";
            this.Text = "配置";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmConfigServer_Load);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox picBackup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboServers;
    }
}