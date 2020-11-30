using System;

namespace polymorphism_simple
{
    class Program
    {
        static void Main(string[] args)
        {
           // Parent P = new Parent();
            Child C = new Child();
            //P.method();
            C.method();
            //var x = (Parent)C;
            //x.method();
            Parent P = C as Parent;// To access parent member you must cast the object.
            P.method();
        }
    }
}
