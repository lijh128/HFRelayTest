using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraPrinting;
using log4net;
using RelayTest.Application.Controls;
using RelayTest.Model;
using RelayTest.Util.Common;

namespace RelayTest.Application.Settings
{
    /// <summary>
    ///     供电柜数据维护
    /// </summary>
    public partial class FrmDevPowerBaseInfo : BaseXtraForm
    {
        #region 声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof (FrmDevPowerBaseInfo));

        //供电柜操作类
        private readonly ProxyBllDEV_POWER_INFO _bllDevPowerInfo = new ProxyBllDEV_POWER_INFO();


        //供电柜显示数据源
        private DataSet _dsPowerbaseInfo = new DataSet();

        #endregion

        #region 事件方法

        /// <summary>
        ///     构造函数
        /// </summary>
        public FrmDevPowerBaseInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     窗体载入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPowerBaseInfo_Load(object sender,
                                           EventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //get data from database
                InitAllControls();
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        ///     导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender,
                                     EventArgs e)
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
        ///     更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender,
                                   EventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //检查必填字段
                bool isAllOk = CheckNotNullField();

                if (!isAllOk)
                    return;

                //准备要存储的数据
                ModelDEV_POWER_INFO modelDevPowerBaseinfo = PreparePowerBaseinfo();


                //判断此数据是否已经存在
                bool isDataExist = _bllDevPowerInfo.Exists(modelDevPowerBaseinfo.F_POWER_ID);

