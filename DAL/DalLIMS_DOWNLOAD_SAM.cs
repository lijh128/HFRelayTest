using System;
using System.Data.OracleClient;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using RelayTest.Util.DBUtility;
using log4net;
namespace RELAYTEST.DAL
{
	/// <summary>
	/// 数据访问类:DalLIMS_DOWNLOAD_SAM
	/// </summary>
    public partial class DalLIMS_DOWNLOAD_SAM : DbHelperOra
	{
        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalLIMS_DOWNLOAD_SAM));

		public DalLIMS_DOWNLOAD_SAM()
		{}
		#region  Method



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(RELAYTEST.Model.ModelLIMS_DOWNLOAD_SAM model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.样品号 != null)
			{
				strSql1.Append("样品号,");
				strSql2.Append(""+model.样品号+",");
			}
			if (model.组别 != null)
			{
				strSql1.Append("组别,");
				strSql2.Append("'"+model.组别+"',");
			}
			if (model.任务号 != null)
			{
				strSql1.Append("任务号,");
				strSql2.Append("'"+model.任务号+"',");
			}
			if (model.检测号 != null)
			{
				strSql1.Append("检测号,");
				strSql2.Append(""+model.检测号+",");
			}
			if (model.排程号 != null)
			{
				strSql1.Append("排程号,");
				strSql2.Append(""+model.排程号+",");
			}
			if (model.分析名称 != null)
			{
				strSql1.Append("分析名称,");
				strSql2.Append("'"+model.分析名称+"',");
			}
			if (model.排程开始时间 != null)
			{
				strSql1.Append("排程开始时间,");
				strSql2.Append("to_date('" + model.排程开始时间.ToString() + "','YYYY-MM-DD HH24:MI:SS'),");
			}
			strSql.Append("insert into LIMS_DOWNLOAD_SAM(");
			strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
			strSql.Append(")");
			ExecuteSql(strSql.ToString());
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(RELAYTEST.Model.ModelLIMS_DOWNLOAD_SAM model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update LIMS_DOWNLOAD_SAM set ");
			if (model.样品号 != null)
			{
				strSql.Append("样品号="+model.样品号+",");
			}
			if (model.组别 != null)
			{
				strSql.Append("组别='"+model.组别+"',");
			}
			if (model.任务号 != null)
			{
				strSql.Append("任务号='"+model.任务号+"',");
			}
			if (model.检测号 != null)
			{
				strSql.Append("检测号="+model.检测号+",");
			}
			if (model.排程号 != null)
			{
				strSql.Append("排程号="+model.排程号+",");
			}
			if (model.分析名称 != null)
			{
				strSql.Append("分析名称='"+model.分析名称+"',");
			}
			if (model.排程开始时间 != null)
			{
				strSql.Append("排程开始时间=to_date('" + model.排程开始时间.ToString() + "','YYYY-MM-DD HH24:MI:SS'),");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where ");
			int rowsAffected=ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from LIMS_DOWNLOAD_SAM ");
			strSql.Append(" where " );
			int rowsAffected=ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public RELAYTEST.Model.ModelLIMS_DOWNLOAD_SAM GetModel()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" 样品号,组别,任务号,检测号,排程号,分析名称,排程开始时间 ");
			strSql.Append(" from LIMS_DOWNLOAD_SAM ");
			strSql.Append(" where " );
			RELAYTEST.Model.ModelLIMS_DOWNLOAD_SAM model=new RELAYTEST.Model.ModelLIMS_DOWNLOAD_SAM();
			DataSet ds=Query(strSql.ToString());
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["样品号"].ToString()!="")
				{
					model.样品号=int.Parse(ds.Tables[0].Rows[0]["样品号"].ToString());
				}
				model.组别=ds.Tables[0].Rows[0]["组别"].ToString();
				model.任务号=ds.Tables[0].Rows[0]["任务号"].ToString();
				if(ds.Tables[0].Rows[0]["检测号"].ToString()!="")
				{
					model.检测号=int.Parse(ds.Tables[0].Rows[0]["检测号"].ToString());
				}
				if(ds.Tables[0].Rows[0]["排程号"].ToString()!="")
				{
					model.排程号=int.Parse(ds.Tables[0].Rows[0]["排程号"].ToString());
				}
				model.分析名称=ds.Tables[0].Rows[0]["分析名称"].ToString();
				if(ds.Tables[0].Rows[0]["排程开始时间"].ToString()!="")
				{
					model.排程开始时间=DateTime.Parse(ds.Tables[0].Rows[0]["排程开始时间"].ToString());
				}
				return model;
			}
			else
			{
				return null;
			}
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select 样品号,组别,任务号,检测号,排程号,分析名称,排程开始时间 ");
			strSql.Append(" FROM LIMS_DOWNLOAD_SAM ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return Query(strSql.ToString());
		}

		/*
		*/

		#endregion  Method

        #region 自定义函数
        /// <summary>
        /// 根据任务编号获得试验样品数据
        /// </summary>
        public DataSet GetListByTaskId(string strTaskId)
        {


            try
            {
                Log.Info("DalLIMS_DOWNLOAD_SAM->GetListByTaskId---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select 任务号,组别,count(*) as 数量 ");
                strSql.Append(" FROM LIMS_DOWNload_SAM  where 任务号='" + strTaskId + "' ");
                strSql.Append(" group by 任务号,组别  ");

                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalLIMS_DOWNLOAD_SAM->GetListByTaskId---FAILED", ex);
                throw ex;
            }

        }

        /// <summary>
        /// 根据任务编号，样品序号获取样品信息
        /// </summary>
        public DataSet GetLimsSampleInfo(string strTaskId)
        {


            try
            {
                Log.Info("DalLIMS_DOWNLOAD_SAM->GetLimsSampleInfo---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select 样品编号,任务号,样品号,检测号,排程号,仪器键值, ");
                strSql.Append("(select f_load_id from t_dev_load_to_sub where f_subordinate_id=仪器键值) as 负载柜编号, ");
                strSql.Append("位置编号,分析名称,to_char(排程开始时间,'yyyy-MM-dd hh:mm:ss') as 排程开始时间,组别,产品系列,规格型号 from ");
                strSql.Append(" lims_download_sam ");
                strSql.Append(" where 任务号='" + strTaskId + "' ");
                strSql.Append(" order by 样品号  ");

                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalLIMS_DOWNLOAD_SAM->GetLimsSampleInfo---FAILED", ex);
                throw ex;
            }

        }
        #endregion
    }
}

