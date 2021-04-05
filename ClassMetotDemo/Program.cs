using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            usteriManager musteriManager = new MusteriManager();
            Musteri musteri1 = new Musteri();
            musteri1.MusteriID = 1;
            musteri1.Isim = "Ataberk";
            musteri1.Soyisim = "Kasap";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriID = 2;
            musteri2.Isim = "Mehmet";
            musteri2.Soyisim = "Kardelen";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriSil(musteri2);

            musteriManager.MusterileriGetir(musteriler);
        }
    }
}
