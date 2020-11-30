using System;

namespace Abstract_simple
{
    class Program
    {
        static void Main(string[] args)
        {
            Child abs = new Child();
             
            Console.WriteLine(abs.name);
            abs.Name();
            
            Console.WriteLine(abs.Lname);
            Console.WriteLine(abs.Mname);
        }
    }
}