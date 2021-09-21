using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Linq;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeDataBase
{
    static class FileHelper
    {
        public static void SaveFile()
        {
            
        }

        public static string fileName = "";

        public static string OpenFile(int checkValue)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Files (*.json, *.xml) | *.json; *.xml",
                RestoreDirectory = true
            };

            if (checkValue == 1)
            {
                openFileDialog.Title = "Upload file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog.FileName;
                }
                else
                {
                    MessageBox.Show("File is not entered.", "Message");
                }
            }

            return fileName;
        }
    }
}

