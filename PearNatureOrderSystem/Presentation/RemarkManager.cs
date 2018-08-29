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
    public partial class RemarkManager : DialogBase
    {
        OrderServices _orderServices = new OrderServices();
        public RemarkManager()
        {
            InitializeComponent();
        }

        private void RemarkManager_Load(object sender, EventArgs e)
        {
            grid_Remarks.DataSource = OrderServices.GetAllRemarks();
            OrderServices.ProductRemarkChanged += Reload;
            Reload();
        }
        private void Reload()
        {
            grid_Remarks.DataSource = OrderServices.GetAllRemarks();
            InitGridView();
        }
        private void InitGridView()
        {
            try
            {
                grid_Remarks.Columns["Id"].Visible = false;
                grid_Remarks.Columns["Remark"].HeaderText = "備註";
            }
            catch(Exception ex)
            {
                // log here
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            ProductRemark productRemark = new ProductRemark();
            productRemark.Remark = tb_Remark.Text.Trim();
            _orderServices.InsertRemark(productRemark);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(grid_Remarks.SelectedRows[0].Cells["Id"].Value);
                string remark = tb_Remark.Text.Trim();
                var query = _orderServices.QueryRemarkById(Id);
                if (query == null)
                {
                    throw new Exception("查無資料。");
                }
                query.Remark = remark;
                _orderServices.UpdateRemark(query);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"更新失敗，錯誤資訊：{ex.Message}。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(grid_Remarks.SelectedRows[0].Cells["Id"].Value);
                if (!_orderServices.DeleteRemark(Id))
                {
                    throw new Exception("刪除失敗。");
                }
            }
            catch(Exception ex)
            {
                MetroMessageBox.Show(this, $"更新失敗，錯誤資訊：{ex.Message}。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_Remark.Clear();
        }

        private void grid_Remarks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(grid_Remarks.SelectedRows[0].Cells["Id"].Value);
                var query = _orderServices.QueryRemarkById(Id);
                if (query == null)
                {
                    throw new Exception("查無資料。");
                }
                tb_Remark.Text = query.Remark;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"更新失敗，錯誤資訊：{ex.Message}。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
