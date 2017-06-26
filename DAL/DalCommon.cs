using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using log4net;
using RelayTest.Util.DBUtility;

namespace RelayTest.DAL
{
    //串口485设置表
    public partial class DalCommon : DbHelperOra
    {


        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalCommon));


        /// <summary>
        /// 导出到access
        /// </summary>
        /// <param name="tablename"></param>
        /// <param name="condition"></param>
        public void FillAccessTableFromOracle(string tablename, string condition,string strDBConn)
        {
            try
            {
                Log.Info("DalCommon->GetLookUpEditDataSet---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * from " + tablename);
               
                if (!string.IsNullOrEmpty(condition))
                {
                    strSql.Append(" WHERE " + condition);
                }
               
                if (tablename.Equals("t_test_par_value_khd"))
                {
                    strSql.Append(" ORDER BY F_SENDORDER ");
                }
                
                DataSet dsOracle = Query(strSql.ToString());

                //列举出oracle的字段名称
                int oracleColunmCount = dsOracle.Tables[0].Columns.Count;
                string[] oracleColunms = new string[oracleColunmCount];


                for (int i = 0; i < oracleColunmCount; i++)
                {
                    oracleColunms[i] = dsOracle.Tables[0].Columns[i].ColumnName;
                }

                OleDbParameter[] parameters = new OleDbParameter[oracleColunmCount];

                for (int j = 0; j < dsOracle.Tables[0].Rows.Count; j++)
                {
                    string insertSql = "";
                    insertSql += "insert into " + tablename + " (";
                    for (int i = 0; i < oracleColunmCount; i++)
                    {
                        insertSql += oracleColunms[i] + ",";
                    }
                    //去掉最后一个逗号
                    insertSql=insertSql.TrimEnd(',');


                    insertSql += ") values (";
                    for (int i = 0; i < oracleColunmCount; i++)
                    {
                        insertSql += "@" + oracleColunms[i] + ",";
                    }
                    //去掉最后一个逗号
                    insertSql=insertSql.TrimEnd(',');
                    insertSql += " )";

                    for (int i = 0; i < oracleColunmCount; i++)
                    {
                        parameters[i] = new OleDbParameter("@" + oracleColunms[i], dsOracle.Tables[0].Rows[j][i]);
                    }

                    AccessDBClass myAccessdb = new AccessDBClass(strDBConn);
                    bool insert_status = myAccessdb.ExecuteSQLNonquery(insertSql, parameters);
                } 
            }
            catch (Exception ex)
            {
                Log.Error("DalCommon->GetLookUpEditDataSet---FAILED", ex);
                throw ex;
            }
        }



        /// <summary>
        /// 获得填充下拉选择框内容的数据表
        /// </summary>
        /// <param name="tablename">表明</param>
        /// <param name="condition">条件</param>
        /// <returns></returns>
        public DataSet GetLookUpEditDataSet(string tablename, string condition)
        {

            try
            {
                Log.Info("DalCommon->GetLookUpEditDataSet---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * from " + tablename );
                if (!string.IsNullOrEmpty(condition))
                {
                    strSql.Append(" where  " + condition);

                }

                Log.Info("DalCommon->GetLookUpEditDataSet---END");

                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalCommon->GetLookUpEditDataSet---FAILED", ex);
                throw ex;
            }
        }
    }
}
