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
	/// ���ݷ�����:DalLIMS_DOWNLOAD_PARA
	/// </summary>
    public partial class DalLIMS_DOWNLOAD_PARA : DbHelperOra
	{
		public DalLIMS_DOWNLOAD_PARA()
		{}
		#region  Method



		/// <summary>
		/// ����һ������
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
			if (model.ί�е��� != null)
			{
				strSql1.Append("ί�е���,");
				strSql2.Append("'"+model.ί�е���+"',");
			}
			if (model.ί������ != null)
			{
				strSql1.Append("ί������,");
				strSql2.Append("to_date('" + model.ί������.ToString() + "','YYYY-MM-DD HH24:MI:SS'),");
			}
			if (model.ί�е�λ != null)
			{
				strSql1.Append("ί�е�λ,");
				strSql2.Append("'"+model.ί�е�λ+"',");
			}
			if (model.��ϵ�� != null)
			{
				strSql1.Append("��ϵ��,");
				strSql2.Append("'"+model.��ϵ��+"',");
			}
			if (model.�绰 != null)
			{
				strSql1.Append("�绰,");
				strSql2.Append(""+model.�绰+",");
			}
			if (model.EMAIL != null)
			{
				strSql1.Append("EMAIL,");
				strSql2.Append("'"+model.EMAIL+"',");
			}
			if (model.������� != null)
			{
				strSql1.Append("�������,");
				strSql2.Append("'"+model.�������+"',");
			}
			if (model.���Ŀ�� != null)
			{
				strSql1.Append("���Ŀ��,");
				strSql2.Append("'"+model.���Ŀ��+"',");
			}
			if (model.��Ʒ���� != null)
			{
				strSql1.Append("��Ʒ����,");
				strSql2.Append("'"+model.��Ʒ����+"',");
			}
			if (model.��Ʒ�������� != null)
			{
				strSql1.Append("��Ʒ��������,");
				strSql2.Append("'"+model.��Ʒ��������+"',");
			}
			if (model.�������� != null)
			{
				strSql1.Append("��������,");
				strSql2.Append("'"+model.��������+"',");
			}
			if (model.������������ != null)
			{
				strSql1.Append("������������,");
				strSql2.Append("'"+model.������������+"',");
			}
			if (model.�������� != null)
			{
				strSql1.Append("��������,");
				strSql2.Append("'"+model.��������+"',");
			}
			if (model.������������ != null)
			{
				strSql1.Append("������������,");
				strSql2.Append("'"+model.������������+"',");
			}
			if (model.������ != null)
			{
				strSql1.Append("������,");
				strSql2.Append("'"+model.������+"',");
			}
			if (model.�����Ŀ != null)
			{
				strSql1.Append("�����Ŀ,");
				strSql2.Append("'"+model.�����Ŀ+"',");
			}
			if (model.����׼ != null)
			{
				strSql1.Append("����׼,");
				strSql2.Append("'"+model.����׼+"',");
			}
			if (model.�����ż�ֵ != null)
			{
				strSql1.Append("�����ż�ֵ,");
				strSql2.Append(""+model.�����ż�ֵ+",");
			}
			if (model.�������� != null)
			{
				strSql1.Append("��������,");
				strSql2.Append("'"+model.��������+"',");
			}
			if (model.����Ĭ��ֵ != null)
			{
				strSql1.Append("����Ĭ��ֵ,");
				strSql2.Append("'"+model.����Ĭ��ֵ+"',");
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
		/// ����һ������
		/// </summary>
		public bool Update(RELAYTEST.Model.ModelLIMS_DOWNLOAD_PARA model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update LIMS_DOWNLOAD_PARA set ");
			if (model.RESULT_NUMBER != null)
			{
				strSql.Append("RESULT_NUMBER="+model.RESULT_NUMBER+",");
			}
			if (model.ί�е��� != null)
			{
				strSql.Append("ί�е���='"+model.ί�е���+"',");
			}
			if (model.ί������ != null)
			{
				strSql.Append("ί������=to_date('" + model.ί������.ToString() + "','YYYY-MM-DD HH24:MI:SS'),");
			}
			if (model.ί�е�λ != null)
			{
				strSql.Append("ί�е�λ='"+model.ί�е�λ+"',");
			}
			if (model.��ϵ�� != null)
			{
				strSql.Append("��ϵ��='"+model.��ϵ��+"',");
			}
			if (model.�绰 != null)
			{
				strSql.Append("�绰="+model.�绰+",");
			}
			if (model.EMAIL != null)
			{
				strSql.Append("EMAIL='"+model.EMAIL+"',");
			}
			if (model.������� != null)
			{
				strSql.Append("�������='"+model.�������+"',");
			}
			if (model.���Ŀ�� != null)
			{
				strSql.Append("���Ŀ��='"+model.���Ŀ��+"',");
			}
			if (model.��Ʒ���� != null)
			{
				strSql.Append("��Ʒ����='"+model.��Ʒ����+"',");
			}
			if (model.��Ʒ�������� != null)
			{
				strSql.Append("��Ʒ��������='"+model.��Ʒ��������+"',");
			}
			if (model.�������� != null)
			{
				strSql.Append("��������='"+model.��������+"',");
			}
			if (model.������������ != null)
			{
				strSql.Append("������������='"+model.������������+"',");
			}
			if (model.�������� != null)
			{
				strSql.Append("��������='"+model.��������+"',");
			}
			if (model.������������ != null)
			{
				strSql.Append("������������='"+model.������������+"',");
			}
			if (model.������ != null)
			{
				strSql.Append("������='"+model.������+"',");
			}
			if (model.�����Ŀ != null)
			{
				strSql.Append("�����Ŀ='"+model.�����Ŀ+"',");
			}
			if (model.����׼ != null)
			{
				strSql.Append("����׼='"+model.����׼+"',");
			}
			if (model.�����ż�ֵ != null)
			{
				strSql.Append("�����ż�ֵ="+model.�����ż�ֵ+",");
			}
			if (model.�������� != null)
			{
				strSql.Append("��������='"+model.��������+"',");
			}
			if (model.����Ĭ��ֵ != null)
			{
				strSql.Append("����Ĭ��ֵ='"+model.����Ĭ��ֵ+"',");
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
		/// �õ�һ������ʵ��
		/// </summary>
		public RELAYTEST.Model.ModelLIMS_DOWNLOAD_PARA GetModel()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" RESULT_NUMBER,ί�е���,ί������,ί�е�λ,��ϵ��,�绰,EMAIL,�������,���Ŀ��,��Ʒ����,��Ʒ��������,��������,������������,��������,������������,������,�����Ŀ,����׼,�����ż�ֵ,��������,����Ĭ��ֵ ");
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
				model.ί�е���=ds.Tables[0].Rows[0]["ί�е���"].ToString();
				if(ds.Tables[0].Rows[0]["ί������"].ToString()!="")
				{
					model.ί������=DateTime.Parse(ds.Tables[0].Rows[0]["ί������"].ToString());
				}
				model.ί�е�λ=ds.Tables[0].Rows[0]["ί�е�λ"].ToString();
				model.��ϵ��=ds.Tables[0].Rows[0]["��ϵ��"].ToString();
				if(ds.Tables[0].Rows[0]["�绰"].ToString()!="")
				{
					model.�绰=int.Parse(ds.Tables[0].Rows[0]["�绰"].ToString());
				}
				model.EMAIL=ds.Tables[0].Rows[0]["EMAIL"].ToString();
				model.�������=ds.Tables[0].Rows[0]["�������"].ToString();
				model.���Ŀ��=ds.Tables[0].Rows[0]["���Ŀ��"].ToString();
				model.��Ʒ����=ds.Tables[0].Rows[0]["��Ʒ����"].ToString();
				model.��Ʒ��������=ds.Tables[0].Rows[0]["��Ʒ��������"].ToString();
				model.��������=ds.Tables[0].Rows[0]["��������"].ToString();
				model.������������=ds.Tables[0].Rows[0]["������������"].ToString();
				model.��������=ds.Tables[0].Rows[0]["��������"].ToString();
				model.������������=ds.Tables[0].Rows[0]["������������"].ToString();
				model.������=ds.Tables[0].Rows[0]["������"].ToString();
				model.�����Ŀ=ds.Tables[0].Rows[0]["�����Ŀ"].ToString();
				model.����׼=ds.Tables[0].Rows[0]["����׼"].ToString();
				if(ds.Tables[0].Rows[0]["�����ż�ֵ"].ToString()!="")
				{
					model.�����ż�ֵ=int.Parse(ds.Tables[0].Rows[0]["�����ż�ֵ"].ToString());
				}
				model.��������=ds.Tables[0].Rows[0]["��������"].ToString();
				model.����Ĭ��ֵ=ds.Tables[0].Rows[0]["����Ĭ��ֵ"].ToString();
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
			strSql.Append("select ί�е���,ί������,ί�е�λ,��ϵ��,�绰,EMAIL,�������,���Ŀ��,��Ʒ����,��Ʒ��������,��������,������������,��������,������������,������,����׼,");
            strSql.Append(" (select ����ͺ� from lims_download_sam where �����=lims_download_para.������ and rownum=1) as ����ͺ�,������ ");
            strSql.Append(" FROM LIMS_DOWNLOAD_PARA ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return Query(strSql.ToString());
		}


        /// <summary>
        /// ���Lims���ݿ���ָ�������ŵĴ�����������
        /// </summary>
        public DataSet getContactTypeByTaskId(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ����Ĭ��ֵ");
            strSql.Append(" FROM LIMS_DOWNLOAD_PARA ");
            strSql.Append(" where ��������='��������' ");
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

