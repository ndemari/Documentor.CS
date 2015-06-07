using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace Documentor.CS 
{
    class FileHandler : MetroForm
    {
        private StreamWriter outFile;
        private StreamReader inFile;
        public List<FileInfo> fileDoc = new List<FileInfo>();
        public List<FileInfo> filePdf = new List<FileInfo>();
        public string filePath = "";

        public void FileCreate(string fileName)
        {
            outFile = File.AppendText(fileName);
        }

        public void FileClose()
        {
            outFile.Close();
        }

        public void CloseinFile()
        {
            inFile.Close();
        }

        public void AllFileDocCreate(DirectoryInfo directory)
        {
            foreach (var docFile in directory.EnumerateFiles("*.doc*", SearchOption.AllDirectories))
            {
                if (!docFile.Name.Contains("~") && !docFile.FullName.Contains(".FileSlack"))
                {
                    outFile.Write(docFile.Name + ",");
                    outFile.Write(docFile.CreationTime.ToString());
                    outFile.WriteLine();
                    fileDoc.Add(docFile);
                }
            }
        }

        public void AllFilePdfCreate(DirectoryInfo directory)
        {
            foreach (var pdfDoc in directory.EnumerateFiles("*.pdf", SearchOption.AllDirectories))
            {
                if (!pdfDoc.Name.Contains("~") && !pdfDoc.FullName.Contains(".FileSlack"))
                {
                    outFile.Write(pdfDoc.Name + ",");
                    outFile.Write(pdfDoc.CreationTime.ToString());
                    outFile.WriteLine();
                    filePdf.Add(pdfDoc);
                }
            }
        }

        public void FolderFileDocCreate(DirectoryInfo directory)
        {
            foreach (var docFile in directory.EnumerateFiles("*.doc*"))
            {
                if (!docFile.Name.Contains("~") && !docFile.FullName.Contains(".FileSlack"))
                {
                    outFile.Write(docFile.Name + ",");
                    outFile.Write(docFile.CreationTime.ToString());
                    outFile.WriteLine();
                    fileDoc.Add(docFile);
                }
            }
        }

        public void FolderFilePdfCreate(DirectoryInfo directory)
        {
            foreach (var pdfDoc in directory.EnumerateFiles("*.pdf"))
            {
                if (!pdfDoc.Name.Contains("~") && !pdfDoc.FullName.Contains(".FileSlack"))
                {
                    outFile.Write(pdfDoc.Name + ",");
                    outFile.Write(pdfDoc.CreationTime.ToString());
                    outFile.WriteLine();
                    filePdf.Add(pdfDoc);
                }
            }
        }

        public void AllFullFileDocCreate(DirectoryInfo directory)
        {
            foreach (var docFile in directory.EnumerateFiles("*.doc*", SearchOption.AllDirectories))
            {
                if (!docFile.Name.Contains("~") && !docFile.FullName.Contains(".FileSlack"))
                {
                    outFile.Write(docFile.FullName + ",");
                    outFile.Write(docFile.CreationTime.ToString());
                    outFile.WriteLine();
                    fileDoc.Add(docFile);
                }
            }
        }

        public void AllFullFilePdfCreate(DirectoryInfo directory)
        {
            foreach (var pdfDoc in directory.EnumerateFiles("*.pdf", SearchOption.AllDirectories))
            {
                if (!pdfDoc.Name.Contains("~") && !pdfDoc.FullName.Contains(".FileSlack"))
                {
                    outFile.Write(pdfDoc.FullName + ",");
                    outFile.Write(pdfDoc.CreationTime.ToString());
                    outFile.WriteLine();
                    fileDoc.Add(pdfDoc);
                }
            }
        }

        public void FolderFullFileDocCreate(DirectoryInfo directory)
        {
            foreach (var docFile in directory.EnumerateFiles("*.doc*"))
            {
                if (!docFile.Name.Contains("~") && !docFile.FullName.Contains(".FileSlack"))
                {
                    outFile.Write(docFile.FullName + ",");
                    outFile.Write(docFile.CreationTime.ToString());
                    outFile.WriteLine();
                    fileDoc.Add(docFile);
                }
            }
        }

        public void FolderFullFilePdfCreate(DirectoryInfo directory)
        {
            foreach (var pdfDoc in directory.EnumerateFiles("*.pdf"))
            {
                if (!pdfDoc.Name.Contains("~") && !pdfDoc.FullName.Contains(".FileSlack"))
                {
                    outFile.Write(pdfDoc.FullName + ",");
                    outFile.Write(pdfDoc.CreationTime.ToString());
                    outFile.WriteLine();
                    fileDoc.Add(pdfDoc);
                }
            }
        }

        public int CountCSVRecords(string fileName)
        {
            int intCount = 0;

            if (File.Exists(fileName))
            {
                string strFile;
                inFile = File.OpenText(fileName);
                while (inFile.Peek() > -1)
                {
                    strFile = inFile.ReadLine();
                    intCount++;
                }
                inFile.Close();
            }
            else
            {
                return 0;
            }

            return intCount;
        }

        public List<string> FillCSVListbox(string fileName)
        {
            List<string> tempList = new List<string>();
            if (File.Exists(fileName))
            {
                inFile = File.OpenText(fileName);
                while (inFile.Peek() > -1)
                {
                    string strIndexOf = inFile.ReadLine();
                    int intIndex = strIndexOf.IndexOf(",");
                    string strFileName = strIndexOf.Substring(0, intIndex);

                    tempList.Add(strFileName);
                }
                inFile.Close();
            }
            else
            {
                return null;
            }
            return tempList;
        }
    }
}
