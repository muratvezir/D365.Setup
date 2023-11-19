using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace D365.Setup
{
    public partial class FormMain : Form
    {
        Config deserializedXML = new Config();
        String xmlFilePath = "";


        public FormMain()
        {
            InitializeComponent();
           

        }

        private void ReadFromXml()
        {

            //OpenFileDialog openFileDialog = new OpenFileDialog();

            //openFileDialog.Filter = "XML Dosyaları (*.xml)|*.xml";
            //openFileDialog.FilterIndex = 1;
            //openFileDialog.RestoreDirectory = true;

            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{

            //    xmlFilePath = openFileDialog.FileName;
            //}

            xmlFilePath = @"C:\Users\m.vezir\Desktop\ConfigTemplate.xml";

            deserializedXML = new Config();
            // Deserialize to object
            XmlSerializer serializer = new XmlSerializer(typeof(Config));
            using (FileStream stream = File.OpenRead(xmlFilePath))
            {
                deserializedXML = (Config)serializer.Deserialize(stream);
            }

            BindConfigToFormControls();

           




        }

        #region FormUIMethods

        public IEnumerable<Control> GetAllDataBoundControls(Control control)
        {
            var dataBoundControls = control.Controls
                .OfType<Control>()
                .Where(c => c.DataBindings.Count > 0);

            foreach (Control innerControl in control.Controls)
            {
                dataBoundControls = dataBoundControls.Concat(GetAllDataBoundControls(innerControl));
            }

            return dataBoundControls;
        }



        private void BindConfigToFormControls()
        {
            configBindingSource.DataSource = deserializedXML;

            var allDataBoundControls = GetAllDataBoundControls(this).Distinct();

            foreach (var control in allDataBoundControls)
            {
                control.DataBindings.Clear();
            }


            textBoxConfig.DataBindings.Add("Text", configBindingSource, "Schema.Version");
            textBoxDomainName.DataBindings.Add("Text", configBindingSource, "ADServiceAccounts.DomainName");

            var accountBindingList = new BindingList<ConfigADServiceAccountsADServiceAccount>(deserializedXML.ADServiceAccounts.ADServiceAccount);
            textBoxLocalAgent.DataBindings.Add("Text", accountBindingList[0], "DNSHostName");
            chkLocalAgent.DataBindings.Add("Checked", accountBindingList[0], "disabled");
            textBoxFRAS.DataBindings.Add("Text", accountBindingList[1], "DNSHostName");
            chkFRAS.DataBindings.Add("Checked", accountBindingList[1], "disabled");

            textBoxFRPS.DataBindings.Add("Text", accountBindingList[2], "DNSHostName");
            chkFRPS.DataBindings.Add("Checked", accountBindingList[2], "disabled");

            textBoxFRCO.DataBindings.Add("Text", accountBindingList[3], "DNSHostName");
            chkFRCO.DataBindings.Add("Checked", accountBindingList[3], "disabled");

            textBoxAXSF.DataBindings.Add("Text", accountBindingList[4], "DNSHostName");
            chkAXSF.DataBindings.Add("Checked", accountBindingList[4], "disabled");

            textBoxReportSvc.DataBindings.Add("Text", accountBindingList[5], "DNSHostName");
            chkReportSvc.DataBindings.Add("Checked", accountBindingList[5], "disabled");

            textBoxDixF.DataBindings.Add("Text", accountBindingList[6], "DNSHostName");
            chkDixF.DataBindings.Add("Checked", accountBindingList[6], "disabled");

            var dbServerList = new BindingList<ConfigSecurity>(deserializedXML.DbServer);

            textBoxAxDbAdmin.DataBindings.Add("Text", dbServerList[0], "User.userName");
            chkAxDbAdmin.DataBindings.Add("Checked", dbServerList[0], "User.generateUser");

            textBoxAxDwAdmin.DataBindings.Add("Text", dbServerList[1], "User.userName");
            chkAxDwAdmin.DataBindings.Add("Checked", dbServerList[1], "User.generateUser");

            textBoxAxDwRuntime.DataBindings.Add("Text", dbServerList[2], "User.userName");
            chkDwRuntime.DataBindings.Add("Checked", dbServerList[2], "User.generateUser");

            var fileShareList = new BindingList<ConfigFileShare>(deserializedXML.FileShares);

            textBoxAgentPath.DataBindings.Add("Text", fileShareList[0], "Path");
            textBoxAgentBasePath.DataBindings.Add("Text", fileShareList[0], "BasePath");
            textBoxAgentLocalPath.DataBindings.Add("Text", fileShareList[0], "LocalPath");
            chkAgentShr.DataBindings.Add("Checked", fileShareList[0], "disabled");


            textBoxAosPath.DataBindings.Add("Text", fileShareList[1], "Path");
            textBoxAosBasePath.DataBindings.Add("Text", fileShareList[1], "BasePath");
            textBoxAosLocalPath.DataBindings.Add("Text", fileShareList[1], "LocalPath");
            chkAosShr.DataBindings.Add("Checked", fileShareList[1], "disabled");

            textBoxDixfPath.DataBindings.Add("Text", fileShareList[2], "Path");
            textBoxDixfBasePath.DataBindings.Add("Text", fileShareList[2], "BasePath");
            textBoxDixfLocalPath.DataBindings.Add("Text", fileShareList[2], "LocalPath");
            chkDixfShr.DataBindings.Add("Checked", fileShareList[2], "disabled");

            textBoxDiagPath.DataBindings.Add("Text", fileShareList[3], "Path");
            textBoxDiagBasePath.DataBindings.Add("Text", fileShareList[3], "BasePath");
            textBoxDiagLocalPath.DataBindings.Add("Text", fileShareList[3], "LocalPath");
            chkDiagnoseShr.DataBindings.Add("Checked", fileShareList[3], "disabled");

                  
            textBoxListener.DataBindings.Add("Text", configBindingSource , "SQLCluster.ListenerName");

            BindingSource sqlVmsbindings = new BindingSource();
            sqlVmsbindings.DataSource = deserializedXML.SQLCluster.SQLVMList;

            ListSqlVms.DataSource = sqlVmsbindings;
            ListSqlVms.DisplayMember = "Name";
           
        }


        #endregion FormUIMethods




        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Config));
            using (TextWriter writer = new StreamWriter(xmlFilePath))
            {
                serializer.Serialize(writer, deserializedXML);
            }

        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            ReadFromXml();
        }

        private void buttonRemoveServer_Click(object sender, EventArgs e)
        {

            var selectedListItem = (ConfigSQLClusterSQLVM)ListSqlVms.SelectedItem;
            var itemToRemove = deserializedXML.SQLCluster.SQLVMList.FirstOrDefault(item => item.name == selectedListItem.name);
            if (itemToRemove != null)
            {
                deserializedXML.SQLCluster.SQLVMList.Remove(itemToRemove);
            }
            var lbBindings = (BindingSource)ListSqlVms.DataSource;
            lbBindings.ResetBindings(false);
        }

        private void buttonAddServer_Click(object sender, EventArgs e)
        {
            SqlServerName inputDialog = new SqlServerName();
            if (inputDialog.ShowDialog() == DialogResult.OK)
            {
                string userInput = inputDialog.UserInput;
                var newItem = new ConfigSQLClusterSQLVM() { name = userInput };
                deserializedXML.SQLCluster.SQLVMList.Add(newItem);
            }
            var lbBindings = (BindingSource)ListSqlVms.DataSource;
            lbBindings.ResetBindings(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DomainDialog inputDialog = new DomainDialog();
            if (inputDialog.ShowDialog() == DialogResult.OK)
            {
                string domainShortName = inputDialog.DomainShortName;
                string domainLongName = inputDialog.DomainLongName;

                textBoxDomainName.Text = domainShortName;
                textBoxLocalAgent.Text = deserializedXML.ADServiceAccounts.ADServiceAccount.
                                           Where(i => i.refName == "gmsaLocalAgent").FirstOrDefault().name.TrimEnd('$') + '.'+ domainLongName;
                textBoxFRAS.Text = deserializedXML.ADServiceAccounts.ADServiceAccount.
                           Where(i => i.refName == "gmsaFRAS").FirstOrDefault().name.TrimEnd('$') + '.' + domainLongName;
                textBoxFRPS.Text = deserializedXML.ADServiceAccounts.ADServiceAccount.
                           Where(i => i.refName == "gmsaFRPS").FirstOrDefault().name.TrimEnd('$') + '.' + domainLongName;
                textBoxFRCO.Text = deserializedXML.ADServiceAccounts.ADServiceAccount.
                           Where(i => i.refName == "gmsaFRCO").FirstOrDefault().name.TrimEnd('$') + '.' + domainLongName;
                textBoxAXSF.Text = deserializedXML.ADServiceAccounts.ADServiceAccount.
                           Where(i => i.refName == "gmsaAXSF").FirstOrDefault().name.TrimEnd('$') + '.' + domainLongName;
                textBoxReportSvc.Text = deserializedXML.ADServiceAccounts.ADServiceAccount.
                           Where(i => i.refName == "gmsaSSRS").FirstOrDefault().name.TrimEnd('$') + '.' + domainLongName;
                textBoxDixF.Text = deserializedXML.ADServiceAccounts.ADServiceAccount.
                           Where(i => i.refName == "gmsaDIXF").FirstOrDefault().name.TrimEnd('$') + '.' + domainLongName;

            }
        }
    }
}
