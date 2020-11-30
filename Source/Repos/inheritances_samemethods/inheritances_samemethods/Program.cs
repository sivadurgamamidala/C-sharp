using System;

namespace inheritances_samemethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent pr = new Parent();
           
            Clild cr = new Clild();

            Parent ct = new Clild();

            pr.Name();
            pr.City();
            Console.WriteLine(pr.fname);

            cr.Name();
            cr.City();
            Console.WriteLine(cr.fname+" "+cr.lname);

            ct.Name();
            ct.City();
            Console.WriteLine(ct.fname + " " + ct.lname);
        }
    }
}
