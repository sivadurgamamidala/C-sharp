using System;

namespace seriresss112
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum, n, m;
            Console.Write("Enter the value of N: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            for (int i=1; i<n; i++)
            {
              
                sum = Math.Pow(1 , i) + Math.Pow(2 , i) + Math.Pow( 3 , i);
                
                Console.Write(sum+"\t");
            }
        }
    }
}
