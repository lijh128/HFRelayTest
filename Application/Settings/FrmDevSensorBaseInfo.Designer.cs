using DevExpress.XtraEditors;
using RelayTest.Util.Common;

namespace RelayTest.Application.Settings
{

    /// <summary>
    /// 负载柜基础数据
    /// </summary>
    partial class FrmDevSensorBaseInfo
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
            this.plnButtons = new DevExpress.XtraEditors.PanelControl();
            this.btnEnabled = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnDisabled = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnExport = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnDelete = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnSave = new RelayTest.Util.Common.BaseSimpleButton();
            this.pnlDetail = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtF_SENSER_NO = new DevExpress.XtraEditors.TextEdit();
            this.txtF_SENSOR_ACTIONVALUE_FLOOR = new DevExpress.XtraEditors.TextEdit();
            this.txtF_SENSOR_ACTIONVALUE_CEILING = new DevExpress.XtraEditors.TextEdit();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.txtF_SENSOR_TYPE = new DevExpress.XtraEditors.TextEdit();
            this.lueF_DEV_TYPE = new DevExpress.XtraEditors.LookUpEdit();
            this.txtF_SENSOR_ADDRESS = new DevExpress.XtraEditors.TextEdit();
            this.txtF_SENSOR_POSTION = new DevExpress.XtraEditors.TextEdit();
            this.dateF_SENDOR_INSTALL_DATE = new DevExpress.XtraEditors.DateEdit();
            this.txtF_TEMPERATURE_ADJUST_COFF = new DevExpress.XtraEditors.TextEdit();
            this.rdoF_DEL = new DevExpress.XtraEditors.RadioGroup();
            this.txtF_SENSOR_VALUE_CEILING = new DevExpress.XtraEditors.TextEdit();
            this.txtF_SENSOR_VALUE_FLOOR = new DevExpress.XtraEditors.TextEdit();
            this.txtF_SENSOR_NOW_VALUE = new DevExpress.XtraEditors.TextEdit();
            this.txtF_MEMO = new DevExpress.XtraEditors.MemoEdit();
            this.lueF_SENSOR_STATUS = new DevExpress.XtraEditors.LookUpEdit();
            this.lueF_DEV_ID = new DevExpress.XtraEditors.LookUpEdit();
            this.txtF_COM_ADDRESS = new DevExpress.XtraEditors.TextEdit();
            this.txtF_SENSOR_VALUE_TIME = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciF_SENSOR_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_SENSOR_TYPE = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_DEV_TYPE = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_DEV_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_COM_ADDRESS = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_SENSOR_ADDRESS = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_SENSOR_VALUE_CEILING = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_SENSOR_VALUE_FLOOR = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_SENSOR_NOW_VALUE = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_SENSOR_VALUE_TIME = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_MEMO = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_SENSOR_STATUS = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_TEMPERATURE_ADJUST_COFF = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_DEL = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_SENSOR_ACTIONVALUE_CEILING = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_SENSOR_ACTIONVALUE_FLOOR = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciInstallDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciF_SENSOR_POSTION = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_SENSER_NO = new DevExpress.XtraLayout.LayoutControlItem();
            this.cboRoundRule = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboPackRule = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblSPR = new RelayTest.Util.Common.BaseLabelControl();
            this.lblZBR = new RelayTest.Util.Common.BaseLabelControl();
            this.txtZBR = new DevExpress.XtraEditors.TextEdit();
            this.txtSPR = new DevExpress.XtraEditors.TextEdit();
            this.lblExportOpt = new RelayTest.Util.Common.BaseLabelControl();
            this.cboExportOpt = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pnlGrid = new DevExpress.XtraEditors.GroupControl();
            this.gcList = new RelayTest.Util.Common.BaseGridControl();
            this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colF_SENSOR_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_SENSOR_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_DEV_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_DEV_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_COM_ADDRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_SENSOR_ADDRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_SENSER_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_SENSOR_POSTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_SENDOR_INSTALL_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_SENSOR_ALARMVALUE_CEILING = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_SENSOR_ALARMVALUE_FLOOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_SENSOR_ACTIONVALUE_CEILING = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_SENSOR_ACTIONVALUE_FLOOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_SENSOR_NOW_VALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_SENSOR_VALUE_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_SENSOR_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_TEMPERATURE_ADJUST_COFF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_MEMO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_DEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            ((System.ComponentModel.ISupportInitialize)(this.plnButtons)).BeginInit();
            this.plnButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).BeginInit();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_SENSER_NO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_SENSOR_ACTIONVALUE_FLOOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_SENSOR_ACTIONVALUE_CEILING.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_SENSOR_TYPE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueF_DEV_TYPE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_SENSOR_ADDRESS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_SENSOR_POSTION.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateF_SENDOR_INSTALL_DATE.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateF_SENDOR_INSTALL_DATE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_TEMPERATURE_ADJUST_COFF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoF_DEL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_SENSOR_VALUE_CEILING.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_SENSOR_VALUE_FLOOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_SENSOR_NOW_VALUE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_MEMO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueF_SENSOR_STATUS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueF_DEV_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COM_ADDRESS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_SENSOR_VALUE_TIME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SENSOR_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SENSOR_TYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_DEV_TYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_DEV_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COM_ADDRESS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SENSOR_ADDRESS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SENSOR_VALUE_CEILING)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SENSOR_VALUE_FLOOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SENSOR_NOW_VALUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SENSOR_VALUE_TIME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_MEMO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SENSOR_STATUS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_TEMPERATURE_ADJUST_COFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_DEL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SENSOR_ACTIONVALUE_CEILING)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SENSOR_ACTIONVALUE_FLOOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInstallDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SENSOR_POSTION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SENSER_NO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoundRule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPackRule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZBR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboExportOpt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plnButtons
            // 
            this.plnButtons.Controls.Add(this.btnEnabled);
            this.plnButtons.Controls.Add(this.btnDisabled);
            this.plnButtons.Controls.Add(this.btnExport);
            this.plnButtons.Controls.Add(this.btnDelete);
            this.plnButtons.Controls.Add(this.btnSave);
            this.plnButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plnButtons.Location = new System.Drawing.Point(0, 692);
            this.plnButtons.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.plnButtons.Name = "plnButtons";
            this.plnButtons.Size = new System.Drawing.Size(1018, 48);
            this.plnButtons.TabIndex = 2;
            // 
            // btnEnabled
            // 
            this.btnEnabled.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEnabled.Appearance.Options.UseFont = true;
            this.btnEnabled.Location = new System.Drawing.Point(385, 9);
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
            this.btnDisabled.Location = new System.Drawing.Point(474, 9);
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
            this.btnExport.Location = new System.Drawing.Point(654, 9);
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
            this.btnDelete.Location = new System.Drawing.Point(563, 9);
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
            this.btnSave.Location = new System.Drawing.Point(294, 9);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlDetail
            // 
            this.pnlDetail.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlDetail.Appearance.Options.UseFont = true;
            this.pnlDetail.AppearanceCaption.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlDetail.AppearanceCaption.Options.UseFont = true;
            this.pnlDetail.Controls.Add(this.layoutControl1);
            this.pnlDetail.Controls.Add(this.cboRoundRule);
            this.pnlDetail.Controls.Add(this.cboPackRule);
            this.pnlDetail.Controls.Add(this.lblSPR);
            this.pnlDetail.Controls.Add(this.lblZBR);
            this.pnlDetail.Controls.Add(this.txtZBR);
            this.pnlDetail.Controls.Add(this.txtSPR);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetail.Location = new System.Drawing.Point(0, 386);
            this.pnlDetail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(1018, 306);
            this.pnlDetail.TabIndex = 1;
            this.pnlDetail.Text = "参数设置";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtF_SENSER_NO);
            this.layoutControl1.Controls.Add(this.txtF_SENSOR_ACTIONVALUE_FLOOR);
            this.layoutControl1.Controls.Add(this.txtF_SENSOR_ACTIONVALUE_CEILING);
            this.layoutControl1.Controls.Add(this.txtCode);
            this.layoutControl1.Controls.Add(this.txtF_SENSOR_TYPE);
            this.layoutControl1.Controls.Add(this.lueF_DEV_TYPE);
            this.layoutControl1.Controls.Add(this.txtF_SENSOR_ADDRESS);
            this.layoutControl1.Controls.Add(this.txtF_SENSOR_POSTION);
            this.layoutControl1.Controls.Add(this.dateF_SENDOR_INSTALL_DATE);
            this.layoutControl1.Controls.Add(this.txtF_TEMPERATURE_ADJUST_COFF);
            this.layoutControl1.Controls.Add(this.rdoF_DEL);
            this.layoutControl1.Controls.Add(this.txtF_SENSOR_VALUE_CEILING);
            this.layoutControl1.Controls.Add(this.txtF_SENSOR_VALUE_FLOOR);
            this.layoutControl1.Controls.Add(this.txtF_SENSOR_NOW_VALUE);
            this.layoutControl1.Controls.Add(this.txtF_MEMO);
            this.layoutControl1.Controls.Add(this.lueF_SENSOR_STATUS);
            this.layoutControl1.Controls.Add(this.lueF_DEV_ID);
            this.layoutControl1.Controls.Add(this.txtF_COM_ADDRESS);
            this.layoutControl1.Controls.Add(this.txtF_SENSOR_VALUE_TIME);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 22);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(126, 581, 250, 350);
            this.layoutControl1.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1014, 282);
            this.layoutControl1.TabIndex = 25;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtF_SENSER_NO
            // 
            this.txtF_SENSER_NO.Location = new System.Drawing.Point(249, 73);
            this.txtF_SENSER_NO.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_SENSER_NO.Name = "txtF_SENSER_NO";
            this.txtF_SENSER_NO.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_SENSER_NO.Properties.Appearance.Options.UseFont = true;
            this.txtF_SENSER_NO.Properties.Appearance.Options.UseTextOptions = true;
            this.txtF_SENSER_NO.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtF_SENSER_NO.Properties.Mask.EditMask = "d";
            this.txtF_SENSER_NO.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtF_SENSER_NO.Properties.MaxLength = 4;
            this.txtF_SENSER_NO.Size = new System.Drawing.Size(258, 22);
            this.txtF_SENSER_NO.StyleController = this.layoutControl1;
            this.txtF_SENSER_NO.TabIndex = 5;
            // 
            // txtF_SENSOR_ACTIONVALUE_FLOOR
            // 
            this.txtF_SENSOR_ACTIONVALUE_FLOOR.Location = new System.Drawing.Point(656, 145);
            this.txtF_SENSOR_ACTIONVALUE_FLOOR.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_SENSOR_ACTIONVALUE_FLOOR.Name = "txtF_SENSOR_ACTIONVALUE_FLOOR";
            this.txtF_SENSOR_ACTIONVALUE_FLOOR.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_SENSOR_ACTIONVALUE_FLOOR.Properties.Appearance.Options.UseFont = true;
            this.txtF_SENSOR_ACTIONVALUE_FLOOR.Properties.Appearance.Options.UseTextOptions = true;
            this.txtF_SENSOR_ACTIONVALUE_FLOOR.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtF_SENSOR_ACTIONVALUE_FLOOR.Properties.Mask.EditMask = "d";
            this.txtF_SENSOR_ACTIONVALUE_FLOOR.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtF_SENSOR_ACTIONVALUE_FLOOR.Size = new System.Drawing.Size(258, 22);
            this.txtF_SENSOR_ACTIONVALUE_FLOOR.StyleController = this.layoutControl1;
            this.txtF_SENSOR_ACTIONVALUE_FLOOR.TabIndex = 7;
            // 
            // txtF_SENSOR_ACTIONVALUE_CEILING
            // 
            this.txtF_SENSOR_ACTIONVALUE_CEILING.Location = new System.Drawing.Point(249, 145);
            this.txtF_SENSOR_ACTIONVALUE_CEILING.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_SENSOR_ACTIONVALUE_CEILING.Name = "txtF_SENSOR_ACTIONVALUE_CEILING";
            this.txtF_SENSOR_ACTIONVALUE_CEILING.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_SENSOR_ACTIONVALUE_CEILING.Properties.Appearance.Options.UseFont = true;
            this.txtF_SENSOR_ACTIONVALUE_CEILING.Properties.Appearance.Options.UseTextOptions = true;
            this.txtF_SENSOR_ACTIONVALUE_CEILING.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtF_SENSOR_ACTIONVALUE_CEILING.Properties.Mask.EditMask = "d";
            this.txtF_SENSOR_ACTIONVALUE_CEILING.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtF_SENSOR_ACTIONVALUE_CEILING.Size = new System.Drawing.Size(258, 22);
            this.txtF_SENSOR_ACTIONVALUE_CEILING.StyleController = this.layoutControl1;
            this.txtF_SENSOR_ACTIONVALUE_CEILING.TabIndex = 6;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(249, 1);
            this.txtCode.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCode.Properties.Appearance.Options.UseFont = true;
            this.txtCode.Size = new System.Drawing.Size(258, 22);
            this.txtCode.StyleController = this.layoutControl1;
            this.txtCode.TabIndex = 0;
            // 
            // txtF_SENSOR_TYPE
            // 
            this.txtF_SENSOR_TYPE.Location = new System.Drawing.Point(656, 1);
            this.txtF_SENSOR_TYPE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_SENSOR_TYPE.Name = "txtF_SENSOR_TYPE";
            this.txtF_SENSOR_TYPE.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_SENSOR_TYPE.Properties.Appearance.Options.UseFont = true;
            this.txtF_SENSOR_TYPE.Size = new System.Drawing.Size(258, 22);
            this.txtF_SENSOR_TYPE.StyleController = this.layoutControl1;
            this.txtF_SENSOR_TYPE.TabIndex = 1;
            // 
            // lueF_DEV_TYPE
            // 
            this.lueF_DEV_TYPE.Location = new System.Drawing.Point(249, 25);
            this.lueF_DEV_TYPE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lueF_DEV_TYPE.Name = "lueF_DEV_TYPE";
            this.lueF_DEV_TYPE.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lueF_DEV_TYPE.Properties.Appearance.Options.UseFont = true;
            this.lueF_DEV_TYPE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueF_DEV_TYPE.Properties.NullText = "";
            this.lueF_DEV_TYPE.Size = new System.Drawing.Size(258, 22);
            this.lueF_DEV_TYPE.StyleController = this.layoutControl1;
            this.lueF_DEV_TYPE.TabIndex = 2;
            this.lueF_DEV_TYPE.EditValueChanged += new System.EventHandler(this.lueF_DEV_TYPE_EditValueChanged);
            // 
            // txtF_SENSOR_ADDRESS
            // 
            this.txtF_SENSOR_ADDRESS.Location = new System.Drawing.Point(656, 48);
            this.txtF_SENSOR_ADDRESS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_SENSOR_ADDRESS.Name = "txtF_SENSOR_ADDRESS";
            this.txtF_SENSOR_ADDRESS.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_SENSOR_ADDRESS.Properties.Appearance.Options.UseFont = true;
            this.txtF_SENSOR_ADDRESS.Properties.Appearance.Options.UseTextOptions = true;
            this.txtF_SENSOR_ADDRESS.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtF_SENSOR_ADDRESS.Properties.Mask.EditMask = "d";
            this.txtF_SENSOR_ADDRESS.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtF_SENSOR_ADDRESS.Properties.MaxLength = 4;
            this.txtF_SENSOR_ADDRESS.Size = new System.Drawing.Size(258, 22);
            this.txtF_SENSOR_ADDRESS.StyleController = this.layoutControl1;
            this.txtF_SENSOR_ADDRESS.TabIndex = 3;
            // 
            // txtF_SENSOR_POSTION
            // 
            this.txtF_SENSOR_POSTION.Location = new System.Drawing.Point(656, 72);
            this.txtF_SENSOR_POSTION.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_SENSOR_POSTION.Name = "txtF_SENSOR_POSTION";
            this.txtF_SENSOR_POSTION.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_SENSOR_POSTION.Properties.Appearance.Options.UseFont = true;
            this.txtF_SENSOR_POSTION.Properties.Mask.EditMask = "d";
            this.txtF_SENSOR_POSTION.Size = new System.Drawing.Size(258, 22);
            this.txtF_SENSOR_POSTION.StyleController = this.layoutControl1;
            this.txtF_SENSOR_POSTION.TabIndex = 3;
            // 
            // dateF_SENDOR_INSTALL_DATE
            // 
            this.dateF_SENDOR_INSTALL_DATE.EditValue = null;
            this.dateF_SENDOR_INSTALL_DATE.Location = new System.Drawing.Point(249, 97);
            this.dateF_SENDOR_INSTALL_DATE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dateF_SENDOR_INSTALL_DATE.Name = "dateF_SENDOR_INSTALL_DATE";
            this.dateF_SENDOR_INSTALL_DATE.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateF_SENDOR_INSTALL_DATE.Properties.Appearance.Options.UseFont = true;
            this.dateF_SENDOR_INSTALL_DATE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateF_SENDOR_INSTALL_DATE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dateF_SENDOR_INSTALL_DATE.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateF_SENDOR_INSTALL_DATE.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateF_SENDOR_INSTALL_DATE.Size = new System.Drawing.Size(258, 22);
            this.dateF_SENDOR_INSTALL_DATE.StyleController = this.layoutControl1;
            this.dateF_SENDOR_INSTALL_DATE.TabIndex = 4;
            // 
            // txtF_TEMPERATURE_ADJUST_COFF
            // 
            this.txtF_TEMPERATURE_ADJUST_COFF.Location = new System.Drawing.Point(656, 193);
            this.txtF_TEMPERATURE_ADJUST_COFF.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_TEMPERATURE_ADJUST_COFF.Name = "txtF_TEMPERATURE_ADJUST_COFF";
            this.txtF_TEMPERATURE_ADJUST_COFF.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_TEMPERATURE_ADJUST_COFF.Properties.Appearance.Options.UseFont = true;
            this.txtF_TEMPERATURE_ADJUST_COFF.Properties.Appearance.Options.UseTextOptions = true;
            this.txtF_TEMPERATURE_ADJUST_COFF.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtF_TEMPERATURE_ADJUST_COFF.Properties.Mask.EditMask = "d";
            this.txtF_TEMPERATURE_ADJUST_COFF.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtF_TEMPERATURE_ADJUST_COFF.Size = new System.Drawing.Size(258, 22);
            this.txtF_TEMPERATURE_ADJUST_COFF.StyleController = this.layoutControl1;
            this.txtF_TEMPERATURE_ADJUST_COFF.TabIndex = 10;
            // 
            // rdoF_DEL
            // 
            this.rdoF_DEL.Location = new System.Drawing.Point(249, 217);
            this.rdoF_DEL.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdoF_DEL.Name = "rdoF_DEL";
            this.rdoF_DEL.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rdoF_DEL.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoF_DEL.Properties.Appearance.Options.UseBackColor = true;
            this.rdoF_DEL.Properties.Appearance.Options.UseFont = true;
            this.rdoF_DEL.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(new decimal(new int[] {
                            0,
                            0,
                            0,
                            0}), "启用"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(new decimal(new int[] {
                            1,
                            0,
                            0,
                            0}), "禁用")});
            this.rdoF_DEL.Size = new System.Drawing.Size(258, 25);
            this.rdoF_DEL.StyleController = this.layoutControl1;
            this.rdoF_DEL.TabIndex = 7;
            // 
            // txtF_SENSOR_VALUE_CEILING
            // 
            this.txtF_SENSOR_VALUE_CEILING.Location = new System.Drawing.Point(249, 121);
            this.txtF_SENSOR_VALUE_CEILING.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_SENSOR_VALUE_CEILING.Name = "txtF_SENSOR_VALUE_CEILING";
            this.txtF_SENSOR_VALUE_CEILING.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_SENSOR_VALUE_CEILING.Properties.Appearance.Options.UseFont = true;
            this.txtF_SENSOR_VALUE_CEILING.Properties.Appearance.Options.UseTextOptions = true;
            this.txtF_SENSOR_VALUE_CEILING.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtF_SENSOR_VALUE_CEILING.Properties.Mask.EditMask = "d";
            this.txtF_SENSOR_VALUE_CEILING.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtF_SENSOR_VALUE_CEILING.Size = new System.Drawing.Size(258, 22);
            this.txtF_SENSOR_VALUE_CEILING.StyleController = this.layoutControl1;
            this.txtF_SENSOR_VALUE_CEILING.TabIndex = 5;
            // 
            // txtF_SENSOR_VALUE_FLOOR
            // 
            this.txtF_SENSOR_VALUE_FLOOR.Location = new System.Drawing.Point(656, 121);
            this.txtF_SENSOR_VALUE_FLOOR.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_SENSOR_VALUE_FLOOR.Name = "txtF_SENSOR_VALUE_FLOOR";
            this.txtF_SENSOR_VALUE_FLOOR.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_SENSOR_VALUE_FLOOR.Properties.Appearance.Options.UseFont = true;
            this.txtF_SENSOR_VALUE_FLOOR.Properties.Appearance.Options.UseTextOptions = true;
            this.txtF_SENSOR_VALUE_FLOOR.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtF_SENSOR_VALUE_FLOOR.Properties.Mask.EditMask = "d";
            this.txtF_SENSOR_VALUE_FLOOR.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtF_SENSOR_VALUE_FLOOR.Size = new System.Drawing.Size(258, 22);
            this.txtF_SENSOR_VALUE_FLOOR.StyleController = this.layoutControl1;
            this.txtF_SENSOR_VALUE_FLOOR.TabIndex = 6;
            // 
            // txtF_SENSOR_NOW_VALUE
            // 
            this.txtF_SENSOR_NOW_VALUE.Location = new System.Drawing.Point(249, 169);
            this.txtF_SENSOR_NOW_VALUE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_SENSOR_NOW_VALUE.Name = "txtF_SENSOR_NOW_VALUE";
            this.txtF_SENSOR_NOW_VALUE.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_SENSOR_NOW_VALUE.Properties.Appearance.Options.UseFont = true;
            this.txtF_SENSOR_NOW_VALUE.Properties.Appearance.Options.UseTextOptions = true;
            this.txtF_SENSOR_NOW_VALUE.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtF_SENSOR_NOW_VALUE.Properties.Mask.EditMask = "d";
            this.txtF_SENSOR_NOW_VALUE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtF_SENSOR_NOW_VALUE.Size = new System.Drawing.Size(258, 22);
            this.txtF_SENSOR_NOW_VALUE.StyleController = this.layoutControl1;
            this.txtF_SENSOR_NOW_VALUE.TabIndex = 8;
            // 
            // txtF_MEMO
            // 
            this.txtF_MEMO.Location = new System.Drawing.Point(249, 244);
            this.txtF_MEMO.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_MEMO.Name = "txtF_MEMO";
            this.txtF_MEMO.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_MEMO.Properties.Appearance.Options.UseFont = true;
            this.txtF_MEMO.Properties.MaxLength = 250;
            this.txtF_MEMO.Size = new System.Drawing.Size(665, 37);
            this.txtF_MEMO.StyleController = this.layoutControl1;
            this.txtF_MEMO.TabIndex = 12;
            // 
            // lueF_SENSOR_STATUS
            // 
            this.lueF_SENSOR_STATUS.Location = new System.Drawing.Point(249, 193);
            this.lueF_SENSOR_STATUS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lueF_SENSOR_STATUS.Name = "lueF_SENSOR_STATUS";
            this.lueF_SENSOR_STATUS.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.lueF_SENSOR_STATUS.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lueF_SENSOR_STATUS.Properties.Appearance.Options.UseBackColor = true;
            this.lueF_SENSOR_STATUS.Properties.Appearance.Options.UseFont = true;
            this.lueF_SENSOR_STATUS.Properties.AutoHeight = false;
            this.lueF_SENSOR_STATUS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueF_SENSOR_STATUS.Properties.NullText = "";
            this.lueF_SENSOR_STATUS.Size = new System.Drawing.Size(258, 22);
            this.lueF_SENSOR_STATUS.StyleController = this.layoutControl1;
            this.lueF_SENSOR_STATUS.TabIndex = 11;
            // 
            // lueF_DEV_ID
            // 
            this.lueF_DEV_ID.Location = new System.Drawing.Point(656, 25);
            this.lueF_DEV_ID.Name = "lueF_DEV_ID";
            this.lueF_DEV_ID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueF_DEV_ID.Properties.NullText = "";
            this.lueF_DEV_ID.Size = new System.Drawing.Size(258, 21);
            this.lueF_DEV_ID.StyleController = this.layoutControl1;
            this.lueF_DEV_ID.TabIndex = 4;
            // 
            // txtF_COM_ADDRESS
            // 
            this.txtF_COM_ADDRESS.Location = new System.Drawing.Point(249, 49);
            this.txtF_COM_ADDRESS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_COM_ADDRESS.Name = "txtF_COM_ADDRESS";
            this.txtF_COM_ADDRESS.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_COM_ADDRESS.Properties.Appearance.Options.UseFont = true;
            this.txtF_COM_ADDRESS.Properties.Mask.EditMask = "(com|COM)([1-9]|[1-9][0-9])";
            this.txtF_COM_ADDRESS.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtF_COM_ADDRESS.Size = new System.Drawing.Size(258, 22);
            this.txtF_COM_ADDRESS.StyleController = this.layoutControl1;
            this.txtF_COM_ADDRESS.TabIndex = 3;
            // 
            // txtF_SENSOR_VALUE_TIME
            // 
            this.txtF_SENSOR_VALUE_TIME.Location = new System.Drawing.Point(656, 169);
            this.txtF_SENSOR_VALUE_TIME.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_SENSOR_VALUE_TIME.Name = "txtF_SENSOR_VALUE_TIME";
            this.txtF_SENSOR_VALUE_TIME.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_SENSOR_VALUE_TIME.Properties.Appearance.Options.UseFont = true;
            this.txtF_SENSOR_VALUE_TIME.Size = new System.Drawing.Size(258, 22);
            this.txtF_SENSOR_VALUE_TIME.StyleController = this.layoutControl1;
            this.txtF_SENSOR_VALUE_TIME.TabIndex = 9;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciF_SENSOR_ID,
            this.lciF_SENSOR_TYPE,
            this.lciF_DEV_TYPE,
            this.lciF_DEV_ID,
            this.lciF_COM_ADDRESS,
            this.lciF_SENSOR_ADDRESS,
            this.lciF_SENSOR_VALUE_CEILING,
            this.lciF_SENSOR_VALUE_FLOOR,
            this.lciF_SENSOR_NOW_VALUE,
            this.lciF_SENSOR_VALUE_TIME,
            this.lciF_MEMO,
            this.lciF_SENSOR_STATUS,
            this.lciF_TEMPERATURE_ADJUST_COFF,
            this.lciF_DEL,
            this.lciF_SENSOR_ACTIONVALUE_CEILING,
            this.lciF_SENSOR_ACTIONVALUE_FLOOR,
            this.lciInstallDate,
            this.emptySpaceItem1,
            this.lciF_SENSOR_POSTION,
            this.lciF_SENSER_NO});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(100, 100, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1014, 282);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciF_SENSOR_ID
            // 
            this.lciF_SENSOR_ID.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lciF_SENSOR_ID.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_SENSOR_ID.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_SENSOR_ID.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_SENSOR_ID.Control = this.txtCode;
            this.lciF_SENSOR_ID.CustomizationFormText = "layoutControlItem1";
            this.lciF_SENSOR_ID.Location = new System.Drawing.Point(0, 0);
            this.lciF_SENSOR_ID.Name = "lciF_SENSOR_ID";
            this.lciF_SENSOR_ID.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_SENSOR_ID.Size = new System.Drawing.Size(407, 24);
            this.lciF_SENSOR_ID.Text = "温度传感器编号：";
            this.lciF_SENSOR_ID.TextSize = new System.Drawing.Size(140, 14);
            // 
            // lciF_SENSOR_TYPE
            // 
            this.lciF_SENSOR_TYPE.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lciF_SENSOR_TYPE.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_SENSOR_TYPE.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_SENSOR_TYPE.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_SENSOR_TYPE.Control = this.txtF_SENSOR_TYPE;
            this.lciF_SENSOR_TYPE.CustomizationFormText = "layoutControlItem2";
            this.lciF_SENSOR_TYPE.Location = new System.Drawing.Point(407, 0);
            this.lciF_SENSOR_TYPE.Name = "lciF_SENSOR_TYPE";
            this.lciF_SENSOR_TYPE.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_SENSOR_TYPE.Size = new System.Drawing.Size(407, 24);
            this.lciF_SENSOR_TYPE.Text = "温度传感器型号：";
            this.lciF_SENSOR_TYPE.TextSize = new System.Drawing.Size(140, 14);
            // 
            // lciF_DEV_TYPE
            // 
            this.lciF_DEV_TYPE.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_DEV_TYPE.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_DEV_TYPE.Control = this.lueF_DEV_TYPE;
            this.lciF_DEV_TYPE.CustomizationFormText = "layoutControlItem3";
            this.lciF_DEV_TYPE.Location = new System.Drawing.Point(0, 24);
            this.lciF_DEV_TYPE.Name = "lciF_DEV_TYPE";
            this.lciF_DEV_TYPE.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_DEV_TYPE.Size = new System.Drawing.Size(407, 24);
            this.lciF_DEV_TYPE.Text = "安装设备类型：";
            this.lciF_DEV_TYPE.TextSize = new System.Drawing.Size(140, 14);
            // 
            // lciF_DEV_ID
            // 
            this.lciF_DEV_ID.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_DEV_ID.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_DEV_ID.Control = this.lueF_DEV_ID;
            this.lciF_DEV_ID.CustomizationFormText = "layoutControlItem4";
            this.lciF_DEV_ID.Location = new System.Drawing.Point(407, 24);
            this.lciF_DEV_ID.Name = "lciF_DEV_ID";
            this.lciF_DEV_ID.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_DEV_ID.Size = new System.Drawing.Size(407, 23);
            this.lciF_DEV_ID.Text = "安装设备编号：";
            this.lciF_DEV_ID.TextSize = new System.Drawing.Size(140, 14);
            // 
            // lciF_COM_ADDRESS
            // 
            this.lciF_COM_ADDRESS.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lciF_COM_ADDRESS.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_COM_ADDRESS.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_COM_ADDRESS.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_COM_ADDRESS.Control = this.txtF_COM_ADDRESS;
            this.lciF_COM_ADDRESS.CustomizationFormText = "layoutControlItem5";
            this.lciF_COM_ADDRESS.Location = new System.Drawing.Point(0, 48);
            this.lciF_COM_ADDRESS.Name = "lciF_COM_ADDRESS";
            this.lciF_COM_ADDRESS.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_COM_ADDRESS.Size = new System.Drawing.Size(407, 24);
            this.lciF_COM_ADDRESS.Text = "通讯端口：";
            this.lciF_COM_ADDRESS.TextSize = new System.Drawing.Size(140, 14);
            // 
            // lciF_SENSOR_ADDRESS
            // 
            this.lciF_SENSOR_ADDRESS.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lciF_SENSOR_ADDRESS.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_SENSOR_ADDRESS.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_SENSOR_ADDRESS.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_SENSOR_ADDRESS.Control = this.txtF_SENSOR_ADDRESS;
            this.lciF_SENSOR_ADDRESS.CustomizationFormText = "layoutControlItem6";
            this.lciF_SENSOR_ADDRESS.Location = new System.Drawing.Point(407, 47);
            this.lciF_SENSOR_ADDRESS.Name = "lciF_SENSOR_ADDRESS";
            this.lciF_SENSOR_ADDRESS.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_SENSOR_ADDRESS.Size = new System.Drawing.Size(407, 24);
            this.lciF_SENSOR_ADDRESS.Text = "通讯地址：";
            this.lciF_SENSOR_ADDRESS.TextSize = new System.Drawing.Size(140, 14);
            // 
            // lciF_SENSOR_VALUE_CEILING
            // 
            this.lciF_SENSOR_VALUE_CEILING.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_SENSOR_VALUE_CEILING.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_SENSOR_VALUE_CEILING.Control = this.txtF_SENSOR_VALUE_CEILING;
            this.lciF_SENSOR_VALUE_CEILING.CustomizationFormText = "layoutControlItem9";
            this.lciF_SENSOR_VALUE_CEILING.Location = new System.Drawing.Point(0, 120);
            this.lciF_SENSOR_VALUE_CEILING.Name = "lciF_SENSOR_VALUE_CEILING";
            this.lciF_SENSOR_VALUE_CEILING.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_SENSOR_VALUE_CEILING.Size = new System.Drawing.Size(407, 24);
            this.lciF_SENSOR_VALUE_CEILING.Text = "温度报警上限值：";
            this.lciF_SENSOR_VALUE_CEILING.TextSize = new System.Drawing.Size(140, 14);
            // 
            // lciF_SENSOR_VALUE_FLOOR
            // 
            this.lciF_SENSOR_VALUE_FLOOR.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_SENSOR_VALUE_FLOOR.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_SENSOR_VALUE_FLOOR.Control = this.txtF_SENSOR_VALUE_FLOOR;
            this.lciF_SENSOR_VALUE_FLOOR.CustomizationFormText = "layoutControlItem10";
            this.lciF_SENSOR_VALUE_FLOOR.Location = new System.Drawing.Point(407, 120);
            this.lciF_SENSOR_VALUE_FLOOR.Name = "lciF_SENSOR_VALUE_FLOOR";
            this.lciF_SENSOR_VALUE_FLOOR.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_SENSOR_VALUE_FLOOR.Size = new System.Drawing.Size(407, 24);
            this.lciF_SENSOR_VALUE_FLOOR.Text = "温度报警下限值：";
            this.lciF_SENSOR_VALUE_FLOOR.TextSize = new System.Drawing.Size(140, 14);
            // 
            // lciF_SENSOR_NOW_VALUE
            // 
            this.lciF_SENSOR_NOW_VALUE.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_SENSOR_NOW_VALUE.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_SENSOR_NOW_VALUE.Control = this.txtF_SENSOR_NOW_VALUE;
            this.lciF_SENSOR_NOW_VALUE.CustomizationFormText = "layoutControlItem11";
            this.lciF_SENSOR_NOW_VALUE.Location = new System.Drawing.Point(0, 168);
            this.lciF_SENSOR_NOW_VALUE.Name = "lciF_SENSOR_NOW_VALUE";
            this.lciF_SENSOR_NOW_VALUE.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_SENSOR_NOW_VALUE.Size = new System.Drawing.Size(407, 24);
            this.lciF_SENSOR_NOW_VALUE.Text = "当前温度值：";
            this.lciF_SENSOR_NOW_VALUE.TextSize = new System.Drawing.Size(140, 14);
            // 
            // lciF_SENSOR_VALUE_TIME
            // 
            this.lciF_SENSOR_VALUE_TIME.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_SENSOR_VALUE_TIME.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_SENSOR_VALUE_TIME.Control = this.txtF_SENSOR_VALUE_TIME;
            this.lciF_SENSOR_VALUE_TIME.CustomizationFormText = "layoutControlItem12";
            this.lciF_SENSOR_VALUE_TIME.Location = new System.Drawing.Point(407, 168);
            this.lciF_SENSOR_VALUE_TIME.Name = "lciF_SENSOR_VALUE_TIME";
            this.lciF_SENSOR_VALUE_TIME.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_SENSOR_VALUE_TIME.Size = new System.Drawing.Size(407, 24);
            this.lciF_SENSOR_VALUE_TIME.Text = "采集时间：";
            this.lciF_SENSOR_VALUE_TIME.TextSize = new System.Drawing.Size(140, 14);
            // 
            // lciF_MEMO
            // 
            this.lciF_MEMO.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_MEMO.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_MEMO.Control = this.txtF_MEMO;
            this.lciF_MEMO.CustomizationFormText = "layoutControlItem15";
            this.lciF_MEMO.Location = new System.Drawing.Point(0, 243);
            this.lciF_MEMO.Name = "lciF_MEMO";
            this.lciF_MEMO.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_MEMO.Size = new System.Drawing.Size(814, 39);
            this.lciF_MEMO.Text = "备注：";
            this.lciF_MEMO.TextSize = new System.Drawing.Size(140, 14);
            // 
            // lciF_SENSOR_STATUS
            // 
            this.lciF_SENSOR_STATUS.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_SENSOR_STATUS.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_SENSOR_STATUS.Control = this.lueF_SENSOR_STATUS;
            this.lciF_SENSOR_STATUS.CustomizationFormText = "layoutControlItem13";
            this.lciF_SENSOR_STATUS.Location = new System.Drawing.Point(0, 192);
            this.lciF_SENSOR_STATUS.Name = "lciF_SENSOR_STATUS";
            this.lciF_SENSOR_STATUS.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_SENSOR_STATUS.Size = new System.Drawing.Size(407, 24);
            this.lciF_SENSOR_STATUS.Text = "工作状态：";
            this.lciF_SENSOR_STATUS.TextSize = new System.Drawing.Size(140, 14);
            // 
            // lciF_TEMPERATURE_ADJUST_COFF
            // 
            this.lciF_TEMPERATURE_ADJUST_COFF.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_TEMPERATURE_ADJUST_COFF.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_TEMPERATURE_ADJUST_COFF.Control = this.txtF_TEMPERATURE_ADJUST_COFF;
            this.lciF_TEMPERATURE_ADJUST_COFF.CustomizationFormText = "layoutControlItem14";
            this.lciF_TEMPERATURE_ADJUST_COFF.Location = new System.Drawing.Point(407, 192);
            this.lciF_TEMPERATURE_ADJUST_COFF.Name = "lciF_TEMPERATURE_ADJUST_COFF";
            this.lciF_TEMPERATURE_ADJUST_COFF.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_TEMPERATURE_ADJUST_COFF.Size = new System.Drawing.Size(407, 51);
            this.lciF_TEMPERATURE_ADJUST_COFF.Text = "温度校正系数：";
            this.lciF_TEMPERATURE_ADJUST_COFF.TextSize = new System.Drawing.Size(140, 14);
            // 
            // lciF_DEL
            // 
            this.lciF_DEL.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_DEL.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_DEL.Control = this.rdoF_DEL;
            this.lciF_DEL.CustomizationFormText = "layoutControlItem16";
            this.lciF_DEL.Location = new System.Drawing.Point(0, 216);
            this.lciF_DEL.Name = "lciF_DEL";
            this.lciF_DEL.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_DEL.Size = new System.Drawing.Size(407, 27);
            this.lciF_DEL.Text = "禁用状态：";
            this.lciF_DEL.TextSize = new System.Drawing.Size(140, 14);
            // 
            // lciF_SENSOR_ACTIONVALUE_CEILING
            // 
            this.lciF_SENSOR_ACTIONVALUE_CEILING.Control = this.txtF_SENSOR_ACTIONVALUE_CEILING;
            this.lciF_SENSOR_ACTIONVALUE_CEILING.CustomizationFormText = "温度超限动作上限值：";
            this.lciF_SENSOR_ACTIONVALUE_CEILING.Location = new System.Drawing.Point(0, 144);
            this.lciF_SENSOR_ACTIONVALUE_CEILING.Name = "lciF_SENSOR_ACTIONVALUE_CEILING";
            this.lciF_SENSOR_ACTIONVALUE_CEILING.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_SENSOR_ACTIONVALUE_CEILING.Size = new System.Drawing.Size(407, 24);
            this.lciF_SENSOR_ACTIONVALUE_CEILING.Text = "温度超限动作上限值：";
            this.lciF_SENSOR_ACTIONVALUE_CEILING.TextSize = new System.Drawing.Size(140, 14);
            // 
            // lciF_SENSOR_ACTIONVALUE_FLOOR
            // 
            this.lciF_SENSOR_ACTIONVALUE_FLOOR.Control = this.txtF_SENSOR_ACTIONVALUE_FLOOR;
            this.lciF_SENSOR_ACTIONVALUE_FLOOR.CustomizationFormText = "温度超限动作下限值：";
            this.lciF_SENSOR_ACTIONVALUE_FLOOR.Location = new System.Drawing.Point(407, 144);
            this.lciF_SENSOR_ACTIONVALUE_FLOOR.Name = "lciF_SENSOR_ACTIONVALUE_FLOOR";
            this.lciF_SENSOR_ACTIONVALUE_FLOOR.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_SENSOR_ACTIONVALUE_FLOOR.Size = new System.Drawing.Size(407, 24);
            this.lciF_SENSOR_ACTIONVALUE_FLOOR.Text = "温度超限动作下限值：";
            this.lciF_SENSOR_ACTIONVALUE_FLOOR.TextSize = new System.Drawing.Size(140, 14);
            // 
            // lciInstallDate
            // 
            this.lciInstallDate.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciInstallDate.AppearanceItemCaption.Options.UseFont = true;
            this.lciInstallDate.Control = this.dateF_SENDOR_INSTALL_DATE;
            this.lciInstallDate.CustomizationFormText = "layoutControlItem8";
            this.lciInstallDate.Location = new System.Drawing.Point(0, 96);
            this.lciInstallDate.Name = "lciInstallDate";
            this.lciInstallDate.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciInstallDate.Size = new System.Drawing.Size(407, 24);
            this.lciInstallDate.Text = "温度传感器安装时间：";
            this.lciInstallDate.TextSize = new System.Drawing.Size(140, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(407, 95);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(407, 25);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciF_SENSOR_POSTION
            // 
            this.lciF_SENSOR_POSTION.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_SENSOR_POSTION.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_SENSOR_POSTION.Control = this.txtF_SENSOR_POSTION;
            this.lciF_SENSOR_POSTION.CustomizationFormText = "layoutControlItem7";
            this.lciF_SENSOR_POSTION.Location = new System.Drawing.Point(407, 71);
            this.lciF_SENSOR_POSTION.Name = "lciF_SENSOR_POSTION";
            this.lciF_SENSOR_POSTION.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_SENSOR_POSTION.Size = new System.Drawing.Size(407, 24);
            this.lciF_SENSOR_POSTION.Text = "温度传感器位置：";
            this.lciF_SENSOR_POSTION.TextSize = new System.Drawing.Size(140, 14);
            // 
            // lciF_SENSER_NO
            // 
            this.lciF_SENSER_NO.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_SENSER_NO.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_SENSER_NO.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_SENSER_NO.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_SENSER_NO.Control = this.txtF_SENSER_NO;
            this.lciF_SENSER_NO.CustomizationFormText = "热敏电阻接入序号：";
            this.lciF_SENSER_NO.Location = new System.Drawing.Point(0, 72);
            this.lciF_SENSER_NO.Name = "lciF_SENSER_NO";
            this.lciF_SENSER_NO.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_SENSER_NO.Size = new System.Drawing.Size(407, 24);
            this.lciF_SENSER_NO.Text = "热敏电阻接入序号：";
            this.lciF_SENSER_NO.TextSize = new System.Drawing.Size(140, 14);
            // 
            // cboRoundRule
            // 
            this.cboRoundRule.EditValue = "";
            this.cboRoundRule.Location = new System.Drawing.Point(1025, 56);
            this.cboRoundRule.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboRoundRule.Name = "cboRoundRule";
            this.cboRoundRule.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboRoundRule.Properties.Appearance.Options.UseFont = true;
            this.cboRoundRule.Properties.AppearanceDropDown.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoundRule.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboRoundRule.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboRoundRule.Properties.PopupSizeable = true;
            this.cboRoundRule.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboRoundRule.Size = new System.Drawing.Size(113, 22);
            this.cboRoundRule.TabIndex = 16;
            this.cboRoundRule.Visible = false;
            // 
            // cboPackRule
            // 
            this.cboPackRule.EditValue = "";
            this.cboPackRule.Location = new System.Drawing.Point(1025, 28);
            this.cboPackRule.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboPackRule.Name = "cboPackRule";
            this.cboPackRule.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboPackRule.Properties.Appearance.Options.UseFont = true;
            this.cboPackRule.Properties.AppearanceDropDown.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPackRule.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cboPackRule.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboPackRule.Properties.PopupSizeable = true;
            this.cboPackRule.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboPackRule.Size = new System.Drawing.Size(113, 22);
            this.cboPackRule.TabIndex = 15;
            this.cboPackRule.Visible = false;
            // 
            // lblSPR
            // 
            this.lblSPR.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSPR.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblSPR.Location = new System.Drawing.Point(1147, 60);
            this.lblSPR.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblSPR.Name = "lblSPR";
            this.lblSPR.Size = new System.Drawing.Size(56, 14);
            this.lblSPR.TabIndex = 24;
            this.lblSPR.Text = "审批人：";
            this.lblSPR.Visible = false;
            // 
            // lblZBR
            // 
            this.lblZBR.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblZBR.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblZBR.Location = new System.Drawing.Point(1147, 32);
            this.lblZBR.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblZBR.Name = "lblZBR";
            this.lblZBR.Size = new System.Drawing.Size(56, 14);
            this.lblZBR.TabIndex = 22;
            this.lblZBR.Text = "制表人：";
            this.lblZBR.Visible = false;
            // 
            // txtZBR
            // 
            this.txtZBR.Location = new System.Drawing.Point(1205, 28);
            this.txtZBR.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtZBR.Name = "txtZBR";
            this.txtZBR.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtZBR.Properties.Appearance.Options.UseFont = true;
            this.txtZBR.Size = new System.Drawing.Size(96, 22);
            this.txtZBR.TabIndex = 17;
            this.txtZBR.Visible = false;
            // 
            // txtSPR
            // 
            this.txtSPR.Location = new System.Drawing.Point(1205, 56);
            this.txtSPR.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSPR.Name = "txtSPR";
            this.txtSPR.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSPR.Properties.Appearance.Options.UseFont = true;
            this.txtSPR.Size = new System.Drawing.Size(96, 22);
            this.txtSPR.TabIndex = 18;
            this.txtSPR.Visible = false;
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
            // pnlGrid
            // 
            this.pnlGrid.AppearanceCaption.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlGrid.AppearanceCaption.Options.UseFont = true;
            this.pnlGrid.Controls.Add(this.gcList);
            this.pnlGrid.Controls.Add(this.lblExportOpt);
            this.pnlGrid.Controls.Add(this.cboExportOpt);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlGrid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1018, 386);
            this.pnlGrid.TabIndex = 0;
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
            this.gcList.Size = new System.Drawing.Size(1014, 362);
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
            this.colF_SENSOR_ID,
            this.colF_SENSOR_TYPE,
            this.colF_DEV_TYPE,
            this.colF_DEV_ID,
            this.colF_COM_ADDRESS,
            this.colF_SENSOR_ADDRESS,
            this.colF_SENSER_NO,
            this.colF_SENSOR_POSTION,
            this.colF_SENDOR_INSTALL_DATE,
            this.colF_SENSOR_ALARMVALUE_CEILING,
            this.colF_SENSOR_ALARMVALUE_FLOOR,
            this.colF_SENSOR_ACTIONVALUE_CEILING,
            this.colF_SENSOR_ACTIONVALUE_FLOOR,
            this.colF_SENSOR_NOW_VALUE,
            this.colF_SENSOR_VALUE_TIME,
            this.colF_SENSOR_STATUS,
            this.colF_TEMPERATURE_ADJUST_COFF,
            this.colF_MEMO,
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
            this.gvList.Click += new System.EventHandler(this.gvList_Click);
            // 
            // colF_SENSOR_ID
            // 
            this.colF_SENSOR_ID.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SENSOR_ID.AppearanceCell.Options.UseFont = true;
            this.colF_SENSOR_ID.AppearanceCell.Options.UseTextOptions = true;
            this.colF_SENSOR_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_SENSOR_ID.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SENSOR_ID.AppearanceHeader.Options.UseFont = true;
            this.colF_SENSOR_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_SENSOR_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_SENSOR_ID.Caption = "温度传感器编号";
            this.colF_SENSOR_ID.FieldName = "F_SENSOR_ID";
            this.colF_SENSOR_ID.Name = "colF_SENSOR_ID";
            this.colF_SENSOR_ID.OptionsColumn.AllowEdit = false;
            this.colF_SENSOR_ID.OptionsColumn.AllowFocus = false;
            this.colF_SENSOR_ID.Visible = true;
            this.colF_SENSOR_ID.VisibleIndex = 0;
            this.colF_SENSOR_ID.Width = 118;
            // 
            // colF_SENSOR_TYPE
            // 
            this.colF_SENSOR_TYPE.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SENSOR_TYPE.AppearanceCell.Options.UseFont = true;
            this.colF_SENSOR_TYPE.AppearanceCell.Options.UseTextOptions = true;
            this.colF_SENSOR_TYPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_SENSOR_TYPE.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SENSOR_TYPE.AppearanceHeader.Options.UseFont = true;
            this.colF_SENSOR_TYPE.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_SENSOR_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_SENSOR_TYPE.Caption = "温度传感器型号";
            this.colF_SENSOR_TYPE.FieldName = "F_SENSOR_TYPE";
            this.colF_SENSOR_TYPE.Name = "colF_SENSOR_TYPE";
            this.colF_SENSOR_TYPE.OptionsColumn.AllowEdit = false;
            this.colF_SENSOR_TYPE.OptionsColumn.AllowFocus = false;
            this.colF_SENSOR_TYPE.Visible = true;
            this.colF_SENSOR_TYPE.VisibleIndex = 1;
            this.colF_SENSOR_TYPE.Width = 159;
            // 
            // colF_DEV_TYPE
            // 
            this.colF_DEV_TYPE.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_DEV_TYPE.AppearanceCell.Options.UseFont = true;
            this.colF_DEV_TYPE.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_DEV_TYPE.AppearanceHeader.Options.UseFont = true;
            this.colF_DEV_TYPE.Caption = "安装设备类型";
            this.colF_DEV_TYPE.FieldName = "F_DEV_TYPE";
            this.colF_DEV_TYPE.Name = "colF_DEV_TYPE";
            this.colF_DEV_TYPE.OptionsColumn.AllowEdit = false;
            this.colF_DEV_TYPE.OptionsColumn.AllowFocus = false;
            this.colF_DEV_TYPE.Visible = true;
            this.colF_DEV_TYPE.VisibleIndex = 2;
            this.colF_DEV_TYPE.Width = 101;
            // 
            // colF_DEV_ID
            // 
            this.colF_DEV_ID.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_DEV_ID.AppearanceCell.Options.UseFont = true;
            this.colF_DEV_ID.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_DEV_ID.AppearanceHeader.Options.UseFont = true;
            this.colF_DEV_ID.Caption = "安装设备编号";
            this.colF_DEV_ID.FieldName = "F_DEV_ID";
            this.colF_DEV_ID.Name = "colF_DEV_ID";
            this.colF_DEV_ID.OptionsColumn.AllowEdit = false;
            this.colF_DEV_ID.OptionsColumn.AllowFocus = false;
            this.colF_DEV_ID.Visible = true;
            this.colF_DEV_ID.VisibleIndex = 3;
            this.colF_DEV_ID.Width = 106;
            // 
            // colF_COM_ADDRESS
            // 
            this.colF_COM_ADDRESS.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_COM_ADDRESS.AppearanceCell.Options.UseFont = true;
            this.colF_COM_ADDRESS.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_COM_ADDRESS.AppearanceHeader.Options.UseFont = true;
            this.colF_COM_ADDRESS.Caption = "通信端口";
            this.colF_COM_ADDRESS.FieldName = "F_COM_ADDRESS";
            this.colF_COM_ADDRESS.Name = "colF_COM_ADDRESS";
            this.colF_COM_ADDRESS.OptionsColumn.AllowEdit = false;
            this.colF_COM_ADDRESS.OptionsColumn.AllowFocus = false;
            this.colF_COM_ADDRESS.Visible = true;
            this.colF_COM_ADDRESS.VisibleIndex = 4;
            // 
            // colF_SENSOR_ADDRESS
            // 
            this.colF_SENSOR_ADDRESS.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SENSOR_ADDRESS.AppearanceCell.Options.UseFont = true;
            this.colF_SENSOR_ADDRESS.AppearanceCell.Options.UseTextOptions = true;
            this.colF_SENSOR_ADDRESS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colF_SENSOR_ADDRESS.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SENSOR_ADDRESS.AppearanceHeader.Options.UseFont = true;
            this.colF_SENSOR_ADDRESS.Caption = "通讯地址";
            this.colF_SENSOR_ADDRESS.FieldName = "F_SENSOR_ADDRESS";
            this.colF_SENSOR_ADDRESS.Name = "colF_SENSOR_ADDRESS";
            this.colF_SENSOR_ADDRESS.OptionsColumn.AllowEdit = false;
            this.colF_SENSOR_ADDRESS.OptionsColumn.AllowFocus = false;
            this.colF_SENSOR_ADDRESS.Visible = true;
            this.colF_SENSOR_ADDRESS.VisibleIndex = 5;
            // 
            // colF_SENSER_NO
            // 
            this.colF_SENSER_NO.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SENSER_NO.AppearanceCell.Options.UseFont = true;
            this.colF_SENSER_NO.AppearanceCell.Options.UseTextOptions = true;
            this.colF_SENSER_NO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colF_SENSER_NO.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SENSER_NO.AppearanceHeader.Options.UseFont = true;
            this.colF_SENSER_NO.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_SENSER_NO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_SENSER_NO.Caption = "热敏电阻接入序号";
            this.colF_SENSER_NO.FieldName = "F_SENSER_NO";
            this.colF_SENSER_NO.Name = "colF_SENSER_NO";
            this.colF_SENSER_NO.OptionsColumn.AllowEdit = false;
            this.colF_SENSER_NO.OptionsColumn.AllowFocus = false;
            this.colF_SENSER_NO.Visible = true;
            this.colF_SENSER_NO.VisibleIndex = 6;
            this.colF_SENSER_NO.Width = 124;
            // 
            // colF_SENSOR_POSTION
            // 
            this.colF_SENSOR_POSTION.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SENSOR_POSTION.AppearanceCell.Options.UseFont = true;
            this.colF_SENSOR_POSTION.AppearanceCell.Options.UseTextOptions = true;
            this.colF_SENSOR_POSTION.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colF_SENSOR_POSTION.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SENSOR_POSTION.AppearanceHeader.Options.UseFont = true;
            this.colF_SENSOR_POSTION.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_SENSOR_POSTION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_SENSOR_POSTION.Caption = "温度传感器位置";
            this.colF_SENSOR_POSTION.FieldName = "F_SENSOR_POSTION";
            this.colF_SENSOR_POSTION.Name = "colF_SENSOR_POSTION";
            this.colF_SENSOR_POSTION.OptionsColumn.AllowEdit = false;
            this.colF_SENSOR_POSTION.OptionsColumn.AllowFocus = false;
            this.colF_SENSOR_POSTION.Visible = true;
            this.colF_SENSOR_POSTION.VisibleIndex = 7;
            this.colF_SENSOR_POSTION.Width = 171;
            // 
            // colF_SENDOR_INSTALL_DATE
            // 
            this.colF_SENDOR_INSTALL_DATE.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SENDOR_INSTALL_DATE.AppearanceCell.Options.UseFont = true;
            this.colF_SENDOR_INSTALL_DATE.AppearanceCell.Options.UseTextOptions = true;
            this.colF_SENDOR_INSTALL_DATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colF_SENDOR_INSTALL_DATE.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SENDOR_INSTALL_DATE.AppearanceHeader.Options.UseFont = true;
            this.colF_SENDOR_INSTALL_DATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_SENDOR_INSTALL_DATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_SENDOR_INSTALL_DATE.Caption = "安装时间";
            this.colF_SENDOR_INSTALL_DATE.FieldName = "F_SENDOR_INSTALL_DATE";
            this.colF_SENDOR_INSTALL_DATE.Name = "colF_SENDOR_INSTALL_DATE";
            this.colF_SENDOR_INSTALL_DATE.OptionsColumn.AllowEdit = false;
            this.colF_SENDOR_INSTALL_DATE.OptionsColumn.AllowFocus = false;
            this.colF_SENDOR_INSTALL_DATE.Visible = true;
            this.colF_SENDOR_INSTALL_DATE.VisibleIndex = 8;
            this.colF_SENDOR_INSTALL_DATE.Width = 145;
            // 
            // colF_SENSOR_ALARMVALUE_CEILING
            // 
            this.colF_SENSOR_ALARMVALUE_CEILING.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SENSOR_ALARMVALUE_CEILING.AppearanceCell.Options.UseFont = true;
            this.colF_SENSOR_ALARMVALUE_CEILING.AppearanceCell.Options.UseTextOptions = true;
            this.colF_SENSOR_ALARMVALUE_CEILING.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colF_SENSOR_ALARMVALUE_CEILING.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SENSOR_ALARMVALUE_CEILING.AppearanceHeader.Options.UseFont = true;
            this.colF_SENSOR_ALARMVALUE_CEILING.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_SENSOR_ALARMVALUE_CEILING.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_SENSOR_ALARMVALUE_CEILING.Caption = "温度报警上限值";
            this.colF_SENSOR_ALARMVALUE_CEILING.FieldName = "F_SENSOR_ALARMVALUE_CEILING";
            this.colF_SENSOR_ALARMVALUE_CEILING.Name = "colF_SENSOR_ALARMVALUE_CEILING";
            this.colF_SENSOR_ALARMVALUE_CEILING.OptionsColumn.AllowEdit = false;
            this.colF_SENSOR_ALARMVALUE_CEILING.OptionsColumn.AllowFocus = false;
            this.colF_SENSOR_ALARMVALUE_CEILING.Visible = true;
            this.colF_SENSOR_ALARMVALUE_CEILING.VisibleIndex = 10;
            // 
            // colF_SENSOR_ALARMVALUE_FLOOR
            // 
            this.colF_SENSOR_ALARMVALUE_FLOOR.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SENSOR_ALARMVALUE_FLOOR.AppearanceCell.Options.UseFont = true;
            this.colF_SENSOR_ALARMVALUE_FLOOR.AppearanceCell.Options.UseTextOptions = true;
            this.colF_SENSOR_ALARMVALUE_FLOOR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colF_SENSOR_ALARMVALUE_FLOOR.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SENSOR_ALARMVALUE_FLOOR.AppearanceHeader.Options.UseFont = true;
            this.colF_SENSOR_ALARMVALUE_FLOOR.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_SENSOR_ALARMVALUE_FLOOR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_SENSOR_ALARMVALUE_FLOOR.Caption = "温度报警下限值";
            this.colF_SENSOR_ALARMVALUE_FLOOR.FieldName = "F_SENSOR_ALARMVALUE_FLOOR";
            this.colF_SENSOR_ALARMVALUE_FLOOR.Name = "colF_SENSOR_ALARMVALUE_FLOOR";
            this.colF_SENSOR_ALARMVALUE_FLOOR.OptionsColumn.AllowEdit = false;
            this.colF_SENSOR_ALARMVALUE_FLOOR.OptionsColumn.AllowFocus = false;
            this.colF_SENSOR_ALARMVALUE_FLOOR.Visible = true;
            this.colF_SENSOR_ALARMVALUE_FLOOR.VisibleIndex = 9;
            this.colF_SENSOR_ALARMVALUE_FLOOR.Width = 120;
            // 
            // colF_SENSOR_ACTIONVALUE_CEILING
            // 
            this.colF_SENSOR_ACTIONVALUE_CEILING.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SENSOR_ACTIONVALUE_CEILING.AppearanceCell.Options.UseFont = true;
            this.colF_SENSOR_ACTIONVALUE_CEILING.AppearanceCell.Options.UseTextOptions = true;
            this.colF_SENSOR_ACTIONVALUE_CEILING.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colF_SENSOR_ACTIONVALUE_CEILING.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SENSOR_ACTIONVALUE_CEILING.AppearanceHeader.Options.UseFont = true;
            this.colF_SENSOR_ACTIONVALUE_CEILING.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_SENSOR_ACTIONVALUE_CEILING.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_SENSOR_ACTIONVALUE_CEILING.Caption = "温度超限动作上限值";
            this.colF_SENSOR_ACTIONVALUE_CEILING.FieldName = "F_SENSOR_ACTIONVALUE_CEILING";
            this.colF_SENSOR_ACTIONVALUE_CEILING.Name = "colF_SENSOR_ACTIONVALUE_CEILING";
            this.colF_SENSOR_ACTIONVALUE_CEILING.OptionsColumn.AllowEdit = false;
            this.colF_SENSOR_ACTIONVALUE_CEILING.OptionsColumn.AllowFocus = false;
            this.colF_SENSOR_ACTIONVALUE_CEILING.Visible = true;
            this.colF_SENSOR_ACTIONVALUE_CEILING.VisibleIndex = 11;
            // 
            // colF_SENSOR_ACTIONVALUE_FLOOR
            // 
            this.colF_SENSOR_ACTIONVALUE_FLOOR.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SENSOR_ACTIONVALUE_FLOOR.AppearanceCell.Options.UseFont = true;
            this.colF_SENSOR_ACTIONVALUE_FLOOR.AppearanceCell.Options.UseTextOptions = true;
            this.colF_SENSOR_ACTIONVALUE_FLOOR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colF_SENSOR_ACTIONVALUE_FLOOR.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SENSOR_ACTIONVALUE_FLOOR.AppearanceHeader.Options.UseFont = true;
            this.colF_SENSOR_ACTIONVALUE_FLOOR.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_SENSOR_ACTIONVALUE_FLOOR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_SENSOR_ACTIONVALUE_FLOOR.Caption = "温度超限动作下限值";
            this.colF_SENSOR_ACTIONVALUE_FLOOR.FieldName = "F_SENSOR_ACTIONVALUE_FLOOR";
            this.colF_SENSOR_ACTIONVALUE_FLOOR.Name = "colF_SENSOR_ACTIONVALUE_FLOOR";
            this.colF_SENSOR_ACTIONVALUE_FLOOR.OptionsColumn.AllowEdit = false;
            this.colF_SENSOR_ACTIONVALUE_FLOOR.OptionsColumn.AllowFocus = false;
            this.colF_SENSOR_ACTIONVALUE_FLOOR.Visible = true;
            this.colF_SENSOR_ACTIONVALUE_FLOOR.VisibleIndex = 12;
            // 
            // colF_SENSOR_NOW_VALUE
            // 
            this.colF_SENSOR_NOW_VALUE.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SENSOR_NOW_VALUE.AppearanceCell.Options.UseFont = true;
            this.colF_SENSOR_NOW_VALUE.AppearanceCell.Options.UseTextOptions = true;
            this.colF_SENSOR_NOW_VALUE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colF_SENSOR_NOW_VALUE.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SENSOR_NOW_VALUE.AppearanceHeader.Options.UseFont = true;
            this.colF_SENSOR_NOW_VALUE.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_SENSOR_NOW_VALUE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_SENSOR_NOW_VALUE.Caption = "当前温度值";
            this.colF_SENSOR_NOW_VALUE.FieldName = "F_SENSOR_NOW_VALUE";
            this.colF_SENSOR_NOW_VALUE.Name = "colF_SENSOR_NOW_VALUE";
            this.colF_SENSOR_NOW_VALUE.OptionsColumn.AllowEdit = false;
            this.colF_SENSOR_NOW_VALUE.OptionsColumn.AllowFocus = false;
            this.colF_SENSOR_NOW_VALUE.Visible = true;
            this.colF_SENSOR_NOW_VALUE.VisibleIndex = 13;
            this.colF_SENSOR_NOW_VALUE.Width = 141;
            // 
            // colF_SENSOR_VALUE_TIME
            // 
            this.colF_SENSOR_VALUE_TIME.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SENSOR_VALUE_TIME.AppearanceCell.Options.UseFont = true;
            this.colF_SENSOR_VALUE_TIME.AppearanceCell.Options.UseTextOptions = true;
            this.colF_SENSOR_VALUE_TIME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colF_SENSOR_VALUE_TIME.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SENSOR_VALUE_TIME.AppearanceHeader.Options.UseFont = true;
            this.colF_SENSOR_VALUE_TIME.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_SENSOR_VALUE_TIME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_SENSOR_VALUE_TIME.Caption = "采集时间";
            this.colF_SENSOR_VALUE_TIME.FieldName = "F_SENSOR_VALUE_TIME";
            this.colF_SENSOR_VALUE_TIME.Name = "colF_SENSOR_VALUE_TIME";
            this.colF_SENSOR_VALUE_TIME.OptionsColumn.AllowEdit = false;
            this.colF_SENSOR_VALUE_TIME.OptionsColumn.AllowFocus = false;
            this.colF_SENSOR_VALUE_TIME.Visible = true;
            this.colF_SENSOR_VALUE_TIME.VisibleIndex = 14;
            // 
            // colF_SENSOR_STATUS
            // 
            this.colF_SENSOR_STATUS.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SENSOR_STATUS.AppearanceCell.Options.UseFont = true;
            this.colF_SENSOR_STATUS.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SENSOR_STATUS.AppearanceHeader.Options.UseFont = true;
            this.colF_SENSOR_STATUS.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_SENSOR_STATUS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_SENSOR_STATUS.Caption = "工作状态";
            this.colF_SENSOR_STATUS.FieldName = "F_SENSOR_STATUS";
            this.colF_SENSOR_STATUS.Name = "colF_SENSOR_STATUS";
            this.colF_SENSOR_STATUS.OptionsColumn.AllowEdit = false;
            this.colF_SENSOR_STATUS.OptionsColumn.AllowFocus = false;
            this.colF_SENSOR_STATUS.Visible = true;
            this.colF_SENSOR_STATUS.VisibleIndex = 15;
            // 
            // colF_TEMPERATURE_ADJUST_COFF
            // 
            this.colF_TEMPERATURE_ADJUST_COFF.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_TEMPERATURE_ADJUST_COFF.AppearanceCell.Options.UseFont = true;
            this.colF_TEMPERATURE_ADJUST_COFF.AppearanceCell.Options.UseTextOptions = true;
            this.colF_TEMPERATURE_ADJUST_COFF.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colF_TEMPERATURE_ADJUST_COFF.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_TEMPERATURE_ADJUST_COFF.AppearanceHeader.Options.UseFont = true;
            this.colF_TEMPERATURE_ADJUST_COFF.Caption = "温度校正系数";
            this.colF_TEMPERATURE_ADJUST_COFF.FieldName = "F_TEMPERATURE_ADJUST_COFF";
            this.colF_TEMPERATURE_ADJUST_COFF.Name = "colF_TEMPERATURE_ADJUST_COFF";
            this.colF_TEMPERATURE_ADJUST_COFF.OptionsColumn.AllowEdit = false;
            this.colF_TEMPERATURE_ADJUST_COFF.OptionsColumn.AllowFocus = false;
            this.colF_TEMPERATURE_ADJUST_COFF.Visible = true;
            this.colF_TEMPERATURE_ADJUST_COFF.VisibleIndex = 16;
            this.colF_TEMPERATURE_ADJUST_COFF.Width = 129;
            // 
            // colF_MEMO
            // 
            this.colF_MEMO.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_MEMO.AppearanceCell.Options.UseFont = true;
            this.colF_MEMO.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_MEMO.AppearanceHeader.Options.UseFont = true;
            this.colF_MEMO.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_MEMO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_MEMO.Caption = "备注";
            this.colF_MEMO.FieldName = "F_MEMO";
            this.colF_MEMO.Name = "colF_MEMO";
            this.colF_MEMO.OptionsColumn.AllowEdit = false;
            this.colF_MEMO.OptionsColumn.AllowFocus = false;
            this.colF_MEMO.Visible = true;
            this.colF_MEMO.VisibleIndex = 17;
            this.colF_MEMO.Width = 111;
            // 
            // colF_DEL
            // 
            this.colF_DEL.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_DEL.AppearanceCell.Options.UseFont = true;
            this.colF_DEL.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_DEL.AppearanceHeader.Options.UseFont = true;
            this.colF_DEL.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_DEL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_DEL.Caption = "禁用状态";
            this.colF_DEL.FieldName = "F_DEL";
            this.colF_DEL.Name = "colF_DEL";
            this.colF_DEL.OptionsColumn.AllowEdit = false;
            this.colF_DEL.OptionsColumn.AllowFocus = false;
            this.colF_DEL.Visible = true;
            this.colF_DEL.VisibleIndex = 18;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.pnlGrid);
            this.xtraScrollableControl1.Controls.Add(this.pnlDetail);
            this.xtraScrollableControl1.Controls.Add(this.plnButtons);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1018, 740);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // FrmDevSensorBaseInfo
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1018, 740);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmDevSensorBaseInfo";
            this.Text = "温度传感器数据维护";
            this.Load += new System.EventHandler(this.FrmPowerBaseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plnButtons)).EndInit();
            this.plnButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtF_SENSER_NO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_SENSOR_ACTIONVALUE_FLOOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_SENSOR_ACTIONVALUE_CEILING.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_SENSOR_TYPE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueF_DEV_TYPE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_SENSOR_ADDRESS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_SENSOR_POSTION.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateF_SENDOR_INSTALL_DATE.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateF_SENDOR_INSTALL_DATE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_TEMPERATURE_ADJUST_COFF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoF_DEL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_SENSOR_VALUE_CEILING.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_SENSOR_VALUE_FLOOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_SENSOR_NOW_VALUE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_MEMO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueF_SENSOR_STATUS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueF_DEV_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COM_ADDRESS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_SENSOR_VALUE_TIME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SENSOR_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SENSOR_TYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_DEV_TYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_DEV_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COM_ADDRESS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SENSOR_ADDRESS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SENSOR_VALUE_CEILING)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SENSOR_VALUE_FLOOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SENSOR_NOW_VALUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SENSOR_VALUE_TIME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_MEMO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SENSOR_STATUS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_TEMPERATURE_ADJUST_COFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_DEL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SENSOR_ACTIONVALUE_CEILING)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SENSOR_ACTIONVALUE_FLOOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInstallDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SENSOR_POSTION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SENSER_NO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoundRule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPackRule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZBR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboExportOpt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            this.pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private DevExpress.XtraEditors.PanelControl plnButtons;
        private BaseSimpleButton btnExport;
        private BaseSimpleButton btnDelete;
        private BaseSimpleButton btnSave;
        private DevExpress.XtraEditors.GroupControl pnlDetail;
        private BaseLabelControl lblExportOpt;
        private DevExpress.XtraEditors.ComboBoxEdit cboExportOpt;
        private DevExpress.XtraEditors.ComboBoxEdit cboRoundRule;
        private DevExpress.XtraEditors.ComboBoxEdit cboPackRule;
        private BaseLabelControl lblSPR;
        private BaseLabelControl lblZBR;
        private DevExpress.XtraEditors.GroupControl pnlGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gvList;
        private DevExpress.XtraGrid.Columns.GridColumn colF_SENSOR_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colF_SENSOR_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colF_SENSOR_POSTION;
        private DevExpress.XtraGrid.Columns.GridColumn colF_SENSOR_ALARMVALUE_FLOOR;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.TextEdit txtZBR;
        private DevExpress.XtraEditors.TextEdit txtSPR;
        private BaseGridControl gcList;
        private TextEdit txtF_SENSOR_TYPE;
        private TextEdit txtCode;
        private RadioGroup rdoF_DEL;
        private BaseSimpleButton btnEnabled;
        private BaseSimpleButton btnDisabled;
        private TextEdit txtF_SENSOR_POSTION;
        private DevExpress.XtraGrid.Columns.GridColumn colF_SENDOR_INSTALL_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colF_SENSOR_ALARMVALUE_CEILING;
        private DevExpress.XtraGrid.Columns.GridColumn colF_SENSOR_NOW_VALUE;
        private DevExpress.XtraGrid.Columns.GridColumn colF_SENSOR_VALUE_TIME;
        private DevExpress.XtraGrid.Columns.GridColumn colF_SENSOR_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colF_MEMO;
        private DevExpress.XtraGrid.Columns.GridColumn colF_DEL;
        private TextEdit txtF_TEMPERATURE_ADJUST_COFF;
        private TextEdit txtF_SENSOR_NOW_VALUE;
        private TextEdit txtF_SENSOR_VALUE_FLOOR;
        private TextEdit txtF_SENSOR_VALUE_CEILING;
        private DateEdit dateF_SENDOR_INSTALL_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colF_TEMPERATURE_ADJUST_COFF;
        private LookUpEdit lueF_DEV_TYPE;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private TextEdit txtF_SENSOR_ADDRESS;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem lciF_SENSOR_ID;
        private DevExpress.XtraLayout.LayoutControlItem lciF_SENSOR_TYPE;
        private DevExpress.XtraLayout.LayoutControlItem lciF_DEV_TYPE;
        private DevExpress.XtraLayout.LayoutControlItem lciF_DEV_ID;
        private DevExpress.XtraLayout.LayoutControlItem lciF_COM_ADDRESS;
        private DevExpress.XtraLayout.LayoutControlItem lciF_SENSOR_ADDRESS;
        private DevExpress.XtraLayout.LayoutControlItem lciF_SENSOR_POSTION;
        private DevExpress.XtraLayout.LayoutControlItem lciInstallDate;
        private DevExpress.XtraLayout.LayoutControlItem lciF_SENSOR_VALUE_CEILING;
        private MemoEdit txtF_MEMO;
        private DevExpress.XtraLayout.LayoutControlItem lciF_SENSOR_VALUE_FLOOR;
        private DevExpress.XtraLayout.LayoutControlItem lciF_SENSOR_NOW_VALUE;
        private DevExpress.XtraLayout.LayoutControlItem lciF_SENSOR_VALUE_TIME;
        private DevExpress.XtraLayout.LayoutControlItem lciF_MEMO;
        private LookUpEdit lueF_SENSOR_STATUS;
        private DevExpress.XtraLayout.LayoutControlItem lciF_SENSOR_STATUS;
        private DevExpress.XtraLayout.LayoutControlItem lciF_TEMPERATURE_ADJUST_COFF;
        private DevExpress.XtraLayout.LayoutControlItem lciF_DEL;
        private DevExpress.XtraGrid.Columns.GridColumn colF_DEV_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colF_DEV_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colF_COM_ADDRESS;
        private DevExpress.XtraGrid.Columns.GridColumn colF_SENSOR_ADDRESS;
        private LookUpEdit lueF_DEV_ID;
        private TextEdit txtF_COM_ADDRESS;
        private TextEdit txtF_SENSOR_ACTIONVALUE_FLOOR;
        private TextEdit txtF_SENSOR_ACTIONVALUE_CEILING;
        private DevExpress.XtraLayout.LayoutControlItem lciF_SENSOR_ACTIONVALUE_CEILING;
        private DevExpress.XtraLayout.LayoutControlItem lciF_SENSOR_ACTIONVALUE_FLOOR;
        private DevExpress.XtraGrid.Columns.GridColumn colF_SENSOR_ACTIONVALUE_CEILING;
        private DevExpress.XtraGrid.Columns.GridColumn colF_SENSOR_ACTIONVALUE_FLOOR;
        private TextEdit txtF_SENSER_NO;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciF_SENSER_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colF_SENSER_NO;
        private TextEdit txtF_SENSOR_VALUE_TIME;

    }
}