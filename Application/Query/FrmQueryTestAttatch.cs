using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using log4net;
using System.IO;

namespace RelayTest.Application.Query
{
    public partial class FrmQueryTestAttatch : DevExpress.XtraEditors.XtraForm
    {
        public string now_taskID = "";

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmQueryTaskInfo));

        public FrmQueryTestAttatch()
        {
            InitializeComponent();
        }

        private void FrmQueryTestAttatch_Load(object sender, EventArgs e)
        {
            lbl_testCode.Text = "任务编号:" + now_taskID;
            lst_attatch.Items.Clear();

            //查询选择任务编号是否存在附件信息
            ProxyBllTEST_PREPARE_ATTATCH blltest_attatch = new ProxyBllTEST_PREPARE_ATTATCH();
            DataSet _dsCommandInfo = new DataSet();
            try
            {
                //绑定数据
                _dsCommandInfo = blltest_attatch.GetList(" F_TEST_TASK_ID='" + now_taskID + "' ");

                if (_dsCommandInfo != null && _dsCommandInfo.Tables.Count > 0)
                {
                    for (int i = 0; i < _dsCommandInfo.Tables[0].Rows.Count; i++)
                    {
                        lst_attatch.Items.Add(_dsCommandInfo.Tables[0].Rows[i]["F_ATTATCHNAME"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        private void btn_Query_attatchment_Click(object sender, EventArgs e)
        {
            //首先判断选择的文件名
            if (lst_attatch.SelectedIndex < 0)
            {
                MessageBox.Show("请选择需要执行导出文件操作的文件名！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                //导出文件时的选择路径
                string exportSelectPath = "";
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (!exportSelectPath.Equals(""))
                    fbd.SelectedPath = exportSelectPath;
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string retMsg = ReadFromDB(now_taskID, lst_attatch.SelectedItem.ToString(), fbd.SelectedPath);
                    MessageBox.Show(retMsg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        public string ReadFromDB(String TaskId, String filename, String SavePath)
        {
            BLL.BllTEST_PREPARE_ATTATCH bllPrepareAttatch = new BLL.BllTEST_PREPARE_ATTATCH();
            string strWhere = "F_TEST_TASK_ID='" + TaskId + "' and F_ATTATCHNAME='" + filename + "'";
            DataSet dsTaskId = bllPrepareAttatch.GetList(strWhere);

            if (dsTaskId == null || dsTaskId.Tables[0].Rows.Count == 0)
            {

                return "文件不存在";
            }
            else
            {
                byte[] byteArray = (Byte[])dsTaskId.Tables[0].Rows[0]["F_ATTATCHMENT"];
                string strfn = SavePath + "\\" + filename;
                using (FileStream fs = new FileStream
                        (strfn, FileMode.CreateNew, FileAccess.Write))
                {
                    fs.Write(byteArray, 0, byteArray.Length);
                }
                return "读取文件保存到本地文件夹完成";
            }

        }
    }


}