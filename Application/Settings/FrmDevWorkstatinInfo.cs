using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.Refactor.Core;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using log4net;
using RelayTest.Model;
using RelayTest.Util.Common;

namespace RelayTest.Application.Settings
{
    
    /// <summary>
    /// 上位机基本信息
    /// </summary>
    public partial class FrmDevWorkstatinInfo : BaseXtraForm
    {
        #region 声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmDevPowerBaseInfo));


        //操作类
        private ProxyBllDEV_WORKSTATION_INFO _bllDevWorkstationInfo = new ProxyBllDEV_WORKSTATION_INFO();
       
        //数据集
        private DataSet _dsWorkstationInfo = new DataSet();

        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmDevWorkstatinInfo()
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
                FillAllSelectedControls();
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }


        /// <summary>
        /// 填充可选控件内容
        /// </summary>
        private void FillAllSelectedControls()
        {
            //表格中工作站状态显示内容
            colF_WORKSTATION_STATUS.ColumnEdit = ApplicationCommon.GetRepositoryItemLookUpEditControl("T_SYSTEM_LIST", "F_VALUE", "F_DISPLAY",
                "F_TYPE='F_WORKSTATION_STATUS'");
            //禁用状态
            colF_DEL.ColumnEdit = ApplicationCommon.GetRepositoryItemLookUpEditControl("T_SYSTEM_LIST", "F_VALUE", "F_DISPLAY", "F_TYPE='ALLOWUSE'");

            //编辑区工作站状态显示
            ApplicationCommon.GetLookUpEditControl(lueF_WORKSTATION_STATUS, "T_SYSTEM_LIST", "F_VALUE","编码","F_DISPLAY","状态","F_TYPE='F_WORKSTATION_STATUS'");

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
                _dsWorkstationInfo = _bllDevWorkstationInfo.GetAllList();

                //有数据情况下绑定
                if (_dsWorkstationInfo != null && _dsWorkstationInfo.Tables.Count > 0)
                {
                    gcList.DataSource = _dsWorkstationInfo.Tables[0];
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
                if (string.IsNullOrEmpty(txtF_WORKSTATION_ID.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("编码不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //名称
                if (string.IsNullOrEmpty(txtF_WORKSTATION_NAME.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("名称不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


                //上位机状态
                if (lueF_WORKSTATION_STATUS.EditValue == null)
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("状态信息不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private ModelDEV_WORKSTATION_INFO PreModelWorkstationInfo()
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                ModelDEV_WORKSTATION_INFO modelWorkstationInfo = new ModelDEV_WORKSTATION_INFO();


                //编号	
                modelWorkstationInfo.F_WORKSTATION_ID = txtF_WORKSTATION_ID.Text;
                //名称	
                modelWorkstationInfo.F_WORKSTATION_NAME = txtF_WORKSTATION_NAME.Text;
                
                //状态	
                modelWorkstationInfo.F_WORKSTATION_STATUS = decimal.Parse(lueF_WORKSTATION_STATUS.EditValue.ToString());

                //校验编号
                modelWorkstationInfo.F_WORKSTATION_CALIBRATION = txtF_WORKSTATION_CALIBRATION.Text;

                //备注
                modelWorkstationInfo.F_WORKSTATION_MEMO = txtF_WORKSTATION_MEMO.Text;

                //创建时间		
                DateTime optDateTime = DateTime.Now;
                modelWorkstationInfo.F_CREATE_TIME = optDateTime;

                //操作员		
                modelWorkstationInfo.F_OPERATOR_ID = AppGlobal.GUserId;

                //操作时间		
                modelWorkstationInfo.F_OPERATIONTIME = optDateTime;

                //是否删除		
                modelWorkstationInfo.F_DEL = 0;

                return modelWorkstationInfo;
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
        /// Add new item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
    
        }


        /// <summary>
        /// 设置负载电流上下限，电压上下限，负载可用状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtValue_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            (new FrmDevLoadChannelInfo()).ShowDialog();
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
                ModelDEV_WORKSTATION_INFO modelWorkstationInfo = PreModelWorkstationInfo();


                //判断此数据是否已经存在
                bool isDataExist = _bllDevWorkstationInfo.Exists(modelWorkstationInfo.F_WORKSTATION_ID);

                if (isDataExist)
                {

                    //已经存在判断是否更新
                    DialogResult dialogResult = XtraMessageBox.Show("当前数据已存在，是否更新？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }

                    //更新数据
                    bool status = _bllDevWorkstationInfo.Update(modelWorkstationInfo);

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
                    _bllDevWorkstationInfo.Add(modelWorkstationInfo);


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
                ModelDEV_WORKSTATION_INFO modelWorkstationInfo = PreModelWorkstationInfo();
                //更新数据
                bool status = _bllDevWorkstationInfo.Enabled(modelWorkstationInfo.F_WORKSTATION_ID);

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
                ModelDEV_WORKSTATION_INFO modelWorkstationInfo = PreModelWorkstationInfo();
                //更新数据
                bool status = _bllDevWorkstationInfo.Disabled(modelWorkstationInfo.F_WORKSTATION_ID);

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
                ModelDEV_WORKSTATION_INFO modelWorkstationInfo = PreModelWorkstationInfo();

                //判断是否有关系
                bool hasRelation = _bllDevWorkstationInfo.HasRelation(modelWorkstationInfo.F_WORKSTATION_ID);
                if (hasRelation)
                {
                    XtraMessageBox.Show("此设备有和其他设备的关系，不能删除。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                //更新数据
                bool status = _bllDevWorkstationInfo.Drop(modelWorkstationInfo.F_WORKSTATION_ID);

                //获得当前rowhandle
                int rowhandle = gvList.FocusedRowHandle;

                //绑定数据
                BindGridview();

                //设置焦点行
                gvList.FocusedRowHandle = rowhandle;

                if (status)
                {
                    XtraMessageBox.Show("此数据已删除。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void gvList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                if (gvList.FocusedRowHandle < 0)
                    return;

                int datasetIndex = gvList.GetDataSourceRowIndex(gvList.FocusedRowHandle);

                DataTable dtGridview = (DataTable) gcList.DataSource;



                //编号
                txtF_WORKSTATION_ID.Text = dtGridview.Rows[datasetIndex]["F_WORKSTATION_ID"].ToString();

                //名称
                txtF_WORKSTATION_NAME.Text = dtGridview.Rows[datasetIndex]["F_WORKSTATION_NAME"].ToString();

                //校验编号
                txtF_WORKSTATION_CALIBRATION.Text = dtGridview.Rows[datasetIndex]["F_WORKSTATION_CALIBRATION"].ToString();

                //描述信息
                txtF_WORKSTATION_MEMO.Text = dtGridview.Rows[datasetIndex]["F_WORKSTATION_MEMO"].ToString();

                //状态
                lueF_WORKSTATION_STATUS.EditValue = decimal.Parse(dtGridview.Rows[datasetIndex]["F_WORKSTATION_STATUS"].ToString());

                //禁用状态
                radioF_DEL.EditValue = int.Parse(dtGridview.Rows[datasetIndex]["F_DEL"].ToString());

                //备注
                txtF_WORKSTATION_MEMO.Text = dtGridview.Rows[datasetIndex]["F_WORKSTATION_MEMO"].ToString();

            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }
    
    }
}