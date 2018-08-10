using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PearNatureOrderSystem.Presentation
{
    public static class FormController
    {
        public static LoginForm loginForm { get; set; }
        public static MainForm mainForm { get; set; }
        public static void Init()
        {
            loginForm = new LoginForm();
            mainForm = new MainForm();
        }
    }
}
