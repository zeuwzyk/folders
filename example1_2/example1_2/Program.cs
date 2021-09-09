using System;

namespace example1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            int numRows = 0, numColumns = 0, auxiliaryValue=0;
            string command = "";

            while (length != 3)
            {
                Console.Write("Enter information (numbers of rows and columns, and l/r): ");
                string information = Console.ReadLine();
                string[] words = information.Split(' ');
                length = words.Length;

                if (length == 3)
                {
                    for (int i = 0; i < length; i++)
                    {
                        if (numRows == 0 && int.TryParse(words[i], out auxiliaryValue))
                            numRows = Verification(words[i], 0);
                        else if (numRows != 0 && numColumns == 0)
                            numColumns = Verification(words[i], 0);
                        else if (words[i] == "l" || words[i] == "r" && numRows != 0 && numColumns != 0)
                            command = words[i];
                        else if (words[i] != "l" || words[i] != "r" && (numRows == 0 || numColumns == 0))
                        {
                            Console.WriteLine("Not correct symbol or number was entered.\n");
                            length -= 1;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Not correct symbol or number was entered.\n");
                            length -= 1;
                            break;
                        }
                    }
                }
                else
                    Console.WriteLine("Not correct number of information was entered.\n");
            }

            int[,] matrix = new int[numRows, numColumns];
            Console.Write("\nMatrix:\n");
            Random rand = new Random();
            Console.Write("\n");
            string[,] stringMatrix = new string[numRows, numColumns];
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numColumns; j++)
                {
                    if (command == "l" && i == j)
                        stringMatrix[i, j] = "*";
                    else if (command == "r" && j == numColumns - 1 - i)
                        stringMatrix[i, j] = "*";
                    else
                        stringMatrix[i, j] = (rand.Next(10, 99)).ToString();
                    Console.Write($"{stringMatrix[i, j]} ");
                }
                Console.Write("\n");
            }
        }
        static int Verification(string word, int value)
        {
            if (int.TryParse(word, out value))
                return value;
            else
                return 0;
        }
    }
}
