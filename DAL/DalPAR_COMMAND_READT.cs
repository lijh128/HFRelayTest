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
	 	//试验运行读取参数信息
		public partial class DalPAR_COMMAND_READT:DbHelperOra
	{
   		     
   		     
   		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalPAR_COMMAND_READT));
    
    	#region Method
   		 /// <summary>
		///   是否存在该记录
		/// </summary>
		public bool Exists(string F_WORKTYPE_NAME,string F_PROGRAMM_CODE,decimal F_RECEIVECOMMAND_PAR_ID)
		{
		 try
            {
                Log.Info("DalPAR_COMMAND_READT->Exists---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select count(1) from T_PAR_COMMAND_READT");
				strSql.Append(" where 1=1 and ");
				                	                       strSql.Append(" F_WORKTYPE_NAME = :F_WORKTYPE_NAME and  ");
                	           		                 	                       strSql.Append(" F_PROGRAMM_CODE = :F_PROGRAMM_CODE and  ");
                	           		                 	                       strSql.Append(" F_RECEIVECOMMAND_PAR_ID = :F_RECEIVECOMMAND_PAR_ID  ");
                	           		 							OracleParameter[] parameters = {
					new OracleParameter(":F_WORKTYPE_NAME", OracleType.VarChar,20),
					new OracleParameter(":F_PROGRAMM_CODE", OracleType.VarChar,10),
					new OracleParameter(":F_RECEIVECOMMAND_PAR_ID", OracleType.Number,8)			};
			parameters[0].Value = F_WORKTYPE_NAME;
			parameters[1].Value = F_PROGRAMM_CODE;
			parameters[2].Value = F_RECEIVECOMMAND_PAR_ID;

			    Log.Info("DalPAR_COMMAND_READT->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_READT->Exists---FAILED", ex);
                throw ex;
            }
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(RelayTest.Model.ModelPAR_COMMAND_READT model)
		{
		
		 try
            {
                Log.Info("DalPAR_COMMAND_READT->Add---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_PAR_COMMAND_READT(");			
            strSql.Append("F_WORKTYPE_NAME,F_PROGRAMM_CODE,F_RECEIVECOMMAND_PAR_ID,F_RECEIVEPAR_NAME,F_ORDER,F_WORKTYPE_MEMO,F_CREATE_TIME,F_OPERATOR_ID,F_OPERATIONTIME,F_DEL");
			strSql.Append(") values (");
            strSql.Append(":F_WORKTYPE_NAME,:F_PROGRAMM_CODE,:F_RECEIVECOMMAND_PAR_ID,:F_RECEIVEPAR_NAME,:F_ORDER,:F_WORKTYPE_MEMO,:F_CREATE_TIME,:F_OPERATOR_ID,:F_OPERATIONTIME,:F_DEL");            
            strSql.Append(") ");            
            		
			OracleParameter[] parameters = {
			            new OracleParameter(":F_WORKTYPE_NAME", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_PROGRAMM_CODE", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_RECEIVECOMMAND_PAR_ID", OracleType.Number,8) ,            
                        new OracleParameter(":F_RECEIVEPAR_NAME", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_ORDER", OracleType.Number,4) ,            
                        new OracleParameter(":F_WORKTYPE_MEMO", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
			    
			if (model.F_WORKTYPE_NAME==null)
			{
            	parameters[0].Value = DBNull.Value;
            }
            else
            {
                parameters[0].Value = model.F_WORKTYPE_NAME;            }
                
			if (model.F_PROGRAMM_CODE==null)
			{
            	parameters[1].Value = DBNull.Value;
            }
            else
            {
                parameters[1].Value = model.F_PROGRAMM_CODE;            }
                
			if (model.F_RECEIVECOMMAND_PAR_ID==null)
			{
            	parameters[2].Value = DBNull.Value;
            }
            else
            {
                parameters[2].Value = model.F_RECEIVECOMMAND_PAR_ID;            }
                
			if (model.F_RECEIVEPAR_NAME==null)
			{
            	parameters[3].Value = DBNull.Value;
            }
            else
            {
                parameters[3].Value = model.F_RECEIVEPAR_NAME;            }
                
			if (model.F_ORDER==null)
			{
            	parameters[4].Value = DBNull.Value;
            }
            else
            {
                parameters[4].Value = model.F_ORDER;            }
                
			if (model.F_WORKTYPE_MEMO==null)
			{
            	parameters[5].Value = DBNull.Value;
            }
            else
            {
                parameters[5].Value = model.F_WORKTYPE_MEMO;            }
                
			if (model.F_CREATE_TIME==null)
			{
            	parameters[6].Value = DBNull.Value;
            }
            else
            {
                parameters[6].Value = model.F_CREATE_TIME;            }
                
			if (model.F_OPERATOR_ID==null)
			{
            	parameters[7].Value = DBNull.Value;
            }
            else
            {
                parameters[7].Value = model.F_OPERATOR_ID;            }
                
			if (model.F_OPERATIONTIME==null)
			{
            	parameters[8].Value = DBNull.Value;
            }
            else
            {
                parameters[8].Value = model.F_OPERATIONTIME;            }
                
			if (model.F_DEL==null)
			{
            	parameters[9].Value = DBNull.Value;
            }
            else
            {
                parameters[9].Value = model.F_DEL;            }
                        
			            ExecuteSql(strSql.ToString(),parameters);
            			
			}
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_READT->Add---FAILED", ex);
                throw ex;
            }
		}
		
	
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(RelayTest.Model.ModelPAR_COMMAND_READT model)
		{
		
			try
            {
                Log.Info("DalPAR_COMMAND_READT->Update---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_PAR_COMMAND_READT set ");
			                        
            strSql.Append(" F_WORKTYPE_NAME = :F_WORKTYPE_NAME , ");                                    
            strSql.Append(" F_PROGRAMM_CODE = :F_PROGRAMM_CODE , ");                                    
            strSql.Append(" F_RECEIVECOMMAND_PAR_ID = :F_RECEIVECOMMAND_PAR_ID , ");                                    
            strSql.Append(" F_RECEIVEPAR_NAME = :F_RECEIVEPAR_NAME , ");                                    
            strSql.Append(" F_ORDER = :F_ORDER , ");                                    
            strSql.Append(" F_WORKTYPE_MEMO = :F_WORKTYPE_MEMO , ");                                    
            strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");                                    
            strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");                                    
            strSql.Append(" F_DEL = :F_DEL  ");            			
			strSql.Append(" where F_WORKTYPE_NAME=:F_WORKTYPE_NAME and F_PROGRAMM_CODE=:F_PROGRAMM_CODE and F_RECEIVECOMMAND_PAR_ID=:F_RECEIVECOMMAND_PAR_ID  ");
						
OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_WORKTYPE_NAME", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_PROGRAMM_CODE", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_RECEIVECOMMAND_PAR_ID", OracleType.Number,8) ,            
                        	
            new OracleParameter(":F_RECEIVEPAR_NAME", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_ORDER", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_WORKTYPE_MEMO", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
						            	if (model.F_WORKTYPE_NAME==null)
				{
	            	parameters[0].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[0].Value = model.F_WORKTYPE_NAME;	            }
                        	if (model.F_PROGRAMM_CODE==null)
				{
	            	parameters[1].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[1].Value = model.F_PROGRAMM_CODE;	            }
                        	if (model.F_RECEIVECOMMAND_PAR_ID==null)
				{
	            	parameters[2].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[2].Value = model.F_RECEIVECOMMAND_PAR_ID;	            }
                        	if (model.F_RECEIVEPAR_NAME==null)
				{
	            	parameters[3].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[3].Value = model.F_RECEIVEPAR_NAME;	            }
                        	if (model.F_ORDER==null)
				{
	            	parameters[4].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[4].Value = model.F_ORDER;	            }
                        	if (model.F_WORKTYPE_MEMO==null)
				{
	            	parameters[5].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[5].Value = model.F_WORKTYPE_MEMO;	            }
                        	if (model.F_OPERATOR_ID==null)
				{
	            	parameters[6].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[6].Value = model.F_OPERATOR_ID;	            }
                        	if (model.F_OPERATIONTIME==null)
				{
	            	parameters[7].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[7].Value = model.F_OPERATIONTIME;	            }
                        	if (model.F_DEL==null)
				{
	            	parameters[8].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[8].Value = model.F_DEL;	            }
                        
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
                Log.Error("DalPAR_COMMAND_READT->Update---FAILED", ex);
                throw ex;
            }
		
		
		
			
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_WORKTYPE_NAME,string F_PROGRAMM_CODE,decimal F_RECEIVECOMMAND_PAR_ID)
		{
			
			try
            {
                Log.Info("DalPAR_COMMAND_READT->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_PAR_COMMAND_READT  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_WORKTYPE_NAME=:F_WORKTYPE_NAME and F_PROGRAMM_CODE=:F_PROGRAMM_CODE and F_RECEIVECOMMAND_PAR_ID=:F_RECEIVECOMMAND_PAR_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_WORKTYPE_NAME", OracleType.VarChar,20),
					new OracleParameter(":F_PROGRAMM_CODE", OracleType.VarChar,10),
					new OracleParameter(":F_RECEIVECOMMAND_PAR_ID", OracleType.Number,8)			};
			parameters[0].Value = F_WORKTYPE_NAME;
			parameters[1].Value = F_PROGRAMM_CODE;
			parameters[2].Value = F_RECEIVECOMMAND_PAR_ID;


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
                Log.Error("DalPAR_COMMAND_READT->Delete---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_WORKTYPE_NAME,string F_PROGRAMM_CODE,decimal F_RECEIVECOMMAND_PAR_ID)
		{
			
			try
            {
                Log.Info("DalPAR_COMMAND_READT->Disabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_PAR_COMMAND_READT  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_WORKTYPE_NAME=:F_WORKTYPE_NAME and F_PROGRAMM_CODE=:F_PROGRAMM_CODE and F_RECEIVECOMMAND_PAR_ID=:F_RECEIVECOMMAND_PAR_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_WORKTYPE_NAME", OracleType.VarChar,20),
					new OracleParameter(":F_PROGRAMM_CODE", OracleType.VarChar,10),
					new OracleParameter(":F_RECEIVECOMMAND_PAR_ID", OracleType.Number,8)			};
			parameters[0].Value = F_WORKTYPE_NAME;
			parameters[1].Value = F_PROGRAMM_CODE;
			parameters[2].Value = F_RECEIVECOMMAND_PAR_ID;


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
                Log.Error("DalPAR_COMMAND_READT->Disabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_WORKTYPE_NAME,string F_PROGRAMM_CODE,decimal F_RECEIVECOMMAND_PAR_ID)
		{
			
			try
            {
                Log.Info("DalPAR_COMMAND_READT->Enabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_PAR_COMMAND_READT  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_WORKTYPE_NAME=:F_WORKTYPE_NAME and F_PROGRAMM_CODE=:F_PROGRAMM_CODE and F_RECEIVECOMMAND_PAR_ID=:F_RECEIVECOMMAND_PAR_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_WORKTYPE_NAME", OracleType.VarChar,20),
					new OracleParameter(":F_PROGRAMM_CODE", OracleType.VarChar,10),
					new OracleParameter(":F_RECEIVECOMMAND_PAR_ID", OracleType.Number,8)			};
			parameters[0].Value = F_WORKTYPE_NAME;
			parameters[1].Value = F_PROGRAMM_CODE;
			parameters[2].Value = F_RECEIVECOMMAND_PAR_ID;


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
                Log.Error("DalPAR_COMMAND_READT->Enabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool Drop(string F_WORKTYPE_NAME,string F_PROGRAMM_CODE,decimal F_RECEIVECOMMAND_PAR_ID)
		{
			
			try
            {
                Log.Info("DalPAR_COMMAND_READT->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("DELETE FROM  T_PAR_COMMAND_READT  ");
			strSql.Append(" where F_WORKTYPE_NAME=:F_WORKTYPE_NAME and F_PROGRAMM_CODE=:F_PROGRAMM_CODE and F_RECEIVECOMMAND_PAR_ID=:F_RECEIVECOMMAND_PAR_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_WORKTYPE_NAME", OracleType.VarChar,20),
					new OracleParameter(":F_PROGRAMM_CODE", OracleType.VarChar,10),
					new OracleParameter(":F_RECEIVECOMMAND_PAR_ID", OracleType.Number,8)			};
			parameters[0].Value = F_WORKTYPE_NAME;
			parameters[1].Value = F_PROGRAMM_CODE;
			parameters[2].Value = F_RECEIVECOMMAND_PAR_ID;


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
                Log.Error("DalPAR_COMMAND_READT->Delete---FAILED", ex);
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
                Log.Info("DalPAR_COMMAND_READT->DeleteWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_PAR_COMMAND_READT  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalPAR_COMMAND_READT->DeleteWhere---FAILED", ex);
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
                Log.Info("DalPAR_COMMAND_READT->DropWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from  T_PAR_COMMAND_READT  ");
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
                Log.Error("DalPAR_COMMAND_READT->DropWhere---FAILED", ex);
                throw ex;
            }
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelPAR_COMMAND_READT GetModel(string F_WORKTYPE_NAME,string F_PROGRAMM_CODE,decimal F_RECEIVECOMMAND_PAR_ID)
		{
			try
            {
                Log.Info("DalPAR_COMMAND_READT->GetModel---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select F_WORKTYPE_NAME, F_PROGRAMM_CODE, F_RECEIVECOMMAND_PAR_ID, F_RECEIVEPAR_NAME, F_ORDER, F_WORKTYPE_MEMO, F_CREATE_TIME, F_OPERATOR_ID, F_OPERATIONTIME, F_DEL  ");			
				strSql.Append("  from T_PAR_COMMAND_READT ");
				strSql.Append(" where 1=1 AND  F_WORKTYPE_NAME=:F_WORKTYPE_NAME and F_PROGRAMM_CODE=:F_PROGRAMM_CODE and F_RECEIVECOMMAND_PAR_ID=:F_RECEIVECOMMAND_PAR_ID ");
							OracleParameter[] parameters = {
					new OracleParameter(":F_WORKTYPE_NAME", OracleType.VarChar,20),
					new OracleParameter(":F_PROGRAMM_CODE", OracleType.VarChar,10),
					new OracleParameter(":F_RECEIVECOMMAND_PAR_ID", OracleType.Number,8)			};
			parameters[0].Value = F_WORKTYPE_NAME;
			parameters[1].Value = F_PROGRAMM_CODE;
			parameters[2].Value = F_RECEIVECOMMAND_PAR_ID;

			
				RelayTest.Model.ModelPAR_COMMAND_READT model=new RelayTest.Model.ModelPAR_COMMAND_READT();
				DataSet ds=Query(strSql.ToString(),parameters);
			
				if(ds.Tables[0].Rows.Count>0)
				{
																				model.F_WORKTYPE_NAME= ds.Tables[0].Rows[0]["F_WORKTYPE_NAME"].ToString();
																																								model.F_PROGRAMM_CODE= ds.Tables[0].Rows[0]["F_PROGRAMM_CODE"].ToString();
																																			if(ds.Tables[0].Rows[0]["F_RECEIVECOMMAND_PAR_ID"].ToString()!="")
					{
						model.F_RECEIVECOMMAND_PAR_ID=decimal.Parse(ds.Tables[0].Rows[0]["F_RECEIVECOMMAND_PAR_ID"].ToString());
					}
																																													model.F_RECEIVEPAR_NAME= ds.Tables[0].Rows[0]["F_RECEIVEPAR_NAME"].ToString();
																																			if(ds.Tables[0].Rows[0]["F_ORDER"].ToString()!="")
					{
						model.F_ORDER=decimal.Parse(ds.Tables[0].Rows[0]["F_ORDER"].ToString());
					}
																																													model.F_WORKTYPE_MEMO= ds.Tables[0].Rows[0]["F_WORKTYPE_MEMO"].ToString();
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
                Log.Error("DalPAR_COMMAND_READT->GetModel---FAILED", ex);
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
                Log.Info("DalPAR_COMMAND_READT->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select * ");
				strSql.Append(" FROM T_PAR_COMMAND_READT  where 1=1");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				return Query(strSql.ToString());
	            }
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_READT->GetList---FAILED", ex);
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
                Log.Info("DalPAR_COMMAND_READT->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select ");
				if(Top>0)
				{
					strSql.Append(" top "+Top.ToString());
				}
				strSql.Append(" * ");
				strSql.Append(" FROM T_PAR_COMMAND_READT  where F_DEL=0 ");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				strSql.Append(" order by " + filedOrder);
				return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_READT->GetList---FAILED", ex);
                throw ex;
            }
			
		}
		#endregion Method

   
	}
}

