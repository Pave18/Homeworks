using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EXAM.Points;
using EXAM.Figures;


namespace EXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            Point P1 = new Point(10, 15);
            Point P2 = new Point(x: 2, y: 4);

            List<Point> LP = new List<Point> {
                P1,
                P2,
                P1 + P2,
                P1 - P2,
                P2 * 21
            };

            int i = 1;
            foreach (Point p in LP)
            {
                Console.Write("Point" + i++ + ": ");
                p.Show();

            }

            Console.WriteLine("//-----------------------");
            // В фигурах класс Point отображате отрезки длины в фигурах. В кругу отображает радиус

            Point Asq = new Point(2, 3);
            Point Bsq = new Point(4, 9);

            Square S1 = new Square(Asq);
            Square S2 = new Square(5.5);

            Rectangle R1 = new Rectangle(5, 6);
            Rectangle R2 = new Rectangle(8.6, Bsq);

            Square S3 = (Square)R1;
            Rectangle R3 = (Rectangle)S2;

            Circle C1 = new Circle(55.6);
            Circle C2 = new Circle(Bsq);

            List<Figure> LF = new List<Figure>{
                S1,
                S2,
                R1,
                R2,
                S3,
                R3,
                C1,
                C2
            };

            i = 1;
            foreach (Figure f in LF)
            {
                Console.Write("Figure" + i++ + ": ");
                f.Show();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
