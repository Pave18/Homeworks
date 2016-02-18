using System;
using System.Text.RegularExpressions;

namespace hw_ip
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите IPv4: ");
                string inputText = Console.ReadLine();

                string pattern = "\\A\\d{1,3}.\\d{1,3}.\\d{1,3}.\\d{1,3}";

                Regex regex = new Regex(pattern, RegexOptions.Multiline | RegexOptions.Compiled | RegexOptions.ExplicitCapture);
                MatchCollection matchCollection = regex.Matches(inputText);
                //---------------------------------------------------------------------------------
                string[] seperators = { "." };
                string[] partsIP = inputText.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
                int counter = 0;
                foreach (string p in partsIP)
                {
                    int intten = System.Convert.ToInt32(p, 10);
                    if (intten > 255)
                        ++counter;
                }
                //---------------------------------------------------------------------------------
                Console.Write(" IP: ");
                if (matchCollection.Count == 0 || counter != 0)
                    Console.Write(" Не верный\n");
                else {
                    Console.Write(" Верный\n");
                    for (int i = 0; i < matchCollection.Count; i++)
                    {
                        Console.WriteLine(" {0}: {1}", i + 1, matchCollection[i].Value);
                    }
                }
                //---------------------------------------------------------------------------------

                Console.WriteLine("\n Повторить?(y)/(n)");
                string answ = Console.ReadLine();
                if (String.IsNullOrEmpty(answ) || answ.ToLower().StartsWith("n"))
                    break;

                Console.Clear();
            }

        }
    }

}
