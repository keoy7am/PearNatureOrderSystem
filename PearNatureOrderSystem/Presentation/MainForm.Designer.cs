namespace PearNatureOrderSystem.Presentation
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_ChangePassword = new MetroFramework.Controls.MetroButton();
            this.btn_Logout = new MetroFramework.Controls.MetroButton();
            this.lb_LoginUser = new MetroFramework.Controls.MetroLabel();
            this.btn_AccountManager = new MetroFramework.Controls.MetroButton();
            this.btn_ProductManager = new MetroFramework.Controls.MetroButton();
            this.lb_totalPrice = new MetroFramework.Controls.MetroLabel();
            this.btn_Print = new MetroFramework.Controls.MetroButton();
            this.btn_ClearOrderList = new MetroFramework.Controls.MetroButton();
            this.lb_time = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lb_list = new MetroFramework.Controls.MetroLabel();
            this.grid_OrderCart = new MetroFramework.Controls.MetroGrid();
            this.lb_prod = new MetroFramework.Controls.MetroLabel();
            this.grid_prod = new MetroFramework.Controls.MetroGrid();
            this.lb_cate = new MetroFramework.Controls.MetroLabel();
            this.grid_cate = new MetroFramework.Controls.MetroGrid();
            this.btn_TableManager = new MetroFramework.Controls.MetroButton();
            this.btn_OrderManager = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_OrderCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_prod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cate)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.Location = new System.Drawing.Point(819, 492);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(117, 41);
            this.btn_ChangePassword.TabIndex = 10;
            this.btn_ChangePassword.Text = "密碼修改";
            this.btn_ChangePassword.UseSelectable = true;
            this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(819, 539);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(117, 41);
            this.btn_Logout.TabIndex = 9;
            this.btn_Logout.Text = "登出";
            this.btn_Logout.UseSelectable = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lb_LoginUser
            // 
            this.lb_LoginUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_LoginUser.AutoSize = true;
            this.lb_LoginUser.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_LoginUser.Location = new System.Drawing.Point(675, 32);
            this.lb_LoginUser.Name = "lb_LoginUser";
            this.lb_LoginUser.Size = new System.Drawing.Size(88, 25);
            this.lb_LoginUser.TabIndex = 8;
            this.lb_LoginUser.Text = "使用者：";
            // 
            // btn_AccountManager
            // 
            this.btn_AccountManager.Location = new System.Drawing.Point(578, 16);
            this.btn_AccountManager.Name = "btn_AccountManager";
            this.btn_AccountManager.Size = new System.Drawing.Size(91, 41);
            this.btn_AccountManager.TabIndex = 7;
            this.btn_AccountManager.Text = "帳號管理";
            this.btn_AccountManager.UseSelectable = true;
            this.btn_AccountManager.Visible = false;
            this.btn_AccountManager.Click += new System.EventHandler(this.btn_AccountManager_Click);
            // 
            // btn_ProductManager
            // 
            this.btn_ProductManager.Location = new System.Drawing.Point(287, 16);
            this.btn_ProductManager.Name = "btn_ProductManager";
            this.btn_ProductManager.Size = new System.Drawing.Size(91, 41);
            this.btn_ProductManager.TabIndex = 6;
            this.btn_ProductManager.Text = "產品管理";
            this.btn_ProductManager.UseSelectable = true;
            this.btn_ProductManager.Visible = false;
            this.btn_ProductManager.Click += new System.EventHandler(this.btn_ProductManager_Click);
            // 
            // lb_totalPrice
            // 
            this.lb_totalPrice.AutoSize = true;
            this.lb_totalPrice.Location = new System.Drawing.Point(664, 477);
            this.lb_totalPrice.Name = "lb_totalPrice";
            this.lb_totalPrice.Size = new System.Drawing.Size(93, 19);
            this.lb_totalPrice.TabIndex = 4;
            this.lb_totalPrice.Text = "總金額：9999";
            // 
            // btn_Print
            // 
            this.btn_Print.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Print.Location = new System.Drawing.Point(567, 455);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(91, 60);
            this.btn_Print.TabIndex = 3;
            this.btn_Print.Text = "列印";
            this.btn_Print.UseSelectable = true;
            // 
            // btn_ClearOrderList
            // 
            this.btn_ClearOrderList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ClearOrderList.Location = new System.Drawing.Point(461, 455);
            this.btn_ClearOrderList.Name = "btn_ClearOrderList";
            this.btn_ClearOrderList.Size = new System.Drawing.Size(91, 60);
            this.btn_ClearOrderList.TabIndex = 2;
            this.btn_ClearOrderList.Text = "清除";
            this.btn_ClearOrderList.UseSelectable = true;
            // 
            // lb_time
            // 
            this.lb_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_time.AutoSize = true;
            this.lb_time.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_time.Location = new System.Drawing.Point(819, 63);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(120, 25);
            this.lb_time.TabIndex = 1;
            this.lb_time.Text = "下午 07:44:45";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.btn_Print);
            this.metroPanel1.Controls.Add(this.lb_list);
            this.metroPanel1.Controls.Add(this.btn_ClearOrderList);
            this.metroPanel1.Controls.Add(this.lb_totalPrice);
            this.metroPanel1.Controls.Add(this.grid_OrderCart);
            this.metroPanel1.Controls.Add(this.lb_prod);
            this.metroPanel1.Controls.Add(this.grid_prod);
            this.metroPanel1.Controls.Add(this.lb_cate);
            this.metroPanel1.Controls.Add(this.grid_cate);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(784, 518);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lb_list
            // 
            this.lb_list.AutoSize = true;
            this.lb_list.Location = new System.Drawing.Point(461, 34);
            this.lb_list.Name = "lb_list";
            this.lb_list.Size = new System.Drawing.Size(65, 19);
            this.lb_list.TabIndex = 7;
            this.lb_list.Text = "已選清單";
            // 
            // grid_OrderCart
            // 
            this.grid_OrderCart.AllowUserToAddRows = false;
            this.grid_OrderCart.AllowUserToDeleteRows = false;
            this.grid_OrderCart.AllowUserToResizeRows = false;
            this.grid_OrderCart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_OrderCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_OrderCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_OrderCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_OrderCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_OrderCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_OrderCart.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_OrderCart.EnableHeadersVisualStyles = false;
            this.grid_OrderCart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_OrderCart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_OrderCart.Location = new System.Drawing.Point(461, 59);
            this.grid_OrderCart.Name = "grid_OrderCart";
            this.grid_OrderCart.ReadOnly = true;
            this.grid_OrderCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_OrderCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_OrderCart.RowHeadersVisible = false;
            this.grid_OrderCart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_OrderCart.RowTemplate.Height = 24;
            this.grid_OrderCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_OrderCart.Size = new System.Drawing.Size(320, 390);
            this.grid_OrderCart.TabIndex = 6;
            // 
            // lb_prod
            // 
            this.lb_prod.AutoSize = true;
            this.lb_prod.Location = new System.Drawing.Point(149, 34);
            this.lb_prod.Name = "lb_prod";
            this.lb_prod.Size = new System.Drawing.Size(37, 19);
            this.lb_prod.TabIndex = 5;
            this.lb_prod.Text = "產品";
            // 
            // grid_prod
            // 
            this.grid_prod.AllowUserToAddRows = false;
            this.grid_prod.AllowUserToDeleteRows = false;
            this.grid_prod.AllowUserToResizeRows = false;
            this.grid_prod.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_prod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_prod.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_prod.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_prod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_prod.DefaultCellStyle = dataGridViewCellStyle5;
            this.grid_prod.EnableHeadersVisualStyles = false;
            this.grid_prod.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_prod.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_prod.Location = new System.Drawing.Point(149, 59);
            this.grid_prod.Name = "grid_prod";
            this.grid_prod.ReadOnly = true;
            this.grid_prod.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_prod.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_prod.RowHeadersVisible = false;
            this.grid_prod.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_prod.RowTemplate.Height = 24;
            this.grid_prod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_prod.Size = new System.Drawing.Size(306, 390);
            this.grid_prod.TabIndex = 4;
            this.grid_prod.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_prod_CellMouseDoubleClick);
            // 
            // lb_cate
            // 
            this.lb_cate.AutoSize = true;
            this.lb_cate.Location = new System.Drawing.Point(4, 34);
            this.lb_cate.Name = "lb_cate";
            this.lb_cate.Size = new System.Drawing.Size(37, 19);
            this.lb_cate.TabIndex = 3;
            this.lb_cate.Text = "分類";
            // 
            // grid_cate
            // 
            this.grid_cate.AllowUserToAddRows = false;
            this.grid_cate.AllowUserToDeleteRows = false;
            this.grid_cate.AllowUserToResizeRows = false;
            this.grid_cate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_cate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_cate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_cate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_cate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grid_cate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_cate.DefaultCellStyle = dataGridViewCellStyle8;
            this.grid_cate.EnableHeadersVisualStyles = false;
            this.grid_cate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_cate.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_cate.Location = new System.Drawing.Point(3, 59);
            this.grid_cate.Name = "grid_cate";
            this.grid_cate.ReadOnly = true;
            this.grid_cate.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_cate.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grid_cate.RowHeadersVisible = false;
            this.grid_cate.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_cate.RowTemplate.Height = 24;
            this.grid_cate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_cate.Size = new System.Drawing.Size(140, 390);
            this.grid_cate.TabIndex = 2;
            this.grid_cate.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_cate_CellMouseClick);
            // 
            // btn_TableManager
            // 
            this.btn_TableManager.Location = new System.Drawing.Point(384, 16);
            this.btn_TableManager.Name = "btn_TableManager";
            this.btn_TableManager.Size = new System.Drawing.Size(91, 41);
            this.btn_TableManager.TabIndex = 11;
            this.btn_TableManager.Text = "桌號管理";
            this.btn_TableManager.UseSelectable = true;
            this.btn_TableManager.Visible = false;
            this.btn_TableManager.Click += new System.EventHandler(this.btn_TableManager_Click);
            // 
            // btn_OrderManager
            // 
            this.btn_OrderManager.Location = new System.Drawing.Point(481, 16);
            this.btn_OrderManager.Name = "btn_OrderManager";
            this.btn_OrderManager.Size = new System.Drawing.Size(91, 41);
            this.btn_OrderManager.TabIndex = 12;
            this.btn_OrderManager.Text = "銷售管理";
            this.btn_OrderManager.UseSelectable = true;
            this.btn_OrderManager.Visible = false;
            this.btn_OrderManager.Click += new System.EventHandler(this.btn_OrderManager_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(962, 604);
            this.Controls.Add(this.btn_OrderManager);
            this.Controls.Add(this.btn_TableManager);
            this.Controls.Add(this.btn_ChangePassword);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.lb_LoginUser);
            this.Controls.Add(this.btn_AccountManager);
            this.Controls.Add(this.btn_ProductManager);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "PearNature Order System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_OrderCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_prod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lb_time;
        private MetroFramework.Controls.MetroLabel lb_list;
        private MetroFramework.Controls.MetroGrid grid_OrderCart;
        private MetroFramework.Controls.MetroLabel lb_prod;
        private MetroFramework.Controls.MetroGrid grid_prod;
        private MetroFramework.Controls.MetroLabel lb_cate;
        private MetroFramework.Controls.MetroGrid grid_cate;
        private MetroFramework.Controls.MetroLabel lb_totalPrice;
        private MetroFramework.Controls.MetroButton btn_Print;
        private MetroFramework.Controls.MetroButton btn_ClearOrderList;
        private MetroFramework.Controls.MetroButton btn_ProductManager;
        private MetroFramework.Controls.MetroButton btn_AccountManager;
        private MetroFramework.Controls.MetroLabel lb_LoginUser;
        private MetroFramework.Controls.MetroButton btn_Logout;
        private MetroFramework.Controls.MetroButton btn_ChangePassword;
        private MetroFramework.Controls.MetroButton btn_TableManager;
        private MetroFramework.Controls.MetroButton btn_OrderManager;
    }
}