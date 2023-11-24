using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D365.Setup
{
    public partial class PowerShellInfo : Form
    {
        public PowerShellInfo()
        {
            InitializeComponent();
        }

        public static void Show(string message, bool sucess)
        {
            PowerShellInfo pInfo = new PowerShellInfo();
            pInfo.rTextBoxMessage.Text = message;

            if (sucess)
                pInfo.rTextBoxMessage.BackColor = Color.LightGreen;
            else
                pInfo.rTextBoxMessage.BackColor = Color.LightCoral;

            pInfo.buttonOK.Click += (sender, e) =>
            {
               
                pInfo.Close();
            };


            pInfo.ShowDialog();
            
        }

    }
}
