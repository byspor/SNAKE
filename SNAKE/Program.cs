using System.Numerics;

namespace SNAKE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80,25);
            Console.CursorVisible = false;

            // Рамка
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '#');
            upLine.Drow();

            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '#');
            downLine.Drow();

            VerticalLine leftLine = new VerticalLine(0, 24, 0, '#');
            leftLine.Drow();

            VerticalLine rightLine = new VerticalLine(0, 24, 78, '#');
            rightLine.Drow();

            //отрисовка начала змейки
            Point p = new Point(4,5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            while (true) 
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}
