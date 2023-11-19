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


            configBindingSource.DataSource = deserializedXML;
            labelVersion.DataBindings.Clear();

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



        }



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
    }
}
