namespace PearNatureOrderSystem.Presentation
{
    partial class OrderForm
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Cancle = new System.Windows.Forms.Button();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Count = new System.Windows.Forms.Label();
            this.lb_Price = new System.Windows.Forms.Label();
            this.lb_Total = new System.Windows.Forms.Label();
            this.cb_IsMealPrice = new System.Windows.Forms.CheckBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.tb_TotalPrice = new System.Windows.Forms.TextBox();
            this.cb_IsMealMaster = new System.Windows.Forms.CheckBox();
            this.tb_Count = new MetroFramework.Controls.MetroTextBox();
            this.btn_NumUp = new MetroFramework.Controls.MetroTile();
            this.btn_NumDown = new MetroFramework.Controls.MetroTile();
            this.lb_Remark = new System.Windows.Forms.Label();
            this.grid_Remarks = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Remarks)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Submit.Location = new System.Drawing.Point(10, 414);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(199, 112);
            this.btn_Submit.TabIndex = 0;
            this.btn_Submit.Text = "加入";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Cancle.Location = new System.Drawing.Point(227, 414);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(199, 112);
            this.btn_Cancle.TabIndex = 1;
            this.btn_Cancle.Text = "取消";
            this.btn_Cancle.UseVisualStyleBackColor = true;
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Cancle_Click);
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Name.Location = new System.Drawing.Point(12, 75);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(104, 37);
            this.lb_Name.TabIndex = 2;
            this.lb_Name.Text = "品名：";
            // 
            // lb_Count
            // 
            this.lb_Count.AutoSize = true;
            this.lb_Count.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Count.Location = new System.Drawing.Point(12, 117);
            this.lb_Count.Name = "lb_Count";
            this.lb_Count.Size = new System.Drawing.Size(104, 37);
            this.lb_Count.TabIndex = 3;
            this.lb_Count.Text = "數量：";
            // 
            // lb_Price
            // 
            this.lb_Price.AutoSize = true;
            this.lb_Price.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Price.Location = new System.Drawing.Point(10, 290);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(104, 37);
            this.lb_Price.TabIndex = 4;
            this.lb_Price.Text = "單價：";
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Total.Location = new System.Drawing.Point(10, 327);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(133, 37);
            this.lb_Total.TabIndex = 5;
            this.lb_Total.Text = "總金額：";
            // 
            // cb_IsMealPrice
            // 
            this.cb_IsMealPrice.AutoSize = true;
            this.cb_IsMealPrice.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_IsMealPrice.Location = new System.Drawing.Point(14, 370);
            this.cb_IsMealPrice.Name = "cb_IsMealPrice";
            this.cb_IsMealPrice.Size = new System.Drawing.Size(181, 41);
            this.cb_IsMealPrice.TabIndex = 6;
            this.cb_IsMealPrice.Text = "是否為套餐";
            this.cb_IsMealPrice.UseVisualStyleBackColor = true;
            this.cb_IsMealPrice.CheckedChanged += new System.EventHandler(this.cb_IsMealPrice_CheckedChanged);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Name.Location = new System.Drawing.Point(144, 79);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.ReadOnly = true;
            this.tb_Name.Size = new System.Drawing.Size(282, 35);
            this.tb_Name.TabIndex = 7;
            // 
            // tb_Price
            // 
            this.tb_Price.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_Price.Location = new System.Drawing.Point(143, 294);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.ReadOnly = true;
            this.tb_Price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_Price.Size = new System.Drawing.Size(283, 35);
            this.tb_Price.TabIndex = 9;
            // 
            // tb_TotalPrice
            // 
            this.tb_TotalPrice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_TotalPrice.Location = new System.Drawing.Point(143, 331);
            this.tb_TotalPrice.Name = "tb_TotalPrice";
            this.tb_TotalPrice.ReadOnly = true;
            this.tb_TotalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tb_TotalPrice.Size = new System.Drawing.Size(283, 35);
            this.tb_TotalPrice.TabIndex = 10;
            // 
            // cb_IsMealMaster
            // 
            this.cb_IsMealMaster.AutoSize = true;
            this.cb_IsMealMaster.Enabled = false;
            this.cb_IsMealMaster.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cb_IsMealMaster.Location = new System.Drawing.Point(231, 373);
            this.cb_IsMealMaster.Name = "cb_IsMealMaster";
            this.cb_IsMealMaster.Size = new System.Drawing.Size(181, 41);
            this.cb_IsMealMaster.TabIndex = 12;
            this.cb_IsMealMaster.Text = "是否為主食";
            this.cb_IsMealMaster.UseVisualStyleBackColor = true;
            this.cb_IsMealMaster.CheckedChanged += new System.EventHandler(this.cb_IsMealMaster_CheckedChanged);
            // 
            // tb_Count
            // 
            // 
            // 
            // 
            this.tb_Count.CustomButton.Image = null;
            this.tb_Count.CustomButton.Location = new System.Drawing.Point(260, 1);
            this.tb_Count.CustomButton.Name = "";
            this.tb_Count.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_Count.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Count.CustomButton.TabIndex = 1;
            this.tb_Count.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Count.CustomButton.UseSelectable = true;
            this.tb_Count.CustomButton.Visible = false;
            this.tb_Count.Enabled = false;
            this.tb_Count.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_Count.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.tb_Count.Lines = new string[] {
        "1"};
            this.tb_Count.Location = new System.Drawing.Point(144, 126);
            this.tb_Count.MaxLength = 100;
            this.tb_Count.Name = "tb_Count";
            this.tb_Count.PasswordChar = '\0';
            this.tb_Count.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Count.SelectedText = "";
            this.tb_Count.SelectionLength = 0;
            this.tb_Count.SelectionStart = 0;
            this.tb_Count.ShortcutsEnabled = true;
            this.tb_Count.Size = new System.Drawing.Size(282, 23);
            this.tb_Count.TabIndex = 13;
            this.tb_Count.Text = "1";
            this.tb_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_Count.UseSelectable = true;
            this.tb_Count.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Count.WaterMarkFont = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_NumUp
            // 
            this.btn_NumUp.ActiveControl = null;
            this.btn_NumUp.Location = new System.Drawing.Point(299, 155);
            this.btn_NumUp.Name = "btn_NumUp";
            this.btn_NumUp.Size = new System.Drawing.Size(127, 134);
            this.btn_NumUp.TabIndex = 14;
            this.btn_NumUp.Text = "↑";
            this.btn_NumUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_NumUp.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_NumUp.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_NumUp.UseSelectable = true;
            this.btn_NumUp.Click += new System.EventHandler(this.btn_NumUp_Click);
            // 
            // btn_NumDown
            // 
            this.btn_NumDown.ActiveControl = null;
            this.btn_NumDown.Location = new System.Drawing.Point(144, 155);
            this.btn_NumDown.Name = "btn_NumDown";
            this.btn_NumDown.Size = new System.Drawing.Size(127, 134);
            this.btn_NumDown.TabIndex = 15;
            this.btn_NumDown.Text = "↓";
            this.btn_NumDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_NumDown.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btn_NumDown.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btn_NumDown.UseSelectable = true;
            this.btn_NumDown.Click += new System.EventHandler(this.btn_NumDown_Click);
            // 
            // lb_Remark
            // 
            this.lb_Remark.AutoSize = true;
            this.lb_Remark.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_Remark.Location = new System.Drawing.Point(449, 77);
            this.lb_Remark.Name = "lb_Remark";
            this.lb_Remark.Size = new System.Drawing.Size(75, 37);
            this.lb_Remark.TabIndex = 17;
            this.lb_Remark.Text = "備註";
            // 
            // grid_Remarks
            // 
            this.grid_Remarks.AllowUserToAddRows = false;
            this.grid_Remarks.AllowUserToDeleteRows = false;
            this.grid_Remarks.AllowUserToResizeRows = false;
            this.grid_Remarks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_Remarks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_Remarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_Remarks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_Remarks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Remarks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_Remarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Remarks.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_Remarks.EnableHeadersVisualStyles = false;
            this.grid_Remarks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_Remarks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_Remarks.Location = new System.Drawing.Point(456, 117);
            this.grid_Remarks.Name = "grid_Remarks";
            this.grid_Remarks.ReadOnly = true;
            this.grid_Remarks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Remarks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_Remarks.RowHeadersVisible = false;
            this.grid_Remarks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_Remarks.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grid_Remarks.RowTemplate.Height = 40;
            this.grid_Remarks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Remarks.Size = new System.Drawing.Size(368, 409);
            this.grid_Remarks.TabIndex = 18;
            this.grid_Remarks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Remarks_CellContentClick);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 549);
            this.Controls.Add(this.grid_Remarks);
            this.Controls.Add(this.lb_Remark);
            this.Controls.Add(this.btn_NumDown);
            this.Controls.Add(this.btn_NumUp);
            this.Controls.Add(this.tb_Count);
            this.Controls.Add(this.cb_IsMealMaster);
            this.Controls.Add(this.tb_TotalPrice);
            this.Controls.Add(this.tb_Price);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.cb_IsMealPrice);
            this.Controls.Add(this.lb_Total);
            this.Controls.Add(this.lb_Price);
            this.Controls.Add(this.lb_Count);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.btn_Cancle);
            this.Controls.Add(this.btn_Submit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.Resizable = false;
            this.Text = "OrderForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Remarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Cancle;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Count;
        private System.Windows.Forms.Label lb_Price;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.CheckBox cb_IsMealPrice;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.TextBox tb_TotalPrice;
        private System.Windows.Forms.CheckBox cb_IsMealMaster;
        private MetroFramework.Controls.MetroTextBox tb_Count;
        private MetroFramework.Controls.MetroTile btn_NumUp;
        private MetroFramework.Controls.MetroTile btn_NumDown;
        private System.Windows.Forms.Label lb_Remark;
        private MetroFramework.Controls.MetroGrid grid_Remarks;
    }
}