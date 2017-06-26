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
	/// BllLIMS_DOWNLOAD_PARA
	/// </summary>
    public partial class BllLIMS_DOWNLOAD_PARA : DBBllBase
	{
        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(BllTEST_INFO));

		private readonly RELAYTEST.DAL.DalLIMS_DOWNLOAD_PARA dal=new RELAYTEST.DAL.DalLIMS_DOWNLOAD_PARA();
		public BllLIMS_DOWNLOAD_PARA()
		{}
		#region  Method

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(RELAYTEST.Model.ModelLIMS_DOWNLOAD_PARA model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(RELAYTEST.Model.ModelLIMS_DOWNLOAD_PARA model)
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
		public RELAYTEST.Model.ModelLIMS_DOWNLOAD_PARA GetModel()
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
		public List<RELAYTEST.Model.ModelLIMS_DOWNLOAD_PARA> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<RELAYTEST.Model.ModelLIMS_DOWNLOAD_PARA> DataTableToList(DataTable dt)
		{
			List<RELAYTEST.Model.ModelLIMS_DOWNLOAD_PARA> modelList = new List<RELAYTEST.Model.ModelLIMS_DOWNLOAD_PARA>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				RELAYTEST.Model.ModelLIMS_DOWNLOAD_PARA model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new RELAYTEST.Model.ModelLIMS_DOWNLOAD_PARA();
					if(dt.Rows[n]["RESULT_NUMBER"].ToString()!="")
					{
						model.RESULT_NUMBER=int.Parse(dt.Rows[n]["RESULT_NUMBER"].ToString());
					}
					model.委托单号=dt.Rows[n]["委托单号"].ToString();
					if(dt.Rows[n]["委托日期"].ToString()!="")
					{
						model.委托日期=DateTime.Parse(dt.Rows[n]["委托日期"].ToString());
					}
					model.委托单位=dt.Rows[n]["委托单位"].ToString();
					model.联系人=dt.Rows[n]["联系人"].ToString();
					if(dt.Rows[n]["电话"].ToString()!="")
					{
						model.电话=int.Parse(dt.Rows[n]["电话"].ToString());
					}
					model.EMAIL=dt.Rows[n]["EMAIL"].ToString();
					model.检测性质=dt.Rows[n]["检测性质"].ToString();
					model.检测目的=dt.Rows[n]["检测目的"].ToString();
					model.产品大类=dt.Rows[n]["产品大类"].ToString();
					model.产品大类名称=dt.Rows[n]["产品大类名称"].ToString();
					model.二级分类=dt.Rows[n]["二级分类"].ToString();
					model.二级分类名称=dt.Rows[n]["二级分类名称"].ToString();
					model.三级分类=dt.Rows[n]["三级分类"].ToString();
					model.三级分类名称=dt.Rows[n]["三级分类名称"].ToString();
					model.任务编号=dt.Rows[n]["任务编号"].ToString();
					model.检测项目=dt.Rows[n]["检测项目"].ToString();
					model.检测标准=dt.Rows[n]["检测标准"].ToString();
					if(dt.Rows[n]["任务编号键值"].ToString()!="")
					{
						model.任务编号键值=int.Parse(dt.Rows[n]["任务编号键值"].ToString());
					}
					model.条件参数=dt.Rows[n]["条件参数"].ToString();
					model.条件默认值=dt.Rows[n]["条件默认值"].ToString();
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
        /// 获得未读取的Lims试验任务信息
        /// </summary>
        public DataSet GetListFromLimsNoRead()
        {
            try
            {
                Log.Info("BllTEST_INFO->GetListFromLimsNoRead---START");

                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                string strWhere = "";
                strWhere = " 任务编号 not in (select f_test_task_id from t_test_info where f_del=0 ) ";
                strWhere = strWhere + " group by 委托单号,委托日期,委托单位,联系人,电话,EMAIL,检测性质,检测目的,产品大类,产品大类名称, ";
                strWhere = strWhere + " 二级分类,二级分类名称,三级分类,三级分类名称,任务编号,检测标准,负责人 ";
                strWhere = strWhere + " order by 委托日期,任务编号 ";
                return GetList(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_INFO->GetListFromLimsNoRead---FAILED", ex);
                throw ex;
            }
            finally
            {
                Log.Info("BllTEST_INFO->GetListFromLimsNoRead---finally");
            }

        }

        /// <summary>
        /// 获得Lims数据库中指定任务编号的试验任务基本信息
        /// </summary>
        public DataSet GetListByTaskId(string strTaskId)
        {
            try
            {
                Log.Info("BllTEST_INFO->GetListByTaskId---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                string strWhere = "";
                strWhere = " 任务编号 = '" + strTaskId+"'";
                strWhere = strWhere + " group by 委托单号,委托日期,委托单位,联系人,电话,EMAIL,检测性质,检测目的,产品大类,产品大类名称, ";
                strWhere = strWhere + " 二级分类,二级分类名称,三级分类,三级分类名称,任务编号,检测标准,负责人 ";
               
                return dal.GetList(strWhere);
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
        /// 获得Lims数据库中指定任务编号的触点类型数据
        /// </summary>
        public DataSet getContactTypeByTaskId(string strTaskId)
        {
            try
            {
                Log.Info("BllTEST_INFO->getContactTypeByTaskId---START");
                ConnectionOpen();
                dal.SetDBAccess(GetDBAccess());
                string strWhere = "";
                strWhere = " 任务编号 = '" + strTaskId + "'";

                return dal.getContactTypeByTaskId(strWhere);
            }
            catch (Exception ex)
            {
                Log.Error("BllTEST_INFO->getContactTypeByTaskId---FAILED", ex);
                throw ex;
            }
            finally
            {
                ConnectionClose();
                Log.Info("BllTEST_INFO->getContactTypeByTaskId---finally");
            }

        }

        #endregion
    }
}

