using System;
using System.Linq;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the names of employees: ");
            string[] name = { "Shiva", "Durga", "Teja"};
            int[] age = {24,25,23};
            
            Console.WriteLine(name[0] +"'s age is "+age[1] );
            Console.WriteLine(name.Length);
            
            for (int i=0; i < 3; i++)
            {
                Console.WriteLine(name[i]+"'s age is "+age[i]);
            }
            for (int j=0; j<name.Length; j++)
            {
                Console.WriteLine(name[j]);
            }
            foreach (string k in name)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine(" ");
            Array.Sort(name);
            foreach (string l in name)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine(" ");
            Array.Reverse(name);
            foreach (string m in name)
            {
                Console.WriteLine(m);
            }
            //Other useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace
            Console.WriteLine("Maximum age is "+age.Max());
            Console.WriteLine("minimum age is "+age.Min());
            Console.WriteLine("Sum of ages : "+age.Sum());
        }
    }
}
