using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Isim + " isimli müşteri listeye eklendi.");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Isim + " isimli müşteri listeden silindi");
        }

        public void MusterileriGetir(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriID + ": " + musteri.Isim + " " + musteri.Soyisim);
            }
        }
    }
}
