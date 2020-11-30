using System;

namespace switch1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of x :");
            int Rule = Convert.ToInt32(Console.ReadLine());
            switch(Rule)
            {
                case 1:
                    Console.WriteLine("Rule no1: maintain social distance");
                    break;
                case 2:
                    Console.WriteLine("Rule no2: wash your hand with soap properly");
                    break;
                case 3:
                    Console.WriteLine("Rule no3: Please do not touch your face");
                    break;
                 case 4:
                    Console.WriteLine("Rule no4: Stay at Home if you can");
                    break;

                case 5:
                    Console.WriteLine("Rule no5:If you got cough use Elbow cough into it.");
                    break;
                default:
                    Console.WriteLine("Stay safe if you can");
                    break;
            }
        }
    }
}
