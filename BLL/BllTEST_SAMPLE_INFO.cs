using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL {
	 	//试验任务样品信息
		public partial class BllTEST_SAMPLE_INFO:DBBllBase
	{ 
	
		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllTEST_SAMPLE_INFO));
   		     
		private readonly RelayTest.DAL.DalTEST_SAMPLE_INFO dal=new RelayTest.DAL.DalTEST_SAMPLE_INFO();
		public BllTEST_SAMPLE_INFO()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录fadfdasfasfas
		/// </summary>
		public bool Exists(string F_TEST_TASK_ID,string F_SAMPLE_GROUP_NUM)
		{
		
			try
            {
                Log.Info("BllTEST_SAMPLE_INFO->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Exists(F_TEST_TASK_ID,F_SAMPLE_GROUP_NUM);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_INFO->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_INFO->Exists---finally");

            }
			
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(RelayTest.Model.ModelTEST_SAMPLE_INFO model)
		{
		
			try
            {
                Log.Info("BllTEST_SAMPLE_INFO->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               					dal.Add(model);
							
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_INFO->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_INFO->Add---finally");
            }
			
		}

		 /// <summary>
       /// 更新一条数据
       /// </summary>
       /// <param name="model">相应的数据实体</param>
       /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
		public bool Update(RelayTest.Model.ModelTEST_SAMPLE_INFO model)
		{
			try
            {
                Log.Info("BllTEST_SAMPLE_INFO->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_INFO->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_INFO->Update---finally");
            }
			
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_TEST_TASK_ID,string F_SAMPLE_GROUP_NUM)
		{
			try
            {
                Log.Info("BllTEST_SAMPLE_INFO->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Delete(F_TEST_TASK_ID,F_SAMPLE_GROUP_NUM);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_INFO->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_INFO->Delete---finally");
            }
					
		}
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_TEST_TASK_ID,string F_SAMPLE_GROUP_NUM)
		{
			try
            {
                Log.Info("BllTEST_SAMPLE_INFO->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Disabled(F_TEST_TASK_ID,F_SAMPLE_GROUP_NUM);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_INFO->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_INFO->Disabled---finally");
            }
					
		}
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_TEST_TASK_ID,string F_SAMPLE_GROUP_NUM)
		{
			try
            {
                Log.Info("BllTEST_SAMPLE_INFO->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Enabled(F_TEST_TASK_ID,F_SAMPLE_GROUP_NUM);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_INFO->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_INFO->Enabled---finally");
            }
					
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool DropWhere(string strWhere)
		{
			try
            {
                Log.Info("BllTEST_SAMPLE_INFO->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_INFO->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_INFO->DropWhere---finally");
            }
			
			
		}
		
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Drop(string F_TEST_TASK_ID,string F_SAMPLE_GROUP_NUM)
		{
			try
            {
                Log.Info("BllTEST_SAMPLE_INFO->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Drop(F_TEST_TASK_ID,F_SAMPLE_GROUP_NUM);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_INFO->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_INFO->Drop---finally");
            }
			
			
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelTEST_SAMPLE_INFO GetModel(string F_TEST_TASK_ID,string F_SAMPLE_GROUP_NUM)
		{
			try
            {
                Log.Info("BllTEST_SAMPLE_INFO->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetModel(F_TEST_TASK_ID,F_SAMPLE_GROUP_NUM);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_INFO->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_INFO->GetModel---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			try
            {
                Log.Info("BllTEST_SAMPLE_INFO->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_INFO->GetList---FAILED", ex);
               throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_INFO->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			try
            {
                Log.Info("BllTEST_SAMPLE_INFO->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(Top,strWhere,filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_INFO->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_INFO->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelTEST_SAMPLE_INFO> GetModelList(string strWhere)
		{
			try
            {
                Log.Info("BllTEST_SAMPLE_INFO->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	DataSet ds = dal.GetList(strWhere);
				return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_INFO->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_INFO->GetModelList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelTEST_SAMPLE_INFO> DataTableToList(DataTable dt)
		{
		
			try
            {
                Log.Info("BllTEST_SAMPLE_INFO->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	List<RelayTest.Model.ModelTEST_SAMPLE_INFO> modelList = new List<RelayTest.Model.ModelTEST_SAMPLE_INFO>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				RelayTest.Model.ModelTEST_SAMPLE_INFO model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new RelayTest.Model.ModelTEST_SAMPLE_INFO();					
										
					//试验任务编号
												model.F_TEST_TASK_ID= dt.Rows[n]["F_TEST_TASK_ID"].ToString();
																									
					//样品数量
								if(dt.Rows[n]["F_SAMPLE_NUM"].ToString()!="")
				{
					model.F_SAMPLE_NUM=decimal.Parse(dt.Rows[n]["F_SAMPLE_NUM"].ToString());
				}
																													
					//样品组别
												model.F_SAMPLE_GROUP_NUM= dt.Rows[n]["F_SAMPLE_GROUP_NUM"].ToString();
																									
					//其他信息
												model.F_SAMPLE_MEMO= dt.Rows[n]["F_SAMPLE_MEMO"].ToString();
																									
					//创建时间
								if(dt.Rows[n]["F_CREATE_TIME"].ToString()!="")
				{
					model.F_CREATE_TIME=DateTime.Parse(dt.Rows[n]["F_CREATE_TIME"].ToString());
				}
																													
					//操作员
												model.F_OPERATOR_ID= dt.Rows[n]["F_OPERATOR_ID"].ToString();
																									
					//操作时间
								if(dt.Rows[n]["F_OPERATIONTIME"].ToString()!="")
				{
					model.F_OPERATIONTIME=DateTime.Parse(dt.Rows[n]["F_OPERATIONTIME"].ToString());
				}
																													
					//是否删除
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
                Log.Error("BllTEST_SAMPLE_INFO->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_INFO->DataTableToList---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			try
            {
                Log.Info("BllTEST_SAMPLE_INFO->GetModelList---START");
               	return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_INFO->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllTEST_SAMPLE_INFO->GetModelList---finally");
            }
			
		}
#endregion
        #region 自定义函数
            /// <summary>
        /// 根据任务编号永久删除一条数据
        /// </summary>
        public bool DropByTaskId(string F_TEST_TASK_ID)
        {
            try
            {
                Log.Info("BllTEST_SAMPLE_INFO->DropByTaskId---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.DropByTaskId(F_TEST_TASK_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_INFO->DropByTaskId---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_INFO->DropByTaskId---finally");
            }
        }

        /// <summary>
        /// 根据任务编号，返回相应任务编号的样品信息到detailTable中
        /// </summary>
        public DataTable GetAndDisplaySampleInfo(DataTable detailTable, string strTaskId)
        {
            try
            {
                Log.Info("BllTEST_SAMPLE_INFO->GetAndDisplaySampleInfo---START");
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
                            detailTable.Rows[i]["F_SAMPLE_NUM"] = dataRow["F_SAMPLE_NUM"].ToString();
                            detailTable.Rows[i]["F_SAMPLE_GROUP_NUM"] = dataRow["F_SAMPLE_GROUP_NUM"].ToString();
                            detailTable.Rows[i]["F_SAMPLE_MEMO"] = dataRow["F_SAMPLE_MEMO"].ToString();
                        }
                    }
                }

                return detailTable;
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_SAMPLE_INFO->GetAndDisplaySampleInfo---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_SAMPLE_INFO->GetAndDisplaySampleInfo---finally");
            }
        }
        #endregion

    }
}