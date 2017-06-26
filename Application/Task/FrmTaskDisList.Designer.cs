namespace RelayTest.Application.Task
{
    partial class FrmTaskDisList
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnSaveNoDis = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnNoDisAddTemp = new RelayTest.Util.Common.BaseSimpleButton();
            this.btnDisAddTemp = new RelayTest.Util.Common.BaseSimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lstTaskNoDisList = new DevExpress.XtraEditors.ListBoxControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.lstTasklist = new DevExpress.XtraEditors.ListBoxControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lstTempDisList = new DevExpress.XtraEditors.ListBoxControl();
            this.btnSaveDis = new RelayTest.Util.Common.BaseSimpleButton();
            this.baseSimpleButton1 = new RelayTest.Util.Common.BaseSimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstTaskNoDisList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstTasklist)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstTempDisList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(989, 544);
            this.panelControl2.TabIndex = 1;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Controls.Add(this.groupControl1);
            this.panelControl3.Controls.Add(this.groupControl4);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(989, 544);
            this.panelControl3.TabIndex = 2;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.groupControl2);
            this.panelControl4.Controls.Add(this.panel2);
            this.panelControl4.Controls.Add(this.panel1);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(206, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(572, 540);
            this.panelControl4.TabIndex = 12;
            // 
            // btnSaveNoDis
            // 
            this.btnSaveNoDis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveNoDis.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveNoDis.Appearance.Options.UseFont = true;
            this.btnSaveNoDis.Location = new System.Drawing.Point(10, 287);
            this.btnSaveNoDis.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSaveNoDis.Name = "btnSaveNoDis";
            this.btnSaveNoDis.Size = new System.Drawing.Size(189, 37);
            this.btnSaveNoDis.TabIndex = 115;
            this.btnSaveNoDis.Text = "保存中间任务至不显示列表";
            this.btnSaveNoDis.Click += new System.EventHandler(this.baseSimpleButton2_Click);
            // 
            // btnNoDisAddTemp
            // 
            this.btnNoDisAddTemp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoDisAddTemp.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNoDisAddTemp.Appearance.Options.UseFont = true;
            this.btnNoDisAddTemp.Location = new System.Drawing.Point(7, 188);
            this.btnNoDisAddTemp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNoDisAddTemp.Name = "btnNoDisAddTemp";
            this.btnNoDisAddTemp.Size = new System.Drawing.Size(188, 36);
            this.btnNoDisAddTemp.TabIndex = 114;
            this.btnNoDisAddTemp.Text = "<<< 添加至中间任务列表";
            this.btnNoDisAddTemp.Click += new System.EventHandler(this.baseSimpleButton1_Click);
            // 
            // btnDisAddTemp
            // 
            this.btnDisAddTemp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisAddTemp.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDisAddTemp.Appearance.Options.UseFont = true;
            this.btnDisAddTemp.Location = new System.Drawing.Point(8, 188);
            this.btnDisAddTemp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDisAddTemp.Name = "btnDisAddTemp";
            this.btnDisAddTemp.Size = new System.Drawing.Size(189, 36);
            this.btnDisAddTemp.TabIndex = 113;
            this.btnDisAddTemp.Text = ">>>添加至中间任务列表";
            this.btnDisAddTemp.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.lstTaskNoDisList);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(778, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(209, 540);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "不显示试验任务列表";
            // 
            // lstTaskNoDisList
            // 
            this.lstTaskNoDisList.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTaskNoDisList.Appearance.Options.UseFont = true;
            this.lstTaskNoDisList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTaskNoDisList.Location = new System.Drawing.Point(2, 25);
            this.lstTaskNoDisList.Margin = new System.Windows.Forms.Padding(6);
            this.lstTaskNoDisList.Name = "lstTaskNoDisList";
            this.lstTaskNoDisList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTaskNoDisList.Size = new System.Drawing.Size(205, 513);
            this.lstTaskNoDisList.TabIndex = 115;
            // 
            // groupControl4
            // 
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.Controls.Add(this.lstTasklist);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl4.Location = new System.Drawing.Point(2, 2);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(204, 540);
            this.groupControl4.TabIndex = 10;
            this.groupControl4.Text = "显示试验任务列表";
            // 
            // lstTasklist
            // 
            this.lstTasklist.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTasklist.Appearance.Options.UseFont = true;
            this.lstTasklist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTasklist.Location = new System.Drawing.Point(2, 25);
            this.lstTasklist.Margin = new System.Windows.Forms.Padding(6);
            this.lstTasklist.Name = "lstTasklist";
            this.lstTasklist.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTasklist.Size = new System.Drawing.Size(200, 513);
            this.lstTasklist.TabIndex = 115;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.baseSimpleButton1);
            this.panel1.Controls.Add(this.btnDisAddTemp);
            this.panel1.Controls.Add(this.btnSaveNoDis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 536);
            this.panel1.TabIndex = 116;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSaveDis);
            this.panel2.Controls.Add(this.btnNoDisAddTemp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(368, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 536);
            this.panel2.TabIndex = 117;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.lstTempDisList);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(207, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(161, 536);
            this.groupControl2.TabIndex = 118;
            this.groupControl2.Text = "中间任务列表";
            // 
            // lstTempDisList
            // 
            this.lstTempDisList.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTempDisList.Appearance.Options.UseFont = true;
            this.lstTempDisList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTempDisList.Location = new System.Drawing.Point(2, 25);
            this.lstTempDisList.Margin = new System.Windows.Forms.Padding(6);
            this.lstTempDisList.Name = "lstTempDisList";
            this.lstTempDisList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTempDisList.Size = new System.Drawing.Size(157, 509);
            this.lstTempDisList.TabIndex = 115;
            // 
            // btnSaveDis
            // 
            this.btnSaveDis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveDis.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveDis.Appearance.Options.UseFont = true;
            this.btnSaveDis.Location = new System.Drawing.Point(7, 287);
            this.btnSaveDis.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSaveDis.Name = "btnSaveDis";
            this.btnSaveDis.Size = new System.Drawing.Size(188, 36);
            this.btnSaveDis.TabIndex = 115;
            this.btnSaveDis.Text = "保存中间任务至显示列表";
            this.btnSaveDis.Click += new System.EventHandler(this.btnSaveDis_Click);
            // 
            // baseSimpleButton1
            // 
            this.baseSimpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseSimpleButton1.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.baseSimpleButton1.Appearance.Options.UseFont = true;
            this.baseSimpleButton1.Location = new System.Drawing.Point(11, 388);
            this.baseSimpleButton1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.baseSimpleButton1.Name = "baseSimpleButton1";
            this.baseSimpleButton1.Size = new System.Drawing.Size(189, 37);
            this.baseSimpleButton1.TabIndex = 116;
            this.baseSimpleButton1.Text = "刷新显示任务列表内容";
            this.baseSimpleButton1.Click += new System.EventHandler(this.baseSimpleButton1_Click_1);
            // 
            // FrmTaskDisList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 544);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Name = "FrmTaskDisList";
            this.Text = "试验任务显示列表维护";
            this.Load += new System.EventHandler(this.FrmTaskDisList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstTaskNoDisList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstTasklist)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstTempDisList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private Util.Common.BaseSimpleButton btnSaveNoDis;
        private Util.Common.BaseSimpleButton btnNoDisAddTemp;
        private Util.Common.BaseSimpleButton btnDisAddTemp;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ListBoxControl lstTaskNoDisList;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.ListBoxControl lstTasklist;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.ListBoxControl lstTempDisList;
        private System.Windows.Forms.Panel panel2;
        private Util.Common.BaseSimpleButton btnSaveDis;
        private System.Windows.Forms.Panel panel1;
        private Util.Common.BaseSimpleButton baseSimpleButton1;

    }
}