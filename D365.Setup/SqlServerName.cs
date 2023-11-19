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
    public partial class SqlServerName : Form
    {
        public string UserInput { get; private set; }
        public SqlServerName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserInput = textBoxSqlServerName.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
