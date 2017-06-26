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
	 	//上位机下位机关系表
		public partial class DalDEV_WORK_TO_SUB:DbHelperOra
	{
   		     
   		     
   		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalDEV_WORK_TO_SUB));
    
    	#region Method
   		 /// <summary>
		///   是否存在该记录
		/// </summary>
		public bool Exists(string F_WORKSTATION_ID,string F_SUBORDINATE_ID)
		{
		 try
            {
                Log.Info("DalDEV_WORK_TO_SUB->Exists---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select count(1) from T_DEV_WORK_TO_SUB");
				strSql.Append(" where 1=1 and ");
				                	                       strSql.Append(" F_WORKSTATION_ID = :F_WORKSTATION_ID and  ");
                	           		                 	                       strSql.Append(" F_SUBORDINATE_ID = :F_SUBORDINATE_ID  ");
                	           		 							OracleParameter[] parameters = {
					new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar,20),
					new OracleParameter(":F_SUBORDINATE_ID", OracleType.VarChar,20)			};
			parameters[0].Value = F_WORKSTATION_ID;
			parameters[1].Value = F_SUBORDINATE_ID;

			    Log.Info("DalDEV_WORK_TO_SUB->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_WORK_TO_SUB->Exists---FAILED", ex);
                throw ex;
            }
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(RelayTest.Model.ModelDEV_WORK_TO_SUB model)
		{
		
		 try
            {
                Log.Info("DalDEV_WORK_TO_SUB->Add---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_DEV_WORK_TO_SUB(");			
            strSql.Append("F_WORKSTATION_ID,F_WORKSTATION_NAME,F_SUBORDINATE_ID,F_SUBORDINATE_NAME,F_MEMO,F_CREATE_TIME,F_OPERATOR_ID,F_OPERATIONTIME,F_DEL");
			strSql.Append(") values (");
            strSql.Append(":F_WORKSTATION_ID,:F_WORKSTATION_NAME,:F_SUBORDINATE_ID,:F_SUBORDINATE_NAME,:F_MEMO,:F_CREATE_TIME,:F_OPERATOR_ID,:F_OPERATIONTIME,:F_DEL");            
            strSql.Append(") ");            
            		
			OracleParameter[] parameters = {
			            new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_WORKSTATION_NAME", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_SUBORDINATE_ID", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_SUBORDINATE_NAME", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_MEMO", OracleType.VarChar,500) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
			    
			if (model.F_WORKSTATION_ID==null)
			{
            	parameters[0].Value = DBNull.Value;
            }
            else
            {
                parameters[0].Value = model.F_WORKSTATION_ID;            }
                
			if (model.F_WORKSTATION_NAME==null)
			{
            	parameters[1].Value = DBNull.Value;
            }
            else
            {
                parameters[1].Value = model.F_WORKSTATION_NAME;            }
                
			if (model.F_SUBORDINATE_ID==null)
			{
            	parameters[2].Value = DBNull.Value;
            }
            else
            {
                parameters[2].Value = model.F_SUBORDINATE_ID;            }
                
			if (model.F_SUBORDINATE_NAME==null)
			{
            	parameters[3].Value = DBNull.Value;
            }
            else
            {
                parameters[3].Value = model.F_SUBORDINATE_NAME;            }
                
			if (model.F_MEMO==null)
			{
            	parameters[4].Value = DBNull.Value;
            }
            else
            {
                parameters[4].Value = model.F_MEMO;            }
                
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
                Log.Error("DalDEV_WORK_TO_SUB->Add---FAILED", ex);
                throw ex;
            }
		}
		
	
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(RelayTest.Model.ModelDEV_WORK_TO_SUB model)
		{
		
			try
            {
                Log.Info("DalDEV_WORK_TO_SUB->Update---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_DEV_WORK_TO_SUB set ");
			                        
            strSql.Append(" F_WORKSTATION_ID = :F_WORKSTATION_ID , ");                                    
            strSql.Append(" F_WORKSTATION_NAME = :F_WORKSTATION_NAME , ");                                    
            strSql.Append(" F_SUBORDINATE_ID = :F_SUBORDINATE_ID , ");                                    
            strSql.Append(" F_SUBORDINATE_NAME = :F_SUBORDINATE_NAME , ");                                    
            strSql.Append(" F_MEMO = :F_MEMO , ");                                    
            strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");                                    
            strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");                                    
            strSql.Append(" F_DEL = :F_DEL  ");            			
			strSql.Append(" where F_WORKSTATION_ID=:F_WORKSTATION_ID and F_SUBORDINATE_ID=:F_SUBORDINATE_ID  ");
						
OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_WORKSTATION_NAME", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_SUBORDINATE_ID", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_SUBORDINATE_NAME", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_MEMO", OracleType.VarChar,500) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
						            	if (model.F_WORKSTATION_ID==null)
				{
	            	parameters[0].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[0].Value = model.F_WORKSTATION_ID;	            }
                        	if (model.F_WORKSTATION_NAME==null)
				{
	            	parameters[1].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[1].Value = model.F_WORKSTATION_NAME;	            }
                        	if (model.F_SUBORDINATE_ID==null)
				{
	            	parameters[2].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[2].Value = model.F_SUBORDINATE_ID;	            }
                        	if (model.F_SUBORDINATE_NAME==null)
				{
	            	parameters[3].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[3].Value = model.F_SUBORDINATE_NAME;	            }
                        	if (model.F_MEMO==null)
				{
	            	parameters[4].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[4].Value = model.F_MEMO;	            }
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
                Log.Error("DalDEV_WORK_TO_SUB->Update---FAILED", ex);
                throw ex;
            }
		
		
		
			
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_WORKSTATION_ID,string F_SUBORDINATE_ID)
		{
			
			try
            {
                Log.Info("DalDEV_WORK_TO_SUB->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_DEV_WORK_TO_SUB  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_WORKSTATION_ID=:F_WORKSTATION_ID and F_SUBORDINATE_ID=:F_SUBORDINATE_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar,20),
					new OracleParameter(":F_SUBORDINATE_ID", OracleType.VarChar,20)			};
			parameters[0].Value = F_WORKSTATION_ID;
			parameters[1].Value = F_SUBORDINATE_ID;


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
                Log.Error("DalDEV_WORK_TO_SUB->Delete---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_WORKSTATION_ID,string F_SUBORDINATE_ID)
		{
			
			try
            {
                Log.Info("DalDEV_WORK_TO_SUB->Disabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_DEV_WORK_TO_SUB  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_WORKSTATION_ID=:F_WORKSTATION_ID and F_SUBORDINATE_ID=:F_SUBORDINATE_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar,20),
					new OracleParameter(":F_SUBORDINATE_ID", OracleType.VarChar,20)			};
			parameters[0].Value = F_WORKSTATION_ID;
			parameters[1].Value = F_SUBORDINATE_ID;


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
                Log.Error("DalDEV_WORK_TO_SUB->Disabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_WORKSTATION_ID,string F_SUBORDINATE_ID)
		{
			
			try
            {
                Log.Info("DalDEV_WORK_TO_SUB->Enabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_DEV_WORK_TO_SUB  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_WORKSTATION_ID=:F_WORKSTATION_ID and F_SUBORDINATE_ID=:F_SUBORDINATE_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar,20),
					new OracleParameter(":F_SUBORDINATE_ID", OracleType.VarChar,20)			};
			parameters[0].Value = F_WORKSTATION_ID;
			parameters[1].Value = F_SUBORDINATE_ID;


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
                Log.Error("DalDEV_WORK_TO_SUB->Enabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool Drop(string F_WORKSTATION_ID,string F_SUBORDINATE_ID)
		{
			
			try
            {
                Log.Info("DalDEV_WORK_TO_SUB->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("DELETE FROM  T_DEV_WORK_TO_SUB  ");
			strSql.Append(" where F_WORKSTATION_ID=:F_WORKSTATION_ID and F_SUBORDINATE_ID=:F_SUBORDINATE_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar,20),
					new OracleParameter(":F_SUBORDINATE_ID", OracleType.VarChar,20)			};
			parameters[0].Value = F_WORKSTATION_ID;
			parameters[1].Value = F_SUBORDINATE_ID;


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
                Log.Error("DalDEV_WORK_TO_SUB->Delete---FAILED", ex);
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
                Log.Info("DalDEV_WORK_TO_SUB->DeleteWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_DEV_WORK_TO_SUB  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalDEV_WORK_TO_SUB->DeleteWhere---FAILED", ex);
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
                Log.Info("DalDEV_WORK_TO_SUB->DropWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from  T_DEV_WORK_TO_SUB  ");
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
                Log.Error("DalDEV_WORK_TO_SUB->DropWhere---FAILED", ex);
                throw ex;
            }
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelDEV_WORK_TO_SUB GetModel(string F_WORKSTATION_ID,string F_SUBORDINATE_ID)
		{
			try
            {
                Log.Info("DalDEV_WORK_TO_SUB->GetModel---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select F_WORKSTATION_ID, F_WORKSTATION_NAME, F_SUBORDINATE_ID, F_SUBORDINATE_NAME, F_MEMO, F_CREATE_TIME, F_OPERATOR_ID, F_OPERATIONTIME, F_DEL  ");			
				strSql.Append("  from T_DEV_WORK_TO_SUB ");
				strSql.Append(" where 1=1 AND  F_WORKSTATION_ID=:F_WORKSTATION_ID and F_SUBORDINATE_ID=:F_SUBORDINATE_ID ");
							OracleParameter[] parameters = {
					new OracleParameter(":F_WORKSTATION_ID", OracleType.VarChar,20),
					new OracleParameter(":F_SUBORDINATE_ID", OracleType.VarChar,20)			};
			parameters[0].Value = F_WORKSTATION_ID;
			parameters[1].Value = F_SUBORDINATE_ID;

			
				RelayTest.Model.ModelDEV_WORK_TO_SUB model=new RelayTest.Model.ModelDEV_WORK_TO_SUB();
				DataSet ds=Query(strSql.ToString(),parameters);
			
				if(ds.Tables[0].Rows.Count>0)
				{
																				model.F_WORKSTATION_ID= ds.Tables[0].Rows[0]["F_WORKSTATION_ID"].ToString();
																																								model.F_WORKSTATION_NAME= ds.Tables[0].Rows[0]["F_WORKSTATION_NAME"].ToString();
																																								model.F_SUBORDINATE_ID= ds.Tables[0].Rows[0]["F_SUBORDINATE_ID"].ToString();
																																								model.F_SUBORDINATE_NAME= ds.Tables[0].Rows[0]["F_SUBORDINATE_NAME"].ToString();
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
                Log.Error("DalDEV_WORK_TO_SUB->GetModel---FAILED", ex);
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
                Log.Info("DalDEV_WORK_TO_SUB->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select * ");
				strSql.Append(" FROM T_DEV_WORK_TO_SUB  where 1=1");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				return Query(strSql.ToString());
	            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_WORK_TO_SUB->GetList---FAILED", ex);
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
                Log.Info("DalDEV_WORK_TO_SUB->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select ");
				if(Top>0)
				{
					strSql.Append(" top "+Top.ToString());
				}
				strSql.Append(" * ");
				strSql.Append(" FROM T_DEV_WORK_TO_SUB  where F_DEL=0 ");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				strSql.Append(" order by " + filedOrder);
				return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalDEV_WORK_TO_SUB->GetList---FAILED", ex);
                throw ex;
            }
			
		}
		#endregion Method

   
	}
}

