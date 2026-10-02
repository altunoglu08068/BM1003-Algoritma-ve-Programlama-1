using System;

class Program
{
    static void Main(string[] args)
    {
        int ay;

        while (true) // sonsuza kadar döner, doğru girişte break ile çıkarız.
        {
            Console.Write("\nHangi ayda olduğunuzu girin (1-12): ");
            ay = Convert.ToInt32(Console.ReadLine());

            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış ayındasınız.");
                    return; // programı bitir.

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahar ayındasınız.");
                    return;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz ayındasınız.");
                    return;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar ayındasınız.");
                    return;

                default:
                    Console.WriteLine("⚠️ 1 ile 12 arasında bir sayı girmelisiniz! Tekrar deneyin.\n");
                    break; // tekrar sorulacak.
            }
        }
    }
}
