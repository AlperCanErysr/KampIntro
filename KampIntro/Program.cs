using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string karegoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapildiMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarBugun>dolarDun)
            {
                Console.WriteLine("DOLAR ARTTI");
            }
            else
            {
                Console.WriteLine("DOLARDA BİR ARTIŞ YOK");
            }

            if (sistemeGirisYapildiMi==true)
            {
                Console.WriteLine("KULLANICI SİSTEME GİRDİ");
            }
            else
            {
                Console.WriteLine("KULLANICI SİSTEME GİRMEDİ");
            }

            Console.ReadKey();
        }
    }
}
