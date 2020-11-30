using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Services ser = new Services();
            Government_service gov = new Government_service();
            Public_service pub = new Public_service();
            Social_service soc = new Social_service();
            Console.WriteLine(ser.name+" are three types "+"\n"+"1."+gov.Gname+"\n2."+pub.Pname+"\n3."+soc.Sname);
            ser.service();
            gov.Govt();
            pub.Public();
            soc.Social();
            ser.fun();
            gov.fun();
            pub.fun();
            soc.fun();
        }
    }
}
