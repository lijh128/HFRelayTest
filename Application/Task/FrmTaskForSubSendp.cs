using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using DevExpress.XtraEditors;
using log4net;
using RelayTest.Application.Settings;
using RelayTest.Util.Common;
using RelayTest.BLL;
using RelayTest.Model;

namespace RelayTest.Application.Task
{
    public partial class FrmTaskForSubSendp : DevExpress.XtraEditors.XtraForm
    {

        #region 声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmTaskManager));

        //试验样品数据
        private DataTable _TestSampleTable = new DataTable("TestSampleTable");

        //试验开始命令设定参数
        private DataTable _TestCommStartPar = new DataTable("TestCommStartPar");

        private string now_taskId = "";

        #endregion

        public FrmTaskForSubSendp()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmTaskForSubSendp_Load(object sender, EventArgs e)
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //初始化
                initData();
                //初始化试验样品数据表。
                InitSampleTable(_TestSampleTable);
                //初始化开始命令参数表
                InitStartParValueTable(_TestCommStartPar);

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
        /// 初始化数据显示
        /// </summary>
        private void initData()
        {
            //工作模式代码
            txtWorkType.Text = "SAME";
            //试验程序代码
            txtProgram.Text = "WM001";
            
            RemoveALLRow(_TestSampleTable);
            RemoveALLRow(_TestCommStartPar);
            //清除设置值与默认值复选框的选择
            chk_setDefaultValue.Visible = true;
            chk_setDefaultValue.Checked = false;
        }

