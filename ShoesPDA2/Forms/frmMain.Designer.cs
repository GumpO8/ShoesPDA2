namespace ShoesPDA2
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picUpload = new System.Windows.Forms.PictureBox();
            this.lbEdition = new System.Windows.Forms.Label();
            this.picExist = new System.Windows.Forms.PictureBox();
            this.picReport = new System.Windows.Forms.PictureBox();
            this.picConfig = new System.Windows.Forms.PictureBox();
            this.picDownload = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblCopyright);
            this.panel2.Controls.Add(this.picLogo);
            this.panel2.Controls.Add(this.picUpload);
            this.panel2.Controls.Add(this.lbEdition);
            this.panel2.Controls.Add(this.picExist);
            this.panel2.Controls.Add(this.picReport);
            this.panel2.Controls.Add(this.picConfig);
            this.panel2.Controls.Add(this.picDownload);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 290);
            // 
            // lblCopyright
            // 
            this.lblCopyright.Location = new System.Drawing.Point(5, 265);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(218, 20);
            this.lblCopyright.Text = "LQ Shoe All rights reserved @2019.";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(10, 7);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(180, 45);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // picUpload
            // 
            this.picUpload.Image = ((System.Drawing.Image)(resources.GetObject("picUpload.Image")));
            this.picUpload.Location = new System.Drawing.Point(5, 187);
            this.picUpload.Name = "picUpload";
            this.picUpload.Size = new System.Drawing.Size(50, 50);
            this.picUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUpload.Click += new System.EventHandler(this.picUpload_Click);
            // 
            // lbEdition
            // 
            this.lbEdition.Location = new System.Drawing.Point(10, 244);
            this.lbEdition.Name = "lbEdition";
            this.lbEdition.Size = new System.Drawing.Size(213, 21);
            this.lbEdition.Text = "V1.0";
            this.lbEdition.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // picExist
            // 
            this.picExist.Image = ((System.Drawing.Image)(resources.GetObject("picExist.Image")));
            this.picExist.Location = new System.Drawing.Point(173, 187);
            this.picExist.Name = "picExist";
            this.picExist.Size = new System.Drawing.Size(50, 50);
            this.picExist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExist.Click += new System.EventHandler(this.picExist_Click);
            // 
            // picReport
            // 
            this.picReport.Image = ((System.Drawing.Image)(resources.GetObject("picReport.Image")));
            this.picReport.Location = new System.Drawing.Point(72, 58);
            this.picReport.Name = "picReport";
            this.picReport.Size = new System.Drawing.Size(110, 110);
            this.picReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReport.Click += new System.EventHandler(this.picReport_Click);
            // 
            // picConfig
            // 
            this.picConfig.Image = ((System.Drawing.Image)(resources.GetObject("picConfig.Image")));
            this.picConfig.Location = new System.Drawing.Point(62, 187);
            this.picConfig.Name = "picConfig";
            this.picConfig.Size = new System.Drawing.Size(50, 50);
            this.picConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picConfig.Click += new System.EventHandler(this.picConfig_Click);
            // 
            // picDownload
            // 
            this.picDownload.Image = ((System.Drawing.Image)(resources.GetObject("picDownload.Image")));
            this.picDownload.Location = new System.Drawing.Point(119, 187);
            this.picDownload.Name = "picDownload";
            this.picDownload.Size = new System.Drawing.Size(50, 50);
            this.picDownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDownload.Click += new System.EventHandler(this.picDownload_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 0);
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "工序报工";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picUpload;
        private System.Windows.Forms.Label lbEdition;
        private System.Windows.Forms.PictureBox picExist;
        private System.Windows.Forms.PictureBox picReport;
        private System.Windows.Forms.PictureBox picConfig;
        private System.Windows.Forms.PictureBox picDownload;

    }
}

