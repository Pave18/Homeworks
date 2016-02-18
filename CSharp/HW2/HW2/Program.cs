using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    // Павленко Егор гр42014
    class Program
    {
        private static bool isSimpleNum(int N)
        {
            //чтоб убедится простое число или нет достаточно проверить не делитсья ли 
            //число на числа до его половины
            for (int i = 2; i <= (int)(N / 2); ++i)
            {
                if (N % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            /*
            10. Дана строка текста, в которой слова разделены пробелами. Необходимо:
            - вычислить количество слов в строке;
            - найти самое длинное слово, которое заканчивается на «у»;
            - переставить слова в строке в обратном порядке,  затем вывести на экран предложение.
            */
            Console.WriteLine("\t\tTask 1\n");

            string str = "Kik Kfy dsgjopph dsgjoppy jdnflk";
            Console.WriteLine("Source string:\n " + str);

            string[] words = str.Split(new char[] { ' ', ',', '.', ':', ';', '-', '_' });

            Console.WriteLine("\nThe number of words per line: " + words.Length + '\n');//количество слов в строке;

            int maxWordLength = 0;
            foreach (string a in words)// ищем самое длинное слово которое заканчивается на «у»
            {
                if (a.Last() == 'y' && a.Length > maxWordLength)
                    maxWordLength = a.Length;
            }
            Console.WriteLine("The longest word that ends in \"y\": ");// выводим самое длинное слово которое заканчивается на «у»
            foreach (string a in words)
            {
                if (a.Last() == 'y' && a.Length == maxWordLength)
                    Console.Write(a);
            }

            Console.WriteLine("\n\nSwapping in a row in the reverse order: ");// слова в строке в обратном порядке
            for (int i = words.Length - 1; 0 < i; --i)
            {
                if (i == words.Length - 1)
                    Console.Write(words[i]);
                else
                    Console.Write(" " + words[i]);
            }


            Console.WriteLine("\n\n\n\t\tTask 2\n");
            /*
            10.Напишите программу для поиска наибольшего простого числа среди элементов рваного массива.  
            */

            int[][] mass = new int[5][];

            mass[0] = new int[6] { 54, 0, 0, 896, 55, 5555555 };
            mass[1] = new int[7] { 0, 3, 4, 0, 0, 0, 6 };
            mass[2] = new int[3] { 4, 13, 43 };
            mass[3] = new int[2] { 0, 0 };
            mass[4] = new int[1] { 55559555 };

            int maxNum = 0;
            for (int i = 0; i < mass.Length; ++i)//поиск макс зачения 
            {
                for (int j = 0; j <= mass[i].Length - 1; ++j)
                {
                    if (isSimpleNum(mass[i][j]) == true && mass[i][j] > maxNum)
                        maxNum = mass[i][j];
                }
            }

            for (int i = 0; i < mass.Length; ++i)// ввывод 
            {
                for (int j = 0; j <= mass[i].Length - 1; ++j)
                {
                    if (mass[i][j] == maxNum)
                        Console.WriteLine("mass[" + i + "][" + j + "] = " + maxNum);
                    else if (maxNum == 0)
                        Console.WriteLine();
                }
            }


        }
    }
}
