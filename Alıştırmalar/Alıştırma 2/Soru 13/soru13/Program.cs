/*
Girilen bir k sayısı tek ise 3 ile çarpılıp 1 ekleniyor, çift ise 2 ile bölünüyor. Bu işlem k sayısı 1
olana kadar devam ediyor. Bu işlemin kaç adım sürdüğünü ve işlem sırasında k sayısının aldığı
maksimum değeri ve k sayısının hangi sayıdan sonra hep çift olarak bire ulaştığını bulan C#
kodunu yazınız.
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Bir (k) sayısı girin: ");

            int k;

            while (!int.TryParse(Console.ReadLine(), out k) || k <= 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n⚠️ HATA! Lütfen 1'den büyük bir tam sayı girin.");
                Console.ResetColor();

                Console.Write("\nTekrar deneyin: ");
            }

            int adimSayaci = 0;
            int kMax = k;
            int ciftGidisBaslangici = 0;
            bool bulunduMu = false;

            Console.WriteLine("\n--- Adımlar ---\n");
            Console.Write(k); // Başlangıç sayısını yazdır

            while (k > 1)
            {
                // KONTROL: "Bu sayıdan sonra hep bölünerek 1'e gider mi?"
                if (!bulunduMu)
                {
                    int geciciSayi = k;
                    bool hepsiCiftMi = true;

                    // Sayının kopyasını 1 olana kadar bölüyoruz
                    while (geciciSayi > 1)
                    {
                        if (geciciSayi % 2 != 0) // Tek sayı yakalarsak
                        {
                            hepsiCiftMi = false; // "Bu sayı 2'nin kuvveti değilmiş"
                            break;
                        }
                        geciciSayi /= 2;
                    }

                    // Eğer hiç tek sayıya rastlamadıysa
                    if (hepsiCiftMi == true)
                    {
                        ciftGidisBaslangici = k;
                        bulunduMu = true;
                    }
                }

                //Ana Döngü
                if (k % 2 == 0)
                {
                    k = k / 2;
                }
                else
                {
                    k = (3 * k) + 1;
                }

                // Maksimum değeri güncelle
                if (k > kMax)
                {
                    kMax = k;
                }

                adimSayaci++;
                Console.Write($" -> {k}");
            }

            // SONUÇLARI YAZDIRMA
            Console.WriteLine("\n\n---------- SONUÇLAR ----------");
            Console.WriteLine($"Adım sayısı\t\t: {adimSayaci}");
            Console.WriteLine($"(k) nın maksimum değeri\t: {kMax}");

            if (ciftGidisBaslangici != 0)
            {
                Console.WriteLine($"Sürekli Çift İniş Başı\t: {ciftGidisBaslangici} (2'nin bir kuvvetidir ve buradan sonra hep bölünerek 1'e gider.)\n");
            }
            else
            {
                Console.WriteLine("Sürekli Çift İniş Başı\t: Girilen (k) sayısı zaten 2'nin kuvvetiydi.\n");
            }
        }
    }
}