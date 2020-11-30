using System;

namespace Asign
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            x = x ^ 1;
            int y = 5;
            y = y ^ 2;
            int z = 5;
            z = z ^ 3;
            int a = 5;
            a = a ^ 4;
            int b = 5;
            b = b ^ 5;
            int c = 5;
            c = c ^ 6;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
