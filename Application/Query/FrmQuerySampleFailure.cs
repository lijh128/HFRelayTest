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
    public partial class FrmQuerySampleFailure : DevExpress.XtraEditors.XtraForm
    {
        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmQueryTaskInfo));

        public FrmQuerySampleFailure()
        {
            InitializeComponent();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (!detCreatetime1.Text.Trim().Equals("") && !detCreatetime2.Text.Trim().Equals(""))
            {
                if (detCreatetime1.Text.CompareTo(detCreatetime2.Text) > 0)
                {
                    MessageBox.Show("查询条件中发生时间结束日期不能大于起始日期!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
            //根据界面内容生成查询条件
            string query_con = "";
            query_con = getQueryCon();

            ProxyBllTEST_SAMPLE_FAILURE blltestSampleFailure = new ProxyBllTEST_SAMPLE_FAILURE();
            DataSet _dsCommandInfo = new DataSet();
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //绑定数据
                _dsCommandInfo = blltestSampleFailure.GetTestSampleFailureInfoByQueryCondition(query_con);

                //有数据情况下绑定
                if (_dsCommandInfo != null && _dsCommandInfo.Tables.Count > 0)
                {
                    gcList.DataSource = _dsCommandInfo.Tables[0];
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
            string query_con = "";

            //试验任务编号条件不为空
            if (!txtTaskID.Text.Trim().Equals(""))
            {
                query_con = " F_TEST_TASK_ID LIKE '%" + txtTaskID.Text.Trim() + "%'";
                return query_con;
            }

            //开始时间起始时间不为空
            if (!detCreatetime1.Text.Equals(""))
            {
                //开始时间结束时间不为空
                if (!detCreatetime2.Text.Equals(""))
                {

                    query_con = " substr(F_CREATE_TIME,1,10)>='" + detCreatetime1.Text + "'";
                    query_con = query_con + " and substr(F_CREATE_TIME,1,10)<='" + detCreatetime2.Text + "'";
                }
                else
                {
                    query_con = " substr(F_CREATE_TIME,1,10)>='" + detCreatetime1.Text + "'";
                }
                
                return query_con;
            }
            else
            {
                if (!detCreatetime2.Text.Equals(""))
                {
                    query_con = " substr(F_CREATE_TIME,1,10)<='" + detCreatetime2.Text + "'";                    
                    return query_con;
                }
            }
            return " 1=1 ";
        }
    }
}