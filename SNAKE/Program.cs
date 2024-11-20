using System.Numerics;

namespace SNAKE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80,25);
            Console.CursorVisible = false;

            Walls walls = new Walls(80, 25);
            walls.Draw();

            //отрисовка начала змейки
            Point p = new Point(4,5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreatorFood();
            food.DrawEat();

            while (true) 
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
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
