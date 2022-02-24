using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShoesPDA2
{
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void picBackup_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void picUpload_Click(object sender, EventArgs e)
        {
            var frmConfigRoutes = new frmDownloadRoutes();
            frmConfigRoutes.ShowDialog();
        }

        private void picHcmWorker_Click(object sender, EventArgs e)
        {
            var frmConfigUser = new frmConfigUser();
            frmConfigUser.ShowDialog();
        }

        private void picServer_Click(object sender, EventArgs e)
        {
            var frmConfigServer = new frmConfigServer();
            frmConfigServer.ShowDialog();
        }

        private void picHistory_Click(object sender, EventArgs e)
        {
            var frmConfigCleanHistory = new frmConfigCleanHistory();
            frmConfigCleanHistory.ShowDialog();
        }
    }
}