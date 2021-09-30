using System;

namespace ตัวอย่าง_Overloading_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Wine wine1 = new Wine(1500);

            Console.WriteLine(wine1.price);
            Console.WriteLine(wine1.year);

            Wine wine2 = new Wine(1500, 10);
            Console.WriteLine(wine2.price);
            Console.WriteLine(wine2.year);
        }
        class Wine
        {
            public int price;
            public int year;

            public Wine(int valuePrice)
            {
                price = valuePrice;
            }

            public Wine(int valuePrice, int valueYear)
            {
                price = valuePrice;
                year = valueYear;
            }

        }
    }
}
