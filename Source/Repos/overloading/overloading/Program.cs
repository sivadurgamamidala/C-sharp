using System;

namespace overloading
{
    
    class Program
    {
        public static int method(int x)
        {
            Console.WriteLine("enter x value:"+x);
            
            return x;
        }
        public static double method(int y)
        {

            Console.WriteLine("enter x value:"+y);
            double a = 10;
            
            
            
            return  a;
        }

        static void Main(string[] args)
        {
            Console.WriteLine();
            method(2);
            method(1);
        }
    }
}
