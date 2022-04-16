using System;

namespace Star_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for(i=1; i<=7; i++) // 1  2 
            {
                for(j=1; j<=i; j++) //1 12
                {
                    Console.Write("*");  //* **
                }
                Console.WriteLine(" ");

            }
            Console.ReadLine();

        }
    }
}
