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
	 	//试验任务参数类型表
		public partial class DalTESTTASK_PARTYPE:DbHelperOra
	{
   		     
   		     
   		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalTESTTASK_PARTYPE));
    
    	#region Method
   		 /// <summary>
		///   是否存在该记录
		/// </summary>
		public new bool Exists(string F_TYPE_CODE)
		{
		 try
            {
                Log.Info("DalTESTTASK_PARTYPE->Exists---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select count(1) from T_TESTTASK_PARTYPE");
				strSql.Append(" where 1=1 and ");
				                	                       strSql.Append(" F_TYPE_CODE = :F_TYPE_CODE  ");
                	           		 							OracleParameter[] parameters = {
					new OracleParameter(":F_TYPE_CODE", OracleType.VarChar,20)			};
			parameters[0].Value = F_TYPE_CODE;

			    Log.Info("DalTESTTASK_PARTYPE->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalTESTTASK_PARTYPE->Exists---FAILED", ex);
                throw ex;
            }
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(RelayTest.Model.ModelTESTTASK_PARTYPE model)
		{
		
		 try
            {
                Log.Info("DalTESTTASK_PARTYPE->Add---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_TESTTASK_PARTYPE(");			
            strSql.Append("F_TYPE_CODE,F_TYPE_NAME,F_CREATE_TIME,F_OPERATOR_ID,F_OPERATIONTIME,F_DEL");
			strSql.Append(") values (");
            strSql.Append(":F_TYPE_CODE,:F_TYPE_NAME,:F_CREATE_TIME,:F_OPERATOR_ID,:F_OPERATIONTIME,:F_DEL");            
            strSql.Append(") ");            
            		
			OracleParameter[] parameters = {
			            new OracleParameter(":F_TYPE_CODE", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_TYPE_NAME", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
			    
			if (model.F_TYPE_CODE==null)
			{
            	parameters[0].Value = DBNull.Value;
            }
            else
            {
                parameters[0].Value = model.F_TYPE_CODE;            }
                
			if (model.F_TYPE_NAME==null)
			{
            	parameters[1].Value = DBNull.Value;
            }
            else
            {
                parameters[1].Value = model.F_TYPE_NAME;            }
                
			if (model.F_CREATE_TIME==null)
			{
            	parameters[2].Value = DBNull.Value;
            }
            else
            {
                parameters[2].Value = model.F_CREATE_TIME;            }
                
			if (model.F_OPERATOR_ID==null)
			{
            	parameters[3].Value = DBNull.Value;
            }
            else
            {
                parameters[3].Value = model.F_OPERATOR_ID;            }
                
			if (model.F_OPERATIONTIME==null)
			{
            	parameters[4].Value = DBNull.Value;
            }
            else
            {
                parameters[4].Value = model.F_OPERATIONTIME;            }
                
			if (model.F_DEL==null)
			{
            	parameters[5].Value = DBNull.Value;
            }
            else
            {
                parameters[5].Value = model.F_DEL;            }
                        
			            ExecuteSql(strSql.ToString(),parameters);
            			
			}
            catch (Exception ex)
            {
                Log.Error("DalTESTTASK_PARTYPE->Add---FAILED", ex);
                throw ex;
            }
		}
		
	
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(RelayTest.Model.ModelTESTTASK_PARTYPE model)
		{
		
			try
            {
                Log.Info("DalTESTTASK_PARTYPE->Update---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_TESTTASK_PARTYPE set ");
			                        
            strSql.Append(" F_TYPE_CODE = :F_TYPE_CODE , ");                                    
            strSql.Append(" F_TYPE_NAME = :F_TYPE_NAME , ");                                    
            strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");                                    
            strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");                                    
            strSql.Append(" F_DEL = :F_DEL  ");            			
			strSql.Append(" where F_TYPE_CODE=:F_TYPE_CODE  ");
						
OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_TYPE_CODE", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_TYPE_NAME", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
						            	if (model.F_TYPE_CODE==null)
				{
	            	parameters[0].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[0].Value = model.F_TYPE_CODE;	            }
                        	if (model.F_TYPE_NAME==null)
				{
	            	parameters[1].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[1].Value = model.F_TYPE_NAME;	            }
                        	if (model.F_OPERATOR_ID==null)
				{
	            	parameters[2].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[2].Value = model.F_OPERATOR_ID;	            }
                        	if (model.F_OPERATIONTIME==null)
				{
	            	parameters[3].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[3].Value = model.F_OPERATIONTIME;	            }
                        	if (model.F_DEL==null)
				{
	            	parameters[4].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[4].Value = model.F_DEL;	            }
                        
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
                Log.Error("DalTESTTASK_PARTYPE->Update---FAILED", ex);
                throw ex;
            }
		
		
		
			
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_TYPE_CODE)
		{
			
			try
            {
                Log.Info("DalTESTTASK_PARTYPE->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TESTTASK_PARTYPE  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_TYPE_CODE=:F_TYPE_CODE ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TYPE_CODE", OracleType.VarChar,20)			};
			parameters[0].Value = F_TYPE_CODE;


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
                Log.Error("DalTESTTASK_PARTYPE->Delete---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_TYPE_CODE)
		{
			
			try
            {
                Log.Info("DalTESTTASK_PARTYPE->Disabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TESTTASK_PARTYPE  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_TYPE_CODE=:F_TYPE_CODE ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TYPE_CODE", OracleType.VarChar,20)			};
			parameters[0].Value = F_TYPE_CODE;


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
                Log.Error("DalTESTTASK_PARTYPE->Disabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_TYPE_CODE)
		{
			
			try
            {
                Log.Info("DalTESTTASK_PARTYPE->Enabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TESTTASK_PARTYPE  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_TYPE_CODE=:F_TYPE_CODE ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TYPE_CODE", OracleType.VarChar,20)			};
			parameters[0].Value = F_TYPE_CODE;


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
                Log.Error("DalTESTTASK_PARTYPE->Enabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool Drop(string F_TYPE_CODE)
		{
			
			try
            {
                Log.Info("DalTESTTASK_PARTYPE->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("DELETE FROM  T_TESTTASK_PARTYPE  ");
			strSql.Append(" where F_TYPE_CODE=:F_TYPE_CODE ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TYPE_CODE", OracleType.VarChar,20)			};
			parameters[0].Value = F_TYPE_CODE;


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
                Log.Error("DalTESTTASK_PARTYPE->Delete---FAILED", ex);
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
                Log.Info("DalTESTTASK_PARTYPE->DeleteWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TESTTASK_PARTYPE  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalTESTTASK_PARTYPE->DeleteWhere---FAILED", ex);
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
                Log.Info("DalTESTTASK_PARTYPE->DropWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from  T_TESTTASK_PARTYPE  ");
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
                Log.Error("DalTESTTASK_PARTYPE->DropWhere---FAILED", ex);
                throw ex;
            }
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelTESTTASK_PARTYPE GetModel(string F_TYPE_CODE)
		{
			try
            {
                Log.Info("DalTESTTASK_PARTYPE->GetModel---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select F_TYPE_CODE, F_TYPE_NAME, F_CREATE_TIME, F_OPERATOR_ID, F_OPERATIONTIME, F_DEL  ");			
				strSql.Append("  from T_TESTTASK_PARTYPE ");
				strSql.Append(" where 1=1 AND  F_TYPE_CODE=:F_TYPE_CODE ");
							OracleParameter[] parameters = {
					new OracleParameter(":F_TYPE_CODE", OracleType.VarChar,20)			};
			parameters[0].Value = F_TYPE_CODE;

			
				RelayTest.Model.ModelTESTTASK_PARTYPE model=new RelayTest.Model.ModelTESTTASK_PARTYPE();
				DataSet ds=Query(strSql.ToString(),parameters);
			
				if(ds.Tables[0].Rows.Count>0)
				{
																				model.F_TYPE_CODE= ds.Tables[0].Rows[0]["F_TYPE_CODE"].ToString();
																																								model.F_TYPE_NAME= ds.Tables[0].Rows[0]["F_TYPE_NAME"].ToString();
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
                Log.Error("DalTESTTASK_PARTYPE->GetModel---FAILED", ex);
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
                Log.Info("DalTESTTASK_PARTYPE->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select * ");
				strSql.Append(" FROM T_TESTTASK_PARTYPE  where 1=1");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				return Query(strSql.ToString());
	            }
            catch (Exception ex)
            {
                Log.Error("DalTESTTASK_PARTYPE->GetList---FAILED", ex);
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
                Log.Info("DalTESTTASK_PARTYPE->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select ");
				if(Top>0)
				{
					strSql.Append(" top "+Top.ToString());
				}
				strSql.Append(" * ");
				strSql.Append(" FROM T_TESTTASK_PARTYPE  where F_DEL=0 ");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				strSql.Append(" order by " + filedOrder);
				return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalTESTTASK_PARTYPE->GetList---FAILED", ex);
                throw ex;
            }
			
		}
		#endregion Method

   
	}
}

