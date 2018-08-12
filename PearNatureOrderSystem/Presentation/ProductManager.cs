using MetroFramework;
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
    public partial class ProductManager : DialogBase
    {
        CategoryServices _categoryServices;
        int SelectedCateId = -1;
        public ProductManager()
        {
            InitializeComponent();
            _categoryServices = new CategoryServices();
        }
        private void ProductManager_Load(object sender, EventArgs e)
        {
            CategoryServices.CategoryChanged += (reload);
            CategoryServices.ProductChanged += (reloadProduct);
            reload();
        }
        private void reload()
        {
            grid_Category.DataSource = CategoryServices.GetCateSource();
            InitCateGridView();
            grid_Category.ClearSelection();
        }
        private void reloadProduct()
        {
            try
            {
                int cateId = Convert.ToInt32(grid_Category.SelectedRows[0].Cells["Id"].Value);
                grid_Product.DataSource = CategoryServices.GetProductSourceByCateID(cateId);
                InitProdGridView();
            }catch(Exception ex)
            {

            }
        }
        private void InitCateGridView()
        {
            try
            {
                grid_Category.Columns["Id"].Visible = false;

                //grid_Category.Columns["Id"].HeaderText = "編號";
                grid_Category.Columns["Name"].HeaderText = "分類名稱";
            }
            catch (Exception ex)
            {
                //log here
            }
        }
        private void InitProdGridView()
        {
            try
            {
                grid_Product.Columns["Id"].Visible = false;

                //grid_Product.Columns["Id"].HeaderText = "編號";
                grid_Product.Columns["Name"].HeaderText = "商品名稱";
                grid_Product.Columns["Price"].HeaderText = "商品定價";
                grid_Product.Columns["MealPrice"].HeaderText = "套餐價格";
            }
            catch (Exception ex)
            {
                //log here
            }
        }
        #region CheckInputs
        private bool CheckCateInput()
        {
            if (tb_CategoryName.Text.Trim() == String.Empty)
            {
                MetroMessageBox.Show(this, "請輸入分類名稱！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_CategoryName.Focus();
                return false;
            }
            return true;
        }
        private bool CheckProdInput()
        {
            if (tb_ProductName.Text.Trim() == String.Empty)
            {
                MetroMessageBox.Show(this, "請輸入商品名稱！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_ProductName.Focus();
                return false;
            }
            if (tb_ProductPrice.Text.Trim() == String.Empty)
            {
                MetroMessageBox.Show(this, "請輸入商品價格！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_ProductPrice.Focus();
                return false;
            }
            if (tb_ProductMealPrice.Text.Trim() == String.Empty)
            {
                MetroMessageBox.Show(this, "請輸入套餐價格！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_ProductMealPrice.Focus();
                return false;
            }
            /* 檢測輸入的價格是否為數字 */
            int price;
            if (!int.TryParse(tb_ProductPrice.Text, out price))
            {
                MetroMessageBox.Show(this, "商品價格只能輸入數字！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_ProductPrice.Focus();
                return false;
            }
            int mealPrice;
            if (!int.TryParse(tb_ProductMealPrice.Text, out mealPrice))
            {
                MetroMessageBox.Show(this, "套餐價格只能輸入數字！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_ProductMealPrice.Focus();
                return false;
            }
            return true;
        }
        #endregion
        #region Category CUD
        private void btn_Cate_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckCateInput()) { return; }
                CategoryModel category  = new CategoryModel();
                category.Name = tb_CategoryName.Text.Trim();
                category.Products = new List<ProductModel>();

                if (!_categoryServices.InsertTable(category))
                {
                    MetroMessageBox.Show(this, "新增分類失敗！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // log here
                MetroMessageBox.Show(this, $"新增分類失敗，錯誤資訊：{ex.Message}。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Cate_Update_Click(object sender, EventArgs e)
        {
            try
            {
                long cateId = Convert.ToInt64(grid_Category.SelectedRows[0].Cells["Id"].Value);
                CategoryModel category = _categoryServices.QueryCategoryById(cateId);
                category.Name = tb_CategoryName.Text.Trim();

                if (!_categoryServices.UpdateTable(category))
                {
                    MetroMessageBox.Show(this, "更新分類失敗！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"更新分類失敗，錯誤資訊：{ex.Message}。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Cate_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MetroMessageBox.Show(this, $"\n\n是否確定要刪除 分類 {grid_Category.SelectedRows[0].Cells["Name"].Value.ToString()} ?", "訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.No == dr) { return; }
                long cateId = Convert.ToInt64(grid_Category.SelectedRows[0].Cells["Id"].Value);

                if (!_categoryServices.DeleteTable(cateId))
                {
                    MetroMessageBox.Show(this, "刪除分類失敗！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"刪除分類失敗，錯誤資訊：{ex.Message}。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
        #region Product CUD
        private void btn_Prod_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckProdInput()) { return; }
                long cateId = Convert.ToInt64(grid_Category.SelectedRows[0].Cells["Id"].Value);
                CategoryModel category = _categoryServices.QueryCategoryById(cateId);
                ProductModel product = new ProductModel();
                if (category.Products.Count > 0)
                {
                    // 取最大id值+1
                    product.Id = category.Products.OrderByDescending(sort => sort.Id).First().Id + 1;
                }
                else { product.Id = category.Products.Count; }
                
                product.Name = tb_ProductName.Text.Trim();
                product.Price = Convert.ToInt32(tb_ProductPrice.Text.Trim());
                product.MealPrice = Convert.ToInt32(tb_ProductMealPrice.Text.Trim());

                category.Products.Add(product);

                if (!_categoryServices.UpdateTable(category,true))
                {
                    MetroMessageBox.Show(this, "新增商品失敗！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"新增商品失敗，錯誤資訊：{ex.Message}。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Prod_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckProdInput()) { return; }
                long cateId = Convert.ToInt64(grid_Category.SelectedRows[0].Cells["Id"].Value);
                long prodId = Convert.ToInt64(grid_Product.SelectedRows[0].Cells["Id"].Value);
                CategoryModel category = _categoryServices.QueryCategoryById(cateId);
                ProductModel product = category.Products.FirstOrDefault(x => x.Id == prodId);

                if (product != null)
                {
                    product.Name = tb_ProductName.Text.Trim();
                    product.Price = Convert.ToInt32(tb_ProductPrice.Text.Trim());
                    product.MealPrice = Convert.ToInt32(tb_ProductMealPrice.Text.Trim());
                }
                else
                {
                    MetroMessageBox.Show(this, "更新商品失敗，商品並不存在！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                if (!_categoryServices.UpdateTable(category,true))
                {
                    MetroMessageBox.Show(this, "更新商品失敗！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"更新商品失敗，錯誤資訊：{ex.Message}。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Prod_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MetroMessageBox.Show(this, $"\n\n是否確定要刪除 商品 {grid_Product.SelectedRows[0].Cells["Name"].Value.ToString()} ?", "訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.No == dr) { return; }
                long cateId = Convert.ToInt64(grid_Category.SelectedRows[0].Cells["Id"].Value);
                long prodId = Convert.ToInt64(grid_Product.SelectedRows[0].Cells["Id"].Value);
                CategoryModel category = _categoryServices.QueryCategoryById(cateId);
                ProductModel product = category.Products.FirstOrDefault(x => x.Id == prodId);
                
                category.Products.Remove(product);

                if (!_categoryServices.UpdateTable(category,true))
                {
                    MetroMessageBox.Show(this, "刪除商品失敗！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"刪除商品失敗，錯誤資訊：{ex.Message}。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        private void grid_Category_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            tb_CategoryName.Text = grid_Category.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            try
            {
                SelectedCateId = Convert.ToInt32(grid_Category.Rows[e.RowIndex].Cells["Id"].Value);
                reloadProduct();
            }
            catch(Exception ex)
            {
                // log here
                MetroMessageBox.Show(this, $"更新商品清單失敗，錯誤資訊：{ex.Message}。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void grid_Product_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            tb_ProductName.Text = grid_Product.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            tb_ProductPrice.Text = grid_Product.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            tb_ProductMealPrice.Text = grid_Product.Rows[e.RowIndex].Cells["MealPrice"].Value.ToString();
        }

        private void btn_Cate_Clear_Click(object sender, EventArgs e)
        {
            tb_CategoryName.Clear();
        }

        private void btn_Product_Clear_Click(object sender, EventArgs e)
        {
            tb_ProductName.Clear();
            tb_ProductPrice.Clear();
            tb_ProductMealPrice.Clear();
        }
    }
}
