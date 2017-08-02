using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using log4net;
using RelayTest.Application.Settings;
using RelayTest.Application.Sys;
using RelayTest.Application.CommPar;
using RelayTest.Application.Task;
using RelayTest.Application.Query;

namespace RelayTest.Application
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof (FrmMain));

        private Boolean is_login = false;

        public FrmMain()
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                InitializeComponent();

                //Localizer.Active = new ChinaEditorsLocalizer();

                //GridLocalizer.Active = new ChinaGridLocalizer();


                DevExpress.Accessibility.AccLocalizer.Active =
                    new DevExpress.LocalizationCHS.DevExpressUtilsLocalizationCHS();
                DevExpress.XtraBars.Localization.BarLocalizer.Active =
                    new DevExpress.LocalizationCHS.DevExpressXtraBarsLocalizationCHS();
                DevExpress.XtraCharts.Localization.ChartLocalizer.Active =
                    new DevExpress.LocalizationCHS.DevExpressXtraChartsLocalizationCHS();
                DevExpress.XtraEditors.Controls.Localizer.Active =
                    new DevExpress.LocalizationCHS.DevExpressXtraEditorsLocalizationCHS();
                DevExpress.XtraGrid.Localization.GridLocalizer.Active =
                    new DevExpress.LocalizationCHS.DevExpressXtraGridLocalizationCHS();
                DevExpress.XtraLayout.Localization.LayoutLocalizer.Active =
                    new DevExpress.LocalizationCHS.DevExpressXtraLayoutLocalizationCHS();
                // DevExpress.XtraNavBar.NavBarLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraNavBarLocalizationCHS();
                DevExpress.XtraPivotGrid.Localization.PivotGridLocalizer.Active =
                    new DevExpress.LocalizationCHS.DevExpressXtraPivotGridLocalizationCHS();
                DevExpress.XtraPrinting.Localization.PreviewLocalizer.Active =
                    new DevExpress.LocalizationCHS.DevExpressXtraPrintingLocalizationCHS();
                DevExpress.XtraReports.Localization.ReportLocalizer.Active =
                    new DevExpress.LocalizationCHS.DevExpressXtraReportsLocalizationCHS();
                DevExpress.XtraRichEdit.Localization.XtraRichEditLocalizer.Active =
                    new DevExpress.LocalizationCHS.DevExpressXtraRichEditLocalizationCHS();
                //DevExpress.XtraRichEdit.Localization.RichEditExtensionsLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraRichEditExtensionsLocalizationCHS();
                //DevExpress.XtraScheduler.Localization.SchedulerLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraSchedulerLocalizationCHS();
                //DevExpress.XtraScheduler.Localization.SchedulerExtensionsLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraSchedulerExtensionsLocalizationCHS();
                //DevExpress.XtraSpellChecker.Localization.SpellCheckerLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraSpellCheckerLocalizationCHS();
                DevExpress.XtraTreeList.Localization.TreeListLocalizer.Active =
                    new DevExpress.LocalizationCHS.DevExpressXtraTreeListLocalizationCHS();
                //DevExpress.XtraVerticalGrid.Localization.VGridLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraVerticalGridLocalizationCHS();
                //DevExpress.XtraWizard.Localization.WizardLocalizer.Active = new DevExpress.LocalizationCHS.DevExpressXtraWizardLocalizationCHS();
            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }


        /// <summary>
        /// set form style
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="styleController"></param>
        public static void SetStyleController(Control parent, StyleController styleController)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is BaseControl)

                    ((BaseControl) control).StyleController = styleController;

                SetStyleController(control, styleController);
            }
        }

        /// <summary>
        /// bind to every menuitem click event
        /// </summary>
        /// <param name="eventArgs"></param>
        private void MenuClickLog(DevExpress.XtraBars.ItemClickEventArgs eventArgs)
        {
            string modelName = this.Text;

            modelName += "->" + eventArgs.Item.Caption;

            ApplicationCommon.WriteApplicationLogs(modelName);
        }

        /// <summary>
        /// bind to every menuitem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormButtonClick(object sender,
            EventArgs e)
        {
            if (sender is SimpleButton)
            {
                Form findForm = (sender as SimpleButton).FindForm();
                if (findForm != null)
                {
                    string modelName = findForm.Text;

                    modelName += "->" + (sender as SimpleButton).Text;
                    ApplicationCommon.WriteApplicationLogs(modelName);
                }
            }
        }

        /// <summary>
        /// 绑定按钮点击事件
        /// </summary>
        /// <param name="parent"></param>
        public void BindClickEventToAllBuutonControl(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is SimpleButton)
                {
                    ((SimpleButton) control).Click += FormButtonClick;
                }

                if (control.Controls.Count > 0)
                {
                    BindClickEventToAllBuutonControl(control);
                }
            }
        }

        /// <summary>
        /// 判断某个mdi窗口是否已经打开，如果打开则重新激活并返回真
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private bool IsExistWindow(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// maintain power parameter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //write menu item click log
            MenuClickLog(e);
            if (IsExistWindow("FrmDevPowerBaseInfo"))
            {
                return;
            }
            FrmDevPowerBaseInfo frm = new FrmDevPowerBaseInfo();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }


        /// <summary>
        /// maintain common parameter, such as coil type, swithc type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mmCommonInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //write menu item click log
            MenuClickLog(e);
            if (IsExistWindow("FrmMaintainMonitorParameter"))
            {
                return;
            }
            FrmMaintainMonitorParameter frm = new FrmMaintainMonitorParameter();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }

        private void mmTestParameter_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }


        /// <summary>
        /// maintain load base info 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mmLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //write menu item click log
            MenuClickLog(e);
            if (IsExistWindow("FrmDevLoadBaseInfo"))
            {
                return;
            }
            FrmDevLoadBaseInfo frm = new FrmDevLoadBaseInfo();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }


        /// <summary>
        /// 供电柜异常情况及动作设定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mmPowerAbnormal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //write menu item click log
            MenuClickLog(e);
            if (IsExistWindow("FrmDevWorkstatinOntherDevicesRelation"))
            {
                return;
            }
            FrmDevWorkstatinOntherDevicesRelation frm = new FrmDevWorkstatinOntherDevicesRelation();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }


        /// <summary>
        /// 负载柜紧急机制及动作设定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mmLoadAbnormal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //write menu item click log
            MenuClickLog(e);
            if (IsExistWindow("FrmDevLoadOntherDevicesRelation"))
            {
                return;
            }
            FrmDevLoadOntherDevicesRelation frm = new FrmDevLoadOntherDevicesRelation();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }


        /// <summary>
        /// 温度传感器数据维护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mmSensor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //write menu item click log
            MenuClickLog(e);
            if (IsExistWindow("FrmDevSensorBaseInfo"))
            {
                return;
            }
            FrmDevSensorBaseInfo frm = new FrmDevSensorBaseInfo();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }


        /// <summary>
        /// 负载线圈电源数据维护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mmCoil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //write menu item click log
            MenuClickLog(e);
            if (IsExistWindow("FrmDevCoilPowerBaseInfo"))
            {
                return;
            }
            FrmDevCoilPowerBaseInfo frm = new FrmDevCoilPowerBaseInfo();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }


        /// <summary>
        /// 下位机基础数据维护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mmSubOrdinate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //write menu item click log
            MenuClickLog(e);
            if (IsExistWindow("FrmDevSubordinateBaseInfo"))
            {
                return;
            }
            FrmDevSubordinateBaseInfo frm = new FrmDevSubordinateBaseInfo();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }


        /// <summary>
        /// 串口数据维护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mmCom232_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //write menu item click log
            MenuClickLog(e);
            if (IsExistWindow("FrmComSetting"))
            {
                return;
            }
            FrmComSetting frm = new FrmComSetting();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }

        /// <summary>
        /// 485数据维护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mmCom485_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }


        /// <summary>
        /// 检测参数类型设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mmParameterMonitorType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //write menu item click log
            MenuClickLog(e);
            if (IsExistWindow("FrmMaintainMonitorParameterType"))
            {
                return;
            }


            FrmMaintainMonitorParameterType frm = new FrmMaintainMonitorParameterType();


            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }


        /// <summary>
        /// 上位机数据维护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
