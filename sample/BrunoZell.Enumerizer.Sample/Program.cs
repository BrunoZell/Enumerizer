using System;
using static Enumerizer;

namespace BrunoZell.Enumerizer.Sample
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("0 <= i < 10");
            foreach (int i in 0 <= i < 10)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n\n10 >= i >= 0");
            foreach (int i in 10 >= i >= 0)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n\n10 >= i >= 0 | 2");
            foreach (int i in 10 >= i >= 0 | 2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n\n-14 < i <= 10 | 3");
            foreach (int i in -14 < i <= 10 | 3)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
