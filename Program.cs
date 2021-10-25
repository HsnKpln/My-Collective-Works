using System;

namespace Zar__Oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-6 arası bir sayı girin : ");
            int girilenSayi = int.Parse(Console.ReadLine());
            int sayi = 1;
            Random rnd1 = new Random();
            Random rnd2 = new Random();
            while (true)
            {
                int zar1 = rnd1.Next(1, 7);
                int zar2 = rnd2.Next(1, 7);
                if (zar1 == girilenSayi && zar2 == girilenSayi)
                {
                    Console.WriteLine("Atılan zar sayısı: {0}",sayi);
                    break;
                }
                sayi++;
            }
        }
    }
}
