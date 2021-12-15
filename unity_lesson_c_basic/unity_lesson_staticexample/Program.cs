using System;

namespace unity_lesson_staticexample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.name = "김아무개";

            Person person2 = new Person();
            person2.name = "이아무개";

            Person.typename = "사람 타입";
            Orc.typename = "오크 타입";

            Orc orc1 = new Orc();
            //static 으로 정의된 클래스는 객체생성 불가. 인스턴스화 불가.
            Orc.SayTypename();
        }
    }
    class Orc
    {
        static public string typename;

        static public void SayTypename() 
        {
            Console.WriteLine(typename);
        }
    }
    class Person
    {
        //접근제한자 : 자료형 앞에 붙여 준다.
        //public, private, protected
        //public : 다른클래스가 접근할 수 있다.
        //private : 다른 클래스는 접근할 수 없다.
        //protected : 상속자만 접근할 수 있다.
        public int age; //나이
        public float height; //키
        public bool isFemale; //여자인지?
        public char genderChar; // 성별문자
        public string name; // 이름
        static public string typename;
        static public void SayTypename() { 
        }
        public void sayage()
        {
            Console.WriteLine($"나이 : {age}");

        }
        public void sayheight()
        {
            Console.WriteLine($"키 : {height}");
        }
        public void sayisFemale()
        {
            Console.WriteLine($"여자인가? : {isFemale}");

        }
      
        public void saygenderchar()
        {
            Console.WriteLine($"성별문자? : {genderChar}");

        }

    }
}