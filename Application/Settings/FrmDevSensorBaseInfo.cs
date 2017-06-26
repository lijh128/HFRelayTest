using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using log4net;
using RelayTest.Model;
using RelayTest.Util.Common;

namespace RelayTest.Application.Settings
{
    
    /// <summary>
    /// 温度传感器数据维护
    /// </summary>
    public partial class FrmDevSensorBaseInfo : BaseXtraForm
    {
        #region 声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmDevSensorBaseInfo));


        //操作类
        private readonly ProxyBllDEV_SENSOR_INFO _bllSensorInfo = new ProxyBllDEV_SENSOR_INFO();

        //显示数据积极
        private DataSet _dsSensorInfo = new DataSet();

       
        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmDevSensorBaseInfo()
        {
            InitializeComponent();
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

                //所有选择信息
                FillAllSelectedControls();

                //绑定GridView
                BindGridview();
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

                //绑定设备类型
                ApplicationCommon.GetLookUpEditControl(lueF_DEV_TYPE, "T_SYSTEM_LIST", "F_VALUE", "编码", "F_DISPLAY", "设备类型", "F_TYPE='F_DEV_TYPE' and F_VALUE<>6");

                //工作状态选择
                ApplicationCommon.GetLookUpEditControl(lueF_SENSOR_STATUS, "T_SYSTEM_LIST", "F_VALUE", "编码", "F_DISPLAY", "设备类型", "F_TYPE='F_SENSOR_STATUS'");


                //设备类型
                colF_DEV_TYPE.ColumnEdit = ApplicationCommon.GetRepositoryItemLookUpEditControl( "T_SYSTEM_LIST", "F_VALUE",  "F_DISPLAY", "F_TYPE='F_DEV_TYPE'");

                //禁用状态
                colF_DEL.ColumnEdit = ApplicationCommon.GetRepositoryItemLookUpEditControl("T_SYSTEM_LIST", "F_VALUE", "F_DISPLAY", "F_TYPE='ALLOWUSE'");
                
                
                //工作状态
                colF_SENSOR_STATUS.ColumnEdit = ApplicationCommon.GetRepositoryItemLookUpEditControl("T_SYSTEM_LIST", "F_VALUE", "F_DISPLAY", "F_TYPE='F_SENSOR_STATUS'");

            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
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
                _dsSensorInfo = _bllSensorInfo.GetAllList();

                //有数据情况下绑定
                if (_dsSensorInfo != null && _dsSensorInfo.Tables.Count > 0)
                {
                    gcList.DataSource = _dsSensorInfo.Tables[0];
                }
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }


