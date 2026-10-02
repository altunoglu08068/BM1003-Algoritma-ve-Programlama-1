using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Kullanıcıdan kargonun ağırlığını (kg) ve konum bilgisini (“şehir içi” veya “şehir dışı”) alınız.
        Kargo ücreti aşağıdaki kurallara göre hesaplanacaktır:
        0–1 kg arası → 30 TL
        1–5 kg arası → 50 TL
        5 kg üzeri → 50 TL + (ağırlık − 5) × 8 TL
        Eğer konum şehir dışı ise, hesaplanan tutarın üzerine %15 ekleyiniz. Ağırlık 0 veya negatif
        girilirse “Geçersiz giriş!” mesajı veriniz.
        */
        
        string cevap = "E";

        while (cevap == "E")
        {
            Console.Clear();
            Console.WriteLine("\n\n---------- Kargo Ücreti Hesaplama Programına Hoşgeldiniz! ----------\n");

            double agirlik;

            Console.Write("Kargonun ağırlığını giriniz (kg): ");

            while (!double.TryParse(Console.ReadLine(), out agirlik) || agirlik <= 0)
            {
                Console.WriteLine("\nHatalı giriş! Lütfen sıfırdan büyük bir sayısal değer girin.\n");
                Console.Write("Tekrar deneyin: ");
            }
            
            Console.Write("Konum giriniz (şehir içi / şehir dışı): ");
            string konum = (Console.ReadLine() ?? "").Trim().Replace(" ", "").ToLower();

            while (konum != "şehiriçi" && konum != "şehirdışı")
            {
                Console.WriteLine("\nHatalı giriş! Lütfen sadece 'şehir içi' veya 'şehir dışı' yazınız.");
                Console.Write("Tekrar deneyin (şehir içi / şehir dışı): ");
                
                konum = (Console.ReadLine() ?? "").Trim().Replace(" ", "").ToLower();
            }

            double fiyat = 0;

            if (agirlik > 0 && agirlik <= 1)
            {
                fiyat = 30;
            }
            else if (agirlik > 1 && agirlik <= 5)
            {
                fiyat = 50;
            }
            else if (agirlik > 5)
            {
                fiyat = 50 + ((agirlik - 5) * 8);
            }

            if (konum == "şehirdışı")
            {
                fiyat *= 1.15;
                Console.WriteLine("\nBilgi: Şehir dışı gönderim bedeli (%15) eklendi.\n");
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Kargo ücretiniz: {fiyat:N2} TL");
            Console.WriteLine("-----------------------------------");

            Console.Write("\nBaşka bir hesaplama yapmak ister misiniz? (E/H): ");
            
            cevap = (Console.ReadLine() ?? "").Trim().ToUpper();
        }

        Console.WriteLine("\nProgram bitti. Güle güle!\n");
    }
}