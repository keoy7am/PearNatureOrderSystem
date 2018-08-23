namespace PearNatureOrderSystem.Presentation
{
    partial class ProductManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Cate_Clear = new MetroFramework.Controls.MetroButton();
            this.btn_Cate_Insert = new MetroFramework.Controls.MetroButton();
            this.btn_Cate_Delete = new MetroFramework.Controls.MetroButton();
            this.btn_Cate_Update = new MetroFramework.Controls.MetroButton();
            this.lb_Name = new MetroFramework.Controls.MetroLabel();
            this.tb_CategoryName = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_ProductMealPrice = new MetroFramework.Controls.MetroLabel();
            this.tb_ProductMealPrice = new MetroFramework.Controls.MetroTextBox();
            this.btn_Product_Clear = new MetroFramework.Controls.MetroButton();
            this.lb_ProductPrice = new MetroFramework.Controls.MetroLabel();
            this.tb_ProductPrice = new MetroFramework.Controls.MetroTextBox();
            this.lb_ProductName = new MetroFramework.Controls.MetroLabel();
            this.btn_Prod_Insert = new MetroFramework.Controls.MetroButton();
            this.tb_ProductName = new MetroFramework.Controls.MetroTextBox();
            this.btn_Prod_Delete = new MetroFramework.Controls.MetroButton();
            this.btn_Prod_Update = new MetroFramework.Controls.MetroButton();
            this.grid_Category = new MetroFramework.Controls.MetroGrid();
            this.grid_Product = new MetroFramework.Controls.MetroGrid();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(32, 59);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "分類";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(383, 59);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 25);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "品項";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Cate_Clear);
            this.groupBox1.Controls.Add(this.btn_Cate_Insert);
            this.groupBox1.Controls.Add(this.btn_Cate_Delete);
            this.groupBox1.Controls.Add(this.btn_Cate_Update);
            this.groupBox1.Controls.Add(this.lb_Name);
            this.groupBox1.Controls.Add(this.tb_CategoryName);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.groupBox1.Location = new System.Drawing.Point(24, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 244);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分類管理";
            // 
            // btn_Cate_Clear
            // 
            this.btn_Cate_Clear.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Cate_Clear.Location = new System.Drawing.Point(175, 177);
            this.btn_Cate_Clear.Name = "btn_Cate_Clear";
            this.btn_Cate_Clear.Size = new System.Drawing.Size(134, 61);
            this.btn_Cate_Clear.TabIndex = 4;
            this.btn_Cate_Clear.Text = "清除";
            this.btn_Cate_Clear.UseSelectable = true;
            this.btn_Cate_Clear.Click += new System.EventHandler(this.btn_Cate_Clear_Click);
            // 
            // btn_Cate_Insert
            // 
            this.btn_Cate_Insert.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Cate_Insert.Location = new System.Drawing.Point(35, 110);
            this.btn_Cate_Insert.Name = "btn_Cate_Insert";
            this.btn_Cate_Insert.Size = new System.Drawing.Size(134, 61);
            this.btn_Cate_Insert.TabIndex = 1;
            this.btn_Cate_Insert.Text = "新增";
            this.btn_Cate_Insert.UseSelectable = true;
            this.btn_Cate_Insert.Click += new System.EventHandler(this.btn_Cate_Insert_Click);
            // 
            // btn_Cate_Delete
            // 
            this.btn_Cate_Delete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Cate_Delete.Location = new System.Drawing.Point(35, 177);
            this.btn_Cate_Delete.Name = "btn_Cate_Delete";
            this.btn_Cate_Delete.Size = new System.Drawing.Size(134, 61);
            this.btn_Cate_Delete.TabIndex = 3;
            this.btn_Cate_Delete.Text = "刪除";
            this.btn_Cate_Delete.UseSelectable = true;
            this.btn_Cate_Delete.Click += new System.EventHandler(this.btn_Cate_Delete_Click);
            // 
            // btn_Cate_Update
            // 
            this.btn_Cate_Update.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Cate_Update.Location = new System.Drawing.Point(175, 110);
            this.btn_Cate_Update.Name = "btn_Cate_Update";
            this.btn_Cate_Update.Size = new System.Drawing.Size(134, 61);
            this.btn_Cate_Update.TabIndex = 2;
            this.btn_Cate_Update.Text = "更新";
            this.btn_Cate_Update.UseSelectable = true;
            this.btn_Cate_Update.Click += new System.EventHandler(this.btn_Cate_Update_Click);
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_Name.Location = new System.Drawing.Point(35, 29);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(88, 25);
            this.lb_Name.TabIndex = 1;
            this.lb_Name.Text = "分類名稱";
            // 
            // tb_CategoryName
            // 
            // 
            // 
            // 
            this.tb_CategoryName.CustomButton.Image = null;
            this.tb_CategoryName.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.tb_CategoryName.CustomButton.Name = "";
            this.tb_CategoryName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_CategoryName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_CategoryName.CustomButton.TabIndex = 1;
            this.tb_CategoryName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_CategoryName.CustomButton.UseSelectable = true;
            this.tb_CategoryName.CustomButton.Visible = false;
            this.tb_CategoryName.Lines = new string[0];
            this.tb_CategoryName.Location = new System.Drawing.Point(129, 29);
            this.tb_CategoryName.MaxLength = 32767;
            this.tb_CategoryName.Name = "tb_CategoryName";
            this.tb_CategoryName.PasswordChar = '\0';
            this.tb_CategoryName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_CategoryName.SelectedText = "";
            this.tb_CategoryName.SelectionLength = 0;
            this.tb_CategoryName.SelectionStart = 0;
            this.tb_CategoryName.ShortcutsEnabled = true;
            this.tb_CategoryName.Size = new System.Drawing.Size(180, 23);
            this.tb_CategoryName.TabIndex = 0;
            this.tb_CategoryName.UseSelectable = true;
            this.tb_CategoryName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_CategoryName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_ProductMealPrice);
            this.groupBox2.Controls.Add(this.tb_ProductMealPrice);
            this.groupBox2.Controls.Add(this.btn_Product_Clear);
            this.groupBox2.Controls.Add(this.lb_ProductPrice);
            this.groupBox2.Controls.Add(this.tb_ProductPrice);
            this.groupBox2.Controls.Add(this.lb_ProductName);
            this.groupBox2.Controls.Add(this.btn_Prod_Insert);
            this.groupBox2.Controls.Add(this.tb_ProductName);
            this.groupBox2.Controls.Add(this.btn_Prod_Delete);
            this.groupBox2.Controls.Add(this.btn_Prod_Update);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(383, 409);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 244);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "品項管理";
            // 
            // lb_ProductMealPrice
            // 
            this.lb_ProductMealPrice.AutoSize = true;
            this.lb_ProductMealPrice.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_ProductMealPrice.Location = new System.Drawing.Point(38, 82);
            this.lb_ProductMealPrice.Name = "lb_ProductMealPrice";
            this.lb_ProductMealPrice.Size = new System.Drawing.Size(88, 25);
            this.lb_ProductMealPrice.TabIndex = 12;
            this.lb_ProductMealPrice.Text = "套餐價格";
            // 
            // tb_ProductMealPrice
            // 
            // 
            // 
            // 
            this.tb_ProductMealPrice.CustomButton.Image = null;
            this.tb_ProductMealPrice.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.tb_ProductMealPrice.CustomButton.Name = "";
            this.tb_ProductMealPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_ProductMealPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_ProductMealPrice.CustomButton.TabIndex = 1;
            this.tb_ProductMealPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_ProductMealPrice.CustomButton.UseSelectable = true;
            this.tb_ProductMealPrice.CustomButton.Visible = false;
            this.tb_ProductMealPrice.Lines = new string[0];
            this.tb_ProductMealPrice.Location = new System.Drawing.Point(132, 82);
            this.tb_ProductMealPrice.MaxLength = 32767;
            this.tb_ProductMealPrice.Name = "tb_ProductMealPrice";
            this.tb_ProductMealPrice.PasswordChar = '\0';
            this.tb_ProductMealPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_ProductMealPrice.SelectedText = "";
            this.tb_ProductMealPrice.SelectionLength = 0;
            this.tb_ProductMealPrice.SelectionStart = 0;
            this.tb_ProductMealPrice.ShortcutsEnabled = true;
            this.tb_ProductMealPrice.Size = new System.Drawing.Size(180, 23);
            this.tb_ProductMealPrice.TabIndex = 7;
            this.tb_ProductMealPrice.UseSelectable = true;
            this.tb_ProductMealPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_ProductMealPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_Product_Clear
            // 
            this.btn_Product_Clear.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Product_Clear.Location = new System.Drawing.Point(178, 177);
            this.btn_Product_Clear.Name = "btn_Product_Clear";
            this.btn_Product_Clear.Size = new System.Drawing.Size(134, 61);
            this.btn_Product_Clear.TabIndex = 12;
            this.btn_Product_Clear.Text = "清除";
            this.btn_Product_Clear.UseSelectable = true;
            this.btn_Product_Clear.Click += new System.EventHandler(this.btn_Product_Clear_Click);
            // 
            // lb_ProductPrice
            // 
            this.lb_ProductPrice.AutoSize = true;
            this.lb_ProductPrice.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_ProductPrice.Location = new System.Drawing.Point(38, 50);
            this.lb_ProductPrice.Name = "lb_ProductPrice";
            this.lb_ProductPrice.Size = new System.Drawing.Size(88, 25);
            this.lb_ProductPrice.TabIndex = 9;
            this.lb_ProductPrice.Text = "商品定價";
            // 
            // tb_ProductPrice
            // 
            // 
            // 
            // 
            this.tb_ProductPrice.CustomButton.Image = null;
            this.tb_ProductPrice.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.tb_ProductPrice.CustomButton.Name = "";
            this.tb_ProductPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_ProductPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_ProductPrice.CustomButton.TabIndex = 1;
            this.tb_ProductPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_ProductPrice.CustomButton.UseSelectable = true;
            this.tb_ProductPrice.CustomButton.Visible = false;
            this.tb_ProductPrice.Lines = new string[0];
            this.tb_ProductPrice.Location = new System.Drawing.Point(132, 50);
            this.tb_ProductPrice.MaxLength = 32767;
            this.tb_ProductPrice.Name = "tb_ProductPrice";
            this.tb_ProductPrice.PasswordChar = '\0';
            this.tb_ProductPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_ProductPrice.SelectedText = "";
            this.tb_ProductPrice.SelectionLength = 0;
            this.tb_ProductPrice.SelectionStart = 0;
            this.tb_ProductPrice.ShortcutsEnabled = true;
            this.tb_ProductPrice.Size = new System.Drawing.Size(180, 23);
            this.tb_ProductPrice.TabIndex = 6;
            this.tb_ProductPrice.UseSelectable = true;
            this.tb_ProductPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_ProductPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lb_ProductName
            // 
            this.lb_ProductName.AutoSize = true;
            this.lb_ProductName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_ProductName.Location = new System.Drawing.Point(38, 20);
            this.lb_ProductName.Name = "lb_ProductName";
            this.lb_ProductName.Size = new System.Drawing.Size(88, 25);
            this.lb_ProductName.TabIndex = 6;
            this.lb_ProductName.Text = "商品名稱";
            // 
            // btn_Prod_Insert
            // 
            this.btn_Prod_Insert.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Prod_Insert.Location = new System.Drawing.Point(38, 110);
            this.btn_Prod_Insert.Name = "btn_Prod_Insert";
            this.btn_Prod_Insert.Size = new System.Drawing.Size(134, 61);
            this.btn_Prod_Insert.TabIndex = 9;
            this.btn_Prod_Insert.Text = "新增";
            this.btn_Prod_Insert.UseSelectable = true;
            this.btn_Prod_Insert.Click += new System.EventHandler(this.btn_Prod_Insert_Click);
            // 
            // tb_ProductName
            // 
            // 
            // 
            // 
            this.tb_ProductName.CustomButton.Image = null;
            this.tb_ProductName.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.tb_ProductName.CustomButton.Name = "";
            this.tb_ProductName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_ProductName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_ProductName.CustomButton.TabIndex = 1;
            this.tb_ProductName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_ProductName.CustomButton.UseSelectable = true;
            this.tb_ProductName.CustomButton.Visible = false;
            this.tb_ProductName.Lines = new string[0];
            this.tb_ProductName.Location = new System.Drawing.Point(132, 20);
            this.tb_ProductName.MaxLength = 32767;
            this.tb_ProductName.Name = "tb_ProductName";
            this.tb_ProductName.PasswordChar = '\0';
            this.tb_ProductName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_ProductName.SelectedText = "";
            this.tb_ProductName.SelectionLength = 0;
            this.tb_ProductName.SelectionStart = 0;
            this.tb_ProductName.ShortcutsEnabled = true;
            this.tb_ProductName.Size = new System.Drawing.Size(180, 23);
            this.tb_ProductName.TabIndex = 5;
            this.tb_ProductName.UseSelectable = true;
            this.tb_ProductName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_ProductName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_Prod_Delete
            // 
            this.btn_Prod_Delete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Prod_Delete.Location = new System.Drawing.Point(38, 177);
            this.btn_Prod_Delete.Name = "btn_Prod_Delete";
            this.btn_Prod_Delete.Size = new System.Drawing.Size(134, 61);
            this.btn_Prod_Delete.TabIndex = 11;
            this.btn_Prod_Delete.Text = "刪除";
            this.btn_Prod_Delete.UseSelectable = true;
            this.btn_Prod_Delete.Click += new System.EventHandler(this.btn_Prod_Delete_Click);
            // 
            // btn_Prod_Update
            // 
            this.btn_Prod_Update.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Prod_Update.Location = new System.Drawing.Point(178, 110);
            this.btn_Prod_Update.Name = "btn_Prod_Update";
            this.btn_Prod_Update.Size = new System.Drawing.Size(134, 61);
            this.btn_Prod_Update.TabIndex = 10;
            this.btn_Prod_Update.Text = "更新";
            this.btn_Prod_Update.UseSelectable = true;
            this.btn_Prod_Update.Click += new System.EventHandler(this.btn_Prod_Update_Click);
            // 
            // grid_Category
            // 
            this.grid_Category.AllowUserToAddRows = false;
            this.grid_Category.AllowUserToDeleteRows = false;
            this.grid_Category.AllowUserToResizeRows = false;
            this.grid_Category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_Category.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_Category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_Category.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_Category.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Category.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_Category.EnableHeadersVisualStyles = false;
            this.grid_Category.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_Category.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_Category.Location = new System.Drawing.Point(32, 87);
            this.grid_Category.Name = "grid_Category";
            this.grid_Category.ReadOnly = true;
            this.grid_Category.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Category.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_Category.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_Category.RowTemplate.Height = 24;
            this.grid_Category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Category.Size = new System.Drawing.Size(345, 316);
            this.grid_Category.TabIndex = 23;
            this.grid_Category.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_Category_CellMouseClick);
            // 
            // grid_Product
            // 
            this.grid_Product.AllowUserToAddRows = false;
            this.grid_Product.AllowUserToDeleteRows = false;
            this.grid_Product.AllowUserToResizeRows = false;
            this.grid_Product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_Product.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_Product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_Product.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_Product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Product.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid_Product.EnableHeadersVisualStyles = false;
            this.grid_Product.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_Product.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_Product.Location = new System.Drawing.Point(383, 87);
            this.grid_Product.Name = "grid_Product";
            this.grid_Product.ReadOnly = true;
            this.grid_Product.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Product.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_Product.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_Product.RowTemplate.Height = 24;
            this.grid_Product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Product.Size = new System.Drawing.Size(345, 316);
            this.grid_Product.TabIndex = 22;
            this.grid_Product.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_Product_CellMouseClick);
            // 
            // ProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 676);
            this.Controls.Add(this.grid_Product);
            this.Controls.Add(this.grid_Category);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductManager";
            this.Resizable = false;
            this.Text = "ProductManager";
            this.Load += new System.EventHandler(this.ProductManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btn_Cate_Insert;
        private MetroFramework.Controls.MetroButton btn_Cate_Delete;
        private MetroFramework.Controls.MetroButton btn_Cate_Update;
        private MetroFramework.Controls.MetroLabel lb_Name;
        private MetroFramework.Controls.MetroTextBox tb_CategoryName;
        private MetroFramework.Controls.MetroLabel lb_ProductPrice;
        private MetroFramework.Controls.MetroTextBox tb_ProductPrice;
        private MetroFramework.Controls.MetroLabel lb_ProductName;
        private MetroFramework.Controls.MetroButton btn_Prod_Insert;
        private MetroFramework.Controls.MetroTextBox tb_ProductName;
        private MetroFramework.Controls.MetroButton btn_Prod_Delete;
        private MetroFramework.Controls.MetroButton btn_Prod_Update;
        private MetroFramework.Controls.MetroGrid grid_Category;
        private MetroFramework.Controls.MetroGrid grid_Product;
        private MetroFramework.Controls.MetroButton btn_Cate_Clear;
        private MetroFramework.Controls.MetroButton btn_Product_Clear;
        private MetroFramework.Controls.MetroLabel lb_ProductMealPrice;
        private MetroFramework.Controls.MetroTextBox tb_ProductMealPrice;
    }
}