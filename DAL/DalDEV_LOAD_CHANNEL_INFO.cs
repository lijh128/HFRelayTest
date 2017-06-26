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
    //负载柜试验路数信息
    public partial class DalDEV_LOAD_CHANNEL_INFO : DbHelperOra
    {


        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalDEV_LOAD_CHANNEL_INFO));

        #region Method
        /// <summary>
        ///   是否存在该记录
        /// </summary>
        public bool Exists(string F_LOAD_ID, string F_LOAD_CHANNEL_ID)
        {
            try
            {
                Log.Info("DalDEV_LOAD_CHANNEL_INFO->Exists---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select count(1) from T_DEV_LOAD_CHANNEL_INFO");
                strSql.Append(" where 1=1 and ");
                strSql.Append(" F_LOAD_ID = :F_LOAD_ID and  ");
                strSql.Append(" F_LOAD_CHANNEL_ID = :F_LOAD_CHANNEL_ID  ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_LOAD_ID", OracleType.VarChar,20),
					new OracleParameter(":F_LOAD_CHANNEL_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_LOAD_ID;
                parameters[1].Value = F_LOAD_CHANNEL_ID;

                Log.Info("DalDEV_LOAD_CHANNEL_INFO->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_LOAD_CHANNEL_INFO->Exists---FAILED", ex);
                throw ex;
            }
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelDEV_LOAD_CHANNEL_INFO model)
        {

            try
            {
                Log.Info("DalDEV_LOAD_CHANNEL_INFO->Add---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into T_DEV_LOAD_CHANNEL_INFO(");

                //负载柜编号
                strSql.Append("  F_LOAD_ID,");
                //通道序号
                strSql.Append("  F_LOAD_CHANNEL_ID,");
                //通道名称
                strSql.Append("  F_LOAD_CHANNEL_NAME,");
                //校准编号
                strSql.Append("  F_LOAD_CHANNEL_CALIBRATION,");
                //通道可用状态
                strSql.Append("  F_LOAD_CHANNEL_STATUS,");
                //创建时间
                strSql.Append("  F_CREATE_TIME,");
                //操作员
                strSql.Append("  F_OPERATOR_ID,");
                //操作时间
                strSql.Append("  F_OPERATIONTIME,");
                //是否删除
                strSql.Append("  F_DEL");
                strSql.Append(") values (");
                strSql.Append(" :F_LOAD_ID,");
                strSql.Append(" :F_LOAD_CHANNEL_ID,");
                strSql.Append(" :F_LOAD_CHANNEL_NAME,");
                strSql.Append(" :F_LOAD_CHANNEL_CALIBRATION,");
                strSql.Append(" :F_LOAD_CHANNEL_STATUS,");
                strSql.Append(" :F_CREATE_TIME,");
                strSql.Append(" :F_OPERATOR_ID,");
                strSql.Append(" :F_OPERATIONTIME,");
                strSql.Append(" :F_DEL");
                strSql.Append(") ");

                OracleParameter[] parameters = {
			            new OracleParameter(":F_LOAD_ID", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_LOAD_CHANNEL_ID", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_LOAD_CHANNEL_NAME", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_LOAD_CHANNEL_CALIBRATION", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_LOAD_CHANNEL_STATUS", OracleType.Number,4) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };

                //负载柜编号
                if (model.F_LOAD_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_LOAD_ID;
                }

                //通道序号
                if (model.F_LOAD_CHANNEL_ID == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_LOAD_CHANNEL_ID;
                }

                //通道名称
                if (model.F_LOAD_CHANNEL_NAME == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_LOAD_CHANNEL_NAME;
                }

                //校准编号
                if (model.F_LOAD_CHANNEL_CALIBRATION == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_LOAD_CHANNEL_CALIBRATION;
                }

                //通道可用状态
                if (model.F_LOAD_CHANNEL_STATUS == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_LOAD_CHANNEL_STATUS;
                }

                //创建时间
                if (model.F_CREATE_TIME == null)
                {
                    parameters[5].Value = DBNull.Value;
                }
                else
                {
                    parameters[5].Value = model.F_CREATE_TIME;
                }

                //操作员
                if (model.F_OPERATOR_ID == null)
                {
                    parameters[6].Value = DBNull.Value;
                }
                else
                {
                    parameters[6].Value = model.F_OPERATOR_ID;
                }

                //操作时间
                if (model.F_OPERATIONTIME == null)
                {
                    parameters[7].Value = DBNull.Value;
                }
                else
                {
                    parameters[7].Value = model.F_OPERATIONTIME;
                }

                //是否删除
                if (model.F_DEL == null)
                {
                    parameters[8].Value = DBNull.Value;
                }
                else
                {
                    parameters[8].Value = model.F_DEL;
                }

                ExecuteSql(strSql.ToString(), parameters);

            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_LOAD_CHANNEL_INFO->Add---FAILED", ex);
                throw ex;
            }
        }




        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(RelayTest.Model.ModelDEV_LOAD_CHANNEL_INFO model)
        {

            try
            {
                Log.Info("DalDEV_LOAD_CHANNEL_INFO->Update---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update T_DEV_LOAD_CHANNEL_INFO set ");

                //负载柜编号
                strSql.Append(" F_LOAD_ID = :F_LOAD_ID , ");

                //通道序号
                strSql.Append(" F_LOAD_CHANNEL_ID = :F_LOAD_CHANNEL_ID , ");

                //通道名称
                strSql.Append(" F_LOAD_CHANNEL_NAME = :F_LOAD_CHANNEL_NAME , ");

                //校准编号
                strSql.Append(" F_LOAD_CHANNEL_CALIBRATION = :F_LOAD_CHANNEL_CALIBRATION , ");

                //通道可用状态
                strSql.Append(" F_LOAD_CHANNEL_STATUS = :F_LOAD_CHANNEL_STATUS , ");

                //操作员
                strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");

                //操作时间
                strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");

                //是否删除
                strSql.Append(" F_DEL = :F_DEL  ");

                strSql.Append(" where F_LOAD_ID=:F_LOAD_ID and F_LOAD_CHANNEL_ID=:F_LOAD_CHANNEL_ID  ");

                OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_LOAD_ID", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_LOAD_CHANNEL_ID", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_LOAD_CHANNEL_NAME", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_LOAD_CHANNEL_CALIBRATION", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_LOAD_CHANNEL_STATUS", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
                //负载柜编号
                if (model.F_LOAD_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_LOAD_ID;
                }
                //通道序号
                if (model.F_LOAD_CHANNEL_ID == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_LOAD_CHANNEL_ID;
                }
                //通道名称
                if (model.F_LOAD_CHANNEL_NAME == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_LOAD_CHANNEL_NAME;
                }
                //校准编号
                if (model.F_LOAD_CHANNEL_CALIBRATION == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_LOAD_CHANNEL_CALIBRATION;
                }
                //通道可用状态
                if (model.F_LOAD_CHANNEL_STATUS == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_LOAD_CHANNEL_STATUS;
                }
                //操作员
                if (model.F_OPERATOR_ID == null)
                {
                    parameters[5].Value = DBNull.Value;
                }
                else
                {
                    parameters[5].Value = model.F_OPERATOR_ID;
                }
                //操作时间
                if (model.F_OPERATIONTIME == null)
                {
                    parameters[6].Value = DBNull.Value;
                }
                else
                {
                    parameters[6].Value = model.F_OPERATIONTIME;
                }
                //是否删除
                if (model.F_DEL == null)
                {
                    parameters[7].Value = DBNull.Value;
                }
                else
                {
                    parameters[7].Value = model.F_DEL;
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
                Log.Error("DalDEV_LOAD_CHANNEL_INFO->Update---FAILED", ex);
                throw ex;
            }




        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_LOAD_ID, string F_LOAD_CHANNEL_ID)
        {

            try
            {
                Log.Info("DalDEV_LOAD_CHANNEL_INFO->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_LOAD_CHANNEL_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_LOAD_ID=:F_LOAD_ID and F_LOAD_CHANNEL_ID=:F_LOAD_CHANNEL_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_LOAD_ID", OracleType.VarChar,20),
					new OracleParameter(":F_LOAD_CHANNEL_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_LOAD_ID;
                parameters[1].Value = F_LOAD_CHANNEL_ID;


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
                Log.Error("DalDEV_LOAD_CHANNEL_INFO->Delete---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_LOAD_ID, string F_LOAD_CHANNEL_ID)
        {

            try
            {
                Log.Info("DalDEV_LOAD_CHANNEL_INFO->Disabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_LOAD_CHANNEL_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_LOAD_ID=:F_LOAD_ID and F_LOAD_CHANNEL_ID=:F_LOAD_CHANNEL_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_LOAD_ID", OracleType.VarChar,20),
					new OracleParameter(":F_LOAD_CHANNEL_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_LOAD_ID;
                parameters[1].Value = F_LOAD_CHANNEL_ID;


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
                Log.Error("DalDEV_LOAD_CHANNEL_INFO->Disabled---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_LOAD_ID, string F_LOAD_CHANNEL_ID)
        {

            try
            {
                Log.Info("DalDEV_LOAD_CHANNEL_INFO->Enabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_LOAD_CHANNEL_INFO  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_LOAD_ID=:F_LOAD_ID and F_LOAD_CHANNEL_ID=:F_LOAD_CHANNEL_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_LOAD_ID", OracleType.VarChar,20),
					new OracleParameter(":F_LOAD_CHANNEL_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_LOAD_ID;
                parameters[1].Value = F_LOAD_CHANNEL_ID;


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
                Log.Error("DalDEV_LOAD_CHANNEL_INFO->Enabled---FAILED", ex);
                throw ex;
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool Drop(string F_LOAD_ID, string F_LOAD_CHANNEL_ID)
        {

            try
            {
                Log.Info("DalDEV_LOAD_CHANNEL_INFO->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM  T_DEV_LOAD_CHANNEL_INFO  ");
                strSql.Append(" where F_LOAD_ID=:F_LOAD_ID and F_LOAD_CHANNEL_ID=:F_LOAD_CHANNEL_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_LOAD_ID", OracleType.VarChar,20),
					new OracleParameter(":F_LOAD_CHANNEL_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_LOAD_ID;
                parameters[1].Value = F_LOAD_CHANNEL_ID;


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
                Log.Error("DalDEV_LOAD_CHANNEL_INFO->Delete---FAILED", ex);
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
                Log.Info("DalDEV_LOAD_CHANNEL_INFO->DeleteWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_LOAD_CHANNEL_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalDEV_LOAD_CHANNEL_INFO->DeleteWhere---FAILED", ex);
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
                Log.Info("DalDEV_LOAD_CHANNEL_INFO->DropWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("delete from  T_DEV_LOAD_CHANNEL_INFO  ");
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
                Log.Error("DalDEV_LOAD_CHANNEL_INFO->DropWhere---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelDEV_LOAD_CHANNEL_INFO GetModel(string F_LOAD_ID, string F_LOAD_CHANNEL_ID)
        {
            try
            {
                Log.Info("DalDEV_LOAD_CHANNEL_INFO->GetModel---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                //负载柜编号
                strSql.Append("F_LOAD_ID,  ");
                //通道序号
                strSql.Append("F_LOAD_CHANNEL_ID,  ");
                //通道名称
                strSql.Append("F_LOAD_CHANNEL_NAME,  ");
                //校准编号
                strSql.Append("F_LOAD_CHANNEL_CALIBRATION,  ");
                //通道可用状态
                strSql.Append("F_LOAD_CHANNEL_STATUS,  ");
                //创建时间
                strSql.Append("F_CREATE_TIME,  ");
                //操作员
                strSql.Append("F_OPERATOR_ID,  ");
                //操作时间
                strSql.Append("F_OPERATIONTIME,  ");
                //是否删除
                strSql.Append("F_DEL  ");
                strSql.Append("  from T_DEV_LOAD_CHANNEL_INFO ");
                strSql.Append(" where 1=1 AND  F_LOAD_ID=:F_LOAD_ID and F_LOAD_CHANNEL_ID=:F_LOAD_CHANNEL_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_LOAD_ID", OracleType.VarChar,20),
					new OracleParameter(":F_LOAD_CHANNEL_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_LOAD_ID;
                parameters[1].Value = F_LOAD_CHANNEL_ID;


                RelayTest.Model.ModelDEV_LOAD_CHANNEL_INFO model = new RelayTest.Model.ModelDEV_LOAD_CHANNEL_INFO();
                DataSet ds = Query(strSql.ToString(), parameters);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    model.F_LOAD_ID = ds.Tables[0].Rows[0]["F_LOAD_ID"].ToString();
                    model.F_LOAD_CHANNEL_ID = ds.Tables[0].Rows[0]["F_LOAD_CHANNEL_ID"].ToString();
                    model.F_LOAD_CHANNEL_NAME = ds.Tables[0].Rows[0]["F_LOAD_CHANNEL_NAME"].ToString();
                    model.F_LOAD_CHANNEL_CALIBRATION = ds.Tables[0].Rows[0]["F_LOAD_CHANNEL_CALIBRATION"].ToString();
                    if (ds.Tables[0].Rows[0]["F_LOAD_CHANNEL_STATUS"].ToString() != "")
                    {
                        model.F_LOAD_CHANNEL_STATUS = decimal.Parse(ds.Tables[0].Rows[0]["F_LOAD_CHANNEL_STATUS"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_CREATE_TIME"].ToString() != "")
                    {
                        model.F_CREATE_TIME = DateTime.Parse(ds.Tables[0].Rows[0]["F_CREATE_TIME"].ToString());
                    }
                    model.F_OPERATOR_ID = ds.Tables[0].Rows[0]["F_OPERATOR_ID"].ToString();
                    if (ds.Tables[0].Rows[0]["F_OPERATIONTIME"].ToString() != "")
                    {
                        model.F_OPERATIONTIME = DateTime.Parse(ds.Tables[0].Rows[0]["F_OPERATIONTIME"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_DEL"].ToString() != "")
                    {
                        model.F_DEL = decimal.Parse(ds.Tables[0].Rows[0]["F_DEL"].ToString());
                    }

                    return model;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_LOAD_CHANNEL_INFO->GetModel---FAILED", ex);
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
                Log.Info("DalDEV_LOAD_CHANNEL_INFO->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM T_DEV_LOAD_CHANNEL_INFO  where 1=1");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_LOAD_CHANNEL_INFO->GetList---FAILED", ex);
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
                Log.Info("DalDEV_LOAD_CHANNEL_INFO->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                if (Top > 0)
                {
                    strSql.Append(" top " + Top.ToString());
                }
                strSql.Append(" * ");
                strSql.Append(" FROM T_DEV_LOAD_CHANNEL_INFO  where F_DEL=0 ");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                strSql.Append(" order by " + filedOrder);
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_LOAD_CHANNEL_INFO->GetList---FAILED", ex);
                throw ex;
            }

        }
        #endregion Method

    }
}

