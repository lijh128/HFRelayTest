namespace RelayTest.Application.Task
{
    partial class FrmRunUpTestStatus
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
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.lstTasklist = new DevExpress.XtraEditors.ListBoxControl();
            this.btnDisAddTemp = new RelayTest.Util.Common.BaseSimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstTasklist)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl4
            // 
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.Controls.Add(this.lstTasklist);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl4.Location = new System.Drawing.Point(0, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(204, 500);
            this.groupControl4.TabIndex = 11;
            this.groupControl4.Text = "已完成试验任务列表";
            // 
            // lstTasklist
            // 
            this.lstTasklist.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTasklist.Appearance.Options.UseFont = true;
            this.lstTasklist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTasklist.Location = new System.Drawing.Point(2, 25);
            this.lstTasklist.Margin = new System.Windows.Forms.Padding(6);
            this.lstTasklist.Name = "lstTasklist";
            this.lstTasklist.Size = new System.Drawing.Size(200, 473);
            this.lstTasklist.TabIndex = 115;
            // 
            // btnDisAddTemp
            // 
            this.btnDisAddTemp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDisAddTemp.Appearance.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDisAddTemp.Appearance.Options.UseFont = true;
            this.btnDisAddTemp.Location = new System.Drawing.Point(246, 230);
            this.btnDisAddTemp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDisAddTemp.Name = "btnDisAddTemp";
            this.btnDisAddTemp.Size = new System.Drawing.Size(189, 36);
            this.btnDisAddTemp.TabIndex = 114;
            this.btnDisAddTemp.Text = "转换为可爬高试验";
            this.btnDisAddTemp.Click += new System.EventHandler(this.btnDisAddTemp_Click);
            // 
            // FrmRunUpTestStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 500);
            this.Controls.Add(this.btnDisAddTemp);
            this.Controls.Add(this.groupControl4);
            this.Name = "FrmRunUpTestStatus";
            this.Text = "爬高试验状态转换";
            this.Load += new System.EventHandler(this.FrmRunUpTestStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstTasklist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.ListBoxControl lstTasklist;
        private Util.Common.BaseSimpleButton btnDisAddTemp;
    }
}