                if (isDataExist)
                {
                    //已经存在判断是否更新
                    DialogResult dialogResult = XtraMessageBox.Show("当前数据已存在，是否更新？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    //更新数据
                    bool status = _bllDevPowerInfo.Update(modelDevPowerBaseinfo);

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
                    _bllDevPowerInfo.Add(modelDevPowerBaseinfo);


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
        ///     启用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnabled_Click(object sender,
                                      EventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //检查必填字段
                bool isAllOk = CheckNotNullField();

                if (!isAllOk)
                    return;

                //准备要存储的数据
                ModelDEV_POWER_INFO modelDevPowerBaseinfo = PreparePowerBaseinfo();

                //更新数据
                bool status = _bllDevPowerInfo.Enabled(modelDevPowerBaseinfo.F_POWER_ID);

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
                    gvList_RowClick(this,null);
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
        ///     禁用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisabled_Click(object sender,
                                       EventArgs e)
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

                //若存在开关数据则不能禁用或者删除
                int subDataCount;

                int.TryParse(txtSwitchNum.Text, out subDataCount);

                if (subDataCount !=0)
                {
                    XtraMessageBox.Show("有附属信息不能禁用或者删除。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gvList_RowClick(this, null);
                    return;
                }

                //检查必填字段
                bool isAllOk = CheckNotNullField();

                if (!isAllOk)
                    return;

                //准备要存储的数据
                ModelDEV_POWER_INFO modelDevPowerBaseinfo = PreparePowerBaseinfo();

                //更新数据
                bool status = _bllDevPowerInfo.Disabled(modelDevPowerBaseinfo.F_POWER_ID);

                //获得当前rowhandle
                int rowhandle = gvList.FocusedRowHandle;

                //绑定数据
                BindGridview();

                //设置焦点行
                gvList.FocusedRowHandle = rowhandle;

                if (status)
                {
                    XtraMessageBox.Show("此数据已禁用。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        ///     删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender,
                                     EventArgs e)
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

                //若存在开关数据则不能禁用或者删除
                int subDataCount;

                int.TryParse(txtSwitchNum.Text, out subDataCount);

                if (subDataCount != 0)
                {
                    XtraMessageBox.Show("有附属信息不能禁用或者删除。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gvList_RowClick(this, null);
                    return;
                }
                //检查必填字段
                bool isAllOk = CheckNotNullField();

                if (!isAllOk)
                    return;

                //准备要存储的数据
                ModelDEV_POWER_INFO modelDevPowerBaseinfo = PreparePowerBaseinfo();


                //判断是否有关系
                bool hasRelation = _bllDevPowerInfo.HasRelation(modelDevPowerBaseinfo.F_POWER_ID);
                if (hasRelation)
                {
                    XtraMessageBox.Show("此设备有和其他设备的关系，不能删除。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //更新数据
                bool status = _bllDevPowerInfo.Drop(modelDevPowerBaseinfo.F_POWER_ID);

                //绑定数据
                BindGridview();

                if (status)
                {
                    XtraMessageBox.Show("此数据已删除。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gvList_RowClick(this, null);
                }
                else
                {
                    XtraMessageBox.Show("没有数据被删除。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        ///     表格点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvList_RowClick(object sender,
                                     RowClickEventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                if (gvList.FocusedRowHandle < 0)
                    return;

                //编号
                txtF_POWER_ID.Text = gvList.GetFocusedRowCellValue("F_POWER_ID").ToString();
                
                //名称
                txtF_POWER_NAME.Text = gvList.GetFocusedRowCellValue("F_POWER_NAME").ToString();

                //校准编号
                txtF_POWER_CALIBRATION.Text = gvList.GetFocusedRowCellValue("F_POWER_CALIBRATION").ToString();


                //描述信息
                txtF_POWER_DESCRIPTION.Text = gvList.GetFocusedRowCellValue("F_POWER_DESCRIPTION").ToString();
               
                //禁用状态
                rdoF_DEL.EditValue = int.Parse(gvList.GetFocusedRowCellValue("F_DEL").ToString());

                //绑定数据到开关信息
                BindPowerSwitchInfoGridView();

                //计算开关数目
                txtSwitchNum.Text = gvPowerSwitchInfo.RowCount.ToString();

                //toolTipController1.ShowHint("xcvxcvxcvxvcx");
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }


        /// <summary>
        /// 编辑开关信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdiSwitch_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                if (txtF_POWER_ID.Text == "")
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("请先选择供电柜信息再编辑通道信息。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                
                //准备数据
                var modelPowerSwitchStatus = new ModelDEV_POWER_SWITCH();

                //供电柜开关操作类
                var bllPowerSwitchStatus = new ProxyBllDEV_POWER_SWITCH();

                if (gvPowerSwitchInfo.RowCount > 0)
                {
                    string powerId = gvPowerSwitchInfo.GetFocusedRowCellValue("F_POWER_ID").ToString();
                    string switchId = gvPowerSwitchInfo.GetFocusedRowCellValue("F_POWER_SWITCH_ID").ToString();
                    modelPowerSwitchStatus = bllPowerSwitchStatus.GetModel(powerId, switchId);
                }
                else
                {
                    modelPowerSwitchStatus.F_POWER_ID = txtF_POWER_ID.Text;
                }


                var frm = new FrmDevPowerSwitchInfo(modelPowerSwitchStatus);

                frm.SaveHandler += BindPowerSwitchInfoGridView;

                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
            
        }

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

              
                //供电柜开关状态
                colF_POWER_SWITCH_STATUS.ColumnEdit = ApplicationCommon.GetRepositoryItemLookUpEditControl("T_SYSTEM_LIST", "F_VALUE", "F_DISPLAY", "F_TYPE='F_POWER_SWITCH_STATUS'");

                //输入输出状态
                colF_POWER_SWITCH_TYPE.ColumnEdit = ApplicationCommon.GetRepositoryItemLookUpEditControl("T_SYSTEM_LIST", "F_VALUE", "F_DISPLAY", "F_TYPE='F_POWER_SWITCH_TYPE'");


                //禁用状态
                colF_DEL.ColumnEdit = ApplicationCommon.GetRepositoryItemLookUpEditControl("T_SYSTEM_LIST", "F_VALUE", "F_DISPLAY", "F_TYPE='ALLOWUSE'");

                //开关禁用状态
                colSwitchF_DEL.ColumnEdit = ApplicationCommon.GetRepositoryItemLookUpEditControl("T_SYSTEM_LIST", "F_VALUE", "F_DISPLAY", "F_TYPE='ALLOWUSE'");


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
                _dsPowerbaseInfo = _bllDevPowerInfo.GetAllList();


                //有数据情况下绑定
                if (_dsPowerbaseInfo != null && _dsPowerbaseInfo.Tables.Count > 0 )
                {
                    gcList.DataSource = _dsPowerbaseInfo.Tables[0];
                }


                    //(ApplicationCommon.GetRepositoryItemLookUpEditControl("T_WORKSTATION_INFO", "FMasterId", "F_MASTER_NAME",""));

                gvList_RowClick(this, null);

            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }


        /// <summary>
        ///     绑定数据到开关信息
        /// </summary>
        public void BindPowerSwitchInfoGridView()
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //获得供电柜编号
                //编号
                if (string.IsNullOrEmpty(txtF_POWER_ID.Text))
                {
                    return;
                }

                //绑定数据
                var bllPowerSwitchStatus = new ProxyBllDEV_POWER_SWITCH();
                DataSet dsPowerSwitch = bllPowerSwitchStatus.GetList("F_POWER_ID='" + txtF_POWER_ID.Text + "'");

                //有数据情况下绑定
                if (dsPowerSwitch != null && dsPowerSwitch.Tables.Count > 0 )
                {
                    gcPowerSwitchInfo.DataSource = dsPowerSwitch.Tables[0];
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
                if (string.IsNullOrEmpty(txtF_POWER_ID.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("编码不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //名称
                if (string.IsNullOrEmpty(txtF_POWER_NAME.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("名称不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private ModelDEV_POWER_INFO PreparePowerBaseinfo()
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                var modelPowerBaseinfo = new ModelDEV_POWER_INFO();


                //供电柜编号或标识		
                modelPowerBaseinfo.F_POWER_ID = txtF_POWER_ID.Text;

                //供电柜名称		
                modelPowerBaseinfo.F_POWER_NAME = txtF_POWER_NAME.Text;

                //校准编号
                modelPowerBaseinfo.F_POWER_CALIBRATION = txtF_POWER_CALIBRATION.Text;

                //描述信息		
                modelPowerBaseinfo.F_POWER_DESCRIPTION = txtF_POWER_DESCRIPTION.Text;

              
                //创建时间		
                DateTime optDateTime = DateTime.Now;
                modelPowerBaseinfo.F_CREATE_TIME = optDateTime;

                //操作员		
                modelPowerBaseinfo.F_OPERATOR_ID = AppGlobal.GUserId;

                //操作时间		
                modelPowerBaseinfo.F_OPERATIONTIME = optDateTime;

                //是否删除		
                modelPowerBaseinfo.F_DEL = 0;

                return modelPowerBaseinfo;
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        #endregion

        private void txtPowerId_EditValueChanged(object sender, EventArgs e)
        {

        }

     

       
    }
}