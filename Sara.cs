using System;

namespace Sara
{
    class Program
    {
        static bool isVowel(char input)
        {
            if(input=='a'||input=='e'||
                input == 'i'|| input == 'o'
                || input == 'u')
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            int counter = 0;
            Console.Write("Input name:");
            string name = Console.ReadLine();
            //"Chayada Vivattanakul"-->"chayada vivattanakul"
            string lowerString = name.ToLower();
            //"chayada vivattanakul"-->"CHAYADA VIVATTANAKUL"
            string upperString = name.ToUpper();
            //เปลี่ยนstringมาเป็นchar Array ทีละตัว
            foreach(char value in lowerString.ToCharArray())
            {
                if (isVowel(value))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
