using System;

namespace switchUser
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            while (x)
            {
                Console.Write("Enter the Rule Number  : ");
                int Rule = Convert.ToInt32(Console.ReadLine());

                switch (Rule)
                {
                    case 1: Console.WriteLine("Maintain Social Distance..."); x = false; break;
                    case 2: Console.WriteLine("Do not Leave your home..."); x = false; break;
                    case 3: Console.WriteLine("Wash Your hands regularly..."); x = false; break;
                    case 4: Console.WriteLine("Maintain two meter distance from the sick person..."); x = false; break;
                    case 5: Console.WriteLine("During cough or sneezing use ur elbow or tissue..."); x = false; break;
                    case 6: Console.WriteLine("No mass gathering..."); x = false; break;
                    default: Console.WriteLine("Invalid rule number...."); break;
                }

            }

            Console.ReadKey();

        }
    }
}
