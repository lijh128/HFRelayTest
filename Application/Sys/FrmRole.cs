using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using log4net;
using RelayTest.Model;

namespace RelayTest.Application.Sys
{
    
    /// <summary>
    /// 角色管理
    /// </summary>
    public partial class FrmRole : DevExpress.XtraEditors.XtraForm
    {

        #region 成员声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmRole));

       //操作类
        private ProxyBllSYSTEM_ROLE _bllSystemRole = new ProxyBllSYSTEM_ROLE();

        /// <summary>
        /// 角色
        /// </summary>
        private DataSet _dsRole;

        #endregion

        /// <summary>
        /// 构造方法
        /// </summary>
        public FrmRole()
        {
                     InitializeComponent();

          

        }
        #region 自定义方法

        /// <summary>
        /// 初始化界面
        /// </summary>
        private void InitAllControl()
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                

            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }

        }

        /// <summary>
        /// 填充表格
        /// </summary>
        private void BindGridview()
        {
            _dsRole = _bllSystemRole.GetAllList();

            //绑定数据
            if (_dsRole != null && _dsRole.Tables.Count > 0)
            {
                gcList.DataSource = _dsRole.Tables[0];

            }
        }

        /// <summary>
        /// 准备数据
        /// </summary>
        /// <returns></returns>
        private ModelSYSTEM_ROLE PrepareModelSystemRole()
        {

            //创建操作类
            ModelSYSTEM_ROLE model = new ModelSYSTEM_ROLE();

            //编号
            model.F_ROLE_ID = txtF_ROLE_ID.Text;

            //名称
            model.F_ROLE_NAME = txtF_ROLE_NAME.Text;

            //描述
            model.F_DESC = txtF_DESC.Text;

           
            //创建时间
            DateTime optDateTime = DateTime.Now;
            model.F_CREATE_TIME = optDateTime;

            //操作员
            model.F_OPERATOR_ID = AppGlobal.GUserId;


            //操作时间
            model.F_OPERATIONTIME = optDateTime;

            //是否删除
            model.F_DEL = 0;

            return model;
        }



        /// <summary>
        /// 检查必填字段
        /// </summary>
        /// <returns></returns>
        private bool CheckNotNullField()
        {
            //角色编码不能为空
            if (string.IsNullOrEmpty(txtF_ROLE_ID.Text))
            {
                XtraMessageBox.Show("编码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //角色名称不能为空
            if (string.IsNullOrEmpty(txtF_ROLE_NAME.Text))
            {
                XtraMessageBox.Show("名称不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            
            return true;
        }
        #endregion

        #region 事件方法

       

        /// <summary>
        /// 载入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRole_Load(object sender, EventArgs e)
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                
                //初始化界面
                InitAllControl();

                //绑定表格
                BindGridview();

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
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //检查必填字段
                bool isAllOk = CheckNotNullField();

                if (!isAllOk)
                    return;

                //准备要存储的数据
                ModelSYSTEM_ROLE modelSystemRole = PrepareModelSystemRole();


                //判断此数据是否已经存在
                bool isDataExist = _bllSystemRole.Exists(modelSystemRole.F_ROLE_ID);

                if (isDataExist)
                {
                    //已经存在判断是否更新
                    DialogResult dialogResult = XtraMessageBox.Show("当前数据已存在，是否更新？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    //更新数据
                    bool status = _bllSystemRole.Update(modelSystemRole);

                    //获得当前rowhandle
                    var rowhandle = gvList.FocusedRowHandle;

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
                    _bllSystemRole.Add(modelSystemRole);


                    //获得当前rowhandle
                    var rowhandle = gvList.FocusedRowHandle;

                    //绑定数据
                    BindGridview();

                    //设置焦点行
                    gvList.FocusedRowHandle = rowhandle+1;

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
        /// 表格点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                if (gvList.FocusedRowHandle < 0 || gvList.FocusedRowHandle >= gvList.RowCount)
                {
                    txtF_ROLE_ID.Text = "";
                    txtF_ROLE_NAME.Text = "";
                    txtF_DESC.Text = "";

                    return;
                }

                //将当前数据显示在界面上
                txtF_ROLE_ID.Text = gvList.GetRowCellValue(gvList.FocusedRowHandle, "F_ROLE_ID").ToString();
                txtF_ROLE_NAME.Text = gvList.GetRowCellValue(gvList.FocusedRowHandle, "F_ROLE_NAME").ToString();
                txtF_DESC.Text = gvList.GetRowCellValue(gvList.FocusedRowHandle, "F_DESC").ToString();

               

            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 删除分
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click_1(object sender, EventArgs e)
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

               
                bool status = _bllSystemRole.Drop(txtF_ROLE_ID.Text);

                
                if (status)
                {
                    XtraMessageBox.Show("此数据已删除。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BindGridview();

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

        #endregion


    }
}