using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using log4net;

namespace RelayTest.Application.Task
{
    public partial class FrmTaskDisList : DevExpress.XtraEditors.XtraForm
    {
        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmTaskManager));

        public FrmTaskDisList()
        {
            InitializeComponent();
        }

        private void FrmTaskDisList_Load(object sender, EventArgs e)
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //读取未开始试验的试验任务
                BindGridview();
                //如果试验任务编号列表不为空，默认选中第一项任务编号
                if (lstTasklist.Items.Count > 0)
                {
                    lstTasklist.SelectedIndex = 0;
                }

            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }
        /// <summary>
        /// query data from database and bind to gridview
        /// </summary>
        private void BindGridview()
        {
            /*20170608MODIFY  试验任务列表信息通过视图显示，提高列表显示速度
            //读取未开始的试验任务
            ProxyBllTEST_INFO bllTest_Info = new ProxyBllTEST_INFO();
            DataSet dsTestInfo = bllTest_Info.GetListNoStart();
            //将读取试验任务的任务编号、试验状态显示在lstTaskList列表中
            lstTasklist.Items.Clear();
            string temptaskNo = "";
            if (dsTestInfo != null)
            {
                for (int i = 0; i < dsTestInfo.Tables[0].Rows.Count; i++)
                {
                    temptaskNo = dsTestInfo.Tables[0].Rows[i]["F_TEST_TASK_ID"].ToString();

                    //判断temptaskNo任务编号的数据在试验任务数据文件中是否存在，如果存在，表示该任务已提交
                    //否则该任务为已保存未提交状态
                    ProxyBllTESINFODB bllTestDB = new ProxyBllTESINFODB();
                    DataSet dsTaskId = bllTestDB.GetList(" F_TEST_TASK_ID='" + temptaskNo + "' ");
                    if (dsTaskId == null || dsTaskId.Tables[0].Rows.Count == 0)
                    {
                        //lstTasklist.Items.Add(temptaskNo + "_未提交");
                        ProxyBllTEST_ALLOCATION bllTestAllocation = new ProxyBllTEST_ALLOCATION();
                        dsTaskId = bllTestAllocation.GetList(" F_TEST_TASK_ID='" + temptaskNo + "' and F_SAMPLE_STATUS<>11 ");
                        {
                            if (dsTaskId == null || dsTaskId.Tables[0].Rows.Count == 0)
                            {
                                lstTasklist.Items.Add(temptaskNo + "_未提交_未分配");
                            }
                            else
                            {
                                lstTasklist.Items.Add(temptaskNo + "_未提交_已分配");
                            }
                        }
                    }
                    else
                    {
                        ProxyBllTEST_ALLOCATION bllTestAllocation = new ProxyBllTEST_ALLOCATION();
                        dsTaskId = bllTestAllocation.GetList(" F_TEST_TASK_ID='" + temptaskNo + "' and F_SAMPLE_STATUS<>11 ");
                        {
                            if (dsTaskId == null || dsTaskId.Tables[0].Rows.Count == 0)
                            {
                                lstTasklist.Items.Add(temptaskNo + "_已提交_未分配");
                            }
                            else
                            {
                                lstTasklist.Items.Add(temptaskNo + "_已提交_已分配");
                            }
                        }
                    }
                }
            }*/
            //20170608MODIFY  试验任务列表信息通过视图显示，提高列表显示速度  end

            
            ProxyBllTEST_INFO bllTest_Info = new ProxyBllTEST_INFO();
            DataSet dsTestInfo = bllTest_Info.GetListNoStart_new();
            //将读取试验任务的任务编号显示在lstTaskList列表中
            lstTasklist.Items.Clear();
            string temptaskNo = "";
            string submit="";
            string allocation="";
            if (dsTestInfo != null)
            {
                for (int i = 0; i < dsTestInfo.Tables[0].Rows.Count; i++)
                {
                    temptaskNo = dsTestInfo.Tables[0].Rows[i]["F_TEST_TASK_ID"].ToString();
                    submit = dsTestInfo.Tables[0].Rows[i]["submit"].ToString();
                    allocation = dsTestInfo.Tables[0].Rows[i]["allocation"].ToString();
                    lstTasklist.Items.Add(temptaskNo);
                }
            }

            //清空中间显示列表
            lstTempDisList.Items.Clear();

            //将读取t_test_info_nodisplay表，将任务编号显示在lstTaskNoDisList列表中
            lstTaskNoDisList.Items.Clear();
            dsTestInfo = bllTest_Info.GetListNoDisplay("");
            if (dsTestInfo != null)
            {
                for (int i = 0; i < dsTestInfo.Tables[0].Rows.Count; i++)
                {
                    temptaskNo = dsTestInfo.Tables[0].Rows[i]["F_TEST_TASK_ID"].ToString();
                    lstTaskNoDisList.Items.Add(temptaskNo);
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            while (lstTasklist.SelectedItems.Count > 0)
            {
                lstTempDisList.Items.Add(lstTasklist.SelectedItems[0].ToString());

                if (lstTasklist.SelectedItems.Count == 1)
                {
                    lstTasklist.Items.RemoveAt(lstTasklist.SelectedIndex);
                    lstTasklist.SelectedIndex = -1;
                }
                else
                {
                    lstTasklist.Items.Remove(lstTasklist.SelectedItems[0]);
                }
            }
            lstTempDisList.SelectedIndex = -1;
        }

        private void baseSimpleButton1_Click(object sender, EventArgs e)
        {
            while (lstTaskNoDisList.SelectedItems.Count > 0)
            {
                lstTempDisList.Items.Add(lstTaskNoDisList.SelectedItems[0].ToString());

                if (lstTaskNoDisList.SelectedItems.Count == 1)
                {
                    lstTaskNoDisList.Items.RemoveAt(lstTaskNoDisList.SelectedIndex);
                    lstTaskNoDisList.SelectedIndex = -1;
                }
                else
                {
                    lstTaskNoDisList.Items.Remove(lstTaskNoDisList.SelectedItems[0]);
                }
            }
            lstTempDisList.SelectedIndex = -1;
        }

        private void baseSimpleButton2_Click(object sender, EventArgs e)
        {
            //保存中间列表数据到不显示列表数据
            ProxyBllTEST_INFO bllTest_Info = new ProxyBllTEST_INFO();
            DataSet dsTestInfo;
            
            //保存临时列表数据到不显示列表中
            for (int i = 0; i < lstTempDisList.Items.Count; i++)
            {
                dsTestInfo = bllTest_Info.GetListNoDisplay(" f_test_task_id='" + lstTempDisList.Items[i].ToString() + "'");
                if (dsTestInfo.Tables[0].Rows.Count == 0)
                    bllTest_Info.Add_noDisplay(lstTempDisList.Items[i].ToString());
            }

            //清空中间显示列表
            lstTempDisList.Items.Clear();

            //将读取t_test_info_nodisplay表，将任务编号显示在lstTaskNoDisList列表中
            lstTaskNoDisList.Items.Clear();
            dsTestInfo = bllTest_Info.GetListNoDisplay("");
            if (dsTestInfo != null)
            {
                for (int i = 0; i < dsTestInfo.Tables[0].Rows.Count; i++)
                {
                    string temptaskNo = dsTestInfo.Tables[0].Rows[i]["F_TEST_TASK_ID"].ToString();
                    lstTaskNoDisList.Items.Add(temptaskNo);
                }
            }
            MessageBox.Show("保存操作完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btnSaveDis_Click(object sender, EventArgs e)
        {
            //保存中间列表数据到不显示列表数据
            ProxyBllTEST_INFO bllTest_Info = new ProxyBllTEST_INFO();
            DataSet dsTestInfo;

            //保存临时列表数据到不显示列表中
            for (int i = 0; i < lstTempDisList.Items.Count; i++)
            {
                bllTest_Info.delete_noDisplay(" f_test_task_id='" + lstTempDisList.Items[i].ToString() + "'");
            }

            //清空中间显示列表
            lstTempDisList.Items.Clear();

            //将读取t_test_info_nodisplay表，将任务编号显示在lstTaskNoDisList列表中
            lstTaskNoDisList.Items.Clear();
            dsTestInfo = bllTest_Info.GetListNoDisplay("");
            if (dsTestInfo != null)
            {
                for (int i = 0; i < dsTestInfo.Tables[0].Rows.Count; i++)
                {
                    string temptaskNo = dsTestInfo.Tables[0].Rows[i]["F_TEST_TASK_ID"].ToString();
                    lstTaskNoDisList.Items.Add(temptaskNo);
                }
            }

            MessageBox.Show("保存操作完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void baseSimpleButton1_Click_1(object sender, EventArgs e)
        {
            ProxyBllTEST_INFO bllTest_Info = new ProxyBllTEST_INFO();
            DataSet dsTestInfo = bllTest_Info.GetListNoStart_new();
            //将读取试验任务的任务编号显示在lstTaskList列表中
            lstTasklist.Items.Clear();
            string temptaskNo = "";
            string submit = "";
            string allocation = "";
            if (dsTestInfo != null)
            {
                for (int i = 0; i < dsTestInfo.Tables[0].Rows.Count; i++)
                {
                    temptaskNo = dsTestInfo.Tables[0].Rows[i]["F_TEST_TASK_ID"].ToString();
                    submit = dsTestInfo.Tables[0].Rows[i]["submit"].ToString();
                    allocation = dsTestInfo.Tables[0].Rows[i]["allocation"].ToString();
                    lstTasklist.Items.Add(temptaskNo);
                }
            }
        }
    }
}