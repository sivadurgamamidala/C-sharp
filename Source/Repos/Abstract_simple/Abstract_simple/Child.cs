using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_simple
{
     class Child : Abstract
    {
        public string Lname = "Mamidala";
        public override void Name()
        {
            Console.WriteLine("M siva durga teja");
        }
    }
}
