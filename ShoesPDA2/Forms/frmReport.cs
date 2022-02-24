using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ShoesPDA2.ReportDBLocalDataSetTableAdapters;

namespace ShoesPDA2
{
    public partial class frmReport : Form
    {
        /// <summary>
        /// 设置 员工 字段智能填充
        /// Opt1: 时间段内最常用员工,最常用工序
        /// </summary>

        OprReports oprReports;

        public frmReport()
        {
            InitializeComponent();
        }
                
        private string initDefHcmWorker()
        {
            string defHcmWorker = "";
            return defHcmWorker;
        }

        /// <summary>
        /// 设置 工序 字段智能填充
        /// Opt1: 时间段内最常用员工,最常用工序
        /// </summary>
        private string initDefOpr()
        {
            //TODO::工序智能填充
            string defOpr = "";
            return defOpr;
        }

        /// <summary>
        /// 设置文本框获焦点,以 员工 工序 指令条码为顺序,优先设置为空的文本框获得焦点
        /// </summary>
        /// <param name="sender"></param>
        private void setTxtControlFocus()
        {
            if (string.IsNullOrEmpty(txtOperator.Text))
            {
                txtOperator.Focus();
            }
            else if (string.IsNullOrEmpty(txtHcmWorker.Text))
            {
                txtHcmWorker.Focus();
            }
            else
            {
                txtBarCode.Text = "";
                txtBarCode.Focus();
            }
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
        
        private void picBackup_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            oprReports = new OprReports();
            txtHcmWorker.Text = initDefHcmWorker();
            txtHcmWorker.Tag = false;
            txtOperator.Text = initDefOpr();
            txtOperator.Tag = false;
            //this.setTxtControlFocus();
            lsvOperator.Items.Clear();

            txtScanBox.Text = string.Empty;
            txtScanBox.Focus();
        }

        private void txtBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //加入列表            
            if (e.KeyChar == (Char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtOperator.Text) || string.IsNullOrEmpty(txtHcmWorker.Text) ||
                    string.IsNullOrEmpty(txtBarCode.Text))
                {
                    MessageBox.Show("员工编号 工序 指令条码 均不能为空！");
                    this.setTxtControlFocus();
                }
                else
                {
                    var operatorId = txtOperator.Text.Trim();
                    var hcmWorker = txtHcmWorker.Text.Trim();
                    var barCode = this.txtBarCode.Text.Trim();

                    //TODO::重复控制支持参数化
                    if (oprReports.exist("", operatorId, barCode))
                    {
                        MessageBox.Show("已存在相同记录！");
                        this.setTxtControlFocus();
                    }
                    else
                    {
                        oprReports.clear();
                        oprReports.initValue();

                        oprReports.HcmWorkerId = hcmWorker;
                        oprReports.OperatorId = operatorId;
                        oprReports.BarCode = barCode;

                        if (oprReports.validateWrite())
                        {
                            oprReports.insert();
                        }

                        if (string.IsNullOrEmpty(oprReports.ErrorInfo))
                        {

                            lsvOperator.BeginUpdate();
                            var lvItem = new ListViewItem();
                            lvItem.Text = operatorId;
                            lvItem.SubItems.Add(hcmWorker);
                            lvItem.SubItems.Add(barCode);
                            lsvOperator.Items.Add(lvItem);
                            lsvOperator.EndUpdate();

                            txtBarCode.Text = string.Empty;
                            txtBarCode.Focus();
                        }
                        else
                        {
                            MessageBox.Show("数据插入失败:" + oprReports.ErrorInfo);
                        }
                    }
                }
            }
        }

        private void txtHcmWorker_KeyPress(object sender, KeyPressEventArgs e)
        {
            int iHcmWorker = 0;

            if (e.KeyChar == (Char)Keys.Enter)
            {
                iHcmWorker = txtHcmWorker.Text.Trim().Length;

                switch(iHcmWorker)
                { 
                    case 6:
                        this.setTxtControlFocus(); 
                        break;
                    case 8: //过滤前缀
                        txtHcmWorker.Text = txtHcmWorker.Text.Trim().Substring(2);
                        this.setTxtControlFocus(); 
                        break;
                    default:
                        MessageBox.Show("员工编号 不正确！");
                        txtHcmWorker.Focus();
                        break;
                }                
            }
        }

        private void txtOperator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                if (txtOperator.Text.Trim().Length != 5)
                {
                    MessageBox.Show("工序编号 不正确！");
                    txtOperator.Focus();
                }
                else
                {
                    this.setTxtControlFocus();
                }
            }
        }

        private void txtHcmWorker_GotFocus(object sender, EventArgs e)
        {
            this.txtSelectAll(sender);
        }

        private void txtOperator_GotFocus(object sender, EventArgs e)
        {
            this.txtSelectAll(sender);
        }

        private void lsvOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bool ret;
            //int index = 0;
            //if (lsvOperator.SelectedIndices.Count > 0)
            //{
            //    index = lsvOperator.SelectedIndices[0];

            //    if (MessageBox.Show("删除选中订单报工数据?", "删除订单数据", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            //    {
            //        ret = oprReports.delete(lsvOperator.Items[index].Text,
            //                    lsvOperator.Items[index].SubItems[1].Text,
            //                    lsvOperator.Items[index].SubItems[2].Text);

            //        if (ret)
            //        {
            //            lsvOperator.Items.RemoveAt(index);
            //            //MessageBox.Show("删除成功！");
            //        }
            //    }                
            //}
        }

        private void lsvOperator_ItemActivate(object sender, EventArgs e)
        {
            bool ret;
            int index = 0;
            if (lsvOperator.SelectedIndices.Count > 0)
            {
                index = lsvOperator.SelectedIndices[0];

                if (MessageBox.Show("删除选中订单报工数据?", "删除订单数据", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    ret = oprReports.delete(lsvOperator.Items[index].Text,
                                            lsvOperator.Items[index].SubItems[1].Text,
                                            lsvOperator.Items[index].SubItems[2].Text);

                    if (ret)
                    {
                        lsvOperator.Items.RemoveAt(index);
                        //MessageBox.Show("删除成功！");
                    }
                }
            }
        }

        private void txtScanBox_GotFocus(object sender, EventArgs e)
        {
            this.txtSelectAll(sender);
        }

        private void txtScanBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            string txtScanBoxPrefix;

            if (txtScanBox.Text.Length >= 2)
            {
                txtScanBoxPrefix = txtScanBox.Text.Substring(0, 2);

                switch (txtScanBoxPrefix)
                {
                    case "07":  //员工
                        txtHcmWorker.Text = txtScanBox.Text;
                        txtHcmWorker_KeyPress(sender, e);
                        break;

                    case "08":  //工序
                        txtOperator.Text = txtScanBox.Text;
                        txtOperator_KeyPress(sender, e);
                        break;

                    default:    //指令
                        txtBarCode.Text = txtScanBox.Text;
                        txtBarCode_KeyPress(sender, e);
                        break;
                }
            }

            txtScanBox.Text = string.Empty;
            txtScanBox_GotFocus(sender, e);
        }
    }
}