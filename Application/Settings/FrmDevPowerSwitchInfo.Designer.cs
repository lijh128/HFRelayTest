using DevExpress.XtraEditors;
using RelayTest.Util.Common;

namespace RelayTest.Application.Settings
{

    /// <summary>
    /// 负载柜基础数据
    /// </summary>
    partial class FrmDevPowerSwitchInfo
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
            this.btnDelete = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnSave = new RelayTest.Util.Common.BaseSimpleButton();
            this.pnlDetail = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lueF_POWER_SWITCH_TYPE = new DevExpress.XtraEditors.LookUpEdit();
            this.txtF_POWER_SWITCH_CALIBRATION = new DevExpress.XtraEditors.TextEdit();
            this.txtF_POWER_SWITCH_ADDRESS = new DevExpress.XtraEditors.TextEdit();
            this.txtF_POWER_ID = new DevExpress.XtraEditors.TextEdit();
            this.txtF_POWER_SWITCH_ID = new DevExpress.XtraEditors.TextEdit();
            this.txtF_LOAD_CAPACITY = new DevExpress.XtraEditors.TextEdit();
            this.txtF_COM_ADDRESS = new DevExpress.XtraEditors.TextEdit();
            this.txtF_ALARM_LIFEDURANCE = new DevExpress.XtraEditors.TextEdit();
            this.txtF_ALARM_TIMEDURANCE = new DevExpress.XtraEditors.TextEdit();
            this.txtF_SWITCH_TIMES = new DevExpress.XtraEditors.TextEdit();
            this.lueF_POWER_SWITCH_STATUS = new DevExpress.XtraEditors.LookUpEdit();
            this.rdoF_DEL = new DevExpress.XtraEditors.RadioGroup();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciF_POWER_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_POWER_SWITCH_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_LOAD_CAPACITY = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_ALARM_LIFEDURANCE = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_ALARM_TIMEDURANCE = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_SWITCH_TIMES = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_DEL = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_POWER_SWITCH_ADDRESS = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_POWER_SWITCH_STATUS = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_POWER_SWITCH_CALIBRATION = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_POWER_SWITCH_TYPE = new DevExpress.XtraLayout.LayoutControlItem();
            this.cboRoundRule = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboPackRule = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblSPR = new RelayTest.Util.Common.BaseLabelControl();
            this.lblZBR = new RelayTest.Util.Common.BaseLabelControl();
            this.txtZBR = new DevExpress.XtraEditors.TextEdit();
            this.txtSPR = new DevExpress.XtraEditors.TextEdit();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.txtF_HOLDREG = new DevExpress.XtraEditors.TextEdit();
            this.lciHoldReg = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.plnButtons)).BeginInit();
            this.plnButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).BeginInit();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueF_POWER_SWITCH_TYPE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_POWER_SWITCH_CALIBRATION.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_POWER_SWITCH_ADDRESS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_POWER_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_POWER_SWITCH_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_CAPACITY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COM_ADDRESS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_ALARM_LIFEDURANCE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_ALARM_TIMEDURANCE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_SWITCH_TIMES.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueF_POWER_SWITCH_STATUS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoF_DEL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_POWER_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_POWER_SWITCH_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_CAPACITY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_ALARM_LIFEDURANCE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_ALARM_TIMEDURANCE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SWITCH_TIMES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_DEL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_POWER_SWITCH_ADDRESS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_POWER_SWITCH_STATUS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_POWER_SWITCH_CALIBRATION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_POWER_SWITCH_TYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoundRule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPackRule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZBR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPR.Properties)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_HOLDREG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHoldReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // plnButtons
            // 
            this.plnButtons.Controls.Add(this.btnEnabled);
            this.plnButtons.Controls.Add(this.btnDisabled);
            this.plnButtons.Controls.Add(this.btnDelete);
            this.plnButtons.Controls.Add(this.btnSave);
            this.plnButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plnButtons.Location = new System.Drawing.Point(0, 270);
            this.plnButtons.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.plnButtons.Name = "plnButtons";
            this.plnButtons.Size = new System.Drawing.Size(924, 58);
            this.plnButtons.TabIndex = 1;
            // 
            // btnEnabled
            // 
            this.btnEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEnabled.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEnabled.Appearance.Options.UseFont = true;
            this.btnEnabled.Location = new System.Drawing.Point(377, 10);
            this.btnEnabled.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEnabled.Name = "btnEnabled";
            this.btnEnabled.Size = new System.Drawing.Size(80, 31);
            this.btnEnabled.TabIndex = 1;
            this.btnEnabled.Text = "启用";
            this.btnEnabled.Click += new System.EventHandler(this.btnEnabled_Click);
            // 
            // btnDisabled
            // 
            this.btnDisabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDisabled.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDisabled.Appearance.Options.UseFont = true;
            this.btnDisabled.Location = new System.Drawing.Point(467, 10);
            this.btnDisabled.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDisabled.Name = "btnDisabled";
            this.btnDisabled.Size = new System.Drawing.Size(80, 31);
            this.btnDisabled.TabIndex = 2;
            this.btnDisabled.Text = "禁用";
            this.btnDisabled.Click += new System.EventHandler(this.btnDisabled_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(557, 10);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 31);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(287, 10);
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
            this.pnlDetail.Controls.Add(this.layoutControl1);
            this.pnlDetail.Controls.Add(this.cboRoundRule);
            this.pnlDetail.Controls.Add(this.cboPackRule);
            this.pnlDetail.Controls.Add(this.lblSPR);
            this.pnlDetail.Controls.Add(this.lblZBR);
            this.pnlDetail.Controls.Add(this.txtZBR);
            this.pnlDetail.Controls.Add(this.txtSPR);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.Location = new System.Drawing.Point(0, 0);
            this.pnlDetail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(924, 270);
            this.pnlDetail.TabIndex = 0;
            this.pnlDetail.Text = "参数设置";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtF_POWER_SWITCH_CALIBRATION);
            this.layoutControl1.Controls.Add(this.txtF_POWER_SWITCH_ADDRESS);
            this.layoutControl1.Controls.Add(this.txtF_POWER_ID);
            this.layoutControl1.Controls.Add(this.txtF_HOLDREG);
            this.layoutControl1.Controls.Add(this.lueF_POWER_SWITCH_TYPE);
            this.layoutControl1.Controls.Add(this.txtF_POWER_SWITCH_ID);
            this.layoutControl1.Controls.Add(this.txtF_LOAD_CAPACITY);
            this.layoutControl1.Controls.Add(this.txtF_COM_ADDRESS);
            this.layoutControl1.Controls.Add(this.txtF_ALARM_LIFEDURANCE);
            this.layoutControl1.Controls.Add(this.txtF_ALARM_TIMEDURANCE);
            this.layoutControl1.Controls.Add(this.txtF_SWITCH_TIMES);
            this.layoutControl1.Controls.Add(this.lueF_POWER_SWITCH_STATUS);
            this.layoutControl1.Controls.Add(this.rdoF_DEL);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 22);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.lcgMain;
            this.layoutControl1.Size = new System.Drawing.Size(920, 246);
            this.layoutControl1.TabIndex = 25;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lueF_POWER_SWITCH_TYPE
            // 
            this.lueF_POWER_SWITCH_TYPE.Location = new System.Drawing.Point(652, 110);
            this.lueF_POWER_SWITCH_TYPE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lueF_POWER_SWITCH_TYPE.Name = "lueF_POWER_SWITCH_TYPE";
            this.lueF_POWER_SWITCH_TYPE.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.lueF_POWER_SWITCH_TYPE.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lueF_POWER_SWITCH_TYPE.Properties.Appearance.Options.UseBackColor = true;
            this.lueF_POWER_SWITCH_TYPE.Properties.Appearance.Options.UseFont = true;
            this.lueF_POWER_SWITCH_TYPE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueF_POWER_SWITCH_TYPE.Properties.NullText = "";
            this.lueF_POWER_SWITCH_TYPE.Size = new System.Drawing.Size(163, 22);
            this.lueF_POWER_SWITCH_TYPE.StyleController = this.layoutControl1;
            this.lueF_POWER_SWITCH_TYPE.TabIndex = 8;
            // 
            // txtF_POWER_SWITCH_CALIBRATION
            // 
            this.txtF_POWER_SWITCH_CALIBRATION.Location = new System.Drawing.Point(291, 110);
            this.txtF_POWER_SWITCH_CALIBRATION.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_POWER_SWITCH_CALIBRATION.Name = "txtF_POWER_SWITCH_CALIBRATION";
            this.txtF_POWER_SWITCH_CALIBRATION.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_POWER_SWITCH_CALIBRATION.Properties.Appearance.Options.UseFont = true;
            this.txtF_POWER_SWITCH_CALIBRATION.Size = new System.Drawing.Size(165, 22);
            this.txtF_POWER_SWITCH_CALIBRATION.StyleController = this.layoutControl1;
            this.txtF_POWER_SWITCH_CALIBRATION.TabIndex = 9;
            // 
            // txtF_POWER_SWITCH_ADDRESS
            // 
            this.txtF_POWER_SWITCH_ADDRESS.Location = new System.Drawing.Point(652, 47);
            this.txtF_POWER_SWITCH_ADDRESS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_POWER_SWITCH_ADDRESS.Name = "txtF_POWER_SWITCH_ADDRESS";
            this.txtF_POWER_SWITCH_ADDRESS.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_POWER_SWITCH_ADDRESS.Properties.Appearance.Options.UseFont = true;
            this.txtF_POWER_SWITCH_ADDRESS.Properties.Appearance.Options.UseTextOptions = true;
            this.txtF_POWER_SWITCH_ADDRESS.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtF_POWER_SWITCH_ADDRESS.Properties.Mask.EditMask = "d";
            this.txtF_POWER_SWITCH_ADDRESS.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtF_POWER_SWITCH_ADDRESS.Properties.MaxLength = 4;
            this.txtF_POWER_SWITCH_ADDRESS.Size = new System.Drawing.Size(163, 22);
            this.txtF_POWER_SWITCH_ADDRESS.StyleController = this.layoutControl1;
            this.txtF_POWER_SWITCH_ADDRESS.TabIndex = 5;
            // 
            // txtF_POWER_ID
            // 
            this.txtF_POWER_ID.Enabled = false;
            this.txtF_POWER_ID.Location = new System.Drawing.Point(291, 15);
            this.txtF_POWER_ID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_POWER_ID.Name = "txtF_POWER_ID";
            this.txtF_POWER_ID.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_POWER_ID.Properties.Appearance.Options.UseFont = true;
            this.txtF_POWER_ID.Size = new System.Drawing.Size(165, 22);
            this.txtF_POWER_ID.StyleController = this.layoutControl1;
            this.txtF_POWER_ID.TabIndex = 0;
            this.txtF_POWER_ID.EditValueChanged += new System.EventHandler(this.txtPowerId_EditValueChanged);
            // 
            // txtF_POWER_SWITCH_ID
            // 
            this.txtF_POWER_SWITCH_ID.Location = new System.Drawing.Point(652, 15);
            this.txtF_POWER_SWITCH_ID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_POWER_SWITCH_ID.Name = "txtF_POWER_SWITCH_ID";
            this.txtF_POWER_SWITCH_ID.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_POWER_SWITCH_ID.Properties.Appearance.Options.UseFont = true;
            this.txtF_POWER_SWITCH_ID.Size = new System.Drawing.Size(163, 22);
            this.txtF_POWER_SWITCH_ID.StyleController = this.layoutControl1;
            this.txtF_POWER_SWITCH_ID.TabIndex = 1;
            // 
            // txtF_LOAD_CAPACITY
            // 
            this.txtF_LOAD_CAPACITY.Location = new System.Drawing.Point(652, 142);
            this.txtF_LOAD_CAPACITY.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_LOAD_CAPACITY.Name = "txtF_LOAD_CAPACITY";
            this.txtF_LOAD_CAPACITY.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_LOAD_CAPACITY.Properties.Appearance.Options.UseFont = true;
            this.txtF_LOAD_CAPACITY.Properties.Appearance.Options.UseTextOptions = true;
            this.txtF_LOAD_CAPACITY.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtF_LOAD_CAPACITY.Properties.Mask.EditMask = "d";
            this.txtF_LOAD_CAPACITY.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtF_LOAD_CAPACITY.Size = new System.Drawing.Size(163, 22);
            this.txtF_LOAD_CAPACITY.StyleController = this.layoutControl1;
            this.txtF_LOAD_CAPACITY.TabIndex = 3;
            // 
            // txtF_COM_ADDRESS
            // 
            this.txtF_COM_ADDRESS.Location = new System.Drawing.Point(291, 47);
            this.txtF_COM_ADDRESS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_COM_ADDRESS.Name = "txtF_COM_ADDRESS";
            this.txtF_COM_ADDRESS.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_COM_ADDRESS.Properties.Appearance.Options.UseFont = true;
            this.txtF_COM_ADDRESS.Properties.Mask.EditMask = "(com|COM)([1-9]|[1-9][0-9])";
            this.txtF_COM_ADDRESS.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtF_COM_ADDRESS.Size = new System.Drawing.Size(165, 22);
            this.txtF_COM_ADDRESS.StyleController = this.layoutControl1;
            this.txtF_COM_ADDRESS.TabIndex = 4;
            // 
            // txtF_ALARM_LIFEDURANCE
            // 
            this.txtF_ALARM_LIFEDURANCE.Location = new System.Drawing.Point(291, 174);
            this.txtF_ALARM_LIFEDURANCE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_ALARM_LIFEDURANCE.Name = "txtF_ALARM_LIFEDURANCE";
            this.txtF_ALARM_LIFEDURANCE.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_ALARM_LIFEDURANCE.Properties.Appearance.Options.UseFont = true;
            this.txtF_ALARM_LIFEDURANCE.Properties.Appearance.Options.UseTextOptions = true;
            this.txtF_ALARM_LIFEDURANCE.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtF_ALARM_LIFEDURANCE.Properties.Mask.EditMask = "d";
            this.txtF_ALARM_LIFEDURANCE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtF_ALARM_LIFEDURANCE.Size = new System.Drawing.Size(165, 22);
            this.txtF_ALARM_LIFEDURANCE.StyleController = this.layoutControl1;
            this.txtF_ALARM_LIFEDURANCE.TabIndex = 4;
            // 
            // txtF_ALARM_TIMEDURANCE
            // 
            this.txtF_ALARM_TIMEDURANCE.Location = new System.Drawing.Point(652, 174);
            this.txtF_ALARM_TIMEDURANCE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_ALARM_TIMEDURANCE.Name = "txtF_ALARM_TIMEDURANCE";
            this.txtF_ALARM_TIMEDURANCE.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_ALARM_TIMEDURANCE.Properties.Appearance.Options.UseFont = true;
            this.txtF_ALARM_TIMEDURANCE.Properties.Appearance.Options.UseTextOptions = true;
            this.txtF_ALARM_TIMEDURANCE.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtF_ALARM_TIMEDURANCE.Properties.Mask.EditMask = "d";
            this.txtF_ALARM_TIMEDURANCE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtF_ALARM_TIMEDURANCE.Size = new System.Drawing.Size(163, 22);
            this.txtF_ALARM_TIMEDURANCE.StyleController = this.layoutControl1;
            this.txtF_ALARM_TIMEDURANCE.TabIndex = 5;
            this.txtF_ALARM_TIMEDURANCE.EditValueChanged += new System.EventHandler(this.txtAlarmTimes_EditValueChanged);
            // 
            // txtF_SWITCH_TIMES
            // 
            this.txtF_SWITCH_TIMES.Location = new System.Drawing.Point(291, 206);
            this.txtF_SWITCH_TIMES.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_SWITCH_TIMES.Name = "txtF_SWITCH_TIMES";
            this.txtF_SWITCH_TIMES.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_SWITCH_TIMES.Properties.Appearance.Options.UseFont = true;
            this.txtF_SWITCH_TIMES.Properties.Appearance.Options.UseTextOptions = true;
            this.txtF_SWITCH_TIMES.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtF_SWITCH_TIMES.Properties.DisplayFormat.FormatString = "d";
            this.txtF_SWITCH_TIMES.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtF_SWITCH_TIMES.Properties.EditFormat.FormatString = "d";
            this.txtF_SWITCH_TIMES.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtF_SWITCH_TIMES.Properties.Mask.EditMask = "d";
            this.txtF_SWITCH_TIMES.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtF_SWITCH_TIMES.Size = new System.Drawing.Size(165, 22);
            this.txtF_SWITCH_TIMES.StyleController = this.layoutControl1;
            this.txtF_SWITCH_TIMES.TabIndex = 6;
            // 
            // lueF_POWER_SWITCH_STATUS
            // 
            this.lueF_POWER_SWITCH_STATUS.Location = new System.Drawing.Point(291, 142);
            this.lueF_POWER_SWITCH_STATUS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lueF_POWER_SWITCH_STATUS.Name = "lueF_POWER_SWITCH_STATUS";
            this.lueF_POWER_SWITCH_STATUS.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.lueF_POWER_SWITCH_STATUS.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lueF_POWER_SWITCH_STATUS.Properties.Appearance.Options.UseBackColor = true;
            this.lueF_POWER_SWITCH_STATUS.Properties.Appearance.Options.UseFont = true;
            this.lueF_POWER_SWITCH_STATUS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueF_POWER_SWITCH_STATUS.Properties.NullText = "";
            this.lueF_POWER_SWITCH_STATUS.Size = new System.Drawing.Size(165, 22);
            this.lueF_POWER_SWITCH_STATUS.StyleController = this.layoutControl1;
            this.lueF_POWER_SWITCH_STATUS.TabIndex = 7;
            // 
            // rdoF_DEL
            // 
            this.rdoF_DEL.Location = new System.Drawing.Point(652, 206);
            this.rdoF_DEL.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rdoF_DEL.Name = "rdoF_DEL";
            this.rdoF_DEL.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rdoF_DEL.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoF_DEL.Properties.Appearance.Options.UseBackColor = true;
            this.rdoF_DEL.Properties.Appearance.Options.UseFont = true;
            this.rdoF_DEL.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "启用"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "禁用")});
            this.rdoF_DEL.Size = new System.Drawing.Size(163, 25);
            this.rdoF_DEL.StyleController = this.layoutControl1;
            this.rdoF_DEL.TabIndex = 8;
            // 
            // lcgMain
            // 
            this.lcgMain.AppearanceGroup.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcgMain.AppearanceGroup.Options.UseFont = true;
            this.lcgMain.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcgMain.AppearanceItemCaption.Options.UseFont = true;
            this.lcgMain.CustomizationFormText = "layoutControlGroup1";
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciF_POWER_ID,
            this.lciF_POWER_SWITCH_ID,
            this.lciF_LOAD_CAPACITY,
            this.lciF_ALARM_LIFEDURANCE,
            this.lciF_ALARM_TIMEDURANCE,
            this.lciF_SWITCH_TIMES,
            this.lciF_DEL,
            this.lciF_POWER_SWITCH_ADDRESS,
            this.layoutControlItem2,
            this.lciF_POWER_SWITCH_STATUS,
            this.lciF_POWER_SWITCH_CALIBRATION,
            this.lciF_POWER_SWITCH_TYPE,
            this.lciHoldReg,
            this.emptySpaceItem1});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.Padding = new DevExpress.XtraLayout.Utils.Padding(100, 100, 10, 10);
            this.lcgMain.Size = new System.Drawing.Size(920, 246);
            this.lcgMain.Text = "lcgMain";
            this.lcgMain.TextVisible = false;
            // 
            // lciF_POWER_ID
            // 
            this.lciF_POWER_ID.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_POWER_ID.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_POWER_ID.Control = this.txtF_POWER_ID;
            this.lciF_POWER_ID.CustomizationFormText = "供电柜编号：";
            this.lciF_POWER_ID.Location = new System.Drawing.Point(0, 0);
            this.lciF_POWER_ID.Name = "lciF_POWER_ID";
            this.lciF_POWER_ID.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciF_POWER_ID.Size = new System.Drawing.Size(361, 32);
            this.lciF_POWER_ID.Text = "供电柜编号：";
            this.lciF_POWER_ID.TextSize = new System.Drawing.Size(182, 14);
            // 
            // lciF_POWER_SWITCH_ID
            // 
            this.lciF_POWER_SWITCH_ID.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lciF_POWER_SWITCH_ID.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_POWER_SWITCH_ID.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_POWER_SWITCH_ID.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_POWER_SWITCH_ID.Control = this.txtF_POWER_SWITCH_ID;
            this.lciF_POWER_SWITCH_ID.CustomizationFormText = "开关序号：";
            this.lciF_POWER_SWITCH_ID.Location = new System.Drawing.Point(361, 0);
            this.lciF_POWER_SWITCH_ID.Name = "lciF_POWER_SWITCH_ID";
            this.lciF_POWER_SWITCH_ID.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciF_POWER_SWITCH_ID.Size = new System.Drawing.Size(359, 32);
            this.lciF_POWER_SWITCH_ID.Text = "开关序号：";
            this.lciF_POWER_SWITCH_ID.TextSize = new System.Drawing.Size(182, 14);
            // 
            // lciF_LOAD_CAPACITY
            // 
            this.lciF_LOAD_CAPACITY.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_LOAD_CAPACITY.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_LOAD_CAPACITY.Control = this.txtF_LOAD_CAPACITY;
            this.lciF_LOAD_CAPACITY.CustomizationFormText = "负荷容量：";
            this.lciF_LOAD_CAPACITY.Location = new System.Drawing.Point(361, 127);
            this.lciF_LOAD_CAPACITY.Name = "lciF_LOAD_CAPACITY";
            this.lciF_LOAD_CAPACITY.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciF_LOAD_CAPACITY.Size = new System.Drawing.Size(359, 32);
            this.lciF_LOAD_CAPACITY.Text = "负荷容量：";
            this.lciF_LOAD_CAPACITY.TextSize = new System.Drawing.Size(182, 14);
            // 
            // lciF_ALARM_LIFEDURANCE
            // 
            this.lciF_ALARM_LIFEDURANCE.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_ALARM_LIFEDURANCE.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_ALARM_LIFEDURANCE.Control = this.txtF_ALARM_LIFEDURANCE;
            this.lciF_ALARM_LIFEDURANCE.CustomizationFormText = "开关报警阈值(按时长)：";
            this.lciF_ALARM_LIFEDURANCE.Location = new System.Drawing.Point(0, 159);
            this.lciF_ALARM_LIFEDURANCE.Name = "lciF_ALARM_LIFEDURANCE";
            this.lciF_ALARM_LIFEDURANCE.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciF_ALARM_LIFEDURANCE.Size = new System.Drawing.Size(361, 32);
            this.lciF_ALARM_LIFEDURANCE.Text = "开关报警阈值(按时长)：";
            this.lciF_ALARM_LIFEDURANCE.TextSize = new System.Drawing.Size(182, 14);
            // 
            // lciF_ALARM_TIMEDURANCE
            // 
            this.lciF_ALARM_TIMEDURANCE.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_ALARM_TIMEDURANCE.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_ALARM_TIMEDURANCE.Control = this.txtF_ALARM_TIMEDURANCE;
            this.lciF_ALARM_TIMEDURANCE.CustomizationFormText = "开关报警阈值(按使用次数)：";
            this.lciF_ALARM_TIMEDURANCE.Location = new System.Drawing.Point(361, 159);
            this.lciF_ALARM_TIMEDURANCE.Name = "lciF_ALARM_TIMEDURANCE";
            this.lciF_ALARM_TIMEDURANCE.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciF_ALARM_TIMEDURANCE.Size = new System.Drawing.Size(359, 32);
            this.lciF_ALARM_TIMEDURANCE.Text = "开关报警阈值(按使用次数)：";
            this.lciF_ALARM_TIMEDURANCE.TextSize = new System.Drawing.Size(182, 14);
            // 
            // lciF_SWITCH_TIMES
            // 
            this.lciF_SWITCH_TIMES.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_SWITCH_TIMES.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_SWITCH_TIMES.Control = this.txtF_SWITCH_TIMES;
            this.lciF_SWITCH_TIMES.CustomizationFormText = "开关动作次数：";
            this.lciF_SWITCH_TIMES.Location = new System.Drawing.Point(0, 191);
            this.lciF_SWITCH_TIMES.Name = "lciF_SWITCH_TIMES";
            this.lciF_SWITCH_TIMES.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciF_SWITCH_TIMES.Size = new System.Drawing.Size(361, 35);
            this.lciF_SWITCH_TIMES.Text = "开关动作次数：";
            this.lciF_SWITCH_TIMES.TextSize = new System.Drawing.Size(182, 14);
            // 
            // lciF_DEL
            // 
            this.lciF_DEL.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_DEL.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_DEL.Control = this.rdoF_DEL;
            this.lciF_DEL.CustomizationFormText = "禁用状态：";
            this.lciF_DEL.Location = new System.Drawing.Point(361, 191);
            this.lciF_DEL.Name = "lciF_DEL";
            this.lciF_DEL.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciF_DEL.Size = new System.Drawing.Size(359, 35);
            this.lciF_DEL.Text = "禁用状态：";
            this.lciF_DEL.TextSize = new System.Drawing.Size(182, 14);
            // 
            // lciF_POWER_SWITCH_ADDRESS
            // 
            this.lciF_POWER_SWITCH_ADDRESS.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_POWER_SWITCH_ADDRESS.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_POWER_SWITCH_ADDRESS.Control = this.txtF_POWER_SWITCH_ADDRESS;
            this.lciF_POWER_SWITCH_ADDRESS.CustomizationFormText = "供电柜开关地址：";
            this.lciF_POWER_SWITCH_ADDRESS.Location = new System.Drawing.Point(361, 32);
            this.lciF_POWER_SWITCH_ADDRESS.Name = "lciF_POWER_SWITCH_ADDRESS";
            this.lciF_POWER_SWITCH_ADDRESS.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciF_POWER_SWITCH_ADDRESS.Size = new System.Drawing.Size(359, 32);
            this.lciF_POWER_SWITCH_ADDRESS.Text = "供电柜地址：";
            this.lciF_POWER_SWITCH_ADDRESS.TextSize = new System.Drawing.Size(182, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.txtF_COM_ADDRESS;
            this.layoutControlItem2.CustomizationFormText = "通信端口地址：";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 32);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem2.Size = new System.Drawing.Size(361, 32);
            this.layoutControlItem2.Text = "通信端口地址：";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(182, 14);
            // 
            // lciF_POWER_SWITCH_STATUS
            // 
            this.lciF_POWER_SWITCH_STATUS.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_POWER_SWITCH_STATUS.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_POWER_SWITCH_STATUS.Control = this.lueF_POWER_SWITCH_STATUS;
            this.lciF_POWER_SWITCH_STATUS.CustomizationFormText = "供电柜开关状态：";
            this.lciF_POWER_SWITCH_STATUS.Location = new System.Drawing.Point(0, 127);
            this.lciF_POWER_SWITCH_STATUS.Name = "lciF_POWER_SWITCH_STATUS";
            this.lciF_POWER_SWITCH_STATUS.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciF_POWER_SWITCH_STATUS.Size = new System.Drawing.Size(361, 32);
            this.lciF_POWER_SWITCH_STATUS.Text = "供电柜开关状态：";
            this.lciF_POWER_SWITCH_STATUS.TextSize = new System.Drawing.Size(182, 14);
            // 
            // lciF_POWER_SWITCH_CALIBRATION
            // 
            this.lciF_POWER_SWITCH_CALIBRATION.Control = this.txtF_POWER_SWITCH_CALIBRATION;
            this.lciF_POWER_SWITCH_CALIBRATION.CustomizationFormText = "校准编号：";
            this.lciF_POWER_SWITCH_CALIBRATION.Location = new System.Drawing.Point(0, 95);
            this.lciF_POWER_SWITCH_CALIBRATION.Name = "lciF_POWER_SWITCH_CALIBRATION";
            this.lciF_POWER_SWITCH_CALIBRATION.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciF_POWER_SWITCH_CALIBRATION.Size = new System.Drawing.Size(361, 32);
            this.lciF_POWER_SWITCH_CALIBRATION.Text = "校准编号：";
            this.lciF_POWER_SWITCH_CALIBRATION.TextSize = new System.Drawing.Size(182, 14);
            // 
            // lciF_POWER_SWITCH_TYPE
            // 
            this.lciF_POWER_SWITCH_TYPE.Control = this.lueF_POWER_SWITCH_TYPE;
            this.lciF_POWER_SWITCH_TYPE.CustomizationFormText = "输入输出类型：";
            this.lciF_POWER_SWITCH_TYPE.Location = new System.Drawing.Point(361, 95);
            this.lciF_POWER_SWITCH_TYPE.Name = "lciF_POWER_SWITCH_TYPE";
            this.lciF_POWER_SWITCH_TYPE.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciF_POWER_SWITCH_TYPE.Size = new System.Drawing.Size(359, 32);
            this.lciF_POWER_SWITCH_TYPE.Text = "输入输出类型：";
            this.lciF_POWER_SWITCH_TYPE.TextSize = new System.Drawing.Size(182, 14);
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
            this.xtraScrollableControl1.Controls.Add(this.pnlDetail);
            this.xtraScrollableControl1.Controls.Add(this.plnButtons);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(924, 328);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // txtF_HOLDREG
            // 
            this.txtF_HOLDREG.Location = new System.Drawing.Point(291, 79);
            this.txtF_HOLDREG.Name = "txtF_HOLDREG";
            this.txtF_HOLDREG.Size = new System.Drawing.Size(165, 21);
            this.txtF_HOLDREG.StyleController = this.layoutControl1;
            this.txtF_HOLDREG.TabIndex = 10;
            // 
            // lciHoldReg
            // 
            this.lciHoldReg.Control = this.txtF_HOLDREG;
            this.lciHoldReg.CustomizationFormText = "通道号：";
            this.lciHoldReg.Location = new System.Drawing.Point(0, 64);
            this.lciHoldReg.Name = "lciHoldReg";
            this.lciHoldReg.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciHoldReg.Size = new System.Drawing.Size(361, 31);
            this.lciHoldReg.Text = "通道号：";
            this.lciHoldReg.TextSize = new System.Drawing.Size(182, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(352, 64);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(351, 31);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FrmDevPowerSwitchInfo
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(924, 328);
            this.Controls.Add(this.xtraScrollableControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDevPowerSwitchInfo";
            this.Text = "供电开关基本信息";
            this.Load += new System.EventHandler(this.FrmPowerBaseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plnButtons)).EndInit();
            this.plnButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueF_POWER_SWITCH_TYPE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_POWER_SWITCH_CALIBRATION.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_POWER_SWITCH_ADDRESS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_POWER_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_POWER_SWITCH_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_CAPACITY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_COM_ADDRESS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_ALARM_LIFEDURANCE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_ALARM_TIMEDURANCE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_SWITCH_TIMES.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueF_POWER_SWITCH_STATUS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoF_DEL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_POWER_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_POWER_SWITCH_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_CAPACITY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_ALARM_LIFEDURANCE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_ALARM_TIMEDURANCE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SWITCH_TIMES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_DEL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_POWER_SWITCH_ADDRESS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_POWER_SWITCH_STATUS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_POWER_SWITCH_CALIBRATION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_POWER_SWITCH_TYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoundRule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPackRule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZBR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPR.Properties)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtF_HOLDREG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHoldReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl plnButtons;
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
        private TextEdit txtF_POWER_SWITCH_ID;
        private TextEdit txtF_POWER_ID;
        private RadioGroup rdoF_DEL;
        private BaseSimpleButton btnEnabled;
        private BaseSimpleButton btnDisabled;
        private TextEdit txtF_ALARM_TIMEDURANCE;
        private TextEdit txtF_ALARM_LIFEDURANCE;
        private TextEdit txtF_LOAD_CAPACITY;
        private TextEdit txtF_SWITCH_TIMES;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private LookUpEdit lueF_POWER_SWITCH_STATUS;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraLayout.LayoutControlItem lciF_POWER_ID;
        private DevExpress.XtraLayout.LayoutControlItem lciF_POWER_SWITCH_ID;
        private DevExpress.XtraLayout.LayoutControlItem lciF_LOAD_CAPACITY;
        private DevExpress.XtraLayout.LayoutControlItem lciF_ALARM_LIFEDURANCE;
        private DevExpress.XtraLayout.LayoutControlItem lciF_ALARM_TIMEDURANCE;
        private DevExpress.XtraLayout.LayoutControlItem lciF_SWITCH_TIMES;
        private DevExpress.XtraLayout.LayoutControlItem lciF_DEL;
        private TextEdit txtF_POWER_SWITCH_ADDRESS;
        private TextEdit txtF_COM_ADDRESS;
        private DevExpress.XtraLayout.LayoutControlItem lciF_POWER_SWITCH_ADDRESS;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private LookUpEdit lueF_POWER_SWITCH_TYPE;
        private TextEdit txtF_POWER_SWITCH_CALIBRATION;
        private DevExpress.XtraLayout.LayoutControlItem lciF_POWER_SWITCH_STATUS;
        private DevExpress.XtraLayout.LayoutControlItem lciF_POWER_SWITCH_CALIBRATION;
        private DevExpress.XtraLayout.LayoutControlItem lciF_POWER_SWITCH_TYPE;
        private TextEdit txtF_HOLDREG;
        private DevExpress.XtraLayout.LayoutControlItem lciHoldReg;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;

    }
}