namespace ShoesPDA2
{
    partial class frmUpload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpload));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.picExportTXT = new System.Windows.Forms.PictureBox();
            this.picReflash = new System.Windows.Forms.PictureBox();
            this.labRecordCount = new System.Windows.Forms.Label();
            this.picUpload = new System.Windows.Forms.PictureBox();
            this.lsvOperator = new System.Windows.Forms.ListView();
            this.colId = new System.Windows.Forms.ColumnHeader();
            this.colOpr = new System.Windows.Forms.ColumnHeader();
            this.colWorker = new System.Windows.Forms.ColumnHeader();
            this.colBarcode = new System.Windows.Forms.ColumnHeader();
            this.picBackup = new System.Windows.Forms.PictureBox();
            this.colCreatedDateTime = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.picExportTXT);
            this.panel1.Controls.Add(this.picReflash);
            this.panel1.Controls.Add(this.labRecordCount);
            this.panel1.Controls.Add(this.picUpload);
            this.panel1.Controls.Add(this.lsvOperator);
            this.panel1.Controls.Add(this.picBackup);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 290);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(27, 140);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(164, 20);
            this.progressBar.Visible = false;
            // 
            // picExportTXT
            // 
            this.picExportTXT.Image = ((System.Drawing.Image)(resources.GetObject("picExportTXT.Image")));
            this.picExportTXT.Location = new System.Drawing.Point(161, 5);
            this.picExportTXT.Name = "picExportTXT";
            this.picExportTXT.Size = new System.Drawing.Size(30, 30);
            this.picExportTXT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExportTXT.Click += new System.EventHandler(this.picExportTXT_Click);
            // 
            // picReflash
            // 
            this.picReflash.Image = ((System.Drawing.Image)(resources.GetObject("picReflash.Image")));
            this.picReflash.Location = new System.Drawing.Point(125, 5);
            this.picReflash.Name = "picReflash";
            this.picReflash.Size = new System.Drawing.Size(30, 30);
            this.picReflash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReflash.Click += new System.EventHandler(this.picReflash_Click);
            // 
            // labRecordCount
            // 
            this.labRecordCount.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labRecordCount.Location = new System.Drawing.Point(41, 15);
            this.labRecordCount.Name = "labRecordCount";
            this.labRecordCount.Size = new System.Drawing.Size(78, 20);
            this.labRecordCount.Text = "待上传:0";
            this.labRecordCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picUpload
            // 
            this.picUpload.Image = ((System.Drawing.Image)(resources.GetObject("picUpload.Image")));
            this.picUpload.Location = new System.Drawing.Point(197, 5);
            this.picUpload.Name = "picUpload";
            this.picUpload.Size = new System.Drawing.Size(30, 30);
            this.picUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUpload.Click += new System.EventHandler(this.picUpload_Click);
            // 
            // lsvOperator
            // 
            this.lsvOperator.Columns.Add(this.colId);
            this.lsvOperator.Columns.Add(this.colOpr);
            this.lsvOperator.Columns.Add(this.colWorker);
            this.lsvOperator.Columns.Add(this.colBarcode);
            this.lsvOperator.Columns.Add(this.colCreatedDateTime);
            this.lsvOperator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvOperator.FullRowSelect = true;
            listViewItem1.Text = "";
            listViewItem1.SubItems.Add("修毛");
            listViewItem1.SubItems.Add("1900001-0063755-047");
            this.lsvOperator.Items.Add(listViewItem1);
            this.lsvOperator.Location = new System.Drawing.Point(0, 41);
            this.lsvOperator.Name = "lsvOperator";
            this.lsvOperator.Size = new System.Drawing.Size(230, 249);
            this.lsvOperator.TabIndex = 7;
            this.lsvOperator.View = System.Windows.Forms.View.Details;
            this.lsvOperator.ItemActivate += new System.EventHandler(this.lsvOperator_ItemActivate);
            this.lsvOperator.SelectedIndexChanged += new System.EventHandler(this.lsvOperator_SelectedIndexChanged);
            // 
            // colId
            // 
            this.colId.Text = "ID";
            this.colId.Width = 0;
            // 
            // colOpr
            // 
            this.colOpr.Text = "工序";
            this.colOpr.Width = 50;
            // 
            // colWorker
            // 
            this.colWorker.Text = "员工";
            this.colWorker.Width = 55;
            // 
            // colBarcode
            // 
            this.colBarcode.Text = "条码";
            this.colBarcode.Width = 120;
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
            // colCreatedDateTime
            // 
            this.colCreatedDateTime.Text = "ColumnHeader";
            this.colCreatedDateTime.Width = 0;
            // 
            // frmUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmUpload";
            this.Text = "上传";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUpload_Load);
            this.Activated += new System.EventHandler(this.frmUpload_Activated);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.PictureBox picExportTXT;
        private System.Windows.Forms.PictureBox picReflash;
        private System.Windows.Forms.Label labRecordCount;
        private System.Windows.Forms.PictureBox picUpload;
        private System.Windows.Forms.ListView lsvOperator;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colOpr;
        private System.Windows.Forms.ColumnHeader colWorker;
        private System.Windows.Forms.ColumnHeader colBarcode;
        private System.Windows.Forms.PictureBox picBackup;
        private System.Windows.Forms.ColumnHeader colCreatedDateTime;
    }
}