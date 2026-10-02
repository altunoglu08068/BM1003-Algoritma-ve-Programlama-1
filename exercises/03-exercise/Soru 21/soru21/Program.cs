// 10 ve 50 arasındaki asal sayıları bulunuz.

using System;

namespace Program
{
    internal class ProgramClass
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("--- 10 ile 50 Arasındaki Asal Sayılar ---\n");

            for (int i = 10; i <= 50; i++)
            {
                bool asalMi = true;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        asalMi = false;
                        break;
                    }
                }

                if (asalMi)
                {
                    Console.WriteLine("\t\t" + i);
                }
            }
            Console.WriteLine("\n-----------------------------------------\n");
        }
    }
}
