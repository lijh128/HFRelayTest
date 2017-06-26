using DevExpress.XtraEditors;
using RelayTest.Util.Common;

namespace RelayTest.Application.Settings
{

    /// <summary>
    /// 负载柜基础数据
    /// </summary>
    partial class FrmDevCoilPowerBaseInfo
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
            this.btnDisabled = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnDelete = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnSave = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnEnabled = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnExport = new RelayTest.Util.Common.BaseSimpleButton();
            this.pnlDetail = new DevExpress.XtraEditors.GroupControl();
            this.lcDetail = new DevExpress.XtraLayout.LayoutControl();
            this.txtF_COILPOWER_POWER = new DevExpress.XtraEditors.TextEdit();
            this.txtF_COILPOWER_CURRENT_FLOOR = new DevExpress.XtraEditors.TextEdit();
            this.txtF_COILPOWER_CURRENT_CEILING = new DevExpress.XtraEditors.TextEdit();
            this.txtF_COILPOWER_VOLTAGE_FLOOR = new DevExpress.XtraEditors.TextEdit();
            this.txtF_COILPOWER_VOLTAGE_CEILING = new DevExpress.XtraEditors.TextEdit();
            this.txtF_COILPOWER_CALIBRATION = new DevExpress.XtraEditors.TextEdit();
            this.txtF_COILPOWER_ADDRESS = new DevExpress.XtraEditors.TextEdit();
            this.lueF_COILPOWER_RUN_STATUS = new DevExpress.XtraEditors.LookUpEdit();
            this.txtF_COILPOWER_ID = new DevExpress.XtraEditors.TextEdit();
            this.txtF_COILPOWER_NAME = new DevExpress.XtraEditors.TextEdit();
            this.rdoF_DEL = new DevExpress.XtraEditors.RadioGroup();
            this.txtF_COILPOWER_MEMO = new DevExpress.XtraEditors.MemoEdit();
            this.txtF_COM_ADDRESS = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciF_COILPOWER_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_COILPOWER_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_COM_ADDRESS = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_COILPOWER_MEMO = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_DEL = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_COILPOWER_RUN_STATUS = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_COILPOWER_ADDRESS = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_COILPOWER_CALIBRATION = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciF_COILPOWER_VOLTAGE_CEILING = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_COILPOWER_VOLTAGE_FLOOR = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_COILPOWER_CURRENT_CEILING = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_COILPOWER_CURRENT_FLOOR = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_COILPOWER_POWER = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.cboRoundRule = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboPackRule = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblSPR = new RelayTest.Util.Common.BaseLabelControl();
            this.lblZBR = new RelayTest.Util.Common.BaseLabelControl();
            this.txtZBR = new DevExpress.XtraEditors.TextEdit();
            this.txtSPR = new DevExpress.XtraEditors.TextEdit();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.pnlGrid = new DevExpress.XtraEditors.GroupControl();
            this.gcList = new RelayTest.Util.Common.BaseGridControl();
            this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colF_COILPOWER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_COILPOWER_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_COILPOWER_CALIBRATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_COM_ADDRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_COILPOWER_ADDRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_COILPOWER_RUN_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_COILPOWER_MEMO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_DEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblExportOpt = new RelayTest.Util.Common.BaseLabelControl();
            this.cboExportOpt = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.plnButtons)).BeginInit();
            this.plnButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).BeginInit();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcDetail)).BeginInit();
            this.lcDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COILPOWER_POWER.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COILPOWER_CURRENT_FLOOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COILPOWER_CURRENT_CEILING.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COILPOWER_VOLTAGE_FLOOR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COILPOWER_VOLTAGE_CEILING.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COILPOWER_CALIBRATION.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COILPOWER_ADDRESS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueF_COILPOWER_RUN_STATUS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COILPOWER_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COILPOWER_NAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoF_DEL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COILPOWER_MEMO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COM_ADDRESS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COILPOWER_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COILPOWER_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COM_ADDRESS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COILPOWER_MEMO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_DEL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COILPOWER_RUN_STATUS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COILPOWER_ADDRESS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COILPOWER_CALIBRATION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COILPOWER_VOLTAGE_CEILING)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COILPOWER_VOLTAGE_FLOOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COILPOWER_CURRENT_CEILING)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COILPOWER_CURRENT_FLOOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COILPOWER_POWER)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoundRule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPackRule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZBR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPR.Properties)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboExportOpt.Properties)).BeginInit();
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
            this.plnButtons.Controls.Add(this.btnDisabled);
            this.plnButtons.Controls.Add(this.btnDelete);
            this.plnButtons.Controls.Add(this.btnSave);
            this.plnButtons.Controls.Add(this.btnEnabled);
            this.plnButtons.Controls.Add(this.btnExport);
            this.plnButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plnButtons.Location = new System.Drawing.Point(0, 685);
            this.plnButtons.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.plnButtons.Name = "plnButtons";
            this.plnButtons.Size = new System.Drawing.Size(1018, 55);
            this.plnButtons.TabIndex = 2;
            // 
            // btnDisabled
            // 
            this.btnDisabled.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDisabled.Appearance.Options.UseFont = true;
            this.btnDisabled.Location = new System.Drawing.Point(469, 12);
            this.btnDisabled.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDisabled.Name = "btnDisabled";
            this.btnDisabled.Size = new System.Drawing.Size(80, 31);
            this.btnDisabled.TabIndex = 2;
            this.btnDisabled.Text = "禁用";
            this.btnDisabled.Click += new System.EventHandler(this.btnDisabled_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(559, 12);
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
            this.btnSave.Location = new System.Drawing.Point(289, 12);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEnabled
            // 
            this.btnEnabled.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEnabled.Appearance.Options.UseFont = true;
            this.btnEnabled.Location = new System.Drawing.Point(379, 11);
            this.btnEnabled.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEnabled.Name = "btnEnabled";
            this.btnEnabled.Size = new System.Drawing.Size(80, 31);
            this.btnEnabled.TabIndex = 1;
            this.btnEnabled.Text = "启用";
            this.btnEnabled.Click += new System.EventHandler(this.btnEnabled_Click);
            // 
            // btnExport
            // 
            this.btnExport.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.Location = new System.Drawing.Point(649, 12);
            this.btnExport.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(80, 31);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "导出";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
            this.pnlDetail.Location = new System.Drawing.Point(0, 443);
            this.pnlDetail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(1018, 242);
            this.pnlDetail.TabIndex = 1;
            this.pnlDetail.Text = "参数设置";
            // 
            // lcDetail
            // 
            this.lcDetail.Controls.Add(this.txtF_COILPOWER_POWER);
            this.lcDetail.Controls.Add(this.txtF_COILPOWER_CURRENT_FLOOR);
            this.lcDetail.Controls.Add(this.txtF_COILPOWER_CURRENT_CEILING);
            this.lcDetail.Controls.Add(this.txtF_COILPOWER_VOLTAGE_FLOOR);
            this.lcDetail.Controls.Add(this.txtF_COILPOWER_VOLTAGE_CEILING);
            this.lcDetail.Controls.Add(this.txtF_COILPOWER_CALIBRATION);
            this.lcDetail.Controls.Add(this.txtF_COILPOWER_ADDRESS);
            this.lcDetail.Controls.Add(this.lueF_COILPOWER_RUN_STATUS);
            this.lcDetail.Controls.Add(this.txtF_COILPOWER_ID);
            this.lcDetail.Controls.Add(this.txtF_COILPOWER_NAME);
            this.lcDetail.Controls.Add(this.rdoF_DEL);
            this.lcDetail.Controls.Add(this.txtF_COILPOWER_MEMO);
            this.lcDetail.Controls.Add(this.txtF_COM_ADDRESS);
            this.lcDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcDetail.Location = new System.Drawing.Point(2, 22);
            this.lcDetail.Name = "lcDetail";
            this.lcDetail.Root = this.layoutControlGroup1;
            this.lcDetail.Size = new System.Drawing.Size(1014, 218);
            this.lcDetail.TabIndex = 25;
            this.lcDetail.Text = "layoutControl1";
            // 
            // txtF_COILPOWER_POWER
            // 
            this.txtF_COILPOWER_POWER.Location = new System.Drawing.Point(263, 121);
            this.txtF_COILPOWER_POWER.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_COILPOWER_POWER.Name = "txtF_COILPOWER_POWER";
            this.txtF_COILPOWER_POWER.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_COILPOWER_POWER.Properties.Appearance.Options.UseFont = true;
            this.txtF_COILPOWER_POWER.Properties.Appearance.Options.UseTextOptions = true;
            this.txtF_COILPOWER_POWER.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtF_COILPOWER_POWER.Properties.Mask.EditMask = "[-+]?\\d+(\\.\\d+)?";
            this.txtF_COILPOWER_POWER.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtF_COILPOWER_POWER.Properties.MaxLength = 18;
            this.txtF_COILPOWER_POWER.Size = new System.Drawing.Size(239, 22);
            this.txtF_COILPOWER_POWER.StyleController = this.lcDetail;
            this.txtF_COILPOWER_POWER.TabIndex = 5;
            // 
            // txtF_COILPOWER_CURRENT_FLOOR
            // 
            this.txtF_COILPOWER_CURRENT_FLOOR.Location = new System.Drawing.Point(670, 97);
            this.txtF_COILPOWER_CURRENT_FLOOR.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_COILPOWER_CURRENT_FLOOR.Name = "txtF_COILPOWER_CURRENT_FLOOR";
            this.txtF_COILPOWER_CURRENT_FLOOR.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_COILPOWER_CURRENT_FLOOR.Properties.Appearance.Options.UseFont = true;
            this.txtF_COILPOWER_CURRENT_FLOOR.Properties.Appearance.Options.UseTextOptions = true;
            this.txtF_COILPOWER_CURRENT_FLOOR.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtF_COILPOWER_CURRENT_FLOOR.Properties.Mask.EditMask = "[-+]?\\d+(\\.\\d+)?";
            this.txtF_COILPOWER_CURRENT_FLOOR.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtF_COILPOWER_CURRENT_FLOOR.Properties.MaxLength = 18;
            this.txtF_COILPOWER_CURRENT_FLOOR.Size = new System.Drawing.Size(239, 22);
            this.txtF_COILPOWER_CURRENT_FLOOR.StyleController = this.lcDetail;
            this.txtF_COILPOWER_CURRENT_FLOOR.TabIndex = 5;
            // 
            // txtF_COILPOWER_CURRENT_CEILING
            // 
            this.txtF_COILPOWER_CURRENT_CEILING.Location = new System.Drawing.Point(263, 97);
            this.txtF_COILPOWER_CURRENT_CEILING.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_COILPOWER_CURRENT_CEILING.Name = "txtF_COILPOWER_CURRENT_CEILING";
            this.txtF_COILPOWER_CURRENT_CEILING.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_COILPOWER_CURRENT_CEILING.Properties.Appearance.Options.UseFont = true;
            this.txtF_COILPOWER_CURRENT_CEILING.Properties.Appearance.Options.UseTextOptions = true;
            this.txtF_COILPOWER_CURRENT_CEILING.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtF_COILPOWER_CURRENT_CEILING.Properties.Mask.EditMask = "[-+]?\\d+(\\.\\d+)?";
            this.txtF_COILPOWER_CURRENT_CEILING.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtF_COILPOWER_CURRENT_CEILING.Properties.MaxLength = 18;
            this.txtF_COILPOWER_CURRENT_CEILING.Size = new System.Drawing.Size(239, 22);
            this.txtF_COILPOWER_CURRENT_CEILING.StyleController = this.lcDetail;
            this.txtF_COILPOWER_CURRENT_CEILING.TabIndex = 5;
            // 
            // txtF_COILPOWER_VOLTAGE_FLOOR
            // 
            this.txtF_COILPOWER_VOLTAGE_FLOOR.Location = new System.Drawing.Point(670, 73);
            this.txtF_COILPOWER_VOLTAGE_FLOOR.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_COILPOWER_VOLTAGE_FLOOR.Name = "txtF_COILPOWER_VOLTAGE_FLOOR";
            this.txtF_COILPOWER_VOLTAGE_FLOOR.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_COILPOWER_VOLTAGE_FLOOR.Properties.Appearance.Options.UseFont = true;
            this.txtF_COILPOWER_VOLTAGE_FLOOR.Properties.Appearance.Options.UseTextOptions = true;
            this.txtF_COILPOWER_VOLTAGE_FLOOR.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtF_COILPOWER_VOLTAGE_FLOOR.Properties.Mask.EditMask = "[-+]?\\d+(\\.\\d+)?";
            this.txtF_COILPOWER_VOLTAGE_FLOOR.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtF_COILPOWER_VOLTAGE_FLOOR.Properties.MaxLength = 18;
            this.txtF_COILPOWER_VOLTAGE_FLOOR.Size = new System.Drawing.Size(239, 22);
            this.txtF_COILPOWER_VOLTAGE_FLOOR.StyleController = this.lcDetail;
            this.txtF_COILPOWER_VOLTAGE_FLOOR.TabIndex = 5;
            // 
            // txtF_COILPOWER_VOLTAGE_CEILING
            // 
            this.txtF_COILPOWER_VOLTAGE_CEILING.Location = new System.Drawing.Point(263, 73);
            this.txtF_COILPOWER_VOLTAGE_CEILING.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_COILPOWER_VOLTAGE_CEILING.Name = "txtF_COILPOWER_VOLTAGE_CEILING";
            this.txtF_COILPOWER_VOLTAGE_CEILING.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_COILPOWER_VOLTAGE_CEILING.Properties.Appearance.Options.UseFont = true;
            this.txtF_COILPOWER_VOLTAGE_CEILING.Properties.Appearance.Options.UseTextOptions = true;
            this.txtF_COILPOWER_VOLTAGE_CEILING.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtF_COILPOWER_VOLTAGE_CEILING.Properties.Mask.EditMask = "[-+]?\\d+(\\.\\d+)?";
            this.txtF_COILPOWER_VOLTAGE_CEILING.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtF_COILPOWER_VOLTAGE_CEILING.Properties.MaxLength = 18;
            this.txtF_COILPOWER_VOLTAGE_CEILING.Size = new System.Drawing.Size(239, 22);
            this.txtF_COILPOWER_VOLTAGE_CEILING.StyleController = this.lcDetail;
            this.txtF_COILPOWER_VOLTAGE_CEILING.TabIndex = 5;
            // 
            // txtF_COILPOWER_CALIBRATION
            // 
            this.txtF_COILPOWER_CALIBRATION.Location = new System.Drawing.Point(263, 25);
            this.txtF_COILPOWER_CALIBRATION.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_COILPOWER_CALIBRATION.Name = "txtF_COILPOWER_CALIBRATION";
            this.txtF_COILPOWER_CALIBRATION.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_COILPOWER_CALIBRATION.Properties.Appearance.Options.UseFont = true;
            this.txtF_COILPOWER_CALIBRATION.Size = new System.Drawing.Size(239, 22);
            this.txtF_COILPOWER_CALIBRATION.StyleController = this.lcDetail;
            this.txtF_COILPOWER_CALIBRATION.TabIndex = 5;
            // 
            // txtF_COILPOWER_ADDRESS
            // 
            this.txtF_COILPOWER_ADDRESS.Location = new System.Drawing.Point(670, 49);
            this.txtF_COILPOWER_ADDRESS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_COILPOWER_ADDRESS.Name = "txtF_COILPOWER_ADDRESS";
            this.txtF_COILPOWER_ADDRESS.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_COILPOWER_ADDRESS.Properties.Appearance.Options.UseFont = true;
            this.txtF_COILPOWER_ADDRESS.Properties.Appearance.Options.UseTextOptions = true;
            this.txtF_COILPOWER_ADDRESS.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtF_COILPOWER_ADDRESS.Properties.MaxLength = 4;
            this.txtF_COILPOWER_ADDRESS.Size = new System.Drawing.Size(239, 22);
            this.txtF_COILPOWER_ADDRESS.StyleController = this.lcDetail;
            this.txtF_COILPOWER_ADDRESS.TabIndex = 2;
            // 
            // lueF_COILPOWER_RUN_STATUS
            // 
            this.lueF_COILPOWER_RUN_STATUS.Location = new System.Drawing.Point(263, 145);
            this.lueF_COILPOWER_RUN_STATUS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lueF_COILPOWER_RUN_STATUS.Name = "lueF_COILPOWER_RUN_STATUS";
            this.lueF_COILPOWER_RUN_STATUS.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lueF_COILPOWER_RUN_STATUS.Properties.Appearance.Options.UseFont = true;
            this.lueF_COILPOWER_RUN_STATUS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueF_COILPOWER_RUN_STATUS.Properties.NullText = "";
            this.lueF_COILPOWER_RUN_STATUS.Size = new System.Drawing.Size(239, 22);
            this.lueF_COILPOWER_RUN_STATUS.StyleController = this.lcDetail;
            this.lueF_COILPOWER_RUN_STATUS.TabIndex = 47;
            // 
            // txtF_COILPOWER_ID
            // 
            this.txtF_COILPOWER_ID.Location = new System.Drawing.Point(263, 1);
            this.txtF_COILPOWER_ID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_COILPOWER_ID.Name = "txtF_COILPOWER_ID";
            this.txtF_COILPOWER_ID.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_COILPOWER_ID.Properties.Appearance.Options.UseFont = true;
            this.txtF_COILPOWER_ID.Size = new System.Drawing.Size(239, 22);
            this.txtF_COILPOWER_ID.StyleController = this.lcDetail;
            this.txtF_COILPOWER_ID.TabIndex = 0;
            this.txtF_COILPOWER_ID.EditValueChanged += new System.EventHandler(this.txtCode_EditValueChanged);
            // 
            // txtF_COILPOWER_NAME
            // 
            this.txtF_COILPOWER_NAME.Location = new System.Drawing.Point(670, 1);
            this.txtF_COILPOWER_NAME.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_COILPOWER_NAME.Name = "txtF_COILPOWER_NAME";
            this.txtF_COILPOWER_NAME.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_COILPOWER_NAME.Properties.Appearance.Options.UseFont = true;
            this.txtF_COILPOWER_NAME.Size = new System.Drawing.Size(239, 22);
            this.txtF_COILPOWER_NAME.StyleController = this.lcDetail;
            this.txtF_COILPOWER_NAME.TabIndex = 1;
            // 
            // rdoF_DEL
            // 
            this.rdoF_DEL.Location = new System.Drawing.Point(670, 142);
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
            this.rdoF_DEL.Size = new System.Drawing.Size(239, 25);
            this.rdoF_DEL.StyleController = this.lcDetail;
            this.rdoF_DEL.TabIndex = 4;
            // 
            // txtF_COILPOWER_MEMO
            // 
            this.txtF_COILPOWER_MEMO.Location = new System.Drawing.Point(263, 169);
            this.txtF_COILPOWER_MEMO.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_COILPOWER_MEMO.Name = "txtF_COILPOWER_MEMO";
            this.txtF_COILPOWER_MEMO.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_COILPOWER_MEMO.Properties.Appearance.Options.UseFont = true;
            this.txtF_COILPOWER_MEMO.Properties.MaxLength = 250;
            this.txtF_COILPOWER_MEMO.Size = new System.Drawing.Size(646, 48);
            this.txtF_COILPOWER_MEMO.StyleController = this.lcDetail;
            this.txtF_COILPOWER_MEMO.TabIndex = 5;
            // 
            // txtF_COM_ADDRESS
            // 
            this.txtF_COM_ADDRESS.Location = new System.Drawing.Point(263, 49);
            this.txtF_COM_ADDRESS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_COM_ADDRESS.Name = "txtF_COM_ADDRESS";
            this.txtF_COM_ADDRESS.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_COM_ADDRESS.Properties.Appearance.Options.UseFont = true;
            this.txtF_COM_ADDRESS.Properties.Mask.EditMask = "(com|COM)([1-9]|[1-9][0-9])";
            this.txtF_COM_ADDRESS.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtF_COM_ADDRESS.Size = new System.Drawing.Size(239, 22);
            this.txtF_COM_ADDRESS.StyleController = this.lcDetail;
            this.txtF_COM_ADDRESS.TabIndex = 2;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlGroup1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciF_COILPOWER_ID,
            this.lciF_COILPOWER_NAME,
            this.lciF_COM_ADDRESS,
            this.lciF_COILPOWER_MEMO,
            this.lciF_DEL,
            this.lciF_COILPOWER_RUN_STATUS,
            this.lciF_COILPOWER_ADDRESS,
            this.lciF_COILPOWER_CALIBRATION,
            this.emptySpaceItem1,
            this.lciF_COILPOWER_VOLTAGE_CEILING,
            this.lciF_COILPOWER_VOLTAGE_FLOOR,
            this.lciF_COILPOWER_CURRENT_CEILING,
            this.lciF_COILPOWER_CURRENT_FLOOR,
            this.lciF_COILPOWER_POWER,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1014, 218);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(100, 100, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciF_COILPOWER_ID
            // 
            this.lciF_COILPOWER_ID.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lciF_COILPOWER_ID.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_COILPOWER_ID.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_COILPOWER_ID.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_COILPOWER_ID.Control = this.txtF_COILPOWER_ID;
            this.lciF_COILPOWER_ID.CustomizationFormText = "编号：";
            this.lciF_COILPOWER_ID.Location = new System.Drawing.Point(0, 0);
            this.lciF_COILPOWER_ID.Name = "lciF_COILPOWER_ID";
            this.lciF_COILPOWER_ID.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 1, 1);
            this.lciF_COILPOWER_ID.Size = new System.Drawing.Size(407, 24);
            this.lciF_COILPOWER_ID.Text = "线圈电源编号：";
            this.lciF_COILPOWER_ID.TextSize = new System.Drawing.Size(154, 14);
            // 
            // lciF_COILPOWER_NAME
            // 
            this.lciF_COILPOWER_NAME.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lciF_COILPOWER_NAME.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_COILPOWER_NAME.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_COILPOWER_NAME.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_COILPOWER_NAME.Control = this.txtF_COILPOWER_NAME;
            this.lciF_COILPOWER_NAME.CustomizationFormText = "名称：";
            this.lciF_COILPOWER_NAME.Location = new System.Drawing.Point(407, 0);
            this.lciF_COILPOWER_NAME.Name = "lciF_COILPOWER_NAME";
            this.lciF_COILPOWER_NAME.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 1, 1);
            this.lciF_COILPOWER_NAME.Size = new System.Drawing.Size(407, 24);
            this.lciF_COILPOWER_NAME.Text = "线圈电源名称：";
            this.lciF_COILPOWER_NAME.TextSize = new System.Drawing.Size(154, 14);
            // 
            // lciF_COM_ADDRESS
            // 
            this.lciF_COM_ADDRESS.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_COM_ADDRESS.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_COM_ADDRESS.Control = this.txtF_COM_ADDRESS;
            this.lciF_COM_ADDRESS.CustomizationFormText = "通信端口：";
            this.lciF_COM_ADDRESS.Location = new System.Drawing.Point(0, 48);
            this.lciF_COM_ADDRESS.Name = "lciF_COM_ADDRESS";
            this.lciF_COM_ADDRESS.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 1, 1);
            this.lciF_COM_ADDRESS.Size = new System.Drawing.Size(407, 24);
            this.lciF_COM_ADDRESS.Text = "通信端口：";
            this.lciF_COM_ADDRESS.TextSize = new System.Drawing.Size(154, 14);
            // 
            // lciF_COILPOWER_MEMO
            // 
            this.lciF_COILPOWER_MEMO.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_COILPOWER_MEMO.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_COILPOWER_MEMO.Control = this.txtF_COILPOWER_MEMO;
            this.lciF_COILPOWER_MEMO.CustomizationFormText = "备注：";
            this.lciF_COILPOWER_MEMO.Location = new System.Drawing.Point(0, 168);
            this.lciF_COILPOWER_MEMO.Name = "lciF_COILPOWER_MEMO";
            this.lciF_COILPOWER_MEMO.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 1, 1);
            this.lciF_COILPOWER_MEMO.Size = new System.Drawing.Size(814, 50);
            this.lciF_COILPOWER_MEMO.Text = "备注：";
            this.lciF_COILPOWER_MEMO.TextSize = new System.Drawing.Size(154, 14);
            // 
            // lciF_DEL
            // 
            this.lciF_DEL.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_DEL.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_DEL.Control = this.rdoF_DEL;
            this.lciF_DEL.CustomizationFormText = "禁用状态";
            this.lciF_DEL.Location = new System.Drawing.Point(407, 141);
            this.lciF_DEL.Name = "lciF_DEL";
            this.lciF_DEL.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 1, 1);
            this.lciF_DEL.Size = new System.Drawing.Size(407, 27);
            this.lciF_DEL.Text = "禁用状态：";
            this.lciF_DEL.TextSize = new System.Drawing.Size(154, 14);
            // 
            // lciF_COILPOWER_RUN_STATUS
            // 
            this.lciF_COILPOWER_RUN_STATUS.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_COILPOWER_RUN_STATUS.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_COILPOWER_RUN_STATUS.Control = this.lueF_COILPOWER_RUN_STATUS;
            this.lciF_COILPOWER_RUN_STATUS.CustomizationFormText = "运行状态：";
            this.lciF_COILPOWER_RUN_STATUS.Location = new System.Drawing.Point(0, 144);
            this.lciF_COILPOWER_RUN_STATUS.Name = "lciF_COILPOWER_RUN_STATUS";
            this.lciF_COILPOWER_RUN_STATUS.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 1, 1);
            this.lciF_COILPOWER_RUN_STATUS.Size = new System.Drawing.Size(407, 24);
            this.lciF_COILPOWER_RUN_STATUS.Text = "运行状态：";
            this.lciF_COILPOWER_RUN_STATUS.TextSize = new System.Drawing.Size(154, 14);
            // 
            // lciF_COILPOWER_ADDRESS
            // 
            this.lciF_COILPOWER_ADDRESS.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_COILPOWER_ADDRESS.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_COILPOWER_ADDRESS.Control = this.txtF_COILPOWER_ADDRESS;
            this.lciF_COILPOWER_ADDRESS.CustomizationFormText = "通信地址：";
            this.lciF_COILPOWER_ADDRESS.Location = new System.Drawing.Point(407, 48);
            this.lciF_COILPOWER_ADDRESS.Name = "lciF_COILPOWER_ADDRESS";
            this.lciF_COILPOWER_ADDRESS.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 1, 1);
            this.lciF_COILPOWER_ADDRESS.Size = new System.Drawing.Size(407, 24);
            this.lciF_COILPOWER_ADDRESS.Text = "通信地址：";
            this.lciF_COILPOWER_ADDRESS.TextSize = new System.Drawing.Size(154, 14);
            // 
            // lciF_COILPOWER_CALIBRATION
            // 
            this.lciF_COILPOWER_CALIBRATION.Control = this.txtF_COILPOWER_CALIBRATION;
            this.lciF_COILPOWER_CALIBRATION.CustomizationFormText = "校准编号：";
            this.lciF_COILPOWER_CALIBRATION.Location = new System.Drawing.Point(0, 24);
            this.lciF_COILPOWER_CALIBRATION.Name = "lciF_COILPOWER_CALIBRATION";
            this.lciF_COILPOWER_CALIBRATION.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 1, 1);
            this.lciF_COILPOWER_CALIBRATION.Size = new System.Drawing.Size(407, 24);
            this.lciF_COILPOWER_CALIBRATION.Text = "校准编号：";
            this.lciF_COILPOWER_CALIBRATION.TextSize = new System.Drawing.Size(154, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(407, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(407, 24);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciF_COILPOWER_VOLTAGE_CEILING
            // 
            this.lciF_COILPOWER_VOLTAGE_CEILING.Control = this.txtF_COILPOWER_VOLTAGE_CEILING;
            this.lciF_COILPOWER_VOLTAGE_CEILING.CustomizationFormText = "线圈电源输出电压上限：";
            this.lciF_COILPOWER_VOLTAGE_CEILING.Location = new System.Drawing.Point(0, 72);
            this.lciF_COILPOWER_VOLTAGE_CEILING.Name = "lciF_COILPOWER_VOLTAGE_CEILING";
            this.lciF_COILPOWER_VOLTAGE_CEILING.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 1, 1);
            this.lciF_COILPOWER_VOLTAGE_CEILING.Size = new System.Drawing.Size(407, 24);
            this.lciF_COILPOWER_VOLTAGE_CEILING.Text = "线圈电源输出电压上限：";
            this.lciF_COILPOWER_VOLTAGE_CEILING.TextSize = new System.Drawing.Size(154, 14);
            // 
            // lciF_COILPOWER_VOLTAGE_FLOOR
            // 
            this.lciF_COILPOWER_VOLTAGE_FLOOR.Control = this.txtF_COILPOWER_VOLTAGE_FLOOR;
            this.lciF_COILPOWER_VOLTAGE_FLOOR.CustomizationFormText = "线圈电源输出电压下限：";
            this.lciF_COILPOWER_VOLTAGE_FLOOR.Location = new System.Drawing.Point(407, 72);
            this.lciF_COILPOWER_VOLTAGE_FLOOR.Name = "lciF_COILPOWER_VOLTAGE_FLOOR";
            this.lciF_COILPOWER_VOLTAGE_FLOOR.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 1, 1);
            this.lciF_COILPOWER_VOLTAGE_FLOOR.Size = new System.Drawing.Size(407, 24);
            this.lciF_COILPOWER_VOLTAGE_FLOOR.Text = "线圈电源输出电压下限：";
            this.lciF_COILPOWER_VOLTAGE_FLOOR.TextSize = new System.Drawing.Size(154, 14);
            // 
            // lciF_COILPOWER_CURRENT_CEILING
            // 
            this.lciF_COILPOWER_CURRENT_CEILING.Control = this.txtF_COILPOWER_CURRENT_CEILING;
            this.lciF_COILPOWER_CURRENT_CEILING.CustomizationFormText = "线圈电源输出电流上限：";
            this.lciF_COILPOWER_CURRENT_CEILING.Location = new System.Drawing.Point(0, 96);
            this.lciF_COILPOWER_CURRENT_CEILING.Name = "lciF_COILPOWER_CURRENT_CEILING";
            this.lciF_COILPOWER_CURRENT_CEILING.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 1, 1);
            this.lciF_COILPOWER_CURRENT_CEILING.Size = new System.Drawing.Size(407, 24);
            this.lciF_COILPOWER_CURRENT_CEILING.Text = "线圈电源输出电流上限：";
            this.lciF_COILPOWER_CURRENT_CEILING.TextSize = new System.Drawing.Size(154, 14);
            // 
            // lciF_COILPOWER_CURRENT_FLOOR
            // 
            this.lciF_COILPOWER_CURRENT_FLOOR.Control = this.txtF_COILPOWER_CURRENT_FLOOR;
            this.lciF_COILPOWER_CURRENT_FLOOR.CustomizationFormText = "线圈电源输出电流下限：";
            this.lciF_COILPOWER_CURRENT_FLOOR.Location = new System.Drawing.Point(407, 96);
            this.lciF_COILPOWER_CURRENT_FLOOR.Name = "lciF_COILPOWER_CURRENT_FLOOR";
            this.lciF_COILPOWER_CURRENT_FLOOR.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 1, 1);
            this.lciF_COILPOWER_CURRENT_FLOOR.Size = new System.Drawing.Size(407, 24);
            this.lciF_COILPOWER_CURRENT_FLOOR.Text = "线圈电源输出电流下限：";
            this.lciF_COILPOWER_CURRENT_FLOOR.TextSize = new System.Drawing.Size(154, 14);
            // 
            // lciF_COILPOWER_POWER
            // 
            this.lciF_COILPOWER_POWER.Control = this.txtF_COILPOWER_POWER;
            this.lciF_COILPOWER_POWER.CustomizationFormText = "线圈电源输出功率：";
            this.lciF_COILPOWER_POWER.Location = new System.Drawing.Point(0, 120);
            this.lciF_COILPOWER_POWER.Name = "lciF_COILPOWER_POWER";
            this.lciF_COILPOWER_POWER.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 1, 1);
            this.lciF_COILPOWER_POWER.Size = new System.Drawing.Size(407, 24);
            this.lciF_COILPOWER_POWER.Text = "线圈电源输出功率：";
            this.lciF_COILPOWER_POWER.TextSize = new System.Drawing.Size(154, 14);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(407, 120);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(407, 21);
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
            this.pnlGrid.Controls.Add(this.gcList);
            this.pnlGrid.Controls.Add(this.lblExportOpt);
            this.pnlGrid.Controls.Add(this.cboExportOpt);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlGrid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1018, 443);
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
            this.gcList.Size = new System.Drawing.Size(1014, 419);
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
            this.colF_COILPOWER_ID,
            this.colF_COILPOWER_NAME,
            this.colF_COILPOWER_CALIBRATION,
            this.colF_COM_ADDRESS,
            this.colF_COILPOWER_ADDRESS,
            this.colF_COILPOWER_RUN_STATUS,
            this.colF_COILPOWER_MEMO,
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
            // colF_COILPOWER_ID
            // 
            this.colF_COILPOWER_ID.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_COILPOWER_ID.AppearanceCell.Options.UseFont = true;
            this.colF_COILPOWER_ID.AppearanceCell.Options.UseTextOptions = true;
            this.colF_COILPOWER_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_COILPOWER_ID.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_COILPOWER_ID.AppearanceHeader.Options.UseFont = true;
            this.colF_COILPOWER_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_COILPOWER_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_COILPOWER_ID.Caption = "线圈电源编号";
            this.colF_COILPOWER_ID.FieldName = "F_COILPOWER_ID";
            this.colF_COILPOWER_ID.Name = "colF_COILPOWER_ID";
            this.colF_COILPOWER_ID.OptionsColumn.AllowEdit = false;
            this.colF_COILPOWER_ID.OptionsColumn.AllowFocus = false;
            this.colF_COILPOWER_ID.Visible = true;
            this.colF_COILPOWER_ID.VisibleIndex = 0;
            this.colF_COILPOWER_ID.Width = 118;
            // 
            // colF_COILPOWER_NAME
            // 
            this.colF_COILPOWER_NAME.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_COILPOWER_NAME.AppearanceCell.Options.UseFont = true;
            this.colF_COILPOWER_NAME.AppearanceCell.Options.UseTextOptions = true;
            this.colF_COILPOWER_NAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_COILPOWER_NAME.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_COILPOWER_NAME.AppearanceHeader.Options.UseFont = true;
            this.colF_COILPOWER_NAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_COILPOWER_NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_COILPOWER_NAME.Caption = "线圈电源名称";
            this.colF_COILPOWER_NAME.FieldName = "F_COILPOWER_NAME";
            this.colF_COILPOWER_NAME.Name = "colF_COILPOWER_NAME";
            this.colF_COILPOWER_NAME.OptionsColumn.AllowEdit = false;
            this.colF_COILPOWER_NAME.OptionsColumn.AllowFocus = false;
            this.colF_COILPOWER_NAME.Visible = true;
            this.colF_COILPOWER_NAME.VisibleIndex = 1;
            this.colF_COILPOWER_NAME.Width = 213;
            // 
            // colF_COILPOWER_CALIBRATION
            // 
            this.colF_COILPOWER_CALIBRATION.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colF_COILPOWER_CALIBRATION.AppearanceCell.Options.UseFont = true;
            this.colF_COILPOWER_CALIBRATION.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colF_COILPOWER_CALIBRATION.AppearanceHeader.Options.UseFont = true;
            this.colF_COILPOWER_CALIBRATION.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_COILPOWER_CALIBRATION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_COILPOWER_CALIBRATION.Caption = "校准编号";
            this.colF_COILPOWER_CALIBRATION.FieldName = "F_COILPOWER_CALIBRATION";
            this.colF_COILPOWER_CALIBRATION.Name = "colF_COILPOWER_CALIBRATION";
            this.colF_COILPOWER_CALIBRATION.OptionsColumn.AllowEdit = false;
            this.colF_COILPOWER_CALIBRATION.OptionsColumn.AllowFocus = false;
            this.colF_COILPOWER_CALIBRATION.Visible = true;
            this.colF_COILPOWER_CALIBRATION.VisibleIndex = 2;
            // 
            // colF_COM_ADDRESS
            // 
            this.colF_COM_ADDRESS.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_COM_ADDRESS.AppearanceCell.Options.UseFont = true;
            this.colF_COM_ADDRESS.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_COM_ADDRESS.AppearanceHeader.Options.UseFont = true;
            this.colF_COM_ADDRESS.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_COM_ADDRESS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_COM_ADDRESS.Caption = "通信端口";
            this.colF_COM_ADDRESS.FieldName = "F_COM_ADDRESS";
            this.colF_COM_ADDRESS.Name = "colF_COM_ADDRESS";
            this.colF_COM_ADDRESS.OptionsColumn.AllowEdit = false;
            this.colF_COM_ADDRESS.OptionsColumn.AllowFocus = false;
            this.colF_COM_ADDRESS.Visible = true;
            this.colF_COM_ADDRESS.VisibleIndex = 3;
            this.colF_COM_ADDRESS.Width = 136;
            // 
            // colF_COILPOWER_ADDRESS
            // 
            this.colF_COILPOWER_ADDRESS.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_COILPOWER_ADDRESS.AppearanceCell.Options.UseFont = true;
            this.colF_COILPOWER_ADDRESS.AppearanceCell.Options.UseTextOptions = true;
            this.colF_COILPOWER_ADDRESS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colF_COILPOWER_ADDRESS.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_COILPOWER_ADDRESS.AppearanceHeader.Options.UseFont = true;
            this.colF_COILPOWER_ADDRESS.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_COILPOWER_ADDRESS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_COILPOWER_ADDRESS.Caption = "通信地址";
            this.colF_COILPOWER_ADDRESS.FieldName = "F_COILPOWER_ADDRESS";
            this.colF_COILPOWER_ADDRESS.Name = "colF_COILPOWER_ADDRESS";
            this.colF_COILPOWER_ADDRESS.OptionsColumn.AllowEdit = false;
            this.colF_COILPOWER_ADDRESS.OptionsColumn.AllowFocus = false;
            this.colF_COILPOWER_ADDRESS.Visible = true;
            this.colF_COILPOWER_ADDRESS.VisibleIndex = 4;
            this.colF_COILPOWER_ADDRESS.Width = 137;
            // 
            // colF_COILPOWER_RUN_STATUS
            // 
            this.colF_COILPOWER_RUN_STATUS.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_COILPOWER_RUN_STATUS.AppearanceCell.Options.UseFont = true;
            this.colF_COILPOWER_RUN_STATUS.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_COILPOWER_RUN_STATUS.AppearanceHeader.Options.UseFont = true;
            this.colF_COILPOWER_RUN_STATUS.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_COILPOWER_RUN_STATUS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_COILPOWER_RUN_STATUS.Caption = "线圈电源运行状态";
            this.colF_COILPOWER_RUN_STATUS.FieldName = "F_COILPOWER_RUN_STATUS";
            this.colF_COILPOWER_RUN_STATUS.Name = "colF_COILPOWER_RUN_STATUS";
            this.colF_COILPOWER_RUN_STATUS.OptionsColumn.AllowEdit = false;
            this.colF_COILPOWER_RUN_STATUS.OptionsColumn.AllowFocus = false;
            this.colF_COILPOWER_RUN_STATUS.Visible = true;
            this.colF_COILPOWER_RUN_STATUS.VisibleIndex = 5;
            this.colF_COILPOWER_RUN_STATUS.Width = 197;
            // 
            // colF_COILPOWER_MEMO
            // 
            this.colF_COILPOWER_MEMO.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_COILPOWER_MEMO.AppearanceCell.Options.UseFont = true;
            this.colF_COILPOWER_MEMO.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_COILPOWER_MEMO.AppearanceHeader.Options.UseFont = true;
            this.colF_COILPOWER_MEMO.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_COILPOWER_MEMO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_COILPOWER_MEMO.Caption = "备注";
            this.colF_COILPOWER_MEMO.FieldName = "F_COILPOWER_MEMO";
            this.colF_COILPOWER_MEMO.Name = "colF_COILPOWER_MEMO";
            this.colF_COILPOWER_MEMO.OptionsColumn.AllowEdit = false;
            this.colF_COILPOWER_MEMO.OptionsColumn.AllowFocus = false;
            this.colF_COILPOWER_MEMO.Visible = true;
            this.colF_COILPOWER_MEMO.VisibleIndex = 6;
            this.colF_COILPOWER_MEMO.Width = 145;
            // 
            // colF_DEL
            // 
            this.colF_DEL.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_DEL.AppearanceCell.Options.UseFont = true;
            this.colF_DEL.AppearanceCell.Options.UseTextOptions = true;
            this.colF_DEL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
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
            this.colF_DEL.VisibleIndex = 7;
            this.colF_DEL.Width = 120;
            // 
            // lblExportOpt
            // 
            this.lblExportOpt.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblExportOpt.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblExportOpt.Location = new System.Drawing.Point(769, -17);
            this.lblExportOpt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblExportOpt.Name = "lblExportOpt";
            this.lblExportOpt.Size = new System.Drawing.Size(70, 14);
            this.lblExportOpt.TabIndex = 0;
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
            // FrmDevCoilPowerBaseInfo
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1018, 740);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmDevCoilPowerBaseInfo";
            this.Text = "线圈电源数据维护";
            this.Load += new System.EventHandler(this.FrmPowerBaseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plnButtons)).EndInit();
            this.plnButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcDetail)).EndInit();
            this.lcDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COILPOWER_POWER.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COILPOWER_CURRENT_FLOOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COILPOWER_CURRENT_CEILING.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COILPOWER_VOLTAGE_FLOOR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COILPOWER_VOLTAGE_CEILING.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COILPOWER_CALIBRATION.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COILPOWER_ADDRESS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueF_COILPOWER_RUN_STATUS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COILPOWER_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COILPOWER_NAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoF_DEL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COILPOWER_MEMO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COM_ADDRESS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COILPOWER_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COILPOWER_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COM_ADDRESS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COILPOWER_MEMO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_DEL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COILPOWER_RUN_STATUS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COILPOWER_ADDRESS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COILPOWER_CALIBRATION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COILPOWER_VOLTAGE_CEILING)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COILPOWER_VOLTAGE_FLOOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COILPOWER_CURRENT_CEILING)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COILPOWER_CURRENT_FLOOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_COILPOWER_POWER)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoundRule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPackRule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZBR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPR.Properties)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            this.pnlGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboExportOpt.Properties)).EndInit();
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
        private DevExpress.XtraEditors.ComboBoxEdit cboRoundRule;
        private DevExpress.XtraEditors.ComboBoxEdit cboPackRule;
        private BaseLabelControl lblSPR;
        private BaseLabelControl lblZBR;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.TextEdit txtZBR;
        private DevExpress.XtraEditors.TextEdit txtSPR;
        private TextEdit txtF_COILPOWER_NAME;
        private TextEdit txtF_COILPOWER_ID;
        private RadioGroup rdoF_DEL;
        private BaseSimpleButton btnEnabled;
        private BaseSimpleButton btnDisabled;
        private GroupControl pnlGrid;
        private BaseGridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvList;
        private DevExpress.XtraGrid.Columns.GridColumn colF_COILPOWER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colF_COILPOWER_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colF_COM_ADDRESS;
        private DevExpress.XtraGrid.Columns.GridColumn colF_COILPOWER_MEMO;
        private DevExpress.XtraGrid.Columns.GridColumn colF_DEL;
        private BaseLabelControl lblExportOpt;
        private ComboBoxEdit cboExportOpt;
        private DevExpress.XtraLayout.LayoutControl lcDetail;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private LookUpEdit lueF_COILPOWER_RUN_STATUS;
        private MemoEdit txtF_COILPOWER_MEMO;
        private DevExpress.XtraLayout.LayoutControlItem lciF_COILPOWER_ID;
        private DevExpress.XtraLayout.LayoutControlItem lciF_COILPOWER_NAME;
        private DevExpress.XtraLayout.LayoutControlItem lciF_COM_ADDRESS;
        private DevExpress.XtraLayout.LayoutControlItem lciF_COILPOWER_RUN_STATUS;
        private DevExpress.XtraLayout.LayoutControlItem lciF_COILPOWER_MEMO;
        private DevExpress.XtraLayout.LayoutControlItem lciF_DEL;
        private TextEdit txtF_COILPOWER_ADDRESS;
        private DevExpress.XtraLayout.LayoutControlItem lciF_COILPOWER_ADDRESS;
        private DevExpress.XtraGrid.Columns.GridColumn colF_COILPOWER_ADDRESS;
        private DevExpress.XtraGrid.Columns.GridColumn colF_COILPOWER_RUN_STATUS;
        private TextEdit txtF_COM_ADDRESS;
        private TextEdit txtF_COILPOWER_CALIBRATION;
        private DevExpress.XtraLayout.LayoutControlItem lciF_COILPOWER_CALIBRATION;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colF_COILPOWER_CALIBRATION;
        private TextEdit txtF_COILPOWER_POWER;
        private TextEdit txtF_COILPOWER_CURRENT_FLOOR;
        private TextEdit txtF_COILPOWER_CURRENT_CEILING;
        private TextEdit txtF_COILPOWER_VOLTAGE_FLOOR;
        private TextEdit txtF_COILPOWER_VOLTAGE_CEILING;
        private DevExpress.XtraLayout.LayoutControlItem lciF_COILPOWER_VOLTAGE_CEILING;
        private DevExpress.XtraLayout.LayoutControlItem lciF_COILPOWER_VOLTAGE_FLOOR;
        private DevExpress.XtraLayout.LayoutControlItem lciF_COILPOWER_CURRENT_CEILING;
        private DevExpress.XtraLayout.LayoutControlItem lciF_COILPOWER_CURRENT_FLOOR;
        private DevExpress.XtraLayout.LayoutControlItem lciF_COILPOWER_POWER;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;

    }
}