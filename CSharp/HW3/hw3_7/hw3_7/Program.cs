using System;

namespace hw3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction(3, 4);
            int a = 10;
            Fraction f1 = f * a;
            Fraction f2 = a * f;
            double d = 1.5;
            Fraction f3 = f + d;
            Console.WriteLine($"f = {f}\nf1 = {f1}\nf2 = {f2}\nf3 = {f3}\n\n");

            if (f)
                Console.WriteLine("f  - proper fraction!");
            else
                Console.WriteLine("f - improper fraction!");

            if (f3)
                Console.WriteLine("f3  - proper fraction!");
            else
                Console.WriteLine("f3 - improper fraction!");

        }
    }

    class Fraction
    {
        int numerator;
        int denominator;

        public int Numerator
        {
            get { return numerator; }
            private set { numerator = value; }
        }

        public int Denominator
        {
            get { return denominator; }
            private set
            {
                if (value != 0)
                    denominator = value;
                else
                    Console.WriteLine("The denominator can not be 0!");
            }
        }

        public Fraction(int n = 0, int d = 1)
        {
            Numerator = n;
            Denominator = d;
            gsd();
        }

        private void gsd()
        {
            int max = (Numerator < Denominator) ? Numerator / 2 : Denominator / 2;
            int gsd = 1;
            for (int i = 1; i <= max; ++i)
                if (Numerator % i == 0 && Denominator % i == 0)
                    gsd = i;
            Numerator /= gsd;
            Denominator /= gsd;
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            Fraction f = new Fraction(f1.Numerator * f2.Denominator + f1.Denominator * f2.Numerator, f1.Denominator * f2.Denominator);
            f.gsd();
            return f;
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            Fraction f = new Fraction(f1.Numerator * f2.Denominator - f1.Denominator * f2.Numerator, f1.Denominator * f2.Denominator);
            f.gsd();
            return f;
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            Fraction f = new Fraction(f1.Numerator * f2.Numerator, f1.Denominator * f2.Denominator);
            f.gsd();
            return f;
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            Fraction f = new Fraction(f1.Numerator * f2.Denominator, f1.Denominator * f2.Numerator);
            f.gsd();
            return f;
        }

        public static implicit operator Fraction(int a)
        {
            return new Fraction(a, 1);
        }

        public static implicit operator Fraction(double a)
        {
            int exp = 1;
            while (a != (int)a)
            {
                a *= 10;
                exp *= 10;
            }
            return new Fraction((int)a, exp);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Fraction frac = obj as Fraction;
            if (frac == null)
                return false;
            return (Numerator == frac.Numerator && Denominator == frac.Denominator);
        }

        public override int GetHashCode()
        {
            return Numerator ^ Denominator;
        }

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            if (ReferenceEquals(f1, f2))
                return true;
            if ((object)f1 == null)
                return false;
            return f1.Equals(f2);
        }

        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return !(f1 == f2);
        }

        public static bool operator <(Fraction f1, Fraction f2)
        {
            return (double)f1.Numerator / f1.Denominator < (double)f2.Numerator / f2.Denominator;
        }

        public static bool operator >(Fraction f1, Fraction f2)
        {
            return (double)f1.Numerator / f1.Denominator > (double)f2.Numerator / f2.Denominator;
        }

        public static bool operator true(Fraction f1)
        {
            return f1.Numerator < f1.Denominator;
        }

        public static bool operator false(Fraction f1)
        {
            return f1.Numerator > f1.Denominator;
        }

        public override string ToString()
        {
            return string.Format($"{Numerator}/{Denominator}");
        }
    }
}