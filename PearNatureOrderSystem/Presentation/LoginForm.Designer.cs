namespace PearNatureOrderSystem.Presentation
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.btn_Login = new MetroFramework.Controls.MetroButton();
            this.tb_Password = new MetroFramework.Controls.MetroTextBox();
            this.tb_Account = new MetroFramework.Controls.MetroTextBox();
            this.btn_Reset = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Login.Location = new System.Drawing.Point(23, 121);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(140, 59);
            this.btn_Login.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "登入";
            this.btn_Login.UseSelectable = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // tb_Password
            // 
            // 
            // 
            // 
            this.tb_Password.CustomButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_Password.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.tb_Password.CustomButton.Location = new System.Drawing.Point(266, 1);
            this.tb_Password.CustomButton.Name = "";
            this.tb_Password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Password.CustomButton.TabIndex = 1;
            this.tb_Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Password.CustomButton.UseSelectable = true;
            this.tb_Password.CustomButton.Visible = false;
            this.tb_Password.DisplayIcon = true;
            this.tb_Password.Icon = ((System.Drawing.Image)(resources.GetObject("tb_Password.Icon")));
            this.tb_Password.Lines = new string[0];
            this.tb_Password.Location = new System.Drawing.Point(23, 92);
            this.tb_Password.MaxLength = 14;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Password.SelectedText = "";
            this.tb_Password.SelectionLength = 0;
            this.tb_Password.SelectionStart = 0;
            this.tb_Password.ShortcutsEnabled = true;
            this.tb_Password.ShowClearButton = true;
            this.tb_Password.Size = new System.Drawing.Size(288, 23);
            this.tb_Password.Style = MetroFramework.MetroColorStyle.Silver;
            this.tb_Password.TabIndex = 1;
            this.tb_Password.UseSelectable = true;
            this.tb_Password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_Account
            // 
            // 
            // 
            // 
            this.tb_Account.CustomButton.Image = null;
            this.tb_Account.CustomButton.Location = new System.Drawing.Point(266, 1);
            this.tb_Account.CustomButton.Name = "";
            this.tb_Account.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_Account.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Account.CustomButton.TabIndex = 1;
            this.tb_Account.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Account.CustomButton.UseSelectable = true;
            this.tb_Account.CustomButton.Visible = false;
            this.tb_Account.DisplayIcon = true;
            this.tb_Account.Icon = ((System.Drawing.Image)(resources.GetObject("tb_Account.Icon")));
            this.tb_Account.Lines = new string[0];
            this.tb_Account.Location = new System.Drawing.Point(23, 63);
            this.tb_Account.MaxLength = 32767;
            this.tb_Account.Name = "tb_Account";
            this.tb_Account.PasswordChar = '\0';
            this.tb_Account.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Account.SelectedText = "";
            this.tb_Account.SelectionLength = 0;
            this.tb_Account.SelectionStart = 0;
            this.tb_Account.ShortcutsEnabled = true;
            this.tb_Account.Size = new System.Drawing.Size(288, 23);
            this.tb_Account.Style = MetroFramework.MetroColorStyle.Silver;
            this.tb_Account.TabIndex = 0;
            this.tb_Account.UseSelectable = true;
            this.tb_Account.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Account.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(171, 122);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(140, 59);
            this.btn_Reset.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_Reset.TabIndex = 3;
            this.btn_Reset.Text = "清除";
            this.btn_Reset.UseSelectable = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(334, 204);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Account);
            this.Controls.Add(this.btn_Login);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "PearNature Order System";
            this.Activated += new System.EventHandler(this.LoginForm_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_Login;
        private MetroFramework.Controls.MetroTextBox tb_Account;
        private MetroFramework.Controls.MetroTextBox tb_Password;
        private MetroFramework.Controls.MetroButton btn_Reset;
    }
}