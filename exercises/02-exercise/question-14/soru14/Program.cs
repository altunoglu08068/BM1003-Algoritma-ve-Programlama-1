/*
Klavyeden girilen 10 adet tamsayı sınav notuna göre, ortalamanın üstünde olanları ekrana
yazan programı yazınız.
Örnek:
10 adet notu giriniz:
56
42
…
75
13
Çıktı:
Sınıfın ortalaması = 53.25
ortalamadan yüksek olan notlar:
56
75
*/

using System;
using System.Globalization;

namespace Program
{
    internal class ProgramClass
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int adet = 10;
            double[] notlar = new double[adet];
            double toplam = 0;

            for (int i = 0; i < adet; i++)
            {
                Console.Write($"{i + 1}. sınav notunu girin: ");

                double not;

                while (!double.TryParse(Console.ReadLine()?.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out not) || not < 0 || not > 100)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n⚠️ HATA!");
                    Console.ResetColor();

                    Console.Write("Tekrar deneyin: ");
                }
                notlar[i] = not;
                toplam += not;
            }

            double ortalama = (double)toplam / adet;

            int sayac = 0;

            for (int i = 0; i < adet; i++)
            {
                if (notlar[i] > ortalama)
                {
                    sayac++;
                }
            }

            double[] ortalamaUstundeAlanlar = new double[sayac];
            int index = 0;

            for (int i = 0; i < adet; i++)
            {
                if (notlar[i] > ortalama)
                {
                    ortalamaUstundeAlanlar[index] = notlar[i];
                    index++;
                }
            }

            Console.WriteLine("\n-----------------------------------------");

            Console.Write("Ortalamayı Geçen Notlar Dizisi\t: [");

            for (int i = 0; i < ortalamaUstundeAlanlar.Length; i++)
            {
                Console.Write(ortalamaUstundeAlanlar[i].ToString(CultureInfo.InvariantCulture));

                if (i < ortalamaUstundeAlanlar.Length - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("]");

            Console.WriteLine($"Girilen notların toplamı\t: {toplam.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Girilen notların ortalaması\t: {ortalama.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("-----------------------------------------\n");
        }
    }
}
