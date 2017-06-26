using RelayTest.Util.Common;

namespace RelayTest.Application.Sys
{
    partial class FrmRoleAuth
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
            this.pnlButtons = new DevExpress.XtraEditors.PanelControl();
            this.btnAuth = new RelayTest.Util.Common.BaseSimpleButton();
            this.pnlMain = new DevExpress.XtraEditors.PanelControl();
            this.lblUser = new DevExpress.XtraEditors.LabelControl();
            this.lueRole = new DevExpress.XtraEditors.LookUpEdit();
            this.gcUsers = new DevExpress.XtraEditors.GroupControl();
            this.chklistAllModules = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.tlModule = new DevExpress.XtraTreeList.TreeList();
            this.colF_MODULE_ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colF_MODULE_NAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colF_DEL = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueRole.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsers)).BeginInit();
            this.gcUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chklistAllModules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnAuth);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 476);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(7);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(794, 59);
            this.pnlButtons.TabIndex = 2;
            // 
            // btnAuth
            // 
            this.btnAuth.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAuth.Appearance.Options.UseFont = true;
            this.btnAuth.Location = new System.Drawing.Point(357, 14);
            this.btnAuth.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(80, 31);
            this.btnAuth.TabIndex = 0;
            this.btnAuth.Text = "授权";
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblUser);
            this.pnlMain.Controls.Add(this.lueRole);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(7);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(794, 42);
            this.pnlMain.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUser.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblUser.Location = new System.Drawing.Point(8, 13);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(70, 14);
            this.lblUser.TabIndex = 20;
            this.lblUser.Text = "选择角色：";
            // 
            // lueRole
            // 
            this.lueRole.Location = new System.Drawing.Point(87, 10);
            this.lueRole.Name = "lueRole";
            this.lueRole.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lueRole.Properties.Appearance.Options.UseFont = true;
            this.lueRole.Properties.AppearanceDropDown.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lueRole.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lueRole.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lueRole.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lueRole.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueRole.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("F_ROLE_ID", "角色编号"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("F_ROLE_NAME", "角色名称")});
            this.lueRole.Properties.NullText = "";
            this.lueRole.Properties.PopupSizeable = false;
            this.lueRole.Size = new System.Drawing.Size(195, 22);
            this.lueRole.TabIndex = 0;
            this.lueRole.EditValueChanged += new System.EventHandler(this.lueUser_EditValueChanged);
            // 
            // gcUsers
            // 
            this.gcUsers.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcUsers.Appearance.Options.UseFont = true;
            this.gcUsers.AppearanceCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gcUsers.AppearanceCaption.Options.UseFont = true;
            this.gcUsers.Controls.Add(this.chklistAllModules);
            this.gcUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcUsers.Location = new System.Drawing.Point(0, 0);
            this.gcUsers.Name = "gcUsers";
            this.gcUsers.Size = new System.Drawing.Size(375, 434);
            this.gcUsers.TabIndex = 4;
            this.gcUsers.Text = "用户";
            // 
            // chklistAllModules
            // 
            this.chklistAllModules.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chklistAllModules.Appearance.Options.UseFont = true;
            this.chklistAllModules.CheckOnClick = true;
            this.chklistAllModules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chklistAllModules.Location = new System.Drawing.Point(2, 24);
            this.chklistAllModules.Name = "chklistAllModules";
            this.chklistAllModules.Size = new System.Drawing.Size(371, 408);
            this.chklistAllModules.TabIndex = 0;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 42);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gcUsers);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.tlModule);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(794, 434);
            this.splitContainerControl1.SplitterPosition = 375;
            this.splitContainerControl1.TabIndex = 5;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // tlModule
            // 
            this.tlModule.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlModule.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.tlModule.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.tlModule.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.tlModule.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.tlModule.Appearance.EvenRow.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlModule.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.tlModule.Appearance.EvenRow.Options.UseBackColor = true;
            this.tlModule.Appearance.EvenRow.Options.UseBorderColor = true;
            this.tlModule.Appearance.EvenRow.Options.UseFont = true;
            this.tlModule.Appearance.EvenRow.Options.UseForeColor = true;
            this.tlModule.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.tlModule.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.tlModule.Appearance.FocusedCell.Options.UseBackColor = true;
            this.tlModule.Appearance.FocusedCell.Options.UseForeColor = true;
            this.tlModule.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(171)))), ((int)(((byte)(177)))));
            this.tlModule.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.tlModule.Appearance.FocusedRow.Options.UseBackColor = true;
            this.tlModule.Appearance.FocusedRow.Options.UseForeColor = true;
            this.tlModule.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.tlModule.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.tlModule.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.tlModule.Appearance.FooterPanel.Options.UseBackColor = true;
            this.tlModule.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.tlModule.Appearance.FooterPanel.Options.UseForeColor = true;
            this.tlModule.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(209)))), ((int)(((byte)(188)))));
            this.tlModule.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(209)))), ((int)(((byte)(188)))));
            this.tlModule.Appearance.GroupButton.Options.UseBackColor = true;
            this.tlModule.Appearance.GroupButton.Options.UseBorderColor = true;
            this.tlModule.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.tlModule.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.tlModule.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.tlModule.Appearance.GroupFooter.Options.UseBackColor = true;
            this.tlModule.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.tlModule.Appearance.GroupFooter.Options.UseForeColor = true;
            this.tlModule.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            this.tlModule.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            this.tlModule.Appearance.HeaderPanel.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tlModule.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.tlModule.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.tlModule.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.tlModule.Appearance.HeaderPanel.Options.UseFont = true;
            this.tlModule.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tlModule.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.tlModule.Appearance.HideSelectionRow.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlModule.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
            this.tlModule.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.tlModule.Appearance.HideSelectionRow.Options.UseFont = true;
            this.tlModule.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.tlModule.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(197)))), ((int)(((byte)(180)))));
            this.tlModule.Appearance.HorzLine.Options.UseBackColor = true;
            this.tlModule.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.tlModule.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.tlModule.Appearance.OddRow.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlModule.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.tlModule.Appearance.OddRow.Options.UseBackColor = true;
            this.tlModule.Appearance.OddRow.Options.UseBorderColor = true;
            this.tlModule.Appearance.OddRow.Options.UseFont = true;
            this.tlModule.Appearance.OddRow.Options.UseForeColor = true;
            this.tlModule.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.tlModule.Appearance.Preview.Font = new System.Drawing.Font("SimSun", 7.5F);
            this.tlModule.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
            this.tlModule.Appearance.Preview.Options.UseBackColor = true;
            this.tlModule.Appearance.Preview.Options.UseFont = true;
            this.tlModule.Appearance.Preview.Options.UseForeColor = true;
            this.tlModule.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.tlModule.Appearance.Row.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tlModule.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.tlModule.Appearance.Row.Options.UseBackColor = true;
            this.tlModule.Appearance.Row.Options.UseFont = true;
            this.tlModule.Appearance.Row.Options.UseForeColor = true;
            this.tlModule.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(201)))), ((int)(((byte)(207)))));
            this.tlModule.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.tlModule.Appearance.SelectedRow.Options.UseBackColor = true;
            this.tlModule.Appearance.SelectedRow.Options.UseForeColor = true;
            this.tlModule.Appearance.TreeLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
            this.tlModule.Appearance.TreeLine.Options.UseBackColor = true;
            this.tlModule.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(197)))), ((int)(((byte)(180)))));
            this.tlModule.Appearance.VertLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
            this.tlModule.Appearance.VertLine.Options.UseBackColor = true;
            this.tlModule.Appearance.VertLine.Options.UseBorderColor = true;
            this.tlModule.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colF_MODULE_ID,
            this.colF_MODULE_NAME,
            this.colF_DEL});
            this.tlModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlModule.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tlModule.KeyFieldName = "F_MODULE_ID";
            this.tlModule.Location = new System.Drawing.Point(0, 0);
            this.tlModule.Margin = new System.Windows.Forms.Padding(4);
            this.tlModule.Name = "tlModule";
            this.tlModule.OptionsBehavior.AutoPopulateColumns = false;
            this.tlModule.OptionsBehavior.PopulateServiceColumns = true;
            this.tlModule.OptionsLayout.AddNewColumns = false;
            this.tlModule.OptionsMenu.EnableColumnMenu = false;
            this.tlModule.OptionsMenu.EnableFooterMenu = false;
            this.tlModule.OptionsView.AutoCalcPreviewLineCount = true;
            this.tlModule.OptionsView.EnableAppearanceEvenRow = true;
            this.tlModule.OptionsView.EnableAppearanceOddRow = true;
            this.tlModule.OptionsView.ExpandButtonCentered = false;
            this.tlModule.OptionsView.ShowButtons = false;
            this.tlModule.OptionsView.ShowIndentAsRowStyle = true;
            this.tlModule.OptionsView.ShowVertLines = false;
            this.tlModule.ParentFieldName = "F_PARENT_MODULE_ID";
            this.tlModule.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.tlModule.Size = new System.Drawing.Size(413, 434);
            this.tlModule.TabIndex = 0;
            this.tlModule.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.Dark;
            // 
            // colF_MODULE_ID
            // 
            this.colF_MODULE_ID.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colF_MODULE_ID.AppearanceCell.Options.UseFont = true;
            this.colF_MODULE_ID.AppearanceCell.Options.UseTextOptions = true;
            this.colF_MODULE_ID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_MODULE_ID.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colF_MODULE_ID.AppearanceHeader.Options.UseFont = true;
            this.colF_MODULE_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_MODULE_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_MODULE_ID.Caption = "编码";
            this.colF_MODULE_ID.FieldName = "F_MODULE_ID";
            this.colF_MODULE_ID.Name = "colF_MODULE_ID";
            this.colF_MODULE_ID.OptionsColumn.AllowEdit = false;
            this.colF_MODULE_ID.OptionsColumn.AllowFocus = false;
            this.colF_MODULE_ID.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.colF_MODULE_ID.Visible = true;
            this.colF_MODULE_ID.VisibleIndex = 0;
            this.colF_MODULE_ID.Width = 112;
            // 
            // colF_MODULE_NAME
            // 
            this.colF_MODULE_NAME.AllNodesSummary = true;
            this.colF_MODULE_NAME.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.colF_MODULE_NAME.AppearanceCell.Options.UseFont = true;
            this.colF_MODULE_NAME.AppearanceCell.Options.UseTextOptions = true;
            this.colF_MODULE_NAME.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colF_MODULE_NAME.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colF_MODULE_NAME.AppearanceHeader.Options.UseFont = true;
            this.colF_MODULE_NAME.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_MODULE_NAME.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_MODULE_NAME.Caption = "模块名称";
            this.colF_MODULE_NAME.FieldName = "F_MODULE_NAME";
            this.colF_MODULE_NAME.Name = "colF_MODULE_NAME";
            this.colF_MODULE_NAME.OptionsColumn.AllowEdit = false;
            this.colF_MODULE_NAME.OptionsColumn.AllowFocus = false;
            this.colF_MODULE_NAME.Visible = true;
            this.colF_MODULE_NAME.VisibleIndex = 1;
            this.colF_MODULE_NAME.Width = 161;
            // 
            // colF_DEL
            // 
            this.colF_DEL.AppearanceCell.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colF_DEL.AppearanceCell.Options.UseFont = true;
            this.colF_DEL.AppearanceHeader.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colF_DEL.AppearanceHeader.Options.UseFont = true;
            this.colF_DEL.AppearanceHeader.Options.UseTextOptions = true;
            this.colF_DEL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colF_DEL.Caption = "授权";
            this.colF_DEL.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colF_DEL.FieldName = "F_DEL";
            this.colF_DEL.Name = "colF_DEL";
            this.colF_DEL.Visible = true;
            this.colF_DEL.VisibleIndex = 2;
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
            // FrmRoleAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(794, 535);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlButtons);
            this.Name = "FrmRoleAuth";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "权限管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAuth_FormClosing);
            this.Load += new System.EventHandler(this.FrmAuth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueRole.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcUsers)).EndInit();
            this.gcUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chklistAllModules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlButtons;
        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraEditors.LabelControl lblUser;
        private DevExpress.XtraEditors.LookUpEdit lueRole;
        private DevExpress.XtraEditors.GroupControl gcUsers;
        private DevExpress.XtraEditors.CheckedListBoxControl chklistAllModules;
        private BaseSimpleButton btnAuth;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTreeList.TreeList tlModule;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colF_MODULE_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colF_MODULE_NAME;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colF_DEL;
    }
}