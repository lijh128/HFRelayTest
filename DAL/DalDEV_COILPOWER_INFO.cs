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
	 	//线圈电源基本信息
		public partial class DalDEV_COILPOWER_INFO:DbHelperOra
	{
   		     
   		     
   		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalDEV_COILPOWER_INFO));

        #region Method
        /// <summary>
        ///   是否存在该记录
        /// </summary>
        public new bool Exists(string F_COILPOWER_ID)
        {
            try
            {
                Log.Info("DalDEV_COILPOWER_INFO->Exists---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select count(1) from T_DEV_COILPOWER_INFO");
                strSql.Append(" where 1=1 and ");
                strSql.Append(" F_COILPOWER_ID = :F_COILPOWER_ID  ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_COILPOWER_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_COILPOWER_ID;

                Log.Info("DalDEV_COILPOWER_INFO->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_COILPOWER_INFO->Exists---FAILED", ex);
                throw ex;
            }
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelDEV_COILPOWER_INFO model)
        {

            try
            {
                Log.Info("DalDEV_COILPOWER_INFO->Add---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into T_DEV_COILPOWER_INFO(");

                //线圈电源编号
                strSql.Append("  F_COILPOWER_ID,");
                //线圈电源输出功率
                strSql.Append("  F_COILPOWER_POWER,");
                //线圈电源运行状态
                strSql.Append("  F_COILPOWER_RUN_STATUS,");
                //备注
                strSql.Append("  F_COILPOWER_MEMO,");
                //创建时间
                strSql.Append("  F_CREATE_TIME,");
                //操作员
                strSql.Append("  F_OPERATOR_ID,");
                //操作时间
                strSql.Append("  F_OPERATIONTIME,");
                //是否删除
                strSql.Append("  F_DEL,");
                //线圈电源名称
                strSql.Append("  F_COILPOWER_NAME,");
                //校准编号
                strSql.Append("  F_COILPOWER_CALIBRATION,");
                //通信端口
                strSql.Append("  F_COM_ADDRESS,");
                //通信地址
                strSql.Append("  F_COILPOWER_ADDRESS,");
                //线圈电源输出电压上限
                strSql.Append("  F_COILPOWER_VOLTAGE_CEILING,");
                //线圈电源输出电压下限
                strSql.Append("  F_COILPOWER_VOLTAGE_FLOOR,");
                //线圈电源输出电流上限
                strSql.Append("  F_COILPOWER_CURRENT_CEILING,");
                //线圈电源输出电流下限
                strSql.Append("  F_COILPOWER_CURRENT_FLOOR");
                strSql.Append(") values (");
                strSql.Append(" :F_COILPOWER_ID,");
                strSql.Append(" :F_COILPOWER_POWER,");
                strSql.Append(" :F_COILPOWER_RUN_STATUS,");
                strSql.Append(" :F_COILPOWER_MEMO,");
                strSql.Append(" :F_CREATE_TIME,");
                strSql.Append(" :F_OPERATOR_ID,");
                strSql.Append(" :F_OPERATIONTIME,");
                strSql.Append(" :F_DEL,");
                strSql.Append(" :F_COILPOWER_NAME,");
                strSql.Append(" :F_COILPOWER_CALIBRATION,");
                strSql.Append(" :F_COM_ADDRESS,");
                strSql.Append(" :F_COILPOWER_ADDRESS,");
                strSql.Append(" :F_COILPOWER_VOLTAGE_CEILING,");
                strSql.Append(" :F_COILPOWER_VOLTAGE_FLOOR,");
                strSql.Append(" :F_COILPOWER_CURRENT_CEILING,");
                strSql.Append(" :F_COILPOWER_CURRENT_FLOOR");
                strSql.Append(") ");

                OracleParameter[] parameters = {
			            new OracleParameter(":F_COILPOWER_ID", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_COILPOWER_POWER", OracleType.Number,18) ,            
                        new OracleParameter(":F_COILPOWER_RUN_STATUS", OracleType.Number,4) ,            
                        new OracleParameter(":F_COILPOWER_MEMO", OracleType.VarChar,500) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4) ,            
                        new OracleParameter(":F_COILPOWER_NAME", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_COILPOWER_CALIBRATION", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_COM_ADDRESS", OracleType.VarChar,500) ,            
                        new OracleParameter(":F_COILPOWER_ADDRESS", OracleType.Number,4) ,            
                        new OracleParameter(":F_COILPOWER_VOLTAGE_CEILING", OracleType.Number,18) ,            
                        new OracleParameter(":F_COILPOWER_VOLTAGE_FLOOR", OracleType.Number,18) ,            
                        new OracleParameter(":F_COILPOWER_CURRENT_CEILING", OracleType.Number,18) ,            
                        new OracleParameter(":F_COILPOWER_CURRENT_FLOOR", OracleType.Number,18)             
              
            };

                //线圈电源编号
                if (model.F_COILPOWER_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_COILPOWER_ID;
                }

                //线圈电源输出功率
                if (model.F_COILPOWER_POWER == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_COILPOWER_POWER;
                }

                //线圈电源运行状态
                if (model.F_COILPOWER_RUN_STATUS == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_COILPOWER_RUN_STATUS;
                }

                //备注
                if (model.F_COILPOWER_MEMO == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_COILPOWER_MEMO;
                }

                //创建时间
                if (model.F_CREATE_TIME == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_CREATE_TIME;
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

                //线圈电源名称
                if (model.F_COILPOWER_NAME == null)
                {
                    parameters[8].Value = DBNull.Value;
                }
                else
                {
                    parameters[8].Value = model.F_COILPOWER_NAME;
                }

                //校准编号
                if (model.F_COILPOWER_CALIBRATION == null)
                {
                    parameters[9].Value = DBNull.Value;
                }
                else
                {
                    parameters[9].Value = model.F_COILPOWER_CALIBRATION;
                }

                //通信端口
                if (model.F_COM_ADDRESS == null)
                {
                    parameters[10].Value = DBNull.Value;
                }
                else
                {
                    parameters[10].Value = model.F_COM_ADDRESS;
                }

                //通信地址
                if (model.F_COILPOWER_ADDRESS == null)
                {
                    parameters[11].Value = DBNull.Value;
                }
                else
                {
                    parameters[11].Value = model.F_COILPOWER_ADDRESS;
                }

                //线圈电源输出电压上限
                if (model.F_COILPOWER_VOLTAGE_CEILING == null)
                {
                    parameters[12].Value = DBNull.Value;
                }
                else
                {
                    parameters[12].Value = model.F_COILPOWER_VOLTAGE_CEILING;
                }

                //线圈电源输出电压下限
                if (model.F_COILPOWER_VOLTAGE_FLOOR == null)
                {
                    parameters[13].Value = DBNull.Value;
                }
                else
                {
                    parameters[13].Value = model.F_COILPOWER_VOLTAGE_FLOOR;
                }

                //线圈电源输出电流上限
                if (model.F_COILPOWER_CURRENT_CEILING == null)
                {
                    parameters[14].Value = DBNull.Value;
                }
                else
                {
                    parameters[14].Value = model.F_COILPOWER_CURRENT_CEILING;
                }

                //线圈电源输出电流下限
                if (model.F_COILPOWER_CURRENT_FLOOR == null)
                {
                    parameters[15].Value = DBNull.Value;
                }
                else
                {
                    parameters[15].Value = model.F_COILPOWER_CURRENT_FLOOR;
                }

                ExecuteSql(strSql.ToString(), parameters);

            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_COILPOWER_INFO->Add---FAILED", ex);
                throw ex;
            }
        }




        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(RelayTest.Model.ModelDEV_COILPOWER_INFO model)
        {

            try
            {
                Log.Info("DalDEV_COILPOWER_INFO->Update---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update T_DEV_COILPOWER_INFO set ");

                //线圈电源编号
                strSql.Append(" F_COILPOWER_ID = :F_COILPOWER_ID , ");

                //线圈电源输出功率
                strSql.Append(" F_COILPOWER_POWER = :F_COILPOWER_POWER , ");

                //线圈电源运行状态
                strSql.Append(" F_COILPOWER_RUN_STATUS = :F_COILPOWER_RUN_STATUS , ");

                //备注
                strSql.Append(" F_COILPOWER_MEMO = :F_COILPOWER_MEMO , ");

                //操作员
                strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");

                //操作时间
                strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");

                //是否删除
                strSql.Append(" F_DEL = :F_DEL , ");

                //线圈电源名称
                strSql.Append(" F_COILPOWER_NAME = :F_COILPOWER_NAME , ");

                //校准编号
                strSql.Append(" F_COILPOWER_CALIBRATION = :F_COILPOWER_CALIBRATION , ");

                //通信端口
                strSql.Append(" F_COM_ADDRESS = :F_COM_ADDRESS , ");

                //通信地址
                strSql.Append(" F_COILPOWER_ADDRESS = :F_COILPOWER_ADDRESS , ");

                //线圈电源输出电压上限
                strSql.Append(" F_COILPOWER_VOLTAGE_CEILING = :F_COILPOWER_VOLTAGE_CEILING , ");

                //线圈电源输出电压下限
                strSql.Append(" F_COILPOWER_VOLTAGE_FLOOR = :F_COILPOWER_VOLTAGE_FLOOR , ");

                //线圈电源输出电流上限
                strSql.Append(" F_COILPOWER_CURRENT_CEILING = :F_COILPOWER_CURRENT_CEILING , ");

                //线圈电源输出电流下限
                strSql.Append(" F_COILPOWER_CURRENT_FLOOR = :F_COILPOWER_CURRENT_FLOOR  ");

                strSql.Append(" where F_COILPOWER_ID=:F_COILPOWER_ID  ");

                OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_COILPOWER_ID", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_COILPOWER_POWER", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_COILPOWER_RUN_STATUS", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_COILPOWER_MEMO", OracleType.VarChar,500) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_COILPOWER_NAME", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_COILPOWER_CALIBRATION", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_COM_ADDRESS", OracleType.VarChar,500) ,            
                        	
            new OracleParameter(":F_COILPOWER_ADDRESS", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_COILPOWER_VOLTAGE_CEILING", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_COILPOWER_VOLTAGE_FLOOR", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_COILPOWER_CURRENT_CEILING", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_COILPOWER_CURRENT_FLOOR", OracleType.Number,18)             
              
            };
                //线圈电源编号
                if (model.F_COILPOWER_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_COILPOWER_ID;
                }
                //线圈电源输出功率
                if (model.F_COILPOWER_POWER == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_COILPOWER_POWER;
                }
                //线圈电源运行状态
                if (model.F_COILPOWER_RUN_STATUS == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_COILPOWER_RUN_STATUS;
                }
                //备注
                if (model.F_COILPOWER_MEMO == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_COILPOWER_MEMO;
                }
                //操作员
                if (model.F_OPERATOR_ID == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_OPERATOR_ID;
                }
                //操作时间
                if (model.F_OPERATIONTIME == null)
                {
                    parameters[5].Value = DBNull.Value;
                }
                else
                {
                    parameters[5].Value = model.F_OPERATIONTIME;
                }
                //是否删除
                if (model.F_DEL == null)
                {
                    parameters[6].Value = DBNull.Value;
                }
                else
                {
                    parameters[6].Value = model.F_DEL;
                }
                //线圈电源名称
                if (model.F_COILPOWER_NAME == null)
                {
                    parameters[7].Value = DBNull.Value;
                }
                else
                {
                    parameters[7].Value = model.F_COILPOWER_NAME;
                }
                //校准编号
                if (model.F_COILPOWER_CALIBRATION == null)
                {
                    parameters[8].Value = DBNull.Value;
                }
                else
                {
                    parameters[8].Value = model.F_COILPOWER_CALIBRATION;
                }
                //通信端口
                if (model.F_COM_ADDRESS == null)
                {
                    parameters[9].Value = DBNull.Value;
                }
                else
                {
                    parameters[9].Value = model.F_COM_ADDRESS;
                }
                //通信地址
                if (model.F_COILPOWER_ADDRESS == null)
                {
                    parameters[10].Value = DBNull.Value;
                }
                else
                {
                    parameters[10].Value = model.F_COILPOWER_ADDRESS;
                }
                //线圈电源输出电压上限
                if (model.F_COILPOWER_VOLTAGE_CEILING == null)
                {
                    parameters[11].Value = DBNull.Value;
                }
                else
                {
                    parameters[11].Value = model.F_COILPOWER_VOLTAGE_CEILING;
                }
                //线圈电源输出电压下限
                if (model.F_COILPOWER_VOLTAGE_FLOOR == null)
                {
                    parameters[12].Value = DBNull.Value;
                }
                else
                {
                    parameters[12].Value = model.F_COILPOWER_VOLTAGE_FLOOR;
                }
                //线圈电源输出电流上限
                if (model.F_COILPOWER_CURRENT_CEILING == null)
                {
                    parameters[13].Value = DBNull.Value;
                }
                else
                {
                    parameters[13].Value = model.F_COILPOWER_CURRENT_CEILING;
                }
                //线圈电源输出电流下限
                if (model.F_COILPOWER_CURRENT_FLOOR == null)
                {
                    parameters[14].Value = DBNull.Value;
                }
                else
                {
                    parameters[14].Value = model.F_COILPOWER_CURRENT_FLOOR;
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
                Log.Error("DalDEV_COILPOWER_INFO->Update---FAILED", ex);
                throw ex;
            }




        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_COILPOWER_ID)
        {

            try
            {
                Log.Info("DalDEV_COILPOWER_INFO->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_COILPOWER_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_COILPOWER_ID=:F_COILPOWER_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_COILPOWER_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_COILPOWER_ID;


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
                Log.Error("DalDEV_COILPOWER_INFO->Delete---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_COILPOWER_ID)
        {

            try
            {
                Log.Info("DalDEV_COILPOWER_INFO->Disabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_COILPOWER_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_COILPOWER_ID=:F_COILPOWER_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_COILPOWER_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_COILPOWER_ID;


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
                Log.Error("DalDEV_COILPOWER_INFO->Disabled---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_COILPOWER_ID)
        {

            try
            {
                Log.Info("DalDEV_COILPOWER_INFO->Enabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_COILPOWER_INFO  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_COILPOWER_ID=:F_COILPOWER_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_COILPOWER_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_COILPOWER_ID;


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
                Log.Error("DalDEV_COILPOWER_INFO->Enabled---FAILED", ex);
                throw ex;
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool Drop(string F_COILPOWER_ID)
        {

            try
            {
                Log.Info("DalDEV_COILPOWER_INFO->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM  T_DEV_COILPOWER_INFO  ");
                strSql.Append(" where F_COILPOWER_ID=:F_COILPOWER_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_COILPOWER_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_COILPOWER_ID;


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
                Log.Error("DalDEV_COILPOWER_INFO->Delete---FAILED", ex);
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
                Log.Info("DalDEV_COILPOWER_INFO->DeleteWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_COILPOWER_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalDEV_COILPOWER_INFO->DeleteWhere---FAILED", ex);
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
                Log.Info("DalDEV_COILPOWER_INFO->DropWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("delete from  T_DEV_COILPOWER_INFO  ");
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
                Log.Error("DalDEV_COILPOWER_INFO->DropWhere---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelDEV_COILPOWER_INFO GetModel(string F_COILPOWER_ID)
        {
            try
            {
                Log.Info("DalDEV_COILPOWER_INFO->GetModel---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                //线圈电源编号
                strSql.Append("F_COILPOWER_ID,  ");
                //线圈电源输出功率
                strSql.Append("F_COILPOWER_POWER,  ");
                //线圈电源运行状态
                strSql.Append("F_COILPOWER_RUN_STATUS,  ");
                //备注
                strSql.Append("F_COILPOWER_MEMO,  ");
                //创建时间
                strSql.Append("F_CREATE_TIME,  ");
                //操作员
                strSql.Append("F_OPERATOR_ID,  ");
                //操作时间
                strSql.Append("F_OPERATIONTIME,  ");
                //是否删除
                strSql.Append("F_DEL,  ");
                //线圈电源名称
                strSql.Append("F_COILPOWER_NAME,  ");
                //校准编号
                strSql.Append("F_COILPOWER_CALIBRATION,  ");
                //通信端口
                strSql.Append("F_COM_ADDRESS,  ");
                //通信地址
                strSql.Append("F_COILPOWER_ADDRESS,  ");
                //线圈电源输出电压上限
                strSql.Append("F_COILPOWER_VOLTAGE_CEILING,  ");
                //线圈电源输出电压下限
                strSql.Append("F_COILPOWER_VOLTAGE_FLOOR,  ");
                //线圈电源输出电流上限
                strSql.Append("F_COILPOWER_CURRENT_CEILING,  ");
                //线圈电源输出电流下限
                strSql.Append("F_COILPOWER_CURRENT_FLOOR  ");
                strSql.Append("  from T_DEV_COILPOWER_INFO ");
                strSql.Append(" where 1=1 AND  F_COILPOWER_ID=:F_COILPOWER_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_COILPOWER_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_COILPOWER_ID;


                RelayTest.Model.ModelDEV_COILPOWER_INFO model = new RelayTest.Model.ModelDEV_COILPOWER_INFO();
                DataSet ds = Query(strSql.ToString(), parameters);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    model.F_COILPOWER_ID = ds.Tables[0].Rows[0]["F_COILPOWER_ID"].ToString();
                    if (ds.Tables[0].Rows[0]["F_COILPOWER_POWER"].ToString() != "")
                    {
                        model.F_COILPOWER_POWER = decimal.Parse(ds.Tables[0].Rows[0]["F_COILPOWER_POWER"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_COILPOWER_RUN_STATUS"].ToString() != "")
                    {
                        model.F_COILPOWER_RUN_STATUS = decimal.Parse(ds.Tables[0].Rows[0]["F_COILPOWER_RUN_STATUS"].ToString());
                    }
                    model.F_COILPOWER_MEMO = ds.Tables[0].Rows[0]["F_COILPOWER_MEMO"].ToString();
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
                    model.F_COILPOWER_NAME = ds.Tables[0].Rows[0]["F_COILPOWER_NAME"].ToString();
                    model.F_COILPOWER_CALIBRATION = ds.Tables[0].Rows[0]["F_COILPOWER_CALIBRATION"].ToString();
                    model.F_COM_ADDRESS = ds.Tables[0].Rows[0]["F_COM_ADDRESS"].ToString();
                    if (ds.Tables[0].Rows[0]["F_COILPOWER_ADDRESS"].ToString() != "")
                    {
                        model.F_COILPOWER_ADDRESS = decimal.Parse(ds.Tables[0].Rows[0]["F_COILPOWER_ADDRESS"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_COILPOWER_VOLTAGE_CEILING"].ToString() != "")
                    {
                        model.F_COILPOWER_VOLTAGE_CEILING = decimal.Parse(ds.Tables[0].Rows[0]["F_COILPOWER_VOLTAGE_CEILING"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_COILPOWER_VOLTAGE_FLOOR"].ToString() != "")
                    {
                        model.F_COILPOWER_VOLTAGE_FLOOR = decimal.Parse(ds.Tables[0].Rows[0]["F_COILPOWER_VOLTAGE_FLOOR"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_COILPOWER_CURRENT_CEILING"].ToString() != "")
                    {
                        model.F_COILPOWER_CURRENT_CEILING = decimal.Parse(ds.Tables[0].Rows[0]["F_COILPOWER_CURRENT_CEILING"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_COILPOWER_CURRENT_FLOOR"].ToString() != "")
                    {
                        model.F_COILPOWER_CURRENT_FLOOR = decimal.Parse(ds.Tables[0].Rows[0]["F_COILPOWER_CURRENT_FLOOR"].ToString());
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
                Log.Error("DalDEV_COILPOWER_INFO->GetModel---FAILED", ex);
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
                Log.Info("DalDEV_COILPOWER_INFO->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM T_DEV_COILPOWER_INFO  where 1=1");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_COILPOWER_INFO->GetList---FAILED", ex);
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
                Log.Info("DalDEV_COILPOWER_INFO->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                if (Top > 0)
                {
                    strSql.Append(" top " + Top.ToString());
                }
                strSql.Append(" * ");
                strSql.Append(" FROM T_DEV_COILPOWER_INFO  where F_DEL=0 ");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                strSql.Append(" order by " + filedOrder);
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_COILPOWER_INFO->GetList---FAILED", ex);
                throw ex;
            }

        }
        #endregion Method


   
	}
}

