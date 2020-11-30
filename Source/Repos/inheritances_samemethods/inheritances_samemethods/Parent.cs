using System;
using System.Collections.Generic;
using System.Text;

namespace inheritances_samemethods
{
    class Parent
    {
        public string fname = "Sivadurgateja";
        public string lname = "Mamidala";
        public void Name()
        {
            Console.WriteLine("Parent Method");
        }
        public virtual void City()
        {
            Console.WriteLine("City Guntur");
        }
    }
}
