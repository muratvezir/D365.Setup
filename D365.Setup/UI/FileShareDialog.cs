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
    public partial class FileShareDialog : Form
    {
        public string FileServerName { get; private set; }
        public string BasePath { get; private set; }

        public FileShareDialog()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            FileServerName = textBoxFileServer.Text;
            BasePath = textBoxFileServer.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBoxFileServer_TextChanged(object sender, EventArgs e)
        {
            string userInput = textBoxFileServer.Text;

            if (userInput.Contains("\\\\"))
            {
                MessageBox.Show("We don't need double backslash on this field");
                textBoxFileServer.Text = userInput.Replace("\\\\", "");
            }
        }
    }
}
