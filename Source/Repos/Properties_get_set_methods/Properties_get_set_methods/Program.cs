using System;

namespace Properties_get_set_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Em = new Employee();
            Em.name = "shiva";
            Em.age = 24;
            Console.WriteLine(Em.name);
            Console.WriteLine(Em.age);
        }
    }
}
