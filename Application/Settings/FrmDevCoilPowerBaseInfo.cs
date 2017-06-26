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
    /// 线圈电源基础数据
    /// </summary>
    public partial class FrmDevCoilPowerBaseInfo : BaseXtraForm
    {
        #region 声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmDevCoilPowerBaseInfo));


       //操作类
        private ProxyBllDEV_COILPOWER_INFO _bllDevCoilpowerInfo = new ProxyBllDEV_COILPOWER_INFO();

        //数据集
        private DataSet _dsCoilInfo = new DataSet();


        #endregion

        #region 自定义方法

        /// <summary>
        ///     初始化界面上的控件
        /// </summary>
        private void InitAllControls()
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //初始化表格
                ApplicationCommon.InitGridviewColumnAndCellFont(gvList);
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

           
                //禁用状态
                colF_DEL.ColumnEdit = ApplicationCommon.GetRepositoryItemLookUpEditControl("T_SYSTEM_LIST", "F_VALUE", "F_DISPLAY", "F_TYPE='ALLOWUSE'");

                //线圈电源状态表格显示
                colF_COILPOWER_RUN_STATUS.ColumnEdit = ApplicationCommon.GetRepositoryItemLookUpEditControl("T_SYSTEM_LIST", "F_VALUE", "F_DISPLAY", "F_TYPE='F_COILPOWER_RUN_STATUS'");

                //线圈电源开关编辑选择
                ApplicationCommon.GetLookUpEditControl(lueF_COILPOWER_RUN_STATUS, "T_SYSTEM_LIST", "F_VALUE","编码", "F_DISPLAY","状态", "F_TYPE='F_COILPOWER_RUN_STATUS'");

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
                _dsCoilInfo = _bllDevCoilpowerInfo.GetAllList();

                //有数据情况下绑定
                if (_dsCoilInfo != null && _dsCoilInfo.Tables.Count > 0)
                {
                    gcList.DataSource = _dsCoilInfo.Tables[0];
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
                if (string.IsNullOrEmpty(txtF_COILPOWER_ID.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("编码不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //名称
                if (string.IsNullOrEmpty(txtF_COILPOWER_NAME.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("名称不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //通信端口
                if (string.IsNullOrEmpty(txtF_COM_ADDRESS.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("通信端口不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //地址
                if (string.IsNullOrEmpty(txtF_COILPOWER_ADDRESS.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("通信地址不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                //状态
                if (lueF_COILPOWER_RUN_STATUS.EditValue == null)
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("状态不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private ModelDEV_COILPOWER_INFO PrepareCoilInfo()
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                ModelDEV_COILPOWER_INFO modelCoilInfo = new ModelDEV_COILPOWER_INFO();


                //线圈电源	
                modelCoilInfo.F_COILPOWER_ID = txtF_COILPOWER_ID.Text;
                //负载线圈电源名称	
                modelCoilInfo.F_COILPOWER_NAME = txtF_COILPOWER_NAME.Text;

                //校验编号
                modelCoilInfo.F_COILPOWER_CALIBRATION = txtF_COILPOWER_CALIBRATION.Text;
                //端口
                modelCoilInfo.F_COM_ADDRESS = txtF_COM_ADDRESS.Text.ToUpper();

                //地址
                decimal coilPowerAddress;
                decimal.TryParse(txtF_COILPOWER_ADDRESS.Text, out coilPowerAddress);
                modelCoilInfo.F_COILPOWER_ADDRESS = coilPowerAddress;

                //状态
                decimal coilPowerStatus;
                decimal.TryParse(lueF_COILPOWER_RUN_STATUS.EditValue.ToString(), out coilPowerStatus);
                modelCoilInfo.F_COILPOWER_RUN_STATUS = coilPowerStatus;

                //输出电压上限
                if (txtF_COILPOWER_VOLTAGE_CEILING.Text == "")
                {
                    modelCoilInfo.F_COILPOWER_VOLTAGE_CEILING = null;
                }
                else
                {
                    modelCoilInfo.F_COILPOWER_VOLTAGE_CEILING = decimal.Parse(txtF_COILPOWER_VOLTAGE_CEILING.Text);
                }

                //输出电压下限
                if (txtF_COILPOWER_VOLTAGE_FLOOR.Text == "")
                {
                    modelCoilInfo.F_COILPOWER_VOLTAGE_FLOOR = null;
                }
                else
                {
                    modelCoilInfo.F_COILPOWER_VOLTAGE_FLOOR = decimal.Parse(txtF_COILPOWER_VOLTAGE_FLOOR.Text);
                }

                //输出电流上限
                if (txtF_COILPOWER_CURRENT_CEILING.Text == "")
                {
                    modelCoilInfo.F_COILPOWER_CURRENT_CEILING = null;
                }
                else
                {
                    modelCoilInfo.F_COILPOWER_CURRENT_CEILING = decimal.Parse(txtF_COILPOWER_CURRENT_CEILING.Text);
                }

                //输出电压下限
                if (txtF_COILPOWER_CURRENT_FLOOR.Text == "")
                {
                    modelCoilInfo.F_COILPOWER_CURRENT_FLOOR = null;
                }
                else
                {
                    modelCoilInfo.F_COILPOWER_CURRENT_FLOOR = decimal.Parse(txtF_COILPOWER_CURRENT_FLOOR.Text);
                }

                //输出电压上限
                if (txtF_COILPOWER_POWER.Text == "")
                {
                    modelCoilInfo.F_COILPOWER_POWER = null;
                }
                else
                {
                    modelCoilInfo.F_COILPOWER_POWER = decimal.Parse(txtF_COILPOWER_POWER.Text);
                }
                   //备注	
                modelCoilInfo.F_COILPOWER_MEMO = txtF_COILPOWER_MEMO.Text;

                //创建时间		
                DateTime optDateTime = DateTime.Now;
                modelCoilInfo.F_CREATE_TIME = optDateTime;

                //操作员		
                modelCoilInfo.F_OPERATOR_ID = AppGlobal.GUserId;

                //操作时间		
                modelCoilInfo.F_OPERATIONTIME = optDateTime;

                //是否删除		
                modelCoilInfo.F_DEL = 0;

                return modelCoilInfo;
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        #endregion

        #region 事件方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmDevCoilPowerBaseInfo()
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

                BindGridview();

            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
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
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //检查必填字段
                bool isAllOk = CheckNotNullField();

                if (!isAllOk)
                    return;

                //准备要存储的数据
                ModelDEV_COILPOWER_INFO modelCoilInfo = PrepareCoilInfo();


                //判断此数据是否已经存在
                bool isDataExist = _bllDevCoilpowerInfo.Exists(modelCoilInfo.F_COILPOWER_ID);

                if (isDataExist)
                {
                    //已经存在判断是否更新
                    DialogResult dialogResult = XtraMessageBox.Show("当前数据已存在，是否更新？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    //更新数据
                    bool status = _bllDevCoilpowerInfo.Update(modelCoilInfo);

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
                    _bllDevCoilpowerInfo.Add(modelCoilInfo);


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
                ModelDEV_COILPOWER_INFO modelCoilInfo = PrepareCoilInfo();
                //更新数据
                bool status = _bllDevCoilpowerInfo.Enabled(modelCoilInfo.F_COILPOWER_ID);

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
                ModelDEV_COILPOWER_INFO modelCoilInfo = PrepareCoilInfo();
                //更新数据
                bool status = _bllDevCoilpowerInfo.Disabled(modelCoilInfo.F_COILPOWER_ID);

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
                ModelDEV_COILPOWER_INFO modelCoilInfo = PrepareCoilInfo();

                //判断是否有关系
                bool hasRelation = _bllDevCoilpowerInfo.HasRelation(modelCoilInfo.F_COILPOWER_ID);
                if (hasRelation)
                {
                    XtraMessageBox.Show("此设备有和其他设备的关系，不能删除。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //更新数据
                bool status = _bllDevCoilpowerInfo.Drop(modelCoilInfo.F_COILPOWER_ID);

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
        private void gvList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                if (gvList.FocusedRowHandle < 0)
                    return;
                //编号
                txtF_COILPOWER_ID.Text = gvList.GetFocusedRowCellValue("F_COILPOWER_ID").ToString();
                //名称
                txtF_COILPOWER_NAME.Text = gvList.GetFocusedRowCellValue("F_COILPOWER_NAME").ToString();
                
                //校验编号
                txtF_COILPOWER_CALIBRATION.Text = gvList.GetFocusedRowCellValue("F_COILPOWER_CALIBRATION").ToString();
                
                //端口
                txtF_COM_ADDRESS.Text = gvList.GetFocusedRowCellValue("F_COM_ADDRESS").ToString();
                //地址
                txtF_COILPOWER_ADDRESS.Text = gvList.GetFocusedRowCellValue("F_COILPOWER_ADDRESS").ToString();

               //电压上限
                txtF_COILPOWER_VOLTAGE_CEILING.Text = gvList.GetFocusedRowCellValue("F_COILPOWER_VOLTAGE_CEILING").ToString();

                //电压下限
                txtF_COILPOWER_VOLTAGE_FLOOR.Text = gvList.GetFocusedRowCellValue("F_COILPOWER_VOLTAGE_FLOOR").ToString();


                //电流上限
                txtF_COILPOWER_CURRENT_CEILING.Text = gvList.GetFocusedRowCellValue("F_COILPOWER_CURRENT_CEILING").ToString();


                //电压下限
                txtF_COILPOWER_CURRENT_FLOOR.Text = gvList.GetFocusedRowCellValue("F_COILPOWER_CURRENT_FLOOR").ToString();


                //输出功率
                txtF_COILPOWER_POWER.Text = gvList.GetFocusedRowCellValue("F_COILPOWER_POWER").ToString();

                //状态
                lueF_COILPOWER_RUN_STATUS.EditValue =
                    decimal.Parse(gvList.GetFocusedRowCellValue("F_COILPOWER_RUN_STATUS").ToString());
                
                //描述信息
                txtF_COILPOWER_MEMO.Text = gvList.GetFocusedRowCellValue("F_COILPOWER_MEMO").ToString();

             
               
                //禁用状态
                rdoF_DEL.EditValue = decimal.Parse(gvList.GetFocusedRowCellValue("F_DEL").ToString());

            

            
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }


        #endregion

        private void txtCode_EditValueChanged(object sender, EventArgs e)
        {

        }

       

    }
}