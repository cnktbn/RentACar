using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Entities
{
   public class KiralamaDetay
    {

        public int Id { get; set; }
        public int MusteriId { get; set; }
        public int AracId { get; set; }
        public decimal ToplamFiyat { get; set; }
        public DateTime AlinanTarih { get; set; }
        public DateTime GetirilenTarih { get; set; }
        public int AlinanKm { get; set; }
        public int TeslimKm { get; set; }
        public int YapilanKm { get; set; }


    }
}
