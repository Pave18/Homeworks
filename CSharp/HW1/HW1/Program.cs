using System;
using System.Linq;
using EighthTask;

namespace HW1
{
    class Program
    {
        /*static ulong fib(ulong n)
        {
            return n > 1 ? fib(n - 1) + fib(n - 2) : n;
        }*/
        static void Main(string[] args)
        {
            bool bMenu = true;
            while (bMenu == true)
            {
                Console.WriteLine(" Select the job from 1 to 8.\n 0.Exit");

                int answer = Convert.ToInt32(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine(" \tTask №1.");

                            int a, b;
                            while (true)
                            {

                                Console.WriteLine(" Enter the number of A and B. Condition A < B");
                                try
                                {
                                    a = int.Parse(Console.ReadLine());
                                    b = int.Parse(Console.ReadLine());
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine(" Error!");
                                    return;
                                }
                                if (a < b)
                                    break;
                            }

                            for (int i = a; i <= b; ++i)
                            {
                                for (int j = 0; j < i; ++j)
                                    Console.Write(" " + i);

                                Console.WriteLine();
                            }
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine(" \tTask №2.");

                            char[] alphabet = new char[26];
                            for (int i = 65, j = 0; i < 91; ++i, ++j)
                                alphabet[j] = Convert.ToChar(i);

                            Console.WriteLine(" Enter the number of times the output?");
                            int num = int.Parse(Console.ReadLine());

                            for (int i = 0, counter = 0; i <= num; ++i, ++counter)
                            {
                                for (int j = 0, k = 0; j < 5; ++j)
                                {
                                    if (counter > 21)
                                    {
                                        if ((counter + j) > 25)
                                        {
                                            Console.Write(" " + alphabet[k]);
                                            ++k;
                                        }
                                        else
                                            Console.Write(" " + alphabet[j + counter]);
                                    }
                                    else
                                        Console.Write(" " + alphabet[j + counter]);

                                    if (counter == 26)
                                        counter = 0;
                                }
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine(" \tTask №3. \n Enter the number.");

                            string a = Console.ReadLine();
                            char[] temp = a.ToCharArray();
                            Array.Reverse(temp);
                            string b = new string(temp);

                            if (a == b)
                                Console.WriteLine("The number is a shifter.");
                            else
                                Console.WriteLine("The number is not a shifter.");
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine(" \tTask №4. \n Enter a value.");

                            char sAnswer = Convert.ToChar(Console.ReadLine());
                            switch (sAnswer)
                            {
                                case 'l':
                                case 't':
                                case 'p':
                                    Console.WriteLine(" Enters the list of values.\n");
                                    break;
                                default:
                                    Console.WriteLine(" The wrong choice.\n");
                                    break;
                            }
                        }
                        break;
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine(" \tTask №5.\n The document lacked the task №5 :)");
                        }
                        break;
                    case 6:
                        {
                            Console.Clear();
                            Console.WriteLine(" \tTask №6.\n X+2  0...20  21\n");

                            for (double i = 0; i <= 20; ++i)
                                Console.WriteLine("X" + (i + 1) + " = " + (i + 2));
                        }
                        break;
                    case 7:
                        {
                            Console.Clear();
                            Console.WriteLine(" \tTask №7.\n Enter the number.");

                            string sNum = Console.ReadLine();
                            char[] cTemp = sNum.ToCharArray();

                            char iMunMax = cTemp.Max();
                            char iMunMin = cTemp.Min();

                            Console.WriteLine("Max - " + iMunMax + " Min - " + iMunMin);
                        }
                        break;
                    case 8:
                        {
                            Console.Clear();
                            Console.WriteLine(" \tTask №8.\n The sum of the numbers 100 on Fibonacci.");

                            short Num = 100;
                            ulong Sum = 0;

                            Sum = EighthTaskProg.fibm(Num);

                            Console.WriteLine(Sum);
                        }
                        break;
                    case 0:
                        bMenu = false;
                        Console.WriteLine(" Goodbye.\n");
                        break;
                    default:
                        Console.WriteLine(" The wrong choice.\n");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
