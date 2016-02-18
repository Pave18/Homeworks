using System;

using EXAM.Points;

namespace EXAM.Figures
{
    public class Circle : Figure
    {
        public double Diameter;

        public Circle()
        {
            this.Diameter = 0;
        }
        public Circle(double r)
        {
            this.Diameter = r;
        }
        public Circle(Point d)
        {
            if (d.x > d.y)
                this.Diameter = (d.x - d.y) * 2;
            else
                this.Diameter = (d.y - d.x) * 2;
        }

        private double Circumference()
        {
            double L = 0;
            double pi = 3.14;

            L = pi * this.Diameter;

            return L;
        }

        public override void Show()
        {
            Console.WriteLine("Circle: \n Radius = " + this.Diameter + "\n Circumference = " + Circumference());
        }
    }
}
