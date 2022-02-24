namespace ShoesPDA2
{
    partial class frmConfigCheckPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigCheckPassword));
            this.panelMain = new System.Windows.Forms.Panel();
            this.picBackup = new System.Windows.Forms.PictureBox();
            this.picLogoon = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.picBackup);
            this.panelMain.Controls.Add(this.picLogoon);
            this.panelMain.Controls.Add(this.txtPassword);
            this.panelMain.Controls.Add(this.picPassword);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(235, 290);
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
            // picLogoon
            // 
            this.picLogoon.BackColor = System.Drawing.Color.White;
            this.picLogoon.Image = ((System.Drawing.Image)(resources.GetObject("picLogoon.Image")));
            this.picLogoon.Location = new System.Drawing.Point(178, 125);
            this.picLogoon.Name = "picLogoon";
            this.picLogoon.Size = new System.Drawing.Size(25, 26);
            this.picLogoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoon.Click += new System.EventHandler(this.picLogoon_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Location = new System.Drawing.Point(30, 125);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(143, 26);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.GotFocus += new System.EventHandler(this.txtPassword_GotFocus);
            // 
            // picPassword
            // 
            this.picPassword.BackColor = System.Drawing.Color.White;
            this.picPassword.Image = ((System.Drawing.Image)(resources.GetObject("picPassword.Image")));
            this.picPassword.Location = new System.Drawing.Point(97, 65);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(40, 40);
            this.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // frmConfigCheckPassword
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
            this.Name = "frmConfigCheckPassword";
            this.Text = "密码";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmConfigCheckPassword_Load);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox picBackup;
        private System.Windows.Forms.PictureBox picLogoon;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox picPassword;
    }
}