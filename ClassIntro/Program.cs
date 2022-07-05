using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursEgitmeni = "Alpercan Eryasar";
            kurs1.IzlenmeOrani = 100;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursEgitmeni = "Berk Baypınar";
            kurs2.IzlenmeOrani = 75;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursEgitmeni = "Tamer Özvatan";
            kurs3.IzlenmeOrani = 50;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.KursEgitmeni = "Emir Açıkgöz";
            kurs4.IzlenmeOrani = 25;

            //  Console.WriteLine(kurs1.KursEgitmeni + " : " + kurs1.KursAdi);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.KursEgitmeni);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }

}
