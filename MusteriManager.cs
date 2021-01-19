using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void AddMusteri(Musteri musteri) 
        {
            Console.WriteLine("Talebiniz başarıyla alındı. Müşteri eklendi." + "ID:" + musteri.Id + " " + musteri.Adi + " " + musteri.Soyadi + "Yaş:" + musteri.Yas);
        }

        public void RemoveMusteri(Musteri musteri) 
        {
            Console.WriteLine(musteri.Id + " Id numaralı:" + " " + musteri.Adi + " " + musteri.Soyadi + " (İsimli müşterinin kaydı sistemden başarıyla silindi.)" );
        }

        public void UpdateMusteri(Musteri[] musteriler, Musteri musteri) 
        {
            bool updateCondition = false;
            for (int i = 0; i < musteriler.Length; i++)
            {
                if (musteriler[i].Id == musteri.Id) ;
                {
                    musteriler[i] = musteri;
                    updateCondition = true;

                }

                if (updateCondition)
                {
                    Console.WriteLine(musteri.Id.ToString() + " ID Numaralı Müşteri Bilgisi Güncellendi.");
                }
                else
                {
                    Console.WriteLine(musteri.Id.ToString() + " ID Numaralı Müşteri Bilgisi Bulunamadı.");
                }

            }
        }

        public void MusteriListele(Musteri[] musteriler) 
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("ID:" + musteri.Id + " " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.Yas);
            }
        }

        
        
    }
}
