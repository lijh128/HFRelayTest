using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using log4net;
using DevExpress.XtraPrinting;

namespace RelayTest.Application.Query
{
    public partial class FrmQueryTaskInfo : DevExpress.XtraEditors.XtraForm
    {
        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmQueryTaskInfo));

        public FrmQueryTaskInfo()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (!detBegintime1.Text.Trim().Equals("") && !detBegintime2.Text.Trim().Equals(""))
            {
                if (detBegintime1.Text.CompareTo(detBegintime2.Text) > 0)
                {
                    MessageBox.Show("查询条件中开始时间结束日期不能大于起始日期!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (!txtFZDY1.Text.Trim().Equals("") && !txtFZDY2.Text.Trim().Equals(""))
            {
                if(Convert.ToInt16(txtFZDY1.Text.Trim())>Convert.ToInt16(txtFZDY2.Text.Trim()))
                {
                    MessageBox.Show("查询条件负载电压范围中后值不能大于前值!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (!txtFZDL1.Text.Trim().Equals("") && !txtFZDL2.Text.Trim().Equals(""))
            {
                if(Convert.ToInt16(txtFZDL1.Text.Trim())>Convert.ToInt16(txtFZDL2.Text.Trim()))
                {
                    MessageBox.Show("查询条件负载电流范围中后值不能大于前值!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            //根据界面内容生成查询条件
            string query_con = "";
            query_con=getQueryCon();
           
            ProxyBllTEST_INFO blltest_Info = new ProxyBllTEST_INFO();
            DataSet _dsCommandInfo = new DataSet();
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //绑定数据
                _dsCommandInfo = blltest_Info.GetTestTaskInfoByQueryCondition(query_con);

                //有数据情况下绑定
                if (_dsCommandInfo != null && _dsCommandInfo.Tables.Count > 0)
                {
                    gcList.DataSource = _dsCommandInfo.Tables[0];
                }

                if (gvList.RowCount > 0)
                {
                    btnExport.Enabled = true;
                }
                else
                {
                    btnExport.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
            
        }

        private string getQueryCon()
        {
            string query_con="";

            //试验任务编号条件不为空
            if (!txtTaskID.Text.Trim().Equals(""))
            {
                query_con = " F_TEST_TASK_ID LIKE '%" + txtTaskID.Text.Trim() + "%'";
                
                if (!comRunStatus.SelectedItem.ToString().Equals("全部"))
                {
                    query_con=query_con+ "and TEST_STATUS='"+comRunStatus.SelectedItem.ToString()+"'";
                }
                return query_con;
            }
            
            //开始时间起始时间不为空
            if (!detBegintime1.Text.Equals(""))
            {
                //开始时间结束时间不为空
                if (!detBegintime2.Text.Equals(""))
                {

                    query_con = " substr(BEGINTIME,1,10)>='" + detBegintime1.Text + "'";
                    query_con = query_con + " and substr(BEGINTIME,1,10)<='" + detBegintime2.Text + "'";
                }
                else
                {
                    query_con = " substr(BEGINTIME,1,10)>='" + detBegintime1.Text + "'";
                }
                if (!comRunStatus.SelectedItem.ToString().Equals("全部"))
                {
                    query_con = query_con + "and TEST_STATUS='" + comRunStatus.SelectedItem.ToString() + "'";
                }
                return query_con;
            }
            else 
            {
                if (!detBegintime2.Text.Equals(""))
                {
                    query_con = " substr(BEGINTIME,1,10)<='" + detBegintime2.Text + "'";
                    if (!comRunStatus.SelectedItem.ToString().Equals("全部"))
                    {
                        query_con=query_con+ "and TEST_STATUS='"+comRunStatus.SelectedItem.ToString()+"'";
                    }
                    return query_con;
                }   
            }
            //判断负载电压查询条件
            if (!txtFZDY1.Text.Trim().Equals(""))
            {
                if (!txtFZDY2.Text.Trim().Equals(""))
                {
                    query_con = " FZDY>=" + txtFZDY1.Text.Trim() + " AND FZDY<=" + txtFZDY2.Text.Trim();
                }
                else
                {
                    query_con = " FZDY>=" + txtFZDY1.Text.Trim();
                }
                if (!comRunStatus.SelectedItem.ToString().Equals("全部"))
                {
                    query_con = query_con + "and TEST_STATUS='" + comRunStatus.SelectedItem.ToString() + "'";
                }
                return query_con;
            }
            else
            {
                if (!txtFZDY2.Text.Trim().Equals(""))
                {
                    query_con = " FZDY<=" + txtFZDY2.Text.Trim();
                    if (!comRunStatus.SelectedItem.ToString().Equals("全部"))
                    {
                        query_con = query_con + "and TEST_STATUS='" + comRunStatus.SelectedItem.ToString() + "'";
                    }
                    return query_con;
                }
            }

            //判断负载电流查询条件
            if (!txtFZDL1.Text.Trim().Equals(""))
            {
                if (!txtFZDY2.Text.Trim().Equals(""))
                {
                    query_con = " ( NOWTDL>=" + txtFZDL1.Text.Trim() + " AND NOWTDL<=" + txtFZDL2.Text.Trim();
                    query_con = query_con+" OR NCWTDL>=" + txtFZDL1.Text.Trim() + " AND NCWTDL<=" + txtFZDL2.Text.Trim() + ")";
                }
                else
                {
                    query_con = "  ( NOWTDL>=" + txtFZDL1.Text.Trim();
                    query_con =query_con+ " OR  NCWTDL>=" + txtFZDL1.Text.Trim()+")";
                }
                if (!comRunStatus.SelectedItem.ToString().Equals("全部"))
                {
                    query_con = query_con + "and TEST_STATUS='" + comRunStatus.SelectedItem.ToString() + "'";
                }
                return query_con;
            }
            else
            {
                if (!txtFZDL2.Text.Trim().Equals(""))
                {
                    query_con = " ( NOWTDL<=" + txtFZDL2.Text.Trim();
                    query_con =query_con+ " OR NCWTDL<=" + txtFZDL2.Text.Trim()+" )";
                    if (!comRunStatus.SelectedItem.ToString().Equals("全部"))
                    {
                        query_con = query_con + "and TEST_STATUS='" + comRunStatus.SelectedItem.ToString() + "'";
                    }
                    return query_con;
                }
            }

            if (!comRunStatus.SelectedItem.ToString().Equals("全部"))
            {
                query_con = " 1=1 and TEST_STATUS='" + comRunStatus.SelectedItem.ToString() + "'";
            }
            else
            {
                query_con = " 1=1 ";
            }
            return query_con;
        }

        private void FrmQueryTaskInfo_Load(object sender, EventArgs e)
        {
            comRunStatus.SelectedIndex = 0;

            btn_Query_attatchment.Enabled = false;
            btnExport.Enabled = false;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (gvList.RowCount > 0)
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
            else
            {
                MessageBox.Show("没有可导出的数据！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gvList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gvList.FocusedRowHandle < 0)
            {
                MessageBox.Show("请在试验任务列表中选择试验任务！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                String now_taskid = "";
                //试验任务编号
                now_taskid = gvList.GetFocusedRowCellValue("F_TEST_TASK_ID").ToString();
                
                //查询选择任务编号是否存在附件信息
                ProxyBllTEST_PREPARE_ATTATCH blltest_attatch=new ProxyBllTEST_PREPARE_ATTATCH();                
                DataSet _dsCommandInfo = new DataSet();
                try
                {
                    //绑定数据
                    _dsCommandInfo = blltest_attatch.GetList(" F_TEST_TASK_ID='" + now_taskid + "' ");
                    
                    if (_dsCommandInfo != null && _dsCommandInfo.Tables.Count > 0)
                    {
                        if (_dsCommandInfo.Tables[0].Rows.Count>0)
                            btn_Query_attatchment.Enabled = true;
                        else
                            btn_Query_attatchment.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                    throw ex;
                }
            }

        }

        private void btn_Query_attatchment_Click(object sender, EventArgs e)
        {
            FrmQueryTestAttatch frm = new FrmQueryTestAttatch();
            BindClickEventToAllBuutonControl(frm);
            frm.now_taskID = gvList.GetFocusedRowCellValue("F_TEST_TASK_ID").ToString();
            frm.ShowDialog();
        }

        /// <summary>
        /// 绑定按钮点击事件
        /// </summary>
        /// <param name="parent"></param>
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