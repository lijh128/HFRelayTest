using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using log4net;
using RelayTest.Model;
using RelayTest.Util.Common;

namespace RelayTest.Application.Settings
{
    
    /// <summary>
    /// 负载柜基础数据
    /// </summary>
    public partial class FrmDevLoadChannelInfo : BaseXtraForm
    {
        #region 声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmDevLoadChannelInfo));


        //操作类
        private ProxyBllDEV_LOAD_CHANNEL_INFO _bllDevLoadChannelInfo = new ProxyBllDEV_LOAD_CHANNEL_INFO();

        //供电柜开关操作model

        private ModelDEV_LOAD_CHANNEL_INFO _modelDevPowerChannelInfo;

        private string _loadId;

        public delegate void SaveEventHandler();

        public event SaveEventHandler SaveHandler;

        #endregion

        #region 事件方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmDevLoadChannelInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmDevLoadChannelInfo(ModelDEV_LOAD_CHANNEL_INFO modelDev):this()
        {

            _loadId = modelDev.F_LOAD_ID;

            _modelDevPowerChannelInfo = modelDev;

        }

        /// <summary>
        /// 窗体载入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPowerBaseInfo_Load(object sender, EventArgs e)
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                //显示数据
                InitAllControls();

            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        ///     初始化界面上的控件
        /// </summary>
        private void InitAllControls()
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //所有选择信息
                FillAllSelectedControls();

                //当前数据显示在控件上
                ShowDataInEditControls();


            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        ///     绑定所有列表信息
        /// </summary>
        private void FillAllSelectedControls()
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //编辑区负载类型
                ApplicationCommon.GetLookUpEditControl(lueF_LOAD_CHANNEL_STATUS, "T_SYSTEM_LIST", "F_VALUE", "编码", "F_DISPLAY", "状态", "F_TYPE='F_LOAD_CHANNEL_STATUS'");

            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 委托事件
        /// </summary>
        public void OnSaveBuutonClickedChange()
        {
            if (SaveHandler != null) SaveHandler();
        }


        /// <summary>
        /// 更新信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //检查必填字段
                bool isAllOk = CheckNotNullField();

                if (!isAllOk)
                    return;

                //准备要存储的数据
                ModelDEV_LOAD_CHANNEL_INFO modelDevLoadChannelInfo = PrepareModelLoadChannelInfo();


                //判断此数据是否已经存在
                bool isDataExist = _bllDevLoadChannelInfo.Exists(modelDevLoadChannelInfo.F_LOAD_ID,modelDevLoadChannelInfo.F_LOAD_CHANNEL_ID);

