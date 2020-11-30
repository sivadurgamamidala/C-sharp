using System;

namespace Calculator_UsingFunctions123
{
    class Program
    {
        static double[] read()
        {
            double[] numbers=new double[2];
            
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
        static void Addition()
        {
            Double a;
            Double[] sum = read();
            a=sum[0]+sum[1];
            write(a);
        }
        static void Subtraction()
        {
            Double a;
            Double[] sum = read();
            a = sum[0] - sum[1];
            write(a);
        }
        static void Multiplication()
        {
            Double a;
            Double[] sum = read();
            a = sum[0] * sum[1];
            write(a);
        }
        static void Division()
        {
            Double a;
            Double[] sum = read();
            a = sum[0] / sum[1];
            write(a);
        }

        static void Main(string[] args)
        {
            String title = "Calculator";
            Console.SetCursorPosition((Console.WindowWidth / 2 -title.Length),Console.CursorTop);
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
                            Addition();
                            
                            code = false;
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("you choose Second option: Subtraction");
                            Subtraction();
                            code = false;
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("you choose Thrid option: Multiplication");
                            Multiplication();
                            code = false;
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("you choose Fouth option: Division");
                            Division();
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
