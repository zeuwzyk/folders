using System;
using System.IO;

namespace NpoiTest.Services
{
    class ReadFile
    {
        public static string checkFile()
        {
            string text = "";

            try
            {
                using (StreamReader reader = new StreamReader("C:\\Users\\User\\Downloads\\resx.txt"))
                    text = reader.ReadToEnd();
                text = text.Replace("{", "");
                text = text.Replace("\"", "");
            }
            catch (Exception exp)
            {
                Console.WriteLine("Not correct path was entered.");
            }

            return text;
        }
    }
}