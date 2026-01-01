/*
Bir tam sayı dizisini parametre olarak alan bir metot yazınız. Bu metot dizideki her bir
elemanın 3 kez kendisiyle çarparak oluşturulmuş yeni diziyi dönsün.
Örnek Giriş :
{ 1, 2, 3 , 4 }
Beklenen Çıkış :
Yeni dizi: 1 8 27 64
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static int[] UckezCarp(int[] x)
        {
            int[] y = new int[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                y[i] = x[i] * x[i] * x[i];
            }

            return y;
        }

        static void Yazdir(int[] x, string mesaj)
        {
            Console.Write($"{mesaj}: [");

            for (int i = 0; i < x.Length; i++)
            {
                Console.Write($"{x[i],2}");

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

            int[] dizi = { 1, 2, 3, 4 };
            Yazdir(dizi, "Orijinal Dizi\t");

            int[] yeniDizi = UckezCarp(dizi);
            Yazdir(yeniDizi, "Yeni Dizi\t");
        }
    }
}