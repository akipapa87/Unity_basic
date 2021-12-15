using System;

namespace lesson_unity_csharp_classexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Orc Orc1 = new Orc();
      
            Orc1.age = 140;
            Orc1.weight = 200.0f;
            Orc1.height = 240.2f;
            Orc1.genderChar = '남';
            Orc1.name = "상급오크";
            Orc1.isRest = false;

            Orc Orc2 = new Orc();

            Orc2.age = 60;
            Orc2.weight = 120.2f;
            Orc2.height = 140.4f;
            Orc2.genderChar = '여';
            Orc2.name = "하급오크";
            Orc2.isRest = true;

            if (Orc1.isRest)
            {
                Orc1.Smash();
                Orc1.Jump();
            }
            else 
            {
                Console.WriteLine($"{Orc1.name}(이)가 놀고 있다");
            }

            if (Orc2.isRest)
            {
                Orc2.Smash();
                Orc2.Jump();
            }
            else 
            {
                Console.WriteLine($"{Orc2.name}(이)가 바쁘다");
            }

            Orc1.Smash();
            Orc1.Jump();
            Orc2.Jump();
            Orc2.Smash();
        }
    }
}

class Orc
{
    public int age;
    public float weight;
    public float height;
    public char genderChar;
    public string name;
    public bool isRest;

    public void Smash()
    {
        Console.WriteLine($"{name} (이)가 휘둘렀다.");
    }
    public void Jump()
    {
        Console.Write($"{name} (이)가 점프했다.");
    }
}