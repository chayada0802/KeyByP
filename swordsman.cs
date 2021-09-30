using System;

namespace Swordsman
{
    class Program
    {
        static void Main(string[] args)
        {
            Swordsman swordsman = new Swordsman();

            Console.WriteLine(swordsman.HP);
            Console.WriteLine(swordsman.EXP);
            Console.WriteLine(swordsman.Atk);
            Console.WriteLine(swordsman.level);
            Console.WriteLine(swordsman.status);
            swordsman.Walk();
            swordsman.Attack();
            swordsman.Sit();


        }
        class Swordsman
        {
            public int HP;
            public int EXP;
            public int Atk;
            public int level;
            public string status;
            public Swordsman()
            {
                HP = 5000;
                EXP = 0;
                Atk = 20;
                level = 1;
                status = "Alive";
            }
            public void Walk() { Console.WriteLine("Walk"); }
            public void Sit() { Console.WriteLine("Sit"); }
            public void Attack() { Console.WriteLine("Attack"); }
            public void Dead() { }
            //            S1 ) จําแนกคุณสมบัติจากโจทย์
            //1.HP
            //2.EXP
            //3.Atk
            //4.Level
            //5.Status
            //S2 ) จําแนกความสามารถจากโจทย์
            //1.เดิน
            //2.นั่ง
            //3.โจมตี
            //4.ตาย
        }
    }
}
