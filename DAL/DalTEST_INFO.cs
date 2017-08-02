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
	 	//试验任务基础数据
		public partial class DalTEST_INFO:DbHelperOra
	{
   		     
   		     
   		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalTEST_INFO));
    
    	#region Method
   		 /// <summary>
		///   是否存在该记录
		/// </summary>
		public bool Exists(string F_TEST_TASK_ID)
		{
		 try
            {
                Log.Info("DalTEST_INFO->Exists---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select count(1) from T_TEST_INFO");
				strSql.Append(" where 1=1 and ");
				                	                       strSql.Append(" F_TEST_TASK_ID = :F_TEST_TASK_ID  ");
                	           		 							OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,20)			};
			parameters[0].Value = F_TEST_TASK_ID;

			    Log.Info("DalTEST_INFO->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_INFO->Exists---FAILED", ex);
                throw ex;
            }
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(RelayTest.Model.ModelTEST_INFO model)
		{
		
		 try
            {
                Log.Info("DalTEST_INFO->Add---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_TEST_INFO(");
			
						//试验任务编号
            strSql.Append("  F_TEST_TASK_ID,");
            			//检测项目
            strSql.Append("  F_TEST_ITEM,");
            			//规格型号
            strSql.Append("  F_TEST_MODEL,");
            			//检测标准
            strSql.Append("  F_TEST_STANDARD,");
            			//检测性质
            strSql.Append("  F_TEST_PROPERTY,");
            			//检测目的
            strSql.Append("  F_TEST_AIM,");
            			//委托单位
            strSql.Append("  F_TASK_DEPUTE_UNIT,");
            			//联系人
            strSql.Append("  F_CONTACT,");
            			//电话
            strSql.Append("  F_PHONE,");
            			//email
            strSql.Append("  F_EMAIL,");
            			//项目负责人
            strSql.Append("  F_TEST_CHARGE,");
            			//委托日期
            strSql.Append("  F_TASK_DEPUTE_DATE,");
            			//样品系列
            strSql.Append("  F_TEST_SERIES,");
            			//样品类别
            strSql.Append("  F_SAMPLE_TYPE,");
            			//序列试验
            strSql.Append("  F_SEQUENCE_TEST,");
            			//试验状态
            strSql.Append("  F_TEST_STATUS,");
            			//创建时间
            strSql.Append("  F_CREATE_TIME,");
            			//操作员
            strSql.Append("  F_OPERATOR_ID,");
            			//操作时间
            strSql.Append("  F_OPERATIONTIME,");
            			//是否删除
            strSql.Append("  F_DEL");
            			strSql.Append(") values (");
			            strSql.Append(" :F_TEST_TASK_ID,");            
                         strSql.Append(" :F_TEST_ITEM,");            
                         strSql.Append(" :F_TEST_MODEL,");            
                         strSql.Append(" :F_TEST_STANDARD,");            
                         strSql.Append(" :F_TEST_PROPERTY,");            
                         strSql.Append(" :F_TEST_AIM,");            
                         strSql.Append(" :F_TASK_DEPUTE_UNIT,");            
                         strSql.Append(" :F_CONTACT,");            
                         strSql.Append(" :F_PHONE,");            
                         strSql.Append(" :F_EMAIL,");            
                         strSql.Append(" :F_TEST_CHARGE,");            
                         strSql.Append(" :F_TASK_DEPUTE_DATE,");            
                         strSql.Append(" :F_TEST_SERIES,");            
                         strSql.Append(" :F_SAMPLE_TYPE,");            
                         strSql.Append(" :F_SEQUENCE_TEST,");            
                         strSql.Append(" :F_TEST_STATUS,");            
                         strSql.Append(" :F_CREATE_TIME,");            
                         strSql.Append(" :F_OPERATOR_ID,");            
                         strSql.Append(" :F_OPERATIONTIME,");            
                         strSql.Append(" :F_DEL");            
                         strSql.Append(") ");            
            		
			OracleParameter[] parameters = {
			            new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_TEST_ITEM", OracleType.VarChar,50) ,            
                        new OracleParameter(":F_TEST_MODEL", OracleType.VarChar,50) ,            
                        new OracleParameter(":F_TEST_STANDARD", OracleType.VarChar,50) ,            
                        new OracleParameter(":F_TEST_PROPERTY", OracleType.VarChar,50) ,            
                        new OracleParameter(":F_TEST_AIM", OracleType.VarChar,50) ,            
                        new OracleParameter(":F_TASK_DEPUTE_UNIT", OracleType.VarChar,100) ,            
                        new OracleParameter(":F_CONTACT", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_PHONE", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_EMAIL", OracleType.VarChar,50) ,            
                        new OracleParameter(":F_TEST_CHARGE", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_TASK_DEPUTE_DATE", OracleType.DateTime) ,            
                        new OracleParameter(":F_TEST_SERIES", OracleType.VarChar,50) ,            
                        new OracleParameter(":F_SAMPLE_TYPE", OracleType.VarChar,50) ,            
                        new OracleParameter(":F_SEQUENCE_TEST", OracleType.Number,4) ,            
                        new OracleParameter(":F_TEST_STATUS", OracleType.Number,4) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
			    
			//试验任务编号
			if (model.F_TEST_TASK_ID==null)
			{
            	parameters[0].Value = DBNull.Value;
            }
            else
            {
                parameters[0].Value = model.F_TEST_TASK_ID;            }
                
			//检测项目
			if (model.F_TEST_ITEM==null)
			{
            	parameters[1].Value = DBNull.Value;
            }
            else
            {
                parameters[1].Value = model.F_TEST_ITEM;            }
                
			//规格型号
			if (model.F_TEST_MODEL==null)
			{
            	parameters[2].Value = DBNull.Value;
            }
            else
            {
                parameters[2].Value = model.F_TEST_MODEL;            }
                
			//检测标准
			if (model.F_TEST_STANDARD==null)
			{
            	parameters[3].Value = DBNull.Value;
            }
            else
            {
                parameters[3].Value = model.F_TEST_STANDARD;            }
                
			//检测性质
			if (model.F_TEST_PROPERTY==null)
			{
            	parameters[4].Value = DBNull.Value;
            }
            else
            {
                parameters[4].Value = model.F_TEST_PROPERTY;            }
                
			//检测目的
			if (model.F_TEST_AIM==null)
			{
            	parameters[5].Value = DBNull.Value;
            }
            else
            {
                parameters[5].Value = model.F_TEST_AIM;            }
                
			//委托单位
			if (model.F_TASK_DEPUTE_UNIT==null)
			{
            	parameters[6].Value = DBNull.Value;
            }
            else
            {
                parameters[6].Value = model.F_TASK_DEPUTE_UNIT;            }
                
			//联系人
			if (model.F_CONTACT==null)
			{
            	parameters[7].Value = DBNull.Value;
            }
            else
            {
                parameters[7].Value = model.F_CONTACT;            }
                
			//电话
			if (model.F_PHONE==null)
			{
            	parameters[8].Value = DBNull.Value;
            }
            else
            {
                parameters[8].Value = model.F_PHONE;            }
                
			//email
			if (model.F_EMAIL==null)
			{
            	parameters[9].Value = DBNull.Value;
            }
            else
            {
                parameters[9].Value = model.F_EMAIL;            }
                
			//项目负责人
			if (model.F_TEST_CHARGE==null)
			{
            	parameters[10].Value = DBNull.Value;
            }
            else
            {
                parameters[10].Value = model.F_TEST_CHARGE;            }
                
			//委托日期
			if (model.F_TASK_DEPUTE_DATE==null)
			{
            	parameters[11].Value = DBNull.Value;
            }
            else
            {
                parameters[11].Value = model.F_TASK_DEPUTE_DATE;            }
                
			//样品系列
			if (model.F_TEST_SERIES==null)
			{
            	parameters[12].Value = DBNull.Value;
            }
            else
            {
                parameters[12].Value = model.F_TEST_SERIES;            }
                
			//样品类别
			if (model.F_SAMPLE_TYPE==null)
			{
            	parameters[13].Value = DBNull.Value;
            }
            else
            {
                parameters[13].Value = model.F_SAMPLE_TYPE;            }
                
			//序列试验
			if (model.F_SEQUENCE_TEST==null)
			{
            	parameters[14].Value = DBNull.Value;
            }
            else
            {
                parameters[14].Value = model.F_SEQUENCE_TEST;            }
                
			//试验状态
			if (model.F_TEST_STATUS==null)
			{
            	parameters[15].Value = DBNull.Value;
            }
            else
            {
                parameters[15].Value = model.F_TEST_STATUS;            }
                
			//创建时间
			if (model.F_CREATE_TIME==null)
			{
            	parameters[16].Value = DBNull.Value;
            }
            else
            {
                parameters[16].Value = model.F_CREATE_TIME;            }
                
			//操作员
			if (model.F_OPERATOR_ID==null)
			{
            	parameters[17].Value = DBNull.Value;
            }
            else
            {
                parameters[17].Value = model.F_OPERATOR_ID;            }
                
			//操作时间
			if (model.F_OPERATIONTIME==null)
			{
            	parameters[18].Value = DBNull.Value;
            }
            else
            {
                parameters[18].Value = model.F_OPERATIONTIME;            }
                
			//是否删除
			if (model.F_DEL==null)
			{
            	parameters[19].Value = DBNull.Value;
            }
            else
            {
                parameters[19].Value = model.F_DEL;            }
                        
			            ExecuteSql(strSql.ToString(),parameters);
            			
			}
            catch (Exception ex)
            {
                Log.Error("DalTEST_INFO->Add---FAILED", ex);
                throw ex;
            }
		}
		
	
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(RelayTest.Model.ModelTEST_INFO model)
		{
		
			try
            {
                Log.Info("DalTEST_INFO->Update---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_TEST_INFO set ");
			             
            //试验任务编号
            strSql.Append(" F_TEST_TASK_ID = :F_TEST_TASK_ID , ");
                         
            //检测项目
            strSql.Append(" F_TEST_ITEM = :F_TEST_ITEM , ");
                         
            //规格型号
            strSql.Append(" F_TEST_MODEL = :F_TEST_MODEL , ");
                         
            //检测标准
            strSql.Append(" F_TEST_STANDARD = :F_TEST_STANDARD , ");
                         
            //检测性质
            strSql.Append(" F_TEST_PROPERTY = :F_TEST_PROPERTY , ");
                         
            //检测目的
            strSql.Append(" F_TEST_AIM = :F_TEST_AIM , ");
                         
            //委托单位
            strSql.Append(" F_TASK_DEPUTE_UNIT = :F_TASK_DEPUTE_UNIT , ");
                         
            //联系人
            strSql.Append(" F_CONTACT = :F_CONTACT , ");
                         
            //电话
            strSql.Append(" F_PHONE = :F_PHONE , ");
                         
            //email
            strSql.Append(" F_EMAIL = :F_EMAIL , ");
                         
            //项目负责人
            strSql.Append(" F_TEST_CHARGE = :F_TEST_CHARGE , ");
                         
            //委托日期
            strSql.Append(" F_TASK_DEPUTE_DATE = :F_TASK_DEPUTE_DATE , ");
                         
            //样品系列
            strSql.Append(" F_TEST_SERIES = :F_TEST_SERIES , ");
                         
            //样品类别
            strSql.Append(" F_SAMPLE_TYPE = :F_SAMPLE_TYPE , ");
                         
            //序列试验
            strSql.Append(" F_SEQUENCE_TEST = :F_SEQUENCE_TEST , ");
                         
            //试验状态
            strSql.Append(" F_TEST_STATUS = :F_TEST_STATUS , ");
                         
            //操作员
            strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");
                         
            //操作时间
            strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");
                         
            //是否删除
            strSql.Append(" F_DEL = :F_DEL  ");
            			
			strSql.Append(" where F_TEST_TASK_ID=:F_TEST_TASK_ID  ");
						
OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_TEST_ITEM", OracleType.VarChar,50) ,            
                        	
            new OracleParameter(":F_TEST_MODEL", OracleType.VarChar,50) ,            
                        	
            new OracleParameter(":F_TEST_STANDARD", OracleType.VarChar,50) ,            
                        	
            new OracleParameter(":F_TEST_PROPERTY", OracleType.VarChar,50) ,            
                        	
            new OracleParameter(":F_TEST_AIM", OracleType.VarChar,50) ,            
                        	
            new OracleParameter(":F_TASK_DEPUTE_UNIT", OracleType.VarChar,100) ,            
                        	
            new OracleParameter(":F_CONTACT", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_PHONE", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_EMAIL", OracleType.VarChar,50) ,            
                        	
            new OracleParameter(":F_TEST_CHARGE", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_TASK_DEPUTE_DATE", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_TEST_SERIES", OracleType.VarChar,50) ,            
                        	
            new OracleParameter(":F_SAMPLE_TYPE", OracleType.VarChar,50) ,            
                        	
            new OracleParameter(":F_SEQUENCE_TEST", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_TEST_STATUS", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
									//试验任务编号
            	if (model.F_TEST_TASK_ID==null)
				{
	            	parameters[0].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[0].Value = model.F_TEST_TASK_ID;	            }
            			//检测项目
            	if (model.F_TEST_ITEM==null)
				{
	            	parameters[1].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[1].Value = model.F_TEST_ITEM;	            }
            			//规格型号
            	if (model.F_TEST_MODEL==null)
				{
	            	parameters[2].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[2].Value = model.F_TEST_MODEL;	            }
            			//检测标准
            	if (model.F_TEST_STANDARD==null)
				{
	            	parameters[3].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[3].Value = model.F_TEST_STANDARD;	            }
            			//检测性质
            	if (model.F_TEST_PROPERTY==null)
				{
	            	parameters[4].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[4].Value = model.F_TEST_PROPERTY;	            }
            			//检测目的
            	if (model.F_TEST_AIM==null)
				{
	            	parameters[5].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[5].Value = model.F_TEST_AIM;	            }
            			//委托单位
            	if (model.F_TASK_DEPUTE_UNIT==null)
				{
	            	parameters[6].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[6].Value = model.F_TASK_DEPUTE_UNIT;	            }
            			//联系人
            	if (model.F_CONTACT==null)
				{
	            	parameters[7].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[7].Value = model.F_CONTACT;	            }
            			//电话
            	if (model.F_PHONE==null)
				{
	            	parameters[8].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[8].Value = model.F_PHONE;	            }
            			//email
            	if (model.F_EMAIL==null)
				{
	            	parameters[9].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[9].Value = model.F_EMAIL;	            }
            			//项目负责人
            	if (model.F_TEST_CHARGE==null)
				{
	            	parameters[10].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[10].Value = model.F_TEST_CHARGE;	            }
            			//委托日期
            	if (model.F_TASK_DEPUTE_DATE==null)
				{
	            	parameters[11].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[11].Value = model.F_TASK_DEPUTE_DATE;	            }
            			//样品系列
            	if (model.F_TEST_SERIES==null)
				{
	            	parameters[12].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[12].Value = model.F_TEST_SERIES;	            }
            			//样品类别
            	if (model.F_SAMPLE_TYPE==null)
				{
	            	parameters[13].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[13].Value = model.F_SAMPLE_TYPE;	            }
            			//序列试验
            	if (model.F_SEQUENCE_TEST==null)
				{
	            	parameters[14].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[14].Value = model.F_SEQUENCE_TEST;	            }
            			//试验状态
            	if (model.F_TEST_STATUS==null)
				{
	            	parameters[15].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[15].Value = model.F_TEST_STATUS;	            }
            			//操作员
            	if (model.F_OPERATOR_ID==null)
				{
	            	parameters[16].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[16].Value = model.F_OPERATOR_ID;	            }
            			//操作时间
            	if (model.F_OPERATIONTIME==null)
				{
	            	parameters[17].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[17].Value = model.F_OPERATIONTIME;	            }
            			//是否删除
            	if (model.F_DEL==null)
				{
	            	parameters[18].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[18].Value = model.F_DEL;	            }
                        
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
                Log.Error("DalTEST_INFO->Update---FAILED", ex);
                throw ex;
            }
		
		
		
			
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_TEST_TASK_ID)
		{
			
			try
            {
                Log.Info("DalTEST_INFO->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_TEST_TASK_ID=:F_TEST_TASK_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,20)			};
			parameters[0].Value = F_TEST_TASK_ID;


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
                Log.Error("DalTEST_INFO->Delete---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_TEST_TASK_ID)
		{
			
			try
            {
                Log.Info("DalTEST_INFO->Disabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_TEST_TASK_ID=:F_TEST_TASK_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,20)			};
			parameters[0].Value = F_TEST_TASK_ID;


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
                Log.Error("DalTEST_INFO->Disabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_TEST_TASK_ID)
		{
			
			try
            {
                Log.Info("DalTEST_INFO->Enabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_INFO  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_TEST_TASK_ID=:F_TEST_TASK_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,20)			};
			parameters[0].Value = F_TEST_TASK_ID;


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
                Log.Error("DalTEST_INFO->Enabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool Drop(string F_TEST_TASK_ID)
		{
			
			try
            {
                Log.Info("DalTEST_INFO->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("DELETE FROM  T_TEST_INFO  ");
			strSql.Append(" where F_TEST_TASK_ID=:F_TEST_TASK_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,20)			};
			parameters[0].Value = F_TEST_TASK_ID;


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
                Log.Error("DalTEST_INFO->Delete---FAILED", ex);
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
                Log.Info("DalTEST_INFO->DeleteWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_INFO  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalTEST_INFO->DeleteWhere---FAILED", ex);
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
                Log.Info("DalTEST_INFO->DropWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from  T_TEST_INFO  ");
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
                Log.Error("DalTEST_INFO->DropWhere---FAILED", ex);
                throw ex;
            }
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelTEST_INFO GetModel(string F_TEST_TASK_ID)
		{
			try
            {
                Log.Info("DalTEST_INFO->GetModel---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select ");
								//试验任务编号
				strSql.Append("F_TEST_TASK_ID,  ");
								//检测项目
				strSql.Append("F_TEST_ITEM,  ");
								//规格型号
				strSql.Append("F_TEST_MODEL,  ");
								//检测标准
				strSql.Append("F_TEST_STANDARD,  ");
								//检测性质
				strSql.Append("F_TEST_PROPERTY,  ");
								//检测目的
				strSql.Append("F_TEST_AIM,  ");
								//委托单位
				strSql.Append("F_TASK_DEPUTE_UNIT,  ");
								//联系人
				strSql.Append("F_CONTACT,  ");
								//电话
				strSql.Append("F_PHONE,  ");
								//email
				strSql.Append("F_EMAIL,  ");
								//项目负责人
				strSql.Append("F_TEST_CHARGE,  ");
								//委托日期
				strSql.Append("F_TASK_DEPUTE_DATE,  ");
								//样品系列
				strSql.Append("F_TEST_SERIES,  ");
								//样品类别
				strSql.Append("F_SAMPLE_TYPE,  ");
								//序列试验
				strSql.Append("F_SEQUENCE_TEST,  ");
								//试验状态
				strSql.Append("F_TEST_STATUS,  ");
								//创建时间
				strSql.Append("F_CREATE_TIME,  ");
								//操作员
				strSql.Append("F_OPERATOR_ID,  ");
								//操作时间
				strSql.Append("F_OPERATIONTIME,  ");
								//是否删除
				strSql.Append("F_DEL  ");
								strSql.Append("  from T_TEST_INFO ");
				strSql.Append(" where 1=1 AND  F_TEST_TASK_ID=:F_TEST_TASK_ID ");
							OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,20)			};
			parameters[0].Value = F_TEST_TASK_ID;

			
				RelayTest.Model.ModelTEST_INFO model=new RelayTest.Model.ModelTEST_INFO();
				DataSet ds=Query(strSql.ToString(),parameters);
			
				if(ds.Tables[0].Rows.Count>0)
				{
																				model.F_TEST_TASK_ID= ds.Tables[0].Rows[0]["F_TEST_TASK_ID"].ToString();
																																								model.F_TEST_ITEM= ds.Tables[0].Rows[0]["F_TEST_ITEM"].ToString();
																																								model.F_TEST_MODEL= ds.Tables[0].Rows[0]["F_TEST_MODEL"].ToString();
																																								model.F_TEST_STANDARD= ds.Tables[0].Rows[0]["F_TEST_STANDARD"].ToString();
																																								model.F_TEST_PROPERTY= ds.Tables[0].Rows[0]["F_TEST_PROPERTY"].ToString();
																																								model.F_TEST_AIM= ds.Tables[0].Rows[0]["F_TEST_AIM"].ToString();
																																								model.F_TASK_DEPUTE_UNIT= ds.Tables[0].Rows[0]["F_TASK_DEPUTE_UNIT"].ToString();
																																								model.F_CONTACT= ds.Tables[0].Rows[0]["F_CONTACT"].ToString();
																																								model.F_PHONE= ds.Tables[0].Rows[0]["F_PHONE"].ToString();
																																								model.F_EMAIL= ds.Tables[0].Rows[0]["F_EMAIL"].ToString();
																																								model.F_TEST_CHARGE= ds.Tables[0].Rows[0]["F_TEST_CHARGE"].ToString();
																																			if(ds.Tables[0].Rows[0]["F_TASK_DEPUTE_DATE"].ToString()!="")
					{
						model.F_TASK_DEPUTE_DATE=DateTime.Parse(ds.Tables[0].Rows[0]["F_TASK_DEPUTE_DATE"].ToString());
					}
																																													model.F_TEST_SERIES= ds.Tables[0].Rows[0]["F_TEST_SERIES"].ToString();
																																								model.F_SAMPLE_TYPE= ds.Tables[0].Rows[0]["F_SAMPLE_TYPE"].ToString();
																																			if(ds.Tables[0].Rows[0]["F_SEQUENCE_TEST"].ToString()!="")
					{
						model.F_SEQUENCE_TEST=decimal.Parse(ds.Tables[0].Rows[0]["F_SEQUENCE_TEST"].ToString());
					}
																																								if(ds.Tables[0].Rows[0]["F_TEST_STATUS"].ToString()!="")
					{
						model.F_TEST_STATUS=decimal.Parse(ds.Tables[0].Rows[0]["F_TEST_STATUS"].ToString());
					}
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
                Log.Error("DalTEST_INFO->GetModel---FAILED", ex);
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
                Log.Info("DalTEST_INFO->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select * ");
				strSql.Append(" FROM T_TEST_INFO  where 1=1");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
                strSql.Append(" order by F_TEST_TASK_ID ");
				return Query(strSql.ToString());
	            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_INFO->GetList---FAILED", ex);
                throw ex;
            }
			
		}

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_new(string strWhere)
        {


            try
            {
                Log.Info("DalTEST_INFO->GetList_new---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM VIEW_TEST_DISPLAY_LIST  where 1=1");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_INFO->GetList_new---FAILED", ex);
                throw ex;
            }

        }
        /// <summary>
        /// 获得已完成数据列表
        /// </summary>
        public DataSet GetList_complete(string strWhere)
        {


            try
            {
                Log.Info("DalTEST_INFO->GetList_complete---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM t_test_info  where 1=1");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                strSql.Append(" order by f_test_task_id desc ");
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_INFO->GetList_complete---FAILED", ex);
                throw ex;
            }

        }

        /// <summary>
        /// 获得t_test_info_nodisplay数据列表中的试验任务编号
        /// </summary>
        public DataSet GetNoDisplayList(string strWhere)
        {


            try
            {
                Log.Info("DalTEST_INFO->GetNoDisplayList---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM T_TEST_INFO_NODISPLAY  where 1=1");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" and " + strWhere);
                }
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_INFO->GetNoDisplayList---FAILED", ex);
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
                Log.Info("DalTEST_INFO->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select ");
				if(Top>0)
				{
					strSql.Append(" top "+Top.ToString());
				}
				strSql.Append(" * ");
				strSql.Append(" FROM T_TEST_INFO  where F_DEL=0 ");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				strSql.Append(" order by " + filedOrder);
				return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_INFO->GetList---FAILED", ex);
                throw ex;
            }
			
		}
		#endregion Method

        #region 自定义函数


        /// <summary>
        /// 获得可分配的最大试验编号
        /// preTaskId   试验任务编号前缀字符串
        /// </summary>
        public DataSet GetMaxTaskID(string preTaskId)
        {


            try
            {
                Log.Info("DalTEST_INFO->GetMaxTaskID---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select max(substr(F_TEST_TASK_ID,10,2)) ");
                strSql.Append(" FROM T_TEST_INFO  where F_DEL=0");
                if (preTaskId.Trim() != "")
                {
                    strSql.Append(" and F_TEST_TASK_ID LIKE '" + preTaskId + "%'");
                }
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_INFO->GetMaxTaskID---FAILED", ex);
                throw ex;
            }

        }
        /// <summary>
        /// 获得指定标准编号的记录数量
        /// tempStandardCode   标准标号
        /// 返回值：指定标准标号记录行
        /// </summary>
        public DataSet GetTaskCount(string tempTaskId)
        {
            try
            {
                Log.Info("DalTEST_INFO->GetMaxTaskID---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select count(*) ");
                strSql.Append(" FROM T_TEST_INFO  where F_DEL=0");
                if (tempTaskId.Trim() != "")
                {
                    strSql.Append(" and F_TEST_TASK_ID='" + tempTaskId + "'");
                }
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_INFO->GetMaxTaskID---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 获得指定任务编号的试验任务基本信息
        /// </summary>
        public DataSet GetListByTaskId(string strTaskId)
        {


            try
            {
                Log.Info("DalTEST_INFO->GetListByTaskId---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM T_TEST_INFO  where F_TEST_TASK_ID='"+strTaskId+"' ");
                
                strSql.Append(" order by F_TEST_TASK_ID ");
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_INFO->GetListByTaskId---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 根据查询条件获得试验任务信息
        /// </summary>
        public DataSet GetTestTaskInfoByQueryCondition(string query_con)
        {
            try
            {
                Log.Info("DalTEST_INFO->GetTestTaskInfoByQueryCondition---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM VIEW_QUERY_TEST_INFO   ");
                strSql.Append(" where 1=1 and  ");
                strSql.Append(query_con);
                strSql.Append(" order by F_TEST_TASK_ID ");
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_INFO->GetTestTaskInfoByQueryCondition---FAILED", ex);
                throw ex;
            }

        }

        /// <summary>
        /// 根据查询条件获得试验设备状态信息
        /// </summary>
        public DataSet GetDevStatusInfoByQueryCondition(string query_con)
        {
            try
            {
                Log.Info("DalTEST_INFO->GetDevStatusInfoByQueryCondition---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM VIEW_QUERY_DEV_STATUS_INFO   ");
                strSql.Append(" where 1=1 and  ");
                strSql.Append(query_con);
                strSql.Append(" order by DEVICE_TYPE,DEVICE_ID,F_TEST_TASK_ID,F_TEST_SAMPLE_ID ");
                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_INFO->GetDevStatusInfoByQueryCondition---FAILED", ex);
                throw ex;
            }

        }

        /// <summary>
        /// 删除f_test_info_nodisplay表中的数据
        /// </summary>
        public void delete_noDisplay(string strWhere)
        {
            try
            {
                Log.Info("DalTEST_INFO->delete_noDisplay---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("DELETE FROM  T_TEST_INFO_NODISPLAY  where "+strWhere);
                
                int rows = ExecuteSql(strSql.ToString());                
                return ;
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_INFO->delete_noDisplay---FAILED", ex);
                throw ex;
                
            }

        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add_noDisplay(string task_id)
        {

            try
            {
                Log.Info("DalTEST_INFO->Add_noDisplay---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into T_TEST_INFO_NODISPLAY(");

                //试验任务编号
                strSql.Append("  F_TEST_TASK_ID");               
                strSql.Append(") values (");
                strSql.Append(" :F_TEST_TASK_ID");                
                strSql.Append(") ");

                OracleParameter[] parameters = {
			            new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,20) 
            };

            //试验任务编号
            if (task_id == null)
            {
                parameters[0].Value = DBNull.Value;
            }
            else
            {
                parameters[0].Value = task_id;
            }
                ExecuteSql(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_INFO->Add_noDisplay---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 更新任务状态为20（试验中，未完成），原任务状态为60（已完成）
        /// </summary>
        public bool update_status(string F_TEST_TASK_ID)
        {

            try
            {
                Log.Info("DalTEST_INFO->update_status---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update  T_TEST_INFO  set F_TEST_STATUS =20, F_OPERATIONTIME = SYSDATE");
                strSql.Append(" where F_TEST_TASK_ID=:F_TEST_TASK_ID ");
                OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,20)			};
                parameters[0].Value = F_TEST_TASK_ID;


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
                Log.Error("DalTEST_INFO->update_status---FAILED", ex);
                throw ex;
            }

        }

        #endregion
    }
}

