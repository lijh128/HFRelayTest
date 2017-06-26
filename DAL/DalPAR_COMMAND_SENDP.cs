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
	 	//试验开始命令程序参数信息
		public partial class DalPAR_COMMAND_SENDP:DbHelperOra
	{
   		     
   		     
   		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalPAR_COMMAND_SENDP));
    
    	#region Method
   		 /// <summary>
		///   是否存在该记录
		/// </summary>
		public bool Exists(string F_WORKTYPE_CODE,string F_PROGRAMM_CODE,decimal F_SENDCOMMAND_PAR_ID)
		{
		 try
            {
                Log.Info("DalPAR_COMMAND_SENDP->Exists---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select count(1) from T_PAR_COMMAND_SENDP");
				strSql.Append(" where 1=1 and ");
				                	                       strSql.Append(" F_WORKTYPE_CODE = :F_WORKTYPE_CODE and  ");
                	           		                 	                       strSql.Append(" F_PROGRAMM_CODE = :F_PROGRAMM_CODE and  ");
                	           		                 	                       strSql.Append(" F_SENDCOMMAND_PAR_ID = :F_SENDCOMMAND_PAR_ID  ");
                	           		 							OracleParameter[] parameters = {
					new OracleParameter(":F_WORKTYPE_CODE", OracleType.VarChar,20),
					new OracleParameter(":F_PROGRAMM_CODE", OracleType.VarChar,10),
					new OracleParameter(":F_SENDCOMMAND_PAR_ID", OracleType.Number,8)			};
			parameters[0].Value = F_WORKTYPE_CODE;
			parameters[1].Value = F_PROGRAMM_CODE;
			parameters[2].Value = F_SENDCOMMAND_PAR_ID;

			    Log.Info("DalPAR_COMMAND_SENDP->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_SENDP->Exists---FAILED", ex);
                throw ex;
            }
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(RelayTest.Model.ModelPAR_COMMAND_SENDP model)
		{
		
		 try
            {
                Log.Info("DalPAR_COMMAND_SENDP->Add---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_PAR_COMMAND_SENDP(");
			
						//工作模式代码
            strSql.Append("  F_WORKTYPE_CODE,");
            			//工作模式名称
            strSql.Append("  F_WORKTYPE_NAME,");
            			//试验程序编码
            strSql.Append("  F_PROGRAMM_CODE,");
            			//命令参数id值
            strSql.Append("  F_SENDCOMMAND_PAR_ID,");
            			//试验参数项名称
            strSql.Append("  F_SENDPAR_NAME,");
            			//排列顺序
            strSql.Append("  F_ORDER,");
            			//备注
            strSql.Append("  F_WORKTYPE_MEMO,");
            			//创建时间
            strSql.Append("  F_CREATE_TIME,");
            			//操作员
            strSql.Append("  F_OPERATOR_ID,");
            			//操作时间
            strSql.Append("  F_OPERATIONTIME,");
            			//是否删除
            strSql.Append("  F_DEL");
            			strSql.Append(") values (");
			            strSql.Append(" :F_WORKTYPE_CODE,");            
                         strSql.Append(" :F_WORKTYPE_NAME,");            
                         strSql.Append(" :F_PROGRAMM_CODE,");            
                         strSql.Append(" :F_SENDCOMMAND_PAR_ID,");            
                         strSql.Append(" :F_SENDPAR_NAME,");            
                         strSql.Append(" :F_ORDER,");            
                         strSql.Append(" :F_WORKTYPE_MEMO,");            
                         strSql.Append(" :F_CREATE_TIME,");            
                         strSql.Append(" :F_OPERATOR_ID,");            
                         strSql.Append(" :F_OPERATIONTIME,");            
                         strSql.Append(" :F_DEL");            
                         strSql.Append(") ");            
            		
			OracleParameter[] parameters = {
			            new OracleParameter(":F_WORKTYPE_CODE", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_WORKTYPE_NAME", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_PROGRAMM_CODE", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_SENDCOMMAND_PAR_ID", OracleType.Number,8) ,            
                        new OracleParameter(":F_SENDPAR_NAME", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_ORDER", OracleType.Number,4) ,            
                        new OracleParameter(":F_WORKTYPE_MEMO", OracleType.VarChar,500) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
			    
			//工作模式代码
			if (model.F_WORKTYPE_CODE==null)
			{
            	parameters[0].Value = DBNull.Value;
            }
            else
            {
                parameters[0].Value = model.F_WORKTYPE_CODE;            }
                
			//工作模式名称
			if (model.F_WORKTYPE_NAME==null)
			{
            	parameters[1].Value = DBNull.Value;
            }
            else
            {
                parameters[1].Value = model.F_WORKTYPE_NAME;            }
                
			//试验程序编码
			if (model.F_PROGRAMM_CODE==null)
			{
            	parameters[2].Value = DBNull.Value;
            }
            else
            {
                parameters[2].Value = model.F_PROGRAMM_CODE;            }
                
			//命令参数id值
			if (model.F_SENDCOMMAND_PAR_ID==null)
			{
            	parameters[3].Value = DBNull.Value;
            }
            else
            {
                parameters[3].Value = model.F_SENDCOMMAND_PAR_ID;            }
                
			//试验参数项名称
			if (model.F_SENDPAR_NAME==null)
			{
            	parameters[4].Value = DBNull.Value;
            }
            else
            {
                parameters[4].Value = model.F_SENDPAR_NAME;            }
                
			//排列顺序
			if (model.F_ORDER==null)
			{
            	parameters[5].Value = DBNull.Value;
            }
            else
            {
                parameters[5].Value = model.F_ORDER;            }
                
			//备注
			if (model.F_WORKTYPE_MEMO==null)
			{
            	parameters[6].Value = DBNull.Value;
            }
            else
            {
                parameters[6].Value = model.F_WORKTYPE_MEMO;            }
                
			//创建时间
			if (model.F_CREATE_TIME==null)
			{
            	parameters[7].Value = DBNull.Value;
            }
            else
            {
                parameters[7].Value = model.F_CREATE_TIME;            }
                
			//操作员
			if (model.F_OPERATOR_ID==null)
			{
            	parameters[8].Value = DBNull.Value;
            }
            else
            {
                parameters[8].Value = model.F_OPERATOR_ID;            }
                
			//操作时间
			if (model.F_OPERATIONTIME==null)
			{
            	parameters[9].Value = DBNull.Value;
            }
            else
            {
                parameters[9].Value = model.F_OPERATIONTIME;            }
                
			//是否删除
			if (model.F_DEL==null)
			{
            	parameters[10].Value = DBNull.Value;
            }
            else
            {
                parameters[10].Value = model.F_DEL;            }
                        
			            ExecuteSql(strSql.ToString(),parameters);
            			
			}
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_SENDP->Add---FAILED", ex);
                throw ex;
            }
		}
		
	
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(RelayTest.Model.ModelPAR_COMMAND_SENDP model)
		{
		
			try
            {
                Log.Info("DalPAR_COMMAND_SENDP->Update---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_PAR_COMMAND_SENDP set ");
			             
            //工作模式代码
            strSql.Append(" F_WORKTYPE_CODE = :F_WORKTYPE_CODE , ");
                         
            //工作模式名称
            strSql.Append(" F_WORKTYPE_NAME = :F_WORKTYPE_NAME , ");
                         
            //试验程序编码
            strSql.Append(" F_PROGRAMM_CODE = :F_PROGRAMM_CODE , ");
                         
            //命令参数id值
            strSql.Append(" F_SENDCOMMAND_PAR_ID = :F_SENDCOMMAND_PAR_ID , ");
                         
            //试验参数项名称
            strSql.Append(" F_SENDPAR_NAME = :F_SENDPAR_NAME , ");
                         
            //排列顺序
            strSql.Append(" F_ORDER = :F_ORDER , ");
                         
            //备注
            strSql.Append(" F_WORKTYPE_MEMO = :F_WORKTYPE_MEMO , ");
                         
            //操作员
            strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");
                         
            //操作时间
            strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");
                         
            //是否删除
            strSql.Append(" F_DEL = :F_DEL  ");
            			
			strSql.Append(" where F_WORKTYPE_CODE=:F_WORKTYPE_CODE and F_PROGRAMM_CODE=:F_PROGRAMM_CODE and F_SENDCOMMAND_PAR_ID=:F_SENDCOMMAND_PAR_ID  ");
						
OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_WORKTYPE_CODE", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_WORKTYPE_NAME", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_PROGRAMM_CODE", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_SENDCOMMAND_PAR_ID", OracleType.Number,8) ,            
                        	
            new OracleParameter(":F_SENDPAR_NAME", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_ORDER", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_WORKTYPE_MEMO", OracleType.VarChar,500) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
									//工作模式代码
            	if (model.F_WORKTYPE_CODE==null)
				{
	            	parameters[0].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[0].Value = model.F_WORKTYPE_CODE;	            }
            			//工作模式名称
            	if (model.F_WORKTYPE_NAME==null)
				{
	            	parameters[1].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[1].Value = model.F_WORKTYPE_NAME;	            }
            			//试验程序编码
            	if (model.F_PROGRAMM_CODE==null)
				{
	            	parameters[2].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[2].Value = model.F_PROGRAMM_CODE;	            }
            			//命令参数id值
            	if (model.F_SENDCOMMAND_PAR_ID==null)
				{
	            	parameters[3].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[3].Value = model.F_SENDCOMMAND_PAR_ID;	            }
            			//试验参数项名称
            	if (model.F_SENDPAR_NAME==null)
				{
	            	parameters[4].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[4].Value = model.F_SENDPAR_NAME;	            }
            			//排列顺序
            	if (model.F_ORDER==null)
				{
	            	parameters[5].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[5].Value = model.F_ORDER;	            }
            			//备注
            	if (model.F_WORKTYPE_MEMO==null)
				{
	            	parameters[6].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[6].Value = model.F_WORKTYPE_MEMO;	            }
            			//操作员
            	if (model.F_OPERATOR_ID==null)
				{
	            	parameters[7].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[7].Value = model.F_OPERATOR_ID;	            }
            			//操作时间
            	if (model.F_OPERATIONTIME==null)
				{
	            	parameters[8].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[8].Value = model.F_OPERATIONTIME;	            }
            			//是否删除
            	if (model.F_DEL==null)
				{
	            	parameters[9].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[9].Value = model.F_DEL;	            }
                        
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
                Log.Error("DalPAR_COMMAND_SENDP->Update---FAILED", ex);
                throw ex;
            }
		
		
		
			
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_WORKTYPE_CODE,string F_PROGRAMM_CODE,decimal F_SENDCOMMAND_PAR_ID)
		{
			
			try
            {
                Log.Info("DalPAR_COMMAND_SENDP->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_PAR_COMMAND_SENDP  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_WORKTYPE_CODE=:F_WORKTYPE_CODE and F_PROGRAMM_CODE=:F_PROGRAMM_CODE and F_SENDCOMMAND_PAR_ID=:F_SENDCOMMAND_PAR_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_WORKTYPE_CODE", OracleType.VarChar,20),
					new OracleParameter(":F_PROGRAMM_CODE", OracleType.VarChar,10),
					new OracleParameter(":F_SENDCOMMAND_PAR_ID", OracleType.Number,8)			};
			parameters[0].Value = F_WORKTYPE_CODE;
			parameters[1].Value = F_PROGRAMM_CODE;
			parameters[2].Value = F_SENDCOMMAND_PAR_ID;


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
                Log.Error("DalPAR_COMMAND_SENDP->Delete---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_WORKTYPE_CODE,string F_PROGRAMM_CODE,decimal F_SENDCOMMAND_PAR_ID)
		{
			
			try
            {
                Log.Info("DalPAR_COMMAND_SENDP->Disabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_PAR_COMMAND_SENDP  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_WORKTYPE_CODE=:F_WORKTYPE_CODE and F_PROGRAMM_CODE=:F_PROGRAMM_CODE and F_SENDCOMMAND_PAR_ID=:F_SENDCOMMAND_PAR_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_WORKTYPE_CODE", OracleType.VarChar,20),
					new OracleParameter(":F_PROGRAMM_CODE", OracleType.VarChar,10),
					new OracleParameter(":F_SENDCOMMAND_PAR_ID", OracleType.Number,8)			};
			parameters[0].Value = F_WORKTYPE_CODE;
			parameters[1].Value = F_PROGRAMM_CODE;
			parameters[2].Value = F_SENDCOMMAND_PAR_ID;


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
                Log.Error("DalPAR_COMMAND_SENDP->Disabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_WORKTYPE_CODE,string F_PROGRAMM_CODE,decimal F_SENDCOMMAND_PAR_ID)
		{
			
			try
            {
                Log.Info("DalPAR_COMMAND_SENDP->Enabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_PAR_COMMAND_SENDP  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_WORKTYPE_CODE=:F_WORKTYPE_CODE and F_PROGRAMM_CODE=:F_PROGRAMM_CODE and F_SENDCOMMAND_PAR_ID=:F_SENDCOMMAND_PAR_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_WORKTYPE_CODE", OracleType.VarChar,20),
					new OracleParameter(":F_PROGRAMM_CODE", OracleType.VarChar,10),
					new OracleParameter(":F_SENDCOMMAND_PAR_ID", OracleType.Number,8)			};
			parameters[0].Value = F_WORKTYPE_CODE;
			parameters[1].Value = F_PROGRAMM_CODE;
			parameters[2].Value = F_SENDCOMMAND_PAR_ID;


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
                Log.Error("DalPAR_COMMAND_SENDP->Enabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool Drop(string F_WORKTYPE_CODE,string F_PROGRAMM_CODE,decimal F_SENDCOMMAND_PAR_ID)
		{
			
			try
            {
                Log.Info("DalPAR_COMMAND_SENDP->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("DELETE FROM  T_PAR_COMMAND_SENDP  ");
			strSql.Append(" where F_WORKTYPE_CODE=:F_WORKTYPE_CODE and F_PROGRAMM_CODE=:F_PROGRAMM_CODE and F_SENDCOMMAND_PAR_ID=:F_SENDCOMMAND_PAR_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_WORKTYPE_CODE", OracleType.VarChar,20),
					new OracleParameter(":F_PROGRAMM_CODE", OracleType.VarChar,10),
					new OracleParameter(":F_SENDCOMMAND_PAR_ID", OracleType.Number,8)			};
			parameters[0].Value = F_WORKTYPE_CODE;
			parameters[1].Value = F_PROGRAMM_CODE;
			parameters[2].Value = F_SENDCOMMAND_PAR_ID;


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
                Log.Error("DalPAR_COMMAND_SENDP->Delete---FAILED", ex);
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
                Log.Info("DalPAR_COMMAND_SENDP->DeleteWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_PAR_COMMAND_SENDP  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalPAR_COMMAND_SENDP->DeleteWhere---FAILED", ex);
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
                Log.Info("DalPAR_COMMAND_SENDP->DropWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from  T_PAR_COMMAND_SENDP  ");
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
                Log.Error("DalPAR_COMMAND_SENDP->DropWhere---FAILED", ex);
                throw ex;
            }
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelPAR_COMMAND_SENDP GetModel(string F_WORKTYPE_CODE,string F_PROGRAMM_CODE,decimal F_SENDCOMMAND_PAR_ID)
		{
			try
            {
                Log.Info("DalPAR_COMMAND_SENDP->GetModel---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select ");
								//工作模式代码
				strSql.Append("F_WORKTYPE_CODE,  ");
								//工作模式名称
				strSql.Append("F_WORKTYPE_NAME,  ");
								//试验程序编码
				strSql.Append("F_PROGRAMM_CODE,  ");
								//命令参数id值
				strSql.Append("F_SENDCOMMAND_PAR_ID,  ");
								//试验参数项名称
				strSql.Append("F_SENDPAR_NAME,  ");
								//排列顺序
				strSql.Append("F_ORDER,  ");
								//备注
				strSql.Append("F_WORKTYPE_MEMO,  ");
								//创建时间
				strSql.Append("F_CREATE_TIME,  ");
								//操作员
				strSql.Append("F_OPERATOR_ID,  ");
								//操作时间
				strSql.Append("F_OPERATIONTIME,  ");
								//是否删除
				strSql.Append("F_DEL  ");
								strSql.Append("  from T_PAR_COMMAND_SENDP ");
				strSql.Append(" where 1=1 AND  F_WORKTYPE_CODE=:F_WORKTYPE_CODE and F_PROGRAMM_CODE=:F_PROGRAMM_CODE and F_SENDCOMMAND_PAR_ID=:F_SENDCOMMAND_PAR_ID ");
							OracleParameter[] parameters = {
					new OracleParameter(":F_WORKTYPE_CODE", OracleType.VarChar,20),
					new OracleParameter(":F_PROGRAMM_CODE", OracleType.VarChar,10),
					new OracleParameter(":F_SENDCOMMAND_PAR_ID", OracleType.Number,8)			};
			parameters[0].Value = F_WORKTYPE_CODE;
			parameters[1].Value = F_PROGRAMM_CODE;
			parameters[2].Value = F_SENDCOMMAND_PAR_ID;

			
				RelayTest.Model.ModelPAR_COMMAND_SENDP model=new RelayTest.Model.ModelPAR_COMMAND_SENDP();
				DataSet ds=Query(strSql.ToString(),parameters);
			
				if(ds.Tables[0].Rows.Count>0)
				{
																				model.F_WORKTYPE_CODE= ds.Tables[0].Rows[0]["F_WORKTYPE_CODE"].ToString();
																																								model.F_WORKTYPE_NAME= ds.Tables[0].Rows[0]["F_WORKTYPE_NAME"].ToString();
																																								model.F_PROGRAMM_CODE= ds.Tables[0].Rows[0]["F_PROGRAMM_CODE"].ToString();
																																			if(ds.Tables[0].Rows[0]["F_SENDCOMMAND_PAR_ID"].ToString()!="")
					{
						model.F_SENDCOMMAND_PAR_ID=decimal.Parse(ds.Tables[0].Rows[0]["F_SENDCOMMAND_PAR_ID"].ToString());
					}
																																													model.F_SENDPAR_NAME= ds.Tables[0].Rows[0]["F_SENDPAR_NAME"].ToString();
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
                Log.Error("DalPAR_COMMAND_SENDP->GetModel---FAILED", ex);
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
                Log.Info("DalPAR_COMMAND_SENDP->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select * ");
				strSql.Append(" FROM T_PAR_COMMAND_SENDP  where 1=1");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
                strSql.Append(" ORDER BY F_ORDER ");
				return Query(strSql.ToString());
	            }
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_SENDP->GetList---FAILED", ex);
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
                Log.Info("DalPAR_COMMAND_SENDP->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select ");
				if(Top>0)
				{
					strSql.Append(" top "+Top.ToString());
				}
				strSql.Append(" * ");
				strSql.Append(" FROM T_PAR_COMMAND_SENDP  where F_DEL=0 ");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				strSql.Append(" order by " + filedOrder);
				return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_SENDP->GetList---FAILED", ex);
                throw ex;
            }
			
		}
		#endregion Method

        #region 自定义函数
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListStartPar(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();


            strSql.Append(" SELECT  ");
            strSql.Append(" decode((SELECT F_SENDPAR_NAME FROM  T_PAR_COMMAND_SENDP WHERE  F_SENDPAR_NAME=a.F_SENDPAR_NAME ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
            }
            strSql.Append("), null ,'0','1')  ");
            strSql.Append(" as  parSelect ,  ");
            strSql.Append(" F_SENDPAR_NAME,   ");
            strSql.Append(" F_SENDPAR_ORDER,  ");
            strSql.Append(" F_SENDCOMMAND_PAR_ID  ");

            strSql.Append(" FROM T_PAR_COMMAND_SEND a ");
            strSql.Append(" WHERE a.F_SENDPAR_ORDER>0  ");
            strSql.Append(" order by a.F_SENDPAR_ORDER ");

            return Query(strSql.ToString());
        }

        /// <summary>
        /// 根据工作模式名称、程序代码，删除数据
        /// F_WORKTYPE_NAME：工作模式名称
        /// F_PROGRAMM_CODE: 程序代码
        /// </summary>
        public bool Delete_by_WorkType(string F_WORKTYPE_NAME, string F_PROGRAMM_CODE)
        {

            try
            {
                Log.Info("DalPAR_COMMAND_SENDP->Delete_by_WorkType---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("delete  T_PAR_COMMAND_SENDP  ");
                strSql.Append(" where F_WORKTYPE_NAME=:F_WORKTYPE_NAME and F_PROGRAMM_CODE=:F_PROGRAMM_CODE  ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_WORKTYPE_NAME", OracleType.VarChar,20),
					new OracleParameter(":F_PROGRAMM_CODE", OracleType.VarChar,10)			};
                parameters[0].Value = F_WORKTYPE_NAME;
                parameters[1].Value = F_PROGRAMM_CODE;


                int rows = ExecuteSql(strSql.ToString(), parameters);
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
                Log.Error("DalPAR_COMMAND_SENDP->Delete_by_WorkType---FAILED", ex);
                throw ex;
            }

        }
        #endregion
   
	}
}

