using System;
using System.Collections.Generic;
using System.Text;

namespace calculator_using_objects
{
    class Multiplication
    {
        public static void multiplication1()
        {

            Console.Write("Enter the first Number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second Number:");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a * b;
            Console.WriteLine("Result: " + c);
        }
    }
}
