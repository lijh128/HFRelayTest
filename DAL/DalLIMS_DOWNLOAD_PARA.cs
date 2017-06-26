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
	/// 数据访问类:DalLIMS_DOWNLOAD_PARA
	/// </summary>
    public partial class DalLIMS_DOWNLOAD_PARA : DbHelperOra
	{
		public DalLIMS_DOWNLOAD_PARA()
		{}
		#region  Method



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(RELAYTEST.Model.ModelLIMS_DOWNLOAD_PARA model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.RESULT_NUMBER != null)
			{
				strSql1.Append("RESULT_NUMBER,");
				strSql2.Append(""+model.RESULT_NUMBER+",");
			}
			if (model.委托单号 != null)
			{
				strSql1.Append("委托单号,");
				strSql2.Append("'"+model.委托单号+"',");
			}
			if (model.委托日期 != null)
			{
				strSql1.Append("委托日期,");
				strSql2.Append("to_date('" + model.委托日期.ToString() + "','YYYY-MM-DD HH24:MI:SS'),");
			}
			if (model.委托单位 != null)
			{
				strSql1.Append("委托单位,");
				strSql2.Append("'"+model.委托单位+"',");
			}
			if (model.联系人 != null)
			{
				strSql1.Append("联系人,");
				strSql2.Append("'"+model.联系人+"',");
			}
			if (model.电话 != null)
			{
				strSql1.Append("电话,");
				strSql2.Append(""+model.电话+",");
			}
			if (model.EMAIL != null)
			{
				strSql1.Append("EMAIL,");
				strSql2.Append("'"+model.EMAIL+"',");
			}
			if (model.检测性质 != null)
			{
				strSql1.Append("检测性质,");
				strSql2.Append("'"+model.检测性质+"',");
			}
			if (model.检测目的 != null)
			{
				strSql1.Append("检测目的,");
				strSql2.Append("'"+model.检测目的+"',");
			}
			if (model.产品大类 != null)
			{
				strSql1.Append("产品大类,");
				strSql2.Append("'"+model.产品大类+"',");
			}
			if (model.产品大类名称 != null)
			{
				strSql1.Append("产品大类名称,");
				strSql2.Append("'"+model.产品大类名称+"',");
			}
			if (model.二级分类 != null)
			{
				strSql1.Append("二级分类,");
				strSql2.Append("'"+model.二级分类+"',");
			}
			if (model.二级分类名称 != null)
			{
				strSql1.Append("二级分类名称,");
				strSql2.Append("'"+model.二级分类名称+"',");
			}
			if (model.三级分类 != null)
			{
				strSql1.Append("三级分类,");
				strSql2.Append("'"+model.三级分类+"',");
			}
			if (model.三级分类名称 != null)
			{
				strSql1.Append("三级分类名称,");
				strSql2.Append("'"+model.三级分类名称+"',");
			}
			if (model.任务编号 != null)
			{
				strSql1.Append("任务编号,");
				strSql2.Append("'"+model.任务编号+"',");
			}
			if (model.检测项目 != null)
			{
				strSql1.Append("检测项目,");
				strSql2.Append("'"+model.检测项目+"',");
			}
			if (model.检测标准 != null)
			{
				strSql1.Append("检测标准,");
				strSql2.Append("'"+model.检测标准+"',");
			}
			if (model.任务编号键值 != null)
			{
				strSql1.Append("任务编号键值,");
				strSql2.Append(""+model.任务编号键值+",");
			}
			if (model.条件参数 != null)
			{
				strSql1.Append("条件参数,");
				strSql2.Append("'"+model.条件参数+"',");
			}
			if (model.条件默认值 != null)
			{
				strSql1.Append("条件默认值,");
				strSql2.Append("'"+model.条件默认值+"',");
			}
			strSql.Append("insert into LIMS_DOWNLOAD_PARA(");
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
		public bool Update(RELAYTEST.Model.ModelLIMS_DOWNLOAD_PARA model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update LIMS_DOWNLOAD_PARA set ");
			if (model.RESULT_NUMBER != null)
			{
				strSql.Append("RESULT_NUMBER="+model.RESULT_NUMBER+",");
			}
			if (model.委托单号 != null)
			{
				strSql.Append("委托单号='"+model.委托单号+"',");
			}
			if (model.委托日期 != null)
			{
				strSql.Append("委托日期=to_date('" + model.委托日期.ToString() + "','YYYY-MM-DD HH24:MI:SS'),");
			}
			if (model.委托单位 != null)
			{
				strSql.Append("委托单位='"+model.委托单位+"',");
			}
			if (model.联系人 != null)
			{
				strSql.Append("联系人='"+model.联系人+"',");
			}
			if (model.电话 != null)
			{
				strSql.Append("电话="+model.电话+",");
			}
			if (model.EMAIL != null)
			{
				strSql.Append("EMAIL='"+model.EMAIL+"',");
			}
			if (model.检测性质 != null)
			{
				strSql.Append("检测性质='"+model.检测性质+"',");
			}
			if (model.检测目的 != null)
			{
				strSql.Append("检测目的='"+model.检测目的+"',");
			}
			if (model.产品大类 != null)
			{
				strSql.Append("产品大类='"+model.产品大类+"',");
			}
			if (model.产品大类名称 != null)
			{
				strSql.Append("产品大类名称='"+model.产品大类名称+"',");
			}
			if (model.二级分类 != null)
			{
				strSql.Append("二级分类='"+model.二级分类+"',");
			}
			if (model.二级分类名称 != null)
			{
				strSql.Append("二级分类名称='"+model.二级分类名称+"',");
			}
			if (model.三级分类 != null)
			{
				strSql.Append("三级分类='"+model.三级分类+"',");
			}
			if (model.三级分类名称 != null)
			{
				strSql.Append("三级分类名称='"+model.三级分类名称+"',");
			}
			if (model.任务编号 != null)
			{
				strSql.Append("任务编号='"+model.任务编号+"',");
			}
			if (model.检测项目 != null)
			{
				strSql.Append("检测项目='"+model.检测项目+"',");
			}
			if (model.检测标准 != null)
			{
				strSql.Append("检测标准='"+model.检测标准+"',");
			}
			if (model.任务编号键值 != null)
			{
				strSql.Append("任务编号键值="+model.任务编号键值+",");
			}
			if (model.条件参数 != null)
			{
				strSql.Append("条件参数='"+model.条件参数+"',");
			}
			if (model.条件默认值 != null)
			{
				strSql.Append("条件默认值='"+model.条件默认值+"',");
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
			strSql.Append("delete from LIMS_DOWNLOAD_PARA ");
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
		public RELAYTEST.Model.ModelLIMS_DOWNLOAD_PARA GetModel()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" RESULT_NUMBER,委托单号,委托日期,委托单位,联系人,电话,EMAIL,检测性质,检测目的,产品大类,产品大类名称,二级分类,二级分类名称,三级分类,三级分类名称,任务编号,检测项目,检测标准,任务编号键值,条件参数,条件默认值 ");
			strSql.Append(" from LIMS_DOWNLOAD_PARA ");
			strSql.Append(" where " );
			RELAYTEST.Model.ModelLIMS_DOWNLOAD_PARA model=new RELAYTEST.Model.ModelLIMS_DOWNLOAD_PARA();
			DataSet ds=Query(strSql.ToString());
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["RESULT_NUMBER"].ToString()!="")
				{
					model.RESULT_NUMBER=int.Parse(ds.Tables[0].Rows[0]["RESULT_NUMBER"].ToString());
				}
				model.委托单号=ds.Tables[0].Rows[0]["委托单号"].ToString();
				if(ds.Tables[0].Rows[0]["委托日期"].ToString()!="")
				{
					model.委托日期=DateTime.Parse(ds.Tables[0].Rows[0]["委托日期"].ToString());
				}
				model.委托单位=ds.Tables[0].Rows[0]["委托单位"].ToString();
				model.联系人=ds.Tables[0].Rows[0]["联系人"].ToString();
				if(ds.Tables[0].Rows[0]["电话"].ToString()!="")
				{
					model.电话=int.Parse(ds.Tables[0].Rows[0]["电话"].ToString());
				}
				model.EMAIL=ds.Tables[0].Rows[0]["EMAIL"].ToString();
				model.检测性质=ds.Tables[0].Rows[0]["检测性质"].ToString();
				model.检测目的=ds.Tables[0].Rows[0]["检测目的"].ToString();
				model.产品大类=ds.Tables[0].Rows[0]["产品大类"].ToString();
				model.产品大类名称=ds.Tables[0].Rows[0]["产品大类名称"].ToString();
				model.二级分类=ds.Tables[0].Rows[0]["二级分类"].ToString();
				model.二级分类名称=ds.Tables[0].Rows[0]["二级分类名称"].ToString();
				model.三级分类=ds.Tables[0].Rows[0]["三级分类"].ToString();
				model.三级分类名称=ds.Tables[0].Rows[0]["三级分类名称"].ToString();
				model.任务编号=ds.Tables[0].Rows[0]["任务编号"].ToString();
				model.检测项目=ds.Tables[0].Rows[0]["检测项目"].ToString();
				model.检测标准=ds.Tables[0].Rows[0]["检测标准"].ToString();
				if(ds.Tables[0].Rows[0]["任务编号键值"].ToString()!="")
				{
					model.任务编号键值=int.Parse(ds.Tables[0].Rows[0]["任务编号键值"].ToString());
				}
				model.条件参数=ds.Tables[0].Rows[0]["条件参数"].ToString();
				model.条件默认值=ds.Tables[0].Rows[0]["条件默认值"].ToString();
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
			strSql.Append("select 委托单号,委托日期,委托单位,联系人,电话,EMAIL,检测性质,检测目的,产品大类,产品大类名称,二级分类,二级分类名称,三级分类,三级分类名称,任务编号,检测标准,");
            strSql.Append(" (select 规格型号 from lims_download_sam where 任务号=lims_download_para.任务编号 and rownum=1) as 规格型号,负责人 ");
            strSql.Append(" FROM LIMS_DOWNLOAD_PARA ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return Query(strSql.ToString());
		}


        /// <summary>
        /// 获得Lims数据库中指定任务编号的触点类型数据
        /// </summary>
        public DataSet getContactTypeByTaskId(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select 条件默认值");
            strSql.Append(" FROM LIMS_DOWNLOAD_PARA ");
            strSql.Append(" where 条件参数='触点类型' ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere);
            }
            return Query(strSql.ToString());
        }

		/*
		*/

		#endregion  Method
	}
}

