using DevExpress.XtraEditors;
using RelayTest.Util.Common;

namespace RelayTest.Application.Settings
{

    /// <summary>
    /// 负载柜基础数据
    /// </summary>
    partial class FrmDevLoadBaseInfo
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
            this.btnChannelInfo = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnEnabled = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnDisabled = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnExport = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnDelete = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnSave = new RelayTest.Util.Common.BaseSimpleButton();
            this.pnlDetail = new DevExpress.XtraEditors.GroupControl();
            this.lcDetail = new DevExpress.XtraLayout.LayoutControl();
            this.txtF_LOAD_CALIBRATION = new DevExpress.XtraEditors.TextEdit();
            this.txtF_LOAD_VOLTAGE_FLOOR = new DevExpress.XtraEditors.TextEdit();
            this.txtF_LOAD_VOLTAGE_CEILING = new DevExpress.XtraEditors.TextEdit();
            this.txtF_LOAD_PULSECURRENT_FLOOR = new DevExpress.XtraEditors.TextEdit();
            this.txtF_LOAD_PULSECURRENT_CEILING = new DevExpress.XtraEditors.TextEdit();
            this.txtF_LOAD_STABLECURRENT_CEILING = new DevExpress.XtraEditors.TextEdit();
            this.lueF_LOAD_VOLTAGE_TYPE = new DevExpress.XtraEditors.LookUpEdit();
            this.rdoF_DEL = new DevExpress.XtraEditors.RadioGroup();
            this.txtF_LOAD_DESCRIPTION = new DevExpress.XtraEditors.MemoEdit();
            this.txtF_LOAD_STABLECURRENT_FLOOR = new DevExpress.XtraEditors.TextEdit();
            this.txtF_CONDUCTYLOAD_COEFFECIENCY = new DevExpress.XtraEditors.TextEdit();
            this.txtF_PROPERTY_ID = new DevExpress.XtraEditors.TextEdit();
            this.txtF_LOAD_NAME = new DevExpress.XtraEditors.TextEdit();
            this.txtF_LOAD_POSTION = new DevExpress.XtraEditors.TextEdit();
            this.txtF_LOAD_ID = new DevExpress.XtraEditors.TextEdit();
            this.lueF_LOAD_TYPE = new DevExpress.XtraEditors.LookUpEdit();
            this.txtChannelNum = new DevExpress.XtraEditors.TextEdit();
            this.lcgDetail = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciF_LOAD_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_LOAD_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_LOAD_POSTION = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_PROPERTY_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_LOAD_TYPE = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_CONDUCTYLOAD_COEFFECIENCY = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_LOAD_STABLECURRENT_CEILING = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_LOAD_PULSECURRENT_CEILING = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_LOAD_PULSECURRENT_FLOOR = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_LOAD_VOLTAGE_CEILING = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_LOAD_VOLTAGE_FLOOR = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciChannelNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_DEL = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_LOAD_DESCRIPTION = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_LOAD_CALIBRATION = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_LOAD_VOLTAGE_TYPE = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciF_LOAD_STABLECURRENT_FLOOR = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.cboRoundRule = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboPackRule = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblSPR = new RelayTest.Util.Common.BaseLabelControl();
            this.lblZBR = new RelayTest.Util.Common.BaseLabelControl();
            this.txtZBR = new DevExpress.XtraEditors.TextEdit();
            this.txtSPR = new DevExpress.XtraEditors.TextEdit();
            this.gcList = new RelayTest.Util.Common.BaseGridControl();
            this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colF_LOAD_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_LOAD_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_LOAD_CALIBRATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_LOAD_POSTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_PROPERTY_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_LOAD_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_CONDUCTYLOAD_COEFFECIENCY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_LOAD_VOLTAGE_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_LOAD_STABLECURRENT_CEILING = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_LOAD_STABLECURRENT_FLOOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_LOAD_PULSECURRENT_CEILING = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_LOAD_PULSECURRENT_FLOOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_LOAD_VOLTAGE_CEILING = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_LOAD_VOLTAGE_FLOOR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_LOAD_DESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_DEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.pnlGrid = new DevExpress.XtraEditors.GroupControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gcLoadChannel = new RelayTest.Util.Common.BaseGridControl();
            this.gvLoadChannel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colF_LOAD_CHANNEL_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_LOAD_CHANNEL_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_LOAD_CHANNEL_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChannelF_DEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblExportOpt = new RelayTest.Util.Common.BaseLabelControl();
            this.cboExportOpt = new DevExpress.XtraEditors.ComboBoxEdit();
            this.colF_LOAD_TEST_NUM = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.plnButtons)).BeginInit();
            this.plnButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).BeginInit();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcDetail)).BeginInit();
            this.lcDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_CALIBRATION.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_VOLTAGE_FLOOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_VOLTAGE_CEILING.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_PULSECURRENT_FLOOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_PULSECURRENT_CEILING.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_STABLECURRENT_CEILING.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueF_LOAD_VOLTAGE_TYPE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoF_DEL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_DESCRIPTION.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_STABLECURRENT_FLOOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_CONDUCTYLOAD_COEFFECIENCY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_PROPERTY_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_NAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_POSTION.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueF_LOAD_TYPE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChannelNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_POSTION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_PROPERTY_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_TYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_CONDUCTYLOAD_COEFFECIENCY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_STABLECURRENT_CEILING)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_PULSECURRENT_CEILING)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_PULSECURRENT_FLOOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_VOLTAGE_CEILING)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_VOLTAGE_FLOOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChannelNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_DEL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_DESCRIPTION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_CALIBRATION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_VOLTAGE_TYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_STABLECURRENT_FLOOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoundRule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPackRule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZBR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoadChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoadChannel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboExportOpt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // plnButtons
            // 
            this.plnButtons.Controls.Add(this.btnChannelInfo);
            this.plnButtons.Controls.Add(this.btnEnabled);
            this.plnButtons.Controls.Add(this.btnDisabled);
            this.plnButtons.Controls.Add(this.btnExport);
            this.plnButtons.Controls.Add(this.btnDelete);
            this.plnButtons.Controls.Add(this.btnSave);
            this.plnButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plnButtons.Location = new System.Drawing.Point(0, 691);
            this.plnButtons.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.plnButtons.Name = "plnButtons";
            this.plnButtons.Size = new System.Drawing.Size(1018, 49);
            this.plnButtons.TabIndex = 2;
            // 
            // btnChannelInfo
            // 
            this.btnChannelInfo.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChannelInfo.Appearance.Options.UseFont = true;
            this.btnChannelInfo.Location = new System.Drawing.Point(653, 9);
            this.btnChannelInfo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnChannelInfo.Name = "btnChannelInfo";
            this.btnChannelInfo.Size = new System.Drawing.Size(80, 31);
            this.btnChannelInfo.TabIndex = 5;
            this.btnChannelInfo.Text = "通道信息";
            this.btnChannelInfo.Click += new System.EventHandler(this.btnChannelInfo_Click);
            // 
            // btnEnabled
            // 
            this.btnEnabled.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEnabled.Appearance.Options.UseFont = true;
            this.btnEnabled.Location = new System.Drawing.Point(385, 11);
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
            this.btnDisabled.Location = new System.Drawing.Point(474, 11);
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
            this.btnExport.Location = new System.Drawing.Point(743, 9);
            this.btnExport.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(80, 31);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "导出";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
            this.btnSave.Location = new System.Drawing.Point(294, 11);
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
            this.pnlDetail.Controls.Add(this.cboRoundRule);
            this.pnlDetail.Controls.Add(this.cboPackRule);
            this.pnlDetail.Controls.Add(this.lblSPR);
            this.pnlDetail.Controls.Add(this.lblZBR);
            this.pnlDetail.Controls.Add(this.txtZBR);
            this.pnlDetail.Controls.Add(this.txtSPR);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDetail.Location = new System.Drawing.Point(0, 391);
            this.pnlDetail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(1018, 300);
            this.pnlDetail.TabIndex = 1;
            this.pnlDetail.Text = "参数设置";
            // 
            // lcDetail
            // 
            this.lcDetail.Appearance.DisabledLayoutItem.ForeColor = System.Drawing.Color.Black;
            this.lcDetail.Appearance.DisabledLayoutItem.Options.UseForeColor = true;
            this.lcDetail.Controls.Add(this.txtF_LOAD_CALIBRATION);
            this.lcDetail.Controls.Add(this.txtF_LOAD_VOLTAGE_FLOOR);
            this.lcDetail.Controls.Add(this.txtF_LOAD_VOLTAGE_CEILING);
            this.lcDetail.Controls.Add(this.txtF_LOAD_PULSECURRENT_FLOOR);
            this.lcDetail.Controls.Add(this.txtF_LOAD_PULSECURRENT_CEILING);
            this.lcDetail.Controls.Add(this.txtF_LOAD_STABLECURRENT_CEILING);
            this.lcDetail.Controls.Add(this.lueF_LOAD_VOLTAGE_TYPE);
            this.lcDetail.Controls.Add(this.rdoF_DEL);
            this.lcDetail.Controls.Add(this.txtF_LOAD_DESCRIPTION);
            this.lcDetail.Controls.Add(this.txtF_LOAD_STABLECURRENT_FLOOR);
            this.lcDetail.Controls.Add(this.txtF_CONDUCTYLOAD_COEFFECIENCY);
            this.lcDetail.Controls.Add(this.txtF_PROPERTY_ID);
            this.lcDetail.Controls.Add(this.txtF_LOAD_NAME);
            this.lcDetail.Controls.Add(this.txtF_LOAD_POSTION);
            this.lcDetail.Controls.Add(this.txtF_LOAD_ID);
            this.lcDetail.Controls.Add(this.lueF_LOAD_TYPE);
            this.lcDetail.Controls.Add(this.txtChannelNum);
            this.lcDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcDetail.Location = new System.Drawing.Point(2, 22);
            this.lcDetail.Name = "lcDetail";
            this.lcDetail.Root = this.lcgDetail;
            this.lcDetail.Size = new System.Drawing.Size(1014, 276);
            this.lcDetail.TabIndex = 25;
            this.lcDetail.Text = "layoutControl1";
            // 
            // txtF_LOAD_CALIBRATION
            // 
            this.txtF_LOAD_CALIBRATION.Location = new System.Drawing.Point(235, 54);
            this.txtF_LOAD_CALIBRATION.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_LOAD_CALIBRATION.Name = "txtF_LOAD_CALIBRATION";
            this.txtF_LOAD_CALIBRATION.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_LOAD_CALIBRATION.Properties.Appearance.Options.UseFont = true;
            this.txtF_LOAD_CALIBRATION.Properties.Mask.EditMask = "d";
            this.txtF_LOAD_CALIBRATION.Size = new System.Drawing.Size(272, 22);
            this.txtF_LOAD_CALIBRATION.StyleController = this.lcDetail;
            this.txtF_LOAD_CALIBRATION.TabIndex = 6;
            // 
            // txtF_LOAD_VOLTAGE_FLOOR
            // 
            this.txtF_LOAD_VOLTAGE_FLOOR.Location = new System.Drawing.Point(642, 174);
            this.txtF_LOAD_VOLTAGE_FLOOR.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_LOAD_VOLTAGE_FLOOR.Name = "txtF_LOAD_VOLTAGE_FLOOR";
            this.txtF_LOAD_VOLTAGE_FLOOR.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_LOAD_VOLTAGE_FLOOR.Properties.Appearance.Options.UseFont = true;
            this.txtF_LOAD_VOLTAGE_FLOOR.Properties.Appearance.Options.UseTextOptions = true;
            this.txtF_LOAD_VOLTAGE_FLOOR.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtF_LOAD_VOLTAGE_FLOOR.Properties.Mask.EditMask = "d";
            this.txtF_LOAD_VOLTAGE_FLOOR.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtF_LOAD_VOLTAGE_FLOOR.Size = new System.Drawing.Size(272, 22);
            this.txtF_LOAD_VOLTAGE_FLOOR.StyleController = this.lcDetail;
            this.txtF_LOAD_VOLTAGE_FLOOR.TabIndex = 46;
            // 
            // txtF_LOAD_VOLTAGE_CEILING
            // 
            this.txtF_LOAD_VOLTAGE_CEILING.Location = new System.Drawing.Point(235, 174);
            this.txtF_LOAD_VOLTAGE_CEILING.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_LOAD_VOLTAGE_CEILING.Name = "txtF_LOAD_VOLTAGE_CEILING";
            this.txtF_LOAD_VOLTAGE_CEILING.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_LOAD_VOLTAGE_CEILING.Properties.Appearance.Options.UseFont = true;
            this.txtF_LOAD_VOLTAGE_CEILING.Properties.Appearance.Options.UseTextOptions = true;
            this.txtF_LOAD_VOLTAGE_CEILING.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtF_LOAD_VOLTAGE_CEILING.Properties.Mask.EditMask = "d";
            this.txtF_LOAD_VOLTAGE_CEILING.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtF_LOAD_VOLTAGE_CEILING.Size = new System.Drawing.Size(272, 22);
            this.txtF_LOAD_VOLTAGE_CEILING.StyleController = this.lcDetail;
            this.txtF_LOAD_VOLTAGE_CEILING.TabIndex = 45;
            // 
            // txtF_LOAD_PULSECURRENT_FLOOR
            // 
            this.txtF_LOAD_PULSECURRENT_FLOOR.Location = new System.Drawing.Point(642, 150);
            this.txtF_LOAD_PULSECURRENT_FLOOR.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_LOAD_PULSECURRENT_FLOOR.Name = "txtF_LOAD_PULSECURRENT_FLOOR";
            this.txtF_LOAD_PULSECURRENT_FLOOR.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_LOAD_PULSECURRENT_FLOOR.Properties.Appearance.Options.UseFont = true;
            this.txtF_LOAD_PULSECURRENT_FLOOR.Properties.Appearance.Options.UseTextOptions = true;
            this.txtF_LOAD_PULSECURRENT_FLOOR.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtF_LOAD_PULSECURRENT_FLOOR.Properties.Mask.EditMask = "d";
            this.txtF_LOAD_PULSECURRENT_FLOOR.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtF_LOAD_PULSECURRENT_FLOOR.Size = new System.Drawing.Size(272, 22);
            this.txtF_LOAD_PULSECURRENT_FLOOR.StyleController = this.lcDetail;
            this.txtF_LOAD_PULSECURRENT_FLOOR.TabIndex = 45;
            // 
            // txtF_LOAD_PULSECURRENT_CEILING
            // 
            this.txtF_LOAD_PULSECURRENT_CEILING.Location = new System.Drawing.Point(235, 150);
            this.txtF_LOAD_PULSECURRENT_CEILING.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_LOAD_PULSECURRENT_CEILING.Name = "txtF_LOAD_PULSECURRENT_CEILING";
            this.txtF_LOAD_PULSECURRENT_CEILING.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_LOAD_PULSECURRENT_CEILING.Properties.Appearance.Options.UseFont = true;
            this.txtF_LOAD_PULSECURRENT_CEILING.Properties.Appearance.Options.UseTextOptions = true;
            this.txtF_LOAD_PULSECURRENT_CEILING.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtF_LOAD_PULSECURRENT_CEILING.Properties.Mask.EditMask = "d";
            this.txtF_LOAD_PULSECURRENT_CEILING.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtF_LOAD_PULSECURRENT_CEILING.Size = new System.Drawing.Size(272, 22);
            this.txtF_LOAD_PULSECURRENT_CEILING.StyleController = this.lcDetail;
            this.txtF_LOAD_PULSECURRENT_CEILING.TabIndex = 44;
            // 
            // txtF_LOAD_STABLECURRENT_CEILING
            // 
            this.txtF_LOAD_STABLECURRENT_CEILING.Location = new System.Drawing.Point(235, 126);
            this.txtF_LOAD_STABLECURRENT_CEILING.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_LOAD_STABLECURRENT_CEILING.Name = "txtF_LOAD_STABLECURRENT_CEILING";
            this.txtF_LOAD_STABLECURRENT_CEILING.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_LOAD_STABLECURRENT_CEILING.Properties.Appearance.Options.UseFont = true;
            this.txtF_LOAD_STABLECURRENT_CEILING.Properties.Appearance.Options.UseTextOptions = true;
            this.txtF_LOAD_STABLECURRENT_CEILING.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtF_LOAD_STABLECURRENT_CEILING.Properties.Mask.EditMask = "d";
            this.txtF_LOAD_STABLECURRENT_CEILING.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtF_LOAD_STABLECURRENT_CEILING.Size = new System.Drawing.Size(272, 22);
            this.txtF_LOAD_STABLECURRENT_CEILING.StyleController = this.lcDetail;
            this.txtF_LOAD_STABLECURRENT_CEILING.TabIndex = 43;
            // 
            // lueF_LOAD_VOLTAGE_TYPE
            // 
            this.lueF_LOAD_VOLTAGE_TYPE.Location = new System.Drawing.Point(235, 102);
            this.lueF_LOAD_VOLTAGE_TYPE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lueF_LOAD_VOLTAGE_TYPE.Name = "lueF_LOAD_VOLTAGE_TYPE";
            this.lueF_LOAD_VOLTAGE_TYPE.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lueF_LOAD_VOLTAGE_TYPE.Properties.Appearance.Options.UseFont = true;
            this.lueF_LOAD_VOLTAGE_TYPE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueF_LOAD_VOLTAGE_TYPE.Properties.NullText = "";
            this.lueF_LOAD_VOLTAGE_TYPE.Size = new System.Drawing.Size(272, 22);
            this.lueF_LOAD_VOLTAGE_TYPE.StyleController = this.lcDetail;
            this.lueF_LOAD_VOLTAGE_TYPE.TabIndex = 44;
            // 
            // rdoF_DEL
            // 
            this.rdoF_DEL.Location = new System.Drawing.Point(642, 198);
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
            this.rdoF_DEL.Size = new System.Drawing.Size(272, 25);
            this.rdoF_DEL.StyleController = this.lcDetail;
            this.rdoF_DEL.TabIndex = 5;
            // 
            // txtF_LOAD_DESCRIPTION
            // 
            this.txtF_LOAD_DESCRIPTION.Location = new System.Drawing.Point(235, 225);
            this.txtF_LOAD_DESCRIPTION.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_LOAD_DESCRIPTION.Name = "txtF_LOAD_DESCRIPTION";
            this.txtF_LOAD_DESCRIPTION.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_LOAD_DESCRIPTION.Properties.Appearance.Options.UseFont = true;
            this.txtF_LOAD_DESCRIPTION.Properties.MaxLength = 250;
            this.txtF_LOAD_DESCRIPTION.Size = new System.Drawing.Size(679, 45);
            this.txtF_LOAD_DESCRIPTION.StyleController = this.lcDetail;
            this.txtF_LOAD_DESCRIPTION.TabIndex = 6;
            // 
            // txtF_LOAD_STABLECURRENT_FLOOR
            // 
            this.txtF_LOAD_STABLECURRENT_FLOOR.Location = new System.Drawing.Point(642, 126);
            this.txtF_LOAD_STABLECURRENT_FLOOR.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_LOAD_STABLECURRENT_FLOOR.Name = "txtF_LOAD_STABLECURRENT_FLOOR";
            this.txtF_LOAD_STABLECURRENT_FLOOR.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_LOAD_STABLECURRENT_FLOOR.Properties.Appearance.Options.UseFont = true;
            this.txtF_LOAD_STABLECURRENT_FLOOR.Properties.Appearance.Options.UseTextOptions = true;
            this.txtF_LOAD_STABLECURRENT_FLOOR.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtF_LOAD_STABLECURRENT_FLOOR.Properties.Mask.EditMask = "d";
            this.txtF_LOAD_STABLECURRENT_FLOOR.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtF_LOAD_STABLECURRENT_FLOOR.Size = new System.Drawing.Size(272, 22);
            this.txtF_LOAD_STABLECURRENT_FLOOR.StyleController = this.lcDetail;
            this.txtF_LOAD_STABLECURRENT_FLOOR.TabIndex = 44;
            // 
            // txtF_CONDUCTYLOAD_COEFFECIENCY
            // 
            this.txtF_CONDUCTYLOAD_COEFFECIENCY.Location = new System.Drawing.Point(642, 78);
            this.txtF_CONDUCTYLOAD_COEFFECIENCY.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_CONDUCTYLOAD_COEFFECIENCY.Name = "txtF_CONDUCTYLOAD_COEFFECIENCY";
            this.txtF_CONDUCTYLOAD_COEFFECIENCY.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_CONDUCTYLOAD_COEFFECIENCY.Properties.Appearance.Options.UseFont = true;
            this.txtF_CONDUCTYLOAD_COEFFECIENCY.Properties.Appearance.Options.UseTextOptions = true;
            this.txtF_CONDUCTYLOAD_COEFFECIENCY.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtF_CONDUCTYLOAD_COEFFECIENCY.Properties.Mask.EditMask = "d";
            this.txtF_CONDUCTYLOAD_COEFFECIENCY.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtF_CONDUCTYLOAD_COEFFECIENCY.Size = new System.Drawing.Size(272, 22);
            this.txtF_CONDUCTYLOAD_COEFFECIENCY.StyleController = this.lcDetail;
            this.txtF_CONDUCTYLOAD_COEFFECIENCY.TabIndex = 43;
            // 
            // txtF_PROPERTY_ID
            // 
            this.txtF_PROPERTY_ID.Location = new System.Drawing.Point(642, 30);
            this.txtF_PROPERTY_ID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_PROPERTY_ID.Name = "txtF_PROPERTY_ID";
            this.txtF_PROPERTY_ID.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_PROPERTY_ID.Properties.Appearance.Options.UseFont = true;
            this.txtF_PROPERTY_ID.Properties.Mask.EditMask = "d";
            this.txtF_PROPERTY_ID.Size = new System.Drawing.Size(272, 22);
            this.txtF_PROPERTY_ID.StyleController = this.lcDetail;
            this.txtF_PROPERTY_ID.TabIndex = 4;
            // 
            // txtF_LOAD_NAME
            // 
            this.txtF_LOAD_NAME.Location = new System.Drawing.Point(642, 6);
            this.txtF_LOAD_NAME.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_LOAD_NAME.Name = "txtF_LOAD_NAME";
            this.txtF_LOAD_NAME.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_LOAD_NAME.Properties.Appearance.Options.UseFont = true;
            this.txtF_LOAD_NAME.Size = new System.Drawing.Size(272, 22);
            this.txtF_LOAD_NAME.StyleController = this.lcDetail;
            this.txtF_LOAD_NAME.TabIndex = 1;
            // 
            // txtF_LOAD_POSTION
            // 
            this.txtF_LOAD_POSTION.Location = new System.Drawing.Point(235, 30);
            this.txtF_LOAD_POSTION.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_LOAD_POSTION.Name = "txtF_LOAD_POSTION";
            this.txtF_LOAD_POSTION.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_LOAD_POSTION.Properties.Appearance.Options.UseFont = true;
            this.txtF_LOAD_POSTION.Properties.Mask.EditMask = "d";
            this.txtF_LOAD_POSTION.Size = new System.Drawing.Size(272, 22);
            this.txtF_LOAD_POSTION.StyleController = this.lcDetail;
            this.txtF_LOAD_POSTION.TabIndex = 3;
            // 
            // txtF_LOAD_ID
            // 
            this.txtF_LOAD_ID.Location = new System.Drawing.Point(235, 6);
            this.txtF_LOAD_ID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_LOAD_ID.Name = "txtF_LOAD_ID";
            this.txtF_LOAD_ID.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_LOAD_ID.Properties.Appearance.Options.UseFont = true;
            this.txtF_LOAD_ID.Size = new System.Drawing.Size(272, 22);
            this.txtF_LOAD_ID.StyleController = this.lcDetail;
            this.txtF_LOAD_ID.TabIndex = 0;
            // 
            // lueF_LOAD_TYPE
            // 
            this.lueF_LOAD_TYPE.Location = new System.Drawing.Point(235, 78);
            this.lueF_LOAD_TYPE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lueF_LOAD_TYPE.Name = "lueF_LOAD_TYPE";
            this.lueF_LOAD_TYPE.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lueF_LOAD_TYPE.Properties.Appearance.Options.UseFont = true;
            this.lueF_LOAD_TYPE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueF_LOAD_TYPE.Properties.NullText = "";
            this.lueF_LOAD_TYPE.Size = new System.Drawing.Size(272, 22);
            this.lueF_LOAD_TYPE.StyleController = this.lcDetail;
            this.lueF_LOAD_TYPE.TabIndex = 43;
            // 
            // txtChannelNum
            // 
            this.txtChannelNum.Enabled = false;
            this.txtChannelNum.Location = new System.Drawing.Point(235, 198);
            this.txtChannelNum.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtChannelNum.Name = "txtChannelNum";
            this.txtChannelNum.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtChannelNum.Properties.Appearance.Options.UseFont = true;
            this.txtChannelNum.Properties.Appearance.Options.UseTextOptions = true;
            this.txtChannelNum.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtChannelNum.Properties.Mask.EditMask = "d";
            this.txtChannelNum.Size = new System.Drawing.Size(272, 22);
            this.txtChannelNum.StyleController = this.lcDetail;
            this.txtChannelNum.TabIndex = 4;
            // 
            // lcgDetail
            // 
            this.lcgDetail.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcgDetail.AppearanceItemCaption.Options.UseFont = true;
            this.lcgDetail.CustomizationFormText = "layoutControlGroup1";
            this.lcgDetail.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgDetail.GroupBordersVisible = false;
            this.lcgDetail.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciF_LOAD_ID,
            this.lciF_LOAD_NAME,
            this.lciF_LOAD_POSTION,
            this.lciF_PROPERTY_ID,
            this.lciF_LOAD_TYPE,
            this.lciF_CONDUCTYLOAD_COEFFECIENCY,
            this.lciF_LOAD_STABLECURRENT_CEILING,
            this.lciF_LOAD_PULSECURRENT_CEILING,
            this.lciF_LOAD_PULSECURRENT_FLOOR,
            this.lciF_LOAD_VOLTAGE_CEILING,
            this.lciF_LOAD_VOLTAGE_FLOOR,
            this.lciChannelNumber,
            this.lciF_DEL,
            this.lciF_LOAD_DESCRIPTION,
            this.lciF_LOAD_CALIBRATION,
            this.lciF_LOAD_VOLTAGE_TYPE,
            this.emptySpaceItem1,
            this.lciF_LOAD_STABLECURRENT_FLOOR,
            this.emptySpaceItem2});
            this.lcgDetail.Location = new System.Drawing.Point(0, 0);
            this.lcgDetail.Name = "lcgDetail";
            this.lcgDetail.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgDetail.Size = new System.Drawing.Size(1014, 276);
            this.lcgDetail.Spacing = new DevExpress.XtraLayout.Utils.Padding(100, 100, 5, 5);
            this.lcgDetail.Text = "lcgDetail";
            this.lcgDetail.TextVisible = false;
            // 
            // lciF_LOAD_ID
            // 
            this.lciF_LOAD_ID.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_LOAD_ID.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_LOAD_ID.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_LOAD_ID.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_LOAD_ID.Control = this.txtF_LOAD_ID;
            this.lciF_LOAD_ID.CustomizationFormText = "编号：";
            this.lciF_LOAD_ID.Location = new System.Drawing.Point(0, 0);
            this.lciF_LOAD_ID.Name = "lciF_LOAD_ID";
            this.lciF_LOAD_ID.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_LOAD_ID.Size = new System.Drawing.Size(407, 24);
            this.lciF_LOAD_ID.Text = "负载柜编号：";
            this.lciF_LOAD_ID.TextSize = new System.Drawing.Size(126, 14);
            // 
            // lciF_LOAD_NAME
            // 
            this.lciF_LOAD_NAME.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_LOAD_NAME.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_LOAD_NAME.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_LOAD_NAME.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_LOAD_NAME.Control = this.txtF_LOAD_NAME;
            this.lciF_LOAD_NAME.CustomizationFormText = "名称：";
            this.lciF_LOAD_NAME.Location = new System.Drawing.Point(407, 0);
            this.lciF_LOAD_NAME.Name = "lciF_LOAD_NAME";
            this.lciF_LOAD_NAME.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_LOAD_NAME.Size = new System.Drawing.Size(407, 24);
            this.lciF_LOAD_NAME.Text = "负载柜名称：";
            this.lciF_LOAD_NAME.TextSize = new System.Drawing.Size(126, 14);
            // 
            // lciF_LOAD_POSTION
            // 
            this.lciF_LOAD_POSTION.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lciF_LOAD_POSTION.AppearanceItemCaption.ForeColor = System.Drawing.Color.Black;
            this.lciF_LOAD_POSTION.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_LOAD_POSTION.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_LOAD_POSTION.Control = this.txtF_LOAD_POSTION;
            this.lciF_LOAD_POSTION.CustomizationFormText = "位置：";
            this.lciF_LOAD_POSTION.Location = new System.Drawing.Point(0, 24);
            this.lciF_LOAD_POSTION.Name = "lciF_LOAD_POSTION";
            this.lciF_LOAD_POSTION.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_LOAD_POSTION.Size = new System.Drawing.Size(407, 24);
            this.lciF_LOAD_POSTION.Text = "负载柜位置：";
            this.lciF_LOAD_POSTION.TextSize = new System.Drawing.Size(126, 14);
            // 
            // lciF_PROPERTY_ID
            // 
            this.lciF_PROPERTY_ID.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lciF_PROPERTY_ID.AppearanceItemCaption.ForeColor = System.Drawing.Color.Black;
            this.lciF_PROPERTY_ID.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_PROPERTY_ID.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_PROPERTY_ID.Control = this.txtF_PROPERTY_ID;
            this.lciF_PROPERTY_ID.CustomizationFormText = "资产编号：";
            this.lciF_PROPERTY_ID.Location = new System.Drawing.Point(407, 24);
            this.lciF_PROPERTY_ID.Name = "lciF_PROPERTY_ID";
            this.lciF_PROPERTY_ID.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_PROPERTY_ID.Size = new System.Drawing.Size(407, 24);
            this.lciF_PROPERTY_ID.Text = "资产编号：";
            this.lciF_PROPERTY_ID.TextSize = new System.Drawing.Size(126, 14);
            // 
            // lciF_LOAD_TYPE
            // 
            this.lciF_LOAD_TYPE.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_LOAD_TYPE.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_LOAD_TYPE.Control = this.lueF_LOAD_TYPE;
            this.lciF_LOAD_TYPE.CustomizationFormText = "负载类型：";
            this.lciF_LOAD_TYPE.Location = new System.Drawing.Point(0, 72);
            this.lciF_LOAD_TYPE.Name = "lciF_LOAD_TYPE";
            this.lciF_LOAD_TYPE.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_LOAD_TYPE.Size = new System.Drawing.Size(407, 24);
            this.lciF_LOAD_TYPE.Text = "负载类型：";
            this.lciF_LOAD_TYPE.TextSize = new System.Drawing.Size(126, 14);
            // 
            // lciF_CONDUCTYLOAD_COEFFECIENCY
            // 
            this.lciF_CONDUCTYLOAD_COEFFECIENCY.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_CONDUCTYLOAD_COEFFECIENCY.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_CONDUCTYLOAD_COEFFECIENCY.Control = this.txtF_CONDUCTYLOAD_COEFFECIENCY;
            this.lciF_CONDUCTYLOAD_COEFFECIENCY.CustomizationFormText = "感性负载功率因素：";
            this.lciF_CONDUCTYLOAD_COEFFECIENCY.Location = new System.Drawing.Point(407, 72);
            this.lciF_CONDUCTYLOAD_COEFFECIENCY.Name = "lciF_CONDUCTYLOAD_COEFFECIENCY";
            this.lciF_CONDUCTYLOAD_COEFFECIENCY.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_CONDUCTYLOAD_COEFFECIENCY.Size = new System.Drawing.Size(407, 24);
            this.lciF_CONDUCTYLOAD_COEFFECIENCY.Text = "感性负载功率因素：";
            this.lciF_CONDUCTYLOAD_COEFFECIENCY.TextSize = new System.Drawing.Size(126, 14);
            // 
            // lciF_LOAD_STABLECURRENT_CEILING
            // 
            this.lciF_LOAD_STABLECURRENT_CEILING.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_LOAD_STABLECURRENT_CEILING.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_LOAD_STABLECURRENT_CEILING.Control = this.txtF_LOAD_STABLECURRENT_CEILING;
            this.lciF_LOAD_STABLECURRENT_CEILING.CustomizationFormText = "稳态电流上限：";
            this.lciF_LOAD_STABLECURRENT_CEILING.Location = new System.Drawing.Point(0, 120);
            this.lciF_LOAD_STABLECURRENT_CEILING.Name = "lciF_LOAD_STABLECURRENT_CEILING";
            this.lciF_LOAD_STABLECURRENT_CEILING.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_LOAD_STABLECURRENT_CEILING.Size = new System.Drawing.Size(407, 24);
            this.lciF_LOAD_STABLECURRENT_CEILING.Text = "稳态电流上限：";
            this.lciF_LOAD_STABLECURRENT_CEILING.TextSize = new System.Drawing.Size(126, 14);
            // 
            // lciF_LOAD_PULSECURRENT_CEILING
            // 
            this.lciF_LOAD_PULSECURRENT_CEILING.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_LOAD_PULSECURRENT_CEILING.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_LOAD_PULSECURRENT_CEILING.Control = this.txtF_LOAD_PULSECURRENT_CEILING;
            this.lciF_LOAD_PULSECURRENT_CEILING.CustomizationFormText = "冲击电流上限：";
            this.lciF_LOAD_PULSECURRENT_CEILING.Location = new System.Drawing.Point(0, 144);
            this.lciF_LOAD_PULSECURRENT_CEILING.Name = "lciF_LOAD_PULSECURRENT_CEILING";
            this.lciF_LOAD_PULSECURRENT_CEILING.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_LOAD_PULSECURRENT_CEILING.Size = new System.Drawing.Size(407, 24);
            this.lciF_LOAD_PULSECURRENT_CEILING.Text = "冲击电流上限：";
            this.lciF_LOAD_PULSECURRENT_CEILING.TextSize = new System.Drawing.Size(126, 14);
            // 
            // lciF_LOAD_PULSECURRENT_FLOOR
            // 
            this.lciF_LOAD_PULSECURRENT_FLOOR.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_LOAD_PULSECURRENT_FLOOR.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_LOAD_PULSECURRENT_FLOOR.Control = this.txtF_LOAD_PULSECURRENT_FLOOR;
            this.lciF_LOAD_PULSECURRENT_FLOOR.CustomizationFormText = "冲击电流下线：";
            this.lciF_LOAD_PULSECURRENT_FLOOR.Location = new System.Drawing.Point(407, 144);
            this.lciF_LOAD_PULSECURRENT_FLOOR.Name = "lciF_LOAD_PULSECURRENT_FLOOR";
            this.lciF_LOAD_PULSECURRENT_FLOOR.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_LOAD_PULSECURRENT_FLOOR.Size = new System.Drawing.Size(407, 24);
            this.lciF_LOAD_PULSECURRENT_FLOOR.Text = "冲击电流下线：";
            this.lciF_LOAD_PULSECURRENT_FLOOR.TextSize = new System.Drawing.Size(126, 14);
            // 
            // lciF_LOAD_VOLTAGE_CEILING
            // 
            this.lciF_LOAD_VOLTAGE_CEILING.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_LOAD_VOLTAGE_CEILING.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_LOAD_VOLTAGE_CEILING.Control = this.txtF_LOAD_VOLTAGE_CEILING;
            this.lciF_LOAD_VOLTAGE_CEILING.CustomizationFormText = "负载电压上限：";
            this.lciF_LOAD_VOLTAGE_CEILING.Location = new System.Drawing.Point(0, 168);
            this.lciF_LOAD_VOLTAGE_CEILING.Name = "lciF_LOAD_VOLTAGE_CEILING";
            this.lciF_LOAD_VOLTAGE_CEILING.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_LOAD_VOLTAGE_CEILING.Size = new System.Drawing.Size(407, 24);
            this.lciF_LOAD_VOLTAGE_CEILING.Text = "负载电压上限：";
            this.lciF_LOAD_VOLTAGE_CEILING.TextSize = new System.Drawing.Size(126, 14);
            // 
            // lciF_LOAD_VOLTAGE_FLOOR
            // 
            this.lciF_LOAD_VOLTAGE_FLOOR.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_LOAD_VOLTAGE_FLOOR.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_LOAD_VOLTAGE_FLOOR.Control = this.txtF_LOAD_VOLTAGE_FLOOR;
            this.lciF_LOAD_VOLTAGE_FLOOR.CustomizationFormText = "负载电压下限：";
            this.lciF_LOAD_VOLTAGE_FLOOR.Location = new System.Drawing.Point(407, 168);
            this.lciF_LOAD_VOLTAGE_FLOOR.Name = "lciF_LOAD_VOLTAGE_FLOOR";
            this.lciF_LOAD_VOLTAGE_FLOOR.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_LOAD_VOLTAGE_FLOOR.Size = new System.Drawing.Size(407, 24);
            this.lciF_LOAD_VOLTAGE_FLOOR.Text = "负载电压下限：";
            this.lciF_LOAD_VOLTAGE_FLOOR.TextSize = new System.Drawing.Size(126, 14);
            // 
            // lciChannelNumber
            // 
            this.lciChannelNumber.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciChannelNumber.AppearanceItemCaption.Options.UseFont = true;
            this.lciChannelNumber.Control = this.txtChannelNum;
            this.lciChannelNumber.CustomizationFormText = "通道数量：";
            this.lciChannelNumber.Location = new System.Drawing.Point(0, 192);
            this.lciChannelNumber.Name = "lciChannelNumber";
            this.lciChannelNumber.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciChannelNumber.Size = new System.Drawing.Size(407, 27);
            this.lciChannelNumber.Text = "通道数量：";
            this.lciChannelNumber.TextSize = new System.Drawing.Size(126, 14);
            // 
            // lciF_DEL
            // 
            this.lciF_DEL.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_DEL.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_DEL.Control = this.rdoF_DEL;
            this.lciF_DEL.CustomizationFormText = "禁用状态：";
            this.lciF_DEL.Location = new System.Drawing.Point(407, 192);
            this.lciF_DEL.Name = "lciF_DEL";
            this.lciF_DEL.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_DEL.Size = new System.Drawing.Size(407, 27);
            this.lciF_DEL.Text = "禁用状态：";
            this.lciF_DEL.TextSize = new System.Drawing.Size(126, 14);
            // 
            // lciF_LOAD_DESCRIPTION
            // 
            this.lciF_LOAD_DESCRIPTION.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_LOAD_DESCRIPTION.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_LOAD_DESCRIPTION.Control = this.txtF_LOAD_DESCRIPTION;
            this.lciF_LOAD_DESCRIPTION.CustomizationFormText = "备注：";
            this.lciF_LOAD_DESCRIPTION.Location = new System.Drawing.Point(0, 219);
            this.lciF_LOAD_DESCRIPTION.Name = "lciF_LOAD_DESCRIPTION";
            this.lciF_LOAD_DESCRIPTION.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_LOAD_DESCRIPTION.Size = new System.Drawing.Size(814, 47);
            this.lciF_LOAD_DESCRIPTION.Text = "备注：";
            this.lciF_LOAD_DESCRIPTION.TextSize = new System.Drawing.Size(126, 14);
            // 
            // lciF_LOAD_CALIBRATION
            // 
            this.lciF_LOAD_CALIBRATION.Control = this.txtF_LOAD_CALIBRATION;
            this.lciF_LOAD_CALIBRATION.CustomizationFormText = "校准编号：";
            this.lciF_LOAD_CALIBRATION.Location = new System.Drawing.Point(0, 48);
            this.lciF_LOAD_CALIBRATION.Name = "lciF_LOAD_CALIBRATION";
            this.lciF_LOAD_CALIBRATION.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_LOAD_CALIBRATION.Size = new System.Drawing.Size(407, 24);
            this.lciF_LOAD_CALIBRATION.Text = "校准编号：";
            this.lciF_LOAD_CALIBRATION.TextSize = new System.Drawing.Size(126, 14);
            // 
            // lciF_LOAD_VOLTAGE_TYPE
            // 
            this.lciF_LOAD_VOLTAGE_TYPE.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_LOAD_VOLTAGE_TYPE.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_LOAD_VOLTAGE_TYPE.Control = this.lueF_LOAD_VOLTAGE_TYPE;
            this.lciF_LOAD_VOLTAGE_TYPE.CustomizationFormText = "负载电压类型：";
            this.lciF_LOAD_VOLTAGE_TYPE.Location = new System.Drawing.Point(0, 96);
            this.lciF_LOAD_VOLTAGE_TYPE.Name = "lciF_LOAD_VOLTAGE_TYPE";
            this.lciF_LOAD_VOLTAGE_TYPE.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_LOAD_VOLTAGE_TYPE.Size = new System.Drawing.Size(407, 24);
            this.lciF_LOAD_VOLTAGE_TYPE.Text = "负载电压类型：";
            this.lciF_LOAD_VOLTAGE_TYPE.TextSize = new System.Drawing.Size(126, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(407, 96);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(407, 24);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciF_LOAD_STABLECURRENT_FLOOR
            // 
            this.lciF_LOAD_STABLECURRENT_FLOOR.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_LOAD_STABLECURRENT_FLOOR.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_LOAD_STABLECURRENT_FLOOR.Control = this.txtF_LOAD_STABLECURRENT_FLOOR;
            this.lciF_LOAD_STABLECURRENT_FLOOR.CustomizationFormText = "稳态电流下限：";
            this.lciF_LOAD_STABLECURRENT_FLOOR.Location = new System.Drawing.Point(407, 120);
            this.lciF_LOAD_STABLECURRENT_FLOOR.Name = "lciF_LOAD_STABLECURRENT_FLOOR";
            this.lciF_LOAD_STABLECURRENT_FLOOR.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 0, 1, 1);
            this.lciF_LOAD_STABLECURRENT_FLOOR.Size = new System.Drawing.Size(407, 24);
            this.lciF_LOAD_STABLECURRENT_FLOOR.Text = "稳态电流下限：";
            this.lciF_LOAD_STABLECURRENT_FLOOR.TextSize = new System.Drawing.Size(126, 14);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(407, 48);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(407, 24);
            this.emptySpaceItem2.Text = "emptySpaceItem2";
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
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
            // gcList
            // 
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcList.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gcList.Location = new System.Drawing.Point(0, 0);
            this.gcList.MainView = this.gvList;
            this.gcList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcList.Name = "gcList";
            this.gcList.Size = new System.Drawing.Size(1014, 181);
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
            this.colF_LOAD_ID,
            this.colF_LOAD_NAME,
            this.colF_LOAD_CALIBRATION,
            this.colF_LOAD_POSTION,
            this.colF_PROPERTY_ID,
            this.colF_LOAD_TYPE,
            this.colF_CONDUCTYLOAD_COEFFECIENCY,
            this.colF_LOAD_VOLTAGE_TYPE,
            this.colF_LOAD_STABLECURRENT_CEILING,
            this.colF_LOAD_STABLECURRENT_FLOOR,
            this.colF_LOAD_PULSECURRENT_CEILING,
            this.colF_LOAD_PULSECURRENT_FLOOR,
            this.colF_LOAD_VOLTAGE_CEILING,
            this.colF_LOAD_VOLTAGE_FLOOR,
            this.colF_LOAD_DESCRIPTION,
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
            // colF_LOAD_ID
            // 
            this.colF_LOAD_ID.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_LOAD_ID.AppearanceCell.Options.UseFont = true;
            this.colF_LOAD_ID.AppearanceCell.Options.UseTextOptions = true;
            this.colF_LOAD_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_LOAD_ID.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colF_LOAD_ID.AppearanceHeader.Options.UseFont = true;
            this.colF_LOAD_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_LOAD_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_LOAD_ID.Caption = "负载柜编号";
            this.colF_LOAD_ID.FieldName = "F_LOAD_ID";
            this.colF_LOAD_ID.Name = "colF_LOAD_ID";
            this.colF_LOAD_ID.OptionsColumn.AllowEdit = false;
            this.colF_LOAD_ID.OptionsColumn.AllowFocus = false;
            this.colF_LOAD_ID.Visible = true;
            this.colF_LOAD_ID.VisibleIndex = 0;
            this.colF_LOAD_ID.Width = 118;
            // 
            // colF_LOAD_NAME
            // 
            this.colF_LOAD_NAME.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_LOAD_NAME.AppearanceCell.Options.UseFont = true;
            this.colF_LOAD_NAME.AppearanceCell.Options.UseTextOptions = true;
            this.colF_LOAD_NAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_LOAD_NAME.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colF_LOAD_NAME.AppearanceHeader.Options.UseFont = true;
            this.colF_LOAD_NAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_LOAD_NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_LOAD_NAME.Caption = "负载柜名称";
            this.colF_LOAD_NAME.FieldName = "F_LOAD_NAME";
            this.colF_LOAD_NAME.Name = "colF_LOAD_NAME";
            this.colF_LOAD_NAME.OptionsColumn.AllowEdit = false;
            this.colF_LOAD_NAME.OptionsColumn.AllowFocus = false;
            this.colF_LOAD_NAME.Visible = true;
            this.colF_LOAD_NAME.VisibleIndex = 1;
            this.colF_LOAD_NAME.Width = 213;
            // 
            // colF_LOAD_CALIBRATION
            // 
            this.colF_LOAD_CALIBRATION.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colF_LOAD_CALIBRATION.AppearanceCell.Options.UseFont = true;
            this.colF_LOAD_CALIBRATION.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colF_LOAD_CALIBRATION.AppearanceHeader.Options.UseFont = true;
            this.colF_LOAD_CALIBRATION.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_LOAD_CALIBRATION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_LOAD_CALIBRATION.Caption = "校准编号";
            this.colF_LOAD_CALIBRATION.FieldName = "F_LOAD_CALIBRATION";
            this.colF_LOAD_CALIBRATION.Name = "colF_LOAD_CALIBRATION";
            this.colF_LOAD_CALIBRATION.OptionsColumn.AllowEdit = false;
            this.colF_LOAD_CALIBRATION.OptionsColumn.AllowFocus = false;
            this.colF_LOAD_CALIBRATION.Visible = true;
            this.colF_LOAD_CALIBRATION.VisibleIndex = 2;
            // 
            // colF_LOAD_POSTION
            // 
            this.colF_LOAD_POSTION.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_LOAD_POSTION.AppearanceCell.Options.UseFont = true;
            this.colF_LOAD_POSTION.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colF_LOAD_POSTION.AppearanceHeader.Options.UseFont = true;
            this.colF_LOAD_POSTION.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_LOAD_POSTION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_LOAD_POSTION.Caption = "负载柜位置";
            this.colF_LOAD_POSTION.FieldName = "F_LOAD_POSTION";
            this.colF_LOAD_POSTION.Name = "colF_LOAD_POSTION";
            this.colF_LOAD_POSTION.OptionsColumn.AllowEdit = false;
            this.colF_LOAD_POSTION.OptionsColumn.AllowFocus = false;
            this.colF_LOAD_POSTION.Visible = true;
            this.colF_LOAD_POSTION.VisibleIndex = 3;
            this.colF_LOAD_POSTION.Width = 123;
            // 
            // colF_PROPERTY_ID
            // 
            this.colF_PROPERTY_ID.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_PROPERTY_ID.AppearanceCell.Options.UseFont = true;
            this.colF_PROPERTY_ID.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colF_PROPERTY_ID.AppearanceHeader.Options.UseFont = true;
            this.colF_PROPERTY_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_PROPERTY_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_PROPERTY_ID.Caption = "资产编号";
            this.colF_PROPERTY_ID.FieldName = "F_PROPERTY_ID";
            this.colF_PROPERTY_ID.Name = "colF_PROPERTY_ID";
            this.colF_PROPERTY_ID.OptionsColumn.AllowEdit = false;
            this.colF_PROPERTY_ID.OptionsColumn.AllowFocus = false;
            this.colF_PROPERTY_ID.Visible = true;
            this.colF_PROPERTY_ID.VisibleIndex = 4;
            this.colF_PROPERTY_ID.Width = 104;
            // 
            // colF_LOAD_TYPE
            // 
            this.colF_LOAD_TYPE.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colF_LOAD_TYPE.AppearanceHeader.Options.UseFont = true;
            this.colF_LOAD_TYPE.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_LOAD_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_LOAD_TYPE.Caption = "负载类型";
            this.colF_LOAD_TYPE.FieldName = "F_LOAD_TYPE";
            this.colF_LOAD_TYPE.Name = "colF_LOAD_TYPE";
            this.colF_LOAD_TYPE.OptionsColumn.AllowEdit = false;
            this.colF_LOAD_TYPE.OptionsColumn.AllowFocus = false;
            this.colF_LOAD_TYPE.Visible = true;
            this.colF_LOAD_TYPE.VisibleIndex = 5;
            // 
            // colF_CONDUCTYLOAD_COEFFECIENCY
            // 
            this.colF_CONDUCTYLOAD_COEFFECIENCY.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colF_CONDUCTYLOAD_COEFFECIENCY.AppearanceHeader.Options.UseFont = true;
            this.colF_CONDUCTYLOAD_COEFFECIENCY.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_CONDUCTYLOAD_COEFFECIENCY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_CONDUCTYLOAD_COEFFECIENCY.Caption = "感性负载功率因素";
            this.colF_CONDUCTYLOAD_COEFFECIENCY.FieldName = "F_CONDUCTYLOAD_COEFFECIENCY";
            this.colF_CONDUCTYLOAD_COEFFECIENCY.Name = "colF_CONDUCTYLOAD_COEFFECIENCY";
            this.colF_CONDUCTYLOAD_COEFFECIENCY.OptionsColumn.AllowEdit = false;
            this.colF_CONDUCTYLOAD_COEFFECIENCY.OptionsColumn.AllowFocus = false;
            this.colF_CONDUCTYLOAD_COEFFECIENCY.Visible = true;
            this.colF_CONDUCTYLOAD_COEFFECIENCY.VisibleIndex = 6;
            this.colF_CONDUCTYLOAD_COEFFECIENCY.Width = 149;
            // 
            // colF_LOAD_VOLTAGE_TYPE
            // 
            this.colF_LOAD_VOLTAGE_TYPE.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colF_LOAD_VOLTAGE_TYPE.AppearanceHeader.Options.UseFont = true;
            this.colF_LOAD_VOLTAGE_TYPE.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_LOAD_VOLTAGE_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_LOAD_VOLTAGE_TYPE.Caption = "负载电压类型";
            this.colF_LOAD_VOLTAGE_TYPE.FieldName = "F_LOAD_VOLTAGE_TYPE";
            this.colF_LOAD_VOLTAGE_TYPE.Name = "colF_LOAD_VOLTAGE_TYPE";
            this.colF_LOAD_VOLTAGE_TYPE.OptionsColumn.AllowEdit = false;
            this.colF_LOAD_VOLTAGE_TYPE.OptionsColumn.AllowFocus = false;
            this.colF_LOAD_VOLTAGE_TYPE.Visible = true;
            this.colF_LOAD_VOLTAGE_TYPE.VisibleIndex = 7;
            this.colF_LOAD_VOLTAGE_TYPE.Width = 143;
            // 
            // colF_LOAD_STABLECURRENT_CEILING
            // 
            this.colF_LOAD_STABLECURRENT_CEILING.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_LOAD_STABLECURRENT_CEILING.AppearanceCell.Options.UseFont = true;
            this.colF_LOAD_STABLECURRENT_CEILING.AppearanceCell.Options.UseTextOptions = true;
            this.colF_LOAD_STABLECURRENT_CEILING.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colF_LOAD_STABLECURRENT_CEILING.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colF_LOAD_STABLECURRENT_CEILING.AppearanceHeader.Options.UseFont = true;
            this.colF_LOAD_STABLECURRENT_CEILING.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_LOAD_STABLECURRENT_CEILING.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_LOAD_STABLECURRENT_CEILING.Caption = "稳态电流上限";
            this.colF_LOAD_STABLECURRENT_CEILING.FieldName = "F_LOAD_STABLECURRENT_CEILING";
            this.colF_LOAD_STABLECURRENT_CEILING.Name = "colF_LOAD_STABLECURRENT_CEILING";
            this.colF_LOAD_STABLECURRENT_CEILING.OptionsColumn.AllowEdit = false;
            this.colF_LOAD_STABLECURRENT_CEILING.OptionsColumn.AllowFocus = false;
            this.colF_LOAD_STABLECURRENT_CEILING.Visible = true;
            this.colF_LOAD_STABLECURRENT_CEILING.VisibleIndex = 8;
            this.colF_LOAD_STABLECURRENT_CEILING.Width = 128;
            // 
            // colF_LOAD_STABLECURRENT_FLOOR
            // 
            this.colF_LOAD_STABLECURRENT_FLOOR.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_LOAD_STABLECURRENT_FLOOR.AppearanceCell.Options.UseFont = true;
            this.colF_LOAD_STABLECURRENT_FLOOR.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colF_LOAD_STABLECURRENT_FLOOR.AppearanceHeader.Options.UseFont = true;
            this.colF_LOAD_STABLECURRENT_FLOOR.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_LOAD_STABLECURRENT_FLOOR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_LOAD_STABLECURRENT_FLOOR.Caption = "稳态电流下限";
            this.colF_LOAD_STABLECURRENT_FLOOR.FieldName = "F_LOAD_STABLECURRENT_FLOOR";
            this.colF_LOAD_STABLECURRENT_FLOOR.Name = "colF_LOAD_STABLECURRENT_FLOOR";
            this.colF_LOAD_STABLECURRENT_FLOOR.OptionsColumn.AllowEdit = false;
            this.colF_LOAD_STABLECURRENT_FLOOR.OptionsColumn.AllowFocus = false;
            this.colF_LOAD_STABLECURRENT_FLOOR.Visible = true;
            this.colF_LOAD_STABLECURRENT_FLOOR.VisibleIndex = 9;
            this.colF_LOAD_STABLECURRENT_FLOOR.Width = 124;
            // 
            // colF_LOAD_PULSECURRENT_CEILING
            // 
            this.colF_LOAD_PULSECURRENT_CEILING.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colF_LOAD_PULSECURRENT_CEILING.AppearanceHeader.Options.UseFont = true;
            this.colF_LOAD_PULSECURRENT_CEILING.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_LOAD_PULSECURRENT_CEILING.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_LOAD_PULSECURRENT_CEILING.Caption = "冲击电流上限";
            this.colF_LOAD_PULSECURRENT_CEILING.FieldName = "F_LOAD_PULSECURRENT_CEILING";
            this.colF_LOAD_PULSECURRENT_CEILING.Name = "colF_LOAD_PULSECURRENT_CEILING";
            this.colF_LOAD_PULSECURRENT_CEILING.OptionsColumn.AllowEdit = false;
            this.colF_LOAD_PULSECURRENT_CEILING.OptionsColumn.AllowFocus = false;
            this.colF_LOAD_PULSECURRENT_CEILING.Visible = true;
            this.colF_LOAD_PULSECURRENT_CEILING.VisibleIndex = 10;
            this.colF_LOAD_PULSECURRENT_CEILING.Width = 133;
            // 
            // colF_LOAD_PULSECURRENT_FLOOR
            // 
            this.colF_LOAD_PULSECURRENT_FLOOR.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colF_LOAD_PULSECURRENT_FLOOR.AppearanceHeader.Options.UseFont = true;
            this.colF_LOAD_PULSECURRENT_FLOOR.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_LOAD_PULSECURRENT_FLOOR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_LOAD_PULSECURRENT_FLOOR.Caption = "冲击电力下限";
            this.colF_LOAD_PULSECURRENT_FLOOR.FieldName = "F_LOAD_PULSECURRENT_FLOOR";
            this.colF_LOAD_PULSECURRENT_FLOOR.Name = "colF_LOAD_PULSECURRENT_FLOOR";
            this.colF_LOAD_PULSECURRENT_FLOOR.OptionsColumn.AllowEdit = false;
            this.colF_LOAD_PULSECURRENT_FLOOR.OptionsColumn.AllowFocus = false;
            this.colF_LOAD_PULSECURRENT_FLOOR.Visible = true;
            this.colF_LOAD_PULSECURRENT_FLOOR.VisibleIndex = 11;
            this.colF_LOAD_PULSECURRENT_FLOOR.Width = 114;
            // 
            // colF_LOAD_VOLTAGE_CEILING
            // 
            this.colF_LOAD_VOLTAGE_CEILING.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_LOAD_VOLTAGE_CEILING.AppearanceCell.Options.UseFont = true;
            this.colF_LOAD_VOLTAGE_CEILING.AppearanceCell.Options.UseTextOptions = true;
            this.colF_LOAD_VOLTAGE_CEILING.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_LOAD_VOLTAGE_CEILING.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colF_LOAD_VOLTAGE_CEILING.AppearanceHeader.Options.UseFont = true;
            this.colF_LOAD_VOLTAGE_CEILING.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_LOAD_VOLTAGE_CEILING.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_LOAD_VOLTAGE_CEILING.Caption = "负载电压上限";
            this.colF_LOAD_VOLTAGE_CEILING.FieldName = "F_LOAD_VOLTAGE_CEILING";
            this.colF_LOAD_VOLTAGE_CEILING.Name = "colF_LOAD_VOLTAGE_CEILING";
            this.colF_LOAD_VOLTAGE_CEILING.OptionsColumn.AllowEdit = false;
            this.colF_LOAD_VOLTAGE_CEILING.OptionsColumn.AllowFocus = false;
            this.colF_LOAD_VOLTAGE_CEILING.Visible = true;
            this.colF_LOAD_VOLTAGE_CEILING.VisibleIndex = 12;
            this.colF_LOAD_VOLTAGE_CEILING.Width = 144;
            // 
            // colF_LOAD_VOLTAGE_FLOOR
            // 
            this.colF_LOAD_VOLTAGE_FLOOR.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_LOAD_VOLTAGE_FLOOR.AppearanceCell.Options.UseFont = true;
            this.colF_LOAD_VOLTAGE_FLOOR.AppearanceCell.Options.UseTextOptions = true;
            this.colF_LOAD_VOLTAGE_FLOOR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_LOAD_VOLTAGE_FLOOR.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colF_LOAD_VOLTAGE_FLOOR.AppearanceHeader.Options.UseFont = true;
            this.colF_LOAD_VOLTAGE_FLOOR.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_LOAD_VOLTAGE_FLOOR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_LOAD_VOLTAGE_FLOOR.Caption = "负载电压下限";
            this.colF_LOAD_VOLTAGE_FLOOR.FieldName = "F_LOAD_VOLTAGE_FLOOR";
            this.colF_LOAD_VOLTAGE_FLOOR.Name = "colF_LOAD_VOLTAGE_FLOOR";
            this.colF_LOAD_VOLTAGE_FLOOR.OptionsColumn.AllowEdit = false;
            this.colF_LOAD_VOLTAGE_FLOOR.OptionsColumn.AllowFocus = false;
            this.colF_LOAD_VOLTAGE_FLOOR.Visible = true;
            this.colF_LOAD_VOLTAGE_FLOOR.VisibleIndex = 13;
            this.colF_LOAD_VOLTAGE_FLOOR.Width = 127;
            // 
            // colF_LOAD_DESCRIPTION
            // 
            this.colF_LOAD_DESCRIPTION.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_LOAD_DESCRIPTION.AppearanceCell.Options.UseFont = true;
            this.colF_LOAD_DESCRIPTION.AppearanceCell.Options.UseTextOptions = true;
            this.colF_LOAD_DESCRIPTION.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_LOAD_DESCRIPTION.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colF_LOAD_DESCRIPTION.AppearanceHeader.Options.UseFont = true;
            this.colF_LOAD_DESCRIPTION.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_LOAD_DESCRIPTION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_LOAD_DESCRIPTION.Caption = "备注";
            this.colF_LOAD_DESCRIPTION.FieldName = "F_LOAD_DESCRIPTION";
            this.colF_LOAD_DESCRIPTION.Name = "colF_LOAD_DESCRIPTION";
            this.colF_LOAD_DESCRIPTION.OptionsColumn.AllowEdit = false;
            this.colF_LOAD_DESCRIPTION.OptionsColumn.AllowFocus = false;
            this.colF_LOAD_DESCRIPTION.Visible = true;
            this.colF_LOAD_DESCRIPTION.VisibleIndex = 14;
            this.colF_LOAD_DESCRIPTION.Width = 347;
            // 
            // colF_DEL
            // 
            this.colF_DEL.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_DEL.AppearanceCell.Options.UseFont = true;
            this.colF_DEL.AppearanceCell.Options.UseTextOptions = true;
            this.colF_DEL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colF_DEL.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colF_DEL.AppearanceHeader.Options.UseFont = true;
            this.colF_DEL.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_DEL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_DEL.Caption = "禁用状态";
            this.colF_DEL.FieldName = "F_DEL";
            this.colF_DEL.Name = "colF_DEL";
            this.colF_DEL.OptionsColumn.AllowEdit = false;
            this.colF_DEL.OptionsColumn.AllowFocus = false;
            this.colF_DEL.Visible = true;
            this.colF_DEL.VisibleIndex = 15;
            this.colF_DEL.Width = 120;
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
            this.pnlGrid.Size = new System.Drawing.Size(1018, 391);
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
            this.splitContainerControl1.Panel2.Controls.Add(this.gcLoadChannel);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1014, 367);
            this.splitContainerControl1.SplitterPosition = 181;
            this.splitContainerControl1.TabIndex = 38;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gcLoadChannel
            // 
            this.gcLoadChannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLoadChannel.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcLoadChannel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gcLoadChannel.Location = new System.Drawing.Point(0, 0);
            this.gcLoadChannel.MainView = this.gvLoadChannel;
            this.gcLoadChannel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcLoadChannel.Name = "gcLoadChannel";
            this.gcLoadChannel.Size = new System.Drawing.Size(1014, 180);
            this.gcLoadChannel.TabIndex = 0;
            this.gcLoadChannel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLoadChannel});
            // 
            // gvLoadChannel
            // 
            this.gvLoadChannel.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvLoadChannel.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvLoadChannel.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvLoadChannel.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvLoadChannel.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvLoadChannel.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvLoadChannel.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvLoadChannel.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvLoadChannel.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvLoadChannel.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvLoadChannel.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvLoadChannel.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvLoadChannel.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvLoadChannel.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvLoadChannel.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvLoadChannel.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvLoadChannel.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvLoadChannel.Appearance.Empty.Options.UseBackColor = true;
            this.gvLoadChannel.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvLoadChannel.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvLoadChannel.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvLoadChannel.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvLoadChannel.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvLoadChannel.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvLoadChannel.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvLoadChannel.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvLoadChannel.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvLoadChannel.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvLoadChannel.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvLoadChannel.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvLoadChannel.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvLoadChannel.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvLoadChannel.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvLoadChannel.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvLoadChannel.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvLoadChannel.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvLoadChannel.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvLoadChannel.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvLoadChannel.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvLoadChannel.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvLoadChannel.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvLoadChannel.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvLoadChannel.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvLoadChannel.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvLoadChannel.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvLoadChannel.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvLoadChannel.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvLoadChannel.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvLoadChannel.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvLoadChannel.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvLoadChannel.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvLoadChannel.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvLoadChannel.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvLoadChannel.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvLoadChannel.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvLoadChannel.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvLoadChannel.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvLoadChannel.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvLoadChannel.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvLoadChannel.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvLoadChannel.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvLoadChannel.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvLoadChannel.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvLoadChannel.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvLoadChannel.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvLoadChannel.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvLoadChannel.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvLoadChannel.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvLoadChannel.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvLoadChannel.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvLoadChannel.Appearance.GroupRow.Options.UseFont = true;
            this.gvLoadChannel.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvLoadChannel.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvLoadChannel.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvLoadChannel.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvLoadChannel.Appearance.HeaderPanel.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.gvLoadChannel.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvLoadChannel.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvLoadChannel.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvLoadChannel.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvLoadChannel.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvLoadChannel.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvLoadChannel.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvLoadChannel.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvLoadChannel.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvLoadChannel.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvLoadChannel.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvLoadChannel.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvLoadChannel.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvLoadChannel.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvLoadChannel.Appearance.OddRow.Options.UseBackColor = true;
            this.gvLoadChannel.Appearance.OddRow.Options.UseForeColor = true;
            this.gvLoadChannel.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvLoadChannel.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvLoadChannel.Appearance.Preview.Options.UseBackColor = true;
            this.gvLoadChannel.Appearance.Preview.Options.UseForeColor = true;
            this.gvLoadChannel.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvLoadChannel.Appearance.Row.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.gvLoadChannel.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvLoadChannel.Appearance.Row.Options.UseBackColor = true;
            this.gvLoadChannel.Appearance.Row.Options.UseFont = true;
            this.gvLoadChannel.Appearance.Row.Options.UseForeColor = true;
            this.gvLoadChannel.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvLoadChannel.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvLoadChannel.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvLoadChannel.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvLoadChannel.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvLoadChannel.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvLoadChannel.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvLoadChannel.Appearance.VertLine.Options.UseBackColor = true;
            this.gvLoadChannel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colF_LOAD_CHANNEL_ID,
            this.colF_LOAD_CHANNEL_NAME,
            this.colF_LOAD_CHANNEL_STATUS,
            this.colChannelF_DEL});
            this.gvLoadChannel.GridControl = this.gcLoadChannel;
            this.gvLoadChannel.Name = "gvLoadChannel";
            this.gvLoadChannel.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gvLoadChannel.OptionsBehavior.ImmediateUpdateRowPosition = false;
            this.gvLoadChannel.OptionsPrint.AutoWidth = false;
            this.gvLoadChannel.OptionsView.ColumnAutoWidth = false;
            this.gvLoadChannel.OptionsView.EnableAppearanceEvenRow = true;
            this.gvLoadChannel.OptionsView.EnableAppearanceOddRow = true;
            this.gvLoadChannel.OptionsView.ShowGroupPanel = false;
            // 
            // colF_LOAD_CHANNEL_ID
            // 
            this.colF_LOAD_CHANNEL_ID.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_LOAD_CHANNEL_ID.AppearanceCell.Options.UseFont = true;
            this.colF_LOAD_CHANNEL_ID.AppearanceCell.Options.UseTextOptions = true;
            this.colF_LOAD_CHANNEL_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_LOAD_CHANNEL_ID.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_LOAD_CHANNEL_ID.AppearanceHeader.Options.UseFont = true;
            this.colF_LOAD_CHANNEL_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_LOAD_CHANNEL_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_LOAD_CHANNEL_ID.Caption = "通道序号";
            this.colF_LOAD_CHANNEL_ID.FieldName = "F_LOAD_CHANNEL_ID";
            this.colF_LOAD_CHANNEL_ID.Name = "colF_LOAD_CHANNEL_ID";
            this.colF_LOAD_CHANNEL_ID.OptionsColumn.AllowEdit = false;
            this.colF_LOAD_CHANNEL_ID.OptionsColumn.AllowFocus = false;
            this.colF_LOAD_CHANNEL_ID.Visible = true;
            this.colF_LOAD_CHANNEL_ID.VisibleIndex = 0;
            this.colF_LOAD_CHANNEL_ID.Width = 118;
            // 
            // colF_LOAD_CHANNEL_NAME
            // 
            this.colF_LOAD_CHANNEL_NAME.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colF_LOAD_CHANNEL_NAME.AppearanceCell.Options.UseFont = true;
            this.colF_LOAD_CHANNEL_NAME.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colF_LOAD_CHANNEL_NAME.AppearanceHeader.Options.UseFont = true;
            this.colF_LOAD_CHANNEL_NAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_LOAD_CHANNEL_NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_LOAD_CHANNEL_NAME.Caption = "通道名称";
            this.colF_LOAD_CHANNEL_NAME.FieldName = "F_LOAD_CHANNEL_NAME";
            this.colF_LOAD_CHANNEL_NAME.Name = "colF_LOAD_CHANNEL_NAME";
            this.colF_LOAD_CHANNEL_NAME.OptionsColumn.AllowEdit = false;
            this.colF_LOAD_CHANNEL_NAME.OptionsColumn.AllowFocus = false;
            this.colF_LOAD_CHANNEL_NAME.Visible = true;
            this.colF_LOAD_CHANNEL_NAME.VisibleIndex = 1;
            // 
            // colF_LOAD_CHANNEL_STATUS
            // 
            this.colF_LOAD_CHANNEL_STATUS.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_LOAD_CHANNEL_STATUS.AppearanceCell.Options.UseFont = true;
            this.colF_LOAD_CHANNEL_STATUS.AppearanceCell.Options.UseTextOptions = true;
            this.colF_LOAD_CHANNEL_STATUS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colF_LOAD_CHANNEL_STATUS.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_LOAD_CHANNEL_STATUS.AppearanceHeader.Options.UseFont = true;
            this.colF_LOAD_CHANNEL_STATUS.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_LOAD_CHANNEL_STATUS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_LOAD_CHANNEL_STATUS.Caption = "通道可用状态";
            this.colF_LOAD_CHANNEL_STATUS.FieldName = "F_LOAD_CHANNEL_STATUS";
            this.colF_LOAD_CHANNEL_STATUS.Name = "colF_LOAD_CHANNEL_STATUS";
            this.colF_LOAD_CHANNEL_STATUS.OptionsColumn.AllowEdit = false;
            this.colF_LOAD_CHANNEL_STATUS.OptionsColumn.AllowFocus = false;
            this.colF_LOAD_CHANNEL_STATUS.Visible = true;
            this.colF_LOAD_CHANNEL_STATUS.VisibleIndex = 2;
            this.colF_LOAD_CHANNEL_STATUS.Width = 120;
            // 
            // colChannelF_DEL
            // 
            this.colChannelF_DEL.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colChannelF_DEL.AppearanceCell.Options.UseFont = true;
            this.colChannelF_DEL.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colChannelF_DEL.AppearanceHeader.Options.UseFont = true;
            this.colChannelF_DEL.AppearanceHeader.Options.UseTextOptions = true;
            this.colChannelF_DEL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colChannelF_DEL.Caption = "禁用状态";
            this.colChannelF_DEL.FieldName = "F_DEL";
            this.colChannelF_DEL.Name = "colChannelF_DEL";
            this.colChannelF_DEL.OptionsColumn.AllowEdit = false;
            this.colChannelF_DEL.OptionsColumn.AllowFocus = false;
            this.colChannelF_DEL.Visible = true;
            this.colChannelF_DEL.VisibleIndex = 3;
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
            // colF_LOAD_TEST_NUM
            // 
            this.colF_LOAD_TEST_NUM.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_LOAD_TEST_NUM.AppearanceCell.Options.UseFont = true;
            this.colF_LOAD_TEST_NUM.AppearanceCell.Options.UseTextOptions = true;
            this.colF_LOAD_TEST_NUM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colF_LOAD_TEST_NUM.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_LOAD_TEST_NUM.AppearanceHeader.Options.UseFont = true;
            this.colF_LOAD_TEST_NUM.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_LOAD_TEST_NUM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_LOAD_TEST_NUM.Caption = "试验路数";
            this.colF_LOAD_TEST_NUM.FieldName = "F_LOAD_TEST_NUM";
            this.colF_LOAD_TEST_NUM.Name = "colF_LOAD_TEST_NUM";
            this.colF_LOAD_TEST_NUM.OptionsColumn.AllowEdit = false;
            this.colF_LOAD_TEST_NUM.OptionsColumn.AllowFocus = false;
            this.colF_LOAD_TEST_NUM.Visible = true;
            this.colF_LOAD_TEST_NUM.VisibleIndex = 3;
            this.colF_LOAD_TEST_NUM.Width = 131;
            // 
            // FrmDevLoadBaseInfo
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1018, 740);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmDevLoadBaseInfo";
            this.Text = "负载柜数据维护";
            this.Load += new System.EventHandler(this.FrmPowerBaseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plnButtons)).EndInit();
            this.plnButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcDetail)).EndInit();
            this.lcDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_CALIBRATION.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_VOLTAGE_FLOOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_VOLTAGE_CEILING.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_PULSECURRENT_FLOOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_PULSECURRENT_CEILING.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_STABLECURRENT_CEILING.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueF_LOAD_VOLTAGE_TYPE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoF_DEL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_DESCRIPTION.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_STABLECURRENT_FLOOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_CONDUCTYLOAD_COEFFECIENCY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_PROPERTY_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_NAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_POSTION.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueF_LOAD_TYPE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChannelNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_POSTION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_PROPERTY_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_TYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_CONDUCTYLOAD_COEFFECIENCY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_STABLECURRENT_CEILING)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_PULSECURRENT_CEILING)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_PULSECURRENT_FLOOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_VOLTAGE_CEILING)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_VOLTAGE_FLOOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciChannelNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_DEL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_DESCRIPTION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_CALIBRATION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_VOLTAGE_TYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_STABLECURRENT_FLOOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoundRule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPackRule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZBR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            this.pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcLoadChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoadChannel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboExportOpt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl plnButtons;
        private BaseSimpleButton btnExport;
        private BaseSimpleButton btnDelete;
        private BaseSimpleButton btnSave;
        private DevExpress.XtraEditors.GroupControl pnlDetail;
        private DevExpress.XtraEditors.ComboBoxEdit cboRoundRule;
        private DevExpress.XtraEditors.ComboBoxEdit cboPackRule;
        private BaseLabelControl lblSPR;
        private BaseLabelControl lblZBR;
        private DevExpress.XtraGrid.Views.Grid.GridView gvList;
        private DevExpress.XtraGrid.Columns.GridColumn colF_LOAD_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colF_LOAD_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colF_DEL;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.TextEdit txtZBR;
        private DevExpress.XtraEditors.TextEdit txtSPR;
        private BaseGridControl gcList;
        private TextEdit txtF_LOAD_NAME;
        private TextEdit txtF_LOAD_ID;
        private RadioGroup rdoF_DEL;
        private BaseSimpleButton btnEnabled;
        private BaseSimpleButton btnDisabled;
        private TextEdit txtF_LOAD_POSTION;
        private DevExpress.XtraGrid.Columns.GridColumn colF_LOAD_POSTION;
        private GroupControl pnlGrid;
        private SplitContainerControl splitContainerControl1;
        private BaseLabelControl lblExportOpt;
        private ComboBoxEdit cboExportOpt;
        private DevExpress.XtraGrid.Columns.GridColumn colF_LOAD_DESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn colF_LOAD_TEST_NUM;
        private BaseGridControl gcLoadChannel;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLoadChannel;
        private DevExpress.XtraGrid.Columns.GridColumn colF_LOAD_CHANNEL_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colF_LOAD_CHANNEL_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colF_LOAD_STABLECURRENT_CEILING;
        private DevExpress.XtraGrid.Columns.GridColumn colF_LOAD_STABLECURRENT_FLOOR;
        private DevExpress.XtraGrid.Columns.GridColumn colF_LOAD_VOLTAGE_CEILING;
        private DevExpress.XtraGrid.Columns.GridColumn colF_LOAD_VOLTAGE_FLOOR;
        private DevExpress.XtraGrid.Columns.GridColumn colF_LOAD_CHANNEL_STATUS;
        private DevExpress.XtraLayout.LayoutControl lcDetail;
        private TextEdit txtF_LOAD_VOLTAGE_FLOOR;
        private TextEdit txtF_LOAD_VOLTAGE_CEILING;
        private TextEdit txtF_LOAD_PULSECURRENT_FLOOR;
        private TextEdit txtF_LOAD_PULSECURRENT_CEILING;
        private TextEdit txtF_LOAD_STABLECURRENT_FLOOR;
        private TextEdit txtF_LOAD_STABLECURRENT_CEILING;
        private LookUpEdit lueF_LOAD_VOLTAGE_TYPE;
        private MemoEdit txtF_LOAD_DESCRIPTION;
        private TextEdit txtF_CONDUCTYLOAD_COEFFECIENCY;
        private TextEdit txtF_PROPERTY_ID;
        private LookUpEdit lueF_LOAD_TYPE;
        private TextEdit txtChannelNum;
        private DevExpress.XtraLayout.LayoutControlGroup lcgDetail;
        private DevExpress.XtraLayout.LayoutControlItem lciF_LOAD_ID;
        private DevExpress.XtraLayout.LayoutControlItem lciF_LOAD_NAME;
        private DevExpress.XtraLayout.LayoutControlItem lciF_LOAD_POSTION;
        private DevExpress.XtraLayout.LayoutControlItem lciF_PROPERTY_ID;
        private DevExpress.XtraLayout.LayoutControlItem lciF_LOAD_TYPE;
        private DevExpress.XtraLayout.LayoutControlItem lciF_CONDUCTYLOAD_COEFFECIENCY;
        private DevExpress.XtraLayout.LayoutControlItem lciF_LOAD_VOLTAGE_TYPE;
        private DevExpress.XtraLayout.LayoutControlItem lciF_LOAD_STABLECURRENT_CEILING;
        private DevExpress.XtraLayout.LayoutControlItem lciF_LOAD_STABLECURRENT_FLOOR;
        private DevExpress.XtraLayout.LayoutControlItem lciF_LOAD_PULSECURRENT_CEILING;
        private DevExpress.XtraLayout.LayoutControlItem lciF_LOAD_PULSECURRENT_FLOOR;
        private DevExpress.XtraLayout.LayoutControlItem lciF_LOAD_VOLTAGE_CEILING;
        private DevExpress.XtraLayout.LayoutControlItem lciF_LOAD_VOLTAGE_FLOOR;
        private DevExpress.XtraLayout.LayoutControlItem lciChannelNumber;
        private DevExpress.XtraLayout.LayoutControlItem lciF_DEL;
        private DevExpress.XtraLayout.LayoutControlItem lciF_LOAD_DESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn colF_PROPERTY_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colF_LOAD_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colF_CONDUCTYLOAD_COEFFECIENCY;
        private DevExpress.XtraGrid.Columns.GridColumn colF_LOAD_VOLTAGE_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colF_LOAD_PULSECURRENT_CEILING;
        private DevExpress.XtraGrid.Columns.GridColumn colF_LOAD_PULSECURRENT_FLOOR;
        private BaseSimpleButton btnChannelInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colChannelF_DEL;
        private TextEdit txtF_LOAD_CALIBRATION;
        private DevExpress.XtraLayout.LayoutControlItem lciF_LOAD_CALIBRATION;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colF_LOAD_CALIBRATION;

    }
}