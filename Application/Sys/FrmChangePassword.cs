using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using log4net;
using RelayTest.Model;

namespace RelayTest.Application.Sys
{
    public partial class FrmChangePassword : DevExpress.XtraEditors.XtraForm
    {

        #region 成员声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmChangePassword));

        //操作类
        private ProxyBllSYSTEM_USER _bllSystemUser = new ProxyBllSYSTEM_USER();

      
        #endregion
        public FrmChangePassword()
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                InitializeComponent();

                //初始化界面
                InitAllControl();
            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
           

        }


        /// <summary>
        /// 初始化界面
        /// </summary>
        private void InitAllControl()
        {
           

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
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //判断必须输入项
                if (string.IsNullOrEmpty(txtOriginalPass.Text))
                {
                    XtraMessageBox.Show("请输入代码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }

                //判断密码
                if (string.IsNullOrEmpty(txtPasswrod.Text) || string.IsNullOrEmpty(txtRepeatPassword.Text))
                {
                    XtraMessageBox.Show("请输入新密码并重复！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }

                if (txtPasswrod.Text != txtRepeatPassword.Text)
                {
                    XtraMessageBox.Show("两次输入的密码必须一致！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                //get original user info
                ModelSYSTEM_USER originalmodelXtuser = _bllSystemUser.GetModel(AppGlobal.GUserId);


                if (txtOriginalPass.Text != Util.DBUtility.DESEncrypt.Decrypt(originalmodelXtuser.F_PASSWORD))
                {
                    XtraMessageBox.Show("原密码输入错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //创建操作类
                ModelSYSTEM_USER model = new ModelSYSTEM_USER();

                //登录名
                model.F_USER_ID = AppGlobal.GUserId;

                //密码
                model.F_PASSWORD = Util.DBUtility.DESEncrypt.Encrypt(txtPasswrod.Text);

                //创建时间
                DateTime optDateTime = DateTime.Now;

                //操作员
                model.F_OPERATOR_ID = AppGlobal.GUserId;


                //操作时间
                model.F_OPERATIONTIME = optDateTime;

              

                //是否删除
                model.F_DEL = 0;

                //判断是否已经有此数据
                if (_bllSystemUser.Exists(model.F_USER_ID))
                {
                    //保存数据
                    _bllSystemUser.ChagePassword(model);

                    //提示信息
                    XtraMessageBox.Show("用户数据已更新！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("此用户不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// before form close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dialogResult = XtraMessageBox.Show("是否关闭此界面？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}