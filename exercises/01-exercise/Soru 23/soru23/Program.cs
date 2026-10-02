using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Bir çalışanın saatlik ücreti 200 TL. Kullanıcının girdiği çalışma saatine göre maaşı
        hesaplayınız. Eğer çalışma saati 40’tan fazlaysa fazla çalışılan her saat için %50 zamlı
        ödeme yapılacaktır.
        */

        Console.Write("\n\nÇalışanın kaç saat çalıştığını girin: ");
        int calisma_saati = Convert.ToInt32(Console.ReadLine());

        const int saatlik_ucret = 200;
        double maas;

        if (calisma_saati <= 40)
        {
            maas = calisma_saati * saatlik_ucret;
        }
        else
        {
            int normal_saat = 40;
            int fazla_saat = calisma_saati - normal_saat;
            double fazla_mesai_ucreti = fazla_saat * saatlik_ucret * 1.5;
            double normal_maas = normal_saat * saatlik_ucret;

            maas = normal_maas + fazla_mesai_ucreti;
        }
        Console.WriteLine($"\nÇalışanın maaşı: {maas} TL\n");
    }
}
