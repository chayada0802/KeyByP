using System;
using System.Collections.Generic;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHeader();
            
            int totalRoses = TotalInputFromKeyboard("Rose");
            int totalSunFlowers = TotalInputFromKeyboard("Sun Flower");

            PlantList list = CreatePlantList(totalRoses, totalSunFlowers);

            Console.Clear();
            list.PrintRoseNames();
            Console.WriteLine();
            list.PrintSunFlowerNames();
        }

        static PlantList CreatePlantList(int totalRoses, int totalSunFlowers) {
            PlantList list = new PlantList();

            Console.Clear();
            foreach (Rose rose in GetAllRose(totalRoses))
            {
                list.AddRose(rose);
                Console.Clear();
            }

            foreach (SunFlower sunFlower in GetAllSunFlower(totalSunFlowers))
            {
                list.AddSunFlowers(sunFlower);
                Console.Clear();
            }

            return list;
        }

        static List<Rose> GetAllRose(int totalRoses) {
            List<Rose> roses = new  List<Rose>();

            for (int i = 0; i < totalRoses; i++)
            {
                roses.Add(CreateRose());
            }

            return roses;
        }

        static List<SunFlower> GetAllSunFlower(int totalSunFlowers) {
            List<SunFlower> sunFlowers = new  List<SunFlower>();

            for (int i = 0; i < totalSunFlowers; i++)
            {
                sunFlowers.Add(CreateSunFlower());
            }

            return sunFlowers;
        }

        static Rose CreateRose() {
            Console.Clear();
            PrintInputRoseHeader();

            return new Rose(InputID(),
            InputPlantName(),
            InputPlantDescription(),
            InputAmount(),
            InputHeight(),
            InputCircumference()
            );
        }

        static SunFlower CreateSunFlower() {
            Console.Clear();
            PrintSunFlowerHeader();

            return new SunFlower(InputID(),
            InputPlantName(),
            InputPlantDescription(),
            InputAmount(),
            InputHeight(),
            InputCircumference()
            );
        }

        static int InputID() {
            Console.Write("ID: ");
            int ID = int.Parse(Console.ReadLine());

            return ID;
        }

        static string InputPlantName() {
            Console.Write("Plant name: ");

            string plantName = Console.ReadLine();

            return plantName;
        }

        static string InputPlantDescription() {
            Console.Write("Plant description: ");
            
            string plantDescription = Console.ReadLine();

            return plantDescription;
        }

        static int InputAmount() {
            Console.Write("Amount: ");
            int amount = int.Parse(Console.ReadLine());

            return amount;
        }

        static float InputHeight() {
            Console.Write("Height: ");

            float height = float.Parse(Console.ReadLine());

            return height;
        }

        static float InputCircumference() {
            Console.Write("Circumference: ");

            float circumference = float.Parse(Console.ReadLine());

            return circumference;
        }

        static void PrintHeader() {
            Console.WriteLine("Welcome to Plant Tree!");
            Console.WriteLine("----------------------");
        }

        static void PrintInputRoseHeader() {
            Console.WriteLine("Input Rose");
            Console.WriteLine("----------\n");
        }

        static void PrintSunFlowerHeader() {
            Console.WriteLine("Input Sun flower");
            Console.WriteLine("---------------\n");
        }

        static int TotalInputFromKeyboard(string title) {
            Console.Clear();
            Console.Write("Input Total {0}: ", title);
            int total = int.Parse(Console.ReadLine());

            return total;
        }

    }
}
