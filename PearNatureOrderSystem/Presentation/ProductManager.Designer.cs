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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_CategroyName = new MetroFramework.Controls.MetroTextBox();
            this.lb_Name = new MetroFramework.Controls.MetroLabel();
            this.btn_Cate_Update = new MetroFramework.Controls.MetroButton();
            this.btn_Cate_Insert = new MetroFramework.Controls.MetroButton();
            this.btn_Cate_Delete = new MetroFramework.Controls.MetroButton();
            this.btn_Prod_Insert = new MetroFramework.Controls.MetroButton();
            this.btn_Prod_Delete = new MetroFramework.Controls.MetroButton();
            this.btn_Prod_Update = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 64);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "分類";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(383, 64);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "品項";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(345, 341);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(383, 86);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(345, 341);
            this.dataGridView2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Cate_Insert);
            this.groupBox1.Controls.Add(this.btn_Cate_Delete);
            this.groupBox1.Controls.Add(this.btn_Cate_Update);
            this.groupBox1.Controls.Add(this.lb_Name);
            this.groupBox1.Controls.Add(this.tb_CategroyName);
            this.groupBox1.Location = new System.Drawing.Point(24, 434);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 163);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分類管理";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.metroTextBox2);
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.btn_Prod_Insert);
            this.groupBox2.Controls.Add(this.metroTextBox1);
            this.groupBox2.Controls.Add(this.btn_Prod_Delete);
            this.groupBox2.Controls.Add(this.btn_Prod_Update);
            this.groupBox2.Location = new System.Drawing.Point(383, 434);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 163);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "品項管理";
            // 
            // tb_CategroyName
            // 
            // 
            // 
            // 
            this.tb_CategroyName.CustomButton.Image = null;
            this.tb_CategroyName.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.tb_CategroyName.CustomButton.Name = "";
            this.tb_CategroyName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_CategroyName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_CategroyName.CustomButton.TabIndex = 1;
            this.tb_CategroyName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_CategroyName.CustomButton.UseSelectable = true;
            this.tb_CategroyName.CustomButton.Visible = false;
            this.tb_CategroyName.Lines = new string[0];
            this.tb_CategroyName.Location = new System.Drawing.Point(236, 40);
            this.tb_CategroyName.MaxLength = 32767;
            this.tb_CategroyName.Name = "tb_CategroyName";
            this.tb_CategroyName.PasswordChar = '\0';
            this.tb_CategroyName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_CategroyName.SelectedText = "";
            this.tb_CategroyName.SelectionLength = 0;
            this.tb_CategroyName.SelectionStart = 0;
            this.tb_CategroyName.ShortcutsEnabled = true;
            this.tb_CategroyName.Size = new System.Drawing.Size(75, 23);
            this.tb_CategroyName.TabIndex = 0;
            this.tb_CategroyName.UseSelectable = true;
            this.tb_CategroyName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_CategroyName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(165, 40);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(65, 19);
            this.lb_Name.TabIndex = 1;
            this.lb_Name.Text = "分類名稱";
            // 
            // btn_Cate_Update
            // 
            this.btn_Cate_Update.Location = new System.Drawing.Point(25, 21);
            this.btn_Cate_Update.Name = "btn_Cate_Update";
            this.btn_Cate_Update.Size = new System.Drawing.Size(134, 61);
            this.btn_Cate_Update.TabIndex = 2;
            this.btn_Cate_Update.Text = "更新";
            this.btn_Cate_Update.UseSelectable = true;
            // 
            // btn_Cate_Insert
            // 
            this.btn_Cate_Insert.Location = new System.Drawing.Point(165, 88);
            this.btn_Cate_Insert.Name = "btn_Cate_Insert";
            this.btn_Cate_Insert.Size = new System.Drawing.Size(146, 61);
            this.btn_Cate_Insert.TabIndex = 3;
            this.btn_Cate_Insert.Text = "新增";
            this.btn_Cate_Insert.UseSelectable = true;
            // 
            // btn_Cate_Delete
            // 
            this.btn_Cate_Delete.Location = new System.Drawing.Point(25, 88);
            this.btn_Cate_Delete.Name = "btn_Cate_Delete";
            this.btn_Cate_Delete.Size = new System.Drawing.Size(134, 61);
            this.btn_Cate_Delete.TabIndex = 4;
            this.btn_Cate_Delete.Text = "刪除";
            this.btn_Cate_Delete.UseSelectable = true;
            // 
            // btn_Prod_Insert
            // 
            this.btn_Prod_Insert.Location = new System.Drawing.Point(161, 88);
            this.btn_Prod_Insert.Name = "btn_Prod_Insert";
            this.btn_Prod_Insert.Size = new System.Drawing.Size(146, 61);
            this.btn_Prod_Insert.TabIndex = 6;
            this.btn_Prod_Insert.Text = "新增";
            this.btn_Prod_Insert.UseSelectable = true;
            // 
            // btn_Prod_Delete
            // 
            this.btn_Prod_Delete.Location = new System.Drawing.Point(21, 88);
            this.btn_Prod_Delete.Name = "btn_Prod_Delete";
            this.btn_Prod_Delete.Size = new System.Drawing.Size(134, 61);
            this.btn_Prod_Delete.TabIndex = 7;
            this.btn_Prod_Delete.Text = "刪除";
            this.btn_Prod_Delete.UseSelectable = true;
            // 
            // btn_Prod_Update
            // 
            this.btn_Prod_Update.Location = new System.Drawing.Point(21, 21);
            this.btn_Prod_Update.Name = "btn_Prod_Update";
            this.btn_Prod_Update.Size = new System.Drawing.Size(134, 61);
            this.btn_Prod_Update.TabIndex = 5;
            this.btn_Prod_Update.Text = "更新";
            this.btn_Prod_Update.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(161, 21);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "商品名稱";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(232, 21);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(75, 23);
            this.metroTextBox1.TabIndex = 5;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(161, 59);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "商品價格";
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(232, 59);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(75, 23);
            this.metroTextBox2.TabIndex = 8;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 614);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ProductManager";
            this.Text = "ProductManager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btn_Cate_Insert;
        private MetroFramework.Controls.MetroButton btn_Cate_Delete;
        private MetroFramework.Controls.MetroButton btn_Cate_Update;
        private MetroFramework.Controls.MetroLabel lb_Name;
        private MetroFramework.Controls.MetroTextBox tb_CategroyName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btn_Prod_Insert;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton btn_Prod_Delete;
        private MetroFramework.Controls.MetroButton btn_Prod_Update;
    }
}