using System;

namespace unity_lesson_function
{
    class Program
    {
        static bool doprinthelloworld = true;
        static void Main(string[] args)
        {
            if (doprinthelloworld)
            {
                printHelloWorld();
            }

            static void printHelloWorld()
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}


