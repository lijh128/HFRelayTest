using System;
using System.Data.OracleClient;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using RelayTest.Util.DBUtility;
using log4net;
using RelayTest.Model;

namespace RelayTest.DAL
{
    //负载柜基本信息
    public partial class DalDEV_LOAD_INFO : DbHelperOra
    {


        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalDEV_LOAD_INFO));

        #region Method
        /// <summary>
        ///   是否存在该记录
        /// </summary>
        public new bool Exists(string F_LOAD_ID)
        {
            try
            {
                Log.Info("DalDEV_LOAD_INFO->Exists---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select count(1) from T_DEV_LOAD_INFO");
                strSql.Append(" where 1=1 and ");
                strSql.Append(" F_LOAD_ID = :F_LOAD_ID  ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_LOAD_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_LOAD_ID;

                Log.Info("DalDEV_LOAD_INFO->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_LOAD_INFO->Exists---FAILED", ex);
                throw ex;
            }
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelDEV_LOAD_INFO model)
        {

            try
            {
                Log.Info("DalDEV_LOAD_INFO->Add---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into T_DEV_LOAD_INFO(");

                //负载柜编号
                strSql.Append("  F_LOAD_ID,");
                //稳态电流下限
                strSql.Append("  F_LOAD_STABLECURRENT_FLOOR,");
                //冲击电流上限
                strSql.Append("  F_LOAD_PULSECURRENT_CEILING,");
                //冲击电流下限
                strSql.Append("  F_LOAD_PULSECURRENT_FLOOR,");
                //负载电压上限
                strSql.Append("  F_LOAD_VOLTAGE_CEILING,");
                //负载电压下限
                strSql.Append("  F_LOAD_VOLTAGE_FLOOR,");
                //描述信息
                strSql.Append("  F_LOAD_DESCRIPTION,");
                //创建时间
                strSql.Append("  F_CREATE_TIME,");
                //操作员
                strSql.Append("  F_OPERATOR_ID,");
                //操作时间
                strSql.Append("  F_OPERATIONTIME,");
                //是否删除
                strSql.Append("  F_DEL,");
                //负载柜名称
                strSql.Append("  F_LOAD_NAME,");
                //校准编号
                strSql.Append("  F_LOAD_CALIBRATION,");
                //负载柜位置
                strSql.Append("  F_LOAD_POSTION,");
                //资产编号
                strSql.Append("  F_PROPERTY_ID,");
                //负载类型
                strSql.Append("  F_LOAD_TYPE,");
                //感性负载功率因素
                strSql.Append("  F_CONDUCTYLOAD_COEFFECIENCY,");
                //负载电压类型
                strSql.Append("  F_LOAD_VOLTAGE_TYPE,");
                //稳态电流上限
                strSql.Append("  F_LOAD_STABLECURRENT_CEILING");
                strSql.Append(") values (");
                strSql.Append(" :F_LOAD_ID,");
                strSql.Append(" :F_LOAD_STABLECURRENT_FLOOR,");
                strSql.Append(" :F_LOAD_PULSECURRENT_CEILING,");
                strSql.Append(" :F_LOAD_PULSECURRENT_FLOOR,");
                strSql.Append(" :F_LOAD_VOLTAGE_CEILING,");
                strSql.Append(" :F_LOAD_VOLTAGE_FLOOR,");
                strSql.Append(" :F_LOAD_DESCRIPTION,");
                strSql.Append(" :F_CREATE_TIME,");
                strSql.Append(" :F_OPERATOR_ID,");
                strSql.Append(" :F_OPERATIONTIME,");
                strSql.Append(" :F_DEL,");
                strSql.Append(" :F_LOAD_NAME,");
                strSql.Append(" :F_LOAD_CALIBRATION,");
                strSql.Append(" :F_LOAD_POSTION,");
                strSql.Append(" :F_PROPERTY_ID,");
                strSql.Append(" :F_LOAD_TYPE,");
                strSql.Append(" :F_CONDUCTYLOAD_COEFFECIENCY,");
                strSql.Append(" :F_LOAD_VOLTAGE_TYPE,");
                strSql.Append(" :F_LOAD_STABLECURRENT_CEILING");
                strSql.Append(") ");

                OracleParameter[] parameters = {
			            new OracleParameter(":F_LOAD_ID", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_LOAD_STABLECURRENT_FLOOR", OracleType.Number,18) ,            
                        new OracleParameter(":F_LOAD_PULSECURRENT_CEILING", OracleType.Number,18) ,            
                        new OracleParameter(":F_LOAD_PULSECURRENT_FLOOR", OracleType.Number,18) ,            
                        new OracleParameter(":F_LOAD_VOLTAGE_CEILING", OracleType.Number,18) ,            
                        new OracleParameter(":F_LOAD_VOLTAGE_FLOOR", OracleType.Number,18) ,            
                        new OracleParameter(":F_LOAD_DESCRIPTION", OracleType.VarChar,500) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4) ,            
                        new OracleParameter(":F_LOAD_NAME", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_LOAD_CALIBRATION", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_LOAD_POSTION", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_PROPERTY_ID", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_LOAD_TYPE", OracleType.Number,4) ,            
                        new OracleParameter(":F_CONDUCTYLOAD_COEFFECIENCY", OracleType.Number,18) ,            
                        new OracleParameter(":F_LOAD_VOLTAGE_TYPE", OracleType.Number,4) ,            
                        new OracleParameter(":F_LOAD_STABLECURRENT_CEILING", OracleType.Number,18)             
              
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

                //稳态电流下限
                if (model.F_LOAD_STABLECURRENT_FLOOR == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_LOAD_STABLECURRENT_FLOOR;
                }

                //冲击电流上限
                if (model.F_LOAD_PULSECURRENT_CEILING == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_LOAD_PULSECURRENT_CEILING;
                }

                //冲击电流下限
                if (model.F_LOAD_PULSECURRENT_FLOOR == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_LOAD_PULSECURRENT_FLOOR;
                }

                //负载电压上限
                if (model.F_LOAD_VOLTAGE_CEILING == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_LOAD_VOLTAGE_CEILING;
                }

                //负载电压下限
                if (model.F_LOAD_VOLTAGE_FLOOR == null)
                {
                    parameters[5].Value = DBNull.Value;
                }
                else
                {
                    parameters[5].Value = model.F_LOAD_VOLTAGE_FLOOR;
                }

                //描述信息
                if (model.F_LOAD_DESCRIPTION == null)
                {
                    parameters[6].Value = DBNull.Value;
                }
                else
                {
                    parameters[6].Value = model.F_LOAD_DESCRIPTION;
                }

                //创建时间
                if (model.F_CREATE_TIME == null)
                {
                    parameters[7].Value = DBNull.Value;
                }
                else
                {
                    parameters[7].Value = model.F_CREATE_TIME;
                }

                //操作员
                if (model.F_OPERATOR_ID == null)
                {
                    parameters[8].Value = DBNull.Value;
                }
                else
                {
                    parameters[8].Value = model.F_OPERATOR_ID;
                }

                //操作时间
                if (model.F_OPERATIONTIME == null)
                {
                    parameters[9].Value = DBNull.Value;
                }
                else
                {
                    parameters[9].Value = model.F_OPERATIONTIME;
                }

                //是否删除
                if (model.F_DEL == null)
                {
                    parameters[10].Value = DBNull.Value;
                }
                else
                {
                    parameters[10].Value = model.F_DEL;
                }

                //负载柜名称
                if (model.F_LOAD_NAME == null)
                {
                    parameters[11].Value = DBNull.Value;
                }
                else
                {
                    parameters[11].Value = model.F_LOAD_NAME;
                }

                //校准编号
                if (model.F_LOAD_CALIBRATION == null)
                {
                    parameters[12].Value = DBNull.Value;
                }
                else
                {
                    parameters[12].Value = model.F_LOAD_CALIBRATION;
                }

                //负载柜位置
                if (model.F_LOAD_POSTION == null)
                {
                    parameters[13].Value = DBNull.Value;
                }
                else
                {
                    parameters[13].Value = model.F_LOAD_POSTION;
                }

                //资产编号
                if (model.F_PROPERTY_ID == null)
                {
                    parameters[14].Value = DBNull.Value;
                }
                else
                {
                    parameters[14].Value = model.F_PROPERTY_ID;
                }

                //负载类型
                if (model.F_LOAD_TYPE == null)
                {
                    parameters[15].Value = DBNull.Value;
                }
                else
                {
                    parameters[15].Value = model.F_LOAD_TYPE;
                }

                //感性负载功率因素
                if (model.F_CONDUCTYLOAD_COEFFECIENCY == null)
                {
                    parameters[16].Value = DBNull.Value;
                }
                else
                {
                    parameters[16].Value = model.F_CONDUCTYLOAD_COEFFECIENCY;
                }

                //负载电压类型
                if (model.F_LOAD_VOLTAGE_TYPE == null)
                {
                    parameters[17].Value = DBNull.Value;
                }
                else
                {
                    parameters[17].Value = model.F_LOAD_VOLTAGE_TYPE;
                }

                //稳态电流上限
                if (model.F_LOAD_STABLECURRENT_CEILING == null)
                {
                    parameters[18].Value = DBNull.Value;
                }
                else
                {
                    parameters[18].Value = model.F_LOAD_STABLECURRENT_CEILING;
                }

                ExecuteSql(strSql.ToString(), parameters);

            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_LOAD_INFO->Add---FAILED", ex);
                throw ex;
            }
        }




        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(RelayTest.Model.ModelDEV_LOAD_INFO model)
        {

            try
            {
                Log.Info("DalDEV_LOAD_INFO->Update---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update T_DEV_LOAD_INFO set ");

                //负载柜编号
                strSql.Append(" F_LOAD_ID = :F_LOAD_ID , ");

                //稳态电流下限
                strSql.Append(" F_LOAD_STABLECURRENT_FLOOR = :F_LOAD_STABLECURRENT_FLOOR , ");

                //冲击电流上限
                strSql.Append(" F_LOAD_PULSECURRENT_CEILING = :F_LOAD_PULSECURRENT_CEILING , ");

                //冲击电流下限
                strSql.Append(" F_LOAD_PULSECURRENT_FLOOR = :F_LOAD_PULSECURRENT_FLOOR , ");

                //负载电压上限
                strSql.Append(" F_LOAD_VOLTAGE_CEILING = :F_LOAD_VOLTAGE_CEILING , ");

                //负载电压下限
                strSql.Append(" F_LOAD_VOLTAGE_FLOOR = :F_LOAD_VOLTAGE_FLOOR , ");

                //描述信息
                strSql.Append(" F_LOAD_DESCRIPTION = :F_LOAD_DESCRIPTION , ");

                //操作员
                strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");

                //操作时间
                strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");

                //是否删除
                strSql.Append(" F_DEL = :F_DEL , ");

                //负载柜名称
                strSql.Append(" F_LOAD_NAME = :F_LOAD_NAME , ");

                //校准编号
                strSql.Append(" F_LOAD_CALIBRATION = :F_LOAD_CALIBRATION , ");

                //负载柜位置
                strSql.Append(" F_LOAD_POSTION = :F_LOAD_POSTION , ");

                //资产编号
                strSql.Append(" F_PROPERTY_ID = :F_PROPERTY_ID , ");

                //负载类型
                strSql.Append(" F_LOAD_TYPE = :F_LOAD_TYPE , ");

                //感性负载功率因素
                strSql.Append(" F_CONDUCTYLOAD_COEFFECIENCY = :F_CONDUCTYLOAD_COEFFECIENCY , ");

                //负载电压类型
                strSql.Append(" F_LOAD_VOLTAGE_TYPE = :F_LOAD_VOLTAGE_TYPE , ");

                //稳态电流上限
                strSql.Append(" F_LOAD_STABLECURRENT_CEILING = :F_LOAD_STABLECURRENT_CEILING  ");

                strSql.Append(" where F_LOAD_ID=:F_LOAD_ID  ");

                OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_LOAD_ID", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_LOAD_STABLECURRENT_FLOOR", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_LOAD_PULSECURRENT_CEILING", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_LOAD_PULSECURRENT_FLOOR", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_LOAD_VOLTAGE_CEILING", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_LOAD_VOLTAGE_FLOOR", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_LOAD_DESCRIPTION", OracleType.VarChar,500) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_LOAD_NAME", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_LOAD_CALIBRATION", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_LOAD_POSTION", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_PROPERTY_ID", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_LOAD_TYPE", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_CONDUCTYLOAD_COEFFECIENCY", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_LOAD_VOLTAGE_TYPE", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_LOAD_STABLECURRENT_CEILING", OracleType.Number,18)             
              
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
                //稳态电流下限
                if (model.F_LOAD_STABLECURRENT_FLOOR == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_LOAD_STABLECURRENT_FLOOR;
                }
                //冲击电流上限
                if (model.F_LOAD_PULSECURRENT_CEILING == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_LOAD_PULSECURRENT_CEILING;
                }
                //冲击电流下限
                if (model.F_LOAD_PULSECURRENT_FLOOR == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_LOAD_PULSECURRENT_FLOOR;
                }
                //负载电压上限
                if (model.F_LOAD_VOLTAGE_CEILING == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_LOAD_VOLTAGE_CEILING;
                }
                //负载电压下限
                if (model.F_LOAD_VOLTAGE_FLOOR == null)
                {
                    parameters[5].Value = DBNull.Value;
                }
                else
                {
                    parameters[5].Value = model.F_LOAD_VOLTAGE_FLOOR;
                }
                //描述信息
                if (model.F_LOAD_DESCRIPTION == null)
                {
                    parameters[6].Value = DBNull.Value;
                }
                else
                {
                    parameters[6].Value = model.F_LOAD_DESCRIPTION;
                }
                //操作员
                if (model.F_OPERATOR_ID == null)
                {
                    parameters[7].Value = DBNull.Value;
                }
                else
                {
                    parameters[7].Value = model.F_OPERATOR_ID;
                }
                //操作时间
                if (model.F_OPERATIONTIME == null)
                {
                    parameters[8].Value = DBNull.Value;
                }
                else
                {
                    parameters[8].Value = model.F_OPERATIONTIME;
                }
                //是否删除
                if (model.F_DEL == null)
                {
                    parameters[9].Value = DBNull.Value;
                }
                else
                {
                    parameters[9].Value = model.F_DEL;
                }
                //负载柜名称
                if (model.F_LOAD_NAME == null)
                {
                    parameters[10].Value = DBNull.Value;
                }
                else
                {
                    parameters[10].Value = model.F_LOAD_NAME;
                }
                //校准编号
                if (model.F_LOAD_CALIBRATION == null)
                {
                    parameters[11].Value = DBNull.Value;
                }
                else
                {
                    parameters[11].Value = model.F_LOAD_CALIBRATION;
                }
                //负载柜位置
                if (model.F_LOAD_POSTION == null)
                {
                    parameters[12].Value = DBNull.Value;
                }
                else
                {
                    parameters[12].Value = model.F_LOAD_POSTION;
                }
                //资产编号
                if (model.F_PROPERTY_ID == null)
                {
                    parameters[13].Value = DBNull.Value;
                }
                else
                {
                    parameters[13].Value = model.F_PROPERTY_ID;
                }
                //负载类型
                if (model.F_LOAD_TYPE == null)
                {
                    parameters[14].Value = DBNull.Value;
                }
                else
                {
                    parameters[14].Value = model.F_LOAD_TYPE;
                }
                //感性负载功率因素
                if (model.F_CONDUCTYLOAD_COEFFECIENCY == null)
                {
                    parameters[15].Value = DBNull.Value;
                }
                else
                {
                    parameters[15].Value = model.F_CONDUCTYLOAD_COEFFECIENCY;
                }
                //负载电压类型
                if (model.F_LOAD_VOLTAGE_TYPE == null)
                {
                    parameters[16].Value = DBNull.Value;
                }
                else
                {
                    parameters[16].Value = model.F_LOAD_VOLTAGE_TYPE;
                }
                //稳态电流上限
                if (model.F_LOAD_STABLECURRENT_CEILING == null)
                {
                    parameters[17].Value = DBNull.Value;
                }
                else
                {
                    parameters[17].Value = model.F_LOAD_STABLECURRENT_CEILING;
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
                Log.Error("DalDEV_LOAD_INFO->Update---FAILED", ex);
                throw ex;
            }




        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_LOAD_ID)
        {

            try
            {
                Log.Info("DalDEV_LOAD_INFO->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_LOAD_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_LOAD_ID=:F_LOAD_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_LOAD_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_LOAD_ID;


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
                Log.Error("DalDEV_LOAD_INFO->Delete---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_LOAD_ID)
        {

            try
            {
                Log.Info("DalDEV_LOAD_INFO->Disabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_LOAD_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_LOAD_ID=:F_LOAD_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_LOAD_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_LOAD_ID;


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
                Log.Error("DalDEV_LOAD_INFO->Disabled---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_LOAD_ID)
        {

            try
            {
                Log.Info("DalDEV_LOAD_INFO->Enabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_LOAD_INFO  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_LOAD_ID=:F_LOAD_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_LOAD_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_LOAD_ID;


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
                Log.Error("DalDEV_LOAD_INFO->Enabled---FAILED", ex);
                throw ex;
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool Drop(string F_LOAD_ID)
        {

            try
            {
                Log.Info("DalDEV_LOAD_INFO->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM  T_DEV_LOAD_INFO  ");
                strSql.Append(" where F_LOAD_ID=:F_LOAD_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_LOAD_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_LOAD_ID;


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
                Log.Error("DalDEV_LOAD_INFO->Delete---FAILED", ex);
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
                Log.Info("DalDEV_LOAD_INFO->DeleteWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_LOAD_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalDEV_LOAD_INFO->DeleteWhere---FAILED", ex);
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
                Log.Info("DalDEV_LOAD_INFO->DropWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("delete from  T_DEV_LOAD_INFO  ");
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
                Log.Error("DalDEV_LOAD_INFO->DropWhere---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelDEV_LOAD_INFO GetModel(string F_LOAD_ID)
        {
            try
            {
                Log.Info("DalDEV_LOAD_INFO->GetModel---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                //负载柜编号
                strSql.Append("F_LOAD_ID,  ");
                //稳态电流下限
                strSql.Append("F_LOAD_STABLECURRENT_FLOOR,  ");
                //冲击电流上限
                strSql.Append("F_LOAD_PULSECURRENT_CEILING,  ");
                //冲击电流下限
                strSql.Append("F_LOAD_PULSECURRENT_FLOOR,  ");
                //负载电压上限
                strSql.Append("F_LOAD_VOLTAGE_CEILING,  ");
                //负载电压下限
                strSql.Append("F_LOAD_VOLTAGE_FLOOR,  ");
                //描述信息
                strSql.Append("F_LOAD_DESCRIPTION,  ");
                //创建时间
                strSql.Append("F_CREATE_TIME,  ");
                //操作员
                strSql.Append("F_OPERATOR_ID,  ");
                //操作时间
                strSql.Append("F_OPERATIONTIME,  ");
                //是否删除
                strSql.Append("F_DEL,  ");
                //负载柜名称
                strSql.Append("F_LOAD_NAME,  ");
                //校准编号
                strSql.Append("F_LOAD_CALIBRATION,  ");
                //负载柜位置
                strSql.Append("F_LOAD_POSTION,  ");
                //资产编号
                strSql.Append("F_PROPERTY_ID,  ");
                //负载类型
                strSql.Append("F_LOAD_TYPE,  ");
                //感性负载功率因素
                strSql.Append("F_CONDUCTYLOAD_COEFFECIENCY,  ");
                //负载电压类型
                strSql.Append("F_LOAD_VOLTAGE_TYPE,  ");
                //稳态电流上限
                strSql.Append("F_LOAD_STABLECURRENT_CEILING  ");
                strSql.Append("  from T_DEV_LOAD_INFO ");
                strSql.Append(" where 1=1 AND  F_LOAD_ID=:F_LOAD_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_LOAD_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_LOAD_ID;


                RelayTest.Model.ModelDEV_LOAD_INFO model = new RelayTest.Model.ModelDEV_LOAD_INFO();
                DataSet ds = Query(strSql.ToString(), parameters);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    model.F_LOAD_ID = ds.Tables[0].Rows[0]["F_LOAD_ID"].ToString();
                    if (ds.Tables[0].Rows[0]["F_LOAD_STABLECURRENT_FLOOR"].ToString() != "")
                    {
                        model.F_LOAD_STABLECURRENT_FLOOR = decimal.Parse(ds.Tables[0].Rows[0]["F_LOAD_STABLECURRENT_FLOOR"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_LOAD_PULSECURRENT_CEILING"].ToString() != "")
                    {
                        model.F_LOAD_PULSECURRENT_CEILING = decimal.Parse(ds.Tables[0].Rows[0]["F_LOAD_PULSECURRENT_CEILING"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_LOAD_PULSECURRENT_FLOOR"].ToString() != "")
                    {
                        model.F_LOAD_PULSECURRENT_FLOOR = decimal.Parse(ds.Tables[0].Rows[0]["F_LOAD_PULSECURRENT_FLOOR"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_LOAD_VOLTAGE_CEILING"].ToString() != "")
                    {
                        model.F_LOAD_VOLTAGE_CEILING = decimal.Parse(ds.Tables[0].Rows[0]["F_LOAD_VOLTAGE_CEILING"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_LOAD_VOLTAGE_FLOOR"].ToString() != "")
                    {
                        model.F_LOAD_VOLTAGE_FLOOR = decimal.Parse(ds.Tables[0].Rows[0]["F_LOAD_VOLTAGE_FLOOR"].ToString());
                    }
                    model.F_LOAD_DESCRIPTION = ds.Tables[0].Rows[0]["F_LOAD_DESCRIPTION"].ToString();
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
                    model.F_LOAD_NAME = ds.Tables[0].Rows[0]["F_LOAD_NAME"].ToString();
                    model.F_LOAD_CALIBRATION = ds.Tables[0].Rows[0]["F_LOAD_CALIBRATION"].ToString();
                    model.F_LOAD_POSTION = ds.Tables[0].Rows[0]["F_LOAD_POSTION"].ToString();
                    model.F_PROPERTY_ID = ds.Tables[0].Rows[0]["F_PROPERTY_ID"].ToString();
                    if (ds.Tables[0].Rows[0]["F_LOAD_TYPE"].ToString() != "")
                    {
                        model.F_LOAD_TYPE = decimal.Parse(ds.Tables[0].Rows[0]["F_LOAD_TYPE"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_CONDUCTYLOAD_COEFFECIENCY"].ToString() != "")
                    {
                        model.F_CONDUCTYLOAD_COEFFECIENCY = decimal.Parse(ds.Tables[0].Rows[0]["F_CONDUCTYLOAD_COEFFECIENCY"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_LOAD_VOLTAGE_TYPE"].ToString() != "")
                    {
                        model.F_LOAD_VOLTAGE_TYPE = decimal.Parse(ds.Tables[0].Rows[0]["F_LOAD_VOLTAGE_TYPE"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_LOAD_STABLECURRENT_CEILING"].ToString() != "")
                    {
                        model.F_LOAD_STABLECURRENT_CEILING = decimal.Parse(ds.Tables[0].Rows[0]["F_LOAD_STABLECURRENT_CEILING"].ToString());
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
                Log.Error("DalDEV_LOAD_INFO->GetModel---FAILED", ex);
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
                Log.Info("DalDEV_LOAD_INFO->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM T_DEV_LOAD_INFO  where 1=1");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_LOAD_INFO->GetList---FAILED", ex);
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
                Log.Info("DalDEV_LOAD_INFO->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                if (Top > 0)
                {
                    strSql.Append(" top " + Top.ToString());
                }
                strSql.Append(" * ");
                strSql.Append(" FROM T_DEV_LOAD_INFO  where F_DEL=0 ");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                strSql.Append(" order by " + filedOrder);
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_LOAD_INFO->GetList---FAILED", ex);
                throw ex;
            }

        }
        #endregion Method
        #region Extension

        /// <summary>
        /// 根据负载柜编号获得相关联的供电柜
        /// </summary>
        /// <param name="loadId">负载柜编号</param>
        /// <returns></returns>
        public DataSet GetPowersRelatedToLoad(string loadId)
        {
            try
            {
                Log.Info("DalDEV_LOAD_INFO->GetPowerLoadPowerToPowerSwitchRelation---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("	SELECT (SELECT COUNT (*)	");
                strSql.Append("	          FROM T_DEV_POWER_TO_LOAD	");
                strSql.Append("	         WHERE     T_DEV_POWER_TO_LOAD.F_LOAD_ID = :F_LOAD_ID	");
                strSql.Append("	               AND T_DEV_POWER_TO_LOAD.F_POWER_ID =	");
                strSql.Append("	                      T_DEV_POWER_INFO.F_POWER_ID	");
                strSql.Append("	               AND T_DEV_POWER_TO_LOAD.F_POWER_SWITCH_ID =	");
                strSql.Append("	                      T_DEV_POWER_SWITCH.F_POWER_SWITCH_ID	");
                strSql.Append("	               AND ROWNUM <= 1)	");
                strSql.Append("	          F_CHECK,	");
                strSql.Append("	       T_DEV_POWER_INFO.F_POWER_ID,	");
                strSql.Append("	       T_DEV_POWER_SWITCH.F_POWER_SWITCH_ID,	");
                strSql.Append("	       T_DEV_POWER_INFO.F_POWER_NAME	");

                strSql.Append("	  FROM T_DEV_POWER_INFO, T_DEV_POWER_SWITCH	");
                strSql.Append("	 WHERE T_DEV_POWER_INFO.F_POWER_ID = T_DEV_POWER_SWITCH.F_POWER_ID	");


                OracleParameter[] parameters =
                {
                    new OracleParameter(":F_LOAD_ID", OracleType.VarChar, 20)
                };
                parameters[0].Value = loadId;


                return Query(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_LOAD_INFO->GetPowerLoadPowerToPowerSwitchRelation---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 根据负载柜编号获得相关联的下位机
        /// </summary>
        /// <param name="loadId">负载柜编号</param>
        /// <returns></returns>
        public DataSet GetSubordinatesRelatedToLoad(string loadId)
        {
            try
            {
                Log.Info("DalDEV_LOAD_INFO->GetSubordinatesRelatedToLoad---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("	SELECT (SELECT COUNT (*)	");
                strSql.Append("	          FROM T_DEV_LOAD_TO_SUB	");
                strSql.Append("	         WHERE     T_DEV_LOAD_TO_SUB.F_LOAD_ID = :F_LOAD_ID	");
                strSql.Append("	               AND T_DEV_LOAD_TO_SUB.F_SUBORDINATE_ID =	");
                strSql.Append("	                      T_DEV_SUBORDINATE_INFO.F_SUBORDINATE_ID	");
                strSql.Append("	               AND ROWNUM <= 1)	");
                strSql.Append("	          F_CHECK,	");
                strSql.Append("	       F_SUBORDINATE_ID ,	");
                strSql.Append("	       F_SUBORDINATE_NAME 	");
                strSql.Append("	  FROM T_DEV_SUBORDINATE_INFO	");


                OracleParameter[] parameters =
                {
                    new OracleParameter(":F_LOAD_ID", OracleType.VarChar, 20)
                };
                parameters[0].Value = loadId;


                DataSet ds = Query(strSql.ToString(), parameters);

                return ds;
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_LOAD_INFO->GetSubordinatesRelatedToLoad---FAILED", ex);
                throw ex;
            }
        }


        /// <summary>
        /// 根据负载柜编号获得相关联的线圈电源
        /// </summary>
        /// <param name="loadId">负载柜编号</param>
        /// <returns></returns>
        public DataSet GetCoilPowersRelatedToLoad(string loadId)
        {
            try
            {
                Log.Info("DalDEV_LOAD_INFO->GetCoilPowersRelatedToLoad---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("	SELECT (SELECT COUNT (*)	");
                strSql.Append("	          FROM T_DEV_COILPOWER_TO_LOAD	");
                strSql.Append("	         WHERE     T_DEV_COILPOWER_TO_LOAD.F_LOAD_ID = :F_LOAD_ID	");
                strSql.Append("	               AND T_DEV_COILPOWER_TO_LOAD.F_COILPOWER_ID =	");
                strSql.Append("	                      T_DEV_COILPOWER_INFO.F_COILPOWER_ID	");
                strSql.Append("	               AND ROWNUM <= 1)	");
                strSql.Append("	          F_CHECK,	");
                strSql.Append("	       F_COILPOWER_ID ,	");
                strSql.Append("	       F_COILPOWER_NAME 	");
                strSql.Append("	  FROM T_DEV_COILPOWER_INFO	");


                OracleParameter[] parameters =
                {
                    new OracleParameter(":F_LOAD_ID", OracleType.VarChar, 20)
                };
                parameters[0].Value = loadId;


                DataSet ds = Query(strSql.ToString(), parameters);

                return ds;
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_LOAD_INFO->GetCoilPowersRelatedToLoad---FAILED", ex);
                throw ex;
            }
        }


        /// <summary>
        /// 保存关系
        /// </summary>
        /// <param name="relationType">关系类型0：下位机，1：线圈电源</param>
        /// <param name="model"></param>
        public void AddRelation(int relationType, ModelDEVRelationComm model)
        {
            try
            {
                Log.Info("DalDEV_LOAD_INFO->AddRelation---START");
                StringBuilder strSql = new StringBuilder();
                switch (relationType)
                {
   
                    case 0:
                        {
                            strSql.Append("	INSERT INTO T_DEV_LOAD_TO_SUB ( 	");
                            break;
                        }
                    case 1:
                        {
                            strSql.Append("	INSERT INTO T_DEV_COILPOWER_TO_LOAD ( 	");
                            break;
                        }
                  
                }
                strSql.Append("	F_LOAD_ID ,	");
                strSql.Append("	F_LOAD_NAME ,	");
                switch (relationType)
                {
   
                    case 0:
                        {
                            strSql.Append("	F_SUBORDINATE_ID ,	");
                            strSql.Append("	F_SUBORDINATE_NAME ,	");
                            break;
                        }
                    case 1:
                        {
                            strSql.Append("	F_COILPOWER_ID ,	");
                            strSql.Append("	F_COILPOWER_NAME ,	");
                            break;
                        }
                 
                }

                strSql.Append("	F_MEMO ,	");
                strSql.Append("	F_CREATE_TIME ,	");
                strSql.Append("	F_OPERATOR_ID ,	");
                strSql.Append("	F_OPERATIONTIME ,	");
                strSql.Append("	F_DEL )	");
                strSql.Append(" values (");
                strSql.Append(":F_LOAD_ID,:F_LOAD_NAME,");
                strSql.Append(":F_POWER_ID,");


                    strSql.Append(":F_POWER_NAME,");
              

                strSql.Append(":F_MEMO,:F_CREATE_TIME,:F_OPERATOR_ID,:F_OPERATIONTIME,:F_DEL");
                strSql.Append(") ");


                
                    OracleParameter[] parameters =
                    {
                        new OracleParameter(":F_LOAD_ID", OracleType.VarChar, 20),
                        new OracleParameter(":F_LOAD_NAME", OracleType.VarChar, 100),
                        new OracleParameter(":F_POWER_ID", OracleType.VarChar, 20),
                        new OracleParameter(":F_POWER_NAME", OracleType.VarChar, 100),
                        new OracleParameter(":F_MEMO", OracleType.VarChar, 500),
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime),
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar, 10),
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime),
                        new OracleParameter(":F_DEL", OracleType.Number, 4)
                    };

                    if (model.F_MASTER_ID == null)
                    {
                        parameters[0].Value = DBNull.Value;
                    }
                    else
                    {
                        parameters[0].Value = model.F_MASTER_ID;
                    }

                    if (model.F_MASTER_NAME == null)
                    {
                        parameters[1].Value = DBNull.Value;
                    }
                    else
                    {
                        parameters[1].Value = model.F_MASTER_NAME;
                    }

                    if (model.F_AFFILIATION_ID == null)
                    {
                        parameters[2].Value = DBNull.Value;
                    }
                    else
                    {
                        parameters[2].Value = model.F_AFFILIATION_ID;
                    }

                    if (model.F_AFFILIATION_NAME == null)
                    {
                        parameters[3].Value = DBNull.Value;
                    }
                    else
                    {
                        parameters[3].Value = model.F_AFFILIATION_NAME;
                    }

                    if (model.F_MEMO == null)
                    {
                        parameters[4].Value = DBNull.Value;
                    }
                    else
                    {
                        parameters[4].Value = model.F_MEMO;
                    }

                    if (model.F_CREATE_TIME == null)
                    {
                        parameters[5].Value = DBNull.Value;
                    }
                    else
                    {
                        parameters[5].Value = model.F_CREATE_TIME;
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
                    ExecuteSql(strSql.ToString(), parameters);

            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_LOAD_INFO->AddRelation---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 删除关系
        /// </summary>
        /// <param name="relationType">关系类型0：下位机，1：线圈电源</param>
        /// <param name="loadId">工作站编号</param>
        public void DeleteRelation(int relationType, string loadId)
        {
            try
            {
                Log.Info("DalDEV_LOAD_INFO->DeleteRelation---START");
                StringBuilder strSql = new StringBuilder();


                switch (relationType)
                {
                    case 0:
                        {
                            strSql.Append("DELETE FROM  T_DEV_LOAD_TO_SUB  ");
                            break;
           
                        }
                    case 1:
                        {
                            strSql.Append("DELETE FROM  T_DEV_COILPOWER_TO_LOAD  ");
                            break;
                             }
                 
                   
                }
                strSql.Append(" where F_LOAD_ID=:FMasterId ");
                OracleParameter[] parameters =
                {
                    new OracleParameter(":FMasterId", OracleType.VarChar, 20)
                };
                parameters[0].Value = loadId;


                ExecuteSql(strSql.ToString(), parameters);

            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_LOAD_INFO->DeleteRelation---FAILED", ex);
                throw ex;
            }
        }

        #endregion
    }
}

