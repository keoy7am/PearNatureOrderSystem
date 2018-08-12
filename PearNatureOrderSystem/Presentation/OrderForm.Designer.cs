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
            this.tb_Count = new System.Windows.Forms.NumericUpDown();
            this.cb_IsMealMaster = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Count)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(23, 237);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(127, 69);
            this.btn_Submit.TabIndex = 0;
            this.btn_Submit.Text = "加入";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.Location = new System.Drawing.Point(156, 237);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(127, 69);
            this.btn_Cancle.TabIndex = 1;
            this.btn_Cancle.Text = "取消";
            this.btn_Cancle.UseVisualStyleBackColor = true;
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Cancle_Click);
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(24, 78);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(41, 12);
            this.lb_Name.TabIndex = 2;
            this.lb_Name.Text = "品名：";
            // 
            // lb_Count
            // 
            this.lb_Count.AutoSize = true;
            this.lb_Count.Location = new System.Drawing.Point(24, 105);
            this.lb_Count.Name = "lb_Count";
            this.lb_Count.Size = new System.Drawing.Size(41, 12);
            this.lb_Count.TabIndex = 3;
            this.lb_Count.Text = "數量：";
            // 
            // lb_Price
            // 
            this.lb_Price.AutoSize = true;
            this.lb_Price.Location = new System.Drawing.Point(24, 133);
            this.lb_Price.Name = "lb_Price";
            this.lb_Price.Size = new System.Drawing.Size(41, 12);
            this.lb_Price.TabIndex = 4;
            this.lb_Price.Text = "單價：";
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.Location = new System.Drawing.Point(24, 163);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(53, 12);
            this.lb_Total.TabIndex = 5;
            this.lb_Total.Text = "總金額：";
            // 
            // cb_IsMealPrice
            // 
            this.cb_IsMealPrice.AutoSize = true;
            this.cb_IsMealPrice.Location = new System.Drawing.Point(23, 194);
            this.cb_IsMealPrice.Name = "cb_IsMealPrice";
            this.cb_IsMealPrice.Size = new System.Drawing.Size(84, 16);
            this.cb_IsMealPrice.TabIndex = 6;
            this.cb_IsMealPrice.Text = "是否為套餐";
            this.cb_IsMealPrice.UseVisualStyleBackColor = true;
            this.cb_IsMealPrice.CheckedChanged += new System.EventHandler(this.cb_IsMealPrice_CheckedChanged);
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(88, 72);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.ReadOnly = true;
            this.tb_Name.Size = new System.Drawing.Size(194, 22);
            this.tb_Name.TabIndex = 7;
            // 
            // tb_Price
            // 
            this.tb_Price.Location = new System.Drawing.Point(88, 128);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.ReadOnly = true;
            this.tb_Price.Size = new System.Drawing.Size(195, 22);
            this.tb_Price.TabIndex = 9;
            // 
            // tb_TotalPrice
            // 
            this.tb_TotalPrice.Location = new System.Drawing.Point(88, 157);
            this.tb_TotalPrice.Name = "tb_TotalPrice";
            this.tb_TotalPrice.ReadOnly = true;
            this.tb_TotalPrice.Size = new System.Drawing.Size(195, 22);
            this.tb_TotalPrice.TabIndex = 10;
            // 
            // tb_Count
            // 
            this.tb_Count.Location = new System.Drawing.Point(88, 100);
            this.tb_Count.Name = "tb_Count";
            this.tb_Count.Size = new System.Drawing.Size(195, 22);
            this.tb_Count.TabIndex = 11;
            this.tb_Count.ValueChanged += new System.EventHandler(this.tb_Count_ValueChanged);
            // 
            // cb_IsMealMaster
            // 
            this.cb_IsMealMaster.AutoSize = true;
            this.cb_IsMealMaster.Enabled = false;
            this.cb_IsMealMaster.Location = new System.Drawing.Point(23, 216);
            this.cb_IsMealMaster.Name = "cb_IsMealMaster";
            this.cb_IsMealMaster.Size = new System.Drawing.Size(84, 16);
            this.cb_IsMealMaster.TabIndex = 12;
            this.cb_IsMealMaster.Text = "是否為主食";
            this.cb_IsMealMaster.UseVisualStyleBackColor = true;
            this.cb_IsMealMaster.CheckedChanged += new System.EventHandler(this.cb_IsMealMaster_CheckedChanged);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 319);
            this.Controls.Add(this.cb_IsMealMaster);
            this.Controls.Add(this.tb_Count);
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
            this.Name = "OrderForm";
            this.Resizable = false;
            this.Text = "OrderForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_Count)).EndInit();
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
        private System.Windows.Forms.NumericUpDown tb_Count;
        private System.Windows.Forms.CheckBox cb_IsMealMaster;
    }
}