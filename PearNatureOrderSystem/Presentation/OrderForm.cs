﻿using MetroFramework;
using PearNatureOrderSystem.Models;
using PearNatureOrderSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PearNatureOrderSystem.Presentation
{
    public partial class OrderForm : DialogBase
    {
        ProductModel product;
        OrderServices _orderServices = new OrderServices();
        OrderDetailModel orderDetail = new OrderDetailModel();
        bool isMeal;
        bool isMealMaster;
        public OrderForm(ProductModel product)
        {
            InitializeComponent();
            this.product = product;
            orderDetail.Name = product.Name;
            orderDetail.Count = 1;
            orderDetail.Price = product.Price;
            orderDetail.TotalPrice = 0;
            RefreshDetail();

            grid_Remarks.DataSource = OrderServices.GetAllRemarks();
            OrderServices.ProductRemarkChanged += RefreshRemarks;
            InitGridView();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            tb_Count.Focus();
            RefreshDetail();
        }
        /// <summary>
        /// 刷新表單
        /// </summary>
        private void RefreshDetail()
        {
            int price;
            bool isDifference = false; // 是否差價
            orderDetail.Price = product.Price;
            orderDetail.MealPrice = product.MealPrice;
            orderDetail.isMeal = isMeal;
            price = orderDetail.Price;
            if (!isMealMaster)
            {
                if (isMeal)
                {
                    orderDetail.Name = $"{product.Name}-套";
                    if (product.Price > product.MealPrice)
                    {
                        price = product.Price - product.MealPrice;
                    }
                    else
                    {
                        price = 0;
                    }
                    isDifference = true;
                }
                else
                {
                    orderDetail.Name = $"{product.Name}";
                }
            }
            else
            {
                orderDetail.Name = $"{product.Name} (*)";
                price = orderDetail.MealPrice;
            }
            orderDetail.TotalPrice = price * orderDetail.Count;
            /* UI */
            tb_Count.Text = orderDetail.Count.ToString();
            tb_Name.Text = orderDetail.Name;
            tb_Price.Text = isDifference ? $"{price.ToString()} (差價)" : price.ToString();
            tb_TotalPrice.Text = isMeal ? $"{orderDetail.TotalPrice}" : $"{orderDetail.TotalPrice}";
        }
        private void RefreshRemarks()
        {
            grid_Remarks.DataSource = OrderServices.GetAllRemarks();
            InitGridView();
        }
        private void InitGridView()
        {
            try
            {
                DataGridViewColumn dgvc = new DataGridViewCheckBoxColumn();
                dgvc.Width = 80;
                dgvc.Name = "選取";

                grid_Remarks.Columns.Insert(0, dgvc);

                grid_Remarks.Columns["Id"].Visible = false;
                grid_Remarks.Columns["Remark"].HeaderText = "備註";
            }
            catch (Exception ex)
            {
                // log here
            }
        }
        private void cb_IsMealPrice_CheckedChanged(object sender, EventArgs e)
        {
            isMeal = cb_IsMealPrice.Checked;
            cb_IsMealMaster.Enabled = isMeal;
            RefreshDetail();
        }

        private void cb_IsMealMaster_CheckedChanged(object sender, EventArgs e)
        {
            isMealMaster = cb_IsMealMaster.Checked;
            RefreshDetail();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (orderDetail.Count > 0)
            {
                orderDetail.ProductRemarks = GetRemarks();
                _orderServices.AddToCart(orderDetail);
                this.Close();
            }
            else
            {
                MetroMessageBox.Show(this, $"商品數量不得為 0 ", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private List<ProductRemark> GetRemarks()
        {
            List<ProductRemark> productRemarks = new List<ProductRemark>();
            try
            {

                foreach (DataGridViewRow dr in grid_Remarks.Rows)
                {
                    if (dr.Cells[0].Value != null && (bool)dr.Cells[0].Value)
                    {
                        try
                        {
                            int id = Convert.ToInt32(dr.Cells["id"].Value);
                            var query = _orderServices.QueryRemarkById(id);
                            productRemarks.Add(query);
                        }
                        catch(Exception ex)
                        {

                        }
                    }
                }
            }
            catch(Exception ex)
            {

            }
            return productRemarks;
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_NumUp_Click(object sender, EventArgs e)
        {
            try
            {
                var count = Convert.ToInt32(tb_Count.Text);
                count++;
                tb_Count.Text = count.ToString();

                orderDetail.Count = Convert.ToInt32(tb_Count.Text);
                RefreshDetail();
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_NumDown_Click(object sender, EventArgs e)
        {
            try
            {
                var count = Convert.ToInt32(tb_Count.Text);
                // 數量不得小於0
                if (count > 0)
                {
                    count--;
                }
                tb_Count.Text = count.ToString();

                orderDetail.Count = Convert.ToInt32(tb_Count.Text);
                RefreshDetail();
            }
            catch (Exception ex)
            {

            }
        }

        private void grid_Remarks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;

                DataGridViewCell cell = grid_Remarks.CurrentCell;
                DataGridViewCheckBoxCell checkCell = (DataGridViewCheckBoxCell)grid_Remarks.Rows[row].Cells[0];
                checkCell.FalseValue = false;
                checkCell.TrueValue = true;
                bool Bool;
                if (checkCell.Value != null)
                {
                    Bool = (bool)checkCell.Value;
                }
                else
                {
                    Bool = false;
                }

                if (Bool == (bool)checkCell.TrueValue)
                {
                    checkCell.Value = checkCell.FalseValue;
                }
                else
                {
                    checkCell.Value = checkCell.TrueValue;
                }
                grid_Remarks.EndEdit();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
