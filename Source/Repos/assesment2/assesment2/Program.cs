using System;
using System.Reflection.Metadata.Ecma335;

namespace assesment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 25;
            int i = 1;
            int j = 1;
            bool X = true;
            while (X)
            {
                if (i % 7 == 0 && i % 2 == 1 && i % 3 == 1 && i % 4 == 1 && i % 5 == 1 && i % 6 == 1)
                {
                    
                    N--;
                    
                    Console.WriteLine(j+". "+i);
                    j++;
                    if (N == 0)
                    {
                        X = false;
                    }
                }
                i++;
            }

        }
    }
}
