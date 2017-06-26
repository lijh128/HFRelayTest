using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using log4net;
using RelayTest.Application.Settings;
using RelayTest.Application.Sys;

namespace RelayTest.Application.CommPar
{
    public partial class FrmCommStart : DevExpress.XtraEditors.XtraForm
    {
        #region 声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmCommStart));

        //操作类
        private ProxyBllPAR_COMMAND_WORKTYPE _bllCommandWorkTypeProgramm = new ProxyBllPAR_COMMAND_WORKTYPE();

        //操作类
        private ProxyBllPAR_COMMAND_SENDP _bllCommandStartPar = new ProxyBllPAR_COMMAND_SENDP();

        //数据集
        private DataSet _dsCommandWorkType = new DataSet();

        private DataSet _dsCommandStartPar = new DataSet();

        

        #endregion
        public FrmCommStart()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体载入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCommandStartPar_Load(object sender, EventArgs e)
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //get data from database
                BindGridview();

            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
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
                _dsCommandWorkType = _bllCommandWorkTypeProgramm.GetAllList();

                //有数据情况下绑定
                if (_dsCommandWorkType != null && _dsCommandWorkType.Tables.Count > 0)
                {
                    gcList.DataSource = _dsCommandWorkType.Tables[0];
                }
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gvList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                if (gvList.FocusedRowHandle < 0)
                    return;

                string tempId = "";
                string tempWorktypeName = "";
                string tempProgrammCode = "";

                tempId = gvList.GetFocusedRowCellValue("F_ID").ToString();
                tempWorktypeName = gvList.GetFocusedRowCellValue("F_WORKTYPE_NAME").ToString();
                tempProgrammCode = gvList.GetFocusedRowCellValue("F_PROGRAMM_CODE").ToString();

                string QueryCon = "";
                QueryCon = " F_WORKTYPE_NAME='" + tempWorktypeName + "' and F_PROGRAMM_CODE='" + tempProgrammCode + "' ";
                //绑定数据
                _dsCommandStartPar = _bllCommandStartPar.GetList(QueryCon);

                //有数据情况下绑定
                if (_dsCommandStartPar != null && _dsCommandStartPar.Tables.Count > 0)
                {
                    gcStartPar.DataSource = _dsCommandStartPar.Tables[0];
                }

            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FrmCommStart_Maintain frm = new FrmCommStart_Maintain();
            BindClickEventToAllBuutonControl(frm);
            frm.ShowDialog();
        }
        public void BindClickEventToAllBuutonControl(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is SimpleButton)
                {
                    ((SimpleButton)control).Click += FormButtonClick;
                }

                if (control.Controls.Count > 0)
                {
                    BindClickEventToAllBuutonControl(control);
                }

            }
        }
       
        /// <summary>
        /// bind to every menuitem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormButtonClick(object sender,
                                  EventArgs e)
        {
            if (sender is SimpleButton)
            {
                Form findForm = (sender as SimpleButton).FindForm();
                if (findForm != null)
                {
                    string modelName = findForm.Text;

                    modelName += "->" + (sender as SimpleButton).Text;
                    ApplicationCommon.WriteApplicationLogs(modelName);
                }
            }
        }
    }
}