using System;

using EXAM.Points;

namespace EXAM.Figures
{
    public class Rectangle : Figure
    {
        public double Length;
        public double Height;

        public Rectangle()
        {
            this.Height = 0;
            this.Length = 0;
        }
        public Rectangle(Point h, Point l)
        {
            if (h.x > h.y)
                this.Height = h.x - h.y;
            else
                this.Height = h.y - h.x;

            if (l.x > l.y)
                this.Length = l.x - l.y;
            else
                this.Length = l.y - l.x;
        }
        public Rectangle(double h, double l)
        {
            this.Height = h;
            this.Length = l;
        }
        public Rectangle(double h, Point l)
        {
            this.Height = h;

            if (l.x > l.y)
                this.Length = l.x - l.y;
            else
                this.Length = l.y - l.x;
        }
        public Rectangle(Point h, double l)
        {
            if (h.x > h.y)
                this.Height = h.x - h.y;
            else
                this.Height = h.y - h.x;

            this.Length = l;
        }

        public override void Show()
        {
            Console.WriteLine("Rectangle: \n Height = " + this.Height + "\n Length = " + this.Length);
        }

        public static explicit operator Square(Rectangle r)
        {
            Square s = new Square();
            s.Height = r.Height;
            s.Length = s.Height;
            return s;
        }

        public static implicit operator Rectangle(Square s)
        {
            Rectangle r = new Rectangle();
            r.Height = s.Height;
            r.Length = s.Height * 2;
            return r;
        }
    }
}