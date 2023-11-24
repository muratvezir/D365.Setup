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
    public partial class PowerShellScriptsForm : Form
    {
        public PowerShellScriptsForm()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {

            // string command = @".\Create-GMSAAccounts.ps1 -ConfigurationFilePath .\ConfigTemplate.xml"; // Örnek bir PowerShell komutu
            string command = @"dir";
            var commandRet = PSHelper.RunPowerShellCommand(command);
            PowerShellInfo.Show(commandRet.Message, commandRet.Success);
           
        }

        private void buttonExportCert_Click(object sender, EventArgs e)
        {
            //string command = @".\Export-Certificates.ps1 -ConfigurationFilePath .\ConfigTemplate.xml";
            string command = @"dir";
            var commandRet = PSHelper.RunPowerShellCommand(command);
            commandRet.Success = false;
            PowerShellInfo.Show(commandRet.Message, commandRet.Success);

        }
    }
}
