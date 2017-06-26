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
    /// 上位机与其他设备关系编辑
    /// </summary>
    public partial class FrmDevWorkstatinOntherDevicesRelationEdit : BaseXtraForm
    {
        #region 声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmDevPowerBaseInfo));


        //操作类
        private ProxyBllDEV_WORKSTATION_INFO _bllDevWorkstationInfo = new ProxyBllDEV_WORKSTATION_INFO();
       
        //数据集
        private DataSet _dsWorkstationInfo = new DataSet();


         //创建操作用数据表
              
                DataTable dtRelation = new DataTable();

              

        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmDevWorkstatinOntherDevicesRelationEdit()
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

            //设备名称
            dtRelation.Columns.Add("F_DEVNAME", typeof (string));

            //备注
            dtRelation.Columns.Add("F_MEMO", typeof (string));
        }


        /// <summary>
        ///    绑定工作站信息
        /// </summary>
        private void BindWorkstationGridview()
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
                BindRelatedDevices();
               
               

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
        private void BindRelatedDevices()
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                if (gvWorkstation.FocusedRowHandle < 0)
                    return;

                if (string.IsNullOrEmpty(cbbDevType.Text))
                {
                    return;
                }

               

                DataTable dt = new DataTable();

                //
                dtRelation.Rows.Clear();

                //获得工作站id
                string workstationId = gvWorkstation.GetFocusedRowCellValue("F_WORKSTATION_ID").ToString();


                if (cbbDevType.SelectedIndex == 0)
                {
                    //上位机与供电柜关系绑定数据
                    dt = _bllDevWorkstationInfo.GetPowersRelatedToWorkstation(workstationId).Tables[0];

                }
                else if (cbbDevType.SelectedIndex == 1)
                {
                    //上位机与下位机绑定数据
                    dt = _bllDevWorkstationInfo.GetSubordinatesRelatedToWorkstation(workstationId).Tables[0];

                }
                else if (cbbDevType.SelectedIndex == 2)
                {
                    //上位机与线圈电源绑定数据
                    dt = _bllDevWorkstationInfo.GetCoilPowersRelatedToWorkstation(workstationId).Tables[0];

                }
                else if (cbbDevType.SelectedIndex == 3)
                {
                    //上位机与传感器绑定数据
                    dt = _bllDevWorkstationInfo.GetSensorsRelatedToWorkstation(workstationId).Tables[0];
                }

                //录记将
                for (int rowIndex = 0; rowIndex < dt.Rows.Count; rowIndex++)
                {

                    dtRelation.Rows.Add(dt.Rows[rowIndex][0], dt.Rows[rowIndex][1], dt.Rows[rowIndex][2], "");
                }


                gcDevice.DataSource = dtRelation;
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
                List<ModelDEVRelationComm> modelDevRelationComms = PrepareModels();
                string workstationId = gvWorkstation.GetFocusedRowCellValue("F_WORKSTATION_ID").ToString();
                //存储数据
                _bllDevWorkstationInfo.AddRelation(cbbDevType.SelectedIndex, workstationId, modelDevRelationComms);


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
                        model.F_MASTER_ID = gvWorkstation.GetFocusedRowCellValue("F_WORKSTATION_ID").ToString();
                        model.F_MASTER_NAME = gvWorkstation.GetFocusedRowCellValue("F_WORKSTATION_NAME").ToString();
                        model.F_AFFILIATION_ID = dataRow["F_DEVID"].ToString();
                        model.F_AFFILIATION_NAME = dataRow["F_DEVNAME"].ToString();
                        model.F_MEMO = dataRow["F_MEMO"].ToString();


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


        /// <summary>
        /// 显示相应的关系数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbbDevType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //绑定数据
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