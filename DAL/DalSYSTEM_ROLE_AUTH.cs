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
    //角色功能对应关系
    public partial class DalSYSTEM_ROLE_AUTH : DbHelperOra
    {


        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalSYSTEM_ROLE_AUTH));

        #region Method
        /// <summary>
        ///   是否存在该记录
        /// </summary>
        public bool Exists(string F_MODULE_ID, string F_ROLE_ID)
        {
            try
            {
                Log.Info("DalSYSTEM_ROLE_AUTH->Exists---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select count(1) from T_SYSTEM_ROLE_AUTH");
                strSql.Append(" where F_DEL = 0 and ");
                strSql.Append(" F_MODULE_ID = :F_MODULE_ID and  ");
                strSql.Append(" F_ROLE_ID = :F_ROLE_ID  ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_MODULE_ID", OracleType.VarChar,50),
					new OracleParameter(":F_ROLE_ID", OracleType.VarChar,10)			};
                parameters[0].Value = F_MODULE_ID;
                parameters[1].Value = F_ROLE_ID;

                Log.Info("DalSYSTEM_ROLE_AUTH->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalSYSTEM_ROLE_AUTH->Exists---FAILED", ex);
                throw ex;
            }
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelSYSTEM_ROLE_AUTH model)
        {

            try
            {
                Log.Info("DalSYSTEM_ROLE_AUTH->Add---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into T_SYSTEM_ROLE_AUTH(");
                strSql.Append("F_MODULE_ID,F_ROLE_ID,F_CREATE_TIME,F_OPERATOR_ID,F_OPERATIONTIME,F_DEL");
                strSql.Append(") values (");
                strSql.Append(":F_MODULE_ID,:F_ROLE_ID,:F_CREATE_TIME,:F_OPERATOR_ID,:F_OPERATIONTIME,:F_DEL");
                strSql.Append(") ");

                OracleParameter[] parameters = {
			            new OracleParameter(":F_MODULE_ID", OracleType.VarChar,50) ,            
                        new OracleParameter(":F_ROLE_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };

                if (model.F_MODULE_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_MODULE_ID;
                }

                if (model.F_ROLE_ID == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_ROLE_ID;
                }

                if (model.F_CREATE_TIME == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_CREATE_TIME;
                }

                if (model.F_OPERATOR_ID == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_OPERATOR_ID;
                }

                if (model.F_OPERATIONTIME == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_OPERATIONTIME;
                }

                if (model.F_DEL == null)
                {
                    parameters[5].Value = DBNull.Value;
                }
                else
                {
                    parameters[5].Value = model.F_DEL;
                }

                ExecuteSql(strSql.ToString(), parameters);

            }
            catch (Exception ex)
            {
                Log.Error("DalSYSTEM_ROLE_AUTH->Add---FAILED", ex);
                throw ex;
            }
        }




        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(RelayTest.Model.ModelSYSTEM_ROLE_AUTH model)
        {

            try
            {
                Log.Info("DalSYSTEM_ROLE_AUTH->Update---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update T_SYSTEM_ROLE_AUTH set ");

                strSql.Append(" F_MODULE_ID = :F_MODULE_ID , ");
                strSql.Append(" F_ROLE_ID = :F_ROLE_ID , ");
                strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");
                strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");
                strSql.Append(" F_DEL = :F_DEL  ");
                strSql.Append(" where F_MODULE_ID=:F_MODULE_ID and F_ROLE_ID=:F_ROLE_ID  ");

                OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_MODULE_ID", OracleType.VarChar,50) ,            
                        	
            new OracleParameter(":F_ROLE_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
                if (model.F_MODULE_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_MODULE_ID;
                }
                if (model.F_ROLE_ID == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_ROLE_ID;
                }
                if (model.F_OPERATOR_ID == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_OPERATOR_ID;
                }
                if (model.F_OPERATIONTIME == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_OPERATIONTIME;
                }
                if (model.F_DEL == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_DEL;
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
                Log.Error("DalSYSTEM_ROLE_AUTH->Update---FAILED", ex);
                throw ex;
            }




        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_MODULE_ID, string F_ROLE_ID)
        {

            try
            {
                Log.Info("DalSYSTEM_ROLE_AUTH->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_SYSTEM_ROLE_AUTH  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_MODULE_ID=:F_MODULE_ID and F_ROLE_ID=:F_ROLE_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_MODULE_ID", OracleType.VarChar,50),
					new OracleParameter(":F_ROLE_ID", OracleType.VarChar,10)			};
                parameters[0].Value = F_MODULE_ID;
                parameters[1].Value = F_ROLE_ID;


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
                Log.Error("DalSYSTEM_ROLE_AUTH->Delete---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_MODULE_ID, string F_ROLE_ID)
        {

            try
            {
                Log.Info("DalSYSTEM_ROLE_AUTH->Disabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_SYSTEM_ROLE_AUTH  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_MODULE_ID=:F_MODULE_ID and F_ROLE_ID=:F_ROLE_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_MODULE_ID", OracleType.VarChar,50),
					new OracleParameter(":F_ROLE_ID", OracleType.VarChar,10)			};
                parameters[0].Value = F_MODULE_ID;
                parameters[1].Value = F_ROLE_ID;


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
                Log.Error("DalSYSTEM_ROLE_AUTH->Disabled---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_MODULE_ID, string F_ROLE_ID)
        {

            try
            {
                Log.Info("DalSYSTEM_ROLE_AUTH->Enabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_SYSTEM_ROLE_AUTH  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_MODULE_ID=:F_MODULE_ID and F_ROLE_ID=:F_ROLE_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_MODULE_ID", OracleType.VarChar,50),
					new OracleParameter(":F_ROLE_ID", OracleType.VarChar,10)			};
                parameters[0].Value = F_MODULE_ID;
                parameters[1].Value = F_ROLE_ID;


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
                Log.Error("DalSYSTEM_ROLE_AUTH->Enabled---FAILED", ex);
                throw ex;
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool Drop(string F_MODULE_ID, string F_ROLE_ID)
        {

            try
            {
                Log.Info("DalSYSTEM_ROLE_AUTH->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM  T_SYSTEM_ROLE_AUTH  ");
                strSql.Append(" where F_MODULE_ID=:F_MODULE_ID and F_ROLE_ID=:F_ROLE_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_MODULE_ID", OracleType.VarChar,50),
					new OracleParameter(":F_ROLE_ID", OracleType.VarChar,10)			};
                parameters[0].Value = F_MODULE_ID;
                parameters[1].Value = F_ROLE_ID;


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
                Log.Error("DalSYSTEM_ROLE_AUTH->Delete---FAILED", ex);
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
                Log.Info("DalSYSTEM_ROLE_AUTH->DeleteWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_SYSTEM_ROLE_AUTH  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalSYSTEM_ROLE_AUTH->DeleteWhere---FAILED", ex);
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
                Log.Info("DalSYSTEM_ROLE_AUTH->DropWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("delete from  T_SYSTEM_ROLE_AUTH  ");
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
                Log.Error("DalSYSTEM_ROLE_AUTH->DropWhere---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelSYSTEM_ROLE_AUTH GetModel(string F_MODULE_ID, string F_ROLE_ID)
        {
            try
            {
                Log.Info("DalSYSTEM_ROLE_AUTH->GetModel---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select F_MODULE_ID, F_ROLE_ID, F_CREATE_TIME, F_OPERATOR_ID, F_OPERATIONTIME, F_DEL  ");
                strSql.Append("  from T_SYSTEM_ROLE_AUTH ");
                strSql.Append(" where F_DEL=0 AND  F_MODULE_ID=:F_MODULE_ID and F_ROLE_ID=:F_ROLE_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_MODULE_ID", OracleType.VarChar,50),
					new OracleParameter(":F_ROLE_ID", OracleType.VarChar,10)			};
                parameters[0].Value = F_MODULE_ID;
                parameters[1].Value = F_ROLE_ID;


                RelayTest.Model.ModelSYSTEM_ROLE_AUTH model = new RelayTest.Model.ModelSYSTEM_ROLE_AUTH();
                DataSet ds = Query(strSql.ToString(), parameters);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    model.F_MODULE_ID = ds.Tables[0].Rows[0]["F_MODULE_ID"].ToString();
                    model.F_ROLE_ID = ds.Tables[0].Rows[0]["F_ROLE_ID"].ToString();
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
                Log.Error("DalSYSTEM_ROLE_AUTH->GetModel---FAILED", ex);
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
                Log.Info("DalSYSTEM_ROLE_AUTH->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM T_SYSTEM_ROLE_AUTH  where F_DEL=0");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalSYSTEM_ROLE_AUTH->GetList---FAILED", ex);
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
                Log.Info("DalSYSTEM_ROLE_AUTH->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                if (Top > 0)
                {
                    strSql.Append(" top " + Top.ToString());
                }
                strSql.Append(" * ");
                strSql.Append(" FROM T_SYSTEM_ROLE_AUTH  where F_DEL=0 ");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                strSql.Append(" order by " + filedOrder);
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalSYSTEM_ROLE_AUTH->GetList---FAILED", ex);
                throw ex;
            }

        }
        #endregion Method


        #region extension

        /// <summary>
        /// Get authed modules by user id
        /// </summary>
        /// <param name="roleId">user id</param>
        /// <returns></returns>
        public DataSet GetUsersOfRole(string roleId)
        {
            try
            {
                Log.Info("DalSYSTEM_ROLE_AUTH->GetUsersOfRole---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("	SELECT T_SYSTEM_USER.F_USER_ID,	");
                strSql.Append("	       T_SYSTEM_USER.F_USER_NAME	");
                strSql.Append("	  FROM T_SYSTEM_USER	");
                strSql.Append("	       LEFT JOIN T_SYSTEM_USER_ROLE	");
                strSql.Append("	          ON T_SYSTEM_USER_ROLE.F_USER_ID = T_SYSTEM_USER.F_USER_ID	");
                strSql.Append("	 WHERE T_SYSTEM_USER_ROLE.F_ROLE_ID = :F_ROLE_ID	");
                OracleParameter[] parameters = {
					new OracleParameter(":F_ROLE_ID", OracleType.VarChar,10)			};
                parameters[0].Value = roleId;

                Log.Info("DalSYSTEM_ROLE_AUTH->GetUsersOfRole---END");

                return Query(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalSYSTEM_ROLE_AUTH->GetUsersOfRole---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 获得一个角色下的功能列表
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public DataSet GetModulesOfRole(string roleId)
        {
            try
            {
                Log.Info("DalSYSTEM_ROLE_AUTH->GetUsersOfRole---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("	SELECT T_SYSTEM_MODULE.F_MODULE_ID,	");
                strSql.Append("	       T_SYSTEM_MODULE.F_MODULE_NAME	");
                strSql.Append("	  FROM T_SYSTEM_ROLE_AUTH	");
                strSql.Append("	       LEFT JOIN T_SYSTEM_MODULE	");
                strSql.Append("	          ON T_SYSTEM_ROLE_AUTH.F_MODULE_ID = T_SYSTEM_MODULE.F_MODULE_ID	");
                strSql.Append("	 WHERE T_SYSTEM_ROLE_AUTH.F_ROLE_ID = :F_ROLE_ID	");

                OracleParameter[] parameters = {
					new OracleParameter(":F_ROLE_ID", OracleType.VarChar,10)			};
                parameters[0].Value = roleId;

                Log.Info("DalSYSTEM_ROLE_AUTH->GetUsersOfRole---END");

                return Query(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalSYSTEM_ROLE_AUTH->GetUsersOfRole---FAILED", ex);
                throw ex;
            }

        }
        #endregion

        #region 自定义函数
        /// <summary>
        /// 根据用户名获得授权模块信息
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public DataSet GetModuleOfUser(string userId)
        {
            try
            {
                Log.Info("DalSYSTEM_ROLE_AUTH->GetModuleOfUser---START");

                StringBuilder strSql = new StringBuilder();
                
                strSql.Append("	select T_SYSTEM_ROLE_AUTH.F_MODULE_ID,T_SYSTEM_MODULE.F_MODULE_NAME ");
                strSql.Append("	from t_system_role_auth,T_SYSTEM_USER_ROLE,T_SYSTEM_USER,T_SYSTEM_MODULE ");
                strSql.Append("	WHERE T_SYSTEM_USER.F_USER_ID=:F_USER_ID	");
                strSql.Append("	AND T_SYSTEM_USER_ROLE.F_USER_ID=T_SYSTEM_USER.F_USER_ID ");
                strSql.Append("	AND T_SYSTEM_ROLE_AUTH.F_ROLE_ID=T_SYSTEM_USER_ROLE.F_ROLE_ID ");
                strSql.Append("	AND T_SYSTEM_MODULE.F_MODULE_ID=T_SYSTEM_ROLE_AUTH.F_MODULE_ID	");
                strSql.Append("	AND LENGTH(T_SYSTEM_MODULE.F_MODULE_ID)=5 ");
                strSql.Append("	ORDER BY F_MODULE_ID ");
                
                OracleParameter[] parameters = {
					new OracleParameter(":F_USER_ID", OracleType.VarChar,10)			};
                parameters[0].Value = userId;

                Log.Info("DalSYSTEM_ROLE_AUTH->GetModuleOfUser---END");

                return Query(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalSYSTEM_ROLE_AUTH->GetModuleOfUser---FAILED", ex);
                throw ex;
            }

        }

        #endregion

    }
}

