using DevExpress.XtraEditors;
using RelayTest.Util.Common;

namespace RelayTest.Application.Settings
{

    /// <summary>
    /// 上位机基本信息
    /// 
    /// </summary>
    partial class FrmDevWorkstatinOntherDevicesRelationEdit
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
            this.gcWorkStation = new RelayTest.Util.Common.BaseGridControl();
            this.gvWorkstation = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colF_WORKSTATION_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_WORKSTATION_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.lcRelation = new DevExpress.XtraLayout.LayoutControl();
            this.cbbDevType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gcDevice = new RelayTest.Util.Common.BaseGridControl();
            this.gvDevice = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colF_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.repositoryItemMemoEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgDevice = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciPower = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgWorkstation = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciWorkStation = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.lcgDevType = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciDevType = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.plnButtons = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new RelayTest.Util.Common.BaseSimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcWorkStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkstation)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcRelation)).BeginInit();
            this.lcRelation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbDevType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgWorkstation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciWorkStation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDevType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDevType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plnButtons)).BeginInit();
            this.plnButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcWorkStation
            // 
            this.gcWorkStation.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcWorkStation.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gcWorkStation.Location = new System.Drawing.Point(24, 45);
            this.gcWorkStation.MainView = this.gvWorkstation;
            this.gcWorkStation.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcWorkStation.Name = "gcWorkStation";
            this.gcWorkStation.Size = new System.Drawing.Size(250, 609);
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
            // 
            // lcRelation
            // 
            this.lcRelation.Controls.Add(this.cbbDevType);
            this.lcRelation.Controls.Add(this.gcDevice);
            this.lcRelation.Controls.Add(this.gcWorkStation);
            this.lcRelation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcRelation.Location = new System.Drawing.Point(0, 0);
            this.lcRelation.Name = "lcRelation";
            this.lcRelation.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(809, 502, 250, 350);
            this.lcRelation.Root = this.lcgMain;
            this.lcRelation.Size = new System.Drawing.Size(1008, 678);
            this.lcRelation.TabIndex = 3;
            this.lcRelation.Text = "关系";
            // 
            // cbbDevType
            // 
            this.cbbDevType.Location = new System.Drawing.Point(371, 27);
            this.cbbDevType.Name = "cbbDevType";
            this.cbbDevType.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDevType.Properties.Appearance.Options.UseFont = true;
            this.cbbDevType.Properties.AppearanceDropDown.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDevType.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbbDevType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbDevType.Properties.Items.AddRange(new object[] {
            "供电柜",
            "下位机",
            "线圈电源",
            "传感器"});
            this.cbbDevType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbDevType.Size = new System.Drawing.Size(292, 22);
            this.cbbDevType.StyleController = this.lcRelation;
            this.cbbDevType.TabIndex = 6;
            this.cbbDevType.SelectedIndexChanged += new System.EventHandler(this.cbbDevType_SelectedIndexChanged);
            // 
            // gcDevice
            // 
            this.gcDevice.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcDevice.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gcDevice.Location = new System.Drawing.Point(308, 101);
            this.gcDevice.MainView = this.gvDevice;
            this.gcDevice.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcDevice.Name = "gcDevice";
            this.gcDevice.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemMemoEdit,
            this.repositoryItemMemoExEdit1});
            this.gcDevice.Size = new System.Drawing.Size(676, 553);
            this.gcDevice.TabIndex = 1;
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
            this.colCheck,
            this.colF_ID,
            this.colF_NAME,
            this.colMemo});
            this.gvDevice.GridControl = this.gcDevice;
            this.gvDevice.Name = "gvDevice";
            this.gvDevice.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gvDevice.OptionsBehavior.ImmediateUpdateRowPosition = false;
            this.gvDevice.OptionsPrint.AutoWidth = false;
            this.gvDevice.OptionsView.ColumnAutoWidth = false;
            this.gvDevice.OptionsView.EnableAppearanceEvenRow = true;
            this.gvDevice.OptionsView.EnableAppearanceOddRow = true;
            this.gvDevice.OptionsView.ShowGroupPanel = false;
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
            // colF_ID
            // 
            this.colF_ID.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_ID.AppearanceCell.Options.UseFont = true;
            this.colF_ID.AppearanceCell.Options.UseTextOptions = true;
            this.colF_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_ID.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_ID.AppearanceHeader.Options.UseFont = true;
            this.colF_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_ID.Caption = "编号";
            this.colF_ID.FieldName = "F_DEVID";
            this.colF_ID.Name = "colF_ID";
            this.colF_ID.OptionsColumn.AllowEdit = false;
            this.colF_ID.OptionsColumn.AllowFocus = false;
            this.colF_ID.Visible = true;
            this.colF_ID.VisibleIndex = 1;
            this.colF_ID.Width = 118;
            // 
            // colF_NAME
            // 
            this.colF_NAME.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_NAME.AppearanceCell.Options.UseFont = true;
            this.colF_NAME.AppearanceCell.Options.UseTextOptions = true;
            this.colF_NAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_NAME.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_NAME.AppearanceHeader.Options.UseFont = true;
            this.colF_NAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_NAME.Caption = "名称";
            this.colF_NAME.FieldName = "F_DEVNAME";
            this.colF_NAME.Name = "colF_NAME";
            this.colF_NAME.OptionsColumn.AllowEdit = false;
            this.colF_NAME.OptionsColumn.AllowFocus = false;
            this.colF_NAME.Visible = true;
            this.colF_NAME.VisibleIndex = 2;
            this.colF_NAME.Width = 154;
            // 
            // colMemo
            // 
            this.colMemo.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMemo.AppearanceCell.Options.UseFont = true;
            this.colMemo.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMemo.AppearanceHeader.Options.UseFont = true;
            this.colMemo.Caption = "备注";
            this.colMemo.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.colMemo.FieldName = "F_MEMO";
            this.colMemo.Name = "colMemo";
            this.colMemo.Visible = true;
            this.colMemo.VisibleIndex = 3;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // repositoryItemMemoEdit
            // 
            this.repositoryItemMemoEdit.Name = "repositoryItemMemoEdit";
            // 
            // lcgMain
            // 
            this.lcgMain.CustomizationFormText = "上位机数据";
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgDevice,
            this.lcgWorkstation,
            this.splitterItem1,
            this.lcgDevType});
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
            this.lciPower});
            this.lcgDevice.Location = new System.Drawing.Point(284, 56);
            this.lcgDevice.Name = "lcgDevice";
            this.lcgDevice.Size = new System.Drawing.Size(704, 602);
            this.lcgDevice.Text = "设备数据";
            // 
            // lciPower
            // 
            this.lciPower.Control = this.gcDevice;
            this.lciPower.CustomizationFormText = "layoutControlItem1";
            this.lciPower.Location = new System.Drawing.Point(0, 0);
            this.lciPower.Name = "lciPower";
            this.lciPower.Size = new System.Drawing.Size(680, 557);
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
            this.lcgWorkstation.Size = new System.Drawing.Size(278, 658);
            this.lcgWorkstation.Text = "上位机数据";
            // 
            // lciWorkStation
            // 
            this.lciWorkStation.Control = this.gcWorkStation;
            this.lciWorkStation.CustomizationFormText = "lciWorkStation";
            this.lciWorkStation.Location = new System.Drawing.Point(0, 0);
            this.lciWorkStation.Name = "lciWorkStation";
            this.lciWorkStation.Size = new System.Drawing.Size(254, 613);
            this.lciWorkStation.Text = "lciWorkStation";
            this.lciWorkStation.TextSize = new System.Drawing.Size(0, 0);
            this.lciWorkStation.TextToControlDistance = 0;
            this.lciWorkStation.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(278, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(6, 658);
            // 
            // lcgDevType
            // 
            this.lcgDevType.AllowHide = false;
            this.lcgDevType.CustomizationFormText = "设备类型";
            this.lcgDevType.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciDevType,
            this.emptySpaceItem1});
            this.lcgDevType.Location = new System.Drawing.Point(284, 0);
            this.lcgDevType.Name = "lcgDevType";
            this.lcgDevType.ShowInCustomizationForm = false;
            this.lcgDevType.Size = new System.Drawing.Size(704, 56);
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
            this.lciDevType.Size = new System.Drawing.Size(362, 32);
            this.lciDevType.Text = "设备类型";
            this.lciDevType.TextSize = new System.Drawing.Size(56, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(362, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(318, 32);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
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
            // FrmDevWorkstatinOntherDevicesRelationEdit
            // 
            this.Appearance.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmDevWorkstatinOntherDevicesRelationEdit";
            this.Text = "上位机与下属设备关系编辑";
            this.Load += new System.EventHandler(this.FrmWorkstatinAntherDevicesRelationEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcWorkStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvWorkstation)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcRelation)).EndInit();
            this.lcRelation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbbDevType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgWorkstation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciWorkStation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDevType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDevType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
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
        private BaseGridControl gcDevice;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDevice;
        private DevExpress.XtraGrid.Columns.GridColumn colF_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colF_NAME;
        private DevExpress.XtraLayout.LayoutControlGroup lcgDevice;
        private DevExpress.XtraLayout.LayoutControlItem lciPower;
        private DevExpress.XtraLayout.LayoutControlGroup lcgWorkstation;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private PanelControl plnButtons;
        private BaseSimpleButton btnSave;
        private ComboBoxEdit cbbDevType;
        private DevExpress.XtraLayout.LayoutControlGroup lcgDevType;
        private DevExpress.XtraLayout.LayoutControlItem lciDevType;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colCheck;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colMemo;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;

    }
}