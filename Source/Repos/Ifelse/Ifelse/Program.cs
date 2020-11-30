using System;

namespace Ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Age: ");
            int Age =Convert.ToInt32( Console.ReadLine());
            if (Age < 18 | Age == 18)
            {
                Console.WriteLine("!Your Age is " + Age + "And you can't get voter Id Because you are not Eligible");
            }
            else
            {
                Console.WriteLine("You are Eligible for apply VoterID and give your details");
                Console.Write("Enter your name: ");
                String Name = Console.ReadLine();
                Console.Write("Enter your City name: ");
                String cityname = Console.ReadLine();
                Console.Write("Enter your State name: ");
                String Statename = Console.ReadLine();
                Console.WriteLine("'<------------The details that you are enter------------>'");
                Console.WriteLine("");
                Console.WriteLine("Name: "+Name);
                Console.WriteLine("Age: " +Age);
                Console.WriteLine("Your City: "+cityname);
                Console.WriteLine("Your State: "+Statename);
            }
        }
    }
}
