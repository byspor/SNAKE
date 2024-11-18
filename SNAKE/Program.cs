using System.Numerics;

namespace SNAKE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(3, 3, '#');
            p1.Draw();

            Point p2 = new Point(5, 6, '$');
            p2.Draw();

            HorizontalLine hLine1 = new HorizontalLine(4, 10, 8, '+');
            hLine1.Drow();

            HorizontalLine hLine2 = new HorizontalLine(4, 10, 14, '+');
            hLine2.Drow();

            VerticalLine vLine1 = new VerticalLine(9, 13, 4, '|');
            vLine1.Drow();

            VerticalLine vLine2 = new VerticalLine(9, 13, 10, '|');
            vLine2.Drow();

            Console.WriteLine();

        }
    }
}
