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
    /// 配电柜输入输出开关关系编辑
    /// </summary>
    public partial class FrmDevPowerSwitchRelationEdit : BaseXtraForm
    {
        #region 声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmDevPowerBaseInfo));


        //操作类
        //关系类
        private ProxyBllDEV_SWITCH_INOUT _bllDevSwitchInout = new ProxyBllDEV_SWITCH_INOUT();

        //供电柜操作
        ProxyBllDEV_POWER_INFO _bllDevPowerInfo = new ProxyBllDEV_POWER_INFO();

        //供电柜开关操作
        private ProxyBllDEV_POWER_SWITCH _bllDevPowerSwitch = new ProxyBllDEV_POWER_SWITCH();

       

        //创建操作用数据表
        DataTable dtRelation = new DataTable();


        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmDevPowerSwitchRelationEdit()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体载入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmWorkstatinAntherDevicesRelationEdit_Load(object sender, EventArgs e)
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                InitAllControls();
                //get data from database
                BindWorkstationGridview();

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

                //创建表
                CreateDataTable();
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
            dtRelation.Columns.Add("F_CHECK", typeof (int));

            //设备id
            dtRelation.Columns.Add("F_DEVID", typeof (string));

        }


        /// <summary>
        ///    绑定配电柜信息
        /// </summary>
        private void BindWorkstationGridview()
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

              
                //绑定数据
                DataSet dsPowerInfo = _bllDevPowerInfo.GetAllList();

                //有数据情况下绑定
                if (dsPowerInfo != null && dsPowerInfo.Tables.Count > 0)
                {
                    gcPower.DataSource = dsPowerInfo.Tables[0];
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
        /// 绑定数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //绑定数据
                BindInputSwitchDataset();
               
               

            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        private void BindInputSwitchDataset()
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                if (gvPower.FocusedRowHandle < 0)
                    return;

             

                dtRelation.Rows.Clear();

                //获得工作站id
                string powerId = gvPower.GetFocusedRowCellValue("F_POWER_ID").ToString();


                //获得输入数据
                DataSet dsInputSwitch = new DataSet();

                dsInputSwitch = _bllDevPowerSwitch.GetList("F_POWER_ID='" + powerId + "' AND F_POWER_SWITCH_TYPE=1");
                //有数据情况下绑定
                if (dsInputSwitch != null && dsInputSwitch.Tables.Count > 0)
                {
                    gcInputSwitch.DataSource = dsInputSwitch.Tables[0];
                }

                gvInputSwitch_RowClick(this, null);
               
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
            

        }

     
        /// <summary>
        /// 保存关系数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditRelation_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                
                //准备数据
                List<ModelDEV_SWITCH_INOUT> modelDevRelationComms = PrepareModels();

                //检查是否有存在的关系
                foreach (ModelDEV_SWITCH_INOUT modelDevRelationComm in modelDevRelationComms)
                {
                    DataSet dsRelation =
                        _bllDevSwitchInout.GetList("F_POWER_ID='" + modelDevRelationComm.F_POWER_ID +
                                                   "' AND F_POWER_SWITCH_ID_IN<>'" +
                                                   modelDevRelationComm.F_POWER_SWITCH_ID_IN +
                                                   "' AND F_POWER_SWITCH_ID_OUT='" +
                                                   modelDevRelationComm.F_POWER_SWITCH_ID_OUT + "'");

                    //有数据情况下绑定
                    if (dsRelation != null && dsRelation.Tables.Count > 0)
                    {
                        if (dsRelation.Tables[0].Rows.Count > 0)
                        {

                            XtraMessageBox.Show("关系已经存在，请修改。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;

                        }
                    }
                }

                string powerId = gvPower.GetFocusedRowCellValue("F_POWER_ID").ToString();
                string inputSwitch = gvInputSwitch.GetFocusedRowCellValue("F_POWER_SWITCH_ID").ToString();
                //存储数据
                _bllDevSwitchInout.AddRelation(powerId,inputSwitch, modelDevRelationComms);


                XtraMessageBox.Show("数据已更新。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
     

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("数据更新过程中出错。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
           

        }


        /// <summary>
        /// 创建相应要保存的数据类
        /// </summary>
        /// <returns></returns>
        private List<ModelDEV_SWITCH_INOUT> PrepareModels()
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");


                List<ModelDEV_SWITCH_INOUT> modelDevSwitchInouts = new List<ModelDEV_SWITCH_INOUT>();


                DateTime optDateTime = DateTime.Now;

                foreach (DataRow dataRow in dtRelation.Rows)
                {
                    if (dataRow["F_CHECK"].ToString() == "1")
                    {
                        ModelDEV_SWITCH_INOUT model = new ModelDEV_SWITCH_INOUT();
                        model.F_POWER_ID = gvPower.GetFocusedRowCellValue("F_POWER_ID").ToString();
                        model.F_POWER_SWITCH_ID_IN = gvInputSwitch.GetFocusedRowCellValue("F_POWER_SWITCH_ID").ToString();
                        model.F_POWER_SWITCH_ID_OUT = dataRow["F_DEVID"].ToString();


                        model.F_CREATE_TIME = optDateTime;

                        //操作员		
                        model.F_OPERATOR_ID = AppGlobal.GUserId;

                        //操作时间		
                        model.F_OPERATIONTIME = optDateTime;

                        //是否删除		
                        model.F_DEL = 0;

                        modelDevSwitchInouts.Add(model);
                    }
                }
                return modelDevSwitchInouts;
               


            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }

        }


       
        /// <summary>
        /// 输入开关表格点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvInputSwitch_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                if (gvPower.FocusedRowHandle < 0)
                    return;


                DataTable dt = new DataTable();

                dtRelation.Rows.Clear();

                //获得供电柜编号
                string powerId = gvPower.GetFocusedRowCellValue("F_POWER_ID").ToString();

                //输入开关编号
                string inputSwitchId = gvInputSwitch.GetFocusedRowCellValue("F_POWER_SWITCH_ID").ToString();

                dt = _bllDevPowerSwitch.GetSwitchInputAndOutputRelation(powerId, inputSwitchId).Tables[0];
                
                //录记将
                for (int rowIndex = 0; rowIndex < dt.Rows.Count; rowIndex++)
                {

                    dtRelation.Rows.Add(dt.Rows[rowIndex][0], dt.Rows[rowIndex][1]);
                }

                gcOutputSwitch.DataSource = dtRelation;



            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

    
    }
}