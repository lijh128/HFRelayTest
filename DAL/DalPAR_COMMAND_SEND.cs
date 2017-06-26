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
	 	//发送命令参数元数据表
		public partial class DalPAR_COMMAND_SEND:DbHelperOra
	{
   		     
   		     
   		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalPAR_COMMAND_SEND));
    
    	#region Method
   		 /// <summary>
		///   是否存在该记录
		/// </summary>
		public bool Exists(decimal F_SENDCOMMAND_PAR_ID)
		{
		 try
            {
                Log.Info("DalPAR_COMMAND_SEND->Exists---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select count(1) from T_PAR_COMMAND_SEND");
				strSql.Append(" where 1=1 and ");
				                	                       strSql.Append(" F_SENDCOMMAND_PAR_ID = :F_SENDCOMMAND_PAR_ID  ");
                	           		 							OracleParameter[] parameters = {
					new OracleParameter(":F_SENDCOMMAND_PAR_ID", OracleType.Number,8)			};
			parameters[0].Value = F_SENDCOMMAND_PAR_ID;

			    Log.Info("DalPAR_COMMAND_SEND->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_SEND->Exists---FAILED", ex);
                throw ex;
            }
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(RelayTest.Model.ModelPAR_COMMAND_SEND model)
		{
		
		 try
            {
                Log.Info("DalPAR_COMMAND_SEND->Add---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_PAR_COMMAND_SEND(");			
            strSql.Append("F_SENDCOMMAND_PAR_ID,F_SENDPAR_NAME,F_SENDPAR_ORDER,F_SENDPAR_DATA_TYPE,F_SENDPAR_DATA_LENGTH,F_SENDPAR_DEFAULT_VALUE,F_SENDPAR_UNIT,F_SENDPAR_SET,F_SENDPAR_DISPLAY,F_SENDPAR_MEMO,F_CREATE_TIME,F_OPERATOR_ID,F_OPERATIONTIME,F_DEL");
			strSql.Append(") values (");
            strSql.Append(":F_SENDCOMMAND_PAR_ID,:F_SENDPAR_NAME,:F_SENDPAR_ORDER,:F_SENDPAR_DATA_TYPE,:F_SENDPAR_DATA_LENGTH,:F_SENDPAR_DEFAULT_VALUE,:F_SENDPAR_UNIT,:F_SENDPAR_SET,:F_SENDPAR_DISPLAY,:F_SENDPAR_MEMO,:F_CREATE_TIME,:F_OPERATOR_ID,:F_OPERATIONTIME,:F_DEL");            
            strSql.Append(") ");            
            		
			OracleParameter[] parameters = {
			            new OracleParameter(":F_SENDCOMMAND_PAR_ID", OracleType.Number,8) ,            
                        new OracleParameter(":F_SENDPAR_NAME", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_SENDPAR_ORDER", OracleType.Number,4) ,            
                        new OracleParameter(":F_SENDPAR_DATA_TYPE", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_SENDPAR_DATA_LENGTH", OracleType.Number,4) ,            
                        new OracleParameter(":F_SENDPAR_DEFAULT_VALUE", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_SENDPAR_UNIT", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_SENDPAR_SET", OracleType.Number,4) ,            
                        new OracleParameter(":F_SENDPAR_DISPLAY", OracleType.Number,4) ,            
                        new OracleParameter(":F_SENDPAR_MEMO", OracleType.VarChar,500) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
			    
			if (model.F_SENDCOMMAND_PAR_ID==null)
			{
            	parameters[0].Value = DBNull.Value;
            }
            else
            {
                parameters[0].Value = model.F_SENDCOMMAND_PAR_ID;            }
                
			if (model.F_SENDPAR_NAME==null)
			{
            	parameters[1].Value = DBNull.Value;
            }
            else
            {
                parameters[1].Value = model.F_SENDPAR_NAME;            }
                
			if (model.F_SENDPAR_ORDER==null)
			{
            	parameters[2].Value = DBNull.Value;
            }
            else
            {
                parameters[2].Value = model.F_SENDPAR_ORDER;            }
                
			if (model.F_SENDPAR_DATA_TYPE==null)
			{
            	parameters[3].Value = DBNull.Value;
            }
            else
            {
                parameters[3].Value = model.F_SENDPAR_DATA_TYPE;            }
                
			if (model.F_SENDPAR_DATA_LENGTH==null)
			{
            	parameters[4].Value = DBNull.Value;
            }
            else
            {
                parameters[4].Value = model.F_SENDPAR_DATA_LENGTH;            }
                
			if (model.F_SENDPAR_DEFAULT_VALUE==null)
			{
            	parameters[5].Value = DBNull.Value;
            }
            else
            {
                parameters[5].Value = model.F_SENDPAR_DEFAULT_VALUE;            }
                
			if (model.F_SENDPAR_UNIT==null)
			{
            	parameters[6].Value = DBNull.Value;
            }
            else
            {
                parameters[6].Value = model.F_SENDPAR_UNIT;            }
                
			if (model.F_SENDPAR_SET==null)
			{
            	parameters[7].Value = DBNull.Value;
            }
            else
            {
                parameters[7].Value = model.F_SENDPAR_SET;            }
                
			if (model.F_SENDPAR_DISPLAY==null)
			{
            	parameters[8].Value = DBNull.Value;
            }
            else
            {
                parameters[8].Value = model.F_SENDPAR_DISPLAY;            }
                
			if (model.F_SENDPAR_MEMO==null)
			{
            	parameters[9].Value = DBNull.Value;
            }
            else
            {
                parameters[9].Value = model.F_SENDPAR_MEMO;            }
                
			if (model.F_CREATE_TIME==null)
			{
            	parameters[10].Value = DBNull.Value;
            }
            else
            {
                parameters[10].Value = model.F_CREATE_TIME;            }
                
			if (model.F_OPERATOR_ID==null)
			{
            	parameters[11].Value = DBNull.Value;
            }
            else
            {
                parameters[11].Value = model.F_OPERATOR_ID;            }
                
			if (model.F_OPERATIONTIME==null)
			{
            	parameters[12].Value = DBNull.Value;
            }
            else
            {
                parameters[12].Value = model.F_OPERATIONTIME;            }
                
			if (model.F_DEL==null)
			{
            	parameters[13].Value = DBNull.Value;
            }
            else
            {
                parameters[13].Value = model.F_DEL;            }
                        
			            ExecuteSql(strSql.ToString(),parameters);
            			
			}
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_SEND->Add---FAILED", ex);
                throw ex;
            }
		}
		
	
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(RelayTest.Model.ModelPAR_COMMAND_SEND model)
		{
		
			try
            {
                Log.Info("DalPAR_COMMAND_SEND->Update---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_PAR_COMMAND_SEND set ");
			                        
            strSql.Append(" F_SENDCOMMAND_PAR_ID = :F_SENDCOMMAND_PAR_ID , ");                                    
            strSql.Append(" F_SENDPAR_NAME = :F_SENDPAR_NAME , ");                                    
            strSql.Append(" F_SENDPAR_ORDER = :F_SENDPAR_ORDER , ");                                    
            strSql.Append(" F_SENDPAR_DATA_TYPE = :F_SENDPAR_DATA_TYPE , ");                                    
            strSql.Append(" F_SENDPAR_DATA_LENGTH = :F_SENDPAR_DATA_LENGTH , ");                                    
            strSql.Append(" F_SENDPAR_DEFAULT_VALUE = :F_SENDPAR_DEFAULT_VALUE , ");                                    
            strSql.Append(" F_SENDPAR_UNIT = :F_SENDPAR_UNIT , ");                                    
            strSql.Append(" F_SENDPAR_SET = :F_SENDPAR_SET , ");                                    
            strSql.Append(" F_SENDPAR_DISPLAY = :F_SENDPAR_DISPLAY , ");                                    
            strSql.Append(" F_SENDPAR_MEMO = :F_SENDPAR_MEMO , ");                                    
            strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");                                    
            strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");                                    
            strSql.Append(" F_DEL = :F_DEL  ");            			
			strSql.Append(" where F_SENDCOMMAND_PAR_ID=:F_SENDCOMMAND_PAR_ID  ");
						
OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_SENDCOMMAND_PAR_ID", OracleType.Number,8) ,            
                        	
            new OracleParameter(":F_SENDPAR_NAME", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_SENDPAR_ORDER", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_SENDPAR_DATA_TYPE", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_SENDPAR_DATA_LENGTH", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_SENDPAR_DEFAULT_VALUE", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_SENDPAR_UNIT", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_SENDPAR_SET", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_SENDPAR_DISPLAY", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_SENDPAR_MEMO", OracleType.VarChar,500) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
						            	if (model.F_SENDCOMMAND_PAR_ID==null)
				{
	            	parameters[0].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[0].Value = model.F_SENDCOMMAND_PAR_ID;	            }
                        	if (model.F_SENDPAR_NAME==null)
				{
	            	parameters[1].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[1].Value = model.F_SENDPAR_NAME;	            }
                        	if (model.F_SENDPAR_ORDER==null)
				{
	            	parameters[2].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[2].Value = model.F_SENDPAR_ORDER;	            }
                        	if (model.F_SENDPAR_DATA_TYPE==null)
				{
	            	parameters[3].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[3].Value = model.F_SENDPAR_DATA_TYPE;	            }
                        	if (model.F_SENDPAR_DATA_LENGTH==null)
				{
	            	parameters[4].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[4].Value = model.F_SENDPAR_DATA_LENGTH;	            }
                        	if (model.F_SENDPAR_DEFAULT_VALUE==null)
				{
	            	parameters[5].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[5].Value = model.F_SENDPAR_DEFAULT_VALUE;	            }
                        	if (model.F_SENDPAR_UNIT==null)
				{
	            	parameters[6].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[6].Value = model.F_SENDPAR_UNIT;	            }
                        	if (model.F_SENDPAR_SET==null)
				{
	            	parameters[7].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[7].Value = model.F_SENDPAR_SET;	            }
                        	if (model.F_SENDPAR_DISPLAY==null)
				{
	            	parameters[8].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[8].Value = model.F_SENDPAR_DISPLAY;	            }
                        	if (model.F_SENDPAR_MEMO==null)
				{
	            	parameters[9].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[9].Value = model.F_SENDPAR_MEMO;	            }
                        	if (model.F_OPERATOR_ID==null)
				{
	            	parameters[10].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[10].Value = model.F_OPERATOR_ID;	            }
                        	if (model.F_OPERATIONTIME==null)
				{
	            	parameters[11].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[11].Value = model.F_OPERATIONTIME;	            }
                        	if (model.F_DEL==null)
				{
	            	parameters[12].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[12].Value = model.F_DEL;	            }
                        
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
                Log.Error("DalPAR_COMMAND_SEND->Update---FAILED", ex);
                throw ex;
            }
		
		
		
			
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(decimal F_SENDCOMMAND_PAR_ID)
		{
			
			try
            {
                Log.Info("DalPAR_COMMAND_SEND->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_PAR_COMMAND_SEND  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_SENDCOMMAND_PAR_ID=:F_SENDCOMMAND_PAR_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_SENDCOMMAND_PAR_ID", OracleType.Number,8)			};
			parameters[0].Value = F_SENDCOMMAND_PAR_ID;


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
                Log.Error("DalPAR_COMMAND_SEND->Delete---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(decimal F_SENDCOMMAND_PAR_ID)
		{
			
			try
            {
                Log.Info("DalPAR_COMMAND_SEND->Disabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_PAR_COMMAND_SEND  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_SENDCOMMAND_PAR_ID=:F_SENDCOMMAND_PAR_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_SENDCOMMAND_PAR_ID", OracleType.Number,8)			};
			parameters[0].Value = F_SENDCOMMAND_PAR_ID;


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
                Log.Error("DalPAR_COMMAND_SEND->Disabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(decimal F_SENDCOMMAND_PAR_ID)
		{
			
			try
            {
                Log.Info("DalPAR_COMMAND_SEND->Enabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_PAR_COMMAND_SEND  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_SENDCOMMAND_PAR_ID=:F_SENDCOMMAND_PAR_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_SENDCOMMAND_PAR_ID", OracleType.Number,8)			};
			parameters[0].Value = F_SENDCOMMAND_PAR_ID;


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
                Log.Error("DalPAR_COMMAND_SEND->Enabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool Drop(decimal F_SENDCOMMAND_PAR_ID)
		{
			
			try
            {
                Log.Info("DalPAR_COMMAND_SEND->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("DELETE FROM  T_PAR_COMMAND_SEND  ");
			strSql.Append(" where F_SENDCOMMAND_PAR_ID=:F_SENDCOMMAND_PAR_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_SENDCOMMAND_PAR_ID", OracleType.Number,8)			};
			parameters[0].Value = F_SENDCOMMAND_PAR_ID;


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
                Log.Error("DalPAR_COMMAND_SEND->Delete---FAILED", ex);
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
                Log.Info("DalPAR_COMMAND_SEND->DeleteWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_PAR_COMMAND_SEND  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalPAR_COMMAND_SEND->DeleteWhere---FAILED", ex);
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
                Log.Info("DalPAR_COMMAND_SEND->DropWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from  T_PAR_COMMAND_SEND  ");
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
                Log.Error("DalPAR_COMMAND_SEND->DropWhere---FAILED", ex);
                throw ex;
            }
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelPAR_COMMAND_SEND GetModel(decimal F_SENDCOMMAND_PAR_ID)
		{
			try
            {
                Log.Info("DalPAR_COMMAND_SEND->GetModel---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select F_SENDCOMMAND_PAR_ID, F_SENDPAR_NAME, F_SENDPAR_ORDER, F_SENDPAR_DATA_TYPE, F_SENDPAR_DATA_LENGTH, F_SENDPAR_DEFAULT_VALUE, F_SENDPAR_UNIT, F_SENDPAR_SET, F_SENDPAR_DISPLAY, F_SENDPAR_MEMO, F_CREATE_TIME, F_OPERATOR_ID, F_OPERATIONTIME, F_DEL  ");			
				strSql.Append("  from T_PAR_COMMAND_SEND ");
				strSql.Append(" where 1=1 AND  F_SENDCOMMAND_PAR_ID=:F_SENDCOMMAND_PAR_ID ");
							OracleParameter[] parameters = {
					new OracleParameter(":F_SENDCOMMAND_PAR_ID", OracleType.Number,8)			};
			parameters[0].Value = F_SENDCOMMAND_PAR_ID;

			
				RelayTest.Model.ModelPAR_COMMAND_SEND model=new RelayTest.Model.ModelPAR_COMMAND_SEND();
				DataSet ds=Query(strSql.ToString(),parameters);
			
				if(ds.Tables[0].Rows.Count>0)
				{
															if(ds.Tables[0].Rows[0]["F_SENDCOMMAND_PAR_ID"].ToString()!="")
					{
						model.F_SENDCOMMAND_PAR_ID=decimal.Parse(ds.Tables[0].Rows[0]["F_SENDCOMMAND_PAR_ID"].ToString());
					}
																																													model.F_SENDPAR_NAME= ds.Tables[0].Rows[0]["F_SENDPAR_NAME"].ToString();
																																			if(ds.Tables[0].Rows[0]["F_SENDPAR_ORDER"].ToString()!="")
					{
						model.F_SENDPAR_ORDER=decimal.Parse(ds.Tables[0].Rows[0]["F_SENDPAR_ORDER"].ToString());
					}
																																													model.F_SENDPAR_DATA_TYPE= ds.Tables[0].Rows[0]["F_SENDPAR_DATA_TYPE"].ToString();
																																			if(ds.Tables[0].Rows[0]["F_SENDPAR_DATA_LENGTH"].ToString()!="")
					{
						model.F_SENDPAR_DATA_LENGTH=decimal.Parse(ds.Tables[0].Rows[0]["F_SENDPAR_DATA_LENGTH"].ToString());
					}
																																													model.F_SENDPAR_DEFAULT_VALUE= ds.Tables[0].Rows[0]["F_SENDPAR_DEFAULT_VALUE"].ToString();
																																								model.F_SENDPAR_UNIT= ds.Tables[0].Rows[0]["F_SENDPAR_UNIT"].ToString();
																																			if(ds.Tables[0].Rows[0]["F_SENDPAR_SET"].ToString()!="")
					{
						model.F_SENDPAR_SET=decimal.Parse(ds.Tables[0].Rows[0]["F_SENDPAR_SET"].ToString());
					}
																																								if(ds.Tables[0].Rows[0]["F_SENDPAR_DISPLAY"].ToString()!="")
					{
						model.F_SENDPAR_DISPLAY=decimal.Parse(ds.Tables[0].Rows[0]["F_SENDPAR_DISPLAY"].ToString());
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
                Log.Error("DalPAR_COMMAND_SEND->GetModel---FAILED", ex);
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
                Log.Info("DalPAR_COMMAND_SEND->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select * ");
				strSql.Append(" FROM T_PAR_COMMAND_SEND  where 1=1");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
                strSql.Append(" order by F_SENDCOMMAND_PAR_ID ");
				return Query(strSql.ToString());
	            }
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_SEND->GetList---FAILED", ex);
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
                Log.Info("DalPAR_COMMAND_SEND->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select ");
				if(Top>0)
				{
					strSql.Append(" top "+Top.ToString());
				}
				strSql.Append(" * ");
				strSql.Append(" FROM T_PAR_COMMAND_SEND  where F_DEL=0 ");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				strSql.Append(" order by " + filedOrder);
				return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_SEND->GetList---FAILED", ex);
                throw ex;
            }
			
		}
		#endregion Method

        #region 自定义函数
        /// <summary>
        /// 获得指定参数id的记录数量
        /// tempParId   参数id
        /// 返回值：0--没有改参数id的记录；1--存在该参数id的记录
        /// </summary>
        public DataSet GetParCount(string tempParId)
        {
            try
            {
                Log.Info("DalPAR_COMMAND_SEND->GetParCount---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select count(*) ");
                strSql.Append(" FROM T_PAR_COMMAND_SEND  where F_DEL=0");
                if (tempParId.Trim() != "")
                {
                    strSql.Append(" and F_SENDCOMMAND_PAR_ID='" + tempParId + "'");
                }
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_SEND->GetParCount---FAILED", ex);
                throw ex;
            }
        }
        #endregion
        #region 自定义函数
        /// <summary>
        /// 获得界面显示数据列表
        /// </summary>
        public DataSet GetList_forDis(string strWhere)
        {
            try
            {
                Log.Info("DalPAR_COMMAND_SEND->GetList_forDis---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select  F_SENDCOMMAND_PAR_ID,F_SENDPAR_NAME, ");
                strSql.Append(" F_SENDPAR_ORDER,F_SENDPAR_DATA_TYPE,");
                strSql.Append("F_SENDPAR_DATA_LENGTH,F_SENDPAR_DEFAULT_VALUE,");
                strSql.Append("F_SENDPAR_UNIT,");
                strSql.Append("(CASE F_SENDPAR_SET WHEN 1 THEN '数据管理客户端' ELSE '上位机' END ) AS F_SENDPAR_SET,");
                strSql.Append("(CASE F_SENDPAR_DISPLAY WHEN 1 THEN '显示' ELSE '不显示' END) AS F_SENDPAR_DISPLAY,");
                strSql.Append("F_SENDPAR_MEMO");
                strSql.Append(" FROM T_PAR_COMMAND_SEND  where 1=1");

                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                strSql.Append(" order by F_SENDCOMMAND_PAR_ID ");
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_SEND->GetList_forDis---FAILED", ex);
                throw ex;
            }

        }
        /// <summary>
        /// 获得命令参数列表，用户在任务信息中设置参数
        /// strWhere 为在数据管理客户端设置的参数
        /// </summary>
        public DataSet GetCommParForSet(string strWhere)
        {
            try
            {
                Log.Info("DalPAR_COMMAND_SEND->GetCommParForSet---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM T_PAR_COMMAND_SEND  where 1=1");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                strSql.Append(" order by length(f_sendcommand_par_id),f_sendcommand_par_id,F_SENDPAR_ORDER ");
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_SEND->GetCommParForSet---FAILED", ex);
                throw ex;
            }

        }
        #endregion

    }
}

