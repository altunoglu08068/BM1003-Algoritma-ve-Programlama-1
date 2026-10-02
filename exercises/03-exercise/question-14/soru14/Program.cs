/*
Bir tam sayı dizisinde yan yana olan iki 5'in sayısını sayan bir C# programı yazın.
Örnek Giriş :
{ 5, 5, 2 }
{ 5, 5, 2, 5, 5 }
{ 5, 6, 2, 9}
Beklenen Çıkış :
1
2
0
*/

using System;

namespace Program
{
    internal class ProgramClass
    {
        static int Sayac(int[] x)
        {
            int sayac = 0;

            for (int i = 0; i < x.Length - 1; i++)
            {
                if (x[i] == 5 && x[i + 1] == 5)
                {
                    sayac++;
                }
            }

            return sayac;
        }
        static void Main(string[] args)
        {
            Console.Clear();

            int[] dizi1 = { 5, 5, 2 };
            int[] dizi2 = { 5, 5, 2, 5, 5 };
            int[] dizi3 = { 5, 6, 2, 9 };

            int sonuc1 = Sayac(dizi1);
            Console.WriteLine($"\nSayaç 1: {sonuc1}");

            int sonuc2 = Sayac(dizi2);
            Console.WriteLine($"\nSayaç 2: {sonuc2}");

            int sonuc3 = Sayac(dizi3);
            Console.WriteLine($"\nSayaç 3: {sonuc3}\n");
        }
    }
}
