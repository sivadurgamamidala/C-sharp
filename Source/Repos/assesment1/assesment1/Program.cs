using System;

namespace assesment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of N");
            int N = Convert.ToInt32(Console.ReadLine());
            int count = 1;
            //int F=0;
            for(int i=1; i<=N; i++)
            {
                if (i % 2 == 0 )
                {
                    continue;
                }
                if (count % 3 == 0)
                {
                    count =1;
                    count++;
                    continue;
                }
               
                if (count % 2 == 0)
                {
                    Console.WriteLine("-" + i);
                    count++;
                    continue;
                }
                    Console.WriteLine(i);
                    count++;
                   
            }
        }
    }
}
