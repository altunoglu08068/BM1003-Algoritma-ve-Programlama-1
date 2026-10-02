using System;

class Program
{
    static void Main(string[] args)
    {
        

        Console.WriteLine("\n\n---------- ATM'ye Hoşgeldiniz! ----------\n");

        int bakiye = 0;
        
        while (true)
        {
            Console.WriteLine("\n--------------------------------\n");
            Console.WriteLine("\nPara yatırmak için (1)'i,");
            Console.WriteLine("\nPara çekmek için (2)'yi,");
            Console.WriteLine("\nBakiyeyi görüntülemek için (3)'ü,");
            Console.WriteLine("\nÇıkış için (4)'e basınız.");
            Console.Write("\n\nSeçiminiz: ");

            int yatirma; 
            int cekme;

            char giris = Console.ReadKey().KeyChar;
            
            Console.WriteLine(); 
            Console.WriteLine(); 

            switch (giris)
            {
                case '1':
                    Console.Write("Ne kadar para yatırmak istediğinizi girin: ");
                    yatirma = Convert.ToInt32(Console.ReadLine());
                    bakiye += yatirma;
                    Console.WriteLine($"\n✅ İşlem Başarılı. Güncel bakiye: {bakiye} TL");
                    break;

                case '2':
                    Console.Write("Ne kadar para çekmek istediğinizi girin: ");
                    cekme = Convert.ToInt32(Console.ReadLine());

                    if (bakiye < cekme)
                    {
                        Console.WriteLine("\n❌ Yetersiz bakiye! İşlem yapılamadı.");
                    }
                    else
                    {
                        bakiye -= cekme;
                        Console.WriteLine($"\n✅ Para çekildi. Güncel bakiye: {bakiye} TL");
                    }
                    break;

                case '3':
                    Console.WriteLine($"💰 Şu anki bakiyeniz: {bakiye} TL");
                    break;

                case '4':
                    Console.WriteLine("Çıkış yaptınız. İyi günler!\n");
                    return;

                default:
                    Console.WriteLine("⚠️ Hatalı tuşlama! Lütfen tekrar deneyin.");
                    break;
            }
        }
    }
}