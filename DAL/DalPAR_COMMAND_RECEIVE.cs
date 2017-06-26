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
	 	//接收命令参数元数据表
		public partial class DalPAR_COMMAND_RECEIVE:DbHelperOra
	{
   		     
   		     
   		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalPAR_COMMAND_RECEIVE));
    
    	#region Method
   		 /// <summary>
		///   是否存在该记录
		/// </summary>
		public bool Exists(decimal F_RECEIVECOMMAND_PAR_ID)
		{
		 try
            {
                Log.Info("DalPAR_COMMAND_RECEIVE->Exists---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select count(1) from T_PAR_COMMAND_RECEIVE");
				strSql.Append(" where 1=1 and ");
				                	                       strSql.Append(" F_RECEIVECOMMAND_PAR_ID = :F_RECEIVECOMMAND_PAR_ID  ");
                	           		 							OracleParameter[] parameters = {
					new OracleParameter(":F_RECEIVECOMMAND_PAR_ID", OracleType.Number,8)			};
			parameters[0].Value = F_RECEIVECOMMAND_PAR_ID;

			    Log.Info("DalPAR_COMMAND_RECEIVE->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_RECEIVE->Exists---FAILED", ex);
                throw ex;
            }
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(RelayTest.Model.ModelPAR_COMMAND_RECEIVE model)
		{
		
		 try
            {
                Log.Info("DalPAR_COMMAND_RECEIVE->Add---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_PAR_COMMAND_RECEIVE(");			
            strSql.Append("F_RECEIVECOMMAND_PAR_ID,F_RECEIVEPAR_NAME,F_RECEIVEPAR_ORDER,F_RECEIVEPAR_DATA_TYPE,F_RECEIVEPAR_DATA_LENGTH,F_RECEIVEPAR_DEFAULT_VALUE,F_RECEIVEPAR_UNIT,F_RECEIVEPAR_DISPLAY,F_RECEIVEPAR_MEMO,F_CREATE_TIME,F_OPERATOR_ID,F_OPERATIONTIME,F_DEL");
			strSql.Append(") values (");
            strSql.Append(":F_RECEIVECOMMAND_PAR_ID,:F_RECEIVEPAR_NAME,:F_RECEIVEPAR_ORDER,:F_RECEIVEPAR_DATA_TYPE,:F_RECEIVEPAR_DATA_LENGTH,:F_RECEIVEPAR_DEFAULT_VALUE,:F_RECEIVEPAR_UNIT,:F_RECEIVEPAR_DISPLAY,:F_RECEIVEPAR_MEMO,:F_CREATE_TIME,:F_OPERATOR_ID,:F_OPERATIONTIME,:F_DEL");            
            strSql.Append(") ");            
            		
			OracleParameter[] parameters = {
			            new OracleParameter(":F_RECEIVECOMMAND_PAR_ID", OracleType.Number,8) ,            
                        new OracleParameter(":F_RECEIVEPAR_NAME", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_RECEIVEPAR_ORDER", OracleType.Number,4) ,            
                        new OracleParameter(":F_RECEIVEPAR_DATA_TYPE", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_RECEIVEPAR_DATA_LENGTH", OracleType.Number,4) ,            
                        new OracleParameter(":F_RECEIVEPAR_DEFAULT_VALUE", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_RECEIVEPAR_UNIT", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_RECEIVEPAR_DISPLAY", OracleType.Number,4) ,            
                        new OracleParameter(":F_RECEIVEPAR_MEMO", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
			    
			if (model.F_RECEIVECOMMAND_PAR_ID==null)
			{
            	parameters[0].Value = DBNull.Value;
            }
            else
            {
                parameters[0].Value = model.F_RECEIVECOMMAND_PAR_ID;            }
                
			if (model.F_RECEIVEPAR_NAME==null)
			{
            	parameters[1].Value = DBNull.Value;
            }
            else
            {
                parameters[1].Value = model.F_RECEIVEPAR_NAME;            }
                
			if (model.F_RECEIVEPAR_ORDER==null)
			{
            	parameters[2].Value = DBNull.Value;
            }
            else
            {
                parameters[2].Value = model.F_RECEIVEPAR_ORDER;            }
                
			if (model.F_RECEIVEPAR_DATA_TYPE==null)
			{
            	parameters[3].Value = DBNull.Value;
            }
            else
            {
                parameters[3].Value = model.F_RECEIVEPAR_DATA_TYPE;            }
                
			if (model.F_RECEIVEPAR_DATA_LENGTH==null)
			{
            	parameters[4].Value = DBNull.Value;
            }
            else
            {
                parameters[4].Value = model.F_RECEIVEPAR_DATA_LENGTH;            }
                
			if (model.F_RECEIVEPAR_DEFAULT_VALUE==null)
			{
            	parameters[5].Value = DBNull.Value;
            }
            else
            {
                parameters[5].Value = model.F_RECEIVEPAR_DEFAULT_VALUE;            }
                
			if (model.F_RECEIVEPAR_UNIT==null)
			{
            	parameters[6].Value = DBNull.Value;
            }
            else
            {
                parameters[6].Value = model.F_RECEIVEPAR_UNIT;            }
                
			if (model.F_RECEIVEPAR_DISPLAY==null)
			{
            	parameters[7].Value = DBNull.Value;
            }
            else
            {
                parameters[7].Value = model.F_RECEIVEPAR_DISPLAY;            }
                
			if (model.F_RECEIVEPAR_MEMO==null)
			{
            	parameters[8].Value = DBNull.Value;
            }
            else
            {
                parameters[8].Value = model.F_RECEIVEPAR_MEMO;            }
                
			if (model.F_CREATE_TIME==null)
			{
            	parameters[9].Value = DBNull.Value;
            }
            else
            {
                parameters[9].Value = model.F_CREATE_TIME;            }
                
			if (model.F_OPERATOR_ID==null)
			{
            	parameters[10].Value = DBNull.Value;
            }
            else
            {
                parameters[10].Value = model.F_OPERATOR_ID;            }
                
			if (model.F_OPERATIONTIME==null)
			{
            	parameters[11].Value = DBNull.Value;
            }
            else
            {
                parameters[11].Value = model.F_OPERATIONTIME;            }
                
			if (model.F_DEL==null)
			{
            	parameters[12].Value = DBNull.Value;
            }
            else
            {
                parameters[12].Value = model.F_DEL;            }
                        
			            ExecuteSql(strSql.ToString(),parameters);
            			
			}
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_RECEIVE->Add---FAILED", ex);
                throw ex;
            }
		}
		
	
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(RelayTest.Model.ModelPAR_COMMAND_RECEIVE model)
		{
		
			try
            {
                Log.Info("DalPAR_COMMAND_RECEIVE->Update---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_PAR_COMMAND_RECEIVE set ");
			                        
            strSql.Append(" F_RECEIVECOMMAND_PAR_ID = :F_RECEIVECOMMAND_PAR_ID , ");                                    
            strSql.Append(" F_RECEIVEPAR_NAME = :F_RECEIVEPAR_NAME , ");                                    
            strSql.Append(" F_RECEIVEPAR_ORDER = :F_RECEIVEPAR_ORDER , ");                                    
            strSql.Append(" F_RECEIVEPAR_DATA_TYPE = :F_RECEIVEPAR_DATA_TYPE , ");                                    
            strSql.Append(" F_RECEIVEPAR_DATA_LENGTH = :F_RECEIVEPAR_DATA_LENGTH , ");                                    
            strSql.Append(" F_RECEIVEPAR_DEFAULT_VALUE = :F_RECEIVEPAR_DEFAULT_VALUE , ");                                    
            strSql.Append(" F_RECEIVEPAR_UNIT = :F_RECEIVEPAR_UNIT , ");                                    
            strSql.Append(" F_RECEIVEPAR_DISPLAY = :F_RECEIVEPAR_DISPLAY , ");                                    
            strSql.Append(" F_RECEIVEPAR_MEMO = :F_RECEIVEPAR_MEMO , ");                                    
            strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");                                    
            strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");                                    
            strSql.Append(" F_DEL = :F_DEL  ");            			
			strSql.Append(" where F_RECEIVECOMMAND_PAR_ID=:F_RECEIVECOMMAND_PAR_ID  ");
						
OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_RECEIVECOMMAND_PAR_ID", OracleType.Number,8) ,            
                        	
            new OracleParameter(":F_RECEIVEPAR_NAME", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_RECEIVEPAR_ORDER", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_RECEIVEPAR_DATA_TYPE", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_RECEIVEPAR_DATA_LENGTH", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_RECEIVEPAR_DEFAULT_VALUE", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_RECEIVEPAR_UNIT", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_RECEIVEPAR_DISPLAY", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_RECEIVEPAR_MEMO", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
						            	if (model.F_RECEIVECOMMAND_PAR_ID==null)
				{
	            	parameters[0].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[0].Value = model.F_RECEIVECOMMAND_PAR_ID;	            }
                        	if (model.F_RECEIVEPAR_NAME==null)
				{
	            	parameters[1].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[1].Value = model.F_RECEIVEPAR_NAME;	            }
                        	if (model.F_RECEIVEPAR_ORDER==null)
				{
	            	parameters[2].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[2].Value = model.F_RECEIVEPAR_ORDER;	            }
                        	if (model.F_RECEIVEPAR_DATA_TYPE==null)
				{
	            	parameters[3].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[3].Value = model.F_RECEIVEPAR_DATA_TYPE;	            }
                        	if (model.F_RECEIVEPAR_DATA_LENGTH==null)
				{
	            	parameters[4].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[4].Value = model.F_RECEIVEPAR_DATA_LENGTH;	            }
                        	if (model.F_RECEIVEPAR_DEFAULT_VALUE==null)
				{
	            	parameters[5].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[5].Value = model.F_RECEIVEPAR_DEFAULT_VALUE;	            }
                        	if (model.F_RECEIVEPAR_UNIT==null)
				{
	            	parameters[6].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[6].Value = model.F_RECEIVEPAR_UNIT;	            }
                        	if (model.F_RECEIVEPAR_DISPLAY==null)
				{
	            	parameters[7].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[7].Value = model.F_RECEIVEPAR_DISPLAY;	            }
                        	if (model.F_RECEIVEPAR_MEMO==null)
				{
	            	parameters[8].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[8].Value = model.F_RECEIVEPAR_MEMO;	            }
                        	if (model.F_OPERATOR_ID==null)
				{
	            	parameters[9].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[9].Value = model.F_OPERATOR_ID;	            }
                        	if (model.F_OPERATIONTIME==null)
				{
	            	parameters[10].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[10].Value = model.F_OPERATIONTIME;	            }
                        	if (model.F_DEL==null)
				{
	            	parameters[11].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[11].Value = model.F_DEL;	            }
                        
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
                Log.Error("DalPAR_COMMAND_RECEIVE->Update---FAILED", ex);
                throw ex;
            }
		
		
		
			
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(decimal F_RECEIVECOMMAND_PAR_ID)
		{
			
			try
            {
                Log.Info("DalPAR_COMMAND_RECEIVE->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_PAR_COMMAND_RECEIVE  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_RECEIVECOMMAND_PAR_ID=:F_RECEIVECOMMAND_PAR_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_RECEIVECOMMAND_PAR_ID", OracleType.Number,8)			};
			parameters[0].Value = F_RECEIVECOMMAND_PAR_ID;


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
                Log.Error("DalPAR_COMMAND_RECEIVE->Delete---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(decimal F_RECEIVECOMMAND_PAR_ID)
		{
			
			try
            {
                Log.Info("DalPAR_COMMAND_RECEIVE->Disabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_PAR_COMMAND_RECEIVE  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_RECEIVECOMMAND_PAR_ID=:F_RECEIVECOMMAND_PAR_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_RECEIVECOMMAND_PAR_ID", OracleType.Number,8)			};
			parameters[0].Value = F_RECEIVECOMMAND_PAR_ID;


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
                Log.Error("DalPAR_COMMAND_RECEIVE->Disabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(decimal F_RECEIVECOMMAND_PAR_ID)
		{
			
			try
            {
                Log.Info("DalPAR_COMMAND_RECEIVE->Enabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_PAR_COMMAND_RECEIVE  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_RECEIVECOMMAND_PAR_ID=:F_RECEIVECOMMAND_PAR_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_RECEIVECOMMAND_PAR_ID", OracleType.Number,8)			};
			parameters[0].Value = F_RECEIVECOMMAND_PAR_ID;


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
                Log.Error("DalPAR_COMMAND_RECEIVE->Enabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool Drop(decimal F_RECEIVECOMMAND_PAR_ID)
		{
			
			try
            {
                Log.Info("DalPAR_COMMAND_RECEIVE->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("DELETE FROM  T_PAR_COMMAND_RECEIVE  ");
			strSql.Append(" where F_RECEIVECOMMAND_PAR_ID=:F_RECEIVECOMMAND_PAR_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_RECEIVECOMMAND_PAR_ID", OracleType.Number,8)			};
			parameters[0].Value = F_RECEIVECOMMAND_PAR_ID;


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
                Log.Error("DalPAR_COMMAND_RECEIVE->Delete---FAILED", ex);
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
                Log.Info("DalPAR_COMMAND_RECEIVE->DeleteWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_PAR_COMMAND_RECEIVE  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalPAR_COMMAND_RECEIVE->DeleteWhere---FAILED", ex);
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
                Log.Info("DalPAR_COMMAND_RECEIVE->DropWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from  T_PAR_COMMAND_RECEIVE  ");
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
                Log.Error("DalPAR_COMMAND_RECEIVE->DropWhere---FAILED", ex);
                throw ex;
            }
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelPAR_COMMAND_RECEIVE GetModel(decimal F_RECEIVECOMMAND_PAR_ID)
		{
			try
            {
                Log.Info("DalPAR_COMMAND_RECEIVE->GetModel---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select F_RECEIVECOMMAND_PAR_ID, F_RECEIVEPAR_NAME, F_RECEIVEPAR_ORDER, F_RECEIVEPAR_DATA_TYPE, F_RECEIVEPAR_DATA_LENGTH, F_RECEIVEPAR_DEFAULT_VALUE, F_RECEIVEPAR_UNIT, F_RECEIVEPAR_DISPLAY, F_RECEIVEPAR_MEMO, F_CREATE_TIME, F_OPERATOR_ID, F_OPERATIONTIME, F_DEL  ");			
				strSql.Append("  from T_PAR_COMMAND_RECEIVE ");
				strSql.Append(" where 1=1 AND  F_RECEIVECOMMAND_PAR_ID=:F_RECEIVECOMMAND_PAR_ID ");
							OracleParameter[] parameters = {
					new OracleParameter(":F_RECEIVECOMMAND_PAR_ID", OracleType.Number,8)			};
			parameters[0].Value = F_RECEIVECOMMAND_PAR_ID;

			
				RelayTest.Model.ModelPAR_COMMAND_RECEIVE model=new RelayTest.Model.ModelPAR_COMMAND_RECEIVE();
				DataSet ds=Query(strSql.ToString(),parameters);
			
				if(ds.Tables[0].Rows.Count>0)
				{
															if(ds.Tables[0].Rows[0]["F_RECEIVECOMMAND_PAR_ID"].ToString()!="")
					{
						model.F_RECEIVECOMMAND_PAR_ID=decimal.Parse(ds.Tables[0].Rows[0]["F_RECEIVECOMMAND_PAR_ID"].ToString());
					}
																																													model.F_RECEIVEPAR_NAME= ds.Tables[0].Rows[0]["F_RECEIVEPAR_NAME"].ToString();
																																			if(ds.Tables[0].Rows[0]["F_RECEIVEPAR_ORDER"].ToString()!="")
					{
						model.F_RECEIVEPAR_ORDER=decimal.Parse(ds.Tables[0].Rows[0]["F_RECEIVEPAR_ORDER"].ToString());
					}
																																													model.F_RECEIVEPAR_DATA_TYPE= ds.Tables[0].Rows[0]["F_RECEIVEPAR_DATA_TYPE"].ToString();
																																			if(ds.Tables[0].Rows[0]["F_RECEIVEPAR_DATA_LENGTH"].ToString()!="")
					{
						model.F_RECEIVEPAR_DATA_LENGTH=decimal.Parse(ds.Tables[0].Rows[0]["F_RECEIVEPAR_DATA_LENGTH"].ToString());
					}
																																													model.F_RECEIVEPAR_DEFAULT_VALUE= ds.Tables[0].Rows[0]["F_RECEIVEPAR_DEFAULT_VALUE"].ToString();
																																								model.F_RECEIVEPAR_UNIT= ds.Tables[0].Rows[0]["F_RECEIVEPAR_UNIT"].ToString();
																																			if(ds.Tables[0].Rows[0]["F_RECEIVEPAR_DISPLAY"].ToString()!="")
					{
						model.F_RECEIVEPAR_DISPLAY=decimal.Parse(ds.Tables[0].Rows[0]["F_RECEIVEPAR_DISPLAY"].ToString());
					}
																																													model.F_RECEIVEPAR_MEMO= ds.Tables[0].Rows[0]["F_RECEIVEPAR_MEMO"].ToString();
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
                Log.Error("DalPAR_COMMAND_RECEIVE->GetModel---FAILED", ex);
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
                Log.Info("DalPAR_COMMAND_RECEIVE->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select * ");
				strSql.Append(" FROM T_PAR_COMMAND_RECEIVE  where 1=1");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				return Query(strSql.ToString());
	            }
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_RECEIVE->GetList---FAILED", ex);
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
                Log.Info("DalPAR_COMMAND_RECEIVE->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select ");
				if(Top>0)
				{
					strSql.Append(" top "+Top.ToString());
				}
				strSql.Append(" * ");
				strSql.Append(" FROM T_PAR_COMMAND_RECEIVE  where F_DEL=0 ");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				strSql.Append(" order by " + filedOrder);
				return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_RECEIVE->GetList---FAILED", ex);
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
                Log.Info("DalPAR_COMMAND_RECEIVE->GetParCount---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select count(*) ");
                strSql.Append(" FROM T_PAR_COMMAND_RECEIVE  where F_DEL=0");
                if (tempParId.Trim() != "")
                {
                    strSql.Append(" and F_COMMAND_PAR_ID='" + tempParId + "'");
                }
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_RECEIVE->GetParCount---FAILED", ex);
                throw ex;
            }
        }
        #endregion
	}
}

