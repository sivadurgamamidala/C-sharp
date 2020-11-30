using System;

namespace ArrayUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the employees names: ");
            String[] name = new String[3];
            int[] age= new int[3];
            for(int i=0; i<3; i++)
            {
                Console.Write((1+i)+".Name: ");
                name[i] = Console.ReadLine();
                Console.Write("age: ");
                age[i]=Convert.ToInt32( Console.ReadLine());
                    
            }
            
            Console.WriteLine("\n");
            Console.WriteLine("Employees name that you entered : ");
            for (int j=0; j<3; j++)
            {
                Console.WriteLine("Employee"+(j+1)+":"+ name[j]+ "'s age is "+age[j]);
            }
            
        }
    }
}
