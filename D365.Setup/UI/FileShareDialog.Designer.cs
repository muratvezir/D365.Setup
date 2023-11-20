
namespace D365.Setup
{
    partial class FileShareDialog
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
            this.textBoxFileServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pBoxFileServer = new System.Windows.Forms.PictureBox();
            this.toolTipFileShare = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBase = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFileServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFileServer
            // 
            this.textBoxFileServer.Location = new System.Drawing.Point(79, 13);
            this.textBoxFileServer.Name = "textBoxFileServer";
            this.textBoxFileServer.Size = new System.Drawing.Size(145, 20);
            this.textBoxFileServer.TabIndex = 0;
            this.textBoxFileServer.TextChanged += new System.EventHandler(this.textBoxFileServer_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Server";
            // 
            // pBoxFileServer
            // 
            this.pBoxFileServer.Image = global::D365.Setup.Properties.Resources.Info;
            this.pBoxFileServer.Location = new System.Drawing.Point(230, 14);
            this.pBoxFileServer.Name = "pBoxFileServer";
            this.pBoxFileServer.Size = new System.Drawing.Size(20, 20);
            this.pBoxFileServer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxFileServer.TabIndex = 2;
            this.pBoxFileServer.TabStop = false;
            this.toolTipFileShare.SetToolTip(this.pBoxFileServer, "You must enter the name of the file server (netbios) to be used without \\\\ at the" +
        " beginning.");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::D365.Setup.Properties.Resources.Info;
            this.pictureBox1.Location = new System.Drawing.Point(230, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.toolTipFileShare.SetToolTip(this.pictureBox1, "You need to write the main share directory on the server, e.g. : C:\\D365Shares");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Base Folder";
            // 
            // textBoxBase
            // 
            this.textBoxBase.Location = new System.Drawing.Point(79, 36);
            this.textBoxBase.Name = "textBoxBase";
            this.textBoxBase.Size = new System.Drawing.Size(147, 20);
            this.textBoxBase.TabIndex = 4;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(228, 62);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(52, 24);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(172, 62);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(52, 24);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "Ok";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FileShareDialog
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(294, 97);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pBoxFileServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFileServer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileShareDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "File Share";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxFileServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFileServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pBoxFileServer;
        private System.Windows.Forms.ToolTip toolTipFileShare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBase;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
    }
}