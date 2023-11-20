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
    
    public partial class DatabaseBackup : Form
    {
        public string BackupFileName { get; private set; }

        public DatabaseBackup()
            {
                InitializeComponent();
            }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            BackupFileName = textBoxBackupFile.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
