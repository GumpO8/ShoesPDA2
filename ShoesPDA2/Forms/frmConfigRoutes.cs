using System;
using System.Windows.Forms;
using System.Threading;

namespace ShoesPDA2
{
    public partial class frmDownloadRoutes : Form
    {
        Routes routes;
        ReportDBLocalDataSet.RoutesDataTable routesTable;

        public delegate void OnClose();
        public delegate void OnCloseWithParam(bool enable);
        private System.Windows.Forms.Timer TimerProgress;
        public Thread thread;

        //创建一个委托，是为访问TextBox控件服务的。
        public void downloadRoutes()
        {
            bool ret;

            C3DBWebServices.Routes consumption = new ShoesPDA2.C3DBWebServices.Routes();
            ret = routes.DownloadRoutes(consumption);
            
            if (ret)
            {
                //fullOperatorList();
                this.BeginInvoke(new OnClose(this.fullOperatorList));
            }            

            TimerProgress.Enabled = false;
            if (TimerProgress != null)
            {
                TimerProgress.Dispose();
            }
            this.BeginInvoke(new OnCloseWithParam(this.setProgressBarVisible), false);
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
        
        public frmDownloadRoutes()
        {
            InitializeComponent();
            TimerProgress = new System.Windows.Forms.Timer();
        }
                
        private void fullOperatorList()
        {
            ReportDBLocalDataSet.RoutesRow row;
            ListViewItem lvItem;

            lsvRoutes.Items.Clear();
            
            routesTable = routes.getData();

            if (routesTable != null && routesTable.Count > 0)
            {
                lsvRoutes.BeginUpdate();

                for (var i = 0; i < routesTable.Count; i++)
                {
                    row = routesTable.Rows[i] as ReportDBLocalDataSet.RoutesRow;
                    lvItem = new ListViewItem(row.rept_no);
                    lvItem.SubItems.Add(row.rept_nam);
                    bool allowDup = row.duplicate;
                    lvItem.SubItems.Add(allowDup ? "T" : "F");
                    lsvRoutes.Items.Add(lvItem);                    
                }

                lsvRoutes.EndUpdate();
            }
        }

        private void picBackup_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmConfigRoutes_Load(object sender, EventArgs e)
        {
            routes = new Routes();
            TimerProgress.Interval = 1000;
            TimerProgress.Tick += new EventHandler(timer_Tick);
        }

        private void frmConfigRoutes_Activated(object sender, EventArgs e)
        {
            fullOperatorList();
        }

        private void picDownload_Click(object sender, EventArgs e)
        {
            TimerProgress.Enabled = true;
            progressBar.Visible = true;

            thread = new Thread(new ThreadStart(this.downloadRoutes));
            thread.IsBackground = true;
            thread.Start();                         
        }
    }
}