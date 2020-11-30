using System;

namespace Series12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the N value to print N numbers: ");
            int N =Convert.ToInt32( Console.ReadLine());
            for(int i=5; i>=1; i--)
            {
                for(int j=1; j<i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 5; k >= i; k--)
                {
                    Console.Write(k);

                }
                Console.WriteLine("");
            }

        }
    }
}
