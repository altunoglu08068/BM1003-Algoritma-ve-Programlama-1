/*
Fibonacci serisinin ilk 10 terimini ekrana yazdıran programı yazınız. (0, 1, 1, 2, 3, 5, 8, 13, 21,
34, 55, 89, 144, 233, 377, 610, 987.. diye devam eden her sayının kendisinden önceki iki
ardışık sayının toplamına eşit olduğu sayı dizisine Fibonacci dizisi denmektedir.)
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int a = 0;
            int b = 1;
            int c;

            Console.WriteLine("Fibonacci Serisinin İlk 10 Terimi");

            Console.WriteLine("\n---------------------------------");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\t\t" + a);
                c = a + b;
                a = b;
                b = c;
            }

            Console.WriteLine("---------------------------------\n");
        }
    }
}
