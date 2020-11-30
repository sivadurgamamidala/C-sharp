using System;

namespace Calculator_UsingFunctions123
{
    class Program
    {
        static double[] read()
        {
            double[] numbers = new double[2];

            Console.Write("Enter first Number: ");
            numbers[0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            numbers[1] = Convert.ToDouble(Console.ReadLine());
            return numbers;
        }
        static void write(Double x)
        {
            Console.WriteLine("Result: " + x);
        }
        static Double Addition(Double a, Double b)
        {
            return a + b;
        }
        static Double Subtraction(Double a, Double b)
        {
            return a - b;
        }
        static Double Multiplication(Double a, Double b)
        {
            return a * b;
        }
        static Double Division(Double a, Double b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            String title = "Calculator";
            Console.SetCursorPosition((Console.WindowWidth / 2 - title.Length), Console.CursorTop);
            Console.WriteLine(title);
            Console.WriteLine("************************************************************************************************************************");
            bool code = true;
            Console.WriteLine("OPTIONS:");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            while (code)
            {

                Console.Write("Choose your option to Perform:");
                int i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        {
                            Console.WriteLine("you choose First option: Addition");
                            Double a;
                            Double[] sum = read();
                            a=Addition(sum[0],sum[1]);
                            write(a);
                            code = false;
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("you choose Second option: Subtraction");
                            Double a;
                            Double[] minus = read();
                            a = Subtraction(minus[0], minus[1]);
                            write(a);
                            code = false;
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("you choose thrid option: Multiplication");
                            Double a;
                            Double[] mul = read();
                            a = Multiplication(mul[0], mul[1]);
                            write(a);
                            code = false;
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("you choose Fouth option: Division");
                            Double a;
                            Double[] div = read();
                            a = Division(div[0], div[1]);
                            write(a);
                            code = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("Invaild option: please select the options between 1-4");
                            break;
                        }
                }

            }
        }
    }
}
