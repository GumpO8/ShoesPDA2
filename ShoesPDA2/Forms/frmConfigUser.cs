using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShoesPDA2
{
    public partial class frmConfigUser : Form
    {
        Parameters parameters;
        ReportDBLocalDataSet.ParametersDataTable parametersTable;
        
        
        public frmConfigUser()
        {
            InitializeComponent();
        }

        private void picBackup_Click(object sender, EventArgs e)
        {
            parametersTable = parameters.find();
            parameters.update(txtDefHcmWorkerId.Text,txtDefOperatorId.Text,0,txtDeviceId.Text,txtDeviceDescription.Text,txtDefUserId.Text);
             
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// 文本框获得焦点后全选文本内容
        /// </summary>
        /// <param name="sender"></param>
        private void txtSelectAll(object sender)
        {
            TextBox tb = sender as TextBox;
            Timer timer = new Timer();

            timer.Interval = 100;
            timer.Enabled = true;
            timer.Tick += (EventHandler)delegate(object obj, EventArgs args)
            {
                tb.SelectAll();
                timer.Dispose();
            };
        }

        private void frmConfigUser_Load(object sender, EventArgs e)
        {
            parameters = new Parameters();
            ReportDBLocalDataSet.ParametersRow row;


            parametersTable = parameters.find();
            row = parametersTable.Rows[0] as ReportDBLocalDataSet.ParametersRow;
            txtDeviceId.Text = row.DeviceId;
            txtDeviceDescription.Text = row.DeviceId;
            txtDefUserId.Text = row.DefUserId;
            txtDefHcmWorkerId.Text = row.DefHcmWorkerId;
            txtDefOperatorId.Text = row.DefOperatorId;

        }
    }
}