using System;

namespace Booleans
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            bool y = false;
            int z = 10;
            int a = 15;
            Console.Write("Is'z' is less than 'a': ");
            Console.WriteLine(z<a);

            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.Write("Enter the b value: ");
            int b =Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the c value: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Is 'b' is greater than c ? = ");
            Console.WriteLine(b > c);

        }
    }
}
