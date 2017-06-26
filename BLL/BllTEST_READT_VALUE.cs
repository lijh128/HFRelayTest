using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL {
	 	//试验任务运行情况参数值记录
		public partial class BllTEST_READVALUE:DBBllBase
	{ 
	
		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllTEST_READVALUE));
   		     
		private readonly RelayTest.DAL.DalTEST_READVALUE dal=new RelayTest.DAL.DalTEST_READVALUE();
		public BllTEST_READVALUE()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录fadfdasfasfas
		/// </summary>
		public bool Exists(string F_TASK_ID,string F_SAMPLE_ID,string F_RECEIVEPAR_NAME,decimal F_READBATCH)
		{
		
			try
            {
                Log.Info("BllTEST_READVALUE->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Exists(F_TASK_ID,F_SAMPLE_ID,F_RECEIVEPAR_NAME,F_READBATCH);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_READVALUE->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_READVALUE->Exists---finally");

            }
			
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(RelayTest.Model.ModelTEST_READVALUE model)
		{
		
			try
            {
                Log.Info("BllTEST_READVALUE->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               					dal.Add(model);
							
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_READVALUE->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_READVALUE->Add---finally");
            }
			
		}

		 /// <summary>
       /// 更新一条数据
       /// </summary>
       /// <param name="model">相应的数据实体</param>
       /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
		public bool Update(RelayTest.Model.ModelTEST_READVALUE model)
		{
			try
            {
                Log.Info("BllTEST_READVALUE->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_READVALUE->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_READVALUE->Update---finally");
            }
			
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_TASK_ID,string F_SAMPLE_ID,string F_RECEIVEPAR_NAME,decimal F_READBATCH)
		{
			try
            {
                Log.Info("BllTEST_READVALUE->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Delete(F_TASK_ID,F_SAMPLE_ID,F_RECEIVEPAR_NAME,F_READBATCH);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_READVALUE->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_READVALUE->Delete---finally");
            }
					
		}
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_TASK_ID,string F_SAMPLE_ID,string F_RECEIVEPAR_NAME,decimal F_READBATCH)
		{
			try
            {
                Log.Info("BllTEST_READVALUE->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Disabled(F_TASK_ID,F_SAMPLE_ID,F_RECEIVEPAR_NAME,F_READBATCH);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_READVALUE->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_READVALUE->Disabled---finally");
            }
					
		}
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_TASK_ID,string F_SAMPLE_ID,string F_RECEIVEPAR_NAME,decimal F_READBATCH)
		{
			try
            {
                Log.Info("BllTEST_READVALUE->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Enabled(F_TASK_ID,F_SAMPLE_ID,F_RECEIVEPAR_NAME,F_READBATCH);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_READVALUE->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_READVALUE->Enabled---finally");
            }
					
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool DropWhere(string strWhere)
		{
			try
            {
                Log.Info("BllTEST_READVALUE->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_READVALUE->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_READVALUE->DropWhere---finally");
            }
			
			
		}
		
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Drop(string F_TASK_ID,string F_SAMPLE_ID,string F_RECEIVEPAR_NAME,decimal F_READBATCH)
		{
			try
            {
                Log.Info("BllTEST_READVALUE->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Drop(F_TASK_ID,F_SAMPLE_ID,F_RECEIVEPAR_NAME,F_READBATCH);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_READVALUE->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_READVALUE->Drop---finally");
            }
			
			
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelTEST_READVALUE GetModel(string F_TASK_ID,string F_SAMPLE_ID,string F_RECEIVEPAR_NAME,decimal F_READBATCH)
		{
			try
            {
                Log.Info("BllTEST_READVALUE->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetModel(F_TASK_ID,F_SAMPLE_ID,F_RECEIVEPAR_NAME,F_READBATCH);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_READVALUE->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_READVALUE->GetModel---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			try
            {
                Log.Info("BllTEST_READVALUE->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_READVALUE->GetList---FAILED", ex);
               throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_READVALUE->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			try
            {
                Log.Info("BllTEST_READVALUE->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(Top,strWhere,filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_READVALUE->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_READVALUE->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelTEST_READVALUE> GetModelList(string strWhere)
		{
			try
            {
                Log.Info("BllTEST_READVALUE->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	DataSet ds = dal.GetList(strWhere);
				return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_READVALUE->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_READVALUE->GetModelList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelTEST_READVALUE> DataTableToList(DataTable dt)
		{
		
			try
            {
                Log.Info("BllTEST_READVALUE->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	List<RelayTest.Model.ModelTEST_READVALUE> modelList = new List<RelayTest.Model.ModelTEST_READVALUE>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				RelayTest.Model.ModelTEST_READVALUE model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new RelayTest.Model.ModelTEST_READVALUE();					
																	model.F_TASK_ID= dt.Rows[n]["F_TASK_ID"].ToString();
																																model.F_SAMPLE_ID= dt.Rows[n]["F_SAMPLE_ID"].ToString();
																																model.F_RECEIVEPAR_NAME= dt.Rows[n]["F_RECEIVEPAR_NAME"].ToString();
																																model.F_RECEIVEPAR_VALUE= dt.Rows[n]["F_RECEIVEPAR_VALUE"].ToString();
																												if(dt.Rows[n]["F_READBATCH"].ToString()!="")
				{
					model.F_READBATCH=decimal.Parse(dt.Rows[n]["F_READBATCH"].ToString());
				}
																																if(dt.Rows[n]["F_CREATE_TIME"].ToString()!="")
				{
					model.F_CREATE_TIME=DateTime.Parse(dt.Rows[n]["F_CREATE_TIME"].ToString());
				}
																																				model.F_OPERATOR_ID= dt.Rows[n]["F_OPERATOR_ID"].ToString();
																												if(dt.Rows[n]["F_OPERATIONTIME"].ToString()!="")
				{
					model.F_OPERATIONTIME=DateTime.Parse(dt.Rows[n]["F_OPERATIONTIME"].ToString());
				}
																																if(dt.Rows[n]["F_DEL"].ToString()!="")
				{
					model.F_DEL=decimal.Parse(dt.Rows[n]["F_DEL"].ToString());
				}
																										
				
					modelList.Add(model);
				}
			}
			return modelList;
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_READVALUE->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_READVALUE->DataTableToList---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			try
            {
                Log.Info("BllTEST_READVALUE->GetModelList---START");
               	return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_READVALUE->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllTEST_READVALUE->GetModelList---finally");
            }
			
		}
#endregion
   
	}
}