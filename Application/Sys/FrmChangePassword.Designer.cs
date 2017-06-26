namespace RelayTest.Application.Sys
{
    partial class FrmChangePassword
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
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.txtRepeatPassword = new DevExpress.XtraEditors.TextEdit();
            this.lblRepeatPassword = new DevExpress.XtraEditors.LabelControl();
            this.txtPasswrod = new DevExpress.XtraEditors.TextEdit();
            this.lblPasswrod = new DevExpress.XtraEditors.LabelControl();
            this.txtOriginalPass = new DevExpress.XtraEditors.TextEdit();
            this.lblOringnalPass = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepeatPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswrod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOriginalPass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnUpdate);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 116);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(342, 74);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Location = new System.Drawing.Point(132, 22);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 31);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.txtRepeatPassword);
            this.pnlEdit.Controls.Add(this.lblRepeatPassword);
            this.pnlEdit.Controls.Add(this.txtPasswrod);
            this.pnlEdit.Controls.Add(this.lblPasswrod);
            this.pnlEdit.Controls.Add(this.txtOriginalPass);
            this.pnlEdit.Controls.Add(this.lblOringnalPass);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEdit.Location = new System.Drawing.Point(0, 0);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(342, 116);
            this.pnlEdit.TabIndex = 0;
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.Location = new System.Drawing.Point(130, 78);
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRepeatPassword.Properties.Appearance.Options.UseFont = true;
            this.txtRepeatPassword.Properties.PasswordChar = '*';
            this.txtRepeatPassword.Size = new System.Drawing.Size(160, 22);
            this.txtRepeatPassword.TabIndex = 2;
            // 
            // lblRepeatPassword
            // 
            this.lblRepeatPassword.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRepeatPassword.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRepeatPassword.Location = new System.Drawing.Point(52, 81);
            this.lblRepeatPassword.Name = "lblRepeatPassword";
            this.lblRepeatPassword.Size = new System.Drawing.Size(63, 14);
            this.lblRepeatPassword.TabIndex = 12;
            this.lblRepeatPassword.Text = "重复密码*";
            // 
            // txtPasswrod
            // 
            this.txtPasswrod.Location = new System.Drawing.Point(130, 46);
            this.txtPasswrod.Name = "txtPasswrod";
            this.txtPasswrod.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPasswrod.Properties.Appearance.Options.UseFont = true;
            this.txtPasswrod.Properties.PasswordChar = '*';
            this.txtPasswrod.Size = new System.Drawing.Size(160, 22);
            this.txtPasswrod.TabIndex = 1;
            // 
            // lblPasswrod
            // 
            this.lblPasswrod.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPasswrod.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPasswrod.Location = new System.Drawing.Point(69, 50);
            this.lblPasswrod.Name = "lblPasswrod";
            this.lblPasswrod.Size = new System.Drawing.Size(49, 14);
            this.lblPasswrod.TabIndex = 10;
            this.lblPasswrod.Text = "新密码*";
            // 
            // txtOriginalPass
            // 
            this.txtOriginalPass.Location = new System.Drawing.Point(130, 17);
            this.txtOriginalPass.Name = "txtOriginalPass";
            this.txtOriginalPass.Properties.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOriginalPass.Properties.Appearance.Options.UseFont = true;
            this.txtOriginalPass.Properties.PasswordChar = '*';
            this.txtOriginalPass.Size = new System.Drawing.Size(160, 22);
            this.txtOriginalPass.TabIndex = 0;
            // 
            // lblOringnalPass
            // 
            this.lblOringnalPass.Appearance.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOringnalPass.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.lblOringnalPass.Location = new System.Drawing.Point(69, 18);
            this.lblOringnalPass.Name = "lblOringnalPass";
            this.lblOringnalPass.Size = new System.Drawing.Size(49, 14);
            this.lblOringnalPass.TabIndex = 4;
            this.lblOringnalPass.Text = "原密码*";
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 190);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUser_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepeatPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswrod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOriginalPass.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraEditors.TextEdit txtOriginalPass;
        private DevExpress.XtraEditors.LabelControl lblOringnalPass;
        private DevExpress.XtraEditors.TextEdit txtRepeatPassword;
        private DevExpress.XtraEditors.LabelControl lblRepeatPassword;
        private DevExpress.XtraEditors.TextEdit txtPasswrod;
        private DevExpress.XtraEditors.LabelControl lblPasswrod;
    }
}