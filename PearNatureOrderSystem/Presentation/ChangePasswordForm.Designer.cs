namespace PearNatureOrderSystem.Presentation
{
    partial class ChangePasswordForm
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
            this.lb_OriginalPassword = new System.Windows.Forms.Label();
            this.tb_OriginalPassword = new System.Windows.Forms.TextBox();
            this.tb_NewPassword = new System.Windows.Forms.TextBox();
            this.lb_NewPassword = new System.Windows.Forms.Label();
            this.btn_UpdatePassword = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_OriginalPassword
            // 
            this.lb_OriginalPassword.AutoSize = true;
            this.lb_OriginalPassword.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_OriginalPassword.Location = new System.Drawing.Point(22, 90);
            this.lb_OriginalPassword.Name = "lb_OriginalPassword";
            this.lb_OriginalPassword.Size = new System.Drawing.Size(75, 27);
            this.lb_OriginalPassword.TabIndex = 0;
            this.lb_OriginalPassword.Text = "舊密碼";
            // 
            // tb_OriginalPassword
            // 
            this.tb_OriginalPassword.Location = new System.Drawing.Point(105, 95);
            this.tb_OriginalPassword.Name = "tb_OriginalPassword";
            this.tb_OriginalPassword.Size = new System.Drawing.Size(142, 22);
            this.tb_OriginalPassword.TabIndex = 1;
            // 
            // tb_NewPassword
            // 
            this.tb_NewPassword.Location = new System.Drawing.Point(105, 131);
            this.tb_NewPassword.Name = "tb_NewPassword";
            this.tb_NewPassword.Size = new System.Drawing.Size(142, 22);
            this.tb_NewPassword.TabIndex = 3;
            // 
            // lb_NewPassword
            // 
            this.lb_NewPassword.AutoSize = true;
            this.lb_NewPassword.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_NewPassword.Location = new System.Drawing.Point(22, 126);
            this.lb_NewPassword.Name = "lb_NewPassword";
            this.lb_NewPassword.Size = new System.Drawing.Size(75, 27);
            this.lb_NewPassword.TabIndex = 2;
            this.lb_NewPassword.Text = "新密碼";
            // 
            // btn_UpdatePassword
            // 
            this.btn_UpdatePassword.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_UpdatePassword.Location = new System.Drawing.Point(27, 166);
            this.btn_UpdatePassword.Name = "btn_UpdatePassword";
            this.btn_UpdatePassword.Size = new System.Drawing.Size(105, 53);
            this.btn_UpdatePassword.TabIndex = 4;
            this.btn_UpdatePassword.Text = "更新密碼";
            this.btn_UpdatePassword.UseVisualStyleBackColor = true;
            this.btn_UpdatePassword.Click += new System.EventHandler(this.btn_UpdatePassword_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Close.Location = new System.Drawing.Point(142, 166);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(105, 53);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Text = "取消";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 230);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_UpdatePassword);
            this.Controls.Add(this.tb_NewPassword);
            this.Controls.Add(this.lb_NewPassword);
            this.Controls.Add(this.tb_OriginalPassword);
            this.Controls.Add(this.lb_OriginalPassword);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePasswordForm";
            this.Resizable = false;
            this.Text = "ChangePasswordForm";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_OriginalPassword;
        private System.Windows.Forms.TextBox tb_OriginalPassword;
        private System.Windows.Forms.TextBox tb_NewPassword;
        private System.Windows.Forms.Label lb_NewPassword;
        private System.Windows.Forms.Button btn_UpdatePassword;
        private System.Windows.Forms.Button btn_Close;
    }
}