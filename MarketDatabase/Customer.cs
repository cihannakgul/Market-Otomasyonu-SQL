using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketDatabase
{
    class Customer
    {
        public int siparisID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string ilAdi { get; set; }
        public string acikAdres { get; set; }
        public string siparisEdilenUrun { get; set; }
        public string marka { get; set; }
        public float fiyat { get; set; }
        public string durum { get; set; }
        public string kargoSirketi { get; set; }  
    }
}
