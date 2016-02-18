using System;

namespace EXAM.Points
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point()
        {
            this.x = 0;
            this.y = 0;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Show()
        {
            Console.WriteLine("X={0} Y={1}", this.x, this.y);
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }
        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.x - p2.x, p1.y - p2.y);
        }
        public static Point operator *(Point p1, int i)
        {
            return new Point(p1.x * i, p1.y * i);
        }
    }
}
