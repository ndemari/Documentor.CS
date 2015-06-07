using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Documentor.CS
{
    public partial class frmMain : MetroForm
    {
        string folder;
        string FileName = "filename.csv";
        FileHandler document = new FileHandler();
        
        void ProgressBarIncrement(int intLoop)
        {
            for (int i = 0; i < intLoop; i++)
            {
                metroProgressBar1.Increment(1);
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(folder);

            int intFiles = 0;
            document.FileCreate(FileName);
            if (chkSubfolders.Checked && rdoFile.Checked)
            {
                document.AllFileDocCreate(di);
                document.AllFilePdfCreate(di);

                document.FileClose();

                metroProgressBar1.Maximum = document.CountCSVRecords(FileName);
                ProgressBarIncrement(metroProgressBar1.Maximum);

            }
            else if (chkSubfolders.Checked && rdoFilePath.Checked)
            {
                document.AllFullFileDocCreate(di);
                document.AllFullFilePdfCreate(di);

                document.FileClose();
                metroProgressBar1.Maximum = document.CountCSVRecords(FileName);

                ProgressBarIncrement(metroProgressBar1.Maximum);
            }
            else if (!chkSubfolders.Checked && rdoFile.Checked)
            {
                document.FolderFileDocCreate(di);
                document.FolderFilePdfCreate(di);

                document.FileClose();

                metroProgressBar1.Maximum = document.CountCSVRecords(FileName);
                ProgressBarIncrement(metroProgressBar1.Maximum);
            }
            else if (!chkSubfolders.Checked && rdoFilePath.Checked)
            {
                document.FolderFullFileDocCreate(di);
                document.FolderFullFilePdfCreate(di);

                document.FileClose();

                metroProgressBar1.Maximum = document.CountCSVRecords(FileName);
                ProgressBarIncrement(metroProgressBar1.Maximum);
            }

            lstFileContents.DataSource = document.FillCSVListbox(FileName);
            intFiles = metroProgressBar1.Maximum;

            lblNumberOfFiles.Text = intFiles.ToString();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            if (txtFolder.Text == string.Empty)
            {
                txtFolder.Text = folderBrowser.SelectedPath;
                folder = txtFolder.Text;

                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    txtFolder.Text = folderBrowser.SelectedPath;
                    folder = folderBrowser.SelectedPath;
                }
            }
            else
            {
                folderBrowser.SelectedPath = txtFolder.Text;
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    txtFolder.Text = folderBrowser.SelectedPath;
                    folder = folderBrowser.SelectedPath;
                }
            }
        }

        private void chkSubfolders_CheckedChanged(object sender, EventArgs e)
        {
            if (metroProgressBar1.Maximum != 0)
            {
                metroProgressBar1.Maximum = 0;
            }

            lblNumberOfFiles.Text = String.Empty;
        }

        private void btnNotpadPP_Click(object sender, EventArgs e)
        {
            Process.Start("notepad++.exe", "filename.csv");
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Process.Start("EXCEL.EXE", "filename.csv");
        }
    }
}
