using System;

namespace Multiple_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            cars x = new cars();
            Console.WriteLine("Car Company:"+x.CarCompany);
            Console.WriteLine("Car Model: :" + x.CarModel);
            Console.WriteLine("Car Engine type: "+ x.CarEngineType);
        }
    }
}
