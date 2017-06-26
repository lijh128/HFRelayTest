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
    //用户表
    public partial class DalSYSTEM_USER : DbHelperOra
    {


        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalSYSTEM_USER));

        #region Method
        /// <summary>
        ///   是否存在该记录
        /// </summary>
        public new bool Exists(string F_USER_ID)
        {
            try
            {
                Log.Info("DalSYSTEM_USER->Exists---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select count(1) from T_SYSTEM_USER");
                strSql.Append(" where 1=1 and ");
                strSql.Append(" F_USER_ID = :F_USER_ID  ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_USER_ID", OracleType.VarChar,10)			};
                parameters[0].Value = F_USER_ID;

                Log.Info("DalSYSTEM_USER->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalSYSTEM_USER->Exists---FAILED", ex);
                throw ex;
            }
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelSYSTEM_USER model)
        {

            try
            {
                Log.Info("DalSYSTEM_USER->Add---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into T_SYSTEM_USER(");

                //用户编号
                strSql.Append("  F_USER_ID,");
                //真实姓名
                strSql.Append("  F_USER_NAME,");
                //密码
                strSql.Append("  F_PASSWORD,");
                //联系电话
                strSql.Append("  F_PHONE,");
                //是否是上位机用户
                strSql.Append("  F_ISSWJ,");
                //创建时间
                strSql.Append("  F_CREATE_TIME,");
                //操作员
                strSql.Append("  F_OPERATOR_ID,");
                //操作时间
                strSql.Append("  F_OPERATIONTIME,");
                //是否删除
                strSql.Append("  F_DEL");
                strSql.Append(") values (");
                strSql.Append(" :F_USER_ID,");
                strSql.Append(" :F_USER_NAME,");
                strSql.Append(" :F_PASSWORD,");
                strSql.Append(" :F_PHONE,");
                strSql.Append(" :F_ISSWJ,");
                strSql.Append(" :F_CREATE_TIME,");
                strSql.Append(" :F_OPERATOR_ID,");
                strSql.Append(" :F_OPERATIONTIME,");
                strSql.Append(" :F_DEL");
                strSql.Append(") ");

                OracleParameter[] parameters = {
			            new OracleParameter(":F_USER_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_USER_NAME", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_PASSWORD", OracleType.VarChar,128) ,            
                        new OracleParameter(":F_PHONE", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_ISSWJ", OracleType.Number,4) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };

                //用户编号
                if (model.F_USER_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_USER_ID;
                }

                //真实姓名
                if (model.F_USER_NAME == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_USER_NAME;
                }

                //密码
                if (model.F_PASSWORD == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_PASSWORD;
                }

                //联系电话
                if (model.F_PHONE == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_PHONE;
                }

                //是否是上位机用户
                if (model.F_ISSWJ == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_ISSWJ;
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
                Log.Error("DalSYSTEM_USER->Add---FAILED", ex);
                throw ex;
            }
        }




        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(RelayTest.Model.ModelSYSTEM_USER model)
        {

            try
            {
                Log.Info("DalSYSTEM_USER->Update---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update T_SYSTEM_USER set ");

                //用户编号
                strSql.Append(" F_USER_ID = :F_USER_ID , ");

                //真实姓名
                strSql.Append(" F_USER_NAME = :F_USER_NAME , ");

                //密码
                strSql.Append(" F_PASSWORD = :F_PASSWORD , ");

                //联系电话
                strSql.Append(" F_PHONE = :F_PHONE , ");

                //是否是上位机用户
                strSql.Append(" F_ISSWJ = :F_ISSWJ , ");

                //操作员
                strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");

                //操作时间
                strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");

                //是否删除
                strSql.Append(" F_DEL = :F_DEL  ");

                strSql.Append(" where F_USER_ID=:F_USER_ID  ");

                OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_USER_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_USER_NAME", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_PASSWORD", OracleType.VarChar,128) ,            
                        	
            new OracleParameter(":F_PHONE", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_ISSWJ", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
                //用户编号
                if (model.F_USER_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_USER_ID;
                }
                //真实姓名
                if (model.F_USER_NAME == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_USER_NAME;
                }
                //密码
                if (model.F_PASSWORD == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_PASSWORD;
                }
                //联系电话
                if (model.F_PHONE == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_PHONE;
                }
                //是否是上位机用户
                if (model.F_ISSWJ == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_ISSWJ;
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
                Log.Error("DalSYSTEM_USER->Update---FAILED", ex);
                throw ex;
            }




        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_USER_ID)
        {

            try
            {
                Log.Info("DalSYSTEM_USER->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_SYSTEM_USER  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_USER_ID=:F_USER_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_USER_ID", OracleType.VarChar,10)			};
                parameters[0].Value = F_USER_ID;


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
                Log.Error("DalSYSTEM_USER->Delete---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_USER_ID)
        {

            try
            {
                Log.Info("DalSYSTEM_USER->Disabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_SYSTEM_USER  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_USER_ID=:F_USER_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_USER_ID", OracleType.VarChar,10)			};
                parameters[0].Value = F_USER_ID;


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
                Log.Error("DalSYSTEM_USER->Disabled---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_USER_ID)
        {

            try
            {
                Log.Info("DalSYSTEM_USER->Enabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_SYSTEM_USER  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_USER_ID=:F_USER_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_USER_ID", OracleType.VarChar,10)			};
                parameters[0].Value = F_USER_ID;


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
                Log.Error("DalSYSTEM_USER->Enabled---FAILED", ex);
                throw ex;
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool Drop(string F_USER_ID)
        {

            try
            {
                Log.Info("DalSYSTEM_USER->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM  T_SYSTEM_USER  ");
                strSql.Append(" where F_USER_ID=:F_USER_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_USER_ID", OracleType.VarChar,10)			};
                parameters[0].Value = F_USER_ID;


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
                Log.Error("DalSYSTEM_USER->Delete---FAILED", ex);
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
                Log.Info("DalSYSTEM_USER->DeleteWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_SYSTEM_USER  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalSYSTEM_USER->DeleteWhere---FAILED", ex);
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
                Log.Info("DalSYSTEM_USER->DropWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("delete from  T_SYSTEM_USER  ");
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
                Log.Error("DalSYSTEM_USER->DropWhere---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelSYSTEM_USER GetModel(string F_USER_ID)
        {
            try
            {
                Log.Info("DalSYSTEM_USER->GetModel---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                //用户编号
                strSql.Append("F_USER_ID,  ");
                //真实姓名
                strSql.Append("F_USER_NAME,  ");
                //密码
                strSql.Append("F_PASSWORD,  ");
                //联系电话
                strSql.Append("F_PHONE,  ");
                //是否是上位机用户
                strSql.Append("F_ISSWJ,  ");
                //创建时间
                strSql.Append("F_CREATE_TIME,  ");
                //操作员
                strSql.Append("F_OPERATOR_ID,  ");
                //操作时间
                strSql.Append("F_OPERATIONTIME,  ");
                //是否删除
                strSql.Append("F_DEL  ");
                strSql.Append("  from T_SYSTEM_USER ");
                strSql.Append(" where 1=1 AND  F_USER_ID=:F_USER_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_USER_ID", OracleType.VarChar,10)			};
                parameters[0].Value = F_USER_ID;


                RelayTest.Model.ModelSYSTEM_USER model = new RelayTest.Model.ModelSYSTEM_USER();
                DataSet ds = Query(strSql.ToString(), parameters);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    model.F_USER_ID = ds.Tables[0].Rows[0]["F_USER_ID"].ToString();
                    model.F_USER_NAME = ds.Tables[0].Rows[0]["F_USER_NAME"].ToString();
                    model.F_PASSWORD = ds.Tables[0].Rows[0]["F_PASSWORD"].ToString();
                    model.F_PHONE = ds.Tables[0].Rows[0]["F_PHONE"].ToString();
                    if (ds.Tables[0].Rows[0]["F_ISSWJ"].ToString() != "")
                    {
                        model.F_ISSWJ = decimal.Parse(ds.Tables[0].Rows[0]["F_ISSWJ"].ToString());
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
                Log.Error("DalSYSTEM_USER->GetModel---FAILED", ex);
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
                Log.Info("DalSYSTEM_USER->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM T_SYSTEM_USER  where 1=1");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalSYSTEM_USER->GetList---FAILED", ex);
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
                Log.Info("DalSYSTEM_USER->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                if (Top > 0)
                {
                    strSql.Append(" top " + Top.ToString());
                }
                strSql.Append(" * ");
                strSql.Append(" FROM T_SYSTEM_USER  where F_DEL=0 ");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                strSql.Append(" order by " + filedOrder);
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalSYSTEM_USER->GetList---FAILED", ex);
                throw ex;
            }

        }
        #endregion Method

        #region Extension


        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="model"></param>
        public void ChagePassword(ModelSYSTEM_USER model)
        {

            try
            {
                Log.Info("DalXUSER->ChagePassword---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update T_XT_USER set ");

                strSql.Append(" F_PASSWORD = :F_PASSWORD , ");
                strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");
                strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");
                strSql.Append(" where F_USERID=:F_USER_ID  ");

                OracleParameter[] parameters = {
			            		            	
           
                        	
            new OracleParameter(":F_PASSWORD", OracleType.VarChar,200) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
             new OracleParameter(":F_USERID", OracleType.VarChar,10)              
              
            };


                if (model.F_PASSWORD == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_PASSWORD;
                }

                if (model.F_OPERATOR_ID == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_OPERATOR_ID;
                }
                if (model.F_OPERATIONTIME == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_OPERATIONTIME;
                }
               
                if (model.F_USER_ID == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_USER_ID;
                }

                int rows = ExecuteSql(strSql.ToString(), parameters);

            }
            catch (Exception ex)
            {
                Log.Error("DalXUSER->ChagePassword---FAILED", ex);
                throw ex;
            }


        }
        #endregion
    }
}

