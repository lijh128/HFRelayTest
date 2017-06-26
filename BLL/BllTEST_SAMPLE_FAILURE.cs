using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL {
	 	//试验样品失效情况记录
		public partial class BllTEST_SAMPLE_FAILURE:DBBllBase
	{ 
	
		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllTEST_SAMPLE_FAILURE));
   		     
		private readonly RelayTest.DAL.DalTEST_SAMPLE_FAILURE dal=new RelayTest.DAL.DalTEST_SAMPLE_FAILURE();
		public BllTEST_SAMPLE_FAILURE()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录fadfdasfasfas
		/// </summary>
		public bool Exists(string F_TASK_ID,string F_SAMPLE_ID,decimal F_FAILURE_CYCLE)
		{
		
			try
            {
                Log.Info("BllTEST_SAMPLE_FAILURE->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Exists(F_TASK_ID,F_SAMPLE_ID,F_FAILURE_CYCLE);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_FAILURE->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_FAILURE->Exists---finally");

            }
			
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(RelayTest.Model.ModelTEST_SAMPLE_FAILURE model)
		{
		
			try
            {
                Log.Info("BllTEST_SAMPLE_FAILURE->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               					dal.Add(model);
							
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_FAILURE->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_FAILURE->Add---finally");
            }
			
		}

		 /// <summary>
       /// 更新一条数据
       /// </summary>
       /// <param name="model">相应的数据实体</param>
       /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
		public bool Update(RelayTest.Model.ModelTEST_SAMPLE_FAILURE model)
		{
			try
            {
                Log.Info("BllTEST_SAMPLE_FAILURE->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_FAILURE->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_FAILURE->Update---finally");
            }
			
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_TASK_ID,string F_SAMPLE_ID,decimal F_FAILURE_CYCLE)
		{
			try
            {
                Log.Info("BllTEST_SAMPLE_FAILURE->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Delete(F_TASK_ID,F_SAMPLE_ID,F_FAILURE_CYCLE);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_FAILURE->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_FAILURE->Delete---finally");
            }
					
		}
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_TASK_ID,string F_SAMPLE_ID,decimal F_FAILURE_CYCLE)
		{
			try
            {
                Log.Info("BllTEST_SAMPLE_FAILURE->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Disabled(F_TASK_ID,F_SAMPLE_ID,F_FAILURE_CYCLE);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_FAILURE->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_FAILURE->Disabled---finally");
            }
					
		}
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_TASK_ID,string F_SAMPLE_ID,decimal F_FAILURE_CYCLE)
		{
			try
            {
                Log.Info("BllTEST_SAMPLE_FAILURE->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Enabled(F_TASK_ID,F_SAMPLE_ID,F_FAILURE_CYCLE);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_FAILURE->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_FAILURE->Enabled---finally");
            }
					
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool DropWhere(string strWhere)
		{
			try
            {
                Log.Info("BllTEST_SAMPLE_FAILURE->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_FAILURE->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_FAILURE->DropWhere---finally");
            }
			
			
		}
		
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Drop(string F_TASK_ID,string F_SAMPLE_ID,decimal F_FAILURE_CYCLE)
		{
			try
            {
                Log.Info("BllTEST_SAMPLE_FAILURE->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Drop(F_TASK_ID,F_SAMPLE_ID,F_FAILURE_CYCLE);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_FAILURE->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_FAILURE->Drop---finally");
            }
			
			
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelTEST_SAMPLE_FAILURE GetModel(string F_TASK_ID,string F_SAMPLE_ID,decimal F_FAILURE_CYCLE)
		{
			try
            {
                Log.Info("BllTEST_SAMPLE_FAILURE->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetModel(F_TASK_ID,F_SAMPLE_ID,F_FAILURE_CYCLE);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_FAILURE->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_FAILURE->GetModel---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			try
            {
                Log.Info("BllTEST_SAMPLE_FAILURE->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_FAILURE->GetList---FAILED", ex);
               throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_FAILURE->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			try
            {
                Log.Info("BllTEST_SAMPLE_FAILURE->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(Top,strWhere,filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_FAILURE->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_FAILURE->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelTEST_SAMPLE_FAILURE> GetModelList(string strWhere)
		{
			try
            {
                Log.Info("BllTEST_SAMPLE_FAILURE->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	DataSet ds = dal.GetList(strWhere);
				return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_FAILURE->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_FAILURE->GetModelList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelTEST_SAMPLE_FAILURE> DataTableToList(DataTable dt)
		{
		
			try
            {
                Log.Info("BllTEST_SAMPLE_FAILURE->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	List<RelayTest.Model.ModelTEST_SAMPLE_FAILURE> modelList = new List<RelayTest.Model.ModelTEST_SAMPLE_FAILURE>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				RelayTest.Model.ModelTEST_SAMPLE_FAILURE model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new RelayTest.Model.ModelTEST_SAMPLE_FAILURE();					
																	model.F_TASK_ID= dt.Rows[n]["F_TASK_ID"].ToString();
																																model.F_SAMPLE_ID= dt.Rows[n]["F_SAMPLE_ID"].ToString();
																												if(dt.Rows[n]["F_FAILURE_CYCLE"].ToString()!="")
				{
					model.F_FAILURE_CYCLE=decimal.Parse(dt.Rows[n]["F_FAILURE_CYCLE"].ToString());
				}
																																				model.F_FAILURE_TYPE= dt.Rows[n]["F_FAILURE_TYPE"].ToString();
																																model.F_FAILURE_MEMO= dt.Rows[n]["F_FAILURE_MEMO"].ToString();
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
                Log.Error("BllTEST_SAMPLE_FAILURE->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_FAILURE->DataTableToList---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			try
            {
                Log.Info("BllTEST_SAMPLE_FAILURE->GetModelList---START");
               	return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_FAILURE->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllTEST_SAMPLE_FAILURE->GetModelList---finally");
            }
			
		}
#endregion

        #region 自定义函数
        /// <summary>
        /// 根据查询条件获得试验样品失效信息
        /// </summary>
        public DataSet GetTestSampleFailureInfoByQueryCondition(string query_con)
        {
            try
            {
                Log.Info("BllTEST_INFO->GetTestSampleFailureInfoByQueryCondition---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetTestSampleFailureInfoByQueryCondition(query_con);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_INFO->GetTestSampleFailureInfoByQueryCondition---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_INFO->GetTestSampleFailureInfoByQueryCondition---finally");
            }
        }
        #endregion
    }
}