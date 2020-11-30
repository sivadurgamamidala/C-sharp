using System;

namespace break_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            for (i=10; i>0; i--)
            {
                
                if (i == 0)
                {
                    break;//here break used to jump out of loop
                }
                for (j=0; j<i; j++)
                {
                    
                    Console.Write(j);
                    

                }
                Console.Write("\n");
                

            }
        }
    }
}
