namespace PearNatureOrderSystem.Presentation
{
    partial class AccountManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new MetroFramework.Controls.MetroButton();
            this.tb_Name = new MetroFramework.Controls.MetroTextBox();
            this.tb_Password = new MetroFramework.Controls.MetroTextBox();
            this.tb_Account = new MetroFramework.Controls.MetroTextBox();
            this.lb_Account = new MetroFramework.Controls.MetroLabel();
            this.lb_Password = new MetroFramework.Controls.MetroLabel();
            this.lb_Name = new MetroFramework.Controls.MetroLabel();
            this.btn_Delete = new MetroFramework.Controls.MetroButton();
            this.btn_Update = new MetroFramework.Controls.MetroButton();
            this.btn_Insert = new MetroFramework.Controls.MetroButton();
            this.grid_Users = new MetroFramework.Controls.MetroGrid();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Clear);
            this.groupBox1.Controls.Add(this.tb_Name);
            this.groupBox1.Controls.Add(this.tb_Password);
            this.groupBox1.Controls.Add(this.tb_Account);
            this.groupBox1.Controls.Add(this.lb_Account);
            this.groupBox1.Controls.Add(this.lb_Password);
            this.groupBox1.Controls.Add(this.lb_Name);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Controls.Add(this.btn_Insert);
            this.groupBox1.Location = new System.Drawing.Point(24, 384);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能列";
            // 
            // btn_Clear
            // 
            this.btn_Clear.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Clear.Location = new System.Drawing.Point(290, 98);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(77, 74);
            this.btn_Clear.TabIndex = 9;
            this.btn_Clear.Text = "清除";
            this.btn_Clear.UseSelectable = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // tb_Name
            // 
            // 
            // 
            // 
            this.tb_Name.CustomButton.Image = null;
            this.tb_Name.CustomButton.Location = new System.Drawing.Point(282, 1);
            this.tb_Name.CustomButton.Name = "";
            this.tb_Name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Name.CustomButton.TabIndex = 1;
            this.tb_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Name.CustomButton.UseSelectable = true;
            this.tb_Name.CustomButton.Visible = false;
            this.tb_Name.Lines = new string[0];
            this.tb_Name.Location = new System.Drawing.Point(63, 70);
            this.tb_Name.MaxLength = 32767;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.PasswordChar = '\0';
            this.tb_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Name.SelectedText = "";
            this.tb_Name.SelectionLength = 0;
            this.tb_Name.SelectionStart = 0;
            this.tb_Name.ShortcutsEnabled = true;
            this.tb_Name.Size = new System.Drawing.Size(304, 23);
            this.tb_Name.TabIndex = 8;
            this.tb_Name.UseSelectable = true;
            this.tb_Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_Password
            // 
            // 
            // 
            // 
            this.tb_Password.CustomButton.Image = null;
            this.tb_Password.CustomButton.Location = new System.Drawing.Point(282, 1);
            this.tb_Password.CustomButton.Name = "";
            this.tb_Password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Password.CustomButton.TabIndex = 1;
            this.tb_Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Password.CustomButton.UseSelectable = true;
            this.tb_Password.CustomButton.Visible = false;
            this.tb_Password.Lines = new string[0];
            this.tb_Password.Location = new System.Drawing.Point(63, 44);
            this.tb_Password.MaxLength = 32767;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '\0';
            this.tb_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Password.SelectedText = "";
            this.tb_Password.SelectionLength = 0;
            this.tb_Password.SelectionStart = 0;
            this.tb_Password.ShortcutsEnabled = true;
            this.tb_Password.Size = new System.Drawing.Size(304, 23);
            this.tb_Password.TabIndex = 7;
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
            this.tb_Account.CustomButton.Location = new System.Drawing.Point(282, 1);
            this.tb_Account.CustomButton.Name = "";
            this.tb_Account.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_Account.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Account.CustomButton.TabIndex = 1;
            this.tb_Account.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Account.CustomButton.UseSelectable = true;
            this.tb_Account.CustomButton.Visible = false;
            this.tb_Account.Lines = new string[0];
            this.tb_Account.Location = new System.Drawing.Point(63, 18);
            this.tb_Account.MaxLength = 32767;
            this.tb_Account.Name = "tb_Account";
            this.tb_Account.PasswordChar = '\0';
            this.tb_Account.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Account.SelectedText = "";
            this.tb_Account.SelectionLength = 0;
            this.tb_Account.SelectionStart = 0;
            this.tb_Account.ShortcutsEnabled = true;
            this.tb_Account.Size = new System.Drawing.Size(304, 23);
            this.tb_Account.TabIndex = 6;
            this.tb_Account.UseSelectable = true;
            this.tb_Account.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Account.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lb_Account
            // 
            this.lb_Account.AutoSize = true;
            this.lb_Account.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_Account.Location = new System.Drawing.Point(7, 18);
            this.lb_Account.Name = "lb_Account";
            this.lb_Account.Size = new System.Drawing.Size(50, 25);
            this.lb_Account.TabIndex = 5;
            this.lb_Account.Text = "帳號";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_Password.Location = new System.Drawing.Point(7, 44);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(50, 25);
            this.lb_Password.TabIndex = 4;
            this.lb_Password.Text = "密碼";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_Name.Location = new System.Drawing.Point(7, 70);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(50, 25);
            this.lb_Name.TabIndex = 3;
            this.lb_Name.Text = "姓名";
            // 
            // btn_Delete
            // 
            this.btn_Delete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Delete.Location = new System.Drawing.Point(192, 98);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(77, 74);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "刪除";
            this.btn_Delete.UseSelectable = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Update.Location = new System.Drawing.Point(99, 98);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(78, 74);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "修改";
            this.btn_Update.UseSelectable = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Insert.Location = new System.Drawing.Point(6, 98);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(78, 74);
            this.btn_Insert.TabIndex = 0;
            this.btn_Insert.Text = "新增";
            this.btn_Insert.UseSelectable = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // grid_Users
            // 
            this.grid_Users.AllowUserToAddRows = false;
            this.grid_Users.AllowUserToDeleteRows = false;
            this.grid_Users.AllowUserToResizeRows = false;
            this.grid_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_Users.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_Users.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_Users.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_Users.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Users.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_Users.EnableHeadersVisualStyles = false;
            this.grid_Users.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_Users.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_Users.Location = new System.Drawing.Point(24, 63);
            this.grid_Users.Name = "grid_Users";
            this.grid_Users.ReadOnly = true;
            this.grid_Users.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Users.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_Users.RowHeadersVisible = false;
            this.grid_Users.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_Users.RowTemplate.Height = 24;
            this.grid_Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Users.Size = new System.Drawing.Size(373, 315);
            this.grid_Users.TabIndex = 1;
            this.grid_Users.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_Users_CellMouseClick);
            // 
            // AccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 579);
            this.Controls.Add(this.grid_Users);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountManager";
            this.Resizable = false;
            this.Text = "AccountManager";
            this.Load += new System.EventHandler(this.AccountManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Users)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel lb_Name;
        private MetroFramework.Controls.MetroButton btn_Delete;
        private MetroFramework.Controls.MetroButton btn_Update;
        private MetroFramework.Controls.MetroButton btn_Insert;
        private MetroFramework.Controls.MetroTextBox tb_Name;
        private MetroFramework.Controls.MetroTextBox tb_Password;
        private MetroFramework.Controls.MetroTextBox tb_Account;
        private MetroFramework.Controls.MetroLabel lb_Account;
        private MetroFramework.Controls.MetroLabel lb_Password;
        private MetroFramework.Controls.MetroGrid grid_Users;
        private MetroFramework.Controls.MetroButton btn_Clear;
    }
}