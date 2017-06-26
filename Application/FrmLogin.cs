using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RelayTest.Application
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        private int login_failure_count=0;

        public FrmLogin()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            AppGlobal.GUserId = "未登录";
            AppGlobal.GUserName = "未登录";
            AppGlobal.GLoginName = "未登录";
            Close();
        }

        private void btnLoing_Click(object sender, EventArgs e)
        {
            string userid = "";
            string password = "";

            if (txtUserid.Text.Trim().Equals(""))
            {
                MessageBox.Show("请输入登录用户名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserid.Focus();
                return;
            }             
            else if(txtPassword.Text.Trim().Equals(""))
            {
                MessageBox.Show("请输入登录用户密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
                return;
            }

            userid=txtUserid.Text.Trim();
            password=txtPassword.Text.Trim();
            password = RelayTest.Util.DBUtility.DESEncrypt.Encrypt(txtPassword.Text.Trim());

            ProxyBllSYSTEM_USER bllSystemUser=new ProxyBllSYSTEM_USER();
            DataSet dsUser=bllSystemUser.GetList(" F_USER_ID='"+userid+"' AND F_PASSWORD='"+password+"'");
            if (dsUser != null && dsUser.Tables[0].Rows.Count != 0)
            {
                AppGlobal.GUserId = userid;
                AppGlobal.GUserName = dsUser.Tables[0].Rows[0]["F_USER_NAME"].ToString();                
                Close() ;
            }
            else
            {
                login_failure_count=login_failure_count+1;
                if (login_failure_count < 3)
                {
                    MessageBox.Show("输入的用户名或密码不正确，请重新输入!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("输入的用户名或密码不正确，错误次数已达到3次，登录错误!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AppGlobal.GUserId = "未登录";
                    AppGlobal.GUserName="未登录";
                    AppGlobal.GLoginName = "未登录";
                    Close();
                }
            }
        }
    }
}