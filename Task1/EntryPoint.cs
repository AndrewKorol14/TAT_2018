using System;

namespace Task1
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            Console.WriteLine("And hi again!");
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(5, 50); i++)
            {
                Console.Write("!");
            }
        }
    }
}