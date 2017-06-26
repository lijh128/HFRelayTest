using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using log4net;
using RelayTest.Model;

namespace RelayTest.Application.Sys
{
    public partial class FrmUser : DevExpress.XtraEditors.XtraForm
    {

        #region 成员声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmUser));

       

        //操作类
        private ProxyBllSYSTEM_USER _bllSystemUser = new ProxyBllSYSTEM_USER();


        /// <summary>
        /// 会员信息浏览数据集
        /// </summary>
        private DataSet _dsUsers;

        #endregion

        #region 事件方法

        public FrmUser()
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                InitializeComponent();

            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
           

        }



        /// <summary>
        /// 更新数据
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
                ModelSYSTEM_USER modelSystemUser = PrepareModelSystemUser();


                //判断此数据是否已经存在
                bool isDataExist = _bllSystemUser.Exists(modelSystemUser.F_USER_ID);

                if (isDataExist)
                {
                    //已经存在判断是否更新
                    DialogResult dialogResult = XtraMessageBox.Show("当前数据已存在，是否更新？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    
                    //更新数据
                    bool status = _bllSystemUser.Update(modelSystemUser);

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
                    _bllSystemUser.Add(modelSystemUser);


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
        /// 删除数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
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
                ModelSYSTEM_USER modelSystemUser = PrepareModelSystemUser();
                //更新数据
                bool status = _bllSystemUser.Delete(modelSystemUser.F_USER_ID);

               
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
        /// 将已删除的用户恢复
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //检查必填字段
                bool isAllOk = CheckNotNullField();

                if (!isAllOk)
                    return;

                //准备要存储的数据
                ModelSYSTEM_USER modelSystemUser = PrepareModelSystemUser();
                //更新数据
                bool status = _bllSystemUser.Enabled(modelSystemUser.F_USER_ID);

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
                    return;
                }

                //将当前数据显示在界面上
                txtF_USER_ID.Text = gvList.GetRowCellValue(gvList.FocusedRowHandle, "F_USER_ID").ToString();
                txtF_USER_NAME.Text = gvList.GetRowCellValue(gvList.FocusedRowHandle, "F_USER_NAME").ToString();
                txtF_PHONE.Text = gvList.GetRowCellValue(gvList.FocusedRowHandle, "F_PHONE").ToString();

                string password = "";
                password = gvList.GetRowCellValue(gvList.FocusedRowHandle, "F_PASSWORD").ToString();

                txtF_PASSWORD.Text = RelayTest.Util.DBUtility.DESEncrypt.Decrypt(password);

                txtRepeatPassword.Text = txtF_PASSWORD.Text;

                //是否是上位机用户
                decimal isSwj;
                decimal.TryParse(gvList.GetRowCellValue(gvList.FocusedRowHandle, "F_ISSWJ").ToString(), out isSwj);
                chkF_ISSWJ.EditValue = isSwj;

            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 载入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUser_Load(object sender, EventArgs e)
        {
            try
            {

                InitAllControl();

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

        #endregion

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
            _dsUsers = _bllSystemUser.GetAllList();

            //绑定数据
            if (_dsUsers != null && _dsUsers.Tables.Count > 0)
            {
                gcList.DataSource = _dsUsers.Tables[0];
            }
        }

        /// <summary>
        /// 准备数据
        /// </summary>
        /// <returns></returns>
        private ModelSYSTEM_USER PrepareModelSystemUser()
        {

            //创建操作类
            ModelSYSTEM_USER model = new ModelSYSTEM_USER();

            //登录名
            model.F_USER_ID = txtF_USER_ID.Text;

            //名称
            model.F_USER_NAME = txtF_USER_NAME.Text;

            //电话 
            model.F_PHONE = txtF_PHONE.Text;

            //密码
            model.F_PASSWORD = Util.DBUtility.DESEncrypt.Encrypt(txtF_PASSWORD.Text);

            //是否是上位机用户
            model.F_ISSWJ = (decimal) chkF_ISSWJ.EditValue;

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
//判断必须输入项
            if (string.IsNullOrEmpty(txtF_USER_ID.Text))
            {
                XtraMessageBox.Show("请输入代码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //判断必须输入项
            if (string.IsNullOrEmpty(txtF_USER_NAME.Text))
            {
                XtraMessageBox.Show("请输入姓名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //判断密码
            if (string.IsNullOrEmpty(txtF_PASSWORD.Text) || string.IsNullOrEmpty(txtRepeatPassword.Text))
            {
                XtraMessageBox.Show("请输入密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (txtF_PASSWORD.Text != txtRepeatPassword.Text)
            {
                XtraMessageBox.Show("两次输入的密码必须一致！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        #endregion
    }
}