using System;

namespace Even_or_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int x =Convert.ToInt32( Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }
    }
}
