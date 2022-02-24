using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShoesPDA2
{
    public partial class frmConfigServer : Form
    {
        Parameters parameters;
        ReportDBLocalDataSet.ParametersDataTable parametersTable;


        public frmConfigServer()
        {
            InitializeComponent();
        }

        private void picBackup_Click(object sender, EventArgs e)
        {
            parametersTable = parameters.find();
            parameters.updateServer(cboServers.SelectedIndex);
             
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmConfigServer_Load(object sender, EventArgs e)
        {
            parameters = new Parameters();
            ReportDBLocalDataSet.ParametersRow row;

            parametersTable = parameters.find();
            row = parametersTable.Rows[0] as ReportDBLocalDataSet.ParametersRow;

            cboServers.SelectedIndex = row.DefServer;

        }
    }
}