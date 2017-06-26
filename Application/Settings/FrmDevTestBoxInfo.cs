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
    /// 试验箱基础数据维护
    /// </summary>
    public partial class FrmDevTestBoxInfo : BaseXtraForm
    {
        #region 声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmDevSubordinateBaseInfo));


        //操作类
        private ProxyBllDEV_TESTBOX_INFO _bllDevTestboxInfo = new ProxyBllDEV_TESTBOX_INFO();
       

        //数据集
        private DataSet _dsTestBox = new DataSet();
        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmDevTestBoxInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体载入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmDevTestBoxInfo_Load(object sender, EventArgs e)
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                ApplicationCommon.InitGridviewColumnAndCellFont(gvList);
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


                //试验箱状态选择信息
                ApplicationCommon.GetLookUpEditControl(lueF_TESTBOX_STATUS, "T_SYSTEM_LIST", "F_VALUE", "编码", "F_DISPLAY", "状态", "F_TYPE='F_TESTBOX_STATUS'");

                //试验箱状态
                colF_TESTBOX_STATUS.ColumnEdit = ApplicationCommon.GetRepositoryItemLookUpEditControl("T_SYSTEM_LIST", "F_VALUE", "F_DISPLAY", "F_TYPE='F_TESTBOX_STATUS'");

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
                _dsTestBox = _bllDevTestboxInfo.GetAllList();

                //有数据情况下绑定
                if (_dsTestBox != null && _dsTestBox.Tables.Count > 0)
                {
                    gcList.DataSource = _dsTestBox.Tables[0];
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
                if (string.IsNullOrEmpty(txtF_TESTBOX_ID.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("编码不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //名称
                if (string.IsNullOrEmpty(txtF_TESTBOX_NAME.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("名称不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


                //地址
                if (string.IsNullOrEmpty(txtF_TESTBOX_ADDRESS.Text))
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
                

                //试验箱状态
                if (lueF_TESTBOX_STATUS.EditValue ==null)
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("试验箱状态不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private ModelDEV_TESTBOX_INFO PrepareModelSubordinateInfo()
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                ModelDEV_TESTBOX_INFO modelDevTestboxInfo = new ModelDEV_TESTBOX_INFO();


                //	试验箱编号			
                modelDevTestboxInfo.F_TESTBOX_ID = txtF_TESTBOX_ID.Text;
                //	试验箱名称			
                modelDevTestboxInfo.F_TESTBOX_NAME = txtF_TESTBOX_NAME.Text;
                      
                //校准编号
                modelDevTestboxInfo.F_TESTBOX_CALIBRATION = txtF_TESTBOX_CALIBRATION.Text;

                //端口
                modelDevTestboxInfo.F_COM_ADDRESS = txtF_COM_ADDRESS.Text.ToUpper();

                //通信地址
                decimal subordinateAddress;

                decimal.TryParse(txtF_TESTBOX_ADDRESS.Text, out subordinateAddress);

                //通信地址
                modelDevTestboxInfo.F_TESTBOX_ADDRESS = subordinateAddress;
                
                //	试验箱状态			
                modelDevTestboxInfo.F_TESTBOX_STATUS = decimal.Parse(lueF_TESTBOX_STATUS.EditValue.ToString());

                //	备注			
                modelDevTestboxInfo.F_TESTBOX_MEMO = txtF_TESTBOX_MEMO.Text;


                //创建时间		
                DateTime optDateTime = DateTime.Now;
                modelDevTestboxInfo.F_CREATE_TIME = optDateTime;

                //操作员		
                modelDevTestboxInfo.F_OPERATOR_ID = AppGlobal.GUserId;

                //操作时间		
                modelDevTestboxInfo.F_OPERATIONTIME = optDateTime;

                //是否删除		
                modelDevTestboxInfo.F_DEL = 0;

                return modelDevTestboxInfo;
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
                ModelDEV_TESTBOX_INFO modelDevTestboxInfo = PrepareModelSubordinateInfo();


                //判断此数据是否已经存在
                bool isDataExist = _bllDevTestboxInfo.Exists(modelDevTestboxInfo.F_TESTBOX_ID);

                if (isDataExist)
                {
                    //已经存在判断是否更新
                    DialogResult dialogResult = XtraMessageBox.Show("当前数据已存在，是否更新？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    //更新数据
                    bool status = _bllDevTestboxInfo.Update(modelDevTestboxInfo);

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
                    _bllDevTestboxInfo.Add(modelDevTestboxInfo);


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
                ModelDEV_TESTBOX_INFO modelDevTestboxInfo = PrepareModelSubordinateInfo();

                //更新数据
                bool status = _bllDevTestboxInfo.Enabled(modelDevTestboxInfo.F_TESTBOX_ID);

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
                ModelDEV_TESTBOX_INFO modelDevTestboxInfo = PrepareModelSubordinateInfo();

                //更新数据
                bool status = _bllDevTestboxInfo.Disabled(modelDevTestboxInfo.F_TESTBOX_ID);

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
                //若存在开关数据则不能禁用或者删除
              
                //检查必填字段
                bool isAllOk = CheckNotNullField();

                if (!isAllOk)
                    return;

                //准备要存储的数据
                ModelDEV_TESTBOX_INFO modelDevTestboxInfo = PrepareModelSubordinateInfo();

                //更新数据
                bool status = _bllDevTestboxInfo.Drop(modelDevTestboxInfo.F_TESTBOX_ID);

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


                string testboxId = gvList.GetFocusedRowCellValue("F_TESTBOX_ID").ToString();

                ModelDEV_TESTBOX_INFO modelDevTestboxInfo = _bllDevTestboxInfo.GetModel(testboxId);


                //试验箱编号		
                txtF_TESTBOX_ID.Text = modelDevTestboxInfo.F_TESTBOX_ID;

                //试验箱名称		
                txtF_TESTBOX_NAME.Text = modelDevTestboxInfo.F_TESTBOX_NAME;

                //校准编号
                txtF_TESTBOX_CALIBRATION.Text = modelDevTestboxInfo.F_TESTBOX_CALIBRATION;

                //所在负载柜编号		
                txtF_COM_ADDRESS.Text = modelDevTestboxInfo.F_COM_ADDRESS;

                //地址
                txtF_TESTBOX_ADDRESS.Text = modelDevTestboxInfo.F_TESTBOX_ADDRESS.ToString();

               //工作状态		
                lueF_TESTBOX_STATUS.EditValue = modelDevTestboxInfo.F_TESTBOX_STATUS;

                //备注
                txtF_TESTBOX_MEMO.Text = modelDevTestboxInfo.F_TESTBOX_MEMO;

                //禁用状态		
                rdoF_DEL.EditValue = modelDevTestboxInfo.F_DEL;


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
            (new FrmDevUpgradeRecord(txtF_TESTBOX_ID.Text)).ShowDialog();
        }

        #endregion

      

        
    }
}