using System;

 using System.IO;

    namespace files1
    {
        class Program
        {
            static void Main(string[] args)
            {
                string writeText = "hello this is shiva";//create a text string
                File.WriteAllText("shiva.txt", writeText); //create a file and write content text in writeText
                string readText = File.ReadAllText("shiva.txt"); //read the content of file shiva
                Console.WriteLine(readText); //output the content
               // File.Copy("shiva.txt", "durga.txt");
                string readText1 = File.ReadAllText("durga.txt");
                Console.WriteLine(readText1);
            //File.Exists(readText1);
            //File.Exists(readText);
            Console.WriteLine(readText1);

        }
        }
    }