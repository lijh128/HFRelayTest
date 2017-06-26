using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using RelayTest.BLL;
using RelayTest.Model;

namespace RelayTest.Application
{

        public static class ApplicationCommon
        {

            /// <summary>
            /// 设置表格显示格式
            /// </summary>
            /// <param name="gridView"></param>
            public static void InitGridviewColumnAndCellFont(GridView gridView)
            {
                for (int index = 0; index < gridView.Columns.Count; index++)
                {
                    //单元格字体
                    gridView.Columns[index].AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    
                    //表头字体
                    gridView.Columns[index].AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));

                    //表头水平对齐
                    gridView.Columns[index].AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;

                    //允许编辑
                    gridView.Columns[index].OptionsColumn.AllowEdit = false;

                    //允许焦点
                    gridView.Columns[index].OptionsColumn.AllowFocus = false;

                }
            }

            /// <summary>
            /// 将工作站信息绑定到lue上。
            /// </summary>
            /// <param name="lueControl"></param>
            public  static void FillLueWorkStationInfo(DevExpress.XtraEditors.LookUpEdit lueControl)
            {

                //设置显示格式和字段
                lueControl.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                lueControl.Properties.Appearance.Options.UseFont = true;
                lueControl.Properties.AppearanceDropDown.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lueControl.Properties.AppearanceDropDown.Options.UseFont = true;

                lueControl.Properties.Columns.Clear();
                lueControl.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("F_WORKSTATION_ID", "上位机编号")
                ,            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("F_WORKSTATION_NAME", "上位机名称")

                });

                lueControl.Properties.DisplayMember = "F_WORKSTATION_NAME";
                lueControl.Properties.ValueMember = "F_WORKSTATION_ID";

                lueControl.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;


                ProxyBllDEV_WORKSTATION_INFO bllDevWorkstationInfo = new ProxyBllDEV_WORKSTATION_INFO();

                //获得数据集
                DataSet dsWorkstation = bllDevWorkstationInfo.GetAllList();

                //有数据情况下绑定
                if (dsWorkstation != null && dsWorkstation.Tables.Count > 0 )
                {
                    lueControl.Properties.DataSource = dsWorkstation.Tables[0];
                }
            }


            /// <summary>
            /// 将工作站状态绑定到lue上。
            /// </summary>
            /// <param name="lueControl"></param>
            public static void FillLueWorkStationStauts(DevExpress.XtraEditors.LookUpEdit lueControl)
            {

                //设置显示格式和字段
                lueControl.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                lueControl.Properties.Appearance.Options.UseFont = true;
                lueControl.Properties.AppearanceDropDown.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lueControl.Properties.AppearanceDropDown.Options.UseFont = true;

                lueControl.Properties.Columns.Clear();
                lueControl.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("F_VALUE", "编码")
                ,            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("F_DISPLAY", "状态")

                });

                lueControl.Properties.DisplayMember = "F_DISPLAY";
                lueControl.Properties.ValueMember = "F_VALUE";

                lueControl.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;


                lueControl.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;

                ProxyBllCommon bllCommon = new ProxyBllCommon();

                //获得数据集
                DataSet dsTable = bllCommon.GetLookUpEditDataSet("T_SYSTEM_LIST", "F_TYPE='F_WORKSTATION_STATUS'");

                //有数据情况下绑定
                if (dsTable != null && dsTable.Tables.Count > 0)
                {
                    lueControl.Properties.DataSource = dsTable.Tables[0];
                }

            }

            /// <summary>
            /// 将用户绑定到lue上。
            /// </summary>
            /// <param name="lueControl"></param>
            public static void FillLueUser(DevExpress.XtraEditors.LookUpEdit lueControl)
            {

                //设置显示格式和字段
                lueControl.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                lueControl.Properties.Appearance.Options.UseFont = true;
                lueControl.Properties.AppearanceDropDown.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lueControl.Properties.AppearanceDropDown.Options.UseFont = true;

                lueControl.Properties.Columns.Clear();
                lueControl.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("F_USER_ID", "用户编号")
                ,            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("F_USER_NAME", "用户名")

                });

                lueControl.Properties.DisplayMember = "F_USER_NAME";
                lueControl.Properties.ValueMember = "F_USER_ID";

                lueControl.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;


                ProxyBllSYSTEM_USER bllSystemUser = new ProxyBllSYSTEM_USER();

                //获得数据集
                DataSet dsUsers = bllSystemUser.GetAllList();

                //有数据情况下绑定
                if (dsUsers != null && dsUsers.Tables.Count > 0)
                {
                    lueControl.Properties.DataSource = dsUsers.Tables[0];
                }
            }

            /// <summary>
            /// 将负载柜信息绑定到lue上。
            /// </summary>
            /// <param name="lueControl"></param>
            public static void FillLueLoadInfo(DevExpress.XtraEditors.LookUpEdit lueControl)
            {

                //设置显示格式和字段
                lueControl.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                lueControl.Properties.Appearance.Options.UseFont = true;
                lueControl.Properties.AppearanceDropDown.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lueControl.Properties.AppearanceDropDown.Options.UseFont = true;

                lueControl.Properties.Columns.Clear();
                lueControl.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("F_LOAD_ID", "负载柜编号")
                ,            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("F_LOAD_NAME", "负载柜名称")

                });

                lueControl.Properties.DisplayMember = "F_LOAD_NAME";
                lueControl.Properties.ValueMember = "F_LOAD_ID";

                lueControl.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;


                ProxyBllDEV_LOAD_CHANNEL_INFO bllDevLoadInfo = new ProxyBllDEV_LOAD_CHANNEL_INFO();

                //获得数据集
                DataSet dsLoad = bllDevLoadInfo.GetAllList();

                //有数据情况下绑定
                if (dsLoad != null && dsLoad.Tables.Count > 0 )
                {
                    lueControl.Properties.DataSource = dsLoad.Tables[0];
                }
            }


            /// <summary>
            /// 获得方法名称
            /// </summary>
            /// <returns></returns>
            public static string GetMethodName()
            {
                var method = new StackFrame(1).GetMethod(); // 这里忽略1层堆栈，也就忽略了当前方法GetMethodName，这样拿到的就正好是外部调用GetMethodName的方法信息
                var property = (
                          from p in method.DeclaringType.GetProperties(
                                   BindingFlags.Instance |
                                   BindingFlags.Static |
                                   BindingFlags.Public |
                                   BindingFlags.NonPublic)
                          where p.GetGetMethod(true) == method || p.GetSetMethod(true) == method
                          select p).FirstOrDefault();
                return property == null ? method.Name : property.Name;
            }


            /// <summary>
            /// 创建RepositoryItemLookUpEdit
            /// </summary>
            /// <param name="tableName">表名</param>
            /// <param name="valueMember">主键字段</param>
            /// <param name="displayMember"></param>
            /// <param name="condition"></param>
            /// <returns></returns>
            public static DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit GetRepositoryItemLookUpEditControl(string tableName,
                                                                                                                        string valueMember,
                                                                                                                        string displayMember,
                string condition)
            {
                DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();

                repositoryItemLookUpEdit.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                repositoryItemLookUpEdit.Appearance.Options.UseFont = true;
                repositoryItemLookUpEdit.AutoHeight = false;
                repositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});

                repositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(displayMember, displayMember),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(valueMember,valueMember)});

                

                ProxyBllCommon bllCommon = new ProxyBllCommon();

                DataSet dsTable = bllCommon.GetLookUpEditDataSet(tableName, condition);

                if (dsTable != null && dsTable.Tables.Count > 0)
                {
                    repositoryItemLookUpEdit.DataSource = dsTable.Tables[0];

                }
                repositoryItemLookUpEdit.DisplayMember = displayMember;
                repositoryItemLookUpEdit.ValueMember = valueMember;

                //默认显示内容
                repositoryItemLookUpEdit.NullText = "";

                return repositoryItemLookUpEdit;

            }


            /// <summary>
            /// 创建LookUpEdit
            /// </summary>
            /// <param name="lueControl">控件名称</param>
            /// <param name="tableName">表名</param>
            /// <param name="valueMember">代码字段</param>
            /// <param name="valueName">代码字段标题</param>
            /// <param name="displayMember">显示内容字段</param>
            /// <param name="condition">显示内容标题</param>
            /// <returns></returns>
            public static void GetLookUpEditControl(LookUpEdit lueControl, string tableName,
                  string valueMember, string valueName,
                                                                                                                        string displayMember,string displayName,
                string condition)
            {



                //设置显示格式和字段
                lueControl.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                lueControl.Properties.Appearance.Options.UseFont = true;
                lueControl.Properties.AppearanceDropDown.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lueControl.Properties.AppearanceDropDown.Options.UseFont = true;

                lueControl.Properties.Columns.Clear();
                lueControl.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(valueMember, valueName)
                ,            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(displayMember, displayName)

                });

                lueControl.Properties.DisplayMember = displayMember;
                lueControl.Properties.ValueMember = valueMember;

                lueControl.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;

                lueControl.Properties.NullText = "";

                ProxyBllCommon bllCommon = new ProxyBllCommon();

                //获得数据集
                DataSet dsTable = bllCommon.GetLookUpEditDataSet(tableName, condition);

                //有数据情况下绑定
                if (dsTable != null && dsTable.Tables.Count > 0)
                {
                    lueControl.Properties.DataSource = dsTable.Tables[0];
                }


            }


            /// <summary>
            /// write application operation logs
            /// </summary>
            /// <param name="module"></param>
            public static void WriteApplicationLogs(string module)
            {
                //操作实例
                ProxyBllOPERATIONLOG bllOperationlog = new ProxyBllOPERATIONLOG();

                //model instance
                ModelOPERATIONLOG modelOperationlog = new ModelOPERATIONLOG();

                //F_ID
                modelOperationlog.F_ID = 0;
                //F_DATE
                modelOperationlog.F_DATE = DateTime.Now;
                //F_USERID
                modelOperationlog.F_USER_ID = AppGlobal.GUserId;
                //F_MODULENAME
                modelOperationlog.F_MODULE_NAME = module;

                //add model
                bllOperationlog.Add(modelOperationlog);

            }


            /// <summary>
            /// 绑定元数据数据类型选择
            /// </summary>
            /// <param name="lueControl"></param>
            public static void FillLueTestTypeMetaDataDatetype(RepositoryItemLookUpEdit lueControl)
            {
                //设置显示格式和字段
                lueControl.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                lueControl.Appearance.Options.UseFont = true;
                lueControl.AppearanceDropDown.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lueControl.AppearanceDropDown.Options.UseFont = true;

                lueControl.Columns.Clear();
                lueControl.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("F_META_TYPE", "数据类型编码")
                ,            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("F_META_TYPENAME", "数据类型名称")

                });
                lueControl.NullText = "";

                lueControl.BestFitMode = BestFitMode.BestFitResizePopup;


                DataTable dtMetaType = new DataTable();

                //编码
                dtMetaType.Columns.Add("F_META_TYPE", typeof(decimal));

                //名称
                dtMetaType.Columns.Add("F_META_TYPENAME", typeof(string));

                lueControl.DisplayMember = "F_META_TYPENAME";
                lueControl.ValueMember = "F_META_TYPE";

                lueControl.TextEditStyle = TextEditStyles.DisableTextEditor;


                dtMetaType.Rows.Add(1,"字符");
                dtMetaType.Rows.Add(2,"整型");
                dtMetaType.Rows.Add(3,"浮点");
                dtMetaType.Rows.Add(4,"日期时间");

                //有数据情况下绑定
                lueControl.DataSource = dtMetaType;
            }

            /// <summary>
            /// 绑定元数据数据类型选择
            /// </summary>
            /// <param name="lueControl"></param>
            public static void FillLueTestTypeMetaDataDatetype(LookUpEdit lueControl)
            {
                //设置显示格式和字段
                lueControl.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                lueControl.Properties.Appearance.Options.UseFont = true;
                lueControl.Properties.AppearanceDropDown.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lueControl.Properties.AppearanceDropDown.Options.UseFont = true;

                lueControl.Properties.Columns.Clear();
                lueControl.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("F_META_TYPE", "数据类型编码")
                ,            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("F_META_TYPENAME", "数据类型名称")

                });


                DataTable dtMetaType = new DataTable();

                //编码
                dtMetaType.Columns.Add("F_META_TYPE", typeof(decimal));

                //名称
                dtMetaType.Columns.Add("F_META_TYPENAME", typeof(string));

                lueControl.Properties.DisplayMember = "F_META_TYPENAME";
                lueControl.Properties.ValueMember = "F_META_TYPE";

                lueControl.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;


                dtMetaType.Rows.Add(1, "字符");
                dtMetaType.Rows.Add(2, "整型");
                dtMetaType.Rows.Add(3, "浮点");
                dtMetaType.Rows.Add(4, "日期时间");

                //有数据情况下绑定
                lueControl.Properties.DataSource = dtMetaType;
            }
            /// <summary>
            /// 操作类型
            /// </summary>
            /// <param name="lueControl"></param>
            public static void FillLueOperationType(LookUpEdit lueControl)
            {
                //设置显示格式和字段
                lueControl.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                lueControl.Properties.Appearance.Options.UseFont = true;
                lueControl.Properties.AppearanceDropDown.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lueControl.Properties.AppearanceDropDown.Options.UseFont = true;

                lueControl.Properties.Columns.Clear();
                lueControl.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("F_OPERATION_TYPE", "操作类型编码")
                ,            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("F_OPERATION_TYPENAME", "操作类型名称")

                });


                DataTable dtOpertionType = new DataTable();

                //编码
                dtOpertionType.Columns.Add("F_OPERATION_TYPE", typeof(decimal));

                //名称
                dtOpertionType.Columns.Add("F_OPERATION_TYPENAME", typeof(string));

                lueControl.Properties.DisplayMember = "F_OPERATION_TYPENAME";
                lueControl.Properties.ValueMember = "F_OPERATION_TYPE";

                lueControl.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;


                dtOpertionType.Rows.Add(1, "显示");
                dtOpertionType.Rows.Add(2, "发送");
                dtOpertionType.Rows.Add(3, "接收");

                //有数据情况下绑定
                lueControl.Properties.DataSource = dtOpertionType;
            }



            /// <summary>
            /// 填充试验类型
            /// </summary>
            /// <param name="lueControl"></param>
            public static void FillLueTestParameterType(LookUpEdit lueControl)
            {
                //设置显示格式和字段
                lueControl.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                lueControl.Properties.Appearance.Options.UseFont = true;
                lueControl.Properties.AppearanceDropDown.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lueControl.Properties.AppearanceDropDown.Options.UseFont = true;

                lueControl.Properties.Columns.Clear();
                lueControl.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("F_TYPE_CODE", "类型编码")
                ,            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("F_TYPE_NAME", "类型名称")

                });

                lueControl.Properties.DisplayMember = "F_TYPE_NAME";
                lueControl.Properties.ValueMember = "F_TYPE_CODE";

                lueControl.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;


                ProxyBllTESTTASK_PARTYPE bllMonitorPartype = new ProxyBllTESTTASK_PARTYPE();

                //获得数据集
                DataSet dsParameterType = bllMonitorPartype.GetAllList();

                //有数据情况下绑定
                if (dsParameterType != null && dsParameterType.Tables.Count > 0)
                {
                    lueControl.Properties.DataSource = dsParameterType.Tables[0];
                }
            }


            /// <summary>
            /// 填充试验类型
            /// </summary>
            /// <param name="lueControl"></param>
            public static void FillLueTestParameterType(RepositoryItemLookUpEdit lueControl)
            {
                //设置显示格式和字段
                lueControl.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                lueControl.Appearance.Options.UseFont = true;
                lueControl.AppearanceDropDown.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lueControl.AppearanceDropDown.Options.UseFont = true;

                lueControl.Columns.Clear();
                lueControl.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("F_TYPE_CODE", "类型编码")
                ,            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("F_TYPE_NAME", "类型名称")

                });

                lueControl.DisplayMember = "F_TYPE_NAME";
                lueControl.ValueMember = "F_TYPE_CODE";

                lueControl.TextEditStyle = TextEditStyles.DisableTextEditor;

                lueControl.AllowNullInput = DefaultBoolean.True;

                lueControl.NullText = "";

                lueControl.BestFitMode = BestFitMode.BestFitResizePopup;



                ProxyBllTESTTASK_PARTYPE bllMonitorPartype = new ProxyBllTESTTASK_PARTYPE();

                //获得数据集
                DataSet dsParameterType = bllMonitorPartype.GetAllList();

                //有数据情况下绑定
                if (dsParameterType != null && dsParameterType.Tables.Count > 0)
                {

                    lueControl.DataSource = dsParameterType.Tables[0];
                }
            }

            /*
            /// <summary>
            /// 填充试验类型
            /// </summary>
            /// <param name="lueControl"></param>
            public static void FillLueTestTypeMetaData(LookUpEdit lueControl)
            {
                //设置显示格式和字段
                lueControl.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                lueControl.Properties.Appearance.Options.UseFont = true;
                lueControl.Properties.AppearanceDropDown.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lueControl.Properties.AppearanceDropDown.Options.UseFont = true;

                lueControl.Properties.Columns.Clear();
                lueControl.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("F_TEST_TYPE_META_ID", "元数据编号")
                ,            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("F_TEST_TYPE_META_NAME", "元数据名称")

                });

                lueControl.Properties.DisplayMember = "F_TEST_TYPE_META_NAME";
                lueControl.Properties.ValueMember = "F_TEST_TYPE_META_ID";

                lueControl.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;


                ProxyBllTEST_TYPE_METADATA bllLoadInfo = new ProxyBllTEST_TYPE_METADATA();

                //获得数据集
                DataSet dsTestType = bllLoadInfo.GetAllList();

                //有数据情况下绑定
                if (dsTestType != null && dsTestType.Tables.Count > 0)
                {
                    lueControl.Properties.DataSource = dsTestType.Tables[0];
                }
            }
            *
             */

            //将基础数据参数填充进来
            public static void FillLueTestParameterValue(RepositoryItemLookUpEdit lueControl,string codeType)
            {
                //设置显示格式和字段
                lueControl.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                lueControl.Appearance.Options.UseFont = true;
                lueControl.AppearanceDropDown.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lueControl.AppearanceDropDown.Options.UseFont = true;

                lueControl.Columns.Clear();
                lueControl.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("F_CODE", "编码")
                ,            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("F_NAME", "类型名称")

                });

                lueControl.DisplayMember = "F_NAME";
                lueControl.ValueMember = "F_CODE";

                lueControl.TextEditStyle = TextEditStyles.DisableTextEditor;

                lueControl.AllowNullInput = DefaultBoolean.True;

                lueControl.NullText = "";

                lueControl.BestFitMode = BestFitMode.BestFitResizePopup;


                ProxyBllTESTTASK_PARVALUE bllMonitorParcomm = new ProxyBllTESTTASK_PARVALUE();

                //获得数据集
                DataSet dsParaComm = bllMonitorParcomm.GetList("F_TYPE_CODE='" + codeType + "'");

                //有数据情况下绑定
                if (dsParaComm != null && dsParaComm.Tables.Count > 0)
                {

                    lueControl.DataSource = dsParaComm.Tables[0];
                }
            }
        }
    
}
