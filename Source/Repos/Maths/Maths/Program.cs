using System;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the X value:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Y value:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number(decimal / whole number) :");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the value of A(Square value):");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of B (absolute positive value):");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Maximum value is "+Math.Max(x, y));
            Console.WriteLine("Manimum value is " + Math.Min(x, y));
            Console.WriteLine("rounds a number to the nearest whole number is (z round number):"+ Math.Round(z));
            Console.WriteLine("square root of A is "+Math.Sqrt(A));
            Console.WriteLine("square root of A is " + Math.Abs(B));
        }
    }
}
