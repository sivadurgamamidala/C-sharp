using System;

namespace userInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter UserName:");
            String name = Console.ReadLine();
            Console.Write("Enter Your age:");
            int age =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("User name="+name);
            Console.WriteLine("Your AGE is " + age);
        }
    }
}
