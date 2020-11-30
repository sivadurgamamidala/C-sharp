using System;

namespace arrayReverseorder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] age = { 10, 20, 30, 40 };
            Array.Reverse(age);
            foreach(int i in age)
            {
                Console.WriteLine(i);
                if (i == 0)
                {
                    break;
                }
            }
        }
    }
}