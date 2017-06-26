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
    /// 负载柜基础数据
    /// </summary>
    public partial class FrmDevLoadBaseInfo : BaseXtraForm
    {
        #region 声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmDevLoadBaseInfo));

        //负载柜操作类
        private readonly ProxyBllDEV_LOAD_INFO _bllDevLoadInfo = new ProxyBllDEV_LOAD_INFO();


        //负载柜数据集
        private DataSet _dsLoadInfo = new DataSet();

        #endregion

        #region 事件方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmDevLoadBaseInfo()
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
                ModelDEV_LOAD_INFO modelDevLoadInfo = PrepareModelLoadInfo();


                //判断此数据是否已经存在
                bool isDataExist = _bllDevLoadInfo.Exists(modelDevLoadInfo.F_LOAD_ID);

                if (isDataExist)
                {
                    //已经存在判断是否更新
                    DialogResult dialogResult = XtraMessageBox.Show("当前数据已存在，是否更新？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    //更新数据
                    bool status = _bllDevLoadInfo.Update(modelDevLoadInfo);

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
                    _bllDevLoadInfo.Add(modelDevLoadInfo);


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
                ModelDEV_LOAD_INFO modelDevLoadInfo = PrepareModelLoadInfo();

                //更新数据
                bool status = _bllDevLoadInfo.Enabled(modelDevLoadInfo.F_LOAD_ID);

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
                //若存在开关数据则不能禁用或者删除
                int subDataCount;

                int.TryParse(txtChannelNum.Text, out subDataCount);

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
                ModelDEV_LOAD_INFO modelDevLoadInfo = PrepareModelLoadInfo();

                //更新数据
                bool status = _bllDevLoadInfo.Disabled(modelDevLoadInfo.F_LOAD_ID);

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
                //若存在通道数据则不能禁用或者删除
                int subDataCount;

                int.TryParse(txtChannelNum.Text, out subDataCount);

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
                ModelDEV_LOAD_INFO modelDevLoadInfo = PrepareModelLoadInfo();

                //更新数据
                bool status = _bllDevLoadInfo.Drop(modelDevLoadInfo.F_LOAD_ID);

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

    
        private void gvList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                if (gvList.FocusedRowHandle < 0)
                    return;

                //负载柜编号
                txtF_LOAD_ID.Text = gvList.GetFocusedRowCellValue("F_LOAD_ID").ToString();
                
                //负载柜名称
                txtF_LOAD_NAME.Text = gvList.GetFocusedRowCellValue("F_LOAD_NAME").ToString();
                
                //校验编号
                txtF_LOAD_CALIBRATION.Text = gvList.GetFocusedRowCellValue("F_LOAD_CALIBRATION").ToString();

                //负载柜位置
                txtF_LOAD_POSTION.Text = gvList.GetFocusedRowCellValue("F_LOAD_POSTION").ToString();
                
                //资产编号
                txtF_PROPERTY_ID.Text = gvList.GetFocusedRowCellValue("F_PROPERTY_ID").ToString();
                
                //负载类型
                lueF_LOAD_TYPE.EditValue = decimal.Parse(gvList.GetFocusedRowCellValue("F_LOAD_TYPE").ToString());
                
                //感性负载功率因素
                txtF_CONDUCTYLOAD_COEFFECIENCY.Text = gvList.GetFocusedRowCellValue("F_CONDUCTYLOAD_COEFFECIENCY").ToString();
                
                //负载电压类型
                lueF_LOAD_VOLTAGE_TYPE.EditValue = decimal.Parse(gvList.GetFocusedRowCellValue("F_LOAD_VOLTAGE_TYPE").ToString());
                
                //稳态电流上限
                txtF_LOAD_STABLECURRENT_CEILING.Text = gvList.GetFocusedRowCellValue("F_LOAD_STABLECURRENT_CEILING").ToString();
                
                //稳态电流下限
                txtF_LOAD_STABLECURRENT_FLOOR.Text = gvList.GetFocusedRowCellValue("F_LOAD_STABLECURRENT_FLOOR").ToString();
                
                //冲击电流上限
                txtF_LOAD_PULSECURRENT_CEILING.Text = gvList.GetFocusedRowCellValue("F_LOAD_PULSECURRENT_CEILING").ToString();
                
                //冲击电流下限
                txtF_LOAD_PULSECURRENT_FLOOR.Text = gvList.GetFocusedRowCellValue("F_LOAD_PULSECURRENT_FLOOR").ToString();
                
                //负载电压上限
                txtF_LOAD_VOLTAGE_CEILING.Text = gvList.GetFocusedRowCellValue("F_LOAD_VOLTAGE_CEILING").ToString();
                
                //负载电压下限
                txtF_LOAD_VOLTAGE_FLOOR.Text = gvList.GetFocusedRowCellValue("F_LOAD_VOLTAGE_FLOOR").ToString();
                
                //描述信息
                txtF_LOAD_DESCRIPTION.Text = gvList.GetFocusedRowCellValue("F_LOAD_DESCRIPTION").ToString();

                //禁用状态
                rdoF_DEL.EditValue = decimal.Parse(gvList.GetFocusedRowCellValue("F_DEL").ToString());

                //绑定数据到开关信息
                BindPowerSwitchInfoGridView();

                //计算开关数目
                txtChannelNum.Text = gvLoadChannel.RowCount.ToString();
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

                //设置表格显示
                ApplicationCommon.InitGridviewColumnAndCellFont(gvList);
                ApplicationCommon.InitGridviewColumnAndCellFont(gvLoadChannel);

                //显示负载柜数据
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

                //编辑区负载类型
                ApplicationCommon.GetLookUpEditControl(lueF_LOAD_TYPE, "T_SYSTEM_LIST", "F_VALUE","编码", "F_DISPLAY","类型" ,"F_TYPE='F_LOAD_TYPE'");

                //编辑区电压类型
                ApplicationCommon.GetLookUpEditControl(lueF_LOAD_VOLTAGE_TYPE, "T_SYSTEM_LIST", "F_VALUE", "编码", "F_DISPLAY", "类型", "F_TYPE='F_LOAD_VOLTAGE_TYPE'");


                //禁用状态
                colF_DEL.ColumnEdit = ApplicationCommon.GetRepositoryItemLookUpEditControl("T_SYSTEM_LIST", "F_VALUE", "F_DISPLAY", "F_TYPE='ALLOWUSE'");
                colChannelF_DEL.ColumnEdit = ApplicationCommon.GetRepositoryItemLookUpEditControl("T_SYSTEM_LIST", "F_VALUE", "F_DISPLAY", "F_TYPE='ALLOWUSE'");
                
                //负载类型
                colF_LOAD_TYPE.ColumnEdit = ApplicationCommon.GetRepositoryItemLookUpEditControl("T_SYSTEM_LIST", "F_VALUE", "F_DISPLAY", "F_TYPE='F_LOAD_TYPE'");
                
                //负载电压类型
                colF_LOAD_VOLTAGE_TYPE.ColumnEdit = ApplicationCommon.GetRepositoryItemLookUpEditControl("T_SYSTEM_LIST", "F_VALUE", "F_DISPLAY", "F_TYPE='F_LOAD_VOLTAGE_TYPE'");

                //负载可用状态
                colF_LOAD_CHANNEL_STATUS.ColumnEdit = ApplicationCommon.GetRepositoryItemLookUpEditControl("T_SYSTEM_LIST", "F_VALUE", "F_DISPLAY", "F_TYPE='F_LOAD_CHANNEL_STATUS'");

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
                //根据选择的上位机绑定数据
                _dsLoadInfo = _bllDevLoadInfo.GetList("");

                //有数据情况下绑定
                if (_dsLoadInfo != null && _dsLoadInfo.Tables.Count > 0)
                {
                    gcList.DataSource = _dsLoadInfo.Tables[0];
                }
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

                //获得负载柜编号
                //编号
                if (string.IsNullOrEmpty(txtF_LOAD_ID.Text))
                {
                    return;
                }

                //绑定数据
                ProxyBllDEV_LOAD_CHANNEL_INFO bllDevLoadChannelInfo = new ProxyBllDEV_LOAD_CHANNEL_INFO();
                DataSet dsLoadChannel = bllDevLoadChannelInfo.GetList("F_LOAD_ID='" + txtF_LOAD_ID.Text + "'");

                //有数据情况下绑定
                if (dsLoadChannel != null && dsLoadChannel.Tables.Count > 0 )
                {
                    gcLoadChannel.DataSource = dsLoadChannel.Tables[0];
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
                if (string.IsNullOrEmpty(txtF_LOAD_ID.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("编码不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //名称
                if (string.IsNullOrEmpty(txtF_LOAD_NAME.Text))
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
        private ModelDEV_LOAD_INFO PrepareModelLoadInfo()
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                ModelDEV_LOAD_INFO modelDevLoadInfo = new ModelDEV_LOAD_INFO();


                //负载柜编号
                modelDevLoadInfo.F_LOAD_ID = txtF_LOAD_ID.Text;
                //负载柜名称
                modelDevLoadInfo.F_LOAD_NAME = txtF_LOAD_NAME.Text;
                //校验编号
                modelDevLoadInfo.F_LOAD_CALIBRATION = txtF_LOAD_CALIBRATION.Text;
                //负载柜位置
                modelDevLoadInfo.F_LOAD_POSTION = txtF_LOAD_POSTION.Text;
                //资产编号
                modelDevLoadInfo.F_PROPERTY_ID = txtF_PROPERTY_ID.Text;
                //负载类型
                modelDevLoadInfo.F_LOAD_TYPE = decimal.Parse(lueF_LOAD_TYPE.EditValue.ToString());
                //感性负载功率因素
                modelDevLoadInfo.F_CONDUCTYLOAD_COEFFECIENCY = decimal.Parse(txtF_CONDUCTYLOAD_COEFFECIENCY.Text);
                //负载电压类型
                modelDevLoadInfo.F_LOAD_VOLTAGE_TYPE = decimal.Parse(lueF_LOAD_VOLTAGE_TYPE.EditValue.ToString());
                //稳态电流上限
                modelDevLoadInfo.F_LOAD_STABLECURRENT_CEILING = decimal.Parse(txtF_LOAD_STABLECURRENT_CEILING.Text);
                //稳态电流下限
                modelDevLoadInfo.F_LOAD_STABLECURRENT_FLOOR = decimal.Parse(txtF_LOAD_STABLECURRENT_FLOOR.Text);
                //冲击电流上限
                modelDevLoadInfo.F_LOAD_PULSECURRENT_CEILING = decimal.Parse(txtF_LOAD_PULSECURRENT_CEILING.Text);
                //冲击电流下限
                modelDevLoadInfo.F_LOAD_PULSECURRENT_FLOOR = decimal.Parse(txtF_LOAD_PULSECURRENT_FLOOR.Text);
                //负载电压上限
                modelDevLoadInfo.F_LOAD_VOLTAGE_CEILING = decimal.Parse(txtF_LOAD_VOLTAGE_CEILING.Text);
                //负载电压下限
                modelDevLoadInfo.F_LOAD_VOLTAGE_FLOOR = decimal.Parse(txtF_LOAD_VOLTAGE_FLOOR.Text);
                //描述信息
                modelDevLoadInfo.F_LOAD_DESCRIPTION = txtF_LOAD_DESCRIPTION.Text;


                //创建时间		
                DateTime optDateTime = DateTime.Now;
                modelDevLoadInfo.F_CREATE_TIME = optDateTime;

                //操作员		
                modelDevLoadInfo.F_OPERATOR_ID = AppGlobal.GUserId;

                //操作时间		
                modelDevLoadInfo.F_OPERATIONTIME = optDateTime;

                //是否删除		
                modelDevLoadInfo.F_DEL = 0;

                return modelDevLoadInfo;
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        #endregion


        /// <summary>
        /// 编辑通道信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChannelInfo_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                if (txtF_LOAD_ID.Text == "")
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("请先选择负载柜信息再编辑通道信息。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //准备数据
                ModelDEV_LOAD_CHANNEL_INFO modelDevLoadChannelInfo = new ModelDEV_LOAD_CHANNEL_INFO();

                //负载柜通道操作类
                ProxyBllDEV_LOAD_CHANNEL_INFO bllDevLoadChannelInfo = new ProxyBllDEV_LOAD_CHANNEL_INFO();

                if (gvLoadChannel.RowCount > 0)
                {
                    string loadId = gvLoadChannel.GetFocusedRowCellValue("F_LOAD_ID").ToString();
                    string channelId = gvLoadChannel.GetFocusedRowCellValue("F_LOAD_CHANNEL_ID").ToString();
                    modelDevLoadChannelInfo = bllDevLoadChannelInfo.GetModel(loadId, channelId);
                }
                else
                {
                    modelDevLoadChannelInfo.F_LOAD_ID = txtF_LOAD_ID.Text;
                }


                var frm = new FrmDevLoadChannelInfo(modelDevLoadChannelInfo);

                frm.SaveHandler += BindPowerSwitchInfoGridView;

                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
            
        }
    }
}