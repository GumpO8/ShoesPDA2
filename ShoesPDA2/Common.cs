using System;

using System.Collections.Generic;
using System.Text;
using ShoesPDA2.ReportDBLocalDataSetTableAdapters;

namespace ShoesPDA2
{
    class Common
    {
        ParametersTableAdapter _ParametersRecord;

         // <summary>
        /// 构造函数
        /// </summary>
        public Common()
        {
            _ParametersRecord = new ParametersTableAdapter();
        }

        public ParametersTableAdapter ParametersRecord
        {
            get { return _ParametersRecord; }
            set { _ParametersRecord = value; }
        }

        /// <summary>
        /// 检查PDA 本地数据库文件
        /// </summary>
        /// <returns></returns>
        public bool CheckDBFile()
        {
            bool isExists = false;

            if (System.IO.File.Exists(_ParametersRecord.Connection.DataSource))
            {
                isExists = true;
            }

            return isExists;
        }
    }
}
