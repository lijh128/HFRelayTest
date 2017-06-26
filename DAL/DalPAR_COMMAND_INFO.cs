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
	 	//试验命令字信息
		public partial class DalPAR_COMMAND_INFO:DbHelperOra
	{
   		     
   		     
   		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalPAR_COMMAND_INFO));
    
    	#region Method
   		 /// <summary>
		///   是否存在该记录
		/// </summary>
		public bool Exists(decimal F_COMMAND_ID,string F_COMMAND_CODE)
		{
		 try
            {
                Log.Info("DalPAR_COMMAND_INFO->Exists---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select count(1) from T_PAR_COMMAND_INFO");
				strSql.Append(" where 1=1 and ");
				                	                       strSql.Append(" F_COMMAND_ID = :F_COMMAND_ID and  ");
                	           		                 	                       strSql.Append(" F_COMMAND_CODE = :F_COMMAND_CODE  ");
                	           		 							OracleParameter[] parameters = {
					new OracleParameter(":F_COMMAND_ID", OracleType.Number,4),
					new OracleParameter(":F_COMMAND_CODE", OracleType.VarChar,20)			};
			parameters[0].Value = F_COMMAND_ID;
			parameters[1].Value = F_COMMAND_CODE;

			    Log.Info("DalPAR_COMMAND_INFO->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_INFO->Exists---FAILED", ex);
                throw ex;
            }
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(RelayTest.Model.ModelPAR_COMMAND_INFO model)
		{
		
		 try
            {
                Log.Info("DalPAR_COMMAND_INFO->Add---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_PAR_COMMAND_INFO(");			
            strSql.Append("F_COMMAND_ID,F_COMMAND_DESC,F_COMMAND_CODE,F_COMMAND_MEMO,F_CREATE_TIME,F_OPERATOR_ID,F_OPERATIONTIME,F_DEL");
			strSql.Append(") values (");
            strSql.Append(":F_COMMAND_ID,:F_COMMAND_DESC,:F_COMMAND_CODE,:F_COMMAND_MEMO,:F_CREATE_TIME,:F_OPERATOR_ID,:F_OPERATIONTIME,:F_DEL");            
            strSql.Append(") ");            
            		
			OracleParameter[] parameters = {
			            new OracleParameter(":F_COMMAND_ID", OracleType.Number,4) ,            
                        new OracleParameter(":F_COMMAND_DESC", OracleType.VarChar,50) ,            
                        new OracleParameter(":F_COMMAND_CODE", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_COMMAND_MEMO", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
			    
			if (model.F_COMMAND_ID==null)
			{
            	parameters[0].Value = DBNull.Value;
            }
            else
            {
                parameters[0].Value = model.F_COMMAND_ID;            }
                
			if (model.F_COMMAND_DESC==null)
			{
            	parameters[1].Value = DBNull.Value;
            }
            else
            {
                parameters[1].Value = model.F_COMMAND_DESC;            }
                
			if (model.F_COMMAND_CODE==null)
			{
            	parameters[2].Value = DBNull.Value;
            }
            else
            {
                parameters[2].Value = model.F_COMMAND_CODE;            }
                
			if (model.F_COMMAND_MEMO==null)
			{
            	parameters[3].Value = DBNull.Value;
            }
            else
            {
                parameters[3].Value = model.F_COMMAND_MEMO;            }
                
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
                Log.Error("DalPAR_COMMAND_INFO->Add---FAILED", ex);
                throw ex;
            }
		}
		
	
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(RelayTest.Model.ModelPAR_COMMAND_INFO model)
		{
		
			try
            {
                Log.Info("DalPAR_COMMAND_INFO->Update---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_PAR_COMMAND_INFO set ");
			                        
            strSql.Append(" F_COMMAND_ID = :F_COMMAND_ID , ");                                    
            strSql.Append(" F_COMMAND_DESC = :F_COMMAND_DESC , ");                                    
            strSql.Append(" F_COMMAND_CODE = :F_COMMAND_CODE , ");                                    
            strSql.Append(" F_COMMAND_MEMO = :F_COMMAND_MEMO , ");                                    
            strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");                                    
            strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");                                    
            strSql.Append(" F_DEL = :F_DEL  ");            			
			strSql.Append(" where F_COMMAND_ID=:F_COMMAND_ID and F_COMMAND_CODE=:F_COMMAND_CODE  ");
						
OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_COMMAND_ID", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_COMMAND_DESC", OracleType.VarChar,50) ,            
                        	
            new OracleParameter(":F_COMMAND_CODE", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_COMMAND_MEMO", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
						            	if (model.F_COMMAND_ID==null)
				{
	            	parameters[0].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[0].Value = model.F_COMMAND_ID;	            }
                        	if (model.F_COMMAND_DESC==null)
				{
	            	parameters[1].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[1].Value = model.F_COMMAND_DESC;	            }
                        	if (model.F_COMMAND_CODE==null)
				{
	            	parameters[2].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[2].Value = model.F_COMMAND_CODE;	            }
                        	if (model.F_COMMAND_MEMO==null)
				{
	            	parameters[3].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[3].Value = model.F_COMMAND_MEMO;	            }
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
                Log.Error("DalPAR_COMMAND_INFO->Update---FAILED", ex);
                throw ex;
            }
		
		
		
			
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(decimal F_COMMAND_ID,string F_COMMAND_CODE)
		{
			
			try
            {
                Log.Info("DalPAR_COMMAND_INFO->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_PAR_COMMAND_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_COMMAND_ID=:F_COMMAND_ID and F_COMMAND_CODE=:F_COMMAND_CODE ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_COMMAND_ID", OracleType.Number,4),
					new OracleParameter(":F_COMMAND_CODE", OracleType.VarChar,20)			};
			parameters[0].Value = F_COMMAND_ID;
			parameters[1].Value = F_COMMAND_CODE;


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
                Log.Error("DalPAR_COMMAND_INFO->Delete---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(decimal F_COMMAND_ID,string F_COMMAND_CODE)
		{
			
			try
            {
                Log.Info("DalPAR_COMMAND_INFO->Disabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_PAR_COMMAND_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_COMMAND_ID=:F_COMMAND_ID and F_COMMAND_CODE=:F_COMMAND_CODE ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_COMMAND_ID", OracleType.Number,4),
					new OracleParameter(":F_COMMAND_CODE", OracleType.VarChar,20)			};
			parameters[0].Value = F_COMMAND_ID;
			parameters[1].Value = F_COMMAND_CODE;


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
                Log.Error("DalPAR_COMMAND_INFO->Disabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(decimal F_COMMAND_ID,string F_COMMAND_CODE)
		{
			
			try
            {
                Log.Info("DalPAR_COMMAND_INFO->Enabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_PAR_COMMAND_INFO  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_COMMAND_ID=:F_COMMAND_ID and F_COMMAND_CODE=:F_COMMAND_CODE ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_COMMAND_ID", OracleType.Number,4),
					new OracleParameter(":F_COMMAND_CODE", OracleType.VarChar,20)			};
			parameters[0].Value = F_COMMAND_ID;
			parameters[1].Value = F_COMMAND_CODE;


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
                Log.Error("DalPAR_COMMAND_INFO->Enabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool Drop(decimal F_COMMAND_ID,string F_COMMAND_CODE)
		{
			
			try
            {
                Log.Info("DalPAR_COMMAND_INFO->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("DELETE FROM  T_PAR_COMMAND_INFO  ");
			strSql.Append(" where F_COMMAND_ID=:F_COMMAND_ID and F_COMMAND_CODE=:F_COMMAND_CODE ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_COMMAND_ID", OracleType.Number,4),
					new OracleParameter(":F_COMMAND_CODE", OracleType.VarChar,20)			};
			parameters[0].Value = F_COMMAND_ID;
			parameters[1].Value = F_COMMAND_CODE;


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
                Log.Error("DalPAR_COMMAND_INFO->Delete---FAILED", ex);
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
                Log.Info("DalPAR_COMMAND_INFO->DeleteWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_PAR_COMMAND_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalPAR_COMMAND_INFO->DeleteWhere---FAILED", ex);
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
                Log.Info("DalPAR_COMMAND_INFO->DropWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from  T_PAR_COMMAND_INFO  ");
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
                Log.Error("DalPAR_COMMAND_INFO->DropWhere---FAILED", ex);
                throw ex;
            }
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelPAR_COMMAND_INFO GetModel(decimal F_COMMAND_ID,string F_COMMAND_CODE)
		{
			try
            {
                Log.Info("DalPAR_COMMAND_INFO->GetModel---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select F_COMMAND_ID, F_COMMAND_DESC, F_COMMAND_CODE, F_COMMAND_MEMO, F_CREATE_TIME, F_OPERATOR_ID, F_OPERATIONTIME, F_DEL  ");			
				strSql.Append("  from T_PAR_COMMAND_INFO ");
				strSql.Append(" where 1=1 AND  F_COMMAND_ID=:F_COMMAND_ID and F_COMMAND_CODE=:F_COMMAND_CODE ");
							OracleParameter[] parameters = {
					new OracleParameter(":F_COMMAND_ID", OracleType.Number,4),
					new OracleParameter(":F_COMMAND_CODE", OracleType.VarChar,20)			};
			parameters[0].Value = F_COMMAND_ID;
			parameters[1].Value = F_COMMAND_CODE;

			
				RelayTest.Model.ModelPAR_COMMAND_INFO model=new RelayTest.Model.ModelPAR_COMMAND_INFO();
				DataSet ds=Query(strSql.ToString(),parameters);
			
				if(ds.Tables[0].Rows.Count>0)
				{
															if(ds.Tables[0].Rows[0]["F_COMMAND_ID"].ToString()!="")
					{
						model.F_COMMAND_ID=decimal.Parse(ds.Tables[0].Rows[0]["F_COMMAND_ID"].ToString());
					}
																																													model.F_COMMAND_DESC= ds.Tables[0].Rows[0]["F_COMMAND_DESC"].ToString();
																																								model.F_COMMAND_CODE= ds.Tables[0].Rows[0]["F_COMMAND_CODE"].ToString();
																																								model.F_COMMAND_MEMO= ds.Tables[0].Rows[0]["F_COMMAND_MEMO"].ToString();
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
                Log.Error("DalPAR_COMMAND_INFO->GetModel---FAILED", ex);
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
                Log.Info("DalPAR_COMMAND_INFO->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select * ");
				strSql.Append(" FROM T_PAR_COMMAND_INFO  where 1=1");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				return Query(strSql.ToString());
	            }
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_INFO->GetList---FAILED", ex);
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
                Log.Info("DalPAR_COMMAND_INFO->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select ");
				if(Top>0)
				{
					strSql.Append(" top "+Top.ToString());
				}
				strSql.Append(" * ");
				strSql.Append(" FROM T_PAR_COMMAND_INFO  where F_DEL=0 ");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				strSql.Append(" order by " + filedOrder);
				return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_INFO->GetList---FAILED", ex);
                throw ex;
            }
			
		}
		#endregion Method

        #region 自定义函数
        /// <summary>
        /// 获得指定命令编号的记录数量
        /// tempCommandCode   命令编码
        /// 返回值：0--没有改命令编号的记录；1--存在该命令编号的记录
        /// </summary>
        public DataSet GetCommandCount(string tempCommandCode)
        {
            try
            {
                Log.Info("DalPAR_COMMAND_INFO->GetCommandCount---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select count(*) ");
                strSql.Append(" FROM T_PAR_COMMAND_INFO  where F_DEL=0");
                if (tempCommandCode.Trim() != "")
                {
                    strSql.Append(" and F_COMMAND_CODE='" + tempCommandCode + "'");
                }
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_INFO->GetCommandCount---FAILED", ex);
                throw ex;
            }
        }
        #endregion
   
	}
}

