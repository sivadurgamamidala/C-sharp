using System;

namespace String.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname = "Shiva durga";
            int x = fname.IndexOf("d");
            int y = fname.IndexOf("a");
            //Console.WriteLine(x);
            Console.WriteLine(y); //output first a=4
            string middlename = fname.Substring(x);
            Console.WriteLine(middlename);

        }
    }
}
