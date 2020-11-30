using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Government_service: Services
    {
        public string Gname = "Government";
        public void Govt()
        {
            Console.WriteLine("Government services");
        }
        public override void fun()
        {
            Console.WriteLine("Goverment services123");
        }
    }
}
