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
using static PearNatureOrderSystem.Appdata;

namespace PearNatureOrderSystem.Presentation
{
    public partial class MainForm : BaseForm
    {
        System.Threading.Timer ThreadTimer; // 控制背景狀態更新
        int OpenAdvanceSetting; // 控制是否開啟進階設定
        public MainForm()
        {
            InitializeComponent();
            // Init Form
            OpenAdvanceSetting = 0;

            // 背景狀態更新 Timer
            ThreadTimer = new System.Threading.Timer(StatusUpdater, null, 0, 1000);

            // 進階功能開關
            if (loginUser.isAdmin)
            {
                btn_AccountManager.Visible = true;
                btn_ProductManager.Visible = true;
            }
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
            int longNow = Convert.ToInt32(now.ToString("ss"));
            int temp = OpenAdvanceSetting;
            this.Invoke(new Action(() =>
            {
                lb_time.Text = now.ToLongTimeString();
            }));

            // 檢測是否開啟進階功能
            //if (longNow % 3 == 0)
            //{
            //    OpenAdvanceSetting = 0;
            //    if (temp > 4)
            //    {
            //        //TODO 顯示進階設定
            //        btn_AccountManager.Visible = true;
            //        btn_ProductManager.Visible = true;
            //    }
            //}
        }

        #region 控制項事件

        private void lb_time_Click(object sender, EventArgs e)
        {
            OpenAdvanceSetting++;
        }

        #endregion

        private void btn_ProductManager_Click(object sender, EventArgs e)
        {
            new ProductManager().ShowDialog();
        }

        private void btn_AccountManager_Click(object sender, EventArgs e)
        {
            new AccountManager().ShowDialog();
        }
    }
}
