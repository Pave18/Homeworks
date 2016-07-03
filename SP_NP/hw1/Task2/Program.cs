using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bank> LBanks = new List<Bank>()
            {
                new Bank {Name ="Bel", Money = 10, Persent = 3},
                new Bank {Name ="Rus", Money = 11, Persent = 2},
                new Bank {Name ="Eur", Money = 150, Persent = 1}
            };


            Console.WriteLine("Banks created...");
            Console.ReadKey();
        }
    }
}
