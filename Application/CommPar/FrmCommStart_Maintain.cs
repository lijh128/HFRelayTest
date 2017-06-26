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
using RelayTest.Model;

namespace RelayTest.Application.Settings
{
    public partial class FrmCommStart_Maintain : DevExpress.XtraEditors.XtraForm
    {
        #region 声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmCommStart_Maintain));

        //操作类
        private ProxyBllPAR_COMMAND_WORKTYPE _bllCommandWorkTypeProgramm = new ProxyBllPAR_COMMAND_WORKTYPE();

        //操作类
        private ProxyBllPAR_COMMAND_SENDP _bllCommandStartPar = new ProxyBllPAR_COMMAND_SENDP();

        //数据集
        private DataSet _dsCommandWorkType = new DataSet();

        //开始命令参数
        private DataTable _StartParTable = new DataTable("StartParTable");

        //选定的参数信息
        private List<ModelPAR_COMMAND_SENDP> _AddmodelCommandStartPar;

        #endregion
        public FrmCommStart_Maintain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCommandStartPar_Maintain_Load(object sender, EventArgs e)
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                InitStartParTable(_StartParTable);
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
        /// 初始化开始命令试验参数选择表
        /// </summary>
        /// <param name="table">初始化DataTable表</param>
        private void InitStartParTable(DataTable table)
        {

            for (int i = 0; i < gvStartPar.Columns.Count; i++)
            {
                if (gvStartPar.Columns[i].FieldName != "parSelect")
                {
                    table.Columns.Add(gvStartPar.Columns[i].FieldName, typeof(string));
                }
            }

            table.Columns.Add("parSelect", typeof(bool)); 
            //行号
            table.Columns.Add("colId", typeof(string));
            //发送命令参数id
            table.Columns.Add("F_SENDCOMMAND_PAR_ID", typeof(string));
            //发送命令的发送顺序
            table.Columns.Add("F_ORDER", typeof(string));

        }

        /// <summary>
        /// 清除DataTable对象中已有的数据
        /// </summary>
        /// <returns></returns>
        /// <param name="DataTable">删除内容的DataTable表</param>
        private void RemoveALLRow(DataTable detailTable)
        {
            for (int i = detailTable.Rows.Count - 1; i >= 0; i--)
            {
                detailTable.Rows[i].Delete();
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

        private void gvList_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                if (gvList.FocusedRowHandle < 0)
                    return;

                RemoveALLRow(_StartParTable);


                string tempId = "";
                string tempWorktypeName = "";
                string tempProgrammCode = "";

                tempId = gvList.GetFocusedRowCellValue("F_ID").ToString();
                tempWorktypeName = gvList.GetFocusedRowCellValue("F_WORKTYPE_NAME").ToString();
                tempProgrammCode = gvList.GetFocusedRowCellValue("F_PROGRAMM_CODE").ToString();

                string QueryCon = "";
                QueryCon = " F_WORKTYPE_NAME='" + tempWorktypeName + "' and F_PROGRAMM_CODE='" + tempProgrammCode + "' ";

                //填充开始命令可选及已设定的参数信息
                ProxyBllPAR_COMMAND_SENDP bllCommandStartPar = new ProxyBllPAR_COMMAND_SENDP();

                _StartParTable = bllCommandStartPar.GetAndDisplayStartPar(_StartParTable, QueryCon);

                gcStartPar.DataSource = _StartParTable;

                gvStartPar.BestFitColumns();

            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ProxyBllPAR_COMMAND_SENDP bllCommSENDP = new ProxyBllPAR_COMMAND_SENDP();
            
            
            string tempWorktypeName="";
            tempWorktypeName = gvList.GetFocusedRowCellValue("F_WORKTYPE_NAME").ToString();
            string tempWorktypeCode = "";
            tempWorktypeCode = gvList.GetFocusedRowCellValue("F_WORKTYPE_CODE").ToString();
            string tempProgrammCode="";
            tempProgrammCode=gvList.GetFocusedRowCellValue("F_PROGRAMM_CODE").ToString();


            //删除选择命令程序的已有参数
            bllCommSENDP.Delete_by_WorkType(tempWorktypeName, tempProgrammCode);

            for (int i = 0; i < _StartParTable.Rows.Count; i++)
            {
                if ((bool)_StartParTable.Rows[i]["parSelect"])
                {
                    var modelCommandStartPar = new ModelPAR_COMMAND_SENDP();
                    modelCommandStartPar.F_WORKTYPE_NAME = tempWorktypeName;
                    modelCommandStartPar.F_WORKTYPE_CODE = tempWorktypeCode;
                    modelCommandStartPar.F_PROGRAMM_CODE =tempProgrammCode;
                    modelCommandStartPar.F_SENDCOMMAND_PAR_ID = Convert.ToInt16(_StartParTable.Rows[i]["F_SENDCOMMAND_PAR_ID"].ToString());
                    modelCommandStartPar.F_SENDPAR_NAME = _StartParTable.Rows[i]["F_SENDPAR_NAME"].ToString();
                    modelCommandStartPar.F_ORDER = Convert.ToInt16(_StartParTable.Rows[i]["F_ORDER"].ToString());

                    modelCommandStartPar.F_WORKTYPE_MEMO = "";

                    modelCommandStartPar.F_CREATE_TIME = DateTime.Now;
                    modelCommandStartPar.F_OPERATOR_ID = AppGlobal.GUserId;
                    modelCommandStartPar.F_OPERATIONTIME = DateTime.Now;
                    modelCommandStartPar.F_DEL = 0;

                    bllCommSENDP.Add(modelCommandStartPar);
                }

            }
            MessageBox.Show("试验开始命令参数保存完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _StartParTable.Rows.Count; i++)
            {
                _StartParTable.Rows[i]["parSelect"] = true;
            }
        }

        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _StartParTable.Rows.Count; i++)
            {
                _StartParTable.Rows[i]["parSelect"] = false;
            }
        }

    }
}