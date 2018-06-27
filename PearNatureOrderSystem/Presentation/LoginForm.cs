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
using PearNatureOrderSystem.Services;
using static PearNatureOrderSystem.Library.CommonBase;

namespace PearNatureOrderSystem.Presentation
{
    public partial class LoginForm : BaseForm//MetroFramework.Forms.MetroForm
    {
        string _password = string.Empty;
        UserServices userServices;
        public LoginForm()
        {
            if (IsProcessing())
            {
                MessageBox.Show("程式已在執行中... 請勿重複執行。", "注意!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Environment.Exit(Environment.ExitCode);
            }
            InitializeComponent();
            userServices = new UserServices();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (!CustomValidation())
            {
                return;
            }
            if (userServices.Login(tb_Account.Text, tb_Password.Text))
            {
                new MainForm().Show();
                this.Hide();
            }
            else
            {
                MetroMessageBox.Show(this, "帳號密碼錯誤！！", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_Password.Focus();
            }

        }

        #region Method

        /// <summary>
        /// 驗證輸入資訊
        /// </summary>
        /// <returns>true:驗證通過 false:驗證失敗</returns>
        private bool CustomValidation()
        {
            if (tb_Account.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "請輸入帳號", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Account.Focus();
                return false;
            }
            if (tb_Password.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "請輸入密碼", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_Password.Focus();
                return false;
            }

            return true;
        }
        #endregion

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Account.Text = string.Empty;
            tb_Password.Text = string.Empty;
        }
    }
}
