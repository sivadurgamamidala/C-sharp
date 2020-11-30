using System;

namespace Series_1_2_3_7_16_41_105_274_715
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of N :");
            int N = Convert.ToInt32(Console.ReadLine());
            Double Sum, x=1, y=0, z, Result=1;
            for(int i=0; i<=N; i++)
            {
                z = x + y;
                Console.Write(Result+" ");
                Sum = Result + Math.Pow(z, 2);
                x = y;
                y = z;
                Result = Sum;
            }
        }
    }
}
