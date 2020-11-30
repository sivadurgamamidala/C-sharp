using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Calculator";
            Console.SetCursorPosition((Console.WindowWidth - str.Length) / 2, Console.CursorTop);
            Console.WriteLine(str);
            Console.Write("************************************************************************************************************************");
            
            Console.WriteLine("OPTIONS");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraction");
            Console.WriteLine("3: Multiplication");
            Console.WriteLine("4: Division");
            Console.WriteLine("5: Exit");
            bool a = true;
            while (a)
            {
                Console.Write("Choose your option to be perform: ");
                Double i = Convert.ToDouble(Console.ReadLine());
               
                Double z;
               
                switch (i)
                {
                    case 1:
                        {
                            Console.WriteLine("You chosen First option: Addition");
                            Console.Write("Enter the First number: ");
                            Double x = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter the Second number: ");
                            Double y = Convert.ToDouble(Console.ReadLine());
                            z = x + y;
                            Console.WriteLine("Result = " + z);
                            //a = false;
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("You chosen Second option: Subtraction");
                            Console.Write("Enter the First number: ");
                            Double x = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter the Second number: ");
                            Double y = Convert.ToDouble(Console.ReadLine());
                            z = x - y;
                            Console.WriteLine("Result = " + z);
                            //a = false;
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("You chosen Third option: Multiplication");
                            Console.Write("Enter the First number: ");
                            Double x = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter the Second number: ");
                            Double y = Convert.ToDouble(Console.ReadLine());
                            z = x * y;
                            Console.WriteLine("Result = " + z);
                            //a = false;
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("You chosen Fouth option: Division");
                            Console.Write("Enter the First number: ");
                            Double x = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter the Second number: ");
                            Double y = Convert.ToDouble(Console.ReadLine());
                            z = x / y;
                            Console.WriteLine("Result = " + z);
                            //a = false;
                            break;
                        }
                    case 5:
                        {
                            a = false;
                            break;
                        }
                    default:
                        Console.WriteLine("Invalid key.....choose option between 1-4");
                        break;
                }
                
            }
            
        }
    }
}
