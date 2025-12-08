using System;
using System.Globalization;

class Program
{
    /*
    Görev 1:
    Eşyaları tutmak için bir yapı oluşturun:
    • Eşya adı (string)
    • Ağırlık (int)
    Ve eşyaların tutulacağı liste/dizi/tasarımı belirleyin.
    Bu yapı sonraki tüm metotlarda kullanılacaktır.
    */
    static string[] EsyaAdi = new string[0];
    static double[] Agirlik = new double[0];

    /*
    Görev 2:
    Aşağıdaki metodu yazın:
    EsyaEkle(string ad, int agirlik)
    • Yeni bir eşya oluşturur
    • Çantadaki listeye ekler
    • Kullanıcıya eklediğini bildirir
    */
    static void EsyaEkle(string ad, double agirlik)
    {
        Array.Resize(ref EsyaAdi, EsyaAdi.Length + 1);
        EsyaAdi[EsyaAdi.Length - 1] = ad;

        Array.Resize(ref Agirlik, Agirlik.Length + 1);
        Agirlik[Agirlik.Length - 1] = agirlik;
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n✅ Eşya: {ad}, Ağırlık: {agirlik.ToString("F2", CultureInfo.InvariantCulture)} başarıyla eklendi.");
        Console.ResetColor();
    }

    /*
    Görev 3:
    EsyaSil(string ad) metodunu yazın.
    • Çantada adı verilen eşyayı arayın
    • Bulursanız listeden çıkarın
    • Bulunamazsa kullanıcıyı bilgilendirin
    */
    static void EsyaSil(string ad)
    {   
        int bulunanIndeks = -1; // -1 demek "Henüz bulamadım" demektir.

        for (int i = 0; i < EsyaAdi.Length; i++)
        {
            if (ad == EsyaAdi[i])
            {
                bulunanIndeks = i;
                break;
            }
        }

        if (bulunanIndeks == -1)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n⚠️ UYARI: {ad} adlı eşya çantada yok.");
            Console.ResetColor();
            return;
        }

