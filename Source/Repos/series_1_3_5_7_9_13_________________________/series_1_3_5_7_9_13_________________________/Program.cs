using System;

namespace series_1_3_5_7_9_13_________________________
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the N value: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int count = 1;
            for(int i=1; i<=N; i++)
            {
                if (i % 2 == 0 || count%6==0)
                {
                    while (count % 6 == 0)
                    {
                        Console.WriteLine("count" + count);
                        count++;
                    }   
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
                //count++;
                
            }
        }
    }
}
