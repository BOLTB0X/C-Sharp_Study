using System;

namespace Type01
{
    class Program
    {
        static void Main(string[] args)
        {
            int tmp1 = 10;
            long longTmp = tmp1; // 암시적 형 변환 (implicit casting)
            Console.WriteLine(longTmp); // 10

            int tmp2 = (int)7.7; // 명시적 형 변환 (explicit casting)
            Console.WriteLine(tmp2); // 7

            int num = 65;
            
            // 형식 변환 (Type Conversion)
            Console.WriteLine(Convert.ToString(num)); // 65
            Console.WriteLine(Convert.ToBoolean(num)); // True
            Console.WriteLine(Convert.ToChar(num)); // A
        }
    }
}