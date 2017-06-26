using System;
using System.Data.OracleClient;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using RelayTest.Util.DBUtility;
using log4net;
using RelayTest.Model;

namespace RelayTest.DAL
{
    //上位机基本信息
    public partial class DalDEV_WORKSTATION_INFO : DbHelperOra
    {
        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof (DalDEV_WORKSTATION_INFO));

        #region Method
        /// <summary>
        ///   是否存在该记录
        /// </summary>
        public new bool Exists(string F_WORKSTATION_ID)
        {
            try
            {
                Log.Info("DalDEV_WORKSTATION_INFO->Exists---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select count(1) from T_DEV_WORKSTATION_INFO");
                strSql.Append(" where 1=1 and ");
                strSql.Append(" F_WORKSTATION_ID = :F_WORKSTATION_ID  ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_WORKSTATION_ID;

                Log.Info("DalDEV_WORKSTATION_INFO->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_WORKSTATION_INFO->Exists---FAILED", ex);
                throw ex;
            }
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelDEV_WORKSTATION_INFO model)
        {

            try
            {
                Log.Info("DalDEV_WORKSTATION_INFO->Add---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into T_DEV_WORKSTATION_INFO(");
                strSql.Append("F_WORKSTATION_ID,F_WORKSTATION_NAME,F_WORKSTATION_CALIBRATION,F_WORKSTATION_STATUS,F_WORKSTATION_MEMO,F_CREATE_TIME,F_OPERATOR_ID,F_OPERATIONTIME,F_DEL");
                strSql.Append(") values (");
                strSql.Append(":F_WORKSTATION_ID,:F_WORKSTATION_NAME,:F_WORKSTATION_CALIBRATION,:F_WORKSTATION_STATUS,:F_WORKSTATION_MEMO,:F_CREATE_TIME,:F_OPERATOR_ID,:F_OPERATIONTIME,:F_DEL");
                strSql.Append(") ");

                OracleParameter[] parameters = {
			            new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_WORKSTATION_NAME", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_WORKSTATION_CALIBRATION", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_WORKSTATION_STATUS", OracleType.Number,4) ,            
                        new OracleParameter(":F_WORKSTATION_MEMO", OracleType.VarChar,500) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };

                if (model.F_WORKSTATION_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_WORKSTATION_ID;
                }

                if (model.F_WORKSTATION_NAME == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_WORKSTATION_NAME;
                }

                if (model.F_WORKSTATION_CALIBRATION == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_WORKSTATION_CALIBRATION;
                }

                if (model.F_WORKSTATION_STATUS == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_WORKSTATION_STATUS;
                }

                if (model.F_WORKSTATION_MEMO == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_WORKSTATION_MEMO;
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
                Log.Error("DalDEV_WORKSTATION_INFO->Add---FAILED", ex);
                throw ex;
            }
        }




        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(RelayTest.Model.ModelDEV_WORKSTATION_INFO model)
        {

            try
            {
                Log.Info("DalDEV_WORKSTATION_INFO->Update---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update T_DEV_WORKSTATION_INFO set ");

                strSql.Append(" F_WORKSTATION_ID = :F_WORKSTATION_ID , ");
                strSql.Append(" F_WORKSTATION_NAME = :F_WORKSTATION_NAME , ");
                strSql.Append(" F_WORKSTATION_CALIBRATION = :F_WORKSTATION_CALIBRATION , ");
                strSql.Append(" F_WORKSTATION_STATUS = :F_WORKSTATION_STATUS , ");
                strSql.Append(" F_WORKSTATION_MEMO = :F_WORKSTATION_MEMO , ");
                strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");
                strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");
                strSql.Append(" F_DEL = :F_DEL  ");
                strSql.Append(" where F_WORKSTATION_ID=:F_WORKSTATION_ID  ");

                OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_WORKSTATION_NAME", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_WORKSTATION_CALIBRATION", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_WORKSTATION_STATUS", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_WORKSTATION_MEMO", OracleType.VarChar,500) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
                if (model.F_WORKSTATION_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_WORKSTATION_ID;
                }
                if (model.F_WORKSTATION_NAME == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_WORKSTATION_NAME;
                }
                if (model.F_WORKSTATION_CALIBRATION == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_WORKSTATION_CALIBRATION;
                }
                if (model.F_WORKSTATION_STATUS == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_WORKSTATION_STATUS;
                }
                if (model.F_WORKSTATION_MEMO == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_WORKSTATION_MEMO;
                }
                if (model.F_OPERATOR_ID == null)
                {
                    parameters[5].Value = DBNull.Value;
                }
                else
                {
                    parameters[5].Value = model.F_OPERATOR_ID;
                }
                if (model.F_OPERATIONTIME == null)
                {
                    parameters[6].Value = DBNull.Value;
                }
                else
                {
                    parameters[6].Value = model.F_OPERATIONTIME;
                }
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
                Log.Error("DalDEV_WORKSTATION_INFO->Update---FAILED", ex);
                throw ex;
            }




        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_WORKSTATION_ID)
        {

            try
            {
                Log.Info("DalDEV_WORKSTATION_INFO->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_WORKSTATION_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_WORKSTATION_ID=:F_WORKSTATION_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_WORKSTATION_ID;


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
                Log.Error("DalDEV_WORKSTATION_INFO->Delete---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_WORKSTATION_ID)
        {

            try
            {
                Log.Info("DalDEV_WORKSTATION_INFO->Disabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_WORKSTATION_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_WORKSTATION_ID=:F_WORKSTATION_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_WORKSTATION_ID;


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
                Log.Error("DalDEV_WORKSTATION_INFO->Disabled---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_WORKSTATION_ID)
        {

            try
            {
                Log.Info("DalDEV_WORKSTATION_INFO->Enabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_WORKSTATION_INFO  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_WORKSTATION_ID=:F_WORKSTATION_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_WORKSTATION_ID;


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
                Log.Error("DalDEV_WORKSTATION_INFO->Enabled---FAILED", ex);
                throw ex;
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool Drop(string F_WORKSTATION_ID)
        {

            try
            {
                Log.Info("DalDEV_WORKSTATION_INFO->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM  T_DEV_WORKSTATION_INFO  ");
                strSql.Append(" where F_WORKSTATION_ID=:F_WORKSTATION_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_WORKSTATION_ID;


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
                Log.Error("DalDEV_WORKSTATION_INFO->Delete---FAILED", ex);
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
                Log.Info("DalDEV_WORKSTATION_INFO->DeleteWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_WORKSTATION_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalDEV_WORKSTATION_INFO->DeleteWhere---FAILED", ex);
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
                Log.Info("DalDEV_WORKSTATION_INFO->DropWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("delete from  T_DEV_WORKSTATION_INFO  ");
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
                Log.Error("DalDEV_WORKSTATION_INFO->DropWhere---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelDEV_WORKSTATION_INFO GetModel(string F_WORKSTATION_ID)
        {
            try
            {
                Log.Info("DalDEV_WORKSTATION_INFO->GetModel---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select F_WORKSTATION_ID, F_WORKSTATION_NAME, F_WORKSTATION_CALIBRATION, F_WORKSTATION_STATUS, F_WORKSTATION_MEMO, F_CREATE_TIME, F_OPERATOR_ID, F_OPERATIONTIME, F_DEL  ");
                strSql.Append("  from T_DEV_WORKSTATION_INFO ");
                strSql.Append(" where 1=1 AND  F_WORKSTATION_ID=:F_WORKSTATION_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_WORKSTATION_ID;


                RelayTest.Model.ModelDEV_WORKSTATION_INFO model = new RelayTest.Model.ModelDEV_WORKSTATION_INFO();
                DataSet ds = Query(strSql.ToString(), parameters);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    model.F_WORKSTATION_ID = ds.Tables[0].Rows[0]["F_WORKSTATION_ID"].ToString();
                    model.F_WORKSTATION_NAME = ds.Tables[0].Rows[0]["F_WORKSTATION_NAME"].ToString();
                    model.F_WORKSTATION_CALIBRATION = ds.Tables[0].Rows[0]["F_WORKSTATION_CALIBRATION"].ToString();
                    if (ds.Tables[0].Rows[0]["F_WORKSTATION_STATUS"].ToString() != "")
                    {
                        model.F_WORKSTATION_STATUS = decimal.Parse(ds.Tables[0].Rows[0]["F_WORKSTATION_STATUS"].ToString());
                    }
                    model.F_WORKSTATION_MEMO = ds.Tables[0].Rows[0]["F_WORKSTATION_MEMO"].ToString();
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
                Log.Error("DalDEV_WORKSTATION_INFO->GetModel---FAILED", ex);
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
                Log.Info("DalDEV_WORKSTATION_INFO->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM T_DEV_WORKSTATION_INFO  where 1=1");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_WORKSTATION_INFO->GetList---FAILED", ex);
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
                Log.Info("DalDEV_WORKSTATION_INFO->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                if (Top > 0)
                {
                    strSql.Append(" top " + Top.ToString());
                }
                strSql.Append(" * ");
                strSql.Append(" FROM T_DEV_WORKSTATION_INFO  where F_DEL=0 ");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                strSql.Append(" order by " + filedOrder);
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_WORKSTATION_INFO->GetList---FAILED", ex);
                throw ex;
            }

        }
        #endregion Method
        #region Extension

        /// <summary>
        /// 根据上位机编号获得相关联的供电柜
        /// </summary>
        /// <param name="workstationId">上位机编号</param>
        /// <returns></returns>
        public DataSet GetPowersRelatedToWorkstation(string workstationId)
        {
            try
            {
                Log.Info("DalDEV_WORKSTATION_INFO->GetPowersRelatedToWorkstation---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("	SELECT (SELECT COUNT (*)	");
                strSql.Append("	          FROM T_DEV_WORK_TO_POWER	");
                strSql.Append("	         WHERE     T_DEV_WORK_TO_POWER.F_WORKSTATION_ID = :F_WORKSTATION_ID	");
                strSql.Append("	               AND T_DEV_WORK_TO_POWER.F_POWER_ID =	");
                strSql.Append("	                      T_DEV_POWER_INFO.F_POWER_ID	");
                strSql.Append("	               AND ROWNUM <= 1)	");
                strSql.Append("	          F_CHECK,	");
                strSql.Append("	       F_POWER_ID ,	");
                strSql.Append("	       F_POWER_NAME 	");
                strSql.Append("	  FROM T_DEV_POWER_INFO	");


                OracleParameter[] parameters =
                {
                    new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar, 20)
                };
                parameters[0].Value = workstationId;


                return Query(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_WORKSTATION_INFO->GetPowersRelatedToWorkstation---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 根据上位机编号获得相关联的下位机
        /// </summary>
        /// <param name="workstationId">上位机编号</param>
        /// <returns></returns>
        public DataSet GetSubordinatesRelatedToWorkstation(string workstationId)
        {
            try
            {
                Log.Info("DalDEV_WORKSTATION_INFO->GetPowersRelatedToWorkstation---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("	SELECT (SELECT COUNT (*)	");
                strSql.Append("	          FROM T_DEV_WORK_TO_SUB	");
                strSql.Append("	         WHERE     T_DEV_WORK_TO_SUB.F_WORKSTATION_ID = :F_WORKSTATION_ID	");
                strSql.Append("	               AND T_DEV_WORK_TO_SUB.F_SUBORDINATE_ID =	");
                strSql.Append("	                      T_DEV_SUBORDINATE_INFO.F_SUBORDINATE_ID	");
                strSql.Append("	               AND ROWNUM <= 1)	");
                strSql.Append("	          F_CHECK,	");
                strSql.Append("	       F_SUBORDINATE_ID ,	");
                strSql.Append("	       F_SUBORDINATE_NAME 	");
                strSql.Append("	  FROM T_DEV_SUBORDINATE_INFO	");


                OracleParameter[] parameters =
                {
                    new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar, 20)
                };
                parameters[0].Value = workstationId;


                DataSet ds = Query(strSql.ToString(), parameters);

                return ds;
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_WORKSTATION_INFO->GetPowersRelatedToWorkstation---FAILED", ex);
                throw ex;
            }
        }


        /// <summary>
        /// 根据上位机编号获得相关联的线圈电源
        /// </summary>
        /// <param name="workstationId">上位机编号</param>
        /// <returns></returns>
        public DataSet GetCoilPowersRelatedToWorkstation(string workstationId)
        {
            try
            {
                Log.Info("DalDEV_WORKSTATION_INFO->GetCoilPowersRelatedToWorkstation---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("	SELECT (SELECT COUNT (*)	");
                strSql.Append("	          FROM T_DEV_WORK_TO_COILPOWER	");
                strSql.Append("	         WHERE     T_DEV_WORK_TO_COILPOWER.F_WORKSTATION_ID = :F_WORKSTATION_ID	");
                strSql.Append("	               AND T_DEV_WORK_TO_COILPOWER.F_COILPOWER_ID =	");
                strSql.Append("	                      T_DEV_COILPOWER_INFO.F_COILPOWER_ID	");
                strSql.Append("	               AND ROWNUM <= 1)	");
                strSql.Append("	          F_CHECK,	");
                strSql.Append("	       F_COILPOWER_ID ,	");
                strSql.Append("	       F_COILPOWER_NAME 	");
                strSql.Append("	  FROM T_DEV_COILPOWER_INFO	");


                OracleParameter[] parameters =
                {
                    new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar, 20)
                };
                parameters[0].Value = workstationId;


                DataSet ds = Query(strSql.ToString(), parameters);

                return ds;
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_WORKSTATION_INFO->GetCoilPowersRelatedToWorkstation---FAILED", ex);
                throw ex;
            }
        }


        /// <summary>
        /// 根据上位机编号获得相关联的传感器
        /// </summary>
        /// <param name="workstationId">上位机编号</param>
        /// <returns></returns>
        public DataSet GetSensorsRelatedToWorkstation(string workstationId)
        {
            try
            {
                Log.Info("DalDEV_WORKSTATION_INFO->GetSensorsRelatedToWorkstation---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("	SELECT (SELECT COUNT (*)	");
                strSql.Append("	          FROM T_DEV_WORK_TO_SENSOR	");
                strSql.Append("	         WHERE     T_DEV_WORK_TO_SENSOR.F_WORKSTATION_ID = :F_WORKSTATION_ID	");
                strSql.Append("	               AND T_DEV_WORK_TO_SENSOR.F_SENSOR_ID =	");
                strSql.Append("	                      T_DEV_SENSOR_INFO.F_SENSOR_ID	");
                strSql.Append("	               AND ROWNUM <= 1)	");
                strSql.Append("	          F_CHECK,	");
                strSql.Append("	       F_SENSOR_ID ,	");
                strSql.Append("	       F_SENSOR_TYPE 	");
                strSql.Append("	  FROM T_DEV_SENSOR_INFO	");


                OracleParameter[] parameters =
                {
                    new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar, 20)
                };
                parameters[0].Value = workstationId;


                DataSet ds = Query(strSql.ToString(), parameters);

                return ds;
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_WORKSTATION_INFO->GetSensorsRelatedToWorkstation---FAILED", ex);
                throw ex;
            }
        }


        /// <summary>
        /// 保存关系
        /// </summary>
        /// <param name="relationType">关系类别1配电柜，2下位机，3线圈电源，4传感器</param>
        /// <param name="model"></param>
        public void AddRelation(int relationType, ModelDEVRelationComm model)
        {
            try
            {
                Log.Info("DalDEV_WORKSTATION_INFO->AddRelation---START");
                StringBuilder strSql = new StringBuilder();
                switch (relationType)
                {
                    case 0:
                    {
                        strSql.Append("	INSERT INTO T_DEV_WORK_TO_POWER ( 	");
                        break;
                    }
                    case 1:
                    {
                        strSql.Append("	INSERT INTO T_DEV_WORK_TO_SUB ( 	");
                        break;
                    }
                    case 2:
                    {
                        strSql.Append("	INSERT INTO T_DEV_WORK_TO_COILPOWER ( 	");
                        break;
                    }
                    case 3:
                    {
                        strSql.Append("	INSERT INTO T_DEV_WORK_TO_SENSOR ( 	");
                        break;
                    }
                }
                strSql.Append("	F_WORKSTATION_ID ,	");
                strSql.Append("	F_WORKSTATION_NAME ,	");
                switch (relationType)
                {
                    case 0:
                    {
                        strSql.Append("	F_POWER_ID ,	");
                        strSql.Append("	F_POWER_NAME ,	");
                        break;
                    }
                    case 1:
                    {
                        strSql.Append("	F_SUBORDINATE_ID ,	");
                        strSql.Append("	F_SUBORDINATE_NAME ,	");
                        break;
                    }
                    case 2:
                    {
                        strSql.Append("	F_COILPOWER_ID ,	");
                        strSql.Append("	F_COILPOWER_NAME ,	");
                        break;
                    }
                    case 3:
                    {
                        strSql.Append("	F_SENSOR_ID ,	");

                        break;
                    }
                }

                strSql.Append("	F_MEMO ,	");
                strSql.Append("	F_CREATE_TIME ,	");
                strSql.Append("	F_OPERATOR_ID ,	");
                strSql.Append("	F_OPERATIONTIME ,	");
                strSql.Append("	F_DEL )	");
                strSql.Append(" values (");
                strSql.Append(":F_WORKSTATION_ID,:F_WORKSTATION_NAME,");
                strSql.Append(":F_POWER_ID,");


                if (relationType != 3)
                {
                    strSql.Append(":F_POWER_NAME,");
                }


                strSql.Append(":F_MEMO,:F_CREATE_TIME,:F_OPERATOR_ID,:F_OPERATIONTIME,:F_DEL");
                strSql.Append(") ");


                if (relationType != 3)
                {
                    OracleParameter[] parameters =
                    {
                        new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar, 20),
                        new OracleParameter(":F_WORKSTATION_NAME", OracleType.VarChar, 100),
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
                else
                {
                    OracleParameter[] parameters =
                    {
                        new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar, 20),
                        new OracleParameter(":F_WORKSTATION_NAME", OracleType.VarChar, 100),
                        new OracleParameter(":F_POWER_ID", OracleType.VarChar, 20),
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


                    if (model.F_MEMO == null)
                    {
                        parameters[3].Value = DBNull.Value;
                    }
                    else
                    {
                        parameters[3].Value = model.F_MEMO;
                    }

                    if (model.F_CREATE_TIME == null)
                    {
                        parameters[4].Value = DBNull.Value;
                    }
                    else
                    {
                        parameters[4].Value = model.F_CREATE_TIME;
                    }

                    if (model.F_OPERATOR_ID == null)
                    {
                        parameters[5].Value = DBNull.Value;
                    }
                    else
                    {
                        parameters[5].Value = model.F_OPERATOR_ID;
                    }

                    if (model.F_OPERATIONTIME == null)
                    {
                        parameters[6].Value = DBNull.Value;
                    }
                    else
                    {
                        parameters[6].Value = model.F_OPERATIONTIME;
                    }

                    if (model.F_DEL == null)
                    {
                        parameters[7].Value = DBNull.Value;
                    }
                    else
                    {
                        parameters[7].Value = model.F_DEL;
                    }
                    ExecuteSql(strSql.ToString(), parameters);
                }


                
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_WORKSTATION_INFO->AddRelation---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 删除关系
        /// </summary>
        /// <param name="relationType">关系类别1配电柜，2下位机，3线圈电源，4传感器</param>
        /// <param name="workStation">工作站编号</param>
        public void DeleteRelation(int relationType, string workStation)
        {
            try
            {
                Log.Info("DalDEV_WORKSTATION_INFO->DeleteRelation---START");
                StringBuilder strSql = new StringBuilder();
                

                switch (relationType)
                {
                    case 0:
                        {
                            strSql.Append("DELETE FROM  T_DEV_WORK_TO_POWER  ");
                            break;
                        }
                    case 1:
                        {
                            strSql.Append("DELETE FROM  T_DEV_WORK_TO_SUB  ");
                            break;
                        }
                    case 2:
                        {
                            strSql.Append("DELETE FROM  T_DEV_WORK_TO_COILPOWER  ");
                            break;
                        }
                    case 3:
                        {
                            strSql.Append("DELETE FROM  T_DEV_WORK_TO_SENSOR  ");
                            break;
                        }
                }
                strSql.Append(" where F_WORKSTATION_ID=:FMasterId ");
                OracleParameter[] parameters =
                {
                    new OracleParameter(":FMasterId", OracleType.VarChar, 20)
                };
                parameters[0].Value = workStation;


                ExecuteSql(strSql.ToString(), parameters);
               
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_WORKSTATION_INFO->DeleteRelation---FAILED", ex);
                throw ex;
            }
        }

        #endregion

        
    }
}