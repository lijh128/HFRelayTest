using System;
using System.Data.OracleClient;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using RelayTest.Model;
using RelayTest.Util.DBUtility;
using log4net;
namespace RelayTest.DAL
{
    //操作履历表
    public partial class DalOPERATIONLOG : DbHelperOra
    {


        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalOPERATIONLOG));

        #region Method
        /// <summary>
        ///   是否存在该记录
        /// </summary>
        public bool Exists(decimal F_ID)
        {
            try
            {
                Log.Info("DalOPERATIONLOG->Exists---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select count(1) from T_OPERATIONLOG");
                strSql.Append(" where 1=1 and ");
                strSql.Append(" F_ID = :F_ID  ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_ID", OracleType.Number,18)			};
                parameters[0].Value = F_ID;

                Log.Info("DalOPERATIONLOG->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalOPERATIONLOG->Exists---FAILED", ex);
                throw ex;
            }
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelOPERATIONLOG model)
        {

            try
            {
                Log.Info("DalOPERATIONLOG->Add---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into T_OPERATIONLOG(");
                strSql.Append("F_ID,F_DATE,F_USER_ID,F_MODULE_NAME");
                strSql.Append(") values (");
                strSql.Append(":F_ID,:F_DATE,:F_USER_ID,:F_MODULE_NAME");
                strSql.Append(") ");

                OracleParameter[] parameters = {
			            new OracleParameter(":F_ID", OracleType.Number,18) ,            
                        new OracleParameter(":F_DATE", OracleType.DateTime) ,            
                        new OracleParameter(":F_USER_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_MODULE_NAME", OracleType.VarChar,200)             
              
            };

                if (model.F_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_ID;
                }

                if (model.F_DATE == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_DATE;
                }

                if (model.F_USER_ID == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_USER_ID;
                }

                if (model.F_MODULE_NAME == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_MODULE_NAME;
                }

                ExecuteSql(strSql.ToString(), parameters);

            }
            catch (Exception ex)
            {
                Log.Error("DalOPERATIONLOG->Add---FAILED", ex);
                throw ex;
            }
        }




        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(RelayTest.Model.ModelOPERATIONLOG model)
        {

            try
            {
                Log.Info("DalOPERATIONLOG->Update---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update T_OPERATIONLOG set ");

                strSql.Append(" F_ID = :F_ID , ");
                strSql.Append(" F_DATE = :F_DATE , ");
                strSql.Append(" F_USER_ID = :F_USER_ID , ");
                strSql.Append(" F_MODULE_NAME = :F_MODULE_NAME  ");
                strSql.Append(" where F_ID=:F_ID  ");

                OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_ID", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_DATE", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_USER_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_MODULE_NAME", OracleType.VarChar,200)             
              
            };
                if (model.F_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_ID;
                }
                if (model.F_DATE == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_DATE;
                }
                if (model.F_USER_ID == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_USER_ID;
                }
                if (model.F_MODULE_NAME == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_MODULE_NAME;
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
                Log.Error("DalOPERATIONLOG->Update---FAILED", ex);
                throw ex;
            }




        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(decimal F_ID)
        {

            try
            {
                Log.Info("DalOPERATIONLOG->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_OPERATIONLOG  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_ID=:F_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_ID", OracleType.Number,18)			};
                parameters[0].Value = F_ID;


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
                Log.Error("DalOPERATIONLOG->Delete---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(decimal F_ID)
        {

            try
            {
                Log.Info("DalOPERATIONLOG->Disabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_OPERATIONLOG  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_ID=:F_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_ID", OracleType.Number,18)			};
                parameters[0].Value = F_ID;


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
                Log.Error("DalOPERATIONLOG->Disabled---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(decimal F_ID)
        {

            try
            {
                Log.Info("DalOPERATIONLOG->Enabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_OPERATIONLOG  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_ID=:F_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_ID", OracleType.Number,18)			};
                parameters[0].Value = F_ID;


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
                Log.Error("DalOPERATIONLOG->Enabled---FAILED", ex);
                throw ex;
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool Drop(decimal F_ID)
        {

            try
            {
                Log.Info("DalOPERATIONLOG->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM  T_OPERATIONLOG  ");
                strSql.Append(" where F_ID=:F_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_ID", OracleType.Number,18)			};
                parameters[0].Value = F_ID;


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
                Log.Error("DalOPERATIONLOG->Delete---FAILED", ex);
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
                Log.Info("DalOPERATIONLOG->DeleteWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_OPERATIONLOG  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalOPERATIONLOG->DeleteWhere---FAILED", ex);
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
                Log.Info("DalOPERATIONLOG->DropWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("delete from  T_OPERATIONLOG  ");
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
                Log.Error("DalOPERATIONLOG->DropWhere---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelOPERATIONLOG GetModel(decimal F_ID)
        {
            try
            {
                Log.Info("DalOPERATIONLOG->GetModel---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select F_ID, F_DATE, F_USER_ID, F_MODULE_NAME  ");
                strSql.Append("  from T_OPERATIONLOG ");
                strSql.Append(" where 1=1 AND  F_ID=:F_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_ID", OracleType.Number,18)			};
                parameters[0].Value = F_ID;


                RelayTest.Model.ModelOPERATIONLOG model = new RelayTest.Model.ModelOPERATIONLOG();
                DataSet ds = Query(strSql.ToString(), parameters);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0]["F_ID"].ToString() != "")
                    {
                        model.F_ID = decimal.Parse(ds.Tables[0].Rows[0]["F_ID"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_DATE"].ToString() != "")
                    {
                        model.F_DATE = DateTime.Parse(ds.Tables[0].Rows[0]["F_DATE"].ToString());
                    }
                    model.F_USER_ID = ds.Tables[0].Rows[0]["F_USER_ID"].ToString();
                    model.F_MODULE_NAME = ds.Tables[0].Rows[0]["F_MODULE_NAME"].ToString();

                    return model;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Log.Error("DalOPERATIONLOG->GetModel---FAILED", ex);
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
                Log.Info("DalOPERATIONLOG->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM T_OPERATIONLOG  where 1=1");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalOPERATIONLOG->GetList---FAILED", ex);
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
                Log.Info("DalOPERATIONLOG->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                if (Top > 0)
                {
                    strSql.Append(" top " + Top.ToString());
                }
                strSql.Append(" * ");
                strSql.Append(" FROM T_OPERATIONLOG  where F_DEL=0 ");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                strSql.Append(" order by " + filedOrder);
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalOPERATIONLOG->GetList---FAILED", ex);
                throw ex;
            }

        }
        #endregion Method



        #region Extension

        /// <summary>
        /// 查询log日志
        /// </summary>
        /// <param name="getLoginfoParams"></param>
        /// <returns></returns>
        public DataSet GetLoginfo(GetLoginfoParams getLoginfoParams)
        {
            try
            {
                Log.Info("DalOPERATIONLOG->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM T_OPERATIONLOG  where 1=1");
                strSql.Append(" and (F_USER_ID = :F_USER_ID OR :F_USER_ID IS NULL)");
                strSql.Append(" and (to_char(F_DATE,'yyyy-MM-dd')>= :F_DATEBEGIN OR :F_DATEBEGIN IS NULL)");
                strSql.Append(" and (to_char(F_DATE,'yyyy-MM-dd')<= :F_DATEEND OR :F_DATEEND IS NULL)");

                OracleParameter[] parameters = {
                                                   new OracleParameter(":F_USER_ID", OracleType.VarChar),
                                                   new OracleParameter(":F_DATEBEGIN", OracleType.VarChar),
                                                   new OracleParameter(":F_DATEEND", OracleType.VarChar),
                                               };
                parameters[0].Value = getLoginfoParams.UserId;
                parameters[1].Value = getLoginfoParams.BeginDateTime;
                parameters[2].Value = getLoginfoParams.EndDateTime;

                return Query(strSql.ToString(),parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalOPERATIONLOG->GetList---FAILED", ex);
                throw ex;
            }
        }
        #endregion
    }
}

