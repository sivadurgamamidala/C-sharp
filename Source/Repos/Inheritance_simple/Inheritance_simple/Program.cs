using System;

namespace Inheritance_simple
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Name var = new Name();
            Console.WriteLine(var.name+" "+var.fname);
            var.Func();

        }
    }
}
