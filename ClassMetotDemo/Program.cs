using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Said";
            musteri1.Toplambakiye = 1233;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Mehmet";
            musteri2.Soyadi = "Armağan";
            musteri2.Toplambakiye = 12213;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Ahmet";
            musteri3.Soyadi = "Armağan";
            musteri3.Toplambakiye = 1234534;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Adi = "Hasan";
            musteri4.Soyadi = "Yahya";
            musteri4.Toplambakiye = 12645345;

            Musteri musteri5 = new Musteri();
            musteri5.Id = 5;
            musteri5.Adi = "Muhammet";
            musteri5.Soyadi = "Seyda";
            musteri5.Toplambakiye = 1768763;

            Musteri[] musteris = new Musteri[] {musteri1, musteri2, musteri3,musteri4, musteri5};

            foreach (Musteri musteri in musteris)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Toplambakiye);
                Console.WriteLine("--------");
            }

            Console.WriteLine("-----------------------------------");
            MusteriManager musterimanager = new MusteriManager();

            musterimanager.Ekle(musteri1);
            musterimanager.Ekle(musteri2);
            musterimanager.Ekle(musteri3);
            musterimanager.Ekle(musteri4);
            musterimanager.Ekle(musteri5);

            Console.WriteLine("--------------------------------");
            musterimanager.List(musteri1);
            musterimanager.List(musteri2);
            musterimanager.List(musteri3);
            musterimanager.List(musteri4);
            musterimanager.List(musteri5);

            Console.WriteLine("--------------------");

            musterimanager.Delete(musteri3);




        }
    }
}
