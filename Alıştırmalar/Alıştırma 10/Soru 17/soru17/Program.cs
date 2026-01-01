/*
Bir tam sayı dizisini parametre olarak alan bir metot yazınız. Bu metot dizideki her bir
elemanın 3 ile çarpılarak oluşturulmuş yeni diziyi dönsün.
Örnek Giriş :
{ 1, 2, 3 , 4 }
Beklenen Çıkış :
Yeni dizi: 3 6 9 12
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static int[] DiziyiUcIleCarp(int[] x)
        {
            int[] y = new int[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                y[i] = x[i] * 3;
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
            Yazdir(dizi, "Orijinal dizi\t");

            int[] yeniDizi = DiziyiUcIleCarp(dizi);
            Yazdir(yeniDizi, "Yeni dizi\t");
        }
    }
}
