using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using log4net;
using RelayTest.BLL;
using RelayTest.Model;

namespace RelayTest.Application.Sys
{
    public partial class FrmLogs : DevExpress.XtraEditors.XtraForm
    {

        #region 成员声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmLogs));


        private ProxyBllOPERATIONLOG _bllOperationlog = new ProxyBllOPERATIONLOG();
       
        /// <summary>
        /// 会员信息浏览数据集
        /// </summary>
        private DataSet _dsCardType;

        #endregion
        public FrmLogs()
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
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                FillAllSelectableControls();
            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }

        }


        /// <summary>
        /// 填充所有可选择控件内容
        /// </summary>
        private void FillAllSelectableControls()
        {

            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

              ApplicationCommon.FillLueUser(lueUserId);

            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

      
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            
            if (lueUserId.EditValue == null && String.IsNullOrEmpty(dteBegin.Text) && string.IsNullOrEmpty(dteEnd.Text))
            {
                XtraMessageBox.Show("不能所有条件均为空。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //设置条件
            string userId = "";
            if (lueUserId.EditValue != null)
            {
                userId = lueUserId.EditValue.ToString();
            }
            string beginDateTime = "";
            if (!string.IsNullOrEmpty(dteBegin.Text))
            {
                beginDateTime = dteBegin.DateTime.ToString("yyyy-MM-dd");
            }

            string endDateTime = "";
            if (!string.IsNullOrEmpty(dteEnd.Text))
            {
                endDateTime = dteEnd.DateTime.ToString("yyyy-MM-dd");
            }
            //查询
            DataSet dsoperationlog = _bllOperationlog.GetLoginfo(new GetLoginfoParams(userId,beginDateTime,endDateTime));

            //有数据情况下绑定
            if (dsoperationlog != null && dsoperationlog.Tables.Count > 0)
            {
                gcList.DataSource = dsoperationlog.Tables[0];
            }
        }
    }
}