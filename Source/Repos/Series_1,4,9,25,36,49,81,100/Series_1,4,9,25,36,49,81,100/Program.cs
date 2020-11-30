using System;

namespace Series_1_4_9_25_36_49_81_100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                
                if (i % 4 == 0)
                {
                    continue;
                }
                Console.Write(Math.Pow(i, 2)+" ");
            }
        }
    }
}