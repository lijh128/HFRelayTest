using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL {
	 	//试验任务基础数据
		public partial class BllTEST_INFO:DBBllBase
	{ 
	
		//Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllTEST_INFO));
   		     
		private readonly RelayTest.DAL.DalTEST_INFO dal=new RelayTest.DAL.DalTEST_INFO();
		public BllTEST_INFO()
		{}
		
		#region  Method
		/// <summary>
		/// 是否存在该记录fadfdasfasfas
		/// </summary>
		public bool Exists(string F_TEST_TASK_ID)
		{
		
			try
            {
                Log.Info("BllTEST_INFO->Exists---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Exists(F_TEST_TASK_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_INFO->Exists---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_INFO->Exists---finally");

            }
			
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void  Add(RelayTest.Model.ModelTEST_INFO model)
		{
		
			try
            {
                Log.Info("BllTEST_INFO->Add---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               					dal.Add(model);
							
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_INFO->Add---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_INFO->Add---finally");
            }
			
		}

		 /// <summary>
       /// 更新一条数据
       /// </summary>
       /// <param name="model">相应的数据实体</param>
       /// <returns>真表示有记录被更新，否表示没有记录被更新</returns>
		public bool Update(RelayTest.Model.ModelTEST_INFO model)
		{
			try
            {
                Log.Info("BllTEST_INFO->Update---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Update(model);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_INFO->Update---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_INFO->Update---finally");
            }
			
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string F_TEST_TASK_ID)
		{
			try
            {
                Log.Info("BllTEST_INFO->Delete---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Delete(F_TEST_TASK_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_INFO->Delete---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_INFO->Delete---finally");
            }
					
		}
		
		/// <summary>
		/// 禁用一条数据
		/// </summary>
		public bool Disabled(string F_TEST_TASK_ID)
		{
			try
            {
                Log.Info("BllTEST_INFO->Disabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Disabled(F_TEST_TASK_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_INFO->Disabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_INFO->Disabled---finally");
            }
					
		}
		
		/// <summary>
		/// 启用一条数据
		/// </summary>
		public bool Enabled(string F_TEST_TASK_ID)
		{
			try
            {
                Log.Info("BllTEST_INFO->Enabled---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Enabled(F_TEST_TASK_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_INFO->Enabled---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_INFO->Enabled---finally");
            }
					
		}
		
		/// <summary>
		/// 永久删除一条数据
		/// </summary>
		public bool DropWhere(string strWhere)
		{
			try
            {
                Log.Info("BllTEST_INFO->DropWhere---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.DropWhere(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_INFO->DropWhere---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_INFO->DropWhere---finally");
            }
			
			
		}
		
		
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Drop(string F_TEST_TASK_ID)
		{
			try
            {
                Log.Info("BllTEST_INFO->Drop---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.Drop(F_TEST_TASK_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_INFO->Drop---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_INFO->Drop---finally");
            }
			
			
		}
		
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RelayTest.Model.ModelTEST_INFO GetModel(string F_TEST_TASK_ID)
		{
			try
            {
                Log.Info("BllTEST_INFO->GetModel---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetModel(F_TEST_TASK_ID);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_INFO->GetModel---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_INFO->GetModel---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			try
            {
                Log.Info("BllTEST_INFO->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_INFO->GetList---FAILED", ex);
               throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_INFO->GetList---finally");
            }
			
		}

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_new(string strWhere)
        {
            try
            {
                Log.Info("BllTEST_INFO->GetList_new---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetList_new(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_INFO->GetList_new---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_INFO->GetList_new---finally");
            }

        }
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			try
            {
                Log.Info("BllTEST_INFO->GetList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	return dal.GetList(Top,strWhere,filedOrder);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_INFO->GetList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_INFO->GetList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelTEST_INFO> GetModelList(string strWhere)
		{
			try
            {
                Log.Info("BllTEST_INFO->GetModelList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	DataSet ds = dal.GetList(strWhere);
				return DataTableToList(ds.Tables[0]);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_INFO->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_INFO->GetModelList---finally");
            }
			
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RelayTest.Model.ModelTEST_INFO> DataTableToList(DataTable dt)
		{
		
			try
            {
                Log.Info("BllTEST_INFO->DataTableToList---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
               	List<RelayTest.Model.ModelTEST_INFO> modelList = new List<RelayTest.Model.ModelTEST_INFO>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				RelayTest.Model.ModelTEST_INFO model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new RelayTest.Model.ModelTEST_INFO();					
										
					//试验任务编号
												model.F_TEST_TASK_ID= dt.Rows[n]["F_TEST_TASK_ID"].ToString();
																									
					//检测项目
												model.F_TEST_ITEM= dt.Rows[n]["F_TEST_ITEM"].ToString();
																									
					//规格型号
												model.F_TEST_MODEL= dt.Rows[n]["F_TEST_MODEL"].ToString();
																									
					//检测标准
												model.F_TEST_STANDARD= dt.Rows[n]["F_TEST_STANDARD"].ToString();
																									
					//检测性质
												model.F_TEST_PROPERTY= dt.Rows[n]["F_TEST_PROPERTY"].ToString();
																									
					//检测目的
												model.F_TEST_AIM= dt.Rows[n]["F_TEST_AIM"].ToString();
																									
					//委托单位
												model.F_TASK_DEPUTE_UNIT= dt.Rows[n]["F_TASK_DEPUTE_UNIT"].ToString();
																									
					//联系人
												model.F_CONTACT= dt.Rows[n]["F_CONTACT"].ToString();
																									
					//电话
												model.F_PHONE= dt.Rows[n]["F_PHONE"].ToString();
																									
					//email
												model.F_EMAIL= dt.Rows[n]["F_EMAIL"].ToString();
																									
					//项目负责人
												model.F_TEST_CHARGE= dt.Rows[n]["F_TEST_CHARGE"].ToString();
																									
					//委托日期
								if(dt.Rows[n]["F_TASK_DEPUTE_DATE"].ToString()!="")
				{
					model.F_TASK_DEPUTE_DATE=DateTime.Parse(dt.Rows[n]["F_TASK_DEPUTE_DATE"].ToString());
				}
																													
					//样品系列
												model.F_TEST_SERIES= dt.Rows[n]["F_TEST_SERIES"].ToString();
																									
					//样品类别
												model.F_SAMPLE_TYPE= dt.Rows[n]["F_SAMPLE_TYPE"].ToString();
																									
					//序列试验
								if(dt.Rows[n]["F_SEQUENCE_TEST"].ToString()!="")
				{
					model.F_SEQUENCE_TEST=decimal.Parse(dt.Rows[n]["F_SEQUENCE_TEST"].ToString());
				}
																													
					//试验状态
								if(dt.Rows[n]["F_TEST_STATUS"].ToString()!="")
				{
					model.F_TEST_STATUS=decimal.Parse(dt.Rows[n]["F_TEST_STATUS"].ToString());
				}
																													
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
                Log.Error("BllTEST_INFO->DataTableToList---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_INFO->DataTableToList---finally");
            }
			
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			try
            {
                Log.Info("BllTEST_INFO->GetModelList---START");
               	return GetList("");
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_INFO->GetModelList---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllTEST_INFO->GetModelList---finally");
            }
			
		}
#endregion

        #region 自定义函数
        /// <summary>
        /// 获得未开始的试验任务数据列表
        /// </summary>
        public DataSet GetListNoStart()
        {
            try
            {
                Log.Info("BllTEST_INFO->GetListNoStart---START");
                //读取试验状态F_TEST_STATUS=10：待试验；的试验任务信息
                return GetList("(F_TEST_STATUS=10) AND F_DEL=0 AND F_TEST_TASK_ID NOT IN (SELECT F_TEST_TASK_ID FROM T_TEST_INFO_NODISPLAY)");
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_INFO->GetListNoStart---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllTEST_INFO->GetListNoStart---finally");
            }

        }

        /// <summary>
        /// 获得未开始的试验任务数据列表
        /// </summary>
        public DataSet GetListNoStart_new()
        {
            try
            {
                Log.Info("BllTEST_INFO->GetListNoStart_new---START");
                //读取试验状态F_TEST_STATUS=10：待试验；的试验任务信息
                return GetList_new("");
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_INFO->GetListNoStart_new---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllTEST_INFO->GetListNoStart_new---finally");
            }

        }
        /// <summary>
        /// 获得t_test_info_nodisplay表的试验编号
        /// </summary>
        public DataSet GetListNoDisplay(string strwhere)
        {
            try
            {
                Log.Info("BllTEST_INFO->GetListNoDisplay---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetNoDisplayList(strwhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_INFO->GetListNoDisplay---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_INFO->GetListNoDisplay---finally");
            }
        }

        /// <summary>
        /// 获得可分配的最大试验编号
        /// preTaskId   试验任务编号前缀字符串
        /// </summary>
        public DataSet GetMaxTaskID(String preTaskId)
        {
            try
            {
                Log.Info("BllTEST_INFO->GetMaxTaskID---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetMaxTaskID(preTaskId);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_INFO->GetMaxTaskID---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllTEST_INFO->GetMaxTaskID---finally");
            }

        }
        /// <summary>
        /// 获得指定任务编号的记录数量
        /// tempTaskId   试验任务编号
        /// 返回值：0--没有改任务编号的记录；1--存在该任务编号的记录
        /// </summary>
        public DataSet GetTaskCount(String tempTaskId)
        {
            try
            {
                Log.Info("BllTEST_INFO->GetTaskCount---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetTaskCount(tempTaskId);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_INFO->GetTaskCount---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllTEST_INFO->GetTaskCount---finally");
            }
        }

        /// <summary>
        /// 获得指定任务编号的试验任务基本信息
        /// </summary>
        public DataSet GetListByTaskId(string strTaskId)
        {
            try
            {
                Log.Info("BllTEST_INFO->GetListByTaskId---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetListByTaskId(strTaskId);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_INFO->GetListByTaskId---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_INFO->GetListByTaskId---finally");
            }
        }

        /// <summary>
        /// 根据查询条件获得试验任务信息
        /// </summary>
        public DataSet GetTestTaskInfoByQueryCondition(string query_con)
        {
            try
            {
                Log.Info("BllTEST_INFO->GetTestTaskInfoByQueryCondition---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetTestTaskInfoByQueryCondition(query_con);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_INFO->GetTestTaskInfoByQueryCondition---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllTEST_INFO->GetTestTaskInfoByQueryCondition---finally");
            }
        }

        /// <summary>
        /// 根据查询条件获得试验设备状态信息
        /// </summary>
        public DataSet GetDevStatusInfoByQueryCondition(string query_con)
        {
            try
            {
                Log.Info("BllTEST_INFO->GetDevStatusInfoByQueryCondition---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                return dal.GetDevStatusInfoByQueryCondition(query_con);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_INFO->GetDevStatusInfoByQueryCondition---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllTEST_INFO->GetDevStatusInfoByQueryCondition---finally");
            }
        }


        /// <summary>
        /// 删除T_TEST_INFO_NODISPLAY表中的数据
        /// </summary>
        public void delete_noDisplay(string strWhere)
        {
            try
            {
                Log.Info("BllTEST_INFO->delete_noDisplay---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                dal.delete_noDisplay(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_INFO->delete_noDisplay---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_INFO->delete_noDisplay---finally");
            }
        }

        /// <summary>
        /// 增加一条T_TEST_INFO_NODISPLAY表的数据，不显示列表数据
        /// </summary>
        public void Add_noDisplay(string task_id)
        {

            try
            {
                Log.Info("BllTEST_INFO->Add_noDisplay---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                dal.Add_noDisplay(task_id);

            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_INFO->Add_noDisplay---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_INFO->Add---finally");
            }

        }
        #endregion

    }
}