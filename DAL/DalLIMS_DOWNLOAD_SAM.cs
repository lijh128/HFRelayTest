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
	/// ���ݷ�����:DalLIMS_DOWNLOAD_SAM
	/// </summary>
    public partial class DalLIMS_DOWNLOAD_SAM : DbHelperOra
	{
        //Log������
        //��־����
        private static readonly ILog Log = LogManager.GetLogger(typeof(DalLIMS_DOWNLOAD_SAM));

		public DalLIMS_DOWNLOAD_SAM()
		{}
		#region  Method



		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(RELAYTEST.Model.ModelLIMS_DOWNLOAD_SAM model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.��Ʒ�� != null)
			{
				strSql1.Append("��Ʒ��,");
				strSql2.Append(""+model.��Ʒ��+",");
			}
			if (model.��� != null)
			{
				strSql1.Append("���,");
				strSql2.Append("'"+model.���+"',");
			}
			if (model.����� != null)
			{
				strSql1.Append("�����,");
				strSql2.Append("'"+model.�����+"',");
			}
			if (model.���� != null)
			{
				strSql1.Append("����,");
				strSql2.Append(""+model.����+",");
			}
			if (model.�ų̺� != null)
			{
				strSql1.Append("�ų̺�,");
				strSql2.Append(""+model.�ų̺�+",");
			}
			if (model.�������� != null)
			{
				strSql1.Append("��������,");
				strSql2.Append("'"+model.��������+"',");
			}
			if (model.�ų̿�ʼʱ�� != null)
			{
				strSql1.Append("�ų̿�ʼʱ��,");
				strSql2.Append("to_date('" + model.�ų̿�ʼʱ��.ToString() + "','YYYY-MM-DD HH24:MI:SS'),");
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
		/// ����һ������
		/// </summary>
		public bool Update(RELAYTEST.Model.ModelLIMS_DOWNLOAD_SAM model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update LIMS_DOWNLOAD_SAM set ");
			if (model.��Ʒ�� != null)
			{
				strSql.Append("��Ʒ��="+model.��Ʒ��+",");
			}
			if (model.��� != null)
			{
				strSql.Append("���='"+model.���+"',");
			}
			if (model.����� != null)
			{
				strSql.Append("�����='"+model.�����+"',");
			}
			if (model.���� != null)
			{
				strSql.Append("����="+model.����+",");
			}
			if (model.�ų̺� != null)
			{
				strSql.Append("�ų̺�="+model.�ų̺�+",");
			}
			if (model.�������� != null)
			{
				strSql.Append("��������='"+model.��������+"',");
			}
			if (model.�ų̿�ʼʱ�� != null)
			{
				strSql.Append("�ų̿�ʼʱ��=to_date('" + model.�ų̿�ʼʱ��.ToString() + "','YYYY-MM-DD HH24:MI:SS'),");
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
		/// ɾ��һ������
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
		/// �õ�һ������ʵ��
		/// </summary>
		public RELAYTEST.Model.ModelLIMS_DOWNLOAD_SAM GetModel()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" ��Ʒ��,���,�����,����,�ų̺�,��������,�ų̿�ʼʱ�� ");
			strSql.Append(" from LIMS_DOWNLOAD_SAM ");
			strSql.Append(" where " );
			RELAYTEST.Model.ModelLIMS_DOWNLOAD_SAM model=new RELAYTEST.Model.ModelLIMS_DOWNLOAD_SAM();
			DataSet ds=Query(strSql.ToString());
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["��Ʒ��"].ToString()!="")
				{
					model.��Ʒ��=int.Parse(ds.Tables[0].Rows[0]["��Ʒ��"].ToString());
				}
				model.���=ds.Tables[0].Rows[0]["���"].ToString();
				model.�����=ds.Tables[0].Rows[0]["�����"].ToString();
				if(ds.Tables[0].Rows[0]["����"].ToString()!="")
				{
					model.����=int.Parse(ds.Tables[0].Rows[0]["����"].ToString());
				}
				if(ds.Tables[0].Rows[0]["�ų̺�"].ToString()!="")
				{
					model.�ų̺�=int.Parse(ds.Tables[0].Rows[0]["�ų̺�"].ToString());
				}
				model.��������=ds.Tables[0].Rows[0]["��������"].ToString();
				if(ds.Tables[0].Rows[0]["�ų̿�ʼʱ��"].ToString()!="")
				{
					model.�ų̿�ʼʱ��=DateTime.Parse(ds.Tables[0].Rows[0]["�ų̿�ʼʱ��"].ToString());
				}
				return model;
			}
			else
			{
				return null;
			}
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ��Ʒ��,���,�����,����,�ų̺�,��������,�ų̿�ʼʱ�� ");
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

        #region �Զ��庯��
        /// <summary>
        /// ���������Ż��������Ʒ����
        /// </summary>
        public DataSet GetListByTaskId(string strTaskId)
        {


            try
            {
                Log.Info("DalLIMS_DOWNLOAD_SAM->GetListByTaskId---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select �����,���,count(*) as ���� ");
                strSql.Append(" FROM LIMS_DOWNload_SAM  where �����='" + strTaskId + "' ");
                strSql.Append(" group by �����,���  ");

                return Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                Log.Error("DalLIMS_DOWNLOAD_SAM->GetListByTaskId---FAILED", ex);
                throw ex;
            }

        }

        /// <summary>
        /// ���������ţ���Ʒ��Ż�ȡ��Ʒ��Ϣ
        /// </summary>
        public DataSet GetLimsSampleInfo(string strTaskId)
        {


            try
            {
                Log.Info("DalLIMS_DOWNLOAD_SAM->GetLimsSampleInfo---START");
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select ��Ʒ���,�����,��Ʒ��,����,�ų̺�,������ֵ, ");
                strSql.Append("(select f_load_id from t_dev_load_to_sub where f_subordinate_id=������ֵ) as ���ع���, ");
                strSql.Append("λ�ñ��,��������,to_char(�ų̿�ʼʱ��,'yyyy-MM-dd hh:mm:ss') as �ų̿�ʼʱ��,���,��Ʒϵ��,����ͺ� from ");
                strSql.Append(" lims_download_sam ");
                strSql.Append(" where �����='" + strTaskId + "' ");
                strSql.Append(" order by ��Ʒ��  ");

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

