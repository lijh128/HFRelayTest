using DevExpress.XtraEditors;
using RelayTest.Util.Common;

namespace RelayTest.Application.Settings
{

    /// <summary>
    /// 下位机数据更新流水
    /// </summary>
    partial class FrmDevUpgradeRecord
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
            this.btnDownload = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnUpload = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnExport = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnDelete = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnUpdate = new RelayTest.Util.Common.BaseSimpleButton();
            this.pnlDetail = new DevExpress.XtraEditors.GroupControl();
            this.lcDetail = new DevExpress.XtraLayout.LayoutControl();
            this.chkF_ATTATCHMENT = new DevExpress.XtraEditors.CheckEdit();
            this.lueF_DEV_TYPE = new DevExpress.XtraEditors.LookUpEdit();
            this.txtF_HARDWARE_VERSION = new DevExpress.XtraEditors.TextEdit();
            this.txtF_SOFTWARE_VERSION = new DevExpress.XtraEditors.TextEdit();
            this.dteF_USED_DATE = new DevExpress.XtraEditors.DateEdit();
            this.dteF_UPDATE_DATE = new DevExpress.XtraEditors.DateEdit();
            this.txtF_MEMO = new DevExpress.XtraEditors.MemoEdit();
            this.lueF_DEV_ID = new DevExpress.XtraEditors.LookUpEdit();
            this.lcgDetail = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciF_DEV_TYPE = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_DEV_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_HARDWARE_VERSION = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_SOFTWARE_VERSION = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_UPDATE_DATE = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_USED_DATE = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_ATTATCHMENT = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_MEMO = new DevExpress.XtraLayout.LayoutControlItem();
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
            this.colF_DEV_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_DEV_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_HARDWARE_VERSION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_SOFTWARE_VERSION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_UPDATE_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_USED_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            ((System.ComponentModel.ISupportInitialize)(this.plnButtons)).BeginInit();
            this.plnButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).BeginInit();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcDetail)).BeginInit();
            this.lcDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkF_ATTATCHMENT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueF_DEV_TYPE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_HARDWARE_VERSION.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_SOFTWARE_VERSION.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteF_USED_DATE.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteF_USED_DATE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteF_UPDATE_DATE.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteF_UPDATE_DATE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_MEMO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueF_DEV_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_DEV_TYPE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_DEV_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_HARDWARE_VERSION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SOFTWARE_VERSION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_UPDATE_DATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_USED_DATE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_ATTATCHMENT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_MEMO)).BeginInit();
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
            this.plnButtons.Controls.Add(this.btnDownload);
            this.plnButtons.Controls.Add(this.btnUpload);
            this.plnButtons.Controls.Add(this.btnExport);
            this.plnButtons.Controls.Add(this.btnDelete);
            this.plnButtons.Controls.Add(this.btnUpdate);
            this.plnButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plnButtons.Location = new System.Drawing.Point(0, 514);
            this.plnButtons.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.plnButtons.Name = "plnButtons";
            this.plnButtons.Size = new System.Drawing.Size(1008, 50);
            this.plnButtons.TabIndex = 2;
            // 
            // btnDownload
            // 
            this.btnDownload.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDownload.Appearance.Options.UseFont = true;
            this.btnDownload.Location = new System.Drawing.Point(559, 9);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(80, 31);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "下载附件";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpload.Appearance.Options.UseFont = true;
            this.btnUpload.Location = new System.Drawing.Point(468, 9);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(80, 31);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "上传附件";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnExport
            // 
            this.btnExport.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.Location = new System.Drawing.Point(648, 9);
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
            this.btnDelete.Location = new System.Drawing.Point(371, 9);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 31);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Location = new System.Drawing.Point(281, 9);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 31);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "保存";
            this.btnUpdate.Click += new System.EventHandler(this.btnSave_Click);
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
            this.pnlDetail.Location = new System.Drawing.Point(0, 291);
            this.pnlDetail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(1008, 223);
            this.pnlDetail.TabIndex = 1;
            this.pnlDetail.Text = "参数设置";
            // 
            // lcDetail
            // 
            this.lcDetail.AllowCustomizationMenu = false;
            this.lcDetail.Controls.Add(this.chkF_ATTATCHMENT);
            this.lcDetail.Controls.Add(this.lueF_DEV_TYPE);
            this.lcDetail.Controls.Add(this.txtF_HARDWARE_VERSION);
            this.lcDetail.Controls.Add(this.txtF_SOFTWARE_VERSION);
            this.lcDetail.Controls.Add(this.dteF_USED_DATE);
            this.lcDetail.Controls.Add(this.dteF_UPDATE_DATE);
            this.lcDetail.Controls.Add(this.txtF_MEMO);
            this.lcDetail.Controls.Add(this.lueF_DEV_ID);
            this.lcDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcDetail.Location = new System.Drawing.Point(2, 22);
            this.lcDetail.Name = "lcDetail";
            this.lcDetail.Root = this.lcgDetail;
            this.lcDetail.Size = new System.Drawing.Size(1004, 199);
            this.lcDetail.TabIndex = 25;
            this.lcDetail.Text = "layoutControl1";
            // 
            // chkF_ATTATCHMENT
            // 
            this.chkF_ATTATCHMENT.Enabled = false;
            this.chkF_ATTATCHMENT.Location = new System.Drawing.Point(613, 90);
            this.chkF_ATTATCHMENT.Name = "chkF_ATTATCHMENT";
            this.chkF_ATTATCHMENT.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkF_ATTATCHMENT.Properties.Appearance.Options.UseFont = true;
            this.chkF_ATTATCHMENT.Properties.Caption = "附件";
            this.chkF_ATTATCHMENT.Size = new System.Drawing.Size(289, 19);
            this.chkF_ATTATCHMENT.StyleController = this.lcDetail;
            this.chkF_ATTATCHMENT.TabIndex = 5;
            // 
            // lueF_DEV_TYPE
            // 
            this.lueF_DEV_TYPE.Location = new System.Drawing.Point(214, 12);
            this.lueF_DEV_TYPE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lueF_DEV_TYPE.Name = "lueF_DEV_TYPE";
            this.lueF_DEV_TYPE.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lueF_DEV_TYPE.Properties.Appearance.Options.UseFont = true;
            this.lueF_DEV_TYPE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueF_DEV_TYPE.Properties.NullText = "";
            this.lueF_DEV_TYPE.Size = new System.Drawing.Size(283, 22);
            this.lueF_DEV_TYPE.StyleController = this.lcDetail;
            this.lueF_DEV_TYPE.TabIndex = 55;
            this.lueF_DEV_TYPE.EditValueChanged += new System.EventHandler(this.lueF_DEV_TYPE_EditValueChanged);
            // 
            // txtF_HARDWARE_VERSION
            // 
            this.txtF_HARDWARE_VERSION.Location = new System.Drawing.Point(214, 38);
            this.txtF_HARDWARE_VERSION.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_HARDWARE_VERSION.Name = "txtF_HARDWARE_VERSION";
            this.txtF_HARDWARE_VERSION.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_HARDWARE_VERSION.Properties.Appearance.Options.UseFont = true;
            this.txtF_HARDWARE_VERSION.Size = new System.Drawing.Size(283, 22);
            this.txtF_HARDWARE_VERSION.StyleController = this.lcDetail;
            this.txtF_HARDWARE_VERSION.TabIndex = 1;
            // 
            // txtF_SOFTWARE_VERSION
            // 
            this.txtF_SOFTWARE_VERSION.Location = new System.Drawing.Point(616, 38);
            this.txtF_SOFTWARE_VERSION.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_SOFTWARE_VERSION.Name = "txtF_SOFTWARE_VERSION";
            this.txtF_SOFTWARE_VERSION.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_SOFTWARE_VERSION.Properties.Appearance.Options.UseFont = true;
            this.txtF_SOFTWARE_VERSION.Size = new System.Drawing.Size(283, 22);
            this.txtF_SOFTWARE_VERSION.StyleController = this.lcDetail;
            this.txtF_SOFTWARE_VERSION.TabIndex = 2;
            // 
            // dteF_USED_DATE
            // 
            this.dteF_USED_DATE.EditValue = null;
            this.dteF_USED_DATE.Location = new System.Drawing.Point(616, 64);
            this.dteF_USED_DATE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dteF_USED_DATE.Name = "dteF_USED_DATE";
            this.dteF_USED_DATE.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dteF_USED_DATE.Properties.Appearance.Options.UseFont = true;
            this.dteF_USED_DATE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteF_USED_DATE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.dteF_USED_DATE.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dteF_USED_DATE.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteF_USED_DATE.Size = new System.Drawing.Size(283, 22);
            this.dteF_USED_DATE.StyleController = this.lcDetail;
            this.dteF_USED_DATE.TabIndex = 4;
            // 
            // dteF_UPDATE_DATE
            // 
            this.dteF_UPDATE_DATE.EditValue = null;
            this.dteF_UPDATE_DATE.Location = new System.Drawing.Point(214, 64);
            this.dteF_UPDATE_DATE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dteF_UPDATE_DATE.Name = "dteF_UPDATE_DATE";
            this.dteF_UPDATE_DATE.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dteF_UPDATE_DATE.Properties.Appearance.Options.UseFont = true;
            this.dteF_UPDATE_DATE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteF_UPDATE_DATE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.dteF_UPDATE_DATE.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dteF_UPDATE_DATE.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteF_UPDATE_DATE.Size = new System.Drawing.Size(283, 22);
            this.dteF_UPDATE_DATE.StyleController = this.lcDetail;
            this.dteF_UPDATE_DATE.TabIndex = 3;
            // 
            // txtF_MEMO
            // 
            this.txtF_MEMO.Location = new System.Drawing.Point(214, 113);
            this.txtF_MEMO.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtF_MEMO.Name = "txtF_MEMO";
            this.txtF_MEMO.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_MEMO.Properties.Appearance.Options.UseFont = true;
            this.txtF_MEMO.Size = new System.Drawing.Size(685, 74);
            this.txtF_MEMO.StyleController = this.lcDetail;
            this.txtF_MEMO.TabIndex = 55;
            // 
            // lueF_DEV_ID
            // 
            this.lueF_DEV_ID.Location = new System.Drawing.Point(616, 12);
            this.lueF_DEV_ID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lueF_DEV_ID.Name = "lueF_DEV_ID";
            this.lueF_DEV_ID.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lueF_DEV_ID.Properties.Appearance.Options.UseFont = true;
            this.lueF_DEV_ID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueF_DEV_ID.Properties.NullText = "";
            this.lueF_DEV_ID.Size = new System.Drawing.Size(283, 22);
            this.lueF_DEV_ID.StyleController = this.lcDetail;
            this.lueF_DEV_ID.TabIndex = 0;
            // 
            // lcgDetail
            // 
            this.lcgDetail.CustomizationFormText = "lcgDetail";
            this.lcgDetail.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgDetail.GroupBordersVisible = false;
            this.lcgDetail.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciF_DEV_TYPE,
            this.lciF_DEV_ID,
            this.lciF_HARDWARE_VERSION,
            this.lciF_SOFTWARE_VERSION,
            this.lciF_UPDATE_DATE,
            this.lciF_USED_DATE,
            this.lciF_ATTATCHMENT,
            this.lciF_MEMO});
            this.lcgDetail.Location = new System.Drawing.Point(0, 0);
            this.lcgDetail.Name = "lcgDetail";
            this.lcgDetail.OptionsItemText.AlignControlsWithHiddenText = true;
            this.lcgDetail.Padding = new DevExpress.XtraLayout.Utils.Padding(100, 100, 10, 10);
            this.lcgDetail.Size = new System.Drawing.Size(1004, 199);
            this.lcgDetail.Text = "lcgDetail";
            this.lcgDetail.TextVisible = false;
            // 
            // lciF_DEV_TYPE
            // 
            this.lciF_DEV_TYPE.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lciF_DEV_TYPE.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_DEV_TYPE.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_DEV_TYPE.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_DEV_TYPE.Control = this.lueF_DEV_TYPE;
            this.lciF_DEV_TYPE.CustomizationFormText = "试验设备类型：";
            this.lciF_DEV_TYPE.Location = new System.Drawing.Point(0, 0);
            this.lciF_DEV_TYPE.Name = "lciF_DEV_TYPE";
            this.lciF_DEV_TYPE.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.lciF_DEV_TYPE.Size = new System.Drawing.Size(402, 26);
            this.lciF_DEV_TYPE.Text = "试验设备类型：";
            this.lciF_DEV_TYPE.TextSize = new System.Drawing.Size(105, 14);
            // 
            // lciF_DEV_ID
            // 
            this.lciF_DEV_ID.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lciF_DEV_ID.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_DEV_ID.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_DEV_ID.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_DEV_ID.Control = this.lueF_DEV_ID;
            this.lciF_DEV_ID.CustomizationFormText = "设备编号：";
            this.lciF_DEV_ID.Location = new System.Drawing.Point(402, 0);
            this.lciF_DEV_ID.Name = "lciF_DEV_ID";
            this.lciF_DEV_ID.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.lciF_DEV_ID.Size = new System.Drawing.Size(402, 26);
            this.lciF_DEV_ID.Text = "设备编号：";
            this.lciF_DEV_ID.TextSize = new System.Drawing.Size(105, 14);
            // 
            // lciF_HARDWARE_VERSION
            // 
            this.lciF_HARDWARE_VERSION.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lciF_HARDWARE_VERSION.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_HARDWARE_VERSION.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_HARDWARE_VERSION.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_HARDWARE_VERSION.Control = this.txtF_HARDWARE_VERSION;
            this.lciF_HARDWARE_VERSION.CustomizationFormText = "硬件版本：";
            this.lciF_HARDWARE_VERSION.Location = new System.Drawing.Point(0, 26);
            this.lciF_HARDWARE_VERSION.Name = "lciF_HARDWARE_VERSION";
            this.lciF_HARDWARE_VERSION.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.lciF_HARDWARE_VERSION.Size = new System.Drawing.Size(402, 26);
            this.lciF_HARDWARE_VERSION.Text = "硬件版本：";
            this.lciF_HARDWARE_VERSION.TextSize = new System.Drawing.Size(105, 14);
            // 
            // lciF_SOFTWARE_VERSION
            // 
            this.lciF_SOFTWARE_VERSION.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lciF_SOFTWARE_VERSION.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_SOFTWARE_VERSION.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_SOFTWARE_VERSION.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_SOFTWARE_VERSION.Control = this.txtF_SOFTWARE_VERSION;
            this.lciF_SOFTWARE_VERSION.CustomizationFormText = "软件版本：";
            this.lciF_SOFTWARE_VERSION.Location = new System.Drawing.Point(402, 26);
            this.lciF_SOFTWARE_VERSION.Name = "lciF_SOFTWARE_VERSION";
            this.lciF_SOFTWARE_VERSION.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.lciF_SOFTWARE_VERSION.Size = new System.Drawing.Size(402, 26);
            this.lciF_SOFTWARE_VERSION.Text = "软件版本：";
            this.lciF_SOFTWARE_VERSION.TextSize = new System.Drawing.Size(105, 14);
            // 
            // lciF_UPDATE_DATE
            // 
            this.lciF_UPDATE_DATE.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_UPDATE_DATE.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_UPDATE_DATE.Control = this.dteF_UPDATE_DATE;
            this.lciF_UPDATE_DATE.CustomizationFormText = "更新时间：";
            this.lciF_UPDATE_DATE.Location = new System.Drawing.Point(0, 52);
            this.lciF_UPDATE_DATE.Name = "lciF_UPDATE_DATE";
            this.lciF_UPDATE_DATE.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.lciF_UPDATE_DATE.Size = new System.Drawing.Size(402, 49);
            this.lciF_UPDATE_DATE.Text = "更新时间：";
            this.lciF_UPDATE_DATE.TextSize = new System.Drawing.Size(105, 14);
            // 
            // lciF_USED_DATE
            // 
            this.lciF_USED_DATE.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_USED_DATE.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_USED_DATE.Control = this.dteF_USED_DATE;
            this.lciF_USED_DATE.CustomizationFormText = "启用时间：";
            this.lciF_USED_DATE.Location = new System.Drawing.Point(402, 52);
            this.lciF_USED_DATE.Name = "lciF_USED_DATE";
            this.lciF_USED_DATE.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.lciF_USED_DATE.Size = new System.Drawing.Size(402, 26);
            this.lciF_USED_DATE.Text = "启用时间：";
            this.lciF_USED_DATE.TextSize = new System.Drawing.Size(105, 14);
            // 
            // lciF_ATTATCHMENT
            // 
            this.lciF_ATTATCHMENT.Control = this.chkF_ATTATCHMENT;
            this.lciF_ATTATCHMENT.CustomizationFormText = "附件：";
            this.lciF_ATTATCHMENT.Location = new System.Drawing.Point(402, 78);
            this.lciF_ATTATCHMENT.Name = "lciF_ATTATCHMENT";
            this.lciF_ATTATCHMENT.Size = new System.Drawing.Size(402, 23);
            this.lciF_ATTATCHMENT.Text = "附件：";
            this.lciF_ATTATCHMENT.TextSize = new System.Drawing.Size(105, 0);
            this.lciF_ATTATCHMENT.TextVisible = false;
            // 
            // lciF_MEMO
            // 
            this.lciF_MEMO.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_MEMO.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_MEMO.Control = this.txtF_MEMO;
            this.lciF_MEMO.CustomizationFormText = "备注：";
            this.lciF_MEMO.Location = new System.Drawing.Point(0, 101);
            this.lciF_MEMO.Name = "lciF_MEMO";
            this.lciF_MEMO.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.lciF_MEMO.Size = new System.Drawing.Size(804, 78);
            this.lciF_MEMO.Text = "备注：";
            this.lciF_MEMO.TextSize = new System.Drawing.Size(105, 14);
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
            this.pnlGrid.Size = new System.Drawing.Size(1008, 291);
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
            this.gcList.Size = new System.Drawing.Size(1004, 267);
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
            this.colF_DEV_TYPE,
            this.colF_DEV_ID,
            this.colF_HARDWARE_VERSION,
            this.colF_SOFTWARE_VERSION,
            this.colF_UPDATE_DATE,
            this.colF_USED_DATE});
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
            // colF_DEV_TYPE
            // 
            this.colF_DEV_TYPE.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_DEV_TYPE.AppearanceCell.Options.UseFont = true;
            this.colF_DEV_TYPE.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_DEV_TYPE.AppearanceHeader.Options.UseFont = true;
            this.colF_DEV_TYPE.Caption = "试验设备类型";
            this.colF_DEV_TYPE.FieldName = "F_DEV_TYPE";
            this.colF_DEV_TYPE.Name = "colF_DEV_TYPE";
            this.colF_DEV_TYPE.OptionsColumn.AllowEdit = false;
            this.colF_DEV_TYPE.OptionsColumn.AllowFocus = false;
            this.colF_DEV_TYPE.Visible = true;
            this.colF_DEV_TYPE.VisibleIndex = 0;
            this.colF_DEV_TYPE.Width = 133;
            // 
            // colF_DEV_ID
            // 
            this.colF_DEV_ID.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_DEV_ID.AppearanceCell.Options.UseFont = true;
            this.colF_DEV_ID.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_DEV_ID.AppearanceHeader.Options.UseFont = true;
            this.colF_DEV_ID.Caption = "设备编号";
            this.colF_DEV_ID.FieldName = "F_DEV_ID";
            this.colF_DEV_ID.Name = "colF_DEV_ID";
            this.colF_DEV_ID.OptionsColumn.AllowEdit = false;
            this.colF_DEV_ID.OptionsColumn.AllowFocus = false;
            this.colF_DEV_ID.Visible = true;
            this.colF_DEV_ID.VisibleIndex = 1;
            // 
            // colF_HARDWARE_VERSION
            // 
            this.colF_HARDWARE_VERSION.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_HARDWARE_VERSION.AppearanceCell.Options.UseFont = true;
            this.colF_HARDWARE_VERSION.AppearanceCell.Options.UseTextOptions = true;
            this.colF_HARDWARE_VERSION.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_HARDWARE_VERSION.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_HARDWARE_VERSION.AppearanceHeader.Options.UseFont = true;
            this.colF_HARDWARE_VERSION.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_HARDWARE_VERSION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_HARDWARE_VERSION.Caption = "硬件版本";
            this.colF_HARDWARE_VERSION.FieldName = "F_HARDWARE_VERSION";
            this.colF_HARDWARE_VERSION.Name = "colF_HARDWARE_VERSION";
            this.colF_HARDWARE_VERSION.OptionsColumn.AllowEdit = false;
            this.colF_HARDWARE_VERSION.OptionsColumn.AllowFocus = false;
            this.colF_HARDWARE_VERSION.Visible = true;
            this.colF_HARDWARE_VERSION.VisibleIndex = 2;
            this.colF_HARDWARE_VERSION.Width = 159;
            // 
            // colF_SOFTWARE_VERSION
            // 
            this.colF_SOFTWARE_VERSION.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SOFTWARE_VERSION.AppearanceCell.Options.UseFont = true;
            this.colF_SOFTWARE_VERSION.AppearanceCell.Options.UseTextOptions = true;
            this.colF_SOFTWARE_VERSION.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_SOFTWARE_VERSION.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SOFTWARE_VERSION.AppearanceHeader.Options.UseFont = true;
            this.colF_SOFTWARE_VERSION.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_SOFTWARE_VERSION.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_SOFTWARE_VERSION.Caption = "软件版本";
            this.colF_SOFTWARE_VERSION.FieldName = "F_SOFTWARE_VERSION";
            this.colF_SOFTWARE_VERSION.Name = "colF_SOFTWARE_VERSION";
            this.colF_SOFTWARE_VERSION.OptionsColumn.AllowEdit = false;
            this.colF_SOFTWARE_VERSION.OptionsColumn.AllowFocus = false;
            this.colF_SOFTWARE_VERSION.Visible = true;
            this.colF_SOFTWARE_VERSION.VisibleIndex = 3;
            this.colF_SOFTWARE_VERSION.Width = 92;
            // 
            // colF_UPDATE_DATE
            // 
            this.colF_UPDATE_DATE.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_UPDATE_DATE.AppearanceCell.Options.UseFont = true;
            this.colF_UPDATE_DATE.AppearanceCell.Options.UseTextOptions = true;
            this.colF_UPDATE_DATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colF_UPDATE_DATE.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_UPDATE_DATE.AppearanceHeader.Options.UseFont = true;
            this.colF_UPDATE_DATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_UPDATE_DATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_UPDATE_DATE.Caption = "更新时间";
            this.colF_UPDATE_DATE.FieldName = "F_UPDATE_DATE";
            this.colF_UPDATE_DATE.Name = "colF_UPDATE_DATE";
            this.colF_UPDATE_DATE.OptionsColumn.AllowEdit = false;
            this.colF_UPDATE_DATE.OptionsColumn.AllowFocus = false;
            this.colF_UPDATE_DATE.Visible = true;
            this.colF_UPDATE_DATE.VisibleIndex = 4;
            this.colF_UPDATE_DATE.Width = 171;
            // 
            // colF_USED_DATE
            // 
            this.colF_USED_DATE.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_USED_DATE.AppearanceCell.Options.UseFont = true;
            this.colF_USED_DATE.AppearanceCell.Options.UseTextOptions = true;
            this.colF_USED_DATE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colF_USED_DATE.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_USED_DATE.AppearanceHeader.Options.UseFont = true;
            this.colF_USED_DATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_USED_DATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_USED_DATE.Caption = "启用时间";
            this.colF_USED_DATE.FieldName = "F_USED_DATE";
            this.colF_USED_DATE.Name = "colF_USED_DATE";
            this.colF_USED_DATE.OptionsColumn.AllowEdit = false;
            this.colF_USED_DATE.OptionsColumn.AllowFocus = false;
            this.colF_USED_DATE.Visible = true;
            this.colF_USED_DATE.VisibleIndex = 5;
            this.colF_USED_DATE.Width = 145;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.pnlGrid);
            this.xtraScrollableControl1.Controls.Add(this.pnlDetail);
            this.xtraScrollableControl1.Controls.Add(this.plnButtons);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1008, 564);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // FrmDevUpgradeRecord
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1008, 564);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmDevUpgradeRecord";
            this.Text = "试验设备更新历史";
            this.Load += new System.EventHandler(this.FrmPowerBaseInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plnButtons)).EndInit();
            this.plnButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetail)).EndInit();
            this.pnlDetail.ResumeLayout(false);
            this.pnlDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcDetail)).EndInit();
            this.lcDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkF_ATTATCHMENT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueF_DEV_TYPE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_HARDWARE_VERSION.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_SOFTWARE_VERSION.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteF_USED_DATE.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteF_USED_DATE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteF_UPDATE_DATE.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteF_UPDATE_DATE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_MEMO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueF_DEV_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_DEV_TYPE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_DEV_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_HARDWARE_VERSION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_SOFTWARE_VERSION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_UPDATE_DATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_USED_DATE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_ATTATCHMENT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_MEMO)).EndInit();
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

        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.PanelControl plnButtons;
        private BaseSimpleButton btnExport;
        private BaseSimpleButton btnDelete;
        private BaseSimpleButton btnUpdate;
        private DevExpress.XtraEditors.GroupControl pnlDetail;
        private BaseLabelControl lblExportOpt;
        private DevExpress.XtraEditors.ComboBoxEdit cboExportOpt;
        private DevExpress.XtraEditors.ComboBoxEdit cboRoundRule;
        private DevExpress.XtraEditors.ComboBoxEdit cboPackRule;
        private BaseLabelControl lblSPR;
        private BaseLabelControl lblZBR;
        private DevExpress.XtraEditors.GroupControl pnlGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gvList;
        private DevExpress.XtraGrid.Columns.GridColumn colF_HARDWARE_VERSION;
        private DevExpress.XtraGrid.Columns.GridColumn colF_SOFTWARE_VERSION;
        private DevExpress.XtraGrid.Columns.GridColumn colF_UPDATE_DATE;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.TextEdit txtZBR;
        private DevExpress.XtraEditors.TextEdit txtSPR;
        private BaseGridControl gcList;
        private TextEdit txtF_SOFTWARE_VERSION;
        private DevExpress.XtraGrid.Columns.GridColumn colF_USED_DATE;
        private DateEdit dteF_USED_DATE;
        private TextEdit txtF_HARDWARE_VERSION;
        private DateEdit dteF_UPDATE_DATE;
        private BaseSimpleButton btnDownload;
        private BaseSimpleButton btnUpload;
        private CheckEdit chkF_ATTATCHMENT;
        private DevExpress.XtraLayout.LayoutControl lcDetail;
        private LookUpEdit lueF_DEV_TYPE;
        private MemoEdit txtF_MEMO;
        private DevExpress.XtraLayout.LayoutControlGroup lcgDetail;
        private DevExpress.XtraLayout.LayoutControlItem lciF_DEV_TYPE;
        private DevExpress.XtraLayout.LayoutControlItem lciF_DEV_ID;
        private DevExpress.XtraLayout.LayoutControlItem lciF_HARDWARE_VERSION;
        private DevExpress.XtraLayout.LayoutControlItem lciF_SOFTWARE_VERSION;
        private DevExpress.XtraLayout.LayoutControlItem lciF_UPDATE_DATE;
        private DevExpress.XtraLayout.LayoutControlItem lciF_USED_DATE;
        private DevExpress.XtraLayout.LayoutControlItem lciF_ATTATCHMENT;
        private DevExpress.XtraLayout.LayoutControlItem lciF_MEMO;
        private DevExpress.XtraGrid.Columns.GridColumn colF_DEV_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colF_DEV_ID;
        private LookUpEdit lueF_DEV_ID;

    }
}