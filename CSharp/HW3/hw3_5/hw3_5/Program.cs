using System;

namespace hw3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] mass = { Belarus.Minsk.population, Russia.Moscow.population, Ukraine.Kiev.population };

            double maxNum = 0;
            for (int i = 0; i < mass.Length; ++i)
            {
                if (mass[i] > maxNum)
                    maxNum = mass[i];
            }

            for (int i = 0; i < mass.Length; ++i)
            {
                if (mass[i] == maxNum)
                    Console.WriteLine($"The biggest population = {maxNum} million");
            }

            if (maxNum == Belarus.Minsk.population)
                Console.WriteLine($"This country {Belarus.Minsk.strСountry}.");
            else if (maxNum == Russia.Moscow.population)
                Console.WriteLine($"This country {Russia.Moscow.strСountry}.");
            else if (maxNum == Ukraine.Kiev.population)
                Console.WriteLine($"This country {Ukraine.Kiev.strСountry}.");
        }
    }
}

namespace Belarus
{
    class Minsk
    {
        public static double population = 1.893;
        public static string strСountry = "Minsk";
        public static void ShowInfo()
        {
            Console.WriteLine($"\t Minsk\n population = {population} million");
        }
    }
}

namespace Russia
{
    class Moscow
    {
        public static double population = 11.92;
        public static string strСountry = "Moscow";
        public static void ShowInfo()
        {
            Console.WriteLine($"\t Moscow\n population = {population} million");
        }
    }
}

namespace Ukraine
{
    class Kiev
    {
        public static double population = 2.89;
        public static string strСountry = "Kiev";
        public static void ShowInfo()
        {
            Console.WriteLine($"\t Kiev\n population = {population} million");
        }
    }
}