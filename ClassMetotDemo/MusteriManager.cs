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
    }
}
