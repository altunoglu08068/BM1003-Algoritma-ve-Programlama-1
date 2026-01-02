/*
Tüm 5 değerlerini 0 ile değiştirdikten sonra tüm sıfırları sağa kaydırarak yeni bir dizi oluşturan
bir C# programı yazın.
Örnek Giriş :
{ 1, 2, 5, 3, 5, 7, 5, 9, 11 }
Beklenen Çıkış :
Yeni dizi: 1 2 3 7 9 11 0 0 0
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static void Degistir(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == 5)
                {
                    x[i] = 0;
                }
            }
        }

        static void SifirlariSonaTasi(int[] x)
        {
            int index = 0;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != 0)
                {
                    x[index] = x[i];
                    index++;
                }
            }

            while (index < x.Length)
            {
                x[index] = 0;
                index++;
            }
        }
        static void Yazdir(int[] x, string mesaj)
        {
            Console.Write($"{mesaj} [");
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

            int[] dizi = { 1, 2, 5, 3, 5, 7, 5, 9, 11 };

            Yazdir(dizi, "Dizi\t\t:");
            Degistir(dizi);
            SifirlariSonaTasi(dizi);
            Yazdir(dizi, "Yeni Dizi\t:");
        }
    }
}
