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
	 	//试验发送命令参数值表
		public partial class DalTEST_SENDP_VALUE:DbHelperOra
	{
   		     
   		     
   		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalTEST_SENDP_VALUE));
    
    	#region Method
   		 /// <summary>
		///   是否存在该记录
		/// </summary>
		public bool Exists(string F_TASK_ID,string F_PROGRAM_CODE,string F_SENDPAR_NAME)
		{
		 try
            {
                Log.Info("DalTEST_SENDP_VALUE->Exists---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select count(1) from T_TEST_SENDP_VALUE");
				strSql.Append(" where 1=1 and ");
				                	                       strSql.Append(" F_TASK_ID = :F_TASK_ID and  ");
                	           		                 	                       strSql.Append(" F_PROGRAM_CODE = :F_PROGRAM_CODE and  ");
                	           		                 	                       strSql.Append(" F_SENDPAR_NAME = :F_SENDPAR_NAME  ");
                	           		 							OracleParameter[] parameters = {
					new OracleParameter(":F_TASK_ID", OracleType.VarChar,50),
					new OracleParameter(":F_PROGRAM_CODE", OracleType.VarChar,10),
					new OracleParameter(":F_SENDPAR_NAME", OracleType.VarChar,100)			};
			parameters[0].Value = F_TASK_ID;
			parameters[1].Value = F_PROGRAM_CODE;
			parameters[2].Value = F_SENDPAR_NAME;

			    Log.Info("DalTEST_SENDP_VALUE->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_SENDP_VALUE->Exists---FAILED", ex);
                throw ex;
            }
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(RelayTest.Model.ModelTEST_SENDP_VALUE model)
		{
		
		 try
            {
                Log.Info("DalTEST_SENDP_VALUE->Add---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_TEST_SENDP_VALUE(");
			
						//试验任务编号
            strSql.Append("  F_TASK_ID,");
            			//工作模式名称
            strSql.Append("  F_WORKTYPE_NAME,");
            			//工作模式编码
            strSql.Append("  F_WORKTYPE_CODE,");
            			//程序代码
            strSql.Append("  F_PROGRAM_CODE,");
            			//参数名称
            strSql.Append("  F_SENDPAR_NAME,");
            			//参数值
            strSql.Append("  F_SENDPAR_VALUE,");
            			//排序序号
            strSql.Append("  F_SENDORDER,");
            			//备注
            strSql.Append("  F_SENDPAR_MEMO,");
            			//创建时间
            strSql.Append("  F_CREATE_TIME,");
            			//操作员
            strSql.Append("  F_OPERATOR_ID,");
            			//操作时间
            strSql.Append("  F_OPERATIONTIME,");
            			//是否删除
            strSql.Append("  F_DEL");
            			strSql.Append(") values (");
			            strSql.Append(" :F_TASK_ID,");            
                         strSql.Append(" :F_WORKTYPE_NAME,");            
                         strSql.Append(" :F_WORKTYPE_CODE,");            
                         strSql.Append(" :F_PROGRAM_CODE,");            
                         strSql.Append(" :F_SENDPAR_NAME,");            
                         strSql.Append(" :F_SENDPAR_VALUE,");            
                         strSql.Append(" :F_SENDORDER,");            
                         strSql.Append(" :F_SENDPAR_MEMO,");            
                         strSql.Append(" :F_CREATE_TIME,");            
                         strSql.Append(" :F_OPERATOR_ID,");            
                         strSql.Append(" :F_OPERATIONTIME,");            
                         strSql.Append(" :F_DEL");            
                         strSql.Append(") ");            
            		
			OracleParameter[] parameters = {
			            new OracleParameter(":F_TASK_ID", OracleType.VarChar,50) ,            
                        new OracleParameter(":F_WORKTYPE_NAME", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_WORKTYPE_CODE", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_PROGRAM_CODE", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_SENDPAR_NAME", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_SENDPAR_VALUE", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_SENDORDER", OracleType.Number,4) ,            
                        new OracleParameter(":F_SENDPAR_MEMO", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
			    
			//试验任务编号
			if (model.F_TASK_ID==null)
			{
            	parameters[0].Value = DBNull.Value;
            }
            else
            {
                parameters[0].Value = model.F_TASK_ID;            }
                
			//工作模式名称
			if (model.F_WORKTYPE_NAME==null)
			{
            	parameters[1].Value = DBNull.Value;
            }
            else
            {
                parameters[1].Value = model.F_WORKTYPE_NAME;            }
                
			//工作模式编码
			if (model.F_WORKTYPE_CODE==null)
			{
            	parameters[2].Value = DBNull.Value;
            }
            else
            {
                parameters[2].Value = model.F_WORKTYPE_CODE;            }
                
			//程序代码
			if (model.F_PROGRAM_CODE==null)
			{
            	parameters[3].Value = DBNull.Value;
            }
            else
            {
                parameters[3].Value = model.F_PROGRAM_CODE;            }
                
			//参数名称
			if (model.F_SENDPAR_NAME==null)
			{
            	parameters[4].Value = DBNull.Value;
            }
            else
            {
                parameters[4].Value = model.F_SENDPAR_NAME;            }
                
			//参数值
			if (model.F_SENDPAR_VALUE==null)
			{
            	parameters[5].Value = DBNull.Value;
            }
            else
            {
                parameters[5].Value = model.F_SENDPAR_VALUE;            }
                
			//排序序号
			if (model.F_SENDORDER==null)
			{
            	parameters[6].Value = DBNull.Value;
            }
            else
            {
                parameters[6].Value = model.F_SENDORDER;            }
                
			//备注
			if (model.F_SENDPAR_MEMO==null)
			{
            	parameters[7].Value = DBNull.Value;
            }
            else
            {
                parameters[7].Value = model.F_SENDPAR_MEMO;            }
                
			//创建时间
			if (model.F_CREATE_TIME==null)
			{
            	parameters[8].Value = DBNull.Value;
            }
            else
            {
                parameters[8].Value = model.F_CREATE_TIME;            }
                
			//操作员
			if (model.F_OPERATOR_ID==null)
			{
            	parameters[9].Value = DBNull.Value;
            }
            else
            {
                parameters[9].Value = model.F_OPERATOR_ID;            }
                
			//操作时间
			if (model.F_OPERATIONTIME==null)
			{
            	parameters[10].Value = DBNull.Value;
            }
            else
            {
                parameters[10].Value = model.F_OPERATIONTIME;            }
                
			//是否删除
			if (model.F_DEL==null)
			{
            	parameters[11].Value = DBNull.Value;
            }
            else
            {
                parameters[11].Value = model.F_DEL;            }
                        
			            ExecuteSql(strSql.ToString(),parameters);
            			
			}
            catch (Exception ex)
            {
                Log.Error("DalTEST_SENDP_VALUE->Add---FAILED", ex);
                throw ex;
            }
		}
		
	
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(RelayTest.Model.ModelTEST_SENDP_VALUE model)
		{
		
			try
            {
                Log.Info("DalTEST_SENDP_VALUE->Update---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_TEST_SENDP_VALUE set ");
			             
            //试验任务编号
            strSql.Append(" F_TASK_ID = :F_TASK_ID , ");
                         
            //工作模式名称
            strSql.Append(" F_WORKTYPE_NAME = :F_WORKTYPE_NAME , ");
                         
            //工作模式编码
            strSql.Append(" F_WORKTYPE_CODE = :F_WORKTYPE_CODE , ");
                         
            //程序代码
            strSql.Append(" F_PROGRAM_CODE = :F_PROGRAM_CODE , ");
                         
            //参数名称
            strSql.Append(" F_SENDPAR_NAME = :F_SENDPAR_NAME , ");
                         
            //参数值
            strSql.Append(" F_SENDPAR_VALUE = :F_SENDPAR_VALUE , ");
                         
            //排序序号
            strSql.Append(" F_SENDORDER = :F_SENDORDER , ");
                         
            //备注
            strSql.Append(" F_SENDPAR_MEMO = :F_SENDPAR_MEMO , ");
                         
            //操作员
            strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");
                         
            //操作时间
            strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");
                         
            //是否删除
            strSql.Append(" F_DEL = :F_DEL  ");
            			
			strSql.Append(" where F_TASK_ID=:F_TASK_ID and F_PROGRAM_CODE=:F_PROGRAM_CODE and F_SENDPAR_NAME=:F_SENDPAR_NAME  ");
						
OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_TASK_ID", OracleType.VarChar,50) ,            
                        	
            new OracleParameter(":F_WORKTYPE_NAME", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_WORKTYPE_CODE", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_PROGRAM_CODE", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_SENDPAR_NAME", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_SENDPAR_VALUE", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_SENDORDER", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_SENDPAR_MEMO", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
									//试验任务编号
            	if (model.F_TASK_ID==null)
				{
	            	parameters[0].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[0].Value = model.F_TASK_ID;	            }
            			//工作模式名称
            	if (model.F_WORKTYPE_NAME==null)
				{
	            	parameters[1].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[1].Value = model.F_WORKTYPE_NAME;	            }
            			//工作模式编码
            	if (model.F_WORKTYPE_CODE==null)
				{
	            	parameters[2].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[2].Value = model.F_WORKTYPE_CODE;	            }
            			//程序代码
            	if (model.F_PROGRAM_CODE==null)
				{
	            	parameters[3].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[3].Value = model.F_PROGRAM_CODE;	            }
            			//参数名称
            	if (model.F_SENDPAR_NAME==null)
				{
	            	parameters[4].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[4].Value = model.F_SENDPAR_NAME;	            }
            			//参数值
            	if (model.F_SENDPAR_VALUE==null)
				{
	            	parameters[5].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[5].Value = model.F_SENDPAR_VALUE;	            }
            			//排序序号
            	if (model.F_SENDORDER==null)
				{
	            	parameters[6].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[6].Value = model.F_SENDORDER;	            }
            			//备注
            	if (model.F_SENDPAR_MEMO==null)
				{
	            	parameters[7].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[7].Value = model.F_SENDPAR_MEMO;	            }
            			//操作员
            	if (model.F_OPERATOR_ID==null)
				{
	            	parameters[8].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[8].Value = model.F_OPERATOR_ID;	            }
            			//操作时间
            	if (model.F_OPERATIONTIME==null)
				{
	            	parameters[9].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[9].Value = model.F_OPERATIONTIME;	            }
            			//是否删除
            	if (model.F_DEL==null)
				{
	            	parameters[10].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[10].Value = model.F_DEL;	            }
                        
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
                Log.Error("DalTEST_SENDP_VALUE->Update---FAILED", ex);
                throw ex;
            }
		
		
		
			
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_TASK_ID,string F_PROGRAM_CODE,string F_SENDPAR_NAME)
		{
			
			try
            {
                Log.Info("DalTEST_SENDP_VALUE->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_SENDP_VALUE  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_TASK_ID=:F_TASK_ID and F_PROGRAM_CODE=:F_PROGRAM_CODE and F_SENDPAR_NAME=:F_SENDPAR_NAME ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TASK_ID", OracleType.VarChar,50),
					new OracleParameter(":F_PROGRAM_CODE", OracleType.VarChar,10),
					new OracleParameter(":F_SENDPAR_NAME", OracleType.VarChar,100)			};
			parameters[0].Value = F_TASK_ID;
			parameters[1].Value = F_PROGRAM_CODE;
			parameters[2].Value = F_SENDPAR_NAME;


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
                Log.Error("DalTEST_SENDP_VALUE->Delete---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_TASK_ID,string F_PROGRAM_CODE,string F_SENDPAR_NAME)
		{
			
			try
            {
                Log.Info("DalTEST_SENDP_VALUE->Disabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_SENDP_VALUE  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_TASK_ID=:F_TASK_ID and F_PROGRAM_CODE=:F_PROGRAM_CODE and F_SENDPAR_NAME=:F_SENDPAR_NAME ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TASK_ID", OracleType.VarChar,50),
					new OracleParameter(":F_PROGRAM_CODE", OracleType.VarChar,10),
					new OracleParameter(":F_SENDPAR_NAME", OracleType.VarChar,100)			};
			parameters[0].Value = F_TASK_ID;
			parameters[1].Value = F_PROGRAM_CODE;
			parameters[2].Value = F_SENDPAR_NAME;


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
                Log.Error("DalTEST_SENDP_VALUE->Disabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_TASK_ID,string F_PROGRAM_CODE,string F_SENDPAR_NAME)
		{
			
			try
            {
                Log.Info("DalTEST_SENDP_VALUE->Enabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_SENDP_VALUE  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_TASK_ID=:F_TASK_ID and F_PROGRAM_CODE=:F_PROGRAM_CODE and F_SENDPAR_NAME=:F_SENDPAR_NAME ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TASK_ID", OracleType.VarChar,50),
					new OracleParameter(":F_PROGRAM_CODE", OracleType.VarChar,10),
					new OracleParameter(":F_SENDPAR_NAME", OracleType.VarChar,100)			};
			parameters[0].Value = F_TASK_ID;
			parameters[1].Value = F_PROGRAM_CODE;
			parameters[2].Value = F_SENDPAR_NAME;


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
                Log.Error("DalTEST_SENDP_VALUE->Enabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool Drop(string F_TASK_ID,string F_PROGRAM_CODE,string F_SENDPAR_NAME)
		{
			
			try
            {
                Log.Info("DalTEST_SENDP_VALUE->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("DELETE FROM  T_TEST_SENDP_VALUE  ");
			strSql.Append(" where F_TASK_ID=:F_TASK_ID and F_PROGRAM_CODE=:F_PROGRAM_CODE and F_SENDPAR_NAME=:F_SENDPAR_NAME ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TASK_ID", OracleType.VarChar,50),
					new OracleParameter(":F_PROGRAM_CODE", OracleType.VarChar,10),
					new OracleParameter(":F_SENDPAR_NAME", OracleType.VarChar,100)			};
			parameters[0].Value = F_TASK_ID;
			parameters[1].Value = F_PROGRAM_CODE;
			parameters[2].Value = F_SENDPAR_NAME;


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
                Log.Error("DalTEST_SENDP_VALUE->Delete---FAILED", ex);
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
                Log.Info("DalTEST_SENDP_VALUE->DeleteWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_SENDP_VALUE  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalTEST_SENDP_VALUE->DeleteWhere---FAILED", ex);
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
                Log.Info("DalTEST_SENDP_VALUE->DropWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from  T_TEST_SENDP_VALUE  ");
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
                Log.Error("DalTEST_SENDP_VALUE->DropWhere---FAILED", ex);
                throw ex;
            }
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelTEST_SENDP_VALUE GetModel(string F_TASK_ID,string F_PROGRAM_CODE,string F_SENDPAR_NAME)
		{
			try
            {
                Log.Info("DalTEST_SENDP_VALUE->GetModel---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select ");
								//试验任务编号
				strSql.Append("F_TASK_ID,  ");
								//工作模式名称
				strSql.Append("F_WORKTYPE_NAME,  ");
								//工作模式编码
				strSql.Append("F_WORKTYPE_CODE,  ");
								//程序代码
				strSql.Append("F_PROGRAM_CODE,  ");
								//参数名称
				strSql.Append("F_SENDPAR_NAME,  ");
								//参数值
				strSql.Append("F_SENDPAR_VALUE,  ");
								//排序序号
				strSql.Append("F_SENDORDER,  ");
								//备注
				strSql.Append("F_SENDPAR_MEMO,  ");
								//创建时间
				strSql.Append("F_CREATE_TIME,  ");
								//操作员
				strSql.Append("F_OPERATOR_ID,  ");
								//操作时间
				strSql.Append("F_OPERATIONTIME,  ");
								//是否删除
				strSql.Append("F_DEL  ");
								strSql.Append("  from T_TEST_SENDP_VALUE ");
				strSql.Append(" where 1=1 AND  F_TASK_ID=:F_TASK_ID and F_PROGRAM_CODE=:F_PROGRAM_CODE and F_SENDPAR_NAME=:F_SENDPAR_NAME ");
							OracleParameter[] parameters = {
					new OracleParameter(":F_TASK_ID", OracleType.VarChar,50),
					new OracleParameter(":F_PROGRAM_CODE", OracleType.VarChar,10),
					new OracleParameter(":F_SENDPAR_NAME", OracleType.VarChar,100)			};
			parameters[0].Value = F_TASK_ID;
			parameters[1].Value = F_PROGRAM_CODE;
			parameters[2].Value = F_SENDPAR_NAME;

			
				RelayTest.Model.ModelTEST_SENDP_VALUE model=new RelayTest.Model.ModelTEST_SENDP_VALUE();
				DataSet ds=Query(strSql.ToString(),parameters);
			
				if(ds.Tables[0].Rows.Count>0)
				{
																				model.F_TASK_ID= ds.Tables[0].Rows[0]["F_TASK_ID"].ToString();
																																								model.F_WORKTYPE_NAME= ds.Tables[0].Rows[0]["F_WORKTYPE_NAME"].ToString();
																																								model.F_WORKTYPE_CODE= ds.Tables[0].Rows[0]["F_WORKTYPE_CODE"].ToString();
																																								model.F_PROGRAM_CODE= ds.Tables[0].Rows[0]["F_PROGRAM_CODE"].ToString();
																																								model.F_SENDPAR_NAME= ds.Tables[0].Rows[0]["F_SENDPAR_NAME"].ToString();
																																								model.F_SENDPAR_VALUE= ds.Tables[0].Rows[0]["F_SENDPAR_VALUE"].ToString();
																																			if(ds.Tables[0].Rows[0]["F_SENDORDER"].ToString()!="")
					{
						model.F_SENDORDER=decimal.Parse(ds.Tables[0].Rows[0]["F_SENDORDER"].ToString());
					}
																																													model.F_SENDPAR_MEMO= ds.Tables[0].Rows[0]["F_SENDPAR_MEMO"].ToString();
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
                Log.Error("DalTEST_SENDP_VALUE->GetModel---FAILED", ex);
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
                Log.Info("DalTEST_SENDP_VALUE->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select * ");
				strSql.Append(" FROM T_TEST_SENDP_VALUE  where 1=1");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				return Query(strSql.ToString());
	            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_SENDP_VALUE->GetList---FAILED", ex);
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
                Log.Info("DalTEST_SENDP_VALUE->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select ");
				if(Top>0)
				{
					strSql.Append(" top "+Top.ToString());
				}
				strSql.Append(" * ");
				strSql.Append(" FROM T_TEST_SENDP_VALUE  where F_DEL=0 ");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				strSql.Append(" order by " + filedOrder);
				return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_SENDP_VALUE->GetList---FAILED", ex);
                throw ex;
            }
			
		}
		#endregion Method

        #region 自定义函数
        /// <summary>
        /// 根据任务编号批量生成并写入sendp值数据
        /// </summary>
        public void AddDataByTaskId(string temp_taskid)
        {

            try
            {
                Log.Info("DalTEST_SENDP_VALUE->AddDataByTaskId---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into T_TEST_SENDP_VALUE  ");
                strSql.Append("( F_TASK_ID,   ");
                strSql.Append("F_PROGRAM_CODE ,   ");
                strSql.Append(" F_SENDPAR_NAME,   ");
                strSql.Append(" F_SENDPAR_VALUE,   ");
                strSql.Append(" F_SENDORDER,   ");
                strSql.Append(" F_SENDPAR_MEMO,   ");
                strSql.Append(" F_CREATE_TIME,   ");
                strSql.Append(" F_OPERATOR_ID,   ");
                strSql.Append(" F_OPERATIONTIME,   ");
                strSql.Append("F_DEL )   ");
                
                strSql.Append("select  ");
                strSql.Append(" F_TASK_ID,   ");
                strSql.Append("F_PROGRAM_CODE ,   ");
                strSql.Append(" F_SENDPAR_NAME,   ");
                strSql.Append(" F_SENDPAR_VALUE,   ");
                strSql.Append(" F_SENDORDER,   ");
                strSql.Append(" F_SENDPAR_MEMO,   ");
                strSql.Append(" F_CREATE_TIME,   ");
                strSql.Append(" F_OPERATOR_ID,   ");
                strSql.Append(" F_OPERATIONTIME,   ");
                strSql.Append("F_DEL    ");
                strSql.Append(" FROM  T_TEST_PAR_VALUE_SWJ  ");
                strSql.Append(" WHERE F_SENDORDER>0 AND F_TASK_ID=:F_TASK_ID ");

                strSql.Append(" UNION  ");

                strSql.Append(" select  ");
                strSql.Append(" F_TASK_ID,   ");
                strSql.Append("F_PROGRAM_CODE ,   ");
                strSql.Append(" F_SENDPAR_NAME,   ");
                strSql.Append(" F_SENDPAR_VALUE,   ");
                strSql.Append(" F_SENDORDER,   ");
                strSql.Append(" F_SENDPAR_MEMO,   ");
                strSql.Append(" F_CREATE_TIME,   ");
                strSql.Append(" F_OPERATOR_ID,   ");
                strSql.Append(" F_OPERATIONTIME,   ");
                strSql.Append("F_DEL    ");
                strSql.Append(" FROM  T_TEST_PAR_VALUE_KHD  ");
                strSql.Append(" WHERE F_SENDORDER>0 AND F_TASK_ID=:F_TASK_ID");

                OracleParameter[] parameters = {
					new OracleParameter(":F_TASK_ID", OracleType.VarChar,50)		};
                parameters[0].Value = temp_taskid;

                ExecuteSql(strSql.ToString(), parameters);
                
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_SENDP_VALUE->AddDataByTaskId---FAILED", ex);
                throw ex;
            }

        }
        #endregion
	}
}

