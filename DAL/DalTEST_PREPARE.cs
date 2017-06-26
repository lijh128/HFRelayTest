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
	 	//试验准备情况记录
		public partial class DalTEST_PREPARE:DbHelperOra
	{
   		     
   		     
   		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalTEST_PREPARE));
    
    	#region Method
   		 /// <summary>
		///   是否存在该记录
		/// </summary>
		public new bool Exists(string F_TEST_TASK_ID)
		{
		 try
            {
                Log.Info("DalTEST_PREPARE->Exists---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select count(1) from T_TEST_PREPARE");
				strSql.Append(" where 1=1 and ");
				                	                       strSql.Append(" F_TEST_TASK_ID = :F_TEST_TASK_ID  ");
                	           		 							OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,50)			};
			parameters[0].Value = F_TEST_TASK_ID;

			    Log.Info("DalTEST_PREPARE->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_PREPARE->Exists---FAILED", ex);
                throw ex;
            }
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(RelayTest.Model.ModelTEST_PREPARE model)
		{
		
		 try
            {
                Log.Info("DalTEST_PREPARE->Add---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_TEST_PREPARE(");			
            strSql.Append("F_TEST_TASK_ID,F_ISPAROK,F_TEST_TIME,F_MEMO,F_CREATE_TIME,F_OPERATOR_ID,F_OPERATIONTIME,F_DEL");
			strSql.Append(") values (");
            strSql.Append(":F_TEST_TASK_ID,:F_ISPAROK,:F_TEST_TIME,:F_MEMO,:F_CREATE_TIME,:F_OPERATOR_ID,:F_OPERATIONTIME,:F_DEL");            
            strSql.Append(") ");            
            		
			OracleParameter[] parameters = {
			            new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,50) ,            
                        new OracleParameter(":F_ISPAROK", OracleType.Number,4) ,            
                        new OracleParameter(":F_TEST_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_MEMO", OracleType.VarChar,500) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
			    
			if (model.F_TEST_TASK_ID==null)
			{
            	parameters[0].Value = DBNull.Value;
            }
            else
            {
                parameters[0].Value = model.F_TEST_TASK_ID;            }
                
			if (model.F_ISPAROK==null)
			{
            	parameters[1].Value = DBNull.Value;
            }
            else
            {
                parameters[1].Value = model.F_ISPAROK;            }
                
			if (model.F_TEST_TIME==null)
			{
            	parameters[2].Value = DBNull.Value;
            }
            else
            {
                parameters[2].Value = model.F_TEST_TIME;            }
                
			if (model.F_MEMO==null)
			{
            	parameters[3].Value = DBNull.Value;
            }
            else
            {
                parameters[3].Value = model.F_MEMO;            }
                
			if (model.F_CREATE_TIME==null)
			{
            	parameters[4].Value = DBNull.Value;
            }
            else
            {
                parameters[4].Value = model.F_CREATE_TIME;            }
                
			if (model.F_OPERATOR_ID==null)
			{
            	parameters[5].Value = DBNull.Value;
            }
            else
            {
                parameters[5].Value = model.F_OPERATOR_ID;            }
                
			if (model.F_OPERATIONTIME==null)
			{
            	parameters[6].Value = DBNull.Value;
            }
            else
            {
                parameters[6].Value = model.F_OPERATIONTIME;            }
                
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
                Log.Error("DalTEST_PREPARE->Add---FAILED", ex);
                throw ex;
            }
		}
		
	
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(RelayTest.Model.ModelTEST_PREPARE model)
		{
		
			try
            {
                Log.Info("DalTEST_PREPARE->Update---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_TEST_PREPARE set ");
			                        
            strSql.Append(" F_TEST_TASK_ID = :F_TEST_TASK_ID , ");                                    
            strSql.Append(" F_ISPAROK = :F_ISPAROK , ");                                    
            strSql.Append(" F_TEST_TIME = :F_TEST_TIME , ");                                    
            strSql.Append(" F_MEMO = :F_MEMO , ");                                    
            strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");                                    
            strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");                                    
            strSql.Append(" F_DEL = :F_DEL  ");            			
			strSql.Append(" where F_TEST_TASK_ID=:F_TEST_TASK_ID  ");
						
OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,50) ,            
                        	
            new OracleParameter(":F_ISPAROK", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_TEST_TIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_MEMO", OracleType.VarChar,500) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
						            	if (model.F_TEST_TASK_ID==null)
				{
	            	parameters[0].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[0].Value = model.F_TEST_TASK_ID;	            }
                        	if (model.F_ISPAROK==null)
				{
	            	parameters[1].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[1].Value = model.F_ISPAROK;	            }
                        	if (model.F_TEST_TIME==null)
				{
	            	parameters[2].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[2].Value = model.F_TEST_TIME;	            }
                        	if (model.F_MEMO==null)
				{
	            	parameters[3].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[3].Value = model.F_MEMO;	            }
                        	if (model.F_OPERATOR_ID==null)
				{
	            	parameters[4].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[4].Value = model.F_OPERATOR_ID;	            }
                        	if (model.F_OPERATIONTIME==null)
				{
	            	parameters[5].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[5].Value = model.F_OPERATIONTIME;	            }
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
                Log.Error("DalTEST_PREPARE->Update---FAILED", ex);
                throw ex;
            }
		
		
		
			
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_TEST_TASK_ID)
		{
			
			try
            {
                Log.Info("DalTEST_PREPARE->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_PREPARE  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_TEST_TASK_ID=:F_TEST_TASK_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,50)			};
			parameters[0].Value = F_TEST_TASK_ID;


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
                Log.Error("DalTEST_PREPARE->Delete---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_TEST_TASK_ID)
		{
			
			try
            {
                Log.Info("DalTEST_PREPARE->Disabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_PREPARE  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_TEST_TASK_ID=:F_TEST_TASK_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,50)			};
			parameters[0].Value = F_TEST_TASK_ID;


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
                Log.Error("DalTEST_PREPARE->Disabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_TEST_TASK_ID)
		{
			
			try
            {
                Log.Info("DalTEST_PREPARE->Enabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_PREPARE  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_TEST_TASK_ID=:F_TEST_TASK_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,50)			};
			parameters[0].Value = F_TEST_TASK_ID;


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
                Log.Error("DalTEST_PREPARE->Enabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool Drop(string F_TEST_TASK_ID)
		{
			
			try
            {
                Log.Info("DalTEST_PREPARE->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("DELETE FROM  T_TEST_PREPARE  ");
			strSql.Append(" where F_TEST_TASK_ID=:F_TEST_TASK_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,50)			};
			parameters[0].Value = F_TEST_TASK_ID;


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
                Log.Error("DalTEST_PREPARE->Delete---FAILED", ex);
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
                Log.Info("DalTEST_PREPARE->DeleteWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_PREPARE  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalTEST_PREPARE->DeleteWhere---FAILED", ex);
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
                Log.Info("DalTEST_PREPARE->DropWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from  T_TEST_PREPARE  ");
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
                Log.Error("DalTEST_PREPARE->DropWhere---FAILED", ex);
                throw ex;
            }
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelTEST_PREPARE GetModel(string F_TEST_TASK_ID)
		{
			try
            {
                Log.Info("DalTEST_PREPARE->GetModel---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select F_TEST_TASK_ID, F_ISPAROK, F_TEST_TIME, F_MEMO, F_CREATE_TIME, F_OPERATOR_ID, F_OPERATIONTIME, F_DEL  ");			
				strSql.Append("  from T_TEST_PREPARE ");
				strSql.Append(" where 1=1 AND  F_TEST_TASK_ID=:F_TEST_TASK_ID ");
							OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,50)			};
			parameters[0].Value = F_TEST_TASK_ID;

			
				RelayTest.Model.ModelTEST_PREPARE model=new RelayTest.Model.ModelTEST_PREPARE();
				DataSet ds=Query(strSql.ToString(),parameters);
			
				if(ds.Tables[0].Rows.Count>0)
				{
																				model.F_TEST_TASK_ID= ds.Tables[0].Rows[0]["F_TEST_TASK_ID"].ToString();
																																			if(ds.Tables[0].Rows[0]["F_ISPAROK"].ToString()!="")
					{
						model.F_ISPAROK=decimal.Parse(ds.Tables[0].Rows[0]["F_ISPAROK"].ToString());
					}
																																								if(ds.Tables[0].Rows[0]["F_TEST_TIME"].ToString()!="")
					{
						model.F_TEST_TIME=DateTime.Parse(ds.Tables[0].Rows[0]["F_TEST_TIME"].ToString());
					}
																																													model.F_MEMO= ds.Tables[0].Rows[0]["F_MEMO"].ToString();
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
                Log.Error("DalTEST_PREPARE->GetModel---FAILED", ex);
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
                Log.Info("DalTEST_PREPARE->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select * ");
				strSql.Append(" FROM T_TEST_PREPARE  where 1=1");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				return Query(strSql.ToString());
	            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_PREPARE->GetList---FAILED", ex);
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
                Log.Info("DalTEST_PREPARE->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select ");
				if(Top>0)
				{
					strSql.Append(" top "+Top.ToString());
				}
				strSql.Append(" * ");
				strSql.Append(" FROM T_TEST_PREPARE  where F_DEL=0 ");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				strSql.Append(" order by " + filedOrder);
				return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_PREPARE->GetList---FAILED", ex);
                throw ex;
            }
			
		}
		#endregion Method

   
	}
}

