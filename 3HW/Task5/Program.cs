using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write N");
            var fact = int.Parse(Console.ReadLine());
            var znach = 1;
            var s = 1;
            do
            {
                znach *= s;
                s++;
            } while (s<=fact);
            Console.WriteLine($"Fact = {znach}");
        }
    }
}
