using System;

namespace PersonDataManagment
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3];
            int count = 1;

            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = new Person();
                Console.WriteLine("**************************************************");
                Console.WriteLine("Enter the person " + i+1 + " Data");
                Console.WriteLine("Enter name : ");
                persons[i].Name = Console.ReadLine();
                Console.WriteLine("Enter the Age : ");
                persons[i].Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the phone Number : ");
                persons[i].PhoneNumber = Convert.ToInt32(Console.ReadLine());
            }
            count = 1;
            foreach (var person in persons)
            {
                Console.WriteLine("**************************************************");
                Console.WriteLine($"person {count} Data : ");
                Console.WriteLine(person.Name);
                Console.WriteLine(person.Age);
                Console.WriteLine(person.PhoneNumber);
                person.Singing();
                count++;
            }

        }
    }
}
