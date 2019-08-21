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
                // 0 1 2 3 4 5 6 7 8 9
                Console.Write(i + " ");
            }

            Console.WriteLine("\n\n10 >= i >= 0");
            foreach (int i in 10 >= i >= 0)
            {
                // 10 9 8 7 6 5 4 3 2 1 0
                Console.Write(i + " ");
            }

            Console.WriteLine("\n\n10 >= i >= 0 | 2");
            foreach (int i in 10 >= i >= 0 | 2)
            {
                // 10 8 6 4 2 0
                Console.Write(i + " ");
            }

            Console.WriteLine("\n\n-14 < i <= 10 | 3");
            foreach (int i in -14 < i <= 10 | 3)
            {
                // -13 -10 -7 -4 -1 2 5 8
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
