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
        public void CheckUserAuth()
        {
            // 進階功能開關
            if (Appdata.loginUser.isAdmin)
            {
                btn_AccountManager.Visible = true;
                btn_ProductManager.Visible = true;
                btn_OrderManager.Visible = true;
                btn_TableManager.Visible = true;
            }
            else
            {
                btn_AccountManager.Visible = false;
                btn_ProductManager.Visible = false;
                btn_OrderManager.Visible = false;
                btn_TableManager.Visible = false;
            }

            lb_LoginUser.Text = $"使用者：{Appdata.loginUser.Name}";
        }


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

        #region 控制項事件

        #endregion

        private void btn_ProductManager_Click(object sender, EventArgs e)
        {
            new ProductManager().ShowDialog();
        }
        #region Manager
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
        #endregion

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            ResetForm();
            this.Hide();
            FormController.loginForm.Show();
            Appdata.loginUser = null;
        }
        private void ResetForm()
        {
            CheckUserAuth();
        }
    }
}
