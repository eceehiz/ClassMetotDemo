using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Müsteri müsteri1 = new Müsteri();
            müsteri1.TC = "1234";
            müsteri1.Ad = "Ahmet";
            müsteri1.Soyad = "Yıldırım";
            müsteri1.Yas = 25;

            Müsteri müsteri2 = new Müsteri();
            müsteri2.TC = "5678";
            müsteri2.Ad = "Mehmet";
            müsteri2.Soyad = "Kuyucu";
            müsteri2.Yas = 52;

            Müsteri müsteri3 = new Müsteri();
            müsteri3.TC = "6789";
            müsteri3.Ad = "Nazlı";
            müsteri3.Soyad = "Çelebi";
            müsteri3.Yas = 38;

            Müsteri[] Müsteriler = new Müsteri[]{müsteri1 , müsteri2 , müsteri3 };

            MüsteriManager müsteriManager = new MüsteriManager();
            müsteriManager.Ekle(müsteri1);
            müsteriManager.Sil(müsteri2);
            müsteriManager.Listele(müsteri3);












        }
    }
}