        /// <summary>
        ///     检查必填段
        /// </summary>
        /// <returns></returns>
        private bool CheckNotNullField()
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                //编号
                if (string.IsNullOrEmpty(txtCode.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("编码不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //名称
                if (string.IsNullOrEmpty(txtF_SENSOR_TYPE.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("型号不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


                //设备类型
                if (string.IsNullOrEmpty(lueF_DEV_TYPE.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("设备类型不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //设备编码
                if (string.IsNullOrEmpty(lueF_DEV_ID.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("设备编号不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //上限
                if (string.IsNullOrEmpty(txtF_SENSOR_VALUE_CEILING.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("上限值不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //下限
                if (string.IsNullOrEmpty(txtF_SENSOR_VALUE_FLOOR.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("下限值不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //设备编码
                if (string.IsNullOrEmpty(lueF_DEV_ID.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("设备编号不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        ///     准备要操作的ModelPARAMETER_MONITORCOMMON
        /// </summary>
        /// <returns></returns>
        private ModelDEV_SENSOR_INFO PrepareSensorInfo()
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                ModelDEV_SENSOR_INFO modelSensorInfo = new ModelDEV_SENSOR_INFO();


                //温度传感器编号		
                modelSensorInfo.F_SENSOR_ID = txtCode.Text;

                //温度传感器型号		
                modelSensorInfo.F_SENSOR_TYPE = txtF_SENSOR_TYPE.Text;

                //设备类型
                decimal devType;
                decimal.TryParse(lueF_DEV_TYPE.EditValue.ToString(), out devType);
                modelSensorInfo.F_DEV_TYPE = devType;

                //设备编码
                if (lueF_DEV_ID.EditValue != null)
                {
                    modelSensorInfo.F_DEV_ID = lueF_DEV_ID.EditValue.ToString();
                }

                //温度传感器位置		
                modelSensorInfo.F_SENSOR_POSTION = txtF_SENSOR_POSTION.Text;

                //端口
                modelSensorInfo.F_COM_ADDRESS = txtF_COM_ADDRESS.Text.ToUpper();

                //通信地址
                modelSensorInfo.F_SENSOR_ADDRESS = decimal.Parse(txtF_SENSOR_ADDRESS.Text);

                //热敏电阻安装端口
                modelSensorInfo.F_SENSER_NO = decimal.Parse(txtF_SENSER_NO.Text);

                //温度传感器安装时间		
                modelSensorInfo.F_SENDOR_INSTALL_DATE = dateF_SENDOR_INSTALL_DATE.DateTime;

                decimal tempDecimal;
                //温度报警下限值		
                decimal.TryParse(txtF_SENSOR_VALUE_FLOOR.Text,out tempDecimal);
                modelSensorInfo.F_SENSOR_ALARMVALUE_FLOOR = tempDecimal;

                //温度报警上限值		
                decimal.TryParse(txtF_SENSOR_VALUE_CEILING.Text, out tempDecimal);
                modelSensorInfo.F_SENSOR_ALARMVALUE_CEILING = tempDecimal;


                //温度动作下限值		
                decimal.TryParse(txtF_SENSOR_ACTIONVALUE_FLOOR.Text, out tempDecimal);
                modelSensorInfo.F_SENSOR_ACTIONVALUE_FLOOR = tempDecimal;

                //温度动作上限值		
                decimal.TryParse(txtF_SENSOR_ACTIONVALUE_CEILING.Text, out tempDecimal);
                modelSensorInfo.F_SENSOR_ACTIONVALUE_CEILING = tempDecimal;

                //当前温度值		
                //modelSensorInfo.F_SENSOR_NOW_VALUE = decimal.Parse(txtF_SENSOR_NOW_VALUE.Text);

                //采集时间		
                //modelSensorInfo.F_SENSOR_VALUE_TIME = dateF_SENSOR_VALUE_TIME.DateTime;

                //温度校正系数		
                decimal.TryParse(txtF_TEMPERATURE_ADJUST_COFF.Text, out tempDecimal);
                modelSensorInfo.F_TEMPERATURE_ADJUST_COFF = tempDecimal;

                //备注		
                modelSensorInfo.F_MEMO = txtF_MEMO.Text;


                //创建时间		
                DateTime optDateTime = DateTime.Now;
                modelSensorInfo.F_CREATE_TIME = optDateTime;

                //操作员		
                modelSensorInfo.F_OPERATOR_ID = AppGlobal.GUserId;

                //操作时间		
                modelSensorInfo.F_OPERATIONTIME = optDateTime;

                //是否删除		
                modelSensorInfo.F_DEL = 0;

                return modelSensorInfo;
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
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "电子表格文件 (*.xls)|*.xls";
                saveFileDialog.FileName = "导出文件.xls";
                DialogResult dialogResult = saveFileDialog.ShowDialog();
                if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }
                string fileName = saveFileDialog.FileName;
                if (!string.IsNullOrEmpty(fileName))
                {
                    try
                    {
                        var __options = new XlsExportOptions();
                        __options.TextExportMode = TextExportMode.Value;
                        __options.ExportMode = XlsExportMode.SingleFile;
                        __options.ShowGridLines = true;
                        gvList.OptionsPrint.UsePrintStyles = true;
                        gcList.ExportToXls(fileName, __options);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("文件正在使用！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            } 
        }


      


        /// <summary>
        /// 更新信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //检查必填字段
                bool isAllOk = CheckNotNullField();

                if (!isAllOk)
                    return;

                //准备要存储的数据
                ModelDEV_SENSOR_INFO modelSensorInfo = PrepareSensorInfo();


                //判断此数据是否已经存在
                bool isDataExist = _bllSensorInfo.Exists(modelSensorInfo.F_SENSOR_ID);

                if (isDataExist)
                {
                    //已经存在判断是否更新
                    DialogResult dialogResult = XtraMessageBox.Show("当前数据已存在，是否更新？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    //更新数据
                    bool status = _bllSensorInfo.Update(modelSensorInfo);

                    //获得当前rowhandle
                    int rowhandle = gvList.FocusedRowHandle;

                    //绑定数据
                    BindGridview();

                    //设置焦点行
                    gvList.FocusedRowHandle = rowhandle;


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
                    _bllSensorInfo.Add(modelSensorInfo);


                    //获得当前rowhandle
                    int rowhandle = gvList.FocusedRowHandle;

                    //绑定数据
                    BindGridview();

                    //设置焦点行
                    gvList.FocusedRowHandle = rowhandle + 1;


                    XtraMessageBox.Show("此数据已增加。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
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
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
              

                //检查必填字段
                bool isAllOk = CheckNotNullField();

                if (!isAllOk)
                    return;

                //准备要存储的数据
                ModelDEV_SENSOR_INFO modelSensorInfo = PrepareSensorInfo();

                //更新数据
                bool status = _bllSensorInfo.Enabled(modelSensorInfo.F_SENSOR_ID);

                //获得当前rowhandle
                int rowhandle = gvList.FocusedRowHandle;

                //绑定数据
                BindGridview();

                //设置焦点行
                gvList.FocusedRowHandle = rowhandle;

                if (status)
                {
                    XtraMessageBox.Show("此数据已启用。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //刷新数据
                    gvList_RowClick(this, null);
                }
                else
                {
                    XtraMessageBox.Show("没有数据被更新。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
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
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
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
                ModelDEV_SENSOR_INFO modelSensorInfo = PrepareSensorInfo();

                //更新数据
                bool status = _bllSensorInfo.Disabled(modelSensorInfo.F_SENSOR_ID);

                //获得当前rowhandle
                int rowhandle = gvList.FocusedRowHandle;

                //绑定数据
                BindGridview();

                //设置焦点行
                gvList.FocusedRowHandle = rowhandle;

                if (status)
                {
                    XtraMessageBox.Show("此数据已禁用。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //刷新数据
                    gvList_RowClick(this, null);
                }
                else
                {
                    XtraMessageBox.Show("没有数据被更新。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
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
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
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
                ModelDEV_SENSOR_INFO modelSensorInfo = PrepareSensorInfo();


                //判断是否有关系
                bool hasRelation = _bllSensorInfo.HasRelation(modelSensorInfo.F_SENSOR_ID);
                if (hasRelation)
                {
                    XtraMessageBox.Show("此设备有和其他设备的关系，不能删除。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //更新数据
                bool status = _bllSensorInfo.Drop(modelSensorInfo.F_SENSOR_ID);

                //获得当前rowhandle
                int rowhandle = gvList.FocusedRowHandle;

                //绑定数据
                BindGridview();

                //设置焦点行
                gvList.FocusedRowHandle = rowhandle;

                if (status)
                {
                    XtraMessageBox.Show("此数据已删除。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //刷新数据
                    gvList_RowClick(this, null);
                }
                else
                {
                    XtraMessageBox.Show("没有数据被更新。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }


        /// <summary>
        /// 点击表格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvList_Click(object sender, EventArgs e)
        {
            
        }




        /// <summary>
        /// 表格点击，将其中数据显示在下面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void gvList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                if (gvList.FocusedRowHandle < 0)
                    return;


                string sensorId = gvList.GetFocusedRowCellValue("F_SENSOR_ID").ToString();

                ModelDEV_SENSOR_INFO modelSensorInfo = _bllSensorInfo.GetModel(sensorId);


                //温度传感器编号		
                txtCode.Text = modelSensorInfo.F_SENSOR_ID;

                //温度传感器型号		
                txtF_SENSOR_TYPE.Text = modelSensorInfo.F_SENSOR_TYPE;

                //设备类型
                lueF_DEV_TYPE.EditValue = modelSensorInfo.F_DEV_TYPE;

                //设备编码
                lueF_DEV_ID.EditValue = modelSensorInfo.F_DEV_ID;

                //端口
                txtF_COM_ADDRESS.Text = modelSensorInfo.F_COM_ADDRESS;

                //通信地址
                txtF_SENSOR_ADDRESS.Text = modelSensorInfo.F_SENSOR_ADDRESS.ToString();


                //热敏电阻安装端口
                txtF_SENSER_NO.Text = modelSensorInfo.F_SENSER_NO.ToString();
             
                //温度传感器位置		
                txtF_SENSOR_POSTION.Text = modelSensorInfo.F_SENSOR_POSTION;

                //温度传感器安装时间		
                if (modelSensorInfo.F_SENDOR_INSTALL_DATE != null)
                    dateF_SENDOR_INSTALL_DATE.DateTime = (DateTime)modelSensorInfo.F_SENDOR_INSTALL_DATE;

                //温度报警下限值		
                txtF_SENSOR_VALUE_FLOOR.Text = modelSensorInfo.F_SENSOR_ALARMVALUE_FLOOR.ToString();

                //温度报警上限值		
                txtF_SENSOR_VALUE_CEILING.Text = modelSensorInfo.F_SENSOR_ALARMVALUE_CEILING.ToString();

                //温度动作上限
                txtF_SENSOR_ACTIONVALUE_CEILING.Text = modelSensorInfo.F_SENSOR_ACTIONVALUE_CEILING.ToString();

                //温度动作下限
                txtF_SENSOR_ACTIONVALUE_FLOOR.Text = modelSensorInfo.F_SENSOR_ACTIONVALUE_FLOOR.ToString();

                //当前温度值		
                txtF_SENSOR_NOW_VALUE.Text = modelSensorInfo.F_SENSOR_NOW_VALUE.ToString();

                //采集时间		
                if (modelSensorInfo.F_SENSOR_VALUE_TIME != null)
                {
                    txtF_SENSOR_VALUE_TIME.Text = ((DateTime)modelSensorInfo.F_SENSOR_VALUE_TIME).ToString("yyyy/mm/dd hh:MM:ss");

                }

                //工作状态
                lueF_SENSOR_STATUS.EditValue = modelSensorInfo.F_SENSOR_STATUS;

                //温度校正系数		
                txtF_TEMPERATURE_ADJUST_COFF.Text = modelSensorInfo.F_TEMPERATURE_ADJUST_COFF.ToString();

                //备注		
                txtF_MEMO.Text = modelSensorInfo.F_MEMO;

                //禁用状态
                rdoF_DEL.EditValue = modelSensorInfo.F_DEL;

            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

      

        /// <summary>
        /// 设备类型变更后后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lueF_DEV_TYPE_EditValueChanged(object sender, EventArgs e)
        {
            //设备类型
            decimal devType;
            decimal.TryParse(lueF_DEV_TYPE.EditValue.ToString(), out devType);

            switch ((int)devType)
            {
                    //负载柜
                case 3:
                {
                    ApplicationCommon.GetLookUpEditControl(lueF_DEV_ID, "T_DEV_LOAD_INFO", "F_LOAD_ID", "设备编号", "F_LOAD_NAME", "设备名称", "F_DEL=0");
                    break;
                }
                //上位机
                case 2:
                {
                    ApplicationCommon.GetLookUpEditControl(lueF_DEV_ID, "T_DEV_WORKSTATION_INFO", "FMasterId", "设备编号", "F_MASTER_NAME", "设备名称", "F_DEL=0");
                    break;
                }
                //供电柜
                case 1:
                {
                    ApplicationCommon.GetLookUpEditControl(lueF_DEV_ID, "T_DEV_POWER_INFO", "F_POWER_ID", "设备编号", "F_POWER_NAME", "设备名称", "F_DEL=0");
                    break;
                }
                //下位机
                case 4:
                {
                    ApplicationCommon.GetLookUpEditControl(lueF_DEV_ID, "T_DEV_SUBORDINATE_INFO", "F_AFFILIATION_ID", "设备编号", "F_AFFILIATION_NAME", "设备名称", "F_DEL=0");
                    break;
                }
                //负载柜
                case 5:
                {
                    ApplicationCommon.GetLookUpEditControl(lueF_DEV_ID, "T_DEV_COILPOWER_INFO", "F_COILPOWER_ID", "设备编号", "F_COILPOWER_NAME", "设备名称", "F_DEL=0");
                    break;
                }
            }
           
        }

    
    }
}