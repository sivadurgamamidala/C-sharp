using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Public_service : Services
    {
        public string Pname = "Public";
        public void Public()
        {
            Console.WriteLine("Public services");
        }
        public void fun()
        {
            Console.WriteLine("Public services123");
        }
    }
}
