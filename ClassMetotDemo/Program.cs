using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Name = "Ayse";
            musteri1.Surname = "Sevde";
            musteri1.AccountNumber = 2821;

            Musteri musteri2 = new Musteri();
            musteri2.Name = "Hüseyin";
            musteri2.Surname = "Fatih";
            musteri2.AccountNumber = 2930;

            Musteri musteri3 = new Musteri();
            musteri3.Name = "Omer";
            musteri3.Surname = "Tarik";
            musteri3.AccountNumber = 1602;

            Musteri[] Musteriler = new Musteri[] { musteri1};

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.MusteriEkle(musteri2);
            musterimanager.MusteriEkle(musteri3);

            musterimanager.MusteriSil(1602);
            musterimanager.MusteriListele(Musteriler);

        }
    }
}
