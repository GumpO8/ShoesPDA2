using System;

using System.Collections.Generic;
using System.Text;
using ShoesPDA2.ReportDBLocalDataSetTableAdapters;
using System.Windows.Forms;

namespace ShoesPDA2
{
    class OprReports : Common
    {
        OprReportsTableAdapter _OprReportsRecord; 
        Int64 _Id;
        string _HcmWorkerId;
        string _OperatorId;
        string _BarCode;
        string _Status;
        string _CreatedByDeviceId;
        DateTime _CreatedDatetime;

        public DateTime CreatedDatetime
        {
            get { return _CreatedDatetime; }
            set { _CreatedDatetime = value; }
        }

        public string CreatedByDeviceId
        {
            get { return _CreatedByDeviceId; }
            set { _CreatedByDeviceId = value; }
        }

        string _errorInfo;
        
        // <summary>
        /// 构造函数
        /// </summary>
        public OprReports()
        {
            _OprReportsRecord = new OprReportsTableAdapter();
        }

        public ReportDBLocalDataSet.OprReportsDataTable getData()
        {
            return _OprReportsRecord.GetData();
        }

        public ReportDBLocalDataSet.OprReportsDataTable findByWorkerOprBarcode(string _hcmWorkerId, string _operatorId, string _barCode)
        {
            return _OprReportsRecord.findByWorkerOprBarcode(_hcmWorkerId, _operatorId, _barCode);
        }

        public ReportDBLocalDataSet.OprReportsDataTable findByOprBarcode(string _operatorId, string _barCode)
        {
            return _OprReportsRecord.findByOprBarcode(_operatorId, _barCode);
        }


        public ReportDBLocalDataSet.OprReportsDataTable getDataUnUpload()
        {
            return _OprReportsRecord.GetDataStatus("","","");
        }

        public ReportDBLocalDataSet.OprReportsDataTable getDataUploaded()
        {
            return _OprReportsRecord.GetDataStatus("已上传","已导出","预留");            
        }

        public bool updateStatus(string fromStatus, string toStatus)
        {
            bool ret = false;

            try
            {
                _OprReportsRecord.UpdateStatus(toStatus,fromStatus);
                ret = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException == null ? ex.Message : ex.InnerException.Message.ToString());
            }
            return ret;
        }

        public bool delete(string operatorId, string hcmWorkerId, string barCode)
        {
            bool ret = false;

            try
            {
                _OprReportsRecord.DeleteByHcmWorkerIdOperatorIdBarCode(hcmWorkerId, operatorId, barCode);
                ret = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException == null ? ex.Message : ex.InnerException.Message.ToString());
            }
            return ret;
        }

        public bool deleteUploaded(DateTime beginDatetime, DateTime endDatetime)
        {
            bool ret = false;

            try
            {
                _OprReportsRecord.DeleteUploaded(beginDatetime, endDatetime);
                ret = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException == null ? ex.Message : ex.InnerException.Message.ToString());
            }
            return ret;
        }

        public long Id
        {
            get { return _Id; }
        }
        
        public string HcmWorkerId
        {
            get { return _HcmWorkerId; }
            set { _HcmWorkerId = value; }
        }

        public string OperatorId
        {
            get { return _OperatorId; }
            set { _OperatorId = value; }
        }

        public string BarCode
        {
            get { return _BarCode; }
            set { _BarCode = value; }
        }

        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        public string ErrorInfo
        {
            get { return _errorInfo; }
            set { _errorInfo = value; }
        }   

        public void clear()
        {
            _HcmWorkerId = "";
            _OperatorId = "";
            _BarCode = "";
        }

        public void initValue()
        {
            _Status = "";
        }

        public bool validateWrite()
        {
            bool _ret = true;

            if (string.IsNullOrEmpty(_HcmWorkerId))
            {
                _errorInfo = "必须填写 员工工号";
                _ret = false;
            }

            if (string.IsNullOrEmpty(_OperatorId))
            {
                _errorInfo = "必须填写 工序";
                _ret = false;
            }

            if (string.IsNullOrEmpty(_BarCode))
            {
                _errorInfo = "必须填写 指令条码";
                _ret = false;
            }

            return _ret;
        }

        public bool insert()
        {
            bool _ret = false;

            if (validateWrite())
            {
                try
                {
                    _OprReportsRecord.Insert(string.IsNullOrEmpty(_HcmWorkerId) ? string.Empty : _HcmWorkerId,
                        string.IsNullOrEmpty(_OperatorId) ? string.Empty : _OperatorId,
                        string.IsNullOrEmpty(_BarCode) ? string.Empty : _BarCode,
                        string.IsNullOrEmpty(_Status) ? string.Empty : _Status,
                        string.IsNullOrEmpty(_CreatedByDeviceId) ? string.Empty : _CreatedByDeviceId,
                        DateTime.Now);

                    _ret = true;
                }
                catch (Exception ex)
                {
                    _errorInfo = ex.InnerException.Message.ToString();
                }
            }
            
            return _ret;
        }

        public bool exist(string _hcmWorkerId,string _operatorId,string _barCode)
        {
            bool ret = false;

            if (string.IsNullOrEmpty(_hcmWorkerId))
            {
                ret = findByOprBarcode(_operatorId, _barCode).Count > 0;
            }
            else
            {
                ret = findByWorkerOprBarcode(_hcmWorkerId, _operatorId, _barCode).Count > 0;
            }

            return ret;
        }
    }
}
