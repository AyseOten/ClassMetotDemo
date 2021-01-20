using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine( musteri.Name + " " + musteri.Surname + " Eklendi");
        }
        public void MusteriSil(int AccountNum)
        {
            Console.WriteLine(AccountNum + " " + "no lu hesap silindi.");
        }
        public void MusteriListele(Musteri[] musteris)
        {
            foreach (Musteri musteri in musteris)
            {
                Console.WriteLine("---------Musteriler-------------");
                Console.WriteLine(musteri.Name);
                Console.WriteLine(musteri.Surname);
                Console.WriteLine(musteri.AccountNumber);
                Console.WriteLine("----------------------");
            }
        }
    }
}
