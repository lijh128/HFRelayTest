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
    //串口设置表
    public partial class DalCOM_SETTINGS : DbHelperOra
    {
        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof (DalCOM_SETTINGS));

        #region Method
        /// <summary>
        ///   是否存在该记录
        /// </summary>
        public bool Exists(string F_WORKSTATION_ID, string F_COM_CODE)
        {
            try
            {
                Log.Info("DalCOM_SETTINGS->Exists---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select count(1) from T_COM_SETTINGS");
                strSql.Append(" where 1=1 and ");
                strSql.Append(" F_WORKSTATION_ID = :F_WORKSTATION_ID and  ");
                strSql.Append(" F_COM_CODE = :F_COM_CODE  ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar,20),
					new OracleParameter(":F_COM_CODE", OracleType.VarChar,20)			};
                parameters[0].Value = F_WORKSTATION_ID;
                parameters[1].Value = F_COM_CODE;

                Log.Info("DalCOM_SETTINGS->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalCOM_SETTINGS->Exists---FAILED", ex);
                throw ex;
            }
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelCOM_SETTINGS model)
        {

            try
            {
                Log.Info("DalCOM_SETTINGS->Add---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into T_COM_SETTINGS(");
                strSql.Append("F_WORKSTATION_ID,F_OPERATOR_ID,F_OPERATIONTIME,F_DEL,F_COM_CODE,F_BAUDRATE,F_DATABIT,F_ODDEVENCHECK,F_STOPBIT,F_TYPE,F_STREAMCONTROL,F_CREATE_TIME");
                strSql.Append(") values (");
                strSql.Append(":F_WORKSTATION_ID,:F_OPERATOR_ID,:F_OPERATIONTIME,:F_DEL,:F_COM_CODE,:F_BAUDRATE,:F_DATABIT,:F_ODDEVENCHECK,:F_STOPBIT,:F_TYPE,:F_STREAMCONTROL,:F_CREATE_TIME");
                strSql.Append(") ");

                OracleParameter[] parameters = {
			            new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4) ,            
                        new OracleParameter(":F_COM_CODE", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_BAUDRATE", OracleType.Number,18) ,            
                        new OracleParameter(":F_DATABIT", OracleType.Number,18) ,            
                        new OracleParameter(":F_ODDEVENCHECK", OracleType.Number,4) ,            
                        new OracleParameter(":F_STOPBIT", OracleType.Number,4) ,            
                        new OracleParameter(":F_TYPE", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_STREAMCONTROL", OracleType.Number,4) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime)             
              
            };

                if (model.F_WORKSTATION_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_WORKSTATION_ID;
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

                if (model.F_COM_CODE == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_COM_CODE;
                }

                if (model.F_BAUDRATE == null)
                {
                    parameters[5].Value = DBNull.Value;
                }
                else
                {
                    parameters[5].Value = model.F_BAUDRATE;
                }

                if (model.F_DATABIT == null)
                {
                    parameters[6].Value = DBNull.Value;
                }
                else
                {
                    parameters[6].Value = model.F_DATABIT;
                }

                if (model.F_ODDEVENCHECK == null)
                {
                    parameters[7].Value = DBNull.Value;
                }
                else
                {
                    parameters[7].Value = model.F_ODDEVENCHECK;
                }

                if (model.F_STOPBIT == null)
                {
                    parameters[8].Value = DBNull.Value;
                }
                else
                {
                    parameters[8].Value = model.F_STOPBIT;
                }

                if (model.F_TYPE == null)
                {
                    parameters[9].Value = DBNull.Value;
                }
                else
                {
                    parameters[9].Value = model.F_TYPE;
                }

                if (model.F_STREAMCONTROL == null)
                {
                    parameters[10].Value = DBNull.Value;
                }
                else
                {
                    parameters[10].Value = model.F_STREAMCONTROL;
                }

                if (model.F_CREATE_TIME == null)
                {
                    parameters[11].Value = DBNull.Value;
                }
                else
                {
                    parameters[11].Value = model.F_CREATE_TIME;
                }

                ExecuteSql(strSql.ToString(), parameters);

            }
            catch (Exception ex)
            {
                Log.Error("DalCOM_SETTINGS->Add---FAILED", ex);
                throw ex;
            }
        }




        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(RelayTest.Model.ModelCOM_SETTINGS model)
        {

            try
            {
                Log.Info("DalCOM_SETTINGS->Update---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update T_COM_SETTINGS set ");

                strSql.Append(" F_WORKSTATION_ID = :F_WORKSTATION_ID , ");
                strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");
                strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");
                strSql.Append(" F_DEL = :F_DEL , ");
                strSql.Append(" F_COM_CODE = :F_COM_CODE , ");
                strSql.Append(" F_BAUDRATE = :F_BAUDRATE , ");
                strSql.Append(" F_DATABIT = :F_DATABIT , ");
                strSql.Append(" F_ODDEVENCHECK = :F_ODDEVENCHECK , ");
                strSql.Append(" F_STOPBIT = :F_STOPBIT , ");
                strSql.Append(" F_TYPE = :F_TYPE , ");
                strSql.Append(" F_STREAMCONTROL = :F_STREAMCONTROL  ");
                strSql.Append(" where F_WORKSTATION_ID=:F_WORKSTATION_ID and F_COM_CODE=:F_COM_CODE  ");

                OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_COM_CODE", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_BAUDRATE", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_DATABIT", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_ODDEVENCHECK", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_STOPBIT", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_TYPE", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_STREAMCONTROL", OracleType.Number,4) ,            
              
            };
                if (model.F_WORKSTATION_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_WORKSTATION_ID;
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
                if (model.F_COM_CODE == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_COM_CODE;
                }
                if (model.F_BAUDRATE == null)
                {
                    parameters[5].Value = DBNull.Value;
                }
                else
                {
                    parameters[5].Value = model.F_BAUDRATE;
                }
                if (model.F_DATABIT == null)
                {
                    parameters[6].Value = DBNull.Value;
                }
                else
                {
                    parameters[6].Value = model.F_DATABIT;
                }
                if (model.F_ODDEVENCHECK == null)
                {
                    parameters[7].Value = DBNull.Value;
                }
                else
                {
                    parameters[7].Value = model.F_ODDEVENCHECK;
                }
                if (model.F_STOPBIT == null)
                {
                    parameters[8].Value = DBNull.Value;
                }
                else
                {
                    parameters[8].Value = model.F_STOPBIT;
                }
                if (model.F_TYPE == null)
                {
                    parameters[9].Value = DBNull.Value;
                }
                else
                {
                    parameters[9].Value = model.F_TYPE;
                }
                if (model.F_STREAMCONTROL == null)
                {
                    parameters[10].Value = DBNull.Value;
                }
                else
                {
                    parameters[10].Value = model.F_STREAMCONTROL;
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
                Log.Error("DalCOM_SETTINGS->Update---FAILED", ex);
                throw ex;
            }




        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_WORKSTATION_ID, string F_COM_CODE)
        {

            try
            {
                Log.Info("DalCOM_SETTINGS->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_COM_SETTINGS  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_WORKSTATION_ID=:F_WORKSTATION_ID and F_COM_CODE=:F_COM_CODE ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar,20),
					new OracleParameter(":F_COM_CODE", OracleType.VarChar,20)			};
                parameters[0].Value = F_WORKSTATION_ID;
                parameters[1].Value = F_COM_CODE;


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
                Log.Error("DalCOM_SETTINGS->Delete---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_WORKSTATION_ID, string F_COM_CODE)
        {

            try
            {
                Log.Info("DalCOM_SETTINGS->Disabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_COM_SETTINGS  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_WORKSTATION_ID=:F_WORKSTATION_ID and F_COM_CODE=:F_COM_CODE ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar,20),
					new OracleParameter(":F_COM_CODE", OracleType.VarChar,20)			};
                parameters[0].Value = F_WORKSTATION_ID;
                parameters[1].Value = F_COM_CODE;


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
                Log.Error("DalCOM_SETTINGS->Disabled---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_WORKSTATION_ID, string F_COM_CODE)
        {

            try
            {
                Log.Info("DalCOM_SETTINGS->Enabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_COM_SETTINGS  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_WORKSTATION_ID=:F_WORKSTATION_ID and F_COM_CODE=:F_COM_CODE ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar,20),
					new OracleParameter(":F_COM_CODE", OracleType.VarChar,20)			};
                parameters[0].Value = F_WORKSTATION_ID;
                parameters[1].Value = F_COM_CODE;


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
                Log.Error("DalCOM_SETTINGS->Enabled---FAILED", ex);
                throw ex;
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool Drop(string F_WORKSTATION_ID, string F_COM_CODE)
        {

            try
            {
                Log.Info("DalCOM_SETTINGS->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM  T_COM_SETTINGS  ");
                strSql.Append(" where F_WORKSTATION_ID=:F_WORKSTATION_ID and F_COM_CODE=:F_COM_CODE ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar,20),
					new OracleParameter(":F_COM_CODE", OracleType.VarChar,20)			};
                parameters[0].Value = F_WORKSTATION_ID;
                parameters[1].Value = F_COM_CODE;


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
                Log.Error("DalCOM_SETTINGS->Delete---FAILED", ex);
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
                Log.Info("DalCOM_SETTINGS->DeleteWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_COM_SETTINGS  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalCOM_SETTINGS->DeleteWhere---FAILED", ex);
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
                Log.Info("DalCOM_SETTINGS->DropWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("delete from  T_COM_SETTINGS  ");
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
                Log.Error("DalCOM_SETTINGS->DropWhere---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelCOM_SETTINGS GetModel(string F_WORKSTATION_ID, string F_COM_CODE)
        {
            try
            {
                Log.Info("DalCOM_SETTINGS->GetModel---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select F_WORKSTATION_ID, F_OPERATOR_ID, F_OPERATIONTIME, F_DEL, F_COM_CODE, F_BAUDRATE, F_DATABIT, F_ODDEVENCHECK, F_STOPBIT, F_TYPE, F_STREAMCONTROL, F_CREATE_TIME  ");
                strSql.Append("  from T_COM_SETTINGS ");
                strSql.Append(" where 1=1 AND  F_WORKSTATION_ID=:F_WORKSTATION_ID and F_COM_CODE=:F_COM_CODE ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar,20),
					new OracleParameter(":F_COM_CODE", OracleType.VarChar,20)			};
                parameters[0].Value = F_WORKSTATION_ID;
                parameters[1].Value = F_COM_CODE;


                RelayTest.Model.ModelCOM_SETTINGS model = new RelayTest.Model.ModelCOM_SETTINGS();
                DataSet ds = Query(strSql.ToString(), parameters);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    model.F_WORKSTATION_ID = ds.Tables[0].Rows[0]["F_WORKSTATION_ID"].ToString();
                    model.F_OPERATOR_ID = ds.Tables[0].Rows[0]["F_OPERATOR_ID"].ToString();
                    if (ds.Tables[0].Rows[0]["F_OPERATIONTIME"].ToString() != "")
                    {
                        model.F_OPERATIONTIME = DateTime.Parse(ds.Tables[0].Rows[0]["F_OPERATIONTIME"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_DEL"].ToString() != "")
                    {
                        model.F_DEL = decimal.Parse(ds.Tables[0].Rows[0]["F_DEL"].ToString());
                    }
                    model.F_COM_CODE = ds.Tables[0].Rows[0]["F_COM_CODE"].ToString();
                    if (ds.Tables[0].Rows[0]["F_BAUDRATE"].ToString() != "")
                    {
                        model.F_BAUDRATE = decimal.Parse(ds.Tables[0].Rows[0]["F_BAUDRATE"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_DATABIT"].ToString() != "")
                    {
                        model.F_DATABIT = decimal.Parse(ds.Tables[0].Rows[0]["F_DATABIT"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_ODDEVENCHECK"].ToString() != "")
                    {
                        model.F_ODDEVENCHECK = decimal.Parse(ds.Tables[0].Rows[0]["F_ODDEVENCHECK"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_STOPBIT"].ToString() != "")
                    {
                        model.F_STOPBIT = decimal.Parse(ds.Tables[0].Rows[0]["F_STOPBIT"].ToString());
                    }
                    model.F_TYPE = ds.Tables[0].Rows[0]["F_TYPE"].ToString();
                    if (ds.Tables[0].Rows[0]["F_STREAMCONTROL"].ToString() != "")
                    {
                        model.F_STREAMCONTROL = decimal.Parse(ds.Tables[0].Rows[0]["F_STREAMCONTROL"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_CREATE_TIME"].ToString() != "")
                    {
                        model.F_CREATE_TIME = DateTime.Parse(ds.Tables[0].Rows[0]["F_CREATE_TIME"].ToString());
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
                Log.Error("DalCOM_SETTINGS->GetModel---FAILED", ex);
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
                Log.Info("DalCOM_SETTINGS->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM T_COM_SETTINGS  where 1=1");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalCOM_SETTINGS->GetList---FAILED", ex);
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
                Log.Info("DalCOM_SETTINGS->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                if (Top > 0)
                {
                    strSql.Append(" top " + Top.ToString());
                }
                strSql.Append(" * ");
                strSql.Append(" FROM T_COM_SETTINGS  where F_DEL=0 ");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                strSql.Append(" order by " + filedOrder);
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalCOM_SETTINGS->GetList---FAILED", ex);
                throw ex;
            }

        }
        #endregion Method
    }
}