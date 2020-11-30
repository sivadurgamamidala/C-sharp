using System;

namespace set_get
{
    class Program
    {
        class Employee
        {
            private string Name;
            private int Age;
            private string City;
            public string name
            {
                get { return Name; }
                set { Name = value; }
            }
            public int age
            {
                get { return Age; }
                set { Age = value; }
            }
            public string city
            {
                get { return City; }
                set { City = value; }
            }
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.Write("Enter your name: ");
            emp.name = Console.ReadLine();
            Console.Write("Enter your age: ");
            emp.age =Convert.ToInt32( Console.ReadLine());
            Console.Write("Enter your city name: ");
            emp.city = Console.ReadLine();

            Console.WriteLine("\n");
            Console.WriteLine("Name: "+emp.name);
            Console.WriteLine("Age: "+emp.age);
            Console.WriteLine("city: "+emp.city);

        }
    }
}
