using System;

using EXAM.Points;

namespace EXAM.Figures
{
    public class Square : Figure
    {
        public double Length;
        public double Height;

        public Square()
        {
            this.Height = 0;
            this.Length = this.Height;
        }
        public Square(Point h)
        {
            if (h.x > h.y)
                this.Height = h.x - h.y;
            else
                this.Height = h.y - h.x;

            this.Length = this.Height;
        }
        public Square(double h)
        {
            this.Height = h;
            this.Length = this.Height;
        }
        
        public override void Show()
        {
            Console.WriteLine("Square: \n Height = " + this.Height + "\n Length = " + this.Length);
        }
    }
}
