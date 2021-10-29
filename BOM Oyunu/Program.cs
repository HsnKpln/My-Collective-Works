using System;

namespace BOM_Oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            int bomSayisi, sinir = 100;
            do
            {
                do
                {
                    try
                    {
                        Console.WriteLine("Lütfen bir BOM sayısı belirleyin..");
                        bomSayisi = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Belirlenen BOM sayısı: {0}", bomSayisi);
                        if (bomSayisi < 1 || bomSayisi > 50)
                            throw new Exception("1 - 50 arası bir sayı girmediniz");
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("lütfen bir sayı giriniz..");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                } while (true);
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 2 == 1)
                    {
                        if (i % bomSayisi == 0)
                        {
                            Console.WriteLine("BOM");
                        }
                        else
                        {
                            Console.WriteLine("Bilgisayarın girdiği sayı: {0}", i);
                        }
                    }
                    else
                    {
                        Console.WriteLine("sıradaki sayıyı giriniz..");
                        string girilenText = Console.ReadLine().ToUpper();
                        if (i % bomSayisi == 0)
                        {
                            //string text = Console.ReadLine().ToUpper();
                            //string text = Convert.ToString(Console.ReadLine().ToUpper());
                            if (girilenText != "BOM")
                            {
                                Console.WriteLine("Kaybettiniz..");
                                break;
                            }


                        }
                        else
                        {
                            try
                            {
                                int girilenSayi = int.Parse(girilenText);
                                if (girilenSayi != i)
                                {
                                    Console.WriteLine("kaybettiniz..");
                                    break;
                                }
                            }
                            catch 
                            {
                                Console.WriteLine("Yanlıs bir giriş yaptınız!");
                                Console.WriteLine("kaybettiniz..");
                                break;
                            }
                        }
                    }
                    if(i ==sinir)
                    Console.WriteLine("Tebrikler Oyun Berabere..");
                }
                Console.WriteLine("Tekrar Oynamak için E tuşuna basınız..");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key != ConsoleKey.E)
                    break;
            } while (true);
            
        }
    }
}
