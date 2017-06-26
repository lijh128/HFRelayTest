using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using log4net;
using RelayTest.Model;

namespace RelayTest.Application.Sys
{
    public partial class FrmRoleAuth : DevExpress.XtraEditors.XtraForm
    {
        #region 成员声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmRoleAuth));

      
        //操作类
        /// <summary>
        /// 用户
        /// </summary>
        private ProxyBllSYSTEM_USER _bllSystemUser = new ProxyBllSYSTEM_USER();
        /// <summary>
        /// 功能
        /// </summary>
        private ProxyBllSYSTEM_MODULE _bllSystemModule = new ProxyBllSYSTEM_MODULE();
        /// <summary>
        /// 角色功能
        /// </summary>
        private ProxyBllSYSTEM_ROLE_AUTH _bllSystemRoleAuth = new ProxyBllSYSTEM_ROLE_AUTH();
        /// <summary>
        /// 角色用户
        /// </summary>
        private ProxyBllSYSTEM_USER_ROLE _bllSystemUserRole = new ProxyBllSYSTEM_USER_ROLE();


        /// <summary>
        /// 角色
        /// </summary>
        private ProxyBllSYSTEM_ROLE _bllSystemRole = new ProxyBllSYSTEM_ROLE();
        #endregion
        

       
        public FrmRoleAuth()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 初始化界面
        /// </summary>
        public void InitAllControl()
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //填充用户信息
                FillAllSelectedControls();

            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
            
        }

