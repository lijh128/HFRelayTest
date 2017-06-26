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
    /// 温度传感器数据维护
    /// </summary>
    public partial class FrmDevPowerSwitchInfo : BaseXtraForm
    {
        #region 声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmDevPowerSwitchInfo));

        //操作类
        private ProxyBllDEV_POWER_SWITCH _bllDevPowerSwitch = new ProxyBllDEV_POWER_SWITCH();
       
        //供电柜开关操作model

        private ModelDEV_POWER_SWITCH _modelDevPowerSwitch;


        private FrmDevPowerBaseInfo _frmPowerBaseInfo;


        public delegate void SaveEventHandler();

        public event SaveEventHandler SaveHandler;

        #endregion

        #region 事件方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmDevPowerSwitchInfo()
        {
            InitializeComponent();
        }


        public void OnSaveBuutonClickedChange()
        {
            if (SaveHandler != null) SaveHandler();
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="modelDevPowerSwitch"></param>
        public FrmDevPowerSwitchInfo(ModelDEV_POWER_SWITCH modelDevPowerSwitch) :this()
        {
            _modelDevPowerSwitch = modelDevPowerSwitch;
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


                InitAllControls();

                //当前数据显示在控件上
                ShowDataInEditControls();

            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
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
                ModelDEV_POWER_SWITCH modelDevPowerSwitch = PreparePowerSwitchinfo();


                //判断此数据是否已经存在
                bool isDataExist = _bllDevPowerSwitch.Exists(modelDevPowerSwitch.F_POWER_ID, modelDevPowerSwitch.F_POWER_SWITCH_ID);

                if (isDataExist)
                {

                    //已经存在判断是否更新
                    DialogResult dialogResult = XtraMessageBox.Show("当前数据已存在，是否更新？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    //更新数据
                    bool status = _bllDevPowerSwitch.Update(modelDevPowerSwitch);


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
                    _bllDevPowerSwitch.Add(modelDevPowerSwitch);


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
                ModelDEV_POWER_SWITCH modelDevPowerSwitch = PreparePowerSwitchinfo();

                //更新数据
                bool status = _bllDevPowerSwitch.Enabled(modelDevPowerSwitch.F_POWER_ID,modelDevPowerSwitch.F_POWER_SWITCH_ID);

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
                ModelDEV_POWER_SWITCH modelDevPowerSwitch = PreparePowerSwitchinfo();

                //更新数据
                bool status = _bllDevPowerSwitch.Enabled(modelDevPowerSwitch.F_POWER_ID, modelDevPowerSwitch.F_POWER_SWITCH_ID);

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
                ModelDEV_POWER_SWITCH modelDevPowerSwitch = PreparePowerSwitchinfo();


                //判断是否有关系
                bool hasRelation = _bllDevPowerSwitch.HasRelation(modelDevPowerSwitch.F_POWER_ID, modelDevPowerSwitch.F_POWER_SWITCH_ID);
                if (hasRelation)
                {
                    XtraMessageBox.Show("此设备有和其他设备的关系，不能删除。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //更新数据
                bool status = _bllDevPowerSwitch.Drop(modelDevPowerSwitch.F_POWER_ID, modelDevPowerSwitch.F_POWER_SWITCH_ID);

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
        /// 初始化所有空间
        /// </summary>
        private void InitAllControls()
        {
            //填充所有可选控件
            FillAllSelectedControls();
        }


        /// <summary>
        ///     绑定所有列表信息
        /// </summary>
        private void FillAllSelectedControls()
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //开关状态
                ApplicationCommon.GetLookUpEditControl(lueF_POWER_SWITCH_STATUS, "T_SYSTEM_LIST", "F_VALUE", "编码", "F_DISPLAY", "状态", "F_TYPE='F_POWER_SWITCH_STATUS'");


                //输入输出
                ApplicationCommon.GetLookUpEditControl(lueF_POWER_SWITCH_TYPE, "T_SYSTEM_LIST", "F_VALUE", "编码", "F_DISPLAY", "状态", "F_TYPE='F_POWER_SWITCH_TYPE'");

            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 将数据显示在控件中
        /// </summary>
        private void ShowDataInEditControls()
        {

            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                if (_modelDevPowerSwitch == null)
                    return;

                //供电柜编号
                txtF_POWER_ID.Text = _modelDevPowerSwitch.F_POWER_ID;


                //开关序号		
                txtF_POWER_SWITCH_ID.Text = _modelDevPowerSwitch.F_POWER_SWITCH_ID;

                //供电柜开关状态		
                lueF_POWER_SWITCH_STATUS.EditValue = _modelDevPowerSwitch.F_POWER_SWITCH_STATUS;

                //通信端口
                txtF_COM_ADDRESS.Text = _modelDevPowerSwitch.F_COM_ADDRESS;

                //通信地址
                txtF_POWER_SWITCH_ADDRESS.Text = _modelDevPowerSwitch.F_POWER_SWITCH_ADDRESS.ToString();

                //通道号
                txtF_HOLDREG.Text = _modelDevPowerSwitch.F_HOLDREG.ToString();

                //校准编号
                txtF_POWER_SWITCH_CALIBRATION.Text = _modelDevPowerSwitch.F_POWER_SWITCH_CALIBRATION;

                //输入输出类型
                lueF_POWER_SWITCH_TYPE.EditValue = _modelDevPowerSwitch.F_POWER_SWITCH_TYPE;
                
                //负荷容量		
                txtF_LOAD_CAPACITY.Text = _modelDevPowerSwitch.F_LOAD_CAPACITY.ToString();

                //开关报警阈值(按时长)		
                txtF_ALARM_LIFEDURANCE.Text =
                    _modelDevPowerSwitch.F_ALARM_LIFEDURANCE.ToString();

                //开关报警阈值(按使用次数)		
                txtF_ALARM_TIMEDURANCE.Text = _modelDevPowerSwitch.F_ALARM_TIMEDURANCE.ToString();

                //开关动作次数		
                txtF_SWITCH_TIMES.Text = _modelDevPowerSwitch.F_SWITCH_TIMES.ToString();

                //供电柜开关状态
                lueF_POWER_SWITCH_STATUS.EditValue = int.Parse(_modelDevPowerSwitch.F_POWER_SWITCH_STATUS.ToString());


                //供电柜开关状态
                rdoF_DEL.EditValue = int.Parse(_modelDevPowerSwitch.F_DEL.ToString());

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
        private ModelDEV_POWER_SWITCH PreparePowerSwitchinfo()
        {

            ModelDEV_POWER_SWITCH modelDevPowerSwitch = new ModelDEV_POWER_SWITCH();

            //供电柜编号
            modelDevPowerSwitch.F_POWER_ID = txtF_POWER_ID.Text;

            //开关序号	
	modelDevPowerSwitch.F_POWER_SWITCH_ID = txtF_POWER_SWITCH_ID.Text;
            
            //通信端口		
    modelDevPowerSwitch.F_COM_ADDRESS = txtF_COM_ADDRESS.Text.ToUpper();
            
            //通信地址		
            modelDevPowerSwitch.F_POWER_SWITCH_ADDRESS = decimal.Parse(txtF_POWER_SWITCH_ADDRESS.Text);

            //通道号
            modelDevPowerSwitch.F_HOLDREG = decimal.Parse(txtF_HOLDREG.Text);

            
            //校验编号
            modelDevPowerSwitch.F_POWER_SWITCH_CALIBRATION = txtF_POWER_SWITCH_CALIBRATION.Text;

            //开关类型
            modelDevPowerSwitch.F_POWER_SWITCH_TYPE = decimal.Parse(lueF_POWER_SWITCH_TYPE.EditValue.ToString());

            //供电柜开关状态		
            modelDevPowerSwitch.F_POWER_SWITCH_STATUS = int.Parse(lueF_POWER_SWITCH_STATUS.EditValue.ToString()); 

       

            //负荷容量		
            modelDevPowerSwitch.F_LOAD_CAPACITY = decimal.Parse(txtF_LOAD_CAPACITY.Text); 

            //开关报警阈值(按时长)		
            modelDevPowerSwitch.F_ALARM_LIFEDURANCE = decimal.Parse(txtF_ALARM_LIFEDURANCE.Text);
               

            //开关报警阈值(按使用次数)		
            modelDevPowerSwitch.F_ALARM_TIMEDURANCE = decimal.Parse(txtF_ALARM_TIMEDURANCE.Text); 

            //开关动作次数		
            modelDevPowerSwitch.F_SWITCH_TIMES = decimal.Parse(txtF_SWITCH_TIMES.Text); 

            //供电柜开关状态
            modelDevPowerSwitch.F_POWER_SWITCH_STATUS = int.Parse(lueF_POWER_SWITCH_STATUS.EditValue.ToString());

            //创建时间		
            DateTime optDateTime = DateTime.Now;
            modelDevPowerSwitch.F_CREATE_TIME = optDateTime;

            //操作员		
            modelDevPowerSwitch.F_OPERATOR_ID = AppGlobal.GUserId;

            //操作时间		
            modelDevPowerSwitch.F_OPERATIONTIME = optDateTime;

            //是否删除		
            modelDevPowerSwitch.F_DEL = 0;

            return modelDevPowerSwitch;
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

                //供电柜编号
                if (string.IsNullOrEmpty(txtF_POWER_ID.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("供电柜编号不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //开关序号
                if (string.IsNullOrEmpty(txtF_POWER_SWITCH_ID.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("开关序号不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //端口
                if (string.IsNullOrEmpty(txtF_COM_ADDRESS.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("端口号不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //地址
                if (string.IsNullOrEmpty(txtF_POWER_SWITCH_ADDRESS.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("开关地址不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //通道号
                if (string.IsNullOrEmpty(txtF_HOLDREG.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("通道号不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }



                //负荷容量
                if (string.IsNullOrEmpty(txtF_LOAD_CAPACITY.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("负荷容量不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //开关报警阈值(按时长)
                if (string.IsNullOrEmpty(txtF_ALARM_LIFEDURANCE.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("开关报警阈值(按时长)不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //开关报警阈值(按使用次数)
                if (string.IsNullOrEmpty(txtF_ALARM_TIMEDURANCE.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("开关报警阈值(按使用次数)不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //开关动作次数
                if (string.IsNullOrEmpty(txtF_SWITCH_TIMES.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("开关动作次数不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //供电柜开关状态
                if (lueF_POWER_SWITCH_STATUS.EditValue ==null)
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("供电柜开关状态不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #endregion

        private void txtAlarmTimes_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPowerId_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}