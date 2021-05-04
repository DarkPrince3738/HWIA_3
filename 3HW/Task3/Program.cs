using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {//task 3 and 4
            Console.WriteLine("Write which figure you want to paint");
            var type = Console.ReadLine();
            switch (type)
            {
                case "1":
                    {
                        Console.WriteLine("Choose size height, width");
                        int height = int.Parse(Console.ReadLine());
                        int width = int.Parse(Console.ReadLine());
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < width; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Write catet lenght");
                        int lenght = int.Parse(Console.ReadLine());
                        for(int i = 1; i <= lenght; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Size A");
                        int a = int.Parse(Console.ReadLine());
                        for (int j = a; j >0; j--)
                        {
                            for (int i = 0; i < (j -1); i++)
                            {
                                Console.Write(" ");
                            }
                            for (int i = j; i <= a; i++)
                            {
                                Console.Write("*");
                                Console.Write(" ");
                            }
                        Console.WriteLine();
                        }
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("Size A");
                        int a = int.Parse(Console.ReadLine());
                        for (int j = a; j > 0; j--)
                        {
                            for (int i = 0; i < j; i++)
                            {
                                Console.Write(" ");
                            }
                            for (int i = j; i <= a; i++)
                            {
                                Console.Write("*");
                                Console.Write(" ");
                            }
                            Console.WriteLine();
                        }
                        for (int j = 0; j < a; j++)
                        {
                            for (int i = 0; i < j; i++)
                            {
                                Console.Write(" ");
                            }
                            for (int i = j; i <= a; i++)
                            {
                                Console.Write("*");
                                Console.Write(" ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Try again");
                        break;
                    }
            }
        }
    }
}
