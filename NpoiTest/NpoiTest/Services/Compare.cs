using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NpoiTest.Services
{
    class Compare
    {
        public static Dictionary<string, string> CompareInformation(string textFile, string[,] textExcel)
        {
            string[] inf;
            List<string> languageName = new List<string>();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            inf = textFile.Split("},");

            for (int i = 0; i < inf.Length; i++)
            {
                for (int j = 0; j < textExcel.GetLength(0); j++)
                {
                    if (inf[i].ToLower().Contains(textExcel[j, 0].ToLower()))
                    {

                        languageName.Add(inf[i].ToLower().Replace(textExcel[j, 0].ToLower(), "")
                                    .Replace(",", "")
                                    .Replace("}", "").Replace("\r\n", "").Replace(" ", ""));

                        dictionary.Add(textExcel[j, 0].ToLower(), languageName[i]);
                    }
                }
            }

            //Console.WriteLine("j");
            return dictionary;
        }

        public static void CreateFile(Dictionary<string, string> namesList, string[,] textExcel)//массив ARRAY     
        {
            Console.Write("\nCreate new file.");
            string nameFile = "resources.";

            for (int i = 0; i < namesList.Count; i++)
            {
                if (namesList.ContainsKey(""))
                {
                    nameFile = "D:\\Projects\\NpoiTest\\resources\\" + nameFile + "resx";
                }
                else
                {
                    nameFile = "D:\\Projects\\NpoiTest\\resources\\" + nameFile + "tr" + ".resx";
                }

                StreamWriter file = File.CreateText(nameFile);


                for (int j = 0; j < textExcel.GetLength(1); j++)
                {
                    //using (var writer = new StreamWriter(nameFile, true))
                    //{
                    file.WriteLine(textExcel[i, j]);//writer

                    //}
                    // File.WriteAllText(nameFile, textExcel[i, j]);

                }
                file.Close();
            }

        }
    }
}