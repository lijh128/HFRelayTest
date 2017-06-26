using DevExpress.XtraEditors;
using RelayTest.Util.Common;

namespace RelayTest.Application.Settings
{

    /// <summary>
    /// 上位机基本信息
    /// 
    /// </summary>
    partial class FrmDevPowerSwitchRelationEdit
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
            this.gcPower = new RelayTest.Util.Common.BaseGridControl();
            this.gvPower = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colF_POWER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_POWER_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.lcRelation = new DevExpress.XtraLayout.LayoutControl();
            this.gcInputSwitch = new RelayTest.Util.Common.BaseGridControl();
            this.gvInputSwitch = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colF_POWER_SWITCH_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemMemoExEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.gcOutputSwitch = new RelayTest.Util.Common.BaseGridControl();
            this.gvOutputSwitch = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colF_DEVID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgOutputSwitch = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciOutSwitch = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgWorkstation = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciWorkStation = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            this.lcgInputSwitch = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.plnButtons = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new RelayTest.Util.Common.BaseSimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.gcPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPower)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcRelation)).BeginInit();
            this.lcRelation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcInputSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInputSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOutputSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOutputSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgOutputSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOutSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgWorkstation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciWorkStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgInputSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plnButtons)).BeginInit();
            this.plnButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcPower
            // 
            this.gcPower.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcPower.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gcPower.Location = new System.Drawing.Point(24, 45);
            this.gcPower.MainView = this.gvPower;
            this.gcPower.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcPower.Name = "gcPower";
            this.gcPower.Size = new System.Drawing.Size(249, 609);
            this.gcPower.TabIndex = 0;
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
            this.gvPower.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvList_RowClick);
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
            this.colF_POWER_ID.Caption = "配电柜编号";
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
            this.colF_POWER_NAME.Caption = "配电柜名称";
            this.colF_POWER_NAME.FieldName = "F_POWER_NAME";
            this.colF_POWER_NAME.Name = "colF_POWER_NAME";
            this.colF_POWER_NAME.OptionsColumn.AllowEdit = false;
            this.colF_POWER_NAME.OptionsColumn.AllowFocus = false;
            this.colF_POWER_NAME.Visible = true;
            this.colF_POWER_NAME.VisibleIndex = 1;
            this.colF_POWER_NAME.Width = 151;
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
            this.lcRelation.Controls.Add(this.gcInputSwitch);
            this.lcRelation.Controls.Add(this.gcPower);
            this.lcRelation.Controls.Add(this.gcOutputSwitch);
            this.lcRelation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcRelation.Location = new System.Drawing.Point(0, 0);
            this.lcRelation.Name = "lcRelation";
            this.lcRelation.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(809, 502, 250, 350);
            this.lcRelation.Root = this.lcgMain;
            this.lcRelation.Size = new System.Drawing.Size(1008, 678);
            this.lcRelation.TabIndex = 3;
            this.lcRelation.Text = "关系";
            // 
            // gcInputSwitch
            // 
            this.gcInputSwitch.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcInputSwitch.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gcInputSwitch.Location = new System.Drawing.Point(307, 45);
            this.gcInputSwitch.MainView = this.gvInputSwitch;
            this.gcInputSwitch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcInputSwitch.Name = "gcInputSwitch";
            this.gcInputSwitch.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2,
            this.repositoryItemMemoEdit1,
            this.repositoryItemMemoExEdit2});
            this.gcInputSwitch.Size = new System.Drawing.Size(300, 609);
            this.gcInputSwitch.TabIndex = 4;
            this.gcInputSwitch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvInputSwitch});
            // 
            // gvInputSwitch
            // 
            this.gvInputSwitch.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvInputSwitch.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvInputSwitch.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvInputSwitch.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvInputSwitch.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvInputSwitch.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvInputSwitch.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvInputSwitch.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvInputSwitch.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvInputSwitch.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvInputSwitch.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvInputSwitch.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvInputSwitch.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvInputSwitch.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvInputSwitch.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvInputSwitch.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvInputSwitch.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvInputSwitch.Appearance.Empty.Options.UseBackColor = true;
            this.gvInputSwitch.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvInputSwitch.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvInputSwitch.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvInputSwitch.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvInputSwitch.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvInputSwitch.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvInputSwitch.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvInputSwitch.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvInputSwitch.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvInputSwitch.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvInputSwitch.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvInputSwitch.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvInputSwitch.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvInputSwitch.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvInputSwitch.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvInputSwitch.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvInputSwitch.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvInputSwitch.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvInputSwitch.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvInputSwitch.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvInputSwitch.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvInputSwitch.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvInputSwitch.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvInputSwitch.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvInputSwitch.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvInputSwitch.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvInputSwitch.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvInputSwitch.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvInputSwitch.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvInputSwitch.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvInputSwitch.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvInputSwitch.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvInputSwitch.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvInputSwitch.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvInputSwitch.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvInputSwitch.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvInputSwitch.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvInputSwitch.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvInputSwitch.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvInputSwitch.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvInputSwitch.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvInputSwitch.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvInputSwitch.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvInputSwitch.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvInputSwitch.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvInputSwitch.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvInputSwitch.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvInputSwitch.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvInputSwitch.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvInputSwitch.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvInputSwitch.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvInputSwitch.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvInputSwitch.Appearance.GroupRow.Options.UseFont = true;
            this.gvInputSwitch.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvInputSwitch.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvInputSwitch.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvInputSwitch.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvInputSwitch.Appearance.HeaderPanel.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.gvInputSwitch.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvInputSwitch.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvInputSwitch.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvInputSwitch.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvInputSwitch.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvInputSwitch.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvInputSwitch.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvInputSwitch.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvInputSwitch.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvInputSwitch.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvInputSwitch.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvInputSwitch.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvInputSwitch.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvInputSwitch.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvInputSwitch.Appearance.OddRow.Options.UseBackColor = true;
            this.gvInputSwitch.Appearance.OddRow.Options.UseForeColor = true;
            this.gvInputSwitch.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvInputSwitch.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvInputSwitch.Appearance.Preview.Options.UseBackColor = true;
            this.gvInputSwitch.Appearance.Preview.Options.UseForeColor = true;
            this.gvInputSwitch.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvInputSwitch.Appearance.Row.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.gvInputSwitch.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvInputSwitch.Appearance.Row.Options.UseBackColor = true;
            this.gvInputSwitch.Appearance.Row.Options.UseFont = true;
            this.gvInputSwitch.Appearance.Row.Options.UseForeColor = true;
            this.gvInputSwitch.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvInputSwitch.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvInputSwitch.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvInputSwitch.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvInputSwitch.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvInputSwitch.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvInputSwitch.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvInputSwitch.Appearance.VertLine.Options.UseBackColor = true;
            this.gvInputSwitch.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colF_POWER_SWITCH_ID});
            this.gvInputSwitch.GridControl = this.gcInputSwitch;
            this.gvInputSwitch.Name = "gvInputSwitch";
            this.gvInputSwitch.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gvInputSwitch.OptionsBehavior.ImmediateUpdateRowPosition = false;
            this.gvInputSwitch.OptionsPrint.AutoWidth = false;
            this.gvInputSwitch.OptionsView.ColumnAutoWidth = false;
            this.gvInputSwitch.OptionsView.EnableAppearanceEvenRow = true;
            this.gvInputSwitch.OptionsView.EnableAppearanceOddRow = true;
            this.gvInputSwitch.OptionsView.ShowGroupPanel = false;
            this.gvInputSwitch.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvInputSwitch_RowClick);
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
            this.colF_POWER_SWITCH_ID.Caption = "输入开关编号";
            this.colF_POWER_SWITCH_ID.FieldName = "F_POWER_SWITCH_ID";
            this.colF_POWER_SWITCH_ID.Name = "colF_POWER_SWITCH_ID";
            this.colF_POWER_SWITCH_ID.OptionsColumn.AllowEdit = false;
            this.colF_POWER_SWITCH_ID.OptionsColumn.AllowFocus = false;
            this.colF_POWER_SWITCH_ID.Visible = true;
            this.colF_POWER_SWITCH_ID.VisibleIndex = 0;
            this.colF_POWER_SWITCH_ID.Width = 118;
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
            // gcOutputSwitch
            // 
            this.gcOutputSwitch.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcOutputSwitch.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gcOutputSwitch.Location = new System.Drawing.Point(641, 45);
            this.gcOutputSwitch.MainView = this.gvOutputSwitch;
            this.gcOutputSwitch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcOutputSwitch.Name = "gcOutputSwitch";
            this.gcOutputSwitch.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemMemoEdit,
            this.repositoryItemMemoExEdit1});
            this.gcOutputSwitch.Size = new System.Drawing.Size(343, 609);
            this.gcOutputSwitch.TabIndex = 1;
            this.gcOutputSwitch.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOutputSwitch});
            // 
            // gvOutputSwitch
            // 
            this.gvOutputSwitch.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvOutputSwitch.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvOutputSwitch.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvOutputSwitch.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvOutputSwitch.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvOutputSwitch.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvOutputSwitch.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvOutputSwitch.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvOutputSwitch.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvOutputSwitch.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvOutputSwitch.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvOutputSwitch.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvOutputSwitch.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvOutputSwitch.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvOutputSwitch.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvOutputSwitch.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvOutputSwitch.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvOutputSwitch.Appearance.Empty.Options.UseBackColor = true;
            this.gvOutputSwitch.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvOutputSwitch.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvOutputSwitch.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvOutputSwitch.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvOutputSwitch.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvOutputSwitch.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvOutputSwitch.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvOutputSwitch.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvOutputSwitch.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvOutputSwitch.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvOutputSwitch.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvOutputSwitch.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvOutputSwitch.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvOutputSwitch.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvOutputSwitch.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvOutputSwitch.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvOutputSwitch.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvOutputSwitch.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvOutputSwitch.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvOutputSwitch.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvOutputSwitch.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvOutputSwitch.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvOutputSwitch.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvOutputSwitch.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvOutputSwitch.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvOutputSwitch.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvOutputSwitch.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvOutputSwitch.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvOutputSwitch.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvOutputSwitch.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvOutputSwitch.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvOutputSwitch.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvOutputSwitch.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvOutputSwitch.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvOutputSwitch.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvOutputSwitch.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvOutputSwitch.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvOutputSwitch.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvOutputSwitch.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvOutputSwitch.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvOutputSwitch.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvOutputSwitch.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvOutputSwitch.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvOutputSwitch.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvOutputSwitch.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvOutputSwitch.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvOutputSwitch.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvOutputSwitch.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvOutputSwitch.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvOutputSwitch.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvOutputSwitch.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvOutputSwitch.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvOutputSwitch.Appearance.GroupRow.Options.UseFont = true;
            this.gvOutputSwitch.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvOutputSwitch.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvOutputSwitch.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvOutputSwitch.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvOutputSwitch.Appearance.HeaderPanel.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.gvOutputSwitch.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvOutputSwitch.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvOutputSwitch.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvOutputSwitch.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvOutputSwitch.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvOutputSwitch.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvOutputSwitch.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvOutputSwitch.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvOutputSwitch.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvOutputSwitch.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvOutputSwitch.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvOutputSwitch.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvOutputSwitch.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvOutputSwitch.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvOutputSwitch.Appearance.OddRow.Options.UseBackColor = true;
            this.gvOutputSwitch.Appearance.OddRow.Options.UseForeColor = true;
            this.gvOutputSwitch.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvOutputSwitch.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvOutputSwitch.Appearance.Preview.Options.UseBackColor = true;
            this.gvOutputSwitch.Appearance.Preview.Options.UseForeColor = true;
            this.gvOutputSwitch.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvOutputSwitch.Appearance.Row.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.gvOutputSwitch.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvOutputSwitch.Appearance.Row.Options.UseBackColor = true;
            this.gvOutputSwitch.Appearance.Row.Options.UseFont = true;
            this.gvOutputSwitch.Appearance.Row.Options.UseForeColor = true;
            this.gvOutputSwitch.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvOutputSwitch.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvOutputSwitch.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvOutputSwitch.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvOutputSwitch.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvOutputSwitch.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvOutputSwitch.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvOutputSwitch.Appearance.VertLine.Options.UseBackColor = true;
            this.gvOutputSwitch.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCheck,
            this.colF_DEVID});
            this.gvOutputSwitch.GridControl = this.gcOutputSwitch;
            this.gvOutputSwitch.Name = "gvOutputSwitch";
            this.gvOutputSwitch.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gvOutputSwitch.OptionsBehavior.ImmediateUpdateRowPosition = false;
            this.gvOutputSwitch.OptionsPrint.AutoWidth = false;
            this.gvOutputSwitch.OptionsView.ColumnAutoWidth = false;
            this.gvOutputSwitch.OptionsView.EnableAppearanceEvenRow = true;
            this.gvOutputSwitch.OptionsView.EnableAppearanceOddRow = true;
            this.gvOutputSwitch.OptionsView.ShowGroupPanel = false;
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
            // colF_DEVID
            // 
            this.colF_DEVID.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_DEVID.AppearanceCell.Options.UseFont = true;
            this.colF_DEVID.AppearanceCell.Options.UseTextOptions = true;
            this.colF_DEVID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_DEVID.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_DEVID.AppearanceHeader.Options.UseFont = true;
            this.colF_DEVID.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_DEVID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_DEVID.Caption = "输出开关编号";
            this.colF_DEVID.FieldName = "F_DEVID";
            this.colF_DEVID.Name = "colF_DEVID";
            this.colF_DEVID.OptionsColumn.AllowEdit = false;
            this.colF_DEVID.OptionsColumn.AllowFocus = false;
            this.colF_DEVID.Visible = true;
            this.colF_DEVID.VisibleIndex = 1;
            this.colF_DEVID.Width = 118;
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
            this.lcgOutputSwitch,
            this.lcgWorkstation,
            this.splitterItem1,
            this.splitterItem2,
            this.lcgInputSwitch});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "Root";
            this.lcgMain.ShowInCustomizationForm = false;
            this.lcgMain.Size = new System.Drawing.Size(1008, 678);
            this.lcgMain.Text = "上位机数据";
            this.lcgMain.TextVisible = false;
            // 
            // lcgOutputSwitch
            // 
            this.lcgOutputSwitch.AllowHide = false;
            this.lcgOutputSwitch.CustomizationFormText = "输出开关";
            this.lcgOutputSwitch.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciOutSwitch});
            this.lcgOutputSwitch.Location = new System.Drawing.Point(617, 0);
            this.lcgOutputSwitch.Name = "lcgOutputSwitch";
            this.lcgOutputSwitch.Size = new System.Drawing.Size(371, 658);
            this.lcgOutputSwitch.Text = "输出开关";
            // 
            // lciOutSwitch
            // 
            this.lciOutSwitch.Control = this.gcOutputSwitch;
            this.lciOutSwitch.CustomizationFormText = "lciOutSwitch";
            this.lciOutSwitch.Location = new System.Drawing.Point(0, 0);
            this.lciOutSwitch.Name = "lciOutSwitch";
            this.lciOutSwitch.Size = new System.Drawing.Size(347, 613);
            this.lciOutSwitch.Text = "lciOutSwitch";
            this.lciOutSwitch.TextSize = new System.Drawing.Size(0, 0);
            this.lciOutSwitch.TextToControlDistance = 0;
            this.lciOutSwitch.TextVisible = false;
            // 
            // lcgWorkstation
            // 
            this.lcgWorkstation.AllowCustomizeChildren = false;
            this.lcgWorkstation.AllowHide = false;
            this.lcgWorkstation.CustomizationFormText = "上位机数据";
            this.lcgWorkstation.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciWorkStation});
            this.lcgWorkstation.Location = new System.Drawing.Point(0, 0);
            this.lcgWorkstation.Name = "lcgWorkstation";
            this.lcgWorkstation.Size = new System.Drawing.Size(277, 658);
            this.lcgWorkstation.Text = "配电柜数据";
            // 
            // lciWorkStation
            // 
            this.lciWorkStation.Control = this.gcPower;
            this.lciWorkStation.CustomizationFormText = "lciWorkStation";
            this.lciWorkStation.Location = new System.Drawing.Point(0, 0);
            this.lciWorkStation.Name = "lciWorkStation";
            this.lciWorkStation.Size = new System.Drawing.Size(253, 613);
            this.lciWorkStation.Text = "lciWorkStation";
            this.lciWorkStation.TextSize = new System.Drawing.Size(0, 0);
            this.lciWorkStation.TextToControlDistance = 0;
            this.lciWorkStation.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(611, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(6, 658);
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.CustomizationFormText = "splitterItem2";
            this.splitterItem2.Location = new System.Drawing.Point(277, 0);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(6, 658);
            // 
            // lcgInputSwitch
            // 
            this.lcgInputSwitch.CustomizationFormText = "输入开关";
            this.lcgInputSwitch.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.lcgInputSwitch.Location = new System.Drawing.Point(283, 0);
            this.lcgInputSwitch.Name = "lcgInputSwitch";
            this.lcgInputSwitch.Size = new System.Drawing.Size(328, 658);
            this.lcgInputSwitch.Text = "输入开关";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcInputSwitch;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(304, 613);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
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
            this.btnSave.Click += new System.EventHandler(this.btnEditRelation_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowHide = false;
            this.layoutControlGroup1.CustomizationFormText = "供电柜数据";
            this.layoutControlGroup1.Location = new System.Drawing.Point(284, 0);
            this.layoutControlGroup1.Name = "lcgDevice";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(704, 658);
            this.layoutControlGroup1.Text = "设备数据";
            // 
            // FrmDevPowerSwitchRelationEdit
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmDevPowerSwitchRelationEdit";
            this.Text = "配电柜开关输入输出关系编辑";
            this.Load += new System.EventHandler(this.FrmWorkstatinAntherDevicesRelationEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPower)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcRelation)).EndInit();
            this.lcRelation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcInputSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInputSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcOutputSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOutputSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgOutputSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOutSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgWorkstation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciWorkStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgInputSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plnButtons)).EndInit();
            this.plnButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gvPower;
        private DevExpress.XtraGrid.Columns.GridColumn colF_POWER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colF_POWER_NAME;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private BaseGridControl gcPower;
        private DevExpress.XtraLayout.LayoutControl lcRelation;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraLayout.LayoutControlItem lciWorkStation;
        private BaseGridControl gcOutputSwitch;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOutputSwitch;
        private DevExpress.XtraGrid.Columns.GridColumn colF_DEVID;
        private DevExpress.XtraLayout.LayoutControlGroup lcgOutputSwitch;
        private DevExpress.XtraLayout.LayoutControlGroup lcgWorkstation;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private PanelControl plnButtons;
        private BaseSimpleButton btnSave;
        private DevExpress.XtraGrid.Columns.GridColumn colCheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private BaseGridControl gcInputSwitch;
        private DevExpress.XtraGrid.Views.Grid.GridView gvInputSwitch;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colF_POWER_SWITCH_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraLayout.LayoutControlItem lciOutSwitch;
        private DevExpress.XtraLayout.SplitterItem splitterItem2;
        private DevExpress.XtraLayout.LayoutControlGroup lcgInputSwitch;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;

    }
}