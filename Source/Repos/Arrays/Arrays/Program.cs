using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name= { "shiva", "Gopi", "Papi", "Pavan"};
            int[] salary = {25000, 30000,35000,40000};
            Console.WriteLine("no of employees: "+name.Length);
            Console.WriteLine("no of employees salary pending: "+salary.Length);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Salary of "+ name[i]+" is "+salary[i]);
            }
           

        }
    }
}
