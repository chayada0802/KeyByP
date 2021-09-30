using System;

namespace ตัวอย่าง_Overloading_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int result1 = add(2, 3);
            int result2 = add(1, 2, 3);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }

        static int add(int number1, int number2)
        {
            return number1 + number2;
        }

        static int add(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }
    }
}
