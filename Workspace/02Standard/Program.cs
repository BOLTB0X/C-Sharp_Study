using System;

namespace Standard02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Read()
            // int inputVar = Console.Read();
            // Console.WriteLine(inputVar); // ASCII 값

            // char charInputVar = (char)inputVar; // ASCII 값을 문자로 변환
            // Console.WriteLine(charInputVar);

            // Console.ReadLine()
            string inputStr = Console.ReadLine();
            Console.WriteLine("출력" + inputStr);

            int age = 25;
            Console.Write("I am " + age + " years old.");

            Console.WriteLine(7 < 5); // False
            Console.WriteLine(3.14); // 3.14


            string ageInput = Console.ReadLine();
            age = Convert.ToInt32(ageInput); // 입력이 문자열 이므로

            Console.WriteLine("I am " + age + " years old.");
        }
    }
}