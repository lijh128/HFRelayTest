using DevExpress.XtraTreeList;

namespace RelayTest.Application.Controls
{
    partial class UcModuleTree
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlModule = new DevExpress.XtraTreeList.TreeList();
            this.colF_MODULEID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colF_NAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((global::System.ComponentModel.ISupportInitialize)(this.tlModule)).BeginInit();
            this.SuspendLayout();
            // 
            // tlModule
            // 
            this.tlModule.Appearance.CustomizationFormHint.Font = new global::System.Drawing.Font("SimSun", 12F, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlModule.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.tlModule.Appearance.Empty.BackColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.tlModule.Appearance.Empty.BackColor2 = global::System.Drawing.Color.White;
            this.tlModule.Appearance.Empty.Options.UseBackColor = true;
            this.tlModule.Appearance.EvenRow.BackColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.tlModule.Appearance.EvenRow.BorderColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(245)))));
            this.tlModule.Appearance.EvenRow.Font = new global::System.Drawing.Font("SimSun", 12F, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlModule.Appearance.EvenRow.ForeColor = global::System.Drawing.Color.Black;
            this.tlModule.Appearance.EvenRow.Options.UseBackColor = true;
            this.tlModule.Appearance.EvenRow.Options.UseBorderColor = true;
            this.tlModule.Appearance.EvenRow.Options.UseFont = true;
            this.tlModule.Appearance.EvenRow.Options.UseForeColor = true;
            this.tlModule.Appearance.FocusedCell.BackColor = global::System.Drawing.Color.White;
            this.tlModule.Appearance.FocusedCell.ForeColor = global::System.Drawing.Color.Black;
            this.tlModule.Appearance.FocusedCell.Options.UseBackColor = true;
            this.tlModule.Appearance.FocusedCell.Options.UseForeColor = true;
            this.tlModule.Appearance.FocusedRow.BackColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(171)))), ((int)(((byte)(177)))));
            this.tlModule.Appearance.FocusedRow.ForeColor = global::System.Drawing.Color.White;
            this.tlModule.Appearance.FocusedRow.Options.UseBackColor = true;
            this.tlModule.Appearance.FocusedRow.Options.UseForeColor = true;
            this.tlModule.Appearance.FooterPanel.BackColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.tlModule.Appearance.FooterPanel.BorderColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(221)))), ((int)(((byte)(208)))));
            this.tlModule.Appearance.FooterPanel.ForeColor = global::System.Drawing.Color.Black;
            this.tlModule.Appearance.FooterPanel.Options.UseBackColor = true;
            this.tlModule.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.tlModule.Appearance.FooterPanel.Options.UseForeColor = true;
            this.tlModule.Appearance.GroupButton.BackColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(209)))), ((int)(((byte)(188)))));
            this.tlModule.Appearance.GroupButton.BorderColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(209)))), ((int)(((byte)(188)))));
            this.tlModule.Appearance.GroupButton.Options.UseBackColor = true;
            this.tlModule.Appearance.GroupButton.Options.UseBorderColor = true;
            this.tlModule.Appearance.GroupFooter.BackColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.tlModule.Appearance.GroupFooter.BorderColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.tlModule.Appearance.GroupFooter.ForeColor = global::System.Drawing.Color.Black;
            this.tlModule.Appearance.GroupFooter.Options.UseBackColor = true;
            this.tlModule.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.tlModule.Appearance.GroupFooter.Options.UseForeColor = true;
            this.tlModule.Appearance.HeaderPanel.BackColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            this.tlModule.Appearance.HeaderPanel.BorderColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(226)))), ((int)(((byte)(216)))));
            this.tlModule.Appearance.HeaderPanel.Font = new global::System.Drawing.Font("SimSun", 12F, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tlModule.Appearance.HeaderPanel.ForeColor = global::System.Drawing.Color.Black;
            this.tlModule.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.tlModule.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.tlModule.Appearance.HeaderPanel.Options.UseFont = true;
            this.tlModule.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tlModule.Appearance.HideSelectionRow.BackColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(211)))), ((int)(((byte)(215)))));
            this.tlModule.Appearance.HideSelectionRow.Font = new global::System.Drawing.Font("SimSun", 12F, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlModule.Appearance.HideSelectionRow.ForeColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
            this.tlModule.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.tlModule.Appearance.HideSelectionRow.Options.UseFont = true;
            this.tlModule.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.tlModule.Appearance.HorzLine.BackColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(197)))), ((int)(((byte)(180)))));
            this.tlModule.Appearance.HorzLine.Options.UseBackColor = true;
            this.tlModule.Appearance.OddRow.BackColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.tlModule.Appearance.OddRow.BorderColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.tlModule.Appearance.OddRow.Font = new global::System.Drawing.Font("SimSun", 12F, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlModule.Appearance.OddRow.ForeColor = global::System.Drawing.Color.Black;
            this.tlModule.Appearance.OddRow.Options.UseBackColor = true;
            this.tlModule.Appearance.OddRow.Options.UseBorderColor = true;
            this.tlModule.Appearance.OddRow.Options.UseFont = true;
            this.tlModule.Appearance.OddRow.Options.UseForeColor = true;
            this.tlModule.Appearance.Preview.BackColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.tlModule.Appearance.Preview.Font = new global::System.Drawing.Font("SimSun", 7.5F);
            this.tlModule.Appearance.Preview.ForeColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(130)))), ((int)(((byte)(134)))));
            this.tlModule.Appearance.Preview.Options.UseBackColor = true;
            this.tlModule.Appearance.Preview.Options.UseFont = true;
            this.tlModule.Appearance.Preview.Options.UseForeColor = true;
            this.tlModule.Appearance.Row.BackColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(236)))));
            this.tlModule.Appearance.Row.Font = new global::System.Drawing.Font("SimSun", 12F, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tlModule.Appearance.Row.ForeColor = global::System.Drawing.Color.Black;
            this.tlModule.Appearance.Row.Options.UseBackColor = true;
            this.tlModule.Appearance.Row.Options.UseFont = true;
            this.tlModule.Appearance.Row.Options.UseForeColor = true;
            this.tlModule.Appearance.SelectedRow.BackColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(201)))), ((int)(((byte)(207)))));
            this.tlModule.Appearance.SelectedRow.ForeColor = global::System.Drawing.Color.Black;
            this.tlModule.Appearance.SelectedRow.Options.UseBackColor = true;
            this.tlModule.Appearance.SelectedRow.Options.UseForeColor = true;
            this.tlModule.Appearance.TreeLine.BackColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
            this.tlModule.Appearance.TreeLine.Options.UseBackColor = true;
            this.tlModule.Appearance.VertLine.BackColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(197)))), ((int)(((byte)(180)))));
            this.tlModule.Appearance.VertLine.BorderColor = global::System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
            this.tlModule.Appearance.VertLine.Options.UseBackColor = true;
            this.tlModule.Appearance.VertLine.Options.UseBorderColor = true;
            this.tlModule.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colF_MODULEID,
            this.colF_NAME});
            this.tlModule.Dock = global::System.Windows.Forms.DockStyle.Fill;
            this.tlModule.Font = new global::System.Drawing.Font("SimSun", 12F);
            this.tlModule.KeyFieldName = "F_MODULEID";
            this.tlModule.Location = new global::System.Drawing.Point(0, 0);
            this.tlModule.Margin = new global::System.Windows.Forms.Padding(4);
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
            this.tlModule.OptionsView.ShowIndentAsRowStyle = true;
            this.tlModule.OptionsView.ShowVertLines = false;
            this.tlModule.ParentFieldName = "F_PARENTID";
            this.tlModule.Size = new global::System.Drawing.Size(457, 555);
            this.tlModule.TabIndex = 1;
            this.tlModule.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.Dark;
            this.tlModule.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeList1_FocusedNodeChanged);
            this.tlModule.Click += new global::System.EventHandler(this.treeList1_Click);
            // 
            // colF_MODULEID
            // 
            this.colF_MODULEID.Caption = "编码";
            this.colF_MODULEID.FieldName = "F_MODULEID";
            this.colF_MODULEID.Name = "colF_MODULEID";
            this.colF_MODULEID.SortOrder = global::System.Windows.Forms.SortOrder.Ascending;
            this.colF_MODULEID.Visible = true;
            this.colF_MODULEID.VisibleIndex = 0;
            this.colF_MODULEID.Width = 112;
            // 
            // colF_NAME
            // 
            this.colF_NAME.AllNodesSummary = true;
            this.colF_NAME.AppearanceCell.Font = new global::System.Drawing.Font("SimSun", 12F, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colF_NAME.AppearanceCell.Options.UseFont = true;
            this.colF_NAME.Caption = "模块名称";
            this.colF_NAME.FieldName = "F_NAME";
            this.colF_NAME.Name = "colF_NAME";
            this.colF_NAME.Visible = true;
            this.colF_NAME.VisibleIndex = 1;
            this.colF_NAME.Width = 161;
            // 
            // UcModuleTree
            // 
            this.AutoScaleDimensions = new global::System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlModule);
            this.Font = new global::System.Drawing.Font("SimSun", 12F, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new global::System.Windows.Forms.Padding(4);
            this.Name = "UcModuleTree";
            this.Size = new global::System.Drawing.Size(457, 555);
            ((global::System.ComponentModel.ISupportInitialize)(this.tlModule)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TreeList tlModule;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colF_NAME;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colF_MODULEID;
    }
}
