using System;

namespace Worksheet1p3
{
    class Worksheet1p3
    {
        static void Main(string[] args)
        {
            int a, b, total = 0;
            string x;
            Console.WriteLine("Welcome to the adding calculator!");
            Console.WriteLine("Please enter your first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter an operator: ");
            x = Console.ReadLine();
            if (x.Equals("+"))
            {
                total = a + b;
            }
            else if (x.Equals("-"))
            {
                total = a - b;
            }
            else if (x.Equals("*"))
            {
                total = a * b;
            }
            else if (x.Equals("/"))
            {
                total = a / b;
            }
            Console.WriteLine("The total is: " + total);

        }
    }
}

