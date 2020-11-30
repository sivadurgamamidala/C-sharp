using System;

namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            //casting flows from char> int>double>long>float and wise versa
            int num = 14;
            double num1 = num;
            Console.WriteLine(num);
            Console.WriteLine(num1);


            double num2 = 14.56;
            int num3 = (int)num2;
            Console.WriteLine(num2);
            
            Console.WriteLine(num3);
        }
    }
}
