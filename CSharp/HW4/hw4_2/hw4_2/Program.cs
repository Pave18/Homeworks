using System;

namespace hw4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GeometricFigure[] figures =
            {
                new Triangle(6, 8, 7),
                new Square(55),
                new Rhombus(55, 90),
                new Rectangle(5,6),
                new Parallelogram(2,3,60),
                new Trapeze(1,6,4,3),
                new Circle(7),
                new Ellipse(1.25,3.25)
            };

                Console.WriteLine();

                foreach (GeometricFigure gf in figures)
                {
                    Console.WriteLine($"Figure:\t\t{gf.GetType()}");
                    Console.WriteLine($"Perimeter:\t{gf.PerimeterFigure}");
                    Console.WriteLine($"Area:\t\t{gf.SquareFigure}");
                    Console.WriteLine();
                }


                Console.WriteLine();
                ISimpleNAngle[] sna = { new SimpleNAngle(3, 3), new SimpleNAngle(5, 4), new SimpleNAngle(4, 5) };
                ComplicatedFigure cf = new ComplicatedFigure(sna);
                cf.ConsistsOf();
                Console.WriteLine($"Full Area = {cf.FullArea()}");
            }
            catch (NegativeSideLengthException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ImpossibleAngleException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ImpossibleTriangleException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ImpossibleTrapezoidException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ImpossibleNAngle ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    abstract class GeometricFigure
    {
        public abstract double SquareFigure { get; }
        public abstract double PerimeterFigure { get; }
    }

    class Triangle : GeometricFigure
    {
        public double A = 0.0;
        public double B = 0.0;
        public double C = 0.0;

        public override double SquareFigure
        {
            get { return Math.Sqrt(PerimeterFigure / 2 * (PerimeterFigure / 2 - A) * (PerimeterFigure / 2 - B) * (PerimeterFigure / 2 - C)); }
        }
        public override double PerimeterFigure
        {
            get { return A + B + C; }
        }
        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;

            if (A < 0 || B < 0 || C < 0)
                throw new NegativeSideLengthException();
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine($"Triangle A = {A} X B = {B} X C = {C} created!");
            }
            else
                throw new ImpossibleTriangleException();
        }
    }
    class Square : GeometricFigure
    {
        public double A = 0.0;

        public override double PerimeterFigure
        {
            get { return A * 4; }
        }
        public override double SquareFigure
        {
            get { return A * A; }
        }

        public Square(double a)
        {
            this.A = a;

            if (a < 0)
                throw new NegativeSideLengthException();
            A = a;
            Console.WriteLine($"Square A = {A} X B = {A} created!");
        }
    }
    class Rhombus : GeometricFigure
    {
        public double A = 0.0;
        public double Alpha = 0.0;

        public override double PerimeterFigure
        {
            get { return A * 4; }
        }
        public override double SquareFigure
        {
            get { return A * A * Math.Sin(Math.PI / 180 * Alpha); }
        }

        public Rhombus(double a, double alpha)
        {
            this.A = a;
            this.Alpha = alpha;

            if (A < 0)
                throw new NegativeSideLengthException();
            if (Alpha < 0 || Alpha > 180)
                throw new ImpossibleAngleException();
            Console.WriteLine($"Rhombus A = {A} X B = {A} created!");
        }
    }
    class Rectangle : GeometricFigure
    {
        public double A = 0.0;
        public double B = 0.0;

        public override double PerimeterFigure
        {
            get { return (A + B) * 2; }
        }
        public override double SquareFigure
        {
            get { return A * B; }
        }

        public Rectangle(double a, double b)
        {
            this.A = a;
            this.B = b;

            if (a < 0 || b < 0)
                throw new NegativeSideLengthException();

            Console.WriteLine($"Rectangle A = {A} X B = {B} created!");
        }

    }
    class Parallelogram : GeometricFigure
    {
        public double A = 0.0;
        public double B = 0.0;
        public double Alpha = 0.0;

        public override double PerimeterFigure
        {
            get { return (A + B) * 2; }
        }
        public override double SquareFigure
        {
            get { return A * B * Math.Sin(Math.PI / 180 * Alpha); }
        }

        public Parallelogram(double a, double b, double alpha)
        {
            this.A = a;
            this.B = b;
            this.Alpha = alpha;

            if (a < 0 || b < 0)
                throw new NegativeSideLengthException();
            if (alpha < 0 || alpha > 180)
                throw new ImpossibleAngleException();

            Console.WriteLine($"Parallelogram A = {A} X B = {B} created!");
        }
    }
    class Trapeze : GeometricFigure
    {
        public double A = 0.0;
        public double B = 0.0;
        public double C = 0.0;
        public double D = 0.0;

        public override double PerimeterFigure
        {
            get { return A + B + C + D; }
        }
        public override double SquareFigure
        {
            get { return (A + B) / 2 * Math.Sqrt(C * C - Math.Pow(((A - B) * (A - B) + C * C - D * D) / (2 * (A - B)), 2)); }
        }

        public Trapeze(double a = 0.0, double b = 0.0, double c = 0.0, double d = 0.0)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;

            if (a < 0 || b < 0 || c < 0 || d < 0)
                throw new NegativeSideLengthException();
            if (a + b + c < d || a + b + d < c || a + c + d < b || b + c + d < a)
                throw new ImpossibleTrapezoidException();

            Console.WriteLine($"Trapezoid A = {A} X B = {B} X C = {C} X D = {D} created!");
        }

    }
    class Circle : GeometricFigure
    {
        public double R = 0.0;

        public override double PerimeterFigure
        {
            get { return 2 * Math.PI * R; }
        }

        public override double SquareFigure
        {
            get { return Math.PI * Math.Sqrt(R); }
        }

        public Circle(double r = 0.0)
        {
            this.R = r;

            if (r < 0)
                throw new NegativeSideLengthException();

            Console.WriteLine($"Circle radius = {R} created!");
        }
    }
    class Ellipse : GeometricFigure
    {
        public double R1 = 0.0;
        public double R2 = 0.0;

        public override double PerimeterFigure
        {
            get { return Math.PI * (3 * (R1 + R2) - Math.Sqrt((3 * R1 + R2) * (R1 + 3 * R2))); }
        }

        public override double SquareFigure
        {
            get { return Math.PI * R1 * R2; }
        }

        public Ellipse(double r1, double r2)
        {
            this.R1 = r1;
            this.R2 = r2;

            if (r1 < 0 || r2 < 0)
                throw new NegativeSideLengthException();

            Console.WriteLine($"Ellipse radius A = {R1} X radius B ={R2} created!");
        }
    }

    interface ISimpleNAngle
    {
        double Angle { get; }
        int NumberOfSides { get; set; }
        double LenghtOfSide { get; set; }
        double Perimeter { get; }
        double Area { get; }
    }

    class SimpleNAngle : ISimpleNAngle
    {
        int numberOfSides;
        double lenghtOfSide;

        public double Angle { get { return 180 * (NumberOfSides - 2); } }
        public int NumberOfSides
        {
            get { return numberOfSides; }
            set
            {
                if (value < 3)
                    throw new ImpossibleNAngle();
                numberOfSides = value;
            }
        }
        public double LenghtOfSide
        {
            get { return lenghtOfSide; }
            set
            {
                if (value < 0)
                    throw new NegativeSideLengthException();
                lenghtOfSide = value;
            }
        }
        public double Perimeter { get { return NumberOfSides * LenghtOfSide; } }
        public double Area { get { return NumberOfSides * LenghtOfSide * LenghtOfSide / (4 * Math.Tan(Math.PI / NumberOfSides)); } }

        public SimpleNAngle(int numberOfSides = 5, double lenghtOfSide = 1)
        {
            LenghtOfSide = lenghtOfSide;
            NumberOfSides = numberOfSides;
        }
    }

    class ComplicatedFigure
    {
        ISimpleNAngle[] figures;
        public ComplicatedFigure(params ISimpleNAngle[] fig)
        {
            figures = new ISimpleNAngle[fig.Length];
            for (int i = 0; i < fig.Length; ++i)
                figures[i] = fig[i];
        }

        public double FullArea()
        {
            double area = 0;
            foreach (ISimpleNAngle sna in figures)
                area += sna.Area;

            return area;
        }

        public void ConsistsOf()
        {
            Console.WriteLine("Complicated Figure Consists Of:");
            foreach (ISimpleNAngle sna in figures)
                Console.WriteLine($"{sna.NumberOfSides}-angle of area = {sna.Area}");
        }
    }

    public class SpecialUserException : ApplicationException
    {
        private string messageDetails = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public SpecialUserException() { }

        public SpecialUserException(string message)
        {
            messageDetails = message;
        }
    }
    public class NegativeSideLengthException : SpecialUserException
    {
        public override string Message
        {
            get
            {
                return string.Format("Wrong input: side length must be positive!");
            }
        }
    }
    public class ImpossibleAngleException : SpecialUserException
    {
        public override string Message
        {
            get
            {
                return string.Format("Wrong input: angle must be between 0 and 180!");
            }
        }
    }
    public class ImpossibleTriangleException : SpecialUserException
    {
        public override string Message
        {
            get
            {
                return string.Format("Wrong input: triangle with such sides cannot exist!");
            }
        }
    }
    public class ImpossibleTrapezoidException : SpecialUserException
    {
        public override string Message
        {
            get
            {
                return string.Format("Wrong input: trapezoid with such sides cannot exist!");
            }
        }
    }
    public class ImpossibleNAngle : SpecialUserException
    {
        public override string Message
        {
            get
            {
                return string.Format("Wrong input: NAngle must have at least 3 sides!");
            }
        }
    }
}
