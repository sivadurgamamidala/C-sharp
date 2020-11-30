using System;
using System.Collections.Generic;
using System.Text;

namespace inheritances_samemethods
{
    class Clild:Parent
    {
        public string lname = "Mami";
        public void Name()
        {
            Console.WriteLine("Child method");
        }
        public override void City()
        {
            Console.WriteLine("City Narasaraopet");
        }
    }
}
