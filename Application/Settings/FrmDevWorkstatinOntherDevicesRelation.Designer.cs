﻿using DevExpress.XtraEditors;
using RelayTest.Util.Common;

namespace RelayTest.Application.Settings
{

    /// <summary>
    /// 上位机基本信息
    /// 
    /// </summary>
    partial class FrmDevWorkstatinOntherDevicesRelation
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
            this.gcWorkStation = new RelayTest.Util.Common.BaseGridControl();
            this.gvWorkstation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colF_WORKSTATION_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_WORKSTATION_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.lcRelation = new DevExpress.XtraLayout.LayoutControl();
            this.gcCoilPower = new RelayTest.Util.Common.BaseGridControl();
            this.gvCoilPower = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colF_COILPOWER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_COILPOWER_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSensor = new RelayTest.Util.Common.BaseGridControl();
            this.gvSensor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colF_SENSOR_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_SENSOR_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPower = new RelayTest.Util.Common.BaseGridControl();
            this.gvPower = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colF_POWER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_POWER_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgPower = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciPower = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgWorkstation = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciWorkStation = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgSubordinate = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciSubordinate = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.lcgCoilPower = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciCoilPower = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgSensor = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciSensor = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem3 = new DevExpress.XtraLayout.SplitterItem();
            this.splitterItem4 = new DevExpress.XtraLayout.SplitterItem();
            this.plnButtons = new DevExpress.XtraEditors.PanelControl();
            this.btnEditRelation = new RelayTest.Util.Common.BaseSimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcSubordinate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSubordinate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcWorkStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkstation)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcRelation)).BeginInit();
            this.lcRelation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCoilPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCoilPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgWorkstation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciWorkStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSubordinate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSubordinate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCoilPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCoilPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plnButtons)).BeginInit();
            this.plnButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcSubordinate
            // 
            this.gcSubordinate.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcSubordinate.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gcSubordinate.Location = new System.Drawing.Point(277, 279);
            this.gcSubordinate.MainView = this.gvSubordinate;
            this.gcSubordinate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcSubordinate.Name = "gcSubordinate";
            this.gcSubordinate.Size = new System.Drawing.Size(360, 188);
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
            // gcWorkStation
            // 
            this.gcWorkStation.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcWorkStation.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gcWorkStation.Location = new System.Drawing.Point(24, 45);
            this.gcWorkStation.MainView = this.gvWorkstation;
            this.gcWorkStation.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcWorkStation.Name = "gcWorkStation";
            this.gcWorkStation.Size = new System.Drawing.Size(219, 609);
            this.gcWorkStation.TabIndex = 0;
            this.gcWorkStation.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvWorkstation});
            // 
            // gvWorkstation
            // 
            this.gvWorkstation.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvWorkstation.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvWorkstation.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvWorkstation.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvWorkstation.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvWorkstation.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvWorkstation.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvWorkstation.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvWorkstation.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvWorkstation.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvWorkstation.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvWorkstation.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvWorkstation.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvWorkstation.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvWorkstation.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvWorkstation.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvWorkstation.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvWorkstation.Appearance.Empty.Options.UseBackColor = true;
            this.gvWorkstation.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvWorkstation.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvWorkstation.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvWorkstation.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvWorkstation.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvWorkstation.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvWorkstation.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvWorkstation.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvWorkstation.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvWorkstation.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvWorkstation.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvWorkstation.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvWorkstation.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvWorkstation.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvWorkstation.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvWorkstation.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvWorkstation.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvWorkstation.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvWorkstation.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvWorkstation.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvWorkstation.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvWorkstation.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvWorkstation.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvWorkstation.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvWorkstation.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvWorkstation.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvWorkstation.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvWorkstation.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvWorkstation.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvWorkstation.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvWorkstation.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvWorkstation.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvWorkstation.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvWorkstation.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvWorkstation.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvWorkstation.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvWorkstation.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvWorkstation.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvWorkstation.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvWorkstation.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvWorkstation.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvWorkstation.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvWorkstation.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvWorkstation.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvWorkstation.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvWorkstation.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvWorkstation.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvWorkstation.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvWorkstation.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvWorkstation.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvWorkstation.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvWorkstation.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvWorkstation.Appearance.GroupRow.Options.UseFont = true;
            this.gvWorkstation.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvWorkstation.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvWorkstation.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvWorkstation.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvWorkstation.Appearance.HeaderPanel.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.gvWorkstation.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvWorkstation.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvWorkstation.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvWorkstation.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvWorkstation.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvWorkstation.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvWorkstation.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvWorkstation.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvWorkstation.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvWorkstation.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvWorkstation.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvWorkstation.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvWorkstation.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvWorkstation.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvWorkstation.Appearance.OddRow.Options.UseBackColor = true;
            this.gvWorkstation.Appearance.OddRow.Options.UseForeColor = true;
            this.gvWorkstation.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvWorkstation.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvWorkstation.Appearance.Preview.Options.UseBackColor = true;
            this.gvWorkstation.Appearance.Preview.Options.UseForeColor = true;
            this.gvWorkstation.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvWorkstation.Appearance.Row.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.gvWorkstation.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvWorkstation.Appearance.Row.Options.UseBackColor = true;
            this.gvWorkstation.Appearance.Row.Options.UseFont = true;
            this.gvWorkstation.Appearance.Row.Options.UseForeColor = true;
            this.gvWorkstation.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvWorkstation.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvWorkstation.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvWorkstation.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvWorkstation.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvWorkstation.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvWorkstation.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvWorkstation.Appearance.VertLine.Options.UseBackColor = true;
            this.gvWorkstation.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colF_WORKSTATION_ID,
            this.colF_WORKSTATION_NAME});
            this.gvWorkstation.GridControl = this.gcWorkStation;
            this.gvWorkstation.Name = "gvWorkstation";
            this.gvWorkstation.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gvWorkstation.OptionsBehavior.ImmediateUpdateRowPosition = false;
            this.gvWorkstation.OptionsPrint.AutoWidth = false;
            this.gvWorkstation.OptionsView.ColumnAutoWidth = false;
            this.gvWorkstation.OptionsView.EnableAppearanceEvenRow = true;
            this.gvWorkstation.OptionsView.EnableAppearanceOddRow = true;
            this.gvWorkstation.OptionsView.ShowGroupPanel = false;
            this.gvWorkstation.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvList_RowClick);
            // 
            // colF_WORKSTATION_ID
            // 
            this.colF_WORKSTATION_ID.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_WORKSTATION_ID.AppearanceCell.Options.UseFont = true;
            this.colF_WORKSTATION_ID.AppearanceCell.Options.UseTextOptions = true;
            this.colF_WORKSTATION_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_WORKSTATION_ID.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_WORKSTATION_ID.AppearanceHeader.Options.UseFont = true;
            this.colF_WORKSTATION_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_WORKSTATION_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_WORKSTATION_ID.Caption = "上位机编号";
            this.colF_WORKSTATION_ID.FieldName = "F_WORKSTATION_ID";
            this.colF_WORKSTATION_ID.Name = "colF_WORKSTATION_ID";
            this.colF_WORKSTATION_ID.OptionsColumn.AllowEdit = false;
            this.colF_WORKSTATION_ID.OptionsColumn.AllowFocus = false;
            this.colF_WORKSTATION_ID.Visible = true;
            this.colF_WORKSTATION_ID.VisibleIndex = 0;
            this.colF_WORKSTATION_ID.Width = 118;
            // 
            // colF_WORKSTATION_NAME
            // 
            this.colF_WORKSTATION_NAME.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_WORKSTATION_NAME.AppearanceCell.Options.UseFont = true;
            this.colF_WORKSTATION_NAME.AppearanceCell.Options.UseTextOptions = true;
            this.colF_WORKSTATION_NAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_WORKSTATION_NAME.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_WORKSTATION_NAME.AppearanceHeader.Options.UseFont = true;
            this.colF_WORKSTATION_NAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_WORKSTATION_NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_WORKSTATION_NAME.Caption = "上位机名称";
            this.colF_WORKSTATION_NAME.FieldName = "F_WORKSTATION_NAME";
            this.colF_WORKSTATION_NAME.Name = "colF_WORKSTATION_NAME";
            this.colF_WORKSTATION_NAME.OptionsColumn.AllowEdit = false;
            this.colF_WORKSTATION_NAME.OptionsColumn.AllowFocus = false;
            this.colF_WORKSTATION_NAME.Visible = true;
            this.colF_WORKSTATION_NAME.VisibleIndex = 1;
            this.colF_WORKSTATION_NAME.Width = 151;
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
            this.xtraScrollableControl1.Click += new System.EventHandler(this.xtraScrollableControl1_Click);
            // 
            // lcRelation
            // 
            this.lcRelation.Controls.Add(this.gcCoilPower);
            this.lcRelation.Controls.Add(this.gcSensor);
            this.lcRelation.Controls.Add(this.gcSubordinate);
            this.lcRelation.Controls.Add(this.gcPower);
            this.lcRelation.Controls.Add(this.gcWorkStation);
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
            this.gcCoilPower.Location = new System.Drawing.Point(277, 522);
            this.gcCoilPower.MainView = this.gvCoilPower;
            this.gcCoilPower.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcCoilPower.Name = "gcCoilPower";
            this.gcCoilPower.Size = new System.Drawing.Size(360, 132);
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
            this.gvCoilPower.OptionsFilter.AllowFilterEditor = false;
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
            // gcSensor
            // 
            this.gcSensor.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcSensor.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gcSensor.Location = new System.Drawing.Point(671, 45);
            this.gcSensor.MainView = this.gvSensor;
            this.gcSensor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcSensor.Name = "gcSensor";
            this.gcSensor.Size = new System.Drawing.Size(313, 609);
            this.gcSensor.TabIndex = 4;
            this.gcSensor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSensor});
            // 
            // gvSensor
            // 
            this.gvSensor.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSensor.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvSensor.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSensor.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvSensor.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvSensor.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvSensor.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvSensor.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvSensor.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvSensor.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvSensor.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvSensor.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvSensor.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvSensor.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvSensor.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvSensor.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvSensor.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvSensor.Appearance.Empty.Options.UseBackColor = true;
            this.gvSensor.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvSensor.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvSensor.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvSensor.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvSensor.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSensor.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvSensor.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSensor.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvSensor.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvSensor.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvSensor.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvSensor.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvSensor.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvSensor.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvSensor.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvSensor.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvSensor.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvSensor.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvSensor.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvSensor.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvSensor.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvSensor.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvSensor.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSensor.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvSensor.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSensor.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvSensor.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvSensor.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvSensor.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvSensor.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvSensor.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSensor.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSensor.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvSensor.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvSensor.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvSensor.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvSensor.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSensor.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSensor.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvSensor.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvSensor.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvSensor.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvSensor.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvSensor.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSensor.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvSensor.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvSensor.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSensor.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvSensor.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvSensor.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvSensor.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvSensor.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvSensor.Appearance.GroupRow.Options.UseFont = true;
            this.gvSensor.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvSensor.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSensor.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvSensor.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvSensor.Appearance.HeaderPanel.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.gvSensor.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvSensor.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvSensor.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvSensor.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvSensor.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvSensor.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvSensor.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvSensor.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvSensor.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvSensor.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvSensor.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvSensor.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvSensor.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvSensor.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvSensor.Appearance.OddRow.Options.UseBackColor = true;
            this.gvSensor.Appearance.OddRow.Options.UseForeColor = true;
            this.gvSensor.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvSensor.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvSensor.Appearance.Preview.Options.UseBackColor = true;
            this.gvSensor.Appearance.Preview.Options.UseForeColor = true;
            this.gvSensor.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvSensor.Appearance.Row.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.gvSensor.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvSensor.Appearance.Row.Options.UseBackColor = true;
            this.gvSensor.Appearance.Row.Options.UseFont = true;
            this.gvSensor.Appearance.Row.Options.UseForeColor = true;
            this.gvSensor.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvSensor.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvSensor.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvSensor.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvSensor.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvSensor.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvSensor.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvSensor.Appearance.VertLine.Options.UseBackColor = true;
            this.gvSensor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colF_SENSOR_ID,
            this.colF_SENSOR_TYPE});
            this.gvSensor.GridControl = this.gcSensor;
            this.gvSensor.Name = "gvSensor";
            this.gvSensor.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gvSensor.OptionsBehavior.ImmediateUpdateRowPosition = false;
            this.gvSensor.OptionsPrint.AutoWidth = false;
            this.gvSensor.OptionsView.ColumnAutoWidth = false;
            this.gvSensor.OptionsView.EnableAppearanceEvenRow = true;
            this.gvSensor.OptionsView.EnableAppearanceOddRow = true;
            this.gvSensor.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvSensor.OptionsView.ShowGroupPanel = false;
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
            this.colF_SENSOR_ID.Caption = "传感器编号";
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
            this.colF_SENSOR_TYPE.Caption = "型号";
            this.colF_SENSOR_TYPE.FieldName = "F_SENSOR_TYPE";
            this.colF_SENSOR_TYPE.Name = "colF_SENSOR_TYPE";
            this.colF_SENSOR_TYPE.OptionsColumn.AllowEdit = false;
            this.colF_SENSOR_TYPE.OptionsColumn.AllowFocus = false;
            this.colF_SENSOR_TYPE.Visible = true;
            this.colF_SENSOR_TYPE.VisibleIndex = 1;
            this.colF_SENSOR_TYPE.Width = 159;
            // 
            // gcPower
            // 
            this.gcPower.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcPower.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gcPower.Location = new System.Drawing.Point(277, 45);
            this.gcPower.MainView = this.gvPower;
            this.gcPower.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcPower.Name = "gcPower";
            this.gcPower.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gcPower.Size = new System.Drawing.Size(360, 179);
            this.gcPower.TabIndex = 1;
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
            this.gvPower.OptionsFilter.AllowFilterEditor = false;
            this.gvPower.OptionsPrint.AutoWidth = false;
            this.gvPower.OptionsView.ColumnAutoWidth = false;
            this.gvPower.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPower.OptionsView.EnableAppearanceOddRow = true;
            this.gvPower.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvPower.OptionsView.ShowGroupPanel = false;
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
            this.colF_POWER_ID.Caption = "供电柜编号";
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
            this.colF_POWER_NAME.Caption = "供电柜名称";
            this.colF_POWER_NAME.FieldName = "F_POWER_NAME";
            this.colF_POWER_NAME.Name = "colF_POWER_NAME";
            this.colF_POWER_NAME.OptionsColumn.AllowEdit = false;
            this.colF_POWER_NAME.OptionsColumn.AllowFocus = false;
            this.colF_POWER_NAME.Visible = true;
            this.colF_POWER_NAME.VisibleIndex = 1;
            this.colF_POWER_NAME.Width = 154;
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
            // lcgMain
            // 
            this.lcgMain.CustomizationFormText = "上位机数据";
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgPower,
            this.lcgWorkstation,
            this.lcgSubordinate,
            this.splitterItem2,
            this.splitterItem1,
            this.lcgCoilPower,
            this.lcgSensor,
            this.splitterItem3,
            this.splitterItem4});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "Root";
            this.lcgMain.ShowInCustomizationForm = false;
            this.lcgMain.Size = new System.Drawing.Size(1008, 678);
            this.lcgMain.Text = "上位机数据";
            this.lcgMain.TextVisible = false;
            // 
            // lcgPower
            // 
            this.lcgPower.AllowHide = false;
            this.lcgPower.CustomizationFormText = "供电柜数据";
            this.lcgPower.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciPower});
            this.lcgPower.Location = new System.Drawing.Point(253, 0);
            this.lcgPower.Name = "lcgPower";
            this.lcgPower.Size = new System.Drawing.Size(388, 228);
            this.lcgPower.Text = "供电柜数据";
            // 
            // lciPower
            // 
            this.lciPower.Control = this.gcPower;
            this.lciPower.CustomizationFormText = "layoutControlItem1";
            this.lciPower.Location = new System.Drawing.Point(0, 0);
            this.lciPower.Name = "lciPower";
            this.lciPower.Size = new System.Drawing.Size(364, 183);
            this.lciPower.Text = "供电柜";
            this.lciPower.TextSize = new System.Drawing.Size(0, 0);
            this.lciPower.TextToControlDistance = 0;
            this.lciPower.TextVisible = false;
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
            this.lcgWorkstation.Size = new System.Drawing.Size(247, 658);
            this.lcgWorkstation.Text = "上位机数据";
            // 
            // lciWorkStation
            // 
            this.lciWorkStation.Control = this.gcWorkStation;
            this.lciWorkStation.CustomizationFormText = "lciWorkStation";
            this.lciWorkStation.Location = new System.Drawing.Point(0, 0);
            this.lciWorkStation.Name = "lciWorkStation";
            this.lciWorkStation.Size = new System.Drawing.Size(223, 613);
            this.lciWorkStation.Text = "lciWorkStation";
            this.lciWorkStation.TextSize = new System.Drawing.Size(0, 0);
            this.lciWorkStation.TextToControlDistance = 0;
            this.lciWorkStation.TextVisible = false;
            // 
            // lcgSubordinate
            // 
            this.lcgSubordinate.AllowHide = false;
            this.lcgSubordinate.CustomizationFormText = "下位机数据";
            this.lcgSubordinate.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciSubordinate});
            this.lcgSubordinate.Location = new System.Drawing.Point(253, 234);
            this.lcgSubordinate.Name = "lcgSubordinate";
            this.lcgSubordinate.Size = new System.Drawing.Size(388, 237);
            this.lcgSubordinate.Text = "下位机数据";
            // 
            // lciSubordinate
            // 
            this.lciSubordinate.Control = this.gcSubordinate;
            this.lciSubordinate.CustomizationFormText = "layoutControlItem3";
            this.lciSubordinate.Location = new System.Drawing.Point(0, 0);
            this.lciSubordinate.Name = "lciSubordinate";
            this.lciSubordinate.Size = new System.Drawing.Size(364, 192);
            this.lciSubordinate.Text = "lciSubordinate";
            this.lciSubordinate.TextSize = new System.Drawing.Size(0, 0);
            this.lciSubordinate.TextToControlDistance = 0;
            this.lciSubordinate.TextVisible = false;
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.CustomizationFormText = "splitterItem2";
            this.splitterItem2.Location = new System.Drawing.Point(253, 228);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(388, 6);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(247, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(6, 658);
            // 
            // lcgCoilPower
            // 
            this.lcgCoilPower.AllowHide = false;
            this.lcgCoilPower.CustomizationFormText = "线圈电源数据";
            this.lcgCoilPower.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciCoilPower});
            this.lcgCoilPower.Location = new System.Drawing.Point(253, 477);
            this.lcgCoilPower.Name = "lcgCoilPower";
            this.lcgCoilPower.Size = new System.Drawing.Size(388, 181);
            this.lcgCoilPower.Text = "线圈电源数据";
            // 
            // lciCoilPower
            // 
            this.lciCoilPower.Control = this.gcCoilPower;
            this.lciCoilPower.CustomizationFormText = "线圈电源";
            this.lciCoilPower.Location = new System.Drawing.Point(0, 0);
            this.lciCoilPower.Name = "lciCoilPower";
            this.lciCoilPower.Size = new System.Drawing.Size(364, 136);
            this.lciCoilPower.Text = "线圈电源";
            this.lciCoilPower.TextSize = new System.Drawing.Size(0, 0);
            this.lciCoilPower.TextToControlDistance = 0;
            this.lciCoilPower.TextVisible = false;
            // 
            // lcgSensor
            // 
            this.lcgSensor.AllowHide = false;
            this.lcgSensor.CustomizationFormText = "传感器数据";
            this.lcgSensor.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciSensor});
            this.lcgSensor.Location = new System.Drawing.Point(647, 0);
            this.lcgSensor.Name = "lcgSensor";
            this.lcgSensor.Size = new System.Drawing.Size(341, 658);
            this.lcgSensor.Text = "传感器数据";
            // 
            // lciSensor
            // 
            this.lciSensor.Control = this.gcSensor;
            this.lciSensor.CustomizationFormText = "传感器";
            this.lciSensor.Location = new System.Drawing.Point(0, 0);
            this.lciSensor.Name = "lciSensor";
            this.lciSensor.Size = new System.Drawing.Size(317, 613);
            this.lciSensor.Text = "传感器";
            this.lciSensor.TextSize = new System.Drawing.Size(0, 0);
            this.lciSensor.TextToControlDistance = 0;
            this.lciSensor.TextVisible = false;
            // 
            // splitterItem3
            // 
            this.splitterItem3.AllowHotTrack = true;
            this.splitterItem3.CustomizationFormText = "splitterItem3";
            this.splitterItem3.Location = new System.Drawing.Point(253, 471);
            this.splitterItem3.Name = "splitterItem3";
            this.splitterItem3.Size = new System.Drawing.Size(388, 6);
            // 
            // splitterItem4
            // 
            this.splitterItem4.AllowHotTrack = true;
            this.splitterItem4.CustomizationFormText = "splitterItem4";
            this.splitterItem4.Location = new System.Drawing.Point(641, 0);
            this.splitterItem4.Name = "splitterItem4";
            this.splitterItem4.Size = new System.Drawing.Size(6, 658);
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
            // FrmDevWorkstatinOntherDevicesRelation
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmDevWorkstatinOntherDevicesRelation";
            this.Text = "上位机与下属设备关系";
            this.Load += new System.EventHandler(this.FrmWorkstatinAntherDevicesRelation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcSubordinate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSubordinate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcWorkStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkstation)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcRelation)).EndInit();
            this.lcRelation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCoilPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCoilPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSensor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSensor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgWorkstation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciWorkStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSubordinate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSubordinate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCoilPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCoilPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSensor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSensor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plnButtons)).EndInit();
            this.plnButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gvWorkstation;
        private DevExpress.XtraGrid.Columns.GridColumn colF_WORKSTATION_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colF_WORKSTATION_NAME;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private BaseGridControl gcWorkStation;
        private DevExpress.XtraLayout.LayoutControl lcRelation;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraLayout.LayoutControlItem lciWorkStation;
        private BaseGridControl gcPower;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPower;
        private DevExpress.XtraGrid.Columns.GridColumn colF_POWER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colF_POWER_NAME;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup lcgPower;
        private DevExpress.XtraLayout.LayoutControlItem lciPower;
        private DevExpress.XtraLayout.LayoutControlGroup lcgWorkstation;
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
        private BaseGridControl gcSensor;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSensor;
        private DevExpress.XtraGrid.Columns.GridColumn colF_SENSOR_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colF_SENSOR_TYPE;
        private DevExpress.XtraLayout.LayoutControlItem lciSensor;
        private DevExpress.XtraLayout.LayoutControlGroup lcgSensor;
        private PanelControl plnButtons;
        private BaseSimpleButton btnEditRelation;
        private DevExpress.XtraLayout.SplitterItem splitterItem3;
        private DevExpress.XtraLayout.SplitterItem splitterItem4;

    }
}