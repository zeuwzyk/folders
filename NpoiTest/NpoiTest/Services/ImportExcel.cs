using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;

namespace NpoiTest.Services
{
    class ImportExcel
    {
        public static string[,] GetExcelDataTable(string fileName)
        {
            List<string> NameColumns = new List<string>();
            var array = new string[,]{};

            try
            {
                IWorkbook workbook = null;
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                if (fileName.IndexOf(".xlsx") > 0)
                {
                    workbook = new XSSFWorkbook(fs);
                }
                else if (fileName.IndexOf(".xls") > 0)
                {
                    workbook = new HSSFWorkbook(fs);
                }

                ISheet sheet = workbook.GetSheetAt(0);

                if (sheet != null)
                {
                    IRow curRow = sheet.GetRow(0);

                    int columnCount = curRow.LastCellNum;
                    int rowCount = sheet.LastRowNum;

                    array = new string[columnCount, rowCount];

                    for (int i = 0; i < columnCount; i++)
                    {
                        NameColumns.Add(curRow.GetCell(i).StringCellValue.Trim());

                        for (int j = 0; j < rowCount; j++)
                        {
                            IRow row = sheet.GetRow(j);
                            if (row != null)
                            {
                                if (row.GetCell(i) != null)
                                {
                                    array[i, j] = row.GetCell(i).ToString(); //работает
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            
                return array;
        }
    }
}
