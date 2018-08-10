using PearNatureOrderSystem.Presentation;
using PearNatureOrderSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PearNatureOrderSystem
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            UserServices.InitDefaultUser();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormController.Init();
            Application.Run(FormController.loginForm);
        }
    }
}
