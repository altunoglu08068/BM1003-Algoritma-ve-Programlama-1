using System;

class Program
{
    static void Main(string[] args)
    {
        // Klavyeden girilen gün adına göre haftanın kaçıncı günü olduğunu bulan programı yazınız.

        Console.Write("\nGün adını girin: ");
        string gun = (Console.ReadLine() ?? "").ToLower();

        Console.WriteLine("\n----- SONUÇ -----\n");

        switch (gun)
        {
            case "pazartesi":
                Console.WriteLine($"{gun}, haftanın 1. günüdür.\n");
                break;
            case "salı":
                Console.WriteLine($"{gun}, haftanın 2. günüdür.\n");
                break;
            case "çarşamba":
                Console.WriteLine($"{gun}, haftanın 3. günüdür.\n");
                break;
            case "perşembe":
                Console.WriteLine($"{gun}, haftanın 4. günüdür.\n");
                break;
            case "cuma":
                Console.WriteLine($"{gun}, haftanın 5. günüdür.\n");
                break;
            case "cumartesi":
                Console.WriteLine($"{gun}, haftanın 6. günüdür.\n");
                break;
            case "pazar":
                Console.WriteLine($"{gun}, haftanın 7. günüdür.\n");
                break;
            default:
                Console.WriteLine("Lütfen, bir gün ismi girin.\n");
                break;
        }
    }
}
