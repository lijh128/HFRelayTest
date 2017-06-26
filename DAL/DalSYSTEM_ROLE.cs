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
    //角色表
    public partial class DalSYSTEM_ROLE : DbHelperOra
    {


        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalSYSTEM_ROLE));

        #region Method
        /// <summary>
        ///   是否存在该记录
        /// </summary>
        public new bool Exists(string F_ROLE_ID)
        {
            try
            {
                Log.Info("DalSYSTEM_ROLE->Exists---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select count(1) from T_SYSTEM_ROLE");
                strSql.Append(" where 1=1 and ");
                strSql.Append(" F_ROLE_ID = :F_ROLE_ID  ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_ROLE_ID", OracleType.VarChar,10)			};
                parameters[0].Value = F_ROLE_ID;

                Log.Info("DalSYSTEM_ROLE->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalSYSTEM_ROLE->Exists---FAILED", ex);
                throw ex;
            }
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelSYSTEM_ROLE model)
        {

            try
            {
                Log.Info("DalSYSTEM_ROLE->Add---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into T_SYSTEM_ROLE(");
                strSql.Append("F_ROLE_ID,F_ROLE_NAME,F_DESC,F_CREATE_TIME,F_OPERATOR_ID,F_OPERATIONTIME,F_DEL");
                strSql.Append(") values (");
                strSql.Append(":F_ROLE_ID,:F_ROLE_NAME,:F_DESC,:F_CREATE_TIME,:F_OPERATOR_ID,:F_OPERATIONTIME,:F_DEL");
                strSql.Append(") ");

                OracleParameter[] parameters = {
			            new OracleParameter(":F_ROLE_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_ROLE_NAME", OracleType.VarChar,200) ,            
                        new OracleParameter(":F_DESC", OracleType.VarChar,200) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };

                if (model.F_ROLE_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_ROLE_ID;
                }

                if (model.F_ROLE_NAME == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_ROLE_NAME;
                }

                if (model.F_DESC == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_DESC;
                }

                if (model.F_CREATE_TIME == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_CREATE_TIME;
                }

                if (model.F_OPERATOR_ID == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_OPERATOR_ID;
                }

                if (model.F_OPERATIONTIME == null)
                {
                    parameters[5].Value = DBNull.Value;
                }
                else
                {
                    parameters[5].Value = model.F_OPERATIONTIME;
                }

                if (model.F_DEL == null)
                {
                    parameters[6].Value = DBNull.Value;
                }
                else
                {
                    parameters[6].Value = model.F_DEL;
                }

                ExecuteSql(strSql.ToString(), parameters);

            }
            catch (Exception ex)
            {
                Log.Error("DalSYSTEM_ROLE->Add---FAILED", ex);
                throw ex;
            }
        }




        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(RelayTest.Model.ModelSYSTEM_ROLE model)
        {

            try
            {
                Log.Info("DalSYSTEM_ROLE->Update---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update T_SYSTEM_ROLE set ");

                strSql.Append(" F_ROLE_ID = :F_ROLE_ID , ");
                strSql.Append(" F_ROLE_NAME = :F_ROLE_NAME , ");
                strSql.Append(" F_DESC = :F_DESC , ");
                strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");
                strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");
                strSql.Append(" F_DEL = :F_DEL  ");
                strSql.Append(" where F_ROLE_ID=:F_ROLE_ID  ");

                OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_ROLE_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_ROLE_NAME", OracleType.VarChar,200) ,            
                        	
            new OracleParameter(":F_DESC", OracleType.VarChar,200) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
                if (model.F_ROLE_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_ROLE_ID;
                }
                if (model.F_ROLE_NAME == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_ROLE_NAME;
                }
                if (model.F_DESC == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_DESC;
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
                Log.Error("DalSYSTEM_ROLE->Update---FAILED", ex);
                throw ex;
            }




        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_ROLE_ID)
        {

            try
            {
                Log.Info("DalSYSTEM_ROLE->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_SYSTEM_ROLE  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_ROLE_ID=:F_ROLE_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_ROLE_ID", OracleType.VarChar,10)			};
                parameters[0].Value = F_ROLE_ID;


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
                Log.Error("DalSYSTEM_ROLE->Delete---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_ROLE_ID)
        {

            try
            {
                Log.Info("DalSYSTEM_ROLE->Disabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_SYSTEM_ROLE  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_ROLE_ID=:F_ROLE_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_ROLE_ID", OracleType.VarChar,10)			};
                parameters[0].Value = F_ROLE_ID;


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
                Log.Error("DalSYSTEM_ROLE->Disabled---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_ROLE_ID)
        {

            try
            {
                Log.Info("DalSYSTEM_ROLE->Enabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_SYSTEM_ROLE  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_ROLE_ID=:F_ROLE_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_ROLE_ID", OracleType.VarChar,10)			};
                parameters[0].Value = F_ROLE_ID;


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
                Log.Error("DalSYSTEM_ROLE->Enabled---FAILED", ex);
                throw ex;
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool Drop(string F_ROLE_ID)
        {

            try
            {
                Log.Info("DalSYSTEM_ROLE->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM  T_SYSTEM_ROLE  ");
                strSql.Append(" where F_ROLE_ID=:F_ROLE_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_ROLE_ID", OracleType.VarChar,10)			};
                parameters[0].Value = F_ROLE_ID;


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
                Log.Error("DalSYSTEM_ROLE->Delete---FAILED", ex);
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
                Log.Info("DalSYSTEM_ROLE->DeleteWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_SYSTEM_ROLE  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalSYSTEM_ROLE->DeleteWhere---FAILED", ex);
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
                Log.Info("DalSYSTEM_ROLE->DropWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("delete from  T_SYSTEM_ROLE  ");
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
                Log.Error("DalSYSTEM_ROLE->DropWhere---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelSYSTEM_ROLE GetModel(string F_ROLE_ID)
        {
            try
            {
                Log.Info("DalSYSTEM_ROLE->GetModel---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select F_ROLE_ID, F_ROLE_NAME, F_DESC, F_CREATE_TIME, F_OPERATOR_ID, F_OPERATIONTIME, F_DEL  ");
                strSql.Append("  from T_SYSTEM_ROLE ");
                strSql.Append(" where 1=1 AND  F_ROLE_ID=:F_ROLE_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_ROLE_ID", OracleType.VarChar,10)			};
                parameters[0].Value = F_ROLE_ID;


                RelayTest.Model.ModelSYSTEM_ROLE model = new RelayTest.Model.ModelSYSTEM_ROLE();
                DataSet ds = Query(strSql.ToString(), parameters);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    model.F_ROLE_ID = ds.Tables[0].Rows[0]["F_ROLE_ID"].ToString();
                    model.F_ROLE_NAME = ds.Tables[0].Rows[0]["F_ROLE_NAME"].ToString();
                    model.F_DESC = ds.Tables[0].Rows[0]["F_DESC"].ToString();
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
                Log.Error("DalSYSTEM_ROLE->GetModel---FAILED", ex);
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
                Log.Info("DalSYSTEM_ROLE->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM T_SYSTEM_ROLE  where 1=1");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalSYSTEM_ROLE->GetList---FAILED", ex);
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
                Log.Info("DalSYSTEM_ROLE->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                if (Top > 0)
                {
                    strSql.Append(" top " + Top.ToString());
                }
                strSql.Append(" * ");
                strSql.Append(" FROM T_SYSTEM_ROLE  where F_DEL=0 ");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                strSql.Append(" order by " + filedOrder);
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalSYSTEM_ROLE->GetList---FAILED", ex);
                throw ex;
            }

        }
        #endregion

    }
}

