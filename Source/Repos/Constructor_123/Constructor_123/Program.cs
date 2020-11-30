using System;

namespace Constructor_123
{
    class Employee
    {
        public string Name;
        public int Age;
        public string City;
        public int Pin;
        public Employee(string name, int age, string city, int pin)
        {
            
            Name =name;

            Age = age;
            City = city;
            Pin = pin;
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee("shiva", 24, "narasaraopet", 522601);
            Console.WriteLine("Name: " +emp.Name);
            Console.WriteLine("Age: "+emp.Age);
            Console.WriteLine("City: "+emp.City);
            Console.WriteLine("PinCode:" +emp.Pin);
        }
    }
}
