using System;

namespace Worksheet1p1
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            Console.WriteLine("Your name is: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
