using DevExpress.XtraEditors;
using RelayTest.Util.Common;

namespace RelayTest.Application.Settings
{

    /// <summary>
    /// 供电柜基本数据
    /// </summary>
    partial class FrmDevPowerBaseInfo
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
            this.btnEdiSwitch = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnEnabled = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnDisabled = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnClose = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnDelete = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnSave = new RelayTest.Util.Common.BaseSimpleButton();
            this.pnlDetail = new DevExpress.XtraEditors.GroupControl();
            this.lcDetail = new DevExpress.XtraLayout.LayoutControl();
            this.txtF_POWER_CALIBRATION = new DevExpress.XtraEditors.TextEdit();
            this.txtF_POWER_ID = new DevExpress.XtraEditors.TextEdit();
            this.txtF_POWER_NAME = new DevExpress.XtraEditors.TextEdit();
            this.rdoF_DEL = new DevExpress.XtraEditors.RadioGroup();
            this.txtF_POWER_DESCRIPTION = new DevExpress.XtraEditors.MemoEdit();
            this.txtSwitchNum = new DevExpress.XtraEditors.TextEdit();
            this.lcgDetail = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciF_POWER_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_POWER_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSwitchNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_POWER_DESCRIPTION = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_POWER_CALIBRATION = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciF_DEL = new DevExpress.XtraLayout.LayoutControlItem();
            this.cboRoundRule = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboPackRule = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblSPR = new RelayTest.Util.Common.BaseLabelControl();
            this.lblZBR = new RelayTest.Util.Common.BaseLabelControl();
            this.txtZBR = new DevExpress.XtraEditors.TextEdit();
            this.txtSPR = new DevExpress.XtraEditors.TextEdit();
            this.lblExportOpt = new RelayTest.Util.Common.BaseLabelControl();
            this.cboExportOpt = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pnlGrid = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gcList = new RelayTest.Util.Common.BaseGridControl();
            this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colF_POWER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_POWER_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_POWER_CALIBRATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_POWER_DESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_DEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gcPowerSwitchInfo = new RelayTest.Util.Common.BaseGridControl();
            this.gvPowerSwitchInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colF_POWER_SWITCH_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_COM_ADDRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_POWER_SWITCH_ADDRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_HOLDREG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_POWER_SWITCH_CALIBRATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_POWER_SWITCH_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_POWER_SWITCH_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_LOAD_CAPACITY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_ALARM_LIFEDURANCE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_ALARM_TIMEDURANCE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_SWITCH_TIMES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSwitchF_DEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtPosition = new DevExpress.XtraEditors.XtraScrollableControl();
            ((System.ComponentModel.ISupportInitialize)(this.plnButtons)).BeginInit();
            this.plnButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).BeginInit();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcDetail)).BeginInit();
            this.lcDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_POWER_CALIBRATION.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_POWER_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_POWER_NAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoF_DEL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_POWER_DESCRIPTION.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSwitchNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_POWER_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_POWER_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSwitchNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_POWER_DESCRIPTION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_POWER_CALIBRATION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_DEL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoundRule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPackRule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZBR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboExportOpt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPowerSwitchInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPowerSwitchInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.txtPosition.SuspendLayout();
            this.SuspendLayout();
            // 
            // plnButtons
            // 
            this.plnButtons.Controls.Add(this.btnEdiSwitch);
            this.plnButtons.Controls.Add(this.btnEnabled);
            this.plnButtons.Controls.Add(this.btnDisabled);
            this.plnButtons.Controls.Add(this.btnClose);
            this.plnButtons.Controls.Add(this.btnDelete);
            this.plnButtons.Controls.Add(this.btnSave);
            this.plnButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plnButtons.Location = new System.Drawing.Point(0, 681);
            this.plnButtons.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.plnButtons.Name = "plnButtons";
            this.plnButtons.Size = new System.Drawing.Size(1018, 50);
            this.plnButtons.TabIndex = 0;
            // 
            // btnEdiSwitch
            // 
            this.btnEdiSwitch.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEdiSwitch.Appearance.Options.UseFont = true;
            this.btnEdiSwitch.Location = new System.Drawing.Point(604, 9);
            this.btnEdiSwitch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEdiSwitch.Name = "btnEdiSwitch";
            this.btnEdiSwitch.Size = new System.Drawing.Size(80, 29);
            this.btnEdiSwitch.TabIndex = 5;
            this.btnEdiSwitch.Text = "开关信息";
            this.btnEdiSwitch.Click += new System.EventHandler(this.btnEdiSwitch_Click);
            // 
            // btnEnabled
            // 
            this.btnEnabled.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEnabled.Appearance.Options.UseFont = true;
            this.btnEnabled.Location = new System.Drawing.Point(334, 11);
            this.btnEnabled.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEnabled.Name = "btnEnabled";
            this.btnEnabled.Size = new System.Drawing.Size(80, 29);
            this.btnEnabled.TabIndex = 1;
            this.btnEnabled.Text = "启用";
            this.btnEnabled.Click += new System.EventHandler(this.btnEnabled_Click);
            // 
            // btnDisabled
            // 
            this.btnDisabled.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDisabled.Appearance.Options.UseFont = true;
            this.btnDisabled.Location = new System.Drawing.Point(425, 11);
            this.btnDisabled.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDisabled.Name = "btnDisabled";
            this.btnDisabled.Size = new System.Drawing.Size(80, 29);
            this.btnDisabled.TabIndex = 2;
            this.btnDisabled.Text = "禁用";
            this.btnDisabled.Click += new System.EventHandler(this.btnDisabled_Click);
            // 
            // btnClose
            // 
            this.btnClose.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Location = new System.Drawing.Point(694, 9);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 29);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "导出";
            this.btnClose.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(514, 9);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 29);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(245, 11);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 29);
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
            this.pnlDetail.Controls.Add(this.cboRoundRule);
            this.pnlDetail.Controls.Add(this.cboPackRule);
            this.pnlDetail.Controls.Add(this.lblSPR);
            this.pnlDetail.Controls.Add(this.lblZBR);
            this.pnlDetail.Controls.Add(this.txtZBR);
            this.pnlDetail.Controls.Add(this.txtSPR);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetail.Location = new System.Drawing.Point(0, 480);
            this.pnlDetail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(1018, 201);
            this.pnlDetail.TabIndex = 1;
            this.pnlDetail.Text = "参数设置";
            // 
            // lcDetail
            // 
            this.lcDetail.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.Color.Black;
            this.lcDetail.Appearance.DisabledLayoutItem.Options.UseForeColor = true;
            this.lcDetail.Controls.Add(this.txtF_POWER_CALIBRATION);
            this.lcDetail.Controls.Add(this.txtF_POWER_ID);
            this.lcDetail.Controls.Add(this.txtF_POWER_NAME);
            this.lcDetail.Controls.Add(this.rdoF_DEL);
            this.lcDetail.Controls.Add(this.txtF_POWER_DESCRIPTION);
            this.lcDetail.Controls.Add(this.txtSwitchNum);
            this.lcDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcDetail.Location = new System.Drawing.Point(2, 22);
            this.lcDetail.Name = "lcDetail";
            this.lcDetail.Root = this.lcgDetail;
            this.lcDetail.Size = new System.Drawing.Size(1014, 177);
            this.lcDetail.TabIndex = 25;
            this.lcDetail.Text = "layoutControl1";
            // 
            // txtF_POWER_CALIBRATION
            // 
            this.txtF_POWER_CALIBRATION.Location = new System.Drawing.Point(179, 33);
            this.txtF_POWER_CALIBRATION.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_POWER_CALIBRATION.Name = "txtF_POWER_CALIBRATION";
            this.txtF_POWER_CALIBRATION.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_POWER_CALIBRATION.Properties.Appearance.Options.UseFont = true;
            this.txtF_POWER_CALIBRATION.Properties.AutoHeight = false;
            this.txtF_POWER_CALIBRATION.Size = new System.Drawing.Size(323, 22);
            this.txtF_POWER_CALIBRATION.StyleController = this.lcDetail;
            this.txtF_POWER_CALIBRATION.TabIndex = 4;
            // 
            // txtF_POWER_ID
            // 
            this.txtF_POWER_ID.Location = new System.Drawing.Point(179, 7);
            this.txtF_POWER_ID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_POWER_ID.Name = "txtF_POWER_ID";
            this.txtF_POWER_ID.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_POWER_ID.Properties.Appearance.Options.UseFont = true;
            this.txtF_POWER_ID.Size = new System.Drawing.Size(323, 22);
            this.txtF_POWER_ID.StyleController = this.lcDetail;
            this.txtF_POWER_ID.TabIndex = 0;
            this.txtF_POWER_ID.EditValueChanged += new System.EventHandler(this.txtPowerId_EditValueChanged);
            // 
            // txtF_POWER_NAME
            // 
            this.txtF_POWER_NAME.Location = new System.Drawing.Point(586, 7);
            this.txtF_POWER_NAME.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_POWER_NAME.Name = "txtF_POWER_NAME";
            this.txtF_POWER_NAME.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_POWER_NAME.Properties.Appearance.Options.UseFont = true;
            this.txtF_POWER_NAME.Size = new System.Drawing.Size(323, 22);
            this.txtF_POWER_NAME.StyleController = this.lcDetail;
            this.txtF_POWER_NAME.TabIndex = 1;
            // 
            // rdoF_DEL
            // 
            this.rdoF_DEL.Location = new System.Drawing.Point(586, 59);
            this.rdoF_DEL.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdoF_DEL.Name = "rdoF_DEL";
            this.rdoF_DEL.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rdoF_DEL.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoF_DEL.Properties.Appearance.Options.UseBackColor = true;
            this.rdoF_DEL.Properties.Appearance.Options.UseFont = true;
            this.rdoF_DEL.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "启用"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "禁用")});
            this.rdoF_DEL.Size = new System.Drawing.Size(323, 25);
            this.rdoF_DEL.StyleController = this.lcDetail;
            this.rdoF_DEL.TabIndex = 4;
            // 
            // txtF_POWER_DESCRIPTION
            // 
            this.txtF_POWER_DESCRIPTION.Location = new System.Drawing.Point(179, 88);
            this.txtF_POWER_DESCRIPTION.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_POWER_DESCRIPTION.Name = "txtF_POWER_DESCRIPTION";
            this.txtF_POWER_DESCRIPTION.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_POWER_DESCRIPTION.Properties.Appearance.Options.UseFont = true;
            this.txtF_POWER_DESCRIPTION.Properties.MaxLength = 250;
            this.txtF_POWER_DESCRIPTION.Size = new System.Drawing.Size(730, 82);
            this.txtF_POWER_DESCRIPTION.StyleController = this.lcDetail;
            this.txtF_POWER_DESCRIPTION.TabIndex = 5;
            // 
            // txtSwitchNum
            // 
            this.txtSwitchNum.Enabled = false;
            this.txtSwitchNum.Location = new System.Drawing.Point(179, 59);
            this.txtSwitchNum.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSwitchNum.Name = "txtSwitchNum";
            this.txtSwitchNum.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSwitchNum.Properties.Appearance.Options.UseFont = true;
            this.txtSwitchNum.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSwitchNum.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSwitchNum.Properties.Mask.EditMask = "d";
            this.txtSwitchNum.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSwitchNum.Size = new System.Drawing.Size(323, 22);
            this.txtSwitchNum.StyleController = this.lcDetail;
            this.txtSwitchNum.TabIndex = 3;
            // 
            // lcgDetail
            // 
            this.lcgDetail.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcgDetail.AppearanceItemCaption.Options.UseFont = true;
            this.lcgDetail.CustomizationFormText = "layoutControlGroup1";
            this.lcgDetail.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgDetail.GroupBordersVisible = false;
            this.lcgDetail.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciF_POWER_ID,
            this.lciF_POWER_NAME,
            this.lciSwitchNumber,
            this.lciF_POWER_DESCRIPTION,
            this.lciF_POWER_CALIBRATION,
            this.emptySpaceItem1,
            this.lciF_DEL});
            this.lcgDetail.Location = new System.Drawing.Point(0, 0);
            this.lcgDetail.Name = "lcgDetail";
            this.lcgDetail.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgDetail.Size = new System.Drawing.Size(1014, 177);
            this.lcgDetail.Spacing = new DevExpress.XtraLayout.Utils.Padding(100, 100, 5, 5);
            this.lcgDetail.Text = "lcgDetail";
            this.lcgDetail.TextVisible = false;
            // 
            // lciF_POWER_ID
            // 
            this.lciF_POWER_ID.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_POWER_ID.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_POWER_ID.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_POWER_ID.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_POWER_ID.Control = this.txtF_POWER_ID;
            this.lciF_POWER_ID.CustomizationFormText = "编号：";
            this.lciF_POWER_ID.Location = new System.Drawing.Point(0, 0);
            this.lciF_POWER_ID.Name = "lciF_POWER_ID";
            this.lciF_POWER_ID.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.lciF_POWER_ID.Size = new System.Drawing.Size(407, 26);
            this.lciF_POWER_ID.Text = "编号：";
            this.lciF_POWER_ID.TextSize = new System.Drawing.Size(70, 14);
            // 
            // lciF_POWER_NAME
            // 
            this.lciF_POWER_NAME.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lciF_POWER_NAME.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_POWER_NAME.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_POWER_NAME.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_POWER_NAME.Control = this.txtF_POWER_NAME;
            this.lciF_POWER_NAME.CustomizationFormText = "名称:";
            this.lciF_POWER_NAME.Location = new System.Drawing.Point(407, 0);
            this.lciF_POWER_NAME.Name = "lciF_POWER_NAME";
            this.lciF_POWER_NAME.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.lciF_POWER_NAME.Size = new System.Drawing.Size(407, 26);
            this.lciF_POWER_NAME.Text = "名称:";
            this.lciF_POWER_NAME.TextSize = new System.Drawing.Size(70, 14);
            // 
            // lciSwitchNumber
            // 
            this.lciSwitchNumber.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciSwitchNumber.AppearanceItemCaption.Options.UseFont = true;
            this.lciSwitchNumber.Control = this.txtSwitchNum;
            this.lciSwitchNumber.CustomizationFormText = "开关数量：";
            this.lciSwitchNumber.Location = new System.Drawing.Point(0, 52);
            this.lciSwitchNumber.Name = "lciSwitchNumber";
            this.lciSwitchNumber.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.lciSwitchNumber.Size = new System.Drawing.Size(407, 29);
            this.lciSwitchNumber.Text = "开关数量：";
            this.lciSwitchNumber.TextSize = new System.Drawing.Size(70, 14);
            // 
            // lciF_POWER_DESCRIPTION
            // 
            this.lciF_POWER_DESCRIPTION.Control = this.txtF_POWER_DESCRIPTION;
            this.lciF_POWER_DESCRIPTION.CustomizationFormText = "备注：";
            this.lciF_POWER_DESCRIPTION.Location = new System.Drawing.Point(0, 81);
            this.lciF_POWER_DESCRIPTION.Name = "lciF_POWER_DESCRIPTION";
            this.lciF_POWER_DESCRIPTION.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.lciF_POWER_DESCRIPTION.Size = new System.Drawing.Size(814, 86);
            this.lciF_POWER_DESCRIPTION.Text = "备注：";
            this.lciF_POWER_DESCRIPTION.TextSize = new System.Drawing.Size(70, 14);
            // 
            // lciF_POWER_CALIBRATION
            // 
            this.lciF_POWER_CALIBRATION.Control = this.txtF_POWER_CALIBRATION;
            this.lciF_POWER_CALIBRATION.CustomizationFormText = "校准编号：";
            this.lciF_POWER_CALIBRATION.Location = new System.Drawing.Point(0, 26);
            this.lciF_POWER_CALIBRATION.Name = "lciF_POWER_CALIBRATION";
            this.lciF_POWER_CALIBRATION.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.lciF_POWER_CALIBRATION.Size = new System.Drawing.Size(407, 26);
            this.lciF_POWER_CALIBRATION.Text = "校准编号";
            this.lciF_POWER_CALIBRATION.TextSize = new System.Drawing.Size(70, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(407, 26);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(407, 26);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciF_DEL
            // 
            this.lciF_DEL.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_DEL.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_DEL.Control = this.rdoF_DEL;
            this.lciF_DEL.CustomizationFormText = "禁用状态：";
            this.lciF_DEL.Location = new System.Drawing.Point(407, 52);
            this.lciF_DEL.Name = "lciF_DEL";
            this.lciF_DEL.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.lciF_DEL.Size = new System.Drawing.Size(407, 29);
            this.lciF_DEL.Text = "禁用状态：";
            this.lciF_DEL.TextSize = new System.Drawing.Size(70, 14);
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
            this.cboExportOpt.Location = new System.Drawing.Point(847, -21);
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
            this.pnlGrid.Controls.Add(this.splitContainerControl1);
            this.pnlGrid.Controls.Add(this.lblExportOpt);
            this.pnlGrid.Controls.Add(this.cboExportOpt);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlGrid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1018, 480);
            this.pnlGrid.TabIndex = 0;
            this.pnlGrid.Text = "列表信息";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 22);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gcList);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gcPowerSwitchInfo);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1014, 456);
            this.splitContainerControl1.SplitterPosition = 244;
            this.splitContainerControl1.TabIndex = 38;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gcList
            // 
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcList.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gcList.Location = new System.Drawing.Point(0, 0);
            this.gcList.MainView = this.gvList;
            this.gcList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gcList.Size = new System.Drawing.Size(1014, 244);
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
            this.colF_POWER_ID,
            this.colF_POWER_NAME,
            this.colF_POWER_CALIBRATION,
            this.colF_POWER_DESCRIPTION,
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
            // colF_POWER_ID
            // 
            this.colF_POWER_ID.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_POWER_ID.AppearanceCell.Options.UseFont = true;
            this.colF_POWER_ID.AppearanceCell.Options.UseTextOptions = true;
            this.colF_POWER_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_POWER_ID.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_POWER_ID.AppearanceHeader.Options.UseFont = true;
            this.colF_POWER_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_POWER_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_POWER_ID.Caption = "编码";
            this.colF_POWER_ID.FieldName = "F_POWER_ID";
            this.colF_POWER_ID.Name = "colF_POWER_ID";
            this.colF_POWER_ID.OptionsColumn.AllowEdit = false;
            this.colF_POWER_ID.OptionsColumn.AllowFocus = false;
            this.colF_POWER_ID.Visible = true;
            this.colF_POWER_ID.VisibleIndex = 0;
            this.colF_POWER_ID.Width = 118;
            // 
            // colF_POWER_NAME
            // 
            this.colF_POWER_NAME.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_POWER_NAME.AppearanceCell.Options.UseFont = true;
            this.colF_POWER_NAME.AppearanceCell.Options.UseTextOptions = true;
            this.colF_POWER_NAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_POWER_NAME.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_POWER_NAME.AppearanceHeader.Options.UseFont = true;
            this.colF_POWER_NAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_POWER_NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_POWER_NAME.Caption = "名称";
            this.colF_POWER_NAME.FieldName = "F_POWER_NAME";
            this.colF_POWER_NAME.Name = "colF_POWER_NAME";
            this.colF_POWER_NAME.OptionsColumn.AllowEdit = false;
            this.colF_POWER_NAME.OptionsColumn.AllowFocus = false;
            this.colF_POWER_NAME.Visible = true;
            this.colF_POWER_NAME.VisibleIndex = 1;
            this.colF_POWER_NAME.Width = 213;
            // 
            // colF_POWER_CALIBRATION
            // 
            this.colF_POWER_CALIBRATION.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colF_POWER_CALIBRATION.AppearanceCell.Options.UseFont = true;
            this.colF_POWER_CALIBRATION.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colF_POWER_CALIBRATION.AppearanceHeader.Options.UseFont = true;
            this.colF_POWER_CALIBRATION.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_POWER_CALIBRATION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_POWER_CALIBRATION.Caption = "校准编号";
            this.colF_POWER_CALIBRATION.FieldName = "F_POWER_CALIBRATION";
            this.colF_POWER_CALIBRATION.Name = "colF_POWER_CALIBRATION";
            this.colF_POWER_CALIBRATION.OptionsColumn.AllowEdit = false;
            this.colF_POWER_CALIBRATION.OptionsColumn.AllowFocus = false;
            this.colF_POWER_CALIBRATION.Visible = true;
            this.colF_POWER_CALIBRATION.VisibleIndex = 2;
            // 
            // colF_POWER_DESCRIPTION
            // 
            this.colF_POWER_DESCRIPTION.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_POWER_DESCRIPTION.AppearanceCell.Options.UseFont = true;
            this.colF_POWER_DESCRIPTION.AppearanceCell.Options.UseTextOptions = true;
            this.colF_POWER_DESCRIPTION.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_POWER_DESCRIPTION.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_POWER_DESCRIPTION.AppearanceHeader.Options.UseFont = true;
            this.colF_POWER_DESCRIPTION.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_POWER_DESCRIPTION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_POWER_DESCRIPTION.Caption = "备注";
            this.colF_POWER_DESCRIPTION.FieldName = "F_POWER_DESCRIPTION";
            this.colF_POWER_DESCRIPTION.Name = "colF_POWER_DESCRIPTION";
            this.colF_POWER_DESCRIPTION.OptionsColumn.AllowEdit = false;
            this.colF_POWER_DESCRIPTION.OptionsColumn.AllowFocus = false;
            this.colF_POWER_DESCRIPTION.Visible = true;
            this.colF_POWER_DESCRIPTION.VisibleIndex = 3;
            this.colF_POWER_DESCRIPTION.Width = 364;
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
            this.colF_DEL.VisibleIndex = 4;
            this.colF_DEL.Width = 120;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repositoryItemLookUpEdit1.Appearance.Options.UseFont = true;
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("F_MASTER_NAME", "dsa"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FMasterId", "Name3")});
            this.repositoryItemLookUpEdit1.DisplayMember = "F_WORSTATION_NAME";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "FMasterId";
            // 
            // gcPowerSwitchInfo
            // 
            this.gcPowerSwitchInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPowerSwitchInfo.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcPowerSwitchInfo.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gcPowerSwitchInfo.Location = new System.Drawing.Point(0, 0);
            this.gcPowerSwitchInfo.MainView = this.gvPowerSwitchInfo;
            this.gcPowerSwitchInfo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcPowerSwitchInfo.Name = "gcPowerSwitchInfo";
            this.gcPowerSwitchInfo.Size = new System.Drawing.Size(1014, 206);
            this.gcPowerSwitchInfo.TabIndex = 0;
            this.gcPowerSwitchInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPowerSwitchInfo,
            this.gridView2});
            // 
            // gvPowerSwitchInfo
            // 
            this.gvPowerSwitchInfo.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPowerSwitchInfo.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvPowerSwitchInfo.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPowerSwitchInfo.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvPowerSwitchInfo.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPowerSwitchInfo.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvPowerSwitchInfo.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvPowerSwitchInfo.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvPowerSwitchInfo.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvPowerSwitchInfo.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvPowerSwitchInfo.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvPowerSwitchInfo.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvPowerSwitchInfo.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPowerSwitchInfo.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvPowerSwitchInfo.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvPowerSwitchInfo.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvPowerSwitchInfo.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvPowerSwitchInfo.Appearance.Empty.Options.UseBackColor = true;
            this.gvPowerSwitchInfo.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvPowerSwitchInfo.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvPowerSwitchInfo.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvPowerSwitchInfo.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvPowerSwitchInfo.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPowerSwitchInfo.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvPowerSwitchInfo.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPowerSwitchInfo.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvPowerSwitchInfo.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPowerSwitchInfo.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvPowerSwitchInfo.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvPowerSwitchInfo.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvPowerSwitchInfo.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvPowerSwitchInfo.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvPowerSwitchInfo.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvPowerSwitchInfo.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvPowerSwitchInfo.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvPowerSwitchInfo.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvPowerSwitchInfo.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvPowerSwitchInfo.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvPowerSwitchInfo.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvPowerSwitchInfo.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvPowerSwitchInfo.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPowerSwitchInfo.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvPowerSwitchInfo.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPowerSwitchInfo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPowerSwitchInfo.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPowerSwitchInfo.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvPowerSwitchInfo.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvPowerSwitchInfo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvPowerSwitchInfo.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvPowerSwitchInfo.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvPowerSwitchInfo.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvPowerSwitchInfo.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvPowerSwitchInfo.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvPowerSwitchInfo.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvPowerSwitchInfo.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvPowerSwitchInfo.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvPowerSwitchInfo.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvPowerSwitchInfo.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvPowerSwitchInfo.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvPowerSwitchInfo.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvPowerSwitchInfo.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvPowerSwitchInfo.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPowerSwitchInfo.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvPowerSwitchInfo.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvPowerSwitchInfo.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvPowerSwitchInfo.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvPowerSwitchInfo.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvPowerSwitchInfo.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvPowerSwitchInfo.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvPowerSwitchInfo.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvPowerSwitchInfo.Appearance.GroupRow.Options.UseFont = true;
            this.gvPowerSwitchInfo.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvPowerSwitchInfo.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPowerSwitchInfo.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvPowerSwitchInfo.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPowerSwitchInfo.Appearance.HeaderPanel.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.gvPowerSwitchInfo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPowerSwitchInfo.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPowerSwitchInfo.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvPowerSwitchInfo.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvPowerSwitchInfo.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvPowerSwitchInfo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvPowerSwitchInfo.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvPowerSwitchInfo.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvPowerSwitchInfo.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvPowerSwitchInfo.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvPowerSwitchInfo.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvPowerSwitchInfo.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvPowerSwitchInfo.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvPowerSwitchInfo.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvPowerSwitchInfo.Appearance.OddRow.Options.UseBackColor = true;
            this.gvPowerSwitchInfo.Appearance.OddRow.Options.UseForeColor = true;
            this.gvPowerSwitchInfo.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvPowerSwitchInfo.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvPowerSwitchInfo.Appearance.Preview.Options.UseBackColor = true;
            this.gvPowerSwitchInfo.Appearance.Preview.Options.UseForeColor = true;
            this.gvPowerSwitchInfo.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvPowerSwitchInfo.Appearance.Row.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.gvPowerSwitchInfo.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvPowerSwitchInfo.Appearance.Row.Options.UseBackColor = true;
            this.gvPowerSwitchInfo.Appearance.Row.Options.UseFont = true;
            this.gvPowerSwitchInfo.Appearance.Row.Options.UseForeColor = true;
            this.gvPowerSwitchInfo.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvPowerSwitchInfo.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvPowerSwitchInfo.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvPowerSwitchInfo.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvPowerSwitchInfo.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvPowerSwitchInfo.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvPowerSwitchInfo.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvPowerSwitchInfo.Appearance.VertLine.Options.UseBackColor = true;
            this.gvPowerSwitchInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colF_POWER_SWITCH_ID,
            this.colF_COM_ADDRESS,
            this.colF_POWER_SWITCH_ADDRESS,
            this.colF_HOLDREG,
            this.colF_POWER_SWITCH_CALIBRATION,
            this.colF_POWER_SWITCH_TYPE,
            this.colF_POWER_SWITCH_STATUS,
            this.colF_LOAD_CAPACITY,
            this.colF_ALARM_LIFEDURANCE,
            this.colF_ALARM_TIMEDURANCE,
            this.colF_SWITCH_TIMES,
            this.colSwitchF_DEL});
            this.gvPowerSwitchInfo.GridControl = this.gcPowerSwitchInfo;
            this.gvPowerSwitchInfo.Name = "gvPowerSwitchInfo";
            this.gvPowerSwitchInfo.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gvPowerSwitchInfo.OptionsBehavior.ImmediateUpdateRowPosition = false;
            this.gvPowerSwitchInfo.OptionsPrint.AutoWidth = false;
            this.gvPowerSwitchInfo.OptionsView.ColumnAutoWidth = false;
            this.gvPowerSwitchInfo.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPowerSwitchInfo.OptionsView.EnableAppearanceOddRow = true;
            this.gvPowerSwitchInfo.OptionsView.ShowGroupPanel = false;
            // 
            // colF_POWER_SWITCH_ID
            // 
            this.colF_POWER_SWITCH_ID.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_POWER_SWITCH_ID.AppearanceCell.Options.UseFont = true;
            this.colF_POWER_SWITCH_ID.AppearanceCell.Options.UseTextOptions = true;
            this.colF_POWER_SWITCH_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_POWER_SWITCH_ID.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_POWER_SWITCH_ID.AppearanceHeader.Options.UseFont = true;
            this.colF_POWER_SWITCH_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_POWER_SWITCH_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_POWER_SWITCH_ID.Caption = "开关序号";
            this.colF_POWER_SWITCH_ID.FieldName = "F_POWER_SWITCH_ID";
            this.colF_POWER_SWITCH_ID.Name = "colF_POWER_SWITCH_ID";
            this.colF_POWER_SWITCH_ID.OptionsColumn.AllowEdit = false;
            this.colF_POWER_SWITCH_ID.OptionsColumn.AllowFocus = false;
            this.colF_POWER_SWITCH_ID.Visible = true;
            this.colF_POWER_SWITCH_ID.VisibleIndex = 0;
            this.colF_POWER_SWITCH_ID.Width = 118;
            // 
            // colF_COM_ADDRESS
            // 
            this.colF_COM_ADDRESS.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_COM_ADDRESS.AppearanceCell.Options.UseFont = true;
            this.colF_COM_ADDRESS.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_COM_ADDRESS.AppearanceHeader.Options.UseFont = true;
            this.colF_COM_ADDRESS.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_COM_ADDRESS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_COM_ADDRESS.Caption = "通信端口地址";
            this.colF_COM_ADDRESS.FieldName = "F_COM_ADDRESS";
            this.colF_COM_ADDRESS.Name = "colF_COM_ADDRESS";
            this.colF_COM_ADDRESS.OptionsColumn.AllowEdit = false;
            this.colF_COM_ADDRESS.OptionsColumn.AllowFocus = false;
            this.colF_COM_ADDRESS.Visible = true;
            this.colF_COM_ADDRESS.VisibleIndex = 1;
            this.colF_COM_ADDRESS.Width = 106;
            // 
            // colF_POWER_SWITCH_ADDRESS
            // 
            this.colF_POWER_SWITCH_ADDRESS.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_POWER_SWITCH_ADDRESS.AppearanceCell.Options.UseFont = true;
            this.colF_POWER_SWITCH_ADDRESS.AppearanceCell.Options.UseTextOptions = true;
            this.colF_POWER_SWITCH_ADDRESS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colF_POWER_SWITCH_ADDRESS.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_POWER_SWITCH_ADDRESS.AppearanceHeader.Options.UseFont = true;
            this.colF_POWER_SWITCH_ADDRESS.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_POWER_SWITCH_ADDRESS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_POWER_SWITCH_ADDRESS.Caption = "供电柜开关地址";
            this.colF_POWER_SWITCH_ADDRESS.FieldName = "F_POWER_SWITCH_ADDRESS";
            this.colF_POWER_SWITCH_ADDRESS.Name = "colF_POWER_SWITCH_ADDRESS";
            this.colF_POWER_SWITCH_ADDRESS.OptionsColumn.AllowEdit = false;
            this.colF_POWER_SWITCH_ADDRESS.OptionsColumn.AllowFocus = false;
            this.colF_POWER_SWITCH_ADDRESS.Visible = true;
            this.colF_POWER_SWITCH_ADDRESS.VisibleIndex = 2;
            this.colF_POWER_SWITCH_ADDRESS.Width = 109;
            // 
            // colF_HOLDREG
            // 
            this.colF_HOLDREG.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colF_HOLDREG.AppearanceCell.Options.UseFont = true;
            this.colF_HOLDREG.AppearanceCell.Options.UseTextOptions = true;
            this.colF_HOLDREG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colF_HOLDREG.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colF_HOLDREG.AppearanceHeader.Options.UseFont = true;
            this.colF_HOLDREG.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_HOLDREG.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_HOLDREG.Caption = "通道号";
            this.colF_HOLDREG.FieldName = "F_HOLDREG";
            this.colF_HOLDREG.Name = "colF_HOLDREG";
            this.colF_HOLDREG.OptionsColumn.AllowEdit = false;
            this.colF_HOLDREG.OptionsColumn.AllowFocus = false;
            this.colF_HOLDREG.Visible = true;
            this.colF_HOLDREG.VisibleIndex = 3;
            // 
            // colF_POWER_SWITCH_CALIBRATION
            // 
            this.colF_POWER_SWITCH_CALIBRATION.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_POWER_SWITCH_CALIBRATION.AppearanceCell.Options.UseFont = true;
            this.colF_POWER_SWITCH_CALIBRATION.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_POWER_SWITCH_CALIBRATION.AppearanceHeader.Options.UseFont = true;
            this.colF_POWER_SWITCH_CALIBRATION.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_POWER_SWITCH_CALIBRATION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_POWER_SWITCH_CALIBRATION.Caption = "校准编号";
            this.colF_POWER_SWITCH_CALIBRATION.FieldName = "F_POWER_SWITCH_CALIBRATION";
            this.colF_POWER_SWITCH_CALIBRATION.Name = "colF_POWER_SWITCH_CALIBRATION";
            this.colF_POWER_SWITCH_CALIBRATION.OptionsColumn.AllowEdit = false;
            this.colF_POWER_SWITCH_CALIBRATION.OptionsColumn.AllowFocus = false;
            this.colF_POWER_SWITCH_CALIBRATION.Visible = true;
            this.colF_POWER_SWITCH_CALIBRATION.VisibleIndex = 4;
            this.colF_POWER_SWITCH_CALIBRATION.Width = 114;
            // 
            // colF_POWER_SWITCH_TYPE
            // 
            this.colF_POWER_SWITCH_TYPE.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_POWER_SWITCH_TYPE.AppearanceCell.Options.UseFont = true;
            this.colF_POWER_SWITCH_TYPE.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_POWER_SWITCH_TYPE.AppearanceHeader.Options.UseFont = true;
            this.colF_POWER_SWITCH_TYPE.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_POWER_SWITCH_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_POWER_SWITCH_TYPE.Caption = "输入输出类型";
            this.colF_POWER_SWITCH_TYPE.FieldName = "F_POWER_SWITCH_TYPE";
            this.colF_POWER_SWITCH_TYPE.Name = "colF_POWER_SWITCH_TYPE";
            this.colF_POWER_SWITCH_TYPE.OptionsColumn.AllowEdit = false;
            this.colF_POWER_SWITCH_TYPE.OptionsColumn.AllowFocus = false;
            this.colF_POWER_SWITCH_TYPE.Visible = true;
            this.colF_POWER_SWITCH_TYPE.VisibleIndex = 5;
            this.colF_POWER_SWITCH_TYPE.Width = 105;
            // 
            // colF_POWER_SWITCH_STATUS
            // 
            this.colF_POWER_SWITCH_STATUS.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_POWER_SWITCH_STATUS.AppearanceCell.Options.UseFont = true;
            this.colF_POWER_SWITCH_STATUS.AppearanceCell.Options.UseTextOptions = true;
            this.colF_POWER_SWITCH_STATUS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_POWER_SWITCH_STATUS.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_POWER_SWITCH_STATUS.AppearanceHeader.Options.UseFont = true;
            this.colF_POWER_SWITCH_STATUS.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_POWER_SWITCH_STATUS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_POWER_SWITCH_STATUS.Caption = "供电柜开关状态";
            this.colF_POWER_SWITCH_STATUS.FieldName = "F_POWER_SWITCH_STATUS";
            this.colF_POWER_SWITCH_STATUS.Name = "colF_POWER_SWITCH_STATUS";
            this.colF_POWER_SWITCH_STATUS.OptionsColumn.AllowEdit = false;
            this.colF_POWER_SWITCH_STATUS.OptionsColumn.AllowFocus = false;
            this.colF_POWER_SWITCH_STATUS.Visible = true;
            this.colF_POWER_SWITCH_STATUS.VisibleIndex = 6;
            this.colF_POWER_SWITCH_STATUS.Width = 183;
            // 
            // colF_LOAD_CAPACITY
            // 
            this.colF_LOAD_CAPACITY.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_LOAD_CAPACITY.AppearanceCell.Options.UseFont = true;
            this.colF_LOAD_CAPACITY.AppearanceCell.Options.UseTextOptions = true;
            this.colF_LOAD_CAPACITY.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colF_LOAD_CAPACITY.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_LOAD_CAPACITY.AppearanceHeader.Options.UseFont = true;
            this.colF_LOAD_CAPACITY.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_LOAD_CAPACITY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_LOAD_CAPACITY.Caption = "负荷容量";
            this.colF_LOAD_CAPACITY.FieldName = "F_LOAD_CAPACITY";
            this.colF_LOAD_CAPACITY.Name = "colF_LOAD_CAPACITY";
            this.colF_LOAD_CAPACITY.OptionsColumn.AllowEdit = false;
            this.colF_LOAD_CAPACITY.OptionsColumn.AllowFocus = false;
            this.colF_LOAD_CAPACITY.Visible = true;
            this.colF_LOAD_CAPACITY.VisibleIndex = 7;
            this.colF_LOAD_CAPACITY.Width = 152;
            // 
            // colF_ALARM_LIFEDURANCE
            // 
            this.colF_ALARM_LIFEDURANCE.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_ALARM_LIFEDURANCE.AppearanceCell.Options.UseFont = true;
            this.colF_ALARM_LIFEDURANCE.AppearanceCell.Options.UseTextOptions = true;
            this.colF_ALARM_LIFEDURANCE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colF_ALARM_LIFEDURANCE.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_ALARM_LIFEDURANCE.AppearanceHeader.Options.UseFont = true;
            this.colF_ALARM_LIFEDURANCE.Caption = "开关报警阈值(按时长)";
            this.colF_ALARM_LIFEDURANCE.FieldName = "F_ALARM_LIFEDURANCE";
            this.colF_ALARM_LIFEDURANCE.Name = "colF_ALARM_LIFEDURANCE";
            this.colF_ALARM_LIFEDURANCE.OptionsColumn.AllowEdit = false;
            this.colF_ALARM_LIFEDURANCE.OptionsColumn.AllowFocus = false;
            this.colF_ALARM_LIFEDURANCE.Visible = true;
            this.colF_ALARM_LIFEDURANCE.VisibleIndex = 8;
            this.colF_ALARM_LIFEDURANCE.Width = 145;
            // 
            // colF_ALARM_TIMEDURANCE
            // 
            this.colF_ALARM_TIMEDURANCE.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_ALARM_TIMEDURANCE.AppearanceCell.Options.UseFont = true;
            this.colF_ALARM_TIMEDURANCE.AppearanceCell.Options.UseTextOptions = true;
            this.colF_ALARM_TIMEDURANCE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colF_ALARM_TIMEDURANCE.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_ALARM_TIMEDURANCE.AppearanceHeader.Options.UseFont = true;
            this.colF_ALARM_TIMEDURANCE.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_ALARM_TIMEDURANCE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_ALARM_TIMEDURANCE.Caption = "开关报警阈值(按使用次数)";
            this.colF_ALARM_TIMEDURANCE.FieldName = "F_ALARM_TIMEDURANCE";
            this.colF_ALARM_TIMEDURANCE.Name = "colF_ALARM_TIMEDURANCE";
            this.colF_ALARM_TIMEDURANCE.OptionsColumn.AllowEdit = false;
            this.colF_ALARM_TIMEDURANCE.OptionsColumn.AllowFocus = false;
            this.colF_ALARM_TIMEDURANCE.Visible = true;
            this.colF_ALARM_TIMEDURANCE.VisibleIndex = 9;
            this.colF_ALARM_TIMEDURANCE.Width = 120;
            // 
            // colF_SWITCH_TIMES
            // 
            this.colF_SWITCH_TIMES.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SWITCH_TIMES.AppearanceCell.Options.UseFont = true;
            this.colF_SWITCH_TIMES.AppearanceCell.Options.UseTextOptions = true;
            this.colF_SWITCH_TIMES.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colF_SWITCH_TIMES.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SWITCH_TIMES.AppearanceHeader.Options.UseFont = true;
            this.colF_SWITCH_TIMES.Caption = "开关动作次数";
            this.colF_SWITCH_TIMES.FieldName = "F_SWITCH_TIMES";
            this.colF_SWITCH_TIMES.Name = "colF_SWITCH_TIMES";
            this.colF_SWITCH_TIMES.OptionsColumn.AllowEdit = false;
            this.colF_SWITCH_TIMES.OptionsColumn.AllowFocus = false;
            this.colF_SWITCH_TIMES.Visible = true;
            this.colF_SWITCH_TIMES.VisibleIndex = 10;
            this.colF_SWITCH_TIMES.Width = 110;
            // 
            // colSwitchF_DEL
            // 
            this.colSwitchF_DEL.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colSwitchF_DEL.AppearanceCell.Options.UseFont = true;
            this.colSwitchF_DEL.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colSwitchF_DEL.AppearanceHeader.Options.UseFont = true;
            this.colSwitchF_DEL.AppearanceHeader.Options.UseTextOptions = true;
            this.colSwitchF_DEL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSwitchF_DEL.Caption = "禁用状态";
            this.colSwitchF_DEL.FieldName = "F_DEL";
            this.colSwitchF_DEL.Name = "colSwitchF_DEL";
            this.colSwitchF_DEL.OptionsColumn.AllowEdit = false;
            this.colSwitchF_DEL.OptionsColumn.AllowFocus = false;
            this.colSwitchF_DEL.Visible = true;
            this.colSwitchF_DEL.VisibleIndex = 11;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gcPowerSwitchInfo;
            this.gridView2.Name = "gridView2";
            // 
            // txtPosition
            // 
            this.txtPosition.Controls.Add(this.pnlGrid);
            this.txtPosition.Controls.Add(this.pnlDetail);
            this.txtPosition.Controls.Add(this.plnButtons);
            this.txtPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPosition.Location = new System.Drawing.Point(0, 0);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(1018, 731);
            this.txtPosition.TabIndex = 0;
            // 
            // FrmDevPowerBaseInfo
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1018, 731);
            this.Controls.Add(this.txtPosition);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmDevPowerBaseInfo";
            this.Text = "供电柜基本信息";
            this.Load += new System.EventHandler(this.FrmPowerBaseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plnButtons)).EndInit();
            this.plnButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcDetail)).EndInit();
            this.lcDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtF_POWER_CALIBRATION.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_POWER_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_POWER_NAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoF_DEL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_POWER_DESCRIPTION.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSwitchNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_POWER_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_POWER_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSwitchNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_POWER_DESCRIPTION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_POWER_CALIBRATION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_DEL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoundRule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPackRule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZBR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboExportOpt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            this.pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPowerSwitchInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPowerSwitchInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.txtPosition.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl plnButtons;
        private BaseSimpleButton btnClose;
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
        private DevExpress.XtraGrid.Columns.GridColumn colF_POWER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colF_POWER_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colF_POWER_DESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn colF_DEL;
        private DevExpress.XtraEditors.XtraScrollableControl txtPosition;
        private DevExpress.XtraEditors.TextEdit txtZBR;
        private DevExpress.XtraEditors.TextEdit txtSPR;
        private BaseGridControl gcList;
        private TextEdit txtF_POWER_NAME;
        private TextEdit txtF_POWER_ID;
        private BaseSimpleButton btnEnabled;
        private BaseSimpleButton btnDisabled;
        private SplitContainerControl splitContainerControl1;
        private BaseGridControl gcPowerSwitchInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPowerSwitchInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colF_POWER_SWITCH_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colF_POWER_SWITCH_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colF_LOAD_CAPACITY;
        private DevExpress.XtraGrid.Columns.GridColumn colF_ALARM_LIFEDURANCE;
        private DevExpress.XtraGrid.Columns.GridColumn colF_ALARM_TIMEDURANCE;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colF_SWITCH_TIMES;
        private RadioGroup rdoF_DEL;
        private DevExpress.XtraGrid.Columns.GridColumn colSwitchF_DEL;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraLayout.LayoutControl lcDetail;
        private MemoEdit txtF_POWER_DESCRIPTION;
        private DevExpress.XtraLayout.LayoutControlGroup lcgDetail;
        private DevExpress.XtraLayout.LayoutControlItem lciF_POWER_ID;
        private DevExpress.XtraLayout.LayoutControlItem lciF_POWER_NAME;
        private DevExpress.XtraLayout.LayoutControlItem lciSwitchNumber;
        private DevExpress.XtraLayout.LayoutControlItem lciF_DEL;
        private DevExpress.XtraLayout.LayoutControlItem lciF_POWER_DESCRIPTION;
        private TextEdit txtSwitchNum;
        private BaseSimpleButton btnEdiSwitch;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private TextEdit txtF_POWER_CALIBRATION;
        private DevExpress.XtraLayout.LayoutControlItem lciF_POWER_CALIBRATION;
        private DevExpress.XtraGrid.Columns.GridColumn colF_POWER_CALIBRATION;
        private DevExpress.XtraGrid.Columns.GridColumn colF_COM_ADDRESS;
        private DevExpress.XtraGrid.Columns.GridColumn colF_POWER_SWITCH_ADDRESS;
        private DevExpress.XtraGrid.Columns.GridColumn colF_POWER_SWITCH_CALIBRATION;
        private DevExpress.XtraGrid.Columns.GridColumn colF_POWER_SWITCH_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colF_HOLDREG;

    }
}