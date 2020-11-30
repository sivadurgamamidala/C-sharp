using System;

namespace series_1__2_6__15_31__56
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of N: ");
            int N =Convert.ToInt32( Console.ReadLine());
            Double sum = 1;
            for (int i=0; i<=N; i++)
            {
                sum = sum + Math.Pow(i,2);
                if (i % 2 == 0)
                {
                    Console.Write(sum);
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("-"+sum);
                    Console.Write(" ");
                }
               
            }
        }
    }
}
