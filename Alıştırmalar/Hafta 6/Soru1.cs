using System;

class Program
{
    static void Main(string[] args)
    {

        // Kullanıcıdan yolcu isimleri ve koltuk numaralarını alan ve bunların yerlerini değiştiren bir program yazınız.

        Console.Write("\n1. yolcunun adını giriniz: ");
        string isim1 = Console.ReadLine() ?? "";

        Console.Write("Koltuk numarasını giriniz: ");
        int koltuk1 = Convert.ToInt32(Console.ReadLine());


        Console.Write("\n2. yolcunun adını giriniz: ");
        string isim2 = Console.ReadLine() ?? "";

        Console.Write("Koltuk numarasını giriniz: ");
        int koltuk2 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("\n\n---- DEĞİŞİMDEN ÖNCE ----");

        Console.WriteLine($"İsim: {isim1}, Koltuk No: {koltuk1}");
        Console.WriteLine($"İsim: {isim2}, Koltuk No: {koltuk2}");

        
        Console.WriteLine("\n---- DEĞİŞİMDEN SONRA ----");

        int gecici = koltuk1;
        koltuk1 = koltuk2;
        koltuk2 = gecici;

        Console.WriteLine($"İsim: {isim1}, Koltuk No: {koltuk1}");
        Console.WriteLine($"İsim: {isim2}, Koltuk No: {koltuk2}\n");
    }
}
