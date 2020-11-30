using System;

namespace array_with_different_data_types
{
    class Program
    {
            class Customer
            {
                public int ID { get; set; }
                public string Name { get; set; }
                public override string ToString()
                {
                    return this.Name;
                }
            }
            static void Main(string[] args)
            {
                object[] array = new object[3];
                array[0] = 101;
                array[1] = "C#";
                Customer c = new Customer();
                c.ID = 55;
                c.Name = "Manish";
                array[2] = c;
                foreach (object obj in array)
                {
                    Console.WriteLine(obj);
                }
                Console.ReadLine();
            }
        }
    }
