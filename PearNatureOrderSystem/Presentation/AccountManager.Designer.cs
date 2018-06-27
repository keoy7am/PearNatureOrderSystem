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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Insert = new MetroFramework.Controls.MetroButton();
            this.btn_Update = new MetroFramework.Controls.MetroButton();
            this.btn_Delete = new MetroFramework.Controls.MetroButton();
            this.lb_Name = new MetroFramework.Controls.MetroLabel();
            this.lb_Password = new MetroFramework.Controls.MetroLabel();
            this.lb_Account = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.tb_Account = new MetroFramework.Controls.MetroTextBox();
            this.tb_Password = new MetroFramework.Controls.MetroTextBox();
            this.tb_Name = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Size = new System.Drawing.Size(260, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能列";
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(7, 100);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(79, 74);
            this.btn_Insert.TabIndex = 0;
            this.btn_Insert.Text = "新增";
            this.btn_Insert.UseSelectable = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(92, 100);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(79, 74);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "修改";
            this.btn_Update.UseSelectable = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(177, 100);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(79, 74);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "刪除";
            this.btn_Delete.UseSelectable = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(7, 70);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(37, 19);
            this.lb_Name.TabIndex = 3;
            this.lb_Name.Text = "姓名";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Location = new System.Drawing.Point(7, 44);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(37, 19);
            this.lb_Password.TabIndex = 4;
            this.lb_Password.Text = "密碼";
            // 
            // lb_Account
            // 
            this.lb_Account.AutoSize = true;
            this.lb_Account.Location = new System.Drawing.Point(7, 18);
            this.lb_Account.Name = "lb_Account";
            this.lb_Account.Size = new System.Drawing.Size(37, 19);
            this.lb_Account.TabIndex = 5;
            this.lb_Account.Text = "帳號";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle14;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(24, 63);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(260, 315);
            this.metroGrid1.TabIndex = 1;
            // 
            // tb_Account
            // 
            // 
            // 
            // 
            this.tb_Account.CustomButton.Image = null;
            this.tb_Account.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tb_Account.CustomButton.Name = "";
            this.tb_Account.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_Account.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Account.CustomButton.TabIndex = 1;
            this.tb_Account.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Account.CustomButton.UseSelectable = true;
            this.tb_Account.CustomButton.Visible = false;
            this.tb_Account.Lines = new string[0];
            this.tb_Account.Location = new System.Drawing.Point(56, 18);
            this.tb_Account.MaxLength = 32767;
            this.tb_Account.Name = "tb_Account";
            this.tb_Account.PasswordChar = '\0';
            this.tb_Account.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Account.SelectedText = "";
            this.tb_Account.SelectionLength = 0;
            this.tb_Account.SelectionStart = 0;
            this.tb_Account.ShortcutsEnabled = true;
            this.tb_Account.Size = new System.Drawing.Size(200, 23);
            this.tb_Account.TabIndex = 6;
            this.tb_Account.UseSelectable = true;
            this.tb_Account.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Account.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_Password
            // 
            // 
            // 
            // 
            this.tb_Password.CustomButton.Image = null;
            this.tb_Password.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tb_Password.CustomButton.Name = "";
            this.tb_Password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Password.CustomButton.TabIndex = 1;
            this.tb_Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Password.CustomButton.UseSelectable = true;
            this.tb_Password.CustomButton.Visible = false;
            this.tb_Password.Lines = new string[0];
            this.tb_Password.Location = new System.Drawing.Point(56, 44);
            this.tb_Password.MaxLength = 32767;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '\0';
            this.tb_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Password.SelectedText = "";
            this.tb_Password.SelectionLength = 0;
            this.tb_Password.SelectionStart = 0;
            this.tb_Password.ShortcutsEnabled = true;
            this.tb_Password.Size = new System.Drawing.Size(200, 23);
            this.tb_Password.TabIndex = 7;
            this.tb_Password.UseSelectable = true;
            this.tb_Password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_Name
            // 
            // 
            // 
            // 
            this.tb_Name.CustomButton.Image = null;
            this.tb_Name.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tb_Name.CustomButton.Name = "";
            this.tb_Name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Name.CustomButton.TabIndex = 1;
            this.tb_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Name.CustomButton.UseSelectable = true;
            this.tb_Name.CustomButton.Visible = false;
            this.tb_Name.Lines = new string[0];
            this.tb_Name.Location = new System.Drawing.Point(56, 70);
            this.tb_Name.MaxLength = 32767;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.PasswordChar = '\0';
            this.tb_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Name.SelectedText = "";
            this.tb_Name.SelectionLength = 0;
            this.tb_Name.SelectionStart = 0;
            this.tb_Name.ShortcutsEnabled = true;
            this.tb_Name.Size = new System.Drawing.Size(200, 23);
            this.tb_Name.TabIndex = 8;
            this.tb_Name.UseSelectable = true;
            this.tb_Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 579);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AccountManager";
            this.Text = "AccountManager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
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
        private MetroFramework.Controls.MetroGrid metroGrid1;
    }
}