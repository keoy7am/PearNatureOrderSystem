using MetroFramework;
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
    public partial class ChangePasswordForm : DialogBase
    {
        UserServices userServices = new UserServices();
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void btn_UpdatePassword_Click(object sender, EventArgs e)
        {
            string originalPassword = tb_OriginalPassword.Text.Trim();
            string newPassword = tb_NewPassword.Text.Trim();

            if(originalPassword != Appdata.loginUser.Password.Trim())
            {
                MetroMessageBox.Show(this, "密碼輸入錯誤！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_OriginalPassword.Focus();
                return;
            }
            if (!CustomValidation()) { return; }

            var user = userServices.QueryUserById(Appdata.loginUser.Id);
            user.Password = newPassword;
            if (!userServices.UpdateUser(user))
            {
                MetroMessageBox.Show(this, "密碼更新發生錯誤！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            MetroMessageBox.Show(this, "密碼更新成功！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 驗證輸入資訊 True:驗證通過 False:驗證失敗
        /// </summary>
        /// <returns>true:驗證通過 false:驗證失敗</returns>
        private bool CustomValidation()
        {
            if (tb_NewPassword.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "請輸入密碼！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_NewPassword.Focus();
                return false;
            }
            if (tb_NewPassword.Text.Contains("*"))
            {
                MetroMessageBox.Show(this, "密碼不能含有＊號字符！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_NewPassword.Focus();
                return false;
            }
            if (tb_NewPassword.Text.Length < 6)
            {
                MetroMessageBox.Show(this, "密碼長度至少6個字。", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_NewPassword.Focus();
                return false;
            }
            return true;
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            UserServices.UserChanged += new UserServices.UserChangedEvent(UpdateAppdataInfo);
        }
        private void UpdateAppdataInfo()
        {
            string newPassword = tb_NewPassword.Text.Trim();
            Appdata.loginUser.Password = newPassword;
        }
    }
}