//write menu item click log

            MenuClickLog(e);
            if (IsExistWindow("FrmDevWorkstatinInfo"))
            {
                return;
            }


            FrmDevWorkstatinInfo frm = new FrmDevWorkstatinInfo();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }

        /// <summary>
        /// 实验数据维护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mmTaskManage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //write menu item click log
            MenuClickLog(e);
            if (IsExistWindow("FrmTaskManager"))
            {
                return;
            }
            FrmTaskManager frm = new FrmTaskManager();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }

        private void mmNet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }


        /// <summary>
        /// 元数据类新维护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mmMetaData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //write menu item click log
            MenuClickLog(e);
            if (IsExistWindow("FrmDevUpgradeRecord"))
            {
                return;
            }
            FrmDevUpgradeRecord frm = new FrmDevUpgradeRecord();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }


        /// <summary>
        /// 试验类型及参数维护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mmTestType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //write menu item click log
            MenuClickLog(e);
            if (IsExistWindow("FrmMaintainMonitorParameterType"))
            {
                return;
            }
        }

        /// <summary>
        /// 用户管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mmUserManage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //write menu item click log
            MenuClickLog(e);
            if (IsExistWindow("FrmUser"))
            {
                return;
            }
            FrmUser frm = new FrmUser();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }

        /// <summary>
        /// 功能管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mmModule_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //write menu item click log
            MenuClickLog(e);
            if (IsExistWindow("FrmModule"))
            {
                return;
            }
            FrmModule frm = new FrmModule();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }


        /// <summary>
        /// 角色管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mmRoleManage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //write menu item click log
            MenuClickLog(e);
            if (IsExistWindow("FrmRole"))
            {
                return;
            }
            FrmRole frm = new FrmRole();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }

        /// <summary>
        /// 权限管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mmAuthoriztion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //write menu item click log
            MenuClickLog(e);
            if (IsExistWindow("FrmRoleAuth"))
            {
                return;
            }
            FrmRoleAuth frm = new FrmRoleAuth();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }


        /// <summary>
        /// 日志管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mmLog_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //write menu item click log
            MenuClickLog(e);
            if (IsExistWindow("FrmLogs"))
            {
                return;
            }
            FrmLogs frm = new FrmLogs();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }

        private void mmDeviceUpdateHis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //write menu item click log
            MenuClickLog(e);
            if (IsExistWindow("FrmDevUpgradeRecord"))
            {
                return;
            }
            FrmDevUpgradeRecord frm = new FrmDevUpgradeRecord();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }

        private void mmLoadPower_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //write menu item click log
            MenuClickLog(e);
            if (IsExistWindow("FrmDevLoadPowerBaseInfo"))
            {
                return;
            }
            FrmDevLoadPowerBaseInfo frm = new FrmDevLoadPowerBaseInfo();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }

        private void mmTestBoxInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //write menu item click log
            MenuClickLog(e);
            if (IsExistWindow("FrmDevTestBoxInfo"))
            {
                return;
            }
            FrmDevTestBoxInfo frm = new FrmDevTestBoxInfo();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }

        private void mmPowerSwitchInOutRelation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //write menu item click log
            MenuClickLog(e);
            if (IsExistWindow("FrmDevPowerSwitchRelationEdit"))
            {
                return;
            }
            FrmDevPowerSwitchRelationEdit frm = new FrmDevPowerSwitchRelationEdit();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }

        private void mmPowerSwitchToOtherDevices_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //write menu item click log
            MenuClickLog(e);
            if (IsExistWindow("FrmDevPowerSwitchOntherDevicesRelationEdit"))
            {
                return;
            }
            FrmDevPowerSwitchOntherDevicesRelationEdit frm = new FrmDevPowerSwitchOntherDevicesRelationEdit();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }

        /// <summary>
        /// 试验命令字维护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MenuClickLog(e);
            if (IsExistWindow("FrmCommCode"))
            {
                return;
            }
            FrmCommCode frm = new FrmCommCode();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }

        /// <summary>
        /// 发送命令参数元数据维护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MenuClickLog(e);
            if (IsExistWindow("FrmCommMetaSend"))
            {
                return;
            }
            FrmCommMetaSend frm = new FrmCommMetaSend();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }

        /// <summary>
        /// 工作模式试验程序信息维护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mmCommWorkType_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MenuClickLog(e);
            if (IsExistWindow("FrmCommWorktype"))
            {
                return;
            }
            FrmCommWorktype frm = new FrmCommWorktype();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }


        /// <summary>
        /// 试验开始命令程序参数维护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barButtonItem1_ItemClick_2(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MenuClickLog(e);
            if (IsExistWindow("FrmCommStart"))
            {
                return;
            }
            FrmCommStart frm = new FrmCommStart();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }

        /// <summary>
        /// 主窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //菜单显示定位到第一个选项卡--试验任务管理
            ribbonControl1.SelectedPage = ribbonPage1;
            //ribbonControl1.Pages.Count
            
            //disable_allsubMenu();
            if (is_login == false)
            {
                FrmLogin frm = new FrmLogin();
                BindClickEventToAllBuutonControl(frm);
                frm.ShowDialog();

                if (AppGlobal.GUserName.Equals("未登录"))
                {
                    lbl_loginName.Text = AppGlobal.GUserName;
                    is_login = false;
                    mmLogin.Enabled = true;
                    mmLogout.Enabled = false;
                }
                else
                {
                    enableAuthMenu(AppGlobal.GUserId);
                    lbl_loginName.Text = "当前用户:" + AppGlobal.GUserName;
                    is_login = true;
                    mmLogin.Enabled = false;
                    mmLogout.Enabled = true;                    
                }
            }
            else
            {
                lbl_loginName.Text = "当前用户:" + AppGlobal.GUserName;
                mmLogin.Enabled = false;
                mmLogout.Enabled = true;
            }


            //Text += " Ver 1.0 build 20151030";


            //更新失效查询命令
            Text += "Ver 1.1 build 20170801";

            barStaticItem2.Caption = "1.1 build 20170801";

           
        }

        private void enableAuthMenu(string userid)
        {
            ProxyBllSYSTEM_ROLE_AUTH bllSystemRoleAuth = new ProxyBllSYSTEM_ROLE_AUTH();
            DataSet dsModule=bllSystemRoleAuth.GetModuleOfUser(userid);
            if (dsModule != null && dsModule.Tables[0].Rows.Count != 0)
            {
                for (int i = 0; i < dsModule.Tables[0].Rows.Count; i++)
                {
                    string tempModuleCode = dsModule.Tables[0].Rows[i]["F_MODULE_NAME"].ToString();

                    for (int m1 = 0; m1 < ribbonControl1.Pages.Count; m1++)
                    {
                        for (int m2 = 0; m2 < ribbonControl1.Pages[m1].Groups.Count; m2++)
                        {
                            for (int m3 = 0; m3 < ribbonControl1.Pages[m1].Groups[m2].ItemLinks.Count; m3++)
                            {
                                if (tempModuleCode.Equals(ribbonControl1.Pages[m1].Groups[m2].ItemLinks[m3].Caption))
                                {
                                    ribbonControl1.Pages[m1].Groups[m2].ItemLinks[m3].Item.Enabled = true;
                                }
                            }
                        }
                    }
                }
            }
            return;
        }
        private void mmTestQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MenuClickLog(e);
            if (IsExistWindow("FrmQueryTaskInfo"))
            {
                return;
            }
            FrmQueryTaskInfo frm = new FrmQueryTaskInfo();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }

        private void mmRunningQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MenuClickLog(e);
            if (IsExistWindow("FrmQuerySampleFailure"))
            {
                return;
            }
            FrmQuerySampleFailure frm = new FrmQuerySampleFailure();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }

        private void disable_allsubMenu()
        {
            ProxyBllSYSTEM_MODULE bllSystemModule = new ProxyBllSYSTEM_MODULE();
            DataSet dsModule = bllSystemModule.GetList(" LENGTH(F_MODULE_ID)=5 AND F_DEL=0 ");

           
            if (dsModule != null && dsModule.Tables[0].Rows.Count != 0)
            {
                for (int i = 0; i < dsModule.Tables[0].Rows.Count; i++)
                {
                    string tempModuleCode = dsModule.Tables[0].Rows[i]["F_MODULE_NAME"].ToString();

                    for (int m1 = 0; m1 < ribbonControl1.Pages.Count; m1++)
                    {
                        for (int m2 = 0; m2 < ribbonControl1.Pages[m1].Groups.Count; m2++)
                        {
                            for (int m3 = 0; m3 < ribbonControl1.Pages[m1].Groups[m2].ItemLinks.Count; m3++)
                            {
                                if (tempModuleCode.Equals(ribbonControl1.Pages[m1].Groups[m2].ItemLinks[m3].Caption))
                                {
                                    ribbonControl1.Pages[m1].Groups[m2].ItemLinks[m3].Item.Enabled = false;
                                }
                            }
                        }
                    }
                }
            }
            return;
        }

        /// <summary>
        /// 登录菜单事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mmLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //菜单显示定位到第一个选项卡--试验任务管理
            ribbonControl1.SelectedPage = ribbonPage1;

            FrmLogin frm = new FrmLogin();
            BindClickEventToAllBuutonControl(frm);
            frm.ShowDialog();
            if (AppGlobal.GUserName.Equals("未登录"))
            {
                lbl_loginName.Text = AppGlobal.GUserName;
                is_login = false;
                mmLogin.Enabled = true;
                mmLogout.Enabled = false;
            }
            else
            {
                enableAuthMenu(AppGlobal.GUserId);
                lbl_loginName.Text = "当前用户:"+AppGlobal.GUserName;
                is_login = true;
                mmLogin.Enabled = false;
                mmLogout.Enabled = true;
            }
        }

        /// <summary>
        /// 注销菜单事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mmLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //IsExistWindow()
            foreach (Form form in this.MdiChildren) 
            { 
                if (!form.IsDisposed) 
                { 
                    form.Close(); 
                } 
            }
            AppGlobal.GUserName = "未登录";
            lbl_loginName.Text = AppGlobal.GUserName;
            is_login = false;
            mmLogin.Enabled = true;
            mmLogout.Enabled = false;
            disable_allsubMenu();
        }

        private void mmDevStatusQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MenuClickLog(e);
            if (IsExistWindow("FrmQueryDevStatus"))
            {
                return;
            }
            FrmQueryDevStatus frm = new FrmQueryDevStatus();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }

        /// <summary>
        /// Lims任务读取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mmLimsTaskRead_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //write menu item click log
            MenuClickLog(e);
            if (IsExistWindow("FrmLimsTaskRead"))
            {
                return;
            }
            FrmLimsTaskRead frm = new FrmLimsTaskRead();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }

        private void mmTaskDisList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MenuClickLog(e);
            if (IsExistWindow("FrmTaskDisList"))
            {
                return;
            }
            FrmTaskDisList frm = new FrmTaskDisList();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }

        private void mmRunUpTestStatus_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MenuClickLog(e);
            if (IsExistWindow("FrmRunUpTestStatus"))
            {
                return;
            }
            FrmRunUpTestStatus frm = new FrmRunUpTestStatus();
            frm.MdiParent = this;
            BindClickEventToAllBuutonControl(frm);
            SetStyleController(frm, styleController);
            frm.Show();
        }

       
    }
}