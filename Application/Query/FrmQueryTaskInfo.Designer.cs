namespace RelayTest.Application.Query
{
    partial class FrmQueryTaskInfo
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
            this.gcList = new RelayTest.Util.Common.BaseGridControl();
            this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colF_TEST_TASK_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEST_STATUS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSAMPLE_NUMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_TEST_MODEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_OPERATOR_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBEGINTIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEXPENDTIME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFZDY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOWTDL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNCWTDL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZSYCS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repEdit_SampleNum = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnQuery = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnExport = new RelayTest.Util.Common.BaseSimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Query_attatchment = new RelayTest.Util.Common.BaseSimpleButton();
            this.txtFZDL2 = new DevExpress.XtraEditors.TextEdit();
            this.txtFZDL1 = new DevExpress.XtraEditors.TextEdit();
            this.txtFZDY2 = new DevExpress.XtraEditors.TextEdit();
            this.txtFZDY1 = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.detBegintime2 = new DevExpress.XtraEditors.DateEdit();
            this.detBegintime1 = new DevExpress.XtraEditors.DateEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comRunStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaskID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new RelayTest.Util.Common.BaseSimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit_SampleNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFZDL2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFZDL1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFZDY2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFZDY1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detBegintime2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detBegintime2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detBegintime1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detBegintime1.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.gcList.Size = new System.Drawing.Size(968, 286);
            this.gcList.TabIndex = 2;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvList,
            this.gridView1});
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
            this.colF_TEST_TASK_ID,
            this.colTEST_STATUS,
            this.colSAMPLE_NUMBER,
            this.colF_TEST_MODEL,
            this.colF_OPERATOR_ID,
            this.colBEGINTIME,
            this.colEXPENDTIME,
            this.colFZDY,
            this.colNOWTDL,
            this.colNCWTDL,
            this.colZSYCS});
            this.gvList.GridControl = this.gcList;
            this.gvList.Name = "gvList";
            this.gvList.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gvList.OptionsBehavior.ImmediateUpdateRowPosition = false;
            this.gvList.OptionsPrint.AutoWidth = false;
            this.gvList.OptionsView.ColumnAutoWidth = false;
            this.gvList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvList.OptionsView.EnableAppearanceOddRow = true;
            this.gvList.OptionsView.ShowGroupPanel = false;
            this.gvList.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvList_FocusedRowChanged);
            // 
            // colF_TEST_TASK_ID
            // 
            this.colF_TEST_TASK_ID.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.colF_TEST_TASK_ID.AppearanceCell.Options.UseFont = true;
            this.colF_TEST_TASK_ID.AppearanceCell.Options.UseTextOptions = true;
            this.colF_TEST_TASK_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_TEST_TASK_ID.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.colF_TEST_TASK_ID.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colF_TEST_TASK_ID.AppearanceHeader.Options.UseFont = true;
            this.colF_TEST_TASK_ID.AppearanceHeader.Options.UseForeColor = true;
            this.colF_TEST_TASK_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_TEST_TASK_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_TEST_TASK_ID.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.colF_TEST_TASK_ID.Caption = "试验任务编号";
            this.colF_TEST_TASK_ID.FieldName = "F_TEST_TASK_ID";
            this.colF_TEST_TASK_ID.Name = "colF_TEST_TASK_ID";
            this.colF_TEST_TASK_ID.OptionsColumn.AllowEdit = false;
            this.colF_TEST_TASK_ID.OptionsColumn.AllowFocus = false;
            this.colF_TEST_TASK_ID.Visible = true;
            this.colF_TEST_TASK_ID.VisibleIndex = 0;
            this.colF_TEST_TASK_ID.Width = 120;
            // 
            // colTEST_STATUS
            // 
            this.colTEST_STATUS.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.colTEST_STATUS.AppearanceCell.Options.UseFont = true;
            this.colTEST_STATUS.AppearanceCell.Options.UseTextOptions = true;
            this.colTEST_STATUS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colTEST_STATUS.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.colTEST_STATUS.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colTEST_STATUS.AppearanceHeader.Options.UseFont = true;
            this.colTEST_STATUS.AppearanceHeader.Options.UseForeColor = true;
            this.colTEST_STATUS.AppearanceHeader.Options.UseTextOptions = true;
            this.colTEST_STATUS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTEST_STATUS.Caption = "运行状态";
            this.colTEST_STATUS.FieldName = "TEST_STATUS";
            this.colTEST_STATUS.Name = "colTEST_STATUS";
            this.colTEST_STATUS.OptionsColumn.AllowEdit = false;
            this.colTEST_STATUS.OptionsColumn.AllowFocus = false;
            this.colTEST_STATUS.Visible = true;
            this.colTEST_STATUS.VisibleIndex = 1;
            this.colTEST_STATUS.Width = 88;
            // 
            // colSAMPLE_NUMBER
            // 
            this.colSAMPLE_NUMBER.AppearanceCell.Font = new System.Drawing.Font("宋体", 10.5F);
            this.colSAMPLE_NUMBER.AppearanceCell.Options.UseFont = true;
            this.colSAMPLE_NUMBER.AppearanceCell.Options.UseTextOptions = true;
            this.colSAMPLE_NUMBER.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colSAMPLE_NUMBER.AppearanceHeader.Font = new System.Drawing.Font("宋体", 10.5F);
            this.colSAMPLE_NUMBER.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colSAMPLE_NUMBER.AppearanceHeader.Options.UseFont = true;
            this.colSAMPLE_NUMBER.AppearanceHeader.Options.UseForeColor = true;
            this.colSAMPLE_NUMBER.AppearanceHeader.Options.UseTextOptions = true;
            this.colSAMPLE_NUMBER.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSAMPLE_NUMBER.Caption = "样品数量";
            this.colSAMPLE_NUMBER.FieldName = "SAMPLE_NUMBER";
            this.colSAMPLE_NUMBER.Name = "colSAMPLE_NUMBER";
            this.colSAMPLE_NUMBER.OptionsColumn.AllowEdit = false;
            this.colSAMPLE_NUMBER.OptionsColumn.AllowFocus = false;
            this.colSAMPLE_NUMBER.Visible = true;
            this.colSAMPLE_NUMBER.VisibleIndex = 2;
            this.colSAMPLE_NUMBER.Width = 78;
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
            this.colF_TEST_MODEL.VisibleIndex = 3;
            this.colF_TEST_MODEL.Width = 109;
            // 
            // colF_OPERATOR_ID
            // 
            this.colF_OPERATOR_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_OPERATOR_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_OPERATOR_ID.Caption = "操作员";
            this.colF_OPERATOR_ID.FieldName = "F_OPERATOR_ID";
            this.colF_OPERATOR_ID.Name = "colF_OPERATOR_ID";
            this.colF_OPERATOR_ID.OptionsColumn.AllowEdit = false;
            this.colF_OPERATOR_ID.OptionsColumn.AllowFocus = false;
            this.colF_OPERATOR_ID.Visible = true;
            this.colF_OPERATOR_ID.VisibleIndex = 4;
            // 
            // colBEGINTIME
            // 
            this.colBEGINTIME.AppearanceHeader.Options.UseTextOptions = true;
            this.colBEGINTIME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBEGINTIME.Caption = "开始时间";
            this.colBEGINTIME.FieldName = "BEGINTIME";
            this.colBEGINTIME.Name = "colBEGINTIME";
            this.colBEGINTIME.OptionsColumn.AllowEdit = false;
            this.colBEGINTIME.OptionsColumn.AllowFocus = false;
            this.colBEGINTIME.Visible = true;
            this.colBEGINTIME.VisibleIndex = 5;
            this.colBEGINTIME.Width = 166;
            // 
            // colEXPENDTIME
            // 
            this.colEXPENDTIME.AppearanceHeader.Options.UseTextOptions = true;
            this.colEXPENDTIME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEXPENDTIME.Caption = "完成时间";
            this.colEXPENDTIME.FieldName = "EXPENDTIME";
            this.colEXPENDTIME.Name = "colEXPENDTIME";
            this.colEXPENDTIME.OptionsColumn.AllowEdit = false;
            this.colEXPENDTIME.OptionsColumn.AllowFocus = false;
            this.colEXPENDTIME.Visible = true;
            this.colEXPENDTIME.VisibleIndex = 6;
            this.colEXPENDTIME.Width = 161;
            // 
            // colFZDY
            // 
            this.colFZDY.AppearanceHeader.Options.UseTextOptions = true;
            this.colFZDY.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFZDY.Caption = "负载电压";
            this.colFZDY.FieldName = "FZDY";
            this.colFZDY.Name = "colFZDY";
            this.colFZDY.OptionsColumn.AllowEdit = false;
            this.colFZDY.OptionsColumn.AllowFocus = false;
            this.colFZDY.Visible = true;
            this.colFZDY.VisibleIndex = 7;
            this.colFZDY.Width = 71;
            // 
            // colNOWTDL
            // 
            this.colNOWTDL.AppearanceHeader.Options.UseTextOptions = true;
            this.colNOWTDL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNOWTDL.Caption = "NO稳态电流";
            this.colNOWTDL.FieldName = "NOWTDL";
            this.colNOWTDL.Name = "colNOWTDL";
            this.colNOWTDL.OptionsColumn.AllowEdit = false;
            this.colNOWTDL.OptionsColumn.AllowFocus = false;
            this.colNOWTDL.Visible = true;
            this.colNOWTDL.VisibleIndex = 8;
            this.colNOWTDL.Width = 85;
            // 
            // colNCWTDL
            // 
            this.colNCWTDL.AppearanceHeader.Options.UseTextOptions = true;
            this.colNCWTDL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNCWTDL.Caption = "NC稳态电流";
            this.colNCWTDL.FieldName = "NCWTDL";
            this.colNCWTDL.Name = "colNCWTDL";
            this.colNCWTDL.OptionsColumn.AllowEdit = false;
            this.colNCWTDL.OptionsColumn.AllowFocus = false;
            this.colNCWTDL.Visible = true;
            this.colNCWTDL.VisibleIndex = 9;
            this.colNCWTDL.Width = 82;
            // 
            // colZSYCS
            // 
            this.colZSYCS.AppearanceHeader.Options.UseTextOptions = true;
            this.colZSYCS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colZSYCS.Caption = "总试验次数";
            this.colZSYCS.FieldName = "ZSYCS";
            this.colZSYCS.Name = "colZSYCS";
            this.colZSYCS.OptionsColumn.AllowEdit = false;
            this.colZSYCS.OptionsColumn.AllowFocus = false;
            this.colZSYCS.Visible = true;
            this.colZSYCS.VisibleIndex = 10;
            this.colZSYCS.Width = 80;
            // 
            // repEdit_SampleNum
            // 
            this.repEdit_SampleNum.AutoHeight = false;
            this.repEdit_SampleNum.Mask.EditMask = "d";
            this.repEdit_SampleNum.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repEdit_SampleNum.Name = "repEdit_SampleNum";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcList;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.gcList);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 158);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(972, 313);
            this.groupControl3.TabIndex = 4;
            this.groupControl3.Text = "试验任务信息";
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQuery.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Appearance.Options.UseFont = true;
            this.btnQuery.Location = new System.Drawing.Point(478, 60);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(80, 39);
            this.btnQuery.TabIndex = 117;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExport.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.Location = new System.Drawing.Point(585, 60);
            this.btnExport.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(98, 38);
            this.btnExport.TabIndex = 118;
            this.btnExport.Text = "导出";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Query_attatchment);
            this.panelControl1.Controls.Add(this.txtFZDL2);
            this.panelControl1.Controls.Add(this.txtFZDL1);
            this.panelControl1.Controls.Add(this.txtFZDY2);
            this.panelControl1.Controls.Add(this.txtFZDY1);
            this.panelControl1.Controls.Add(this.label7);
            this.panelControl1.Controls.Add(this.label8);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.detBegintime2);
            this.panelControl1.Controls.Add(this.detBegintime1);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.comRunStatus);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.txtTaskID);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.btnExport);
            this.panelControl1.Controls.Add(this.btnQuery);
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(972, 158);
            this.panelControl1.TabIndex = 0;
            // 
            // btn_Query_attatchment
            // 
            this.btn_Query_attatchment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Query_attatchment.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Query_attatchment.Appearance.Options.UseFont = true;
            this.btn_Query_attatchment.Location = new System.Drawing.Point(711, 60);
            this.btn_Query_attatchment.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Query_attatchment.Name = "btn_Query_attatchment";
            this.btn_Query_attatchment.Size = new System.Drawing.Size(123, 39);
            this.btn_Query_attatchment.TabIndex = 147;
            this.btn_Query_attatchment.Text = "查看任务附件";
            this.btn_Query_attatchment.Click += new System.EventHandler(this.btn_Query_attatchment_Click);
            // 
            // txtFZDL2
            // 
            this.txtFZDL2.Location = new System.Drawing.Point(276, 127);
            this.txtFZDL2.Name = "txtFZDL2";
            this.txtFZDL2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtFZDL2.Size = new System.Drawing.Size(135, 21);
            this.txtFZDL2.TabIndex = 146;
            // 
            // txtFZDL1
            // 
            this.txtFZDL1.Location = new System.Drawing.Point(107, 127);
            this.txtFZDL1.Name = "txtFZDL1";
            this.txtFZDL1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtFZDL1.Size = new System.Drawing.Size(135, 21);
            this.txtFZDL1.TabIndex = 145;
            // 
            // txtFZDY2
            // 
            this.txtFZDY2.Location = new System.Drawing.Point(276, 99);
            this.txtFZDY2.Name = "txtFZDY2";
            this.txtFZDY2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtFZDY2.Size = new System.Drawing.Size(135, 21);
            this.txtFZDY2.TabIndex = 144;
            // 
            // txtFZDY1
            // 
            this.txtFZDY1.Location = new System.Drawing.Point(108, 99);
            this.txtFZDY1.Name = "txtFZDY1";
            this.txtFZDY1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtFZDY1.Size = new System.Drawing.Size(135, 21);
            this.txtFZDY1.TabIndex = 143;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(249, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 14);
            this.label7.TabIndex = 141;
            this.label7.Text = "至";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(38, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 14);
            this.label8.TabIndex = 139;
            this.label8.Text = "负载电流";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(249, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 14);
            this.label6.TabIndex = 137;
            this.label6.Text = "至";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(38, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 135;
            this.label3.Text = "负载电压";
            // 
            // detBegintime2
            // 
            this.detBegintime2.EditValue = null;
            this.detBegintime2.Location = new System.Drawing.Point(276, 69);
            this.detBegintime2.Name = "detBegintime2";
            this.detBegintime2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.detBegintime2.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.detBegintime2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.detBegintime2.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.detBegintime2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.detBegintime2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.detBegintime2.Size = new System.Drawing.Size(135, 21);
            this.detBegintime2.TabIndex = 134;
            // 
            // detBegintime1
            // 
            this.detBegintime1.EditValue = null;
            this.detBegintime1.Location = new System.Drawing.Point(108, 69);
            this.detBegintime1.Name = "detBegintime1";
            this.detBegintime1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.detBegintime1.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.detBegintime1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.detBegintime1.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.detBegintime1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.detBegintime1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.detBegintime1.Size = new System.Drawing.Size(135, 21);
            this.detBegintime1.TabIndex = 133;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(249, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 14);
            this.label5.TabIndex = 132;
            this.label5.Text = "至";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(38, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 131;
            this.label4.Text = "开始时间";
            // 
            // comRunStatus
            // 
            this.comRunStatus.FormattingEnabled = true;
            this.comRunStatus.Items.AddRange(new object[] {
            "全部",
            "待试验",
            "试验中",
            "试验结束"});
            this.comRunStatus.Location = new System.Drawing.Point(108, 12);
            this.comRunStatus.Name = "comRunStatus";
            this.comRunStatus.Size = new System.Drawing.Size(135, 22);
            this.comRunStatus.TabIndex = 130;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(38, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 129;
            this.label2.Text = "运行状态";
            // 
            // txtTaskID
            // 
            this.txtTaskID.Location = new System.Drawing.Point(108, 40);
            this.txtTaskID.Name = "txtTaskID";
            this.txtTaskID.Size = new System.Drawing.Size(135, 22);
            this.txtTaskID.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 127;
            this.label1.Text = "任务编号";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Location = new System.Drawing.Point(862, 61);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 38);
            this.btnClose.TabIndex = 116;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmQueryTaskInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 471);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmQueryTaskInfo";
            this.Text = "试验任务信息查询";
            this.Load += new System.EventHandler(this.FrmQueryTaskInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repEdit_SampleNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFZDL2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFZDL1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFZDY2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFZDY1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detBegintime2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detBegintime2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detBegintime1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detBegintime1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Util.Common.BaseGridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvList;
        private DevExpress.XtraGrid.Columns.GridColumn colF_TEST_TASK_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repEdit_SampleNum;
        private DevExpress.XtraGrid.Columns.GridColumn colTEST_STATUS;
        private DevExpress.XtraGrid.Columns.GridColumn colSAMPLE_NUMBER;
        private DevExpress.XtraGrid.Columns.GridColumn colF_TEST_MODEL;
        private DevExpress.XtraGrid.Columns.GridColumn colF_OPERATOR_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colBEGINTIME;
        private DevExpress.XtraGrid.Columns.GridColumn colEXPENDTIME;
        private DevExpress.XtraGrid.Columns.GridColumn colFZDY;
        private DevExpress.XtraGrid.Columns.GridColumn colNOWTDL;
        private DevExpress.XtraGrid.Columns.GridColumn colNCWTDL;
        private DevExpress.XtraGrid.Columns.GridColumn colZSYCS;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private Util.Common.BaseSimpleButton btnQuery;
        private Util.Common.BaseSimpleButton btnExport;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit detBegintime2;
        private DevExpress.XtraEditors.DateEdit detBegintime1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comRunStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaskID;
        private System.Windows.Forms.Label label1;
        private Util.Common.BaseSimpleButton btnClose;
        private DevExpress.XtraEditors.TextEdit txtFZDL2;
        private DevExpress.XtraEditors.TextEdit txtFZDL1;
        private DevExpress.XtraEditors.TextEdit txtFZDY2;
        private DevExpress.XtraEditors.TextEdit txtFZDY1;
        private Util.Common.BaseSimpleButton btn_Query_attatchment;

    }
}