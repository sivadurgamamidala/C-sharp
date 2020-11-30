using System;

namespace calculator_using_objects
{
    class Program
    {

        static void Main(string[] args)
        {
            String title = "Calculator";
            Console.SetCursorPosition((Console.WindowWidth / 2 - title.Length), Console.CursorTop);
            Console.Write("Calculator");
            Console.WriteLine("\n");
            Calculator calc = new Calculator();
            bool x = true;
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the first Number:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the second Number:");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Calculator calc = new Calculator();
            while (x)
            {
                Console.WriteLine("\t OPTIONS \n");
                Console.WriteLine("Option1: Addition");
                Console.WriteLine("Option2: Subtraction");
                Console.WriteLine("Option3: Multiplication");
                Console.WriteLine("Option4: Division");
                Console.WriteLine("Option5: To Exit");
                Console.WriteLine("\n");
                Console.Write("Select your option to perform:");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n == 5)
                {
                    Console.WriteLine("you chosen option to EXIT");
                    x = false;
                    break;
                }
                Console.Write("Enter the first Number:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the second Number:");
                int b = Convert.ToInt32(Console.ReadLine());
                //Calculator calc = new Calculator();
                if (n == 1)
                {
                    Console.WriteLine("Result: "+calc.Addition(a, b));
                }
                else if (n == 2){
                    Console.WriteLine("Result: " + calc.Subtraction(a, b));
                    
                }
                else if (n == 3)
                {
                    Console.WriteLine("Result: " + calc.Multiplication(a, b));
                    
                }
                else if (n == 4)
                {
                    Console.WriteLine("Result: " + calc.Division(a, b));
                    
                }
                //else if (n == 5)
                //{
                //    Console.WriteLine("EXIT");
                //    x = false;
                //    break;
                //}
                else
                {
                    Console.WriteLine("you chosen invalid option ...... please choose correct option");
                }
            }
        }
    }
}
