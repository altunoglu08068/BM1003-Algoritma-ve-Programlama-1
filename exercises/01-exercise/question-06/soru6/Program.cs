using System;

class Program
{
    static void Main(string[] args)
    {
        /* Sıcaklığı santigrat cinsinden okumak ve aşağıdaki sıcaklık durumuna göre uygun bir mesaj
           görüntülemek için programı yazın:

           Sıcaklık < 0, ardından Dondurucu hava
           Sıcaklık 0-10, ardından Çok Soğuk hava
           Sıcaklık 10-20, ardından Soğuk hava
           Sıcaklık 20-30 ve ardından Normal Sıcaklık
           Sıcaklık 30-40 sonra Sıcak
           Sıcaklığı >=40 sonra Çok Sıcak
        */

        Console.Write("\n\nŞu an hava kaç °C: ");
        int sicaklik = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n----- SONUÇ -----");

        if (sicaklik < 0)
        {
            Console.WriteLine("\nŞu an hava dondurucu şekilde soğuk.\n");
        }
        else if (sicaklik >= 0 && sicaklik < 10)
        {
            Console.WriteLine("\nŞu an hava çok soğuk.\n");
        }
        else if (sicaklik >= 10 && sicaklik < 20)
        {
            Console.WriteLine("\nŞu an hava soğuk.\n");
        }
        else if (sicaklik >= 20 && sicaklik < 30)
        {
            Console.WriteLine("\nŞu an hava sıcaklığı normal.\n");
        }
        else if (sicaklik >= 30 && sicaklik < 40)
        {
            Console.WriteLine("\nŞu an hava sıcak\n");
        }
        else if (sicaklik >= 40)
        {
            Console.WriteLine("\nHava şu an çok sıcak\n");
        }
    }
}