        for (int i = bulunanIndeks; i < EsyaAdi.Length - 1; i++)
        {
            EsyaAdi[i] = EsyaAdi[i + 1];
            Agirlik[i] = Agirlik[i + 1];
        }
        Array.Resize(ref EsyaAdi, EsyaAdi.Length - 1);
        Array.Resize(ref Agirlik, Agirlik.Length - 1);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n✅ {ad} adlı eşya başarıyla silindi.");
        Console.ResetColor();
    }

    /*
    Görev 4:
    EsyaListele() metodunu yazın.
    • Çantadaki tüm eşyaları ad + ağırlık şeklinde ekrana yazdırır
    • Eğer çanta boşsa uygun mesaj verilmelidir
    */
    static void EsyaListele()
    {
        if (EsyaAdi.Length == 0)
        {
            Console.WriteLine("\nÇantanız boş.");
            return;
        }

        Console.WriteLine("\nÇantanızdaki Eşyalar:");
        Console.WriteLine("----------------------");
        for (int i = 0; i < Agirlik.Length; i++)
        {
            Console.WriteLine($"{i + 1}. Eşya: {EsyaAdi[i]} \t------> Ağırlık: {Agirlik[i].ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }

    /*
    Görev 5:
    ToplamAgirlik() → int metodunu yazın.
    Listedeki her eşyanın ağırlığını toplayın
    • Sonucu döndürün
    Bu işlem döngü + toplama algoritmasıdır.
    */
    static double ToplamAgirlik()
    {
        double toplam = 0;

        for (int i = 0; i < Agirlik.Length; i++)
        {
            toplam += Agirlik[i];
        }
        return toplam;
    }

    /*
    Görev 6:
    EnAgirEsyaBul() metodunu yazın.
    • Listedeki en yüksek ağırlığa sahip eşyayı bulun
    • Adını ve ağırlığını döndürün veya ekrana yazdırın
    Bu klasik max bulma algoritmasıdır.
    */
    static void EnAgirEsyaBul()
    {
        if (Agirlik.Length == 0)
        {
            Console.WriteLine("\nÇanta boş, en ağır eşya yok.");
            return;
        }
        
        int enAgirIndeks = 0;
        for (int i = 1; i < Agirlik.Length; i++)
        {
            if (Agirlik[i] > Agirlik[enAgirIndeks])
            {
                enAgirIndeks = i;
            }
        }
        string esyaIsim = EsyaAdi[enAgirIndeks];
        double agirlik = Agirlik[enAgirIndeks];

        Console.WriteLine($"\nEn ağır eşya: {esyaIsim} \t------> Ağırlık: {agirlik.ToString("F2", CultureInfo.InvariantCulture)}");
    }

    /*
    Görev 7:
    EnHafifEsyaBul() metodunu yazın.
    • Listedeki en düşük ağırlığa sahip eşyayı bulun
    • Adını ve ağırlığını döndürün/ekrana yazdırın
    Bu klasik min bulma
    */
    static void EnHafifEsyaBul()
    {
        if (Agirlik.Length == 0)
        {
            Console.WriteLine("\nÇanta boş, en hafif eşya yok.");
            return;
        }
        
        int enHafifIndeks = 0;
        for (int i = 1; i < Agirlik.Length; i++)
        {
            if (Agirlik[i] < Agirlik[enHafifIndeks])
            {
                enHafifIndeks = i;
            }
        }
        string esyaIsim = EsyaAdi[enHafifIndeks];
        double agirlik = Agirlik[enHafifIndeks];

        Console.WriteLine($"\nEn hafif eşya: {esyaIsim} \t------> Ağırlık: {agirlik.ToString("F2", CultureInfo.InvariantCulture)}");
    }

    /*
    Görev 8:
    EsyaAra(string ad) → bool metodunu yazın.
    • Linear search kullanarak adı verilen eşyanın çantada olup olmadığını bulun
    • Bulursanız true, yoksa false döndürün
    */
    static bool EsyaAra(string ad)
    {
        for (int i = 0; i < EsyaAdi.Length; i++)
        {
            if (ad == EsyaAdi[i])
            {
                return true;
            }
        }
        return false;
    }

    /*
    Görev 9:
    Uygulamanın ana menüsünü yazın:
    1 - Eşya ekle
    2 - Eşya sil
    3 - Listele
    4 - Toplam ağırlık
    5 - En ağır eşya
    6 - En hafif eşya
    7 - Eşya ara
    */

    static void AnaMenu()
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("     EŞYA YÖNETİM SİSTEMİ         ");
        Console.WriteLine("===================================");
        Console.WriteLine("1 - Eşya ekle");
        Console.WriteLine("2 - Eşya sil");
        Console.WriteLine("3 - Listele");
        Console.WriteLine("4 - Toplam ağırlık");
        Console.WriteLine("5 - En ağır eşya");
        Console.WriteLine("6 - En hafif eşya");
        Console.WriteLine("7 - Eşya ara");
        Console.WriteLine("8 - Çıkış");
        Console.WriteLine("===================================");
    }
    
    static void Main(string[] args)
    {
        char secim;

        do
        {
            AnaMenu();

            Console.Write("\nBir seçim girin (1-8): ");
            secim = Console.ReadKey().KeyChar; 
            Console.WriteLine();

            switch (secim)
            {
                case '1':
                    Console.Write("\nEşyanın adını girin: ");
                    string esyaIsmi = Console.ReadLine() ?? "";

                    Console.Write("\nEşyanın ağırlığını girin (Örn: 2.5 veya 2,5): ");
                    string girilenAgirlik = Console.ReadLine() ?? "";
                    girilenAgirlik = girilenAgirlik.Replace(',', '.');

                    double agirlik;
                    
                    while (!double.TryParse(girilenAgirlik, NumberStyles.Any, CultureInfo.InvariantCulture, out agirlik) || agirlik <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n⚠️ HATA! Geçerli bir sayı girin (0'dan büyük olmalı):");
                        Console.ResetColor();
                        
                        Console.Write("\nAğırlık girin: ");
                        girilenAgirlik = Console.ReadLine() ?? "";
                        girilenAgirlik = girilenAgirlik.Replace(',', '.');
                    }
                    
                    EsyaEkle(esyaIsmi, agirlik);
                    break;

                case '2':
                    Console.Write("\nSilmek istediğiniz eşyanın adını girin: ");
                    string isimSilme = Console.ReadLine() ?? "";
                    EsyaSil(isimSilme);
                    break;

                case '3':
                    EsyaListele();
                    break;
                
                case '4':
                    double toplam = ToplamAgirlik();
                    Console.WriteLine($"\nToplam Ağırlık: {toplam.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                
                case '5':
                    EnAgirEsyaBul();
                    break;

                case '6':
                    EnHafifEsyaBul();
                    break;

                case '7':
                    Console.Write("\nAradığınız eşyanın adını girin: ");
                    string isimArama = Console.ReadLine() ?? "";
                    bool sonuc = EsyaAra(isimArama);
                    if(sonuc){
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n✅ Evet, çantada var.");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n❌ Hayır, çantada yok.");
                        Console.ResetColor();
                    }
                    break;

                case '8':
                    Console.WriteLine("\nÇıkış yaptınız. Güle güle! 👋\n");
                    break;

                default:
                    Console.WriteLine("\nGeçersiz seçim! Lütfen 1-8 arası bir sayı girin.");
                    break;
            }
            
            if (secim != '8')
            {
                Console.Write("\nDevam etmek için bir tuşa basın: ");
                Console.ReadKey();
            }
        } 
        while (secim != '8');
    }
}