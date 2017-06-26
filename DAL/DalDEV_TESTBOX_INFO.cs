using System;
using System.Data.OracleClient;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using RelayTest.Util.DBUtility;
using log4net;
namespace RelayTest.DAL
{
    //试验箱基本信息
    public partial class DalDEV_TESTBOX_INFO : DbHelperOra
    {


        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalDEV_TESTBOX_INFO));

        #region Method
        /// <summary>
        ///   是否存在该记录
        /// </summary>
        public new bool Exists(string F_TESTBOX_ID)
        {
            try
            {
                Log.Info("DalDEV_TESTBOX_INFO->Exists---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select count(1) from T_DEV_TESTBOX_INFO");
                strSql.Append(" where 1=1 and ");
                strSql.Append(" F_TESTBOX_ID = :F_TESTBOX_ID  ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_TESTBOX_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_TESTBOX_ID;

                Log.Info("DalDEV_TESTBOX_INFO->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_TESTBOX_INFO->Exists---FAILED", ex);
                throw ex;
            }
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelDEV_TESTBOX_INFO model)
        {

            try
            {
                Log.Info("DalDEV_TESTBOX_INFO->Add---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into T_DEV_TESTBOX_INFO(");

                //试验箱编号
                strSql.Append("  F_TESTBOX_ID,");
                //操作时间
                strSql.Append("  F_OPERATIONTIME,");
                //是否删除
                strSql.Append("  F_DEL,");
                //试验箱名称
                strSql.Append("  F_TESTBOX_NAME,");
                //校准编号
                strSql.Append("  F_TESTBOX_CALIBRATION,");
                //试验箱地址
                strSql.Append("  F_TESTBOX_ADDRESS,");
                //通信端口地址
                strSql.Append("  F_COM_ADDRESS,");
                //试验箱状态
                strSql.Append("  F_TESTBOX_STATUS,");
                //备注
                strSql.Append("  F_TESTBOX_MEMO,");
                //创建时间
                strSql.Append("  F_CREATE_TIME,");
                //操作员
                strSql.Append("  F_OPERATOR_ID");
                strSql.Append(") values (");
                strSql.Append(" :F_TESTBOX_ID,");
                strSql.Append(" :F_OPERATIONTIME,");
                strSql.Append(" :F_DEL,");
                strSql.Append(" :F_TESTBOX_NAME,");
                strSql.Append(" :F_TESTBOX_CALIBRATION,");
                strSql.Append(" :F_TESTBOX_ADDRESS,");
                strSql.Append(" :F_COM_ADDRESS,");
                strSql.Append(" :F_TESTBOX_STATUS,");
                strSql.Append(" :F_TESTBOX_MEMO,");
                strSql.Append(" :F_CREATE_TIME,");
                strSql.Append(" :F_OPERATOR_ID");
                strSql.Append(") ");

                OracleParameter[] parameters = {
			            new OracleParameter(":F_TESTBOX_ID", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4) ,            
                        new OracleParameter(":F_TESTBOX_NAME", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_TESTBOX_CALIBRATION", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_TESTBOX_ADDRESS", OracleType.Number,4) ,            
                        new OracleParameter(":F_COM_ADDRESS", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_TESTBOX_STATUS", OracleType.Number,4) ,            
                        new OracleParameter(":F_TESTBOX_MEMO", OracleType.VarChar,500) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10)             
              
            };

                //试验箱编号
                if (model.F_TESTBOX_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_TESTBOX_ID;
                }

                //操作时间
                if (model.F_OPERATIONTIME == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_OPERATIONTIME;
                }

                //是否删除
                if (model.F_DEL == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_DEL;
                }

                //试验箱名称
                if (model.F_TESTBOX_NAME == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_TESTBOX_NAME;
                }

                //校准编号
                if (model.F_TESTBOX_CALIBRATION == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_TESTBOX_CALIBRATION;
                }

                //试验箱地址
                if (model.F_TESTBOX_ADDRESS == null)
                {
                    parameters[5].Value = DBNull.Value;
                }
                else
                {
                    parameters[5].Value = model.F_TESTBOX_ADDRESS;
                }

                //通信端口地址
                if (model.F_COM_ADDRESS == null)
                {
                    parameters[6].Value = DBNull.Value;
                }
                else
                {
                    parameters[6].Value = model.F_COM_ADDRESS;
                }

                //试验箱状态
                if (model.F_TESTBOX_STATUS == null)
                {
                    parameters[7].Value = DBNull.Value;
                }
                else
                {
                    parameters[7].Value = model.F_TESTBOX_STATUS;
                }

                //备注
                if (model.F_TESTBOX_MEMO == null)
                {
                    parameters[8].Value = DBNull.Value;
                }
                else
                {
                    parameters[8].Value = model.F_TESTBOX_MEMO;
                }

                //创建时间
                if (model.F_CREATE_TIME == null)
                {
                    parameters[9].Value = DBNull.Value;
                }
                else
                {
                    parameters[9].Value = model.F_CREATE_TIME;
                }

                //操作员
                if (model.F_OPERATOR_ID == null)
                {
                    parameters[10].Value = DBNull.Value;
                }
                else
                {
                    parameters[10].Value = model.F_OPERATOR_ID;
                }

                ExecuteSql(strSql.ToString(), parameters);

            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_TESTBOX_INFO->Add---FAILED", ex);
                throw ex;
            }
        }




        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(RelayTest.Model.ModelDEV_TESTBOX_INFO model)
        {

            try
            {
                Log.Info("DalDEV_TESTBOX_INFO->Update---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update T_DEV_TESTBOX_INFO set ");

                //试验箱编号
                strSql.Append(" F_TESTBOX_ID = :F_TESTBOX_ID , ");

                //操作时间
                strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");

                //是否删除
                strSql.Append(" F_DEL = :F_DEL , ");

                //试验箱名称
                strSql.Append(" F_TESTBOX_NAME = :F_TESTBOX_NAME , ");

                //校准编号
                strSql.Append(" F_TESTBOX_CALIBRATION = :F_TESTBOX_CALIBRATION , ");

                //试验箱地址
                strSql.Append(" F_TESTBOX_ADDRESS = :F_TESTBOX_ADDRESS , ");

                //通信端口地址
                strSql.Append(" F_COM_ADDRESS = :F_COM_ADDRESS , ");

                //试验箱状态
                strSql.Append(" F_TESTBOX_STATUS = :F_TESTBOX_STATUS , ");

                //备注
                strSql.Append(" F_TESTBOX_MEMO = :F_TESTBOX_MEMO , ");

                //操作员
                strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID  ");

                strSql.Append(" where F_TESTBOX_ID=:F_TESTBOX_ID  ");

                OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_TESTBOX_ID", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_TESTBOX_NAME", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_TESTBOX_CALIBRATION", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_TESTBOX_ADDRESS", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_COM_ADDRESS", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_TESTBOX_STATUS", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_TESTBOX_MEMO", OracleType.VarChar,500) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10)             
              
            };
                //试验箱编号
                if (model.F_TESTBOX_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_TESTBOX_ID;
                }
                //操作时间
                if (model.F_OPERATIONTIME == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_OPERATIONTIME;
                }
                //是否删除
                if (model.F_DEL == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_DEL;
                }
                //试验箱名称
                if (model.F_TESTBOX_NAME == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_TESTBOX_NAME;
                }
                //校准编号
                if (model.F_TESTBOX_CALIBRATION == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_TESTBOX_CALIBRATION;
                }
                //试验箱地址
                if (model.F_TESTBOX_ADDRESS == null)
                {
                    parameters[5].Value = DBNull.Value;
                }
                else
                {
                    parameters[5].Value = model.F_TESTBOX_ADDRESS;
                }
                //通信端口地址
                if (model.F_COM_ADDRESS == null)
                {
                    parameters[6].Value = DBNull.Value;
                }
                else
                {
                    parameters[6].Value = model.F_COM_ADDRESS;
                }
                //试验箱状态
                if (model.F_TESTBOX_STATUS == null)
                {
                    parameters[7].Value = DBNull.Value;
                }
                else
                {
                    parameters[7].Value = model.F_TESTBOX_STATUS;
                }
                //备注
                if (model.F_TESTBOX_MEMO == null)
                {
                    parameters[8].Value = DBNull.Value;
                }
                else
                {
                    parameters[8].Value = model.F_TESTBOX_MEMO;
                }
                //操作员
                if (model.F_OPERATOR_ID == null)
                {
                    parameters[9].Value = DBNull.Value;
                }
                else
                {
                    parameters[9].Value = model.F_OPERATOR_ID;
                }

                int rows = ExecuteSql(strSql.ToString(), parameters);
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_TESTBOX_INFO->Update---FAILED", ex);
                throw ex;
            }




        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_TESTBOX_ID)
        {

            try
            {
                Log.Info("DalDEV_TESTBOX_INFO->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_TESTBOX_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_TESTBOX_ID=:F_TESTBOX_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_TESTBOX_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_TESTBOX_ID;


                int rows = ExecuteSql(strSql.ToString(), parameters);
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_TESTBOX_INFO->Delete---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_TESTBOX_ID)
        {

            try
            {
                Log.Info("DalDEV_TESTBOX_INFO->Disabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_TESTBOX_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_TESTBOX_ID=:F_TESTBOX_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_TESTBOX_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_TESTBOX_ID;


                int rows = ExecuteSql(strSql.ToString(), parameters);
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_TESTBOX_INFO->Disabled---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_TESTBOX_ID)
        {

            try
            {
                Log.Info("DalDEV_TESTBOX_INFO->Enabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_TESTBOX_INFO  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_TESTBOX_ID=:F_TESTBOX_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_TESTBOX_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_TESTBOX_ID;


                int rows = ExecuteSql(strSql.ToString(), parameters);
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_TESTBOX_INFO->Enabled---FAILED", ex);
                throw ex;
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool Drop(string F_TESTBOX_ID)
        {

            try
            {
                Log.Info("DalDEV_TESTBOX_INFO->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM  T_DEV_TESTBOX_INFO  ");
                strSql.Append(" where F_TESTBOX_ID=:F_TESTBOX_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_TESTBOX_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_TESTBOX_ID;


                int rows = ExecuteSql(strSql.ToString(), parameters);
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_TESTBOX_INFO->Delete---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        ///  按条件删除一批数据
        /// </summary>
        public bool DeleteWhere(string strWhere)
        {
            try
            {
                Log.Info("DalDEV_TESTBOX_INFO->DeleteWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_TESTBOX_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_DEL=0  ");
                if (strWhere != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                int rows = ExecuteSql(strSql.ToString());
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_TESTBOX_INFO->DeleteWhere---FAILED", ex);
                throw ex;
            }
        }



        /// <summary>
        ///  按条件永久删除一批数据
        /// </summary>
        public bool DropWhere(string strWhere)
        {
            try
            {
                Log.Info("DalDEV_TESTBOX_INFO->DropWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("delete from  T_DEV_TESTBOX_INFO  ");
                strSql.Append(" where 1=1  ");
                if (strWhere != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                int rows = ExecuteSql(strSql.ToString());
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_TESTBOX_INFO->DropWhere---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelDEV_TESTBOX_INFO GetModel(string F_TESTBOX_ID)
        {
            try
            {
                Log.Info("DalDEV_TESTBOX_INFO->GetModel---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                //试验箱编号
                strSql.Append("F_TESTBOX_ID,  ");
                //操作时间
                strSql.Append("F_OPERATIONTIME,  ");
                //是否删除
                strSql.Append("F_DEL,  ");
                //试验箱名称
                strSql.Append("F_TESTBOX_NAME,  ");
                //校准编号
                strSql.Append("F_TESTBOX_CALIBRATION,  ");
                //试验箱地址
                strSql.Append("F_TESTBOX_ADDRESS,  ");
                //通信端口地址
                strSql.Append("F_COM_ADDRESS,  ");
                //试验箱状态
                strSql.Append("F_TESTBOX_STATUS,  ");
                //备注
                strSql.Append("F_TESTBOX_MEMO,  ");
                //创建时间
                strSql.Append("F_CREATE_TIME,  ");
                //操作员
                strSql.Append("F_OPERATOR_ID  ");
                strSql.Append("  from T_DEV_TESTBOX_INFO ");
                strSql.Append(" where 1=1 AND  F_TESTBOX_ID=:F_TESTBOX_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_TESTBOX_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_TESTBOX_ID;


                RelayTest.Model.ModelDEV_TESTBOX_INFO model = new RelayTest.Model.ModelDEV_TESTBOX_INFO();
                DataSet ds = Query(strSql.ToString(), parameters);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    model.F_TESTBOX_ID = ds.Tables[0].Rows[0]["F_TESTBOX_ID"].ToString();
                    if (ds.Tables[0].Rows[0]["F_OPERATIONTIME"].ToString() != "")
                    {
                        model.F_OPERATIONTIME = DateTime.Parse(ds.Tables[0].Rows[0]["F_OPERATIONTIME"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_DEL"].ToString() != "")
                    {
                        model.F_DEL = decimal.Parse(ds.Tables[0].Rows[0]["F_DEL"].ToString());
                    }
                    model.F_TESTBOX_NAME = ds.Tables[0].Rows[0]["F_TESTBOX_NAME"].ToString();
                    model.F_TESTBOX_CALIBRATION = ds.Tables[0].Rows[0]["F_TESTBOX_CALIBRATION"].ToString();
                    if (ds.Tables[0].Rows[0]["F_TESTBOX_ADDRESS"].ToString() != "")
                    {
                        model.F_TESTBOX_ADDRESS = decimal.Parse(ds.Tables[0].Rows[0]["F_TESTBOX_ADDRESS"].ToString());
                    }
                    model.F_COM_ADDRESS = ds.Tables[0].Rows[0]["F_COM_ADDRESS"].ToString();
                    if (ds.Tables[0].Rows[0]["F_TESTBOX_STATUS"].ToString() != "")
                    {
                        model.F_TESTBOX_STATUS = decimal.Parse(ds.Tables[0].Rows[0]["F_TESTBOX_STATUS"].ToString());
                    }
                    model.F_TESTBOX_MEMO = ds.Tables[0].Rows[0]["F_TESTBOX_MEMO"].ToString();
                    if (ds.Tables[0].Rows[0]["F_CREATE_TIME"].ToString() != "")
                    {
                        model.F_CREATE_TIME = DateTime.Parse(ds.Tables[0].Rows[0]["F_CREATE_TIME"].ToString());
                    }
                    model.F_OPERATOR_ID = ds.Tables[0].Rows[0]["F_OPERATOR_ID"].ToString();

                    return model;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_TESTBOX_INFO->GetModel---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {


            try
            {
                Log.Info("DalDEV_TESTBOX_INFO->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM T_DEV_TESTBOX_INFO  where 1=1");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_TESTBOX_INFO->GetList---FAILED", ex);
                throw ex;
            }

        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {

            try
            {
                Log.Info("DalDEV_TESTBOX_INFO->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                if (Top > 0)
                {
                    strSql.Append(" top " + Top.ToString());
                }
                strSql.Append(" * ");
                strSql.Append(" FROM T_DEV_TESTBOX_INFO  where F_DEL=0 ");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                strSql.Append(" order by " + filedOrder);
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_TESTBOX_INFO->GetList---FAILED", ex);
                throw ex;
            }

        }
        #endregion Method


    }
}

