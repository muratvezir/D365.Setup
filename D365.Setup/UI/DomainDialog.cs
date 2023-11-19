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
    public partial class DomainDialog : Form
    {
        public string DomainShortName { get; private set; }
        public string DomainLongName { get; private set; }

        public DomainDialog()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DomainShortName = textBoxShortName.Text;
            DomainLongName = textBoxLongName.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
