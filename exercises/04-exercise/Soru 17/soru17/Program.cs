// Kendisine parametre olarak gönderilen bir tamsayı diziyi ekrana yazdıran bir metot yazınız.

using System;

namespace MyApp
{
    internal class Program
    {
        static void Yazdir(int[] dizi)
        {
            Console.Write("Dizi elemanları: [");
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write(dizi[i]);
                if (i < dizi.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }
        static void Main(string[] args)
        {
            Console.Clear();

            int[] dizi = new int[5];

            Random rastgele = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rastgele.Next(1, 101);
            }
            Console.WriteLine("\n-------------------------------------------");
            Yazdir(dizi);
            Console.WriteLine("-------------------------------------------\n");
        }
    }
}