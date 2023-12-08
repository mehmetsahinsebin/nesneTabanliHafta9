using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesneTabanliHafta9
{
    class Araba
    {
        public string marka; // her yerden ulaşılabilmesi için public eklenir
        public string model;
        public int yil;
        public int gunlukUcret;
        public bool kiradaMi;

        public Araba(string Marka, string Model, int Yil,int GunlukUcret,bool KiradaMi)
        {
            this.marka = Marka;
            this.model = Model;
            this.yil = Yil;
            this.gunlukUcret = GunlukUcret;
            this.kiradaMi = KiradaMi;


        }
    }
}
