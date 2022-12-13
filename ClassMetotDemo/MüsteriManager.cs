using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MüsteriManager
    {
        public void Ekle(Müsteri müsteri)
        {

            Console.WriteLine("Müsteri Eklendi:" + " " + müsteri.Ad + " " + müsteri.Soyad);
        }
        public void Sil(Müsteri müsteri)
        {

            Console.WriteLine("Şu TC Kimlik Nolu Müsteri Silindi:" + " " + müsteri.TC);
        }
        public void Listele(Müsteri müsteri)
        {

            Console.WriteLine("Müsteri Yaşı:" + " " + müsteri.Yas);
        }
    }
}