        /// <summary>
        /// query data from database and bind to gridview
        /// </summary>
        private void BindGridview()
        {
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
                    if (dsTaskId != null && dsTaskId.Tables[0].Rows.Count >= 0)                    
                    {
                        lstTasklist.Items.Add(temptaskNo + "-已提交");
                    }
                }
            }
        }

        /// <summary>
        /// 初始化试验样品数据表
        /// </summary>
        /// <param name="table">初始化DataTable表</param>
        private void InitSampleTable(DataTable table)
        {

            for (int i = 0; i < gvSampleInfoList.Columns.Count; i++)
            {
                table.Columns.Add(gvSampleInfoList.Columns[i].FieldName);
            }
            //行号
            table.Columns.Add("colId", typeof(string));
            //试验任务编号
            table.Columns.Add("F_TEST_TASK_ID", typeof(string));

        }

        /// <summary>
        /// 初始化试验样品参数表
        /// </summary>
        /// <param name="table">初始化DataTable表</param>
        private void InitStartParValueTable(DataTable table)
        {

            for (int i = 0; i < gvParValue.Columns.Count; i++)
            {
                table.Columns.Add(gvParValue.Columns[i].FieldName);
            }
            //行号
            table.Columns.Add("colId", typeof(string));
            table.Columns.Add("colSENDORDER", typeof(string));

        }

        /// <summary>
        /// 清除DataTable对象中已有的数据
        /// </summary>
        /// <returns></returns>
        /// <param name="DataTable">删除内容的DataTable表</param>
        private void RemoveALLRow(DataTable detailTable)
        {
            for (int i = detailTable.Rows.Count - 1; i >= 0; i--)
            {
                detailTable.Rows[i].Delete();
            }
        }

        /// <summary>
        /// 读取并显示需要在试验参数信息中设置的参数
        /// </summary>
        private void QueryAndDis_CommPar()
        {
            ProxyBllCOMMAND_PAR_SEND bllTestCommPar = new ProxyBllCOMMAND_PAR_SEND();

            //获取在数据管理客户端需要设置的参数F_SENDPAR_SET=1
            string temp_con = "";
            temp_con = " F_SENDPAR_SET=2 ";
            _TestCommStartPar = bllTestCommPar.GetAndDisplayCommPar(_TestCommStartPar, temp_con);

            gcParValue.DataSource = _TestCommStartPar;
        }

        /// <summary>
        /// 初始参数值与默认值相同复选框值修改事件
        /// 选中该复选框时，将试验参数值数据表中默认值列的值复制给参数值列
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chk_setDefaultValue_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_setDefaultValue.Checked)
            {
                for (int i = 0; i < _TestCommStartPar.Rows.Count; i++)
                {
                    _TestCommStartPar.Rows[i]["F_SENDPAR_VALUE"] = _TestCommStartPar.Rows[i]["F_SENDPAR_DEFAULT_VALUE"];
                }
            }
        }

        private void lstTasklist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTasklist.SelectedIndex >= 0)
            {
                string tempstr = lstTasklist.SelectedItem.ToString();
                now_taskId = tempstr.Substring(0, tempstr.IndexOf("-"));

              
                //根据任务编号nowTaskId显示试验任务样品编号信息
                displayTaskSampleInfoByTaskId(now_taskId);

                //根据任务编号nowTaskId显示试验任务参数信息
                displayTaskCommParInfoByTaskId(now_taskId);
            }
        }

        /// <summary>
        /// 根据任务编号显示试验任务样品信息的内容
        /// </summary>
        /// <param name="taskId">任务编号</param>
        private void displayTaskSampleInfoByTaskId(string taskId)
        {
            RemoveALLRow(_TestSampleTable);
            //读取选定试验任务的试验样品数据
            ProxyBllTEST_ALLOCATION bllTestSampleAlloction = new ProxyBllTEST_ALLOCATION();

            _TestSampleTable = bllTestSampleAlloction.GetAndDisplaySampleInfo(_TestSampleTable, taskId);

            if (_TestSampleTable.Rows.Count == 0)
            {
                _TestSampleTable.Rows.Add();
            }
            gcSampleInfoList.DataSource = _TestSampleTable;
        }

        /// <summary>
        /// 根据任务编号显示试验任务命令参数信息的内容
        /// </summary>
        /// <param name="taskId">任务编号</param>
        private void displayTaskCommParInfoByTaskId(string taskId)
        {
            RemoveALLRow(_TestCommStartPar);

            //根据试验任务编号判断该试验任务参数值   
            ProxyBllTEST_PAR_VALUE_SWJ bllTestParValue = new ProxyBllTEST_PAR_VALUE_SWJ();

            _TestCommStartPar = bllTestParValue.GetAndDisplayParValue(_TestCommStartPar, taskId);
            gcParValue.DataSource = _TestCommStartPar;
            if (_TestCommStartPar.Rows.Count == 0)
            {
                QueryAndDis_CommPar();
                chk_setDefaultValue.Checked = false;
                chk_setDefaultValue.Visible = true;
            }
            else
            {
                chk_setDefaultValue.Checked = false;
                chk_setDefaultValue.Visible = false;
            }
        }

        private void chk_setDefaultValue_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chk_setDefaultValue.Checked)
            {
                for (int i = 0; i < _TestCommStartPar.Rows.Count; i++)
                {
                    _TestCommStartPar.Rows[i]["F_SENDPAR_VALUE"] = _TestCommStartPar.Rows[i]["F_SENDPAR_DEFAULT_VALUE"];
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (!now_taskId.Trim().Equals(""))
            {
                //试验样品信息各数据行的数据有效，保存该组数据到T_TEST_SAMPLE_INFO表中
                ProxyBllTEST_ALLOCATION bllTestAllocation = new ProxyBllTEST_ALLOCATION();

                //删除该任务编号的样品分配信息数据
                string dropWhere = "";
                dropWhere = " F_TEST_TASK_ID='" + now_taskId + "' ";
                bllTestAllocation.DropWhere(dropWhere);

                //生成任务编号now_taskId的样品编号信息，并写入T_TEST_ALLOCATION
                for (int i = 0; i < _TestSampleTable.Rows.Count; i++)
                {
                    var modelTestAllocation = new ModelTEST_ALLOCATION();
                    
                    modelTestAllocation.F_TEST_TASK_ID = now_taskId;
                    modelTestAllocation.F_TEST_SAMPLE_ID = _TestSampleTable.Rows[i]["F_TEST_SAMPLE_ID"].ToString();
                    modelTestAllocation.F_LOAD_ID = _TestSampleTable.Rows[i]["F_LOAD_ID"].ToString();
                    modelTestAllocation.F_LOAD_CHANNEL_ID = _TestSampleTable.Rows[i]["F_LOAD_CHANNEL_ID"].ToString();
                    modelTestAllocation.F_SAMPLE_STATUS = 0;
                    modelTestAllocation.F_CREATE_TIME = DateTime.Now;
                    modelTestAllocation.F_OPERATOR_ID = AppGlobal.GUserId;
                    modelTestAllocation.F_OPERATIONTIME = DateTime.Now;
                    modelTestAllocation.F_DEL = 0;
                    bllTestAllocation.Add_KHD(modelTestAllocation);
                }

                //试验参数数据填写值有效，保存
                ProxyBllTEST_PAR_VALUE_SWJ bllTestParValue = new ProxyBllTEST_PAR_VALUE_SWJ();
                //删除该任务编号的试验开始命令参数值
                bllTestParValue.DropByTaskId(now_taskId);

                for (int i = 0; i < _TestCommStartPar.Rows.Count; i++)
                {
                    var ModelTEST_PAR_VALUE_SWJ = new ModelTEST_PAR_VALUE_SWJ();
                    ModelTEST_PAR_VALUE_SWJ.F_TASK_ID = now_taskId;
                    //程序代码：在客户端表中备用，均填写为000
                    ModelTEST_PAR_VALUE_SWJ.F_PROGRAM_CODE = txtProgram.Text;
                    ModelTEST_PAR_VALUE_SWJ.F_WORKTYPE_CODE = txtWorkType.Text;
                    ModelTEST_PAR_VALUE_SWJ.F_SENDPAR_NAME = _TestCommStartPar.Rows[i]["F_SENDPAR_NAME"].ToString();
                    ModelTEST_PAR_VALUE_SWJ.F_SENDPAR_VALUE = _TestCommStartPar.Rows[i]["F_SENDPAR_VALUE"].ToString();
                    //ModelTEST_PAR_VALUE_KHD.F_SENDPAR_UNIT = _TestCommStartPar.Rows[i]["F_PAR_UNIT"].ToString();
                    ModelTEST_PAR_VALUE_SWJ.F_SENDORDER = Convert.ToInt16(_TestCommStartPar.Rows[i]["colSENDORDER"].ToString());
                    ModelTEST_PAR_VALUE_SWJ.F_CREATE_TIME = DateTime.Now;
                    ModelTEST_PAR_VALUE_SWJ.F_OPERATOR_ID = AppGlobal.GUserId;
                    ModelTEST_PAR_VALUE_SWJ.F_OPERATIONTIME = DateTime.Now;
                    ModelTEST_PAR_VALUE_SWJ.F_DEL = 0;

                    bllTestParValue.Add(ModelTEST_PAR_VALUE_SWJ);

                }
                MessageBox.Show("任务编号:" + now_taskId + "的上位机模拟数据保存完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void baseSimpleButton1_Click(object sender, EventArgs e)
        {
            ProxyBllTEST_SENDP_VALUE bllTest_SendpValue = new ProxyBllTEST_SENDP_VALUE();
            bllTest_SendpValue.DropWhere("F_TASK_ID='" + now_taskId + "'");
            bllTest_SendpValue.AddDataByTaskId(now_taskId);
            
            MessageBox.Show("任务编号:" + now_taskId + "的sendp表数据生成完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}