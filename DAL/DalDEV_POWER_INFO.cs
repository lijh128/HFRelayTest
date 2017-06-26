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
    //供电柜基本信息
    public partial class DalDEV_POWER_INFO : DbHelperOra
    {


        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalDEV_POWER_INFO));

        #region Method
        /// <summary>
        ///   是否存在该记录
        /// </summary>
        public new bool Exists(string F_POWER_ID)
        {
            try
            {
                Log.Info("DalDEV_POWER_INFO->Exists---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select count(1) from T_DEV_POWER_INFO");
                strSql.Append(" where 1=1 and ");
                strSql.Append(" F_POWER_ID = :F_POWER_ID  ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_POWER_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_POWER_ID;

                Log.Info("DalDEV_POWER_INFO->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_POWER_INFO->Exists---FAILED", ex);
                throw ex;
            }
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelDEV_POWER_INFO model)
        {

            try
            {
                Log.Info("DalDEV_POWER_INFO->Add---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into T_DEV_POWER_INFO(");

                //供电柜编号
                strSql.Append("  F_POWER_ID,");
                //供电柜名称
                strSql.Append("  F_POWER_NAME,");
                //校准编号
                strSql.Append("  F_POWER_CALIBRATION,");
                //描述信息
                strSql.Append("  F_POWER_DESCRIPTION,");
                //创建时间
                strSql.Append("  F_CREATE_TIME,");
                //操作员
                strSql.Append("  F_OPERATOR_ID,");
                //操作时间
                strSql.Append("  F_OPERATIONTIME,");
                //是否删除
                strSql.Append("  F_DEL");
                strSql.Append(") values (");
                strSql.Append(" :F_POWER_ID,");
                strSql.Append(" :F_POWER_NAME,");
                strSql.Append(" :F_POWER_CALIBRATION,");
                strSql.Append(" :F_POWER_DESCRIPTION,");
                strSql.Append(" :F_CREATE_TIME,");
                strSql.Append(" :F_OPERATOR_ID,");
                strSql.Append(" :F_OPERATIONTIME,");
                strSql.Append(" :F_DEL");
                strSql.Append(") ");

                OracleParameter[] parameters = {
			            new OracleParameter(":F_POWER_ID", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_POWER_NAME", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_POWER_CALIBRATION", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_POWER_DESCRIPTION", OracleType.VarChar,500) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };

                //供电柜编号
                if (model.F_POWER_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_POWER_ID;
                }

                //供电柜名称
                if (model.F_POWER_NAME == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_POWER_NAME;
                }

                //校准编号
                if (model.F_POWER_CALIBRATION == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_POWER_CALIBRATION;
                }

                //描述信息
                if (model.F_POWER_DESCRIPTION == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_POWER_DESCRIPTION;
                }

                //创建时间
                if (model.F_CREATE_TIME == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_CREATE_TIME;
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

                ExecuteSql(strSql.ToString(), parameters);

            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_POWER_INFO->Add---FAILED", ex);
                throw ex;
            }
        }




        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(RelayTest.Model.ModelDEV_POWER_INFO model)
        {

            try
            {
                Log.Info("DalDEV_POWER_INFO->Update---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update T_DEV_POWER_INFO set ");

                //供电柜编号
                strSql.Append(" F_POWER_ID = :F_POWER_ID , ");

                //供电柜名称
                strSql.Append(" F_POWER_NAME = :F_POWER_NAME , ");

                //校准编号
                strSql.Append(" F_POWER_CALIBRATION = :F_POWER_CALIBRATION , ");

                //描述信息
                strSql.Append(" F_POWER_DESCRIPTION = :F_POWER_DESCRIPTION , ");

                //操作员
                strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");

                //操作时间
                strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");

                //是否删除
                strSql.Append(" F_DEL = :F_DEL  ");

                strSql.Append(" where F_POWER_ID=:F_POWER_ID  ");

                OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_POWER_ID", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_POWER_NAME", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_POWER_CALIBRATION", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_POWER_DESCRIPTION", OracleType.VarChar,500) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
                //供电柜编号
                if (model.F_POWER_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_POWER_ID;
                }
                //供电柜名称
                if (model.F_POWER_NAME == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_POWER_NAME;
                }
                //校准编号
                if (model.F_POWER_CALIBRATION == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_POWER_CALIBRATION;
                }
                //描述信息
                if (model.F_POWER_DESCRIPTION == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_POWER_DESCRIPTION;
                }
                //操作员
                if (model.F_OPERATOR_ID == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_OPERATOR_ID;
                }
                //操作时间
                if (model.F_OPERATIONTIME == null)
                {
                    parameters[5].Value = DBNull.Value;
                }
                else
                {
                    parameters[5].Value = model.F_OPERATIONTIME;
                }
                //是否删除
                if (model.F_DEL == null)
                {
                    parameters[6].Value = DBNull.Value;
                }
                else
                {
                    parameters[6].Value = model.F_DEL;
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
                Log.Error("DalDEV_POWER_INFO->Update---FAILED", ex);
                throw ex;
            }




        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_POWER_ID)
        {

            try
            {
                Log.Info("DalDEV_POWER_INFO->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_POWER_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_POWER_ID=:F_POWER_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_POWER_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_POWER_ID;


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
                Log.Error("DalDEV_POWER_INFO->Delete---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_POWER_ID)
        {

            try
            {
                Log.Info("DalDEV_POWER_INFO->Disabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_POWER_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_POWER_ID=:F_POWER_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_POWER_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_POWER_ID;


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
                Log.Error("DalDEV_POWER_INFO->Disabled---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_POWER_ID)
        {

            try
            {
                Log.Info("DalDEV_POWER_INFO->Enabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_POWER_INFO  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_POWER_ID=:F_POWER_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_POWER_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_POWER_ID;


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
                Log.Error("DalDEV_POWER_INFO->Enabled---FAILED", ex);
                throw ex;
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool Drop(string F_POWER_ID)
        {

            try
            {
                Log.Info("DalDEV_POWER_INFO->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM  T_DEV_POWER_INFO  ");
                strSql.Append(" where F_POWER_ID=:F_POWER_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_POWER_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_POWER_ID;


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
                Log.Error("DalDEV_POWER_INFO->Delete---FAILED", ex);
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
                Log.Info("DalDEV_POWER_INFO->DeleteWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_POWER_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalDEV_POWER_INFO->DeleteWhere---FAILED", ex);
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
                Log.Info("DalDEV_POWER_INFO->DropWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("delete from  T_DEV_POWER_INFO  ");
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
                Log.Error("DalDEV_POWER_INFO->DropWhere---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelDEV_POWER_INFO GetModel(string F_POWER_ID)
        {
            try
            {
                Log.Info("DalDEV_POWER_INFO->GetModel---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                //供电柜编号
                strSql.Append("F_POWER_ID,  ");
                //供电柜名称
                strSql.Append("F_POWER_NAME,  ");
                //校准编号
                strSql.Append("F_POWER_CALIBRATION,  ");
                //描述信息
                strSql.Append("F_POWER_DESCRIPTION,  ");
                //创建时间
                strSql.Append("F_CREATE_TIME,  ");
                //操作员
                strSql.Append("F_OPERATOR_ID,  ");
                //操作时间
                strSql.Append("F_OPERATIONTIME,  ");
                //是否删除
                strSql.Append("F_DEL  ");
                strSql.Append("  from T_DEV_POWER_INFO ");
                strSql.Append(" where 1=1 AND  F_POWER_ID=:F_POWER_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_POWER_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_POWER_ID;


                RelayTest.Model.ModelDEV_POWER_INFO model = new RelayTest.Model.ModelDEV_POWER_INFO();
                DataSet ds = Query(strSql.ToString(), parameters);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    model.F_POWER_ID = ds.Tables[0].Rows[0]["F_POWER_ID"].ToString();
                    model.F_POWER_NAME = ds.Tables[0].Rows[0]["F_POWER_NAME"].ToString();
                    model.F_POWER_CALIBRATION = ds.Tables[0].Rows[0]["F_POWER_CALIBRATION"].ToString();
                    model.F_POWER_DESCRIPTION = ds.Tables[0].Rows[0]["F_POWER_DESCRIPTION"].ToString();
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
                Log.Error("DalDEV_POWER_INFO->GetModel---FAILED", ex);
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
                Log.Info("DalDEV_POWER_INFO->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM T_DEV_POWER_INFO  where 1=1");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_POWER_INFO->GetList---FAILED", ex);
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
                Log.Info("DalDEV_POWER_INFO->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                if (Top > 0)
                {
                    strSql.Append(" top " + Top.ToString());
                }
                strSql.Append(" * ");
                strSql.Append(" FROM T_DEV_POWER_INFO  where F_DEL=0 ");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                strSql.Append(" order by " + filedOrder);
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_POWER_INFO->GetList---FAILED", ex);
                throw ex;
            }

        }
        #endregion Method


    }
}

