using System;

namespace String1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            String Name = Console.ReadLine();
            Console.Write("Enter your first name : ");
            String fname = Console.ReadLine();
            Console.Write("Enter your Last name : ");
            String lname = Console.ReadLine();
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Length of the Name is " + Name.Length);
            Console.WriteLine("Name in Upper case : " + Name.ToUpper());
            Console.WriteLine("Name in Lower case : " + Name.ToLower());
            String FullName = fname + lname;
            Console.WriteLine("Your full name is : " + FullName);
            String FullName1 = String.Concat(fname, lname);
            Console.WriteLine("Your full name 1 is : " + FullName1);
            String FullName2 = $"My Name is {fname} {lname}";
            Console.WriteLine("Your full name 2 is : " + FullName2);
            Console.WriteLine(Name[0]);
            Console.WriteLine(Name[1]);
            Console.WriteLine(Name[2]);
            Console.WriteLine(Name[3]);
            Console.WriteLine(Name[4]);
        }
    }
}
