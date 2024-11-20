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
            upLine.Draw();

            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '#');
            downLine.Draw();

            VerticalLine leftLine = new VerticalLine(0, 24, 0, '#');
            leftLine.Draw();

            VerticalLine rightLine = new VerticalLine(0, 24, 78, '#');
            rightLine.Draw();

            //отрисовка начала змейки
            Point p = new Point(4,5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreatorFood();
            food.DrawEat();

            while (true) 
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreatorFood();                    
                    food.DrawEat();
                }
                else 
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
        }
    }
}
