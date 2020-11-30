using System;

namespace Continues123
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            bool y = true;
            int h;

            while(y)
            {
                Console.Write("Enter the x value: ");
                x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        {
                            Console.WriteLine(" you choosen option one");
                            y = false;
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(" you choosen option two");
                            y = false;
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(" you choosen option three");
                            y = false;
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine(" you choosen option four");
                            y = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("you choosen invalid option");
                            for(h=1; h<10; h++)
                            {
                                Console.Write(h);
                                if (h == 5)
                                {
                                    Console.WriteLine("you reach at last stage 'h=5'");
                                    continue;
                                    
                                }
                                Console.Write("\n");

                            }
                            break;
                        }
                }
                Console.ReadKey();
            }
        }
    }
}
