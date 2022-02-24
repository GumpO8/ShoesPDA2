using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShoesPDA2
{
    public partial class frmConfigCheckPassword : Form
    {
        public frmConfigCheckPassword()
        {
            InitializeComponent();
        }

        private void picBackup_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void picLogoon_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "seuic" || txtPassword.Text == "8511111")
            {
                this.DialogResult = DialogResult.OK;

                var frmConfig = new frmConfig();
                frmConfig.ShowDialog();
            }
            else
            {
                MessageBox.Show("密码错误！");
            }
        }

        private void frmConfigCheckPassword_Load(object sender, EventArgs e)
        {
            txtPassword.Focus();
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

        private void txtPassword_GotFocus(object sender, EventArgs e)
        {
            this.txtSelectAll(sender);
        }
    }
}