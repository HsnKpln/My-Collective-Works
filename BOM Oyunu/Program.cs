using System;

namespace BOM_Oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir BOM sayısı belirleyin..");
            int bomSayisi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Belirlenen BOM sayısı: {0}", bomSayisi);
            for (int i = 1; i < 101; i++)
            {
                if (i%2 == 1)
                {
                    if (i%bomSayisi == 0)
                    {
                        Console.WriteLine("BOM");
                    }
                    else
                    {
                         Console.WriteLine("Bilgisayarın girdiği sayı: {0}",i);
                    }
                }
                else
                {
                    Console.WriteLine("sıradaki sayıyı giriniz..");
                    int girilenSayi = Convert.ToInt32(Console.ReadLine());
                    if (i%bomSayisi == 0)
                    {
                        string text = Console.ReadLine().ToUpper();
                        if (text != "BOM")
                        {
                            Console.WriteLine("Kaybettiniz..");
                            break;
                        }
                       
                       
                    }
                    else
                    {
                        if (girilenSayi !=i)
                        {
                            Console.WriteLine("kaybettiniz..");
                            break;
                        }
                    }
                }
            }
        }
    }
}
