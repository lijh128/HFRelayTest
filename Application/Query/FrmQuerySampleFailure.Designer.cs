namespace RelayTest.Application.Query
{
    partial class FrmQuerySampleFailure
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
            this.colF_LOAD_CHANNEL_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_LOAD_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_SAMPLE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEdit_SampleNum = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colF_TEST_TASK_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFAILURE_ORDER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_FAILURE_CYCLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_TEST_MODEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_FAILURE_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colF_FAILURE_CYCLE_ALL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_TEST_CYCLE_ALL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_CREATE_TIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcList = new RelayTest.Util.Common.BaseGridControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaskID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.detCreatetime1 = new DevExpress.XtraEditors.DateEdit();
            this.detCreatetime2 = new DevExpress.XtraEditors.DateEdit();
            this.btnClose = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnQuery = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnExport = new RelayTest.Util.Common.BaseSimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit_SampleNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detCreatetime1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detCreatetime1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detCreatetime2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detCreatetime2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colF_LOAD_CHANNEL_ID
            // 
            this.colF_LOAD_CHANNEL_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_LOAD_CHANNEL_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_LOAD_CHANNEL_ID.Caption = "负载通道";
            this.colF_LOAD_CHANNEL_ID.FieldName = "F_LOAD_CHANNEL_ID";
            this.colF_LOAD_CHANNEL_ID.Name = "colF_LOAD_CHANNEL_ID";
            this.colF_LOAD_CHANNEL_ID.OptionsColumn.AllowEdit = false;
            this.colF_LOAD_CHANNEL_ID.OptionsColumn.AllowFocus = false;
            this.colF_LOAD_CHANNEL_ID.Visible = true;
            this.colF_LOAD_CHANNEL_ID.VisibleIndex = 3;
            this.colF_LOAD_CHANNEL_ID.Width = 73;
            // 
            // colF_LOAD_ID
            // 
            this.colF_LOAD_ID.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_LOAD_ID.AppearanceCell.Options.UseFont = true;
            this.colF_LOAD_ID.AppearanceCell.Options.UseTextOptions = true;
            this.colF_LOAD_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colF_LOAD_ID.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_LOAD_ID.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colF_LOAD_ID.AppearanceHeader.Options.UseFont = true;
            this.colF_LOAD_ID.AppearanceHeader.Options.UseForeColor = true;
            this.colF_LOAD_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_LOAD_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_LOAD_ID.Caption = "负载柜";
            this.colF_LOAD_ID.FieldName = "F_LOAD_ID";
            this.colF_LOAD_ID.Name = "colF_LOAD_ID";
            this.colF_LOAD_ID.OptionsColumn.AllowEdit = false;
            this.colF_LOAD_ID.OptionsColumn.AllowFocus = false;
            this.colF_LOAD_ID.Visible = true;
            this.colF_LOAD_ID.VisibleIndex = 2;
            this.colF_LOAD_ID.Width = 70;
            // 
            // colF_SAMPLE_ID
            // 
            this.colF_SAMPLE_ID.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_SAMPLE_ID.AppearanceCell.Options.UseFont = true;
            this.colF_SAMPLE_ID.AppearanceCell.Options.UseTextOptions = true;
            this.colF_SAMPLE_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_SAMPLE_ID.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold);
            this.colF_SAMPLE_ID.AppearanceHeader.ForeColor = System.Drawing.Color.DarkRed;
            this.colF_SAMPLE_ID.AppearanceHeader.Options.UseFont = true;
            this.colF_SAMPLE_ID.AppearanceHeader.Options.UseForeColor = true;
            this.colF_SAMPLE_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_SAMPLE_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_SAMPLE_ID.Caption = "样品编号";
            this.colF_SAMPLE_ID.FieldName = "F_SAMPLE_ID";
            this.colF_SAMPLE_ID.Name = "colF_SAMPLE_ID";
            this.colF_SAMPLE_ID.OptionsColumn.AllowEdit = false;
            this.colF_SAMPLE_ID.OptionsColumn.AllowFocus = false;
            this.colF_SAMPLE_ID.Visible = true;
            this.colF_SAMPLE_ID.VisibleIndex = 1;
            this.colF_SAMPLE_ID.Width = 88;
            // 
            // repEdit_SampleNum
            // 
            this.repEdit_SampleNum.AutoHeight = false;
            this.repEdit_SampleNum.Mask.EditMask = "d";
            this.repEdit_SampleNum.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repEdit_SampleNum.Name = "repEdit_SampleNum";
            // 
            // colF_TEST_TASK_ID
            // 
            this.colF_TEST_TASK_ID.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_TEST_TASK_ID.AppearanceCell.Options.UseFont = true;
            this.colF_TEST_TASK_ID.AppearanceCell.Options.UseTextOptions = true;
            this.colF_TEST_TASK_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_TEST_TASK_ID.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold);
            this.colF_TEST_TASK_ID.AppearanceHeader.ForeColor = System.Drawing.Color.DarkRed;
            this.colF_TEST_TASK_ID.AppearanceHeader.Options.UseFont = true;
            this.colF_TEST_TASK_ID.AppearanceHeader.Options.UseForeColor = true;
            this.colF_TEST_TASK_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_TEST_TASK_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_TEST_TASK_ID.Caption = "试验任务编号";
            this.colF_TEST_TASK_ID.ColumnEdit = this.repEdit_SampleNum;
            this.colF_TEST_TASK_ID.FieldName = "F_TEST_TASK_ID";
            this.colF_TEST_TASK_ID.Name = "colF_TEST_TASK_ID";
            this.colF_TEST_TASK_ID.OptionsColumn.AllowEdit = false;
            this.colF_TEST_TASK_ID.OptionsColumn.AllowFocus = false;
            this.colF_TEST_TASK_ID.Visible = true;
            this.colF_TEST_TASK_ID.VisibleIndex = 0;
            this.colF_TEST_TASK_ID.Width = 120;
            // 
            // colFAILURE_ORDER_ID
            // 
            this.colFAILURE_ORDER_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colFAILURE_ORDER_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFAILURE_ORDER_ID.Caption = "失效次数";
            this.colFAILURE_ORDER_ID.FieldName = "FAILURE_ORDER_ID";
            this.colFAILURE_ORDER_ID.Name = "colFAILURE_ORDER_ID";
            this.colFAILURE_ORDER_ID.OptionsColumn.AllowEdit = false;
            this.colFAILURE_ORDER_ID.OptionsColumn.AllowFocus = false;
            this.colFAILURE_ORDER_ID.Visible = true;
            this.colFAILURE_ORDER_ID.VisibleIndex = 4;
            // 
            // colF_FAILURE_CYCLE
            // 
            this.colF_FAILURE_CYCLE.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_FAILURE_CYCLE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_FAILURE_CYCLE.Caption = "失效时刻";
            this.colF_FAILURE_CYCLE.FieldName = "F_FAILURE_CYCLE";
            this.colF_FAILURE_CYCLE.Name = "colF_FAILURE_CYCLE";
            this.colF_FAILURE_CYCLE.OptionsColumn.AllowEdit = false;
            this.colF_FAILURE_CYCLE.OptionsColumn.AllowFocus = false;
            this.colF_FAILURE_CYCLE.Visible = true;
            this.colF_FAILURE_CYCLE.VisibleIndex = 5;
            this.colF_FAILURE_CYCLE.Width = 77;
            // 
            // colF_TEST_MODEL
            // 
            this.colF_TEST_MODEL.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_TEST_MODEL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_TEST_MODEL.Caption = "样品规格";
            this.colF_TEST_MODEL.FieldName = "F_TEST_MODEL";
            this.colF_TEST_MODEL.Name = "colF_TEST_MODEL";
            this.colF_TEST_MODEL.OptionsColumn.AllowEdit = false;
            this.colF_TEST_MODEL.OptionsColumn.AllowFocus = false;
            this.colF_TEST_MODEL.Visible = true;
            this.colF_TEST_MODEL.VisibleIndex = 6;
            this.colF_TEST_MODEL.Width = 110;
            // 
            // colF_FAILURE_TYPE
            // 
            this.colF_FAILURE_TYPE.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_FAILURE_TYPE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_FAILURE_TYPE.Caption = "失效类型";
            this.colF_FAILURE_TYPE.FieldName = "F_FAILURE_TYPE";
            this.colF_FAILURE_TYPE.Name = "colF_FAILURE_TYPE";
            this.colF_FAILURE_TYPE.OptionsColumn.AllowEdit = false;
            this.colF_FAILURE_TYPE.OptionsColumn.AllowFocus = false;
            this.colF_FAILURE_TYPE.Visible = true;
            this.colF_FAILURE_TYPE.VisibleIndex = 7;
            this.colF_FAILURE_TYPE.Width = 67;
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
            this.colF_TEST_TASK_ID,
            this.colF_SAMPLE_ID,
            this.colF_LOAD_ID,
            this.colF_LOAD_CHANNEL_ID,
            this.colFAILURE_ORDER_ID,
            this.colF_FAILURE_CYCLE,
            this.colF_TEST_MODEL,
            this.colF_FAILURE_TYPE,
            this.colF_FAILURE_CYCLE_ALL,
            this.colF_TEST_CYCLE_ALL,
            this.colF_CREATE_TIME});
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
            // colF_FAILURE_CYCLE_ALL
            // 
            this.colF_FAILURE_CYCLE_ALL.Caption = "失效总次数";
            this.colF_FAILURE_CYCLE_ALL.FieldName = "F_FAILURE_CYCLE_ALL";
            this.colF_FAILURE_CYCLE_ALL.Name = "colF_FAILURE_CYCLE_ALL";
            this.colF_FAILURE_CYCLE_ALL.OptionsColumn.AllowEdit = false;
            this.colF_FAILURE_CYCLE_ALL.OptionsColumn.AllowFocus = false;
            this.colF_FAILURE_CYCLE_ALL.Visible = true;
            this.colF_FAILURE_CYCLE_ALL.VisibleIndex = 8;
            this.colF_FAILURE_CYCLE_ALL.Width = 88;
            // 
            // colF_TEST_CYCLE_ALL
            // 
            this.colF_TEST_CYCLE_ALL.Caption = "试验总次数";
            this.colF_TEST_CYCLE_ALL.FieldName = "F_TEST_CYCLE_ALL";
            this.colF_TEST_CYCLE_ALL.Name = "colF_TEST_CYCLE_ALL";
            this.colF_TEST_CYCLE_ALL.OptionsColumn.AllowEdit = false;
            this.colF_TEST_CYCLE_ALL.OptionsColumn.AllowFocus = false;
            this.colF_TEST_CYCLE_ALL.Visible = true;
            this.colF_TEST_CYCLE_ALL.VisibleIndex = 9;
            this.colF_TEST_CYCLE_ALL.Width = 93;
            // 
            // colF_CREATE_TIME
            // 
            this.colF_CREATE_TIME.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_CREATE_TIME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_CREATE_TIME.Caption = "失效发生时间";
            this.colF_CREATE_TIME.FieldName = "F_CREATE_TIME";
            this.colF_CREATE_TIME.Name = "colF_CREATE_TIME";
            this.colF_CREATE_TIME.OptionsColumn.AllowEdit = false;
            this.colF_CREATE_TIME.OptionsColumn.AllowFocus = false;
            this.colF_CREATE_TIME.Visible = true;
            this.colF_CREATE_TIME.VisibleIndex = 10;
            this.colF_CREATE_TIME.Width = 175;
            // 
            // gcList
            // 
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcList.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gcList.Location = new System.Drawing.Point(2, 25);
            this.gcList.MainView = this.gvList;
            this.gcList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repEdit_SampleNum});
            this.gcList.Size = new System.Drawing.Size(969, 437);
            this.gcList.TabIndex = 2;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvList});
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.gcList);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 84);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(973, 464);
            this.groupControl3.TabIndex = 6;
            this.groupControl3.Text = "试验任务信息";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "任务编号";
            // 
            // txtTaskID
            // 
            this.txtTaskID.Location = new System.Drawing.Point(108, 15);
            this.txtTaskID.Name = "txtTaskID";
            this.txtTaskID.Size = new System.Drawing.Size(135, 22);
            this.txtTaskID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(38, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "失效发生时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(248, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "至";
            // 
            // detCreatetime1
            // 
            this.detCreatetime1.EditValue = null;
            this.detCreatetime1.Location = new System.Drawing.Point(135, 43);
            this.detCreatetime1.Name = "detCreatetime1";
            this.detCreatetime1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.detCreatetime1.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.detCreatetime1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.detCreatetime1.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.detCreatetime1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.detCreatetime1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.detCreatetime1.Size = new System.Drawing.Size(108, 21);
            this.detCreatetime1.TabIndex = 10;
            // 
            // detCreatetime2
            // 
            this.detCreatetime2.EditValue = null;
            this.detCreatetime2.Location = new System.Drawing.Point(276, 44);
            this.detCreatetime2.Name = "detCreatetime2";
            this.detCreatetime2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.detCreatetime2.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.detCreatetime2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.detCreatetime2.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.detCreatetime2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.detCreatetime2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.detCreatetime2.Size = new System.Drawing.Size(110, 21);
            this.detCreatetime2.TabIndex = 11;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Location = new System.Drawing.Point(764, 26);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 34);
            this.btnClose.TabIndex = 116;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQuery.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Appearance.Options.UseFont = true;
            this.btnQuery.Location = new System.Drawing.Point(568, 26);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(80, 34);
            this.btnQuery.TabIndex = 117;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExport.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.Location = new System.Drawing.Point(666, 26);
            this.btnExport.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(80, 34);
            this.btnExport.TabIndex = 118;
            this.btnExport.Text = "导出";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnExport);
            this.panelControl1.Controls.Add(this.btnQuery);
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.detCreatetime2);
            this.panelControl1.Controls.Add(this.detCreatetime1);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.txtTaskID);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(973, 84);
            this.panelControl1.TabIndex = 5;
            // 
            // FrmQuerySampleFailure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 548);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmQuerySampleFailure";
            this.Text = "试验样品失效查询";
            ((System.ComponentModel.ISupportInitialize)(this.repEdit_SampleNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detCreatetime1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detCreatetime1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detCreatetime2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detCreatetime2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colF_LOAD_CHANNEL_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colF_LOAD_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colF_SAMPLE_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repEdit_SampleNum;
        private DevExpress.XtraGrid.Columns.GridColumn colF_TEST_TASK_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colFAILURE_ORDER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colF_FAILURE_CYCLE;
        private DevExpress.XtraGrid.Columns.GridColumn colF_TEST_MODEL;
        private DevExpress.XtraGrid.Columns.GridColumn colF_FAILURE_TYPE;
        private DevExpress.XtraGrid.Views.Grid.GridView gvList;
        private Util.Common.BaseGridControl gcList;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.Columns.GridColumn colF_CREATE_TIME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaskID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.DateEdit detCreatetime1;
        private DevExpress.XtraEditors.DateEdit detCreatetime2;
        private Util.Common.BaseSimpleButton btnClose;
        private Util.Common.BaseSimpleButton btnQuery;
        private Util.Common.BaseSimpleButton btnExport;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colF_FAILURE_CYCLE_ALL;
        private DevExpress.XtraGrid.Columns.GridColumn colF_TEST_CYCLE_ALL;
    }
}