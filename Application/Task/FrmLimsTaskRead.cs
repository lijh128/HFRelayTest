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
    public partial class FrmLimsTaskRead : DevExpress.XtraEditors.XtraForm
    {
        #region 声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmTaskManager));

        //试验任务数据
        private ModelTEST_INFO _mdlTestInfo;

        //试验样品数据
        private DataTable _TestSampleTable = new DataTable("TestSampleTable");

        //新增的样品信息
        //private List<ModelTEST_SAMPLE_INFO> _AddmodelTestSampleInfo;

        //试验开始命令设定参数
        private DataTable _TestCommStartPar = new DataTable("TestCommStartPar");

        //导出文件时的选择路径
        private string exportSelectPath = "";

        //当前选中任务列表中的选中的任务信息
        private string selecttaskinfo = "";


        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmLimsTaskRead()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 关闭按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// 窗体载入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTaskManager_Load(object sender, EventArgs e)
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

                //读取Lims中未保存到实验数据库中的试验数据
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
            //试验任务编号
            txtTaskId.Text = "";
            //检测项目
            txtTestItem.Text = "";
            //规格型号
            txtTestModel.Text = "";
            //检测标准
            txtTestStandard.Text = "";
            //检测性质
            txtTestProperty.Text = "";
            //检测目的
            txtTestAim.Text = "";
            //委托单位
            txtDeputeUnit.Text = "";
            //联系人
            txtContact.Text = "";
            //电话
            txtPhone.Text = "";
            //email
            txtEmail.Text = "";
            //负责人
            txtCharge.Text = "";
            //委托日期
            dateEdit_task.Text = "";            
            RemoveALLRow(_TestSampleTable);
            RemoveALLRow(_TestCommStartPar);
            //清除设置值与默认值复选框的选择
            //chk_setDefaultValue.Visible = true;
            //chk_setDefaultValue.Checked = false;            
        }

        /// <summary>
        /// query data from database and bind to gridview
        /// </summary>
        private void BindGridview()
        {
            //读取Lims数据库中的试验任务数据

            ProxyBllLIMS_DOWNLOAD_PARA bllLimsDownloadPara = new ProxyBllLIMS_DOWNLOAD_PARA();
            DataSet dsTestInfo = bllLimsDownloadPara.GetListFromLimsNoRead();
            
            //将读取试验任务的任务编号、试验状态显示在lstTaskList列表中
            lstTasklist.Items.Clear();
            string temptaskNo="";
            if (dsTestInfo != null)
            {
                for(int i=0;i<dsTestInfo.Tables[0].Rows.Count;i++)
                {
                    temptaskNo = dsTestInfo.Tables[0].Rows[i]["任务编号"].ToString();
                    lstTasklist.Items.Add(temptaskNo);  
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
        /// 演示测试时使用，填写试验任务信息的默认值
        /// </summary>
        private void FillBaseInfo()
        {
            //检测项目
            txtTestItem.Text = "阻性负载电耐久性";
            //规格型号
            txtTestModel.Text = "JQX-102F/12VDC";
            //检测标准
            txtTestStandard.Text = "Q/FVF 4038-2015";
            //检测性质
            txtTestProperty.Text = "常规测试";
            //检测目的
            txtTestAim.Text = "股份公司产品可靠性监控";
            //委托单位
            txtDeputeUnit.Text = "股份公司总部检测中心";
            //联系人
            txtContact.Text = "陈洪科";
            //电话
            txtPhone.Text = "655";
            //email
            txtEmail.Text = "1001498@hongfa.cn";
            //负责人
            txtCharge.Text = "test";            
        }
        /// <summary>
        /// 根据任务编号编码规则创建一个新的任务编号
        /// 返回值：新生成的任务编号
        /// </summary>
        private String createNewTaskId()
        {
            //新任务规则为"YYMMDD"+3位委托单序号（"本程序中固定为'001'"）+2位任务序号
            String taskId = "";
            taskId = string.Format("{0:yyyy}", DateTime.Now);
            taskId = taskId.Substring(2, 2); 
            taskId = taskId + string.Format("{0:MMdd}", DateTime.Now);
            taskId = taskId + "001";
            //从数据库中读取试验任务的最大顺序号，已生成试验任务编号
            ProxyBllTEST_INFO bllTest_Info = new ProxyBllTEST_INFO();
            DataSet dsTaskId = bllTest_Info.GetMaxTaskID(taskId);

            String temptaskNo = "";

            if (dsTaskId != null)
            {
                if (dsTaskId.Tables[0].Rows.Count > 0)
                {
                    temptaskNo = dsTaskId.Tables[0].Rows[0][0].ToString();
                    if (temptaskNo == "")
                    {
                        temptaskNo = "01";
                    }
                    else
                    {
                        if (Convert.ToInt16(temptaskNo) >=9 && Convert.ToInt16(temptaskNo) < 99)
                        {
                            temptaskNo = (Convert.ToInt16(temptaskNo) + 1).ToString();
                        }
                        else
                        {
                            temptaskNo = "0" + (Convert.ToInt16(temptaskNo) + 1).ToString();
                        }
                    }

                }
            }
            else
            {
                temptaskNo = "01";
            }
            taskId = taskId + temptaskNo;
            return taskId;
        }

        /// <summary>
        /// 读取并显示需要在试验参数信息中设置的参数
        /// </summary>
        private void QueryAndDis_CommPar()
        {
            ProxyBllCOMMAND_PAR_SEND bllTestCommPar = new ProxyBllCOMMAND_PAR_SEND();

            //获取在数据管理客户端需要设置的参数F_SENDPAR_SET=1
            string temp_con = "";
            temp_con = " F_SENDPAR_SET=1 ";
            _TestCommStartPar = bllTestCommPar.GetAndDisplayCommPar(_TestCommStartPar, temp_con);

            gcParValue.DataSource = _TestCommStartPar;
        }

       

        /// <summary>
        /// 新增样品行按钮时间
        /// 试验样品数据行增加一个空行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewSampleLine_Click(object sender, EventArgs e)
        {
            _TestSampleTable.Rows.Add();
        }

        /// <summary>
        /// 保存任务到客户端任务数据库表中
        /// </summary>
        private int SaveTask_To_KHD()
        {
            int saveflag = 0;

            string now_taskId = "";
            now_taskId = txtTaskId.Text;

            if (!now_taskId.Trim().Equals(""))
            {
                //2015年10月18日修改，增加保存试验任务时判断该任务编号是否存在已运行的样品（t_test_allocation表trunc(f_sample_status/10)>1）
                //如果存在，不可进行保存操作
                ProxyBllTEST_ALLOCATION bllTestAllocation = new ProxyBllTEST_ALLOCATION();
                DataSet dsTestSample = bllTestAllocation.GetList(" trunc(F_SAMPLE_STATUS/10)>1 AND F_TEST_TASK_ID='" + now_taskId + "' ");
                if (dsTestSample != null && dsTestSample.Tables[0].Rows.Count != 0)
                {
                    MessageBox.Show("任务编号：" + now_taskId + "的试验任务中存在已运行的样品，不可进行保存操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }


                //20170330-add-start获取试验样品的触点类型数据，判断是否为多触点样品，多触点样品在lims_contact_type表中是否有对应名称
                ProxyBllLIMS_DOWNLOAD_PARA blllimsDownLoadPara = new ProxyBllLIMS_DOWNLOAD_PARA();
                string temp_contact_type = "";
                DataSet dsContactType = blllimsDownLoadPara.getContactTypeByTaskId(now_taskId);
                for (int i = 0; i < dsContactType.Tables[0].Rows.Count; i++)
                {
                    temp_contact_type = dsContactType.Tables[0].Rows[i]["条件默认值"].ToString();
                }
                if (!temp_contact_type.Equals(""))
                {
                    ProxyBllLIMS_CONTACT_TYPE blllimsContactType = new ProxyBllLIMS_CONTACT_TYPE();
                    DataSet dsLims_Contact_Type = blllimsContactType.GetLimsContactName(temp_contact_type);

                    if (dsLims_Contact_Type.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("任务编号：" + now_taskId + "的触点类型在lims_contact_type表中没有对应名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1;
                    }

               }
                //20170330-add-start获取试验样品的触点类型数据，判断是否为多触点样品，多触点样品在lims_contact_type表中是否有对应名称


                //判断该试验任务编号的信息是否处于“已提交”状态
                //如果当前保存任务为“已提交”状态任务，执行保存操作后，提示任务状态将修改为“未提交”状态。需要重新执行提交操作。
                ProxyBllTESINFODB bllTestDB = new ProxyBllTESINFODB();
                DataSet dsTaskId = bllTestDB.GetList(" F_TEST_TASK_ID='" + now_taskId + "' ");
                if (dsTaskId != null && dsTaskId.Tables[0].Rows.Count != 0)
                {
                    DialogResult dialogResult = XtraMessageBox.Show("任务编号：" + now_taskId + "的试验任务已提交，是否重新保存任务信息？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.No)
                    {
                        return -1;
                    }
                    else
                    {
                        bllTestDB.DropWhere(" F_TEST_TASK_ID='" + now_taskId + "' ");
                    }
                }

                //判断试验基础信息必填项是否已填写
                //试验基础信息必填项已填写，保存该组数据到T_TEST_INFO表中
                if (judgeTestBaseInfo())
                {
                    BllTEST_INFO blltest_info = new BllTEST_INFO();

                    //判断该任务编号在数据库中是否存在，如果存在进行修改处理，否则进行新增操作
                    DataSet dsTaskCount = blltest_info.GetTaskCount(now_taskId);
                    int temptaskCount = -1;

                    if (dsTaskCount != null)
                    {
                        if (dsTaskCount.Tables[0].Rows.Count > 0)
                        {
                            temptaskCount = Convert.ToInt16(dsTaskCount.Tables[0].Rows[0][0].ToString());
                        }
                    }

                    if (temptaskCount == 0)  //新增操作
                    {
                        try
                        {
                            //将试验任务数据写入Model类中
                            CreateOrUpdateTestInfo(1);
                            blltest_info.Add(_mdlTestInfo);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("任务编号:" + now_taskId + "的试验基础信息新增保存错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return -1;
                        }
                    }
                    else  //修改操作
                    {
                        try
                        {
                            //将试验任务数据写入Model类中
                            CreateOrUpdateTestInfo(2);
                            blltest_info.Update(_mdlTestInfo);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("任务编号:" + now_taskId + "的试验基础信息修改保存错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return -1;
                        }
                    }
                    saveflag = saveflag + 1;
                }

                //2015年10月18日修改--判断该任务是否可修改样品，如果可以，执行保存，如不可以，不需执行保存样品的操作
                if (gcSampleInfoList.Enabled)
                {

                    //判断试验样品信息是否有数据行，各数据行的数据是否有效
                    if (judgeTestSampleInfo())
                    {
                        //试验样品信息各数据行的数据有效，保存该组数据到T_TEST_SAMPLE_INFO表中
                        ProxyBllTEST_SAMPLE_INFO bllTestSampleInfo = new ProxyBllTEST_SAMPLE_INFO();

                        //删除该任务编号的样品数据
                        bllTestSampleInfo.DropByTaskId(now_taskId);

                        for (int i = 0; i < _TestSampleTable.Rows.Count; i++)
                        {
                            var modelTestSampleInfo = new ModelTEST_SAMPLE_INFO();
                            modelTestSampleInfo.F_TEST_TASK_ID = now_taskId;
                            modelTestSampleInfo.F_SAMPLE_NUM = Convert.ToInt16(_TestSampleTable.Rows[i]["F_SAMPLE_NUM"].ToString());
                            modelTestSampleInfo.F_SAMPLE_GROUP_NUM = _TestSampleTable.Rows[i]["F_SAMPLE_GROUP_NUM"].ToString();
                            modelTestSampleInfo.F_SAMPLE_MEMO = _TestSampleTable.Rows[i]["F_SAMPLE_MEMO"].ToString();
                            modelTestSampleInfo.F_CREATE_TIME = DateTime.Now;
                            modelTestSampleInfo.F_OPERATOR_ID = AppGlobal.GUserId;
                            modelTestSampleInfo.F_OPERATIONTIME = DateTime.Now;
                            modelTestSampleInfo.F_DEL = 0;

                            bllTestSampleInfo.Add(modelTestSampleInfo);

                        }

                        //生成样品编号，并写入T_TEST_ALLOCATION表中，写入任务编号F_TEST_TASK_ID、样品编号F_TEST_SAMPLE_ID字段
                        //运行状态F_SAMPLE_STATUS值为-1，状态为未分配                   

                        //删除该任务编号的样品分配信息数据
                        string dropWhere = "";
                        dropWhere = " F_TEST_TASK_ID='" + now_taskId + "' ";
                        bllTestAllocation.DropWhere(dropWhere);

                        //20170112-add-start获取试验样品的触点类型数据，判断是否为多触点样品
                        //ProxyBllLIMS_DOWNLOAD_PARA blllimsDownLoadPara = new ProxyBllLIMS_DOWNLOAD_PARA();
                        //string temp_contact_type = "";
                        //DataSet dsContactType= blllimsDownLoadPara.getContactTypeByTaskId(now_taskId);
                        //for (int i = 0; i < dsContactType.Tables[0].Rows.Count; i++)
                        //{
                            //temp_contact_type = dsContactType.Tables[0].Rows[i]["条件默认值"].ToString();
                        //}
                        
                        //20170112-add-end获取试验样品的触点类型数据结束。

                        //从lims_sam读取样品编号，写入allocation表中
                        ProxyBllLIMS_DOWNLOAD_SAM blllimsDownLoadSample = new ProxyBllLIMS_DOWNLOAD_SAM();
                        DataSet dsLims_DownLoad_Sam = blllimsDownLoadSample.GetLimsSampleInfo(now_taskId);
                        int task_order = 0;
                        for (int i = 0; i < dsLims_DownLoad_Sam.Tables[0].Rows.Count; i++)
                        {
                            var modelTestAllocation = new ModelTEST_ALLOCATION();                            
                            string temp_sampleid = "";
                            DataRow dataRow = dsLims_DownLoad_Sam.Tables[0].Rows[i];
                            modelTestAllocation.F_TEST_TASK_ID = now_taskId;
                            
                            temp_sampleid = dataRow["样品编号"].ToString();
                            temp_sampleid = temp_sampleid.Substring(temp_sampleid.LastIndexOf("-") + 1, temp_sampleid.Length - temp_sampleid.LastIndexOf("-") - 1);
                            modelTestAllocation.F_TEST_SAMPLE_ID = temp_sampleid;
                            
                            //20170112-add-start获取试验样品的触点类型数据，判断是否为多触点样品
                            if (!temp_contact_type.Equals(""))
                            {
                                ProxyBllLIMS_CONTACT_TYPE blllimsContactType = new ProxyBllLIMS_CONTACT_TYPE();
                                DataSet dsLims_Contact_Type = blllimsContactType.GetLimsContactName(temp_contact_type);

                                for (int k = 0; k < dsLims_Contact_Type.Tables[0].Rows.Count; k++)
                                {
                                    task_order = task_order + 1;
                                    modelTestAllocation.F_TEST_SAMPLE_ID = temp_sampleid +"-"+dsLims_Contact_Type.Tables[0].Rows[k]["CONTACT_NAME"].ToString(); ;

                                    modelTestAllocation.样品号 = Convert.ToInt32(dataRow["样品号"].ToString());
                                    modelTestAllocation.检测号 = Convert.ToInt32(dataRow["检测号"].ToString());
                                    modelTestAllocation.排程号 = Convert.ToInt32(dataRow["排程号"].ToString());
                                    modelTestAllocation.仪器键值 = dataRow["仪器键值"].ToString();
                                    modelTestAllocation.F_LOAD_ID = dataRow["负载柜编号"].ToString();
                                    modelTestAllocation.位置编号 = dataRow["位置编号"].ToString();
                                    modelTestAllocation.分析名称 = dataRow["分析名称"].ToString();
                                    modelTestAllocation.排程开始时间 = Convert.ToDateTime(dataRow["排程开始时间"].ToString());
                                    modelTestAllocation.组别 = dataRow["组别"].ToString();
                                    modelTestAllocation.产品系列 = dataRow["产品系列"].ToString();
                                    modelTestAllocation.规格型号 = dataRow["规格型号"].ToString();
                                    modelTestAllocation.F_SAMPLE_STATUS = 11;
                                    modelTestAllocation.F_CREATE_TIME = DateTime.Now;
                                    modelTestAllocation.F_OPERATOR_ID = "LIMS";
                                    modelTestAllocation.F_OPERATIONTIME = DateTime.Now;
                                    modelTestAllocation.F_DEL = 0;
                                    modelTestAllocation.F_TASK_ORDER = task_order;
                                    bllTestAllocation.Add_Lims(modelTestAllocation);
                                }
                            }
                            //20170112-add-end获取试验样品的触点类型数据，判断是否为多触点样品
                            else
                            {
                                task_order = task_order + 1;
                                modelTestAllocation.F_TEST_SAMPLE_ID = temp_sampleid;
                                modelTestAllocation.样品号 = Convert.ToInt32(dataRow["样品号"].ToString());
                                modelTestAllocation.检测号 = Convert.ToInt32(dataRow["检测号"].ToString());
                                modelTestAllocation.排程号 = Convert.ToInt32(dataRow["排程号"].ToString());
                                modelTestAllocation.仪器键值 = dataRow["仪器键值"].ToString();
                                modelTestAllocation.F_LOAD_ID = dataRow["负载柜编号"].ToString();
                                modelTestAllocation.位置编号 = dataRow["位置编号"].ToString();
                                modelTestAllocation.分析名称 = dataRow["分析名称"].ToString();
                                modelTestAllocation.排程开始时间 = Convert.ToDateTime(dataRow["排程开始时间"].ToString());
                                modelTestAllocation.组别 = dataRow["组别"].ToString();
                                modelTestAllocation.产品系列 = dataRow["产品系列"].ToString();
                                modelTestAllocation.规格型号 = dataRow["规格型号"].ToString();
                                modelTestAllocation.F_SAMPLE_STATUS = 11;
                                modelTestAllocation.F_CREATE_TIME = DateTime.Now;
                                modelTestAllocation.F_OPERATOR_ID = "LIMS";
                                modelTestAllocation.F_OPERATIONTIME = DateTime.Now;
                                modelTestAllocation.F_DEL = 0;
                                modelTestAllocation.F_TASK_ORDER = task_order + 1;
                                bllTestAllocation.Add_Lims(modelTestAllocation);
                            }
                        }
                   }
                }

                 saveflag = saveflag + 10;

               
                //试验参数数据填写值有效，保存
                ProxyBllTEST_PAR_VALUE_KHD bllTestParValue = new ProxyBllTEST_PAR_VALUE_KHD();
                //删除该任务编号的试验开始命令参数值
                bllTestParValue.DropByTaskId(now_taskId);

                for (int i = 0; i < _TestCommStartPar.Rows.Count; i++)
                {
                    var ModelTEST_PAR_VALUE_KHD = new ModelTEST_PAR_VALUE_KHD();
                    ModelTEST_PAR_VALUE_KHD.F_TASK_ID = now_taskId;
                    //程序代码：在客户端表中备用，均填写为000
                    ModelTEST_PAR_VALUE_KHD.F_PROGRAM_CODE = "000";
                    ModelTEST_PAR_VALUE_KHD.F_SENDPAR_NAME = _TestCommStartPar.Rows[i]["F_SENDPAR_NAME"].ToString();

                    if (_TestCommStartPar.Rows[i]["F_SENDPAR_VALUE"].ToString().Trim().Equals(""))
                        if (_TestCommStartPar.Rows[i]["F_SENDPAR_DEFAULT_VALUE"].ToString().Length > 10)
                            ModelTEST_PAR_VALUE_KHD.F_SENDPAR_VALUE = _TestCommStartPar.Rows[i]["F_SENDPAR_DEFAULT_VALUE"].ToString().Substring(0, 10);
                        else
                            ModelTEST_PAR_VALUE_KHD.F_SENDPAR_VALUE = _TestCommStartPar.Rows[i]["F_SENDPAR_DEFAULT_VALUE"].ToString();
                    else
                        if (_TestCommStartPar.Rows[i]["F_SENDPAR_VALUE"].ToString().Length>10)
                            ModelTEST_PAR_VALUE_KHD.F_SENDPAR_VALUE = _TestCommStartPar.Rows[i]["F_SENDPAR_VALUE"].ToString().Substring(0, 10);
                        else
                            ModelTEST_PAR_VALUE_KHD.F_SENDPAR_VALUE = _TestCommStartPar.Rows[i]["F_SENDPAR_VALUE"].ToString();

                    //ModelTEST_PAR_VALUE_KHD.F_SENDPAR_UNIT = _TestCommStartPar.Rows[i]["F_PAR_UNIT"].ToString();
                    ModelTEST_PAR_VALUE_KHD.F_SENDORDER = Convert.ToInt16(_TestCommStartPar.Rows[i]["colSENDORDER"].ToString());
                    ModelTEST_PAR_VALUE_KHD.F_CREATE_TIME = DateTime.Now;
                    ModelTEST_PAR_VALUE_KHD.F_OPERATOR_ID = AppGlobal.GUserId;
                    ModelTEST_PAR_VALUE_KHD.F_OPERATIONTIME = DateTime.Now;
                    ModelTEST_PAR_VALUE_KHD.F_DEL = 0;

                    bllTestParValue.Add(ModelTEST_PAR_VALUE_KHD);

                }
                saveflag = saveflag + 100;

                /*
                //根据saveflag的标志信息
                if (saveflag == 111) //试验基础信息、试验样品信息、试验参数信息均保存完成
                {
                    MessageBox.Show("任务编号:" + now_taskId + "的试验基础信息、试验样品信息、试验参数信息保存完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (saveflag == 110)//试验样品信息、试验参数信息均保存完成
                {
                    MessageBox.Show("任务编号:" + now_taskId + "的试验样品信息、试验参数信息保存完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (saveflag == 101)//试验基础信息、试验参数信息均保存完成
                {
                    MessageBox.Show("任务编号:" + now_taskId + "的试验基础信息、试验参数信息保存完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (saveflag == 11) //试验基础信息、试验样品信息保存完成
                {
                    MessageBox.Show("任务编号:" + now_taskId + "的试验基础信息、试验样品信息保存完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (saveflag == 100) //试验参数信息保存完成
                {
                    MessageBox.Show("任务编号:" + now_taskId + "的试验参数信息保存完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (saveflag == 10) //试验样品信息保存完成
                {
                    MessageBox.Show("任务编号:" + now_taskId + "的试验样品信息保存完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (saveflag == 1) //试验基础信息保存完成
                {
                    MessageBox.Show("任务编号:" + now_taskId + "的试验基础信息保存完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }*/
            }
            return saveflag;
        }

        /// <summary>
        /// 提交任务按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;

            //首先执行保存任务
            if (SaveTask_To_KHD() == -1)
            {
                MessageBox.Show("当前选择的lims任务信息保存到客户端数据库任务表错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSubmit.Enabled = true;
                return ;
            }


            //只有在试验任务基础信息、试验样品信息、试验参数信息三部分的数据均保存到相应的数据表后，方可执行提交操作
            //提交操作根据3个数据表的内容生成上位机运行所需的数据文件
            //试验任务基础信息保存到T_TEST_INFO
            //试验样品信息保存到T_TEST_SAMPLE_INFO
            //试验参数信息保存到T_TEST_PAR_VALUE_KHD
            
            //首先判断试验任务编号数据项是否为空，如果为空，不可执行提交操作
            if (txtTaskId.Text.Trim().Equals(""))
            {
                MessageBox.Show("请选择需要执行提交操作的任务编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSubmit.Enabled = true;
                return;
            }
            string now_taskid = txtTaskId.Text;
            //判断now_taskid任务编号的数据是否保存完整；
            //T_TEST_INFO、T_TEST_SAMPLE_INFO、T_TEST_PAR_VALUE_KHD中均存在该任务编号的数据

            ProxyBllTEST_INFO bllTestInfo = new ProxyBllTEST_INFO();
            DataSet dsTaskId = bllTestInfo.GetList(" F_TEST_TASK_ID='"+now_taskid+"' ");
            if (dsTaskId == null || dsTaskId.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("任务编号:"+now_taskid+"的试验任务基础信息不存在，请先录入并保存改任务编号的试验任务基础信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSubmit.Enabled = true;
                return;
            }

            ProxyBllTEST_SAMPLE_INFO bllTestSampleInfo = new ProxyBllTEST_SAMPLE_INFO();
            dsTaskId = bllTestSampleInfo.GetList(" F_TEST_TASK_ID='" + now_taskid + "' ");
            if (dsTaskId == null || dsTaskId.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("任务编号:" + now_taskid + "的试验样品信息不存在，请先录入并保存改任务编号的试验样品信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSubmit.Enabled = true;
                return;
            }

            ProxyBllTEST_PAR_VALUE_KHD bllTestParValue = new ProxyBllTEST_PAR_VALUE_KHD();
            dsTaskId = bllTestParValue.GetList(" F_TASK_ID='" + now_taskid + "' ");
            if (dsTaskId == null || dsTaskId.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("任务编号:" + now_taskid + "的试验参数信息不存在，请先录入并保存改任务编号的试验参数信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSubmit.Enabled = true;
                return;
            }

            //执行提交任务操作，生成试验任务相关数据的access文件
            //判断access模板文件夹是否存在
            if (Directory.Exists("DataFile") == false)//如果不存在就创建file文件夹
            {
                MessageBox.Show("Access模板文件夹不存在，请检查模板文件夹DataFile是否存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSubmit.Enabled = true;
                return;
            }
            else
            {
                //判断模板文件是否存在Template.mdb
                if (File.Exists("DataFile/Template.mdb") == false)
                {
                    MessageBox.Show("Access模板文件不存在，请检查模板文件Template.mdb是否存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSubmit.Enabled = true;
                    return;
                }

                //判断当前任务编号的access数据文件是否存在；如果存在，删除原有任务文件，按当前oracle数据库数据，生成新的access数据文件
                if (File.Exists("DataFile/" + now_taskid + ".mdb") == true)
                {
                    File.Delete("DataFile/" + now_taskid + ".mdb");
                    File.Delete("DataFile/" + now_taskid + ".ldb");
                }
                
                FrmSubmitPrompt frm = new FrmSubmitPrompt();
                frm.Show();
                frm.Refresh();

                File.Copy("DataFile/Template.mdb", "DataFile/" + now_taskid + ".mdb");

                string mdbpath = "DataFile/" + now_taskid + ".mdb";
                ProxyBllCommon proxyBllCommon = new ProxyBllCommon();
                //导出试验任务基本信息到access文件中
                proxyBllCommon.FillAccessTableFromOracle("T_TEST_INFO", " F_TEST_TASK_ID='" + now_taskid + "' ", mdbpath);
                //导出试验任务样品信息到access文件中
                proxyBllCommon.FillAccessTableFromOracle("T_TEST_SAMPLE_INFO", " F_TEST_TASK_ID='" + now_taskid + "' ", mdbpath);
                //导出试验任务参数信息到access文件中
                proxyBllCommon.FillAccessTableFromOracle("T_TEST_PAR_VALUE_KHD", " F_TASK_ID='" + now_taskid + "' ", mdbpath);

                //将生成的access文件写入oracle数据库中
                if (saveMDBToOacle(mdbpath, now_taskid))
                {
                    frm.Close();
                    MessageBox.Show("试验任务信息提交完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    initData();
                    BindGridview();
                    string tempstr = ""; ;
                    for (int i = 0; i < lstTasklist.ItemCount; i++)
                    {
                        tempstr = lstTasklist.Items[i].ToString();
                        if (tempstr.Equals(now_taskid))
                        {
                            lstTasklist.SelectedIndex = i;
                            break; ;
                        }
                    }
                    btnSubmit.Enabled = true;
                    return;
                }
                else
                {
                    MessageBox.Show("将试验信息Access文件写入Oracle时错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSubmit.Enabled = true;
                    return;
                } 
            }
           
        }

        bool saveMDBToOacle(string mdbFile,string strTaskid)
        {
            ModelTESINFODB mdlTestInfoDB = new ModelTESINFODB();
            mdlTestInfoDB.F_TEST_TASK_ID = strTaskid;
            mdlTestInfoDB.F_TEST_INFODBFILENAME = strTaskid + ".mdb";

            using (FileStream fs = new FileStream(mdbFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {            
                byte[] byteFile = new byte[fs.Length];
                fs.Read(byteFile, 0, (int)fs.Length);
                fs.Close();
                mdlTestInfoDB.F_TEST_INFODB = byteFile;
            }
            
            mdlTestInfoDB.F_CREATE_TIME = DateTime.Now;
            mdlTestInfoDB.F_OPERATOR_ID = AppGlobal.GUserId;
            mdlTestInfoDB.F_OPERATIONTIME = DateTime.Now;
            mdlTestInfoDB.F_DEL = 0;

            try
            {
                ProxyBllTESINFODB bllTestDb = new ProxyBllTESINFODB();
                bllTestDb.Add(mdlTestInfoDB);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("将试验信息Access文件写入Oracle时错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        /// <summary>
        /// 保存任务按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            int saveflag = 0;

            string now_taskId = "";
            now_taskId = txtTaskId.Text;

            if (!now_taskId.Trim().Equals(""))
            {
                //2015年10月18日修改，增加保存试验任务时判断该任务编号是否存在已运行的样品（t_test_allocation表trunc(f_sample_status/10)>1）
                //如果存在，不可进行保存操作
                ProxyBllTEST_ALLOCATION bllTestAllocation = new ProxyBllTEST_ALLOCATION();
                DataSet dsTestSample = bllTestAllocation.GetList(" trunc(F_SAMPLE_STATUS/10)>1 AND F_TEST_TASK_ID='" + now_taskId + "' ");
                if (dsTestSample != null && dsTestSample.Tables[0].Rows.Count != 0)
                {
                    MessageBox.Show("任务编号：" + now_taskId + "的试验任务中存在已运行的样品，不可进行保存操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //判断该试验任务编号的信息是否处于“已提交”状态
                //如果当前保存任务为“已提交”状态任务，执行保存操作后，提示任务状态将修改为“未提交”状态。需要重新执行提交操作。
                ProxyBllTESINFODB bllTestDB = new ProxyBllTESINFODB();
                DataSet dsTaskId = bllTestDB.GetList(" F_TEST_TASK_ID='" + now_taskId + "' ");
                if (dsTaskId != null && dsTaskId.Tables[0].Rows.Count != 0)
                {
                    DialogResult dialogResult = XtraMessageBox.Show("任务编号：" + now_taskId + "的试验任务已提交，是否重新保存任务信息？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        bllTestDB.DropWhere(" F_TEST_TASK_ID='" + now_taskId + "' ");
                    }
                }
                //判断试验基础信息必填项是否已填写
                //试验基础信息必填项已填写，保存该组数据到T_TEST_INFO表中
                if (judgeTestBaseInfo())
                {
                    BllTEST_INFO blltest_info = new BllTEST_INFO();

                    //判断该任务编号在数据库中是否存在，如果存在进行修改处理，否则进行新增操作
                    DataSet dsTaskCount = blltest_info.GetTaskCount(now_taskId);
                    int temptaskCount = -1;

                    if (dsTaskCount != null)
                    {
                        if (dsTaskCount.Tables[0].Rows.Count > 0)
                        {
                            temptaskCount = Convert.ToInt16(dsTaskCount.Tables[0].Rows[0][0].ToString());
                        }
                    }
                    if (temptaskCount == 0)  //新增操作
                    {
                        try
                        {
                            //将试验任务数据写入Model类中
                            CreateOrUpdateTestInfo(1);
                            blltest_info.Add(_mdlTestInfo);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("任务编号:" + now_taskId + "的试验基础信息新增保存错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else  //修改操作
                    {
                        try
                        {
                            //将试验任务数据写入Model类中
                            CreateOrUpdateTestInfo(2);
                            blltest_info.Update(_mdlTestInfo);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("任务编号:" + now_taskId + "的试验基础信息修改保存错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    saveflag = saveflag + 1;
                }

                //2015年10月18日修改--判断该任务是否可修改样品，如果可以，执行保存，如不可以，不需执行保存样品的操作
                if (gcSampleInfoList.Enabled)
                {

                    //判断试验样品信息是否有数据行，各数据行的数据是否有效
                    if (judgeTestSampleInfo())
                    {
                        //试验样品信息各数据行的数据有效，保存该组数据到T_TEST_SAMPLE_INFO表中
                        ProxyBllTEST_SAMPLE_INFO bllTestSampleInfo = new ProxyBllTEST_SAMPLE_INFO();

                        //删除该任务编号的样品数据
                        bllTestSampleInfo.DropByTaskId(now_taskId);

                        for (int i = 0; i < _TestSampleTable.Rows.Count; i++)
                        {
                            var modelTestSampleInfo = new ModelTEST_SAMPLE_INFO();
                            modelTestSampleInfo.F_TEST_TASK_ID = now_taskId;
                            modelTestSampleInfo.F_SAMPLE_NUM = Convert.ToInt16(_TestSampleTable.Rows[i]["F_SAMPLE_NUM"].ToString());
                            modelTestSampleInfo.F_SAMPLE_GROUP_NUM = _TestSampleTable.Rows[i]["F_SAMPLE_GROUP_NUM"].ToString();
                            modelTestSampleInfo.F_SAMPLE_MEMO = _TestSampleTable.Rows[i]["F_SAMPLE_MEMO"].ToString();
                            modelTestSampleInfo.F_CREATE_TIME = DateTime.Now;
                            modelTestSampleInfo.F_OPERATOR_ID = AppGlobal.GUserId;
                            modelTestSampleInfo.F_OPERATIONTIME = DateTime.Now;
                            modelTestSampleInfo.F_DEL = 0;

                            bllTestSampleInfo.Add(modelTestSampleInfo);

                        }

                        //生成样品编号，并写入T_TEST_ALLOCATION表中，写入任务编号F_TEST_TASK_ID、样品编号F_TEST_SAMPLE_ID字段
                        //运行状态F_SAMPLE_STATUS值为-1，状态为未分配                   

                        //删除该任务编号的样品分配信息数据
                        string dropWhere = "";
                        dropWhere = " F_TEST_TASK_ID='" + now_taskId + "' ";
                        bllTestAllocation.DropWhere(dropWhere);

                        //生成任务编号now_taskId的样品编号信息，并写入T_TEST_ALLOCATION
                        for (int i = 0; i < _TestSampleTable.Rows.Count; i++)
                        {
                            var modelTestAllocation = new ModelTEST_ALLOCATION();

                            int temp_sample_num = Convert.ToInt16(_TestSampleTable.Rows[i]["F_SAMPLE_NUM"].ToString());
                            string temp_group_num = _TestSampleTable.Rows[i]["F_SAMPLE_GROUP_NUM"].ToString();
                            for (int k = 1; k <= temp_sample_num; k++)
                            {
                                modelTestAllocation.F_TEST_TASK_ID = now_taskId;

                                //以%2f的形式显示
                                if (k < 10)
                                    modelTestAllocation.F_TEST_SAMPLE_ID = temp_group_num + "-0" + k.ToString();
                                else
                                    modelTestAllocation.F_TEST_SAMPLE_ID = temp_group_num + "-" + k.ToString();
                                //样品编码，试验样品待分配试验通道，状态值为11
                                modelTestAllocation.F_SAMPLE_STATUS = 11;
                                modelTestAllocation.F_CREATE_TIME = DateTime.Now;
                                modelTestAllocation.F_OPERATOR_ID = AppGlobal.GUserId;
                                modelTestAllocation.F_OPERATIONTIME = DateTime.Now;
                                modelTestAllocation.F_DEL = 0;
                                bllTestAllocation.Add_KHD(modelTestAllocation);
                            }
                        }

                        saveflag = saveflag + 10;
                    }
                }

                //判断试验参数数据填写的值是否有效
                if (judgeTestCommParInfo())
                {
                    //试验参数数据填写值有效，保存
                    ProxyBllTEST_PAR_VALUE_KHD bllTestParValue = new ProxyBllTEST_PAR_VALUE_KHD();
                    //删除该任务编号的试验开始命令参数值
                    bllTestParValue.DropByTaskId(now_taskId);

                    for (int i = 0; i < _TestCommStartPar.Rows.Count; i++)
                    {
                        var ModelTEST_PAR_VALUE_KHD = new ModelTEST_PAR_VALUE_KHD();
                        ModelTEST_PAR_VALUE_KHD.F_TASK_ID = now_taskId;
                        //程序代码：在客户端表中备用，均填写为000
                        ModelTEST_PAR_VALUE_KHD.F_PROGRAM_CODE = "000";
                        ModelTEST_PAR_VALUE_KHD.F_SENDPAR_NAME = _TestCommStartPar.Rows[i]["F_SENDPAR_NAME"].ToString();
                        ModelTEST_PAR_VALUE_KHD.F_SENDPAR_VALUE = _TestCommStartPar.Rows[i]["F_SENDPAR_VALUE"].ToString();
                        //ModelTEST_PAR_VALUE_KHD.F_SENDPAR_UNIT = _TestCommStartPar.Rows[i]["F_PAR_UNIT"].ToString();
                        ModelTEST_PAR_VALUE_KHD.F_SENDORDER = Convert.ToInt16(_TestCommStartPar.Rows[i]["colSENDORDER"].ToString());
                        ModelTEST_PAR_VALUE_KHD.F_CREATE_TIME = DateTime.Now;
                        ModelTEST_PAR_VALUE_KHD.F_OPERATOR_ID = AppGlobal.GUserId;
                        ModelTEST_PAR_VALUE_KHD.F_OPERATIONTIME = DateTime.Now;
                        ModelTEST_PAR_VALUE_KHD.F_DEL = 0;

                        bllTestParValue.Add(ModelTEST_PAR_VALUE_KHD);

                    }
                    saveflag = saveflag + 100;
                }
                //根据saveflag的标志信息
                if (saveflag == 111) //试验基础信息、试验样品信息、试验参数信息均保存完成
                {
                    MessageBox.Show("任务编号:" + now_taskId + "的试验基础信息、试验样品信息、试验参数信息保存完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (saveflag == 110)//试验样品信息、试验参数信息均保存完成
                {
                    MessageBox.Show("任务编号:" + now_taskId + "的试验样品信息、试验参数信息保存完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (saveflag == 101)//试验基础信息、试验参数信息均保存完成
                {
                    MessageBox.Show("任务编号:" + now_taskId + "的试验基础信息、试验参数信息保存完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (saveflag == 11) //试验基础信息、试验样品信息保存完成
                {
                    MessageBox.Show("任务编号:" + now_taskId + "的试验基础信息、试验样品信息保存完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (saveflag == 100) //试验参数信息保存完成
                {
                    MessageBox.Show("任务编号:" + now_taskId + "的试验参数信息保存完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (saveflag == 10) //试验样品信息保存完成
                {
                    MessageBox.Show("任务编号:" + now_taskId + "的试验样品信息保存完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (saveflag == 1) //试验基础信息保存完成
                {
                    MessageBox.Show("任务编号:" + now_taskId + "的试验基础信息保存完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (saveflag != 0)
                {
                    initData();
                    BindGridview();
                    string tempstr = ""; ;
                    for (int i = 0; i < lstTasklist.ItemCount; i++)
                    {
                        tempstr = lstTasklist.Items[i].ToString();
                        if (tempstr.Substring(0, tempstr.IndexOf("_")).Equals(now_taskId))
                        {
                            lstTasklist.SelectedIndex = i;
                            break;                                ;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 判断试验基础信息的数据项是否填写完整有效
        /// 必填项是否填写
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private bool judgeTestBaseInfo()
        {
            if (txtTaskId.Text.Trim().Equals(""))
            {
                MessageBox.Show("试验任务编号不能为空，请填写试验任务编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtTestItem.Text.Trim().Equals(""))
            {
                MessageBox.Show("检测项目不能为空，请填写检测项目！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtTestModel.Text.Trim().Equals(""))
            {
                MessageBox.Show("规格型号不能为空，请填写规格型号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtTestStandard.Text.Trim().Equals(""))
            {
                MessageBox.Show("检测标准不能为空，请填写检测标准！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtTestProperty.Text.Trim().Equals(""))
            {
                MessageBox.Show("检测性质不能为空，请填写检测性质！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtTestAim.Text.Trim().Equals(""))
            {
                MessageBox.Show("检测目的不能为空，请填写检测目的！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtContact.Text.Trim().Equals(""))
            {
                MessageBox.Show("联系人不能为空，请填写联系人！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtCharge.Text.Trim().Equals(""))
            {
                MessageBox.Show("负责人不能为空，请填写负责人！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        /// <summary>
        /// 将数据写入试验任务信息表中(TEST_INFO)Model
        /// 参数：operType=1：新增Add操作；operType=2:修改Update操作
        /// </summary>
        /// <returns></returns>
        private void CreateOrUpdateTestInfo(int operType)
        {

            this._mdlTestInfo = new ModelTEST_INFO();
            //任务编号
            this._mdlTestInfo.F_TEST_TASK_ID = txtTaskId.Text.Trim();
            //检测项目
            this._mdlTestInfo.F_TEST_ITEM = txtTestItem.Text.Trim();
            //规格型号
            this._mdlTestInfo.F_TEST_MODEL = txtTestModel.Text.Trim();
            //检测标准
            this._mdlTestInfo.F_TEST_STANDARD = txtTestStandard.Text.Trim();
            //检测性质
            this._mdlTestInfo.F_TEST_PROPERTY = txtTestProperty.Text.Trim();
            //检测目的
            this._mdlTestInfo.F_TEST_AIM = txtTestAim.Text.Trim();
            //委托单位
            this._mdlTestInfo.F_TASK_DEPUTE_UNIT = txtDeputeUnit.Text.Trim();
            //联系人
            this._mdlTestInfo.F_CONTACT = txtContact.Text.Trim();
            //电话
            this._mdlTestInfo.F_PHONE = txtPhone.Text.Trim();
            //email
            this._mdlTestInfo.F_EMAIL = txtEmail.Text.Trim();
            //负责人
            this._mdlTestInfo.F_TEST_CHARGE = txtCharge.Text.Trim();
            //委托日期
            this._mdlTestInfo.F_TASK_DEPUTE_DATE = dateEdit_task.DateTime;

            //样品系列、样品类别、序列试验目前界面不显示，数据库中填写下面的默认值。
            //样品系列
            this._mdlTestInfo.F_TEST_SERIES = "";
            //样品类别
            this._mdlTestInfo.F_SAMPLE_TYPE = "";           
            //序列试验
            this._mdlTestInfo.F_SEQUENCE_TEST = 0;   

            //试验任务状态;新增试验任务，状态为10：等待试验开始
            this._mdlTestInfo.F_TEST_STATUS = 10;

            //创建时间
            if (operType == 1)
                this._mdlTestInfo.F_CREATE_TIME = DateTime.Now;
            //操作员
            this._mdlTestInfo.F_OPERATOR_ID = AppGlobal.GUserId;
            //操作时间
            this._mdlTestInfo.F_OPERATIONTIME = DateTime.Now;
            //是否删除
            this._mdlTestInfo.F_DEL = 0;
        }

        // <summary>
        /// 判断试验样品息的数据项是否填写完整有效
        /// 必填项是否填写
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private bool judgeTestSampleInfo()
        {
            if (_TestSampleTable.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < _TestSampleTable.Rows.Count; i++)
                {
                    if (_TestSampleTable.Rows[i]["F_SAMPLE_NUM"].ToString().Trim().Equals(""))
                    {
                        MessageBox.Show("试验样品信息表第"+(i+1).ToString()+"行样品数量未填写，请输入该项数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                    if (_TestSampleTable.Rows[i]["F_SAMPLE_GROUP_NUM"].ToString().Trim().Equals(""))
                    {
                        MessageBox.Show("试验样品信息表第" + (i + 1).ToString() + "行样品组别未填写，请输入该项数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }
            //判断是否存在多行输入了相同的样品组别
            for (int i = 0; i < _TestSampleTable.Rows.Count; i++)
            {
                string temp_group = _TestSampleTable.Rows[i]["F_SAMPLE_GROUP_NUM"].ToString().Trim();
                for (int j =i+1; j < _TestSampleTable.Rows.Count; j++)
                {
                    if (_TestSampleTable.Rows[j]["F_SAMPLE_GROUP_NUM"].ToString().Trim().Equals(temp_group))
                    {
                        MessageBox.Show("试验样品信息表第" + (i + 1).ToString() + "行与第"+(j+1).ToString()+"行输入了相同的样品组别，请更正!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// 判断试验参数信息的数据项是否填写完整有效
        /// 必填项是否填写
        /// </summary>
        private bool judgeTestCommParInfo()
        {
            if (_TestSampleTable.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                for (int i = 0; i <_TestCommStartPar.Rows.Count; i++)
                {
                    if (_TestCommStartPar.Rows[i]["F_SENDPAR_VALUE"].ToString().Trim().Equals(""))
                    {
                        MessageBox.Show("试验参数信息表第" + (i + 1).ToString() + "行:" + _TestCommStartPar.Rows[i]["F_SENDPAR_NAME"].ToString().Trim()
                            +"的参数值未填写，请输入该项数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// 任务编号列表中选择的数据项发生改变时，读取新选择任务编号的信息
        /// 并在右侧的窗口分别显示试验任务基础信息、试验样品信息、试验参数信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstTasklist_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nowTaskId = "";
            if (lstTasklist.SelectedIndex >= 0)
            {
                
                string tempstr = lstTasklist.SelectedItem.ToString();
                nowTaskId = tempstr;

                //根据任务编号nowTaskId显示试验任务基础信息
                displayTaskBaseInfoByTaskId(nowTaskId);

                //根据任务编号nowTaskId显示试验任务样品信息
                displayTaskSampleInfoByTaskId(nowTaskId);

                //根据任务编号nowTaskId显示试验任务参数信息
                displayTaskCommParInfoByTaskId(nowTaskId);
            }
        }

        /// <summary>
        /// 根据任务编号显示试验任务基本信息的内容
        /// </summary>
        /// <param name="taskId">任务编号</param>
        private void displayTaskBaseInfoByTaskId(string taskId)
        {
            BllLIMS_DOWNLOAD_PARA bllLims_download_para = new BllLIMS_DOWNLOAD_PARA();
            //BllTEST_INFO blltest_info = new BllTEST_INFO();
            DataSet dsTestInfo = bllLims_download_para.GetListByTaskId(taskId);

            if (dsTestInfo != null)
            {
                //试验任务编号
                txtTaskId.Text = dsTestInfo.Tables[0].Rows[0]["任务编号"].ToString();
                //检测项目
                //txtTestItem.Text = dsTestInfo.Tables[0].Rows[0]["检测项目"].ToString();
                txtTestItem.Text = "空";
                //规格型号
                txtTestModel.Text = dsTestInfo.Tables[0].Rows[0]["规格型号"].ToString();
                //检测标准
                txtTestStandard.Text = dsTestInfo.Tables[0].Rows[0]["检测标准"].ToString();
                //检测性质
                txtTestProperty.Text = dsTestInfo.Tables[0].Rows[0]["检测性质"].ToString();
                //检测目的
                if (dsTestInfo.Tables[0].Rows[0]["检测目的"].ToString().Equals(""))
                    txtTestAim.Text = "未填写";
                else
                    txtTestAim.Text = dsTestInfo.Tables[0].Rows[0]["检测目的"].ToString();
                //委托单位
                txtDeputeUnit.Text = dsTestInfo.Tables[0].Rows[0]["委托单位"].ToString();
                //联系人
                txtContact.Text = dsTestInfo.Tables[0].Rows[0]["联系人"].ToString();
                //电话
                txtPhone.Text = dsTestInfo.Tables[0].Rows[0]["电话"].ToString();
                //email
                txtEmail.Text = dsTestInfo.Tables[0].Rows[0]["EMAIL"].ToString();
                //负责人
                txtCharge.Text = dsTestInfo.Tables[0].Rows[0]["负责人"].ToString();
                //txtCharge.Text = "LIMS";
                //委托日期
                dateEdit_task.Text = string.Format("{0:yyyy/MM/dd}", Convert.ToDateTime(dsTestInfo.Tables[0].Rows[0]["委托日期"].ToString()));
            }
        }

        /// <summary>
        /// 根据任务编号显示试验任务样品信息的内容
        /// </summary>
        /// <param name="taskId">任务编号</param>
        private void displayTaskSampleInfoByTaskId(string taskId)
        {
            RemoveALLRow(_TestSampleTable);
            //从Lims数据库中，读取选定试验任务的试验样品数据
            ProxyBllLIMS_DOWNLOAD_SAM blllimsDownLoadSample = new ProxyBllLIMS_DOWNLOAD_SAM();
            //ProxyBllTEST_SAMPLE_INFO bllTestSampleInfo = new ProxyBllTEST_SAMPLE_INFO();

            _TestSampleTable = blllimsDownLoadSample.GetAndDisplaySampleInfo(_TestSampleTable, taskId);

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

            //根据Lims试验任务编号lims视图中读取该试验任务参数值   
            ProxyBllTEST_PAR_VALUE_KHD bllTestParValue = new ProxyBllTEST_PAR_VALUE_KHD();
            _TestCommStartPar = bllTestParValue.GetAndDisplayParValueFromLimsView(_TestCommStartPar, taskId);
           
            gcParValue.DataSource = _TestCommStartPar;
            if (_TestCommStartPar.Rows.Count == 0)
            {
                QueryAndDis_CommPar();
            }
            
        }

        /// <summary>
        /// 删除任务按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string now_taskId = "";
            now_taskId = txtTaskId.Text;

            if (now_taskId.Trim().Equals(""))
            {
                MessageBox.Show("要删除的任务编号为空，不能执行试验任务删除操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!selecttaskinfo.Equals("") && selecttaskinfo.IndexOf("已分配")>0)
            {
                MessageBox.Show("要删除的任务编号中存在已分配样品，先到上位机系统清除该任务分配信息后，方可执行本试验任务的删除操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dialogResult = XtraMessageBox.Show("确定要删除试验任务编号为："+now_taskId+"的试验任务吗？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                return;
            }
            else
            {
                ProxyBllTEST_INFO blltest_info = new ProxyBllTEST_INFO();
                //判断试验任务状态，只有F_TEST_STATUS=10的试验任务编号
                DataSet dsTestInfo = blltest_info.GetListByTaskId(now_taskId);
                if (dsTestInfo != null)
                {
                    string strTestStatus = dsTestInfo.Tables[0].Rows[0]["F_TEST_STATUS"].ToString().Trim();
                    //试验任务处于未开始状态
                    if (strTestStatus.Equals("10"))
                    {
                       //获取试验任务的已分配样品数量，已分配样品数量为0的试验任务，方可执行删除操作
                        
                        //删除试验任务基本信息
                        blltest_info.Drop(now_taskId);
                        //删除试验试验任务样品信息
                        ProxyBllTEST_SAMPLE_INFO blltestSampleInfo = new ProxyBllTEST_SAMPLE_INFO();
                        blltestSampleInfo.DropByTaskId(now_taskId);
                        //删除试验任务参数信息
                        ProxyBllTEST_PAR_VALUE_KHD blltestCommParInfo = new ProxyBllTEST_PAR_VALUE_KHD();
                        blltestCommParInfo.DropByTaskId(now_taskId);
                        //删除试验任务
                        ProxyBllTESINFODB blltestDB = new ProxyBllTESINFODB();
                        blltestDB.Drop(now_taskId);
                        //删除样品分配表数据
                        ProxyBllTEST_ALLOCATION bllTestAllocation = new ProxyBllTEST_ALLOCATION();
                        bllTestAllocation.DropWhere(" F_TEST_TASK_ID='" + now_taskId + "' ");
                        //读取未开始试验的试验任务
                        BindGridview();
                    }
                    else
                    {
                        if (strTestStatus.Substring(0,1).Equals("2"))
                        {
                            MessageBox.Show("该试验任务目前处于运行状态，不能执行删除操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else if (strTestStatus.Substring(0, 1).Equals("6"))
                        {
                            MessageBox.Show("该试验任务目前处于结束状态，不能执行删除操作!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        
                    }
                }
            }
           
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //首先判断试验任务编号数据项是否为空，如果为空，不可执行提交操作
            if (txtTaskId.Text.Trim().Equals(""))
            {
                MessageBox.Show("请选择需要执行导出文件操作的任务编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string now_taskid = txtTaskId.Text;

            ProxyBllTESINFODB blltestInfoDb = new ProxyBllTESINFODB();
            DataSet dsTaskId = blltestInfoDb.GetList("F_TEST_TASK_ID='"+now_taskid+"'");

            if (dsTaskId == null || dsTaskId.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("任务编号:"+now_taskid+"的试验任务数据文件信息不存在，不能执行导出文件操作！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (!exportSelectPath.Equals(""))
                    fbd.SelectedPath = exportSelectPath;
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists( fbd.SelectedPath + "/" + now_taskid + ".mdb") == true)
                    {
                        File.Delete( fbd.SelectedPath + "/" + now_taskid + ".mdb");
                        File.Delete( fbd.SelectedPath + "/" + now_taskid + ".ldb");
                    }

                    byte[] byteArray = (Byte[])dsTaskId.Tables[0].Rows[0]["F_TEST_INFODB"];
                    //string strfn = "d:/" + now_taskid + ".mdb";
                    exportSelectPath = fbd.SelectedPath;                   
                    string strfn = fbd.SelectedPath + "/" + now_taskid + ".mdb"; 
                    using (FileStream fs = new FileStream
                            (strfn, FileMode.CreateNew, FileAccess.Write))
                    {
                        fs.Write(byteArray, 0, byteArray.Length);
                    }
                    MessageBox.Show("文件已导出至"+fbd.SelectedPath+"文件夹下，文件名为"+now_taskid + ".mdb！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void baseSimpleButton1_Click(object sender, EventArgs e)
        {
            FrmTaskForSubSendp frm = new FrmTaskForSubSendp();
            BindClickEventToAllBuutonControl(frm);
            frm.ShowDialog();
        }
        public void BindClickEventToAllBuutonControl(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is SimpleButton)
                {
                    ((SimpleButton)control).Click += FormButtonClick;
                }

                if (control.Controls.Count > 0)
                {
                    BindClickEventToAllBuutonControl(control);
                }

            }
        }
        /// <summary>
        /// bind to every menuitem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormButtonClick(object sender,
                                  EventArgs e)
        {
            if (sender is SimpleButton)
            {
                Form findForm = (sender as SimpleButton).FindForm();
                if (findForm != null)
                {
                    string modelName = findForm.Text;

                    modelName += "->" + (sender as SimpleButton).Text;
                    ApplicationCommon.WriteApplicationLogs(modelName);
                }
            }
        }

        private void btnDelSampleLine_Click(object sender, EventArgs e)
        {
            int rowIndex = gvSampleInfoList.GetDataSourceRowIndex(gvSampleInfoList.FocusedRowHandle);
            gvSampleInfoList.DeleteRow(rowIndex);

        }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }      
    }
}