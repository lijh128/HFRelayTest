using System;
using System.Data.OracleClient;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using RelayTest.Util.DBUtility;
using log4net;

namespace RELAYTEST.DAL
{
    /// <summary>
    /// 数据访问类:DalLIMS_CONTACT_TYPE
    /// </summary>
    public partial class DalLIMS_CONTACT_TYPE : DbHelperOra
    {         //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalLIMS_CONTACT_TYPE));

        public DalLIMS_CONTACT_TYPE()
		{}

        /// <summary>
        /// 根据触点类型，返回相应触点类型的触点名称
        /// </summary>
        public DataSet GetLimsContactName(string strContactType)
        {
            try
            {
                Log.Info("DalLIMS_CONTACT_TYPE->GetLimsContactName---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select CONTACT_NAME ");
                strSql.Append(" from ");
                strSql.Append(" LIMS_CONTACT_TYPE ");
                strSql.Append(" where CONTACT_TYPE='" + strContactType + "' ");
                strSql.Append(" order by ORDER_NUMBER  ");

                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalLIMS_CONTACT_TYPE->GetLimsContactName---FAILED", ex);
                throw ex;
            }
        }
    }
}
