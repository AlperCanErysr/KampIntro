using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Bilgisayar";
            double urunFiyati = 25.750;
            string urunAciklamasi = "İş Bilgisayarı";

            Urun urun1 = new Urun();
            urun1.Adi = "Bilgisayar";
            urun1.Fiyati = 25.750;
            urun1.Aciklama = "İş Bilgisayarı";

            Urun urun2 = new Urun();
            urun2.Adi = "Telefon";
            urun2.Fiyati = 17.890;
            urun2.Aciklama = "Cep Telefonu";

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (var item in urunler)
            {
                Console.WriteLine(item.Adi);
                Console.WriteLine(item.Fiyati);
                Console.WriteLine(item.Aciklama);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("------------METOTLAR------------");
            Console.WriteLine();

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("elma","kırmızı elma",12,50);
            sepetManager.Ekle2("armut", "yeşil armut", 24,100);
            sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 36,150);
        }
    }
}
