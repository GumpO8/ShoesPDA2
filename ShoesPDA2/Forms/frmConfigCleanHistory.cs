using System;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;

namespace ShoesPDA2
{
    public partial class frmConfigCleanHistory : Form
    {
        OprReports oprReports;
        ReportDBLocalDataSet.OprReportsDataTable oprReportsTable;

        public delegate void OnClose();
        public delegate void OnCloseWithParam(bool enable); 
        private System.Windows.Forms.Timer TimerProgress;
        public Thread thread;

        public frmConfigCleanHistory()
        {
            InitializeComponent();
            TimerProgress = new System.Windows.Forms.Timer();
        }
        
        //创建一个委托，是为访问TextBox控件服务的。
        public void deletedDatas()
        {
            bool ret = false;            
            
            DateTime beginDate = DateTime.MinValue;
            DateTime endDate = DateTime.MinValue;

            if (rdoAll.Checked)
            {
                beginDate = DateTime.MinValue;
                endDate = DateTime.MaxValue;
            }
            else if (rdoThreeMonth.Checked)
            {
                beginDate = DateTime.Now.AddMonths(-3);
                endDate = DateTime.Now;
            }
            else if (rdoCurMonth.Checked)
            {
                beginDate = DateTime.Now.AddDays(1 - DateTime.Now.Day);
                endDate = DateTime.Now;
            }

            try
            {
                ret = oprReports.deleteUploaded(beginDate, endDate); 
                
                if (ret)
                {                
                    this.fullOperatorList();
                }
            }            
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            finally
            {
                if (ret)
                {
                    MessageBox.Show("记录清除成功。");
                }
            }            
        }

        //创建一个委托，是为访问TextBox控件服务的。
        private void setProgressBarVisible(bool enable)
        {
            progressBar.Visible = enable;
        }

        //创建一个委托，是为访问TextBox控件服务的。
        private void timer_Tick(object sender, EventArgs e)
        {
            this.BeginInvoke(new OnClose(this.ProgressBarIncrease));
        }

        //创建一个委托，是为访问TextBox控件服务的。
        private void ProgressBarIncrease()
        {
            if (progressBar.Value >= 100)
            {
                progressBar.Value = 0;
            }

            progressBar.Value += 2;
        }

        private void fullOperatorList()
        {
            this.BeginInvoke(new OnCloseWithParam(this.fullOperatorList), true); 
        }

        private void fullOperatorList(bool independent)
        {
            ReportDBLocalDataSet.OprReportsRow row;
            ListViewItem lvItem;

            lsvOperator.Items.Clear();
            labRecordCount.Text = "合计:";

            oprReportsTable = oprReports.getDataUploaded();
            
            
            if (oprReportsTable != null && oprReportsTable.Count > 0)
            {
                labRecordCount.Text += oprReportsTable.Count;

                lsvOperator.BeginUpdate();
                for (var i = 0; i < oprReportsTable.Count; i++)
                {
                    row = oprReportsTable.Rows[i] as ReportDBLocalDataSet.OprReportsRow;
                    lvItem = new ListViewItem(row.Id.ToString());
                    lvItem.SubItems.Add(row.CreatedDatetime.ToString("yyyy-MM-dd"));
                    lvItem.SubItems.Add(row.Status); 
                    lvItem.SubItems.Add(row.OperatorId);
                    lvItem.SubItems.Add(row.HcmWorkerId);
                    lvItem.SubItems.Add(row.C3BarCode);                    
                    lsvOperator.Items.Add(lvItem);                    
                }
                lsvOperator.EndUpdate();
            }

            if (independent)
            {
                TimerProgress.Enabled = false;
                if (TimerProgress != null)
                {
                    TimerProgress.Dispose();
                }

                this.BeginInvoke(new OnCloseWithParam(this.setProgressBarVisible), false);
            }
            
        }

        private void picBackup_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmUpload_Load(object sender, EventArgs e)
        {
            oprReports = new OprReports();
            //TimerProgress.Interval = 1000;
            //TimerProgress.Tick += new EventHandler(timer_Tick);
            lsvOperator.Items.Clear();
            picReflash_Click(sender, e);
        }

        private void picReflash_Click(object sender, EventArgs e)
        {
            TimerProgress.Enabled = true;
            progressBar.Visible = true;

            thread = new Thread(new ThreadStart(this.fullOperatorList));
            ////////thread = new Thread(new ParameterizedThreadStart(this.fullOperatorList));
            thread.IsBackground = true;
            thread.Start();
            //this.BeginInvoke(new OnCloseWithParam(this.fullOperatorList), true);
            //fullOperatorList(false);

        }

        private void frmUpload_Activated(object sender, EventArgs e)
        {
            TimerProgress.Enabled = true;
            progressBar.Visible = true;

            //Thread.Sleep(5000); //停一秒
            thread = new Thread(new ThreadStart(this.fullOperatorList));
            //thread = new Thread(new ParameterizedThreadStart(this.fullOperatorList));
            thread.IsBackground = true;
            thread.Start();            
            //fullOperatorList(false);
        }

        private void picUpload_Click(object sender, EventArgs e)
        {
            if (lsvOperator.Items.Count > 0)
            {
                this.deletedDatas();                
            }
        }
    }
}