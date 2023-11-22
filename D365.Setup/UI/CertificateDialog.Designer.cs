
namespace D365.Setup
{
    partial class CertificateDialog
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
            this.textBoxtenant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTipCertificate = new System.Windows.Forms.ToolTip(this.components);
            this.pBoxFileServer = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxProtectTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSSRS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFileServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxtenant
            // 
            this.textBoxtenant.Location = new System.Drawing.Point(131, 26);
            this.textBoxtenant.Name = "textBoxtenant";
            this.textBoxtenant.Size = new System.Drawing.Size(449, 31);
            this.textBoxtenant.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tenant";
            // 
            // pBoxFileServer
            // 
            this.pBoxFileServer.Image = global::D365.Setup.Properties.Resources.Info;
            this.pBoxFileServer.Location = new System.Drawing.Point(589, 26);
            this.pBoxFileServer.Margin = new System.Windows.Forms.Padding(6);
            this.pBoxFileServer.Name = "pBoxFileServer";
            this.pBoxFileServer.Size = new System.Drawing.Size(40, 38);
            this.pBoxFileServer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxFileServer.TabIndex = 3;
            this.pBoxFileServer.TabStop = false;
            this.toolTipCertificate.SetToolTip(this.pBoxFileServer, "Enter the domain of the star certificate (e.g contoso.com)");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::D365.Setup.Properties.Resources.Info;
            this.pictureBox1.Location = new System.Drawing.Point(589, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.toolTipCertificate.SetToolTip(this.pictureBox1, "Enter the domain user for the protecto part of the certificates (e.g Mydomain\\adm" +
        "inistrator) ");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::D365.Setup.Properties.Resources.Info;
            this.pictureBox2.Location = new System.Drawing.Point(589, 106);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "";
            this.toolTipCertificate.SetToolTip(this.pictureBox2, "Enter the FQDN of the SSRS computer (eg PDFBIN1.contoso.com)");
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(525, 159);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(104, 46);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(413, 159);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(104, 46);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "Ok";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxProtectTo
            // 
            this.textBoxProtectTo.Location = new System.Drawing.Point(131, 66);
            this.textBoxProtectTo.Name = "textBoxProtectTo";
            this.textBoxProtectTo.Size = new System.Drawing.Size(449, 31);
            this.textBoxProtectTo.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Protect To";
            // 
            // textBoxSSRS
            // 
            this.textBoxSSRS.Location = new System.Drawing.Point(131, 103);
            this.textBoxSSRS.Name = "textBoxSSRS";
            this.textBoxSSRS.Size = new System.Drawing.Size(449, 31);
            this.textBoxSSRS.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "SSRS";
            // 
            // CertificateDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(647, 220);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSSRS);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxProtectTo);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.pBoxFileServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxtenant);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CertificateDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Certificate Dialog";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFileServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxtenant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTipCertificate;
        private System.Windows.Forms.PictureBox pBoxFileServer;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxProtectTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxSSRS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}