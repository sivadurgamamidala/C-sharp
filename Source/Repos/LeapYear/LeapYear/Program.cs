using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the year to find where it is leap year or not: ");
            int leapyear = Convert.ToInt32(Console.ReadLine());

            if (leapyear % 4 == 0)
            {
                if (leapyear%400==0)
                {
                Console.WriteLine(leapyear + " is leapyear");
                }
                else if(leapyear % 100 == 0)
                {
                    Console.WriteLine(leapyear + " is not leapyear");
                }
                else
                {
                    Console.WriteLine(leapyear + " is leapyear");
                }
            }
            else
            {
                Console.WriteLine(leapyear + " is not leapyear");
            }


        }
    }
}
