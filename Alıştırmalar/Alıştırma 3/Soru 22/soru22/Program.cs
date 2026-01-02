// 1 - 100 arasında kaç asal sayı vardır bulunuz.

using System;

namespace Program
{
    internal class ProgramClass
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("------ 1 ile 100 Arasındaki Asal Sayılar ------\n");

            int asalSayac = 0;

            for (int i = 2; i <= 100; i++)
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
                    asalSayac++;
                }
            }
            Console.WriteLine($"\n1 ile 100 arasındaki asal sayıların adedi: {asalSayac}");
            Console.WriteLine("\n-----------------------------------------------\n");
        }
    }
}
