using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.Refactor.Core;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using log4net;
using RelayTest.Model;
using RelayTest.Util.Common;

namespace RelayTest.Application.CommPar
{
    public partial class FrmCommCode :  BaseXtraForm
    {
        #region 声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmCommCode));

        //操作类
        private ProxyBllCOMMAND_INFO _bllCommand_Info = new ProxyBllCOMMAND_INFO();

        //数据集
        private DataSet _dsCommandInfo = new DataSet();

        //试验任务数据
        private ModelPAR_COMMAND_INFO _mdlCommandInfo;

        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmCommCode()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体载入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTestCommandInfo_Load(object sender, EventArgs e)
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                InitAllControls();

                initData();
                //get data from database
                BindGridview();

            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        #region 自定义方法

        /// <summary>
        ///     初始化界面上的控件
        /// </summary>
        private void InitAllControls()
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 初始化数据显示
        /// </summary>
        private void initData()
        {
            txtId.Text = "";
            txtCode.Text = "";
            txtDesc.Text = "";
            txtMemo.Text = "";
        }  

        /// <summary>
        ///     query data from database and bind to gridview
        /// </summary>
        private void BindGridview()
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //绑定数据
                _dsCommandInfo = _bllCommand_Info.GetAllList();

                //有数据情况下绑定
                if (_dsCommandInfo != null && _dsCommandInfo.Tables.Count > 0)
                {
                    gcList.DataSource = _dsCommandInfo.Tables[0];
                }
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }
        #endregion

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
        /// 彻底删除一条记录，一旦删除无法恢复，建议不要使用此功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string now_CommandCode = "";
            string now_CommandId = "";
            now_CommandId=txtId.Text;
            now_CommandCode = txtCode.Text;
            DialogResult dialogResult = XtraMessageBox.Show("确认执行试验命令字：" + now_CommandCode + "的删除操作吗？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                ProxyBllCOMMAND_INFO bllCommnadInfo = new ProxyBllCOMMAND_INFO();
                bllCommnadInfo.Delete(Convert.ToInt16(now_CommandId),now_CommandCode);
                //读取试验命令字信息
                BindGridview();
            }
        }

        private void gvList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                if (gvList.FocusedRowHandle < 0)
                    return;

                //命令id
                txtId.Text = gvList.GetFocusedRowCellValue("F_COMMAND_ID").ToString();
                //命令编码
                txtCode.Text = gvList.GetFocusedRowCellValue("F_COMMAND_CODE").ToString();
                //命令描述
                txtDesc.Text = gvList.GetFocusedRowCellValue("F_COMMAND_DESC").ToString();
                //备注
                txtMemo.Text = gvList.GetFocusedRowCellValue("F_COMMAND_MEMO").ToString();
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 保存信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            ProxyBllCOMMAND_INFO bllCommand_Info = new ProxyBllCOMMAND_INFO();
            //置灰保存按钮
            btnSave.Enabled = false;

            //判断该命令字编号在数据库中是否存在，如果存在进行修改处理，否则进行新增操作
            string now_CommandCode = "";
            now_CommandCode = txtCode.Text;

            DataSet dsCommandCodeCount = bllCommand_Info.GetCommandCount(now_CommandCode);

            int tempCommandCount = -1;

            if (dsCommandCodeCount != null)
            {
                if (dsCommandCodeCount.Tables[0].Rows.Count > 0)
                {
                    tempCommandCount = Convert.ToInt16(dsCommandCodeCount.Tables[0].Rows[0][0].ToString());
                }
            }
            if (tempCommandCount == 0)  //新增操作
            {
                try
                {
                    //将产品标准数据写入Model类中
                    CreateOrUpdateCommandInfo(1);
                    bllCommand_Info.Add(_mdlCommandInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("系统处理异常，请联系管理员。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else  //修改操作
            {
                //已经存在判断是否执行修改保存
                DialogResult dialogResult = XtraMessageBox.Show("当前数据已存在，是否执行修改保存操作？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {

                        //将产品数据写入Model类中
                        CreateOrUpdateCommandInfo(2);
                        bllCommand_Info.Update(_mdlCommandInfo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("系统处理异常，请联系管理员。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            btnSave.Enabled = true;
            //读取未开始试验的试验任务
            BindGridview();

        }

        /// <summary>
        /// 将数据写入试验命令字信息表中(T_COMMAND_INFO)Model
        /// 参数：operType=1：新增Add操作；operType=2:修改Update操作
        /// </summary>
        /// <returns></returns>
        private void CreateOrUpdateCommandInfo(int operType)
        {

            this._mdlCommandInfo = new ModelPAR_COMMAND_INFO();

            //命令id
            this._mdlCommandInfo.F_COMMAND_ID = Convert.ToInt16(txtId.Text);
            //命令编码
            this._mdlCommandInfo.F_COMMAND_CODE = txtCode.Text;
            //命令描述
            this._mdlCommandInfo.F_COMMAND_DESC = txtDesc.Text;
            //备注
            this._mdlCommandInfo.F_COMMAND_MEMO = txtMemo.Text;

            //创建时间
            if (operType == 1)
                this._mdlCommandInfo.F_CREATE_TIME = DateTime.Now;
            //操作员
            this._mdlCommandInfo.F_OPERATOR_ID = AppGlobal.GUserId;
            //操作时间
            this._mdlCommandInfo.F_OPERATIONTIME = DateTime.Now;
            //是否删除
            this._mdlCommandInfo.F_DEL = 0;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            initData();
            btnSave.Enabled = true;
        }
    }
}