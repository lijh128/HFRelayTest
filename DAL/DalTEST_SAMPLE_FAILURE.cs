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
	 	//试验样品失效情况记录
		public partial class DalTEST_SAMPLE_FAILURE:DbHelperOra
	{
   		     
   		     
   		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalTEST_SAMPLE_FAILURE));
    
    	#region Method
   		 /// <summary>
		///   是否存在该记录
		/// </summary>
		public bool Exists(string F_TASK_ID,string F_SAMPLE_ID,decimal F_FAILURE_CYCLE)
		{
		 try
            {
                Log.Info("DalTEST_SAMPLE_FAILURE->Exists---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select count(1) from T_TEST_SAMPLE_FAILURE");
				strSql.Append(" where 1=1 and ");
				                	                       strSql.Append(" F_TASK_ID = :F_TASK_ID and  ");
                	           		                 	                       strSql.Append(" F_SAMPLE_ID = :F_SAMPLE_ID and  ");
                	           		                 	                       strSql.Append(" F_FAILURE_CYCLE = :F_FAILURE_CYCLE  ");
                	           		 							OracleParameter[] parameters = {
					new OracleParameter(":F_TASK_ID", OracleType.VarChar,50),
					new OracleParameter(":F_SAMPLE_ID", OracleType.VarChar,20),
					new OracleParameter(":F_FAILURE_CYCLE", OracleType.Number,8)			};
			parameters[0].Value = F_TASK_ID;
			parameters[1].Value = F_SAMPLE_ID;
			parameters[2].Value = F_FAILURE_CYCLE;

			    Log.Info("DalTEST_SAMPLE_FAILURE->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_SAMPLE_FAILURE->Exists---FAILED", ex);
                throw ex;
            }
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(RelayTest.Model.ModelTEST_SAMPLE_FAILURE model)
		{
		
		 try
            {
                Log.Info("DalTEST_SAMPLE_FAILURE->Add---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_TEST_SAMPLE_FAILURE(");			
            strSql.Append("F_TASK_ID,F_SAMPLE_ID,F_FAILURE_CYCLE,F_FAILURE_TYPE,F_FAILURE_MEMO,F_CREATE_TIME,F_OPERATOR_ID,F_OPERATIONTIME,F_DEL");
			strSql.Append(") values (");
            strSql.Append(":F_TASK_ID,:F_SAMPLE_ID,:F_FAILURE_CYCLE,:F_FAILURE_TYPE,:F_FAILURE_MEMO,:F_CREATE_TIME,:F_OPERATOR_ID,:F_OPERATIONTIME,:F_DEL");            
            strSql.Append(") ");            
            		
			OracleParameter[] parameters = {
			            new OracleParameter(":F_TASK_ID", OracleType.VarChar,50) ,            
                        new OracleParameter(":F_SAMPLE_ID", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_FAILURE_CYCLE", OracleType.Number,8) ,            
                        new OracleParameter(":F_FAILURE_TYPE", OracleType.VarChar,50) ,            
                        new OracleParameter(":F_FAILURE_MEMO", OracleType.VarChar,500) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
			    
			if (model.F_TASK_ID==null)
			{
            	parameters[0].Value = DBNull.Value;
            }
            else
            {
                parameters[0].Value = model.F_TASK_ID;            }
                
			if (model.F_SAMPLE_ID==null)
			{
            	parameters[1].Value = DBNull.Value;
            }
            else
            {
                parameters[1].Value = model.F_SAMPLE_ID;            }
                
			if (model.F_FAILURE_CYCLE==null)
			{
            	parameters[2].Value = DBNull.Value;
            }
            else
            {
                parameters[2].Value = model.F_FAILURE_CYCLE;            }
                
			if (model.F_FAILURE_TYPE==null)
			{
            	parameters[3].Value = DBNull.Value;
            }
            else
            {
                parameters[3].Value = model.F_FAILURE_TYPE;            }
                
			if (model.F_FAILURE_MEMO==null)
			{
            	parameters[4].Value = DBNull.Value;
            }
            else
            {
                parameters[4].Value = model.F_FAILURE_MEMO;            }
                
			if (model.F_CREATE_TIME==null)
			{
            	parameters[5].Value = DBNull.Value;
            }
            else
            {
                parameters[5].Value = model.F_CREATE_TIME;            }
                
			if (model.F_OPERATOR_ID==null)
			{
            	parameters[6].Value = DBNull.Value;
            }
            else
            {
                parameters[6].Value = model.F_OPERATOR_ID;            }
                
			if (model.F_OPERATIONTIME==null)
			{
            	parameters[7].Value = DBNull.Value;
            }
            else
            {
                parameters[7].Value = model.F_OPERATIONTIME;            }
                
			if (model.F_DEL==null)
			{
            	parameters[8].Value = DBNull.Value;
            }
            else
            {
                parameters[8].Value = model.F_DEL;            }
                        
			            ExecuteSql(strSql.ToString(),parameters);
            			
			}
            catch (Exception ex)
            {
                Log.Error("DalTEST_SAMPLE_FAILURE->Add---FAILED", ex);
                throw ex;
            }
		}
		
	
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(RelayTest.Model.ModelTEST_SAMPLE_FAILURE model)
		{
		
			try
            {
                Log.Info("DalTEST_SAMPLE_FAILURE->Update---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_TEST_SAMPLE_FAILURE set ");
			                        
            strSql.Append(" F_TASK_ID = :F_TASK_ID , ");                                    
            strSql.Append(" F_SAMPLE_ID = :F_SAMPLE_ID , ");                                    
            strSql.Append(" F_FAILURE_CYCLE = :F_FAILURE_CYCLE , ");                                    
            strSql.Append(" F_FAILURE_TYPE = :F_FAILURE_TYPE , ");                                    
            strSql.Append(" F_FAILURE_MEMO = :F_FAILURE_MEMO , ");                                    
            strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");                                    
            strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");                                    
            strSql.Append(" F_DEL = :F_DEL  ");            			
			strSql.Append(" where F_TASK_ID=:F_TASK_ID and F_SAMPLE_ID=:F_SAMPLE_ID and F_FAILURE_CYCLE=:F_FAILURE_CYCLE  ");
						
OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_TASK_ID", OracleType.VarChar,50) ,            
                        	
            new OracleParameter(":F_SAMPLE_ID", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_FAILURE_CYCLE", OracleType.Number,8) ,            
                        	
            new OracleParameter(":F_FAILURE_TYPE", OracleType.VarChar,50) ,            
                        	
            new OracleParameter(":F_FAILURE_MEMO", OracleType.VarChar,500) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
						            	if (model.F_TASK_ID==null)
				{
	            	parameters[0].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[0].Value = model.F_TASK_ID;	            }
                        	if (model.F_SAMPLE_ID==null)
				{
	            	parameters[1].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[1].Value = model.F_SAMPLE_ID;	            }
                        	if (model.F_FAILURE_CYCLE==null)
				{
	            	parameters[2].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[2].Value = model.F_FAILURE_CYCLE;	            }
                        	if (model.F_FAILURE_TYPE==null)
				{
	            	parameters[3].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[3].Value = model.F_FAILURE_TYPE;	            }
                        	if (model.F_FAILURE_MEMO==null)
				{
	            	parameters[4].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[4].Value = model.F_FAILURE_MEMO;	            }
                        	if (model.F_OPERATOR_ID==null)
				{
	            	parameters[5].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[5].Value = model.F_OPERATOR_ID;	            }
                        	if (model.F_OPERATIONTIME==null)
				{
	            	parameters[6].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[6].Value = model.F_OPERATIONTIME;	            }
                        	if (model.F_DEL==null)
				{
	            	parameters[7].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[7].Value = model.F_DEL;	            }
                        
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
                Log.Error("DalTEST_SAMPLE_FAILURE->Update---FAILED", ex);
                throw ex;
            }
		
		
		
			
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_TASK_ID,string F_SAMPLE_ID,decimal F_FAILURE_CYCLE)
		{
			
			try
            {
                Log.Info("DalTEST_SAMPLE_FAILURE->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_SAMPLE_FAILURE  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_TASK_ID=:F_TASK_ID and F_SAMPLE_ID=:F_SAMPLE_ID and F_FAILURE_CYCLE=:F_FAILURE_CYCLE ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TASK_ID", OracleType.VarChar,50),
					new OracleParameter(":F_SAMPLE_ID", OracleType.VarChar,20),
					new OracleParameter(":F_FAILURE_CYCLE", OracleType.Number,8)			};
			parameters[0].Value = F_TASK_ID;
			parameters[1].Value = F_SAMPLE_ID;
			parameters[2].Value = F_FAILURE_CYCLE;


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
                Log.Error("DalTEST_SAMPLE_FAILURE->Delete---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_TASK_ID,string F_SAMPLE_ID,decimal F_FAILURE_CYCLE)
		{
			
			try
            {
                Log.Info("DalTEST_SAMPLE_FAILURE->Disabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_SAMPLE_FAILURE  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_TASK_ID=:F_TASK_ID and F_SAMPLE_ID=:F_SAMPLE_ID and F_FAILURE_CYCLE=:F_FAILURE_CYCLE ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TASK_ID", OracleType.VarChar,50),
					new OracleParameter(":F_SAMPLE_ID", OracleType.VarChar,20),
					new OracleParameter(":F_FAILURE_CYCLE", OracleType.Number,8)			};
			parameters[0].Value = F_TASK_ID;
			parameters[1].Value = F_SAMPLE_ID;
			parameters[2].Value = F_FAILURE_CYCLE;


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
                Log.Error("DalTEST_SAMPLE_FAILURE->Disabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_TASK_ID,string F_SAMPLE_ID,decimal F_FAILURE_CYCLE)
		{
			
			try
            {
                Log.Info("DalTEST_SAMPLE_FAILURE->Enabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_SAMPLE_FAILURE  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_TASK_ID=:F_TASK_ID and F_SAMPLE_ID=:F_SAMPLE_ID and F_FAILURE_CYCLE=:F_FAILURE_CYCLE ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TASK_ID", OracleType.VarChar,50),
					new OracleParameter(":F_SAMPLE_ID", OracleType.VarChar,20),
					new OracleParameter(":F_FAILURE_CYCLE", OracleType.Number,8)			};
			parameters[0].Value = F_TASK_ID;
			parameters[1].Value = F_SAMPLE_ID;
			parameters[2].Value = F_FAILURE_CYCLE;


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
                Log.Error("DalTEST_SAMPLE_FAILURE->Enabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool Drop(string F_TASK_ID,string F_SAMPLE_ID,decimal F_FAILURE_CYCLE)
		{
			
			try
            {
                Log.Info("DalTEST_SAMPLE_FAILURE->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("DELETE FROM  T_TEST_SAMPLE_FAILURE  ");
			strSql.Append(" where F_TASK_ID=:F_TASK_ID and F_SAMPLE_ID=:F_SAMPLE_ID and F_FAILURE_CYCLE=:F_FAILURE_CYCLE ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TASK_ID", OracleType.VarChar,50),
					new OracleParameter(":F_SAMPLE_ID", OracleType.VarChar,20),
					new OracleParameter(":F_FAILURE_CYCLE", OracleType.Number,8)			};
			parameters[0].Value = F_TASK_ID;
			parameters[1].Value = F_SAMPLE_ID;
			parameters[2].Value = F_FAILURE_CYCLE;


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
                Log.Error("DalTEST_SAMPLE_FAILURE->Delete---FAILED", ex);
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
                Log.Info("DalTEST_SAMPLE_FAILURE->DeleteWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_SAMPLE_FAILURE  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalTEST_SAMPLE_FAILURE->DeleteWhere---FAILED", ex);
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
                Log.Info("DalTEST_SAMPLE_FAILURE->DropWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from  T_TEST_SAMPLE_FAILURE  ");
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
                Log.Error("DalTEST_SAMPLE_FAILURE->DropWhere---FAILED", ex);
                throw ex;
            }
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelTEST_SAMPLE_FAILURE GetModel(string F_TASK_ID,string F_SAMPLE_ID,decimal F_FAILURE_CYCLE)
		{
			try
            {
                Log.Info("DalTEST_SAMPLE_FAILURE->GetModel---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select F_TASK_ID, F_SAMPLE_ID, F_FAILURE_CYCLE, F_FAILURE_TYPE, F_FAILURE_MEMO, F_CREATE_TIME, F_OPERATOR_ID, F_OPERATIONTIME, F_DEL  ");			
				strSql.Append("  from T_TEST_SAMPLE_FAILURE ");
				strSql.Append(" where 1=1 AND  F_TASK_ID=:F_TASK_ID and F_SAMPLE_ID=:F_SAMPLE_ID and F_FAILURE_CYCLE=:F_FAILURE_CYCLE ");
							OracleParameter[] parameters = {
					new OracleParameter(":F_TASK_ID", OracleType.VarChar,50),
					new OracleParameter(":F_SAMPLE_ID", OracleType.VarChar,20),
					new OracleParameter(":F_FAILURE_CYCLE", OracleType.Number,8)			};
			parameters[0].Value = F_TASK_ID;
			parameters[1].Value = F_SAMPLE_ID;
			parameters[2].Value = F_FAILURE_CYCLE;

			
				RelayTest.Model.ModelTEST_SAMPLE_FAILURE model=new RelayTest.Model.ModelTEST_SAMPLE_FAILURE();
				DataSet ds=Query(strSql.ToString(),parameters);
			
				if(ds.Tables[0].Rows.Count>0)
				{
																				model.F_TASK_ID= ds.Tables[0].Rows[0]["F_TASK_ID"].ToString();
																																								model.F_SAMPLE_ID= ds.Tables[0].Rows[0]["F_SAMPLE_ID"].ToString();
																																			if(ds.Tables[0].Rows[0]["F_FAILURE_CYCLE"].ToString()!="")
					{
						model.F_FAILURE_CYCLE=decimal.Parse(ds.Tables[0].Rows[0]["F_FAILURE_CYCLE"].ToString());
					}
																																													model.F_FAILURE_TYPE= ds.Tables[0].Rows[0]["F_FAILURE_TYPE"].ToString();
																																								model.F_FAILURE_MEMO= ds.Tables[0].Rows[0]["F_FAILURE_MEMO"].ToString();
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
                Log.Error("DalTEST_SAMPLE_FAILURE->GetModel---FAILED", ex);
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
                Log.Info("DalTEST_SAMPLE_FAILURE->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select * ");
				strSql.Append(" FROM T_TEST_SAMPLE_FAILURE  where 1=1");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				return Query(strSql.ToString());
	            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_SAMPLE_FAILURE->GetList---FAILED", ex);
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
                Log.Info("DalTEST_SAMPLE_FAILURE->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select ");
				if(Top>0)
				{
					strSql.Append(" top "+Top.ToString());
				}
				strSql.Append(" * ");
				strSql.Append(" FROM T_TEST_SAMPLE_FAILURE  where F_DEL=0 ");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				strSql.Append(" order by " + filedOrder);
				return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_SAMPLE_FAILURE->GetList---FAILED", ex);
                throw ex;
            }
			
		}
		#endregion Method
        #region 自定义函数
        /// <summary>
        /// 根据查询条件获得试验样品失效信息
        /// </summary>
        public DataSet GetTestSampleFailureInfoByQueryCondition(string query_con)
        {
            try
            {
                Log.Info("DalTEST_INFO->GetTestSampleFailureInfoByQueryCondition---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM VIEW_QUERY_TEST_FAIL_INFO_NEW   ");
                strSql.Append(" where 1=1 and  ");
                strSql.Append(query_con);
                strSql.Append(" order by F_TEST_TASK_ID,F_SAMPLE_ID ");
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_INFO->GetTestSampleFailureInfoByQueryCondition---FAILED", ex);
                throw ex;
            }

        }
        #endregion

    }
}

