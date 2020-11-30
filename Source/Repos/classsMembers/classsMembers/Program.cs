using System;

namespace classsMembers
{
    class car
    {
        
        String car_company = "bmw";
        string color;
        int max_speed;
        public void information()
        {
            Console.WriteLine("information about car");
            
        }

        static void Main(string[] args)
        {
            car mycar = new car();
            car mycar1 = new car();
            mycar.information();
            Console.Write("enter your car company name: ");
            mycar.car_company = Console.ReadLine();
            Console.Write("enter your car color name: ");
            mycar.color = Console.ReadLine();
            Console.Write("enter your car max speed: ");
            mycar.max_speed =Convert.ToInt32(Console.ReadLine());
            string x = mycar.car_company;
            string y = mycar.color;
            int z = mycar.max_speed;
            Console.WriteLine("\n");
            Console.WriteLine("check your car details that you entered");
            Console.WriteLine("car company name: "+x);
            Console.WriteLine("car color: "+y);
            Console.WriteLine("car max speed: "+z);
            Console.Write("enter your car company name: ");
            mycar1.car_company = Console.ReadLine();
            Console.Write("enter your car color name: ");
            mycar1.color = Console.ReadLine();
            Console.Write("enter your car max speed: ");
            mycar1.max_speed = Convert.ToInt32(Console.ReadLine());
            string a = mycar1.car_company;
            string b = mycar1.color;
            int c = mycar1.max_speed;
            Console.WriteLine("\n");
            Console.WriteLine("check your car details that you entered");
            Console.WriteLine("car company name: " + a);
            Console.WriteLine("car color: " + b);
            Console.WriteLine("car max speed: " + c);


        }
    }
}