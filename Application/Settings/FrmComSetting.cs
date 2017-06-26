using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using log4net;
using RelayTest.Model;
using RelayTest.Util.Common;
using LookUpEdit = DevExpress.DXCore.Controls.XtraEditors.LookUpEdit;
using XtraMessageBox = DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox;

namespace RelayTest.Application.Settings
{
    
    /// <summary>
    /// 串口参数设置
    /// </summary>
    public partial class FrmComSetting : BaseXtraForm
    {
        #region 声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmComSetting));


        private ProxyBllCOM_SETTINGS _bllComSettings = new ProxyBllCOM_SETTINGS();
       
        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmComSetting()
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


        /// <summary>
        /// 初始化界面上的控件
        /// </summary>
        private void InitAllControls()
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                //绑定工作站信息
                FillAllSelectedControls();

                //绑定GridView
                BindGridview();
            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }


        /// <summary>
        /// 绑定工作站信息
        /// </summary>
        private void FillAllSelectedControls()
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //将数据绑定到选择框中
                ApplicationCommon.FillLueWorkStationInfo(lueF_WORKSTATION_ID);

                //禁用状态
                colF_DEL.ColumnEdit = ApplicationCommon.GetRepositoryItemLookUpEditControl("T_SYSTEM_LIST", "F_VALUE", "F_DISPLAY", "F_TYPE='ALLOWUSE'");

            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }


        /// <summary>
        /// 绑定表格
        /// </summary>
        private void BindGridview()
        {

            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                if (lueF_WORKSTATION_ID.EditValue == null)
                    return;
                string wrokstationId = lueF_WORKSTATION_ID.EditValue.ToString();

                //如果为空则返回
                if (string.IsNullOrEmpty(wrokstationId))
                    return;


                DataSet dsCom232Settings = _bllComSettings.GetList("F_WORKSTATION_ID='" + wrokstationId + "'");

                //有数据情况下绑定
                if (dsCom232Settings != null && dsCom232Settings.Tables.Count > 0)
                {
                    gcList.DataSource = dsCom232Settings.Tables[0];
                }

            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }

            
        }

        /// <summary>
        /// 导出数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "电子表格文件 (*.xls)|*.xls";
                saveFileDialog.FileName = "导出文件.xls";
                var dialogResult = saveFileDialog.ShowDialog();
                if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }
                string fileName = saveFileDialog.FileName;
                if (!string.IsNullOrEmpty(fileName))
                {
                    try
                    {
                        DevExpress.XtraPrinting.XlsExportOptions __options = new DevExpress.XtraPrinting.XlsExportOptions();
                        __options.TextExportMode = TextExportMode.Value;
                        __options.ExportMode = DevExpress.XtraPrinting.XlsExportMode.SingleFile;
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
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 将具体信息显示在编辑控件
        /// </summary>
        private void FillDataToDisplayControls()
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                string wrokstationId = lueF_WORKSTATION_ID.EditValue.ToString();

                //如果为空则返回
                if (string.IsNullOrEmpty(wrokstationId))
                    return;

                string comId = gvList.GetFocusedRowCellValue("F_COM_CODE").ToString();



                ModelCOM_SETTINGS modelCom232Settings = _bllComSettings.GetModel(wrokstationId,comId);

                //有数据情况下绑定
                if (modelCom232Settings == null)
                {
                    return;
                }

                //端口类型
                cbbF_TYPE.Text = modelCom232Settings.F_TYPE;

                //编号
                txtF_COM_CODE.Text = modelCom232Settings.F_COM_CODE;

                //波特率
                cbbF_BAUDRATE.Text = modelCom232Settings.F_BAUDRATE.ToString();

                //数据位
                cbbF_DATABIT.Text = modelCom232Settings.F_DATABIT.ToString();

                //奇偶校验
                cbbF_ODDEVENCHECK.SelectedIndex = (int)modelCom232Settings.F_ODDEVENCHECK;

                //停止位
                if (modelCom232Settings.F_STOPBIT == 10)
                {
                    cbbF_STOPBIT.SelectedIndex = 0;
                }
                else if (modelCom232Settings.F_STOPBIT == 15)
                {
                    cbbF_STOPBIT.SelectedIndex = 1;
                }
                else if (modelCom232Settings.F_STOPBIT == 20)
                {
                    cbbF_STOPBIT.SelectedIndex = 2;
                }
               
                //停止位
                cbbF_STREAMCONTROL.SelectedIndex = int.Parse(modelCom232Settings.F_STREAMCONTROL.ToString());


            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 保存
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
                ModelCOM_SETTINGS modelCom232Settings = PrepaireModelCOM232_SETTINGS();

                //判断此数据是否已经存在
                bool isDataExist = _bllComSettings.Exists(modelCom232Settings.F_WORKSTATION_ID, modelCom232Settings.F_COM_CODE);

                //如果存在则更新
                if (isDataExist)
                {
                    //已经存在判断是否更新
                    DialogResult dialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("当前数据已存在，是否更新？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    //更新数据
                    bool status = _bllComSettings.Update(modelCom232Settings);

                    //获得当前rowhandle
                    int rowhandle = gvList.FocusedRowHandle;

                    //绑定数据
                    BindGridview();

                    //设置焦点行
                    gvList.FocusedRowHandle = rowhandle;


                    if (status)
                    {
                        DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("此数据已更新。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("没有数据被更新，执行中断。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    //插入数据
                    _bllComSettings.Add(modelCom232Settings);


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
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }


        /// <summary>
        /// 准备要存储的数据
        /// </summary>
        /// <returns></returns>
        private ModelCOM_SETTINGS PrepaireModelCOM232_SETTINGS()
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //创建数据实例
                ModelCOM_SETTINGS modelCom232Settings = new ModelCOM_SETTINGS();

                

                //上位机编码		
                modelCom232Settings.F_WORKSTATION_ID = lueF_WORKSTATION_ID.EditValue.ToString();

                //串口类型
                modelCom232Settings.F_TYPE = cbbF_TYPE.Text;

                //串口号		
                modelCom232Settings.F_COM_CODE = txtF_COM_CODE.Text.ToUpper();

                //波特率		
                modelCom232Settings.F_BAUDRATE = decimal.Parse(cbbF_BAUDRATE.Text);

                //数据位		
                modelCom232Settings.F_DATABIT = decimal.Parse(cbbF_DATABIT.Text);

                //奇偶校验		
                modelCom232Settings.F_ODDEVENCHECK = cbbF_ODDEVENCHECK.SelectedIndex;

                //停止位		
                modelCom232Settings.F_STOPBIT = decimal.Parse(cbbF_STOPBIT.Text)*10;

                //据流控制		
                modelCom232Settings.F_STREAMCONTROL = cbbF_STREAMCONTROL.SelectedIndex;

                //创建时间		
                DateTime opTime = DateTime.Now;
                modelCom232Settings.F_CREATE_TIME = opTime;

                //操作员		
                modelCom232Settings.F_OPERATOR_ID = AppGlobal.GUserId;

                //操作时间		
                modelCom232Settings.F_OPERATIONTIME = opTime;

                //是否删除		
                modelCom232Settings.F_DEL = 0;


                return modelCom232Settings;

            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
           

        }

        /// <summary>
        /// 检查是否全部输入
        /// </summary>
        /// <returns></returns>
        private bool CheckNotNullField()
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                //工作站编号
                if (lueF_WORKSTATION_ID.EditValue == null)
                {
                    XtraMessageBox.Show("工作站编号不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }




                string workstationId = lueF_WORKSTATION_ID.EditValue.ToString();
                if (string.IsNullOrEmpty(workstationId))
                {
                    XtraMessageBox.Show("工作站编号不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //类型
                if (string.IsNullOrEmpty(cbbF_TYPE.Text))
                {
                    XtraMessageBox.Show("端口类型不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //串口号
                if (string.IsNullOrEmpty(txtF_COM_CODE.Text))
                {
                    XtraMessageBox.Show("串口编号不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //波特率
                if (string.IsNullOrEmpty(cbbF_BAUDRATE.Text))
                {
                    XtraMessageBox.Show("波特率不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //数据位
                if (string.IsNullOrEmpty(cbbF_DATABIT.Text))
                {
                    XtraMessageBox.Show("数据位不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //奇偶校验
                if (string.IsNullOrEmpty(cbbF_ODDEVENCHECK.Text))
                {
                    XtraMessageBox.Show("奇偶校验不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //停止位
                if (string.IsNullOrEmpty(cbbF_STOPBIT.Text))
                {
                    XtraMessageBox.Show("停止位不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //数据流控制
                if (string.IsNullOrEmpty(cbbF_STREAMCONTROL.Text))
                {
                    XtraMessageBox.Show("数据流控制不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// 重新绑定数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lueWorkstationId_EditValueChanged(object sender, EventArgs e)
        {
            //绑定数据
            BindGridview();
            
        }
        
        /// <summary>
        /// 点击表格时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

            //显示具体内容
            FillDataToDisplayControls();
        }

      /// <summary>
      /// 启用数据数据
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
                ModelCOM_SETTINGS modelCom232Settings = PrepaireModelCOM232_SETTINGS();

                //更新数据
                bool status = _bllComSettings.Enabled(modelCom232Settings.F_WORKSTATION_ID, modelCom232Settings.F_COM_CODE);

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
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 禁用数据
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
                ModelCOM_SETTINGS modelCom232Settings = PrepaireModelCOM232_SETTINGS();

                //更新数据
                bool status = _bllComSettings.Disabled(modelCom232Settings.F_WORKSTATION_ID, modelCom232Settings.F_COM_CODE);

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
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }


        /// <summary>
        /// 永久删除一条数据
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
                ModelCOM_SETTINGS modelCom232Settings = PrepaireModelCOM232_SETTINGS();

                //更新数据
                bool status = _bllComSettings.Drop(modelCom232Settings.F_WORKSTATION_ID, modelCom232Settings.F_COM_CODE);

                //绑定数据
                BindGridview();


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
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

    
    }
}