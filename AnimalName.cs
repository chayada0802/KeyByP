using System;

namespace Animal
{
    class Program
    {
        class Animal
        {
            public string name;
            public string birthdate;
            public string gender;
        }
            static void Main(string[] args)
        {
            Animal dog = new Animal();

            dog.name = "Nhong";
            dog.birthdate = "31 may 1991";
            dog.gender = "male";

            Console.WriteLine(dog.name);
        }
    }
}