                if (isDataExist)
                {

                    //已经存在判断是否更新
                    DialogResult dialogResult = XtraMessageBox.Show("当前数据已存在，是否更新？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    //更新数据
                    bool status = _bllDevLoadChannelInfo.Update(modelDevLoadChannelInfo);


                    if (status)
                    {
                        XtraMessageBox.Show("此数据已更新。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("没有数据被更新，操作中断。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    _bllDevLoadChannelInfo.Add(modelDevLoadChannelInfo);


                    XtraMessageBox.Show("此数据已增加。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                OnSaveBuutonClickedChange();

            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 启动其中的一条记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnabled_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //检查必填字段
                bool isAllOk = CheckNotNullField();

                if (!isAllOk)
                    return;

                //准备要存储的数据
                ModelDEV_LOAD_CHANNEL_INFO modelDevLoadChannelInfo = PrepareModelLoadChannelInfo();

                //更新数据
                bool status = _bllDevLoadChannelInfo.Enabled(modelDevLoadChannelInfo.F_LOAD_ID, modelDevLoadChannelInfo.F_LOAD_CHANNEL_ID);

                if (status)
                {
                    XtraMessageBox.Show("此数据已启用。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("没有数据被更新。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }


        /// <summary>
        /// 禁用其中的一条记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisabled_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                //禁用前判断
                DialogResult dialogResult = XtraMessageBox.Show("此操作可能导致其他关联数据出错，是否继续？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }

                //检查必填字段
                bool isAllOk = CheckNotNullField();

                if (!isAllOk)
                    return;

                //准备要存储的数据
                ModelDEV_LOAD_CHANNEL_INFO modelDevLoadChannelInfo = PrepareModelLoadChannelInfo();

                //更新数据
                bool status = _bllDevLoadChannelInfo.Disabled(modelDevLoadChannelInfo.F_LOAD_ID, modelDevLoadChannelInfo.F_LOAD_CHANNEL_ID);

                if (status)
                {
                    XtraMessageBox.Show("此数据已禁用。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("没有数据被更新。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }



        /// <summary>
        /// 彻底删除一条记录，一旦删除无法恢复，建议不要使用此功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                //删除前判断
                DialogResult dialogResult = XtraMessageBox.Show("此操作将永久删除数据并有可能导致其他关联数据出错，是否继续？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }

                //检查必填字段
                bool isAllOk = CheckNotNullField();

                if (!isAllOk)
                    return;

                //准备要存储的数据
                ModelDEV_LOAD_CHANNEL_INFO modelDevLoadChannelInfo = PrepareModelLoadChannelInfo();

                //更新数据
                bool status = _bllDevLoadChannelInfo.Drop(modelDevLoadChannelInfo.F_LOAD_ID, modelDevLoadChannelInfo.F_LOAD_CHANNEL_ID);

                if (status)
                {
                    XtraMessageBox.Show("此数据已删除。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("没有数据被更新。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                OnSaveBuutonClickedChange();
            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        #endregion

        #region 自定义方法

        /// <summary>
        /// 将数据显示在控件中
        /// </summary>
        private void ShowDataInEditControls()
        {

            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");



                if (_modelDevPowerChannelInfo == null)
                    return;

                //负载柜编号
                txtF_LOAD_ID.Text = _modelDevPowerChannelInfo.F_LOAD_ID;

                //通道序号		
                txtF_LOAD_CHANNEL_ID.Text = _modelDevPowerChannelInfo.F_LOAD_CHANNEL_ID;

                //通道名称		
                txtF_LOAD_CHANNEL_NAME.Text = _modelDevPowerChannelInfo.F_LOAD_CHANNEL_ID;
            
                //校准编号
                txtF_LOAD_CHANNEL_CALIBRATION.Text = _modelDevPowerChannelInfo.F_LOAD_CHANNEL_CALIBRATION;

                //负载可用状态		
                lueF_LOAD_CHANNEL_STATUS.EditValue = (decimal)_modelDevPowerChannelInfo.F_LOAD_CHANNEL_STATUS;
            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }


        }

        /// <summary>
        /// 检查必填字段是否已经完全填充
        /// </summary>
        /// <returns></returns>
        private bool CheckNotNullField()
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //编号
                if (string.IsNullOrEmpty(txtF_LOAD_CHANNEL_ID.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("通道编号不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //名称
                if (string.IsNullOrEmpty(txtF_LOAD_CHANNEL_NAME.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("通道名称不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


             
                //可用状态
                if (lueF_LOAD_CHANNEL_STATUS.EditValue == null)
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("可用状态不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }

        }

        /// <summary>
        /// 创建存储类
        /// </summary>
        /// <returns></returns>
        private ModelDEV_LOAD_CHANNEL_INFO PrepareModelLoadChannelInfo()
        {

            ModelDEV_LOAD_CHANNEL_INFO modelDevLoadChannelInfo = new ModelDEV_LOAD_CHANNEL_INFO();

            //负载柜编号

            modelDevLoadChannelInfo.F_LOAD_ID = _loadId;

            //通道序号		
            modelDevLoadChannelInfo.F_LOAD_CHANNEL_ID = txtF_LOAD_CHANNEL_ID.Text;

            //通道名称		
            modelDevLoadChannelInfo.F_LOAD_CHANNEL_NAME = txtF_LOAD_CHANNEL_NAME.Text;

           //校准编号
            modelDevLoadChannelInfo.F_LOAD_CHANNEL_CALIBRATION = txtF_LOAD_CHANNEL_CALIBRATION.Text;
            //通道状态		
            modelDevLoadChannelInfo.F_LOAD_CHANNEL_STATUS = decimal.Parse(lueF_LOAD_CHANNEL_STATUS.EditValue.ToString());

          
            //创建时间		
            DateTime optDateTime = DateTime.Now;
            modelDevLoadChannelInfo.F_CREATE_TIME = optDateTime;

            //操作员		
            modelDevLoadChannelInfo.F_OPERATOR_ID = AppGlobal.GUserId;

            //操作时间		
            modelDevLoadChannelInfo.F_OPERATIONTIME = optDateTime;

            //是否删除		
            modelDevLoadChannelInfo.F_DEL = 0;

            return modelDevLoadChannelInfo;
        }


        /// <summary>
        /// 表格点击，将其中数据显示在下面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        #endregion
    }
}