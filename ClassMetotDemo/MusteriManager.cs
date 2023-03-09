using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Name + " " + musteri.LastName + " isimli müşteri sisteme eklendi.");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Name + " " + musteri.LastName + " isimli müşteri sistemden silindi.");
        }

        public void HesapBakiyesi(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + musteri.Name + " " + musteri.LastName + " isimli müşterinin hesap bakiyesi " + musteri.AccountBalance + " TL dir.");
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Ad : " + musteri.Name);
            Console.WriteLine("Soyad : " + musteri.LastName);
            Console.WriteLine("Hesap Bakiyesi : " + musteri.AccountBalance);
            Console.WriteLine("________________________");

        }
    }
}
