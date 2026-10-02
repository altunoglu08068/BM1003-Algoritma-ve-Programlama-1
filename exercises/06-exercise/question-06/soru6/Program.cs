using System;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan alınan string'in tersini yazdıran bir program kodlayınız.

        Console.Write("\n\nBir ifade giriniz: ");
        string ifade = (Console.ReadLine() ?? "").ToUpper();

        Console.WriteLine("\n------ SONUÇ ------\n");

        Console.WriteLine($"Girdiğiniz ifade: {ifade}\n");

        char[] karakterler = ifade.ToCharArray();
        Array.Reverse(karakterler);
        string ters_ifade = new string(karakterler);

        Console.WriteLine($"İfadenin tersi: {ters_ifade}\n");
    }
}
