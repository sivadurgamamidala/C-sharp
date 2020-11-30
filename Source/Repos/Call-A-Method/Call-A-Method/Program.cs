using System;

namespace Call_A_Method
{
    class Program
    {   
        static void shiva() //this method will call multiple times
        {
            Console.WriteLine("hai this is Shivadurgamamidala");
        }
        static void state(string x="Andhra pradesh")// default parameter 
        {
            Console.WriteLine("State Name: " + x);
        }
        static void myname(String fname)//parameter act as variables inside method
        {
            Console.WriteLine("Name: "+fname);
        }
        static void student(string Sname="sai", int age=20)
        {
            Console.WriteLine("Student Name: "+Sname+", Age:"+age+";");
        }
        static void student1()
        {
            Console.Write("Student Name: ");
            string Sname=Console.ReadLine();
            Console.Write("Student age: ");
            int age1= Convert.ToInt32(Console.ReadLine()); ;
           
           
        }
        static void Main(string[] args)
        {
            shiva(); 
            shiva();
            shiva();
            shiva();
            shiva();
            myname("Shiva");
            myname("Durga");
            myname("Teja");
            state("kerala");
            state();
            state("telangana");
            state("Madhya pradesh");
            state("Punjab");
            student("shiva", 24);
            student("durga", 34);
            student1();
        }
    }
}
