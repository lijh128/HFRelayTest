namespace RelayTest.Application.Sys
{
    partial class FrmLogs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

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
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.lciQueryCondition = new DevExpress.XtraLayout.LayoutControl();
            this.lueUserId = new DevExpress.XtraEditors.LookUpEdit();
            this.dteBegin = new DevExpress.XtraEditors.DateEdit();
            this.dteEnd = new DevExpress.XtraEditors.DateEdit();
            this.lcgQueryCondition = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciUserID = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciBeginDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEndDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.pnlList = new DevExpress.XtraEditors.PanelControl();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colF_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_MODULE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lciQueryCondition)).BeginInit();
            this.lciQueryCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueUserId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBegin.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgQueryCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUserID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBeginDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlList)).BeginInit();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnQuery);
            this.pnlBottom.Controls.Add(this.btnExport);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 485);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(764, 55);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Appearance.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuery.Appearance.Options.UseFont = true;
            this.btnQuery.Location = new System.Drawing.Point(300, 12);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(80, 31);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnExport
            // 
            this.btnExport.Appearance.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.Location = new System.Drawing.Point(386, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(80, 31);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "导出";
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.lciQueryCondition);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(0, 0);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(764, 113);
            this.pnlEdit.TabIndex = 0;
            // 
            // lciQueryCondition
            // 
            this.lciQueryCondition.Controls.Add(this.lueUserId);
            this.lciQueryCondition.Controls.Add(this.dteBegin);
            this.lciQueryCondition.Controls.Add(this.dteEnd);
            this.lciQueryCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lciQueryCondition.Location = new System.Drawing.Point(2, 2);
            this.lciQueryCondition.Name = "lciQueryCondition";
            this.lciQueryCondition.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(50, 173, 250, 350);
            this.lciQueryCondition.Root = this.lcgQueryCondition;
            this.lciQueryCondition.Size = new System.Drawing.Size(760, 109);
            this.lciQueryCondition.TabIndex = 0;
            this.lciQueryCondition.Text = "layoutControl1";
            // 
            // lueUserId
            // 
            this.lueUserId.Location = new System.Drawing.Point(180, 38);
            this.lueUserId.Name = "lueUserId";
            this.lueUserId.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lueUserId.Properties.Appearance.Options.UseFont = true;
            this.lueUserId.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueUserId.Properties.NullText = "";
            this.lueUserId.Size = new System.Drawing.Size(196, 22);
            this.lueUserId.StyleController = this.lciQueryCondition;
            this.lueUserId.TabIndex = 0;
            // 
            // dteBegin
            // 
            this.dteBegin.EditValue = null;
            this.dteBegin.Location = new System.Drawing.Point(180, 70);
            this.dteBegin.Name = "dteBegin";
            this.dteBegin.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dteBegin.Properties.Appearance.Options.UseFont = true;
            this.dteBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteBegin.Properties.Mask.EditMask = "";
            this.dteBegin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dteBegin.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteBegin.Size = new System.Drawing.Size(196, 22);
            this.dteBegin.StyleController = this.lciQueryCondition;
            this.dteBegin.TabIndex = 1;
            // 
            // dteEnd
            // 
            this.dteEnd.EditValue = null;
            this.dteEnd.Location = new System.Drawing.Point(460, 70);
            this.dteEnd.Name = "dteEnd";
            this.dteEnd.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dteEnd.Properties.Appearance.Options.UseFont = true;
            this.dteEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteEnd.Properties.Mask.EditMask = "";
            this.dteEnd.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dteEnd.Properties.PasswordChar = '*';
            this.dteEnd.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteEnd.Size = new System.Drawing.Size(194, 22);
            this.dteEnd.StyleController = this.lciQueryCondition;
            this.dteEnd.TabIndex = 2;
            // 
            // lcgQueryCondition
            // 
            this.lcgQueryCondition.AppearanceGroup.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcgQueryCondition.AppearanceGroup.Options.UseFont = true;
            this.lcgQueryCondition.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcgQueryCondition.AppearanceItemCaption.Options.UseFont = true;
            this.lcgQueryCondition.CustomizationFormText = "Root";
            this.lcgQueryCondition.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgQueryCondition.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciUserID,
            this.lciBeginDate,
            this.lciEndDate,
            this.emptySpaceItem1});
            this.lcgQueryCondition.Location = new System.Drawing.Point(0, 0);
            this.lcgQueryCondition.Name = "Root";
            this.lcgQueryCondition.Padding = new DevExpress.XtraLayout.Utils.Padding(100, 100, 10, 10);
            this.lcgQueryCondition.Size = new System.Drawing.Size(760, 109);
            this.lcgQueryCondition.Text = "查询条件";
            // 
            // lciUserID
            // 
            this.lciUserID.Control = this.lueUserId;
            this.lciUserID.CustomizationFormText = "lciUserID";
            this.lciUserID.Location = new System.Drawing.Point(0, 0);
            this.lciUserID.Name = "lciUserID";
            this.lciUserID.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciUserID.Size = new System.Drawing.Size(280, 32);
            this.lciUserID.Text = "操作员：";
            this.lciUserID.TextSize = new System.Drawing.Size(70, 14);
            // 
            // lciBeginDate
            // 
            this.lciBeginDate.Control = this.dteBegin;
            this.lciBeginDate.CustomizationFormText = "开始日期：";
            this.lciBeginDate.Location = new System.Drawing.Point(0, 32);
            this.lciBeginDate.Name = "lciBeginDate";
            this.lciBeginDate.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciBeginDate.Size = new System.Drawing.Size(280, 33);
            this.lciBeginDate.Text = "开始日期：";
            this.lciBeginDate.TextSize = new System.Drawing.Size(70, 14);
            // 
            // lciEndDate
            // 
            this.lciEndDate.Control = this.dteEnd;
            this.lciEndDate.CustomizationFormText = "结束日期：";
            this.lciEndDate.Location = new System.Drawing.Point(280, 32);
            this.lciEndDate.Name = "lciEndDate";
            this.lciEndDate.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciEndDate.Size = new System.Drawing.Size(278, 33);
            this.lciEndDate.Text = "结束日期：";
            this.lciEndDate.TextSize = new System.Drawing.Size(70, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(280, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(278, 32);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.gcList);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.Location = new System.Drawing.Point(0, 113);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(764, 372);
            this.pnlList.TabIndex = 4;
            // 
            // gcList
            // 
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcList.Location = new System.Drawing.Point(2, 2);
            this.gcList.MainView = this.gvList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemDateEdit1});
            this.gcList.Size = new System.Drawing.Size(760, 368);
            this.gcList.TabIndex = 0;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvList});
            // 
            // gvList
            // 
            this.gvList.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvList.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvList.Appearance.FilterPanel.Font = new System.Drawing.Font("SimSun", 12F);
            this.gvList.Appearance.FilterPanel.Options.UseFont = true;
            this.gvList.Appearance.FooterPanel.Font = new System.Drawing.Font("SimSun", 12F);
            this.gvList.Appearance.FooterPanel.Options.UseFont = true;
            this.gvList.Appearance.GroupPanel.Font = new System.Drawing.Font("SimSun", 12F);
            this.gvList.Appearance.GroupPanel.Options.UseFont = true;
            this.gvList.Appearance.GroupRow.Font = new System.Drawing.Font("SimSun", 12F);
            this.gvList.Appearance.GroupRow.Options.UseFont = true;
            this.gvList.Appearance.HeaderPanel.Font = new System.Drawing.Font("SimSun", 12F);
            this.gvList.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvList.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvList.Appearance.OddRow.Options.UseBackColor = true;
            this.gvList.Appearance.Row.Font = new System.Drawing.Font("SimSun", 12F);
            this.gvList.Appearance.Row.Options.UseFont = true;
            this.gvList.Appearance.TopNewRow.Font = new System.Drawing.Font("SimSun", 12F);
            this.gvList.Appearance.TopNewRow.Options.UseFont = true;
            this.gvList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colF_USER_ID,
            this.colF_MODULE_NAME,
            this.colF_DATE});
            this.gvList.GridControl = this.gcList;
            this.gvList.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.gvList.Name = "gvList";
            this.gvList.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvList.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvList.OptionsBehavior.Editable = false;
            this.gvList.OptionsBehavior.ReadOnly = true;
            this.gvList.OptionsCustomization.AllowFilter = false;
            this.gvList.OptionsMenu.EnableColumnMenu = false;
            this.gvList.OptionsMenu.EnableFooterMenu = false;
            this.gvList.OptionsMenu.EnableGroupPanelMenu = false;
            this.gvList.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.False;
            this.gvList.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.gvList.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gvList.OptionsView.ColumnAutoWidth = false;
            this.gvList.OptionsView.EnableAppearanceEvenRow = true;
            this.gvList.OptionsView.EnableAppearanceOddRow = true;
            this.gvList.OptionsView.ShowChildrenInGroupPanel = true;
            this.gvList.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvList.OptionsView.ShowFooter = true;
            this.gvList.OptionsView.ShowGroupedColumns = true;
            this.gvList.OptionsView.ShowGroupPanel = false;
            // 
            // colF_USER_ID
            // 
            this.colF_USER_ID.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_USER_ID.AppearanceCell.Options.UseFont = true;
            this.colF_USER_ID.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_USER_ID.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colF_USER_ID.AppearanceHeader.Options.UseFont = true;
            this.colF_USER_ID.AppearanceHeader.Options.UseForeColor = true;
            this.colF_USER_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_USER_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_USER_ID.Caption = "用户";
            this.colF_USER_ID.FieldName = "F_USER_ID";
            this.colF_USER_ID.Name = "colF_USER_ID";
            this.colF_USER_ID.OptionsColumn.AllowEdit = false;
            this.colF_USER_ID.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colF_USER_ID.Visible = true;
            this.colF_USER_ID.VisibleIndex = 0;
            this.colF_USER_ID.Width = 118;
            // 
            // colF_MODULE_NAME
            // 
            this.colF_MODULE_NAME.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_MODULE_NAME.AppearanceCell.Options.UseFont = true;
            this.colF_MODULE_NAME.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_MODULE_NAME.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colF_MODULE_NAME.AppearanceHeader.Options.UseFont = true;
            this.colF_MODULE_NAME.AppearanceHeader.Options.UseForeColor = true;
            this.colF_MODULE_NAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_MODULE_NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_MODULE_NAME.Caption = "功能模块";
            this.colF_MODULE_NAME.FieldName = "F_MODULE_NAME";
            this.colF_MODULE_NAME.Name = "colF_MODULE_NAME";
            this.colF_MODULE_NAME.OptionsColumn.AllowEdit = false;
            this.colF_MODULE_NAME.Visible = true;
            this.colF_MODULE_NAME.VisibleIndex = 1;
            this.colF_MODULE_NAME.Width = 377;
            // 
            // colF_DATE
            // 
            this.colF_DATE.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_DATE.AppearanceCell.Options.UseFont = true;
            this.colF_DATE.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_DATE.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.colF_DATE.AppearanceHeader.Options.UseFont = true;
            this.colF_DATE.AppearanceHeader.Options.UseForeColor = true;
            this.colF_DATE.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_DATE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_DATE.Caption = "操作时间";
            this.colF_DATE.ColumnEdit = this.repositoryItemDateEdit1;
            this.colF_DATE.FieldName = "F_DATE";
            this.colF_DATE.Name = "colF_DATE";
            this.colF_DATE.OptionsColumn.AllowEdit = false;
            this.colF_DATE.OptionsColumn.AllowFocus = false;
            this.colF_DATE.Visible = true;
            this.colF_DATE.VisibleIndex = 2;
            this.colF_DATE.Width = 143;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "yyyy-MM-dd hh:mm:ss";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // FrmLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 540);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "日志查询";
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lciQueryCondition)).EndInit();
            this.lciQueryCondition.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueUserId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBegin.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgQueryCondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUserID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBeginDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlList)).EndInit();
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraEditors.PanelControl pnlList;
        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvList;
        public DevExpress.XtraGrid.Columns.GridColumn colF_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colF_MODULE_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colF_DATE;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.DateEdit dteBegin;
        private DevExpress.XtraEditors.DateEdit dteEnd;
        private DevExpress.XtraEditors.LookUpEdit lueUserId;
        private DevExpress.XtraLayout.LayoutControl lciQueryCondition;
        private DevExpress.XtraLayout.LayoutControlGroup lcgQueryCondition;
        private DevExpress.XtraLayout.LayoutControlItem lciUserID;
        private DevExpress.XtraLayout.LayoutControlItem lciBeginDate;
        private DevExpress.XtraLayout.LayoutControlItem lciEndDate;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
    }
}