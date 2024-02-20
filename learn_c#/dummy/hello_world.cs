using System;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your name");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name});

            Console.ReadKey();
        }
    }
}