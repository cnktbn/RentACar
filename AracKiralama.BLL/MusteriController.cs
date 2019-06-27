using AracKiralama.DAL;
using AracKiralama.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.BAL
{
    public class MusteriController
    {
        MusteriManagement mm = new MusteriManagement();
        public List<Musteri> GetMusteriler()
        {
            List<Musteri> musteriler = new List<Musteri>();
            musteriler = mm.GetirMusteriler();
            return musteriler;

        }

        public bool InsertMusteri(Musteri musteri)
        {
            bool cevap;
            cevap = mm.EkleMusteri(musteri);
            return cevap;
        }

        public bool UpdateMusteri(Musteri musteri)
        {
            bool cevap;
            cevap = mm.GuncelleMusteri(musteri);
            return cevap;
        }

       
    }
}
