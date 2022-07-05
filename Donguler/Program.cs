using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Yazılımın Temelleri";
            string kurs3 = "C#";
            string kurs4 = "Python";
            string kurs5 = "C++";

            string[] kurslar = new string[] {kurs1,kurs2,kurs3,kurs4,kurs5};

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("---------------------------------");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.ReadKey();
        }
    }
}
