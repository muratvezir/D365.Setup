using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D365.Setup
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
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
        [System.Xml.Serialization.XmlArrayItemAttribute("Certificate", IsNullable = false)]
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
        [System.Xml.Serialization.XmlArrayItemAttribute("Security", IsNullable = false)]
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
        [System.Xml.Serialization.XmlArrayItemAttribute("Database", IsNullable = false)]
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
        [System.Xml.Serialization.XmlArrayItemAttribute("FileShare", IsNullable = false)]
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
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConfigSchema
    {

        private decimal versionField;

        /// <remarks/>
        public decimal Version
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
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConfigADServiceAccounts
    {

        private string domainNameField;

        private ConfigADServiceAccountsADServiceAccount[] aDServiceAccountField;

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
        [System.Xml.Serialization.XmlElementAttribute("ADServiceAccount")]
        public ConfigADServiceAccountsADServiceAccount[] ADServiceAccount
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
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConfigCertificate
    {

        private string[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        private string typeField;

        private bool exportableField;

        private bool generateSelfSignedCertField;

        private bool generateADCSCertField;

        private bool generateADCSCertFieldSpecified;

        private bool disabledField;

        private bool disabledFieldSpecified;

        private bool manualPropertiesField;

        private bool manualPropertiesFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CertificateType", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("DNSName", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("EnhancedKeyUsage", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("FileName", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("KeyUsage", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Name", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ProtectTo", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Provider", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Subject", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Thumbprint", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool exportable
        {
            get
            {
                return this.exportableField;
            }
            set
            {
                this.exportableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool generateSelfSignedCert
        {
            get
            {
                return this.generateSelfSignedCertField;
            }
            set
            {
                this.generateSelfSignedCertField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool generateADCSCert
        {
            get
            {
                return this.generateADCSCertField;
            }
            set
            {
                this.generateADCSCertField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool generateADCSCertSpecified
        {
            get
            {
                return this.generateADCSCertFieldSpecified;
            }
            set
            {
                this.generateADCSCertFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool disabledSpecified
        {
            get
            {
                return this.disabledFieldSpecified;
            }
            set
            {
                this.disabledFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool manualProperties
        {
            get
            {
                return this.manualPropertiesField;
            }
            set
            {
                this.manualPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool manualPropertiesSpecified
        {
            get
            {
                return this.manualPropertiesFieldSpecified;
            }
            set
            {
                this.manualPropertiesFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        CertificateType,

        /// <remarks/>
        DNSName,

        /// <remarks/>
        EnhancedKeyUsage,

        /// <remarks/>
        FileName,

        /// <remarks/>
        KeyUsage,

        /// <remarks/>
        Name,

        /// <remarks/>
        ProtectTo,

        /// <remarks/>
        Provider,

        /// <remarks/>
        Subject,

        /// <remarks/>
        Thumbprint,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
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
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConfigSecurityUser
    {

        private string refNameField;

        private string typeField;

        private string userNameField;

        private bool generateUserField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
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
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConfigDatabaseDbTuningDBFileGrowthMB
    {

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConfigDatabaseDbTuningLogFileGrowthMB
    {

        private ushort valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConfigDatabaseDbTuningLogFileSizeGB
    {

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
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
        [System.Xml.Serialization.XmlElementAttribute("NodeType")]
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
        [System.Xml.Serialization.XmlArrayItemAttribute("Setting", IsNullable = false)]
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
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConfigServiceFabricClusterNodeType
    {

        private ConfigServiceFabricClusterNodeTypeVM[] vMListField;

        private string nameField;

        private bool primaryField;

        private string namePrefixField;

        private string purposeField;

        private bool disabledField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("VM", IsNullable = false)]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConfigServiceFabricClusterNodeTypeVM
    {

        private string nameField;

        private string ipAddressField;

        private string faultDomainField;

        private string updateDomainField;

        private bool hasSSISField;

        private bool hasSSISFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
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
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConfigServiceFabricClusterSetting
    {

        private ConfigServiceFabricClusterSettingParameter[] parametersField;

        private string nameField;

        private bool disabledField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Parameter", IsNullable = false)]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConfigServiceFabricClusterSettingParameter
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlTextAttribute()]
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
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
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
        [System.Xml.Serialization.XmlArrayItemAttribute("SQLVM", IsNullable = false)]
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
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ConfigSQLClusterSQLVM
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
