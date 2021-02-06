﻿using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //SOLID
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = " Fatma";
            musteri1.Soyadi = "Uysal";
            musteri1.TcNo = "123456789";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 54321;
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "1234567890";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);
        }
    }
}
