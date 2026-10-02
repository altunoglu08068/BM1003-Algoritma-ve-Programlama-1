/*
10 ile 1000 arasındaki tam kare sayıları ekrana yazdıran programı yazınız.
(Tam kare, karekökü bir doğal sayı olan tam sayılara denir.
0, 1, 4, 9, 16, 25, 36, 49... tam kare sayılara örnektir.)
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static void Main(string[] args)
        {
            Console.Clear();

            for (int i = 1; i * i <= 1000; i++)
            {
                int sayi = i * i;

                if (sayi >= 10)
                {
                    Console.WriteLine(sayi);
                }
            }

            Console.WriteLine();
        }
    }
}
