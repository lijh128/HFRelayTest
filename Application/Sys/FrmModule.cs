using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using log4net;
using RelayTest.Model;

namespace RelayTest.Application.Sys
{

    /// <summary>
    /// 功能模块管理
    /// </summary>
    public partial class FrmModule : DevExpress.XtraEditors.XtraForm
    {

        #region 声明

        //Log操作类
        //日志对象
        private static readonly ILog Log = LogManager.GetLogger(typeof(FrmModule));


        //操作类
        private ProxyBllSYSTEM_MODULE _bllSystemModule = new ProxyBllSYSTEM_MODULE();

        //数据集
        private DataSet _dsSystemModule = new DataSet();

        #endregion


        #region 事件方法

        /// <summary>
        /// 构造函数
        /// </summary>
        public FrmModule()
        {
            InitializeComponent();

        }

        /// <summary>
        /// 窗体载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmModule_Load(object sender, EventArgs e)
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

               
                //初始化控件
                InitAllControl();

                //绑定数据源
                BindGridview();
            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 保存
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
                ModelSYSTEM_MODULE modelSystemModule = PrepareModelSystemModule();


                //判断此数据是否已经存在
                bool isDataExist = _bllSystemModule.Exists(modelSystemModule.F_MODULE_ID);

                if (isDataExist)
                {
                    //已经存在判断是否更新
                    DialogResult dialogResult = XtraMessageBox.Show("当前数据已存在，是否更新？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                    //更新数据
                    bool status = _bllSystemModule.Update(modelSystemModule);

                    //获得当前rowhandle
                    var rowhandle = tlModule.FocusedNode;

                    //绑定数据
                    BindGridview();

                    //设置焦点行
                    tlModule.SetFocusedNode(rowhandle);


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
                    _bllSystemModule.Add(modelSystemModule);


                    //绑定数据
                    BindGridview();


                    var rowhandle = tlModule.FindNodeByKeyID(modelSystemModule.F_MODULE_ID);

                    //设置焦点行
                    tlModule.SetFocusedNode(rowhandle);



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
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Info(GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");
                //删除前判断
                DialogResult dialogResult = XtraMessageBox.Show("此操作将永久删除数据并有可能导致其他关联数据出错，是否继续？", "选择", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }

                //检查必填字段
                bool isAllOk = CheckNotNullField();

                if (!isAllOk)
                    return;

                //准备要存储的数据
                ModelSYSTEM_MODULE modelSystemModule = PrepareModelSystemModule();
                //更新数据
                bool status = _bllSystemModule.Drop(modelSystemModule.F_MODULE_ID);

                
                //绑定数据
                BindGridview();


                if (status)
                {
                    XtraMessageBox.Show("此数据已删除。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("没有数据被更新。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                Log.Error(GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }


        /// <summary>
        /// 点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tlModule_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                if (tlModule.AllNodesCount < 0)
                    return;

                if (tlModule.FocusedNode == null)
                    return;

                ModelSYSTEM_MODULE modelSystemModule = new ModelSYSTEM_MODULE();

                modelSystemModule = _bllSystemModule.GetModel(tlModule.FocusedNode["F_MODULE_ID"].ToString());
                txtF_MODULE_NAME.Text = modelSystemModule.F_MODULE_NAME;
                txtF_MODULE_ID.Text = modelSystemModule.F_MODULE_ID;
                txtF_PARENT_MODULE_ID.Text = modelSystemModule.F_PARENT_MODULE_ID;
                txtModuleForm.Text = modelSystemModule.F_PATH;
                txtF_ACTION.Text = modelSystemModule.F_ACTION;
                txtF_ORDNO.Text = modelSystemModule.F_ORDNO.ToString();

                chkF_ISADMINONLY.Checked = (modelSystemModule.F_ISADMINONLY == "1");

            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "电子表格文件 (*.xls)|*.xls";
                saveFileDialog.FileName = "导出文件.xls";
                var dialogResult = saveFileDialog.ShowDialog();
                if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }
                string fileName = saveFileDialog.FileName;
                if (!string.IsNullOrEmpty(fileName))
                {
                    try
                    {
                        DevExpress.XtraPrinting.XlsExportOptions __options = new DevExpress.XtraPrinting.XlsExportOptions();
                        __options.TextExportMode = TextExportMode.Value;
                        __options.ExportMode = DevExpress.XtraPrinting.XlsExportMode.SingleFile;
                        __options.ShowGridLines = true;
                        tlModule.OptionsPrint.UsePrintStyles = true;
                        tlModule.ExportToXls(fileName, __options);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("文件正在使用！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }
        }

        #endregion

        #region 自定义方法

        /// <summary>
        /// 初始化界面
        /// </summary>
        private void InitAllControl()
        {
            try
            {
                Log.Info(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---START");

            }
            catch (Exception ex)
            {
                Log.Error(this.GetType() + "->" + ApplicationCommon.GetMethodName() + "---FAILED", ex);
                throw ex;
            }

        }

        /// <summary>
        /// 填充表格
        /// </summary>
        private void BindGridview()
        {
            _dsSystemModule = _bllSystemModule.GetAllList();

            //绑定数据
            if (_dsSystemModule != null && _dsSystemModule.Tables.Count > 0)
            {
                tlModule.DataSource = _dsSystemModule.Tables[0];

                tlModule.KeyFieldName = "F_MODULE_ID";
                tlModule.ParentFieldName = "F_PARENT_MODULE_ID";
            }
        }

        /// <summary>
        /// 准备数据
        /// </summary>
        /// <returns></returns>
        private ModelSYSTEM_MODULE PrepareModelSystemModule()
        {

            //创建操作类
            ModelSYSTEM_MODULE model = new ModelSYSTEM_MODULE();

            //编号
            model.F_MODULE_ID = txtF_MODULE_ID.Text;

            //名称
            model.F_MODULE_NAME = txtF_MODULE_NAME.Text;

            //父级编码
            model.F_PARENT_MODULE_ID = txtF_PARENT_MODULE_ID.Text;

            //行为
            model.F_ACTION = txtF_ACTION.Text;

            //窗体
            model.F_PATH = txtModuleForm.Text;

            //顺序
            model.F_ORDNO = decimal.Parse(txtF_ORDNO.Text);

            //只有管理员可以执行
            model.F_ISADMINONLY = (chkF_ISADMINONLY.Checked ? 1 : 0).ToString();

            //创建时间
            DateTime optDateTime = DateTime.Now;
            model.F_CREATE_TIME = optDateTime;

            //操作员
            model.F_OPERATOR_ID = AppGlobal.GUserId;


            //操作时间
            model.F_OPERATIONTIME = optDateTime;

            //是否删除
            model.F_DEL = 0;

            return model;
        }



        /// <summary>
        /// 检查必填字段
        /// </summary>
        /// <returns></returns>
        private bool CheckNotNullField()
        {
            //模块编码不能为空
            if (string.IsNullOrEmpty(txtF_MODULE_ID.Text))
            {
                XtraMessageBox.Show("模块编码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //模块名称不能为空
            if (string.IsNullOrEmpty(txtF_MODULE_NAME.Text))
            {
                XtraMessageBox.Show("模块名称不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //父级编码不能为空
            if (string.IsNullOrEmpty(txtF_PARENT_MODULE_ID.Text) )
            {
                XtraMessageBox.Show("父级编码不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            //执行顺序不能为空
            if (string.IsNullOrEmpty(txtF_ORDNO.Text) )
            {
                XtraMessageBox.Show("执行顺序不能为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        #endregion
    }
}
