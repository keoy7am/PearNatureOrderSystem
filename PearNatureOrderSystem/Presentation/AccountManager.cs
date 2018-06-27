using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PearNatureOrderSystem.Services;

namespace PearNatureOrderSystem.Presentation
{
    public partial class AccountManager : BaseForm
    {
        UserServices _userServices;
        public AccountManager()
        {
            InitializeComponent();
            _userServices = new UserServices();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            // TODO 檢查 名稱、帳號是否存在
        }


        // TODO 透過Ident檢查可否執行
        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
