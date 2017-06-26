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
    //温度传感器基本信息
    public partial class DalDEV_SENSOR_INFO : DbHelperOra
    {


        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalDEV_SENSOR_INFO));

        #region Method
        /// <summary>
        ///   是否存在该记录
        /// </summary>
        public new bool Exists(string F_SENSOR_ID)
        {
            try
            {
                Log.Info("DalDEV_SENSOR_INFO->Exists---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select count(1) from T_DEV_SENSOR_INFO");
                strSql.Append(" where 1=1 and ");
                strSql.Append(" F_SENSOR_ID = :F_SENSOR_ID  ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_SENSOR_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_SENSOR_ID;

                Log.Info("DalDEV_SENSOR_INFO->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_SENSOR_INFO->Exists---FAILED", ex);
                throw ex;
            }
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelDEV_SENSOR_INFO model)
        {

            try
            {
                Log.Info("DalDEV_SENSOR_INFO->Add---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into T_DEV_SENSOR_INFO(");

                //温度传感器编号
                strSql.Append("  F_SENSOR_ID,");
                //温度传感器安装时间
                strSql.Append("  F_SENDOR_INSTALL_DATE,");
                //温度报警上限值
                strSql.Append("  F_SENSOR_ALARMVALUE_CEILING,");
                //温度报警下限值
                strSql.Append("  F_SENSOR_ALARMVALUE_FLOOR,");
                //温度超限动作上限值
                strSql.Append("  F_SENSOR_ACTIONVALUE_CEILING,");
                //温度超限动作下限值
                strSql.Append("  F_SENSOR_ACTIONVALUE_FLOOR,");
                //当前温度值
                strSql.Append("  F_SENSOR_NOW_VALUE,");
                //采集时间
                strSql.Append("  F_SENSOR_VALUE_TIME,");
                //工作状态
                strSql.Append("  F_SENSOR_STATUS,");
                //温度校正系数
                strSql.Append("  F_TEMPERATURE_ADJUST_COFF,");
                //备注
                strSql.Append("  F_MEMO,");
                //温度传感器型号
                strSql.Append("  F_SENSOR_TYPE,");
                //创建时间
                strSql.Append("  F_CREATE_TIME,");
                //操作员
                strSql.Append("  F_OPERATOR_ID,");
                //操作时间
                strSql.Append("  F_OPERATIONTIME,");
                //是否删除
                strSql.Append("  F_DEL,");
                //校准编号
                strSql.Append("  F_SENSOR_CALIBRATION,");
                //温度传感器安装设备类型
                strSql.Append("  F_DEV_TYPE,");
                //温度传感器安装设备编号
                strSql.Append("  F_DEV_ID,");
                //通讯地址
                strSql.Append("  F_SENSOR_ADDRESS,");
                //通讯端口
                strSql.Append("  F_COM_ADDRESS,");
                //热敏电阻接入序号
                strSql.Append("  F_SENSER_NO,");
                //温度传感器位置
                strSql.Append("  F_SENSOR_POSTION");
                strSql.Append(") values (");
                strSql.Append(" :F_SENSOR_ID,");
                strSql.Append(" :F_SENDOR_INSTALL_DATE,");
                strSql.Append(" :F_SENSOR_ALARMVALUE_CEILING,");
                strSql.Append(" :F_SENSOR_ALARMVALUE_FLOOR,");
                strSql.Append(" :F_SENSOR_ACTIONVALUE_CEILING,");
                strSql.Append(" :F_SENSOR_ACTIONVALUE_FLOOR,");
                strSql.Append(" :F_SENSOR_NOW_VALUE,");
                strSql.Append(" :F_SENSOR_VALUE_TIME,");
                strSql.Append(" :F_SENSOR_STATUS,");
                strSql.Append(" :F_TEMPERATURE_ADJUST_COFF,");
                strSql.Append(" :F_MEMO,");
                strSql.Append(" :F_SENSOR_TYPE,");
                strSql.Append(" :F_CREATE_TIME,");
                strSql.Append(" :F_OPERATOR_ID,");
                strSql.Append(" :F_OPERATIONTIME,");
                strSql.Append(" :F_DEL,");
                strSql.Append(" :F_SENSOR_CALIBRATION,");
                strSql.Append(" :F_DEV_TYPE,");
                strSql.Append(" :F_DEV_ID,");
                strSql.Append(" :F_SENSOR_ADDRESS,");
                strSql.Append(" :F_COM_ADDRESS,");
                strSql.Append(" :F_SENSER_NO,");
                strSql.Append(" :F_SENSOR_POSTION");
                strSql.Append(") ");

                OracleParameter[] parameters = {
			            new OracleParameter(":F_SENSOR_ID", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_SENDOR_INSTALL_DATE", OracleType.DateTime) ,            
                        new OracleParameter(":F_SENSOR_ALARMVALUE_CEILING", OracleType.Number,18) ,            
                        new OracleParameter(":F_SENSOR_ALARMVALUE_FLOOR", OracleType.Number,18) ,            
                        new OracleParameter(":F_SENSOR_ACTIONVALUE_CEILING", OracleType.Number,18) ,            
                        new OracleParameter(":F_SENSOR_ACTIONVALUE_FLOOR", OracleType.Number,18) ,            
                        new OracleParameter(":F_SENSOR_NOW_VALUE", OracleType.Number,18) ,            
                        new OracleParameter(":F_SENSOR_VALUE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_SENSOR_STATUS", OracleType.Number,4) ,            
                        new OracleParameter(":F_TEMPERATURE_ADJUST_COFF", OracleType.Number,18) ,            
                        new OracleParameter(":F_MEMO", OracleType.VarChar,500) ,            
                        new OracleParameter(":F_SENSOR_TYPE", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4) ,            
                        new OracleParameter(":F_SENSOR_CALIBRATION", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_DEV_TYPE", OracleType.Number,4) ,            
                        new OracleParameter(":F_DEV_ID", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_SENSOR_ADDRESS", OracleType.Number,4) ,            
                        new OracleParameter(":F_COM_ADDRESS", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_SENSER_NO", OracleType.Number,4) ,            
                        new OracleParameter(":F_SENSOR_POSTION", OracleType.VarChar,100)             
              
            };

                //温度传感器编号
                if (model.F_SENSOR_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_SENSOR_ID;
                }

                //温度传感器安装时间
                if (model.F_SENDOR_INSTALL_DATE == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_SENDOR_INSTALL_DATE;
                }

                //温度报警上限值
                if (model.F_SENSOR_ALARMVALUE_CEILING == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_SENSOR_ALARMVALUE_CEILING;
                }

                //温度报警下限值
                if (model.F_SENSOR_ALARMVALUE_FLOOR == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_SENSOR_ALARMVALUE_FLOOR;
                }

                //温度超限动作上限值
                if (model.F_SENSOR_ACTIONVALUE_CEILING == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_SENSOR_ACTIONVALUE_CEILING;
                }

                //温度超限动作下限值
                if (model.F_SENSOR_ACTIONVALUE_FLOOR == null)
                {
                    parameters[5].Value = DBNull.Value;
                }
                else
                {
                    parameters[5].Value = model.F_SENSOR_ACTIONVALUE_FLOOR;
                }

                //当前温度值
                if (model.F_SENSOR_NOW_VALUE == null)
                {
                    parameters[6].Value = DBNull.Value;
                }
                else
                {
                    parameters[6].Value = model.F_SENSOR_NOW_VALUE;
                }

                //采集时间
                if (model.F_SENSOR_VALUE_TIME == null)
                {
                    parameters[7].Value = DBNull.Value;
                }
                else
                {
                    parameters[7].Value = model.F_SENSOR_VALUE_TIME;
                }

                //工作状态
                if (model.F_SENSOR_STATUS == null)
                {
                    parameters[8].Value = DBNull.Value;
                }
                else
                {
                    parameters[8].Value = model.F_SENSOR_STATUS;
                }

                //温度校正系数
                if (model.F_TEMPERATURE_ADJUST_COFF == null)
                {
                    parameters[9].Value = DBNull.Value;
                }
                else
                {
                    parameters[9].Value = model.F_TEMPERATURE_ADJUST_COFF;
                }

                //备注
                if (model.F_MEMO == null)
                {
                    parameters[10].Value = DBNull.Value;
                }
                else
                {
                    parameters[10].Value = model.F_MEMO;
                }

                //温度传感器型号
                if (model.F_SENSOR_TYPE == null)
                {
                    parameters[11].Value = DBNull.Value;
                }
                else
                {
                    parameters[11].Value = model.F_SENSOR_TYPE;
                }

                //创建时间
                if (model.F_CREATE_TIME == null)
                {
                    parameters[12].Value = DBNull.Value;
                }
                else
                {
                    parameters[12].Value = model.F_CREATE_TIME;
                }

                //操作员
                if (model.F_OPERATOR_ID == null)
                {
                    parameters[13].Value = DBNull.Value;
                }
                else
                {
                    parameters[13].Value = model.F_OPERATOR_ID;
                }

                //操作时间
                if (model.F_OPERATIONTIME == null)
                {
                    parameters[14].Value = DBNull.Value;
                }
                else
                {
                    parameters[14].Value = model.F_OPERATIONTIME;
                }

                //是否删除
                if (model.F_DEL == null)
                {
                    parameters[15].Value = DBNull.Value;
                }
                else
                {
                    parameters[15].Value = model.F_DEL;
                }

                //校准编号
                if (model.F_SENSOR_CALIBRATION == null)
                {
                    parameters[16].Value = DBNull.Value;
                }
                else
                {
                    parameters[16].Value = model.F_SENSOR_CALIBRATION;
                }

                //温度传感器安装设备类型
                if (model.F_DEV_TYPE == null)
                {
                    parameters[17].Value = DBNull.Value;
                }
                else
                {
                    parameters[17].Value = model.F_DEV_TYPE;
                }

                //温度传感器安装设备编号
                if (model.F_DEV_ID == null)
                {
                    parameters[18].Value = DBNull.Value;
                }
                else
                {
                    parameters[18].Value = model.F_DEV_ID;
                }

                //通讯地址
                if (model.F_SENSOR_ADDRESS == null)
                {
                    parameters[19].Value = DBNull.Value;
                }
                else
                {
                    parameters[19].Value = model.F_SENSOR_ADDRESS;
                }

                //通讯端口
                if (model.F_COM_ADDRESS == null)
                {
                    parameters[20].Value = DBNull.Value;
                }
                else
                {
                    parameters[20].Value = model.F_COM_ADDRESS;
                }

                //热敏电阻接入序号
                if (model.F_SENSER_NO == null)
                {
                    parameters[21].Value = DBNull.Value;
                }
                else
                {
                    parameters[21].Value = model.F_SENSER_NO;
                }

                //温度传感器位置
                if (model.F_SENSOR_POSTION == null)
                {
                    parameters[22].Value = DBNull.Value;
                }
                else
                {
                    parameters[22].Value = model.F_SENSOR_POSTION;
                }

                ExecuteSql(strSql.ToString(), parameters);

            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_SENSOR_INFO->Add---FAILED", ex);
                throw ex;
            }
        }




        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(RelayTest.Model.ModelDEV_SENSOR_INFO model)
        {

            try
            {
                Log.Info("DalDEV_SENSOR_INFO->Update---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update T_DEV_SENSOR_INFO set ");

                //温度传感器编号
                strSql.Append(" F_SENSOR_ID = :F_SENSOR_ID , ");

                //温度传感器安装时间
                strSql.Append(" F_SENDOR_INSTALL_DATE = :F_SENDOR_INSTALL_DATE , ");

                //温度报警上限值
                strSql.Append(" F_SENSOR_ALARMVALUE_CEILING = :F_SENSOR_ALARMVALUE_CEILING , ");

                //温度报警下限值
                strSql.Append(" F_SENSOR_ALARMVALUE_FLOOR = :F_SENSOR_ALARMVALUE_FLOOR , ");

                //温度超限动作上限值
                strSql.Append(" F_SENSOR_ACTIONVALUE_CEILING = :F_SENSOR_ACTIONVALUE_CEILING , ");

                //温度超限动作下限值
                strSql.Append(" F_SENSOR_ACTIONVALUE_FLOOR = :F_SENSOR_ACTIONVALUE_FLOOR , ");

                //当前温度值
                strSql.Append(" F_SENSOR_NOW_VALUE = :F_SENSOR_NOW_VALUE , ");

                //采集时间
                strSql.Append(" F_SENSOR_VALUE_TIME = :F_SENSOR_VALUE_TIME , ");

                //工作状态
                strSql.Append(" F_SENSOR_STATUS = :F_SENSOR_STATUS , ");

                //温度校正系数
                strSql.Append(" F_TEMPERATURE_ADJUST_COFF = :F_TEMPERATURE_ADJUST_COFF , ");

                //备注
                strSql.Append(" F_MEMO = :F_MEMO , ");

                //温度传感器型号
                strSql.Append(" F_SENSOR_TYPE = :F_SENSOR_TYPE , ");

                //操作员
                strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");

                //操作时间
                strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");

                //是否删除
                strSql.Append(" F_DEL = :F_DEL , ");

                //校准编号
                strSql.Append(" F_SENSOR_CALIBRATION = :F_SENSOR_CALIBRATION , ");

                //温度传感器安装设备类型
                strSql.Append(" F_DEV_TYPE = :F_DEV_TYPE , ");

                //温度传感器安装设备编号
                strSql.Append(" F_DEV_ID = :F_DEV_ID , ");

                //通讯地址
                strSql.Append(" F_SENSOR_ADDRESS = :F_SENSOR_ADDRESS , ");

                //通讯端口
                strSql.Append(" F_COM_ADDRESS = :F_COM_ADDRESS , ");

                //热敏电阻接入序号
                strSql.Append(" F_SENSER_NO = :F_SENSER_NO , ");

                //温度传感器位置
                strSql.Append(" F_SENSOR_POSTION = :F_SENSOR_POSTION  ");

                strSql.Append(" where F_SENSOR_ID=:F_SENSOR_ID  ");

                OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_SENSOR_ID", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_SENDOR_INSTALL_DATE", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_SENSOR_ALARMVALUE_CEILING", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_SENSOR_ALARMVALUE_FLOOR", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_SENSOR_ACTIONVALUE_CEILING", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_SENSOR_ACTIONVALUE_FLOOR", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_SENSOR_NOW_VALUE", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_SENSOR_VALUE_TIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_SENSOR_STATUS", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_TEMPERATURE_ADJUST_COFF", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_MEMO", OracleType.VarChar,500) ,            
                        	
            new OracleParameter(":F_SENSOR_TYPE", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_SENSOR_CALIBRATION", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_DEV_TYPE", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_DEV_ID", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_SENSOR_ADDRESS", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_COM_ADDRESS", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_SENSER_NO", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_SENSOR_POSTION", OracleType.VarChar,100)             
              
            };
                //温度传感器编号
                if (model.F_SENSOR_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_SENSOR_ID;
                }
                //温度传感器安装时间
                if (model.F_SENDOR_INSTALL_DATE == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_SENDOR_INSTALL_DATE;
                }
                //温度报警上限值
                if (model.F_SENSOR_ALARMVALUE_CEILING == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_SENSOR_ALARMVALUE_CEILING;
                }
                //温度报警下限值
                if (model.F_SENSOR_ALARMVALUE_FLOOR == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_SENSOR_ALARMVALUE_FLOOR;
                }
                //温度超限动作上限值
                if (model.F_SENSOR_ACTIONVALUE_CEILING == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_SENSOR_ACTIONVALUE_CEILING;
                }
                //温度超限动作下限值
                if (model.F_SENSOR_ACTIONVALUE_FLOOR == null)
                {
                    parameters[5].Value = DBNull.Value;
                }
                else
                {
                    parameters[5].Value = model.F_SENSOR_ACTIONVALUE_FLOOR;
                }
                //当前温度值
                if (model.F_SENSOR_NOW_VALUE == null)
                {
                    parameters[6].Value = DBNull.Value;
                }
                else
                {
                    parameters[6].Value = model.F_SENSOR_NOW_VALUE;
                }
                //采集时间
                if (model.F_SENSOR_VALUE_TIME == null)
                {
                    parameters[7].Value = DBNull.Value;
                }
                else
                {
                    parameters[7].Value = model.F_SENSOR_VALUE_TIME;
                }
                //工作状态
                if (model.F_SENSOR_STATUS == null)
                {
                    parameters[8].Value = DBNull.Value;
                }
                else
                {
                    parameters[8].Value = model.F_SENSOR_STATUS;
                }
                //温度校正系数
                if (model.F_TEMPERATURE_ADJUST_COFF == null)
                {
                    parameters[9].Value = DBNull.Value;
                }
                else
                {
                    parameters[9].Value = model.F_TEMPERATURE_ADJUST_COFF;
                }
                //备注
                if (model.F_MEMO == null)
                {
                    parameters[10].Value = DBNull.Value;
                }
                else
                {
                    parameters[10].Value = model.F_MEMO;
                }
                //温度传感器型号
                if (model.F_SENSOR_TYPE == null)
                {
                    parameters[11].Value = DBNull.Value;
                }
                else
                {
                    parameters[11].Value = model.F_SENSOR_TYPE;
                }
                //操作员
                if (model.F_OPERATOR_ID == null)
                {
                    parameters[12].Value = DBNull.Value;
                }
                else
                {
                    parameters[12].Value = model.F_OPERATOR_ID;
                }
                //操作时间
                if (model.F_OPERATIONTIME == null)
                {
                    parameters[13].Value = DBNull.Value;
                }
                else
                {
                    parameters[13].Value = model.F_OPERATIONTIME;
                }
                //是否删除
                if (model.F_DEL == null)
                {
                    parameters[14].Value = DBNull.Value;
                }
                else
                {
                    parameters[14].Value = model.F_DEL;
                }
                //校准编号
                if (model.F_SENSOR_CALIBRATION == null)
                {
                    parameters[15].Value = DBNull.Value;
                }
                else
                {
                    parameters[15].Value = model.F_SENSOR_CALIBRATION;
                }
                //温度传感器安装设备类型
                if (model.F_DEV_TYPE == null)
                {
                    parameters[16].Value = DBNull.Value;
                }
                else
                {
                    parameters[16].Value = model.F_DEV_TYPE;
                }
                //温度传感器安装设备编号
                if (model.F_DEV_ID == null)
                {
                    parameters[17].Value = DBNull.Value;
                }
                else
                {
                    parameters[17].Value = model.F_DEV_ID;
                }
                //通讯地址
                if (model.F_SENSOR_ADDRESS == null)
                {
                    parameters[18].Value = DBNull.Value;
                }
                else
                {
                    parameters[18].Value = model.F_SENSOR_ADDRESS;
                }
                //通讯端口
                if (model.F_COM_ADDRESS == null)
                {
                    parameters[19].Value = DBNull.Value;
                }
                else
                {
                    parameters[19].Value = model.F_COM_ADDRESS;
                }
                //热敏电阻接入序号
                if (model.F_SENSER_NO == null)
                {
                    parameters[20].Value = DBNull.Value;
                }
                else
                {
                    parameters[20].Value = model.F_SENSER_NO;
                }
                //温度传感器位置
                if (model.F_SENSOR_POSTION == null)
                {
                    parameters[21].Value = DBNull.Value;
                }
                else
                {
                    parameters[21].Value = model.F_SENSOR_POSTION;
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
                Log.Error("DalDEV_SENSOR_INFO->Update---FAILED", ex);
                throw ex;
            }




        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_SENSOR_ID)
        {

            try
            {
                Log.Info("DalDEV_SENSOR_INFO->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_SENSOR_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_SENSOR_ID=:F_SENSOR_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_SENSOR_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_SENSOR_ID;


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
                Log.Error("DalDEV_SENSOR_INFO->Delete---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_SENSOR_ID)
        {

            try
            {
                Log.Info("DalDEV_SENSOR_INFO->Disabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_SENSOR_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_SENSOR_ID=:F_SENSOR_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_SENSOR_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_SENSOR_ID;


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
                Log.Error("DalDEV_SENSOR_INFO->Disabled---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_SENSOR_ID)
        {

            try
            {
                Log.Info("DalDEV_SENSOR_INFO->Enabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_SENSOR_INFO  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_SENSOR_ID=:F_SENSOR_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_SENSOR_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_SENSOR_ID;


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
                Log.Error("DalDEV_SENSOR_INFO->Enabled---FAILED", ex);
                throw ex;
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool Drop(string F_SENSOR_ID)
        {

            try
            {
                Log.Info("DalDEV_SENSOR_INFO->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM  T_DEV_SENSOR_INFO  ");
                strSql.Append(" where F_SENSOR_ID=:F_SENSOR_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_SENSOR_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_SENSOR_ID;


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
                Log.Error("DalDEV_SENSOR_INFO->Delete---FAILED", ex);
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
                Log.Info("DalDEV_SENSOR_INFO->DeleteWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_SENSOR_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalDEV_SENSOR_INFO->DeleteWhere---FAILED", ex);
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
                Log.Info("DalDEV_SENSOR_INFO->DropWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("delete from  T_DEV_SENSOR_INFO  ");
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
                Log.Error("DalDEV_SENSOR_INFO->DropWhere---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelDEV_SENSOR_INFO GetModel(string F_SENSOR_ID)
        {
            try
            {
                Log.Info("DalDEV_SENSOR_INFO->GetModel---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                //温度传感器编号
                strSql.Append("F_SENSOR_ID,  ");
                //温度传感器安装时间
                strSql.Append("F_SENDOR_INSTALL_DATE,  ");
                //温度报警上限值
                strSql.Append("F_SENSOR_ALARMVALUE_CEILING,  ");
                //温度报警下限值
                strSql.Append("F_SENSOR_ALARMVALUE_FLOOR,  ");
                //温度超限动作上限值
                strSql.Append("F_SENSOR_ACTIONVALUE_CEILING,  ");
                //温度超限动作下限值
                strSql.Append("F_SENSOR_ACTIONVALUE_FLOOR,  ");
                //当前温度值
                strSql.Append("F_SENSOR_NOW_VALUE,  ");
                //采集时间
                strSql.Append("F_SENSOR_VALUE_TIME,  ");
                //工作状态
                strSql.Append("F_SENSOR_STATUS,  ");
                //温度校正系数
                strSql.Append("F_TEMPERATURE_ADJUST_COFF,  ");
                //备注
                strSql.Append("F_MEMO,  ");
                //温度传感器型号
                strSql.Append("F_SENSOR_TYPE,  ");
                //创建时间
                strSql.Append("F_CREATE_TIME,  ");
                //操作员
                strSql.Append("F_OPERATOR_ID,  ");
                //操作时间
                strSql.Append("F_OPERATIONTIME,  ");
                //是否删除
                strSql.Append("F_DEL,  ");
                //校准编号
                strSql.Append("F_SENSOR_CALIBRATION,  ");
                //温度传感器安装设备类型
                strSql.Append("F_DEV_TYPE,  ");
                //温度传感器安装设备编号
                strSql.Append("F_DEV_ID,  ");
                //通讯地址
                strSql.Append("F_SENSOR_ADDRESS,  ");
                //通讯端口
                strSql.Append("F_COM_ADDRESS,  ");
                //热敏电阻接入序号
                strSql.Append("F_SENSER_NO,  ");
                //温度传感器位置
                strSql.Append("F_SENSOR_POSTION  ");
                strSql.Append("  from T_DEV_SENSOR_INFO ");
                strSql.Append(" where 1=1 AND  F_SENSOR_ID=:F_SENSOR_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_SENSOR_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_SENSOR_ID;


                RelayTest.Model.ModelDEV_SENSOR_INFO model = new RelayTest.Model.ModelDEV_SENSOR_INFO();
                DataSet ds = Query(strSql.ToString(), parameters);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    model.F_SENSOR_ID = ds.Tables[0].Rows[0]["F_SENSOR_ID"].ToString();
                    if (ds.Tables[0].Rows[0]["F_SENDOR_INSTALL_DATE"].ToString() != "")
                    {
                        model.F_SENDOR_INSTALL_DATE = DateTime.Parse(ds.Tables[0].Rows[0]["F_SENDOR_INSTALL_DATE"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_SENSOR_ALARMVALUE_CEILING"].ToString() != "")
                    {
                        model.F_SENSOR_ALARMVALUE_CEILING = decimal.Parse(ds.Tables[0].Rows[0]["F_SENSOR_ALARMVALUE_CEILING"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_SENSOR_ALARMVALUE_FLOOR"].ToString() != "")
                    {
                        model.F_SENSOR_ALARMVALUE_FLOOR = decimal.Parse(ds.Tables[0].Rows[0]["F_SENSOR_ALARMVALUE_FLOOR"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_SENSOR_ACTIONVALUE_CEILING"].ToString() != "")
                    {
                        model.F_SENSOR_ACTIONVALUE_CEILING = decimal.Parse(ds.Tables[0].Rows[0]["F_SENSOR_ACTIONVALUE_CEILING"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_SENSOR_ACTIONVALUE_FLOOR"].ToString() != "")
                    {
                        model.F_SENSOR_ACTIONVALUE_FLOOR = decimal.Parse(ds.Tables[0].Rows[0]["F_SENSOR_ACTIONVALUE_FLOOR"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_SENSOR_NOW_VALUE"].ToString() != "")
                    {
                        model.F_SENSOR_NOW_VALUE = decimal.Parse(ds.Tables[0].Rows[0]["F_SENSOR_NOW_VALUE"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_SENSOR_VALUE_TIME"].ToString() != "")
                    {
                        model.F_SENSOR_VALUE_TIME = DateTime.Parse(ds.Tables[0].Rows[0]["F_SENSOR_VALUE_TIME"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_SENSOR_STATUS"].ToString() != "")
                    {
                        model.F_SENSOR_STATUS = decimal.Parse(ds.Tables[0].Rows[0]["F_SENSOR_STATUS"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_TEMPERATURE_ADJUST_COFF"].ToString() != "")
                    {
                        model.F_TEMPERATURE_ADJUST_COFF = decimal.Parse(ds.Tables[0].Rows[0]["F_TEMPERATURE_ADJUST_COFF"].ToString());
                    }
                    model.F_MEMO = ds.Tables[0].Rows[0]["F_MEMO"].ToString();
                    model.F_SENSOR_TYPE = ds.Tables[0].Rows[0]["F_SENSOR_TYPE"].ToString();
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
                    model.F_SENSOR_CALIBRATION = ds.Tables[0].Rows[0]["F_SENSOR_CALIBRATION"].ToString();
                    if (ds.Tables[0].Rows[0]["F_DEV_TYPE"].ToString() != "")
                    {
                        model.F_DEV_TYPE = decimal.Parse(ds.Tables[0].Rows[0]["F_DEV_TYPE"].ToString());
                    }
                    model.F_DEV_ID = ds.Tables[0].Rows[0]["F_DEV_ID"].ToString();
                    if (ds.Tables[0].Rows[0]["F_SENSOR_ADDRESS"].ToString() != "")
                    {
                        model.F_SENSOR_ADDRESS = decimal.Parse(ds.Tables[0].Rows[0]["F_SENSOR_ADDRESS"].ToString());
                    }
                    model.F_COM_ADDRESS = ds.Tables[0].Rows[0]["F_COM_ADDRESS"].ToString();
                    if (ds.Tables[0].Rows[0]["F_SENSER_NO"].ToString() != "")
                    {
                        model.F_SENSER_NO = decimal.Parse(ds.Tables[0].Rows[0]["F_SENSER_NO"].ToString());
                    }
                    model.F_SENSOR_POSTION = ds.Tables[0].Rows[0]["F_SENSOR_POSTION"].ToString();

                    return model;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_SENSOR_INFO->GetModel---FAILED", ex);
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
                Log.Info("DalDEV_SENSOR_INFO->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM T_DEV_SENSOR_INFO  where 1=1");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_SENSOR_INFO->GetList---FAILED", ex);
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
                Log.Info("DalDEV_SENSOR_INFO->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                if (Top > 0)
                {
                    strSql.Append(" top " + Top.ToString());
                }
                strSql.Append(" * ");
                strSql.Append(" FROM T_DEV_SENSOR_INFO  where F_DEL=0 ");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                strSql.Append(" order by " + filedOrder);
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_SENSOR_INFO->GetList---FAILED", ex);
                throw ex;
            }

        }
        #endregion Method


    }
}

