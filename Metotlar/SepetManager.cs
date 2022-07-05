using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun eklenenUrun)
        {
            Console.WriteLine("TEBRİKLER SEPETE EKLENDİ : " + eklenenUrun.Adi);
        }
        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("TEBRİKLER SEPETE EKLENDİ : " + urunAdi);
        }
    }
}
