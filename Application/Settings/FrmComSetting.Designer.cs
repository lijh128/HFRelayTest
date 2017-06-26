using System.Data;
using DevExpress.XtraEditors;
using RelayTest.Util.Common;

namespace RelayTest.Application.Settings
{

    /// <summary>
    /// 串口参数设置
    /// </summary>
    partial class FrmComSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.plnButtons = new DevExpress.XtraEditors.PanelControl();
            this.btnEnabled = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnDisabled = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnExport = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnDelete = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnSave = new RelayTest.Util.Common.BaseSimpleButton();
            this.pnlDetail = new DevExpress.XtraEditors.GroupControl();
            this.lcDetail = new DevExpress.XtraLayout.LayoutControl();
            this.cbbF_TYPE = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtF_COM_CODE = new DevExpress.XtraEditors.TextEdit();
            this.cbbF_BAUDRATE = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbbF_DATABIT = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbbF_ODDEVENCHECK = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbbF_STOPBIT = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbbF_STREAMCONTROL = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lcgDetail = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciF_COM_CODE = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_BAUDRATE = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_DATABIT = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_ODDEVENCHECK = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_STOPBIT = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_STREAMCONTROL = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_TYPE = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.pnlGrid = new DevExpress.XtraEditors.GroupControl();
            this.gcList = new RelayTest.Util.Common.BaseGridControl();
            this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colF_COM_CODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_BAUDRATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_DATABIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_DEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblExportOpt = new RelayTest.Util.Common.BaseLabelControl();
            this.cboExportOpt = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pnlTop = new DevExpress.XtraEditors.GroupControl();
            this.lblF_WORKSTATION_ID = new RelayTest.Util.Common.BaseLabelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.baseLabelControl5 = new RelayTest.Util.Common.BaseLabelControl();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.lueF_WORKSTATION_ID = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.plnButtons)).BeginInit();
            this.plnButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).BeginInit();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcDetail)).BeginInit();
            this.lcDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbF_TYPE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COM_CODE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbF_BAUDRATE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbF_DATABIT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbF_ODDEVENCHECK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbF_STOPBIT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbF_STREAMCONTROL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COM_CODE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_BAUDRATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_DATABIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_ODDEVENCHECK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_STOPBIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_STREAMCONTROL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_TYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboExportOpt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueF_WORKSTATION_ID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridColumn2
            // 
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "gridColumn1";
            // 
            // plnButtons
            // 
            this.plnButtons.Controls.Add(this.btnEnabled);
            this.plnButtons.Controls.Add(this.btnDisabled);
            this.plnButtons.Controls.Add(this.btnExport);
            this.plnButtons.Controls.Add(this.btnDelete);
            this.plnButtons.Controls.Add(this.btnSave);
            this.plnButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plnButtons.Location = new System.Drawing.Point(0, 652);
            this.plnButtons.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.plnButtons.Name = "plnButtons";
            this.plnButtons.Size = new System.Drawing.Size(1153, 56);
            this.plnButtons.TabIndex = 3;
            // 
            // btnEnabled
            // 
            this.btnEnabled.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEnabled.Appearance.Options.UseFont = true;
            this.btnEnabled.Location = new System.Drawing.Point(446, 13);
            this.btnEnabled.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEnabled.Name = "btnEnabled";
            this.btnEnabled.Size = new System.Drawing.Size(80, 31);
            this.btnEnabled.TabIndex = 1;
            this.btnEnabled.Text = "启用";
            this.btnEnabled.Click += new System.EventHandler(this.btnEnabled_Click);
            // 
            // btnDisabled
            // 
            this.btnDisabled.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDisabled.Appearance.Options.UseFont = true;
            this.btnDisabled.Location = new System.Drawing.Point(536, 13);
            this.btnDisabled.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDisabled.Name = "btnDisabled";
            this.btnDisabled.Size = new System.Drawing.Size(80, 31);
            this.btnDisabled.TabIndex = 2;
            this.btnDisabled.Text = "禁用";
            this.btnDisabled.Click += new System.EventHandler(this.btnDisabled_Click);
            // 
            // btnExport
            // 
            this.btnExport.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.Location = new System.Drawing.Point(716, 12);
            this.btnExport.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(80, 31);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "导出";
            this.btnExport.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(626, 12);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 31);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(356, 13);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlDetail
            // 
            this.pnlDetail.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlDetail.Appearance.Options.UseFont = true;
            this.pnlDetail.AppearanceCaption.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlDetail.AppearanceCaption.Options.UseFont = true;
            this.pnlDetail.Controls.Add(this.lcDetail);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetail.Location = new System.Drawing.Point(0, 477);
            this.pnlDetail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(1153, 175);
            this.pnlDetail.TabIndex = 2;
            this.pnlDetail.Text = "参数设置";
            // 
            // lcDetail
            // 
            this.lcDetail.Controls.Add(this.cbbF_TYPE);
            this.lcDetail.Controls.Add(this.txtF_COM_CODE);
            this.lcDetail.Controls.Add(this.cbbF_BAUDRATE);
            this.lcDetail.Controls.Add(this.cbbF_DATABIT);
            this.lcDetail.Controls.Add(this.cbbF_ODDEVENCHECK);
            this.lcDetail.Controls.Add(this.cbbF_STOPBIT);
            this.lcDetail.Controls.Add(this.cbbF_STREAMCONTROL);
            this.lcDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcDetail.Location = new System.Drawing.Point(2, 22);
            this.lcDetail.Name = "lcDetail";
            this.lcDetail.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(771, 416, 250, 350);
            this.lcDetail.Root = this.lcgDetail;
            this.lcDetail.Size = new System.Drawing.Size(1149, 151);
            this.lcDetail.TabIndex = 0;
            this.lcDetail.Text = "lcDetail";
            // 
            // cbbF_TYPE
            // 
            this.cbbF_TYPE.Location = new System.Drawing.Point(199, 15);
            this.cbbF_TYPE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbbF_TYPE.Name = "cbbF_TYPE";
            this.cbbF_TYPE.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbF_TYPE.Properties.Appearance.Options.UseFont = true;
            this.cbbF_TYPE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbF_TYPE.Properties.Items.AddRange(new object[] {
            "232",
            "485"});
            this.cbbF_TYPE.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbF_TYPE.Size = new System.Drawing.Size(370, 22);
            this.cbbF_TYPE.StyleController = this.lcDetail;
            this.cbbF_TYPE.TabIndex = 2;
            // 
            // txtF_COM_CODE
            // 
            this.txtF_COM_CODE.Location = new System.Drawing.Point(199, 47);
            this.txtF_COM_CODE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_COM_CODE.Name = "txtF_COM_CODE";
            this.txtF_COM_CODE.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_COM_CODE.Properties.Appearance.Options.UseFont = true;
            this.txtF_COM_CODE.Properties.Mask.EditMask = "(com|COM)([1-9]|[1-9][0-9])";
            this.txtF_COM_CODE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtF_COM_CODE.Size = new System.Drawing.Size(370, 22);
            this.txtF_COM_CODE.StyleController = this.lcDetail;
            this.txtF_COM_CODE.TabIndex = 0;
            // 
            // cbbF_BAUDRATE
            // 
            this.cbbF_BAUDRATE.Location = new System.Drawing.Point(673, 47);
            this.cbbF_BAUDRATE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbbF_BAUDRATE.Name = "cbbF_BAUDRATE";
            this.cbbF_BAUDRATE.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbF_BAUDRATE.Properties.Appearance.Options.UseFont = true;
            this.cbbF_BAUDRATE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbF_BAUDRATE.Properties.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600",
            "115200"});
            this.cbbF_BAUDRATE.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbF_BAUDRATE.Size = new System.Drawing.Size(371, 22);
            this.cbbF_BAUDRATE.StyleController = this.lcDetail;
            this.cbbF_BAUDRATE.TabIndex = 1;
            // 
            // cbbF_DATABIT
            // 
            this.cbbF_DATABIT.Location = new System.Drawing.Point(199, 79);
            this.cbbF_DATABIT.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbbF_DATABIT.Name = "cbbF_DATABIT";
            this.cbbF_DATABIT.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbF_DATABIT.Properties.Appearance.Options.UseFont = true;
            this.cbbF_DATABIT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbF_DATABIT.Properties.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.cbbF_DATABIT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbF_DATABIT.Size = new System.Drawing.Size(370, 22);
            this.cbbF_DATABIT.StyleController = this.lcDetail;
            this.cbbF_DATABIT.TabIndex = 2;
            // 
            // cbbF_ODDEVENCHECK
            // 
            this.cbbF_ODDEVENCHECK.Location = new System.Drawing.Point(673, 79);
            this.cbbF_ODDEVENCHECK.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbbF_ODDEVENCHECK.Name = "cbbF_ODDEVENCHECK";
            this.cbbF_ODDEVENCHECK.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbF_ODDEVENCHECK.Properties.Appearance.Options.UseFont = true;
            this.cbbF_ODDEVENCHECK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbF_ODDEVENCHECK.Properties.Items.AddRange(new object[] {
            "0:无",
            "1:奇校验",
            "2:偶校验",
            "3:标记",
            "4:空格"});
            this.cbbF_ODDEVENCHECK.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbF_ODDEVENCHECK.Size = new System.Drawing.Size(371, 22);
            this.cbbF_ODDEVENCHECK.StyleController = this.lcDetail;
            this.cbbF_ODDEVENCHECK.TabIndex = 3;
            // 
            // cbbF_STOPBIT
            // 
            this.cbbF_STOPBIT.Location = new System.Drawing.Point(199, 111);
            this.cbbF_STOPBIT.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbbF_STOPBIT.Name = "cbbF_STOPBIT";
            this.cbbF_STOPBIT.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbF_STOPBIT.Properties.Appearance.Options.UseFont = true;
            this.cbbF_STOPBIT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbF_STOPBIT.Properties.Items.AddRange(new object[] {
            "1.0",
            "1.5",
            "2.0"});
            this.cbbF_STOPBIT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbF_STOPBIT.Size = new System.Drawing.Size(370, 22);
            this.cbbF_STOPBIT.StyleController = this.lcDetail;
            this.cbbF_STOPBIT.TabIndex = 4;
            // 
            // cbbF_STREAMCONTROL
            // 
            this.cbbF_STREAMCONTROL.Location = new System.Drawing.Point(673, 111);
            this.cbbF_STREAMCONTROL.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbbF_STREAMCONTROL.Name = "cbbF_STREAMCONTROL";
            this.cbbF_STREAMCONTROL.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbF_STREAMCONTROL.Properties.Appearance.Options.UseFont = true;
            this.cbbF_STREAMCONTROL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbF_STREAMCONTROL.Properties.Items.AddRange(new object[] {
            "无",
            "Xon/Xoff",
            "RTS/CTS",
            "DTR/DSR"});
            this.cbbF_STREAMCONTROL.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbF_STREAMCONTROL.Size = new System.Drawing.Size(371, 22);
            this.cbbF_STREAMCONTROL.StyleController = this.lcDetail;
            this.cbbF_STREAMCONTROL.TabIndex = 5;
            // 
            // lcgDetail
            // 
            this.lcgDetail.CustomizationFormText = "Root";
            this.lcgDetail.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgDetail.GroupBordersVisible = false;
            this.lcgDetail.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciF_COM_CODE,
            this.lciF_BAUDRATE,
            this.lciF_DATABIT,
            this.lciF_ODDEVENCHECK,
            this.lciF_STOPBIT,
            this.lciF_STREAMCONTROL,
            this.lciF_TYPE,
            this.emptySpaceItem1});
            this.lcgDetail.Location = new System.Drawing.Point(0, 0);
            this.lcgDetail.Name = "Root";
            this.lcgDetail.Padding = new DevExpress.XtraLayout.Utils.Padding(100, 100, 10, 10);
            this.lcgDetail.Size = new System.Drawing.Size(1149, 151);
            this.lcgDetail.Text = "Root";
            this.lcgDetail.TextVisible = false;
            // 
            // lciF_COM_CODE
            // 
            this.lciF_COM_CODE.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_COM_CODE.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_COM_CODE.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_COM_CODE.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_COM_CODE.Control = this.txtF_COM_CODE;
            this.lciF_COM_CODE.CustomizationFormText = "端口：";
            this.lciF_COM_CODE.Location = new System.Drawing.Point(0, 32);
            this.lciF_COM_CODE.Name = "lciF_COM_CODE";
            this.lciF_COM_CODE.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciF_COM_CODE.Size = new System.Drawing.Size(474, 32);
            this.lciF_COM_CODE.Text = "端口：";
            this.lciF_COM_CODE.TextSize = new System.Drawing.Size(90, 14);
            // 
            // lciF_BAUDRATE
            // 
            this.lciF_BAUDRATE.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_BAUDRATE.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_BAUDRATE.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_BAUDRATE.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_BAUDRATE.Control = this.cbbF_BAUDRATE;
            this.lciF_BAUDRATE.CustomizationFormText = "波特率：";
            this.lciF_BAUDRATE.Location = new System.Drawing.Point(474, 32);
            this.lciF_BAUDRATE.Name = "lciF_BAUDRATE";
            this.lciF_BAUDRATE.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciF_BAUDRATE.Size = new System.Drawing.Size(475, 32);
            this.lciF_BAUDRATE.Text = "波特率：";
            this.lciF_BAUDRATE.TextSize = new System.Drawing.Size(90, 14);
            // 
            // lciF_DATABIT
            // 
            this.lciF_DATABIT.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_DATABIT.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_DATABIT.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_DATABIT.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_DATABIT.Control = this.cbbF_DATABIT;
            this.lciF_DATABIT.CustomizationFormText = "数据位：";
            this.lciF_DATABIT.Location = new System.Drawing.Point(0, 64);
            this.lciF_DATABIT.Name = "lciF_DATABIT";
            this.lciF_DATABIT.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciF_DATABIT.Size = new System.Drawing.Size(474, 32);
            this.lciF_DATABIT.Text = "数据位：";
            this.lciF_DATABIT.TextSize = new System.Drawing.Size(90, 14);
            // 
            // lciF_ODDEVENCHECK
            // 
            this.lciF_ODDEVENCHECK.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_ODDEVENCHECK.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_ODDEVENCHECK.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_ODDEVENCHECK.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_ODDEVENCHECK.Control = this.cbbF_ODDEVENCHECK;
            this.lciF_ODDEVENCHECK.CustomizationFormText = "奇偶校验：";
            this.lciF_ODDEVENCHECK.Location = new System.Drawing.Point(474, 64);
            this.lciF_ODDEVENCHECK.Name = "lciF_ODDEVENCHECK";
            this.lciF_ODDEVENCHECK.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciF_ODDEVENCHECK.Size = new System.Drawing.Size(475, 32);
            this.lciF_ODDEVENCHECK.Text = "奇偶校验：";
            this.lciF_ODDEVENCHECK.TextSize = new System.Drawing.Size(90, 14);
            // 
            // lciF_STOPBIT
            // 
            this.lciF_STOPBIT.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_STOPBIT.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_STOPBIT.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_STOPBIT.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_STOPBIT.Control = this.cbbF_STOPBIT;
            this.lciF_STOPBIT.CustomizationFormText = "停止位：";
            this.lciF_STOPBIT.Location = new System.Drawing.Point(0, 96);
            this.lciF_STOPBIT.Name = "lciF_STOPBIT";
            this.lciF_STOPBIT.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciF_STOPBIT.Size = new System.Drawing.Size(474, 35);
            this.lciF_STOPBIT.Text = "停止位：";
            this.lciF_STOPBIT.TextSize = new System.Drawing.Size(90, 14);
            // 
            // lciF_STREAMCONTROL
            // 
            this.lciF_STREAMCONTROL.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_STREAMCONTROL.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_STREAMCONTROL.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_STREAMCONTROL.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_STREAMCONTROL.Control = this.cbbF_STREAMCONTROL;
            this.lciF_STREAMCONTROL.CustomizationFormText = "数据流控制：";
            this.lciF_STREAMCONTROL.Location = new System.Drawing.Point(474, 96);
            this.lciF_STREAMCONTROL.Name = "lciF_STREAMCONTROL";
            this.lciF_STREAMCONTROL.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciF_STREAMCONTROL.Size = new System.Drawing.Size(475, 35);
            this.lciF_STREAMCONTROL.Text = "数据流控制：";
            this.lciF_STREAMCONTROL.TextSize = new System.Drawing.Size(90, 14);
            // 
            // lciF_TYPE
            // 
            this.lciF_TYPE.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lciF_TYPE.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_TYPE.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_TYPE.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_TYPE.Control = this.cbbF_TYPE;
            this.lciF_TYPE.CustomizationFormText = "端口类型：";
            this.lciF_TYPE.Location = new System.Drawing.Point(0, 0);
            this.lciF_TYPE.Name = "lciF_TYPE";
            this.lciF_TYPE.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciF_TYPE.Size = new System.Drawing.Size(474, 32);
            this.lciF_TYPE.Text = "端口类型：";
            this.lciF_TYPE.TextSize = new System.Drawing.Size(90, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(474, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(475, 32);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.pnlGrid);
            this.xtraScrollableControl1.Controls.Add(this.pnlDetail);
            this.xtraScrollableControl1.Controls.Add(this.pnlTop);
            this.xtraScrollableControl1.Controls.Add(this.plnButtons);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1153, 708);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // pnlGrid
            // 
            this.pnlGrid.AppearanceCaption.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlGrid.AppearanceCaption.Options.UseFont = true;
            this.pnlGrid.Controls.Add(this.gcList);
            this.pnlGrid.Controls.Add(this.lblExportOpt);
            this.pnlGrid.Controls.Add(this.cboExportOpt);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 56);
            this.pnlGrid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1153, 421);
            this.pnlGrid.TabIndex = 1;
            this.pnlGrid.Text = "列表信息";
            // 
            // gcList
            // 
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcList.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gcList.Location = new System.Drawing.Point(2, 22);
            this.gcList.MainView = this.gvList;
            this.gcList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcList.Name = "gcList";
            this.gcList.Size = new System.Drawing.Size(1149, 397);
            this.gcList.TabIndex = 0;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvList});
            // 
            // gvList
            // 
            this.gvList.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvList.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvList.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvList.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvList.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvList.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvList.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvList.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvList.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvList.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvList.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvList.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvList.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvList.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvList.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvList.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvList.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvList.Appearance.Empty.Options.UseBackColor = true;
            this.gvList.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvList.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvList.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvList.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvList.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvList.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvList.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvList.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvList.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvList.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvList.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvList.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvList.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvList.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvList.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvList.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvList.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvList.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvList.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvList.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvList.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvList.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvList.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvList.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvList.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvList.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvList.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvList.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvList.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvList.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvList.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvList.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvList.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvList.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvList.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvList.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvList.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvList.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvList.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvList.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvList.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvList.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvList.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvList.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvList.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvList.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvList.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvList.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvList.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvList.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvList.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvList.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvList.Appearance.GroupRow.Options.UseFont = true;
            this.gvList.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvList.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvList.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvList.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvList.Appearance.HeaderPanel.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.gvList.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvList.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvList.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvList.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvList.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvList.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvList.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvList.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvList.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvList.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvList.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvList.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvList.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvList.Appearance.OddRow.Options.UseBackColor = true;
            this.gvList.Appearance.OddRow.Options.UseForeColor = true;
            this.gvList.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvList.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvList.Appearance.Preview.Options.UseBackColor = true;
            this.gvList.Appearance.Preview.Options.UseForeColor = true;
            this.gvList.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvList.Appearance.Row.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.gvList.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvList.Appearance.Row.Options.UseBackColor = true;
            this.gvList.Appearance.Row.Options.UseFont = true;
            this.gvList.Appearance.Row.Options.UseForeColor = true;
            this.gvList.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvList.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvList.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvList.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvList.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvList.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvList.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvList.Appearance.VertLine.Options.UseBackColor = true;
            this.gvList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colF_COM_CODE,
            this.colF_BAUDRATE,
            this.colF_DATABIT,
            this.colF_DEL});
            this.gvList.GridControl = this.gcList;
            this.gvList.Name = "gvList";
            this.gvList.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gvList.OptionsBehavior.ImmediateUpdateRowPosition = false;
            this.gvList.OptionsPrint.AutoWidth = false;
            this.gvList.OptionsView.ColumnAutoWidth = false;
            this.gvList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvList.OptionsView.EnableAppearanceOddRow = true;
            this.gvList.OptionsView.ShowGroupPanel = false;
            this.gvList.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvList_RowClick);
            // 
            // colF_COM_CODE
            // 
            this.colF_COM_CODE.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_COM_CODE.AppearanceCell.Options.UseFont = true;
            this.colF_COM_CODE.AppearanceCell.Options.UseTextOptions = true;
            this.colF_COM_CODE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_COM_CODE.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_COM_CODE.AppearanceHeader.Options.UseFont = true;
            this.colF_COM_CODE.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_COM_CODE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_COM_CODE.Caption = "串口编号";
            this.colF_COM_CODE.FieldName = "F_COM_CODE";
            this.colF_COM_CODE.Name = "colF_COM_CODE";
            this.colF_COM_CODE.OptionsColumn.AllowEdit = false;
            this.colF_COM_CODE.OptionsColumn.AllowFocus = false;
            this.colF_COM_CODE.Visible = true;
            this.colF_COM_CODE.VisibleIndex = 0;
            this.colF_COM_CODE.Width = 118;
            // 
            // colF_BAUDRATE
            // 
            this.colF_BAUDRATE.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_BAUDRATE.AppearanceCell.Options.UseFont = true;
            this.colF_BAUDRATE.AppearanceCell.Options.UseTextOptions = true;
            this.colF_BAUDRATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_BAUDRATE.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_BAUDRATE.AppearanceHeader.Options.UseFont = true;
            this.colF_BAUDRATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_BAUDRATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_BAUDRATE.Caption = "波特率";
            this.colF_BAUDRATE.FieldName = "F_BAUDRATE";
            this.colF_BAUDRATE.Name = "colF_BAUDRATE";
            this.colF_BAUDRATE.OptionsColumn.AllowEdit = false;
            this.colF_BAUDRATE.OptionsColumn.AllowFocus = false;
            this.colF_BAUDRATE.Visible = true;
            this.colF_BAUDRATE.VisibleIndex = 1;
            this.colF_BAUDRATE.Width = 118;
            // 
            // colF_DATABIT
            // 
            this.colF_DATABIT.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_DATABIT.AppearanceCell.Options.UseFont = true;
            this.colF_DATABIT.AppearanceCell.Options.UseTextOptions = true;
            this.colF_DATABIT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_DATABIT.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_DATABIT.AppearanceHeader.Options.UseFont = true;
            this.colF_DATABIT.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_DATABIT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_DATABIT.Caption = "数据位";
            this.colF_DATABIT.FieldName = "F_DATABIT";
            this.colF_DATABIT.Name = "colF_DATABIT";
            this.colF_DATABIT.OptionsColumn.AllowEdit = false;
            this.colF_DATABIT.OptionsColumn.AllowFocus = false;
            this.colF_DATABIT.Visible = true;
            this.colF_DATABIT.VisibleIndex = 2;
            this.colF_DATABIT.Width = 118;
            // 
            // colF_DEL
            // 
            this.colF_DEL.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colF_DEL.AppearanceCell.Options.UseFont = true;
            this.colF_DEL.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colF_DEL.AppearanceHeader.Options.UseFont = true;
            this.colF_DEL.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_DEL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_DEL.Caption = "禁用状态";
            this.colF_DEL.FieldName = "F_DEL";
            this.colF_DEL.Name = "colF_DEL";
            this.colF_DEL.OptionsColumn.AllowEdit = false;
            this.colF_DEL.OptionsColumn.AllowFocus = false;
            this.colF_DEL.Visible = true;
            this.colF_DEL.VisibleIndex = 3;
            // 
            // lblExportOpt
            // 
            this.lblExportOpt.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblExportOpt.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblExportOpt.Location = new System.Drawing.Point(769, -17);
            this.lblExportOpt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblExportOpt.Name = "lblExportOpt";
            this.lblExportOpt.Size = new System.Drawing.Size(70, 14);
            this.lblExportOpt.TabIndex = 37;
            this.lblExportOpt.Text = "导出选项：";
            this.lblExportOpt.Visible = false;
            // 
            // cboExportOpt
            // 
            this.cboExportOpt.EditValue = "明细信息";
            this.cboExportOpt.Location = new System.Drawing.Point(847, -23);
            this.cboExportOpt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboExportOpt.Name = "cboExportOpt";
            this.cboExportOpt.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboExportOpt.Properties.Appearance.Options.UseFont = true;
            this.cboExportOpt.Properties.AppearanceDropDown.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboExportOpt.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboExportOpt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboExportOpt.Properties.Items.AddRange(new object[] {
            "主信息",
            "明细信息"});
            this.cboExportOpt.Properties.PopupSizeable = true;
            this.cboExportOpt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboExportOpt.Size = new System.Drawing.Size(113, 22);
            this.cboExportOpt.TabIndex = 12;
            this.cboExportOpt.Visible = false;
            // 
            // pnlTop
            // 
            this.pnlTop.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlTop.Appearance.Options.UseFont = true;
            this.pnlTop.AppearanceCaption.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlTop.AppearanceCaption.Options.UseFont = true;
            this.pnlTop.Controls.Add(this.lblF_WORKSTATION_ID);
            this.pnlTop.Controls.Add(this.comboBoxEdit1);
            this.pnlTop.Controls.Add(this.baseLabelControl5);
            this.pnlTop.Controls.Add(this.textEdit5);
            this.pnlTop.Controls.Add(this.textEdit6);
            this.pnlTop.Controls.Add(this.lueF_WORKSTATION_ID);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1153, 56);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.Text = "上位机信息";
            // 
            // lblF_WORKSTATION_ID
            // 
            this.lblF_WORKSTATION_ID.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblF_WORKSTATION_ID.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblF_WORKSTATION_ID.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.lblF_WORKSTATION_ID.Location = new System.Drawing.Point(12, 29);
            this.lblF_WORKSTATION_ID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblF_WORKSTATION_ID.Name = "lblF_WORKSTATION_ID";
            this.lblF_WORKSTATION_ID.Size = new System.Drawing.Size(90, 14);
            this.lblF_WORKSTATION_ID.TabIndex = 34;
            this.lblF_WORKSTATION_ID.Text = "上位机编号：";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.EditValue = "";
            this.comboBoxEdit1.Location = new System.Drawing.Point(1025, 56);
            this.comboBoxEdit1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.AppearanceDropDown.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEdit1.Properties.AppearanceDropDown.Options.UseFont = true;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.PopupSizeable = true;
            this.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit1.Size = new System.Drawing.Size(113, 22);
            this.comboBoxEdit1.TabIndex = 16;
            this.comboBoxEdit1.Visible = false;
            // 
            // baseLabelControl5
            // 
            this.baseLabelControl5.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseLabelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.baseLabelControl5.Location = new System.Drawing.Point(1147, 60);
            this.baseLabelControl5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.baseLabelControl5.Name = "baseLabelControl5";
            this.baseLabelControl5.Size = new System.Drawing.Size(56, 14);
            this.baseLabelControl5.TabIndex = 24;
            this.baseLabelControl5.Text = "审批人：";
            this.baseLabelControl5.Visible = false;
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(1205, 28);
            this.textEdit5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textEdit5.Properties.Appearance.Options.UseFont = true;
            this.textEdit5.Size = new System.Drawing.Size(96, 22);
            this.textEdit5.TabIndex = 17;
            this.textEdit5.Visible = false;
            // 
            // textEdit6
            // 
            this.textEdit6.Location = new System.Drawing.Point(1205, 56);
            this.textEdit6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textEdit6.Properties.Appearance.Options.UseFont = true;
            this.textEdit6.Size = new System.Drawing.Size(96, 22);
            this.textEdit6.TabIndex = 18;
            this.textEdit6.Visible = false;
            // 
            // lueF_WORKSTATION_ID
            // 
            this.lueF_WORKSTATION_ID.Location = new System.Drawing.Point(112, 25);
            this.lueF_WORKSTATION_ID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lueF_WORKSTATION_ID.Name = "lueF_WORKSTATION_ID";
            this.lueF_WORKSTATION_ID.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lueF_WORKSTATION_ID.Properties.Appearance.Options.UseFont = true;
            this.lueF_WORKSTATION_ID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueF_WORKSTATION_ID.Properties.NullText = "";
            this.lueF_WORKSTATION_ID.Properties.PopupSizeable = false;
            this.lueF_WORKSTATION_ID.Size = new System.Drawing.Size(131, 22);
            this.lueF_WORKSTATION_ID.TabIndex = 0;
            this.lueF_WORKSTATION_ID.EditValueChanged += new System.EventHandler(this.lueWorkstationId_EditValueChanged);
            // 
            // FrmComSetting
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1153, 708);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmComSetting";
            this.Text = "串口参数设置";
            this.Load += new System.EventHandler(this.FrmPowerBaseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plnButtons)).EndInit();
            this.plnButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcDetail)).EndInit();
            this.lcDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbbF_TYPE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COM_CODE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbF_BAUDRATE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbF_DATABIT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbF_ODDEVENCHECK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbF_STOPBIT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbF_STREAMCONTROL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COM_CODE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_BAUDRATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_DATABIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_ODDEVENCHECK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_STOPBIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_STREAMCONTROL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_TYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            this.pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboExportOpt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueF_WORKSTATION_ID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.PanelControl plnButtons;
        private BaseSimpleButton btnExport;
        private BaseSimpleButton btnDelete;
        private BaseSimpleButton btnSave;
        private DevExpress.XtraEditors.GroupControl pnlDetail;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private BaseSimpleButton btnEnabled;
        private BaseSimpleButton btnDisabled;
        private ComboBoxEdit cbbF_BAUDRATE;
        private GroupControl pnlTop;
        private BaseLabelControl lblF_WORKSTATION_ID;
        private TextEdit txtF_COM_CODE;
        private ComboBoxEdit comboBoxEdit1;
        private BaseLabelControl baseLabelControl5;
        private TextEdit textEdit5;
        private TextEdit textEdit6;
        private ComboBoxEdit cbbF_DATABIT;
        private ComboBoxEdit cbbF_STREAMCONTROL;
        private ComboBoxEdit cbbF_STOPBIT;
        private ComboBoxEdit cbbF_ODDEVENCHECK;
        private GroupControl pnlGrid;
        private BaseGridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvList;
        private DevExpress.XtraGrid.Columns.GridColumn colF_COM_CODE;
        private DevExpress.XtraGrid.Columns.GridColumn colF_BAUDRATE;
        private DevExpress.XtraGrid.Columns.GridColumn colF_DATABIT;
        private DevExpress.XtraGrid.Columns.GridColumn colF_DEL;
        private BaseLabelControl lblExportOpt;
        private ComboBoxEdit cboExportOpt;
        private LookUpEdit lueF_WORKSTATION_ID;
        private DevExpress.XtraLayout.LayoutControl lcDetail;
        private ComboBoxEdit cbbF_TYPE;
        private DevExpress.XtraLayout.LayoutControlGroup lcgDetail;
        private DevExpress.XtraLayout.LayoutControlItem lciF_COM_CODE;
        private DevExpress.XtraLayout.LayoutControlItem lciF_BAUDRATE;
        private DevExpress.XtraLayout.LayoutControlItem lciF_DATABIT;
        private DevExpress.XtraLayout.LayoutControlItem lciF_ODDEVENCHECK;
        private DevExpress.XtraLayout.LayoutControlItem lciF_STOPBIT;
        private DevExpress.XtraLayout.LayoutControlItem lciF_STREAMCONTROL;
        private DevExpress.XtraLayout.LayoutControlItem lciF_TYPE;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;

       
    }
}