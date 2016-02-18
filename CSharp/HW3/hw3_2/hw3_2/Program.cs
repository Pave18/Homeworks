using System;

namespace hw3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the coefficients. (x,y) (x.y) (x y)");
                string strCoeff = Convert.ToString(Console.ReadLine());

                Coeff.Parse(strCoeff);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch
            {
                Console.WriteLine("Error!");
            }
        }
    }

    class Coeff
    {
        static int a;
        static int b;

        public static void Parse(string str)
        {
            string[] coeff = str.Split(' ', ',','.');

            if (coeff.Length != 2)
                throw new FormatException("Wrong Format!\n");

            int temp_a, temp_b;
            bool cond_1 = Int32.TryParse(coeff[0], out temp_a);
            bool cond_2 = Int32.TryParse(coeff[1], out temp_b);

            if (!(cond_1 && cond_2))
                throw new FormatException("Wrong Format!\n");

            a = temp_a;
            b = temp_b;
            Console.WriteLine($"{a}x + {b}y = 0");
        }
    }
}
