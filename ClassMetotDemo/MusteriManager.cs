using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi +  " " + musteri.Soyadi + " isim ve soyimli müşteri eklendi.");
        }
        public void List(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + ". Müşteri");
            Console.WriteLine(musteri.Adi);
            Console.WriteLine(musteri.Soyadi);
            Console.WriteLine(musteri.Toplambakiye);
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + "müşteri silindi");
        }
    }
}
