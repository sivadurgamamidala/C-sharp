using System;

namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int[,] arr1 = new int[10, 10];
            int i, j;

            Console.Write("\nEnter Matrix elements: ");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    arr1[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

        }
    }
}5