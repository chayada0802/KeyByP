using System;

namespace Reference_Type
{
    class Program
    {
        public class Point { public int x; public int y; }
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 7;

            Point p2 = p1;

            Console.WriteLine(p1.x);
            Console.WriteLine(p2.x);

            p1.x = 9;

            Console.WriteLine(p1.x);
            Console.WriteLine(p2.x);
        }
    }
}
