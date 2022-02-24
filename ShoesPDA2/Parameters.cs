using System;

using System.Collections.Generic;
using System.Text;
using ShoesPDA2.ReportDBLocalDataSetTableAdapters;

namespace ShoesPDA2
{
    class Parameters : Common
    {
        ParametersTableAdapter _ParametersRecord;
        Int64 _Id;
        string _DefHcmWorkerId;
        string _DefOperatorId;
        string _DeviceId;
        string _DefUserId;
        Int32 _DefServer;


        public Int32 DefServer
        {
            get { return _DefServer; }
            set { _DefServer = value; }
        }

        public string DefUserId
        {
            get { return _DefUserId; }
            set { _DefUserId = value; }
        }

        public string DeviceId
        {
            get { return _DeviceId; }
            set { _DeviceId = value; }
        }
        string _DeviceDescription;

        public string DeviceDescription
        {
            get { return _DeviceDescription; }
            set { _DeviceDescription = value; }
        }

        public Int64 Id
        {
            get { return _Id; }
        }
        

        public string DefHcmWorkerId
        {
            get { return _DefHcmWorkerId; }
            set { _DefHcmWorkerId = value; }
        }        

        public string DefOperatorId
        {
            get { return _DefOperatorId; }
            set { _DefOperatorId = value; }
        }

        string _errorInfo;

        // <summary>
        /// 构造函数
        /// </summary>
        public Parameters()
        {
            _ParametersRecord = new ParametersTableAdapter();
        }

        public ReportDBLocalDataSet.ParametersDataTable find()
        {
            ReportDBLocalDataSet.ParametersDataTable table  = _ParametersRecord.GetData();
            ReportDBLocalDataSet.ParametersRow row;

            if (table.Count <= 0)
            {
                _ParametersRecord.Insert("", "", 0, "", "", "",0);
                table = _ParametersRecord.GetData();
            }

            row = table.Rows[0] as ReportDBLocalDataSet.ParametersRow;

            _Id = row.Id;
            _DefHcmWorkerId = row.DefHcmWorkerId;
            _DefOperatorId = row.DefOperatorId;
            _DeviceId = row.DeviceId;
            _DefUserId = row.DefUserId;
            _DefServer = row.DefServer;

            return table;
        }


        public void update(string _p1,string _p2,int _p3,string _p4,string _p5,string _p6)
        {
            _ParametersRecord.Updates(_p1,_p2,_p3,_p4,_p5,_p6);
        }

        public void updateServer(Int32 _p1)
        {
            _ParametersRecord.UpdateDefServer(_p1);
        }

        public bool exist()
        {
            bool ret = false;

            ret = find().Count > 0;

            return ret;
        }
    }
}
