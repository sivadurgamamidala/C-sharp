using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Fname var = new Fname();
            var.fun();
            Console.WriteLine(var.fname+" "+var.fullname);
        }
    }
}
