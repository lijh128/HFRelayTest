using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace RelayTest.Application.Controls
{


    public partial class ucModuleMenu : XtraUserControl
    {
        private readonly ProxyBllSYSTEM_MODULE _xtglBllModule = new ProxyBllSYSTEM_MODULE();
        public int UserInd;
        public string UserLoginName;
        public string UserName;
        public static int SubItemId = 1000;

        public ucModuleMenu()
        {
            InitializeComponent();
            UserInd = -1;
            UserLoginName = "";
        }

        private void mmuModule_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }


        

        /**/
        /*
        /// <summary>
        /// 菜单单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void subMenu_ShowForm(object sender, EventArgs e)
        {
            try
            {
                string acName = ((ToolStripMenuItem) sender).Tag.ToString();

                if (acName != "")
                {
                    //根据从数据库中读取的窗体类名称创建窗体
                    string type = acName.Substring(0, 3);
                    acName = acName.Substring(4);
                    Type t = Type.GetType(acName);
//                    Object obj = Activator.CreateInstance(t);

                    if (t != null)
                    {
                        Assembly assembly = Assembly.GetAssembly(t);
                        var frm = (Form) assembly.CreateInstance(t.FullName);


                        //设置窗体的位置和字体
                        if (frm != null)
                        {
                            frm.StartPosition = FormStartPosition.CenterScreen;
                            frm.Font = Font;

                            //为窗体中的所有按钮添加写日志的事件
                            foreach (Control control in frm.Controls)
                            {
                                if (control is Button)
                                {
                                    (control).Click += WriteLog;
                                }
                            }

                            //根据前面是MDI还是SDI来创建窗体
                            if (type == "MDI")
                            {
                                foreach (Form openForm in Application.OpenForms)
                                {
                                    if (openForm.Name == "FrmMain")
                                    {
                                        foreach (Form childrenForm in openForm.MdiChildren)
                                        {
                                            if (childrenForm.GetType().FullName == acName)
                                            {
                                                childrenForm.Visible = true; //如果配置窗口已打开则将其显示
                                                childrenForm.Activate(); //并激活该窗体
                                                return;
                                            }
                                        }
                                        frm.MdiParent = openForm;
                                        frm.Show();
                                        return;
                                    }
                                }
                            }
                            else
                            {
                                frm.ShowDialog();
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("创建菜单对应窗体时出错，请联系系统管理员", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        */
        /**/

        /// <summary>
        /// 菜单单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void subMenu_Click(object sender, EventArgs e)
        {
            try
            {
                //tag属性在这里有用到。
                String str = ((ToolStripMenuItem) sender).Tag.ToString();

                if (str != "")
                {
                    foreach (MethodInfo info in GetType().GetMethods())
                    {
                        if (str.Trim().ToLower().CompareTo(info.ToString().Trim().ToLower()) == 0)
                        {
                            info.Invoke(this, null);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("调用菜单点击事件时出错，请联系系统管理员", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }


        public void DemoShow()
        {
            MessageBox.Show("一个测试");
        }



        /*   由于菜单由barmanange产生，所以不再使用这个函数
        /// <summary>
        /// 递归创建MenuStrip菜单(模块列表)
        /// </summary>
        /// <param name="dtSource">数据源</param>
        /// <param name="topMenu">父菜单项</param>
        /// <param name="inFatherId">父菜单的ID</param>
        private void LoadSubMenu(DataTable dtSource, ToolStripMenuItem topMenu, String inFatherId)
        {
            DataRow[] rows = dtSource.Select(String.Format("F_ParentID={0}", inFatherId));

            ToolStripMenuItem subMenu;
            foreach (DataRow row in rows)
            {
                //创建子菜单项
                subMenu = new ToolStripMenuItem();
                subMenu.Name = row["F_ID"].ToString();
                subMenu.Text = row["F_NAME"].ToString();

                if (row["F_AUTH"].ToString() == "0")
                {
                    subMenu.Enabled = false;
                }
                if (row["F_ACTION"].ToString() == "" && row["F_PATH"].ToString() == "")
                {
                    subMenu.Enabled = true;
                }

                //判断是否为顶级菜单
                if (inFatherId == "0")
                {
                    mmuModule.Items.Add(subMenu);
                }
                else
                {
                    if (row["F_PATH"].ToString().Length > 0)
                    {
                        subMenu.Tag = row["F_PATH"].ToString();
                        subMenu.Click += subMenu_ShowForm;
                    }
                    else if (row["F_ACTION"].ToString().Length > 0)
                    {
                        subMenu.Tag = row["F_ACTION"].ToString();
                        subMenu.Click += subMenu_Click;
                    }
                    topMenu.DropDownItems.Add(subMenu);
                }

                //递归调用
                LoadSubMenu(dtSource, subMenu, row["F_ID"].ToString());
            }
        }

        */
        /// <summary>
        /// 递归创建MenuStrip菜单(模块列表)
        /// </summary>
        /// <param name="topMenu">父菜单项</param>
        /// <param name="FATHER_ID">父菜单的ID</param>
        private void LoadSubItem(DataTable dtSource, BarSubItem topMenu, String inFatherId)
        {
            DataRow[] rows = dtSource.Select(String.Format("F_ParentID={0}", inFatherId));


            foreach (DataRow row in rows)
            {
                
                
                //创建子菜单项


                //判断是否为顶级菜单
                if (inFatherId == "0")
                {
                    var subItem = new BarSubItem(barManager, row["F_NAME"].ToString());

                    subItem.Id = SubItemId;
                    mmMain.ItemLinks.Add(subItem);
                    LoadSubItem(dtSource, subItem, row["F_ID"].ToString());
                }
                else
                {
                    if (row["F_HASCHILD"].ToString() != "0")
                    {
                        var subItem = new BarSubItem(barManager, row["F_NAME"].ToString());
                        if (row["F_AUTH"].ToString() == "0")
                        {
                            subItem.Enabled = false;
                        }
                        if (row["F_ACTION"].ToString() == "" && row["F_PATH"].ToString() == "")
                        {
                            subItem.Enabled = true;
                        }
//                        topMenu.AddItem(subItem);
                        subItem.Id = SubItemId;
                        topMenu.ItemLinks.Add(subItem);
                        LoadSubItem(dtSource, subItem, row["F_ID"].ToString());
                    }
                    else
                    {
                        var subItem = new BarButtonItem(barManager, row["F_NAME"].ToString());
                        
                        if (row["F_AUTH"].ToString() == "0")
                        {
                            subItem.Enabled = false;
                        }
                        if (row["F_ACTION"].ToString() == "" && row["F_PATH"].ToString() == "")
                        {
                            subItem.Enabled = true;
                        }
                        if (row["F_PATH"].ToString().Length > 0)
                        {
                            subItem.Tag = row["F_PATH"].ToString();
                            subItem.ItemClick += subItem_ShowForm;
                        }
                        else if (row["F_ACTION"].ToString().Length > 0)
                        {
                            subItem.Tag = row["F_ACTION"].ToString();
                            subItem.ItemClick += subItem_Click;
                        }

//                        topMenu.AddItem(subItem);
                        subItem.Id = SubItemId;
                        topMenu.ItemLinks.Add(subItem);
                    }
                }
                SubItemId++;
                //递归调用
            }
        }

        private void subItem_ShowForm(object sender, ItemClickEventArgs e)
        {
            try
            {
                string acName = e.Item.Tag.ToString();

                if (acName != "")
                {
                    //根据从数据库中读取的窗体类名称创建窗体
                    string type = acName.Substring(0, 3);
                    acName = acName.Substring(4);
                    Type t = Type.GetType(acName);
                    Object obj = Activator.CreateInstance(t);
                    Assembly assembly = Assembly.GetAssembly(t);
                    var frm = (Form) assembly.CreateInstance(t.FullName);


                    //设置窗体的位置和字体
                    frm.StartPosition = FormStartPosition.CenterScreen;
//                    pControl.Font = Font;

                    //为窗体中的所有按钮添加写日志的事件

                    //根据前面是MDI还是SDI来创建窗体
                    if (type == "MDI")
                    {
                        foreach (Form openForm in global::System.Windows.Forms.Application.OpenForms)
                        {
                            if (openForm.Name == "FrmMain")
                            {
                                foreach (Form childrenForm in openForm.MdiChildren)
                                {
                                    if (childrenForm.GetType().FullName == acName)
                                    {
                                        childrenForm.Visible = true; //如果配置窗口已打开则将其显示
                                        childrenForm.Activate(); //并激活该窗体
                                        return;
                                    }
                                }
                                frm.MdiParent = openForm;
                                frm.Show();
                                return;
                            }
                        }
                    }
                    else
                    {
                        frm.ShowDialog();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("创建菜单对应窗体时出错，请联系系统管理员", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        

        private void subItem_Click(object sender, ItemClickEventArgs e)
        {
            try
            {
                //tag属性在这里有用到。
                String str = e.Item.Tag.ToString();


                if (str != "")
                {
                    foreach (MethodInfo info in base.GetType().GetMethods())
                    {
                        if (str.Trim().ToLower().CompareTo(info.ToString().Trim().ToLower()) == 0)
                        {
                            info.Invoke(this, null);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("调用菜单点击事件时出错，请联系系统管理员", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }


        public void InitMenu()
        {
//            using (DataSet dataSet = _xtglBllModule.GetUerModule(UserInd))
//            {
//                DataTable dt = dataSet.Tables[0];
//                //mmuModule.Items.Clear();
//                //LoadSubMenu(dt, null, "0");
//                mmMain.ClearLinks();
//                LoadSubItem(dt, null, "0");
//            }
        }

        

        private void barManager_CreateToolbar(object sender, CreateToolbarEventArgs e)
        {
            
        }

        private void barLargeButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
//            (new Frm_YK_SDJHD()).ShowDialog();
        }

        private void barLargeButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}