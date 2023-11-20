using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace D365.Setup
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class Config
    {

        private ConfigSchema schemaField;

        private ConfigADServiceAccounts aDServiceAccountsField;

        private ConfigCertificate[] certificatesField;

        private ConfigSecurity[] dbServerField;

        private ConfigDatabase[] databasesField;

        private ConfigFileShare[] fileSharesField;

        private ConfigServiceFabricCluster serviceFabricClusterField;

        private ConfigSQLCluster sQLClusterField;

        /// <remarks/>
        public ConfigSchema Schema
        {
            get
            {
                return this.schemaField;
            }
            set
            {
                this.schemaField = value;
            }
        }

        /// <remarks/>
        public ConfigADServiceAccounts ADServiceAccounts
        {
            get
            {
                return this.aDServiceAccountsField;
            }
            set
            {
                this.aDServiceAccountsField = value;
            }
        }

        /// <remarks/>
        [XmlArrayItem("Certificate", IsNullable = false)]
        public ConfigCertificate[] Certificates
        {
            get
            {
                return this.certificatesField;
            }
            set
            {
                this.certificatesField = value;
            }
        }

        /// <remarks/>
        [XmlArrayItem("Security", IsNullable = false)]
        public ConfigSecurity[] DbServer
        {
            get
            {
                return this.dbServerField;
            }
            set
            {
                this.dbServerField = value;
            }
        }

        /// <remarks/>
        [XmlArrayItem("Database", IsNullable = false)]
        public ConfigDatabase[] Databases
        {
            get
            {
                return this.databasesField;
            }
            set
            {
                this.databasesField = value;
            }
        }

        /// <remarks/>
        [XmlArrayItem("FileShare", IsNullable = false)]
        public ConfigFileShare[] FileShares
        {
            get
            {
                return this.fileSharesField;
            }
            set
            {
                this.fileSharesField = value;
            }
        }

        /// <remarks/>
        public ConfigServiceFabricCluster ServiceFabricCluster
        {
            get
            {
                return this.serviceFabricClusterField;
            }
            set
            {
                this.serviceFabricClusterField = value;
            }
        }

        /// <remarks/>
        public ConfigSQLCluster SQLCluster
        {
            get
            {
                return this.sQLClusterField;
            }
            set
            {
                this.sQLClusterField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ConfigSchema
    {

        private string versionField;

        /// <remarks/>
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ConfigADServiceAccounts
    {

        private string domainNameField;

        private List<ConfigADServiceAccountsADServiceAccount> aDServiceAccountField;

        /// <remarks/>
        public string DomainName
        {
            get
            {
                return this.domainNameField;
            }
            set
            {
                this.domainNameField = value;
            }
        }

        /// <remarks/>
        [XmlElement("ADServiceAccount")]
        public List<ConfigADServiceAccountsADServiceAccount> ADServiceAccount
        {
            get
            {
                return this.aDServiceAccountField;
            }
            set
            {
                this.aDServiceAccountField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ConfigADServiceAccountsADServiceAccount
    {

        private string dNSHostNameField;

        private string typeField;

        private string nameField;

        private string refNameField;

        private bool disabledField;

        /// <remarks/>
        public string DNSHostName
        {
            get
            {
                return this.dNSHostNameField;
            }
            set
            {
                this.dNSHostNameField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string refName
        {
            get
            {
                return this.refNameField;
            }
            set
            {
                this.refNameField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public bool disabled
        {
            get
            {
                return this.disabledField;
            }
            set
            {
                this.disabledField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ConfigCertificate
    {

        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "FileName")]
        public string FileName { get; set; }

        [XmlElement(ElementName = "DNSName")]
        public string DNSName { get; set; }

        [XmlElement(ElementName = "Subject")]
        public string Subject { get; set; }

        [XmlElement(ElementName = "Provider")]
        public string Provider { get; set; }

        [XmlElement(ElementName = "KeyUsage")]
        public string KeyUsage { get; set; }

        [XmlElement(ElementName = "EnhancedKeyUsage")]
        public string EnhancedKeyUsage { get; set; }

        [XmlElement(ElementName = "Thumbprint")]
        public string Thumbprint { get; set; }

        [XmlElement(ElementName = "ProtectTo")]
        public string ProtectTo { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlAttribute(AttributeName = "exportable")]
        public bool Exportable { get; set; }

        [XmlAttribute(AttributeName = "generateSelfSignedCert")]
        public bool GenerateSelfSignedCert { get; set; }

        [XmlAttribute(AttributeName = "generateADCSCert")]
        public bool GenerateADCSCert { get; set; }

        [XmlText]
        public string Text { get; set; }

        [XmlAttribute(AttributeName = "disabled")]
        public bool Disabled { get; set; }

        [XmlElement(ElementName = "CertificateType")]
        public string CertificateType { get; set; }

        [XmlAttribute(AttributeName = "manualProperties")]
        public bool ManualProperties { get; set; }
    }


    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ConfigSecurity
    {

        private ConfigSecurityUser userField;

        /// <remarks/>
        public ConfigSecurityUser User
        {
            get
            {
                return this.userField;
            }
            set
            {
                this.userField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ConfigSecurityUser
    {

        private string refNameField;

        private string typeField;

        private string userNameField;

        private bool generateUserField;

        /// <remarks/>
        [XmlAttribute()]
        public string refName
        {
            get
            {
                return this.refNameField;
            }
            set
            {
                this.refNameField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string userName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public bool generateUser
        {
            get
            {
                return this.generateUserField;
            }
            set
            {
                this.generateUserField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ConfigDatabase
    {

        private string backupFileField;

        private ConfigDatabaseDbTuning dbTuningField;

        private string refNameField;

        private string dbNameField;

        /// <remarks/>
        public string BackupFile
        {
            get
            {
                return this.backupFileField;
            }
            set
            {
                this.backupFileField = value;
            }
        }

        /// <remarks/>
        public ConfigDatabaseDbTuning DbTuning
        {
            get
            {
                return this.dbTuningField;
            }
            set
            {
                this.dbTuningField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string refName
        {
            get
            {
                return this.refNameField;
            }
            set
            {
                this.refNameField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string dbName
        {
            get
            {
                return this.dbNameField;
            }
            set
            {
                this.dbNameField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ConfigDatabaseDbTuning
    {

        private ConfigDatabaseDbTuningDBFileGrowthMB dBFileGrowthMBField;

        private ConfigDatabaseDbTuningLogFileGrowthMB logFileGrowthMBField;

        private ConfigDatabaseDbTuningLogFileSizeGB logFileSizeGBField;

        /// <remarks/>
        public ConfigDatabaseDbTuningDBFileGrowthMB DBFileGrowthMB
        {
            get
            {
                return this.dBFileGrowthMBField;
            }
            set
            {
                this.dBFileGrowthMBField = value;
            }
        }

        /// <remarks/>
        public ConfigDatabaseDbTuningLogFileGrowthMB LogFileGrowthMB
        {
            get
            {
                return this.logFileGrowthMBField;
            }
            set
            {
                this.logFileGrowthMBField = value;
            }
        }

        /// <remarks/>
        public ConfigDatabaseDbTuningLogFileSizeGB LogFileSizeGB
        {
            get
            {
                return this.logFileSizeGBField;
            }
            set
            {
                this.logFileSizeGBField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ConfigDatabaseDbTuningDBFileGrowthMB
    {

        private byte valueField;

        /// <remarks/>
        [XmlAttribute()]
        public byte value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ConfigDatabaseDbTuningLogFileGrowthMB
    {

        private ushort valueField;

        /// <remarks/>
        [XmlAttribute()]
        public ushort value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ConfigDatabaseDbTuningLogFileSizeGB
    {

        private byte valueField;

        /// <remarks/>
        [XmlAttribute()]
        public byte value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ConfigFileShare
    {

        private string pathField;

        private string basePathField;

        private string localPathField;

        private string refNameField;

        private string nameField;

        private bool disabledField;

        /// <remarks/>
        public string Path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }

        /// <remarks/>
        public string BasePath
        {
            get
            {
                return this.basePathField;
            }
            set
            {
                this.basePathField = value;
            }
        }

        /// <remarks/>
        public string LocalPath
        {
            get
            {
                return this.localPathField;
            }
            set
            {
                this.localPathField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string refName
        {
            get
            {
                return this.refNameField;
            }
            set
            {
                this.refNameField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public bool disabled
        {
            get
            {
                return this.disabledField;
            }
            set
            {
                this.disabledField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ConfigServiceFabricCluster
    {

        private string clusterNameField;

        private ConfigServiceFabricClusterNodeType[] nodeTypeField;

        private ConfigServiceFabricClusterSetting[] serviceFabricSettingsField;

        /// <remarks/>
        public string ClusterName
        {
            get
            {
                return this.clusterNameField;
            }
            set
            {
                this.clusterNameField = value;
            }
        }

        /// <remarks/>
        [XmlElement("NodeType")]
        public ConfigServiceFabricClusterNodeType[] NodeType
        {
            get
            {
                return this.nodeTypeField;
            }
            set
            {
                this.nodeTypeField = value;
            }
        }

        /// <remarks/>
        [XmlArrayItem("Setting", IsNullable = false)]
        public ConfigServiceFabricClusterSetting[] ServiceFabricSettings
        {
            get
            {
                return this.serviceFabricSettingsField;
            }
            set
            {
                this.serviceFabricSettingsField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ConfigServiceFabricClusterNodeType
    {

        private ConfigServiceFabricClusterNodeTypeVM[] vMListField;

        private string nameField;

        private bool primaryField;

        private string namePrefixField;

        private string purposeField;

        private bool disabledField;

        /// <remarks/>
        [XmlArrayItem("VM", IsNullable = false)]
        public ConfigServiceFabricClusterNodeTypeVM[] VMList
        {
            get
            {
                return this.vMListField;
            }
            set
            {
                this.vMListField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public bool primary
        {
            get
            {
                return this.primaryField;
            }
            set
            {
                this.primaryField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string namePrefix
        {
            get
            {
                return this.namePrefixField;
            }
            set
            {
                this.namePrefixField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string purpose
        {
            get
            {
                return this.purposeField;
            }
            set
            {
                this.purposeField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public bool disabled
        {
            get
            {
                return this.disabledField;
            }
            set
            {
                this.disabledField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ConfigServiceFabricClusterNodeTypeVM
    {

        private string nameField;

        private string ipAddressField;

        private string faultDomainField;

        private string updateDomainField;

        private bool hasSSISField;

        private bool hasSSISFieldSpecified;

        /// <remarks/>
        [XmlAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string ipAddress
        {
            get
            {
                return this.ipAddressField;
            }
            set
            {
                this.ipAddressField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string faultDomain
        {
            get
            {
                return this.faultDomainField;
            }
            set
            {
                this.faultDomainField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string updateDomain
        {
            get
            {
                return this.updateDomainField;
            }
            set
            {
                this.updateDomainField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public bool hasSSIS
        {
            get
            {
                return this.hasSSISField;
            }
            set
            {
                this.hasSSISField = value;
            }
        }

        /// <remarks/>
        [XmlIgnore()]
        public bool hasSSISSpecified
        {
            get
            {
                return this.hasSSISFieldSpecified;
            }
            set
            {
                this.hasSSISFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ConfigServiceFabricClusterSetting
    {

        private ConfigServiceFabricClusterSettingParameter[] parametersField;

        private string nameField;

        private bool disabledField;

        /// <remarks/>
        [XmlArrayItem("Parameter", IsNullable = false)]
        public ConfigServiceFabricClusterSettingParameter[] Parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [XmlAttribute()]
        public bool disabled
        {
            get
            {
                return this.disabledField;
            }
            set
            {
                this.disabledField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ConfigServiceFabricClusterSettingParameter
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [XmlAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [XmlText()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ConfigSQLCluster
    {

        private string listenerNameField;

        private List<ConfigSQLClusterSQLVM> sQLVMListField;

        /// <remarks/>
        public string ListenerName
        {
            get
            {
                return this.listenerNameField;
            }
            set
            {
                this.listenerNameField = value;
            }
        }

        /// <remarks/>
        [XmlArrayItem("SQLVM", IsNullable = false)]
        public List<ConfigSQLClusterSQLVM> SQLVMList
        {
            get
            {
                return this.sQLVMListField;
            }
            set
            {
                this.sQLVMListField = value;
            }
        }
    }

    /// <remarks/>
    [Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [XmlType(AnonymousType = true)]
    public partial class ConfigSQLClusterSQLVM
    {

        private string nameField;

        /// <remarks/>
        [XmlAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }


}
