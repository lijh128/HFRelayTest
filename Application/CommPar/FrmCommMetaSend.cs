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
    public partial class FrmCommMetaSend : DevExpress.XtraEditors.XtraForm
    {
        #region 声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmCommMetaSend));

        //操作类
        private ProxyBllCOMMAND_PAR_SEND _bllCommandParSend = new ProxyBllCOMMAND_PAR_SEND();

        //数据集
        private DataSet _dsCommandParSend = new DataSet();

        //参数信息
        private ModelPAR_COMMAND_SEND _mdlCommandParSend;

        #endregion
        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmCommMetaSend()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体载入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCommandParInfo_Load(object sender, EventArgs e)
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
            txtName.Text = "";
            cbbParType.Text = "";
            txtLength.Text = "";
            txtUnit.Text = "";
            txtOrder.Text = "";
            txtValue.Text = "";
            radioSetPos.SelectedIndex = -1;
            radioCommSub.SelectedIndex=-1;
            txtMemo.Text="";
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
                _dsCommandParSend = _bllCommandParSend.GetList_forDis("");

                //有数据情况下绑定
                if (_dsCommandParSend != null && _dsCommandParSend.Tables.Count > 0)
                {
                    gcList.DataSource = _dsCommandParSend.Tables[0];
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
            string now_CommandParId = "";
            now_CommandParId = txtId.Text;
            string now_CommandParName = "";
            now_CommandParName = txtName.Text;
            DialogResult dialogResult = XtraMessageBox.Show("确认执行参数：" + now_CommandParName + "的删除操作吗？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                ProxyBllCOMMAND_PAR_SEND bllCommnadParSend = new ProxyBllCOMMAND_PAR_SEND();
                bllCommnadParSend.Delete(Convert.ToInt16(now_CommandParId));
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

                txtId.Text = gvList.GetFocusedRowCellValue("F_SENDCOMMAND_PAR_ID").ToString();
                txtName.Text = gvList.GetFocusedRowCellValue("F_SENDPAR_NAME").ToString();
                cbbParType.Text = gvList.GetFocusedRowCellValue("F_SENDPAR_DATA_TYPE").ToString();
                txtLength.Text = gvList.GetFocusedRowCellValue("F_SENDPAR_DATA_LENGTH").ToString();
                txtUnit.Text = gvList.GetFocusedRowCellValue("F_SENDPAR_UNIT").ToString();
                txtOrder.Text = gvList.GetFocusedRowCellValue("F_SENDPAR_ORDER").ToString();
                txtValue.Text = gvList.GetFocusedRowCellValue("F_SENDPAR_DEFAULT_VALUE").ToString();
                //数据维护位置
                if (gvList.GetFocusedRowCellValue("F_SENDPAR_SET").ToString().Equals("数据管理客户端"))
                    radioSetPos.SelectedIndex = 0;
                else
                    radioSetPos.SelectedIndex = 1;
                //是否下位机接收参数
                if (gvList.GetFocusedRowCellValue("F_SENDPAR_DISPLAY").ToString().Equals("显示"))
                    radioCommSub.SelectedIndex = 0;
                else
                    radioCommSub.SelectedIndex = 1;

                txtMemo.Text = gvList.GetFocusedRowCellValue("F_SENDPAR_MEMO").ToString();
                
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
            ProxyBllCOMMAND_PAR_SEND bllCommandParSend = new ProxyBllCOMMAND_PAR_SEND();
            //置灰保存按钮
            btnSave.Enabled = false;

            //判断该命令字编号在数据库中是否存在，如果存在进行修改处理，否则进行新增操作
            string now_CommandParId = "";
            now_CommandParId = txtId.Text;

            DataSet dsCommandParCount = bllCommandParSend.GetParCount(now_CommandParId);

            int tempParCount = -1;

            if (dsCommandParCount != null)
            {
                if (dsCommandParCount.Tables[0].Rows.Count > 0)
                {
                    tempParCount = Convert.ToInt16(dsCommandParCount.Tables[0].Rows[0][0].ToString());
                }
            }
            if (tempParCount == 0)  //新增操作
            {
                try
                {
                    //将产品标准数据写入Model类中
                    CreateOrUpdateParInfo(1);
                    bllCommandParSend.Add(_mdlCommandParSend);
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
                        CreateOrUpdateParInfo(2);
                        bllCommandParSend.Update(_mdlCommandParSend);
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
        private void CreateOrUpdateParInfo(int operType)
        {

            this._mdlCommandParSend = new ModelPAR_COMMAND_SEND();

           
            this._mdlCommandParSend.F_SENDCOMMAND_PAR_ID = Convert.ToInt16(txtId.Text);

            this._mdlCommandParSend.F_SENDPAR_NAME = txtName.Text;

            this._mdlCommandParSend.F_SENDPAR_DATA_TYPE = cbbParType.Text;

            this._mdlCommandParSend.F_SENDPAR_DATA_LENGTH = Convert.ToInt16(txtLength.Text);

            this._mdlCommandParSend.F_SENDPAR_UNIT = txtUnit.Text;

            this._mdlCommandParSend.F_SENDPAR_ORDER = Convert.ToInt16(txtOrder.Text);

            this._mdlCommandParSend.F_SENDPAR_DEFAULT_VALUE =txtValue.Text;
            //参数设置位置。1：数据管理客户端；2：上位机
            if (radioSetPos.SelectedIndex == 0)
                this._mdlCommandParSend.F_SENDPAR_SET = 1;
            else
                this._mdlCommandParSend.F_SENDPAR_SET = 2;
            //是否界面显示参数。1：是；0：不是
            if (radioCommSub.SelectedIndex == 0)
                this._mdlCommandParSend.F_SENDPAR_DISPLAY = 1;
            else
                this._mdlCommandParSend.F_SENDPAR_DISPLAY = 0;

            this._mdlCommandParSend.F_SENDPAR_MEMO = txtMemo.Text;

            //创建时间
            if (operType == 1)
                this._mdlCommandParSend.F_CREATE_TIME = DateTime.Now;
            //操作员
            this._mdlCommandParSend.F_OPERATOR_ID = AppGlobal.GUserId;
            //操作时间
            this._mdlCommandParSend.F_OPERATIONTIME = DateTime.Now;
            //是否删除
            this._mdlCommandParSend.F_DEL = 0;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            initData();
            btnSave.Enabled = true;
        }



    }
}