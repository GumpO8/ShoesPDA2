namespace ShoesPDA2
{
    partial class frmReport
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReport));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtScanBox = new System.Windows.Forms.TextBox();
            this.lsvOperator = new System.Windows.Forms.ListView();
            this.colOpr = new System.Windows.Forms.ColumnHeader();
            this.colWorker = new System.Windows.Forms.ColumnHeader();
            this.colBarcode = new System.Windows.Forms.ColumnHeader();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.lblBarCode = new System.Windows.Forms.Label();
            this.txtOperator = new System.Windows.Forms.TextBox();
            this.lblOperator = new System.Windows.Forms.Label();
            this.txtHcmWorker = new System.Windows.Forms.TextBox();
            this.lblHcmWorker = new System.Windows.Forms.Label();
            this.picBackup = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtScanBox);
            this.panel1.Controls.Add(this.lsvOperator);
            this.panel1.Controls.Add(this.txtBarCode);
            this.panel1.Controls.Add(this.lblBarCode);
            this.panel1.Controls.Add(this.txtOperator);
            this.panel1.Controls.Add(this.lblOperator);
            this.panel1.Controls.Add(this.txtHcmWorker);
            this.panel1.Controls.Add(this.lblHcmWorker);
            this.panel1.Controls.Add(this.picBackup);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 290);
            // 
            // txtScanBox
            // 
            this.txtScanBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtScanBox.Location = new System.Drawing.Point(50, 5);
            this.txtScanBox.Name = "txtScanBox";
            this.txtScanBox.Size = new System.Drawing.Size(180, 26);
            this.txtScanBox.TabIndex = 12;
            this.txtScanBox.Text = "08002";
            this.txtScanBox.GotFocus += new System.EventHandler(this.txtScanBox_GotFocus);
            this.txtScanBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtScanBox_KeyPress);
            // 
            // lsvOperator
            // 
            this.lsvOperator.Columns.Add(this.colOpr);
            this.lsvOperator.Columns.Add(this.colWorker);
            this.lsvOperator.Columns.Add(this.colBarcode);
            this.lsvOperator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lsvOperator.FullRowSelect = true;
            listViewItem2.Text = "";
            listViewItem2.SubItems.Add("修毛");
            listViewItem2.SubItems.Add("1900001-0063755-047");
            this.lsvOperator.Items.Add(listViewItem2);
            this.lsvOperator.Location = new System.Drawing.Point(0, 93);
            this.lsvOperator.Name = "lsvOperator";
            this.lsvOperator.Size = new System.Drawing.Size(235, 197);
            this.lsvOperator.TabIndex = 7;
            this.lsvOperator.View = System.Windows.Forms.View.Details;
            this.lsvOperator.ItemActivate += new System.EventHandler(this.lsvOperator_ItemActivate);
            this.lsvOperator.SelectedIndexChanged += new System.EventHandler(this.lsvOperator_SelectedIndexChanged);
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
            // txtBarCode
            // 
            this.txtBarCode.Enabled = false;
            this.txtBarCode.Location = new System.Drawing.Point(88, 66);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(142, 21);
            this.txtBarCode.TabIndex = 3;
            this.txtBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarCode_KeyPress);
            // 
            // lblBarCode
            // 
            this.lblBarCode.Location = new System.Drawing.Point(5, 68);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(99, 20);
            this.lblBarCode.Text = "指令条码：";
            // 
            // txtOperator
            // 
            this.txtOperator.Enabled = false;
            this.txtOperator.Location = new System.Drawing.Point(50, 37);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(75, 21);
            this.txtOperator.TabIndex = 1;
            this.txtOperator.Text = "修毛";
            this.txtOperator.GotFocus += new System.EventHandler(this.txtOperator_GotFocus);
            this.txtOperator.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOperator_KeyPress);
            // 
            // lblOperator
            // 
            this.lblOperator.Location = new System.Drawing.Point(5, 40);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(51, 20);
            this.lblOperator.Text = "工序：";
            // 
            // txtHcmWorker
            // 
            this.txtHcmWorker.Enabled = false;
            this.txtHcmWorker.Location = new System.Drawing.Point(179, 37);
            this.txtHcmWorker.Name = "txtHcmWorker";
            this.txtHcmWorker.Size = new System.Drawing.Size(51, 21);
            this.txtHcmWorker.TabIndex = 2;
            this.txtHcmWorker.Text = "000038";
            this.txtHcmWorker.GotFocus += new System.EventHandler(this.txtHcmWorker_GotFocus);
            this.txtHcmWorker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHcmWorker_KeyPress);
            // 
            // lblHcmWorker
            // 
            this.lblHcmWorker.Location = new System.Drawing.Point(131, 40);
            this.lblHcmWorker.Name = "lblHcmWorker";
            this.lblHcmWorker.Size = new System.Drawing.Size(60, 20);
            this.lblHcmWorker.Text = "员工：";
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
            // frmReport
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
            this.Name = "frmReport";
            this.Text = "报工扫描";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lsvOperator;
        private System.Windows.Forms.ColumnHeader colOpr;
        private System.Windows.Forms.ColumnHeader colWorker;
        private System.Windows.Forms.ColumnHeader colBarcode;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Label lblBarCode;
        private System.Windows.Forms.TextBox txtOperator;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.TextBox txtHcmWorker;
        private System.Windows.Forms.Label lblHcmWorker;
        private System.Windows.Forms.PictureBox picBackup;
        private System.Windows.Forms.TextBox txtScanBox;
    }
}