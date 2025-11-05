using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        • Kullanıcıdan önce N değerini alın.
        Ardından N x N boyutunda bir matris oluşturun. Ve elemanlarını -9 ile
        +9 arasında (dahil) rastgele oluşturun.

        • Matrisi ekrana yazdırın.
        
        • Bu matrise bakarak aşağıdaki görevleri yerine getirin:
        
        • Asal köşegen üzerindeki sayıların toplamını bulun.
        
        • Yardımcı köşegen üzerindeki sayıların çarpımını bulun.
        
        • Matrisin içinde kaç adet negatif sayı olduğunu sayın.
        
        • Matrisin içinde en sık tekrar eden sayıyı bulun.
        
        • Eğer eşitlik varsa en küçük olanı seçin.
        
        • Matris içindeki asal sayıların ortalamasını hesaplayın.
        
        • Asal yoksa: "Asal sayı yok." yazın.
        
        • Son olarak matrisi saat yönünde 90 derece döndürün ve yeni halini
        ekrana yazdırın.
        */

        Console.Write("\n\nBir N değeri girin: ");
        int N = Convert.ToInt32(Console.ReadLine());

        int[,] matris = new int[N, N];

        Random rastgele = new Random();

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matris[i, j] = rastgele.Next(-9, 10);
            }
        }
        Console.WriteLine("\n------- Oluşturulan Matris --------\n");

        for (int i = 0; i < N; i++)
        {
            Console.Write("[");

            for (int j = 0; j < N; j++)
            {
                Console.Write($"{matris[i, j],3}");

                if (j < N - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }
        Console.WriteLine();

        Console.WriteLine("-----------------------------------\n\n");

        int ana_kosegen_toplami = 0;

        for (int i = 0; i < N; i++)
        {
            ana_kosegen_toplami += matris[i, i];
        }

        Console.WriteLine($"Ana köşegen toplamı: {ana_kosegen_toplami}");

        int yardimci_kosegen_carpimi = 1;

        for (int i = 0; i < N; i++)
        {
            int j = N - 1 - i;
            yardimci_kosegen_carpimi *= matris[i, j];
        }

        Console.WriteLine($"\nYardımcı köşegen çarpımı: {yardimci_kosegen_carpimi}");

        int negatif_sayi_adedi = 0;

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (matris[i, j] < 0)
                {
                    negatif_sayi_adedi++;
                }
            }
        }

        Console.WriteLine($"\nNegatif sayı adedi: {negatif_sayi_adedi}");

        // En sık tekrar eden sayıyı bul.
        int en_sik_sayi = matris[0, 0];
        int en_cok_tekrar = 0;

        // -9 ile +9 arası tüm sayıları kontrol et.
        for (int sayi = -9; sayi <= 9; sayi++)
        {
            int tekrar_sayisi = 0;

            // Bu sayıdan kaç tane var?
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matris[i, j] == sayi)
                    {
                        tekrar_sayisi++;
                    }
                }
            }

            // Daha fazla mı tekrar bulduk?
            if (tekrar_sayisi > en_cok_tekrar)
            {
                en_cok_tekrar = tekrar_sayisi;
                en_sik_sayi = sayi;
            }
            //Aynı tekrarda ama daha küçük sayı mı?
            else if (tekrar_sayisi == en_cok_tekrar && sayi < en_sik_sayi)
            {
                en_sik_sayi = sayi;
            }
        }

        Console.WriteLine($"\nEn sık tekrar eden sayı: {en_sik_sayi}, ({en_cok_tekrar} kez tekrar edildi.)");

        // Asal sayıların ortalamasını bul.
        int asal_toplam = 0;
        int asal_adet = 0;

        // -9 ile +9 arasında sadece bu asal sayılar var: 2, 3, 5, 7.
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                int sayi = matris[i, j];

                // Asal sayı kontrolü.
                if (sayi == 2 || sayi == 3 || sayi == 5 || sayi == 7)
                {
                    asal_toplam += sayi;
                    asal_adet++;
                }
            }
        }

        if (asal_adet > 0)
        {
            double asal_ortalama = (double)asal_toplam / asal_adet;
            Console.WriteLine($"\nAsal sayıların ortalaması: {asal_ortalama}");
        }
        else
        {
            Console.WriteLine("Asal sayı yok.");
        }

        // Matrisi 90° saat yönünde döndür.
        Console.WriteLine("\n---------- Saat Yönünde 90° Döndürülmüş Matris ----------\n");

        for (int j = 0; j < N; j++) // Sütunları gez.
        {
            Console.Write("[");
            for (int i = N - 1; i >= 0; i--) // Satırları tersten gez.
            {
                Console.Write($"{matris[i, j],3}");

                if (i > 0)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
        }
        Console.WriteLine();
    }
}
