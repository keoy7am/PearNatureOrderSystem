using PearNatureOrderSystem.Presentation;
using PearNatureOrderSystem.Services;
using SerializationRepository;
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

            /* 各Service 序列化器、路徑設定 */
            ApplicationRegister._userRepo = new RepositoryRegister(new JsonSerializable(), @".\user.json");
            ApplicationRegister._categroyRepo = new RepositoryRegister(new JsonSerializable(), @".\Categroy.json");
            ApplicationRegister._productRepo = new RepositoryRegister(new JsonSerializable(), @".\Product.json");

            /* 各Service 服務註冊 */
            UserServices.InitUserServices();
            ProductServices.InitProductSerices();

            UserServices.InitDefaultUser();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
