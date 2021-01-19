using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 012;
            musteri1.Adi = "Nuran";
            musteri1.Soyadi = "Özcan";
            musteri1.Yas = 50;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 013;
            musteri2.Adi = "Vefa";
            musteri2.Soyadi = "Erden";
            musteri2.Yas = 38;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 014;
            musteri3.Adi = "Ayşe";
            musteri3.Soyadi = "Çelik";
            musteri3.Yas = 72;

            Musteri[] musteris = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteris)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Yas);
                Console.WriteLine("-------------------");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.AddMusteri(musteri1); 
            musteriManager.AddMusteri(musteri2);

            musteriManager.RemoveMusteri(musteri2);
            musteriManager.RemoveMusteri(musteri3);

            


        }





    }
    }

