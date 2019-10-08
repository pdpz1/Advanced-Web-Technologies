using System;

namespace Worksheet1p3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum = 0;
            Console.WriteLine("Welcome to the adding calculator!");
            Console.WriteLine("Please enter your first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please write your second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            sum = a + b;
            Console.WriteLine("The sum is " + sum);

        }
    }
}
