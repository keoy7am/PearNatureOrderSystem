using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using PearNatureOrderSystem.Models;
using PearNatureOrderSystem.Services;
using static PearNatureOrderSystem.Library.CommonBase;

namespace PearNatureOrderSystem.Presentation
{
    public partial class AccountManager : DialogBase
    {
        UserServices _userServices;
        private bool accountChange, passwordChange, nameChange; // 判斷是否值有異動
        public AccountManager()
        {
            InitializeComponent();
            _userServices = new UserServices();
        }
        private void AccountManager_Load(object sender, EventArgs e)
        {
            UserServices.UserChanged += new UserServices.UserChangedEvent(reload);
            reload();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            // TODO 檢查 名稱、帳號是否存在
            if (!CustomValidation()) { return; }
            if (!CheckIsNotExist()) { return; }
            try
            {
                UserModel userModel = new UserModel();
                userModel.Id = GetTimeForInt();
                userModel.isAdmin = false;
                userModel.Account = tb_Account.Text.Trim();
                userModel.Password = tb_Password.Text.Trim();
                userModel.SaltKey = MD5.GenerateKey();
                userModel.Name = tb_Name.Text.Trim();
                _userServices.InsertUser(userModel);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"帳號建立失敗，錯誤資訊：{ex.Message}。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // TODO 透過Id檢查可否執行
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (!CustomValidation()) { return; }
            if (!IsExist()) { return; }
            try
            {
                long Id = Convert.ToInt64(grid_Users.SelectedRows[0].Cells["Id"].Value);
                string account = tb_Account.Text.Trim();
                string password = tb_Password.Text.Trim();
                string name = tb_Name.Text.Trim();
                _userServices.UpdateUser(Id, account, password, name);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"帳號更新失敗，錯誤資訊：{ex.Message}。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (!CustomValidation()) { return; }
            string name = grid_Users.SelectedRows[0].Cells["Name"].Value.ToString() ;
            DialogResult dr = MetroMessageBox.Show(this, $"\n\n是否確定要刪除 使用者 {name} ?", "訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.No== dr) { return; }
            long Id = Convert.ToInt64(grid_Users.SelectedRows[0].Cells["Id"].Value);
            _userServices.DeleteUser(Id);
        }


        #region Method
        /// <summary>
        /// 重新讀取
        /// </summary>
        private void reload()
        {
            grid_Users.DataSource = UserServices.GetUserModelSource();
            InitGridView();
            //MaskPasswords();
            ResetFlags();
        }
        /// <summary>
        /// 驗證輸入資訊 True:驗證通過 False:驗證失敗
        /// </summary>
        /// <returns>true:驗證通過 false:驗證失敗</returns>
        private bool CustomValidation()
        {
            if (tb_Account.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "請輸入帳號！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Account.Focus();
                return false;
            }
            if (tb_Password.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "請輸入密碼！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Password.Focus();
                return false;
            }
            if (tb_Password.Text.Contains("*"))
            {
                MetroMessageBox.Show(this, "密碼不能含有＊號字符！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Password.Focus();
                return false;
            }
            if (tb_Password.Text.Length < 6)
            {
                MetroMessageBox.Show(this, "密碼長度至少6個字。", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Password.Focus();
                return false;
            }
            if (tb_Name.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "請輸入名稱！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Name.Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// 檢查輸入資訊是否已存在(有異動才檢查) True:不存在 False:已存在
        /// </summary>
        /// <returns></returns>
        private bool CheckIsNotExist()
        {
            if (_userServices.IsAccountExist(tb_Account.Text.Trim()))
            {
                MetroMessageBox.Show(this, "帳號已經存在！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (_userServices.IsNameExist(tb_Name.Text.Trim()))
            {
                MetroMessageBox.Show(this, "名稱已經存在！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        /// <summary>
        /// 檢查輸入資訊是否已存在(有異動才檢查) True:不存在 False:已存在
        /// </summary>
        /// <returns></returns>
        private bool IsExist()
        {
            if (!_userServices.IsAccountExist(tb_Account.Text.Trim()))
            {
                MetroMessageBox.Show(this, "帳號不存在！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        /// <summary>
        /// 是否異動
        /// </summary>
        /// <returns></returns>
        private bool IsChanged()
        {
            try
            {
                long Id = Convert.ToInt64(grid_Users.SelectedRows[0].Cells["Id"].Value);
                UserModel user = _userServices.QueryUserById(Id);
                // 進行資料比對
                // 這裡若透過Event觸發Flag並無法明確知道資料是否異動過
                if (tb_Account.Text.Trim() != user.Account) { accountChange = true; }
                if (tb_Password.Text.Trim() != user.Password) { passwordChange = true; }
                if (tb_Name.Text.Trim() != user.Name) { nameChange = true; }

                if (accountChange || passwordChange || nameChange)
                {
                    return true;
                }
            }
            catch(Exception ex)
            {

            }
            MetroMessageBox.Show(this, "資料未進行任何異動!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }
        /// <summary>
        /// 定義視窗顯示欄位
        /// </summary>
        private void InitGridView()
        {
            try
            {
                // 預設載入第一筆資訊
                //if (grid_Users.Rows.Count > 0)
                //{
                //    tb_Account.Text = grid_Users.Rows[0].Cells["Account"].Value.ToString();
                //    tb_Password.Text = grid_Users.Rows[0].Cells["Password"].Value.ToString();
                //    tb_Name.Text = grid_Users.Rows[0].Cells["Name"].Value.ToString();
                //}

                grid_Users.Columns["Id"].Visible = false;
                grid_Users.Columns["SaltKey"].Visible = false;
                grid_Users.Columns["isAdmin"].Visible = false;

                grid_Users.Columns["Account"].HeaderText = "帳號";
                grid_Users.Columns["Password"].HeaderText = "密碼";
                grid_Users.Columns["Name"].HeaderText = "名稱";
                MaskPasswords();
            }
            catch (Exception ex)
            {
                //log here
            }
        }
        /// <summary>
        /// 隱藏所有使用者密碼
        /// </summary>
        private void MaskPasswords()
        {

            try
            {
                foreach (DataGridViewRow i in grid_Users.Rows)
                {
                    string newPassword = GetMaskedPassword(i.Cells["Password"].Value.ToString());
                    i.Cells["Password"].Value = newPassword;
                }
            }
            catch (Exception ex)
            {
                //log here
            }
        }
        /// <summary>
        /// 依照密碼長度回傳遮罩後的密碼
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private string GetMaskedPassword(string password)
        {
            string maskedPassword = string.Empty;
            for (int i = 0; i < password.Length; i++)
            {
                maskedPassword += "*";
            }
            return maskedPassword;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_Account.Clear();
            tb_Password.Clear();
            tb_Name.Clear();
        }

        /// <summary>
        /// 重置輸入框修改狀態
        /// </summary>
        private void ResetFlags()
        {
            accountChange = false;
            passwordChange = false;
            nameChange = false;
        }
        #endregion
        #region Event
        /// <summary>
        /// 點擊列時刷新下列編輯的資訊
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grid_Users_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            tb_Account.Text = grid_Users.Rows[e.RowIndex].Cells["Account"].Value.ToString();
            tb_Password.Text = grid_Users.Rows[e.RowIndex].Cells["Password"].Value.ToString();
            tb_Name.Text = grid_Users.Rows[e.RowIndex].Cells["Name"].Value.ToString();
        }
        #endregion

    }
}
