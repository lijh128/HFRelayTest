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
    public partial class FrmMaintainMonitorParameter : BaseXtraForm
    {
        #region 声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmMaintainMonitorParameter));

        //参数信息操作类
        ProxyBllTESTTASK_PARVALUE _bllteTestTtaskParvalue = new ProxyBllTESTTASK_PARVALUE();

        //参数类型操作类
        BllTESTTASK_PARTYPE _bllMonitorPartype = new BllTESTTASK_PARTYPE();

        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmMaintainMonitorParameter()
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

                //填充参数选择类型列表框
                FillAllSelectedControls();
            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 填充参数选择类型列表框
        /// </summary>
        private void FillAllSelectedControls()
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                ApplicationCommon.FillLueTestParameterType(lueParameterType);

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
        ///  绑定表格
        /// </summary>
        private void BindGridview()
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                string typeCode = lueParameterType.EditValue.ToString();

                //如果为空则返回
                if (string.IsNullOrEmpty(typeCode))
                    return;


                DataSet dsParameterMonitorcomm = _bllteTestTtaskParvalue.GetList("F_TYPE_CODE='" + typeCode + "'");

                //有数据情况下绑定
                if (dsParameterMonitorcomm != null && dsParameterMonitorcomm.Tables.Count > 0 )
                {
                    gcList.DataSource = dsParameterMonitorcomm.Tables[0];
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
                txtCode.Text = gvList.GetFocusedRowCellValue("F_CODE").ToString();

                //名称
                txtName.Text = gvList.GetFocusedRowCellValue("F_NAME").ToString();


                //描述
                txtDescription.Text = gvList.GetFocusedRowCellValue("F_DESCRIPTION").ToString();

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
                //检查参数类型
                if (lueParameterType.EditValue == null)
                {
                    XtraMessageBox.Show("参数类型选择不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                string typeCode = lueParameterType.EditValue.ToString();
                if (string.IsNullOrEmpty(typeCode))
                {
                    XtraMessageBox.Show("参数类型选择不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //编号
                if (string.IsNullOrEmpty(txtCode.Text))
                {
                    XtraMessageBox.Show("编号不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //名称
                if (string.IsNullOrEmpty(txtName.Text))
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
        private ModelTESTTASK_PARVALUE PrepaireModelParameterMonitorcommon()
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                ModelTESTTASK_PARVALUE modelParameterMonitorcommon = new ModelTESTTASK_PARVALUE();

                //分类代码		
                modelParameterMonitorcommon.F_TYPE_CODE = lueParameterType.EditValue.ToString();

                //参数编号		
                modelParameterMonitorcommon.F_CODE = txtCode.Text;

                //参数名称		
                modelParameterMonitorcommon.F_NAME = txtName.Text;

                //描述		
                modelParameterMonitorcommon.F_DESCRIPTION = txtDescription.Text;

                //创建时间		
                DateTime optTime = DateTime.Now;
                modelParameterMonitorcommon.F_CREATE_TIME = optTime;

                //操作员		
                modelParameterMonitorcommon.F_OPERATOR_ID = AppGlobal.GUserId;

                //操作时间		
                modelParameterMonitorcommon.F_OPERATIONTIME = optTime;

                //是否删除		
                modelParameterMonitorcommon.F_DEL = 0;

                return modelParameterMonitorcommon;

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
                txtCode.Text = "";

                //名称
                txtName.Text = "";

                //描述
                txtDescription.Text = "";

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
        /// 关闭按钮事件
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
        /// 如果存在则更新，如果不存在就增加
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
                ModelTESTTASK_PARVALUE modelParameterMonitorcommon = PrepaireModelParameterMonitorcommon();

                //判断此数据是否已经存在
                bool isDataExist = _bllteTestTtaskParvalue.Exists(modelParameterMonitorcommon.F_TYPE_CODE, modelParameterMonitorcommon.F_CODE);

                //如果存在则更新
                if (isDataExist)
                {
                    //已经存在判断是否更新
                    DialogResult dialogResult = XtraMessageBox.Show("当前数据已存在，是否更新？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    //更新数据
                    bool status = _bllteTestTtaskParvalue.Update(modelParameterMonitorcommon);

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
                else
                {
                    //插入数据
                    _bllteTestTtaskParvalue.Add(modelParameterMonitorcommon);


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
                ModelTESTTASK_PARVALUE modelParameterMonitorcommon = PrepaireModelParameterMonitorcommon();

                //更新数据
                bool status = _bllteTestTtaskParvalue.Enabled(modelParameterMonitorcommon.F_TYPE_CODE,modelParameterMonitorcommon.F_CODE);

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
                ModelTESTTASK_PARVALUE modelParameterMonitorcommon = PrepaireModelParameterMonitorcommon();

                //更新数据
                bool status = _bllteTestTtaskParvalue.Disabled(modelParameterMonitorcommon.F_TYPE_CODE, modelParameterMonitorcommon.F_CODE);

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
                ModelTESTTASK_PARVALUE modelParameterMonitorcommon = PrepaireModelParameterMonitorcommon();

                //更新数据
                bool status = _bllteTestTtaskParvalue.Drop(modelParameterMonitorcommon.F_TYPE_CODE, modelParameterMonitorcommon.F_CODE);

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