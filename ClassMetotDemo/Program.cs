using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 101;
            musteri1.Name = "Mehmet Akif";
            musteri1.LastName = "Albayrak";
            musteri1.AccountBalance = 20000;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 102;
            musteri2.Name = "Mesut Ali";
            musteri2.LastName = "Albayrak";
            musteri2.AccountBalance = 25000;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 103;
            musteri3.Name = "Ahmet Enes";
            musteri3.LastName = "Albayrak";
            musteri3.AccountBalance = 30000;

        }


    }
}
