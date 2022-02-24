using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShoesPDA2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //private void btnOK_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("用户名或者密码不能为空", "登录提示");
        //}

        //private void btnCancle_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.lbEdition.Text = string.Format("Ver: {0}", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
        }

        private void picExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picReport_Click(object sender, EventArgs e)
        {
            var frmReport = new frmReport();

            frmReport.ShowDialog();
        }

        private void picUpload_Click(object sender, EventArgs e)
        {
            var frmUpload = new frmUpload();

            frmUpload.ShowDialog();
        }

        private void picConfig_Click(object sender, EventArgs e)
        {
            var frmConfigCheckPassword = new frmConfigCheckPassword();

            frmConfigCheckPassword.ShowDialog();
        }

        private void picDownload_Click(object sender, EventArgs e)
        {
            var frmConfig = new frmConfig();
            
            frmConfig.picHcmWorker.Visible = false;
            frmConfig.lblHcmWorker.Visible = false;
            frmConfig.lblHcmWorkerDesc.Visible = false;
            frmConfig.panelLine2.Visible = false;

            frmConfig.picServer.Visible = false;
            frmConfig.lblServer.Visible = false;
            frmConfig.lblServerDesc.Visible = false;
            frmConfig.panelLine3.Visible = false;

            frmConfig.picHistory.Visible = false;
            frmConfig.lblHistory.Visible = false;
            frmConfig.lblHistoryDesc.Visible = false;
            frmConfig.panelLine4.Visible = false;

            frmConfig.ShowDialog();
        }
    }
}