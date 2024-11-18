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

            Point p3 = new Point(2, 2, '*');
            p3.Draw();

            Point p4 = new Point(4, 1, '@');
            p4.Draw();

            Console.WriteLine();

            List<char> list = new List<char>();
            list.Add('#');
            list.Add('$');
            list.Add('*');            

            foreach (char c in list) 
            {
                Console.WriteLine(c);
            }

            List<Point> list2 = new List<Point>();

            list2.Add(p1);
            list2.Add(p2);
            list2.Add(p3);
            list2.Add(p4);

            


        }
    }
}
