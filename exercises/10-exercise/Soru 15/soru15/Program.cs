/*
Bir diziyi parametre olarak alan ve elemanlarını sola kaydıran bir metot yazınız.
Örnek Giriş :
{ 10, 20, -30, -40, 50 }
Beklenen Çıkış :
Yeni dizi: 20 -30 -40 50 10
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static int[] SolaKaydir(int[] x)
        {
            int[] y = new int[x.Length];

            int ilkEleman = x[0];

            for (int i = 0; i < x.Length; i++)
            {
                if (i == x.Length - 1)
                {
                    y[i] = ilkEleman;
                }
                else
                {
                    y[i] = x[i + 1];
                }
            }
            return y;
        }
        static void Yazdir(int[] x, string mesaj)
        {
            Console.Write($"{mesaj}: [");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i]);

                if (i < x.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]\n");
        }
        static void Main(string[] args)
        {
            Console.Clear();

            int[] dizi = { 10, 20, -30, -40, 50 };

            Yazdir(dizi, "Orijinal dizi\t");

            int[] yeniDizi = SolaKaydir(dizi);

            Yazdir(yeniDizi, "Yeni dizi\t");
        }
    }
}
