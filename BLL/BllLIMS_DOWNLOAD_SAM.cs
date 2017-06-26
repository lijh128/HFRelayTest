using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using RelayTest.Util.DBUtility;
using RelayTest.Model;
using log4net;
namespace RelayTest.BLL
{
	/// <summary>
	/// BllLIMS_DOWNLOAD_SAM
	/// </summary>
    public partial class BllLIMS_DOWNLOAD_SAM : DBBllBase
	{
        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllTEST_SAMPLE_INFO));

		private readonly RELAYTEST.DAL.DalLIMS_DOWNLOAD_SAM dal=new RELAYTEST.DAL.DalLIMS_DOWNLOAD_SAM();
		public BllLIMS_DOWNLOAD_SAM()
		{}
		#region  Method

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(RELAYTEST.Model.ModelLIMS_DOWNLOAD_SAM model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(RELAYTEST.Model.ModelLIMS_DOWNLOAD_SAM model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.Delete();
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RELAYTEST.Model.ModelLIMS_DOWNLOAD_SAM GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.GetModel();
		}

		

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RELAYTEST.Model.ModelLIMS_DOWNLOAD_SAM> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RELAYTEST.Model.ModelLIMS_DOWNLOAD_SAM> DataTableToList(DataTable dt)
		{
			List<RELAYTEST.Model.ModelLIMS_DOWNLOAD_SAM> modelList = new List<RELAYTEST.Model.ModelLIMS_DOWNLOAD_SAM>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				RELAYTEST.Model.ModelLIMS_DOWNLOAD_SAM model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new RELAYTEST.Model.ModelLIMS_DOWNLOAD_SAM();
					if(dt.Rows[n]["样品号"].ToString()!="")
					{
						model.样品号=int.Parse(dt.Rows[n]["样品号"].ToString());
					}
					model.组别=dt.Rows[n]["组别"].ToString();
					model.任务号=dt.Rows[n]["任务号"].ToString();
					if(dt.Rows[n]["检测号"].ToString()!="")
					{
						model.检测号=int.Parse(dt.Rows[n]["检测号"].ToString());
					}
					if(dt.Rows[n]["排程号"].ToString()!="")
					{
						model.排程号=int.Parse(dt.Rows[n]["排程号"].ToString());
					}
					model.分析名称=dt.Rows[n]["分析名称"].ToString();
					if(dt.Rows[n]["排程开始时间"].ToString()!="")
					{
						model.排程开始时间=DateTime.Parse(dt.Rows[n]["排程开始时间"].ToString());
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method

        #region 自定义函数
        /// <summary>
        /// 根据任务编号，返回相应任务编号的LIMS数据库中的样品信息到detailTable中
        /// </summary>
        public DataTable GetAndDisplaySampleInfo(DataTable detailTable, string strTaskId)
        {
            try
            {
                Log.Info("BllLIMS_DOWNLOAD_SAM->GetAndDisplaySampleInfo---START");
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
                            detailTable.Rows[i]["F_TEST_TASK_ID"] = dataRow["任务号"].ToString();
                            detailTable.Rows[i]["F_SAMPLE_NUM"] = dataRow["数量"].ToString();
                            detailTable.Rows[i]["F_SAMPLE_GROUP_NUM"] = dataRow["组别"].ToString();
                            //detailTable.Rows[i]["F_SAMPLE_MEMO"] = dataRow["F_SAMPLE_MEMO"].ToString();
                            detailTable.Rows[i]["F_SAMPLE_MEMO"] = "";
                        }
                    }
                }

                return detailTable;
            }
            catch (Exception ex)
            {
                Log.Error("BllLIMS_DOWNLOAD_SAM->GetAndDisplaySampleInfo---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllLIMS_DOWNLOAD_SAM->GetAndDisplaySampleInfo---finally");
            }
        }

        /// <summary>
        /// 根据任务编号，样品序号获取样品信息
        /// </summary>
        public DataSet GetLimsSampleInfo(string strTaskId)
        {
            try
            {
                Log.Info("BllLIMS_DOWNLOAD_SAM->GetLimsSampleInfo---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                DataSet dataSetSampleInfo = dal.GetLimsSampleInfo(strTaskId);

                return dataSetSampleInfo;
            }
            catch (Exception ex)
            {
                Log.Error("BllLIMS_DOWNLOAD_SAM->GetLimsSampleInfo---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllLIMS_DOWNLOAD_SAM->GetLimsSampleInfo---finally");
            }
        }
#endregion

    }
}

