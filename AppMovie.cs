using System;
using System.Collections.Generic;
namespace AppMovie
{
    //    ให้สร้าง App สําหรับการดูหนัง โดย ผู้ใช้สามารถสร้าง List ของหนัง และสามารถ Share list
    //ของหนังให้กับ ผู้ใช้คนอื่นๆได้ดังนั้นจะต้องสร้าง class User และ Class Movie ที่เก็บข้อมูล
    //หนังแต่ละเรื่องที่ผู้ใช้ได้ดูโดยมีข้อกําหนดดังต่อไปนี้
    //1. Class user จะมีMethod addList ที่รับ movie เข้ามา ใช้ในการเก็บ List ของหนังที่ตัวเอง

    //ดูทั้งหมด โดย user จะมีmovies ที่เป็น array ของ Movie คอยเก็บรวบรวมข้อมูลไว้ให้
    //และมี method Getmovies ที่ return ชื่อหนังทั้งหมดออกมาให้

    //2. Movie จะประกอบไปด้วยข้อมูลดังต่อไปนี้

    //1. Id เป็น type int
    //2. Name เป็นชื่อหนัง

    //หลังจากที่สร้าง class ทั้งสองเสร็จสิ้น ให้สร้าง instance ที่ชื่อ jane ขึ้นมา โดย jane จะมีหนัง
    //ที่เคยดูแล้วทั้งหมด 5 เรื่อง หลังจากนั้นให้แสดงชื่อหนังที่ jane เคยดูแล้วทั้งหมดออกมาที่
    //Console

    class Program
    {
        static void Main(string[] args)
        {
            //List<Movie> movies = new List<Movie>();

            //Movie loki = new Movie(1, "Loki");
            //Movie starwars = new Movie(2, "Star wars");
            //Movie whatIf = new Movie(3, "What...if");

            //movies.Add(loki);
            //movies.Add(starwars);//ต่อคิว
            //movies.Insert(1, whatIf);//012 ไปแทรก1เพิ่มแทรก
            //movies.Remove(loki);//เอาออก

            //foreach (Movie movie in movies)
            //{
            //    Console.WriteLine(movie.name);
            //}
            User jane = new User("jane");

            Movie loki = new Movie(1, "Loki");
            Movie starwars = new Movie(2, "Star wars");

            jane.addList(loki);
            jane.addList(starwars);

            jane.getMovies();
        }
        class Movie
        {
            //        S1) วิเคราะห์คุณสมบัติของ Movie

            //1. Movie จะประกอบไปด้วยข้อมูลดังต่อไปนี้

            //1. Id เป็น type int
            //2. Name เป็นชื่อหนัง
            public int ID;
            public string name;

            public Movie(int valueID, string valueName)
            {
                ID = valueID;
                name = valueName;
            }
        }
        //    S2) วิเคราะห์คุณสมบัติของและความ
        //สามารถของ User

        //1. User จะประกอบไปด้วยข้อมูลดังต่อไปนี้

        //1. Name
        //2. List ของ movie

        //2. User จะมีความสามารถดังต่อไปนี้
        //1. Addlist สําหรับ add หนังเข้าไป
        //2. getMovies สําหรับแสดงหนังที่ User
        //คนนี้ดูไปแล้ว
        class User
        {
            public string name;
            private List<Movie> movies;

            public User(string valueName)
            {
                name = valueName;
                movies = new List<Movie>();
            }

            public void addList(Movie movie)
            {
                movies.Add(movie);
            }

            public void getMovies()
            {
                movies.ForEach(value => { Console.WriteLine(value.name); });
            }

        }
    }
}
//“List เป็นโครงสร้างข้อมูลที่ใช้ในการเก็บข้อมูลแบบเป็นลําดับ สิ่ง
//แตกต่างของมันกับอาเรย์คือ มันสามารถเก็บข้อมูลได้แบบไดนามิ
//กส์หรือเพิ่มขึ้นเรื่อยๆ โดยที่เราไม่ต้องบอกขนาดล่วงหน้า”
