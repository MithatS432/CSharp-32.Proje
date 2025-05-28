using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_ve_Struct2
{
    internal class Program
    {
        // Enum: Departman Tanımları
        enum Departman
        {
            Yazilim,
            Muhasebe,
            InsanKaynaklari,
            Pazarlama
        }

        // Struct: Personel Bilgileri
        struct Personel
        {
            public int ID;
            public string AdSoyad;
            public Departman Departman;

            public void BilgiYazdir()
            {
                Console.WriteLine($"ID: {ID}, Ad: {AdSoyad}, Departman: {Departman}");
            }
        }
        static void Main(string[] args)
        {
            Personel p1 = new Personel();
            p1.ID = 1;
            p1.AdSoyad = "Zeynep Kaya";
            p1.Departman = Departman.Yazilim;

            Personel p2 = new Personel
            {
                ID = 2,
                AdSoyad = "Mehmet Demir",
                Departman = Departman.Muhasebe
            };

            p1.BilgiYazdir();
            p2.BilgiYazdir();
        }
    }
}
