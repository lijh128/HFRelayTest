using System;
using System.Collections.Generic;
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
    /// 供电柜开关与其他设备关系基本信息
    /// </summary>
    public partial class FrmDevPowerSwitchOntherDevicesRelationEdit : BaseXtraForm
    {
        #region 声明
        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmDevPowerBaseInfo));


        //操作类

        //供电柜数据
        private ProxyBllDEV_POWER_INFO _bllDevPowerInfo = new ProxyBllDEV_POWER_INFO();

        //负载柜操作类
        private ProxyBllDEV_LOAD_INFO _bllDevLoadInfo = new ProxyBllDEV_LOAD_INFO();

        //负载电源操作类
        private ProxyBllDEV_LOADPOWER_INFO _bllDevLoadpowerInfo = new ProxyBllDEV_LOADPOWER_INFO();

        //供电柜开关操作类
        private ProxyBllDEV_POWER_SWITCH _bllDevPowerSwitch = new ProxyBllDEV_POWER_SWITCH();

      

        //创建操作用数据表
        DataTable dtRelation = new DataTable();

        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmDevPowerSwitchOntherDevicesRelationEdit()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体载入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLoadOntherDevicesRelationEdit_Load(object sender, EventArgs e)
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

                //创建编辑用表
                CreateDataTable();
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


                //数据集
                DataSet dsDeviceInfo=new DataSet();

                switch (cbbDevType.SelectedIndex)
                {
                        //负载电源
                    case 0:
                    {
                        //连接设备名称
                        gvDevice.Columns[0].FieldName = "F_LOADPOWER_ID";
                        gvDevice.Columns[0].Caption = "负载电源编号";
                             gvDevice.Columns[1].FieldName = "F_LOADPOWER_NAME";
                        gvDevice.Columns[1].Caption = "负载电源名称";

                        dsDeviceInfo = _bllDevLoadpowerInfo.GetAllList();


                        //开关名称
                        gvSwitch.Columns[1].Caption = "输入开关编号";
                        break;
                    }
                        //负载柜
                         case 1:
                    {
                              gvDevice.Columns[0].FieldName = "F_LOAD_ID";
                        gvDevice.Columns[0].Caption = "负载柜编号";
                             gvDevice.Columns[1].FieldName = "F_LOAD_NAME";
                        gvDevice.Columns[1].Caption = "负载柜名称";

                        dsDeviceInfo = _bllDevLoadInfo.GetAllList();

                        //开关名称
                        gvSwitch.Columns[1].Caption = "输出开关编号";
          
                        break;
                    }
                }

               
                //有数据情况下绑定
                if (dsDeviceInfo != null && dsDeviceInfo.Tables.Count > 0)
                {
                    gcDevice.DataSource = dsDeviceInfo.Tables[0];
                }


                //配电柜数据
                DataSet dsPower = _bllDevPowerInfo.GetAllList();

                //有数据情况下绑定
                if (dsPower != null && dsPower.Tables.Count > 0)
                {
                    gcPower.DataSource = dsPower.Tables[0];
                }
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }


        /// <summary>
        /// 创建所
        /// </summary>
        private void CreateDataTable()
        {
            //是否选择
            dtRelation.Columns.Add("F_CHECK", typeof(int));

            
            //供电柜开关编号
            dtRelation.Columns.Add("F_POWER_SWITCH_ID", typeof(string));

            
        }


        /// <summary>
        /// 绑定数据
        /// </summary>
        private void BindRelatedDevices()
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                if (gvDevice.FocusedRowHandle < 0)
                    return;

                if (string.IsNullOrEmpty(cbbDevType.Text))
                {
                    return;
                }



                DataTable dt = new DataTable();

                //
                dtRelation.Rows.Clear();

               
                //配电柜编号
                string powerId = gvPower.GetFocusedRowCellValue("F_POWER_ID").ToString();

                //负载电源
                if (cbbDevType.SelectedIndex == 0)
                {

                    //获得负载柜id
                    string loadPowerId = gvDevice.GetFocusedRowCellValue("F_LOADPOWER_ID").ToString();

                    //负载电源与供电柜开关关系
                    dt = _bllDevPowerSwitch.GetPowerLoadPowerToPowerSwitchRelation(loadPowerId, powerId).Tables[0];
               

                }
                else if (cbbDevType.SelectedIndex == 1)
                {

                    //获得负载柜id
                    string loadId = gvDevice.GetFocusedRowCellValue("F_LOAD_ID").ToString();

                    //上位机与下位机绑定数据
                    dt = _bllDevPowerSwitch.GetPowerSwitchToLoadRelation(loadId,powerId).Tables[0];

                }


                //录记将
                for (int rowIndex = 0; rowIndex < dt.Rows.Count; rowIndex++)
                {
                    if (cbbDevType.SelectedIndex == 0)
                    {
                        dtRelation.Rows.Add(dt.Rows[rowIndex][0], dt.Rows[rowIndex][1]);

                    }
                    else
                    {
                        dtRelation.Rows.Add(dt.Rows[rowIndex][0], dt.Rows[rowIndex][1]);
                    }
                }


                gcSwitch.DataSource = dtRelation;
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }


        }
        /// <summary>
        /// 创建相应要保存的数据类
        /// </summary>
        /// <returns></returns>
        private List<ModelDEVRelationComm> PrepareModels()
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                List<ModelDEVRelationComm> modelDevRelationComms = new List<ModelDEVRelationComm>();


                DateTime optDateTime = DateTime.Now;

                foreach (DataRow dataRow in dtRelation.Rows)
                {
                    if (dataRow["F_CHECK"].ToString() == "1")
                    {
                        ModelDEVRelationComm model = new ModelDEVRelationComm();

                        //负载电源
                        if (cbbDevType.SelectedIndex == 0)
                        {
                            model.F_MASTER_ID = gvDevice.GetFocusedRowCellValue("F_LOADPOWER_ID").ToString();
                            model.F_MASTER_NAME = gvDevice.GetFocusedRowCellValue("F_LOADPOWER_NAME").ToString();
                  
                        }
                            //负载
                        else if (cbbDevType.SelectedIndex == 1)
                        {

                            model.F_MASTER_ID = gvDevice.GetFocusedRowCellValue("F_LOAD_ID").ToString();
                            model.F_MASTER_NAME = gvDevice.GetFocusedRowCellValue("F_LOAD_NAME").ToString();
                     
                        }
                        model.F_AFFILIATION_ID = dataRow["F_POWER_SWITCH_ID"].ToString();


                        model.F_CREATE_TIME = optDateTime;

                        //操作员		
                        model.F_OPERATOR_ID = AppGlobal.GUserId;

                        //操作时间		
                        model.F_OPERATIONTIME = optDateTime;

                        //是否删除		
                        model.F_DEL = 0;

                        modelDevRelationComms.Add(model);
                    }
                }
                return modelDevRelationComms;



            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }



        }

        #endregion

       

        /// <summary>
        /// 负载柜点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
               

                //绑定关系
                BindRelatedDevices();
                


            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

     
        /// <summary>
        /// 类型选择变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbDevType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                //绑定表格
                BindGridview();
                //绑定关系
                BindRelatedDevices();



            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //准备数据
                List<ModelDEVRelationComm> modelDevRelationComms = PrepareModels();
                string deviceId="";
  
                //负载电源
                if (cbbDevType.SelectedIndex == 0)
                {
                    deviceId = gvDevice.GetFocusedRowCellValue("F_LOADPOWER_ID").ToString();
             
                }
                //负载
                else if (cbbDevType.SelectedIndex == 1)
                {

                    deviceId = gvDevice.GetFocusedRowCellValue("F_LOAD_ID").ToString();
                }

                //供电柜
                string powerId = gvPower.GetFocusedRowCellValue("F_POWER_ID").ToString();

                //存储数据
                _bllDevPowerSwitch.AddRelation(cbbDevType.SelectedIndex, powerId, deviceId, modelDevRelationComms);


                XtraMessageBox.Show("数据已更新。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
    



            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
         

        }


        /// <summary>
        /// 供电柜表格点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvPower_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                //绑定关系
                BindRelatedDevices();
     }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
         
        }

    
    }
}