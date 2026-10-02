using System;
using System.Globalization; // Yeni eklenen kütüphane!

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n\n---------- Beden Kitle İndeksi (BMI) Hesaplayıcı ----------\n\n");

        double boy;
        double kilo;
        string giris;

        // --- Boy Girişi Kontrolü ---
        while (true)
        {
            Console.Write("Boyunuzu girin (m): ");
            giris = Console.ReadLine() ?? "";
            
            // ADIM 1: Metni kesinlikle nokta formatına çeviriyoruz.
            giris = giris.Replace(',', '.'); 

            // ADIM 2: TryParse'a metni nokta ile okumasını emrediyoruz (CultureInfo.InvariantCulture).
            if (double.TryParse(giris, NumberStyles.Any, CultureInfo.InvariantCulture, out boy) && boy > 0)
            {
                Console.WriteLine();
                break;
            }

            // Hata Durumu (Geçersiz Giriş)
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n❌ Geçersiz giriş! Pozitif bir sayı girmelisiniz (ör: 1.75). Tekrar deneyiniz.\n");
            Console.ResetColor();
        }
        
        // --- Kilo Girişi Kontrolü ---
        while (true)
        {
            Console.Write("\nKilonuzu girin (kg): ");
            giris = Console.ReadLine() ?? "";

            // ADIM 1: Metni kesinlikle nokta formatına çeviriyoruz.
            giris = giris.Replace(',', '.');

            // ADIM 2: TryParse'a metni nokta ile okumasını emrediyoruz.
            if (double.TryParse(giris, NumberStyles.Any, CultureInfo.InvariantCulture, out kilo) && kilo > 0)
            {
                Console.WriteLine();
                break;
            }

            // Hata Durumu (Geçersiz Giriş)
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n❌ Geçersiz giriş! Pozitif bir sayı girmelisiniz (ör: 70.5). Tekrar deneyiniz.\n");
            Console.ResetColor();
        }
        
        // --- Hesaplama ve Sonuç ---
        double BedenKitleIndeksi = kilo / (boy * boy);

        // Sonuç Sınıflandırması
        ConsoleColor renk;
        string durum;

        if (BedenKitleIndeksi < 18.5)
        {
            durum = "Zayıfsınız";
            renk = ConsoleColor.Cyan;
        }
        else if (BedenKitleIndeksi < 25)
        {
            durum = "Normal durumdasınız";
            renk = ConsoleColor.Green;
        }
        else if (BedenKitleIndeksi < 30)
        {
            durum = "Fazla kilolusunuz";
            renk = ConsoleColor.Yellow;
        }
        else
        {
            durum = "Obezsiniz";
            renk = ConsoleColor.Magenta;
        }

        Console.WriteLine("\n--------------------");
        
        // --- Sonuç Çıktısı (Renk Uygulaması) ---
        
        // 1. "Beden Kitle İndeksiniz (BMI): " metnini yaz.
        Console.Write("\nBeden Kitle İndeksiniz (BMI): "); 
        
        // 2. BMI değeri, kategori rengiyle (renk değişkeni) yazılır.
        Console.ForegroundColor = renk;
        Console.Write($"{BedenKitleIndeksi:F2}\n");
        
        // 3. Devam metni için rengi sıfırla.
        Console.ResetColor(); 
        Console.Write("\nSonuç: ");
        
        // 4. Durum (Zayıfsınız, Normalsiniz vb.) kategori rengiyle yazılır.
        Console.ForegroundColor = renk;
        Console.Write($"{durum}.\n");
        
        Console.ResetColor();
        Console.WriteLine("\n--------------------");
        Console.WriteLine();
    }
}