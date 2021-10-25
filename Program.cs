using System;

namespace sayı_tahmin_etme
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Random rnd = new Random();
                int tutulanSayi = rnd.Next(0, 100);
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("Tahmin ettiğiniz sayıyı girin: ");
                    int girilenSayi = int.Parse(Console.ReadLine());
                    if (girilenSayi > tutulanSayi)
                    {
                        Console.WriteLine("sayıyı düşürün!!");
                    }
                    else if (girilenSayi < tutulanSayi)
                    {
                        Console.WriteLine("sayıyı yükseltin!!");
                    }
                    else if (girilenSayi == tutulanSayi)
                    {
                        Console.Clear();
                        Console.WriteLine("tebrikler bildiniz..");
                        Console.WriteLine("Devam etmek için E tuşuna basınız..");
                        
                        ConsoleKeyInfo info = Console.ReadKey();
                        if (info.Key != ConsoleKey.E)
                            break;
                      else
                        {
                            tutulanSayi = rnd.Next(0, 100);
                        }
                    }
                }
               

            } while (true);
        }
    }
}
