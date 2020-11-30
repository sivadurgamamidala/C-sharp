using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CandidateCode
{
    static void Main(String[] args)
    {
        
        long N=Convert.ToInt32( Console.ReadLine());
        int[] x=new int[N];
        int[] y = new int[N];
        int[] Powerpuff_Girls = new int[N];
        //Console.WriteLine("");
        int min;
        for (long i=0; i < N; i++)
        {
           
            x[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("");
        for(long i=0;i<N; i++)
        {
            y[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("");
        for(long i=0; i<N; i++)
        {
            Powerpuff_Girls[i] = (y[i] / x[i]);
        }
        min = Powerpuff_Girls[0];
        for (long i=0; i < N; i++)
        {
            if (Powerpuff_Girls[i] < min)
            {
                min = Powerpuff_Girls[i];
            }
        }
        Console.WriteLine(min);
    }
}