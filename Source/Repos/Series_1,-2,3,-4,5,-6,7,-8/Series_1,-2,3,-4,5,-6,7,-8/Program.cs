using System;

namespace Series_1__2_3__4_5__6_7__8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i=1; i<=N; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("-"+i);
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                
            }
        }
    }
}
