namespace Documentor.CS
{
    partial class frmMain
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
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.txtFolder = new MetroFramework.Controls.MetroTextBox();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.lstFileContents = new MetroFramework.Controls.MetroComboBox();
            this.btnNotpadPP = new MetroFramework.Controls.MetroButton();
            this.btnExcel = new MetroFramework.Controls.MetroButton();
            this.chkSubfolders = new MetroFramework.Controls.MetroCheckBox();
            this.rdoFile = new MetroFramework.Controls.MetroRadioButton();
            this.rdoFilePath = new MetroFramework.Controls.MetroRadioButton();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(24, 75);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(223, 23);
            this.txtFolder.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(271, 75);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(24, 124);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            // 
            // lstFileContents
            // 
            this.lstFileContents.FormattingEnabled = true;
            this.lstFileContents.ItemHeight = 23;
            this.lstFileContents.Location = new System.Drawing.Point(491, 103);
            this.lstFileContents.Name = "lstFileContents";
            this.lstFileContents.Size = new System.Drawing.Size(362, 29);
            this.lstFileContents.TabIndex = 3;
            // 
            // btnNotpadPP
            // 
            this.btnNotpadPP.Location = new System.Drawing.Point(271, 140);
            this.btnNotpadPP.Name = "btnNotpadPP";
            this.btnNotpadPP.Size = new System.Drawing.Size(115, 23);
            this.btnNotpadPP.TabIndex = 4;
            this.btnNotpadPP.Text = "Open Notepad++";
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(271, 197);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(115, 23);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.Text = "Open Excel";
            // 
            // chkSubfolders
            // 
            this.chkSubfolders.AutoSize = true;
            this.chkSubfolders.Location = new System.Drawing.Point(24, 178);
            this.chkSubfolders.Name = "chkSubfolders";
            this.chkSubfolders.Size = new System.Drawing.Size(123, 15);
            this.chkSubfolders.TabIndex = 6;
            this.chkSubfolders.Text = "Include SubFolders";
            this.chkSubfolders.UseVisualStyleBackColor = true;
            // 
            // rdoFile
            // 
            this.rdoFile.AutoSize = true;
            this.rdoFile.Location = new System.Drawing.Point(24, 219);
            this.rdoFile.Name = "rdoFile";
            this.rdoFile.Size = new System.Drawing.Size(41, 15);
            this.rdoFile.TabIndex = 7;
            this.rdoFile.TabStop = true;
            this.rdoFile.Text = "File";
            this.rdoFile.UseVisualStyleBackColor = true;
            // 
            // rdoFilePath
            // 
            this.rdoFilePath.AutoSize = true;
            this.rdoFilePath.Location = new System.Drawing.Point(24, 258);
            this.rdoFilePath.Name = "rdoFilePath";
            this.rdoFilePath.Size = new System.Drawing.Size(79, 15);
            this.rdoFilePath.TabIndex = 8;
            this.rdoFilePath.TabStop = true;
            this.rdoFilePath.Text = "File + Path";
            this.rdoFilePath.UseVisualStyleBackColor = true;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(24, 300);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(829, 23);
            this.metroProgressBar1.TabIndex = 9;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(491, 78);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "File Quick Look";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 350);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.rdoFilePath);
            this.Controls.Add(this.rdoFile);
            this.Controls.Add(this.chkSubfolders);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnNotpadPP);
            this.Controls.Add(this.lstFileContents);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFolder);
            this.Name = "frmMain";
            this.Text = "Documentor.CS";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTextBox txtFolder;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroButton btnStart;
        private MetroFramework.Controls.MetroComboBox lstFileContents;
        private MetroFramework.Controls.MetroButton btnNotpadPP;
        private MetroFramework.Controls.MetroButton btnExcel;
        private MetroFramework.Controls.MetroCheckBox chkSubfolders;
        private MetroFramework.Controls.MetroRadioButton rdoFile;
        private MetroFramework.Controls.MetroRadioButton rdoFilePath;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

