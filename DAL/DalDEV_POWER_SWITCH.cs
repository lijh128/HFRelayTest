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
    //供电柜开关状态
    public partial class DalDEV_POWER_SWITCH : DbHelperOra
    {


        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalDEV_POWER_SWITCH));

        #region Method
        /// <summary>
        ///   是否存在该记录
        /// </summary>
        public bool Exists(string F_POWER_ID, string F_POWER_SWITCH_ID)
        {
            try
            {
                Log.Info("DalDEV_POWER_SWITCH->Exists---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select count(1) from T_DEV_POWER_SWITCH");
                strSql.Append(" where 1=1 and ");
                strSql.Append(" F_POWER_ID = :F_POWER_ID and  ");
                strSql.Append(" F_POWER_SWITCH_ID = :F_POWER_SWITCH_ID  ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_POWER_ID", OracleType.VarChar,20),
					new OracleParameter(":F_POWER_SWITCH_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_POWER_ID;
                parameters[1].Value = F_POWER_SWITCH_ID;

                Log.Info("DalDEV_POWER_SWITCH->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_POWER_SWITCH->Exists---FAILED", ex);
                throw ex;
            }
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelDEV_POWER_SWITCH model)
        {

            try
            {
                Log.Info("DalDEV_POWER_SWITCH->Add---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into T_DEV_POWER_SWITCH(");

                //供电柜编号
                strSql.Append("  F_POWER_ID,");
                //开关报警阈值(按时长)
                strSql.Append("  F_ALARM_LIFEDURANCE,");
                //开关报警阈值(按使用次数)
                strSql.Append("  F_ALARM_TIMEDURANCE,");
                //开关动作次数
                strSql.Append("  F_SWITCH_TIMES,");
                //创建时间
                strSql.Append("  F_CREATE_TIME,");
                //操作员
                strSql.Append("  F_OPERATOR_ID,");
                //操作时间
                strSql.Append("  F_OPERATIONTIME,");
                //是否删除
                strSql.Append("  F_DEL,");
                //开关序号
                strSql.Append("  F_POWER_SWITCH_ID,");
                //供电柜开关地址
                strSql.Append("  F_POWER_SWITCH_ADDRESS,");
                //通道号
                strSql.Append("  F_COM_ADDRESS,");
                //F_HOLDREG
                strSql.Append("  F_HOLDREG,");
                //校准编号
                strSql.Append("  F_POWER_SWITCH_CALIBRATION,");
                //输入输出类型
                strSql.Append("  F_POWER_SWITCH_TYPE,");
                //供电柜开关状态
                strSql.Append("  F_POWER_SWITCH_STATUS,");
                //负荷容量
                strSql.Append("  F_LOAD_CAPACITY");
                strSql.Append(") values (");
                strSql.Append(" :F_POWER_ID,");
                strSql.Append(" :F_ALARM_LIFEDURANCE,");
                strSql.Append(" :F_ALARM_TIMEDURANCE,");
                strSql.Append(" :F_SWITCH_TIMES,");
                strSql.Append(" :F_CREATE_TIME,");
                strSql.Append(" :F_OPERATOR_ID,");
                strSql.Append(" :F_OPERATIONTIME,");
                strSql.Append(" :F_DEL,");
                strSql.Append(" :F_POWER_SWITCH_ID,");
                strSql.Append(" :F_POWER_SWITCH_ADDRESS,");
                strSql.Append(" :F_COM_ADDRESS,");
                strSql.Append(" :F_HOLDREG,");
                strSql.Append(" :F_POWER_SWITCH_CALIBRATION,");
                strSql.Append(" :F_POWER_SWITCH_TYPE,");
                strSql.Append(" :F_POWER_SWITCH_STATUS,");
                strSql.Append(" :F_LOAD_CAPACITY");
                strSql.Append(") ");

                OracleParameter[] parameters = {
			            new OracleParameter(":F_POWER_ID", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_ALARM_LIFEDURANCE", OracleType.Number,18) ,            
                        new OracleParameter(":F_ALARM_TIMEDURANCE", OracleType.Number,18) ,            
                        new OracleParameter(":F_SWITCH_TIMES", OracleType.Number,18) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4) ,            
                        new OracleParameter(":F_POWER_SWITCH_ID", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_POWER_SWITCH_ADDRESS", OracleType.Number,4) ,            
                        new OracleParameter(":F_COM_ADDRESS", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_HOLDREG", OracleType.Number,4) ,            
                        new OracleParameter(":F_POWER_SWITCH_CALIBRATION", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_POWER_SWITCH_TYPE", OracleType.Number,4) ,            
                        new OracleParameter(":F_POWER_SWITCH_STATUS", OracleType.Number,4) ,            
                        new OracleParameter(":F_LOAD_CAPACITY", OracleType.Number,18)             
              
            };

                //供电柜编号
                if (model.F_POWER_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_POWER_ID;
                }

                //开关报警阈值(按时长)
                if (model.F_ALARM_LIFEDURANCE == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_ALARM_LIFEDURANCE;
                }

                //开关报警阈值(按使用次数)
                if (model.F_ALARM_TIMEDURANCE == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_ALARM_TIMEDURANCE;
                }

                //开关动作次数
                if (model.F_SWITCH_TIMES == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_SWITCH_TIMES;
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

                //开关序号
                if (model.F_POWER_SWITCH_ID == null)
                {
                    parameters[8].Value = DBNull.Value;
                }
                else
                {
                    parameters[8].Value = model.F_POWER_SWITCH_ID;
                }

                //供电柜开关地址
                if (model.F_POWER_SWITCH_ADDRESS == null)
                {
                    parameters[9].Value = DBNull.Value;
                }
                else
                {
                    parameters[9].Value = model.F_POWER_SWITCH_ADDRESS;
                }

                //通道号
                if (model.F_COM_ADDRESS == null)
                {
                    parameters[10].Value = DBNull.Value;
                }
                else
                {
                    parameters[10].Value = model.F_COM_ADDRESS;
                }

                //F_HOLDREG
                if (model.F_HOLDREG == null)
                {
                    parameters[11].Value = DBNull.Value;
                }
                else
                {
                    parameters[11].Value = model.F_HOLDREG;
                }

                //校准编号
                if (model.F_POWER_SWITCH_CALIBRATION == null)
                {
                    parameters[12].Value = DBNull.Value;
                }
                else
                {
                    parameters[12].Value = model.F_POWER_SWITCH_CALIBRATION;
                }

                //输入输出类型
                if (model.F_POWER_SWITCH_TYPE == null)
                {
                    parameters[13].Value = DBNull.Value;
                }
                else
                {
                    parameters[13].Value = model.F_POWER_SWITCH_TYPE;
                }

                //供电柜开关状态
                if (model.F_POWER_SWITCH_STATUS == null)
                {
                    parameters[14].Value = DBNull.Value;
                }
                else
                {
                    parameters[14].Value = model.F_POWER_SWITCH_STATUS;
                }

                //负荷容量
                if (model.F_LOAD_CAPACITY == null)
                {
                    parameters[15].Value = DBNull.Value;
                }
                else
                {
                    parameters[15].Value = model.F_LOAD_CAPACITY;
                }

                ExecuteSql(strSql.ToString(), parameters);

            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_POWER_SWITCH->Add---FAILED", ex);
                throw ex;
            }
        }




        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(RelayTest.Model.ModelDEV_POWER_SWITCH model)
        {

            try
            {
                Log.Info("DalDEV_POWER_SWITCH->Update---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update T_DEV_POWER_SWITCH set ");

                //供电柜编号
                strSql.Append(" F_POWER_ID = :F_POWER_ID , ");

                //开关报警阈值(按时长)
                strSql.Append(" F_ALARM_LIFEDURANCE = :F_ALARM_LIFEDURANCE , ");

                //开关报警阈值(按使用次数)
                strSql.Append(" F_ALARM_TIMEDURANCE = :F_ALARM_TIMEDURANCE , ");

                //开关动作次数
                strSql.Append(" F_SWITCH_TIMES = :F_SWITCH_TIMES , ");

                //操作员
                strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");

                //操作时间
                strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");

                //是否删除
                strSql.Append(" F_DEL = :F_DEL , ");

                //开关序号
                strSql.Append(" F_POWER_SWITCH_ID = :F_POWER_SWITCH_ID , ");

                //供电柜开关地址
                strSql.Append(" F_POWER_SWITCH_ADDRESS = :F_POWER_SWITCH_ADDRESS , ");

                //通道号
                strSql.Append(" F_COM_ADDRESS = :F_COM_ADDRESS , ");

                //F_HOLDREG
                strSql.Append(" F_HOLDREG = :F_HOLDREG , ");

                //校准编号
                strSql.Append(" F_POWER_SWITCH_CALIBRATION = :F_POWER_SWITCH_CALIBRATION , ");

                //输入输出类型
                strSql.Append(" F_POWER_SWITCH_TYPE = :F_POWER_SWITCH_TYPE , ");

                //供电柜开关状态
                strSql.Append(" F_POWER_SWITCH_STATUS = :F_POWER_SWITCH_STATUS , ");

                //负荷容量
                strSql.Append(" F_LOAD_CAPACITY = :F_LOAD_CAPACITY  ");

                strSql.Append(" where F_POWER_ID=:F_POWER_ID and F_POWER_SWITCH_ID=:F_POWER_SWITCH_ID  ");

                OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_POWER_ID", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_ALARM_LIFEDURANCE", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_ALARM_TIMEDURANCE", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_SWITCH_TIMES", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_POWER_SWITCH_ID", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_POWER_SWITCH_ADDRESS", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_COM_ADDRESS", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_HOLDREG", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_POWER_SWITCH_CALIBRATION", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_POWER_SWITCH_TYPE", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_POWER_SWITCH_STATUS", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_LOAD_CAPACITY", OracleType.Number,18)             
              
            };
                //供电柜编号
                if (model.F_POWER_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_POWER_ID;
                }
                //开关报警阈值(按时长)
                if (model.F_ALARM_LIFEDURANCE == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_ALARM_LIFEDURANCE;
                }
                //开关报警阈值(按使用次数)
                if (model.F_ALARM_TIMEDURANCE == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_ALARM_TIMEDURANCE;
                }
                //开关动作次数
                if (model.F_SWITCH_TIMES == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_SWITCH_TIMES;
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
                //开关序号
                if (model.F_POWER_SWITCH_ID == null)
                {
                    parameters[7].Value = DBNull.Value;
                }
                else
                {
                    parameters[7].Value = model.F_POWER_SWITCH_ID;
                }
                //供电柜开关地址
                if (model.F_POWER_SWITCH_ADDRESS == null)
                {
                    parameters[8].Value = DBNull.Value;
                }
                else
                {
                    parameters[8].Value = model.F_POWER_SWITCH_ADDRESS;
                }
                //通道号
                if (model.F_COM_ADDRESS == null)
                {
                    parameters[9].Value = DBNull.Value;
                }
                else
                {
                    parameters[9].Value = model.F_COM_ADDRESS;
                }
                //F_HOLDREG
                if (model.F_HOLDREG == null)
                {
                    parameters[10].Value = DBNull.Value;
                }
                else
                {
                    parameters[10].Value = model.F_HOLDREG;
                }
                //校准编号
                if (model.F_POWER_SWITCH_CALIBRATION == null)
                {
                    parameters[11].Value = DBNull.Value;
                }
                else
                {
                    parameters[11].Value = model.F_POWER_SWITCH_CALIBRATION;
                }
                //输入输出类型
                if (model.F_POWER_SWITCH_TYPE == null)
                {
                    parameters[12].Value = DBNull.Value;
                }
                else
                {
                    parameters[12].Value = model.F_POWER_SWITCH_TYPE;
                }
                //供电柜开关状态
                if (model.F_POWER_SWITCH_STATUS == null)
                {
                    parameters[13].Value = DBNull.Value;
                }
                else
                {
                    parameters[13].Value = model.F_POWER_SWITCH_STATUS;
                }
                //负荷容量
                if (model.F_LOAD_CAPACITY == null)
                {
                    parameters[14].Value = DBNull.Value;
                }
                else
                {
                    parameters[14].Value = model.F_LOAD_CAPACITY;
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
                Log.Error("DalDEV_POWER_SWITCH->Update---FAILED", ex);
                throw ex;
            }




        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_POWER_ID, string F_POWER_SWITCH_ID)
        {

            try
            {
                Log.Info("DalDEV_POWER_SWITCH->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_POWER_SWITCH  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_POWER_ID=:F_POWER_ID and F_POWER_SWITCH_ID=:F_POWER_SWITCH_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_POWER_ID", OracleType.VarChar,20),
					new OracleParameter(":F_POWER_SWITCH_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_POWER_ID;
                parameters[1].Value = F_POWER_SWITCH_ID;


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
                Log.Error("DalDEV_POWER_SWITCH->Delete---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_POWER_ID, string F_POWER_SWITCH_ID)
        {

            try
            {
                Log.Info("DalDEV_POWER_SWITCH->Disabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_POWER_SWITCH  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_POWER_ID=:F_POWER_ID and F_POWER_SWITCH_ID=:F_POWER_SWITCH_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_POWER_ID", OracleType.VarChar,20),
					new OracleParameter(":F_POWER_SWITCH_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_POWER_ID;
                parameters[1].Value = F_POWER_SWITCH_ID;


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
                Log.Error("DalDEV_POWER_SWITCH->Disabled---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_POWER_ID, string F_POWER_SWITCH_ID)
        {

            try
            {
                Log.Info("DalDEV_POWER_SWITCH->Enabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_POWER_SWITCH  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_POWER_ID=:F_POWER_ID and F_POWER_SWITCH_ID=:F_POWER_SWITCH_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_POWER_ID", OracleType.VarChar,20),
					new OracleParameter(":F_POWER_SWITCH_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_POWER_ID;
                parameters[1].Value = F_POWER_SWITCH_ID;


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
                Log.Error("DalDEV_POWER_SWITCH->Enabled---FAILED", ex);
                throw ex;
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool Drop(string F_POWER_ID, string F_POWER_SWITCH_ID)
        {

            try
            {
                Log.Info("DalDEV_POWER_SWITCH->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM  T_DEV_POWER_SWITCH  ");
                strSql.Append(" where F_POWER_ID=:F_POWER_ID and F_POWER_SWITCH_ID=:F_POWER_SWITCH_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_POWER_ID", OracleType.VarChar,20),
					new OracleParameter(":F_POWER_SWITCH_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_POWER_ID;
                parameters[1].Value = F_POWER_SWITCH_ID;


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
                Log.Error("DalDEV_POWER_SWITCH->Delete---FAILED", ex);
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
                Log.Info("DalDEV_POWER_SWITCH->DeleteWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_POWER_SWITCH  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalDEV_POWER_SWITCH->DeleteWhere---FAILED", ex);
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
                Log.Info("DalDEV_POWER_SWITCH->DropWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("delete from  T_DEV_POWER_SWITCH  ");
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
                Log.Error("DalDEV_POWER_SWITCH->DropWhere---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelDEV_POWER_SWITCH GetModel(string F_POWER_ID, string F_POWER_SWITCH_ID)
        {
            try
            {
                Log.Info("DalDEV_POWER_SWITCH->GetModel---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                //供电柜编号
                strSql.Append("F_POWER_ID,  ");
                //开关报警阈值(按时长)
                strSql.Append("F_ALARM_LIFEDURANCE,  ");
                //开关报警阈值(按使用次数)
                strSql.Append("F_ALARM_TIMEDURANCE,  ");
                //开关动作次数
                strSql.Append("F_SWITCH_TIMES,  ");
                //创建时间
                strSql.Append("F_CREATE_TIME,  ");
                //操作员
                strSql.Append("F_OPERATOR_ID,  ");
                //操作时间
                strSql.Append("F_OPERATIONTIME,  ");
                //是否删除
                strSql.Append("F_DEL,  ");
                //开关序号
                strSql.Append("F_POWER_SWITCH_ID,  ");
                //供电柜开关地址
                strSql.Append("F_POWER_SWITCH_ADDRESS,  ");
                //通道号
                strSql.Append("F_COM_ADDRESS,  ");
                //F_HOLDREG
                strSql.Append("F_HOLDREG,  ");
                //校准编号
                strSql.Append("F_POWER_SWITCH_CALIBRATION,  ");
                //输入输出类型
                strSql.Append("F_POWER_SWITCH_TYPE,  ");
                //供电柜开关状态
                strSql.Append("F_POWER_SWITCH_STATUS,  ");
                //负荷容量
                strSql.Append("F_LOAD_CAPACITY  ");
                strSql.Append("  from T_DEV_POWER_SWITCH ");
                strSql.Append(" where 1=1 AND  F_POWER_ID=:F_POWER_ID and F_POWER_SWITCH_ID=:F_POWER_SWITCH_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_POWER_ID", OracleType.VarChar,20),
					new OracleParameter(":F_POWER_SWITCH_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_POWER_ID;
                parameters[1].Value = F_POWER_SWITCH_ID;


                RelayTest.Model.ModelDEV_POWER_SWITCH model = new RelayTest.Model.ModelDEV_POWER_SWITCH();
                DataSet ds = Query(strSql.ToString(), parameters);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    model.F_POWER_ID = ds.Tables[0].Rows[0]["F_POWER_ID"].ToString();
                    if (ds.Tables[0].Rows[0]["F_ALARM_LIFEDURANCE"].ToString() != "")
                    {
                        model.F_ALARM_LIFEDURANCE = decimal.Parse(ds.Tables[0].Rows[0]["F_ALARM_LIFEDURANCE"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_ALARM_TIMEDURANCE"].ToString() != "")
                    {
                        model.F_ALARM_TIMEDURANCE = decimal.Parse(ds.Tables[0].Rows[0]["F_ALARM_TIMEDURANCE"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_SWITCH_TIMES"].ToString() != "")
                    {
                        model.F_SWITCH_TIMES = decimal.Parse(ds.Tables[0].Rows[0]["F_SWITCH_TIMES"].ToString());
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
                    model.F_POWER_SWITCH_ID = ds.Tables[0].Rows[0]["F_POWER_SWITCH_ID"].ToString();
                    if (ds.Tables[0].Rows[0]["F_POWER_SWITCH_ADDRESS"].ToString() != "")
                    {
                        model.F_POWER_SWITCH_ADDRESS = decimal.Parse(ds.Tables[0].Rows[0]["F_POWER_SWITCH_ADDRESS"].ToString());
                    }
                    model.F_COM_ADDRESS = ds.Tables[0].Rows[0]["F_COM_ADDRESS"].ToString();
                    if (ds.Tables[0].Rows[0]["F_HOLDREG"].ToString() != "")
                    {
                        model.F_HOLDREG = decimal.Parse(ds.Tables[0].Rows[0]["F_HOLDREG"].ToString());
                    }
                    model.F_POWER_SWITCH_CALIBRATION = ds.Tables[0].Rows[0]["F_POWER_SWITCH_CALIBRATION"].ToString();
                    if (ds.Tables[0].Rows[0]["F_POWER_SWITCH_TYPE"].ToString() != "")
                    {
                        model.F_POWER_SWITCH_TYPE = decimal.Parse(ds.Tables[0].Rows[0]["F_POWER_SWITCH_TYPE"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_POWER_SWITCH_STATUS"].ToString() != "")
                    {
                        model.F_POWER_SWITCH_STATUS = decimal.Parse(ds.Tables[0].Rows[0]["F_POWER_SWITCH_STATUS"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_LOAD_CAPACITY"].ToString() != "")
                    {
                        model.F_LOAD_CAPACITY = decimal.Parse(ds.Tables[0].Rows[0]["F_LOAD_CAPACITY"].ToString());
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
                Log.Error("DalDEV_POWER_SWITCH->GetModel---FAILED", ex);
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
                Log.Info("DalDEV_POWER_SWITCH->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM T_DEV_POWER_SWITCH  where 1=1");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_POWER_SWITCH->GetList---FAILED", ex);
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
                Log.Info("DalDEV_POWER_SWITCH->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                if (Top > 0)
                {
                    strSql.Append(" top " + Top.ToString());
                }
                strSql.Append(" * ");
                strSql.Append(" FROM T_DEV_POWER_SWITCH  where F_DEL=0 ");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                strSql.Append(" order by " + filedOrder);
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_POWER_SWITCH->GetList---FAILED", ex);
                throw ex;
            }

        }
        #endregion Method


        #region Extension

        /// <summary>
        /// 根据供电柜编号获得开关输入输出关系
        /// </summary>
        /// <param name="powerId">供电柜编号</param>
        /// <param name="inputSwitchId"></param>
        /// <returns></returns>
        public DataSet GetSwitchInputAndOutputRelation(string powerId, string inputSwitchId)
        {
       
      
            try
            {
                Log.Info("DalDEV_POWER_SWITCH->GetPowersRelatedToWorkstation---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("	SELECT (SELECT COUNT (*)	");
                strSql.Append("	          FROM T_DEV_SWITCH_INOUT	");
                strSql.Append("	         WHERE     T_DEV_SWITCH_INOUT.F_POWER_ID = :F_POWER_ID	");
                strSql.Append("	               AND T_DEV_SWITCH_INOUT.F_POWER_ID =	");
                strSql.Append("	                      T_DEV_POWER_SWITCH.F_POWER_ID	");
                strSql.Append("	               AND T_DEV_SWITCH_INOUT.F_POWER_SWITCH_ID_IN =	");
                strSql.Append("	                      :F_POWER_SWITCH_ID	");
                strSql.Append("	               AND T_DEV_SWITCH_INOUT.F_POWER_SWITCH_ID_OUT =	");
                strSql.Append("	                      T_DEV_POWER_SWITCH.F_POWER_SWITCH_ID	");
                strSql.Append("	               AND T_DEV_POWER_SWITCH.F_POWER_SWITCH_TYPE = 0	");
                strSql.Append("	               AND ROWNUM <= 1)	");
                strSql.Append("	          F_CHECK,	");
                strSql.Append("	       F_POWER_SWITCH_ID	");
                strSql.Append("	  FROM T_DEV_POWER_SWITCH	");
                strSql.Append("	 WHERE F_POWER_ID = :F_POWER_ID AND F_POWER_SWITCH_TYPE = 0	");




                OracleParameter[] parameters =
                {
                    new OracleParameter(":F_POWER_ID", OracleType.VarChar, 20),
                    new OracleParameter(":F_POWER_SWITCH_ID", OracleType.VarChar, 20)
                };
                parameters[0].Value = powerId;
                parameters[1].Value = inputSwitchId;


                return Query(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_POWER_SWITCH->GetPowersRelatedToWorkstation---FAILED", ex);
                throw ex;
            }
        }



        /// <summary>
        /// 负载电源与供电柜输入开关关系
        /// </summary>
        /// <param name="loadPowerId">负载电源</param>
        /// <param name="powerId">供电柜</param>
        public DataSet GetLoadPowerToPowerSwitchRelation(string loadPowerId, string powerId)
        {

            try
            {
                Log.Info("DalDEV_POWER_SWITCH->GetLoadPowerToPowerSwitchRelation---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("	SELECT (SELECT COUNT (*)	");
                strSql.Append("	          FROM T_DEV_LOADPOW_TO_SWITCH	");
                strSql.Append("	         WHERE     T_DEV_LOADPOW_TO_SWITCH.F_LOADPOWER_ID = :F_LOADPOWER_ID	");
                strSql.Append("	               AND T_DEV_LOADPOW_TO_SWITCH.F_POWER_ID = :F_POWER_ID	");
                strSql.Append("	               AND T_DEV_LOADPOW_TO_SWITCH.F_POWER_SWITCH_ID =	");
                strSql.Append("	                      T_DEV_POWER_SWITCH.F_POWER_SWITCH_ID	");
                strSql.Append("	               AND ROWNUM <= 1)	");
                strSql.Append("	          F_CHECK,	");
                strSql.Append("	       T_DEV_POWER_SWITCH.F_POWER_SWITCH_ID	");
                strSql.Append("	  FROM T_DEV_POWER_SWITCH	");
                strSql.Append("	 WHERE     T_DEV_POWER_SWITCH.F_POWER_ID = :F_POWER_ID	");
                strSql.Append("	       AND T_DEV_POWER_SWITCH.F_POWER_SWITCH_TYPE = 1	");

                OracleParameter[] parameters =
                {
                    new OracleParameter(":F_POWER_ID", OracleType.VarChar, 20),
                    new OracleParameter(":F_LOADPOWER_ID", OracleType.VarChar, 20)
                };
                parameters[0].Value = powerId;
                parameters[1].Value = loadPowerId;

                return Query(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_POWER_SWITCH->GetLoadPowerToPowerSwitchRelation---FAILED", ex);
                throw ex;
            }
        }


        /// <summary>
        /// 供电柜输出开关与负载柜关系
        /// </summary>
        /// <param name="loadId">负载编号</param>
        /// <param name="powerId">供电柜</param>
        public DataSet GetPowerSwitchToLoadRelation(string loadId, string powerId)
        {

            try
            {
                Log.Info("DalDEV_POWER_SWITCH->GetPowerSwitchToLoadRelation---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("	SELECT (SELECT COUNT (*)	");
                strSql.Append("	          FROM T_DEV_SWITCH_TO_LOAD	");
                strSql.Append("	         WHERE     T_DEV_SWITCH_TO_LOAD.F_LOAD_ID = :F_LOAD_ID	");
                strSql.Append("	               AND T_DEV_SWITCH_TO_LOAD.F_POWER_ID = :F_POWER_ID	");
                strSql.Append("	               AND T_DEV_SWITCH_TO_LOAD.F_POWER_SWITCH_ID =	");
                strSql.Append("	                      T_DEV_POWER_SWITCH.F_POWER_SWITCH_ID	");
                strSql.Append("	               AND ROWNUM <= 1)	");
                strSql.Append("	          F_CHECK,	");
                strSql.Append("	       T_DEV_POWER_SWITCH.F_POWER_SWITCH_ID	");
                strSql.Append("	  FROM T_DEV_POWER_SWITCH	");
                strSql.Append("	 WHERE     T_DEV_POWER_SWITCH.F_POWER_ID = :F_POWER_ID	");
                strSql.Append("	       AND T_DEV_POWER_SWITCH.F_POWER_SWITCH_TYPE = 0	");

                OracleParameter[] parameters =
                {
                    new OracleParameter(":F_POWER_ID", OracleType.VarChar, 20),
                    new OracleParameter(":F_LOAD_ID", OracleType.VarChar, 20)
                };
                parameters[0].Value = powerId;
                parameters[1].Value = loadId;

                return Query(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_POWER_SWITCH->GetPowerSwitchToLoadRelation---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 删除关系
        /// </summary>
        /// <param name="relationType">关系类型0：负载电源，1：负载柜</param>
        /// <param name="powerId"></param>
        /// <param name="devceId">设备编号</param>
        public void DeleteRelation(int relationType, string powerId, string devceId)
        {
            try
            {
                Log.Info("DalDEV_POWER_SWITCH->DeleteRelation---START");
                StringBuilder strSql = new StringBuilder();


                switch (relationType)
                {
                        //负载电源
                    case 0:
                        {
                            strSql.Append("DELETE FROM  T_DEV_LOADPOW_TO_SWITCH  ");
                            strSql.Append(" where F_LOADPOWER_ID=:FMasterId ");
                            strSql.Append(" AND F_POWER_ID=:F_POWER_ID ");

                            break;

                        }
                        //负载柜
                    case 1:
                        {
                            strSql.Append("DELETE FROM  T_DEV_SWITCH_TO_LOAD  ");
                            strSql.Append(" where F_LOAD_ID=:FMasterId ");
                            strSql.Append(" AND F_POWER_ID=:F_POWER_ID ");
                            break;
                        }


                }
                
                OracleParameter[] parameters =
                {
                    new OracleParameter(":FMasterId", OracleType.VarChar, 20),
                    new OracleParameter(":F_POWER_ID", OracleType.VarChar, 20)
                };
                parameters[0].Value = devceId;
                parameters[1].Value = powerId;


                ExecuteSql(strSql.ToString(), parameters);

            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_POWER_SWITCH->DeleteRelation---FAILED", ex);
                throw ex;
            }
        }


        #endregion

    }
}

