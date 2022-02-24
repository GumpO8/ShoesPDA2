using System;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;

namespace ShoesPDA2
{
    public partial class frmUpload : Form
    {
        OprReports oprReports;
        ReportDBLocalDataSet.OprReportsDataTable oprReportsTable;

        Parameters parameters;
        ReportDBLocalDataSet.ParametersDataTable parametersTable;
        
        public delegate void OnClose();
        public delegate void OnCloseWithParam(bool enable); 
        private System.Windows.Forms.Timer TimerProgress;
        public Thread thread;

        public frmUpload()
        {
            InitializeComponent();
            TimerProgress = new System.Windows.Forms.Timer();
        }
        
        //创建一个委托，是为访问TextBox控件服务的。
        public void uploadDatas()
        {
            bool ret = false;
            string temp;
            string operatorId = string.Empty;
            string hcmWorkerId = string.Empty;
            string barCode  = string.Empty;
            string createdDatetime = string.Empty;

            List<string> list = new List<string>();
            
            C3DBWebServices.Routes uploadReports = new ShoesPDA2.C3DBWebServices.Routes();

            try
            {
                parameters = new Parameters();
                parametersTable = parameters.find();

                if (parameters.DefUserId == string.Empty)
                {
                    throw new ArgumentOutOfRangeException();
                }

                foreach (ListViewItem item in lsvOperator.Items)
                {
                    operatorId = item.SubItems[1].Text;
                    hcmWorkerId = item.SubItems[2].Text;
                    barCode = item.SubItems[3].Text;
                    createdDatetime = item.SubItems[4].Text;

                    //List数据结构：7(0单据代码),13(1部件日报类型),100448(2创单人),2020-01-19(3报工时间),08001(4工序编号),07100448(5报工人员编号),125487896-121131221132(6条码)
                    //list.Add("7,13,00037,2020-01-19,08001,07001750,LF20002408414-0087"); 
                    //temp = "7,13," + hcmWorkerId + "," + DateTime.Now.ToShortDateString().ToString() + "," + operatorId + "," + hcmWorkerId + "," + barCode;
                    temp = "7,13," + parameters.DefUserId + "," + createdDatetime + "," + operatorId + ",07" + hcmWorkerId + "," + barCode;

                    list.Add(temp);

                }
                
                ret = uploadReports.UploadReportsTrans(list.ToArray(), parameters.DefServer);

                if (ret)
                {
                    oprReports.updateStatus("", "已上传");
                    this.BeginInvoke(new OnCloseWithParam(this.fullOperatorList), false);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("尚未设置默认用户!");

            }            
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            finally
            {
                TimerProgress.Enabled = false;
                if (TimerProgress != null)
                {
                    TimerProgress.Dispose();
                }
                this.BeginInvoke(new OnCloseWithParam(this.setProgressBarVisible), false);

                if (ret)
                {
                    MessageBox.Show("已上传C3成功: " + lsvOperator.Items.Count.ToString() + "条数据");
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
            labRecordCount.Text = "待上传:";

            oprReportsTable = oprReports.getDataUnUpload();
            
            
            if (oprReportsTable != null && oprReportsTable.Count > 0)
            {
                labRecordCount.Text += oprReportsTable.Count;

                lsvOperator.BeginUpdate();
                for (var i = 0; i < oprReportsTable.Count; i++)
                {
                    row = oprReportsTable.Rows[i] as ReportDBLocalDataSet.OprReportsRow;
                    lvItem = new ListViewItem(row.Id.ToString());
                    lvItem.SubItems.Add(row.OperatorId);
                    lvItem.SubItems.Add(row.HcmWorkerId);
                    lvItem.SubItems.Add(row.C3BarCode);
                    lvItem.SubItems.Add(row.CreatedDatetime.ToString("yyyy-MM-dd"));
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

        private void exportTXT()
        {
            StreamWriter streamWriter = null;
            string temp;
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\" +
                            DateTime.Now.ToShortDateString() + ".txt";      //保存文件的路径            
            string operatorId = string.Empty;
            string hcmWorkerId = string.Empty;

            try
            {
                if (File.Exists(path))//如果文件已创建
                {
                    streamWriter = File.AppendText(path);
                }
                else
                {
                    streamWriter = new StreamWriter(path);//如果没有创建
                    //streamWriter.WriteLine("新建数据,789," + DateTime.Now.ToShortDateString());
                }

                foreach (ListViewItem item in lsvOperator.Items)
                {
                    if (operatorId != item.SubItems[1].Text || hcmWorkerId != item.SubItems[2].Text)
                    {
                        temp = item.SubItems[1].Text + "\r\n" + item.SubItems[2].Text + "\r\n" + item.SubItems[3].Text;
                    }
                    else
                    {
                        temp = item.SubItems[3].Text;
                    }

                    streamWriter.WriteLine(temp);

                    operatorId = item.SubItems[1].Text;
                    hcmWorkerId = item.SubItems[2].Text;
                }

                oprReports.updateStatus("", "已导出");
                MessageBox.Show("文件导出成功:" + path);

            }
            catch (Exception ex)//异常处理
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //清空缓冲区         
                streamWriter.Flush();
                //关闭流             
                streamWriter.Close();
            }
        }

        private void picBackup_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmUpload_Load(object sender, EventArgs e)
        {
            lsvOperator.Items.Clear(); 
            oprReports = new OprReports();
            TimerProgress.Interval = 1000;
            TimerProgress.Tick += new EventHandler(timer_Tick);
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

        private void picExportTXT_Click(object sender, EventArgs e)
        {
            if (lsvOperator.Items.Count == 0)
            {
                MessageBox.Show("无未上传数据!");
            }
            else
            {
                exportTXT();
                fullOperatorList(false);
            }
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

        private void lsvOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bool ret;
            //int index = 0;
            //if (lsvOperator.SelectedIndices.Count > 0)
            //{
            //    index = lsvOperator.SelectedIndices[0];
            //    MessageBox.Show(index.ToString());

            //    if (MessageBox.Show("删除选中订单报工数据?", "删除订单数据", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            //    {
            //        ret = oprReports.delete(lsvOperator.Items[index].SubItems[1].Text,
            //                    lsvOperator.Items[index].SubItems[2].Text,
            //                    lsvOperator.Items[index].SubItems[3].Text);

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
                    ret = oprReports.delete(lsvOperator.Items[index].SubItems[1].Text,
                                lsvOperator.Items[index].SubItems[2].Text,
                                lsvOperator.Items[index].SubItems[3].Text);

                    if (ret)
                    {
                        lsvOperator.Items.RemoveAt(index);
                        //MessageBox.Show("删除成功！");
                    }
                }
            }
        }

        private void picUpload_Click(object sender, EventArgs e)
        {
            if (lsvOperator.Items.Count == 0)
            {
                MessageBox.Show("无未上传数据!");
            }
            else
            {
                TimerProgress.Enabled = true;
                progressBar.Visible = true;

                thread = new Thread(new ThreadStart(this.uploadDatas));
                thread.IsBackground = true;
                thread.Start();                 
                //fullOperatorList();
            }
        }
    }
}