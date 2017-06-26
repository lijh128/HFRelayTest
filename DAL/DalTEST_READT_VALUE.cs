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
	 	//试验任务运行情况参数值记录
		public partial class DalTEST_READVALUE:DbHelperOra
	{
   		     
   		     
   		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalTEST_READVALUE));
    
    	#region Method
   		 /// <summary>
		///   是否存在该记录
		/// </summary>
		public bool Exists(string F_TASK_ID,string F_SAMPLE_ID,string F_RECEIVEPAR_NAME,decimal F_READBATCH)
		{
		 try
            {
                Log.Info("DalTEST_READVALUE->Exists---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select count(1) from T_TEST_READT_VALUE");
				strSql.Append(" where 1=1 and ");
				                	                       strSql.Append(" F_TASK_ID = :F_TASK_ID and  ");
                	           		                 	                       strSql.Append(" F_SAMPLE_ID = :F_SAMPLE_ID and  ");
                	           		                 	                       strSql.Append(" F_RECEIVEPAR_NAME = :F_RECEIVEPAR_NAME and  ");
                	           		                 	                       strSql.Append(" F_READBATCH = :F_READBATCH  ");
                	           		 							OracleParameter[] parameters = {
					new OracleParameter(":F_TASK_ID", OracleType.VarChar,50),
					new OracleParameter(":F_SAMPLE_ID", OracleType.VarChar,20),
					new OracleParameter(":F_RECEIVEPAR_NAME", OracleType.VarChar,100),
					new OracleParameter(":F_READBATCH", OracleType.Number,18)			};
			parameters[0].Value = F_TASK_ID;
			parameters[1].Value = F_SAMPLE_ID;
			parameters[2].Value = F_RECEIVEPAR_NAME;
			parameters[3].Value = F_READBATCH;

			    Log.Info("DalTEST_READVALUE->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_READVALUE->Exists---FAILED", ex);
                throw ex;
            }
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(RelayTest.Model.ModelTEST_READVALUE model)
		{
		
		 try
            {
                Log.Info("DalTEST_READVALUE->Add---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_TEST_READT_VALUE(");			
            strSql.Append("F_TASK_ID,F_SAMPLE_ID,F_RECEIVEPAR_NAME,F_RECEIVEPAR_VALUE,F_READBATCH,F_CREATE_TIME,F_OPERATOR_ID,F_OPERATIONTIME,F_DEL");
			strSql.Append(") values (");
            strSql.Append(":F_TASK_ID,:F_SAMPLE_ID,:F_RECEIVEPAR_NAME,:F_RECEIVEPAR_VALUE,:F_READBATCH,:F_CREATE_TIME,:F_OPERATOR_ID,:F_OPERATIONTIME,:F_DEL");            
            strSql.Append(") ");            
            		
			OracleParameter[] parameters = {
			            new OracleParameter(":F_TASK_ID", OracleType.VarChar,50) ,            
                        new OracleParameter(":F_SAMPLE_ID", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_RECEIVEPAR_NAME", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_RECEIVEPAR_VALUE", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_READBATCH", OracleType.Number,18) ,            
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
                
			if (model.F_RECEIVEPAR_NAME==null)
			{
            	parameters[2].Value = DBNull.Value;
            }
            else
            {
                parameters[2].Value = model.F_RECEIVEPAR_NAME;            }
                
			if (model.F_RECEIVEPAR_VALUE==null)
			{
            	parameters[3].Value = DBNull.Value;
            }
            else
            {
                parameters[3].Value = model.F_RECEIVEPAR_VALUE;            }
                
			if (model.F_READBATCH==null)
			{
            	parameters[4].Value = DBNull.Value;
            }
            else
            {
                parameters[4].Value = model.F_READBATCH;            }
                
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
                Log.Error("DalTEST_READVALUE->Add---FAILED", ex);
                throw ex;
            }
		}
		
	
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(RelayTest.Model.ModelTEST_READVALUE model)
		{
		
			try
            {
                Log.Info("DalTEST_READVALUE->Update---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_TEST_READT_VALUE set ");
			                        
            strSql.Append(" F_TASK_ID = :F_TASK_ID , ");                                    
            strSql.Append(" F_SAMPLE_ID = :F_SAMPLE_ID , ");                                    
            strSql.Append(" F_RECEIVEPAR_NAME = :F_RECEIVEPAR_NAME , ");                                    
            strSql.Append(" F_RECEIVEPAR_VALUE = :F_RECEIVEPAR_VALUE , ");                                    
            strSql.Append(" F_READBATCH = :F_READBATCH , ");                                    
            strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");                                    
            strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");                                    
            strSql.Append(" F_DEL = :F_DEL  ");            			
			strSql.Append(" where F_TASK_ID=:F_TASK_ID and F_SAMPLE_ID=:F_SAMPLE_ID and F_RECEIVEPAR_NAME=:F_RECEIVEPAR_NAME and F_READBATCH=:F_READBATCH  ");
						
OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_TASK_ID", OracleType.VarChar,50) ,            
                        	
            new OracleParameter(":F_SAMPLE_ID", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_RECEIVEPAR_NAME", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_RECEIVEPAR_VALUE", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_READBATCH", OracleType.Number,18) ,            
                        	
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
                        	if (model.F_RECEIVEPAR_NAME==null)
				{
	            	parameters[2].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[2].Value = model.F_RECEIVEPAR_NAME;	            }
                        	if (model.F_RECEIVEPAR_VALUE==null)
				{
	            	parameters[3].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[3].Value = model.F_RECEIVEPAR_VALUE;	            }
                        	if (model.F_READBATCH==null)
				{
	            	parameters[4].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[4].Value = model.F_READBATCH;	            }
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
                Log.Error("DalTEST_READVALUE->Update---FAILED", ex);
                throw ex;
            }
		
		
		
			
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_TASK_ID,string F_SAMPLE_ID,string F_RECEIVEPAR_NAME,decimal F_READBATCH)
		{
			
			try
            {
                Log.Info("DalTEST_READVALUE->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_READT_VALUE  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_TASK_ID=:F_TASK_ID and F_SAMPLE_ID=:F_SAMPLE_ID and F_RECEIVEPAR_NAME=:F_RECEIVEPAR_NAME and F_READBATCH=:F_READBATCH ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TASK_ID", OracleType.VarChar,50),
					new OracleParameter(":F_SAMPLE_ID", OracleType.VarChar,20),
					new OracleParameter(":F_RECEIVEPAR_NAME", OracleType.VarChar,100),
					new OracleParameter(":F_READBATCH", OracleType.Number,18)			};
			parameters[0].Value = F_TASK_ID;
			parameters[1].Value = F_SAMPLE_ID;
			parameters[2].Value = F_RECEIVEPAR_NAME;
			parameters[3].Value = F_READBATCH;


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
                Log.Error("DalTEST_READVALUE->Delete---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_TASK_ID,string F_SAMPLE_ID,string F_RECEIVEPAR_NAME,decimal F_READBATCH)
		{
			
			try
            {
                Log.Info("DalTEST_READVALUE->Disabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_READT_VALUE  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_TASK_ID=:F_TASK_ID and F_SAMPLE_ID=:F_SAMPLE_ID and F_RECEIVEPAR_NAME=:F_RECEIVEPAR_NAME and F_READBATCH=:F_READBATCH ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TASK_ID", OracleType.VarChar,50),
					new OracleParameter(":F_SAMPLE_ID", OracleType.VarChar,20),
					new OracleParameter(":F_RECEIVEPAR_NAME", OracleType.VarChar,100),
					new OracleParameter(":F_READBATCH", OracleType.Number,18)			};
			parameters[0].Value = F_TASK_ID;
			parameters[1].Value = F_SAMPLE_ID;
			parameters[2].Value = F_RECEIVEPAR_NAME;
			parameters[3].Value = F_READBATCH;


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
                Log.Error("DalTEST_READVALUE->Disabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_TASK_ID,string F_SAMPLE_ID,string F_RECEIVEPAR_NAME,decimal F_READBATCH)
		{
			
			try
            {
                Log.Info("DalTEST_READVALUE->Enabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_READT_VALUE  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_TASK_ID=:F_TASK_ID and F_SAMPLE_ID=:F_SAMPLE_ID and F_RECEIVEPAR_NAME=:F_RECEIVEPAR_NAME and F_READBATCH=:F_READBATCH ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TASK_ID", OracleType.VarChar,50),
					new OracleParameter(":F_SAMPLE_ID", OracleType.VarChar,20),
					new OracleParameter(":F_RECEIVEPAR_NAME", OracleType.VarChar,100),
					new OracleParameter(":F_READBATCH", OracleType.Number,18)			};
			parameters[0].Value = F_TASK_ID;
			parameters[1].Value = F_SAMPLE_ID;
			parameters[2].Value = F_RECEIVEPAR_NAME;
			parameters[3].Value = F_READBATCH;


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
                Log.Error("DalTEST_READVALUE->Enabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool Drop(string F_TASK_ID,string F_SAMPLE_ID,string F_RECEIVEPAR_NAME,decimal F_READBATCH)
		{
			
			try
            {
                Log.Info("DalTEST_READVALUE->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("DELETE FROM  T_TEST_READT_VALUE  ");
			strSql.Append(" where F_TASK_ID=:F_TASK_ID and F_SAMPLE_ID=:F_SAMPLE_ID and F_RECEIVEPAR_NAME=:F_RECEIVEPAR_NAME and F_READBATCH=:F_READBATCH ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TASK_ID", OracleType.VarChar,50),
					new OracleParameter(":F_SAMPLE_ID", OracleType.VarChar,20),
					new OracleParameter(":F_RECEIVEPAR_NAME", OracleType.VarChar,100),
					new OracleParameter(":F_READBATCH", OracleType.Number,18)			};
			parameters[0].Value = F_TASK_ID;
			parameters[1].Value = F_SAMPLE_ID;
			parameters[2].Value = F_RECEIVEPAR_NAME;
			parameters[3].Value = F_READBATCH;


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
                Log.Error("DalTEST_READVALUE->Delete---FAILED", ex);
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
                Log.Info("DalTEST_READVALUE->DeleteWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_READT_VALUE  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalTEST_READVALUE->DeleteWhere---FAILED", ex);
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
                Log.Info("DalTEST_READVALUE->DropWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from  T_TEST_READT_VALUE  ");
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
                Log.Error("DalTEST_READVALUE->DropWhere---FAILED", ex);
                throw ex;
            }
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelTEST_READVALUE GetModel(string F_TASK_ID,string F_SAMPLE_ID,string F_RECEIVEPAR_NAME,decimal F_READBATCH)
		{
			try
            {
                Log.Info("DalTEST_READVALUE->GetModel---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select F_TASK_ID, F_SAMPLE_ID, F_RECEIVEPAR_NAME, F_RECEIVEPAR_VALUE, F_READBATCH, F_CREATE_TIME, F_OPERATOR_ID, F_OPERATIONTIME, F_DEL  ");			
				strSql.Append("  from T_TEST_READT_VALUE ");
				strSql.Append(" where 1=1 AND  F_TASK_ID=:F_TASK_ID and F_SAMPLE_ID=:F_SAMPLE_ID and F_RECEIVEPAR_NAME=:F_RECEIVEPAR_NAME and F_READBATCH=:F_READBATCH ");
							OracleParameter[] parameters = {
					new OracleParameter(":F_TASK_ID", OracleType.VarChar,50),
					new OracleParameter(":F_SAMPLE_ID", OracleType.VarChar,20),
					new OracleParameter(":F_RECEIVEPAR_NAME", OracleType.VarChar,100),
					new OracleParameter(":F_READBATCH", OracleType.Number,18)			};
			parameters[0].Value = F_TASK_ID;
			parameters[1].Value = F_SAMPLE_ID;
			parameters[2].Value = F_RECEIVEPAR_NAME;
			parameters[3].Value = F_READBATCH;

			
				RelayTest.Model.ModelTEST_READVALUE model=new RelayTest.Model.ModelTEST_READVALUE();
				DataSet ds=Query(strSql.ToString(),parameters);
			
				if(ds.Tables[0].Rows.Count>0)
				{
																				model.F_TASK_ID= ds.Tables[0].Rows[0]["F_TASK_ID"].ToString();
																																								model.F_SAMPLE_ID= ds.Tables[0].Rows[0]["F_SAMPLE_ID"].ToString();
																																								model.F_RECEIVEPAR_NAME= ds.Tables[0].Rows[0]["F_RECEIVEPAR_NAME"].ToString();
																																								model.F_RECEIVEPAR_VALUE= ds.Tables[0].Rows[0]["F_RECEIVEPAR_VALUE"].ToString();
																																			if(ds.Tables[0].Rows[0]["F_READBATCH"].ToString()!="")
					{
						model.F_READBATCH=decimal.Parse(ds.Tables[0].Rows[0]["F_READBATCH"].ToString());
					}
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
                Log.Error("DalTEST_READVALUE->GetModel---FAILED", ex);
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
                Log.Info("DalTEST_READVALUE->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select * ");
				strSql.Append(" FROM T_TEST_READT_VALUE  where 1=1");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				return Query(strSql.ToString());
	            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_READVALUE->GetList---FAILED", ex);
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
                Log.Info("DalTEST_READVALUE->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select ");
				if(Top>0)
				{
					strSql.Append(" top "+Top.ToString());
				}
				strSql.Append(" * ");
				strSql.Append(" FROM T_TEST_READT_VALUE  where F_DEL=0 ");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				strSql.Append(" order by " + filedOrder);
				return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_READVALUE->GetList---FAILED", ex);
                throw ex;
            }
			
		}
		#endregion Method

   
	}
}

