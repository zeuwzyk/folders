using System;
using System.Collections.Generic;
using NpoiTest.Services;

namespace NpoiTest
{
    class Program
    {
        static void Main()
        {
            string text;
            var information = new string[,] { }; 
            Dictionary<string,string> namesList;

            information = ImportExcel.GetExcelDataTable("C:\\Users\\User\\Downloads\\GUI.xlsx");
            text = ReadFile.checkFile();
            namesList = Compare.CompareInformation(text, information);

            Compare.CreateFile(namesList, information);
        }
    }
}
