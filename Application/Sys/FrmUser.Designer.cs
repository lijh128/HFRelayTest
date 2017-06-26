namespace RelayTest.Application.Sys
{
    partial class FrmUser
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
            this.colF_DEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnRestore = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDisable = new DevExpress.XtraEditors.SimpleButton();
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.lcDetail = new DevExpress.XtraLayout.LayoutControl();
            this.chkF_ISSWJ = new DevExpress.XtraEditors.CheckEdit();
            this.txtRepeatPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtF_USER_ID = new DevExpress.XtraEditors.TextEdit();
            this.txtF_USER_NAME = new DevExpress.XtraEditors.TextEdit();
            this.txtF_PHONE = new DevExpress.XtraEditors.TextEdit();
            this.txtF_PASSWORD = new DevExpress.XtraEditors.TextEdit();
            this.lcgDetail = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciF_USER_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciRepeatPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_PHONE = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_PASSWORD = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_USER_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.pnlList = new DevExpress.XtraEditors.PanelControl();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colF_USER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_USER_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_PHONE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colF_ISSWJ = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcDetail)).BeginInit();
            this.lcDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkF_ISSWJ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepeatPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_USER_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_USER_NAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_PHONE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_PASSWORD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_USER_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRepeatPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_PHONE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_PASSWORD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_USER_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlList)).BeginInit();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            this.SuspendLayout();
            // 
            // colF_DEL
            // 
            this.colF_DEL.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_DEL.AppearanceCell.Options.UseFont = true;
            this.colF_DEL.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_DEL.AppearanceHeader.Options.UseFont = true;
            this.colF_DEL.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_DEL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_DEL.Caption = "已禁用";
            this.colF_DEL.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colF_DEL.FieldName = "F_DEL";
            this.colF_DEL.Name = "colF_DEL";
            this.colF_DEL.OptionsColumn.AllowEdit = false;
            this.colF_DEL.OptionsColumn.AllowFocus = false;
            this.colF_DEL.Visible = true;
            this.colF_DEL.VisibleIndex = 4;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemCheckEdit1.ValueUnchecked = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnExport);
            this.pnlBottom.Controls.Add(this.btnRestore);
            this.pnlBottom.Controls.Add(this.btnSave);
            this.pnlBottom.Controls.Add(this.btnDisable);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 483);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(804, 59);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnExport
            // 
            this.btnExport.Appearance.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.Location = new System.Drawing.Point(491, 15);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(80, 29);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "导出";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Appearance.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.Appearance.Options.UseFont = true;
            this.btnRestore.Location = new System.Drawing.Point(321, 15);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(80, 29);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "启用";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(234, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.Appearance.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisable.Appearance.Options.UseFont = true;
            this.btnDisable.Location = new System.Drawing.Point(406, 15);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(80, 29);
            this.btnDisable.TabIndex = 2;
            this.btnDisable.Text = "禁用";
            this.btnDisable.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.lcDetail);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEdit.Location = new System.Drawing.Point(0, 378);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(804, 105);
            this.pnlEdit.TabIndex = 0;
            // 
            // lcDetail
            // 
            this.lcDetail.Controls.Add(this.chkF_ISSWJ);
            this.lcDetail.Controls.Add(this.txtRepeatPassword);
            this.lcDetail.Controls.Add(this.txtF_USER_ID);
            this.lcDetail.Controls.Add(this.txtF_USER_NAME);
            this.lcDetail.Controls.Add(this.txtF_PHONE);
            this.lcDetail.Controls.Add(this.txtF_PASSWORD);
            this.lcDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcDetail.Location = new System.Drawing.Point(2, 2);
            this.lcDetail.Name = "lcDetail";
            this.lcDetail.Root = this.lcgDetail;
            this.lcDetail.Size = new System.Drawing.Size(800, 101);
            this.lcDetail.TabIndex = 0;
            this.lcDetail.Text = "layoutControl1";
            // 
            // chkF_ISSWJ
            // 
            this.chkF_ISSWJ.Location = new System.Drawing.Point(403, 64);
            this.chkF_ISSWJ.Name = "chkF_ISSWJ";
            this.chkF_ISSWJ.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkF_ISSWJ.Properties.Appearance.Options.UseFont = true;
            this.chkF_ISSWJ.Properties.Caption = "是上位机用户";
            this.chkF_ISSWJ.Properties.ValueChecked = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.chkF_ISSWJ.Properties.ValueUnchecked = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.chkF_ISSWJ.Size = new System.Drawing.Size(295, 19);
            this.chkF_ISSWJ.StyleController = this.lcDetail;
            this.chkF_ISSWJ.TabIndex = 5;
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.Location = new System.Drawing.Point(482, 38);
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRepeatPassword.Properties.Appearance.Options.UseFont = true;
            this.txtRepeatPassword.Properties.PasswordChar = '*';
            this.txtRepeatPassword.Size = new System.Drawing.Size(216, 22);
            this.txtRepeatPassword.StyleController = this.lcDetail;
            this.txtRepeatPassword.TabIndex = 3;
            // 
            // txtF_USER_ID
            // 
            this.txtF_USER_ID.Location = new System.Drawing.Point(181, 12);
            this.txtF_USER_ID.Name = "txtF_USER_ID";
            this.txtF_USER_ID.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_USER_ID.Properties.Appearance.Options.UseFont = true;
            this.txtF_USER_ID.Properties.Mask.EditMask = "d";
            this.txtF_USER_ID.Size = new System.Drawing.Size(218, 22);
            this.txtF_USER_ID.StyleController = this.lcDetail;
            this.txtF_USER_ID.TabIndex = 0;
            // 
            // txtF_USER_NAME
            // 
            this.txtF_USER_NAME.Location = new System.Drawing.Point(482, 12);
            this.txtF_USER_NAME.Name = "txtF_USER_NAME";
            this.txtF_USER_NAME.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_USER_NAME.Properties.Appearance.Options.UseFont = true;
            this.txtF_USER_NAME.Size = new System.Drawing.Size(216, 22);
            this.txtF_USER_NAME.StyleController = this.lcDetail;
            this.txtF_USER_NAME.TabIndex = 2;
            // 
            // txtF_PHONE
            // 
            this.txtF_PHONE.Location = new System.Drawing.Point(181, 64);
            this.txtF_PHONE.Name = "txtF_PHONE";
            this.txtF_PHONE.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_PHONE.Properties.Appearance.Options.UseFont = true;
            this.txtF_PHONE.Properties.Mask.EditMask = "d";
            this.txtF_PHONE.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtF_PHONE.Size = new System.Drawing.Size(218, 22);
            this.txtF_PHONE.StyleController = this.lcDetail;
            this.txtF_PHONE.TabIndex = 4;
            // 
            // txtF_PASSWORD
            // 
            this.txtF_PASSWORD.Location = new System.Drawing.Point(181, 38);
            this.txtF_PASSWORD.Name = "txtF_PASSWORD";
            this.txtF_PASSWORD.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_PASSWORD.Properties.Appearance.Options.UseFont = true;
            this.txtF_PASSWORD.Properties.Mask.EditMask = "d";
            this.txtF_PASSWORD.Properties.PasswordChar = '*';
            this.txtF_PASSWORD.Size = new System.Drawing.Size(218, 22);
            this.txtF_PASSWORD.StyleController = this.lcDetail;
            this.txtF_PASSWORD.TabIndex = 1;
            // 
            // lcgDetail
            // 
            this.lcgDetail.CustomizationFormText = "lcgDetail";
            this.lcgDetail.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgDetail.GroupBordersVisible = false;
            this.lcgDetail.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciF_USER_ID,
            this.lciRepeatPassword,
            this.lciF_PHONE,
            this.lciF_PASSWORD,
            this.lciF_USER_NAME,
            this.layoutControlItem1});
            this.lcgDetail.Location = new System.Drawing.Point(0, 0);
            this.lcgDetail.Name = "lcgDetail";
            this.lcgDetail.Padding = new DevExpress.XtraLayout.Utils.Padding(100, 100, 10, 10);
            this.lcgDetail.Size = new System.Drawing.Size(800, 101);
            this.lcgDetail.Text = "lcgDetail";
            this.lcgDetail.TextVisible = false;
            // 
            // lciF_USER_ID
            // 
            this.lciF_USER_ID.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lciF_USER_ID.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_USER_ID.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_USER_ID.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_USER_ID.Control = this.txtF_USER_ID;
            this.lciF_USER_ID.CustomizationFormText = "登录名：";
            this.lciF_USER_ID.Location = new System.Drawing.Point(0, 0);
            this.lciF_USER_ID.Name = "lciF_USER_ID";
            this.lciF_USER_ID.Size = new System.Drawing.Size(301, 26);
            this.lciF_USER_ID.Text = "登录名：";
            this.lciF_USER_ID.TextSize = new System.Drawing.Size(75, 14);
            // 
            // lciRepeatPassword
            // 
            this.lciRepeatPassword.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lciRepeatPassword.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciRepeatPassword.AppearanceItemCaption.Options.UseFont = true;
            this.lciRepeatPassword.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciRepeatPassword.Control = this.txtRepeatPassword;
            this.lciRepeatPassword.CustomizationFormText = "重复密码：";
            this.lciRepeatPassword.Location = new System.Drawing.Point(301, 26);
            this.lciRepeatPassword.Name = "lciRepeatPassword";
            this.lciRepeatPassword.Size = new System.Drawing.Size(299, 26);
            this.lciRepeatPassword.Text = "重复密码：";
            this.lciRepeatPassword.TextSize = new System.Drawing.Size(75, 14);
            // 
            // lciF_PHONE
            // 
            this.lciF_PHONE.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_PHONE.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_PHONE.Control = this.txtF_PHONE;
            this.lciF_PHONE.CustomizationFormText = "联系电话：";
            this.lciF_PHONE.Location = new System.Drawing.Point(0, 52);
            this.lciF_PHONE.Name = "lciF_PHONE";
            this.lciF_PHONE.Size = new System.Drawing.Size(301, 29);
            this.lciF_PHONE.Text = "联系电话：";
            this.lciF_PHONE.TextSize = new System.Drawing.Size(75, 14);
            // 
            // lciF_PASSWORD
            // 
            this.lciF_PASSWORD.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lciF_PASSWORD.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_PASSWORD.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_PASSWORD.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_PASSWORD.Control = this.txtF_PASSWORD;
            this.lciF_PASSWORD.CustomizationFormText = "密码：";
            this.lciF_PASSWORD.Location = new System.Drawing.Point(0, 26);
            this.lciF_PASSWORD.Name = "lciF_PASSWORD";
            this.lciF_PASSWORD.Size = new System.Drawing.Size(301, 26);
            this.lciF_PASSWORD.Text = "密码：";
            this.lciF_PASSWORD.TextSize = new System.Drawing.Size(75, 14);
            // 
            // lciF_USER_NAME
            // 
            this.lciF_USER_NAME.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lciF_USER_NAME.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_USER_NAME.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_USER_NAME.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_USER_NAME.Control = this.txtF_USER_NAME;
            this.lciF_USER_NAME.CustomizationFormText = "密码：";
            this.lciF_USER_NAME.Location = new System.Drawing.Point(301, 0);
            this.lciF_USER_NAME.Name = "lciF_USER_NAME";
            this.lciF_USER_NAME.Size = new System.Drawing.Size(299, 26);
            this.lciF_USER_NAME.Text = "姓名：";
            this.lciF_USER_NAME.TextSize = new System.Drawing.Size(75, 14);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.chkF_ISSWJ;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(301, 52);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(299, 29);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.gcList);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.Location = new System.Drawing.Point(0, 0);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(804, 378);
            this.pnlList.TabIndex = 4;
            // 
            // gcList
            // 
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gcList.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcList.Location = new System.Drawing.Point(2, 2);
            this.gcList.MainView = this.gvList;
            this.gcList.Name = "gcList";
            this.gcList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gcList.Size = new System.Drawing.Size(800, 374);
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
            this.colF_USER_NAME,
            this.colF_PHONE,
            this.colF_ISSWJ,
            this.colF_DEL});
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
            this.gvList.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvList_RowClick);
            // 
            // colF_USER_ID
            // 
            this.colF_USER_ID.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_USER_ID.AppearanceCell.Options.UseFont = true;
            this.colF_USER_ID.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_USER_ID.AppearanceHeader.Options.UseFont = true;
            this.colF_USER_ID.Caption = "登录名";
            this.colF_USER_ID.FieldName = "F_USER_ID";
            this.colF_USER_ID.Name = "colF_USER_ID";
            this.colF_USER_ID.OptionsColumn.AllowEdit = false;
            this.colF_USER_ID.OptionsColumn.AllowFocus = false;
            this.colF_USER_ID.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colF_USER_ID.Visible = true;
            this.colF_USER_ID.VisibleIndex = 0;
            this.colF_USER_ID.Width = 118;
            // 
            // colF_USER_NAME
            // 
            this.colF_USER_NAME.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_USER_NAME.AppearanceCell.Options.UseFont = true;
            this.colF_USER_NAME.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_USER_NAME.AppearanceHeader.Options.UseFont = true;
            this.colF_USER_NAME.Caption = "姓名";
            this.colF_USER_NAME.FieldName = "F_USER_NAME";
            this.colF_USER_NAME.Name = "colF_USER_NAME";
            this.colF_USER_NAME.OptionsColumn.AllowEdit = false;
            this.colF_USER_NAME.OptionsColumn.AllowFocus = false;
            this.colF_USER_NAME.Visible = true;
            this.colF_USER_NAME.VisibleIndex = 1;
            this.colF_USER_NAME.Width = 124;
            // 
            // colF_PHONE
            // 
            this.colF_PHONE.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_PHONE.AppearanceCell.Options.UseFont = true;
            this.colF_PHONE.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_PHONE.AppearanceHeader.Options.UseFont = true;
            this.colF_PHONE.Caption = "联系电话";
            this.colF_PHONE.FieldName = "F_PHONE";
            this.colF_PHONE.Name = "colF_PHONE";
            this.colF_PHONE.OptionsColumn.AllowEdit = false;
            this.colF_PHONE.OptionsColumn.AllowFocus = false;
            this.colF_PHONE.Visible = true;
            this.colF_PHONE.VisibleIndex = 2;
            this.colF_PHONE.Width = 143;
            // 
            // colF_ISSWJ
            // 
            this.colF_ISSWJ.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_ISSWJ.AppearanceCell.Options.UseFont = true;
            this.colF_ISSWJ.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F);
            this.colF_ISSWJ.AppearanceHeader.Options.UseFont = true;
            this.colF_ISSWJ.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_ISSWJ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_ISSWJ.Caption = "上位机用户";
            this.colF_ISSWJ.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colF_ISSWJ.FieldName = "F_ISSWJ";
            this.colF_ISSWJ.Name = "colF_ISSWJ";
            this.colF_ISSWJ.OptionsColumn.AllowEdit = false;
            this.colF_ISSWJ.OptionsColumn.AllowFocus = false;
            this.colF_ISSWJ.Visible = true;
            this.colF_ISSWJ.VisibleIndex = 3;
            this.colF_ISSWJ.Width = 175;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 542);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlBottom);
            this.Name = "FrmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcDetail)).EndInit();
            this.lcDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chkF_ISSWJ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepeatPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_USER_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_USER_NAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_PHONE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_PASSWORD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_USER_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRepeatPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_PHONE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_PASSWORD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_USER_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlList)).EndInit();
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDisable;
        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraEditors.PanelControl pnlList;
        private DevExpress.XtraEditors.TextEdit txtF_USER_NAME;
        private DevExpress.XtraEditors.TextEdit txtF_USER_ID;
        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvList;
        public DevExpress.XtraGrid.Columns.GridColumn colF_USER_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colF_USER_NAME;
        private DevExpress.XtraEditors.TextEdit txtRepeatPassword;
        private DevExpress.XtraEditors.TextEdit txtF_PASSWORD;
        private DevExpress.XtraEditors.TextEdit txtF_PHONE;
        private DevExpress.XtraGrid.Columns.GridColumn colF_PHONE;
        private DevExpress.XtraEditors.SimpleButton btnRestore;
        private DevExpress.XtraGrid.Columns.GridColumn colF_DEL;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraLayout.LayoutControl lcDetail;
        private DevExpress.XtraLayout.LayoutControlGroup lcgDetail;
        private DevExpress.XtraLayout.LayoutControlItem lciF_USER_ID;
        private DevExpress.XtraLayout.LayoutControlItem lciF_PASSWORD;
        private DevExpress.XtraLayout.LayoutControlItem lciF_USER_NAME;
        private DevExpress.XtraLayout.LayoutControlItem lciRepeatPassword;
        private DevExpress.XtraLayout.LayoutControlItem lciF_PHONE;
        private DevExpress.XtraEditors.CheckEdit chkF_ISSWJ;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colF_ISSWJ;
    }
}