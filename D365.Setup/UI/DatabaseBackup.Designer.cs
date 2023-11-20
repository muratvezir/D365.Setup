
namespace D365.Setup
{
    partial class DatabaseBackup
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBackupFile = new System.Windows.Forms.TextBox();
            this.pBoxFileServer = new System.Windows.Forms.PictureBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.toolTipDatabase = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFileServer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Backup File Name";
            // 
            // textBoxBackupFile
            // 
            this.textBoxBackupFile.Location = new System.Drawing.Point(112, 6);
            this.textBoxBackupFile.Name = "textBoxBackupFile";
            this.textBoxBackupFile.Size = new System.Drawing.Size(140, 20);
            this.textBoxBackupFile.TabIndex = 1;
            // 
            // pBoxFileServer
            // 
            this.pBoxFileServer.Image = global::D365.Setup.Properties.Resources.Info;
            this.pBoxFileServer.Location = new System.Drawing.Point(258, 6);
            this.pBoxFileServer.Name = "pBoxFileServer";
            this.pBoxFileServer.Size = new System.Drawing.Size(20, 20);
            this.pBoxFileServer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxFileServer.TabIndex = 3;
            this.pBoxFileServer.TabStop = false;
            this.toolTipDatabase.SetToolTip(this.pBoxFileServer, "Write Full Path of your db backup on SQL Server Local\r\nDirectory  (eg C:\\SqlBacku" +
        "ps\\AxBootstrapDB_Empty.bak)");
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(228, 32);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(52, 24);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(172, 32);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(52, 24);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "Ok";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // DatabaseBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 63);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.pBoxFileServer);
            this.Controls.Add(this.textBoxBackupFile);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatabaseBackup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Database Backup";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFileServer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBackupFile;
        private System.Windows.Forms.PictureBox pBoxFileServer;
        private System.Windows.Forms.ToolTip toolTipDatabase;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
    }
}