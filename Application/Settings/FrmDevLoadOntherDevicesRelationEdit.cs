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
    /// 负载柜与其他设备关系显示
    /// </summary>
    public partial class FrmDevLoadOntherDevicesRelationEdit : BaseXtraForm
    {
        #region 声明
        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmDevPowerBaseInfo));


        //操作类
        private ProxyBllDEV_LOAD_INFO _bllDevLoadInfo = new ProxyBllDEV_LOAD_INFO();

        //数据集
        private DataSet _dsLoadInfo = new DataSet();


        //创建操作用数据表
        DataTable dtRelation = new DataTable();

        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmDevLoadOntherDevicesRelationEdit()
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

                FillAllSelectedControls();

                //创建编辑用表
                CreateDataTable();
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
                _dsLoadInfo = _bllDevLoadInfo.GetAllList();

                //有数据情况下绑定
                if (_dsLoadInfo != null && _dsLoadInfo.Tables.Count > 0)
                {
                    gcLoad.DataSource = _dsLoadInfo.Tables[0];
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

            //设备id
            dtRelation.Columns.Add("F_DEVID", typeof(string));

            //设备名称
            dtRelation.Columns.Add("F_DEVNAME", typeof(string));

            //备注
            dtRelation.Columns.Add("F_MEMO", typeof(string));
        }


        /// <summary>
        /// 绑定数据
        /// </summary>
        private void BindRelatedDevices()
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                if (gvLoad.FocusedRowHandle < 0)
                    return;

                if (string.IsNullOrEmpty(cbbDevType.Text))
                {
                    return;
                }



                DataTable dt = new DataTable();

                //
                dtRelation.Rows.Clear();

                //获得负载柜id
                string loadId = gvLoad.GetFocusedRowCellValue("F_LOAD_ID").ToString();

                colF_NAME.Caption = "名称";
                if (cbbDevType.SelectedIndex == 0)
                {
                    //上位机与下位机绑定数据
                    dt = _bllDevLoadInfo.GetSubordinatesRelatedToLoad(loadId).Tables[0];
                }
                else if (cbbDevType.SelectedIndex == 1)
                {
                    //上位机与线圈电源绑定数据
                    dt = _bllDevLoadInfo.GetCoilPowersRelatedToLoad(loadId).Tables[0];

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
                        model.F_MASTER_ID = gvLoad.GetFocusedRowCellValue("F_LOAD_ID").ToString();
                        model.F_MASTER_NAME = gvLoad.GetFocusedRowCellValue("F_LOAD_NAME").ToString();
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
            //准备数据
            List<ModelDEVRelationComm> modelDevRelationComms = PrepareModels();
            string workstationId = gvLoad.GetFocusedRowCellValue("F_LOAD_ID").ToString();
            //存储数据
            _bllDevLoadInfo.AddRelation(cbbDevType.SelectedIndex, workstationId, modelDevRelationComms);


            XtraMessageBox.Show("数据已更新。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
     

        }

    
    }
}