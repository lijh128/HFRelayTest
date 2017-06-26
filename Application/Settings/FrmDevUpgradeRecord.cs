using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using log4net;
using RelayTest.Model;
using RelayTest.Util.Common;

namespace RelayTest.Application.Settings
{
    
    /// <summary>
    /// 设备更新历史
    /// </summary>
    public partial class FrmDevUpgradeRecord : BaseXtraForm
    {
        #region 声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmDevUpgradeRecord));


        //
        private ProxyBllDEV_UPGRADERECORD _bllDevUpgraderecord = new ProxyBllDEV_UPGRADERECORD();

        //数据集
        private DataSet _dsSubordinateHis = new DataSet();

    
       
        #endregion

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

                BindGridview();
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        ///     绑定所有列表信息
        /// </summary>
        private void FillAllSelectedControls()
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //绑定设备类型
                ApplicationCommon.GetLookUpEditControl(lueF_DEV_TYPE, "T_SYSTEM_LIST", "F_VALUE", "编码", "F_DISPLAY", "设备类型", "F_TYPE='F_DEV_TYPE' ");

             //设备类型
                colF_DEV_TYPE.ColumnEdit = ApplicationCommon.GetRepositoryItemLookUpEditControl("T_SYSTEM_LIST", "F_VALUE", "F_DISPLAY", "F_TYPE='F_DEV_TYPE'");

 
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
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
                _dsSubordinateHis = _bllDevUpgraderecord.GetAllList();

                //有数据情况下绑定
                if (_dsSubordinateHis != null && _dsSubordinateHis.Tables.Count > 0)
                {
                    gcList.DataSource = _dsSubordinateHis.Tables[0];
                }
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }




