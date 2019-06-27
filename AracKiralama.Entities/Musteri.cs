using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Entities
{
   public class Musteri
    {

        public int Id { get; set; }
        public string TCKno { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Sehir { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public string KimlikFotokopi { get; set; }

    }
}
