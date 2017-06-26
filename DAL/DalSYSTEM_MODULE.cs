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
    //模块功能表
    public partial class DalSYSTEM_MODULE : DbHelperOra
    {


        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalSYSTEM_MODULE));

        #region Method
        /// <summary>
        ///   是否存在该记录
        /// </summary>
        public new bool Exists(string F_MODULE_ID)
        {
            try
            {
                Log.Info("DalSYSTEM_MODULE->Exists---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select count(1) from T_SYSTEM_MODULE");
                strSql.Append(" where 1=1 and ");
                strSql.Append(" F_MODULE_ID = :F_MODULE_ID  ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_MODULE_ID", OracleType.VarChar,50)			};
                parameters[0].Value = F_MODULE_ID;

                Log.Info("DalSYSTEM_MODULE->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalSYSTEM_MODULE->Exists---FAILED", ex);
                throw ex;
            }
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelSYSTEM_MODULE model)
        {

            try
            {
                Log.Info("DalSYSTEM_MODULE->Add---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into T_SYSTEM_MODULE(");
                strSql.Append("F_MODULE_ID,F_CREATE_TIME,F_OPERATOR_ID,F_OPERATIONTIME,F_DEL,F_MODULE_NAME,F_FULLNAME,F_PARENT_MODULE_ID,F_ACTION,F_PATH,F_ORDNO,F_DESC,F_ISADMINONLY");
                strSql.Append(") values (");
                strSql.Append(":F_MODULE_ID,:F_CREATE_TIME,:F_OPERATOR_ID,:F_OPERATIONTIME,:F_DEL,:F_MODULE_NAME,:F_FULLNAME,:F_PARENT_MODULE_ID,:F_ACTION,:F_PATH,:F_ORDNO,:F_DESC,:F_ISADMINONLY");
                strSql.Append(") ");

                OracleParameter[] parameters = {
			            new OracleParameter(":F_MODULE_ID", OracleType.VarChar,50) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4) ,            
                        new OracleParameter(":F_MODULE_NAME", OracleType.VarChar,200) ,            
                        new OracleParameter(":F_FULLNAME", OracleType.VarChar,200) ,            
                        new OracleParameter(":F_PARENT_MODULE_ID", OracleType.VarChar,50) ,            
                        new OracleParameter(":F_ACTION", OracleType.VarChar,200) ,            
                        new OracleParameter(":F_PATH", OracleType.VarChar,200) ,            
                        new OracleParameter(":F_ORDNO", OracleType.Number,4) ,            
                        new OracleParameter(":F_DESC", OracleType.VarChar,500) ,            
                        new OracleParameter(":F_ISADMINONLY", OracleType.VarChar,4)             
              
            };

                if (model.F_MODULE_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_MODULE_ID;
                }

                if (model.F_CREATE_TIME == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_CREATE_TIME;
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

                if (model.F_MODULE_NAME == null)
                {
                    parameters[5].Value = DBNull.Value;
                }
                else
                {
                    parameters[5].Value = model.F_MODULE_NAME;
                }

                if (model.F_FULLNAME == null)
                {
                    parameters[6].Value = DBNull.Value;
                }
                else
                {
                    parameters[6].Value = model.F_FULLNAME;
                }

                if (model.F_PARENT_MODULE_ID == null)
                {
                    parameters[7].Value = DBNull.Value;
                }
                else
                {
                    parameters[7].Value = model.F_PARENT_MODULE_ID;
                }

                if (model.F_ACTION == null)
                {
                    parameters[8].Value = DBNull.Value;
                }
                else
                {
                    parameters[8].Value = model.F_ACTION;
                }

                if (model.F_PATH == null)
                {
                    parameters[9].Value = DBNull.Value;
                }
                else
                {
                    parameters[9].Value = model.F_PATH;
                }

                if (model.F_ORDNO == null)
                {
                    parameters[10].Value = DBNull.Value;
                }
                else
                {
                    parameters[10].Value = model.F_ORDNO;
                }

                if (model.F_DESC == null)
                {
                    parameters[11].Value = DBNull.Value;
                }
                else
                {
                    parameters[11].Value = model.F_DESC;
                }

                if (model.F_ISADMINONLY == null)
                {
                    parameters[12].Value = DBNull.Value;
                }
                else
                {
                    parameters[12].Value = model.F_ISADMINONLY;
                }

                ExecuteSql(strSql.ToString(), parameters);

            }
            catch (Exception ex)
            {
                Log.Error("DalSYSTEM_MODULE->Add---FAILED", ex);
                throw ex;
            }
        }




        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(RelayTest.Model.ModelSYSTEM_MODULE model)
        {

            try
            {
                Log.Info("DalSYSTEM_MODULE->Update---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update T_SYSTEM_MODULE set ");

                strSql.Append(" F_MODULE_ID = :F_MODULE_ID , ");
                strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");
                strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");
                strSql.Append(" F_DEL = :F_DEL , ");
                strSql.Append(" F_MODULE_NAME = :F_MODULE_NAME , ");
                strSql.Append(" F_FULLNAME = :F_FULLNAME , ");
                strSql.Append(" F_PARENT_MODULE_ID = :F_PARENT_MODULE_ID , ");
                strSql.Append(" F_ACTION = :F_ACTION , ");
                strSql.Append(" F_PATH = :F_PATH , ");
                strSql.Append(" F_ORDNO = :F_ORDNO , ");
                strSql.Append(" F_DESC = :F_DESC , ");
                strSql.Append(" F_ISADMINONLY = :F_ISADMINONLY  ");
                strSql.Append(" where F_MODULE_ID=:F_MODULE_ID  ");

                OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_MODULE_ID", OracleType.VarChar,50) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_MODULE_NAME", OracleType.VarChar,200) ,            
                        	
            new OracleParameter(":F_FULLNAME", OracleType.VarChar,200) ,            
                        	
            new OracleParameter(":F_PARENT_MODULE_ID", OracleType.VarChar,50) ,            
                        	
            new OracleParameter(":F_ACTION", OracleType.VarChar,200) ,            
                        	
            new OracleParameter(":F_PATH", OracleType.VarChar,200) ,            
                        	
            new OracleParameter(":F_ORDNO", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_DESC", OracleType.VarChar,500) ,            
                        	
            new OracleParameter(":F_ISADMINONLY", OracleType.VarChar,4)             
              
            };
                if (model.F_MODULE_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_MODULE_ID;
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
                if (model.F_DEL == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_DEL;
                }
                if (model.F_MODULE_NAME == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_MODULE_NAME;
                }
                if (model.F_FULLNAME == null)
                {
                    parameters[5].Value = DBNull.Value;
                }
                else
                {
                    parameters[5].Value = model.F_FULLNAME;
                }
                if (model.F_PARENT_MODULE_ID == null)
                {
                    parameters[6].Value = DBNull.Value;
                }
                else
                {
                    parameters[6].Value = model.F_PARENT_MODULE_ID;
                }
                if (model.F_ACTION == null)
                {
                    parameters[7].Value = DBNull.Value;
                }
                else
                {
                    parameters[7].Value = model.F_ACTION;
                }
                if (model.F_PATH == null)
                {
                    parameters[8].Value = DBNull.Value;
                }
                else
                {
                    parameters[8].Value = model.F_PATH;
                }
                if (model.F_ORDNO == null)
                {
                    parameters[9].Value = DBNull.Value;
                }
                else
                {
                    parameters[9].Value = model.F_ORDNO;
                }
                if (model.F_DESC == null)
                {
                    parameters[10].Value = DBNull.Value;
                }
                else
                {
                    parameters[10].Value = model.F_DESC;
                }
                if (model.F_ISADMINONLY == null)
                {
                    parameters[11].Value = DBNull.Value;
                }
                else
                {
                    parameters[11].Value = model.F_ISADMINONLY;
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
                Log.Error("DalSYSTEM_MODULE->Update---FAILED", ex);
                throw ex;
            }




        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_MODULE_ID)
        {

            try
            {
                Log.Info("DalSYSTEM_MODULE->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_SYSTEM_MODULE  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_MODULE_ID=:F_MODULE_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_MODULE_ID", OracleType.VarChar,50)			};
                parameters[0].Value = F_MODULE_ID;


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
                Log.Error("DalSYSTEM_MODULE->Delete---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_MODULE_ID)
        {

            try
            {
                Log.Info("DalSYSTEM_MODULE->Disabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_SYSTEM_MODULE  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_MODULE_ID=:F_MODULE_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_MODULE_ID", OracleType.VarChar,50)			};
                parameters[0].Value = F_MODULE_ID;


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
                Log.Error("DalSYSTEM_MODULE->Disabled---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_MODULE_ID)
        {

            try
            {
                Log.Info("DalSYSTEM_MODULE->Enabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_SYSTEM_MODULE  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_MODULE_ID=:F_MODULE_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_MODULE_ID", OracleType.VarChar,50)			};
                parameters[0].Value = F_MODULE_ID;


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
                Log.Error("DalSYSTEM_MODULE->Enabled---FAILED", ex);
                throw ex;
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool Drop(string F_MODULE_ID)
        {

            try
            {
                Log.Info("DalSYSTEM_MODULE->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM  T_SYSTEM_MODULE  ");
                strSql.Append(" where F_MODULE_ID=:F_MODULE_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_MODULE_ID", OracleType.VarChar,50)			};
                parameters[0].Value = F_MODULE_ID;


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
                Log.Error("DalSYSTEM_MODULE->Delete---FAILED", ex);
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
                Log.Info("DalSYSTEM_MODULE->DeleteWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_SYSTEM_MODULE  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalSYSTEM_MODULE->DeleteWhere---FAILED", ex);
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
                Log.Info("DalSYSTEM_MODULE->DropWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("delete from  T_SYSTEM_MODULE  ");
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
                Log.Error("DalSYSTEM_MODULE->DropWhere---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelSYSTEM_MODULE GetModel(string F_MODULE_ID)
        {
            try
            {
                Log.Info("DalSYSTEM_MODULE->GetModel---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select F_MODULE_ID, F_CREATE_TIME, F_OPERATOR_ID, F_OPERATIONTIME, F_DEL, F_MODULE_NAME, F_FULLNAME, F_PARENT_MODULE_ID, F_ACTION, F_PATH, F_ORDNO, F_DESC, F_ISADMINONLY  ");
                strSql.Append("  from T_SYSTEM_MODULE ");
                strSql.Append(" where 1=1 AND  F_MODULE_ID=:F_MODULE_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_MODULE_ID", OracleType.VarChar,50)			};
                parameters[0].Value = F_MODULE_ID;


                RelayTest.Model.ModelSYSTEM_MODULE model = new RelayTest.Model.ModelSYSTEM_MODULE();
                DataSet ds = Query(strSql.ToString(), parameters);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    model.F_MODULE_ID = ds.Tables[0].Rows[0]["F_MODULE_ID"].ToString();
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
                    model.F_MODULE_NAME = ds.Tables[0].Rows[0]["F_MODULE_NAME"].ToString();
                    model.F_FULLNAME = ds.Tables[0].Rows[0]["F_FULLNAME"].ToString();
                    model.F_PARENT_MODULE_ID = ds.Tables[0].Rows[0]["F_PARENT_MODULE_ID"].ToString();
                    model.F_ACTION = ds.Tables[0].Rows[0]["F_ACTION"].ToString();
                    model.F_PATH = ds.Tables[0].Rows[0]["F_PATH"].ToString();
                    if (ds.Tables[0].Rows[0]["F_ORDNO"].ToString() != "")
                    {
                        model.F_ORDNO = decimal.Parse(ds.Tables[0].Rows[0]["F_ORDNO"].ToString());
                    }
                    model.F_DESC = ds.Tables[0].Rows[0]["F_DESC"].ToString();
                    model.F_ISADMINONLY = ds.Tables[0].Rows[0]["F_ISADMINONLY"].ToString();

                    return model;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Log.Error("DalSYSTEM_MODULE->GetModel---FAILED", ex);
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
                Log.Info("DalSYSTEM_MODULE->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM T_SYSTEM_MODULE  where 1=1");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalSYSTEM_MODULE->GetList---FAILED", ex);
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
                Log.Info("DalSYSTEM_MODULE->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                if (Top > 0)
                {
                    strSql.Append(" top " + Top.ToString());
                }
                strSql.Append(" * ");
                strSql.Append(" FROM T_SYSTEM_MODULE  where F_DEL=0 ");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                strSql.Append(" order by " + filedOrder);
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalSYSTEM_MODULE->GetList---FAILED", ex);
                throw ex;
            }

        }
        #endregion Method


        #region Extension
        /// <summary>
        /// 按顺序获得全部记录
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllMoudle()
        {
            try
            {
                Log.Info("DalSYSTEM_MODULE->GetAllMoudle---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM T_SYSTEM_MODULE ");

                strSql.Append(" order by F_MODULE_ID,F_ORDNO ");

                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalSYSTEM_MODULE->GetAllMoudle---FAILED", ex);
                throw ex;
            }


        }
        #endregion


    }
}

