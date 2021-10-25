using System;

namespace Kelime_Tahmin_Oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kelimeler = { "web", "mobil", "game", "software" };
            string secilenKelime;
            int hak = 5;
            int kullaniciPuani = 0;
            double puanKatsayisi = 1;
            double dusulucek = (15 / 100);
            int kazanilanPuan = 100;
            Random rnd = new Random();
            secilenKelime = kelimeler[rnd.Next(0, kelimeler.Length - 1)];
            char[] yerTutucu = new char[secilenKelime.Length];
            for (int i = 0; i < yerTutucu.Length; i++)
            {
                yerTutucu[i] = '*';
                Console.Write('*');
            }
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Kalan Kakkınız: {0}", hak);
                Console.WriteLine("Bir harf giriniz: ");
                char girilenHarf = Convert.ToChar(Console.ReadLine());

                bool hedef = false;
                int kalanHarf = 0;
                for (int i = 0; i < secilenKelime.Length; i++)
                {
                    if (secilenKelime[i] == girilenHarf)
                    {
                        yerTutucu[i] = girilenHarf;
                        hedef = true;
                        //kullaniciPuani = Convert.ToDouble(kazanilanPuan * puanKatsayisi);
                    }
                    if (yerTutucu[i] == '*')
                    {
                        kalanHarf++;
                    }
                    Console.Write(yerTutucu[i]);
                }
                Console.WriteLine();
                if (kalanHarf ==0)
                {
                    Console.WriteLine("Tebrikler bildiniz..");
                    break;
                }
                if (hedef==false)
                {
                    hak--;
                    
                    //puanKatsayisi = Convert.ToDouble(puanKatsayisi - dusulucek);
                }
                if (hak==0)
                {
                    Console.WriteLine("Kaybettiniz..");
                    break;
                }
                Console.WriteLine("-------------------------");
            }
            Console.WriteLine("Seçilen Kelime: {0}", secilenKelime);
            Console.WriteLine("Puanınız: {0}", kullaniciPuani);
        }
    }
}
