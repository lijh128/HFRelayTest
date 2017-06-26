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
    /// 负载电源基础数据
    /// </summary>
    public partial class FrmDevLoadPowerBaseInfo : BaseXtraForm
    {
        #region 声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmDevLoadPowerBaseInfo));

        //负载柜操作类
        private readonly ProxyBllDEV_LOADPOWER_INFO _bllDevLoadpowerInfo = new ProxyBllDEV_LOADPOWER_INFO();


        //负载柜数据集
        private DataSet _dsLoadPower = new DataSet();

        #endregion

        #region 事件方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmDevLoadPowerBaseInfo()
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
                ModelDEV_LOADPOWER_INFO modelDevLoadInfo = PrepareModelLoadPowerInfo();


                //判断此数据是否已经存在
                bool isDataExist = _bllDevLoadpowerInfo.Exists(modelDevLoadInfo.F_LOADPOWER_ID);

                if (isDataExist)
                {
                    //已经存在判断是否更新
                    DialogResult dialogResult = XtraMessageBox.Show("当前数据已存在，是否更新？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    //更新数据
                    bool status = _bllDevLoadpowerInfo.Update(modelDevLoadInfo);

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
                    _bllDevLoadpowerInfo.Add(modelDevLoadInfo);


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
                ModelDEV_LOADPOWER_INFO modelDevLoadpowerInfo = PrepareModelLoadPowerInfo();

                //更新数据
                bool status = _bllDevLoadpowerInfo.Enabled(modelDevLoadpowerInfo.F_LOADPOWER_ID);

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
                ModelDEV_LOADPOWER_INFO modelDevLoadpowerInfo = PrepareModelLoadPowerInfo();

                //更新数据
                bool status = _bllDevLoadpowerInfo.Disabled(modelDevLoadpowerInfo.F_LOADPOWER_ID);

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

                //检查必填字段
                bool isAllOk = CheckNotNullField();

                if (!isAllOk)
                    return;

                //准备要存储的数据
                ModelDEV_LOADPOWER_INFO modelDevLoadpowerInfo = PrepareModelLoadPowerInfo();



                //判断是否有关系
                bool hasRelation = _bllDevLoadpowerInfo.HasRelation(modelDevLoadpowerInfo.F_LOADPOWER_ID);
                if (hasRelation)
                {
                    XtraMessageBox.Show("此设备有和其他设备的关系，不能删除。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //更新数据
                bool status = _bllDevLoadpowerInfo.Drop(modelDevLoadpowerInfo.F_LOADPOWER_ID);

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

                //负载电源编号
                txtF_LOADPOWER_ID.Text = gvList.GetFocusedRowCellValue("F_LOADPOWER_ID").ToString();

                //负载电源名称
                txtF_LOADPOWER_NAME.Text = gvList.GetFocusedRowCellValue("F_LOADPOWER_NAME").ToString();

                //校准编号
                txtF_LOADPOWER_CALIBRATION.Text = gvList.GetFocusedRowCellValue("F_LOADPOWER_CALIBRATION").ToString();

                //通信端口
                txtF_COM_ADDRESS.Text = gvList.GetFocusedRowCellValue("F_COM_ADDRESS").ToString();

                //通信地址
                txtF_LOADPOWER_ADDRESS.EditValue = decimal.Parse(gvList.GetFocusedRowCellValue("F_LOADPOWER_ADDRESS").ToString());

                //负载电源输出电压上限
                txtF_LOADPOWER_VOLTAGE_CEILING.Text = gvList.GetFocusedRowCellValue("F_LOADPOWER_VOLTAGE_CEILING").ToString();

                //负载电源输出电压下限
                txtF_LOADPOWER_VOLTAGE_FLOOR.Text = gvList.GetFocusedRowCellValue("F_LOADPOWER_VOLTAGE_FLOOR").ToString();

                //负载电源输出电流上限
                txtF_LOADPOWER_CURRENT_CEILING.Text = gvList.GetFocusedRowCellValue("F_LOADPOWER_CURRENT_CEILING").ToString();

                //负载电源输出电流下限
                txtF_LOADPOWER_CURRENT_FLOOR.Text = gvList.GetFocusedRowCellValue("F_LOADPOWER_CURRENT_FLOOR").ToString();

                //负载电源输出频率上限
                txtF_LOADPOWER_FREQUENCY_CEILING.Text = gvList.GetFocusedRowCellValue("F_LOADPOWER_FREQUENCY_CEILING").ToString();

                //负载电源输出频率下限
                txtF_LOADPOWER_FREQUENCY_FLOOR.Text = gvList.GetFocusedRowCellValue("F_LOADPOWER_FREQUENCY_FLOOR").ToString();

                //负载电源输出功率
                txtF_LOADPOWER_POWER.Text = gvList.GetFocusedRowCellValue("F_LOADPOWER_POWER").ToString();

                //负载电源运行状态
                lueF_LOADPOWER_RUN_STATUS.EditValue = decimal.Parse(gvList.GetFocusedRowCellValue("F_LOADPOWER_RUN_STATUS").ToString());

                //备注
                txtF_LOADPOWER_MEMO.Text = gvList.GetFocusedRowCellValue("F_LOADPOWER_MEMO").ToString();

                //禁用状态
                rdoF_DEL.EditValue = decimal.Parse(gvList.GetFocusedRowCellValue("F_DEL").ToString());

                //绑定数据到开关信息
                BindPowerSwitchInfoGridView();

                
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


                //开关状态
                ApplicationCommon.GetLookUpEditControl(lueF_LOADPOWER_RUN_STATUS, "T_SYSTEM_LIST", "F_VALUE", "编码", "F_DISPLAY", "状态", "F_TYPE='F_LOADPOWER_RUN_STATUS'");

               
                //负载电源状态
                colF_LOADPOWER_RUN_STATUS.ColumnEdit = ApplicationCommon.GetRepositoryItemLookUpEditControl("T_SYSTEM_LIST", "F_VALUE", "F_DISPLAY", "F_TYPE='F_LOADPOWER_RUN_STATUS'");

                //禁用状态
                colF_DEL.ColumnEdit = ApplicationCommon.GetRepositoryItemLookUpEditControl("T_SYSTEM_LIST", "F_VALUE", "F_DISPLAY", "F_TYPE='ALLOWUSE'");
               
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
                _dsLoadPower = _bllDevLoadpowerInfo.GetList("");

                //有数据情况下绑定
                if (_dsLoadPower != null && _dsLoadPower.Tables.Count > 0)
                {
                    gcList.DataSource = _dsLoadPower.Tables[0];
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
                if (string.IsNullOrEmpty(txtF_LOADPOWER_ID.Text))
                {
                    return;
                }

                //绑定数据
                ProxyBllDEV_LOAD_CHANNEL_INFO bllDevLoadChannelInfo = new ProxyBllDEV_LOAD_CHANNEL_INFO();
                DataSet dsLoadChannel = bllDevLoadChannelInfo.GetList("F_LOAD_ID='" + txtF_LOADPOWER_ID.Text + "'");

               
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
                if (string.IsNullOrEmpty(txtF_LOADPOWER_ID.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("编码不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //名称
                if (string.IsNullOrEmpty(txtF_LOADPOWER_NAME.Text))
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
        private ModelDEV_LOADPOWER_INFO PrepareModelLoadPowerInfo()
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                ModelDEV_LOADPOWER_INFO modelDevLoadpowerInfo = new ModelDEV_LOADPOWER_INFO();


                //敷在电源编号
                modelDevLoadpowerInfo.F_LOADPOWER_ID = txtF_LOADPOWER_ID.Text;
                //负载电源名称
                modelDevLoadpowerInfo.F_LOADPOWER_NAME = txtF_LOADPOWER_NAME.Text;
                //校验编码
                modelDevLoadpowerInfo.F_LOADPOWER_CALIBRATION = txtF_LOADPOWER_CALIBRATION.Text;
                //端口号
                modelDevLoadpowerInfo.F_COM_ADDRESS = txtF_COM_ADDRESS.Text.ToUpper();
                //地址
                modelDevLoadpowerInfo.F_LOADPOWER_ADDRESS = decimal.Parse(txtF_LOADPOWER_ADDRESS.EditValue.ToString());

                decimal tempDecimal;
                
                //负载电源输出电压上限	
                decimal.TryParse(txtF_LOADPOWER_VOLTAGE_CEILING.Text,out tempDecimal);
                modelDevLoadpowerInfo.F_LOADPOWER_VOLTAGE_CEILING = tempDecimal;
                
                //负载电源输出电压下限
                decimal.TryParse(txtF_LOADPOWER_VOLTAGE_FLOOR.Text, out tempDecimal);
                modelDevLoadpowerInfo.F_LOADPOWER_VOLTAGE_FLOOR = tempDecimal;
                
                //负载电源输出电流上限
                decimal.TryParse(txtF_LOADPOWER_CURRENT_CEILING.Text, out tempDecimal);
                modelDevLoadpowerInfo.F_LOADPOWER_CURRENT_CEILING = tempDecimal;

                //负载电源输出电流下限
                decimal.TryParse(txtF_LOADPOWER_CURRENT_FLOOR.Text, out tempDecimal);
                modelDevLoadpowerInfo.F_LOADPOWER_CURRENT_FLOOR = tempDecimal;
                
                //负载电源输出频率上限
                decimal.TryParse(txtF_LOADPOWER_FREQUENCY_CEILING.Text, out tempDecimal);
                modelDevLoadpowerInfo.F_LOADPOWER_FREQUENCY_CEILING = tempDecimal;
                
                //负载电源输出频率下限
                decimal.TryParse(txtF_LOADPOWER_FREQUENCY_FLOOR.Text, out tempDecimal);
                modelDevLoadpowerInfo.F_LOADPOWER_FREQUENCY_FLOOR = tempDecimal;
               
                //负载电源输出功率
                decimal.TryParse(txtF_LOADPOWER_VOLTAGE_CEILING.Text, out tempDecimal);
                modelDevLoadpowerInfo.F_LOADPOWER_POWER = tempDecimal;
                
                //负载电源运行状态
                modelDevLoadpowerInfo.F_LOADPOWER_RUN_STATUS = decimal.Parse(lueF_LOADPOWER_RUN_STATUS.EditValue.ToString());
                //备注
                modelDevLoadpowerInfo.F_LOADPOWER_MEMO = txtF_LOADPOWER_MEMO.Text;

                //创建时间		
                DateTime optDateTime = DateTime.Now;
                modelDevLoadpowerInfo.F_CREATE_TIME = optDateTime;

                //操作员		
                modelDevLoadpowerInfo.F_OPERATOR_ID = AppGlobal.GUserId;

                //操作时间		
                modelDevLoadpowerInfo.F_OPERATIONTIME = optDateTime;

                //是否删除		
                modelDevLoadpowerInfo.F_DEL = 0;

                return modelDevLoadpowerInfo;
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        #endregion

        private void btnChannelInfo_Click(object sender, EventArgs e)
        {
            //准备数据
            ModelDEV_LOAD_CHANNEL_INFO modelDevLoadChannelInfo = new ModelDEV_LOAD_CHANNEL_INFO();

            //负载柜通道操作类
            ProxyBllDEV_LOAD_CHANNEL_INFO bllDevLoadChannelInfo = new ProxyBllDEV_LOAD_CHANNEL_INFO();

         


            var frm = new FrmDevLoadChannelInfo(modelDevLoadChannelInfo);

            frm.SaveHandler += BindPowerSwitchInfoGridView;

            frm.ShowDialog();
        }
    }
}