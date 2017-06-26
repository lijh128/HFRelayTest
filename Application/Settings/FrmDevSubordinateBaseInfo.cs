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
    /// 下位机基础数据维护
    /// </summary>
    public partial class FrmDevSubordinateBaseInfo : BaseXtraForm
    {
        #region 声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmDevSubordinateBaseInfo));


        //操作类
        private ProxyBllDEV_SUBORDINATE_INFO _bllDevSubordinateInfo = new ProxyBllDEV_SUBORDINATE_INFO();
       

        //数据集
        private DataSet _dsSubordinateInfo = new DataSet();
        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmDevSubordinateBaseInfo()
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


                //下位机状态选择信息
                ApplicationCommon.GetLookUpEditControl(lueF_SUBORDINATE_STATUS,"T_SYSTEM_LIST", "F_VALUE","编码", "F_DISPLAY","状态", "F_TYPE='F_SUBORDINATE_STATUS'");

                //下位机状态
                colF_SUBORDINATE_STATUS.ColumnEdit = ApplicationCommon.GetRepositoryItemLookUpEditControl("T_SYSTEM_LIST", "F_VALUE", "F_DISPLAY", "F_TYPE='F_SUBORDINATE_STATUS'");

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
                _dsSubordinateInfo = _bllDevSubordinateInfo.GetAllList();

                //有数据情况下绑定
                if (_dsSubordinateInfo != null && _dsSubordinateInfo.Tables.Count > 0)
                {
                    gcList.DataSource = _dsSubordinateInfo.Tables[0];
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
                if (string.IsNullOrEmpty(txtF_SUBORDINATE_ID.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("编码不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //名称
                if (string.IsNullOrEmpty(txtF_SUBORDINATE_NAME.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("名称不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


                //地址
                if (string.IsNullOrEmpty(txtF_SUBORDINATE_ADDRESS.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("通信地址不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //端口
                if (string.IsNullOrEmpty(txtF_COM_ADDRESS.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("通信端口不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                

                //下位机状态
                if (lueF_SUBORDINATE_STATUS.EditValue ==null)
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("下位机状态不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        ///     准备要操作Model
        /// </summary>
        /// <returns></returns>
        private ModelDEV_SUBORDINATE_INFO PrepareModelSubordinateInfo()
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                ModelDEV_SUBORDINATE_INFO modelDevSubordinateInfo = new ModelDEV_SUBORDINATE_INFO();


                //	下位机编号			
                modelDevSubordinateInfo.F_SUBORDINATE_ID = txtF_SUBORDINATE_ID.Text;
                //	下位机名称			
                modelDevSubordinateInfo.F_SUBORDINATE_NAME = txtF_SUBORDINATE_NAME.Text;
                      
                //校准编号
                modelDevSubordinateInfo.F_SUBORDINATE_CALIBRATION = txtF_SUBORDINATE_CALIBRATION.Text;

                //端口
                modelDevSubordinateInfo.F_COM_ADDRESS = txtF_COM_ADDRESS.Text.ToUpper();

                //通信地址
                decimal subordinateAddress;

                decimal.TryParse(txtF_SUBORDINATE_ADDRESS.Text, out subordinateAddress);

                //通信地址
                modelDevSubordinateInfo.F_SUBORDINATE_ADDRESS = subordinateAddress;
                
                //	下位机状态			
                modelDevSubordinateInfo.F_SUBORDINATE_STATUS = decimal.Parse(lueF_SUBORDINATE_STATUS.EditValue.ToString());

                //	备注			
                modelDevSubordinateInfo.F_SUBORDINATE_MEMO = txtF_SUBORDINATE_MEMO.Text;


                //创建时间		
                DateTime optDateTime = DateTime.Now;
                modelDevSubordinateInfo.F_CREATE_TIME = optDateTime;

                //操作员		
                modelDevSubordinateInfo.F_OPERATOR_ID = AppGlobal.GUserId;

                //操作时间		
                modelDevSubordinateInfo.F_OPERATIONTIME = optDateTime;

                //是否删除		
                modelDevSubordinateInfo.F_DEL = 0;

                return modelDevSubordinateInfo;
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
                ModelDEV_SUBORDINATE_INFO modelDevSubordinateInfo = PrepareModelSubordinateInfo();


                //判断此数据是否已经存在
                bool isDataExist = _bllDevSubordinateInfo.Exists(modelDevSubordinateInfo.F_SUBORDINATE_ID);

                if (isDataExist)
                {
                    //已经存在判断是否更新
                    DialogResult dialogResult = XtraMessageBox.Show("当前数据已存在，是否更新？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    //更新数据
                    bool status = _bllDevSubordinateInfo.Update(modelDevSubordinateInfo);

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
                    _bllDevSubordinateInfo.Add(modelDevSubordinateInfo);


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
                ModelDEV_SUBORDINATE_INFO modelDevSubordinateInfo = PrepareModelSubordinateInfo();

                //更新数据
                bool status = _bllDevSubordinateInfo.Enabled(modelDevSubordinateInfo.F_SUBORDINATE_ID);

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
                ModelDEV_SUBORDINATE_INFO modelDevSubordinateInfo = PrepareModelSubordinateInfo();

                //更新数据
                bool status = _bllDevSubordinateInfo.Disabled(modelDevSubordinateInfo.F_SUBORDINATE_ID);

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
                ModelDEV_SUBORDINATE_INFO modelDevSubordinateInfo = PrepareModelSubordinateInfo();


                //判断是否有关系
                bool hasRelation = _bllDevSubordinateInfo.HasRelation(modelDevSubordinateInfo.F_SUBORDINATE_ID);
                if (hasRelation)
                {
                    XtraMessageBox.Show("此设备有和其他设备的关系，不能删除。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //更新数据
                bool status = _bllDevSubordinateInfo.Drop(modelDevSubordinateInfo.F_SUBORDINATE_ID);

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


                string subordinateId = gvList.GetFocusedRowCellValue("F_SUBORDINATE_ID").ToString();

                ModelDEV_SUBORDINATE_INFO modelDevSubordinateInfo = _bllDevSubordinateInfo.GetModel(subordinateId);


                //下位机编号		
                txtF_SUBORDINATE_ID.Text = modelDevSubordinateInfo.F_SUBORDINATE_ID;

                //下位机名称		
                txtF_SUBORDINATE_NAME.Text = modelDevSubordinateInfo.F_SUBORDINATE_NAME;

                //校准编号
                txtF_SUBORDINATE_CALIBRATION.Text = modelDevSubordinateInfo.F_SUBORDINATE_CALIBRATION;

                //所在负载柜编号		
                txtF_COM_ADDRESS.Text = modelDevSubordinateInfo.F_COM_ADDRESS;

                //上位机信息		
                txtF_SUBORDINATE_ADDRESS.Text = modelDevSubordinateInfo.F_SUBORDINATE_ADDRESS.ToString();

                //工作状态		
                lueF_SUBORDINATE_STATUS.EditValue = modelDevSubordinateInfo.F_SUBORDINATE_STATUS;

                //备注
                txtF_SUBORDINATE_MEMO.Text = modelDevSubordinateInfo.F_SUBORDINATE_MEMO;

                //禁用状态		
                rdoF_DEL.EditValue = modelDevSubordinateInfo.F_DEL;


             }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }


        /// <summary>
        /// 管理更新历史
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHis_Click(object sender, EventArgs e)
        {
            (new FrmDevUpgradeRecord(txtF_SUBORDINATE_ID.Text)).ShowDialog();
        }

        #endregion

      

        
    }
}