namespace PearNatureOrderSystem.Presentation
{
    partial class TableManager
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
            this.grid_Tables = new MetroFramework.Controls.MetroGrid();
            this.btn_Clear = new MetroFramework.Controls.MetroButton();
            this.btn_Delete = new MetroFramework.Controls.MetroButton();
            this.btn_Update = new MetroFramework.Controls.MetroButton();
            this.btn_Insert = new MetroFramework.Controls.MetroButton();
            this.lb_TableName = new MetroFramework.Controls.MetroLabel();
            this.lb_TableDesc = new MetroFramework.Controls.MetroLabel();
            this.tb_TableName = new MetroFramework.Controls.MetroTextBox();
            this.tb_TableDesc = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Tables)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_Tables
            // 
            this.grid_Tables.AllowUserToAddRows = false;
            this.grid_Tables.AllowUserToDeleteRows = false;
            this.grid_Tables.AllowUserToResizeRows = false;
            this.grid_Tables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_Tables.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_Tables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_Tables.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_Tables.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Tables.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_Tables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Tables.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_Tables.EnableHeadersVisualStyles = false;
            this.grid_Tables.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_Tables.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_Tables.Location = new System.Drawing.Point(24, 64);
            this.grid_Tables.Name = "grid_Tables";
            this.grid_Tables.ReadOnly = true;
            this.grid_Tables.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Tables.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_Tables.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_Tables.RowTemplate.Height = 24;
            this.grid_Tables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Tables.Size = new System.Drawing.Size(346, 240);
            this.grid_Tables.TabIndex = 0;
            this.grid_Tables.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_Tables_CellMouseClick);
            // 
            // btn_Clear
            // 
            this.btn_Clear.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Clear.Location = new System.Drawing.Point(298, 399);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(77, 74);
            this.btn_Clear.TabIndex = 13;
            this.btn_Clear.Text = "清除";
            this.btn_Clear.UseSelectable = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Delete.Location = new System.Drawing.Point(200, 399);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(77, 74);
            this.btn_Delete.TabIndex = 12;
            this.btn_Delete.Text = "刪除";
            this.btn_Delete.UseSelectable = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Update.Location = new System.Drawing.Point(107, 399);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(78, 74);
            this.btn_Update.TabIndex = 11;
            this.btn_Update.Text = "修改";
            this.btn_Update.UseSelectable = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Insert.Location = new System.Drawing.Point(14, 399);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(78, 74);
            this.btn_Insert.TabIndex = 10;
            this.btn_Insert.Text = "新增";
            this.btn_Insert.UseSelectable = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // lb_TableName
            // 
            this.lb_TableName.AutoSize = true;
            this.lb_TableName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_TableName.Location = new System.Drawing.Point(24, 311);
            this.lb_TableName.Name = "lb_TableName";
            this.lb_TableName.Size = new System.Drawing.Size(69, 25);
            this.lb_TableName.TabIndex = 14;
            this.lb_TableName.Text = "桌號：";
            // 
            // lb_TableDesc
            // 
            this.lb_TableDesc.AutoSize = true;
            this.lb_TableDesc.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_TableDesc.Location = new System.Drawing.Point(24, 347);
            this.lb_TableDesc.Name = "lb_TableDesc";
            this.lb_TableDesc.Size = new System.Drawing.Size(69, 25);
            this.lb_TableDesc.TabIndex = 15;
            this.lb_TableDesc.Text = "備註：";
            // 
            // tb_TableName
            // 
            // 
            // 
            // 
            this.tb_TableName.CustomButton.Image = null;
            this.tb_TableName.CustomButton.Location = new System.Drawing.Point(248, 1);
            this.tb_TableName.CustomButton.Name = "";
            this.tb_TableName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_TableName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_TableName.CustomButton.TabIndex = 1;
            this.tb_TableName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_TableName.CustomButton.UseSelectable = true;
            this.tb_TableName.CustomButton.Visible = false;
            this.tb_TableName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_TableName.Lines = new string[0];
            this.tb_TableName.Location = new System.Drawing.Point(99, 311);
            this.tb_TableName.MaxLength = 32767;
            this.tb_TableName.Name = "tb_TableName";
            this.tb_TableName.PasswordChar = '\0';
            this.tb_TableName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_TableName.SelectedText = "";
            this.tb_TableName.SelectionLength = 0;
            this.tb_TableName.SelectionStart = 0;
            this.tb_TableName.ShortcutsEnabled = true;
            this.tb_TableName.Size = new System.Drawing.Size(270, 23);
            this.tb_TableName.TabIndex = 16;
            this.tb_TableName.UseSelectable = true;
            this.tb_TableName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_TableName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_TableDesc
            // 
            // 
            // 
            // 
            this.tb_TableDesc.CustomButton.Image = null;
            this.tb_TableDesc.CustomButton.Location = new System.Drawing.Point(248, 1);
            this.tb_TableDesc.CustomButton.Name = "";
            this.tb_TableDesc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_TableDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_TableDesc.CustomButton.TabIndex = 1;
            this.tb_TableDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_TableDesc.CustomButton.UseSelectable = true;
            this.tb_TableDesc.CustomButton.Visible = false;
            this.tb_TableDesc.Lines = new string[0];
            this.tb_TableDesc.Location = new System.Drawing.Point(99, 347);
            this.tb_TableDesc.MaxLength = 32767;
            this.tb_TableDesc.Name = "tb_TableDesc";
            this.tb_TableDesc.PasswordChar = '\0';
            this.tb_TableDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_TableDesc.SelectedText = "";
            this.tb_TableDesc.SelectionLength = 0;
            this.tb_TableDesc.SelectionStart = 0;
            this.tb_TableDesc.ShortcutsEnabled = true;
            this.tb_TableDesc.Size = new System.Drawing.Size(270, 23);
            this.tb_TableDesc.TabIndex = 17;
            this.tb_TableDesc.UseSelectable = true;
            this.tb_TableDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_TableDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 485);
            this.Controls.Add(this.tb_TableDesc);
            this.Controls.Add(this.tb_TableName);
            this.Controls.Add(this.lb_TableDesc);
            this.Controls.Add(this.lb_TableName);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.grid_Tables);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TableManager";
            this.Resizable = false;
            this.Text = "TableManager";
            this.Load += new System.EventHandler(this.TableManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Tables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grid_Tables;
        private MetroFramework.Controls.MetroButton btn_Clear;
        private MetroFramework.Controls.MetroButton btn_Delete;
        private MetroFramework.Controls.MetroButton btn_Update;
        private MetroFramework.Controls.MetroButton btn_Insert;
        private MetroFramework.Controls.MetroLabel lb_TableName;
        private MetroFramework.Controls.MetroLabel lb_TableDesc;
        private MetroFramework.Controls.MetroTextBox tb_TableName;
        private MetroFramework.Controls.MetroTextBox tb_TableDesc;
    }
}