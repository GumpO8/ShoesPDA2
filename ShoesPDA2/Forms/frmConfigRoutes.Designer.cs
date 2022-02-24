namespace ShoesPDA2
{
    partial class frmDownloadRoutes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDownloadRoutes));
            this.panelMain = new System.Windows.Forms.Panel();
            this.picDownload = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lsvRoutes = new System.Windows.Forms.ListView();
            this.RouteId = new System.Windows.Forms.ColumnHeader();
            this.RouteName = new System.Windows.Forms.ColumnHeader();
            this.AllowDuplo = new System.Windows.Forms.ColumnHeader();
            this.picBackup = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.picDownload);
            this.panelMain.Controls.Add(this.progressBar);
            this.panelMain.Controls.Add(this.lsvRoutes);
            this.panelMain.Controls.Add(this.picBackup);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(235, 290);
            // 
            // picDownload
            // 
            this.picDownload.Image = ((System.Drawing.Image)(resources.GetObject("picDownload.Image")));
            this.picDownload.Location = new System.Drawing.Point(202, 5);
            this.picDownload.Name = "picDownload";
            this.picDownload.Size = new System.Drawing.Size(30, 30);
            this.picDownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDownload.Click += new System.EventHandler(this.picDownload_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(35, 135);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(164, 20);
            this.progressBar.Visible = false;
            // 
            // lsvRoutes
            // 
            this.lsvRoutes.Columns.Add(this.RouteId);
            this.lsvRoutes.Columns.Add(this.RouteName);
            this.lsvRoutes.Columns.Add(this.AllowDuplo);
            this.lsvRoutes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvRoutes.FullRowSelect = true;
            this.lsvRoutes.Location = new System.Drawing.Point(0, 41);
            this.lsvRoutes.Name = "lsvRoutes";
            this.lsvRoutes.Size = new System.Drawing.Size(235, 249);
            this.lsvRoutes.TabIndex = 12;
            this.lsvRoutes.View = System.Windows.Forms.View.Details;
            // 
            // RouteId
            // 
            this.RouteId.Text = "工序";
            this.RouteId.Width = 50;
            // 
            // RouteName
            // 
            this.RouteName.Text = "工序名称";
            this.RouteName.Width = 110;
            // 
            // AllowDuplo
            // 
            this.AllowDuplo.Text = "重复";
            this.AllowDuplo.Width = 40;
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
            // frmDownloadRoutes
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
            this.Name = "frmDownloadRoutes";
            this.Text = "frmConfigRoutes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmConfigRoutes_Load);
            this.Activated += new System.EventHandler(this.frmConfigRoutes_Activated);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListView lsvRoutes;
        private System.Windows.Forms.ColumnHeader RouteId;
        private System.Windows.Forms.ColumnHeader RouteName;
        private System.Windows.Forms.ColumnHeader AllowDuplo;
        private System.Windows.Forms.PictureBox picBackup;
        private System.Windows.Forms.PictureBox picDownload;

    }
}