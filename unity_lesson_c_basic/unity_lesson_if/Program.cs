using System;

namespace unity_lesson_if
{
    class Program
    {

        static bool condition1 = true;
        static bool condition2 = true;
        static bool condition3 = true;
    }
    static void Main(string[] args)
    {
        if (condition1)
        {
            Console.WriteLine("조건 1이 참이다");
        }
        else if (condition2)
        {
            Console.WriteLine("조건 1이 거짓이고 조건 2가 참이다");
        }
    }
}
    



