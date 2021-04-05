using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();
            Musteri musteri1 = new Musteri();
            musteri1.MusteriID = 1;
            musteri1.Isim = "Ataberk";
            musteri1.Soyisim = "Kasap";

            musteriManager.MusteriEkle(musteri1);
        }
    }
}
