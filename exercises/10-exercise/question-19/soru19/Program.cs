/*
Bir tamsayı dizisinde 4 ve 4’ten büyük elemanları kaldırarak yeni bir dizi oluşturan bir metot
yazınız.
Örnek Giriş :
{ 0, -2, 1, 2, 3, 5 , 4, 7, 8 }
Beklenen Çıkış :
0 -2 1 2 3
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static int[] Fitrele(int[] x)
        {
            int sayac = 0;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < 4)
                {
                    sayac++;
                }
            }

            int[] yeniDizi = new int[sayac];
            int index = 0;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < 4)
                {
                    yeniDizi[index] = x[i];
                    index++;
                }
            }
            return yeniDizi;
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

            int[] dizi = { 0, -2, 1, 2, 3, 5, 4, 7, 8 };
            Yazdir(dizi, "Orijinal Dizi\t\t");

            int[] yeniDizi = Fitrele(dizi);
            Yazdir(yeniDizi, "Filtrelenmiş Dizi\t");
        }
    }
}
