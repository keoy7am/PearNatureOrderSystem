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
    public partial class TableManager : DialogBase
    {
        TableServices _tableService;
        public TableManager()
        {
            InitializeComponent();
            _tableService = new TableServices();
        }
        private void TableManager_Load(object sender, EventArgs e)
        {
            TableServices.TableChanged += (reload);
            reload();
        }
        private void reload()
        {
            grid_Tables.DataSource = TableServices.GetTableSource();
            InitGridView();
        }
        private void InitGridView()
        {
            try
            {
                grid_Tables.Columns["Id"].Visible = false;

                //grid_Tables.Columns["Id"].HeaderText = "編號";
                grid_Tables.Columns["Name"].HeaderText = "桌號名稱";
                grid_Tables.Columns["Desc"].HeaderText = "桌號敘述";
            }
            catch (Exception ex)
            {
                //log here
            }
        }
        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckInput()) { return; }
                TableModel tableModel = new TableModel();
                tableModel.Name = tb_TableName.Text.Trim();
                tableModel.Desc = tb_TableDesc.Text.Trim();

                if (!_tableService.InsertTable(tableModel))
                {
                    MetroMessageBox.Show(this, "新增桌號失敗！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }catch(Exception ex)
            {
                // log here
                MetroMessageBox.Show(this, $"新增桌號失敗，錯誤資訊：{ex.Message}。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                TableModel tableModel = new TableModel();
                tableModel.Id = Convert.ToInt64(grid_Tables.SelectedRows[0].Cells["Id"].Value);
                tableModel.Name = tb_TableName.Text.Trim();
                tableModel.Desc = tb_TableDesc.Text.Trim();
                
                if (!_tableService.UpdateTable(tableModel))
                {
                    MetroMessageBox.Show(this, "更新桌號失敗！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"更新桌號失敗，錯誤資訊：{ex.Message}。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MetroMessageBox.Show(this, $"\n\n是否確定要刪除 {tb_TableName.Text} ?", "訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.No == dr) { return; }
                long tableId = Convert.ToInt64(grid_Tables.SelectedRows[0].Cells["Id"].Value);
                
                if (!_tableService.DeleteTable(tableId))
                {
                    MetroMessageBox.Show(this, "刪除桌號失敗！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"刪除桌號失敗，錯誤資訊：{ex.Message}。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_TableName.Clear();
            tb_TableDesc.Clear();
        }
        private bool CheckInput()
        {
            if (tb_TableName.Text.Trim() == String.Empty)
            {
                MetroMessageBox.Show(this, "請輸入桌號名稱！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_TableName.Focus();
                return false;
            }
            //if (tb_TableDesc.Text.Trim() == String.Empty)
            //{
            //    MetroMessageBox.Show(this, "請輸入桌號敘述！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    tb_TableDesc.Focus();
            //    return false;
            //}
            return true;
        }

        private void grid_Tables_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            tb_TableName.Text = grid_Tables.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            tb_TableDesc.Text = grid_Tables.Rows[e.RowIndex].Cells["Desc"].Value.ToString();
        }
    }
}
