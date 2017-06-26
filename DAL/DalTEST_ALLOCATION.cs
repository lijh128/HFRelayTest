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
	 	//试验任务分配及运行情况记录
		public partial class DalTEST_ALLOCATION:DbHelperOra
	{
   		     
   		     
   		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalTEST_ALLOCATION));
    
    	#region Method
   		 /// <summary>
		///   是否存在该记录
		/// </summary>
		public bool Exists(string F_TEST_TASK_ID,string F_TEST_SAMPLE_ID)
		{
		 try
            {
                Log.Info("DalTEST_ALLOCATION->Exists---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select count(1) from T_TEST_ALLOCATION");
				strSql.Append(" where 1=1 and ");
				                	                       strSql.Append(" F_TEST_TASK_ID = :F_TEST_TASK_ID and  ");
                	           		                 	                       strSql.Append(" F_TEST_SAMPLE_ID = :F_TEST_SAMPLE_ID  ");
                	           		 							OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,50),
					new OracleParameter(":F_TEST_SAMPLE_ID", OracleType.VarChar,50)			};
			parameters[0].Value = F_TEST_TASK_ID;
			parameters[1].Value = F_TEST_SAMPLE_ID;

			    Log.Info("DalTEST_ALLOCATION->Exists---END");

                return Exists(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_ALLOCATION->Exists---FAILED", ex);
                throw ex;
            }
		}
		
				
		
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add_Lims(RelayTest.Model.ModelTEST_ALLOCATION model)
		{
		
		 try
            {
                Log.Info("DalTEST_ALLOCATION->Add---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_TEST_ALLOCATION(");			
            strSql.Append("F_TEST_TASK_ID,F_TEST_SAMPLE_ID,F_LOAD_ID,F_LOAD_CHANNEL_ID,F_SAMPLE_STATUS,F_MAKING_CURRENT,F_BREAK_CURRENT,F_FAILURE_CYCLE,F_TEST_CYCLE,F_MEMO,F_CREATE_TIME,F_OPERATOR_ID,F_OPERATIONTIME,F_DEL,");
            strSql.Append("样品号,检测号,排程号,仪器键值,位置编号,分析名称,排程开始时间,组别,产品系列,规格型号,F_TASK_ORDER ");
			strSql.Append(") values (");
            strSql.Append(":F_TEST_TASK_ID,:F_TEST_SAMPLE_ID,:F_LOAD_ID,:F_LOAD_CHANNEL_ID,:F_SAMPLE_STATUS,:F_MAKING_CURRENT,:F_BREAK_CURRENT,:F_FAILURE_CYCLE,:F_TEST_CYCLE,:F_MEMO,:F_CREATE_TIME,:F_OPERATOR_ID,:F_OPERATIONTIME,:F_DEL,");
            strSql.Append(":样品号,:检测号,:排程号,:仪器键值,:位置编号,:分析名称,:排程开始时间,:组别,:产品系列,:规格型号,:F_TASK_ORDER ");            
            strSql.Append(") ");            
            		
			OracleParameter[] parameters = {
			            new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,50) ,            
                        new OracleParameter(":F_TEST_SAMPLE_ID", OracleType.VarChar,50) ,            
                        new OracleParameter(":F_LOAD_ID", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_LOAD_CHANNEL_ID", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_SAMPLE_STATUS", OracleType.Number,4) ,            
                        new OracleParameter(":F_MAKING_CURRENT", OracleType.Number,18) ,            
                        new OracleParameter(":F_BREAK_CURRENT", OracleType.Number,18) ,            
                        new OracleParameter(":F_FAILURE_CYCLE", OracleType.Number,18) ,            
                        new OracleParameter(":F_TEST_CYCLE", OracleType.Number,18) ,            
                        new OracleParameter(":F_MEMO", OracleType.VarChar,500) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4), 
                        new OracleParameter(":样品号", OracleType.Number,4), 
                        new OracleParameter(":检测号", OracleType.Number,4), 
                        new OracleParameter(":排程号", OracleType.Number,4), 
                        new OracleParameter(":仪器键值", OracleType.VarChar,50), 
                        new OracleParameter(":位置编号", OracleType.VarChar,50), 
                        new OracleParameter(":分析名称", OracleType.VarChar,50), 
                        new OracleParameter(":排程开始时间", OracleType.DateTime),
                        new OracleParameter(":组别", OracleType.VarChar,50), 
                        new OracleParameter(":产品系列", OracleType.VarChar,50), 
                        new OracleParameter(":规格型号", OracleType.VarChar,50),
                        new OracleParameter(":F_TASK_ORDER", OracleType.Int16,2)
            };
			    
			if (model.F_TEST_TASK_ID==null)
			{
            	parameters[0].Value = DBNull.Value;
            }
            else
            {
                parameters[0].Value = model.F_TEST_TASK_ID;            }
                
			if (model.F_TEST_SAMPLE_ID==null)
			{
            	parameters[1].Value = DBNull.Value;
            }
            else
            {
                parameters[1].Value = model.F_TEST_SAMPLE_ID;            }
                
			if (model.F_LOAD_ID==null)
			{
            	parameters[2].Value = DBNull.Value;
            }
            else
            {
                parameters[2].Value = model.F_LOAD_ID;            }
                
			if (model.F_LOAD_CHANNEL_ID==null)
			{
            	parameters[3].Value = DBNull.Value;
            }
            else
            {
                parameters[3].Value = model.F_LOAD_CHANNEL_ID;            }
                
			if (model.F_SAMPLE_STATUS==null)
			{
            	parameters[4].Value = DBNull.Value;
            }
            else
            {
                parameters[4].Value = model.F_SAMPLE_STATUS;            }
                
			if (model.F_MAKING_CURRENT==null)
			{
            	parameters[5].Value = DBNull.Value;
            }
            else
            {
                parameters[5].Value = model.F_MAKING_CURRENT;            }
                
			if (model.F_BREAK_CURRENT==null)
			{
            	parameters[6].Value = DBNull.Value;
            }
            else
            {
                parameters[6].Value = model.F_BREAK_CURRENT;            }
                
			if (model.F_FAILURE_CYCLE==null)
			{
            	parameters[7].Value = DBNull.Value;
            }
            else
            {
                parameters[7].Value = model.F_FAILURE_CYCLE;            }
                
			if (model.F_TEST_CYCLE==null)
			{
            	parameters[8].Value = DBNull.Value;
            }
            else
            {
                parameters[8].Value = model.F_TEST_CYCLE;            }
                
			if (model.F_MEMO==null)
			{
            	parameters[9].Value = DBNull.Value;
            }
            else
            {
                parameters[9].Value = model.F_MEMO;            }
                
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

            if (model.样品号==null)
			{
            	parameters[14].Value = DBNull.Value;
            }
            else
            {
                parameters[14].Value = model.样品号;            }

            if (model.检测号 == null)
            {
                parameters[15].Value = DBNull.Value;
            }
            else
            {
                parameters[15].Value = model.检测号;
            }

            if (model.排程号 == null)
            {
                parameters[16].Value = DBNull.Value;
            }
            else
            {
                parameters[16].Value = model.排程号;
            }

            if (model.仪器键值 == null)
            {
                parameters[17].Value = DBNull.Value;
            }
            else
            {
                parameters[17].Value = model.仪器键值;
            }

            if (model.位置编号== null)
            {
                parameters[18].Value = DBNull.Value;
            }
            else
            {
                parameters[18].Value = model.位置编号;
            }
            if (model.分析名称 == null)
            {
                parameters[19].Value = DBNull.Value;
            }
            else
            {
                parameters[19].Value = model.分析名称;
            }
            if (model.排程开始时间 == null)
            {
                parameters[20].Value = DBNull.Value;
            }
            else
            {
                parameters[20].Value = model.排程开始时间;
            }
            if (model.组别 == null)
            {
                parameters[21].Value = DBNull.Value;
            }
            else
            {
                parameters[21].Value = model.组别;
            }
            if (model.产品系列 == null)
            {
                parameters[22].Value = DBNull.Value;
            }
            else
            {
                parameters[22].Value = model.产品系列;
            }
            if (model.规格型号 == null)
            {
                parameters[23].Value = DBNull.Value;
            }
            else
            {
                parameters[23].Value = model.规格型号;
            }
            if (model.F_TASK_ORDER == null)
            {
                parameters[24].Value = DBNull.Value;
            }
            else
            {
                parameters[24].Value = model.F_TASK_ORDER;
            }
			 
                ExecuteSql(strSql.ToString(),parameters);
			} 
            catch (Exception ex)
            {
                Log.Error("DalTEST_ALLOCATION->Add---FAILED", ex);
                throw ex;
            }
		}

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add_KHD(RelayTest.Model.ModelTEST_ALLOCATION model)
        {

            try
            {
                Log.Info("DalTEST_ALLOCATION->Add---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into T_TEST_ALLOCATION(");
                strSql.Append("F_TEST_TASK_ID,F_TEST_SAMPLE_ID,F_LOAD_ID,F_LOAD_CHANNEL_ID,F_SAMPLE_STATUS,F_MAKING_CURRENT,F_BREAK_CURRENT,F_FAILURE_CYCLE,F_TEST_CYCLE,F_MEMO,F_CREATE_TIME,F_OPERATOR_ID,F_OPERATIONTIME,F_DEL");               
                strSql.Append(") values (");
                strSql.Append(":F_TEST_TASK_ID,:F_TEST_SAMPLE_ID,:F_LOAD_ID,:F_LOAD_CHANNEL_ID,:F_SAMPLE_STATUS,:F_MAKING_CURRENT,:F_BREAK_CURRENT,:F_FAILURE_CYCLE,:F_TEST_CYCLE,:F_MEMO,:F_CREATE_TIME,:F_OPERATOR_ID,:F_OPERATIONTIME,:F_DEL");                
                strSql.Append(") ");

                OracleParameter[] parameters = {
			            new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,50) ,            
                        new OracleParameter(":F_TEST_SAMPLE_ID", OracleType.VarChar,50) ,            
                        new OracleParameter(":F_LOAD_ID", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_LOAD_CHANNEL_ID", OracleType.VarChar,20) ,            
                        new OracleParameter(":F_SAMPLE_STATUS", OracleType.Number,4) ,            
                        new OracleParameter(":F_MAKING_CURRENT", OracleType.Number,18) ,            
                        new OracleParameter(":F_BREAK_CURRENT", OracleType.Number,18) ,            
                        new OracleParameter(":F_FAILURE_CYCLE", OracleType.Number,18) ,            
                        new OracleParameter(":F_TEST_CYCLE", OracleType.Number,18) ,            
                        new OracleParameter(":F_MEMO", OracleType.VarChar,500) ,            
                        new OracleParameter(":F_CREATE_TIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        new OracleParameter(":F_DEL", OracleType.Number,4)
            };

                if (model.F_TEST_TASK_ID == null)
                {
                    parameters[0].Value = DBNull.Value;
                }
                else
                {
                    parameters[0].Value = model.F_TEST_TASK_ID;
                }

                if (model.F_TEST_SAMPLE_ID == null)
                {
                    parameters[1].Value = DBNull.Value;
                }
                else
                {
                    parameters[1].Value = model.F_TEST_SAMPLE_ID;
                }

                if (model.F_LOAD_ID == null)
                {
                    parameters[2].Value = DBNull.Value;
                }
                else
                {
                    parameters[2].Value = model.F_LOAD_ID;
                }

                if (model.F_LOAD_CHANNEL_ID == null)
                {
                    parameters[3].Value = DBNull.Value;
                }
                else
                {
                    parameters[3].Value = model.F_LOAD_CHANNEL_ID;
                }

                if (model.F_SAMPLE_STATUS == null)
                {
                    parameters[4].Value = DBNull.Value;
                }
                else
                {
                    parameters[4].Value = model.F_SAMPLE_STATUS;
                }

                if (model.F_MAKING_CURRENT == null)
                {
                    parameters[5].Value = DBNull.Value;
                }
                else
                {
                    parameters[5].Value = model.F_MAKING_CURRENT;
                }

                if (model.F_BREAK_CURRENT == null)
                {
                    parameters[6].Value = DBNull.Value;
                }
                else
                {
                    parameters[6].Value = model.F_BREAK_CURRENT;
                }

                if (model.F_FAILURE_CYCLE == null)
                {
                    parameters[7].Value = DBNull.Value;
                }
                else
                {
                    parameters[7].Value = model.F_FAILURE_CYCLE;
                }

                if (model.F_TEST_CYCLE == null)
                {
                    parameters[8].Value = DBNull.Value;
                }
                else
                {
                    parameters[8].Value = model.F_TEST_CYCLE;
                }

                if (model.F_MEMO == null)
                {
                    parameters[9].Value = DBNull.Value;
                }
                else
                {
                    parameters[9].Value = model.F_MEMO;
                }

                if (model.F_CREATE_TIME == null)
                {
                    parameters[10].Value = DBNull.Value;
                }
                else
                {
                    parameters[10].Value = model.F_CREATE_TIME;
                }

                if (model.F_OPERATOR_ID == null)
                {
                    parameters[11].Value = DBNull.Value;
                }
                else
                {
                    parameters[11].Value = model.F_OPERATOR_ID;
                }

                if (model.F_OPERATIONTIME == null)
                {
                    parameters[12].Value = DBNull.Value;
                }
                else
                {
                    parameters[12].Value = model.F_OPERATIONTIME;
                }

                if (model.F_DEL == null)
                {
                    parameters[13].Value = DBNull.Value;
                }
                else
                {
                    parameters[13].Value = model.F_DEL;
                }
                ExecuteSql(strSql.ToString(), parameters);
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_ALLOCATION->Add---FAILED", ex);
                throw ex;
            }
        }
	
		
		
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(RelayTest.Model.ModelTEST_ALLOCATION model)
		{
		
			try
            {
                Log.Info("DalTEST_ALLOCATION->Update---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_TEST_ALLOCATION set ");
			                        
            strSql.Append(" F_TEST_TASK_ID = :F_TEST_TASK_ID , ");                                    
            strSql.Append(" F_TEST_SAMPLE_ID = :F_TEST_SAMPLE_ID , ");                                    
            strSql.Append(" F_LOAD_ID = :F_LOAD_ID , ");                                    
            strSql.Append(" F_LOAD_CHANNEL_ID = :F_LOAD_CHANNEL_ID , ");                                    
            strSql.Append(" F_SAMPLE_STATUS = :F_SAMPLE_STATUS , ");                                    
            strSql.Append(" F_MAKING_CURRENT = :F_MAKING_CURRENT , ");                                    
            strSql.Append(" F_BREAK_CURRENT = :F_BREAK_CURRENT , ");                                    
            strSql.Append(" F_FAILURE_CYCLE = :F_FAILURE_CYCLE , ");                                    
            strSql.Append(" F_TEST_CYCLE = :F_TEST_CYCLE , ");                                    
            strSql.Append(" F_MEMO = :F_MEMO , ");                                    
            strSql.Append(" F_OPERATOR_ID = :F_OPERATOR_ID , ");                                    
            strSql.Append(" F_OPERATIONTIME = :F_OPERATIONTIME , ");                                    
            strSql.Append(" F_DEL = :F_DEL  ");            			
			strSql.Append(" where F_TEST_TASK_ID=:F_TEST_TASK_ID and F_TEST_SAMPLE_ID=:F_TEST_SAMPLE_ID  ");
						
OracleParameter[] parameters = {
			            	
            new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,50) ,            
                        	
            new OracleParameter(":F_TEST_SAMPLE_ID", OracleType.VarChar,50) ,            
                        	
            new OracleParameter(":F_LOAD_ID", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_LOAD_CHANNEL_ID", OracleType.VarChar,20) ,            
                        	
            new OracleParameter(":F_SAMPLE_STATUS", OracleType.Number,4) ,            
                        	
            new OracleParameter(":F_MAKING_CURRENT", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_BREAK_CURRENT", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_FAILURE_CYCLE", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_TEST_CYCLE", OracleType.Number,18) ,            
                        	
            new OracleParameter(":F_MEMO", OracleType.VarChar,500) ,            
                        	
            new OracleParameter(":F_OPERATOR_ID", OracleType.VarChar,10) ,            
                        	
            new OracleParameter(":F_OPERATIONTIME", OracleType.DateTime) ,            
                        	
            new OracleParameter(":F_DEL", OracleType.Number,4)             
              
            };
						            	if (model.F_TEST_TASK_ID==null)
				{
	            	parameters[0].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[0].Value = model.F_TEST_TASK_ID;	            }
                        	if (model.F_TEST_SAMPLE_ID==null)
				{
	            	parameters[1].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[1].Value = model.F_TEST_SAMPLE_ID;	            }
                        	if (model.F_LOAD_ID==null)
				{
	            	parameters[2].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[2].Value = model.F_LOAD_ID;	            }
                        	if (model.F_LOAD_CHANNEL_ID==null)
				{
	            	parameters[3].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[3].Value = model.F_LOAD_CHANNEL_ID;	            }
                        	if (model.F_SAMPLE_STATUS==null)
				{
	            	parameters[4].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[4].Value = model.F_SAMPLE_STATUS;	            }
                        	if (model.F_MAKING_CURRENT==null)
				{
	            	parameters[5].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[5].Value = model.F_MAKING_CURRENT;	            }
                        	if (model.F_BREAK_CURRENT==null)
				{
	            	parameters[6].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[6].Value = model.F_BREAK_CURRENT;	            }
                        	if (model.F_FAILURE_CYCLE==null)
				{
	            	parameters[7].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[7].Value = model.F_FAILURE_CYCLE;	            }
                        	if (model.F_TEST_CYCLE==null)
				{
	            	parameters[8].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[8].Value = model.F_TEST_CYCLE;	            }
                        	if (model.F_MEMO==null)
				{
	            	parameters[9].Value = DBNull.Value;
	            }
	            else
	            {
	                parameters[9].Value = model.F_MEMO;	            }
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
                Log.Error("DalTEST_ALLOCATION->Update---FAILED", ex);
                throw ex;
            }
		
		
		
			
		}
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_TEST_TASK_ID,string F_TEST_SAMPLE_ID)
		{
			
			try
            {
                Log.Info("DalTEST_ALLOCATION->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_ALLOCATION  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_TEST_TASK_ID=:F_TEST_TASK_ID and F_TEST_SAMPLE_ID=:F_TEST_SAMPLE_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,50),
					new OracleParameter(":F_TEST_SAMPLE_ID", OracleType.VarChar,50)			};
			parameters[0].Value = F_TEST_TASK_ID;
			parameters[1].Value = F_TEST_SAMPLE_ID;


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
                Log.Error("DalTEST_ALLOCATION->Delete---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_TEST_TASK_ID,string F_TEST_SAMPLE_ID)
		{
			
			try
            {
                Log.Info("DalTEST_ALLOCATION->Disabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_ALLOCATION  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_TEST_TASK_ID=:F_TEST_TASK_ID and F_TEST_SAMPLE_ID=:F_TEST_SAMPLE_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,50),
					new OracleParameter(":F_TEST_SAMPLE_ID", OracleType.VarChar,50)			};
			parameters[0].Value = F_TEST_TASK_ID;
			parameters[1].Value = F_TEST_SAMPLE_ID;


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
                Log.Error("DalTEST_ALLOCATION->Disabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_TEST_TASK_ID,string F_TEST_SAMPLE_ID)
		{
			
			try
            {
                Log.Info("DalTEST_ALLOCATION->Enabled---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_ALLOCATION  set F_DEL =0, F_OPERATIONTIME = SYSDATE");
			strSql.Append(" where F_TEST_TASK_ID=:F_TEST_TASK_ID and F_TEST_SAMPLE_ID=:F_TEST_SAMPLE_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,50),
					new OracleParameter(":F_TEST_SAMPLE_ID", OracleType.VarChar,50)			};
			parameters[0].Value = F_TEST_TASK_ID;
			parameters[1].Value = F_TEST_SAMPLE_ID;


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
                Log.Error("DalTEST_ALLOCATION->Enabled---FAILED", ex);
                throw ex;
            }
			
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool Drop(string F_TEST_TASK_ID,string F_TEST_SAMPLE_ID)
		{
			
			try
            {
                Log.Info("DalTEST_ALLOCATION->Delete---START");
              StringBuilder strSql=new StringBuilder();
			strSql.Append("DELETE FROM  T_TEST_ALLOCATION  ");
			strSql.Append(" where F_TEST_TASK_ID=:F_TEST_TASK_ID and F_TEST_SAMPLE_ID=:F_TEST_SAMPLE_ID ");
						OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,50),
					new OracleParameter(":F_TEST_SAMPLE_ID", OracleType.VarChar,50)			};
			parameters[0].Value = F_TEST_TASK_ID;
			parameters[1].Value = F_TEST_SAMPLE_ID;


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
                Log.Error("DalTEST_ALLOCATION->Delete---FAILED", ex);
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
                Log.Info("DalTEST_ALLOCATION->DeleteWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("update  T_TEST_ALLOCATION  set F_DEL =1, F_OPERATIONTIME = SYSDATE");
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
                Log.Error("DalTEST_ALLOCATION->DeleteWhere---FAILED", ex);
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
                Log.Info("DalTEST_ALLOCATION->DropWhere---START");
              	StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from  T_TEST_ALLOCATION  ");
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
                Log.Error("DalTEST_ALLOCATION->DropWhere---FAILED", ex);
                throw ex;
            }
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelTEST_ALLOCATION GetModel(string F_TEST_TASK_ID,string F_TEST_SAMPLE_ID)
		{
			try
            {
                Log.Info("DalTEST_ALLOCATION->GetModel---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select F_TEST_TASK_ID, F_TEST_SAMPLE_ID, F_LOAD_ID, F_LOAD_CHANNEL_ID, F_SAMPLE_STATUS, F_MAKING_CURRENT, F_BREAK_CURRENT, F_FAILURE_CYCLE, F_TEST_CYCLE, F_MEMO, F_CREATE_TIME, F_OPERATOR_ID, F_OPERATIONTIME, F_DEL  ");			
				strSql.Append("  from T_TEST_ALLOCATION ");
				strSql.Append(" where 1=1 AND  F_TEST_TASK_ID=:F_TEST_TASK_ID and F_TEST_SAMPLE_ID=:F_TEST_SAMPLE_ID ");
							OracleParameter[] parameters = {
					new OracleParameter(":F_TEST_TASK_ID", OracleType.VarChar,50),
					new OracleParameter(":F_TEST_SAMPLE_ID", OracleType.VarChar,50)			};
			parameters[0].Value = F_TEST_TASK_ID;
			parameters[1].Value = F_TEST_SAMPLE_ID;

			
				RelayTest.Model.ModelTEST_ALLOCATION model=new RelayTest.Model.ModelTEST_ALLOCATION();
				DataSet ds=Query(strSql.ToString(),parameters);
			
				if(ds.Tables[0].Rows.Count>0)
				{
																				model.F_TEST_TASK_ID= ds.Tables[0].Rows[0]["F_TEST_TASK_ID"].ToString();
																																								model.F_TEST_SAMPLE_ID= ds.Tables[0].Rows[0]["F_TEST_SAMPLE_ID"].ToString();
																																								model.F_LOAD_ID= ds.Tables[0].Rows[0]["F_LOAD_ID"].ToString();
																																								model.F_LOAD_CHANNEL_ID= ds.Tables[0].Rows[0]["F_LOAD_CHANNEL_ID"].ToString();
																																			if(ds.Tables[0].Rows[0]["F_SAMPLE_STATUS"].ToString()!="")
					{
						model.F_SAMPLE_STATUS=decimal.Parse(ds.Tables[0].Rows[0]["F_SAMPLE_STATUS"].ToString());
					}
																																								if(ds.Tables[0].Rows[0]["F_MAKING_CURRENT"].ToString()!="")
					{
						model.F_MAKING_CURRENT=decimal.Parse(ds.Tables[0].Rows[0]["F_MAKING_CURRENT"].ToString());
					}
																																								if(ds.Tables[0].Rows[0]["F_BREAK_CURRENT"].ToString()!="")
					{
						model.F_BREAK_CURRENT=decimal.Parse(ds.Tables[0].Rows[0]["F_BREAK_CURRENT"].ToString());
					}
																																								if(ds.Tables[0].Rows[0]["F_FAILURE_CYCLE"].ToString()!="")
					{
						model.F_FAILURE_CYCLE=decimal.Parse(ds.Tables[0].Rows[0]["F_FAILURE_CYCLE"].ToString());
					}
																																								if(ds.Tables[0].Rows[0]["F_TEST_CYCLE"].ToString()!="")
					{
						model.F_TEST_CYCLE=decimal.Parse(ds.Tables[0].Rows[0]["F_TEST_CYCLE"].ToString());
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
                Log.Error("DalTEST_ALLOCATION->GetModel---FAILED", ex);
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
                Log.Info("DalTEST_ALLOCATION->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select * ");
				strSql.Append(" FROM T_TEST_ALLOCATION  where 1=1");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				return Query(strSql.ToString());
	            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_ALLOCATION->GetList---FAILED", ex);
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
                Log.Info("DalTEST_ALLOCATION->GetList---START");
              	StringBuilder strSql=new StringBuilder();
				strSql.Append("select ");
				if(Top>0)
				{
					strSql.Append(" top "+Top.ToString());
				}
				strSql.Append(" * ");
				strSql.Append(" FROM T_TEST_ALLOCATION  where F_DEL=0 ");
				if(strWhere.Trim()!="")
				{
					strSql.Append(" and "+strWhere);
				}
				strSql.Append(" order by " + filedOrder);
				return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_ALLOCATION->GetList---FAILED", ex);
                throw ex;
            }
			
		}
		#endregion Method

        #region 自定义函数
        /// <summary>
        /// 根据任务编号获得试验样品数据
        /// </summary>
        public DataSet GetListByTaskId(string strTaskId)
        {


            try
            {
                Log.Info("DalTEST_ALLOCATION->GetListByTaskId---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select * ");
                strSql.Append(" FROM T_TEST_ALLOCATION  where F_TEST_TASK_ID='" + strTaskId + "' ");

                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalTEST_ALLOCATION->GetListByTaskId---FAILED", ex);
                throw ex;
            }

        }
        #endregion


    }
}

