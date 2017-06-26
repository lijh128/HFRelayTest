using DevExpress.XtraEditors;
using RelayTest.Util.Common;

namespace RelayTest.Application.Settings
{

    /// <summary>
    /// 供电柜开关与其他设备关系基本信息
    /// 
    /// </summary>
    partial class FrmDevPowerSwitchOntherDevicesRelationEdit
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
            this.gcDevice = new RelayTest.Util.Common.BaseGridControl();
            this.gvDevice = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colF_LOAD_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_LOAD_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.lcRelation = new DevExpress.XtraLayout.LayoutControl();
            this.gcPower = new RelayTest.Util.Common.BaseGridControl();
            this.gvPower = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colF_POWER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_POWER_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemMemoExEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.cbbDevType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gcSwitch = new RelayTest.Util.Common.BaseGridControl();
            this.gvSwitch = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colF_POWER_SWITCH_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgDevice = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciSwitch = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgLoad = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciLoad = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.lcgDevType = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciDevType = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lcgPower = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciPower = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            this.plnButtons = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new RelayTest.Util.Common.BaseSimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDevice)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcRelation)).BeginInit();
            this.lcRelation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDevType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDevType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDevType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plnButtons)).BeginInit();
            this.plnButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcDevice
            // 
            this.gcDevice.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcDevice.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gcDevice.Location = new System.Drawing.Point(24, 101);
            this.gcDevice.MainView = this.gvDevice;
            this.gcDevice.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcDevice.Name = "gcDevice";
            this.gcDevice.Size = new System.Drawing.Size(294, 553);
            this.gcDevice.TabIndex = 0;
            this.gcDevice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDevice});
            // 
            // gvDevice
            // 
            this.gvDevice.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvDevice.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvDevice.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvDevice.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvDevice.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvDevice.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvDevice.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvDevice.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvDevice.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvDevice.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvDevice.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvDevice.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvDevice.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvDevice.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvDevice.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvDevice.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvDevice.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvDevice.Appearance.Empty.Options.UseBackColor = true;
            this.gvDevice.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvDevice.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvDevice.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvDevice.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvDevice.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvDevice.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvDevice.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvDevice.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvDevice.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvDevice.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvDevice.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvDevice.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvDevice.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvDevice.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvDevice.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvDevice.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvDevice.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvDevice.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvDevice.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvDevice.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvDevice.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvDevice.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvDevice.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvDevice.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvDevice.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvDevice.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvDevice.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvDevice.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvDevice.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvDevice.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvDevice.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvDevice.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvDevice.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvDevice.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvDevice.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvDevice.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvDevice.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvDevice.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvDevice.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvDevice.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvDevice.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvDevice.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvDevice.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvDevice.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvDevice.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvDevice.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvDevice.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvDevice.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvDevice.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvDevice.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvDevice.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvDevice.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvDevice.Appearance.GroupRow.Options.UseFont = true;
            this.gvDevice.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvDevice.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvDevice.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvDevice.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvDevice.Appearance.HeaderPanel.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.gvDevice.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvDevice.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvDevice.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvDevice.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvDevice.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDevice.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvDevice.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvDevice.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvDevice.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvDevice.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvDevice.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvDevice.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvDevice.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvDevice.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvDevice.Appearance.OddRow.Options.UseBackColor = true;
            this.gvDevice.Appearance.OddRow.Options.UseForeColor = true;
            this.gvDevice.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvDevice.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvDevice.Appearance.Preview.Options.UseBackColor = true;
            this.gvDevice.Appearance.Preview.Options.UseForeColor = true;
            this.gvDevice.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvDevice.Appearance.Row.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.gvDevice.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvDevice.Appearance.Row.Options.UseBackColor = true;
            this.gvDevice.Appearance.Row.Options.UseFont = true;
            this.gvDevice.Appearance.Row.Options.UseForeColor = true;
            this.gvDevice.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvDevice.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvDevice.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvDevice.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvDevice.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvDevice.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvDevice.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvDevice.Appearance.VertLine.Options.UseBackColor = true;
            this.gvDevice.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colF_LOAD_ID,
            this.colF_LOAD_NAME});
            this.gvDevice.GridControl = this.gcDevice;
            this.gvDevice.Name = "gvDevice";
            this.gvDevice.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gvDevice.OptionsBehavior.ImmediateUpdateRowPosition = false;
            this.gvDevice.OptionsPrint.AutoWidth = false;
            this.gvDevice.OptionsView.ColumnAutoWidth = false;
            this.gvDevice.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDevice.OptionsView.EnableAppearanceOddRow = true;
            this.gvDevice.OptionsView.ShowGroupPanel = false;
            this.gvDevice.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvList_RowClick);
            // 
            // colF_LOAD_ID
            // 
            this.colF_LOAD_ID.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_LOAD_ID.AppearanceCell.Options.UseFont = true;
            this.colF_LOAD_ID.AppearanceCell.Options.UseTextOptions = true;
            this.colF_LOAD_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_LOAD_ID.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
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
            this.colF_LOAD_NAME.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
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
            this.colF_LOAD_NAME.Width = 151;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.lcRelation);
            this.xtraScrollableControl1.Controls.Add(this.plnButtons);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1008, 730);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // lcRelation
            // 
            this.lcRelation.Controls.Add(this.gcPower);
            this.lcRelation.Controls.Add(this.cbbDevType);
            this.lcRelation.Controls.Add(this.gcSwitch);
            this.lcRelation.Controls.Add(this.gcDevice);
            this.lcRelation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcRelation.Location = new System.Drawing.Point(0, 0);
            this.lcRelation.Name = "lcRelation";
            this.lcRelation.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(72, 219, 235, 350);
            this.lcRelation.Root = this.lcgMain;
            this.lcRelation.Size = new System.Drawing.Size(1008, 678);
            this.lcRelation.TabIndex = 3;
            this.lcRelation.Text = "关系";
            // 
            // gcPower
            // 
            this.gcPower.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcPower.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gcPower.Location = new System.Drawing.Point(352, 101);
            this.gcPower.MainView = this.gvPower;
            this.gcPower.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcPower.Name = "gcPower";
            this.gcPower.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2,
            this.repositoryItemMemoEdit1,
            this.repositoryItemMemoExEdit2});
            this.gcPower.Size = new System.Drawing.Size(632, 248);
            this.gcPower.TabIndex = 2;
            this.gcPower.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPower});
            // 
            // gvPower
            // 
            this.gvPower.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPower.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvPower.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPower.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvPower.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPower.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvPower.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvPower.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvPower.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvPower.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvPower.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvPower.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvPower.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPower.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvPower.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvPower.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvPower.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvPower.Appearance.Empty.Options.UseBackColor = true;
            this.gvPower.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvPower.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvPower.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvPower.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvPower.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPower.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvPower.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPower.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvPower.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPower.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvPower.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvPower.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvPower.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvPower.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvPower.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvPower.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvPower.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvPower.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvPower.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvPower.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvPower.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvPower.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvPower.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPower.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvPower.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPower.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPower.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPower.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvPower.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvPower.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvPower.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvPower.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvPower.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvPower.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvPower.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvPower.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvPower.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvPower.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvPower.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvPower.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvPower.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvPower.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvPower.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvPower.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPower.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvPower.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvPower.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvPower.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvPower.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvPower.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvPower.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvPower.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvPower.Appearance.GroupRow.Options.UseFont = true;
            this.gvPower.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvPower.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPower.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvPower.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvPower.Appearance.HeaderPanel.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.gvPower.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPower.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPower.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvPower.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvPower.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvPower.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvPower.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvPower.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvPower.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvPower.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvPower.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvPower.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvPower.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvPower.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvPower.Appearance.OddRow.Options.UseBackColor = true;
            this.gvPower.Appearance.OddRow.Options.UseForeColor = true;
            this.gvPower.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvPower.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvPower.Appearance.Preview.Options.UseBackColor = true;
            this.gvPower.Appearance.Preview.Options.UseForeColor = true;
            this.gvPower.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvPower.Appearance.Row.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.gvPower.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvPower.Appearance.Row.Options.UseBackColor = true;
            this.gvPower.Appearance.Row.Options.UseFont = true;
            this.gvPower.Appearance.Row.Options.UseForeColor = true;
            this.gvPower.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvPower.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvPower.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvPower.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvPower.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvPower.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvPower.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvPower.Appearance.VertLine.Options.UseBackColor = true;
            this.gvPower.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colF_POWER_ID,
            this.colF_POWER_NAME});
            this.gvPower.GridControl = this.gcPower;
            this.gvPower.Name = "gvPower";
            this.gvPower.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gvPower.OptionsBehavior.ImmediateUpdateRowPosition = false;
            this.gvPower.OptionsPrint.AutoWidth = false;
            this.gvPower.OptionsView.ColumnAutoWidth = false;
            this.gvPower.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPower.OptionsView.EnableAppearanceOddRow = true;
            this.gvPower.OptionsView.ShowGroupPanel = false;
            this.gvPower.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvPower_RowClick);
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
            this.colF_POWER_ID.Caption = "编号";
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
            this.colF_POWER_NAME.Width = 154;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            this.repositoryItemCheckEdit2.ValueChecked = 1;
            this.repositoryItemCheckEdit2.ValueUnchecked = 0;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // repositoryItemMemoExEdit2
            // 
            this.repositoryItemMemoExEdit2.AutoHeight = false;
            this.repositoryItemMemoExEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit2.Name = "repositoryItemMemoExEdit2";
            // 
            // cbbDevType
            // 
            this.cbbDevType.Location = new System.Drawing.Point(87, 27);
            this.cbbDevType.Name = "cbbDevType";
            this.cbbDevType.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDevType.Properties.Appearance.Options.UseFont = true;
            this.cbbDevType.Properties.AppearanceDropDown.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDevType.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbbDevType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbDevType.Properties.Items.AddRange(new object[] {
            "负载电源",
            "负载柜"});
            this.cbbDevType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbDevType.Size = new System.Drawing.Size(228, 22);
            this.cbbDevType.StyleController = this.lcRelation;
            this.cbbDevType.TabIndex = 6;
            this.cbbDevType.SelectedIndexChanged += new System.EventHandler(this.cbbDevType_SelectedIndexChanged);
            // 
            // gcSwitch
            // 
            this.gcSwitch.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcSwitch.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gcSwitch.Location = new System.Drawing.Point(352, 404);
            this.gcSwitch.MainView = this.gvSwitch;
            this.gcSwitch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcSwitch.Name = "gcSwitch";
            this.gcSwitch.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemMemoEdit,
            this.repositoryItemMemoExEdit1});
            this.gcSwitch.Size = new System.Drawing.Size(632, 250);
            this.gcSwitch.TabIndex = 1;
            this.gcSwitch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSwitch});
            // 
            // gvSwitch
            // 
            this.gvSwitch.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSwitch.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvSwitch.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSwitch.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvSwitch.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvSwitch.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvSwitch.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvSwitch.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvSwitch.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvSwitch.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvSwitch.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvSwitch.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvSwitch.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvSwitch.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvSwitch.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvSwitch.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvSwitch.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvSwitch.Appearance.Empty.Options.UseBackColor = true;
            this.gvSwitch.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvSwitch.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvSwitch.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvSwitch.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvSwitch.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSwitch.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvSwitch.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSwitch.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvSwitch.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvSwitch.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvSwitch.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvSwitch.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvSwitch.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvSwitch.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvSwitch.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvSwitch.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvSwitch.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvSwitch.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvSwitch.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvSwitch.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvSwitch.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvSwitch.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvSwitch.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSwitch.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvSwitch.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSwitch.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvSwitch.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvSwitch.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvSwitch.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvSwitch.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvSwitch.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSwitch.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSwitch.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvSwitch.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvSwitch.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvSwitch.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvSwitch.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSwitch.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSwitch.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvSwitch.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvSwitch.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvSwitch.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvSwitch.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvSwitch.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSwitch.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvSwitch.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvSwitch.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSwitch.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSwitch.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvSwitch.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvSwitch.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvSwitch.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvSwitch.Appearance.GroupRow.Options.UseFont = true;
            this.gvSwitch.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvSwitch.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSwitch.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvSwitch.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSwitch.Appearance.HeaderPanel.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.gvSwitch.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvSwitch.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvSwitch.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvSwitch.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvSwitch.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvSwitch.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvSwitch.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvSwitch.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvSwitch.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvSwitch.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvSwitch.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvSwitch.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvSwitch.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvSwitch.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvSwitch.Appearance.OddRow.Options.UseBackColor = true;
            this.gvSwitch.Appearance.OddRow.Options.UseForeColor = true;
            this.gvSwitch.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvSwitch.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvSwitch.Appearance.Preview.Options.UseBackColor = true;
            this.gvSwitch.Appearance.Preview.Options.UseForeColor = true;
            this.gvSwitch.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvSwitch.Appearance.Row.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.gvSwitch.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvSwitch.Appearance.Row.Options.UseBackColor = true;
            this.gvSwitch.Appearance.Row.Options.UseFont = true;
            this.gvSwitch.Appearance.Row.Options.UseForeColor = true;
            this.gvSwitch.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvSwitch.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvSwitch.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvSwitch.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvSwitch.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvSwitch.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvSwitch.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvSwitch.Appearance.VertLine.Options.UseBackColor = true;
            this.gvSwitch.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCheck,
            this.colF_POWER_SWITCH_ID});
            this.gvSwitch.GridControl = this.gcSwitch;
            this.gvSwitch.Name = "gvSwitch";
            this.gvSwitch.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gvSwitch.OptionsBehavior.ImmediateUpdateRowPosition = false;
            this.gvSwitch.OptionsPrint.AutoWidth = false;
            this.gvSwitch.OptionsView.ColumnAutoWidth = false;
            this.gvSwitch.OptionsView.EnableAppearanceEvenRow = true;
            this.gvSwitch.OptionsView.EnableAppearanceOddRow = true;
            this.gvSwitch.OptionsView.ShowGroupPanel = false;
            // 
            // colCheck
            // 
            this.colCheck.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCheck.AppearanceCell.Options.UseFont = true;
            this.colCheck.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colCheck.AppearanceHeader.Options.UseFont = true;
            this.colCheck.Caption = "选择";
            this.colCheck.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colCheck.FieldName = "F_CHECK";
            this.colCheck.Name = "colCheck";
            this.colCheck.Visible = true;
            this.colCheck.VisibleIndex = 0;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
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
            this.colF_POWER_SWITCH_ID.Caption = "编号";
            this.colF_POWER_SWITCH_ID.FieldName = "F_POWER_SWITCH_ID";
            this.colF_POWER_SWITCH_ID.Name = "colF_POWER_SWITCH_ID";
            this.colF_POWER_SWITCH_ID.OptionsColumn.AllowEdit = false;
            this.colF_POWER_SWITCH_ID.OptionsColumn.AllowFocus = false;
            this.colF_POWER_SWITCH_ID.Visible = true;
            this.colF_POWER_SWITCH_ID.VisibleIndex = 1;
            this.colF_POWER_SWITCH_ID.Width = 118;
            // 
            // repositoryItemMemoEdit
            // 
            this.repositoryItemMemoEdit.Name = "repositoryItemMemoEdit";
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // lcgMain
            // 
            this.lcgMain.CustomizationFormText = "上位机数据";
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgDevice,
            this.lcgLoad,
            this.splitterItem1,
            this.lcgDevType,
            this.lcgPower,
            this.splitterItem2});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "Root";
            this.lcgMain.ShowInCustomizationForm = false;
            this.lcgMain.Size = new System.Drawing.Size(1008, 678);
            this.lcgMain.Text = "上位机数据";
            this.lcgMain.TextVisible = false;
            // 
            // lcgDevice
            // 
            this.lcgDevice.AllowHide = false;
            this.lcgDevice.CustomizationFormText = "供电柜数据";
            this.lcgDevice.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciSwitch});
            this.lcgDevice.Location = new System.Drawing.Point(328, 359);
            this.lcgDevice.Name = "lcgDevice";
            this.lcgDevice.Size = new System.Drawing.Size(660, 299);
            this.lcgDevice.Text = "开关数据";
            // 
            // lciSwitch
            // 
            this.lciSwitch.Control = this.gcSwitch;
            this.lciSwitch.CustomizationFormText = "layoutControlItem1";
            this.lciSwitch.Location = new System.Drawing.Point(0, 0);
            this.lciSwitch.Name = "lciSwitch";
            this.lciSwitch.Size = new System.Drawing.Size(636, 254);
            this.lciSwitch.Text = "供电柜";
            this.lciSwitch.TextSize = new System.Drawing.Size(0, 0);
            this.lciSwitch.TextToControlDistance = 0;
            this.lciSwitch.TextVisible = false;
            // 
            // lcgLoad
            // 
            this.lcgLoad.AllowCustomizeChildren = false;
            this.lcgLoad.AllowHide = false;
            this.lcgLoad.CustomizationFormText = "上位机数据";
            this.lcgLoad.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciLoad});
            this.lcgLoad.Location = new System.Drawing.Point(0, 56);
            this.lcgLoad.Name = "lcgLoad";
            this.lcgLoad.Size = new System.Drawing.Size(322, 602);
            this.lcgLoad.Text = "设备数据";
            // 
            // lciLoad
            // 
            this.lciLoad.Control = this.gcDevice;
            this.lciLoad.CustomizationFormText = "lciWorkStation";
            this.lciLoad.Location = new System.Drawing.Point(0, 0);
            this.lciLoad.Name = "lciLoad";
            this.lciLoad.Size = new System.Drawing.Size(298, 557);
            this.lciLoad.Text = "lciLoad";
            this.lciLoad.TextSize = new System.Drawing.Size(0, 0);
            this.lciLoad.TextToControlDistance = 0;
            this.lciLoad.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(322, 56);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(6, 602);
            // 
            // lcgDevType
            // 
            this.lcgDevType.AllowHide = false;
            this.lcgDevType.CustomizationFormText = "设备类型";
            this.lcgDevType.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciDevType,
            this.emptySpaceItem1});
            this.lcgDevType.Location = new System.Drawing.Point(0, 0);
            this.lcgDevType.Name = "lcgDevType";
            this.lcgDevType.ShowInCustomizationForm = false;
            this.lcgDevType.Size = new System.Drawing.Size(988, 56);
            this.lcgDevType.Text = "设备类型";
            this.lcgDevType.TextVisible = false;
            // 
            // lciDevType
            // 
            this.lciDevType.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciDevType.AppearanceItemCaption.Options.UseFont = true;
            this.lciDevType.Control = this.cbbDevType;
            this.lciDevType.CustomizationFormText = "设备类型";
            this.lciDevType.Location = new System.Drawing.Point(0, 0);
            this.lciDevType.Name = "lciDevType";
            this.lciDevType.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciDevType.Size = new System.Drawing.Size(298, 32);
            this.lciDevType.Text = "设备类型";
            this.lciDevType.TextSize = new System.Drawing.Size(56, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(298, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(666, 32);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lcgPower
            // 
            this.lcgPower.CustomizationFormText = "配电柜数据";
            this.lcgPower.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciPower});
            this.lcgPower.Location = new System.Drawing.Point(328, 56);
            this.lcgPower.Name = "lcgPower";
            this.lcgPower.Size = new System.Drawing.Size(660, 297);
            this.lcgPower.Text = "配电柜数据";
            // 
            // lciPower
            // 
            this.lciPower.Control = this.gcPower;
            this.lciPower.CustomizationFormText = "layoutControlItem1";
            this.lciPower.Location = new System.Drawing.Point(0, 0);
            this.lciPower.Name = "lciPower";
            this.lciPower.Size = new System.Drawing.Size(636, 252);
            this.lciPower.Text = "lciPower";
            this.lciPower.TextSize = new System.Drawing.Size(0, 0);
            this.lciPower.TextToControlDistance = 0;
            this.lciPower.TextVisible = false;
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.CustomizationFormText = "splitterItem2";
            this.splitterItem2.Location = new System.Drawing.Point(328, 353);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(660, 6);
            // 
            // plnButtons
            // 
            this.plnButtons.Controls.Add(this.btnSave);
            this.plnButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plnButtons.Location = new System.Drawing.Point(0, 678);
            this.plnButtons.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.plnButtons.Name = "plnButtons";
            this.plnButtons.Size = new System.Drawing.Size(1008, 52);
            this.plnButtons.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(464, 11);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmDevPowerSwitchOntherDevicesRelationEdit
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmDevPowerSwitchOntherDevicesRelationEdit";
            this.Text = "供电柜开关与其他设备关系维护";
            this.Load += new System.EventHandler(this.FrmLoadOntherDevicesRelationEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDevice)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcRelation)).EndInit();
            this.lcRelation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDevType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDevType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDevType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plnButtons)).EndInit();
            this.plnButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gvDevice;
        private DevExpress.XtraGrid.Columns.GridColumn colF_LOAD_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colF_LOAD_NAME;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private BaseGridControl gcDevice;
        private DevExpress.XtraLayout.LayoutControl lcRelation;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraLayout.LayoutControlItem lciLoad;
        private BaseGridControl gcSwitch;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSwitch;
        private DevExpress.XtraGrid.Columns.GridColumn colF_POWER_SWITCH_ID;
        private DevExpress.XtraLayout.LayoutControlGroup lcgDevice;
        private DevExpress.XtraLayout.LayoutControlItem lciSwitch;
        private DevExpress.XtraLayout.LayoutControlGroup lcgLoad;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private PanelControl plnButtons;
        private BaseSimpleButton btnSave;
        private ComboBoxEdit cbbDevType;
        private DevExpress.XtraLayout.LayoutControlGroup lcgDevType;
        private DevExpress.XtraLayout.LayoutControlItem lciDevType;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colCheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private BaseGridControl gcPower;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPower;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colF_POWER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colF_POWER_NAME;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraLayout.LayoutControlItem lciPower;
        private DevExpress.XtraLayout.LayoutControlGroup lcgPower;
        private DevExpress.XtraLayout.SplitterItem splitterItem2;

    }
}