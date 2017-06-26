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
    public partial class FrmCommWorktype : DevExpress.XtraEditors.XtraForm
    {
        #region 声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmCommWorktype));

        //操作类
        private ProxyBllPAR_COMMAND_WORKTYPE _bllCommandWorktypeProgramm = new ProxyBllPAR_COMMAND_WORKTYPE();

        //数据集
        private DataSet _dsCommandWorktypeProgramm = new DataSet();

        //参数信息
        private ModelPAR_COMMAND_WORKTYPE _mdlCommandWorktypeProgramm;

        #endregion

        public FrmCommWorktype()
        {
            InitializeComponent();
        }

        private void FrmCommandWorktypeProgramm_Load(object sender, EventArgs e)
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
            txtWorktypeName.Text = "";
            txtWorktypeCode.Text = "";
            txtProgrammCode.Text = "";
            txtProgrammDesc.Text = "";
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
                _dsCommandWorktypeProgramm = _bllCommandWorktypeProgramm.GetAllList();

                //有数据情况下绑定
                if (_dsCommandWorktypeProgramm != null && _dsCommandWorktypeProgramm.Tables.Count > 0)
                {
                    gcList.DataSource = _dsCommandWorktypeProgramm.Tables[0];
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
            string now_WorktypeId = "";
            now_WorktypeId = txtId.Text;
            string now_WorktypeName = "";
            now_WorktypeName = txtWorktypeName.Text;
            string now_ProgrammCode = "";
            now_ProgrammCode = txtProgrammCode.Text;
            DialogResult dialogResult = XtraMessageBox.Show("确认执行工作模式：" + now_WorktypeName + ",程序代码:" + now_ProgrammCode + "的删除操作吗？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                ProxyBllPAR_COMMAND_WORKTYPE _bllCommandWorktypeProgramm = new ProxyBllPAR_COMMAND_WORKTYPE();
                _bllCommandWorktypeProgramm.Delete(Convert.ToInt16(now_WorktypeName));
                //读取参数信息
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

                txtId.Text = gvList.GetFocusedRowCellValue("F_ID").ToString();
                txtWorktypeName.Text = gvList.GetFocusedRowCellValue("F_WORKTYPE_NAME").ToString();
                txtWorktypeCode.Text = gvList.GetFocusedRowCellValue("F_WORKTYPE_CODE").ToString();
                txtProgrammCode.Text = gvList.GetFocusedRowCellValue("F_PROGRAMM_CODE").ToString();
                txtProgrammDesc.Text = gvList.GetFocusedRowCellValue("F_PROGRAMM_DESC").ToString();

                txtMemo.Text = gvList.GetFocusedRowCellValue("F_WORKTYPE_MEMO").ToString();

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
            ProxyBllPAR_COMMAND_WORKTYPE bllCommandWorktypeProgramm = new ProxyBllPAR_COMMAND_WORKTYPE();
            //置灰保存按钮
            btnSave.Enabled = false;

            //判断该命令字编号在数据库中是否存在，如果存在进行修改处理，否则进行新增操作
            string now_Id = "";
            now_Id = txtId.Text;

            DataSet dsCommandWorktypeCount = bllCommandWorktypeProgramm.GetCount(now_Id);

            int tempCount = -1;

            if (dsCommandWorktypeCount != null)
            {
                if (dsCommandWorktypeCount.Tables[0].Rows.Count > 0)
                {
                    tempCount = Convert.ToInt16(dsCommandWorktypeCount.Tables[0].Rows[0][0].ToString());
                }
            }
            if (tempCount == 0)  //新增操作
            {
                try
                {
                    //将产品标准数据写入Model类中
                    CreateOrUpdateInfo(1);
                    bllCommandWorktypeProgramm.Add(_mdlCommandWorktypeProgramm);
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
                        CreateOrUpdateInfo(2);
                        bllCommandWorktypeProgramm.Update(_mdlCommandWorktypeProgramm);
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
        /// 将数据写入发送命令参数元数据表中(T_COMMAND_PAR_SEND)Model
        /// 参数：operType=1：新增Add操作；operType=2:修改Update操作
        /// </summary>
        /// <returns></returns>
        private void CreateOrUpdateInfo(int operType)
        {

            this._mdlCommandWorktypeProgramm = new ModelPAR_COMMAND_WORKTYPE();


            this._mdlCommandWorktypeProgramm.F_ID = Convert.ToInt16(txtId.Text);

            this._mdlCommandWorktypeProgramm.F_WORKTYPE_NAME = txtWorktypeName.Text;

            this._mdlCommandWorktypeProgramm.F_WORKTYPE_CODE = txtWorktypeCode.Text;

            this._mdlCommandWorktypeProgramm.F_PROGRAMM_CODE = txtProgrammCode.Text;

            this._mdlCommandWorktypeProgramm.F_PROGRAMM_DESC = txtProgrammDesc.Text;

            this._mdlCommandWorktypeProgramm.F_WORKTYPE_MEMO = txtMemo.Text;

            //创建时间
            if (operType == 1)
                this._mdlCommandWorktypeProgramm.F_CREATE_TIME = DateTime.Now;
            //操作员
            this._mdlCommandWorktypeProgramm.F_OPERATOR_ID = AppGlobal.GUserId;
            //操作时间
            this._mdlCommandWorktypeProgramm.F_OPERATIONTIME = DateTime.Now;
            //是否删除
            this._mdlCommandWorktypeProgramm.F_DEL = 0;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            initData();
            btnSave.Enabled = true;
        }
    }
}