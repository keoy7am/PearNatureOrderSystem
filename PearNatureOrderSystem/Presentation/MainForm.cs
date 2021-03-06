﻿using MetroFramework;
using PearNatureOrderSystem.Library;
using PearNatureOrderSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PearNatureOrderSystem.Presentation
{
    public partial class MainForm : BaseForm
    {
        System.Threading.Timer ThreadTimer; // 控制背景狀態更新
        public MainForm()
        {
            InitializeComponent();

            // 背景狀態更新 Timer
            ThreadTimer = new System.Threading.Timer(StatusUpdater, null, 0, 1000);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            /* 預設程式為最頂層顯示及最大化 */
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            CategoryServices.CategoryChanged += (ReloadCategory);
            CategoryServices.ProductChanged += (ReloadProduct);
            OrderServices.OrderCartChanged += (ReloadOrderCart);
            TableServices.TableChanged += (ReloadTable);
            ResetForm();
        }
        
        #region 控制項事件

        #region 登出
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            ResetForm();
            this.Hide();
            FormController.loginForm.Show();
            Appdata.loginUser = null;
        }
        #endregion
        #region grid_cate 點擊分類時刷新商品清單
        private void grid_cate_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            try
            {
                ReloadProduct();
            }
            catch (Exception ex)
            {
                // log here
                MetroMessageBox.Show(this, $"更新商品清單失敗，錯誤資訊：{ex.Message}。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
        #region grid_prod 單擊商品時開啟商品加入表單
        private void grid_prod_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            int cateId = Convert.ToInt32(grid_cate.SelectedRows[0].Cells["Id"].Value);
            int prodId = Convert.ToInt32(grid_prod.SelectedRows[0].Cells["Id"].Value);

            var products = CategoryServices.QueryProductsByCateId(cateId);
            var product = products.FirstOrDefault(x => x.Id == prodId);
            new OrderForm(product).ShowDialog();
        }
        #endregion
        #region btn_ClearOrderList 清除訂單
        private void btn_ClearOrderList_Click(object sender, EventArgs e)
        {
            OrderServices.ResetOrderCart();
        }
        #endregion
        #region btn_ClearOrderSelected 移除指定品項
        private void btn_ClearOrderSelected_Click(object sender, EventArgs e)
        {
            try
            {
                int orderId = Convert.ToInt32(grid_OrderCart.SelectedRows[0].Cells["Id"].Value);
                OrderServices.RemoveFromCart(orderId);
                foreach (DataGridViewRow dgvr in grid_OrderCart.Rows)
                {
                    if (dgvr.Selected == true)
                    {
                        grid_OrderCart.Rows.Remove(dgvr);
                    }
                }

            }
            catch(Exception ex)
            {
                // log here
            }
        }
        #endregion
        #endregion

        #region Manager
        private void btn_ProductManager_Click(object sender, EventArgs e)
        {
            new ProductManager().ShowDialog();
        }
        private void btn_AccountManager_Click(object sender, EventArgs e)
        {
            new AccountManager().ShowDialog();
        }

        private void btn_ChangePassword_Click(object sender, EventArgs e)
        {
            new ChangePasswordForm().ShowDialog();
        }

        private void btn_TableManager_Click(object sender, EventArgs e)
        {
            new TableManager().ShowDialog();
        }

        private void btn_OrderManager_Click(object sender, EventArgs e)
        {
            new OrderManager().ShowDialog();
        }
        private void btn_RemarkManager_Click(object sender, EventArgs e)
        {
            new RemarkManager().ShowDialog();
        }
        #endregion

        #region UI
        /// <summary>
        /// 權限檢查
        /// </summary>
        public void CheckUserAuth()
        {
            // 進階功能開關
            if (Appdata.loginUser.isAdmin)
            {
                btn_AccountManager.Visible = true;
                btn_ProductManager.Visible = true;
                btn_OrderManager.Visible = true;
                btn_TableManager.Visible = true;
                btn_RemarkManager.Visible = true;
            }
            else
            {
                btn_AccountManager.Visible = false;
                btn_ProductManager.Visible = false;
                btn_OrderManager.Visible = false;
                btn_TableManager.Visible = false;
                btn_RemarkManager.Visible = false;
            }

            lb_LoginUser.Text = $"使用者：{Appdata.loginUser.Name}";
        }
        /// <summary>
        /// 重置Form
        /// </summary>
        private void ResetForm()
        {
            CheckUserAuth();
            ReloadCategory();
            ReloadTable();
            OrderServices.ResetOrderCart();
        }
        /// <summary>
        /// 刷新分類清單
        /// </summary>
        private void ReloadCategory()
        {
            grid_cate.DataSource = CategoryServices.GetCateSource();
            InitCateGridView();
            grid_cate.ClearSelection();
            grid_prod.DataSource = null;
        }
        /// <summary>
        /// 刷新產品清單 (依照已選分類項目)
        /// </summary>
        private void ReloadProduct()
        {
            try
            {
                int cateId = Convert.ToInt32(grid_cate.SelectedRows[0].Cells["Id"].Value);
                grid_prod.DataSource = CategoryServices.GetProductSourceByCateID(cateId);
                InitProdGridView();
            }
            catch (Exception ex)
            {

            }
        }
        /// <summary>
        /// 刷新訂單列表
        /// </summary>
        private void ReloadOrderCart()
        {
            try
            {
                grid_OrderCart.DataSource = OrderServices.GetOrderCartSource();
                InitOrderCartGridView();
                grid_OrderCart.ClearSelection();
                lb_totalPrice.Text = $"總金額： {OrderServices.GetTotalPrice()}";
            }
            catch (Exception ex)
            {

            }
        }
        private void ReloadTable()
        {
            try
            {
                cb_Table.DataSource = TableServices.GetTableSource(false);
                cb_Table.DisplayMember = "Name";
                cb_Table.ValueMember = "Name";
            }
            catch(Exception ex)
            {

            }
        }
        /// <summary>
        /// 定義分類清單標頭
        /// </summary>
        private void InitCateGridView()
        {
            try
            {
                grid_cate.Columns["Id"].Visible = false;

                //grid_cate.Columns["Id"].HeaderText = "編號";
                grid_cate.Columns["Name"].HeaderText = "分類名稱";
            }
            catch (Exception ex)
            {
                //log here
            }
        }
        /// <summary>
        /// 定義商品清單標頭
        /// </summary>
        private void InitProdGridView()
        {
            try
            {
                grid_prod.Columns["Id"].Visible = false;
                grid_prod.Columns["Price"].Visible = false;
                grid_prod.Columns["MealPrice"].Visible = false;

                //grid_prod.Columns["Id"].HeaderText = "編號";
                grid_prod.Columns["Name"].HeaderText = "商品名稱";
                //grid_prod.Columns["Price"].HeaderText = "商品定價";
                //grid_prod.Columns["MealPrice"].HeaderText = "套餐價格";
            }
            catch (Exception ex)
            {
                //log here
            }
        }
        /// <summary>
        /// 定義訂單標頭
        /// </summary>
        private void InitOrderCartGridView()
        {
            try
            {
                grid_OrderCart.Columns["Id"].Visible = false;
                grid_OrderCart.Columns["Price"].Visible = false;
                grid_OrderCart.Columns["MealPrice"].Visible = false;
                grid_OrderCart.Columns["isMeal"].Visible = false;
                grid_OrderCart.Columns["isMealMaster"].Visible = false;

                grid_OrderCart.Columns["Name"].HeaderText = "商品名稱";
                grid_OrderCart.Columns["Count"].HeaderText = "數量";
                grid_OrderCart.Columns["TotalPrice"].HeaderText = "總金額";


                //grid_OrderCart.Columns["Name"].Width = 220;
                grid_OrderCart.Columns["Count"].Width = 60;
                grid_OrderCart.Columns["TotalPrice"].Width = 80;
            }
            catch (Exception ex)
            {
                //log here
            }
        }
        #endregion

        #region MISC

        /// <summary>
        /// 背景狀態檢查
        /// </summary>
        /// <param name="o"></param>
        private void StatusUpdater(object o)
        {
            try
            {
                UpdateTimeStatus();
            }
            catch (Exception ex)
            {
                //log here
            }
        }
        public void UpdateTimeStatus()
        {
            var now = DateTime.Now;
            this.Invoke(new Action(() =>
            {
                lb_time.Text = now.ToLongTimeString();
            }));
        }
        #endregion

        private void btn_Print_Click(object sender, EventArgs e)
        {
            try
            {

                if (cb_Table.SelectedValue == null || cb_Table.SelectedValue.ToString().Length <= 0)
                {
                    MetroMessageBox.Show(this, $"請選擇桌號。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (OrderServices.orderCartDetails.Count <= 0)
                {
                    MetroMessageBox.Show(this, $"請先將商品加入訂單列表。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var result = PrintHelper.Print(cb_Table.SelectedValue.ToString());
                if (result[0].ToString().ToLower() == "true")
                {
                    OrderServices.ResetOrderCart();
                    //OrderServices.AddRecord();
                }
                else
                {
                    MetroMessageBox.Show(this, $"列印失敗。 錯誤訊息：{result[1].ToString()}", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"列印失敗。 錯誤訊息：{ex.Message}", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// 使程式無法移動
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Move(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
        }
    }
}
