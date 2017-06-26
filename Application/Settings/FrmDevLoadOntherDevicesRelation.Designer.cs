using DevExpress.XtraEditors;
using RelayTest.Util.Common;

namespace RelayTest.Application.Settings
{

    /// <summary>
    /// 上位机基本信息
    /// 
    /// </summary>
    partial class FrmDevLoadOntherDevicesRelation
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
            this.gcSubordinate = new RelayTest.Util.Common.BaseGridControl();
            this.gvSubordinate = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colF_SUBORDINATE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_SUBORDINATE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcLoad = new RelayTest.Util.Common.BaseGridControl();
            this.gvLoad = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colF_LOAD_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_LOAD_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.lcRelation = new DevExpress.XtraLayout.LayoutControl();
            this.gcCoilPower = new RelayTest.Util.Common.BaseGridControl();
            this.gvCoilPower = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colF_COILPOWER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_COILPOWER_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgLoad = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciLoad = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgSubordinate = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciSubordinate = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.lcgCoilPower = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciCoilPower = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem3 = new DevExpress.XtraLayout.SplitterItem();
            this.plnButtons = new DevExpress.XtraEditors.PanelControl();
            this.btnEditRelation = new RelayTest.Util.Common.BaseSimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcSubordinate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSubordinate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoad)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcRelation)).BeginInit();
            this.lcRelation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCoilPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCoilPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSubordinate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSubordinate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCoilPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCoilPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plnButtons)).BeginInit();
            this.plnButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcSubordinate
            // 
            this.gcSubordinate.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcSubordinate.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gcSubordinate.Location = new System.Drawing.Point(308, 51);
            this.gcSubordinate.MainView = this.gvSubordinate;
            this.gcSubordinate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcSubordinate.Name = "gcSubordinate";
            this.gcSubordinate.Size = new System.Drawing.Size(676, 315);
            this.gcSubordinate.TabIndex = 5;
            this.gcSubordinate.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSubordinate});
            // 
            // gvSubordinate
            // 
            this.gvSubordinate.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSubordinate.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvSubordinate.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSubordinate.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvSubordinate.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvSubordinate.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvSubordinate.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvSubordinate.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvSubordinate.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvSubordinate.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvSubordinate.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvSubordinate.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvSubordinate.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvSubordinate.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvSubordinate.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvSubordinate.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvSubordinate.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvSubordinate.Appearance.Empty.Options.UseBackColor = true;
            this.gvSubordinate.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvSubordinate.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvSubordinate.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvSubordinate.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvSubordinate.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSubordinate.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvSubordinate.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSubordinate.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvSubordinate.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvSubordinate.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvSubordinate.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvSubordinate.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvSubordinate.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvSubordinate.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvSubordinate.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvSubordinate.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvSubordinate.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvSubordinate.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvSubordinate.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvSubordinate.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvSubordinate.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvSubordinate.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvSubordinate.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSubordinate.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvSubordinate.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSubordinate.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvSubordinate.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvSubordinate.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvSubordinate.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvSubordinate.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvSubordinate.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSubordinate.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSubordinate.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvSubordinate.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvSubordinate.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvSubordinate.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvSubordinate.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSubordinate.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSubordinate.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvSubordinate.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvSubordinate.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvSubordinate.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvSubordinate.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvSubordinate.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSubordinate.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvSubordinate.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvSubordinate.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSubordinate.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSubordinate.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvSubordinate.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvSubordinate.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvSubordinate.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvSubordinate.Appearance.GroupRow.Options.UseFont = true;
            this.gvSubordinate.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvSubordinate.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSubordinate.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvSubordinate.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSubordinate.Appearance.HeaderPanel.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.gvSubordinate.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvSubordinate.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvSubordinate.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvSubordinate.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvSubordinate.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvSubordinate.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvSubordinate.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvSubordinate.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvSubordinate.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvSubordinate.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvSubordinate.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvSubordinate.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvSubordinate.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvSubordinate.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvSubordinate.Appearance.OddRow.Options.UseBackColor = true;
            this.gvSubordinate.Appearance.OddRow.Options.UseForeColor = true;
            this.gvSubordinate.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvSubordinate.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvSubordinate.Appearance.Preview.Options.UseBackColor = true;
            this.gvSubordinate.Appearance.Preview.Options.UseForeColor = true;
            this.gvSubordinate.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvSubordinate.Appearance.Row.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.gvSubordinate.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvSubordinate.Appearance.Row.Options.UseBackColor = true;
            this.gvSubordinate.Appearance.Row.Options.UseFont = true;
            this.gvSubordinate.Appearance.Row.Options.UseForeColor = true;
            this.gvSubordinate.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvSubordinate.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvSubordinate.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvSubordinate.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvSubordinate.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvSubordinate.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvSubordinate.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvSubordinate.Appearance.VertLine.Options.UseBackColor = true;
            this.gvSubordinate.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colF_SUBORDINATE_ID,
            this.colF_SUBORDINATE_NAME});
            this.gvSubordinate.GridControl = this.gcSubordinate;
            this.gvSubordinate.Name = "gvSubordinate";
            this.gvSubordinate.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gvSubordinate.OptionsBehavior.ImmediateUpdateRowPosition = false;
            this.gvSubordinate.OptionsPrint.AutoWidth = false;
            this.gvSubordinate.OptionsView.ColumnAutoWidth = false;
            this.gvSubordinate.OptionsView.EnableAppearanceEvenRow = true;
            this.gvSubordinate.OptionsView.EnableAppearanceOddRow = true;
            this.gvSubordinate.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvSubordinate.OptionsView.ShowGroupPanel = false;
            // 
            // colF_SUBORDINATE_ID
            // 
            this.colF_SUBORDINATE_ID.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SUBORDINATE_ID.AppearanceCell.Options.UseFont = true;
            this.colF_SUBORDINATE_ID.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SUBORDINATE_ID.AppearanceHeader.Options.UseFont = true;
            this.colF_SUBORDINATE_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_SUBORDINATE_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_SUBORDINATE_ID.Caption = "下位机编号";
            this.colF_SUBORDINATE_ID.FieldName = "F_SUBORDINATE_ID";
            this.colF_SUBORDINATE_ID.Name = "colF_SUBORDINATE_ID";
            this.colF_SUBORDINATE_ID.OptionsColumn.AllowEdit = false;
            this.colF_SUBORDINATE_ID.OptionsColumn.AllowFocus = false;
            this.colF_SUBORDINATE_ID.Visible = true;
            this.colF_SUBORDINATE_ID.VisibleIndex = 0;
            this.colF_SUBORDINATE_ID.Width = 141;
            // 
            // colF_SUBORDINATE_NAME
            // 
            this.colF_SUBORDINATE_NAME.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SUBORDINATE_NAME.AppearanceCell.Options.UseFont = true;
            this.colF_SUBORDINATE_NAME.AppearanceCell.Options.UseTextOptions = true;
            this.colF_SUBORDINATE_NAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_SUBORDINATE_NAME.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SUBORDINATE_NAME.AppearanceHeader.Options.UseFont = true;
            this.colF_SUBORDINATE_NAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_SUBORDINATE_NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_SUBORDINATE_NAME.Caption = "下位机名称";
            this.colF_SUBORDINATE_NAME.FieldName = "F_SUBORDINATE_NAME";
            this.colF_SUBORDINATE_NAME.Name = "colF_SUBORDINATE_NAME";
            this.colF_SUBORDINATE_NAME.OptionsColumn.AllowEdit = false;
            this.colF_SUBORDINATE_NAME.OptionsColumn.AllowFocus = false;
            this.colF_SUBORDINATE_NAME.Visible = true;
            this.colF_SUBORDINATE_NAME.VisibleIndex = 1;
            this.colF_SUBORDINATE_NAME.Width = 118;
            // 
            // gcLoad
            // 
            this.gcLoad.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcLoad.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gcLoad.Location = new System.Drawing.Point(24, 45);
            this.gcLoad.MainView = this.gvLoad;
            this.gcLoad.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcLoad.Name = "gcLoad";
            this.gcLoad.Size = new System.Drawing.Size(250, 609);
            this.gcLoad.TabIndex = 0;
            this.gcLoad.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLoad});
            // 
            // gvLoad
            // 
            this.gvLoad.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvLoad.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvLoad.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvLoad.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvLoad.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvLoad.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvLoad.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvLoad.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvLoad.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvLoad.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvLoad.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvLoad.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvLoad.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvLoad.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvLoad.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvLoad.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvLoad.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvLoad.Appearance.Empty.Options.UseBackColor = true;
            this.gvLoad.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvLoad.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvLoad.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvLoad.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvLoad.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvLoad.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvLoad.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvLoad.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvLoad.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvLoad.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvLoad.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvLoad.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvLoad.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvLoad.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvLoad.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvLoad.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvLoad.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvLoad.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvLoad.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvLoad.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvLoad.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvLoad.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvLoad.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvLoad.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvLoad.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvLoad.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvLoad.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvLoad.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvLoad.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvLoad.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvLoad.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvLoad.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvLoad.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvLoad.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvLoad.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvLoad.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvLoad.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvLoad.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvLoad.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvLoad.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvLoad.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvLoad.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvLoad.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvLoad.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvLoad.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvLoad.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvLoad.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvLoad.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvLoad.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvLoad.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvLoad.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvLoad.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvLoad.Appearance.GroupRow.Options.UseFont = true;
            this.gvLoad.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvLoad.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvLoad.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvLoad.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvLoad.Appearance.HeaderPanel.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.gvLoad.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvLoad.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvLoad.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvLoad.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvLoad.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvLoad.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvLoad.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvLoad.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvLoad.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvLoad.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvLoad.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvLoad.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvLoad.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvLoad.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvLoad.Appearance.OddRow.Options.UseBackColor = true;
            this.gvLoad.Appearance.OddRow.Options.UseForeColor = true;
            this.gvLoad.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvLoad.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvLoad.Appearance.Preview.Options.UseBackColor = true;
            this.gvLoad.Appearance.Preview.Options.UseForeColor = true;
            this.gvLoad.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvLoad.Appearance.Row.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.gvLoad.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvLoad.Appearance.Row.Options.UseBackColor = true;
            this.gvLoad.Appearance.Row.Options.UseFont = true;
            this.gvLoad.Appearance.Row.Options.UseForeColor = true;
            this.gvLoad.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvLoad.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvLoad.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvLoad.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvLoad.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvLoad.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvLoad.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvLoad.Appearance.VertLine.Options.UseBackColor = true;
            this.gvLoad.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colF_LOAD_ID,
            this.colF_LOAD_NAME});
            this.gvLoad.GridControl = this.gcLoad;
            this.gvLoad.Name = "gvLoad";
            this.gvLoad.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gvLoad.OptionsBehavior.ImmediateUpdateRowPosition = false;
            this.gvLoad.OptionsPrint.AutoWidth = false;
            this.gvLoad.OptionsView.ColumnAutoWidth = false;
            this.gvLoad.OptionsView.EnableAppearanceEvenRow = true;
            this.gvLoad.OptionsView.EnableAppearanceOddRow = true;
            this.gvLoad.OptionsView.ShowGroupPanel = false;
            this.gvLoad.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvList_RowClick);
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
            this.lcRelation.Controls.Add(this.gcCoilPower);
            this.lcRelation.Controls.Add(this.gcSubordinate);
            this.lcRelation.Controls.Add(this.gcLoad);
            this.lcRelation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcRelation.Location = new System.Drawing.Point(0, 0);
            this.lcRelation.Name = "lcRelation";
            this.lcRelation.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(809, 502, 250, 350);
            this.lcRelation.Root = this.lcgMain;
            this.lcRelation.Size = new System.Drawing.Size(1008, 678);
            this.lcRelation.TabIndex = 3;
            this.lcRelation.Text = "layoutControl1";
            // 
            // gcCoilPower
            // 
            this.gcCoilPower.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcCoilPower.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gcCoilPower.Location = new System.Drawing.Point(308, 421);
            this.gcCoilPower.MainView = this.gvCoilPower;
            this.gcCoilPower.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcCoilPower.Name = "gcCoilPower";
            this.gcCoilPower.Size = new System.Drawing.Size(676, 233);
            this.gcCoilPower.TabIndex = 4;
            this.gcCoilPower.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCoilPower});
            // 
            // gvCoilPower
            // 
            this.gvCoilPower.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCoilPower.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvCoilPower.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCoilPower.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvCoilPower.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCoilPower.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvCoilPower.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvCoilPower.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvCoilPower.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvCoilPower.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvCoilPower.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvCoilPower.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvCoilPower.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCoilPower.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvCoilPower.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvCoilPower.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvCoilPower.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvCoilPower.Appearance.Empty.Options.UseBackColor = true;
            this.gvCoilPower.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvCoilPower.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvCoilPower.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvCoilPower.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvCoilPower.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCoilPower.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvCoilPower.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCoilPower.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvCoilPower.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCoilPower.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvCoilPower.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvCoilPower.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvCoilPower.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvCoilPower.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvCoilPower.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvCoilPower.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvCoilPower.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvCoilPower.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvCoilPower.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvCoilPower.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvCoilPower.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvCoilPower.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvCoilPower.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCoilPower.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvCoilPower.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCoilPower.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCoilPower.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCoilPower.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvCoilPower.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvCoilPower.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvCoilPower.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCoilPower.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCoilPower.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvCoilPower.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvCoilPower.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvCoilPower.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvCoilPower.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCoilPower.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCoilPower.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvCoilPower.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvCoilPower.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvCoilPower.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvCoilPower.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvCoilPower.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCoilPower.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvCoilPower.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvCoilPower.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCoilPower.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvCoilPower.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvCoilPower.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvCoilPower.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvCoilPower.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvCoilPower.Appearance.GroupRow.Options.UseFont = true;
            this.gvCoilPower.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvCoilPower.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCoilPower.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvCoilPower.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvCoilPower.Appearance.HeaderPanel.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.gvCoilPower.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCoilPower.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvCoilPower.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvCoilPower.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvCoilPower.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvCoilPower.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvCoilPower.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvCoilPower.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvCoilPower.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvCoilPower.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvCoilPower.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvCoilPower.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvCoilPower.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvCoilPower.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvCoilPower.Appearance.OddRow.Options.UseBackColor = true;
            this.gvCoilPower.Appearance.OddRow.Options.UseForeColor = true;
            this.gvCoilPower.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvCoilPower.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvCoilPower.Appearance.Preview.Options.UseBackColor = true;
            this.gvCoilPower.Appearance.Preview.Options.UseForeColor = true;
            this.gvCoilPower.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvCoilPower.Appearance.Row.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.gvCoilPower.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvCoilPower.Appearance.Row.Options.UseBackColor = true;
            this.gvCoilPower.Appearance.Row.Options.UseFont = true;
            this.gvCoilPower.Appearance.Row.Options.UseForeColor = true;
            this.gvCoilPower.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvCoilPower.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvCoilPower.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvCoilPower.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvCoilPower.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvCoilPower.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvCoilPower.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvCoilPower.Appearance.VertLine.Options.UseBackColor = true;
            this.gvCoilPower.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colF_COILPOWER_ID,
            this.colF_COILPOWER_NAME});
            this.gvCoilPower.GridControl = this.gcCoilPower;
            this.gvCoilPower.Name = "gvCoilPower";
            this.gvCoilPower.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gvCoilPower.OptionsBehavior.ImmediateUpdateRowPosition = false;
            this.gvCoilPower.OptionsPrint.AutoWidth = false;
            this.gvCoilPower.OptionsView.ColumnAutoWidth = false;
            this.gvCoilPower.OptionsView.EnableAppearanceEvenRow = true;
            this.gvCoilPower.OptionsView.EnableAppearanceOddRow = true;
            this.gvCoilPower.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvCoilPower.OptionsView.ShowGroupPanel = false;
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
            this.colF_COILPOWER_NAME.Width = 156;
            // 
            // lcgMain
            // 
            this.lcgMain.CustomizationFormText = "上位机数据";
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgLoad,
            this.lcgSubordinate,
            this.splitterItem2,
            this.splitterItem1,
            this.lcgCoilPower,
            this.splitterItem3});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "Root";
            this.lcgMain.ShowInCustomizationForm = false;
            this.lcgMain.Size = new System.Drawing.Size(1008, 678);
            this.lcgMain.Text = "上位机数据";
            this.lcgMain.TextVisible = false;
            // 
            // lcgLoad
            // 
            this.lcgLoad.AllowCustomizeChildren = false;
            this.lcgLoad.AllowHide = false;
            this.lcgLoad.CustomizationFormText = "上位机数据";
            this.lcgLoad.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciLoad});
            this.lcgLoad.Location = new System.Drawing.Point(0, 0);
            this.lcgLoad.Name = "lcgLoad";
            this.lcgLoad.Size = new System.Drawing.Size(278, 658);
            this.lcgLoad.Text = "负载柜数据";
            // 
            // lciLoad
            // 
            this.lciLoad.Control = this.gcLoad;
            this.lciLoad.CustomizationFormText = "lciWorkStation";
            this.lciLoad.Location = new System.Drawing.Point(0, 0);
            this.lciLoad.Name = "lciLoad";
            this.lciLoad.Size = new System.Drawing.Size(254, 613);
            this.lciLoad.Text = "lciLoad";
            this.lciLoad.TextSize = new System.Drawing.Size(0, 0);
            this.lciLoad.TextToControlDistance = 0;
            this.lciLoad.TextVisible = false;
            // 
            // lcgSubordinate
            // 
            this.lcgSubordinate.AllowHide = false;
            this.lcgSubordinate.CustomizationFormText = "下位机数据";
            this.lcgSubordinate.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciSubordinate});
            this.lcgSubordinate.Location = new System.Drawing.Point(284, 6);
            this.lcgSubordinate.Name = "lcgSubordinate";
            this.lcgSubordinate.Size = new System.Drawing.Size(704, 364);
            this.lcgSubordinate.Text = "下位机数据";
            // 
            // lciSubordinate
            // 
            this.lciSubordinate.Control = this.gcSubordinate;
            this.lciSubordinate.CustomizationFormText = "layoutControlItem3";
            this.lciSubordinate.Location = new System.Drawing.Point(0, 0);
            this.lciSubordinate.Name = "lciSubordinate";
            this.lciSubordinate.Size = new System.Drawing.Size(680, 319);
            this.lciSubordinate.Text = "lciSubordinate";
            this.lciSubordinate.TextSize = new System.Drawing.Size(0, 0);
            this.lciSubordinate.TextToControlDistance = 0;
            this.lciSubordinate.TextVisible = false;
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.CustomizationFormText = "splitterItem2";
            this.splitterItem2.Location = new System.Drawing.Point(284, 0);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(704, 6);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(278, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(6, 658);
            // 
            // lcgCoilPower
            // 
            this.lcgCoilPower.AllowHide = false;
            this.lcgCoilPower.CustomizationFormText = "线圈电源数据";
            this.lcgCoilPower.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciCoilPower});
            this.lcgCoilPower.Location = new System.Drawing.Point(284, 376);
            this.lcgCoilPower.Name = "lcgCoilPower";
            this.lcgCoilPower.Size = new System.Drawing.Size(704, 282);
            this.lcgCoilPower.Text = "线圈电源数据";
            // 
            // lciCoilPower
            // 
            this.lciCoilPower.Control = this.gcCoilPower;
            this.lciCoilPower.CustomizationFormText = "线圈电源";
            this.lciCoilPower.Location = new System.Drawing.Point(0, 0);
            this.lciCoilPower.Name = "lciCoilPower";
            this.lciCoilPower.Size = new System.Drawing.Size(680, 237);
            this.lciCoilPower.Text = "线圈电源";
            this.lciCoilPower.TextSize = new System.Drawing.Size(0, 0);
            this.lciCoilPower.TextToControlDistance = 0;
            this.lciCoilPower.TextVisible = false;
            // 
            // splitterItem3
            // 
            this.splitterItem3.AllowHotTrack = true;
            this.splitterItem3.CustomizationFormText = "splitterItem3";
            this.splitterItem3.Location = new System.Drawing.Point(284, 370);
            this.splitterItem3.Name = "splitterItem3";
            this.splitterItem3.Size = new System.Drawing.Size(704, 6);
            // 
            // plnButtons
            // 
            this.plnButtons.Controls.Add(this.btnEditRelation);
            this.plnButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plnButtons.Location = new System.Drawing.Point(0, 678);
            this.plnButtons.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.plnButtons.Name = "plnButtons";
            this.plnButtons.Size = new System.Drawing.Size(1008, 52);
            this.plnButtons.TabIndex = 4;
            // 
            // btnEditRelation
            // 
            this.btnEditRelation.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEditRelation.Appearance.Options.UseFont = true;
            this.btnEditRelation.Location = new System.Drawing.Point(464, 11);
            this.btnEditRelation.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEditRelation.Name = "btnEditRelation";
            this.btnEditRelation.Size = new System.Drawing.Size(80, 31);
            this.btnEditRelation.TabIndex = 0;
            this.btnEditRelation.Text = "编辑关系";
            this.btnEditRelation.Click += new System.EventHandler(this.btnEditRelation_Click);
            // 
            // FrmDevLoadOntherDevicesRelation
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmDevLoadOntherDevicesRelation";
            this.Text = "负载柜与设备关系";
            this.Load += new System.EventHandler(this.FrmLoadAntherDevicesRelation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcSubordinate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSubordinate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoad)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcRelation)).EndInit();
            this.lcRelation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCoilPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCoilPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSubordinate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSubordinate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCoilPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCoilPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plnButtons)).EndInit();
            this.plnButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gvLoad;
        private DevExpress.XtraGrid.Columns.GridColumn colF_LOAD_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colF_LOAD_NAME;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private BaseGridControl gcLoad;
        private DevExpress.XtraLayout.LayoutControl lcRelation;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraLayout.LayoutControlItem lciLoad;
        private DevExpress.XtraLayout.LayoutControlGroup lcgLoad;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private BaseGridControl gcSubordinate;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSubordinate;
        private DevExpress.XtraGrid.Columns.GridColumn colF_SUBORDINATE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colF_SUBORDINATE_NAME;
        private DevExpress.XtraLayout.LayoutControlGroup lcgSubordinate;
        private DevExpress.XtraLayout.SplitterItem splitterItem2;
        private DevExpress.XtraLayout.LayoutControlItem lciSubordinate;
        private BaseGridControl gcCoilPower;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCoilPower;
        private DevExpress.XtraGrid.Columns.GridColumn colF_COILPOWER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colF_COILPOWER_NAME;
        private DevExpress.XtraLayout.LayoutControlGroup lcgCoilPower;
        private DevExpress.XtraLayout.LayoutControlItem lciCoilPower;
        private PanelControl plnButtons;
        private BaseSimpleButton btnEditRelation;
        private DevExpress.XtraLayout.SplitterItem splitterItem3;

    }
}