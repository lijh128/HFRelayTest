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
	 	//工作模式试验程序信息表
		public partial class DalPAR_COMMAND_WORKTYPE:DbHelperOra
	{
   		     
   		     
   		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalPAR_COMMAND_WORKTYPE));
    
    	#region Method
   		 /// <summary>
		///   是否存在该记录
		/// </summary>
		public bool Exists(decimal F_ID)
		{
		 try
            {
                Log.Info("DalPAR_COMMAND_WORKTYPE->Exists---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select count(1) from T_PAR_COMMAND_WORKTYPE");
				strSql.Append(" where 1=1 and ");
				                	                       strSql.Append(" F_ID = :F_ID  ");
                	           		 							OracleParameter[] parameters = {
					new OracleParameter(":F_ID", OracleType.Number,8)			};
			parameters[0].Value = F_ID;

			    Log.Info("DalPAR_COMMAND_WORKTYPE->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_WORKTYPE->Exists---FAILED", ex);
                throw ex;
            }
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(RelayTest.Model.ModelPAR_COMMAND_WORKTYPE model)
		{
		
		 try
            {
                Log.Info("DalPAR_COMMAND_WORKTYPE->Add---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_PAR_COMMAND_WORKTYPE(");			
            strSql.Append("F_ID,F_WORKTYPE_NAME,F_WORKTYPE_CODE,F_PROGRAMM_CODE,F_PROGRAMM_DESC,F_WORKTYPE_MEMO,F_CREATE_TIME,F_OPERATOR_ID,F_OPERATIONTIME,F_DEL");
			strSql.Append(") values (");
            strSql.Append(":F_ID,:F_WORKTYPE_NAME,:F_WORKTYPE_CODE,:F_PROGRAMM_CODE,:F_PROGRAMM_DESC,:F_WORKTYPE_MEMO,:F_CREATE_TIME,:F_OPERATOR_ID,:F_OPERATIONTIME,:F_DEL");            
            strSql.Append(") ");            
            		
			OracleParameter[] parameters = {
			            new OracleParameter(":F_ID", OracleType.Number,8) ,            
                        new OracleParameter(":F_WORKTYPE_NAME", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_WORKTYPE_CODE", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_PROGRAMM_CODE", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_PROGRAMM_DESC", OracleType.VarChar,500) ,            
                        new OracleParameter(":F_WORKTYPE_MEMO", OracleType.VarChar,500) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
			    
			if (model.F_ID==null)
			{
            	parameters[0].Value = DBNull.Value;
            }
            else
            {
                parameters[0].Value = model.F_ID;            }
                
			if (model.F_WORKTYPE_NAME==null)
			{
            	parameters[1].Value = DBNull.Value;
            }
            else
            {
                parameters[1].Value = model.F_WORKTYPE_NAME;            }
                
			if (model.F_WORKTYPE_CODE==null)
			{
            	parameters[2].Value = DBNull.Value;
            }
            else
            {
                parameters[2].Value = model.F_WORKTYPE_CODE;            }
                
			if (model.F_PROGRAMM_CODE==null)
			{
            	parameters[3].Value = DBNull.Value;
            }
            else
            {
                parameters[3].Value = model.F_PROGRAMM_CODE;            }
                
			if (model.F_PROGRAMM_DESC==null)
			{
            	parameters[4].Value = DBNull.Value;
            }
            else
            {
                parameters[4].Value = model.F_PROGRAMM_DESC;            }
                
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
                Log.Error("DalPAR_COMMAND_WORKTYPE->Add---FAILED", ex);
                throw ex;
            }
		}
		
	
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(RelayTest.Model.ModelPAR_COMMAND_WORKTYPE model)
		{
		
			try
            {
                Log.Info("DalPAR_COMMAND_WORKTYPE->Update---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_PAR_COMMAND_WORKTYPE set ");
			                        
            strSql.Append(" F_ID = :F_ID , ");                                    
            strSql.Append(" F_WORKTYPE_NAME = :F_WORKTYPE_NAME , ");                                    
            strSql.Append(" F_WORKTYPE_CODE = :F_WORKTYPE_CODE , ");                                    
            strSql.Append(" F_PROGRAMM_CODE = :F_PROGRAMM_CODE , ");                                    
            strSql.Append(" F_PROGRAMM_DESC = :F_PROGRAMM_DESC , ");                                    
            strSql.Append(" F_WORKTYPE_MEMO = :F_WORKTYPE_MEMO , ");                                    
            strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");                                    
            strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");                                    
            strSql.Append(" F_DEL = :F_DEL  ");            			
			strSql.Append(" where F_ID=:F_ID  ");
						
OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_ID", OracleType.Number,8) ,            
                        	
            new OracleParameter(":F_WORKTYPE_NAME", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_WORKTYPE_CODE", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_PROGRAMM_CODE", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_PROGRAMM_DESC", OracleType.VarChar,500) ,            
                        	
            new OracleParameter(":F_WORKTYPE_MEMO", OracleType.VarChar,500) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
						            	if (model.F_ID==null)
				{
	            	parameters[0].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[0].Value = model.F_ID;	            }
                        	if (model.F_WORKTYPE_NAME==null)
				{
	            	parameters[1].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[1].Value = model.F_WORKTYPE_NAME;	            }
                        	if (model.F_WORKTYPE_CODE==null)
				{
	            	parameters[2].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[2].Value = model.F_WORKTYPE_CODE;	            }
                        	if (model.F_PROGRAMM_CODE==null)
				{
	            	parameters[3].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[3].Value = model.F_PROGRAMM_CODE;	            }
                        	if (model.F_PROGRAMM_DESC==null)
				{
	            	parameters[4].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[4].Value = model.F_PROGRAMM_DESC;	            }
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
                Log.Error("DalPAR_COMMAND_WORKTYPE->Update---FAILED", ex);
                throw ex;
            }
		
		
		
			
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(decimal F_ID)
		{
			
			try
            {
                Log.Info("DalPAR_COMMAND_WORKTYPE->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_PAR_COMMAND_WORKTYPE  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_ID=:F_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_ID", OracleType.Number,8)			};
			parameters[0].Value = F_ID;


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
                Log.Error("DalPAR_COMMAND_WORKTYPE->Delete---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(decimal F_ID)
		{
			
			try
            {
                Log.Info("DalPAR_COMMAND_WORKTYPE->Disabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_PAR_COMMAND_WORKTYPE  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_ID=:F_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_ID", OracleType.Number,8)			};
			parameters[0].Value = F_ID;


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
                Log.Error("DalPAR_COMMAND_WORKTYPE->Disabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(decimal F_ID)
		{
			
			try
            {
                Log.Info("DalPAR_COMMAND_WORKTYPE->Enabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_PAR_COMMAND_WORKTYPE  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_ID=:F_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_ID", OracleType.Number,8)			};
			parameters[0].Value = F_ID;


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
                Log.Error("DalPAR_COMMAND_WORKTYPE->Enabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool Drop(decimal F_ID)
		{
			
			try
            {
                Log.Info("DalPAR_COMMAND_WORKTYPE->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("DELETE FROM  T_PAR_COMMAND_WORKTYPE  ");
			strSql.Append(" where F_ID=:F_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_ID", OracleType.Number,8)			};
			parameters[0].Value = F_ID;


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
                Log.Error("DalPAR_COMMAND_WORKTYPE->Delete---FAILED", ex);
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
                Log.Info("DalPAR_COMMAND_WORKTYPE->DeleteWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_PAR_COMMAND_WORKTYPE  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalPAR_COMMAND_WORKTYPE->DeleteWhere---FAILED", ex);
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
                Log.Info("DalPAR_COMMAND_WORKTYPE->DropWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from  T_PAR_COMMAND_WORKTYPE  ");
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
                Log.Error("DalPAR_COMMAND_WORKTYPE->DropWhere---FAILED", ex);
                throw ex;
            }
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelPAR_COMMAND_WORKTYPE GetModel(decimal F_ID)
		{
			try
            {
                Log.Info("DalPAR_COMMAND_WORKTYPE->GetModel---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select F_ID, F_WORKTYPE_NAME, F_WORKTYPE_CODE, F_PROGRAMM_CODE, F_PROGRAMM_DESC, F_WORKTYPE_MEMO, F_CREATE_TIME, F_OPERATOR_ID, F_OPERATIONTIME, F_DEL  ");			
				strSql.Append("  from T_PAR_COMMAND_WORKTYPE ");
				strSql.Append(" where 1=1 AND  F_ID=:F_ID ");
							OracleParameter[] parameters = {
					new OracleParameter(":F_ID", OracleType.Number,8)			};
			parameters[0].Value = F_ID;

			
				RelayTest.Model.ModelPAR_COMMAND_WORKTYPE model=new RelayTest.Model.ModelPAR_COMMAND_WORKTYPE();
				DataSet ds=Query(strSql.ToString(),parameters);
			
				if(ds.Tables[0].Rows.Count>0)
				{
															if(ds.Tables[0].Rows[0]["F_ID"].ToString()!="")
					{
						model.F_ID=decimal.Parse(ds.Tables[0].Rows[0]["F_ID"].ToString());
					}
																																													model.F_WORKTYPE_NAME= ds.Tables[0].Rows[0]["F_WORKTYPE_NAME"].ToString();
																																								model.F_WORKTYPE_CODE= ds.Tables[0].Rows[0]["F_WORKTYPE_CODE"].ToString();
																																								model.F_PROGRAMM_CODE= ds.Tables[0].Rows[0]["F_PROGRAMM_CODE"].ToString();
																																								model.F_PROGRAMM_DESC= ds.Tables[0].Rows[0]["F_PROGRAMM_DESC"].ToString();
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
                Log.Error("DalPAR_COMMAND_WORKTYPE->GetModel---FAILED", ex);
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
                Log.Info("DalPAR_COMMAND_WORKTYPE->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select * ");
				strSql.Append(" FROM T_PAR_COMMAND_WORKTYPE  where 1=1");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				return Query(strSql.ToString());
	            }
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_WORKTYPE->GetList---FAILED", ex);
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
                Log.Info("DalPAR_COMMAND_WORKTYPE->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select ");
				if(Top>0)
				{
					strSql.Append(" top "+Top.ToString());
				}
				strSql.Append(" * ");
				strSql.Append(" FROM T_PAR_COMMAND_WORKTYPE  where F_DEL=0 ");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				strSql.Append(" order by " + filedOrder);
				return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_WORKTYPE->GetList---FAILED", ex);
                throw ex;
            }
			
		}
		#endregion Method

        #region 自定义函数
        /// <summary>
        /// 获得指定id的记录数量
        /// tempParId   参数id
        /// 返回值：0--没有改参数id的记录；1--存在该参数id的记录
        /// </summary>
        public DataSet GetCount(string tempId)
        {
            try
            {
                Log.Info("DalPAR_COMMAND_WORKTYPE->GetParCount---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select count(*) ");
                strSql.Append(" FROM T_PAR_COMMAND_WORKTYPE  where F_DEL=0");
                if (tempId.Trim() != "")
                {
                    strSql.Append(" and F_ID='" + tempId + "'");
                }
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalPAR_COMMAND_WORKTYPE->GetParCount---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_forTestManage(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select F_ID,F_WORKTYPE_NAME,F_WORKTYPE_CODE,F_PROGRAMM_CODE,F_PROGRAMM_DESC,F_WORKTYPE_MEMO,F_CREATE_TIME,F_OPERATOR_ID,F_OPERATIONTIME,F_DEL, ");
            strSql.Append(" (F_WORKTYPE_NAME || '-' || F_PROGRAMM_CODE) as worktypeDis ");
            strSql.Append(" FROM T_COMMAND_WORKTYPE_PROGRAMM ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" ORDER BY F_ID ");
            return Query(strSql.ToString());
        }
        #endregion
   
	}
}

