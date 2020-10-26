using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÇokŞekillilikÖrnek
{
    class Ekmek:Ürün
    {
        public string EkmekTuru { get; set; }
        public int Gramaj { get; set; }

        public override double KdvUygula()
        {
            return Fiyat + Fiyat * 0.1;
        }

        public Ekmek(string ad,double fiyat,string tur,int gram)
        {
            UrunAdi = ad;
            Fiyat = fiyat;
            EkmekTuru = tur;
            Gramaj = gram;
        }
    }
}
