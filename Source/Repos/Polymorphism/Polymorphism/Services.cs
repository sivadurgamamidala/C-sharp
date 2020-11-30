using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Services
    {
        public string name = "service";
        public virtual void fun()
        {
            Console.WriteLine("normal services");
        }
        public void service()
        {
            Console.WriteLine("types of Services");
        }
        
    }
}
