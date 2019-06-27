using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.Entities
{
    public class Araba
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int ModelYili { get; set; }
        public string Plaka { get; set; }
        public bool ManuelMi { get; set; }
        public int SinifId { get; set; }
        public bool KiradaMi { get; set; }
        public int Km { get; set; }

    }
}
