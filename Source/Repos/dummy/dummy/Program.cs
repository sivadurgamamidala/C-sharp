using System;

namespace dummy
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            int m;
            int n;

            Console.WriteLine("Enter two no's seperated by space: ");

            x = Console.ReadLine();
            m = Convert.ToInt32(x.Split(' ')[0]);
            n = Convert.ToInt32(x.Split(' ')[1]);

            Console.WriteLine("" + m + " " + n);
        }
        }
}
