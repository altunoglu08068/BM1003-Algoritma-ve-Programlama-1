using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Kullanıcıdan yıl bilgisini alıp, o yılın artık yıl olup olmadığını bulan programı yazınız.
        Kural: Yıl 4’e tam bölünüyorsa artık yıldır.
        */

        Console.Write("\n\nHangi yılda olduğunuzu girin: ");
        int yil = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n------ SONUÇ ------");

        if (yil % 4 == 0)
        {
            Console.WriteLine($"\nBulunduğunuz {yil} yılı, bir artık yıldır.\n");
        }
        else
        {
            Console.WriteLine($"\nBulunduğunuz {yil} yılı, artık yıl değildir.\n");
        }
    }
}
