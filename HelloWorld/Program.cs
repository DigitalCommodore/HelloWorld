using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name?");
            var name = Console.ReadLine();
            Console.WriteLine("Age?");
            var age = Console.ReadLine();
            Console.WriteLine("Birth Month?");
            var month = Console.ReadLine();
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Birth Month: {0}", month);
        }
    }
}