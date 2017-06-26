namespace RelayTest.Application.Query
{
    partial class FrmQueryTestAttatch
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Query_attatchment = new RelayTest.Util.Common.BaseSimpleButton();
            this.lbl_testCode = new DevExpress.XtraEditors.LabelControl();
            this.lst_attatch = new DevExpress.XtraEditors.ListBoxControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lst_attatch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Query_attatchment);
            this.panel1.Controls.Add(this.lbl_testCode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 64);
            this.panel1.TabIndex = 0;
            // 
            // btn_Query_attatchment
            // 
            this.btn_Query_attatchment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Query_attatchment.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Query_attatchment.Appearance.Options.UseFont = true;
            this.btn_Query_attatchment.Location = new System.Drawing.Point(241, 20);
            this.btn_Query_attatchment.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Query_attatchment.Name = "btn_Query_attatchment";
            this.btn_Query_attatchment.Size = new System.Drawing.Size(123, 29);
            this.btn_Query_attatchment.TabIndex = 148;
            this.btn_Query_attatchment.Text = "下载任务附件";
            this.btn_Query_attatchment.Click += new System.EventHandler(this.btn_Query_attatchment_Click);
            // 
            // lbl_testCode
            // 
            this.lbl_testCode.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.lbl_testCode.Location = new System.Drawing.Point(12, 24);
            this.lbl_testCode.Name = "lbl_testCode";
            this.lbl_testCode.Size = new System.Drawing.Size(70, 17);
            this.lbl_testCode.TabIndex = 0;
            this.lbl_testCode.Text = "任务编号：";
            // 
            // lst_attatch
            // 
            this.lst_attatch.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.lst_attatch.Appearance.Options.UseFont = true;
            this.lst_attatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_attatch.Location = new System.Drawing.Point(0, 64);
            this.lst_attatch.Name = "lst_attatch";
            this.lst_attatch.Size = new System.Drawing.Size(437, 251);
            this.lst_attatch.TabIndex = 1;
            // 
            // FrmQueryTestAttatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 315);
            this.Controls.Add(this.lst_attatch);
            this.Controls.Add(this.panel1);
            this.Name = "FrmQueryTestAttatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询任务附件信息";
            this.Load += new System.EventHandler(this.FrmQueryTestAttatch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lst_attatch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl lbl_testCode;
        private Util.Common.BaseSimpleButton btn_Query_attatchment;
        private DevExpress.XtraEditors.ListBoxControl lst_attatch;
    }
}