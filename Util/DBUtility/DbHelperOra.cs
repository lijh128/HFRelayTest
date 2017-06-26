using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using log4net;

namespace RelayTest.Util.DBUtility
{
	/// <summary>
    /// Copyright (C) Maticsoft
	/// 数据访问基础类(基于Oracle)
	/// 可以用户可以修改满足自己项目的需要。
	/// </summary>
    public abstract class DbHelperOra : DBDALBase
	{
        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DbHelperOra));
        //数据库连接字符串(web.config来配置)，可以动态更改connectionString支持多数据库.		
        public static string connectionString;
		public DbHelperOra()
		{			
		}
        

        #region 公用方法

        public static string ParseOracleParameter(OracleParameter[] cmdParam)
        {
            string strParam = "";
            for(int i=0;i<cmdParam.Length;i++)
            {
                strParam += "["+cmdParam[i].DbType + "," + cmdParam[i].ParameterName + "," + cmdParam[i].Value + "] ";
            }
            return strParam;
        }
        
        public int GetMaxID(string FieldName, string TableName)
        {
            
            string strsql = "select max(" + FieldName + ")+1 from " + TableName;
            Log.Info("DbHelperOra->GetMaxID(string, string) SQL: " + strsql);
            object obj = GetSingle(strsql);
            if (obj == null)
            {
                return 1;
            }
            else
            {
                return int.Parse(obj.ToString());
            }
        }
        public bool Exists(string strSql)
        {
            object obj = GetSingle(strSql);
            Log.Info("DbHelperOra->Exists(string) SQL: " + strSql);
            int cmdresult;
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool Exists(string strSql, params OracleParameter[] cmdParms)
        {
            Log.Info("DbHelperOra->Exists(string,params OracleParameter[])  SQL: " + strSql);
            Log.Info("DbHelperOra->Exists(string,params OracleParameter[]) cmdParms: " + ParseOracleParameter(cmdParms));
         
            object obj = GetSingle(strSql, cmdParms);
            int cmdresult;
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

       
        #endregion

		
		#region  执行简单SQL语句

		/// <summary>
		/// 执行SQL语句，返回影响的记录数
		/// </summary>
		/// <param name="SQLString">SQL语句</param>
		/// <returns>影响的记录数</returns>
        public int ExecuteSql(string SQLString)
		{
            Log.Info("DbHelperOra->ExecuteSql(string) SQL: " + SQLString);
            OracleConnection connection = base._dbAccess.GetConnection;

            using (OracleCommand cmd = new OracleCommand(SQLString, connection))
            {
					try
					{		
                    //connection.Open();
                    cmd.Transaction = base._dbAccess.GetTransaction;
						int rows=cmd.ExecuteNonQuery();
						return rows;
					}
					catch(System.Data.OracleClient.OracleException E)
					{					
                    //connection.Close();
						throw new Exception(E.Message);
					}
				}				

		}
		
		/// <summary>
		/// 执行多条SQL语句，实现数据库事务。
		/// </summary>
		/// <param name="SQLStringList">多条SQL语句</param>		
        public void ExecuteSqlTran(ArrayList SQLStringList)
		{

            using (OracleConnection conn = base._dbAccess.GetConnection)
			{
				//conn.Open();
				OracleCommand cmd = new OracleCommand();
				cmd.Connection=conn;				
				OracleTransaction tx=conn.BeginTransaction();			
				cmd.Transaction=tx;				
				try
				{   		
					for(int n=0;n<SQLStringList.Count;n++)
					{
						string strsql=SQLStringList[n].ToString();
						if (strsql.Trim().Length>1)
						{
                            Log.Info("DbHelperOra->ExecuteSqlTran(ArrayList) SQL[" + n + "]: " + strsql);
							cmd.CommandText=strsql;
							cmd.ExecuteNonQuery();
						}
					}										
					//tx.Commit();					
				}
				catch(System.Data.OracleClient.OracleException E)
				{		
					throw new Exception(E.Message);
				}
			}
		}
		/// <summary>
		/// 执行带一个存储过程参数的的SQL语句。
		/// </summary>
		/// <param name="SQLString">SQL语句</param>
		/// <param name="content">参数内容,比如一个字段是格式复杂的文章，有特殊符号，可以通过这个方式添加</param>
		/// <returns>影响的记录数</returns>
        public int ExecuteSql(string SQLString, string content)
		{

            Log.Info("DbHelperOra->ExecuteSql(string,string) SQL: " + SQLString + "; content : " + content);
							
            using (OracleConnection connection = base._dbAccess.GetConnection)
			{
				OracleCommand cmd = new OracleCommand(SQLString,connection);
                System.Data.OracleClient.OracleParameter myParameter = new System.Data.OracleClient.OracleParameter("@content", System.Data.OracleClient.OracleType.VarChar);
				myParameter.Value = content ;
				cmd.Parameters.Add(myParameter);
				try
				{
					connection.Open();
					int rows=cmd.ExecuteNonQuery();
					return rows;
				}
				catch(System.Data.OracleClient.OracleException E)
				{				
					throw new Exception(E.Message);
				}
				finally
				{
					cmd.Dispose();
					connection.Close();
				}	
			}
		}		
		/// <summary>
		/// 向数据库里插入图像格式的字段(和上面情况类似的另一种实例)
		/// </summary>
		/// <param name="strSQL">SQL语句</param>
		/// <param name="fs">图像字节,数据库的字段类型为image的情况</param>
		/// <returns>影响的记录数</returns>
        public int ExecuteSqlInsertImg(string strSQL, byte[] fs)
		{
            Log.Info("DbHelperOra->ExecuteSqlInsertImg(string,byte[]) SQL: " + strSQL);
			
            using (OracleConnection connection = base._dbAccess.GetConnection)
			{
				OracleCommand cmd = new OracleCommand(strSQL,connection);
                System.Data.OracleClient.OracleParameter myParameter = new System.Data.OracleClient.OracleParameter("@fs", System.Data.OracleClient.OracleType.LongRaw);
				myParameter.Value = fs ;
				cmd.Parameters.Add(myParameter);
				try
				{
					connection.Open();
					int rows=cmd.ExecuteNonQuery();
					return rows;
				}
				catch(System.Data.OracleClient.OracleException E)
				{				
					throw new Exception(E.Message);
				}
				finally
				{
					cmd.Dispose();
					connection.Close();
				}				
			}
		}
		
		/// <summary>
		/// 执行一条计算查询结果语句，返回查询结果（object）。
		/// </summary>
		/// <param name="SQLString">计算查询结果语句</param>
		/// <returns>查询结果（object）</returns>
        public object GetSingle(string SQLString)
		{
            Log.Info("DbHelperOra->GetSingle(string) SQL: " + SQLString);

		    OracleConnection connection = base._dbAccess.GetConnection;
			//{
				using(OracleCommand cmd = new OracleCommand(SQLString,connection))
				{
					try
					{
						//connection.Open();
                        cmd.Transaction = base._dbAccess.GetTransaction;
						object obj = cmd.ExecuteScalar();
						if((Object.Equals(obj,null))||(Object.Equals(obj,System.DBNull.Value)))
						{					
							return null;
						}
						else
						{
							return obj;
						}				
					}
					catch(System.Data.OracleClient.OracleException e)
					{						
						//connection.Close();
						throw new Exception(e.Message);
					}	
				}
			//}
		}
		/// <summary>
        /// 执行查询语句，返回OracleDataReader ( 注意：调用该方法后，一定要对SqlDataReader进行Close )
		/// </summary>
		/// <param name="strSQL">查询语句</param>
		/// <returns>OracleDataReader</returns>
        public OracleDataReader ExecuteReader(string strSQL)
		{
            Log.Info("DbHelperOra->ExecuteReader(string) SQL: " + strSQL);
            OracleConnection connection = base._dbAccess.GetConnection;
			OracleCommand cmd = new OracleCommand(strSQL,connection);				
			try
			{
				connection.Open();
                OracleDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
				return myReader;
			}
			catch(System.Data.OracleClient.OracleException e)
			{								
				throw new Exception(e.Message);
			}			
			
		}		
		/// <summary>
		/// 执行查询语句，返回DataSet
		/// </summary>
		/// <param name="SQLString">查询语句</param>
		/// <returns>DataSet</returns>
        public DataSet Query(string SQLString)
		{
            Log.Info("DbHelperOra->Query(string) SQL: " + SQLString);
		    OracleConnection connection = base._dbAccess.GetConnection;
            
                OracleCommand cmd = new OracleCommand();
                PrepareCommand(cmd, connection, base._dbAccess.GetTransaction, SQLString, null);
                using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    try
                    {
                        da.Fill(ds, "ds");
                        cmd.Parameters.Clear();
                        return ds;
                    }
                    catch (System.Data.OracleClient.OracleException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                   
                }
           
		}


		#endregion

		#region 执行带参数的SQL语句

		/// <summary>
		/// 执行SQL语句，返回影响的记录数
		/// </summary>
		/// <param name="SQLString">SQL语句</param>
		/// <returns>影响的记录数</returns>
        public int ExecuteSql(string SQLString, params OracleParameter[] cmdParms)
		{
            Log.Info("DbHelperOra->ExecuteSql(string ,params OracleParameter[]) SQL: " + SQLString);
            Log.Info("DbHelperOra->ExecuteSql(string ,params OracleParameter[]) cmdParms: " + ParseOracleParameter(cmdParms));
            //{
                OracleConnection connection = base._dbAccess.GetConnection;
                using (OracleCommand cmd = new OracleCommand())
                {
                    try
                    {
                        PrepareCommand(cmd, connection, base._dbAccess.GetTransaction, SQLString, cmdParms);
                        int rows = cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        return rows;
                    }
                    catch (Exception e)
                    {
                        
                        throw e;
                    }
                }
            //}
        }

		
			
		/// <summary>
		/// 执行多条SQL语句，实现数据库事务。
		/// </summary>
		/// <param name="SQLStringList">SQL语句的哈希表（key为sql语句，value是该语句的OracleParameter[]）</param>
        public void ExecuteSqlTran(Hashtable SQLStringList)
		{			

            using (OracleConnection conn = base._dbAccess.GetConnection)
			{
				conn.Open();
				using (OracleTransaction trans = conn.BeginTransaction()) 
				{
					OracleCommand cmd = new OracleCommand();
					try 
					{
						//循环
						foreach (DictionaryEntry myDE in SQLStringList)
						{	
							string 	cmdText=myDE.Key.ToString();
							OracleParameter[] cmdParms=(OracleParameter[])myDE.Value;

                            Log.Info("DbHelperOra->ExecuteSqlTran(Hashtable) SQL: " + cmdText);
                            Log.Info("DbHelperOra->ExecuteSqlTran(Hashtable) cmdParms: " + ParseOracleParameter(cmdParms));
         
							PrepareCommand(cmd,conn,trans,cmdText, cmdParms);
							int val = cmd.ExecuteNonQuery();
							cmd.Parameters.Clear();

							trans.Commit();
						}					
					}
					catch 
					{
						trans.Rollback();
						throw;
					}
				}				
			}
		}

        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">SQL语句和执行参数）</param>
        public void ExecuteSqlTran(List<SqlCommandList> SQLStringList)
        {
            using (OracleConnection conn = base._dbAccess.GetConnection)
            {
                conn.Open();
                using (OracleTransaction trans = conn.BeginTransaction())
                {
                    OracleCommand cmd = new OracleCommand();
                    try
                    {
                        //循环
                        foreach (SqlCommandList myDE in SQLStringList)
                        {
                            string cmdText = myDE.cmdText;
                            OracleParameter[] cmdParms = myDE.cmdParamsAry;
                            Log.Info("DbHelperOra->ExecuteSqlTran(List<SqlCommandList>) SQL: " + cmdText);
                            Log.Info("DbHelperOra->ExecuteSqlTran(List<SqlCommandList>) cmdParms: " + ParseOracleParameter(cmdParms));
                            PrepareCommand(cmd, conn, trans, cmdText, cmdParms);
                            int val = cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }
                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }
	
				
		/// <summary>
		/// 执行一条计算查询结果语句，返回查询结果（object）。
		/// </summary>
		/// <param name="SQLString">计算查询结果语句</param>
		/// <returns>查询结果（object）</returns>
        public object GetSingle(string SQLString, params OracleParameter[] cmdParms)
		{
            Log.Info("DbHelperOra->GetSingle(string,params OracleParameter[]) SQL: " + SQLString);
            Log.Info("DbHelperOra->GetSingle(string,params OracleParameter[]) cmdParms: " + ParseOracleParameter(cmdParms));
                          
                OracleConnection connection = base._dbAccess.GetConnection;
                using (OracleCommand cmd = new OracleCommand())
                {
                    try
                    {
                        PrepareCommand(cmd, connection, base._dbAccess.GetTransaction, SQLString, cmdParms);
                        object obj = cmd.ExecuteScalar();
                        cmd.Parameters.Clear();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            return null;
                        }
						else
						{
							return obj;
						}				
                    }
                    catch //(System.Data.OracleClient.OracleException e)
                    {
                        //throw new Exception(e.Message);
                        throw;
                    }
                }
            //}
        }
		
		/// <summary>
        /// 执行查询语句，返回OracleDataReader ( 注意：调用该方法后，一定要对SqlDataReader进行Close )
		/// </summary>
		/// <param name="strSQL">查询语句</param>
		/// <returns>OracleDataReader</returns>
        public OracleDataReader ExecuteReader(string SQLString, params OracleParameter[] cmdParms)
		{
            Log.Info("DbHelperOra->ExecuteReader(string,params OracleParameter[]) SQL: " + SQLString);
            Log.Info("DbHelperOra->ExecuteReader(string,params OracleParameter[]) cmdParms: " + ParseOracleParameter(cmdParms));
           
			OracleConnection connection = new OracleConnection(connectionString);
			OracleCommand cmd = new OracleCommand();				
			try
			{
				PrepareCommand(cmd, connection, null,SQLString, cmdParms);
                OracleDataReader myReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
				cmd.Parameters.Clear();
				return myReader;
			}
			catch //(System.Data.OracleClient.OracleException e)
			{								
				//throw new Exception(e.Message);
                throw;
			}					
			
		}		
		
		/// <summary>
		/// 执行查询语句，返回DataSet
		/// </summary>
		/// <param name="SQLString">查询语句</param>
		/// <returns>DataSet</returns>
        public DataSet Query(string SQLString, params OracleParameter[] cmdParms)
        {
            Log.Info("DbHelperOra->Query(string,params OracleParameter[]) SQL: " + SQLString);
            Log.Info("DbHelperOra->Query(string,params OracleParameter[]) cmdParms: " + ParseOracleParameter(cmdParms));
  
                OracleConnection connection = base._dbAccess.GetConnection;
                OracleCommand cmd = new OracleCommand();
                PrepareCommand(cmd, connection, base._dbAccess.GetTransaction, SQLString, cmdParms);
                using (OracleDataAdapter da = new OracleDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    try
                    {
                        da.Fill(ds, "ds");
						cmd.Parameters.Clear();
					}
                    catch //(System.Data.OracleClient.OracleException ex)
                    {
                        //throw new Exception(ex.Message);
                        throw;
                    }
                    return ds;
                }
            //}
        }


        private void PrepareCommand(OracleCommand cmd, OracleConnection conn, OracleTransaction trans, string cmdText, OracleParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
			cmd.Connection = conn;
			cmd.CommandText = cmdText;
			if (trans != null)
				cmd.Transaction = trans;
			if (cmdParms != null) 
			{
				foreach (OracleParameter parm in cmdParms)
					cmd.Parameters.Add(parm);
			}
		}

		#endregion

		#region 存储过程操作

        public static string ParseProcedureParam(IDataParameter[] parameters)
        {
            string strParam = "";
            for (int i = 0; i < parameters.Length; i++)
            {
                strParam += "[" + parameters[i].DbType + "," + parameters[i].ParameterName + "," + parameters[i].Value + "] ";
            }
            return strParam;
        }

		/// <summary>
        /// 执行存储过程 返回SqlDataReader ( 注意：调用该方法后，一定要对SqlDataReader进行Close )
		/// </summary>
		/// <param name="storedProcName">存储过程名</param>
		/// <param name="parameters">存储过程参数</param>
        /// <returns>OracleDataReader</returns>
        public OracleDataReader RunProcedure(string storedProcName, IDataParameter[] parameters)
        {
            Log.Info("DbHelperOra->RunProcedure(string, IDataParameter[] ) SQL: " + storedProcName);
            Log.Info("DbHelperOra->RunProcedure(string, IDataParameter[] ) Parameter: " + ParseProcedureParam(parameters));
            OracleConnection connection = base._dbAccess.GetConnection;
			OracleDataReader returnReader;
			connection.Open();
			OracleCommand command = BuildQueryCommand( connection,storedProcName, parameters );
			command.CommandType = CommandType.StoredProcedure;
            returnReader = command.ExecuteReader(CommandBehavior.CloseConnection);				
			return returnReader;			
		}
		
		
		/// <summary>
		/// 执行存储过程
		/// </summary>
		/// <param name="storedProcName">存储过程名</param>
		/// <param name="parameters">存储过程参数</param>
		/// <param name="tableName">DataSet结果中的表名</param>
		/// <returns>DataSet</returns>
        public DataSet RunProcedure(string storedProcName, IDataParameter[] parameters, string tableName)
        {
            Log.Info("DbHelperOra->RunProcedure(string, IDataParameter[],string ) SQL: " + storedProcName);
            Log.Info("DbHelperOra->RunProcedure(string, IDataParameter[],string ) Parameter: " + ParseProcedureParam(parameters));
            Log.Info("DbHelperOra->RunProcedure(string, IDataParameter[],string ) tableName: " + tableName);
            using (OracleConnection connection = base._dbAccess.GetConnection)
			{
				DataSet dataSet = new DataSet();
				connection.Open();
				OracleDataAdapter sqlDA = new OracleDataAdapter();
				sqlDA.SelectCommand = BuildQueryCommand(connection, storedProcName, parameters );
				sqlDA.Fill( dataSet, tableName );
				connection.Close();
				return dataSet;
			}
		}

		
		/// <summary>
		/// 构建 OracleCommand 对象(用来返回一个结果集，而不是一个整数值)
		/// </summary>
		/// <param name="connection">数据库连接</param>
		/// <param name="storedProcName">存储过程名</param>
		/// <param name="parameters">存储过程参数</param>
		/// <returns>OracleCommand</returns>
        private OracleCommand BuildQueryCommand(OracleConnection connection, string storedProcName, IDataParameter[] parameters)
		{
            Log.Info("DbHelperOra->BuildQueryCommand(OracleConnection,string, IDataParameter[],string ) SQL: " + storedProcName);
            Log.Info("DbHelperOra->BuildQueryCommand(OracleConnection,string, IDataParameter[],string ) Parameter: " + ParseProcedureParam(parameters));
       
			OracleCommand command = new OracleCommand( storedProcName, connection );
			command.CommandType = CommandType.StoredProcedure;
			foreach (OracleParameter parameter in parameters)
			{
				command.Parameters.Add( parameter );
			}
			return command;			
		}
		
		/// <summary>
		/// 执行存储过程，返回影响的行数		
		/// </summary>
		/// <param name="storedProcName">存储过程名</param>
		/// <param name="parameters">存储过程参数</param>
		/// <param name="rowsAffected">影响的行数</param>
		/// <returns></returns>
        public int RunProcedure(string storedProcName, IDataParameter[] parameters, out int rowsAffected)
		{
            Log.Info("DbHelperOra->RunProcedure(string, IDataParameter[],out int ) SQL: " + storedProcName);
            Log.Info("DbHelperOra->RunProcedure(string, IDataParameter[],out int ) Parameter: " + ParseProcedureParam(parameters));
       
            using (OracleConnection connection = base._dbAccess.GetConnection)
			{
				int result;
				connection.Open();
				OracleCommand command = BuildIntCommand(connection,storedProcName, parameters );
				rowsAffected = command.ExecuteNonQuery();
				result = (int)command.Parameters["ReturnValue"].Value;
				//Connection.Close();
				return result;
			}
		}
		
		/// <summary>
		/// 创建 OracleCommand 对象实例(用来返回一个整数值)	
		/// </summary>
		/// <param name="storedProcName">存储过程名</param>
		/// <param name="parameters">存储过程参数</param>
		/// <returns>OracleCommand 对象实例</returns>
        private OracleCommand BuildIntCommand(OracleConnection connection, string storedProcName, IDataParameter[] parameters)
		{
            OracleCommand command = BuildQueryCommand(base._dbAccess.GetConnection, storedProcName, parameters);
			command.Parameters.Add( new OracleParameter ( "ReturnValue",
                System.Data.OracleClient.OracleType.Int32, 4, ParameterDirection.ReturnValue,
				false,0,0,string.Empty,DataRowVersion.Default,null ));
			return command;
		}
		#endregion	

	}
}
