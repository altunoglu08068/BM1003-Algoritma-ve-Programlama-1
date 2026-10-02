using System;

class Program
{
    /*
    Görev:
    Aşağıdaki menüyü ekrana yazdıran MenuGoster() adlı bir metot yaz.
    • 1 - Tost (30 TL)
    • 2 - Ayran (10 TL)
    • 3 - Çay (5 TL)
    Bu metot parametre almaz, değer döndürmez.
    Sadece yazdırır.
    */
    static void MenuGoster()
    {
        Console.WriteLine("1 - Tost (30 TL)");
        Console.WriteLine("2 - Ayran (10 TL)");
        Console.WriteLine("3 - Çay (5 TL)");
    }

    /*
    Görev:
    Kullanıcıdan 1, 2 veya 3 olacak şekilde bir ürün seçmesini isteyen SecimAl() metodunu yaz.
    • Kullanıcı yanlış girerse tekrar sor.
    • Doğru girince o sayıyı int olarak geri döndür.
    */
    static int SecimAl()
    {
        int secim;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nBilgi: Seçiminizi menüde belirtilen (1, 2, 3, ...) numaralarla girmelisiniz.");
        Console.ResetColor();

        Console.Write("\nSeçiminiz: ");

        while (!int.TryParse(Console.ReadLine(), out secim) || (secim != 1 && secim != 2 && secim != 3))
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n⚠️ UYARI: Seçiminizi menüde belirtilen (1, 2, 3, ...) numaralarla girmelisiniz.");
            Console.ResetColor();

            Console.Write("\nSeçiminiz: ");
        }
        return secim;
    }
    
    /*
    Görev:
    Kullanıcıdan kaç adet ürün istediğini alan AdetAl() metodunu yaz.
    • Negatif veya 0 olamaz.
    • Yanlış girerse tekrar sor.
    • Doğru adet sayısını int olarak döndür.
    */
    static int AdetAl()
    {
        int adet;
        Console.Write("\nAdet sayısını giriniz: ");

        while (!int.TryParse(Console.ReadLine(), out adet) || (adet <= 0))
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n⚠️ UYARI: Adet sayısı pozitif olmalıdır.");
            Console.ResetColor();

            Console.Write("\nAdet sayısını giriniz: ");
        }
        return adet;
    }

    /*
    Görev:
    Ürün koduna göre fiyat döndüren FiyatGetir(int urunKodu) metodunu yaz.
    • 1 → 30 TL
    • 2 → 10 TL
    • 3 → 5 TL
    Bu metot seçilen ürünün fiyatını int olarak geri döndürmeli.
    */
    static int FiyatGetir(int urunKodu)
    {
        int fiyat = 0;

        switch (urunKodu)
        {
            case 1:
                fiyat = 30;
            break;

            case 2:
                fiyat = 10;
            break;

            case 3:
                fiyat = 5;
            break;
            
            default:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n⚠️ Geçersiz ürün kodu!");
                Console.ResetColor();
                fiyat = 0;
            break;
        }
        return fiyat;
    }

    /*
    Görev:
    SatirTutariHesapla(int adet, int birimFiyat) adında bir metot yaz.
    
    Bu metot:
    adet * birimFiyat
    hesabını yapacak ve sonucu int olarak döndürecek.
    */
    static int SatirTutariHesapla(int adet, int birimFiyat)
    {
        return adet * birimFiyat;
    }
    
    /*
    Görev:
    IndirimHakkiVarMi(int toplamTutar) metodunu yaz.
    • toplamTutar > 100 ise true döndür
    • değilse false döndür
    Bu metot sadece indirim olup olmadığını söyler.
    */
    static bool IndirimHakkiVarMi(int toplamTutar)
    {
        return toplamTutar > 100;
    }

    /*
    Görev:
    IndirimliTutarHesapla(int toplamTutar) metodunu yaz.
    • Eğer indirim varsa → toplamTutar * %10 indirim
    • Eğer yoksa → toplamTutar aynı kalsın
    Sonuç int olarak dönecek.
    */
    static int IndirimliTutarHesapla(int toplamTutar)
    {
        if (IndirimHakkiVarMi(toplamTutar) == true)
        {
            toplamTutar = (int)(toplamTutar * 0.90);
        }
        return toplamTutar;
    }

    /*
    Görev:
    Sipariş bilgilerini ekrana yazdıran bir metot yazın.

    Yazılacak bilgiler:
    • Ürün adı
    • Adet
    • Birim fiyat
    • Satır tutarı
    • İndirim olup olmadığı
    • Son tutar
    Bu metot sadece ekrana yazı yazar. Değer döndürmez.
    */
    static void SiparisOzetiniYazdir(int urunKodu, int adet, int birimFiyat, int satirTutar, int sonTutar)
    {
        string urunAdi;
        switch (urunKodu)
        {
            case 1:
                urunAdi = "Tost";
            break;

            case 2:
                urunAdi = "Ayran";
            break;

            default:
                urunAdi = "Çay";
            break;
        }
        Console.WriteLine("\n==============================");
        Console.WriteLine("       SİPARİŞ FİŞİ");
        Console.WriteLine("==============================");
        
        Console.WriteLine($"Ürün Adı       : {urunAdi}");
        Console.WriteLine($"Birim Fiyat    : {birimFiyat} TL");
        Console.WriteLine($"Adet           : {adet}");
        Console.WriteLine($"Satır Tutarı   : {satirTutar} TL");

        if (satirTutar != sonTutar)
        {
            Console.WriteLine("İndirim Durumu : Var (%10 Uygulandı.)");
        }
        else
        {
            Console.WriteLine("İndirim Durumu : Yok");
        }

        Console.WriteLine("------------------------------");
        Console.WriteLine($"Son Tutar      : {sonTutar} TL");
        Console.WriteLine("==============================\n");
    }
    static void Main(string[] args)
    {
        Console.Clear();

        MenuGoster();
        int secim = SecimAl();
        int adet = AdetAl();

        int birimFiyat = FiyatGetir(secim);
        int normalTutar = SatirTutariHesapla(adet, birimFiyat);
        int sonTutar = IndirimliTutarHesapla(normalTutar);
        SiparisOzetiniYazdir(secim, adet, birimFiyat, normalTutar, sonTutar);
    }
}
