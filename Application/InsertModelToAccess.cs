/********************************************************************************
** 作者    ：刘
** 创始时间：2015-07-20
** 描述    ：向Access文件中插入相关数据
** 履历    ：No.         日期           修改人                 描述
*********************************************************************************/
using System;
using System.Data;
using System.Data.OleDb;
using log4net;
using RelayTest.Model;
using RelayTest.Util.DBUtility;

namespace RelayTest.Application
{
    public class InsertModelToAccess
    {
        public int InsertTestBaseInfo(DataSet dsTestInfo,string now_taskId)
        {
            int intResult = 0;
            AccessDBClass myAccessdb = new AccessDBClass("DataFile/" + now_taskId + ".mdb");             
            if (dsTestInfo != null)
            {
                ModelTEST_INFO mdlTestBaseInfo = new ModelTEST_INFO();
                //试验任务编号
                mdlTestBaseInfo.F_TEST_TASK_ID = dsTestInfo.Tables[0].Rows[0]["F_TEST_TASK_ID"].ToString();
                //检测项目
                mdlTestBaseInfo.F_TEST_ITEM = dsTestInfo.Tables[0].Rows[0]["F_TEST_ITEM"].ToString();
                //规格型号
                mdlTestBaseInfo.F_TEST_MODEL = dsTestInfo.Tables[0].Rows[0]["F_TEST_MODEL"].ToString();
                //检测标准
                mdlTestBaseInfo.F_TEST_STANDARD = dsTestInfo.Tables[0].Rows[0]["F_TEST_STANDARD"].ToString();
                //检测性质
                mdlTestBaseInfo.F_TEST_PROPERTY = dsTestInfo.Tables[0].Rows[0]["F_TEST_PROPERTY"].ToString();
                //检测目的
                mdlTestBaseInfo.F_TEST_AIM = dsTestInfo.Tables[0].Rows[0]["F_TEST_AIM"].ToString();
                //委托单位
                mdlTestBaseInfo.F_TASK_DEPUTE_UNIT = dsTestInfo.Tables[0].Rows[0]["F_TASK_DEPUTE_UNIT"].ToString();
                //联系人
                mdlTestBaseInfo.F_CONTACT = dsTestInfo.Tables[0].Rows[0]["F_CONTACT"].ToString();
                //电话
                mdlTestBaseInfo.F_PHONE = dsTestInfo.Tables[0].Rows[0]["F_PHONE"].ToString();
                //email
                mdlTestBaseInfo.F_EMAIL = dsTestInfo.Tables[0].Rows[0]["F_EMAIL"].ToString();
                //负责人
                mdlTestBaseInfo.F_TEST_CHARGE = dsTestInfo.Tables[0].Rows[0]["F_TEST_CHARGE"].ToString();
                //委托日期
                mdlTestBaseInfo.F_TASK_DEPUTE_DATE = Convert.ToDateTime(dsTestInfo.Tables[0].Rows[0]["F_TASK_DEPUTE_DATE"].ToString());
                //样品系列
                //mdlTestBaseInfo.F_TEST_SERIES = dsTestInfo.Tables[0].Rows[0]["F_TEST_SERIES"].ToString();
                mdlTestBaseInfo.F_TEST_SERIES = " ";
                //样品类别
                //mdlTestBaseInfo.F_SAMPLE_TYPE = dsTestInfo.Tables[0].Rows[0]["F_SAMPLE_TYPE"].ToString();
                mdlTestBaseInfo.F_SAMPLE_TYPE = " ";
                //序列试验
                mdlTestBaseInfo.F_SEQUENCE_TEST = Convert.ToInt16(dsTestInfo.Tables[0].Rows[0]["F_SEQUENCE_TEST"].ToString());
                //试验状态
                mdlTestBaseInfo.F_TEST_STATUS = Convert.ToInt16(dsTestInfo.Tables[0].Rows[0]["F_TEST_STATUS"].ToString());
                //创建时间
                mdlTestBaseInfo.F_CREATE_TIME = Convert.ToDateTime(dsTestInfo.Tables[0].Rows[0]["F_CREATE_TIME"].ToString());
                //操作员
                mdlTestBaseInfo.F_OPERATOR_ID = dsTestInfo.Tables[0].Rows[0]["F_OPERATOR_ID"].ToString();
                //操作时间
                mdlTestBaseInfo.F_OPERATIONTIME = Convert.ToDateTime(dsTestInfo.Tables[0].Rows[0]["F_OPERATIONTIME"].ToString());
                //是否删除
                mdlTestBaseInfo.F_DEL = Convert.ToInt16(dsTestInfo.Tables[0].Rows[0]["F_DEL"].ToString());

                string strSql = "insert into T_TEST_INFO(F_TEST_TASK_ID,F_TEST_ITEM,F_TEST_MODEL";
                strSql = strSql+",F_TEST_STANDARD,F_TEST_PROPERTY,F_TEST_AIM";
                strSql = strSql + ",F_TASK_DEPUTE_UNIT,F_CONTACT,F_PHONE";
                strSql = strSql + ",F_EMAIL,F_TEST_CHARGE,F_TASK_DEPUTE_DATE";
                strSql = strSql + ",F_TEST_SERIES,F_SAMPLE_TYPE,F_SEQUENCE_TEST";
                strSql = strSql + ",F_TEST_STATUS,F_CREATE_TIME,F_OPERATOR_ID";
                strSql = strSql + ",F_OPERATIONTIME,F_DEL)";
                strSql = strSql + " values(@F_TEST_TASK_ID,@F_TEST_ITEM,@F_TEST_MODEL  ";
                strSql = strSql + ",@F_TEST_STANDARD,@F_TEST_PROPERTY,@F_TEST_AIM";
                strSql = strSql + ",@F_TASK_DEPUTE_UNIT,@F_CONTACT,@F_PHONE";
                strSql = strSql + ",@F_EMAIL,@F_TEST_CHARGE,@F_TASK_DEPUTE_DATE";
                strSql = strSql + ",@F_TEST_SERIES,@F_SAMPLE_TYPE,@F_SEQUENCE_TEST";
                strSql = strSql + ",@F_TEST_STATUS,@F_CREATE_TIME,@F_OPERATOR_ID";
                strSql = strSql + ",@F_OPERATIONTIME,@F_DEL)";

                OleDbParameter[] prams = {
                                             new OleDbParameter("@F_TEST_TASK_ID", mdlTestBaseInfo.F_TEST_TASK_ID),
                                             new OleDbParameter("@F_TEST_ITEM", mdlTestBaseInfo.F_TEST_ITEM),
                                             new OleDbParameter("@F_TEST_MODEL", mdlTestBaseInfo.F_TEST_MODEL),
                                             new OleDbParameter("@F_TEST_STANDARD", mdlTestBaseInfo.F_TEST_STANDARD),
                                             new OleDbParameter("@F_TEST_PROPERTY", mdlTestBaseInfo.F_TEST_PROPERTY),
                                             new OleDbParameter("@F_TEST_AIM", mdlTestBaseInfo.F_TEST_AIM),
                                             new OleDbParameter("@F_TASK_DEPUTE_UNIT", mdlTestBaseInfo.F_TASK_DEPUTE_UNIT),
                                             new OleDbParameter("@F_CONTACT", mdlTestBaseInfo.F_CONTACT),
                                             new OleDbParameter("@F_PHONE", mdlTestBaseInfo.F_PHONE),
                                             new OleDbParameter("@F_EMAIL", mdlTestBaseInfo.F_EMAIL),
                                             new OleDbParameter("@F_TEST_CHARGE", mdlTestBaseInfo.F_TEST_CHARGE),
                                             new OleDbParameter("@F_TASK_DEPUTE_DATE", mdlTestBaseInfo.F_TASK_DEPUTE_DATE),
                                             new OleDbParameter("@F_TEST_SERIES", mdlTestBaseInfo.F_TEST_SERIES),
                                             new OleDbParameter("@F_SAMPLE_TYPE", mdlTestBaseInfo.F_SAMPLE_TYPE),
                                             new OleDbParameter("@F_SEQUENCE_TEST", mdlTestBaseInfo.F_SEQUENCE_TEST),
                                             new OleDbParameter("@F_TEST_STATUS", mdlTestBaseInfo.F_TEST_STATUS),
                                             new OleDbParameter("@F_CREATE_TIME", mdlTestBaseInfo.F_CREATE_TIME),
                                             new OleDbParameter("@F_OPERATOR_ID", mdlTestBaseInfo.F_OPERATOR_ID),
                                             new OleDbParameter("@F_OPERATIONTIME", mdlTestBaseInfo.F_OPERATIONTIME),
                                             new OleDbParameter("@F_DEL", mdlTestBaseInfo.F_DEL)
                                         };
                bool insert_status = myAccessdb.ExecuteSQLNonquery(strSql, prams);
            }
        return intResult;
        }
    }
}
