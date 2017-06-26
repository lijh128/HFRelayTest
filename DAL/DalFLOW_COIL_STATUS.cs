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
	 	//线圈电源状态转换流水
		public partial class DalFLOW_COIL_STATUS:DbHelperOra
	{
   		     
   		     
   		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalFLOW_COIL_STATUS));
    
    	#region Method
   		 /// <summary>
		///   是否存在该记录
		/// </summary>
		public bool Exists(decimal F__ID)
		{
		 try
            {
                Log.Info("DalFLOW_COIL_STATUS->Exists---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select count(1) from T_FLOW_COIL_STATUS");
				strSql.Append(" where 1=1 and ");
				                	                       strSql.Append(" F__ID = :F__ID  ");
                	           		 							OracleParameter[] parameters = {
					new OracleParameter(":F__ID", OracleType.Number,18)			};
			parameters[0].Value = F__ID;

			    Log.Info("DalFLOW_COIL_STATUS->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalFLOW_COIL_STATUS->Exists---FAILED", ex);
                throw ex;
            }
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(RelayTest.Model.ModelFLOW_COIL_STATUS model)
		{
		
		 try
            {
                Log.Info("DalFLOW_COIL_STATUS->Add---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_FLOW_COIL_STATUS(");			
            strSql.Append("F__ID,F_COILPOWER_ID,F_COILPOWER_NAME,F_COILPOWER_SWITCH_STATUS,F_MEMO,F_CREATE_TIME,F_OPERATOR_ID,F_OPERATIONTIME,F_DEL");
			strSql.Append(") values (");
            strSql.Append(":F__ID,:F_COILPOWER_ID,:F_COILPOWER_NAME,:F_COILPOWER_SWITCH_STATUS,:F_MEMO,:F_CREATE_TIME,:F_OPERATOR_ID,:F_OPERATIONTIME,:F_DEL");            
            strSql.Append(") ");            
            		
			OracleParameter[] parameters = {
			            new OracleParameter(":F__ID", OracleType.Number,18) ,            
                        new OracleParameter(":F_COILPOWER_ID", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_COILPOWER_NAME", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_COILPOWER_SWITCH_STATUS", OracleType.Number,4) ,            
                        new OracleParameter(":F_MEMO", OracleType.VarChar,500) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
			    
			if (model.F__ID==null)
			{
            	parameters[0].Value = DBNull.Value;
            }
            else
            {
                parameters[0].Value = model.F__ID;            }
                
			if (model.F_COILPOWER_ID==null)
			{
            	parameters[1].Value = DBNull.Value;
            }
            else
            {
                parameters[1].Value = model.F_COILPOWER_ID;            }
                
			if (model.F_COILPOWER_NAME==null)
			{
            	parameters[2].Value = DBNull.Value;
            }
            else
            {
                parameters[2].Value = model.F_COILPOWER_NAME;            }
                
			if (model.F_COILPOWER_SWITCH_STATUS==null)
			{
            	parameters[3].Value = DBNull.Value;
            }
            else
            {
                parameters[3].Value = model.F_COILPOWER_SWITCH_STATUS;            }
                
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
                Log.Error("DalFLOW_COIL_STATUS->Add---FAILED", ex);
                throw ex;
            }
		}
		
	
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(RelayTest.Model.ModelFLOW_COIL_STATUS model)
		{
		
			try
            {
                Log.Info("DalFLOW_COIL_STATUS->Update---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_FLOW_COIL_STATUS set ");
			                        
            strSql.Append(" F__ID = :F__ID , ");                                    
            strSql.Append(" F_COILPOWER_ID = :F_COILPOWER_ID , ");                                    
            strSql.Append(" F_COILPOWER_NAME = :F_COILPOWER_NAME , ");                                    
            strSql.Append(" F_COILPOWER_SWITCH_STATUS = :F_COILPOWER_SWITCH_STATUS , ");                                    
            strSql.Append(" F_MEMO = :F_MEMO , ");                                    
            strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");                                    
            strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");                                    
            strSql.Append(" F_DEL = :F_DEL  ");            			
			strSql.Append(" where F__ID=:F__ID  ");
						
OracleParameter[] parameters = {
			            	
            new OracleParameter(":F__ID", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_COILPOWER_ID", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_COILPOWER_NAME", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_COILPOWER_SWITCH_STATUS", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_MEMO", OracleType.VarChar,500) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
						            	if (model.F__ID==null)
				{
	            	parameters[0].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[0].Value = model.F__ID;	            }
                        	if (model.F_COILPOWER_ID==null)
				{
	            	parameters[1].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[1].Value = model.F_COILPOWER_ID;	            }
                        	if (model.F_COILPOWER_NAME==null)
				{
	            	parameters[2].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[2].Value = model.F_COILPOWER_NAME;	            }
                        	if (model.F_COILPOWER_SWITCH_STATUS==null)
				{
	            	parameters[3].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[3].Value = model.F_COILPOWER_SWITCH_STATUS;	            }
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
                Log.Error("DalFLOW_COIL_STATUS->Update---FAILED", ex);
                throw ex;
            }
		
		
		
			
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(decimal F__ID)
		{
			
			try
            {
                Log.Info("DalFLOW_COIL_STATUS->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_FLOW_COIL_STATUS  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F__ID=:F__ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F__ID", OracleType.Number,18)			};
			parameters[0].Value = F__ID;


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
                Log.Error("DalFLOW_COIL_STATUS->Delete---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(decimal F__ID)
		{
			
			try
            {
                Log.Info("DalFLOW_COIL_STATUS->Disabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_FLOW_COIL_STATUS  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F__ID=:F__ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F__ID", OracleType.Number,18)			};
			parameters[0].Value = F__ID;


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
                Log.Error("DalFLOW_COIL_STATUS->Disabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(decimal F__ID)
		{
			
			try
            {
                Log.Info("DalFLOW_COIL_STATUS->Enabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_FLOW_COIL_STATUS  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F__ID=:F__ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F__ID", OracleType.Number,18)			};
			parameters[0].Value = F__ID;


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
                Log.Error("DalFLOW_COIL_STATUS->Enabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool Drop(decimal F__ID)
		{
			
			try
            {
                Log.Info("DalFLOW_COIL_STATUS->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("DELETE FROM  T_FLOW_COIL_STATUS  ");
			strSql.Append(" where F__ID=:F__ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F__ID", OracleType.Number,18)			};
			parameters[0].Value = F__ID;


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
                Log.Error("DalFLOW_COIL_STATUS->Delete---FAILED", ex);
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
                Log.Info("DalFLOW_COIL_STATUS->DeleteWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_FLOW_COIL_STATUS  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalFLOW_COIL_STATUS->DeleteWhere---FAILED", ex);
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
                Log.Info("DalFLOW_COIL_STATUS->DropWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from  T_FLOW_COIL_STATUS  ");
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
                Log.Error("DalFLOW_COIL_STATUS->DropWhere---FAILED", ex);
                throw ex;
            }
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelFLOW_COIL_STATUS GetModel(decimal F__ID)
		{
			try
            {
                Log.Info("DalFLOW_COIL_STATUS->GetModel---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select F__ID, F_COILPOWER_ID, F_COILPOWER_NAME, F_COILPOWER_SWITCH_STATUS, F_MEMO, F_CREATE_TIME, F_OPERATOR_ID, F_OPERATIONTIME, F_DEL  ");			
				strSql.Append("  from T_FLOW_COIL_STATUS ");
				strSql.Append(" where 1=1 AND  F__ID=:F__ID ");
							OracleParameter[] parameters = {
					new OracleParameter(":F__ID", OracleType.Number,18)			};
			parameters[0].Value = F__ID;

			
				RelayTest.Model.ModelFLOW_COIL_STATUS model=new RelayTest.Model.ModelFLOW_COIL_STATUS();
				DataSet ds=Query(strSql.ToString(),parameters);
			
				if(ds.Tables[0].Rows.Count>0)
				{
															if(ds.Tables[0].Rows[0]["F__ID"].ToString()!="")
					{
						model.F__ID=decimal.Parse(ds.Tables[0].Rows[0]["F__ID"].ToString());
					}
																																													model.F_COILPOWER_ID= ds.Tables[0].Rows[0]["F_COILPOWER_ID"].ToString();
																																								model.F_COILPOWER_NAME= ds.Tables[0].Rows[0]["F_COILPOWER_NAME"].ToString();
																																			if(ds.Tables[0].Rows[0]["F_COILPOWER_SWITCH_STATUS"].ToString()!="")
					{
						model.F_COILPOWER_SWITCH_STATUS=decimal.Parse(ds.Tables[0].Rows[0]["F_COILPOWER_SWITCH_STATUS"].ToString());
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
                Log.Error("DalFLOW_COIL_STATUS->GetModel---FAILED", ex);
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
                Log.Info("DalFLOW_COIL_STATUS->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select * ");
				strSql.Append(" FROM T_FLOW_COIL_STATUS  where 1=1");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				return Query(strSql.ToString());
	            }
            catch (Exception ex)
            {
                Log.Error("DalFLOW_COIL_STATUS->GetList---FAILED", ex);
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
                Log.Info("DalFLOW_COIL_STATUS->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select ");
				if(Top>0)
				{
					strSql.Append(" top "+Top.ToString());
				}
				strSql.Append(" * ");
				strSql.Append(" FROM T_FLOW_COIL_STATUS  where F_DEL=0 ");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				strSql.Append(" order by " + filedOrder);
				return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalFLOW_COIL_STATUS->GetList---FAILED", ex);
                throw ex;
            }
			
		}
		#endregion Method

   
	}
}

