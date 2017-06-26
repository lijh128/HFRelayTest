using DevExpress.XtraEditors;
using RelayTest.Util.Common;

namespace RelayTest.Application.Settings
{

    /// <summary>
    /// 负载柜基础数据
    /// </summary>
    partial class FrmDevLoadChannelInfo
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
            this.btnDelete = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnSave = new RelayTest.Util.Common.BaseSimpleButton();
            this.pnlDetail = new DevExpress.XtraEditors.GroupControl();
            this.lcDetail = new DevExpress.XtraLayout.LayoutControl();
            this.txtF_LOAD_CHANNEL_CALIBRATION = new DevExpress.XtraEditors.TextEdit();
            this.txtF_LOAD_CHANNEL_ID = new DevExpress.XtraEditors.TextEdit();
            this.txtF_LOAD_ID = new DevExpress.XtraEditors.TextEdit();
            this.lueF_LOAD_CHANNEL_STATUS = new DevExpress.XtraEditors.LookUpEdit();
            this.radioAllowUse = new DevExpress.XtraEditors.RadioGroup();
            this.txtF_LOAD_CHANNEL_NAME = new DevExpress.XtraEditors.TextEdit();
            this.lcpDetail = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciF_LOAD_CHANNEL_STATUS = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_LOAD_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciAllowUse = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_LOAD_CHANNEL_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_LOAD_CHANNEL_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_LOAD_CHANNEL_CALIBRATION = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.cboRoundRule = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboPackRule = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblSPR = new RelayTest.Util.Common.BaseLabelControl();
            this.lblZBR = new RelayTest.Util.Common.BaseLabelControl();
            this.txtZBR = new DevExpress.XtraEditors.TextEdit();
            this.txtSPR = new DevExpress.XtraEditors.TextEdit();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            ((System.ComponentModel.ISupportInitialize)(this.plnButtons)).BeginInit();
            this.plnButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).BeginInit();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcDetail)).BeginInit();
            this.lcDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_CHANNEL_CALIBRATION.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_CHANNEL_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueF_LOAD_CHANNEL_STATUS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioAllowUse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_CHANNEL_NAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcpDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_CHANNEL_STATUS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAllowUse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_CHANNEL_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_CHANNEL_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_CHANNEL_CALIBRATION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoundRule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPackRule.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZBR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPR.Properties)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
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
            this.plnButtons.Controls.Add(this.btnDelete);
            this.plnButtons.Controls.Add(this.btnSave);
            this.plnButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plnButtons.Location = new System.Drawing.Point(0, 173);
            this.plnButtons.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.plnButtons.Name = "plnButtons";
            this.plnButtons.Size = new System.Drawing.Size(784, 51);
            this.plnButtons.TabIndex = 1;
            // 
            // btnEnabled
            // 
            this.btnEnabled.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEnabled.Appearance.Options.UseFont = true;
            this.btnEnabled.Location = new System.Drawing.Point(307, 11);
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
            this.btnDisabled.Location = new System.Drawing.Point(397, 11);
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
            this.btnDelete.Location = new System.Drawing.Point(487, 11);
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
            this.btnSave.Location = new System.Drawing.Point(217, 11);
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
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.Location = new System.Drawing.Point(0, 0);
            this.pnlDetail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(784, 173);
            this.pnlDetail.TabIndex = 0;
            this.pnlDetail.Text = "参数设置";
            // 
            // lcDetail
            // 
            this.lcDetail.Controls.Add(this.txtF_LOAD_CHANNEL_CALIBRATION);
            this.lcDetail.Controls.Add(this.txtF_LOAD_CHANNEL_ID);
            this.lcDetail.Controls.Add(this.txtF_LOAD_ID);
            this.lcDetail.Controls.Add(this.lueF_LOAD_CHANNEL_STATUS);
            this.lcDetail.Controls.Add(this.radioAllowUse);
            this.lcDetail.Controls.Add(this.txtF_LOAD_CHANNEL_NAME);
            this.lcDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcDetail.Location = new System.Drawing.Point(2, 22);
            this.lcDetail.Name = "lcDetail";
            this.lcDetail.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(821, 142, 250, 350);
            this.lcDetail.Root = this.lcpDetail;
            this.lcDetail.Size = new System.Drawing.Size(780, 149);
            this.lcDetail.TabIndex = 25;
            this.lcDetail.Text = "layoutControl1";
            // 
            // txtF_LOAD_CHANNEL_CALIBRATION
            // 
            this.txtF_LOAD_CHANNEL_CALIBRATION.Location = new System.Drawing.Point(199, 79);
            this.txtF_LOAD_CHANNEL_CALIBRATION.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_LOAD_CHANNEL_CALIBRATION.Name = "txtF_LOAD_CHANNEL_CALIBRATION";
            this.txtF_LOAD_CHANNEL_CALIBRATION.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_LOAD_CHANNEL_CALIBRATION.Properties.Appearance.Options.UseFont = true;
            this.txtF_LOAD_CHANNEL_CALIBRATION.Properties.Mask.EditMask = "d";
            this.txtF_LOAD_CHANNEL_CALIBRATION.Size = new System.Drawing.Size(186, 22);
            this.txtF_LOAD_CHANNEL_CALIBRATION.StyleController = this.lcDetail;
            this.txtF_LOAD_CHANNEL_CALIBRATION.TabIndex = 7;
            // 
            // txtF_LOAD_CHANNEL_ID
            // 
            this.txtF_LOAD_CHANNEL_ID.Location = new System.Drawing.Point(199, 47);
            this.txtF_LOAD_CHANNEL_ID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_LOAD_CHANNEL_ID.Name = "txtF_LOAD_CHANNEL_ID";
            this.txtF_LOAD_CHANNEL_ID.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_LOAD_CHANNEL_ID.Properties.Appearance.Options.UseFont = true;
            this.txtF_LOAD_CHANNEL_ID.Size = new System.Drawing.Size(186, 22);
            this.txtF_LOAD_CHANNEL_ID.StyleController = this.lcDetail;
            this.txtF_LOAD_CHANNEL_ID.TabIndex = 0;
            // 
            // txtF_LOAD_ID
            // 
            this.txtF_LOAD_ID.Enabled = false;
            this.txtF_LOAD_ID.Location = new System.Drawing.Point(199, 15);
            this.txtF_LOAD_ID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_LOAD_ID.Name = "txtF_LOAD_ID";
            this.txtF_LOAD_ID.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_LOAD_ID.Properties.Appearance.Options.UseFont = true;
            this.txtF_LOAD_ID.Properties.Mask.EditMask = "d";
            this.txtF_LOAD_ID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtF_LOAD_ID.Size = new System.Drawing.Size(186, 22);
            this.txtF_LOAD_ID.StyleController = this.lcDetail;
            this.txtF_LOAD_ID.TabIndex = 2;
            // 
            // lueF_LOAD_CHANNEL_STATUS
            // 
            this.lueF_LOAD_CHANNEL_STATUS.Location = new System.Drawing.Point(199, 111);
            this.lueF_LOAD_CHANNEL_STATUS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lueF_LOAD_CHANNEL_STATUS.Name = "lueF_LOAD_CHANNEL_STATUS";
            this.lueF_LOAD_CHANNEL_STATUS.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.lueF_LOAD_CHANNEL_STATUS.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lueF_LOAD_CHANNEL_STATUS.Properties.Appearance.Options.UseBackColor = true;
            this.lueF_LOAD_CHANNEL_STATUS.Properties.Appearance.Options.UseFont = true;
            this.lueF_LOAD_CHANNEL_STATUS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueF_LOAD_CHANNEL_STATUS.Properties.NullText = "";
            this.lueF_LOAD_CHANNEL_STATUS.Size = new System.Drawing.Size(186, 22);
            this.lueF_LOAD_CHANNEL_STATUS.StyleController = this.lcDetail;
            this.lueF_LOAD_CHANNEL_STATUS.TabIndex = 6;
            // 
            // radioAllowUse
            // 
            this.radioAllowUse.Location = new System.Drawing.Point(489, 108);
            this.radioAllowUse.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.radioAllowUse.Name = "radioAllowUse";
            this.radioAllowUse.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioAllowUse.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioAllowUse.Properties.Appearance.Options.UseBackColor = true;
            this.radioAllowUse.Properties.Appearance.Options.UseFont = true;
            this.radioAllowUse.Properties.Columns = 2;
            this.radioAllowUse.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "启用"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "禁用")});
            this.radioAllowUse.Size = new System.Drawing.Size(186, 26);
            this.radioAllowUse.StyleController = this.lcDetail;
            this.radioAllowUse.TabIndex = 54;
            // 
            // txtF_LOAD_CHANNEL_NAME
            // 
            this.txtF_LOAD_CHANNEL_NAME.Location = new System.Drawing.Point(489, 47);
            this.txtF_LOAD_CHANNEL_NAME.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_LOAD_CHANNEL_NAME.Name = "txtF_LOAD_CHANNEL_NAME";
            this.txtF_LOAD_CHANNEL_NAME.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_LOAD_CHANNEL_NAME.Properties.Appearance.Options.UseFont = true;
            this.txtF_LOAD_CHANNEL_NAME.Size = new System.Drawing.Size(186, 22);
            this.txtF_LOAD_CHANNEL_NAME.StyleController = this.lcDetail;
            this.txtF_LOAD_CHANNEL_NAME.TabIndex = 1;
            // 
            // lcpDetail
            // 
            this.lcpDetail.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcpDetail.AppearanceItemCaption.Options.UseFont = true;
            this.lcpDetail.CustomizationFormText = "lcpDetail";
            this.lcpDetail.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcpDetail.GroupBordersVisible = false;
            this.lcpDetail.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciF_LOAD_CHANNEL_STATUS,
            this.lciF_LOAD_ID,
            this.lciAllowUse,
            this.lciF_LOAD_CHANNEL_NAME,
            this.lciF_LOAD_CHANNEL_ID,
            this.lciF_LOAD_CHANNEL_CALIBRATION,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.lcpDetail.Location = new System.Drawing.Point(0, 0);
            this.lcpDetail.Name = "lcpDetail";
            this.lcpDetail.Padding = new DevExpress.XtraLayout.Utils.Padding(100, 100, 10, 10);
            this.lcpDetail.Size = new System.Drawing.Size(780, 149);
            this.lcpDetail.Text = "lcpDetail";
            this.lcpDetail.TextVisible = false;
            // 
            // lciF_LOAD_CHANNEL_STATUS
            // 
            this.lciF_LOAD_CHANNEL_STATUS.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_LOAD_CHANNEL_STATUS.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_LOAD_CHANNEL_STATUS.Control = this.lueF_LOAD_CHANNEL_STATUS;
            this.lciF_LOAD_CHANNEL_STATUS.CustomizationFormText = "通道状态：";
            this.lciF_LOAD_CHANNEL_STATUS.Location = new System.Drawing.Point(0, 96);
            this.lciF_LOAD_CHANNEL_STATUS.Name = "lciF_LOAD_CHANNEL_STATUS";
            this.lciF_LOAD_CHANNEL_STATUS.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciF_LOAD_CHANNEL_STATUS.Size = new System.Drawing.Size(290, 33);
            this.lciF_LOAD_CHANNEL_STATUS.Text = "通道状态：";
            this.lciF_LOAD_CHANNEL_STATUS.TextSize = new System.Drawing.Size(90, 14);
            // 
            // lciF_LOAD_ID
            // 
            this.lciF_LOAD_ID.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lciF_LOAD_ID.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_LOAD_ID.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_LOAD_ID.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_LOAD_ID.Control = this.txtF_LOAD_ID;
            this.lciF_LOAD_ID.CustomizationFormText = "负载编号：";
            this.lciF_LOAD_ID.Location = new System.Drawing.Point(0, 0);
            this.lciF_LOAD_ID.Name = "lciF_LOAD_ID";
            this.lciF_LOAD_ID.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciF_LOAD_ID.Size = new System.Drawing.Size(290, 32);
            this.lciF_LOAD_ID.Text = "负载柜编号：";
            this.lciF_LOAD_ID.TextSize = new System.Drawing.Size(90, 14);
            // 
            // lciAllowUse
            // 
            this.lciAllowUse.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciAllowUse.AppearanceItemCaption.Options.UseFont = true;
            this.lciAllowUse.Control = this.radioAllowUse;
            this.lciAllowUse.CustomizationFormText = "禁用状态：";
            this.lciAllowUse.Location = new System.Drawing.Point(290, 93);
            this.lciAllowUse.Name = "lciAllowUse";
            this.lciAllowUse.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciAllowUse.Size = new System.Drawing.Size(290, 36);
            this.lciAllowUse.Text = "禁用状态：";
            this.lciAllowUse.TextSize = new System.Drawing.Size(90, 14);
            // 
            // lciF_LOAD_CHANNEL_NAME
            // 
            this.lciF_LOAD_CHANNEL_NAME.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lciF_LOAD_CHANNEL_NAME.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_LOAD_CHANNEL_NAME.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_LOAD_CHANNEL_NAME.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_LOAD_CHANNEL_NAME.Control = this.txtF_LOAD_CHANNEL_NAME;
            this.lciF_LOAD_CHANNEL_NAME.CustomizationFormText = "通道名称：";
            this.lciF_LOAD_CHANNEL_NAME.Location = new System.Drawing.Point(290, 32);
            this.lciF_LOAD_CHANNEL_NAME.Name = "lciF_LOAD_CHANNEL_NAME";
            this.lciF_LOAD_CHANNEL_NAME.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciF_LOAD_CHANNEL_NAME.Size = new System.Drawing.Size(290, 32);
            this.lciF_LOAD_CHANNEL_NAME.Text = "通道名称：";
            this.lciF_LOAD_CHANNEL_NAME.TextSize = new System.Drawing.Size(90, 14);
            // 
            // lciF_LOAD_CHANNEL_ID
            // 
            this.lciF_LOAD_CHANNEL_ID.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lciF_LOAD_CHANNEL_ID.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_LOAD_CHANNEL_ID.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_LOAD_CHANNEL_ID.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_LOAD_CHANNEL_ID.Control = this.txtF_LOAD_CHANNEL_ID;
            this.lciF_LOAD_CHANNEL_ID.CustomizationFormText = "通道编号：";
            this.lciF_LOAD_CHANNEL_ID.Location = new System.Drawing.Point(0, 32);
            this.lciF_LOAD_CHANNEL_ID.Name = "lciF_LOAD_CHANNEL_ID";
            this.lciF_LOAD_CHANNEL_ID.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciF_LOAD_CHANNEL_ID.Size = new System.Drawing.Size(290, 32);
            this.lciF_LOAD_CHANNEL_ID.Text = "通道编号：";
            this.lciF_LOAD_CHANNEL_ID.TextSize = new System.Drawing.Size(90, 14);
            // 
            // lciF_LOAD_CHANNEL_CALIBRATION
            // 
            this.lciF_LOAD_CHANNEL_CALIBRATION.Control = this.txtF_LOAD_CHANNEL_CALIBRATION;
            this.lciF_LOAD_CHANNEL_CALIBRATION.CustomizationFormText = "校准编号：";
            this.lciF_LOAD_CHANNEL_CALIBRATION.Location = new System.Drawing.Point(0, 64);
            this.lciF_LOAD_CHANNEL_CALIBRATION.Name = "lciF_LOAD_CHANNEL_CALIBRATION";
            this.lciF_LOAD_CHANNEL_CALIBRATION.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciF_LOAD_CHANNEL_CALIBRATION.Size = new System.Drawing.Size(290, 32);
            this.lciF_LOAD_CHANNEL_CALIBRATION.Text = "校准编号：";
            this.lciF_LOAD_CHANNEL_CALIBRATION.TextSize = new System.Drawing.Size(90, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(290, 64);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.emptySpaceItem1.Size = new System.Drawing.Size(290, 29);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem2.Location = new System.Drawing.Point(290, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(290, 32);
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
            this.xtraScrollableControl1.Controls.Add(this.pnlDetail);
            this.xtraScrollableControl1.Controls.Add(this.plnButtons);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(784, 224);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // FrmDevLoadChannelInfo
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(784, 224);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDevLoadChannelInfo";
            this.Text = "负载通道数据维护";
            this.Load += new System.EventHandler(this.FrmPowerBaseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plnButtons)).EndInit();
            this.plnButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcDetail)).EndInit();
            this.lcDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_CHANNEL_CALIBRATION.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_CHANNEL_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueF_LOAD_CHANNEL_STATUS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioAllowUse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_LOAD_CHANNEL_NAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcpDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_CHANNEL_STATUS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAllowUse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_CHANNEL_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_CHANNEL_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_LOAD_CHANNEL_CALIBRATION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoundRule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPackRule.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZBR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPR.Properties)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
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
        private TextEdit txtF_LOAD_ID;
        private TextEdit txtF_LOAD_CHANNEL_ID;
        private BaseSimpleButton btnEnabled;
        private BaseSimpleButton btnDisabled;
        private TextEdit txtF_LOAD_CHANNEL_NAME;
        private DevExpress.XtraLayout.LayoutControl lcDetail;
        private DevExpress.XtraLayout.LayoutControlGroup lcpDetail;
        private DevExpress.XtraLayout.LayoutControlItem lciF_LOAD_CHANNEL_ID;
        private DevExpress.XtraLayout.LayoutControlItem lciF_LOAD_CHANNEL_STATUS;
        private DevExpress.XtraLayout.LayoutControlItem lciF_LOAD_ID;
        private LookUpEdit lueF_LOAD_CHANNEL_STATUS;
        private RadioGroup radioAllowUse;
        private DevExpress.XtraLayout.LayoutControlItem lciAllowUse;
        private DevExpress.XtraLayout.LayoutControlItem lciF_LOAD_CHANNEL_NAME;
        private TextEdit txtF_LOAD_CHANNEL_CALIBRATION;
        private DevExpress.XtraLayout.LayoutControlItem lciF_LOAD_CHANNEL_CALIBRATION;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;

    }
}