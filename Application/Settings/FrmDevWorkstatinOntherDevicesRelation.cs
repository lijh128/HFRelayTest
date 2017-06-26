using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.Refactor.Core;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraPrinting;
using log4net;
using RelayTest.Model;
using RelayTest.Util.Common;

namespace RelayTest.Application.Settings
{
    
    /// <summary>
    /// 上位机与其他设备关系显示
    /// </summary>
    public partial class FrmDevWorkstatinOntherDevicesRelation : BaseXtraForm
    {
        #region 声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmDevPowerBaseInfo));


        //操作类
        private ProxyBllDEV_WORKSTATION_INFO _bllDevWorkstationInfo = new ProxyBllDEV_WORKSTATION_INFO();
       
        //数据集
        private DataSet _dsWorkstationInfo = new DataSet();

        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmDevWorkstatinOntherDevicesRelation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体载入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmWorkstatinAntherDevicesRelation_Load(object sender, EventArgs e)
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                InitAllControls();
                //get data from database
                BindGridview();

            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }


        #region 自定义方法

        /// <summary>
        ///     初始化界面上的控件
        /// </summary>
        private void InitAllControls()
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                FillAllSelectedControls();
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        private void FillAllSelectedControls()
        {

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
                _dsWorkstationInfo = _bllDevWorkstationInfo.GetAllList();

                //有数据情况下绑定
                if (_dsWorkstationInfo != null && _dsWorkstationInfo.Tables.Count > 0)
                {
                    gcWorkStation.DataSource = _dsWorkstationInfo.Tables[0];
                }
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }


        
      

       

        #endregion

        /// <summary>
        /// 关闭按钮事件
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
                        gvWorkstation.OptionsPrint.UsePrintStyles = true;
                        gcWorkStation.ExportToXls(fileName, __options);
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


        /// <summary>
        /// Add new item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
    
        }


        /// <summary>
        /// 设置负载电流上下限，电压上下限，负载可用状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtValue_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            (new FrmDevLoadChannelInfo()).ShowDialog();
        }


        /// <summary>
        /// 更新信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }


        /// <summary>
        /// 启动其中的一条记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnabled_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

               
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }


        /// <summary>
        /// 禁用其中的一条记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisabled_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }



        /// <summary>
        /// 彻底删除一条记录，一旦删除无法恢复，建议不要使用此功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }


        private void gvList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                if (gvWorkstation.FocusedRowHandle < 0)
                    return;


                //获得工作站id
                string workstationId = gvWorkstation.GetFocusedRowCellValue("F_WORKSTATION_ID").ToString();

                //上位机与供电柜关系绑定数据
                gcPower.DataSource= _bllDevWorkstationInfo.GetPowersRelatedToWorkstation(workstationId).Tables[0];

                gvPower.ActiveFilterString = "F_CHECK = 1";

               

                //上位机与下位机绑定数据
                gcSubordinate.DataSource = _bllDevWorkstationInfo.GetSubordinatesRelatedToWorkstation(workstationId).Tables[0];

                gvSubordinate.ActiveFilterString = "F_CHECK = 1";


                //上位机与线圈电源绑定数据
                gcCoilPower.DataSource = _bllDevWorkstationInfo.GetCoilPowersRelatedToWorkstation(workstationId).Tables[0];

                gvCoilPower.ActiveFilterString = "F_CHECK = 1";


                //上位机与传感器绑定数据
                gcSensor.DataSource = _bllDevWorkstationInfo.GetSensorsRelatedToWorkstation(workstationId).Tables[0];

                gvSensor.ActiveFilterString = "F_CHECK = 1";


            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        private void xtraScrollableControl1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 编辑关系
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditRelation_Click(object sender, EventArgs e)
        {
            (new FrmDevWorkstatinOntherDevicesRelationEdit()).ShowDialog();
            gvList_RowClick(this, null);
        }

      
    
    }
}