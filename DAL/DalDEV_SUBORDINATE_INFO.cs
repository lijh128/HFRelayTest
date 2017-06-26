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
    //下位机基本信息
    public partial class DalDEV_SUBORDINATE_INFO : DbHelperOra
    {


        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalDEV_SUBORDINATE_INFO));

        #region Method
        /// <summary>
        ///   是否存在该记录
        /// </summary>
        public new bool Exists(string F_SUBORDINATE_ID)
        {
            
            try
            {
                
                Log.Info("DalDEV_SUBORDINATE_INFO->Exists---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select count(1) from T_DEV_SUBORDINATE_INFO");
                strSql.Append(" where 1=1 and ");
                strSql.Append(" F_SUBORDINATE_ID = :F_SUBORDINATE_ID  ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_SUBORDINATE_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_SUBORDINATE_ID;

                Log.Info("DalDEV_SUBORDINATE_INFO->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_SUBORDINATE_INFO->Exists---FAILED", ex);
                throw ex;
            }
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(RelayTest.Model.ModelDEV_SUBORDINATE_INFO model)
        {

            try
            {
                Log.Info("DalDEV_SUBORDINATE_INFO->Add---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into T_DEV_SUBORDINATE_INFO(");

                //下位机编号
                strSql.Append("  F_SUBORDINATE_ID,");
                //操作时间
                strSql.Append("  F_OPERATIONTIME,");
                //是否删除
                strSql.Append("  F_DEL,");
                //下位机名称
                strSql.Append("  F_SUBORDINATE_NAME,");
                //校准编号
                strSql.Append("  F_SUBORDINATE_CALIBRATION,");
                //下位机地址
                strSql.Append("  F_SUBORDINATE_ADDRESS,");
                //通信端口地址
                strSql.Append("  F_COM_ADDRESS,");
                //下位机状态
                strSql.Append("  F_SUBORDINATE_STATUS,");
                //备注
                strSql.Append("  F_SUBORDINATE_MEMO,");
                //创建时间
                strSql.Append("  F_CREATE_TIME,");
                //操作员
                strSql.Append("  F_OPERATOR_ID");
                strSql.Append(") values (");
                strSql.Append(" :F_SUBORDINATE_ID,");
                strSql.Append(" :F_OPERATIONTIME,");
                strSql.Append(" :F_DEL,");
                strSql.Append(" :F_SUBORDINATE_NAME,");
                strSql.Append(" :F_SUBORDINATE_CALIBRATION,");
                strSql.Append(" :F_SUBORDINATE_ADDRESS,");
                strSql.Append(" :F_COM_ADDRESS,");
                strSql.Append(" :F_SUBORDINATE_STATUS,");
                strSql.Append(" :F_SUBORDINATE_MEMO,");
                strSql.Append(" :F_CREATE_TIME,");
                strSql.Append(" :F_OPERATOR_ID");
                strSql.Append(") ");

                OracleParameter[] parameters = {
			            new OracleParameter(":F_SUBORDINATE_ID", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4) ,            
                        new OracleParameter(":F_SUBORDINATE_NAME", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_SUBORDINATE_CALIBRATION", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_SUBORDINATE_ADDRESS", OracleType.Number,4) ,            
                        new OracleParameter(":F_COM_ADDRESS", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_SUBORDINATE_STATUS", OracleType.Number,4) ,            
                        new OracleParameter(":F_SUBORDINATE_MEMO", OracleType.VarChar,500) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10)             
              
            };

                //下位机编号
                if (model.F_SUBORDINATE_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_SUBORDINATE_ID;
                }

                //操作时间
                if (model.F_OPERATIONTIME == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_OPERATIONTIME;
                }

                //是否删除
                if (model.F_DEL == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_DEL;
                }

                //下位机名称
                if (model.F_SUBORDINATE_NAME == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_SUBORDINATE_NAME;
                }

                //校准编号
                if (model.F_SUBORDINATE_CALIBRATION == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_SUBORDINATE_CALIBRATION;
                }

                //下位机地址
                if (model.F_SUBORDINATE_ADDRESS == null)
                {
                    parameters[5].Value = DBNull.Value;
                }
                else
                {
                    parameters[5].Value = model.F_SUBORDINATE_ADDRESS;
                }

                //通信端口地址
                if (model.F_COM_ADDRESS == null)
                {
                    parameters[6].Value = DBNull.Value;
                }
                else
                {
                    parameters[6].Value = model.F_COM_ADDRESS;
                }

                //下位机状态
                if (model.F_SUBORDINATE_STATUS == null)
                {
                    parameters[7].Value = DBNull.Value;
                }
                else
                {
                    parameters[7].Value = model.F_SUBORDINATE_STATUS;
                }

                //备注
                if (model.F_SUBORDINATE_MEMO == null)
                {
                    parameters[8].Value = DBNull.Value;
                }
                else
                {
                    parameters[8].Value = model.F_SUBORDINATE_MEMO;
                }

                //创建时间
                if (model.F_CREATE_TIME == null)
                {
                    parameters[9].Value = DBNull.Value;
                }
                else
                {
                    parameters[9].Value = model.F_CREATE_TIME;
                }

                //操作员
                if (model.F_OPERATOR_ID == null)
                {
                    parameters[10].Value = DBNull.Value;
                }
                else
                {
                    parameters[10].Value = model.F_OPERATOR_ID;
                }

                ExecuteSql(strSql.ToString(), parameters);

            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_SUBORDINATE_INFO->Add---FAILED", ex);
                throw ex;
            }
        }




        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(RelayTest.Model.ModelDEV_SUBORDINATE_INFO model)
        {

            try
            {
                Log.Info("DalDEV_SUBORDINATE_INFO->Update---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update T_DEV_SUBORDINATE_INFO set ");

                //下位机编号
                strSql.Append(" F_SUBORDINATE_ID = :F_SUBORDINATE_ID , ");

                //操作时间
                strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");

                //是否删除
                strSql.Append(" F_DEL = :F_DEL , ");

                //下位机名称
                strSql.Append(" F_SUBORDINATE_NAME = :F_SUBORDINATE_NAME , ");

                //校准编号
                strSql.Append(" F_SUBORDINATE_CALIBRATION = :F_SUBORDINATE_CALIBRATION , ");

                //下位机地址
                strSql.Append(" F_SUBORDINATE_ADDRESS = :F_SUBORDINATE_ADDRESS , ");

                //通信端口地址
                strSql.Append(" F_COM_ADDRESS = :F_COM_ADDRESS , ");

                //下位机状态
                strSql.Append(" F_SUBORDINATE_STATUS = :F_SUBORDINATE_STATUS , ");

                //备注
                strSql.Append(" F_SUBORDINATE_MEMO = :F_SUBORDINATE_MEMO , ");

                //操作员
                strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID  ");

                strSql.Append(" where F_SUBORDINATE_ID=:F_SUBORDINATE_ID  ");

                OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_SUBORDINATE_ID", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_SUBORDINATE_NAME", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_SUBORDINATE_CALIBRATION", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_SUBORDINATE_ADDRESS", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_COM_ADDRESS", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_SUBORDINATE_STATUS", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_SUBORDINATE_MEMO", OracleType.VarChar,500) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10)             
              
            };
                //下位机编号
                if (model.F_SUBORDINATE_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_SUBORDINATE_ID;
                }
                //操作时间
                if (model.F_OPERATIONTIME == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_OPERATIONTIME;
                }
                //是否删除
                if (model.F_DEL == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_DEL;
                }
                //下位机名称
                if (model.F_SUBORDINATE_NAME == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_SUBORDINATE_NAME;
                }
                //校准编号
                if (model.F_SUBORDINATE_CALIBRATION == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_SUBORDINATE_CALIBRATION;
                }
                //下位机地址
                if (model.F_SUBORDINATE_ADDRESS == null)
                {
                    parameters[5].Value = DBNull.Value;
                }
                else
                {
                    parameters[5].Value = model.F_SUBORDINATE_ADDRESS;
                }
                //通信端口地址
                if (model.F_COM_ADDRESS == null)
                {
                    parameters[6].Value = DBNull.Value;
                }
                else
                {
                    parameters[6].Value = model.F_COM_ADDRESS;
                }
                //下位机状态
                if (model.F_SUBORDINATE_STATUS == null)
                {
                    parameters[7].Value = DBNull.Value;
                }
                else
                {
                    parameters[7].Value = model.F_SUBORDINATE_STATUS;
                }
                //备注
                if (model.F_SUBORDINATE_MEMO == null)
                {
                    parameters[8].Value = DBNull.Value;
                }
                else
                {
                    parameters[8].Value = model.F_SUBORDINATE_MEMO;
                }
                //操作员
                if (model.F_OPERATOR_ID == null)
                {
                    parameters[9].Value = DBNull.Value;
                }
                else
                {
                    parameters[9].Value = model.F_OPERATOR_ID;
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
                Log.Error("DalDEV_SUBORDINATE_INFO->Update---FAILED", ex);
                throw ex;
            }




        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string F_SUBORDINATE_ID)
        {

            try
            {
                Log.Info("DalDEV_SUBORDINATE_INFO->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_SUBORDINATE_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_SUBORDINATE_ID=:F_SUBORDINATE_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_SUBORDINATE_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_SUBORDINATE_ID;


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
                Log.Error("DalDEV_SUBORDINATE_INFO->Delete---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 禁用一条数据
        /// </summary>
        public bool Disabled(string F_SUBORDINATE_ID)
        {

            try
            {
                Log.Info("DalDEV_SUBORDINATE_INFO->Disabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_SUBORDINATE_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_SUBORDINATE_ID=:F_SUBORDINATE_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_SUBORDINATE_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_SUBORDINATE_ID;


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
                Log.Error("DalDEV_SUBORDINATE_INFO->Disabled---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 启用一条数据
        /// </summary>
        public bool Enabled(string F_SUBORDINATE_ID)
        {

            try
            {
                Log.Info("DalDEV_SUBORDINATE_INFO->Enabled---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_SUBORDINATE_INFO  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_SUBORDINATE_ID=:F_SUBORDINATE_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_SUBORDINATE_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_SUBORDINATE_ID;


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
                Log.Error("DalDEV_SUBORDINATE_INFO->Enabled---FAILED", ex);
                throw ex;
            }

        }

        /// <summary>
        /// 永久删除一条数据
        /// </summary>
        public bool Drop(string F_SUBORDINATE_ID)
        {

            try
            {
                Log.Info("DalDEV_SUBORDINATE_INFO->Delete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM  T_DEV_SUBORDINATE_INFO  ");
                strSql.Append(" where F_SUBORDINATE_ID=:F_SUBORDINATE_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_SUBORDINATE_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_SUBORDINATE_ID;


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
                Log.Error("DalDEV_SUBORDINATE_INFO->Delete---FAILED", ex);
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
                Log.Info("DalDEV_SUBORDINATE_INFO->DeleteWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_DEV_SUBORDINATE_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalDEV_SUBORDINATE_INFO->DeleteWhere---FAILED", ex);
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
                Log.Info("DalDEV_SUBORDINATE_INFO->DropWhere---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("delete from  T_DEV_SUBORDINATE_INFO  ");
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
                Log.Error("DalDEV_SUBORDINATE_INFO->DropWhere---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RelayTest.Model.ModelDEV_SUBORDINATE_INFO GetModel(string F_SUBORDINATE_ID)
        {
            try
            {
                Log.Info("DalDEV_SUBORDINATE_INFO->GetModel---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                //下位机编号
                strSql.Append("F_SUBORDINATE_ID,  ");
                //操作时间
                strSql.Append("F_OPERATIONTIME,  ");
                //是否删除
                strSql.Append("F_DEL,  ");
                //下位机名称
                strSql.Append("F_SUBORDINATE_NAME,  ");
                //校准编号
                strSql.Append("F_SUBORDINATE_CALIBRATION,  ");
                //下位机地址
                strSql.Append("F_SUBORDINATE_ADDRESS,  ");
                //通信端口地址
                strSql.Append("F_COM_ADDRESS,  ");
                //下位机状态
                strSql.Append("F_SUBORDINATE_STATUS,  ");
                //备注
                strSql.Append("F_SUBORDINATE_MEMO,  ");
                //创建时间
                strSql.Append("F_CREATE_TIME,  ");
                //操作员
                strSql.Append("F_OPERATOR_ID  ");
                strSql.Append("  from T_DEV_SUBORDINATE_INFO ");
                strSql.Append(" where 1=1 AND  F_SUBORDINATE_ID=:F_SUBORDINATE_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_SUBORDINATE_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_SUBORDINATE_ID;


                RelayTest.Model.ModelDEV_SUBORDINATE_INFO model = new RelayTest.Model.ModelDEV_SUBORDINATE_INFO();
                DataSet ds = Query(strSql.ToString(), parameters);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    model.F_SUBORDINATE_ID = ds.Tables[0].Rows[0]["F_SUBORDINATE_ID"].ToString();
                    if (ds.Tables[0].Rows[0]["F_OPERATIONTIME"].ToString() != "")
                    {
                        model.F_OPERATIONTIME = DateTime.Parse(ds.Tables[0].Rows[0]["F_OPERATIONTIME"].ToString());
                    }
                    if (ds.Tables[0].Rows[0]["F_DEL"].ToString() != "")
                    {
                        model.F_DEL = decimal.Parse(ds.Tables[0].Rows[0]["F_DEL"].ToString());
                    }
                    model.F_SUBORDINATE_NAME = ds.Tables[0].Rows[0]["F_SUBORDINATE_NAME"].ToString();
                    model.F_SUBORDINATE_CALIBRATION = ds.Tables[0].Rows[0]["F_SUBORDINATE_CALIBRATION"].ToString();
                    if (ds.Tables[0].Rows[0]["F_SUBORDINATE_ADDRESS"].ToString() != "")
                    {
                        model.F_SUBORDINATE_ADDRESS = decimal.Parse(ds.Tables[0].Rows[0]["F_SUBORDINATE_ADDRESS"].ToString());
                    }
                    model.F_COM_ADDRESS = ds.Tables[0].Rows[0]["F_COM_ADDRESS"].ToString();
                    if (ds.Tables[0].Rows[0]["F_SUBORDINATE_STATUS"].ToString() != "")
                    {
                        model.F_SUBORDINATE_STATUS = decimal.Parse(ds.Tables[0].Rows[0]["F_SUBORDINATE_STATUS"].ToString());
                    }
                    model.F_SUBORDINATE_MEMO = ds.Tables[0].Rows[0]["F_SUBORDINATE_MEMO"].ToString();
                    if (ds.Tables[0].Rows[0]["F_CREATE_TIME"].ToString() != "")
                    {
                        model.F_CREATE_TIME = DateTime.Parse(ds.Tables[0].Rows[0]["F_CREATE_TIME"].ToString());
                    }
                    model.F_OPERATOR_ID = ds.Tables[0].Rows[0]["F_OPERATOR_ID"].ToString();

                    return model;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_SUBORDINATE_INFO->GetModel---FAILED", ex);
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
                Log.Info("DalDEV_SUBORDINATE_INFO->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM T_DEV_SUBORDINATE_INFO  where 1=1");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_SUBORDINATE_INFO->GetList---FAILED", ex);
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
                Log.Info("DalDEV_SUBORDINATE_INFO->GetList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ");
                if (Top > 0)
                {
                    strSql.Append(" top " + Top.ToString());
                }
                strSql.Append(" * ");
                strSql.Append(" FROM T_DEV_SUBORDINATE_INFO  where F_DEL=0 ");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                strSql.Append(" order by " + filedOrder);
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_SUBORDINATE_INFO->GetList---FAILED", ex);
                throw ex;
            }

        }
        #endregion Method

    }
}

