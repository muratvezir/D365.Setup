
namespace D365.Setup
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupTop = new System.Windows.Forms.GroupBox();
            this.textBoxDomainName = new System.Windows.Forms.TextBox();
            this.labelDomain = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.textBoxConfig = new System.Windows.Forms.TextBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.configBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlConfig = new System.Windows.Forms.TabControl();
            this.tabPageCertificate = new System.Windows.Forms.TabPage();
            this.panelChild = new System.Windows.Forms.Panel();
            this.groupGmsa = new System.Windows.Forms.GroupBox();
            this.tabPageADServiceAccounts = new System.Windows.Forms.TabPage();
            this.chkDixF = new System.Windows.Forms.CheckBox();
            this.chkReportSvc = new System.Windows.Forms.CheckBox();
            this.chkAXSF = new System.Windows.Forms.CheckBox();
            this.chkFRCO = new System.Windows.Forms.CheckBox();
            this.chkFRPS = new System.Windows.Forms.CheckBox();
            this.chkFRAS = new System.Windows.Forms.CheckBox();
            this.chkLocalAgent = new System.Windows.Forms.CheckBox();
            this.textBoxFRCO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDixF = new System.Windows.Forms.TextBox();
            this.textBoxReportSvc = new System.Windows.Forms.TextBox();
            this.textBoxAXSF = new System.Windows.Forms.TextBox();
            this.textBoxFRPS = new System.Windows.Forms.TextBox();
            this.textBoxFRAS = new System.Windows.Forms.TextBox();
            this.textBoxLocalAgent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFRAS = new System.Windows.Forms.Label();
            this.labelLocalAgent = new System.Windows.Forms.Label();
            this.groupDatabase = new System.Windows.Forms.GroupBox();
            this.buttonRead = new System.Windows.Forms.Button();
            this.groupTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configBindingSource)).BeginInit();
            this.tabControlConfig.SuspendLayout();
            this.panelChild.SuspendLayout();
            this.groupGmsa.SuspendLayout();
            this.tabPageADServiceAccounts.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupTop
            // 
            this.groupTop.Controls.Add(this.textBoxDomainName);
            this.groupTop.Controls.Add(this.labelDomain);
            this.groupTop.Controls.Add(this.labelVersion);
            this.groupTop.Controls.Add(this.textBoxConfig);
            this.groupTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupTop.Location = new System.Drawing.Point(0, 0);
            this.groupTop.Name = "groupTop";
            this.groupTop.Size = new System.Drawing.Size(1620, 126);
            this.groupTop.TabIndex = 0;
            this.groupTop.TabStop = false;
            this.groupTop.Text = "General Info";
            // 
            // textBoxDomainName
            // 
            this.textBoxDomainName.Location = new System.Drawing.Point(182, 76);
            this.textBoxDomainName.Name = "textBoxDomainName";
            this.textBoxDomainName.Size = new System.Drawing.Size(297, 31);
            this.textBoxDomainName.TabIndex = 3;
            // 
            // labelDomain
            // 
            this.labelDomain.AutoSize = true;
            this.labelDomain.Location = new System.Drawing.Point(13, 82);
            this.labelDomain.Name = "labelDomain";
            this.labelDomain.Size = new System.Drawing.Size(147, 25);
            this.labelDomain.TabIndex = 2;
            this.labelDomain.Text = "Domain Name";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(13, 35);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(85, 25);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "Version";
            // 
            // textBoxConfig
            // 
            this.textBoxConfig.Location = new System.Drawing.Point(182, 32);
            this.textBoxConfig.Name = "textBoxConfig";
            this.textBoxConfig.Size = new System.Drawing.Size(297, 31);
            this.textBoxConfig.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.buttonRead);
            this.panelBottom.Controls.Add(this.btnSaveConfig);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 983);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1620, 100);
            this.panelBottom.TabIndex = 2;
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Location = new System.Drawing.Point(1484, 17);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(111, 59);
            this.btnSaveConfig.TabIndex = 0;
            this.btnSaveConfig.Text = "Save";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // tabControlConfig
            // 
            this.tabControlConfig.Controls.Add(this.tabPageADServiceAccounts);
            this.tabControlConfig.Controls.Add(this.tabPageCertificate);
            this.tabControlConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlConfig.Location = new System.Drawing.Point(0, 0);
            this.tabControlConfig.Name = "tabControlConfig";
            this.tabControlConfig.SelectedIndex = 0;
            this.tabControlConfig.Size = new System.Drawing.Size(1620, 957);
            this.tabControlConfig.TabIndex = 0;
            // 
            // tabPageCertificate
            // 
            this.tabPageCertificate.Location = new System.Drawing.Point(8, 39);
            this.tabPageCertificate.Name = "tabPageCertificate";
            this.tabPageCertificate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCertificate.Size = new System.Drawing.Size(1282, 666);
            this.tabPageCertificate.TabIndex = 1;
            this.tabPageCertificate.Text = "Certificates";
            this.tabPageCertificate.UseVisualStyleBackColor = true;
            // 
            // panelChild
            // 
            this.panelChild.Controls.Add(this.tabControlConfig);
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(0, 126);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(1620, 957);
            this.panelChild.TabIndex = 1;
            // 
            // groupGmsa
            // 
            this.groupGmsa.Controls.Add(this.chkDixF);
            this.groupGmsa.Controls.Add(this.chkReportSvc);
            this.groupGmsa.Controls.Add(this.chkAXSF);
            this.groupGmsa.Controls.Add(this.chkFRCO);
            this.groupGmsa.Controls.Add(this.chkFRPS);
            this.groupGmsa.Controls.Add(this.chkFRAS);
            this.groupGmsa.Controls.Add(this.chkLocalAgent);
            this.groupGmsa.Controls.Add(this.textBoxFRCO);
            this.groupGmsa.Controls.Add(this.label5);
            this.groupGmsa.Controls.Add(this.textBoxDixF);
            this.groupGmsa.Controls.Add(this.textBoxReportSvc);
            this.groupGmsa.Controls.Add(this.textBoxAXSF);
            this.groupGmsa.Controls.Add(this.textBoxFRPS);
            this.groupGmsa.Controls.Add(this.textBoxFRAS);
            this.groupGmsa.Controls.Add(this.textBoxLocalAgent);
            this.groupGmsa.Controls.Add(this.label4);
            this.groupGmsa.Controls.Add(this.label3);
            this.groupGmsa.Controls.Add(this.label2);
            this.groupGmsa.Controls.Add(this.label1);
            this.groupGmsa.Controls.Add(this.labelFRAS);
            this.groupGmsa.Controls.Add(this.labelLocalAgent);
            this.groupGmsa.Location = new System.Drawing.Point(10, 18);
            this.groupGmsa.Name = "groupGmsa";
            this.groupGmsa.Size = new System.Drawing.Size(548, 316);
            this.groupGmsa.TabIndex = 21;
            this.groupGmsa.TabStop = false;
            this.groupGmsa.Text = "Gmsa";
            // 
            // tabPageADServiceAccounts
            // 
            this.tabPageADServiceAccounts.Controls.Add(this.groupDatabase);
            this.tabPageADServiceAccounts.Controls.Add(this.groupGmsa);
            this.tabPageADServiceAccounts.Location = new System.Drawing.Point(8, 39);
            this.tabPageADServiceAccounts.Name = "tabPageADServiceAccounts";
            this.tabPageADServiceAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageADServiceAccounts.Size = new System.Drawing.Size(1604, 910);
            this.tabPageADServiceAccounts.TabIndex = 0;
            this.tabPageADServiceAccounts.Text = "Accounts";
            this.tabPageADServiceAccounts.UseVisualStyleBackColor = true;
            // 
            // chkDixF
            // 
            this.chkDixF.AutoSize = true;
            this.chkDixF.Location = new System.Drawing.Point(481, 257);
            this.chkDixF.Name = "chkDixF";
            this.chkDixF.Size = new System.Drawing.Size(28, 27);
            this.chkDixF.TabIndex = 41;
            this.chkDixF.UseVisualStyleBackColor = true;
            // 
            // chkReportSvc
            // 
            this.chkReportSvc.AutoSize = true;
            this.chkReportSvc.Location = new System.Drawing.Point(481, 220);
            this.chkReportSvc.Name = "chkReportSvc";
            this.chkReportSvc.Size = new System.Drawing.Size(28, 27);
            this.chkReportSvc.TabIndex = 40;
            this.chkReportSvc.UseVisualStyleBackColor = true;
            // 
            // chkAXSF
            // 
            this.chkAXSF.AutoSize = true;
            this.chkAXSF.Location = new System.Drawing.Point(481, 183);
            this.chkAXSF.Name = "chkAXSF";
            this.chkAXSF.Size = new System.Drawing.Size(28, 27);
            this.chkAXSF.TabIndex = 39;
            this.chkAXSF.UseVisualStyleBackColor = true;
            // 
            // chkFRCO
            // 
            this.chkFRCO.AutoSize = true;
            this.chkFRCO.Location = new System.Drawing.Point(481, 146);
            this.chkFRCO.Name = "chkFRCO";
            this.chkFRCO.Size = new System.Drawing.Size(28, 27);
            this.chkFRCO.TabIndex = 38;
            this.chkFRCO.UseVisualStyleBackColor = true;
            // 
            // chkFRPS
            // 
            this.chkFRPS.AutoSize = true;
            this.chkFRPS.Location = new System.Drawing.Point(481, 109);
            this.chkFRPS.Name = "chkFRPS";
            this.chkFRPS.Size = new System.Drawing.Size(28, 27);
            this.chkFRPS.TabIndex = 37;
            this.chkFRPS.UseVisualStyleBackColor = true;
            // 
            // chkFRAS
            // 
            this.chkFRAS.AutoSize = true;
            this.chkFRAS.Location = new System.Drawing.Point(481, 72);
            this.chkFRAS.Name = "chkFRAS";
            this.chkFRAS.Size = new System.Drawing.Size(28, 27);
            this.chkFRAS.TabIndex = 36;
            this.chkFRAS.UseVisualStyleBackColor = true;
            // 
            // chkLocalAgent
            // 
            this.chkLocalAgent.AutoSize = true;
            this.chkLocalAgent.Location = new System.Drawing.Point(481, 36);
            this.chkLocalAgent.Name = "chkLocalAgent";
            this.chkLocalAgent.Size = new System.Drawing.Size(28, 27);
            this.chkLocalAgent.TabIndex = 35;
            this.chkLocalAgent.UseVisualStyleBackColor = true;
            // 
            // textBoxFRCO
            // 
            this.textBoxFRCO.Location = new System.Drawing.Point(202, 143);
            this.textBoxFRCO.Name = "textBoxFRCO";
            this.textBoxFRCO.Size = new System.Drawing.Size(261, 31);
            this.textBoxFRCO.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "FRCO";
            // 
            // textBoxDixF
            // 
            this.textBoxDixF.Location = new System.Drawing.Point(202, 254);
            this.textBoxDixF.Name = "textBoxDixF";
            this.textBoxDixF.Size = new System.Drawing.Size(261, 31);
            this.textBoxDixF.TabIndex = 32;
            // 
            // textBoxReportSvc
            // 
            this.textBoxReportSvc.Location = new System.Drawing.Point(202, 217);
            this.textBoxReportSvc.Name = "textBoxReportSvc";
            this.textBoxReportSvc.Size = new System.Drawing.Size(261, 31);
            this.textBoxReportSvc.TabIndex = 30;
            // 
            // textBoxAXSF
            // 
            this.textBoxAXSF.Location = new System.Drawing.Point(202, 180);
            this.textBoxAXSF.Name = "textBoxAXSF";
            this.textBoxAXSF.Size = new System.Drawing.Size(261, 31);
            this.textBoxAXSF.TabIndex = 28;
            // 
            // textBoxFRPS
            // 
            this.textBoxFRPS.Location = new System.Drawing.Point(202, 106);
            this.textBoxFRPS.Name = "textBoxFRPS";
            this.textBoxFRPS.Size = new System.Drawing.Size(261, 31);
            this.textBoxFRPS.TabIndex = 26;
            // 
            // textBoxFRAS
            // 
            this.textBoxFRAS.Location = new System.Drawing.Point(202, 69);
            this.textBoxFRAS.Name = "textBoxFRAS";
            this.textBoxFRAS.Size = new System.Drawing.Size(261, 31);
            this.textBoxFRAS.TabIndex = 24;
            // 
            // textBoxLocalAgent
            // 
            this.textBoxLocalAgent.Location = new System.Drawing.Point(202, 32);
            this.textBoxLocalAgent.Name = "textBoxLocalAgent";
            this.textBoxLocalAgent.Size = new System.Drawing.Size(261, 31);
            this.textBoxLocalAgent.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "DixF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "ReportSvc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "AXSF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "FRPS";
            // 
            // labelFRAS
            // 
            this.labelFRAS.AutoSize = true;
            this.labelFRAS.Location = new System.Drawing.Point(40, 72);
            this.labelFRAS.Name = "labelFRAS";
            this.labelFRAS.Size = new System.Drawing.Size(68, 25);
            this.labelFRAS.TabIndex = 23;
            this.labelFRAS.Text = "FRAS";
            // 
            // labelLocalAgent
            // 
            this.labelLocalAgent.AutoSize = true;
            this.labelLocalAgent.Location = new System.Drawing.Point(40, 35);
            this.labelLocalAgent.Name = "labelLocalAgent";
            this.labelLocalAgent.Size = new System.Drawing.Size(126, 25);
            this.labelLocalAgent.TabIndex = 21;
            this.labelLocalAgent.Text = "Local Agent";
            // 
            // groupDatabase
            // 
            this.groupDatabase.Location = new System.Drawing.Point(10, 341);
            this.groupDatabase.Name = "groupDatabase";
            this.groupDatabase.Size = new System.Drawing.Size(548, 171);
            this.groupDatabase.TabIndex = 22;
            this.groupDatabase.TabStop = false;
            this.groupDatabase.Text = "Database";
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(14, 17);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(111, 59);
            this.buttonRead.TabIndex = 1;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 1083);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.groupTop);
            this.Name = "FormMain";
            this.Text = "365 f&O Config Template";
            this.groupTop.ResumeLayout(false);
            this.groupTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.configBindingSource)).EndInit();
            this.tabControlConfig.ResumeLayout(false);
            this.panelChild.ResumeLayout(false);
            this.groupGmsa.ResumeLayout(false);
            this.groupGmsa.PerformLayout();
            this.tabPageADServiceAccounts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupTop;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.TextBox textBoxConfig;
        private System.Windows.Forms.TextBox textBoxDomainName;
        private System.Windows.Forms.Label labelDomain;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.BindingSource configBindingSource;
        private System.Windows.Forms.TabControl tabControlConfig;
        private System.Windows.Forms.TabPage tabPageCertificate;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.TabPage tabPageADServiceAccounts;
        private System.Windows.Forms.GroupBox groupGmsa;
        private System.Windows.Forms.CheckBox chkDixF;
        private System.Windows.Forms.CheckBox chkReportSvc;
        private System.Windows.Forms.CheckBox chkAXSF;
        private System.Windows.Forms.CheckBox chkFRCO;
        private System.Windows.Forms.CheckBox chkFRPS;
        private System.Windows.Forms.CheckBox chkFRAS;
        private System.Windows.Forms.CheckBox chkLocalAgent;
        private System.Windows.Forms.TextBox textBoxFRCO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDixF;
        private System.Windows.Forms.TextBox textBoxReportSvc;
        private System.Windows.Forms.TextBox textBoxAXSF;
        private System.Windows.Forms.TextBox textBoxFRPS;
        private System.Windows.Forms.TextBox textBoxFRAS;
        private System.Windows.Forms.TextBox textBoxLocalAgent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFRAS;
        private System.Windows.Forms.Label labelLocalAgent;
        private System.Windows.Forms.GroupBox groupDatabase;
        private System.Windows.Forms.Button buttonRead;
    }
}