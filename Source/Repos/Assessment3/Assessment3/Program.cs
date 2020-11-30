using System;

namespace Assessment3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 9, flag, count=1;
            for(int i=1; i<10000; i++)
            {
                int sum = N + (10 * i);
                flag = 1;
                if (sum > 10000)
                {
                    break;
                }
                for (int j = 2; j <= sum / 2; ++j)
                {
                    if (sum % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                {
                    if (count % 10 == 0)
                    {
                        Console.Write("\n");
                    }
                    Console.Write(sum + " ");
                    count++;
                }
                
            }
        }
    }
}
