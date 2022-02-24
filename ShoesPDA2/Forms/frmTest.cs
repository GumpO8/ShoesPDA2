using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ShoesPDA2.Forms
{
    public partial class frmTest : Form, IDisposable
    {
        public delegate void OnClose();
        public delegate void OnCloseWithParam(bool enable);        
        private System.Windows.Forms.Timer TimerProgress;        
        private Routes routes;
        public Thread thread;

        public frmTest()
        {
            InitializeComponent();
            this.TimerProgress = new System.Windows.Forms.Timer();
        }

        public void downloadRoutes()
        {
            bool ret;
            
            C3DBWebServices.Routes consumption = new ShoesPDA2.C3DBWebServices.Routes();
            ret = routes.DownloadRoutes(consumption);

            TimerProgress.Enabled = false;
            if (TimerProgress != null)
            {
                TimerProgress.Dispose();
            }
            this.BeginInvoke(new OnCloseWithParam(this.ToggleStatus), false);             

        }

        private void ToggleStatus(bool enable)
        {            
            progressBar.Visible = enable;
            
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            routes = new Routes();
            TimerProgress.Interval = 1000;
            TimerProgress.Tick += new EventHandler(timer_Tick);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimerProgress.Enabled = true;
            progressBar.Visible = true;            

            thread = new Thread(new ThreadStart(this.downloadRoutes));
            thread.IsBackground = true;
            thread.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.BeginInvoke(new OnClose(this.ProgressBarIncrease));
        }

        private void ProgressBarIncrease()
        {
            if (progressBar.Value >= 100)
            {
                progressBar.Value = 0;
            }

            progressBar.Value += 10;
        }

        #region IDisposable 成员

        void IDisposable.Dispose()
        {
            if (TimerProgress != null)
            {
                TimerProgress.Dispose();
            }            

            if (thread != null)
            {
                thread.Abort();
            } 
            
            throw new NotImplementedException();
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}