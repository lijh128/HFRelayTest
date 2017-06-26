using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.DXCore.Controls.XtraEditors;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using log4net;
using RelayTest.BLL;
using RelayTest.Model;
using RelayTest.Util.Common;

namespace RelayTest.Application.Settings
{
  
    /// <summary>
    /// 检测参数设置
    /// </summary>
    public partial class FrmMaintainMonitorParameterType : BaseXtraForm
    {
        #region 声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmMaintainMonitorParameterType));


        //参数类型操作类
        BllTESTTASK_PARTYPE _bllTesttaskPartype = new BllTESTTASK_PARTYPE();

        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmMaintainMonitorParameterType()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体载入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMaintainMonitorParameter_Load(object sender, EventArgs e)
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //初始化界面上的控件
                InitAllControls();

                BindGridview();


            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        #region  自定义方法

        /// <summary>
        /// 初始化界面上的控件
        /// </summary>
        private void InitAllControls()
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                FillAllSelectedControls();
            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        private void FillAllSelectedControls()
        {
//禁用状态
            colF_DEL.ColumnEdit = ApplicationCommon.GetRepositoryItemLookUpEditControl("T_SYSTEM_LIST", "F_VALUE", "F_DISPLAY", "F_TYPE='ALLOWUSE'");
        }

        /// <summary>
        ///  绑定表格
        /// </summary>
        private void BindGridview()
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                DataSet dsParameterType = _bllTesttaskPartype.GetAllList();
                //有数据情况下绑定
                if (dsParameterType != null && dsParameterType.Tables.Count > 0 )
                {
                    gcList.DataSource = dsParameterType.Tables[0];
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

            
                //编号
                txtTypeCode.Text = gvList.GetFocusedRowCellValue("F_TYPE_CODE").ToString();

                //名称
                txtTypeName.Text = gvList.GetFocusedRowCellValue("F_TYPE_NAME").ToString();


                //禁用状态
                radioAllowUse.EditValue = int.Parse(gvList.GetFocusedRowCellValue("F_DEL").ToString());


            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
            
        }


        /// <summary>
        /// 检查必填段
        /// </summary>
        /// <returns></returns>
        private bool CheckNotNullField()
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                

                //编号
                if (string.IsNullOrEmpty(txtTypeCode.Text))
                {
                    XtraMessageBox.Show("编码不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //名称
                if (string.IsNullOrEmpty(txtTypeName.Text))
                {
                    XtraMessageBox.Show("名称不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// 准备要操作的ModelPARAMETER_MONITORCOMMON
        /// </summary>
        /// <returns></returns>
        private ModelTESTTASK_PARTYPE PreapairModelParameterMonitortype()
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                ModelTESTTASK_PARTYPE modelParameterMonitortype = new ModelTESTTASK_PARTYPE();


                //参数编号		
                modelParameterMonitortype.F_TYPE_CODE = txtTypeCode.Text;

                //参数名称		
                modelParameterMonitortype.F_TYPE_NAME = txtTypeName.Text;

                //创建时间		
                DateTime optTime = DateTime.Now;
                modelParameterMonitortype.F_CREATE_TIME = optTime;

                //操作员		
                modelParameterMonitortype.F_OPERATOR_ID = AppGlobal.GUserId;

                //操作时间		
                modelParameterMonitortype.F_OPERATIONTIME = optTime;

                //是否删除		
                modelParameterMonitortype.F_DEL = 0;

                return modelParameterMonitortype;

            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
           
        }

        #endregion

        #region 系统事件

        /// <summary>
        /// 点击表格事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                //编号
                txtTypeCode.Text = "";

                //名称
                txtTypeName.Text = "";


                //禁用状态
                radioAllowUse.EditValue = 0;


                //若无记录则返回
                if (gvList.RowCount <= 0)
                    return;

                //若如焦点则返回
                if (gvList.FocusedRowHandle < 0)
                    return;

                //将具体信息显示在编辑控件
                FillDataToDisplayControls();

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
        /// 参数类型变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lueParameterType_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                BindGridview();

                gvList_RowClick(this, null);

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
                ModelTESTTASK_PARTYPE modelParameterMonitortype = PreapairModelParameterMonitortype();

                //判断此数据是否已经存在
                bool isDataExist = _bllTesttaskPartype.Exists(modelParameterMonitortype.F_TYPE_CODE);

                //如果存在数据则更新
                if (isDataExist)
                {
                    //已经存在判断是否更新
                    DialogResult dialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("当前数据已存在，是否更新？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    //更新数据
                    bool status = _bllTesttaskPartype.Update(modelParameterMonitortype);

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
                        XtraMessageBox.Show("没有数据被更新，执行中断。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                    //如果不存在就增加数据
                else
                {
                    //插入数据
                    _bllTesttaskPartype.Add(modelParameterMonitortype);


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
        /// 启用一条数据
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
                ModelTESTTASK_PARTYPE modelParameterMonitortype = PreapairModelParameterMonitortype();

                //更新数据
                bool status = _bllTesttaskPartype.Enabled(modelParameterMonitortype.F_TYPE_CODE);

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
        /// 禁用一条数据
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
                ModelTESTTASK_PARTYPE modelParameterMonitortype = PreapairModelParameterMonitortype();

                //更新数据
                bool status = _bllTesttaskPartype.Disabled(modelParameterMonitortype.F_TYPE_CODE);

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
                ModelTESTTASK_PARTYPE modelParameterMonitortype = PreapairModelParameterMonitortype();

                //更新数据
                bool status = _bllTesttaskPartype.Drop(modelParameterMonitortype.F_TYPE_CODE);

                //绑定数据
                BindGridview();
                //重新刷新数据
                lueParameterType_EditValueChanged(this, null);

                if (status)
                {
                    XtraMessageBox.Show("此数据已删除。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //刷新数据
                    gvList_RowClick(this, null);
                }
                else
                {
                    XtraMessageBox.Show("没有数据被删除。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        #endregion
    }
}