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
    //负载电源基本信息
    public partial class DalDEV_LOADPOWER_INFO : DbHelperOra
    {


        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalDEV_LOADPOWER_INFO));

        #region Method
        /// <summary>
        ///   是否存在该记录
        /// </summary>
        public new bool Exists(string F_LOADPOWER_ID)
        {
            try
            {
                Log.Info("DalDEV_LOADPOWER_INFO->Exists---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select count(1) from T_DEV_LOADPOWER_INFO");
                strSql.Append(" where 1=1 and ");
                strSql.Append(" F_LOADPOWER_ID = :F_LOADPOWER_ID  ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_LOADPOWER_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_LOADPOWER_ID;

                Log.Info("DalDEV_LOADPOWER_INFO->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_LOADPOWER_INFO->Exists---FAILED", ex);
                throw ex;
            }
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelDEV_LOADPOWER_INFO model)
        {

            try
            {
                Log.Info("DalDEV_LOADPOWER_INFO->Add---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into T_DEV_LOADPOWER_INFO(");
                strSql.Append("F_LOADPOWER_ID,F_LOADPOWER_FREQUENCY_CEILING,F_LOADPOWER_FREQUENCY_FLOOR,F_LOADPOWER_POWER,F_LOADPOWER_RUN_STATUS,F_LOADPOWER_MEMO,F_CREATE_TIME,F_OPERATOR_ID,F_OPERATIONTIME,F_DEL,F_LOADPOWER_NAME,F_LOADPOWER_CALIBRATION,F_COM_ADDRESS,F_LOADPOWER_ADDRESS,F_LOADPOWER_VOLTAGE_CEILING,F_LOADPOWER_VOLTAGE_FLOOR,F_LOADPOWER_CURRENT_CEILING,F_LOADPOWER_CURRENT_FLOOR");
                strSql.Append(") values (");
                strSql.Append(":F_LOADPOWER_ID,:F_LOADPOWER_FREQUENCY_CEILING,:F_LOADPOWER_FREQUENCY_FLOOR,:F_LOADPOWER_POWER,:F_LOADPOWER_RUN_STATUS,:F_LOADPOWER_MEMO,:F_CREATE_TIME,:F_OPERATOR_ID,:F_OPERATIONTIME,:F_DEL,:F_LOADPOWER_NAME,:F_LOADPOWER_CALIBRATION,:F_COM_ADDRESS,:F_LOADPOWER_ADDRESS,:F_LOADPOWER_VOLTAGE_CEILING,:F_LOADPOWER_VOLTAGE_FLOOR,:F_LOADPOWER_CURRENT_CEILING,:F_LOADPOWER_CURRENT_FLOOR");
                strSql.Append(") ");

                OracleParameter[] parameters = {
			            new OracleParameter(":F_LOADPOWER_ID", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_LOADPOWER_FREQUENCY_CEILING", OracleType.Number,18) ,            
                        new OracleParameter(":F_LOADPOWER_FREQUENCY_FLOOR", OracleType.Number,18) ,            
                        new OracleParameter(":F_LOADPOWER_POWER", OracleType.Number,18) ,            
                        new OracleParameter(":F_LOADPOWER_RUN_STATUS", OracleType.Number,4) ,            
                        new OracleParameter(":F_LOADPOWER_MEMO", OracleType.VarChar,500) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4) ,            
                        new OracleParameter(":F_LOADPOWER_NAME", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_LOADPOWER_CALIBRATION", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_COM_ADDRESS", OracleType.VarChar,500) ,            
                        new OracleParameter(":F_LOADPOWER_ADDRESS", OracleType.Number,4) ,            
                        new OracleParameter(":F_LOADPOWER_VOLTAGE_CEILING", OracleType.Number,18) ,            
                        new OracleParameter(":F_LOADPOWER_VOLTAGE_FLOOR", OracleType.Number,18) ,            
                        new OracleParameter(":F_LOADPOWER_CURRENT_CEILING", OracleType.Number,18) ,            
                        new OracleParameter(":F_LOADPOWER_CURRENT_FLOOR", OracleType.Number,18)             
              
            };

                if (model.F_LOADPOWER_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_LOADPOWER_ID;
                }

                if (model.F_LOADPOWER_FREQUENCY_CEILING == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_LOADPOWER_FREQUENCY_CEILING;
                }

                if (model.F_LOADPOWER_FREQUENCY_FLOOR == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_LOADPOWER_FREQUENCY_FLOOR;
                }

                if (model.F_LOADPOWER_POWER == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_LOADPOWER_POWER;
                }

                if (model.F_LOADPOWER_RUN_STATUS == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_LOADPOWER_RUN_STATUS;
                }

                if (model.F_LOADPOWER_MEMO == null)
                {
                    parameters[5].Value = DBNull.Value;
                }
                else
                {
                    parameters[5].Value = model.F_LOADPOWER_MEMO;
                }

                if (model.F_CREATE_TIME == null)
                {
                    parameters[6].Value = DBNull.Value;
                }
                else
                {
                    parameters[6].Value = model.F_CREATE_TIME;
                }

                if (model.F_OPERATOR_ID == null)
                {
                    parameters[7].Value = DBNull.Value;
                }
                else
                {
                    parameters[7].Value = model.F_OPERATOR_ID;
                }

                if (model.F_OPERATIONTIME == null)
                {
                    parameters[8].Value = DBNull.Value;
                }
                else
                {
                    parameters[8].Value = model.F_OPERATIONTIME;
                }

                if (model.F_DEL == null)
                {
                    parameters[9].Value = DBNull.Value;
                }
                else
                {
                    parameters[9].Value = model.F_DEL;
                }

                if (model.F_LOADPOWER_NAME == null)
                {
                    parameters[10].Value = DBNull.Value;
                }
                else
                {
                    parameters[10].Value = model.F_LOADPOWER_NAME;
                }

                if (model.F_LOADPOWER_CALIBRATION == null)
                {
                    parameters[11].Value = DBNull.Value;
                }
                else
                {
                    parameters[11].Value = model.F_LOADPOWER_CALIBRATION;
                }

                if (model.F_COM_ADDRESS == null)
                {
                    parameters[12].Value = DBNull.Value;
                }
                else
                {
                    parameters[12].Value = model.F_COM_ADDRESS;
                }

                if (model.F_LOADPOWER_ADDRESS == null)
                {
                    parameters[13].Value = DBNull.Value;
                }
                else
                {
                    parameters[13].Value = model.F_LOADPOWER_ADDRESS;
                }

                if (model.F_LOADPOWER_VOLTAGE_CEILING == null)
                {
                    parameters[14].Value = DBNull.Value;
                }
                else
                {
                    parameters[14].Value = model.F_LOADPOWER_VOLTAGE_CEILING;
                }

                if (model.F_LOADPOWER_VOLTAGE_FLOOR == null)
                {
                    parameters[15].Value = DBNull.Value;
                }
                else
                {
                    parameters[15].Value = model.F_LOADPOWER_VOLTAGE_FLOOR;
                }

                if (model.F_LOADPOWER_CURRENT_CEILING == null)
                {
                    parameters[16].Value = DBNull.Value;
                }
                else
                {
                    parameters[16].Value = model.F_LOADPOWER_CURRENT_CEILING;
                }

                if (model.F_LOADPOWER_CURRENT_FLOOR == null)
                {
                    parameters[17].Value = DBNull.Value;
                }
                else
                {
                    parameters[17].Value = model.F_LOADPOWER_CURRENT_FLOOR;
                }

                ExecuteSql(strSql.ToString(), parameters);

            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_LOADPOWER_INFO->Add---FAILED", ex);
                throw ex;
            }
        }




        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(RelayTest.Model.ModelDEV_LOADPOWER_INFO model)
        {

            try
            {
                Log.Info("DalDEV_LOADPOWER_INFO->Update---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update T_DEV_LOADPOWER_INFO set ");

                strSql.Append(" F_LOADPOWER_ID = :F_LOADPOWER_ID , ");
                strSql.Append(" F_LOADPOWER_FREQUENCY_CEILING = :F_LOADPOWER_FREQUENCY_CEILING , ");
                strSql.Append(" F_LOADPOWER_FREQUENCY_FLOOR = :F_LOADPOWER_FREQUENCY_FLOOR , ");
                strSql.Append(" F_LOADPOWER_POWER = :F_LOADPOWER_POWER , ");
                strSql.Append(" F_LOADPOWER_RUN_STATUS = :F_LOADPOWER_RUN_STATUS , ");
                strSql.Append(" F_LOADPOWER_MEMO = :F_LOADPOWER_MEMO , ");
                strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");
                strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");
                strSql.Append(" F_DEL = :F_DEL , ");
                strSql.Append(" F_LOADPOWER_NAME = :F_LOADPOWER_NAME , ");
                strSql.Append(" F_LOADPOWER_CALIBRATION = :F_LOADPOWER_CALIBRATION , ");
                strSql.Append(" F_COM_ADDRESS = :F_COM_ADDRESS , ");
                strSql.Append(" F_LOADPOWER_ADDRESS = :F_LOADPOWER_ADDRESS , ");
                strSql.Append(" F_LOADPOWER_VOLTAGE_CEILING = :F_LOADPOWER_VOLTAGE_CEILING , ");
                strSql.Append(" F_LOADPOWER_VOLTAGE_FLOOR = :F_LOADPOWER_VOLTAGE_FLOOR , ");
                strSql.Append(" F_LOADPOWER_CURRENT_CEILING = :F_LOADPOWER_CURRENT_CEILING , ");
                strSql.Append(" F_LOADPOWER_CURRENT_FLOOR = :F_LOADPOWER_CURRENT_FLOOR  ");
                strSql.Append(" where F_LOADPOWER_ID=:F_LOADPOWER_ID  ");

                OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_LOADPOWER_ID", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_LOADPOWER_FREQUENCY_CEILING", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_LOADPOWER_FREQUENCY_FLOOR", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_LOADPOWER_POWER", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_LOADPOWER_RUN_STATUS", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_LOADPOWER_MEMO", OracleType.VarChar,500) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_LOADPOWER_NAME", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_LOADPOWER_CALIBRATION", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_COM_ADDRESS", OracleType.VarChar,500) ,            
                        	
            new OracleParameter(":F_LOADPOWER_ADDRESS", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_LOADPOWER_VOLTAGE_CEILING", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_LOADPOWER_VOLTAGE_FLOOR", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_LOADPOWER_CURRENT_CEILING", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_LOADPOWER_CURRENT_FLOOR", OracleType.Number,18)             
              
            };
                if (model.F_LOADPOWER_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_LOADPOWER_ID;
                }
                if (model.F_LOADPOWER_FREQUENCY_CEILING == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_LOADPOWER_FREQUENCY_CEILING;
                }
                if (model.F_LOADPOWER_FREQUENCY_FLOOR == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_LOADPOWER_FREQUENCY_FLOOR;
                }
                if (model.F_LOADPOWER_POWER == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_LOADPOWER_POWER;
                }
                if (model.F_LOADPOWER_RUN_STATUS == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_LOADPOWER_RUN_STATUS;
                }
                if (model.F_LOADPOWER_MEMO == null)
                {
                    parameters[5].Value = DBNull.Value;
                }
                else
                {
                    parameters[5].Value = model.F_LOADPOWER_MEMO;
                }
                if (model.F_OPERATOR_ID == null)
                {
                    parameters[6].Value = DBNull.Value;
                }
                else
                {
                    parameters[6].Value = model.F_OPERATOR_ID;
                }
                if (model.F_OPERATIONTIME == null)
                {
                    parameters[7].Value = DBNull.Value;
                }
                else
                {
                    parameters[7].Value = model.F_OPERATIONTIME;
                }
                if (model.F_DEL == null)
                {
                    parameters[8].Value = DBNull.Value;
                }
                else
                {
                    parameters[8].Value = model.F_DEL;
                }
                if (model.F_LOADPOWER_NAME == null)
                {
                    parameters[9].Value = DBNull.Value;
                }
                else
                {
                    parameters[9].Value = model.F_LOADPOWER_NAME;
                }
                if (model.F_LOADPOWER_CALIBRATION == null)
                {
                    parameters[10].Value = DBNull.Value;
                }
                else
                {
                    parameters[10].Value = model.F_LOADPOWER_CALIBRATION;
                }
                if (model.F_COM_ADDRESS == null)
                {
                    parameters[11].Value = DBNull.Value;
                }
                else
                {
                    parameters[11].Value = model.F_COM_ADDRESS;
                }
                if (model.F_LOADPOWER_ADDRESS == null)
                {
                    parameters[12].Value = DBNull.Value;
                }
                else
                {
                    parameters[12].Value = model.F_LOADPOWER_ADDRESS;
                }
                if (model.F_LOADPOWER_VOLTAGE_CEILING == null)
                {
                    parameters[13].Value = DBNull.Value;
                }
                else
                {
                    parameters[13].Value = model.F_LOADPOWER_VOLTAGE_CEILING;
                }
                if (model.F_LOADPOWER_VOLTAGE_FLOOR == null)
                {
                    parameters[14].Value = DBNull.Value;
                }
                else
                {
                    parameters[14].Value = model.F_LOADPOWER_VOLTAGE_FLOOR;
                }
                if (model.F_LOADPOWER_CURRENT_CEILING == null)
                {
                    parameters[15].Value = DBNull.Value;
                }
                else
                {
                    parameters[15].Value = model.F_LOADPOWER_CURRENT_CEILING;
                }
                if (model.F_LOADPOWER_CURRENT_FLOOR == null)
                {
                    parameters[16].Value = DBNull.Value;
                }
                else
                {
                    parameters[16].Value = model.F_LOADPOWER_CURRENT_FLOOR;
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
                Log.Error("DalDEV_LOADPOWER_INFO->Update---FAILED", ex);
                throw ex;
            }




        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_LOADPOWER_ID)
        {

            try
            {
                Log.Info("DalDEV_LOADPOWER_INFO->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_LOADPOWER_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_LOADPOWER_ID=:F_LOADPOWER_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_LOADPOWER_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_LOADPOWER_ID;


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
                Log.Error("DalDEV_LOADPOWER_INFO->Delete---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_LOADPOWER_ID)
        {

            try
            {
                Log.Info("DalDEV_LOADPOWER_INFO->Disabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_LOADPOWER_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_LOADPOWER_ID=:F_LOADPOWER_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_LOADPOWER_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_LOADPOWER_ID;


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
                Log.Error("DalDEV_LOADPOWER_INFO->Disabled---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_LOADPOWER_ID)
        {

            try
            {
                Log.Info("DalDEV_LOADPOWER_INFO->Enabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_LOADPOWER_INFO  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_LOADPOWER_ID=:F_LOADPOWER_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_LOADPOWER_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_LOADPOWER_ID;


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
                Log.Error("DalDEV_LOADPOWER_INFO->Enabled---FAILED", ex);
                throw ex;
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool Drop(string F_LOADPOWER_ID)
        {

            try
            {
                Log.Info("DalDEV_LOADPOWER_INFO->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM  T_DEV_LOADPOWER_INFO  ");
                strSql.Append(" where F_LOADPOWER_ID=:F_LOADPOWER_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_LOADPOWER_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_LOADPOWER_ID;


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
                Log.Error("DalDEV_LOADPOWER_INFO->Delete---FAILED", ex);
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
                Log.Info("DalDEV_LOADPOWER_INFO->DeleteWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_LOADPOWER_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalDEV_LOADPOWER_INFO->DeleteWhere---FAILED", ex);
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
                Log.Info("DalDEV_LOADPOWER_INFO->DropWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("delete from  T_DEV_LOADPOWER_INFO  ");
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
                Log.Error("DalDEV_LOADPOWER_INFO->DropWhere---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelDEV_LOADPOWER_INFO GetModel(string F_LOADPOWER_ID)
        {
            try
            {
                Log.Info("DalDEV_LOADPOWER_INFO->GetModel---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select F_LOADPOWER_ID, F_LOADPOWER_FREQUENCY_CEILING, F_LOADPOWER_FREQUENCY_FLOOR, F_LOADPOWER_POWER, F_LOADPOWER_RUN_STATUS, F_LOADPOWER_MEMO, F_CREATE_TIME, F_OPERATOR_ID, F_OPERATIONTIME, F_DEL, F_LOADPOWER_NAME, F_LOADPOWER_CALIBRATION, F_COM_ADDRESS, F_LOADPOWER_ADDRESS, F_LOADPOWER_VOLTAGE_CEILING, F_LOADPOWER_VOLTAGE_FLOOR, F_LOADPOWER_CURRENT_CEILING, F_LOADPOWER_CURRENT_FLOOR  ");
                strSql.Append("  from T_DEV_LOADPOWER_INFO ");
                strSql.Append(" where 1=1 AND  F_LOADPOWER_ID=:F_LOADPOWER_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_LOADPOWER_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_LOADPOWER_ID;


                RelayTest.Model.ModelDEV_LOADPOWER_INFO model = new RelayTest.Model.ModelDEV_LOADPOWER_INFO();
                DataSet ds = Query(strSql.ToString(), parameters);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    model.F_LOADPOWER_ID = ds.Tables[0].Rows[0]["F_LOADPOWER_ID"].ToString();
                    if (ds.Tables[0].Rows[0]["F_LOADPOWER_FREQUENCY_CEILING"].ToString() != "")
                    {
                        model.F_LOADPOWER_FREQUENCY_CEILING = decimal.Parse(ds.Tables[0].Rows[0]["F_LOADPOWER_FREQUENCY_CEILING"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_LOADPOWER_FREQUENCY_FLOOR"].ToString() != "")
                    {
                        model.F_LOADPOWER_FREQUENCY_FLOOR = decimal.Parse(ds.Tables[0].Rows[0]["F_LOADPOWER_FREQUENCY_FLOOR"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_LOADPOWER_POWER"].ToString() != "")
                    {
                        model.F_LOADPOWER_POWER = decimal.Parse(ds.Tables[0].Rows[0]["F_LOADPOWER_POWER"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_LOADPOWER_RUN_STATUS"].ToString() != "")
                    {
                        model.F_LOADPOWER_RUN_STATUS = decimal.Parse(ds.Tables[0].Rows[0]["F_LOADPOWER_RUN_STATUS"].ToString());
                    }
                    model.F_LOADPOWER_MEMO = ds.Tables[0].Rows[0]["F_LOADPOWER_MEMO"].ToString();
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
                    model.F_LOADPOWER_NAME = ds.Tables[0].Rows[0]["F_LOADPOWER_NAME"].ToString();
                    model.F_LOADPOWER_CALIBRATION = ds.Tables[0].Rows[0]["F_LOADPOWER_CALIBRATION"].ToString();
                    model.F_COM_ADDRESS = ds.Tables[0].Rows[0]["F_COM_ADDRESS"].ToString();
                    if (ds.Tables[0].Rows[0]["F_LOADPOWER_ADDRESS"].ToString() != "")
                    {
                        model.F_LOADPOWER_ADDRESS = decimal.Parse(ds.Tables[0].Rows[0]["F_LOADPOWER_ADDRESS"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_LOADPOWER_VOLTAGE_CEILING"].ToString() != "")
                    {
                        model.F_LOADPOWER_VOLTAGE_CEILING = decimal.Parse(ds.Tables[0].Rows[0]["F_LOADPOWER_VOLTAGE_CEILING"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_LOADPOWER_VOLTAGE_FLOOR"].ToString() != "")
                    {
                        model.F_LOADPOWER_VOLTAGE_FLOOR = decimal.Parse(ds.Tables[0].Rows[0]["F_LOADPOWER_VOLTAGE_FLOOR"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_LOADPOWER_CURRENT_CEILING"].ToString() != "")
                    {
                        model.F_LOADPOWER_CURRENT_CEILING = decimal.Parse(ds.Tables[0].Rows[0]["F_LOADPOWER_CURRENT_CEILING"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_LOADPOWER_CURRENT_FLOOR"].ToString() != "")
                    {
                        model.F_LOADPOWER_CURRENT_FLOOR = decimal.Parse(ds.Tables[0].Rows[0]["F_LOADPOWER_CURRENT_FLOOR"].ToString());
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
                Log.Error("DalDEV_LOADPOWER_INFO->GetModel---FAILED", ex);
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
                Log.Info("DalDEV_LOADPOWER_INFO->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM T_DEV_LOADPOWER_INFO  where 1=1");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_LOADPOWER_INFO->GetList---FAILED", ex);
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
                Log.Info("DalDEV_LOADPOWER_INFO->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                if (Top > 0)
                {
                    strSql.Append(" top " + Top.ToString());
                }
                strSql.Append(" * ");
                strSql.Append(" FROM T_DEV_LOADPOWER_INFO  where F_DEL=0 ");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                strSql.Append(" order by " + filedOrder);
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_LOADPOWER_INFO->GetList---FAILED", ex);
                throw ex;
            }

        }
        #endregion Method


    }
}

