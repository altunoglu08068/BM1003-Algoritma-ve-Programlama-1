/*
Belirli bir tamsayı dizisindeki maksimum öğeyi bulan, tüm öğeleri maksimum öğeyle
değiştiren bir C# programı yazın.
Örnek Giriş :
{ 10, 20, -30, -40 }
Beklenen Çıkış :
Yeni dizi: 20 20 20 20
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static int EnBuyukBul(int[] x)
        {
            int enBuyuk = x[0];

            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] > enBuyuk)
                {
                    enBuyuk = x[i];
                }
            }
            return enBuyuk;
        }
        static void DiziYazdir(int[] x)
        {
            Console.Write("[");

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
        static int[] DiziyiDegistir(int[] x, int enBuyuk)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = enBuyuk;
            }
            return x;
        }
        static void Main(string[] args)
        {
            Console.Clear();

            int[] dizi = new int[20];
            Random rastgele = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rastgele.Next(-100, 101);
            }

            Console.WriteLine("------------------------- DİZİ -------------------------\n");

            DiziYazdir(dizi);

            int enBuyuk = EnBuyukBul(dizi);

            DiziyiDegistir(dizi, enBuyuk);

            Console.WriteLine("--------- Maksimum Elemanla Değiştirilmiş Dizi ---------\n");

            DiziYazdir(dizi);
        }
    }
}
