using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Entities
{
    public class ArabaSinif
    {
        public int Id { get; set; }
        public string Sinif { get; set; }
        public decimal Fiyat { get; set; }


        public override string ToString()
        {
            return this.Sinif;
        }
    }

}
