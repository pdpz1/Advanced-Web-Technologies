using System;

namespace Sum1to10
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i=1; i<=10; i++)
            {
                sum += i;
            }
            Console.Write(sum);
        }
    }
}
