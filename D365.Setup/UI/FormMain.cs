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
        Boolean xmlReaded = false;
        Config deserializedXML = new Config();
        String xmlFilePath = "";
        DateTime fileLastWriteTime;



        public FormMain()
        {
            InitializeComponent();
            System.Drawing.Icon icon = Properties.Resources.Dynamics365;
            this.Icon = icon;
            toogleButtons();


        }

        private void ReadFromXml(string _xmlfilepath)
        {
            if (_xmlfilepath == string.Empty)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Filter = "XML Files (*.xml)|*.xml";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    xmlFilePath = openFileDialog.FileName;
                }
            }
            else
                xmlFilePath = _xmlfilepath;

           fileLastWriteTime = File.GetLastWriteTime(xmlFilePath);
           //xmlFilePath = @"C:\Users\m.vezir\Desktop\ConfigTemplate.xml";

           deserializedXML = new Config();
            // Deserialize to object
            XmlSerializer serializer = new XmlSerializer(typeof(Config));
            using (FileStream stream = File.OpenRead(xmlFilePath))
            {
                deserializedXML = (Config)serializer.Deserialize(stream);
            }

            BindConfigToFormControls();
            xmlReaded = true;
            toogleButtons();




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


            textBoxListener.DataBindings.Add("Text", configBindingSource, "SQLCluster.ListenerName");

            BindingSource sqlVmsbindings = new BindingSource();
            sqlVmsbindings.DataSource = deserializedXML.SQLCluster.SQLVMList;

            ListSqlVms.DataSource = sqlVmsbindings;
            ListSqlVms.DisplayMember = "Name";

            var databasesList = new BindingList<ConfigDatabase>(deserializedXML.Databases);

            textBoxAXDB.DataBindings.Add("Text", databasesList[0], "dbName");
            textBoxBackupFile.DataBindings.Add("Text", databasesList[0], "BackupFile");
            textBoxFinDb.DataBindings.Add("Text", databasesList[1], "dbName");
            textBoxOrchDB.DataBindings.Add("Text", databasesList[2], "dbName");
            textBoxAxDw.DataBindings.Add("Text", databasesList[3], "dbName");

            var certificateList = new BindingList<ConfigCertificate>(deserializedXML.Certificates);

            textBoxSFThumprint.DataBindings.Add("Text", certificateList[0], "Thumbprint");
            textBoxSFCThumprint.DataBindings.Add("Text", certificateList[1], "Thumbprint");
            textBoxSFEThumprint.DataBindings.Add("Text", certificateList[2], "Thumbprint");
            textBoxSAThumprint.DataBindings.Add("Text", certificateList[3], "Thumbprint");
            textBoxDEThumprint.DataBindings.Add("Text", certificateList[4], "Thumbprint");
            textBoxDSThumprint.DataBindings.Add("Text", certificateList[5], "Thumbprint");
            textBoxFRThumprint.DataBindings.Add("Text", certificateList[6], "Thumbprint");
            textBoxRSThumprint.DataBindings.Add("Text", certificateList[7], "Thumbprint");
            textBoxLAThumprint.DataBindings.Add("Text", certificateList[8], "Thumbprint");
            textBoxSSRSThumprint.DataBindings.Add("Text", certificateList[9], "Thumbprint");
            textBoxSQLThumprint.DataBindings.Add("Text", certificateList[10], "Thumbprint");
            textBoxRSATThumprint.DataBindings.Add("Text", certificateList[11], "Thumbprint");


            textBoxSFName.DataBindings.Add("Text", certificateList[0], "Name");
            textBoxSFCName.DataBindings.Add("Text", certificateList[1], "Name");
            textBoxSFEName.DataBindings.Add("Text", certificateList[2], "Name");
            textBoxSAName.DataBindings.Add("Text", certificateList[3], "Name");
            textBoxDEName.DataBindings.Add("Text", certificateList[4], "Name");
            textBoxDSName.DataBindings.Add("Text", certificateList[5], "Name");
            textBoxFRName.DataBindings.Add("Text", certificateList[6], "Name");
            textBoxRSName.DataBindings.Add("Text", certificateList[7], "Name");
            textBoxLAName.DataBindings.Add("Text", certificateList[8], "Name");
            textBoxSSRSName.DataBindings.Add("Text", certificateList[9], "Name");
            textBoxSQLName.DataBindings.Add("Text", certificateList[10], "Name");
            textBoxRSATName.DataBindings.Add("Text", certificateList[11], "Name");


            textBoxSFDns.DataBindings.Add("Text", certificateList[0], "DnsName");
            textBoxSFCDns.DataBindings.Add("Text", certificateList[1], "DnsName");
            textBoxSFEDns.DataBindings.Add("Text", certificateList[2], "DnsName");
            textBoxSADns.DataBindings.Add("Text", certificateList[3], "DnsName");
            textBoxDEDns.DataBindings.Add("Text", certificateList[4], "DnsName");
            textBoxDSDns.DataBindings.Add("Text", certificateList[5], "DnsName");
            textBoxFRDns.DataBindings.Add("Text", certificateList[6], "DnsName");
            textBoxRSDns.DataBindings.Add("Text", certificateList[7], "DnsName");
            textBoxLADns.DataBindings.Add("Text", certificateList[8], "DnsName");
            textBoxSSRSDns.DataBindings.Add("Text", certificateList[9], "DnsName");
            textBoxSQLDns.DataBindings.Add("Text", certificateList[10], "DnsName");
            textBoxRSATDns.DataBindings.Add("Text", certificateList[11], "DnsName");

            textBoxSFProtect.DataBindings.Add("Text", certificateList[0], "ProtectTo");
            textBoxSFCProtect.DataBindings.Add("Text", certificateList[1], "ProtectTo");
            textBoxSFEProtect.DataBindings.Add("Text", certificateList[2], "ProtectTo");
            textBoxSAProtect.DataBindings.Add("Text", certificateList[3], "ProtectTo");
            textBoxDEProtect.DataBindings.Add("Text", certificateList[4], "ProtectTo");
            textBoxDSProtect.DataBindings.Add("Text", certificateList[5], "ProtectTo");
            textBoxFRProtect.DataBindings.Add("Text", certificateList[6], "ProtectTo");
            textBoxRSProtect.DataBindings.Add("Text", certificateList[7], "ProtectTo");
            textBoxLAProtect.DataBindings.Add("Text", certificateList[8], "ProtectTo");
            textBoxSSRSProtect.DataBindings.Add("Text", certificateList[9], "ProtectTo");
            textBoxSQLProtect.DataBindings.Add("Text", certificateList[10], "ProtectTo");
            textBoxRSATProtect.DataBindings.Add("Text", certificateList[11], "ProtectTo");

            chkSFExport.DataBindings.Add("Checked", certificateList[0], "exportable");
            chkSFCExport.DataBindings.Add("Checked", certificateList[1], "exportable");
            chkSFEExport.DataBindings.Add("Checked", certificateList[2], "exportable");
            chkSAExport.DataBindings.Add("Checked", certificateList[3], "exportable");
            chkDEExport.DataBindings.Add("Checked", certificateList[4], "exportable");
            chkDSExport.DataBindings.Add("Checked", certificateList[5], "exportable");
            chkFRExport.DataBindings.Add("Checked", certificateList[6], "exportable");
            chkRSExport.DataBindings.Add("Checked", certificateList[7], "exportable");
            chkLAExport.DataBindings.Add("Checked", certificateList[8], "exportable");
            chkSSRSExport.DataBindings.Add("Checked", certificateList[9], "exportable");
            chkSQLExport.DataBindings.Add("Checked", certificateList[10], "exportable");
            chkRSATExport.DataBindings.Add("Checked", certificateList[11], "exportable");


            chkSFSelf.DataBindings.Add("Checked", certificateList[0], "generateSelfSignedCert");
            chkSFCSelf.DataBindings.Add("Checked", certificateList[1], "generateSelfSignedCert");
            chkSFESelf.DataBindings.Add("Checked", certificateList[2], "generateSelfSignedCert");
            chkSASelf.DataBindings.Add("Checked", certificateList[3], "generateSelfSignedCert");
            chkDESelf.DataBindings.Add("Checked", certificateList[4], "generateSelfSignedCert");
            chkDSSelf.DataBindings.Add("Checked", certificateList[5], "generateSelfSignedCert");
            chkFRSelf.DataBindings.Add("Checked", certificateList[6], "generateSelfSignedCert");
            chkRSSelf.DataBindings.Add("Checked", certificateList[7], "generateSelfSignedCert");
            chkLASelf.DataBindings.Add("Checked", certificateList[8], "generateSelfSignedCert");
            chkSSRSSelf.DataBindings.Add("Checked", certificateList[9], "generateSelfSignedCert");
            chkSQLSelf.DataBindings.Add("Checked", certificateList[10], "generateSelfSignedCert");
            chkRSATSelf.DataBindings.Add("Checked", certificateList[11], "generateSelfSignedCert");



            chkSFADCS.DataBindings.Add("Checked", certificateList[0], "generateADCSCert");
            chkSFCADCS.DataBindings.Add("Checked", certificateList[1], "generateADCSCert");
            chkSFEADCS.DataBindings.Add("Checked", certificateList[2], "generateADCSCert");
            chkSAADCS.DataBindings.Add("Checked", certificateList[3], "generateADCSCert");
            chkDEADCS.DataBindings.Add("Checked", certificateList[4], "generateADCSCert");
            chkDSADCS.DataBindings.Add("Checked", certificateList[5], "generateADCSCert");
            chkFRADCS.DataBindings.Add("Checked", certificateList[6], "generateADCSCert");
            chkRSADCS.DataBindings.Add("Checked", certificateList[7], "generateADCSCert");
            chkLAADCS.DataBindings.Add("Checked", certificateList[8], "generateADCSCert");
            chkSSRSADCS.DataBindings.Add("Checked", certificateList[9], "generateADCSCert");
            chkSQLADCS.DataBindings.Add("Checked", certificateList[10], "generateADCSCert");
            chkRSATADCS.DataBindings.Add("Checked", certificateList[11], "generateADCSCert");

            chkSFDis.DataBindings.Add("Checked", certificateList[0], "disabled");
            chkSFCDis.DataBindings.Add("Checked", certificateList[1], "disabled");
            chkSFEDis.DataBindings.Add("Checked", certificateList[2], "disabled");
            chkSADis.DataBindings.Add("Checked", certificateList[3], "disabled");
            chkDEDis.DataBindings.Add("Checked", certificateList[4], "disabled");
            chkDSDis.DataBindings.Add("Checked", certificateList[5], "disabled");
            chkFRDis.DataBindings.Add("Checked", certificateList[6], "disabled");
            chkRSDis.DataBindings.Add("Checked", certificateList[7], "disabled");
            chkLADis.DataBindings.Add("Checked", certificateList[8], "disabled");
            chkSSRSDis.DataBindings.Add("Checked", certificateList[9], "disabled");
            chkSQLDis.DataBindings.Add("Checked", certificateList[10], "disabled");
            chkRSATDis.DataBindings.Add("Checked", certificateList[11], "disabled");

            chkSFMan.DataBindings.Add("Checked", certificateList[0], "manualProperties");
            chkSFCMan.DataBindings.Add("Checked", certificateList[1], "manualProperties");
            chkSFEMan.DataBindings.Add("Checked", certificateList[2], "manualProperties");
            chkSAMan.DataBindings.Add("Checked", certificateList[3], "manualProperties");
            chkDEMan.DataBindings.Add("Checked", certificateList[4], "manualProperties");
            chkDSMan.DataBindings.Add("Checked", certificateList[5], "manualProperties");
            chkFRMan.DataBindings.Add("Checked", certificateList[6], "manualProperties");
            chkRSMan.DataBindings.Add("Checked", certificateList[7], "manualProperties");
            chkLAMan.DataBindings.Add("Checked", certificateList[8], "manualProperties");
            chkSSRSMan.DataBindings.Add("Checked", certificateList[9], "manualProperties");
            chkSQLMan.DataBindings.Add("Checked", certificateList[10], "manualProperties");
            chkRSATMan.DataBindings.Add("Checked", certificateList[11], "manualProperties");


            BindingSource clusterNodesbindings = new BindingSource();
            clusterNodesbindings.DataSource = deserializedXML.ServiceFabricCluster.NodeType;
            gridNodes.AutoGenerateColumns = false;
            gridNodes.DataSource = clusterNodesbindings;
            


            BindingSource clusterVmsbindings = new BindingSource();
            clusterVmsbindings.DataSource = deserializedXML.ServiceFabricCluster.NodeType[0].VMList;
            gridVms.AutoGenerateColumns = false;
            gridVms.DataSource = clusterVmsbindings;
  



        }


        public void toogleButtons()
        {
            buttonDomain.Enabled = xmlReaded;
            buttonFileShare.Enabled = xmlReaded;
            popupMenuGridNode.Enabled = xmlReaded;
            buttonBackup.Enabled = xmlReaded;
            buttonCert.Enabled = xmlReaded;

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
            ReadFromXml("");
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

        private void buttonDomain_Click(object sender, EventArgs e)
        {
            DomainDialog inputDialog = new DomainDialog();
            if (inputDialog.ShowDialog() == DialogResult.OK)
            {
                string domainShortName = inputDialog.DomainShortName;
                string domainLongName = inputDialog.DomainLongName;

                textBoxDomainName.Text = domainShortName;
                textBoxDomainName.DataBindings["Text"].WriteValue();

                textBoxLocalAgent.Text = deserializedXML.ADServiceAccounts.ADServiceAccount.
                                           Where(i => i.refName == "gmsaLocalAgent").FirstOrDefault().name.TrimEnd('$') + '.' + domainLongName;
                textBoxLocalAgent.DataBindings["Text"].WriteValue();
                textBoxFRAS.Text = deserializedXML.ADServiceAccounts.ADServiceAccount.
                           Where(i => i.refName == "gmsaFRAS").FirstOrDefault().name.TrimEnd('$') + '.' + domainLongName;
                textBoxFRAS.DataBindings["Text"].WriteValue();
                textBoxFRPS.Text = deserializedXML.ADServiceAccounts.ADServiceAccount.
                           Where(i => i.refName == "gmsaFRPS").FirstOrDefault().name.TrimEnd('$') + '.' + domainLongName;
                textBoxFRPS.DataBindings["Text"].WriteValue();
                textBoxFRCO.Text = deserializedXML.ADServiceAccounts.ADServiceAccount.
                           Where(i => i.refName == "gmsaFRCO").FirstOrDefault().name.TrimEnd('$') + '.' + domainLongName;
                textBoxFRCO.DataBindings["Text"].WriteValue();
                textBoxAXSF.Text = deserializedXML.ADServiceAccounts.ADServiceAccount.
                           Where(i => i.refName == "gmsaAXSF").FirstOrDefault().name.TrimEnd('$') + '.' + domainLongName;
                textBoxAXSF.DataBindings["Text"].WriteValue();
                textBoxReportSvc.Text = deserializedXML.ADServiceAccounts.ADServiceAccount.
                           Where(i => i.refName == "gmsaSSRS").FirstOrDefault().name.TrimEnd('$') + '.' + domainLongName;
                textBoxReportSvc.DataBindings["Text"].WriteValue();
                textBoxDixF.Text = deserializedXML.ADServiceAccounts.ADServiceAccount.
                           Where(i => i.refName == "gmsaDIXF").FirstOrDefault().name.TrimEnd('$') + '.' + domainLongName;
                textBoxDixF.DataBindings["Text"].WriteValue();

            }
            
           
           
        }

        private void buttonFileShare_Click(object sender, EventArgs e)
        {
            FileShareDialog inputDialog = new FileShareDialog();
            if (inputDialog.ShowDialog() == DialogResult.OK)
            {
                string fileServerName = inputDialog.FileServerName;
                string basePath = inputDialog.BasePath;

                var agentdata = deserializedXML.FileShares.Where(i => i.refName == "agent" && i.disabled == false).FirstOrDefault();
                if (agentdata != null)
                {
                    textBoxAgentPath.Text = String.Format(@"\\{0}\{1}", fileServerName, agentdata.name);
                    textBoxAgentPath.DataBindings["Text"].WriteValue();
                    textBoxAgentBasePath.Text = basePath;
                    textBoxAgentBasePath.DataBindings["Text"].WriteValue();
                }

                var aosdate = deserializedXML.FileShares.Where(i => i.refName == "aos" && i.disabled == false).FirstOrDefault();
                if (aosdate != null)
                {
                    textBoxAosPath.Text = String.Format(@"\\{0}\{1}", fileServerName, aosdate.name);
                    textBoxAosPath.DataBindings["Text"].WriteValue();
                    textBoxAosBasePath.Text = basePath;
                    textBoxAosBasePath.DataBindings["Text"].WriteValue();
                }

                var dixfdata = deserializedXML.FileShares.Where(i => i.refName == "dixf" && i.disabled == false).FirstOrDefault();
                if (dixfdata != null)
                {
                    textBoxDixfPath.Text = String.Format(@"\\{0}\{1}", fileServerName, dixfdata.name);
                    textBoxDixfPath.DataBindings["Text"].WriteValue();
                    textBoxDixfBasePath.Text = basePath;
                    textBoxDixfBasePath.DataBindings["Text"].WriteValue();
                }

                var sfDiagnosticsdata = deserializedXML.FileShares.Where(i => i.refName == "sfDiagnostics" && i.disabled == false).FirstOrDefault();
                if (sfDiagnosticsdata != null)
                {
                    textBoxDiagPath.Text = String.Format(@"\\{0}\{1}", fileServerName, sfDiagnosticsdata.name);
                    textBoxDiagPath.DataBindings["Text"].WriteValue();
                    textBoxDiagBasePath.Text = basePath;
                    textBoxDiagBasePath.DataBindings["Text"].WriteValue();
                }



            }

        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            DatabaseBackup inputDialog = new DatabaseBackup();
            if (inputDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxBackupFile.Text = inputDialog.BackupFileName;
                textBoxBackupFile.DataBindings["Text"].WriteValue();
            }
        }

        private void gridNodes_SelectionChanged(object sender, EventArgs e)
        {
            BindingSource clusterVmsbindings = new BindingSource();
            clusterVmsbindings.DataSource = deserializedXML.ServiceFabricCluster.NodeType[gridNodes.CurrentCell.RowIndex].VMList;
            gridVms.AutoGenerateColumns = false;
            gridVms.DataSource = clusterVmsbindings;
        }

        private void toolStripAddNew_Click(object sender, EventArgs e)
        {

            var vmsList = deserializedXML.ServiceFabricCluster.NodeType[gridNodes.CurrentCell.RowIndex].VMList;
            ConfigServiceFabricClusterNodeTypeVM clusterVM = new ConfigServiceFabricClusterNodeTypeVM();
            clusterVM.name = "New Node";
            clusterVM.ipAddress = "127.0.0.1";
            clusterVM.faultDomain = "";
            clusterVM.updateDomain = "";
            clusterVM.hasSSIS = false;
            vmsList.Add(clusterVM);
            BindingSource clusterVmsbindings = (BindingSource)gridVms.DataSource;
            clusterVmsbindings.ResetBindings(false);

        }

        private void toolStripMIRemove_Click(object sender, EventArgs e)
        {
            var selectedRow = gridVms.CurrentCell.RowIndex;
            var vmsList = deserializedXML.ServiceFabricCluster.NodeType[gridNodes.CurrentCell.RowIndex].VMList;

            // İlgili satırı bulup kaldırma işlemi
            if (selectedRow <= vmsList.Count())
            {
                vmsList.RemoveAt(selectedRow);
            }
            BindingSource clusterVmsbindings = (BindingSource)gridVms.DataSource;
            clusterVmsbindings.ResetBindings(false);
        }

        private void buttonCert_Click(object sender, EventArgs e)
        {
            CertificateDialog inputDialog = new CertificateDialog();
            if (inputDialog.ShowDialog() == DialogResult.OK)
            {
                var protectTextBoxes = groupBoxCert.Controls.OfType<TextBox>()
                        .Where(textBox => textBox.Tag?.ToString() == "Protect");

                foreach (TextBox item in protectTextBoxes)
                {
                    item.Text = inputDialog.ProtectTo;
                    item.DataBindings["Text"].WriteValue();
                }

                textBoxSSRSName.Text = inputDialog.SSRS;
                textBoxSSRSName.DataBindings["Text"].WriteValue();
                textBoxSSRSDns.Text = inputDialog.SSRS;
                textBoxSSRSDns.DataBindings["Text"].WriteValue();



            }

        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            if (xmlFilePath == string.Empty)
            {
                return;
            }

            if (File.GetLastWriteTime(xmlFilePath) > fileLastWriteTime)
            {
                fileLastWriteTime = File.GetLastWriteTime(xmlFilePath);
                DialogResult dialogResult = MessageBox.Show("Do you want to reload ?", "File Changed", MessageBoxButtons.OKCancel);

                if (dialogResult == DialogResult.OK)
                {

                    this.BringToFront();
                    ReadFromXml(xmlFilePath);
                }
            }



        }

        //Form Is Flickering There are to many objects 
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void labelExport_DoubleClick(object sender, EventArgs e)
        {
            var exportCheckBoxes = groupBoxCert.Controls.OfType<CheckBox>()
                       .Where(textBox => textBox.Tag?.ToString() == "Export");

            

            foreach (CheckBox item in exportCheckBoxes)
            {
                item.Checked = !chkSFExport.Checked;
                item.DataBindings["Checked"].WriteValue();
            }
        }

       
    }
}
