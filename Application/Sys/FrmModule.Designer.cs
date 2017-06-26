using RelayTest.Application.Controls;
using RelayTest.Util.Common;

namespace RelayTest.Application.Sys
{
    partial class FrmModule
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
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.tlModule = new DevExpress.XtraTreeList.TreeList();
            this.colF_MODULE_ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colF_MODULE_NAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.lcDetail = new DevExpress.XtraLayout.LayoutControl();
            this.txtF_MODULE_ID = new RelayTest.Util.Common.BaseTextEdit();
            this.chkF_ISADMINONLY = new DevExpress.XtraEditors.CheckEdit();
            this.txtF_MODULE_NAME = new RelayTest.Util.Common.BaseTextEdit();
            this.txtF_PARENT_MODULE_ID = new RelayTest.Util.Common.BaseTextEdit();
            this.txtModuleForm = new RelayTest.Util.Common.BaseTextEdit();
            this.txtF_ACTION = new RelayTest.Util.Common.BaseTextEdit();
            this.txtF_ORDNO = new RelayTest.Util.Common.BaseTextEdit();
            this.lcgDetail = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciF_MODULE_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_MODULE_NAME = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_PARENT_MODULE_ID = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_ACTION = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_ORDNO = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciF_ISADMINONLY = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.pnlButtons = new DevExpress.XtraEditors.PanelControl();
            this.btnExport = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnDelete = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnSave = new RelayTest.Util.Common.BaseSimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcDetail)).BeginInit();
            this.lcDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_MODULE_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkF_ISADMINONLY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_MODULE_NAME.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_PARENT_MODULE_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModuleForm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_ACTION.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_ORDNO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_MODULE_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_MODULE_NAME)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_PARENT_MODULE_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_ACTION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_ORDNO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_ISADMINONLY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcMain
            // 
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.IsSplitterFixed = true;
            this.spcMain.Location = new System.Drawing.Point(0, 0);
            this.spcMain.Name = "spcMain";
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Controls.Add(this.tlModule);
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.lcDetail);
            this.spcMain.Size = new System.Drawing.Size(794, 469);
            this.spcMain.SplitterDistance = 375;
            this.spcMain.TabIndex = 0;
            // 
            // tlModule
            // 
            this.tlModule.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlModule.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.tlModule.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.tlModule.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
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
            this.tlModule.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.tlModule.Appearance.OddRow.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlModule.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
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
            this.colF_MODULE_NAME});
            this.tlModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlModule.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tlModule.KeyFieldName = "F_MODULEID";
            this.tlModule.Location = new System.Drawing.Point(0, 0);
            this.tlModule.Margin = new System.Windows.Forms.Padding(4);
            this.tlModule.Name = "tlModule";
            this.tlModule.OptionsBehavior.AutoPopulateColumns = false;
            this.tlModule.OptionsBehavior.Editable = false;
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
            this.tlModule.ParentFieldName = "F_PARENTID";
            this.tlModule.Size = new System.Drawing.Size(375, 469);
            this.tlModule.TabIndex = 0;
            this.tlModule.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.Dark;
            this.tlModule.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tlModule_FocusedNodeChanged);
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
            this.colF_MODULE_NAME.Visible = true;
            this.colF_MODULE_NAME.VisibleIndex = 1;
            this.colF_MODULE_NAME.Width = 161;
            // 
            // lcDetail
            // 
            this.lcDetail.Controls.Add(this.txtF_MODULE_ID);
            this.lcDetail.Controls.Add(this.chkF_ISADMINONLY);
            this.lcDetail.Controls.Add(this.txtF_MODULE_NAME);
            this.lcDetail.Controls.Add(this.txtF_PARENT_MODULE_ID);
            this.lcDetail.Controls.Add(this.txtModuleForm);
            this.lcDetail.Controls.Add(this.txtF_ACTION);
            this.lcDetail.Controls.Add(this.txtF_ORDNO);
            this.lcDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcDetail.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcDetail.Location = new System.Drawing.Point(0, 0);
            this.lcDetail.Name = "lcDetail";
            this.lcDetail.Root = this.lcgDetail;
            this.lcDetail.Size = new System.Drawing.Size(415, 469);
            this.lcDetail.TabIndex = 0;
            this.lcDetail.Text = "layoutControl1";
            // 
            // txtF_MODULE_ID
            // 
            this.txtF_MODULE_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtF_MODULE_ID.Location = new System.Drawing.Point(116, 60);
            this.txtF_MODULE_ID.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.txtF_MODULE_ID.Name = "txtF_MODULE_ID";
            this.txtF_MODULE_ID.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_MODULE_ID.Properties.Appearance.Options.UseFont = true;
            this.txtF_MODULE_ID.Size = new System.Drawing.Size(277, 22);
            this.txtF_MODULE_ID.StyleController = this.lcDetail;
            this.txtF_MODULE_ID.TabIndex = 0;
            // 
            // chkF_ISADMINONLY
            // 
            this.chkF_ISADMINONLY.Location = new System.Drawing.Point(116, 304);
            this.chkF_ISADMINONLY.Name = "chkF_ISADMINONLY";
            this.chkF_ISADMINONLY.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkF_ISADMINONLY.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.chkF_ISADMINONLY.Properties.Appearance.Options.UseFont = true;
            this.chkF_ISADMINONLY.Properties.Appearance.Options.UseForeColor = true;
            this.chkF_ISADMINONLY.Properties.Caption = "只有管理员可以执行";
            this.chkF_ISADMINONLY.Size = new System.Drawing.Size(277, 19);
            this.chkF_ISADMINONLY.StyleController = this.lcDetail;
            this.chkF_ISADMINONLY.TabIndex = 6;
            // 
            // txtF_MODULE_NAME
            // 
            this.txtF_MODULE_NAME.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtF_MODULE_NAME.Location = new System.Drawing.Point(116, 102);
            this.txtF_MODULE_NAME.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.txtF_MODULE_NAME.Name = "txtF_MODULE_NAME";
            this.txtF_MODULE_NAME.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_MODULE_NAME.Properties.Appearance.Options.UseFont = true;
            this.txtF_MODULE_NAME.Size = new System.Drawing.Size(277, 22);
            this.txtF_MODULE_NAME.StyleController = this.lcDetail;
            this.txtF_MODULE_NAME.TabIndex = 1;
            // 
            // txtF_PARENT_MODULE_ID
            // 
            this.txtF_PARENT_MODULE_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtF_PARENT_MODULE_ID.Location = new System.Drawing.Point(116, 144);
            this.txtF_PARENT_MODULE_ID.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.txtF_PARENT_MODULE_ID.Name = "txtF_PARENT_MODULE_ID";
            this.txtF_PARENT_MODULE_ID.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_PARENT_MODULE_ID.Properties.Appearance.Options.UseFont = true;
            this.txtF_PARENT_MODULE_ID.Size = new System.Drawing.Size(277, 22);
            this.txtF_PARENT_MODULE_ID.StyleController = this.lcDetail;
            this.txtF_PARENT_MODULE_ID.TabIndex = 2;
            // 
            // txtModuleForm
            // 
            this.txtModuleForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModuleForm.Location = new System.Drawing.Point(116, 228);
            this.txtModuleForm.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.txtModuleForm.Name = "txtModuleForm";
            this.txtModuleForm.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtModuleForm.Properties.Appearance.Options.UseFont = true;
            this.txtModuleForm.Size = new System.Drawing.Size(277, 22);
            this.txtModuleForm.StyleController = this.lcDetail;
            this.txtModuleForm.TabIndex = 3;
            // 
            // txtF_ACTION
            // 
            this.txtF_ACTION.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtF_ACTION.Location = new System.Drawing.Point(116, 186);
            this.txtF_ACTION.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.txtF_ACTION.Name = "txtF_ACTION";
            this.txtF_ACTION.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_ACTION.Properties.Appearance.Options.UseFont = true;
            this.txtF_ACTION.Size = new System.Drawing.Size(277, 22);
            this.txtF_ACTION.StyleController = this.lcDetail;
            this.txtF_ACTION.TabIndex = 4;
            // 
            // txtF_ORDNO
            // 
            this.txtF_ORDNO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtF_ORDNO.Location = new System.Drawing.Point(116, 270);
            this.txtF_ORDNO.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.txtF_ORDNO.Name = "txtF_ORDNO";
            this.txtF_ORDNO.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtF_ORDNO.Properties.Appearance.Options.UseFont = true;
            this.txtF_ORDNO.Properties.Mask.EditMask = "d";
            this.txtF_ORDNO.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtF_ORDNO.Size = new System.Drawing.Size(277, 22);
            this.txtF_ORDNO.StyleController = this.lcDetail;
            this.txtF_ORDNO.TabIndex = 5;
            // 
            // lcgDetail
            // 
            this.lcgDetail.CustomizationFormText = "layoutControlGroup1";
            this.lcgDetail.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgDetail.GroupBordersVisible = false;
            this.lcgDetail.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciF_MODULE_ID,
            this.lciF_MODULE_NAME,
            this.lciF_PARENT_MODULE_ID,
            this.lciF_ACTION,
            this.lciF_ORDNO,
            this.lciF_ISADMINONLY,
            this.layoutControlItem4});
            this.lcgDetail.Location = new System.Drawing.Point(0, 0);
            this.lcgDetail.Name = "lcgDetail";
            this.lcgDetail.OptionsItemText.AlignControlsWithHiddenText = true;
            this.lcgDetail.Padding = new DevExpress.XtraLayout.Utils.Padding(20, 20, 50, 50);
            this.lcgDetail.Size = new System.Drawing.Size(415, 469);
            this.lcgDetail.Text = "功能编辑";
            this.lcgDetail.TextVisible = false;
            // 
            // lciF_MODULE_ID
            // 
            this.lciF_MODULE_ID.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_MODULE_ID.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_MODULE_ID.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_MODULE_ID.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_MODULE_ID.Control = this.txtF_MODULE_ID;
            this.lciF_MODULE_ID.CustomizationFormText = "功能编号：";
            this.lciF_MODULE_ID.Location = new System.Drawing.Point(0, 0);
            this.lciF_MODULE_ID.Name = "lciF_MODULE_ID";
            this.lciF_MODULE_ID.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 10);
            this.lciF_MODULE_ID.Size = new System.Drawing.Size(375, 42);
            this.lciF_MODULE_ID.Text = "功能编号：";
            this.lciF_MODULE_ID.TextSize = new System.Drawing.Size(90, 14);
            // 
            // lciF_MODULE_NAME
            // 
            this.lciF_MODULE_NAME.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_MODULE_NAME.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_MODULE_NAME.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_MODULE_NAME.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_MODULE_NAME.Control = this.txtF_MODULE_NAME;
            this.lciF_MODULE_NAME.CustomizationFormText = "模块名称：";
            this.lciF_MODULE_NAME.Location = new System.Drawing.Point(0, 42);
            this.lciF_MODULE_NAME.Name = "lciF_MODULE_NAME";
            this.lciF_MODULE_NAME.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 10);
            this.lciF_MODULE_NAME.Size = new System.Drawing.Size(375, 42);
            this.lciF_MODULE_NAME.Text = "模块名称：";
            this.lciF_MODULE_NAME.TextSize = new System.Drawing.Size(90, 14);
            // 
            // lciF_PARENT_MODULE_ID
            // 
            this.lciF_PARENT_MODULE_ID.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_PARENT_MODULE_ID.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_PARENT_MODULE_ID.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_PARENT_MODULE_ID.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_PARENT_MODULE_ID.Control = this.txtF_PARENT_MODULE_ID;
            this.lciF_PARENT_MODULE_ID.CustomizationFormText = "父节点代码：";
            this.lciF_PARENT_MODULE_ID.Location = new System.Drawing.Point(0, 84);
            this.lciF_PARENT_MODULE_ID.Name = "lciF_PARENT_MODULE_ID";
            this.lciF_PARENT_MODULE_ID.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 10);
            this.lciF_PARENT_MODULE_ID.Size = new System.Drawing.Size(375, 42);
            this.lciF_PARENT_MODULE_ID.Text = "父节点代码：";
            this.lciF_PARENT_MODULE_ID.TextSize = new System.Drawing.Size(90, 14);
            // 
            // lciF_ACTION
            // 
            this.lciF_ACTION.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_ACTION.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_ACTION.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_ACTION.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_ACTION.Control = this.txtF_ACTION;
            this.lciF_ACTION.CustomizationFormText = "模块行为：";
            this.lciF_ACTION.Location = new System.Drawing.Point(0, 126);
            this.lciF_ACTION.Name = "lciF_ACTION";
            this.lciF_ACTION.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 10);
            this.lciF_ACTION.Size = new System.Drawing.Size(375, 42);
            this.lciF_ACTION.Text = "模块行为：";
            this.lciF_ACTION.TextSize = new System.Drawing.Size(90, 14);
            // 
            // lciF_ORDNO
            // 
            this.lciF_ORDNO.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lciF_ORDNO.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.lciF_ORDNO.AppearanceItemCaption.Options.UseFont = true;
            this.lciF_ORDNO.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciF_ORDNO.Control = this.txtF_ORDNO;
            this.lciF_ORDNO.CustomizationFormText = "排序编号：";
            this.lciF_ORDNO.Location = new System.Drawing.Point(0, 210);
            this.lciF_ORDNO.Name = "lciF_ORDNO";
            this.lciF_ORDNO.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 10);
            this.lciF_ORDNO.Size = new System.Drawing.Size(375, 42);
            this.lciF_ORDNO.Text = "排序编号：";
            this.lciF_ORDNO.TextSize = new System.Drawing.Size(90, 14);
            // 
            // lciF_ISADMINONLY
            // 
            this.lciF_ISADMINONLY.Control = this.chkF_ISADMINONLY;
            this.lciF_ISADMINONLY.CustomizationFormText = "lciF_ISADMINONLY";
            this.lciF_ISADMINONLY.Location = new System.Drawing.Point(0, 252);
            this.lciF_ISADMINONLY.Name = "lciF_ISADMINONLY";
            this.lciF_ISADMINONLY.Size = new System.Drawing.Size(375, 117);
            this.lciF_ISADMINONLY.Text = "lciF_ISADMINONLY";
            this.lciF_ISADMINONLY.TextSize = new System.Drawing.Size(90, 0);
            this.lciF_ISADMINONLY.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutControlItem4.AppearanceItemCaption.ForeColor = System.Drawing.Color.DarkRed;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem4.Control = this.txtModuleForm;
            this.layoutControlItem4.CustomizationFormText = "模块目录：";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 10);
            this.layoutControlItem4.Size = new System.Drawing.Size(375, 42);
            this.layoutControlItem4.Text = "模块目录：";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(90, 14);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnExport);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 469);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(794, 68);
            this.pnlButtons.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExport.Appearance.Options.UseFont = true;
            this.btnExport.Location = new System.Drawing.Point(447, 21);
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
            this.btnDelete.Location = new System.Drawing.Point(356, 21);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 31);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(269, 21);
            this.btnSave.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(794, 537);
            this.Controls.Add(this.spcMain);
            this.Controls.Add(this.pnlButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModule";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "功能管理";
            this.Load += new System.EventHandler(this.FrmModule_Load);
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcDetail)).EndInit();
            this.lcDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtF_MODULE_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkF_ISADMINONLY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_MODULE_NAME.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_PARENT_MODULE_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModuleForm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_ACTION.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtF_ORDNO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_MODULE_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_MODULE_NAME)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_PARENT_MODULE_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_ACTION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_ORDNO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciF_ISADMINONLY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private global::System.Windows.Forms.SplitContainer spcMain;
        private BaseTextEdit txtF_ORDNO;
        private BaseTextEdit txtModuleForm;
        private BaseTextEdit txtF_MODULE_ID;
        private BaseTextEdit txtF_PARENT_MODULE_ID;
        private BaseTextEdit txtF_MODULE_NAME;
        private BaseTextEdit txtF_ACTION;
        private DevExpress.XtraTreeList.TreeList tlModule;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colF_MODULE_ID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colF_MODULE_NAME;
        private DevExpress.XtraEditors.PanelControl pnlButtons;
        private BaseSimpleButton btnExport;
        private BaseSimpleButton btnDelete;
        private BaseSimpleButton btnSave;
        private DevExpress.XtraEditors.CheckEdit chkF_ISADMINONLY;
        private DevExpress.XtraLayout.LayoutControl lcDetail;
        private DevExpress.XtraLayout.LayoutControlGroup lcgDetail;
        private DevExpress.XtraLayout.LayoutControlItem lciF_MODULE_ID;
        private DevExpress.XtraLayout.LayoutControlItem lciF_MODULE_NAME;
        private DevExpress.XtraLayout.LayoutControlItem lciF_PARENT_MODULE_ID;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem lciF_ACTION;
        private DevExpress.XtraLayout.LayoutControlItem lciF_ORDNO;
        private DevExpress.XtraLayout.LayoutControlItem lciF_ISADMINONLY;
    }
}