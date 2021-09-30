using System;

namespace ChangeGrade
{
    //กําหนดค่าเริ่มต้นเมื่อสร้าง Instance ขึ้นมา ดังนี้
    //1. ชื่อ = Jane
    //2. นามสกุล = Jo
    //3. เกรด = A
    //หลังจากนั้นสร้าง function changeGrade ขึ้นมาโดยรับ object student โดยเปลี่ยนเกรด
    //นักเรียนทุกคนที่ส่งผ่านเข้าไปจาก A เป็น F โดย function changeGrade ไม่มีการ return ค่า
    //กลับ ให้เรียกใช้function changeGrade
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Jane", "Jo", "A");

            changeGrade(student);

            Console.WriteLine(student.grade);
        }
        public static void changeGrade(Student student)
        {
            student.grade = "F";
        }

    }
    
    class Student
    {
        public string name;
        public string surname;
        public string grade;

        public Student(string valueName, string valueSurname, string valueGrade)
        {
            name = valueName;
            surname = valueSurname;
            grade = valueGrade;
        }

    }
}
