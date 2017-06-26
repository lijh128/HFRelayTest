using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL {
	 	//试验任务分配及运行情况记录
		public partial class BllTEST_ALLOCATION:DBBllBase
	{ 
	
		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllTEST_ALLOCATION));
   		     
		private readonly RelayTest.DAL.DalTEST_ALLOCATION dal=new RelayTest.DAL.DalTEST_ALLOCATION();
		public BllTEST_ALLOCATION()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录fadfdasfasfas
		/// </summary>
		public bool Exists(string F_TEST_TASK_ID,string F_TEST_SAMPLE_ID)
		{
		
			try
            {
                Log.Info("BllTEST_ALLOCATION->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Exists(F_TEST_TASK_ID,F_TEST_SAMPLE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_ALLOCATION->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_ALLOCATION->Exists---finally");

            }
			
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add_KHD(RelayTest.Model.ModelTEST_ALLOCATION model)
		{
		
			try
            {
                Log.Info("BllTEST_ALLOCATION->Add_KHD---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               					dal.Add_KHD(model);
							
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_ALLOCATION->Add_KHD---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_ALLOCATION->Add_KHD---finally");
            }
			
		}

        /// <summary>
        /// 增加一条从Lims数据读取的数据
        /// </summary>
        public void Add_Lims(RelayTest.Model.ModelTEST_ALLOCATION model)
        {

            try
            {
                Log.Info("BllTEST_ALLOCATION->Add_Lims---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                dal.Add_Lims(model);

            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_ALLOCATION->Add_Lims---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_ALLOCATION->Add_Lims---finally");
            }

        }

		 /// <summary>
       /// 更新一条数据
       /// </summary>
       /// <param name="model">相应的数据实体</param>
       /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
		public bool Update(RelayTest.Model.ModelTEST_ALLOCATION model)
		{
			try
            {
                Log.Info("BllTEST_ALLOCATION->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_ALLOCATION->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_ALLOCATION->Update---finally");
            }
			
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_TEST_TASK_ID,string F_TEST_SAMPLE_ID)
		{
			try
            {
                Log.Info("BllTEST_ALLOCATION->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Delete(F_TEST_TASK_ID,F_TEST_SAMPLE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_ALLOCATION->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_ALLOCATION->Delete---finally");
            }
					
		}
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_TEST_TASK_ID,string F_TEST_SAMPLE_ID)
		{
			try
            {
                Log.Info("BllTEST_ALLOCATION->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Disabled(F_TEST_TASK_ID,F_TEST_SAMPLE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_ALLOCATION->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_ALLOCATION->Disabled---finally");
            }
					
		}
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_TEST_TASK_ID,string F_TEST_SAMPLE_ID)
		{
			try
            {
                Log.Info("BllTEST_ALLOCATION->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Enabled(F_TEST_TASK_ID,F_TEST_SAMPLE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_ALLOCATION->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_ALLOCATION->Enabled---finally");
            }
					
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool DropWhere(string strWhere)
		{
			try
            {
                Log.Info("BllTEST_ALLOCATION->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_ALLOCATION->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_ALLOCATION->DropWhere---finally");
            }
			
			
		}
		
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Drop(string F_TEST_TASK_ID,string F_TEST_SAMPLE_ID)
		{
			try
            {
                Log.Info("BllTEST_ALLOCATION->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Drop(F_TEST_TASK_ID,F_TEST_SAMPLE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_ALLOCATION->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_ALLOCATION->Drop---finally");
            }
			
			
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelTEST_ALLOCATION GetModel(string F_TEST_TASK_ID,string F_TEST_SAMPLE_ID)
		{
			try
            {
                Log.Info("BllTEST_ALLOCATION->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetModel(F_TEST_TASK_ID,F_TEST_SAMPLE_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_ALLOCATION->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_ALLOCATION->GetModel---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			try
            {
                Log.Info("BllTEST_ALLOCATION->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_ALLOCATION->GetList---FAILED", ex);
               throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_ALLOCATION->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			try
            {
                Log.Info("BllTEST_ALLOCATION->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(Top,strWhere,filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_ALLOCATION->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_ALLOCATION->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelTEST_ALLOCATION> GetModelList(string strWhere)
		{
			try
            {
                Log.Info("BllTEST_ALLOCATION->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	DataSet ds = dal.GetList(strWhere);
				return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_ALLOCATION->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_ALLOCATION->GetModelList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelTEST_ALLOCATION> DataTableToList(DataTable dt)
		{
		
			try
            {
                Log.Info("BllTEST_ALLOCATION->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	List<RelayTest.Model.ModelTEST_ALLOCATION> modelList = new List<RelayTest.Model.ModelTEST_ALLOCATION>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				RelayTest.Model.ModelTEST_ALLOCATION model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new RelayTest.Model.ModelTEST_ALLOCATION();					
																	model.F_TEST_TASK_ID= dt.Rows[n]["F_TEST_TASK_ID"].ToString();
																																model.F_TEST_SAMPLE_ID= dt.Rows[n]["F_TEST_SAMPLE_ID"].ToString();
																																model.F_LOAD_ID= dt.Rows[n]["F_LOAD_ID"].ToString();
																																model.F_LOAD_CHANNEL_ID= dt.Rows[n]["F_LOAD_CHANNEL_ID"].ToString();
																												if(dt.Rows[n]["F_SAMPLE_STATUS"].ToString()!="")
				{
					model.F_SAMPLE_STATUS=decimal.Parse(dt.Rows[n]["F_SAMPLE_STATUS"].ToString());
				}
																																if(dt.Rows[n]["F_MAKING_CURRENT"].ToString()!="")
				{
					model.F_MAKING_CURRENT=decimal.Parse(dt.Rows[n]["F_MAKING_CURRENT"].ToString());
				}
																																if(dt.Rows[n]["F_BREAK_CURRENT"].ToString()!="")
				{
					model.F_BREAK_CURRENT=decimal.Parse(dt.Rows[n]["F_BREAK_CURRENT"].ToString());
				}
																																if(dt.Rows[n]["F_FAILURE_CYCLE"].ToString()!="")
				{
					model.F_FAILURE_CYCLE=decimal.Parse(dt.Rows[n]["F_FAILURE_CYCLE"].ToString());
				}
																																if(dt.Rows[n]["F_TEST_CYCLE"].ToString()!="")
				{
					model.F_TEST_CYCLE=decimal.Parse(dt.Rows[n]["F_TEST_CYCLE"].ToString());
				}
																																				model.F_MEMO= dt.Rows[n]["F_MEMO"].ToString();
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
                Log.Error("BllTEST_ALLOCATION->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_ALLOCATION->DataTableToList---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			try
            {
                Log.Info("BllTEST_ALLOCATION->GetModelList---START");
               	return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_ALLOCATION->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllTEST_ALLOCATION->GetModelList---finally");
            }
			
		}
#endregion

        #region 自定义函数
        /// <summary>
        /// 根据任务编号，返回相应任务编号的样品信息到detailTable中
        /// </summary>
        public DataTable GetAndDisplaySampleInfo(DataTable detailTable, string strTaskId)
        {
            try
            {
                Log.Info("BllTEST_ALLOCATION->GetAndDisplaySampleInfo---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                DataSet dataSetSampleInfo = dal.GetListByTaskId(strTaskId);
                if (dataSetSampleInfo != null)
                {
                    if (dataSetSampleInfo.Tables[0].Rows.Count > 0)
                    {
                        for (int i = 0; i < dataSetSampleInfo.Tables[0].Rows.Count; i++)
                        {
                            DataRow dataRow = dataSetSampleInfo.Tables[0].Rows[i];
                            detailTable.Rows.Add();
                            detailTable.Rows[i]["colId"] = (i + 1).ToString();
                            detailTable.Rows[i]["F_TEST_TASK_ID"] = dataRow["F_TEST_TASK_ID"].ToString();
                            detailTable.Rows[i]["F_TEST_SAMPLE_ID"] = dataRow["F_TEST_SAMPLE_ID"].ToString();
                            detailTable.Rows[i]["F_LOAD_ID"] = dataRow["F_LOAD_ID"].ToString();
                            detailTable.Rows[i]["F_LOAD_CHANNEL_ID"] = dataRow["F_LOAD_CHANNEL_ID"].ToString();
                        }
                    }
                }

                return detailTable;
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_ALLOCATION->GetAndDisplaySampleInfo---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_ALLOCATION->GetAndDisplaySampleInfo---finally");
            }
        }
        #endregion

    }
}