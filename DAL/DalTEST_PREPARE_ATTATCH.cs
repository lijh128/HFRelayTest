﻿using System;
using System.Data.OracleClient;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using RelayTest.Util.DBUtility;
using log4net;
namespace RelayTest.DAL  
{
	 	//试验准备情况附件
		public partial class DalTEST_PREPARE_ATTATCH:DbHelperOra
	{
   		     
   		     
   		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalTEST_PREPARE_ATTATCH));
    
    	#region Method
   		 /// <summary>
		///   是否存在该记录
		/// </summary>
		public new bool Exists(string F_TEST_TASK_ID)
		{
		 try
            {
                Log.Info("DalTEST_PREPARE_ATTATCH->Exists---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select count(1) from T_TEST_PREPARE_ATTATCH");
				strSql.Append(" where 1=1 and ");
				                	                       strSql.Append(" F_TEST_TASK_ID = :F_TEST_TASK_ID  ");
                	           		 							OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,50)			};
			parameters[0].Value = F_TEST_TASK_ID;

			    Log.Info("DalTEST_PREPARE_ATTATCH->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_PREPARE_ATTATCH->Exists---FAILED", ex);
                throw ex;
            }
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(RelayTest.Model.ModelTEST_PREPARE_ATTATCH model)
		{
		
		 try
            {
                Log.Info("DalTEST_PREPARE_ATTATCH->Add---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_TEST_PREPARE_ATTATCH(");			
            strSql.Append("F_TEST_TASK_ID,F_ATTATCHNAME,F_ATTATCHMENT,F_CREATE_TIME,F_OPERATOR_ID,F_OPERATIONTIME,F_DEL");
			strSql.Append(") values (");
            strSql.Append(":F_TEST_TASK_ID,:F_ATTATCHNAME,:F_ATTATCHMENT,:F_CREATE_TIME,:F_OPERATOR_ID,:F_OPERATIONTIME,:F_DEL");            
            strSql.Append(") ");            
            		
			OracleParameter[] parameters = {
			            new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,50) ,            
                        new OracleParameter(":F_ATTATCHNAME", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_ATTATCHMENT", OracleType.Blob) ,            
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
                
			if (model.F_ATTATCHNAME==null)
			{
            	parameters[1].Value = DBNull.Value;
            }
            else
            {
                parameters[1].Value = model.F_ATTATCHNAME;            }
                
			if (model.F_ATTATCHMENT==null)
			{
            	parameters[2].Value = DBNull.Value;
            }
            else
            {
                parameters[2].Value = model.F_ATTATCHMENT;            }
                
			if (model.F_CREATE_TIME==null)
			{
            	parameters[3].Value = DBNull.Value;
            }
            else
            {
                parameters[3].Value = model.F_CREATE_TIME;            }
                
			if (model.F_OPERATOR_ID==null)
			{
            	parameters[4].Value = DBNull.Value;
            }
            else
            {
                parameters[4].Value = model.F_OPERATOR_ID;            }
                
			if (model.F_OPERATIONTIME==null)
			{
            	parameters[5].Value = DBNull.Value;
            }
            else
            {
                parameters[5].Value = model.F_OPERATIONTIME;            }
                
			if (model.F_DEL==null)
			{
            	parameters[6].Value = DBNull.Value;
            }
            else
            {
                parameters[6].Value = model.F_DEL;            }
                        
			            ExecuteSql(strSql.ToString(),parameters);
            			
			}
            catch (Exception ex)
            {
                Log.Error("DalTEST_PREPARE_ATTATCH->Add---FAILED", ex);
                throw ex;
            }
		}
		
	
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(RelayTest.Model.ModelTEST_PREPARE_ATTATCH model)
		{
		
			try
            {
                Log.Info("DalTEST_PREPARE_ATTATCH->Update---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_TEST_PREPARE_ATTATCH set ");
			                        
            strSql.Append(" F_TEST_TASK_ID = :F_TEST_TASK_ID , ");                                    
            strSql.Append(" F_ATTATCHNAME = :F_ATTATCHNAME , ");                                    
            strSql.Append(" F_ATTATCHMENT = :F_ATTATCHMENT , ");                                    
            strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");                                    
            strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");                                    
            strSql.Append(" F_DEL = :F_DEL  ");            			
			strSql.Append(" where F_TEST_TASK_ID=:F_TEST_TASK_ID  ");
						
OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,50) ,            
                        	
            new OracleParameter(":F_ATTATCHNAME", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_ATTATCHMENT", OracleType.Blob) ,            
                        	
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
                        	if (model.F_ATTATCHNAME==null)
				{
	            	parameters[1].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[1].Value = model.F_ATTATCHNAME;	            }
                        	if (model.F_ATTATCHMENT==null)
				{
	            	parameters[2].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[2].Value = model.F_ATTATCHMENT;	            }
                        	if (model.F_OPERATOR_ID==null)
				{
	            	parameters[3].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[3].Value = model.F_OPERATOR_ID;	            }
                        	if (model.F_OPERATIONTIME==null)
				{
	            	parameters[4].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[4].Value = model.F_OPERATIONTIME;	            }
                        	if (model.F_DEL==null)
				{
	            	parameters[5].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[5].Value = model.F_DEL;	            }
                        
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
                Log.Error("DalTEST_PREPARE_ATTATCH->Update---FAILED", ex);
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
                Log.Info("DalTEST_PREPARE_ATTATCH->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_PREPARE_ATTATCH  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalTEST_PREPARE_ATTATCH->Delete---FAILED", ex);
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
                Log.Info("DalTEST_PREPARE_ATTATCH->Disabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_PREPARE_ATTATCH  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalTEST_PREPARE_ATTATCH->Disabled---FAILED", ex);
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
                Log.Info("DalTEST_PREPARE_ATTATCH->Enabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_PREPARE_ATTATCH  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalTEST_PREPARE_ATTATCH->Enabled---FAILED", ex);
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
                Log.Info("DalTEST_PREPARE_ATTATCH->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("DELETE FROM  T_TEST_PREPARE_ATTATCH  ");
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
                Log.Error("DalTEST_PREPARE_ATTATCH->Delete---FAILED", ex);
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
                Log.Info("DalTEST_PREPARE_ATTATCH->DeleteWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_PREPARE_ATTATCH  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalTEST_PREPARE_ATTATCH->DeleteWhere---FAILED", ex);
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
                Log.Info("DalTEST_PREPARE_ATTATCH->DropWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from  T_TEST_PREPARE_ATTATCH  ");
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
                Log.Error("DalTEST_PREPARE_ATTATCH->DropWhere---FAILED", ex);
                throw ex;
            }
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelTEST_PREPARE_ATTATCH GetModel(string F_TEST_TASK_ID)
		{
			try
            {
                Log.Info("DalTEST_PREPARE_ATTATCH->GetModel---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select F_TEST_TASK_ID, F_ATTATCHNAME, F_ATTATCHMENT, F_CREATE_TIME, F_OPERATOR_ID, F_OPERATIONTIME, F_DEL  ");			
				strSql.Append("  from T_TEST_PREPARE_ATTATCH ");
				strSql.Append(" where 1=1 AND  F_TEST_TASK_ID=:F_TEST_TASK_ID ");
							OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,50)			};
			parameters[0].Value = F_TEST_TASK_ID;

			
				RelayTest.Model.ModelTEST_PREPARE_ATTATCH model=new RelayTest.Model.ModelTEST_PREPARE_ATTATCH();
				DataSet ds=Query(strSql.ToString(),parameters);
			
				if(ds.Tables[0].Rows.Count>0)
				{
                    model.F_TEST_TASK_ID= ds.Tables[0].Rows[0]["F_TEST_TASK_ID"].ToString();
																																								model.F_ATTATCHNAME= ds.Tables[0].Rows[0]["F_ATTATCHNAME"].ToString();
																																													if(ds.Tables[0].Rows[0]["F_ATTATCHMENT"].ToString()!="")
					{
						model.F_ATTATCHMENT= (byte[])ds.Tables[0].Rows[0]["F_ATTATCHMENT"];
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
                Log.Error("DalTEST_PREPARE_ATTATCH->GetModel---FAILED", ex);
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
                Log.Info("DalTEST_PREPARE_ATTATCH->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select * ");
				strSql.Append(" FROM T_TEST_PREPARE_ATTATCH  where 1=1");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				return Query(strSql.ToString());
	            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_PREPARE_ATTATCH->GetList---FAILED", ex);
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
                Log.Info("DalTEST_PREPARE_ATTATCH->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select ");
				if(Top>0)
				{
					strSql.Append(" top "+Top.ToString());
				}
				strSql.Append(" * ");
				strSql.Append(" FROM T_TEST_PREPARE_ATTATCH  where F_DEL=0 ");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				strSql.Append(" order by " + filedOrder);
				return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_PREPARE_ATTATCH->GetList---FAILED", ex);
                throw ex;
            }
			
		}
		#endregion Method

   
	}
}