        /// <summary>
        /// 填充所有可选列
        /// </summary>
        public void FillAllSelectedControls()
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                lueRole.Properties.DataSource = _bllSystemRole.GetAllList().Tables[0];
                lueRole.Properties.DisplayMember = "F_ROLE_NAME";
                lueRole.Properties.ValueMember = "F_ROLE_ID";

            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
           
        }

        /// <summary>
        /// 窗口载入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAuth_Load(object sender, EventArgs e)
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                
                //初始化控件
                InitAllControl();
            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
          
        }


        /// <summary>
        /// 用户选择变换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lueUser_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //获取角色中包含的用户
                GetUsersInRole();

                //获取此角色下的功能列表
                GetModulesInRoles();
               
            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
            
             


        }

        /// <summary>
        /// 获取角色下的功能列表
        /// </summary>
        private void GetModulesInRoles()
        {
            //角色id
            string roleId = lueRole.EditValue.ToString();

            //读取数据源
            DataSet dsAllModules = _bllSystemModule.GetAllList();

           
            //设定显示数据和数值数据

            //已授权模块
            DataSet dsModulesOfRole = _bllSystemRoleAuth.GetModulesOfRole(roleId);


            //便利全部授权模块
            for (int indexOfModules = 0; indexOfModules < dsAllModules.Tables[0].Rows.Count; indexOfModules++)
            {
                //便利已授权记录
                foreach (DataRow dataRow in dsModulesOfRole.Tables[0].Rows)
                {
                    //如果两个记录相等
                    if (dsAllModules.Tables[0].Rows[indexOfModules]["F_MODULE_ID"].ToString() == dataRow["F_MODULE_ID"].ToString())
                    {
                        //设置勾选状态
                        dsAllModules.Tables[0].Rows[indexOfModules]["F_DEL"] = 1;
                    }
                }
            }

            //绑定数据
            tlModule.DataSource = dsAllModules.Tables[0];
        }

        /// <summary>
        /// 获取角色中包含的用户
        /// </summary>
        private void GetUsersInRole()
        {
            //角色id
            string roleId = lueRole.EditValue.ToString();

            //读取数据源
            DataSet dsAllUers = _bllSystemUser.GetAllList();

            //绑定数据
            chklistAllModules.DataSource = dsAllUers.Tables[0];

            //设定显示数据和数值数据
            chklistAllModules.DisplayMember = "F_USER_NAME";
            chklistAllModules.ValueMember = "F_USER_ID";


            //将所有选项都删除
            chklistAllModules.UnCheckAll();


            //已授权模块
            DataSet dsUsersOfRole = _bllSystemRoleAuth.GetUsersOfRole(roleId);


            //便利全部授权模块
            for (int indexOfAllModules = 0; indexOfAllModules < chklistAllModules.ItemCount; indexOfAllModules++)
            {
                //便利已授权记录
                foreach (DataRow dataRow in dsUsersOfRole.Tables[0].Rows)
                {
                    //如果两个记录相等
                    if (chklistAllModules.GetItemValue(indexOfAllModules).ToString() == dataRow["F_USER_ID"].ToString())
                    {
                        //设置勾选状态
                        chklistAllModules.SetItemChecked(indexOfAllModules, true);
                    }
                }
            }
        }


        /// <summary>
        /// 授权
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAuth_Click(object sender, EventArgs e)
        {


            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                //如果没有选择任何数据则退出
                if (chklistAllModules.SelectedItems.Count == 0)
                {
                    XtraMessageBox.Show("请至少选择一个操作内容。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }

                //准备要存储的用户角色关联信息
                List<ModelSYSTEM_USER_ROLE> modelSystemUserRoles = PrepareUserRoleList();


                //准备要存储的角色模块关联信息
                List<ModelSYSTEM_ROLE_AUTH> modelSystemRoleAuths = PrepareRoleAuthList();

                //保存数据
                _bllSystemRoleAuth.Auth(lueRole.EditValue.ToString(), modelSystemUserRoles, modelSystemRoleAuths);

             
                    XtraMessageBox.Show("授权完成。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
            
            

        }

        /// <summary>
        /// 准备要存储的角色模块列表
        /// </summary>
        /// <returns></returns>
        private List<ModelSYSTEM_ROLE_AUTH> PrepareRoleAuthList()
        {
            //准备要插入的数据
            List<ModelSYSTEM_ROLE_AUTH> modelSystemRoleAuths = new List<ModelSYSTEM_ROLE_AUTH>();

            //创建时间
            DateTime optDateTime = DateTime.Now;
            //遍历全部授权模块
            for (int indexOfAllModules = 0; indexOfAllModules < tlModule.VisibleNodesCount; indexOfAllModules++)
            {

               
                //如果被选择，则是要授权
                if ((decimal)tlModule.GetNodeByVisibleIndex(indexOfAllModules).GetValue("F_DEL")==1)
                {
                    ModelSYSTEM_ROLE_AUTH modelSystemRoleAuth = new ModelSYSTEM_ROLE_AUTH();

                    //用户
                    modelSystemRoleAuth.F_MODULE_ID = tlModule.GetNodeByVisibleIndex(indexOfAllModules).GetValue("F_MODULE_ID").ToString();

                    //角色
                    modelSystemRoleAuth.F_ROLE_ID = lueRole.EditValue.ToString();


                    modelSystemRoleAuth.F_CREATE_TIME = optDateTime;

                    //操作员
                    modelSystemRoleAuth.F_OPERATOR_ID = AppGlobal.GUserId;


                    //操作时间
                    modelSystemRoleAuth.F_OPERATIONTIME = optDateTime;

                    //是否删除
                    modelSystemRoleAuth.F_DEL = 0;

                    modelSystemRoleAuths.Add(modelSystemRoleAuth);
                }
            }
            return modelSystemRoleAuths;

        }

        /// <summary>
        /// 准备要插入的用户角色关联列表
        /// </summary>
        /// <returns></returns>
        private List<ModelSYSTEM_USER_ROLE> PrepareUserRoleList()
        {
//准备要插入的数据
            List<ModelSYSTEM_USER_ROLE> modelSystemUserRoles = new List<ModelSYSTEM_USER_ROLE>();

            //创建时间
            DateTime optDateTime = DateTime.Now;
            //遍历全部授权模块
            for (int indexOfAllModules = 0; indexOfAllModules < chklistAllModules.ItemCount; indexOfAllModules++)
            {
                //如果被选择，则是要授权
                if (chklistAllModules.GetItemChecked(indexOfAllModules))
                {
                    ModelSYSTEM_USER_ROLE modelSystemUserRole = new ModelSYSTEM_USER_ROLE();

                    //用户
                    modelSystemUserRole.F_USER_ID = chklistAllModules.GetItemValue(indexOfAllModules).ToString();

                    //角色
                    modelSystemUserRole.F_ROLE_ID = lueRole.EditValue.ToString();


                    modelSystemUserRole.F_CREATE_TIME = optDateTime;

                    //操作员
                    modelSystemUserRole.F_OPERATOR_ID = AppGlobal.GUserId;


                    //操作时间
                    modelSystemUserRole.F_OPERATIONTIME = optDateTime;

                    //是否删除
                    modelSystemUserRole.F_DEL = 0;

                    modelSystemUserRoles.Add(modelSystemUserRole);
                }
            }
            return modelSystemUserRoles;
        }

        /// <summary>
        /// before form close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAuth_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
     
    }
}
