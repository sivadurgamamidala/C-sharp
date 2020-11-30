using System;

namespace star123
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            for (i = 0; i <= 5; i++)
            {

                for (j = 0; j < i; j++)
                {
                    Console.Write("*");

                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
