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
    public partial class DialogBase : MetroFramework.Forms.MetroForm
    {
        public DialogBase()
        {
            InitializeComponent();
        }

        private void DialogBase_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
    }
}
