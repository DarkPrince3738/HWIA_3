using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write A and B value");
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = a+1; i < b; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum = {sum}");
            Console.Write("Not pair ");
            for (int i = a + 1; i < b; i++)
            {
                if (i%2!=0)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
