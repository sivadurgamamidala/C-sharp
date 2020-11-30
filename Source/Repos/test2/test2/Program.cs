using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class CandidateCode
{
    static void Main(String[] args)
    {
        int T = Convert.ToInt32(Console.ReadLine());
        int[] count1=new int[T];
        if (T >= 1 && T <= 10000000)
        {
            for (int i=0; i<T; i++)
            {
                int N = Convert.ToInt32(Console.ReadLine());
                long[] x =new long[N];
                long[] y = new long[N];
                long[] a = new long[N];
                long[] b = new long[N];
                long[] c = new long[N];
                int l = N-1;
                int m = N-1;
                int count = 0;
                if (N >= 1 && N <= 10000000)
                {
                    string o = Console.ReadLine();
                    for (int j = 0; j < N; j++)
                    {
                        x[j] = Convert.ToInt64(o.Split(' ')[j]);
                        if (x[j] < 0)
                        {
                            Math.Abs(x[j]);
                        }
                    }
                    string p = Console.ReadLine();
                    for (int j = 0; j < N; j++)
                    {
                        y[j] = Convert.ToInt64(p.Split(' ')[j]);
                        if (y[j] < 0)
                        {
                            Math.Abs(y[j]);
                        }
                    }
                    for (int j = 0; j < N; j++)
                    {
                        a[j] = x[j];
                    }
                    for (int j = 0; j < N; j++)
                    {
                        b[j] = x[j];
                    }
                    for (int j = 0; j < N; j++)
                    {
                        for (int k = j + 1; k < N; k++)
                        {
                            if (y[k] > y[j])
                            {
                                long temp = y[j];
                                y[j] = y[k];
                                y[k] = temp;
                            }
                        }
                    }
                    for (int j = 0; j < N; j++)
                    {
                        for (int k = j + 1; k < N; k++)
                        {
                            if (b[k] > b[j])
                            {
                                long temp = b[j];
                                b[j] = b[k];
                                b[k] = temp;
                            }
                        }
                    }
                    for (int j = 0; j < N; j++)
                    {
                        for (int k = j + 1; k < N; k++)
                        {
                            if (a[k] < a[j])
                            {
                                long temp = a[j];
                                a[j] = a[k];
                                a[k] = temp;
                            }
                        }
                    }
                    for(int j=0; j<N; j++)
                    {
                        if (y[j] < a[l])
                        {
                            c[j] = a[l];
                            l=l-1;
                        }
                        else
                        {
                            c[j] = b[m];
                            m=m-1;
                        }
                    }
                    for(int j=0; j<N; j++)
                    {
                        if (c[j] > y[j]) 
                        {
                            count++;
                        }
                        count1[i] = count;
                    }
                }
            }
            for (int i = 0; i < T; i++)
            {
                Console.WriteLine(count1[i]);
            }
        }

    }
}