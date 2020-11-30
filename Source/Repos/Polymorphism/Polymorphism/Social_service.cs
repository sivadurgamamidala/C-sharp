using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Social_service: Services
    {
        public string Sname = "social";
        public void Social()
        {
            Console.WriteLine("Social services");
        }
        public void fun()
        {
            Console.WriteLine("Social services123");
        }
    }
}