        /// <summary>
        ///     检查必填段
        /// </summary>
        /// <returns></returns>
        private bool CheckNotNullField()
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                //编号
                if (string.IsNullOrEmpty(lueF_DEV_ID.EditValue.ToString()))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("编码不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //硬件版本
                if (string.IsNullOrEmpty(txtF_HARDWARE_VERSION.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("硬件版本不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }


                //软件版本
                if (string.IsNullOrEmpty(txtF_SOFTWARE_VERSION.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("软件版本不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //更新时间
                if (string.IsNullOrEmpty(dteF_UPDATE_DATE.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("更新时间不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                //启用时间
                if (string.IsNullOrEmpty(dteF_USED_DATE.Text))
                {
                    DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("启用时间不能为空。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }


        /// <summary>
        ///     准备要操作Model
        /// </summary>
        /// <returns></returns>
        private ModelDEV_UPGRADERECORD PrepareModelSubordinateHis()
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                ModelDEV_UPGRADERECORD modelDevUpgraderecord = new ModelDEV_UPGRADERECORD();


                //设备代码			
                modelDevUpgraderecord.F_DEV_TYPE = decimal.Parse(lueF_DEV_TYPE.EditValue.ToString());

                //设备编号
                modelDevUpgraderecord.F_DEV_ID = lueF_DEV_ID.EditValue.ToString();


                //设备名称
                modelDevUpgraderecord.F_DEV_NAME = lueF_DEV_ID.Text;

                //	硬件版本			
                modelDevUpgraderecord.F_HARDWARE_VERSION = txtF_HARDWARE_VERSION.Text;
                //	软件版本			
                modelDevUpgraderecord.F_SOFTWARE_VERSION = txtF_SOFTWARE_VERSION.Text;
                //	更新时间			
                modelDevUpgraderecord.F_UPDATE_DATE = dteF_UPDATE_DATE.DateTime;

                //	启用时间			
                modelDevUpgraderecord.F_USED_DATE = dteF_USED_DATE.DateTime;

                //	备注			
                modelDevUpgraderecord.F_MEMO= txtF_MEMO.Text;

                //创建时间		
                DateTime optDateTime = DateTime.Now;
                modelDevUpgraderecord.F_CREATE_TIME = optDateTime;

                //操作员		
                modelDevUpgraderecord.F_OPERATOR_ID = AppGlobal.GUserId;

                //操作时间		
                modelDevUpgraderecord.F_OPERATIONTIME = optDateTime;

                //是否删除		
                modelDevUpgraderecord.F_DEL = 0;

                return modelDevUpgraderecord;
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        #endregion

        #region 事件方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmDevUpgradeRecord()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmDevUpgradeRecord(string subordinateId):this()
        {
           
        }


        /// <summary>
        /// 窗体载入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPowerBaseInfo_Load(object sender, EventArgs e)
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




        /// <summary>
        /// 更新信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //检查必填字段
                bool isAllOk = CheckNotNullField();

                if (!isAllOk)
                    return;

                //准备要存储的数据
                ModelDEV_UPGRADERECORD modelDevUpgraderecord = PrepareModelSubordinateHis();


                //判断此数据是否已经存在
                bool isDataExist = _bllDevUpgraderecord.Exists(modelDevUpgraderecord.F_DEV_TYPE,modelDevUpgraderecord.F_DEV_ID, modelDevUpgraderecord.F_HARDWARE_VERSION, modelDevUpgraderecord.F_SOFTWARE_VERSION);

                if (isDataExist)
                {
                    //已经存在判断是否更新
                    DialogResult dialogResult = XtraMessageBox.Show("当前数据已存在，是否更新？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    //更新数据
                    bool status = _bllDevUpgraderecord.Update(modelDevUpgraderecord);

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
                    _bllDevUpgraderecord.Add(modelDevUpgraderecord);


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
        /// 彻底删除一条记录，一旦删除无法恢复，建议不要使用此功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                //删除前判断
                DialogResult dialogResult = DevExpress.DXCore.Controls.XtraEditors.XtraMessageBox.Show("此操作将永久删除数据并有可能导致其他关联数据出错，是否继续？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }

                //检查必填字段
                bool isAllOk = CheckNotNullField();

                if (!isAllOk)
                    return;

                //准备要存储的数据
                ModelDEV_UPGRADERECORD modelDevUpgraderecord = PrepareModelSubordinateHis();

                //更新数据
                bool status = _bllDevUpgraderecord.Drop(modelDevUpgraderecord.F_DEV_TYPE,modelDevUpgraderecord.F_DEV_ID, modelDevUpgraderecord.F_HARDWARE_VERSION, modelDevUpgraderecord.F_SOFTWARE_VERSION);

                if (status)
                {
                    XtraMessageBox.Show("此数据已删除。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("没有数据被更新，操作中断。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
               
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

   
        /// <summary>
        /// 上传附件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpload_Click(object sender, EventArgs e)
        {
            //检查是否有这条记录存在
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //检查必填字段
                bool isAllOk = CheckNotNullField();

                if (!isAllOk)
                    return;

                //准备要存储的数据
                ModelDEV_UPGRADERECORD modelDevUpgraderecord = PrepareModelSubordinateHis();


                //判断此数据是否已经存在
                bool isDataExist = _bllDevUpgraderecord.Exists(modelDevUpgraderecord.F_DEV_TYPE, modelDevUpgraderecord.F_DEV_ID, modelDevUpgraderecord.F_HARDWARE_VERSION, modelDevUpgraderecord.F_SOFTWARE_VERSION);

                if (!isDataExist)
                {
                    XtraMessageBox.Show("请先保存数据再上传附件。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //打开文件

                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Filter = "压缩文件 (*.zip)|*.zip";

                DialogResult dialogResult = openFileDialog.ShowDialog();
                if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }
                //打开文件
                string fileName = openFileDialog.FileName;

                //创建流
                FileStream fsUpload = File.OpenRead(fileName);

                //设定大小
                modelDevUpgraderecord.F_ATTATCHMENT = new byte[fsUpload.Length];

                //读出数据
                fsUpload.Read(modelDevUpgraderecord.F_ATTATCHMENT, 0, modelDevUpgraderecord.F_ATTATCHMENT.Length);

                fsUpload.Close();

                bool status = _bllDevUpgraderecord.Upload(modelDevUpgraderecord);


                if (status)
                {
                    XtraMessageBox.Show("附件已上传。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("没有数据被更新，操作中断。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

       
        /// <summary>
        /// 下载附件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDownload_Click(object sender, EventArgs e)
        {
            //检查是否有这条记录存在
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                if (!chkF_ATTATCHMENT.Checked)
                {
                    XtraMessageBox.Show("当前记录没有附件，执行中断。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //检查必填字段
                bool isAllOk = CheckNotNullField();

                if (!isAllOk)
                    return;

                //准备要存储的数据
                ModelDEV_UPGRADERECORD modelDevUpgraderecord = PrepareModelSubordinateHis();


                //判断此数据是否已经存在
                bool isDataExist = _bllDevUpgraderecord.Exists(modelDevUpgraderecord.F_DEV_TYPE, modelDevUpgraderecord.F_DEV_ID, modelDevUpgraderecord.F_HARDWARE_VERSION, modelDevUpgraderecord.F_SOFTWARE_VERSION);

                if (!isDataExist)
                {
                    XtraMessageBox.Show("没有此条数据。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Filter = "压缩文件 (*.zip)|*.zip";

                DialogResult dialogResult = saveFileDialog.ShowDialog();
                if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }
                //打开文件
                string fileName = saveFileDialog.FileName;

                //读取附件数据
                DataSet dsAttatch = _bllDevUpgraderecord.GetAttatch(modelDevUpgraderecord);


                if (dsAttatch != null && dsAttatch.Tables.Count > 0)
                {
                    byte[] objFileBuffer = (byte[])dsAttatch.Tables[0].Rows[0]["F_ATTATCHMENT"];
                    FileStream fs = new FileStream(fileName, FileMode.Create);

                    fs.Write(objFileBuffer, 0, objFileBuffer.Length);
                    fs.Flush();
                    fs.Close(); 
                }


                XtraMessageBox.Show("附件已下载。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 点击表格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                if (gvList.FocusedRowHandle < 0)
                    return;

                decimal devType = decimal.Parse(gvList.GetFocusedRowCellValue("F_DEV_TYPE").ToString());

                string devId = gvList.GetFocusedRowCellValue("F_DEV_ID").ToString();

                string hardVersion = gvList.GetFocusedRowCellValue("F_HARDWARE_VERSION").ToString();
                string softVersion = gvList.GetFocusedRowCellValue("F_SOFTWARE_VERSION").ToString();

                ModelDEV_UPGRADERECORD modelDevUpgraderecord = _bllDevUpgraderecord.GetModel(devType, devId, hardVersion, softVersion);


                //设备类型
                lueF_DEV_TYPE.EditValue = devType;

                //设备编号		
                lueF_DEV_ID.EditValue = devId;

                //硬件版本		
                txtF_HARDWARE_VERSION.Text = modelDevUpgraderecord.F_HARDWARE_VERSION;

                //软件版本		
                txtF_SOFTWARE_VERSION.Text = modelDevUpgraderecord.F_SOFTWARE_VERSION;

                //上位机信息		
                dteF_UPDATE_DATE.DateTime = modelDevUpgraderecord.F_UPDATE_DATE;

                //工作状态		
                dteF_USED_DATE.DateTime = modelDevUpgraderecord.F_USED_DATE;

                //备注
                txtF_MEMO.Text = gvList.GetFocusedRowCellValue("F_MEMO").ToString();

                chkF_ATTATCHMENT.Checked = _bllDevUpgraderecord.HasAttatch(modelDevUpgraderecord);

            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 设备类型变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lueF_DEV_TYPE_EditValueChanged(object sender, EventArgs e)
        {
            //设备类型
            decimal devType;
            decimal.TryParse(lueF_DEV_TYPE.EditValue.ToString(), out devType);

            switch ((int)devType)
            {
                //负载柜
                case 3:
                    {
                        ApplicationCommon.GetLookUpEditControl(lueF_DEV_ID, "T_DEV_LOAD_INFO", "F_LOAD_ID", "设备编号", "F_LOAD_NAME", "设备名称", "F_DEL=0");
                        break;
                    }
                //上位机
                case 2:
                    {
                        ApplicationCommon.GetLookUpEditControl(lueF_DEV_ID, "T_DEV_WORKSTATION_INFO", "FMasterId", "设备编号", "F_MASTER_NAME", "设备名称", "F_DEL=0");
                        break;
                    }
                //供电柜
                case 1:
                    {
                        ApplicationCommon.GetLookUpEditControl(lueF_DEV_ID, "T_DEV_POWER_INFO", "F_POWER_ID", "设备编号", "F_POWER_NAME", "设备名称", "F_DEL=0");
                        break;
                    }
                //下位机
                case 4:
                    {
                        ApplicationCommon.GetLookUpEditControl(lueF_DEV_ID, "T_DEV_SUBORDINATE_INFO", "F_AFFILIATION_ID", "设备编号", "F_AFFILIATION_NAME", "设备名称", "F_DEL=0");
                        break;
                    }
                //负载柜
                case 5:
                    {
                        ApplicationCommon.GetLookUpEditControl(lueF_DEV_ID, "T_DEV_COILPOWER_INFO", "F_COILPOWER_ID", "设备编号", "F_COILPOWER_NAME", "设备名称", "F_DEL=0");
                        break;
                    }
                //传感器
                case 6:
                    {
                        ApplicationCommon.GetLookUpEditControl(lueF_DEV_ID, "T_DEV_SENSOR_INFO", "F_SENSOR_ID", "设备编号", "F_SENSOR_ID", "设备名称", "F_DEL=0");
                        break;
                    }
            }
        }

        #endregion

        
    }
}