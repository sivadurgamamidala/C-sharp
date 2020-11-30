using System;

namespace arrayReverseorder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] age = { 10, 20, 30, 40 };
            for(int i=5; i >= 0; i--)
            {
                Console.WriteLine(age[i]);
                if (i == 0)
                {
                    break;
                }
            }
        }
    }
}