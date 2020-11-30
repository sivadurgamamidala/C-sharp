using System;

namespace Calculator_interface
{
   
    class Program
    {
        public static int[] Number()
        {
            int[] num = new int[2];
            Console.Write("Enter the first number: ");
            num[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            num[1] = Convert.ToInt32(Console.ReadLine());
            return num;
        }
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            bool x= true;
            String title = "Calculator";
            Console.SetCursorPosition((Console.WindowWidth / 2 - title.Length), Console.CursorTop);
            Console.WriteLine(title);
            while (x)
            {
                Console.WriteLine("\n");
                Console.WriteLine("OPTIONS");
                Console.WriteLine("Option 1: Addition");
                Console.WriteLine("Option 2: Subtration");
                Console.WriteLine("Option 3: Multiplication");
                Console.WriteLine("Option 4: Division");
                Console.WriteLine("Option 5: Exit");
                Console.Write("Enter the option want to perform: ");
                int n =Convert.ToInt32( Console.ReadLine());
                if (n == 5)
                {
                    Console.WriteLine("You choose an option to Exit");
                    x = false;
                    break;
                }
                else if (n == 1)
                {
                    Console.WriteLine("You choose an option to Addition");
                    int[] num = Number();
                    Console.WriteLine("Result:"+ calc.Addition(num[0], num[1]));
                }
                 else if (n == 2)
                {
                    Console.WriteLine("You choose an option to Addition");
                    double[] num = new double[2];
                    Number(num);
                    
                    Console.WriteLine("Result:" + Sub.calculator(num[0], num[1]));
                }
                else if (n == 3)
                {
                    Console.WriteLine("You choose an option to Addition");
                    double[] num = new double[2];
                    double[] mul=Number(num);
                    Console.WriteLine("Result:" + Mul.calculator(mul[0], mul[1]));
                }
                else if (n == 4)
                {
                    Console.WriteLine("You choose an option to Addition");
                    double[] num = new double[2];
                    double[] div=Number(num);
                    Console.WriteLine("Result:" + Div.calculator(div[0], div[1]));
                }
                else
                {
                    Console.WriteLine("Invalid key : Choose the correct option");
                }
            }
        }
    }
}