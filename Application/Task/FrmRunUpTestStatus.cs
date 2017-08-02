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
    public partial class FrmRunUpTestStatus : DevExpress.XtraEditors.XtraForm
    {
        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmTaskManager));

        public FrmRunUpTestStatus()
        {
            InitializeComponent();
        }

        private void FrmRunUpTestStatus_Load(object sender, EventArgs e)
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //读取已完成的试验任务
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

        private void BindGridview()
        {
            ProxyBllTEST_INFO bllTest_Info = new ProxyBllTEST_INFO();
            DataSet dsTestInfo = bllTest_Info.GetListComplete();
            //将读取试验任务的任务编号显示在lstTaskList列表中
            lstTasklist.Items.Clear();
            string temptaskNo = "";
            if (dsTestInfo != null)
            {
                for (int i = 0; i < dsTestInfo.Tables[0].Rows.Count; i++)
                {
                    temptaskNo = dsTestInfo.Tables[0].Rows[i]["F_TEST_TASK_ID"].ToString();
                    lstTasklist.Items.Add(temptaskNo);
                }
            }
          
        }

        private void btnDisAddTemp_Click(object sender, EventArgs e)
        {
            //保存中间列表数据到不显示列表数据
            ProxyBllTEST_INFO bllTest_Info = new ProxyBllTEST_INFO();
            ProxyBllTEST_ALLOCATION bllTest_Allocation = new ProxyBllTEST_ALLOCATION();

            DataSet dsTestInfo;

            string now_taskid = "";
            if (lstTasklist.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择需要继续进行爬高试验的试验编号!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    //修改选中任务编号的试验状态
                    now_taskid = lstTasklist.SelectedItems[0].ToString();
                    bllTest_Info.update_status(now_taskid);
                    bllTest_Allocation.update_status(now_taskid);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("任务编号:" + now_taskid + "的试验基础信息修改保存错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("爬高试验状态修改完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGridview();
            }
        }
    }
}