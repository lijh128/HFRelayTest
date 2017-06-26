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
    //下位机系统更新流水
    public partial class DalDEV_UPGRADERECORD : DbHelperOra
    {


        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalDEV_UPGRADERECORD));

        #region Method
        /// <summary>
        ///   是否存在该记录
        /// </summary>
        public bool Exists(decimal F_DEV_TYPE, string F_DEV_ID, string F_HARDWARE_VERSION, string F_SOFTWARE_VERSION)
        {
            try
            {
                Log.Info("DalDEV_UPGRADERECORD->Exists---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select count(1) from T_DEV_UPGRADERECORD");
                strSql.Append(" where 1=1 and ");
                strSql.Append(" F_DEV_TYPE = :F_DEV_TYPE and  ");
                strSql.Append(" F_DEV_ID = :F_DEV_ID and  ");
                strSql.Append(" F_HARDWARE_VERSION = :F_HARDWARE_VERSION and  ");
                strSql.Append(" F_SOFTWARE_VERSION = :F_SOFTWARE_VERSION  ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_DEV_TYPE", OracleType.Number,8),
					new OracleParameter(":F_DEV_ID", OracleType.VarChar,20),
					new OracleParameter(":F_HARDWARE_VERSION", OracleType.VarChar,100),
					new OracleParameter(":F_SOFTWARE_VERSION", OracleType.VarChar,100)			};
                parameters[0].Value = F_DEV_TYPE;
                parameters[1].Value = F_DEV_ID;
                parameters[2].Value = F_HARDWARE_VERSION;
                parameters[3].Value = F_SOFTWARE_VERSION;

                Log.Info("DalDEV_UPGRADERECORD->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_UPGRADERECORD->Exists---FAILED", ex);
                throw ex;
            }
        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(decimal F_DEV_TYPE, string F_DEV_ID, string F_HARDWARE_VERSION, string F_SOFTWARE_VERSION)
        {

            try
            {
                Log.Info("DalDEV_UPGRADERECORD->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_UPGRADERECORD  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_DEV_TYPE=:F_DEV_TYPE and F_DEV_ID=:F_DEV_ID and F_HARDWARE_VERSION=:F_HARDWARE_VERSION and F_SOFTWARE_VERSION=:F_SOFTWARE_VERSION ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_DEV_TYPE", OracleType.Number,8),
					new OracleParameter(":F_DEV_ID", OracleType.VarChar,20),
					new OracleParameter(":F_HARDWARE_VERSION", OracleType.VarChar,100),
					new OracleParameter(":F_SOFTWARE_VERSION", OracleType.VarChar,100)			};
                parameters[0].Value = F_DEV_TYPE;
                parameters[1].Value = F_DEV_ID;
                parameters[2].Value = F_HARDWARE_VERSION;
                parameters[3].Value = F_SOFTWARE_VERSION;


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
                Log.Error("DalDEV_UPGRADERECORD->Delete---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(decimal F_DEV_TYPE, string F_DEV_ID, string F_HARDWARE_VERSION, string F_SOFTWARE_VERSION)
        {

            try
            {
                Log.Info("DalDEV_UPGRADERECORD->Disabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_UPGRADERECORD  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_DEV_TYPE=:F_DEV_TYPE and F_DEV_ID=:F_DEV_ID and F_HARDWARE_VERSION=:F_HARDWARE_VERSION and F_SOFTWARE_VERSION=:F_SOFTWARE_VERSION ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_DEV_TYPE", OracleType.Number,8),
					new OracleParameter(":F_DEV_ID", OracleType.VarChar,20),
					new OracleParameter(":F_HARDWARE_VERSION", OracleType.VarChar,100),
					new OracleParameter(":F_SOFTWARE_VERSION", OracleType.VarChar,100)			};
                parameters[0].Value = F_DEV_TYPE;
                parameters[1].Value = F_DEV_ID;
                parameters[2].Value = F_HARDWARE_VERSION;
                parameters[3].Value = F_SOFTWARE_VERSION;


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
                Log.Error("DalDEV_UPGRADERECORD->Disabled---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(decimal F_DEV_TYPE, string F_DEV_ID, string F_HARDWARE_VERSION, string F_SOFTWARE_VERSION)
        {

            try
            {
                Log.Info("DalDEV_UPGRADERECORD->Enabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_UPGRADERECORD  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_DEV_TYPE=:F_DEV_TYPE and F_DEV_ID=:F_DEV_ID and F_HARDWARE_VERSION=:F_HARDWARE_VERSION and F_SOFTWARE_VERSION=:F_SOFTWARE_VERSION ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_DEV_TYPE", OracleType.Number,8),
					new OracleParameter(":F_DEV_ID", OracleType.VarChar,20),
					new OracleParameter(":F_HARDWARE_VERSION", OracleType.VarChar,100),
					new OracleParameter(":F_SOFTWARE_VERSION", OracleType.VarChar,100)			};
                parameters[0].Value = F_DEV_TYPE;
                parameters[1].Value = F_DEV_ID;
                parameters[2].Value = F_HARDWARE_VERSION;
                parameters[3].Value = F_SOFTWARE_VERSION;


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
                Log.Error("DalDEV_UPGRADERECORD->Enabled---FAILED", ex);
                throw ex;
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool Drop(decimal F_DEV_TYPE, string F_DEV_ID, string F_HARDWARE_VERSION, string F_SOFTWARE_VERSION)
        {

            try
            {
                Log.Info("DalDEV_UPGRADERECORD->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM  T_DEV_UPGRADERECORD  ");
                strSql.Append(" where F_DEV_TYPE=:F_DEV_TYPE and F_DEV_ID=:F_DEV_ID and F_HARDWARE_VERSION=:F_HARDWARE_VERSION and F_SOFTWARE_VERSION=:F_SOFTWARE_VERSION ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_DEV_TYPE", OracleType.Number,8),
					new OracleParameter(":F_DEV_ID", OracleType.VarChar,20),
					new OracleParameter(":F_HARDWARE_VERSION", OracleType.VarChar,100),
					new OracleParameter(":F_SOFTWARE_VERSION", OracleType.VarChar,100)			};
                parameters[0].Value = F_DEV_TYPE;
                parameters[1].Value = F_DEV_ID;
                parameters[2].Value = F_HARDWARE_VERSION;
                parameters[3].Value = F_SOFTWARE_VERSION;


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
                Log.Error("DalDEV_UPGRADERECORD->Delete---FAILED", ex);
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
                Log.Info("DalDEV_UPGRADERECORD->DeleteWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_UPGRADERECORD  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalDEV_UPGRADERECORD->DeleteWhere---FAILED", ex);
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
                Log.Info("DalDEV_UPGRADERECORD->DropWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("delete from  T_DEV_UPGRADERECORD  ");
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
                Log.Error("DalDEV_UPGRADERECORD->DropWhere---FAILED", ex);
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
                Log.Info("DalDEV_UPGRADERECORD->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM T_DEV_UPGRADERECORD  where 1=1");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_UPGRADERECORD->GetList---FAILED", ex);
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
                Log.Info("DalDEV_UPGRADERECORD->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                if (Top > 0)
                {
                    strSql.Append(" top " + Top.ToString());
                }
                strSql.Append(" * ");
                strSql.Append(" FROM T_DEV_UPGRADERECORD  where F_DEL=0 ");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                strSql.Append(" order by " + filedOrder);
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_UPGRADERECORD->GetList---FAILED", ex);
                throw ex;
            }

        }
        #endregion Method

        #region Extension


        /// <summary>
        /// 判断是否有附件
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool HasAttatch(ModelDEV_UPGRADERECORD model)
        {
            try
            {
                Log.Info("DalDEV_UPGRADERECORD->HasAttatch---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select NVL (LENGTH (T_DEV_UPGRADERECORD.F_ATTATCHMENT), 0) ");
                strSql.Append("  from T_DEV_UPGRADERECORD ");
                strSql.Append(" where F_DEV_TYPE=:F_DEV_TYPE and F_DEV_ID=:F_DEV_ID and F_HARDWARE_VERSION=:F_HARDWARE_VERSION and F_SOFTWARE_VERSION=:F_SOFTWARE_VERSION ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_DEV_TYPE", OracleType.Number,8),
					new OracleParameter(":F_DEV_ID", OracleType.VarChar,20),
					new OracleParameter(":F_HARDWARE_VERSION", OracleType.VarChar,100),
					new OracleParameter(":F_SOFTWARE_VERSION", OracleType.VarChar,100)			};
                parameters[0].Value = model.F_DEV_TYPE;
                parameters[1].Value = model.F_DEV_ID;
                parameters[2].Value = model.F_HARDWARE_VERSION;
                parameters[3].Value = model.F_SOFTWARE_VERSION;
                DataSet ds = Query(strSql.ToString(), parameters);

                if (ds != null && ds.Tables.Count > 0)
                {
                    return int.Parse(ds.Tables[0].Rows[0][0].ToString()) > 0;
                }
                return false;

            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_UPGRADERECORD->HasAttatch---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelDEV_UPGRADERECORD GetModel(decimal F_DEV_TYPE, string F_DEV_ID, string F_HARDWARE_VERSION, string F_SOFTWARE_VERSION)
        {
            try
            {
                Log.Info("DalDEV_UPGRADERECORD->GetModel---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select F_DEV_TYPE, F_CREATE_TIME, F_OPERATOR_ID, F_OPERATIONTIME, F_DEL, F_DEV_ID, F_DEV_NAME, F_HARDWARE_VERSION, F_SOFTWARE_VERSION, F_UPDATE_DATE, F_USED_DATE,  F_MEMO  ");
                strSql.Append("  from T_DEV_UPGRADERECORD ");
                strSql.Append(" where 1=1 AND  F_DEV_TYPE=:F_DEV_TYPE and F_DEV_ID=:F_DEV_ID and F_HARDWARE_VERSION=:F_HARDWARE_VERSION and F_SOFTWARE_VERSION=:F_SOFTWARE_VERSION ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_DEV_TYPE", OracleType.Number,8),
					new OracleParameter(":F_DEV_ID", OracleType.VarChar,20),
					new OracleParameter(":F_HARDWARE_VERSION", OracleType.VarChar,100),
					new OracleParameter(":F_SOFTWARE_VERSION", OracleType.VarChar,100)			};
                parameters[0].Value = F_DEV_TYPE;
                parameters[1].Value = F_DEV_ID;
                parameters[2].Value = F_HARDWARE_VERSION;
                parameters[3].Value = F_SOFTWARE_VERSION;


                RelayTest.Model.ModelDEV_UPGRADERECORD model = new RelayTest.Model.ModelDEV_UPGRADERECORD();
                DataSet ds = Query(strSql.ToString(), parameters);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0]["F_DEV_TYPE"].ToString() != "")
                    {
                        model.F_DEV_TYPE = decimal.Parse(ds.Tables[0].Rows[0]["F_DEV_TYPE"].ToString());
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
                    model.F_DEV_ID = ds.Tables[0].Rows[0]["F_DEV_ID"].ToString();
                    model.F_DEV_NAME = ds.Tables[0].Rows[0]["F_DEV_NAME"].ToString();
                    model.F_HARDWARE_VERSION = ds.Tables[0].Rows[0]["F_HARDWARE_VERSION"].ToString();
                    model.F_SOFTWARE_VERSION = ds.Tables[0].Rows[0]["F_SOFTWARE_VERSION"].ToString();
                    if (ds.Tables[0].Rows[0]["F_UPDATE_DATE"].ToString() != "")
                    {
                        model.F_UPDATE_DATE = DateTime.Parse(ds.Tables[0].Rows[0]["F_UPDATE_DATE"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_USED_DATE"].ToString() != "")
                    {
                        model.F_USED_DATE = DateTime.Parse(ds.Tables[0].Rows[0]["F_USED_DATE"].ToString());
                    }
                   
                    model.F_MEMO = ds.Tables[0].Rows[0]["F_MEMO"].ToString();

                    return model;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_UPGRADERECORD->GetModel---FAILED", ex);
                throw ex;
            }

        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelDEV_UPGRADERECORD model)
        {

            try
            {
                Log.Info("DalDEV_UPGRADERECORD->Add---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into T_DEV_UPGRADERECORD(");
                strSql.Append("F_DEV_TYPE,F_CREATE_TIME,F_OPERATOR_ID,F_OPERATIONTIME,F_DEL,F_DEV_ID,F_DEV_NAME,F_HARDWARE_VERSION,F_SOFTWARE_VERSION,F_UPDATE_DATE,F_USED_DATE,F_MEMO");
                strSql.Append(") values (");
                strSql.Append(":F_DEV_TYPE,:F_CREATE_TIME,:F_OPERATOR_ID,:F_OPERATIONTIME,:F_DEL,:F_DEV_ID,:F_DEV_NAME,:F_HARDWARE_VERSION,:F_SOFTWARE_VERSION,:F_UPDATE_DATE,:F_USED_DATE,:F_MEMO");
                strSql.Append(") ");

                OracleParameter[] parameters = {
			            new OracleParameter(":F_DEV_TYPE", OracleType.Number,8) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4) ,            
                        new OracleParameter(":F_DEV_ID", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_DEV_NAME", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_HARDWARE_VERSION", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_SOFTWARE_VERSION", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_UPDATE_DATE", OracleType.DateTime) ,            
                        new OracleParameter(":F_USED_DATE", OracleType.DateTime) ,            
                        new OracleParameter(":F_MEMO", OracleType.VarChar,500)             
              
            };

                if (model.F_DEV_TYPE == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_DEV_TYPE;
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

                if (model.F_DEV_ID == null)
                {
                    parameters[5].Value = DBNull.Value;
                }
                else
                {
                    parameters[5].Value = model.F_DEV_ID;
                }

                if (model.F_DEV_NAME == null)
                {
                    parameters[6].Value = DBNull.Value;
                }
                else
                {
                    parameters[6].Value = model.F_DEV_NAME;
                }

                if (model.F_HARDWARE_VERSION == null)
                {
                    parameters[7].Value = DBNull.Value;
                }
                else
                {
                    parameters[7].Value = model.F_HARDWARE_VERSION;
                }

                if (model.F_SOFTWARE_VERSION == null)
                {
                    parameters[8].Value = DBNull.Value;
                }
                else
                {
                    parameters[8].Value = model.F_SOFTWARE_VERSION;
                }

                if (model.F_UPDATE_DATE == null)
                {
                    parameters[9].Value = DBNull.Value;
                }
                else
                {
                    parameters[9].Value = model.F_UPDATE_DATE;
                }

                if (model.F_USED_DATE == null)
                {
                    parameters[10].Value = DBNull.Value;
                }
                else
                {
                    parameters[10].Value = model.F_USED_DATE;
                }

               
                if (model.F_MEMO == null)
                {
                    parameters[11].Value = DBNull.Value;
                }
                else
                {
                    parameters[11].Value = model.F_MEMO;
                }

                ExecuteSql(strSql.ToString(), parameters);

            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_UPGRADERECORD->Add---FAILED", ex);
                throw ex;
            }
        }






        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(RelayTest.Model.ModelDEV_UPGRADERECORD model)
        {

            try
            {
                Log.Info("DalDEV_UPGRADERECORD->Update---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update T_DEV_UPGRADERECORD set ");

                strSql.Append(" F_DEV_TYPE = :F_DEV_TYPE , ");
                strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");
                strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");
                strSql.Append(" F_DEL = :F_DEL , ");
                strSql.Append(" F_DEV_ID = :F_DEV_ID , ");
                strSql.Append(" F_DEV_NAME = :F_DEV_NAME , ");
                strSql.Append(" F_HARDWARE_VERSION = :F_HARDWARE_VERSION , ");
                strSql.Append(" F_SOFTWARE_VERSION = :F_SOFTWARE_VERSION , ");
                strSql.Append(" F_UPDATE_DATE = :F_UPDATE_DATE , ");
                strSql.Append(" F_USED_DATE = :F_USED_DATE , ");
                strSql.Append(" F_MEMO = :F_MEMO  ");
                strSql.Append(
                    " where F_DEV_TYPE=:F_DEV_TYPE and F_DEV_ID=:F_DEV_ID and F_HARDWARE_VERSION=:F_HARDWARE_VERSION and F_SOFTWARE_VERSION=:F_SOFTWARE_VERSION  ");

                OracleParameter[] parameters =
                {

                    new OracleParameter(":F_DEV_TYPE", OracleType.Number, 8),

                    new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar, 10),

                    new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime),

                    new OracleParameter(":F_DEL", OracleType.Number, 4),

                    new OracleParameter(":F_DEV_ID", OracleType.VarChar, 20),

                    new OracleParameter(":F_DEV_NAME", OracleType.VarChar, 100),

                    new OracleParameter(":F_HARDWARE_VERSION", OracleType.VarChar, 100),

                    new OracleParameter(":F_SOFTWARE_VERSION", OracleType.VarChar, 100),

                    new OracleParameter(":F_UPDATE_DATE", OracleType.DateTime),

                    new OracleParameter(":F_USED_DATE", OracleType.DateTime),


                    new OracleParameter(":F_MEMO", OracleType.VarChar, 500)

                };
                if (model.F_DEV_TYPE == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_DEV_TYPE;
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
                if (model.F_DEV_ID == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_DEV_ID;
                }
                if (model.F_DEV_NAME == null)
                {
                    parameters[5].Value = DBNull.Value;
                }
                else
                {
                    parameters[5].Value = model.F_DEV_NAME;
                }
                if (model.F_HARDWARE_VERSION == null)
                {
                    parameters[6].Value = DBNull.Value;
                }
                else
                {
                    parameters[6].Value = model.F_HARDWARE_VERSION;
                }
                if (model.F_SOFTWARE_VERSION == null)
                {
                    parameters[7].Value = DBNull.Value;
                }
                else
                {
                    parameters[7].Value = model.F_SOFTWARE_VERSION;
                }
                if (model.F_UPDATE_DATE == null)
                {
                    parameters[8].Value = DBNull.Value;
                }
                else
                {
                    parameters[8].Value = model.F_UPDATE_DATE;
                }
                if (model.F_USED_DATE == null)
                {
                    parameters[9].Value = DBNull.Value;
                }
                else
                {
                    parameters[9].Value = model.F_USED_DATE;
                }
              
                if (model.F_MEMO == null)
                {
                    parameters[10].Value = DBNull.Value;
                }
                else
                {
                    parameters[10].Value = model.F_MEMO;
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
                Log.Error("DalDEV_UPGRADERECORD->Update---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 上传附件
        /// </summary>
        public bool Upload(RelayTest.Model.ModelDEV_UPGRADERECORD model)
        {

            try
            {
                Log.Info("DalDEV_UPGRADERECORD->Update---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update T_DEV_UPGRADERECORD set ");

                strSql.Append(" F_ATTATCHMENT = :F_ATTATCHMENT , ");
                strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");
                strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID  ");
                strSql.Append(" where F_DEV_TYPE=:F_DEV_TYPE and F_DEV_ID=:F_DEV_ID and F_HARDWARE_VERSION=:F_HARDWARE_VERSION and F_SOFTWARE_VERSION=:F_SOFTWARE_VERSION ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_DEV_TYPE", OracleType.Number,8),
					new OracleParameter(":F_DEV_ID", OracleType.VarChar,20),
					new OracleParameter(":F_HARDWARE_VERSION", OracleType.VarChar,100),
					new OracleParameter(":F_SOFTWARE_VERSION", OracleType.VarChar,100)		,
                                                new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10)     ,        
                     new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,
                      new OracleParameter(":F_ATTATCHMENT", OracleType.Blob) ,            
                                               };
                parameters[0].Value = model.F_DEV_TYPE;
                parameters[1].Value = model.F_DEV_ID;
                parameters[2].Value = model.F_HARDWARE_VERSION;
                parameters[3].Value = model.F_SOFTWARE_VERSION;

              
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
                if (model.F_ATTATCHMENT == null)
                {
                    parameters[6].Value = DBNull.Value;
                }
                else
                {
                    parameters[6].Value = model.F_ATTATCHMENT;
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
                Log.Error("DalDEV_UPGRADERECORD->Update---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 获得附件数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public DataSet GetAttatch(ModelDEV_UPGRADERECORD model)
        {
            try
            {
                Log.Info("DalDEV_UPGRADERECORD->GetAttatch---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select F_ATTATCHMENT from T_DEV_UPGRADERECORD");
                strSql.Append(" where 1=1 AND  F_DEV_TYPE=:F_DEV_TYPE and F_DEV_ID=:F_DEV_ID and F_HARDWARE_VERSION=:F_HARDWARE_VERSION and F_SOFTWARE_VERSION=:F_SOFTWARE_VERSION ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_DEV_TYPE", OracleType.Number,8),
					new OracleParameter(":F_DEV_ID", OracleType.VarChar,20),
					new OracleParameter(":F_HARDWARE_VERSION", OracleType.VarChar,100),
					new OracleParameter(":F_SOFTWARE_VERSION", OracleType.VarChar,100)			};
                parameters[0].Value = model.F_DEV_TYPE;
                parameters[1].Value = model.F_DEV_ID;
                parameters[2].Value = model.F_HARDWARE_VERSION;
                parameters[3].Value = model.F_SOFTWARE_VERSION;


                return Query(strSql.ToString(),parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_UPGRADERECORD->GetAttatch---FAILED", ex);
                throw ex;
            }
        }
        #endregion

       
    }
}

