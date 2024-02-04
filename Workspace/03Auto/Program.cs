using System;

namespace Auto03
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "kh";
            var fullName = name + " lee"; // C++의 Auto와 같은 용도

            Console.WriteLine(fullName); // kh lee
            // GetType()를 사용하여 객체의 타입 정보를 출력
            Console.WriteLine(fullName.GetType()); // System.String

            var number = 100; // 초기화도 같이 해줘야함
            Console.WriteLine(number.GetType()); // System.Int32

            // for, foreach를 쓸 때 유용
            for(var i = 1; i <= 10; i++) 
            {
                Console.WriteLine(i); // 1, 2, 3.... ,9, 10
            }

            string[] arr = { "Alpha", "Beta", "Gamma" };
            
            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}