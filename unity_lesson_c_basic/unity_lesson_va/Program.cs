using System;

namespace unity_lesson_va
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Person
    {
        int age; //나이
        float height; //키
        bool isFemale; //여자인지?
        char genderChar; // 성별문자
        string name; // 이름

        void sayage()
        {
            Console.WriteLine($"나이 : {age}");

        }
        void sayheight()
        {
            Console.WriteLine($"키 : {height}");
        }
        void sayisFemale()
        {
            Console.WriteLine($"여자인가? : {isFemale}");

        }
        void saygenderchar()
        {
            Console.WriteLine($"성별문자? : {genderChar}");

        }
    }
}