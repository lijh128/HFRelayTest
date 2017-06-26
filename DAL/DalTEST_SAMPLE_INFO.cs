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
	 	//试验任务样品信息
		public partial class DalTEST_SAMPLE_INFO:DbHelperOra
	{
   		     
   		     
   		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalTEST_SAMPLE_INFO));
    
    	#region Method
   		 /// <summary>
		///   是否存在该记录
		/// </summary>
		public bool Exists(string F_TEST_TASK_ID,string F_SAMPLE_GROUP_NUM)
		{
		 try
            {
                Log.Info("DalTEST_SAMPLE_INFO->Exists---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select count(1) from T_TEST_SAMPLE_INFO");
				strSql.Append(" where 1=1 and ");
				                	                       strSql.Append(" F_TEST_TASK_ID = :F_TEST_TASK_ID and  ");
                	           		                 	                       strSql.Append(" F_SAMPLE_GROUP_NUM = :F_SAMPLE_GROUP_NUM  ");
                	           		 							OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,20),
					new OracleParameter(":F_SAMPLE_GROUP_NUM", OracleType.VarChar,100)			};
			parameters[0].Value = F_TEST_TASK_ID;
			parameters[1].Value = F_SAMPLE_GROUP_NUM;

			    Log.Info("DalTEST_SAMPLE_INFO->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_SAMPLE_INFO->Exists---FAILED", ex);
                throw ex;
            }
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(RelayTest.Model.ModelTEST_SAMPLE_INFO model)
		{
		
		 try
            {
                Log.Info("DalTEST_SAMPLE_INFO->Add---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_TEST_SAMPLE_INFO(");
			
						//试验任务编号
            strSql.Append("  F_TEST_TASK_ID,");
            			//样品数量
            strSql.Append("  F_SAMPLE_NUM,");
            			//样品组别
            strSql.Append("  F_SAMPLE_GROUP_NUM,");
            			//其他信息
            strSql.Append("  F_SAMPLE_MEMO,");
            			//创建时间
            strSql.Append("  F_CREATE_TIME,");
            			//操作员
            strSql.Append("  F_OPERATOR_ID,");
            			//操作时间
            strSql.Append("  F_OPERATIONTIME,");
            			//是否删除
            strSql.Append("  F_DEL");
            			strSql.Append(") values (");
			            strSql.Append(" :F_TEST_TASK_ID,");            
                         strSql.Append(" :F_SAMPLE_NUM,");            
                         strSql.Append(" :F_SAMPLE_GROUP_NUM,");            
                         strSql.Append(" :F_SAMPLE_MEMO,");            
                         strSql.Append(" :F_CREATE_TIME,");            
                         strSql.Append(" :F_OPERATOR_ID,");            
                         strSql.Append(" :F_OPERATIONTIME,");            
                         strSql.Append(" :F_DEL");            
                         strSql.Append(") ");            
            		
			OracleParameter[] parameters = {
			            new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_SAMPLE_NUM", OracleType.Number,18) ,            
                        new OracleParameter(":F_SAMPLE_GROUP_NUM", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_SAMPLE_MEMO", OracleType.VarChar,500) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
			    
			//试验任务编号
			if (model.F_TEST_TASK_ID==null)
			{
            	parameters[0].Value = DBNull.Value;
            }
            else
            {
                parameters[0].Value = model.F_TEST_TASK_ID;            }
                
			//样品数量
			if (model.F_SAMPLE_NUM==null)
			{
            	parameters[1].Value = DBNull.Value;
            }
            else
            {
                parameters[1].Value = model.F_SAMPLE_NUM;            }
                
			//样品组别
			if (model.F_SAMPLE_GROUP_NUM==null)
			{
            	parameters[2].Value = DBNull.Value;
            }
            else
            {
                parameters[2].Value = model.F_SAMPLE_GROUP_NUM;            }
                
			//其他信息
			if (model.F_SAMPLE_MEMO==null)
			{
            	parameters[3].Value = DBNull.Value;
            }
            else
            {
                parameters[3].Value = model.F_SAMPLE_MEMO;            }
                
			//创建时间
			if (model.F_CREATE_TIME==null)
			{
            	parameters[4].Value = DBNull.Value;
            }
            else
            {
                parameters[4].Value = model.F_CREATE_TIME;            }
                
			//操作员
			if (model.F_OPERATOR_ID==null)
			{
            	parameters[5].Value = DBNull.Value;
            }
            else
            {
                parameters[5].Value = model.F_OPERATOR_ID;            }
                
			//操作时间
			if (model.F_OPERATIONTIME==null)
			{
            	parameters[6].Value = DBNull.Value;
            }
            else
            {
                parameters[6].Value = model.F_OPERATIONTIME;            }
                
			//是否删除
			if (model.F_DEL==null)
			{
            	parameters[7].Value = DBNull.Value;
            }
            else
            {
                parameters[7].Value = model.F_DEL;            }
                        
			            ExecuteSql(strSql.ToString(),parameters);
            			
			}
            catch (Exception ex)
            {
                Log.Error("DalTEST_SAMPLE_INFO->Add---FAILED", ex);
                throw ex;
            }
		}
		
	
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(RelayTest.Model.ModelTEST_SAMPLE_INFO model)
		{
		
			try
            {
                Log.Info("DalTEST_SAMPLE_INFO->Update---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_TEST_SAMPLE_INFO set ");
			             
            //试验任务编号
            strSql.Append(" F_TEST_TASK_ID = :F_TEST_TASK_ID , ");
                         
            //样品数量
            strSql.Append(" F_SAMPLE_NUM = :F_SAMPLE_NUM , ");
                         
            //样品组别
            strSql.Append(" F_SAMPLE_GROUP_NUM = :F_SAMPLE_GROUP_NUM , ");
                         
            //其他信息
            strSql.Append(" F_SAMPLE_MEMO = :F_SAMPLE_MEMO , ");
                         
            //操作员
            strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");
                         
            //操作时间
            strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");
                         
            //是否删除
            strSql.Append(" F_DEL = :F_DEL  ");
            			
			strSql.Append(" where F_TEST_TASK_ID=:F_TEST_TASK_ID and F_SAMPLE_GROUP_NUM=:F_SAMPLE_GROUP_NUM  ");
						
OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_SAMPLE_NUM", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_SAMPLE_GROUP_NUM", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_SAMPLE_MEMO", OracleType.VarChar,500) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
									//试验任务编号
            	if (model.F_TEST_TASK_ID==null)
				{
	            	parameters[0].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[0].Value = model.F_TEST_TASK_ID;	            }
            			//样品数量
            	if (model.F_SAMPLE_NUM==null)
				{
	            	parameters[1].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[1].Value = model.F_SAMPLE_NUM;	            }
            			//样品组别
            	if (model.F_SAMPLE_GROUP_NUM==null)
				{
	            	parameters[2].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[2].Value = model.F_SAMPLE_GROUP_NUM;	            }
            			//其他信息
            	if (model.F_SAMPLE_MEMO==null)
				{
	            	parameters[3].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[3].Value = model.F_SAMPLE_MEMO;	            }
            			//操作员
            	if (model.F_OPERATOR_ID==null)
				{
	            	parameters[4].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[4].Value = model.F_OPERATOR_ID;	            }
            			//操作时间
            	if (model.F_OPERATIONTIME==null)
				{
	            	parameters[5].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[5].Value = model.F_OPERATIONTIME;	            }
            			//是否删除
            	if (model.F_DEL==null)
				{
	            	parameters[6].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[6].Value = model.F_DEL;	            }
                        
            int rows=ExecuteSql(strSql.ToString(),parameters);
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
                Log.Error("DalTEST_SAMPLE_INFO->Update---FAILED", ex);
                throw ex;
            }
		
		
		
			
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_TEST_TASK_ID,string F_SAMPLE_GROUP_NUM)
		{
			
			try
            {
                Log.Info("DalTEST_SAMPLE_INFO->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_SAMPLE_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_TEST_TASK_ID=:F_TEST_TASK_ID and F_SAMPLE_GROUP_NUM=:F_SAMPLE_GROUP_NUM ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,20),
					new OracleParameter(":F_SAMPLE_GROUP_NUM", OracleType.VarChar,100)			};
			parameters[0].Value = F_TEST_TASK_ID;
			parameters[1].Value = F_SAMPLE_GROUP_NUM;


			int rows=ExecuteSql(strSql.ToString(),parameters);
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
                Log.Error("DalTEST_SAMPLE_INFO->Delete---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_TEST_TASK_ID,string F_SAMPLE_GROUP_NUM)
		{
			
			try
            {
                Log.Info("DalTEST_SAMPLE_INFO->Disabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_SAMPLE_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_TEST_TASK_ID=:F_TEST_TASK_ID and F_SAMPLE_GROUP_NUM=:F_SAMPLE_GROUP_NUM ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,20),
					new OracleParameter(":F_SAMPLE_GROUP_NUM", OracleType.VarChar,100)			};
			parameters[0].Value = F_TEST_TASK_ID;
			parameters[1].Value = F_SAMPLE_GROUP_NUM;


			int rows=ExecuteSql(strSql.ToString(),parameters);
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
                Log.Error("DalTEST_SAMPLE_INFO->Disabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_TEST_TASK_ID,string F_SAMPLE_GROUP_NUM)
		{
			
			try
            {
                Log.Info("DalTEST_SAMPLE_INFO->Enabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_SAMPLE_INFO  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_TEST_TASK_ID=:F_TEST_TASK_ID and F_SAMPLE_GROUP_NUM=:F_SAMPLE_GROUP_NUM ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,20),
					new OracleParameter(":F_SAMPLE_GROUP_NUM", OracleType.VarChar,100)			};
			parameters[0].Value = F_TEST_TASK_ID;
			parameters[1].Value = F_SAMPLE_GROUP_NUM;


			int rows=ExecuteSql(strSql.ToString(),parameters);
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
                Log.Error("DalTEST_SAMPLE_INFO->Enabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool Drop(string F_TEST_TASK_ID,string F_SAMPLE_GROUP_NUM)
		{
			
			try
            {
                Log.Info("DalTEST_SAMPLE_INFO->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("DELETE FROM  T_TEST_SAMPLE_INFO  ");
			strSql.Append(" where F_TEST_TASK_ID=:F_TEST_TASK_ID and F_SAMPLE_GROUP_NUM=:F_SAMPLE_GROUP_NUM ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,20),
					new OracleParameter(":F_SAMPLE_GROUP_NUM", OracleType.VarChar,100)			};
			parameters[0].Value = F_TEST_TASK_ID;
			parameters[1].Value = F_SAMPLE_GROUP_NUM;


			int rows=ExecuteSql(strSql.ToString(),parameters);
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
                Log.Error("DalTEST_SAMPLE_INFO->Delete---FAILED", ex);
                throw ex;
            }
			
		}
		
				
		/// <summary>
		///  按条件删除一批数据
		/// </summary>
		public bool DeleteWhere(string strWhere )
		{
			try
            {
                Log.Info("DalTEST_SAMPLE_INFO->DeleteWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_SAMPLE_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_DEL=0  ");
			if (strWhere!="")
			{
				strSql.Append(" and " + strWhere);
			}
			int rows=ExecuteSql(strSql.ToString());
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
                Log.Error("DalTEST_SAMPLE_INFO->DeleteWhere---FAILED", ex);
                throw ex;
            }
		}
		
		
		
		/// <summary>
		///  按条件永久删除一批数据
		/// </summary>
		public bool DropWhere(string strWhere )
		{
			try
            {
                Log.Info("DalTEST_SAMPLE_INFO->DropWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from  T_TEST_SAMPLE_INFO  ");
			strSql.Append(" where 1=1  ");
			if (strWhere!="")
			{
				strSql.Append(" and " + strWhere);
			}
			int rows=ExecuteSql(strSql.ToString());
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
                Log.Error("DalTEST_SAMPLE_INFO->DropWhere---FAILED", ex);
                throw ex;
            }
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelTEST_SAMPLE_INFO GetModel(string F_TEST_TASK_ID,string F_SAMPLE_GROUP_NUM)
		{
			try
            {
                Log.Info("DalTEST_SAMPLE_INFO->GetModel---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select ");
								//试验任务编号
				strSql.Append("F_TEST_TASK_ID,  ");
								//样品数量
				strSql.Append("F_SAMPLE_NUM,  ");
								//样品组别
				strSql.Append("F_SAMPLE_GROUP_NUM,  ");
								//其他信息
				strSql.Append("F_SAMPLE_MEMO,  ");
								//创建时间
				strSql.Append("F_CREATE_TIME,  ");
								//操作员
				strSql.Append("F_OPERATOR_ID,  ");
								//操作时间
				strSql.Append("F_OPERATIONTIME,  ");
								//是否删除
				strSql.Append("F_DEL  ");
								strSql.Append("  from T_TEST_SAMPLE_INFO ");
				strSql.Append(" where 1=1 AND  F_TEST_TASK_ID=:F_TEST_TASK_ID and F_SAMPLE_GROUP_NUM=:F_SAMPLE_GROUP_NUM ");
							OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,20),
					new OracleParameter(":F_SAMPLE_GROUP_NUM", OracleType.VarChar,100)			};
			parameters[0].Value = F_TEST_TASK_ID;
			parameters[1].Value = F_SAMPLE_GROUP_NUM;

			
				RelayTest.Model.ModelTEST_SAMPLE_INFO model=new RelayTest.Model.ModelTEST_SAMPLE_INFO();
				DataSet ds=Query(strSql.ToString(),parameters);
			
				if(ds.Tables[0].Rows.Count>0)
				{
																				model.F_TEST_TASK_ID= ds.Tables[0].Rows[0]["F_TEST_TASK_ID"].ToString();
																																			if(ds.Tables[0].Rows[0]["F_SAMPLE_NUM"].ToString()!="")
					{
						model.F_SAMPLE_NUM=decimal.Parse(ds.Tables[0].Rows[0]["F_SAMPLE_NUM"].ToString());
					}
																																													model.F_SAMPLE_GROUP_NUM= ds.Tables[0].Rows[0]["F_SAMPLE_GROUP_NUM"].ToString();
																																								model.F_SAMPLE_MEMO= ds.Tables[0].Rows[0]["F_SAMPLE_MEMO"].ToString();
																																			if(ds.Tables[0].Rows[0]["F_CREATE_TIME"].ToString()!="")
					{
						model.F_CREATE_TIME=DateTime.Parse(ds.Tables[0].Rows[0]["F_CREATE_TIME"].ToString());
					}
																																													model.F_OPERATOR_ID= ds.Tables[0].Rows[0]["F_OPERATOR_ID"].ToString();
																																			if(ds.Tables[0].Rows[0]["F_OPERATIONTIME"].ToString()!="")
					{
						model.F_OPERATIONTIME=DateTime.Parse(ds.Tables[0].Rows[0]["F_OPERATIONTIME"].ToString());
					}
																																								if(ds.Tables[0].Rows[0]["F_DEL"].ToString()!="")
					{
						model.F_DEL=decimal.Parse(ds.Tables[0].Rows[0]["F_DEL"].ToString());
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
                Log.Error("DalTEST_SAMPLE_INFO->GetModel---FAILED", ex);
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
                Log.Info("DalTEST_SAMPLE_INFO->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select * ");
				strSql.Append(" FROM T_TEST_SAMPLE_INFO  where 1=1");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				return Query(strSql.ToString());
	            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_SAMPLE_INFO->GetList---FAILED", ex);
                throw ex;
            }
			
		}
		
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
		
		try
            {
                Log.Info("DalTEST_SAMPLE_INFO->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select ");
				if(Top>0)
				{
					strSql.Append(" top "+Top.ToString());
				}
				strSql.Append(" * ");
				strSql.Append(" FROM T_TEST_SAMPLE_INFO  where F_DEL=0 ");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				strSql.Append(" order by " + filedOrder);
				return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_SAMPLE_INFO->GetList---FAILED", ex);
                throw ex;
            }
			
		}
		#endregion Method
        #region 自定义函数
        /// <summary>
        /// 根据任务编号永久删除一条数据
        /// </summary>
        public bool DropByTaskId(string F_TEST_TASK_ID)
        {

            try
            {
                Log.Info("DalTEST_SAMPLE_INFO->DropByTaskId---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM  T_TEST_SAMPLE_INFO  ");
                strSql.Append(" where F_TEST_TASK_ID=:F_TEST_TASK_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,20),
					new OracleParameter(":F_SAMPLE_GROUP_NUM", OracleType.VarChar,100)			};
                parameters[0].Value = F_TEST_TASK_ID;


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
                Log.Error("DalTEST_SAMPLE_INFO->DropByTaskId---FAILED", ex);
                throw ex;
            }

        }
        /// <summary>
        /// 根据任务编号获得试验样品数据
        /// </summary>
        public DataSet GetListByTaskId(string strTaskId)
        {


            try
            {
                Log.Info("DalTEST_SAMPLE_INFO->GetListByTaskId---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM T_TEST_SAMPLE_INFO  where F_TEST_TASK_ID='"+strTaskId+"' ");
                
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_SAMPLE_INFO->GetListByTaskId---FAILED", ex);
                throw ex;
            }

        }
        #endregion

    }
}

