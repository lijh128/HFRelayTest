namespace RelayTest.Application.Query
{
    partial class FrmQueryDevStatus
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
            this.colF_TEST_TASK_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExport = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnQuery = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnClose = new RelayTest.Util.Common.BaseSimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaskID = new System.Windows.Forms.TextBox();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gcList = new RelayTest.Util.Common.BaseGridControl();
            this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDEVICE_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEdit_SampleNum = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDEVICE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEVICE_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_TEST_SAMPLE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXPENDTIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.comDevStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comDevType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit_SampleNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colF_TEST_TASK_ID
            // 
            this.colF_TEST_TASK_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_TEST_TASK_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_TEST_TASK_ID.Caption = "运行任务编号";
            this.colF_TEST_TASK_ID.FieldName = "F_TEST_TASK_ID";
            this.colF_TEST_TASK_ID.Name = "colF_TEST_TASK_ID";
            this.colF_TEST_TASK_ID.OptionsColumn.AllowEdit = false;
            this.colF_TEST_TASK_ID.OptionsColumn.AllowFocus = false;
            this.colF_TEST_TASK_ID.Visible = true;
            this.colF_TEST_TASK_ID.VisibleIndex = 3;
            this.colF_TEST_TASK_ID.Width = 110;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExport.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.Location = new System.Drawing.Point(666, 26);
            this.btnExport.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(80, 34);
            this.btnExport.TabIndex = 118;
            this.btnExport.Text = "导出";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQuery.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Appearance.Options.UseFont = true;
            this.btnQuery.Location = new System.Drawing.Point(568, 26);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(80, 34);
            this.btnQuery.TabIndex = 117;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Location = new System.Drawing.Point(764, 26);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 34);
            this.btnClose.TabIndex = 116;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "任务编号";
            // 
            // txtTaskID
            // 
            this.txtTaskID.Location = new System.Drawing.Point(108, 46);
            this.txtTaskID.Name = "txtTaskID";
            this.txtTaskID.Size = new System.Drawing.Size(135, 22);
            this.txtTaskID.TabIndex = 1;
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.gcList);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 84);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(934, 455);
            this.groupControl3.TabIndex = 8;
            this.groupControl3.Text = "试验任务信息";
            // 
            // gcList
            // 
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcList.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gcList.Location = new System.Drawing.Point(2, 25);
            this.gcList.MainView = this.gvList;
            this.gcList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repEdit_SampleNum});
            this.gcList.Size = new System.Drawing.Size(930, 428);
            this.gcList.TabIndex = 2;
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
            this.gvList.Appearance.HeaderPanel.Font = new System.Drawing.Font("宋体", 10.5F);
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
            this.gvList.Appearance.Row.Font = new System.Drawing.Font("宋体", 10.5F);
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
            this.colDEVICE_TYPE,
            this.colDEVICE_ID,
            this.colDEVICE_STATUS,
            this.colF_TEST_TASK_ID,
            this.colF_TEST_SAMPLE_ID,
            this.colEXPENDTIME});
            this.gvList.GridControl = this.gcList;
            this.gvList.Name = "gvList";
            this.gvList.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gvList.OptionsBehavior.ImmediateUpdateRowPosition = false;
            this.gvList.OptionsPrint.AutoWidth = false;
            this.gvList.OptionsView.ColumnAutoWidth = false;
            this.gvList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvList.OptionsView.EnableAppearanceOddRow = true;
            this.gvList.OptionsView.ShowGroupPanel = false;
            // 
            // colDEVICE_TYPE
            // 
            this.colDEVICE_TYPE.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.colDEVICE_TYPE.AppearanceCell.Options.UseFont = true;
            this.colDEVICE_TYPE.AppearanceCell.Options.UseTextOptions = true;
            this.colDEVICE_TYPE.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDEVICE_TYPE.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.colDEVICE_TYPE.AppearanceHeader.ForeColor = System.Drawing.Color.DarkRed;
            this.colDEVICE_TYPE.AppearanceHeader.Options.UseFont = true;
            this.colDEVICE_TYPE.AppearanceHeader.Options.UseForeColor = true;
            this.colDEVICE_TYPE.AppearanceHeader.Options.UseTextOptions = true;
            this.colDEVICE_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDEVICE_TYPE.Caption = "设备类型";
            this.colDEVICE_TYPE.ColumnEdit = this.repEdit_SampleNum;
            this.colDEVICE_TYPE.FieldName = "DEVICE_TYPE";
            this.colDEVICE_TYPE.Name = "colDEVICE_TYPE";
            this.colDEVICE_TYPE.OptionsColumn.AllowEdit = false;
            this.colDEVICE_TYPE.OptionsColumn.AllowFocus = false;
            this.colDEVICE_TYPE.Visible = true;
            this.colDEVICE_TYPE.VisibleIndex = 0;
            this.colDEVICE_TYPE.Width = 120;
            // 
            // repEdit_SampleNum
            // 
            this.repEdit_SampleNum.AutoHeight = false;
            this.repEdit_SampleNum.Mask.EditMask = "d";
            this.repEdit_SampleNum.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repEdit_SampleNum.Name = "repEdit_SampleNum";
            // 
            // colDEVICE_ID
            // 
            this.colDEVICE_ID.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.colDEVICE_ID.AppearanceCell.Options.UseFont = true;
            this.colDEVICE_ID.AppearanceCell.Options.UseTextOptions = true;
            this.colDEVICE_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colDEVICE_ID.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold);
            this.colDEVICE_ID.AppearanceHeader.ForeColor = System.Drawing.Color.DarkRed;
            this.colDEVICE_ID.AppearanceHeader.Options.UseFont = true;
            this.colDEVICE_ID.AppearanceHeader.Options.UseForeColor = true;
            this.colDEVICE_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colDEVICE_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDEVICE_ID.Caption = "设备编号";
            this.colDEVICE_ID.FieldName = "DEVICE_ID";
            this.colDEVICE_ID.Name = "colDEVICE_ID";
            this.colDEVICE_ID.OptionsColumn.AllowEdit = false;
            this.colDEVICE_ID.OptionsColumn.AllowFocus = false;
            this.colDEVICE_ID.Visible = true;
            this.colDEVICE_ID.VisibleIndex = 1;
            this.colDEVICE_ID.Width = 88;
            // 
            // colDEVICE_STATUS
            // 
            this.colDEVICE_STATUS.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.colDEVICE_STATUS.AppearanceCell.Options.UseFont = true;
            this.colDEVICE_STATUS.AppearanceCell.Options.UseTextOptions = true;
            this.colDEVICE_STATUS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDEVICE_STATUS.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.colDEVICE_STATUS.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colDEVICE_STATUS.AppearanceHeader.Options.UseFont = true;
            this.colDEVICE_STATUS.AppearanceHeader.Options.UseForeColor = true;
            this.colDEVICE_STATUS.AppearanceHeader.Options.UseTextOptions = true;
            this.colDEVICE_STATUS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDEVICE_STATUS.Caption = "设备状态";
            this.colDEVICE_STATUS.FieldName = "DEVICE_STATUS";
            this.colDEVICE_STATUS.Name = "colDEVICE_STATUS";
            this.colDEVICE_STATUS.OptionsColumn.AllowEdit = false;
            this.colDEVICE_STATUS.OptionsColumn.AllowFocus = false;
            this.colDEVICE_STATUS.Visible = true;
            this.colDEVICE_STATUS.VisibleIndex = 2;
            this.colDEVICE_STATUS.Width = 93;
            // 
            // colF_TEST_SAMPLE_ID
            // 
            this.colF_TEST_SAMPLE_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_TEST_SAMPLE_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_TEST_SAMPLE_ID.Caption = "样品编号";
            this.colF_TEST_SAMPLE_ID.FieldName = "F_TEST_SAMPLE_ID";
            this.colF_TEST_SAMPLE_ID.Name = "colF_TEST_SAMPLE_ID";
            this.colF_TEST_SAMPLE_ID.OptionsColumn.AllowEdit = false;
            this.colF_TEST_SAMPLE_ID.OptionsColumn.AllowFocus = false;
            this.colF_TEST_SAMPLE_ID.Visible = true;
            this.colF_TEST_SAMPLE_ID.VisibleIndex = 4;
            this.colF_TEST_SAMPLE_ID.Width = 100;
            // 
            // colEXPENDTIME
            // 
            this.colEXPENDTIME.AppearanceHeader.Options.UseTextOptions = true;
            this.colEXPENDTIME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEXPENDTIME.Caption = "预计完成时间";
            this.colEXPENDTIME.FieldName = "EXPENDTIME";
            this.colEXPENDTIME.Name = "colEXPENDTIME";
            this.colEXPENDTIME.OptionsColumn.AllowEdit = false;
            this.colEXPENDTIME.OptionsColumn.AllowFocus = false;
            this.colEXPENDTIME.Visible = true;
            this.colEXPENDTIME.VisibleIndex = 5;
            this.colEXPENDTIME.Width = 191;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.comDevStatus);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.comDevType);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.btnExport);
            this.panelControl1.Controls.Add(this.btnQuery);
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.txtTaskID);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(934, 84);
            this.panelControl1.TabIndex = 7;
            // 
            // comDevStatus
            // 
            this.comDevStatus.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comDevStatus.FormattingEnabled = true;
            this.comDevStatus.Items.AddRange(new object[] {
            "全部",
            "空闲",
            "占用",
            "禁用"});
            this.comDevStatus.Location = new System.Drawing.Point(340, 18);
            this.comDevStatus.Name = "comDevStatus";
            this.comDevStatus.Size = new System.Drawing.Size(135, 25);
            this.comDevStatus.TabIndex = 133;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(271, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 132;
            this.label3.Text = "设备状态";
            // 
            // comDevType
            // 
            this.comDevType.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comDevType.FormattingEnabled = true;
            this.comDevType.Items.AddRange(new object[] {
            "全部",
            "上位机",
            "下位机",
            "负载柜",
            "线圈电源"});
            this.comDevType.Location = new System.Drawing.Point(107, 18);
            this.comDevType.Name = "comDevType";
            this.comDevType.Size = new System.Drawing.Size(135, 25);
            this.comDevType.TabIndex = 131;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(38, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 119;
            this.label2.Text = "设备类型";
            // 
            // FrmQueryDevStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 539);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmQueryDevStatus";
            this.Text = "设备运行状态查询";
            this.Load += new System.EventHandler(this.FrmQueryDevStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit_SampleNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colF_TEST_TASK_ID;
        private Util.Common.BaseSimpleButton btnExport;
        private Util.Common.BaseSimpleButton btnQuery;
        private Util.Common.BaseSimpleButton btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaskID;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private Util.Common.BaseGridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvList;
        private DevExpress.XtraGrid.Columns.GridColumn colDEVICE_TYPE;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repEdit_SampleNum;
        private DevExpress.XtraGrid.Columns.GridColumn colDEVICE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDEVICE_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colF_TEST_SAMPLE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colEXPENDTIME;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comDevType;
        private System.Windows.Forms.ComboBox comDevStatus;
        private System.Windows.Forms.Label label3;
    }
}