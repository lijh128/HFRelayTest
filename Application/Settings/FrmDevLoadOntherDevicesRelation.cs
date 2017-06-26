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
    /// 负载柜与其他设备关系显示
    /// </summary>
    public partial class FrmDevLoadOntherDevicesRelation : BaseXtraForm
    {
        #region 声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmDevPowerBaseInfo));
        

        //操作类
        private ProxyBllDEV_LOAD_INFO _bllDevLoadInfo = new ProxyBllDEV_LOAD_INFO();
       
        //数据集
        private DataSet _dsLoadInfo = new DataSet();

        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmDevLoadOntherDevicesRelation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体载入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLoadAntherDevicesRelation_Load(object sender, EventArgs e)
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


        
      

       

        #endregion

     


        private void gvList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                if (gvLoad.FocusedRowHandle < 0)
                    return;
                
                
                //获得负载柜id
                string workstationId = gvLoad.GetFocusedRowCellValue("F_LOAD_ID").ToString();

                
                //上位机与下位机绑定数据
                gcSubordinate.DataSource = _bllDevLoadInfo.GetSubordinatesRelatedToLoad(workstationId).Tables[0];

                gvSubordinate.ActiveFilterString = "F_CHECK = 1";


                //上位机与线圈电源绑定数据
                gcCoilPower.DataSource = _bllDevLoadInfo.GetCoilPowersRelatedToLoad(workstationId).Tables[0];

                gvCoilPower.ActiveFilterString = "F_CHECK = 1";



            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

   

        private void btnEditRelation_Click(object sender, EventArgs e)
        {
            //编辑关系
            (new FrmDevLoadOntherDevicesRelationEdit()).ShowDialog();

            gvList_RowClick(this,null);
        }

      

    
    }
}