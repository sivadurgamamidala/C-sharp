using System;

namespace series_1__3_5__7_9__13_15__17_19__21_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            Console.WriteLine("Enter the value of N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for(int i=1; i<=N; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                if (count % 6 == 0 && flag==1)
                {
                    count++;
                    continue;
                }
                else if (count % 6 == 0 && flag==0)
                {
                    count++;
                    continue;
                }
                if (flag == 0)
                {
                    count++;
                    flag = 1;
                    Console.WriteLine(i);
                }
                else if (flag == 1)
                {
                    count++;
                    flag = 0;
                    Console.WriteLine(-1*i);
                }
            }
        }
    }
}