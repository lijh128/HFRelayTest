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
		public partial class DalSYSTEM_LIST:DbHelperOra
	{
   		     
   		     
   		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalSYSTEM_LIST));
    
    	#region Method
   		 /// <summary>
		///   是否存在该记录
		/// </summary>
		public bool Exists(string F_TYPE,decimal F_VALUE)
		{
		 try
            {
                Log.Info("DalSYSTEM_LIST->Exists---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select count(1) from T_SYSTEM_LIST");
				strSql.Append(" where 1=1 and ");
				                	                       strSql.Append(" F_TYPE = :F_TYPE and  ");
                	           		                 	                       strSql.Append(" F_VALUE = :F_VALUE  ");
                	           		 							OracleParameter[] parameters = {
					new OracleParameter(":F_TYPE", OracleType.VarChar,50),
					new OracleParameter(":F_VALUE", OracleType.Number,4)			};
			parameters[0].Value = F_TYPE;
			parameters[1].Value = F_VALUE;

			    Log.Info("DalSYSTEM_LIST->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalSYSTEM_LIST->Exists---FAILED", ex);
                throw ex;
            }
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(RelayTest.Model.ModelSYSTEM_LIST model)
		{
		
		 try
            {
                Log.Info("DalSYSTEM_LIST->Add---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_SYSTEM_LIST(");			
            strSql.Append("F_TYPE,F_VALUE,F_DISPLAY");
			strSql.Append(") values (");
            strSql.Append(":F_TYPE,:F_VALUE,:F_DISPLAY");            
            strSql.Append(") ");            
            		
			OracleParameter[] parameters = {
			            new OracleParameter(":F_TYPE", OracleType.VarChar,50) ,            
                        new OracleParameter(":F_VALUE", OracleType.Number,4) ,            
                        new OracleParameter(":F_DISPLAY", OracleType.VarChar,50)             
              
            };
			    
			if (model.F_TYPE==null)
			{
            	parameters[0].Value = DBNull.Value;
            }
            else
            {
                parameters[0].Value = model.F_TYPE;            }
                
			if (model.F_VALUE==null)
			{
            	parameters[1].Value = DBNull.Value;
            }
            else
            {
                parameters[1].Value = model.F_VALUE;            }
                
			if (model.F_DISPLAY==null)
			{
            	parameters[2].Value = DBNull.Value;
            }
            else
            {
                parameters[2].Value = model.F_DISPLAY;            }
                        
			            ExecuteSql(strSql.ToString(),parameters);
            			
			}
            catch (Exception ex)
            {
                Log.Error("DalSYSTEM_LIST->Add---FAILED", ex);
                throw ex;
            }
		}
		
	
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(RelayTest.Model.ModelSYSTEM_LIST model)
		{
		
			try
            {
                Log.Info("DalSYSTEM_LIST->Update---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_SYSTEM_LIST set ");
			                        
            strSql.Append(" F_TYPE = :F_TYPE , ");                                    
            strSql.Append(" F_VALUE = :F_VALUE , ");                                    
            strSql.Append(" F_DISPLAY = :F_DISPLAY  ");            			
			strSql.Append(" where F_TYPE=:F_TYPE and F_VALUE=:F_VALUE  ");
						
OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_TYPE", OracleType.VarChar,50) ,            
                        	
            new OracleParameter(":F_VALUE", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_DISPLAY", OracleType.VarChar,50)             
              
            };
						            	if (model.F_TYPE==null)
				{
	            	parameters[0].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[0].Value = model.F_TYPE;	            }
                        	if (model.F_VALUE==null)
				{
	            	parameters[1].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[1].Value = model.F_VALUE;	            }
                        	if (model.F_DISPLAY==null)
				{
	            	parameters[2].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[2].Value = model.F_DISPLAY;	            }
                        
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
                Log.Error("DalSYSTEM_LIST->Update---FAILED", ex);
                throw ex;
            }
		
		
		
			
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_TYPE,decimal F_VALUE)
		{
			
			try
            {
                Log.Info("DalSYSTEM_LIST->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_SYSTEM_LIST  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_TYPE=:F_TYPE and F_VALUE=:F_VALUE ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TYPE", OracleType.VarChar,50),
					new OracleParameter(":F_VALUE", OracleType.Number,4)			};
			parameters[0].Value = F_TYPE;
			parameters[1].Value = F_VALUE;


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
                Log.Error("DalSYSTEM_LIST->Delete---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_TYPE,decimal F_VALUE)
		{
			
			try
            {
                Log.Info("DalSYSTEM_LIST->Disabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_SYSTEM_LIST  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_TYPE=:F_TYPE and F_VALUE=:F_VALUE ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TYPE", OracleType.VarChar,50),
					new OracleParameter(":F_VALUE", OracleType.Number,4)			};
			parameters[0].Value = F_TYPE;
			parameters[1].Value = F_VALUE;


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
                Log.Error("DalSYSTEM_LIST->Disabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_TYPE,decimal F_VALUE)
		{
			
			try
            {
                Log.Info("DalSYSTEM_LIST->Enabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_SYSTEM_LIST  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_TYPE=:F_TYPE and F_VALUE=:F_VALUE ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TYPE", OracleType.VarChar,50),
					new OracleParameter(":F_VALUE", OracleType.Number,4)			};
			parameters[0].Value = F_TYPE;
			parameters[1].Value = F_VALUE;


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
                Log.Error("DalSYSTEM_LIST->Enabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool Drop(string F_TYPE,decimal F_VALUE)
		{
			
			try
            {
                Log.Info("DalSYSTEM_LIST->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("DELETE FROM  T_SYSTEM_LIST  ");
			strSql.Append(" where F_TYPE=:F_TYPE and F_VALUE=:F_VALUE ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TYPE", OracleType.VarChar,50),
					new OracleParameter(":F_VALUE", OracleType.Number,4)			};
			parameters[0].Value = F_TYPE;
			parameters[1].Value = F_VALUE;


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
                Log.Error("DalSYSTEM_LIST->Delete---FAILED", ex);
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
                Log.Info("DalSYSTEM_LIST->DeleteWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_SYSTEM_LIST  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalSYSTEM_LIST->DeleteWhere---FAILED", ex);
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
                Log.Info("DalSYSTEM_LIST->DropWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from  T_SYSTEM_LIST  ");
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
                Log.Error("DalSYSTEM_LIST->DropWhere---FAILED", ex);
                throw ex;
            }
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelSYSTEM_LIST GetModel(string F_TYPE,decimal F_VALUE)
		{
			try
            {
                Log.Info("DalSYSTEM_LIST->GetModel---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select F_TYPE, F_VALUE, F_DISPLAY  ");			
				strSql.Append("  from T_SYSTEM_LIST ");
				strSql.Append(" where 1=1 AND  F_TYPE=:F_TYPE and F_VALUE=:F_VALUE ");
							OracleParameter[] parameters = {
					new OracleParameter(":F_TYPE", OracleType.VarChar,50),
					new OracleParameter(":F_VALUE", OracleType.Number,4)			};
			parameters[0].Value = F_TYPE;
			parameters[1].Value = F_VALUE;

			
				RelayTest.Model.ModelSYSTEM_LIST model=new RelayTest.Model.ModelSYSTEM_LIST();
				DataSet ds=Query(strSql.ToString(),parameters);
			
				if(ds.Tables[0].Rows.Count>0)
				{
																				model.F_TYPE= ds.Tables[0].Rows[0]["F_TYPE"].ToString();
																																			if(ds.Tables[0].Rows[0]["F_VALUE"].ToString()!="")
					{
						model.F_VALUE=decimal.Parse(ds.Tables[0].Rows[0]["F_VALUE"].ToString());
					}
																																													model.F_DISPLAY= ds.Tables[0].Rows[0]["F_DISPLAY"].ToString();
																															
					return model;
				}
				else
				{
					return null;
				}
            }
            catch (Exception ex)
            {
                Log.Error("DalSYSTEM_LIST->GetModel---FAILED", ex);
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
                Log.Info("DalSYSTEM_LIST->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select * ");
				strSql.Append(" FROM T_SYSTEM_LIST  where 1=1");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				return Query(strSql.ToString());
	            }
            catch (Exception ex)
            {
                Log.Error("DalSYSTEM_LIST->GetList---FAILED", ex);
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
                Log.Info("DalSYSTEM_LIST->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select ");
				if(Top>0)
				{
					strSql.Append(" top "+Top.ToString());
				}
				strSql.Append(" * ");
				strSql.Append(" FROM T_SYSTEM_LIST  where F_DEL=0 ");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				strSql.Append(" order by " + filedOrder);
				return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalSYSTEM_LIST->GetList---FAILED", ex);
                throw ex;
            }
			
		}
		#endregion Method

   
	}
}

