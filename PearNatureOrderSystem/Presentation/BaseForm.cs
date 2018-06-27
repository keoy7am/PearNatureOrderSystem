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
using MetroFramework.Forms;

namespace PearNatureOrderSystem.Presentation
{
    public partial class BaseForm : MetroFramework.Forms.MetroForm
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 確保所有視窗及線程皆已關閉
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {

            if (e.CloseReason != CloseReason.WindowsShutDown && e.CloseReason != CloseReason.ApplicationExitCall)
            {
                DialogResult dr = MetroMessageBox.Show(this, "\n\n是否確定要關閉程式?", "訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                    base.OnFormClosing(e);
                    return;
                }
                else
                {
                    if (Application.MessageLoop)
                    {
                        Application.Exit();
                        Application.ExitThread();
                    }
                    else
                    {
                        Environment.Exit(1);
                    }
                }
            }
            
        }
    }
}
