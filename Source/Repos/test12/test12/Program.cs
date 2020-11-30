using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;

class CandidateCode
{
    static void Main(String[] args)
    {
            int N = Convert.ToInt32(Console.ReadLine());
            long[] x = new long[N];
            long[] y = new long[N];
            long[] Powerpuff_Girls = new long[N];
            long min;
            Boolean flag = true;
            if (N >= 1 && N <= 10000000)
            {
                 while (flag)
                 {
                    string o = Console.ReadLine();
                    for (long i = 0; i < N; i++)
                    {
                        x[i] = Convert.ToInt64(o.Split(' ')[i]);
                    }
                    //for(long i=0; i<N; i++)
                    //{
                    //    x[i]=Math.Abs(x[i]);
                    //}
                    string p = Console.ReadLine();
                    for (long i = 0; i < N; i++)
                    {
                        y[i] = Convert.ToInt64(p.Split(' ')[i]);
                    }
                    for (long i = 0; i < N; i++)
                    {
                        if (x[i] < 0 || y[i] < 0)
                        {
                            flag = false;
                        }
                    }
                    if (flag == false)
                    {
                    //break;
                    throw new ArithmeticException("Access denied - quantity of each ingredient is more than zero");

                }
                    //for (long i = 0; i < N; i++)
                    //{
                    //    y[i]= Math.Abs(y[i]);
                    //}
                    for (long i = 0; i < N; i++)
                    {
                        Powerpuff_Girls[i] = (y[i] / x[i]);
                    }
                    min = Powerpuff_Girls[0];
                    for (long i = 0; i < N; i++)
                    {
                        if (Powerpuff_Girls[i] < min)
                        {
                            min = Powerpuff_Girls[i];
                        }
                    }
                    Console.WriteLine(min);
                    flag = false;
                 }
            }
            Console.ReadKey();
    }
}    