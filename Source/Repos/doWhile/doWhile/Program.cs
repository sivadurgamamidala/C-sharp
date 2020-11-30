using System;

namespace doWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            do
            {
                Console.WriteLine(x);
                x++;
            }
            while (x < 0);
        }
    }
}
