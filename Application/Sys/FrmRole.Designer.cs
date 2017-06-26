namespace RelayTest.Application.Sys
{
    partial class FrmRole
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
            this.pnlBottons = new DevExpress.XtraEditors.PanelControl();
            this.btnExport = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnDelete = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnSave = new RelayTest.Util.Common.BaseSimpleButton();
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.lcDetail = new DevExpress.XtraLayout.LayoutControl();
            this.txtF_ROLE_ID = new DevExpress.XtraEditors.TextEdit();
            this.txtF_ROLE_NAME = new DevExpress.XtraEditors.TextEdit();
            this.txtF_DESC = new DevExpress.XtraEditors.MemoEdit();
            this.lcgDetail = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciF_ROLE_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_ROLE_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_DESC = new DevExpress.XtraLayout.LayoutControlItem();
            this.pnlList = new DevExpress.XtraEditors.PanelControl();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colF_ROLE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_ROLE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_DESC = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottons)).BeginInit();
            this.pnlBottons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcDetail)).BeginInit();
            this.lcDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_ROLE_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_ROLE_NAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_DESC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_ROLE_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_ROLE_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_DESC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlList)).BeginInit();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = 1;
            this.repositoryItemCheckEdit1.ValueUnchecked = 0;
            // 
            // pnlBottons
            // 
            this.pnlBottons.Controls.Add(this.btnExport);
            this.pnlBottons.Controls.Add(this.btnDelete);
            this.pnlBottons.Controls.Add(this.btnSave);
            this.pnlBottons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottons.Location = new System.Drawing.Point(0, 448);
            this.pnlBottons.Name = "pnlBottons";
            this.pnlBottons.Size = new System.Drawing.Size(794, 58);
            this.pnlBottons.TabIndex = 1;
            // 
            // btnExport
            // 
            this.btnExport.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.Location = new System.Drawing.Point(447, 14);
            this.btnExport.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(80, 31);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "导出";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Location = new System.Drawing.Point(356, 14);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 31);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(269, 14);
            this.btnSave.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.lcDetail);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEdit.Location = new System.Drawing.Point(0, 305);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(794, 143);
            this.pnlEdit.TabIndex = 0;
            // 
            // lcDetail
            // 
            this.lcDetail.Controls.Add(this.txtF_ROLE_ID);
            this.lcDetail.Controls.Add(this.txtF_ROLE_NAME);
            this.lcDetail.Controls.Add(this.txtF_DESC);
            this.lcDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcDetail.Location = new System.Drawing.Point(2, 2);
            this.lcDetail.Name = "lcDetail";
            this.lcDetail.Root = this.lcgDetail;
            this.lcDetail.Size = new System.Drawing.Size(790, 139);
            this.lcDetail.TabIndex = 0;
            this.lcDetail.Text = "layoutControl1";
            // 
            // txtF_ROLE_ID
            // 
            this.txtF_ROLE_ID.Location = new System.Drawing.Point(184, 12);
            this.txtF_ROLE_ID.Name = "txtF_ROLE_ID";
            this.txtF_ROLE_ID.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtF_ROLE_ID.Properties.Appearance.Options.UseFont = true;
            this.txtF_ROLE_ID.Properties.Mask.EditMask = "d";
            this.txtF_ROLE_ID.Size = new System.Drawing.Size(206, 25);
            this.txtF_ROLE_ID.StyleController = this.lcDetail;
            this.txtF_ROLE_ID.TabIndex = 0;
            // 
            // txtF_ROLE_NAME
            // 
            this.txtF_ROLE_NAME.Location = new System.Drawing.Point(479, 12);
            this.txtF_ROLE_NAME.Name = "txtF_ROLE_NAME";
            this.txtF_ROLE_NAME.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtF_ROLE_NAME.Properties.Appearance.Options.UseFont = true;
            this.txtF_ROLE_NAME.Properties.Mask.EditMask = "d";
            this.txtF_ROLE_NAME.Size = new System.Drawing.Size(206, 25);
            this.txtF_ROLE_NAME.StyleController = this.lcDetail;
            this.txtF_ROLE_NAME.TabIndex = 1;
            // 
            // txtF_DESC
            // 
            this.txtF_DESC.Location = new System.Drawing.Point(184, 41);
            this.txtF_DESC.Name = "txtF_DESC";
            this.txtF_DESC.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtF_DESC.Properties.Appearance.Options.UseFont = true;
            this.txtF_DESC.Size = new System.Drawing.Size(501, 86);
            this.txtF_DESC.StyleController = this.lcDetail;
            this.txtF_DESC.TabIndex = 2;
            // 
            // lcgDetail
            // 
            this.lcgDetail.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcgDetail.AppearanceItemCaption.Options.UseFont = true;
            this.lcgDetail.CustomizationFormText = "lcgDetail";
            this.lcgDetail.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgDetail.GroupBordersVisible = false;
            this.lcgDetail.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciF_ROLE_ID,
            this.lciF_ROLE_NAME,
            this.lciF_DESC});
            this.lcgDetail.Location = new System.Drawing.Point(0, 0);
            this.lcgDetail.Name = "lcgDetail";
            this.lcgDetail.Padding = new DevExpress.XtraLayout.Utils.Padding(100, 100, 10, 10);
            this.lcgDetail.Size = new System.Drawing.Size(790, 139);
            this.lcgDetail.Text = "lcgDetail";
            this.lcgDetail.TextVisible = false;
            // 
            // lciF_ROLE_ID
            // 
            this.lciF_ROLE_ID.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_ROLE_ID.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_ROLE_ID.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_ROLE_ID.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_ROLE_ID.Control = this.txtF_ROLE_ID;
            this.lciF_ROLE_ID.CustomizationFormText = "角色编号：";
            this.lciF_ROLE_ID.Location = new System.Drawing.Point(0, 0);
            this.lciF_ROLE_ID.Name = "lciF_ROLE_ID";
            this.lciF_ROLE_ID.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.lciF_ROLE_ID.Size = new System.Drawing.Size(295, 29);
            this.lciF_ROLE_ID.Text = "角色编号：";
            this.lciF_ROLE_ID.TextSize = new System.Drawing.Size(75, 14);
            // 
            // lciF_ROLE_NAME
            // 
            this.lciF_ROLE_NAME.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_ROLE_NAME.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_ROLE_NAME.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_ROLE_NAME.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_ROLE_NAME.Control = this.txtF_ROLE_NAME;
            this.lciF_ROLE_NAME.CustomizationFormText = "角色名称：";
            this.lciF_ROLE_NAME.Location = new System.Drawing.Point(295, 0);
            this.lciF_ROLE_NAME.Name = "lciF_ROLE_NAME";
            this.lciF_ROLE_NAME.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.lciF_ROLE_NAME.Size = new System.Drawing.Size(295, 29);
            this.lciF_ROLE_NAME.Text = "角色名称：";
            this.lciF_ROLE_NAME.TextSize = new System.Drawing.Size(75, 14);
            // 
            // lciF_DESC
            // 
            this.lciF_DESC.Control = this.txtF_DESC;
            this.lciF_DESC.CustomizationFormText = "描述：";
            this.lciF_DESC.Location = new System.Drawing.Point(0, 29);
            this.lciF_DESC.Name = "lciF_DESC";
            this.lciF_DESC.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 2, 2);
            this.lciF_DESC.Size = new System.Drawing.Size(590, 90);
            this.lciF_DESC.Text = "描述：";
            this.lciF_DESC.TextSize = new System.Drawing.Size(75, 14);
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.gcList);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.Location = new System.Drawing.Point(0, 0);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(794, 305);
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
            this.repositoryItemCheckEdit1});
            this.gcList.Size = new System.Drawing.Size(790, 301);
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
            this.colF_ROLE_ID,
            this.colF_ROLE_NAME,
            this.colF_DESC});
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
            this.gvList.OptionsView.ShowGroupedColumns = true;
            this.gvList.OptionsView.ShowGroupPanel = false;
            this.gvList.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvList_RowClick);
            // 
            // colF_ROLE_ID
            // 
            this.colF_ROLE_ID.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colF_ROLE_ID.AppearanceCell.Options.UseFont = true;
            this.colF_ROLE_ID.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colF_ROLE_ID.AppearanceHeader.Options.UseFont = true;
            this.colF_ROLE_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_ROLE_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_ROLE_ID.Caption = "角色编号";
            this.colF_ROLE_ID.FieldName = "F_ROLE_ID";
            this.colF_ROLE_ID.Name = "colF_ROLE_ID";
            this.colF_ROLE_ID.OptionsColumn.AllowEdit = false;
            this.colF_ROLE_ID.OptionsColumn.AllowFocus = false;
            this.colF_ROLE_ID.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colF_ROLE_ID.Visible = true;
            this.colF_ROLE_ID.VisibleIndex = 0;
            this.colF_ROLE_ID.Width = 118;
            // 
            // colF_ROLE_NAME
            // 
            this.colF_ROLE_NAME.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colF_ROLE_NAME.AppearanceCell.Options.UseFont = true;
            this.colF_ROLE_NAME.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colF_ROLE_NAME.AppearanceHeader.Options.UseFont = true;
            this.colF_ROLE_NAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_ROLE_NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_ROLE_NAME.Caption = "角色名称";
            this.colF_ROLE_NAME.FieldName = "F_ROLE_NAME";
            this.colF_ROLE_NAME.Name = "colF_ROLE_NAME";
            this.colF_ROLE_NAME.OptionsColumn.AllowEdit = false;
            this.colF_ROLE_NAME.OptionsColumn.AllowFocus = false;
            this.colF_ROLE_NAME.Visible = true;
            this.colF_ROLE_NAME.VisibleIndex = 1;
            this.colF_ROLE_NAME.Width = 124;
            // 
            // colF_DESC
            // 
            this.colF_DESC.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colF_DESC.AppearanceCell.Options.UseFont = true;
            this.colF_DESC.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colF_DESC.AppearanceHeader.Options.UseFont = true;
            this.colF_DESC.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_DESC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_DESC.Caption = "描述";
            this.colF_DESC.FieldName = "F_DESC";
            this.colF_DESC.Name = "colF_DESC";
            this.colF_DESC.OptionsColumn.AllowEdit = false;
            this.colF_DESC.OptionsColumn.AllowFocus = false;
            this.colF_DESC.Visible = true;
            this.colF_DESC.VisibleIndex = 2;
            // 
            // FrmRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 506);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlBottons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "角色管理";
            this.Load += new System.EventHandler(this.FrmRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottons)).EndInit();
            this.pnlBottons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcDetail)).EndInit();
            this.lcDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtF_ROLE_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_ROLE_NAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_DESC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_ROLE_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_ROLE_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_DESC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlList)).EndInit();
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlBottons;
        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraEditors.PanelControl pnlList;
        private DevExpress.XtraEditors.TextEdit txtF_ROLE_ID;
        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvList;
        public DevExpress.XtraGrid.Columns.GridColumn colF_ROLE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colF_ROLE_NAME;
        private DevExpress.XtraEditors.TextEdit txtF_ROLE_NAME;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private Util.Common.BaseSimpleButton btnExport;
        private Util.Common.BaseSimpleButton btnDelete;
        private Util.Common.BaseSimpleButton btnSave;
        private DevExpress.XtraGrid.Columns.GridColumn colF_DESC;
        private DevExpress.XtraEditors.MemoEdit txtF_DESC;
        private DevExpress.XtraLayout.LayoutControl lcDetail;
        private DevExpress.XtraLayout.LayoutControlGroup lcgDetail;
        private DevExpress.XtraLayout.LayoutControlItem lciF_ROLE_ID;
        private DevExpress.XtraLayout.LayoutControlItem lciF_ROLE_NAME;
        private DevExpress.XtraLayout.LayoutControlItem lciF_DESC;
    }
}