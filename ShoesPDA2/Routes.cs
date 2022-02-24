using System;

using System.Collections.Generic;
using System.Text;
using ShoesPDA2.ReportDBLocalDataSetTableAdapters;
using ShoesPDA2.C3DBWebServices;
using System.Data;
using System.Windows.Forms;

namespace ShoesPDA2
{
    class Routes : Common
    {
        RoutesTableAdapter _RoutesRecord;

        string _DeptmentId;

        public string DeptmentId
        {
            get { return _DeptmentId; }
            set { _DeptmentId = value; }
        }
        string _DeptmentName;

        public string DeptmentName
        {
            get { return _DeptmentName; }
            set { _DeptmentName = value; }
        }

        string _RouteId;

        public string RouteId
        {
            get { return _RouteId; }
            set { _RouteId = value; }
        }

        string _RouteName;

        public string RouteName
        {
            get { return _RouteName; }
            set { _RouteName = value; }
        }

        bool _Duplicate;

        public bool Duplicate
        {
            get { return _Duplicate; }
            set { _Duplicate = value; }
        }

        string _errorInfo;

        public string ErrorInfo
        {
            get { return _errorInfo; }
            set { _errorInfo = value; }
        }

        // <summary>
        /// 构造函数
        /// </summary>
        public Routes()
        {
            _RoutesRecord = new RoutesTableAdapter();
        }

        public ReportDBLocalDataSet.RoutesDataTable getData()
        {
            return _RoutesRecord.GetData();
        }

        public void clear()
        {
            _DeptmentId = "";
            _DeptmentName = "";
            _RouteId = "";
            _RouteName = "";            
        }

        public void initValue()
        {
            _Duplicate = false;
        }

        public ReportDBLocalDataSet.RoutesDataTable find(string _RouteId)
        {
            return _RoutesRecord.GetDataByRouteId(_RouteId);
        }

        public bool exist(string _RouteId)
        {
            bool ret = false;

            ret = find(_RouteId).Count > 0;

            return ret;
        }

        public bool validateWrite()
        {
            bool _ret = true;

            if (string.IsNullOrEmpty(_RouteId))
            {
                _errorInfo = "必须填写 工序编号";
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
                    _RoutesRecord.Insert(string.IsNullOrEmpty(_DeptmentId) ? string.Empty : _DeptmentId,
                        string.IsNullOrEmpty(_DeptmentName) ? string.Empty : _DeptmentName,
                        string.IsNullOrEmpty(_RouteId) ? string.Empty : _RouteId,
                        string.IsNullOrEmpty(_RouteName) ? string.Empty : _RouteName,
                        _Duplicate);

                    _ret = true;
                }
                catch (Exception ex)
                {
                    _errorInfo = ex.InnerException.Message.ToString();
                }
            }

            return _ret;
        }

        public bool update()
        {
            bool _ret = false;
            
            try
            {
                _RoutesRecord.UpdateByRouteId(string.IsNullOrEmpty(_DeptmentId) ? string.Empty : _DeptmentId,
                    string.IsNullOrEmpty(_DeptmentName) ? string.Empty : _DeptmentName,
                    string.IsNullOrEmpty(_RouteName) ? string.Empty : _RouteName,                    
                    string.IsNullOrEmpty(_RouteId) ? string.Empty : _RouteId);

                _ret = true;
            }
            catch (Exception ex)
            {
                _errorInfo = ex.InnerException.Message.ToString();
            }
            

            return _ret;
        }

        public bool updateDuplicate()
        {
            bool _ret = false;

            try
            {
                _RoutesRecord.updateDuplicateByRouteId(_Duplicate,_RouteId);

                _ret = true;
            }
            catch (Exception ex)
            {
                _errorInfo = ex.InnerException.Message.ToString();
            }


            return _ret;
        }

        /// <summary>
        /// 从WebServices下载工序数据
        /// WebServices地址: http://ares15:8070/Routes.asmx?op=RoutesList
        /// </summary>
        /// <param name="consumption"></param>
        /// <returns></returns>
        public bool DownloadRoutes(C3DBWebServices.Routes consumption)
        {
            bool returnStatus = false;
            int rowCount;
            
            try
            {
                DataSet RoutesDS = consumption.RoutesList();                
                
                rowCount = RoutesDS.Tables[0].Rows.Count;
            
                for (int i = 0; i < rowCount; i++)
                {
                    this.clear();
                    this.initValue();
                    this.DeptmentId = RoutesDS.Tables[0].Rows[i][0].ToString();
                    this.DeptmentName = RoutesDS.Tables[0].Rows[i][1].ToString();
                    this.RouteId = RoutesDS.Tables[0].Rows[i][2].ToString();
                    this.RouteName = RoutesDS.Tables[0].Rows[i][3].ToString();                    
                                        
                    if (this.exist(RouteId))
                    {
                        _RoutesRecord.UpdateByRouteId(DeptmentId, DeptmentName, RouteName, RouteId);
                    }
                    else
                    {
                        _RoutesRecord.Insert(DeptmentId, DeptmentName, RouteId, RouteName, Duplicate);
                    }
                }
                returnStatus = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException == null ? ex.Message : ex.InnerException.Message.ToString());
            }
            
            return returnStatus;
        }
    }
}
