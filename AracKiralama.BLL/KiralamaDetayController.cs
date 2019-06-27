using AracKiralama.DAL;
using AracKiralama.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.BAL
{
    class KiralamaDetayController
    {
        KiralamaDetayManagement kdm = new KiralamaDetayManagement();

        public List<KiralamaDetay>GetKiralamaDetaylar()
        {
            List<KiralamaDetay> kiralamalar = new List<KiralamaDetay>();
            kiralamalar = kdm.GetirKiralamaDetay();
            return kiralamalar;
        }

        public bool InsertKiralamaDetay(KiralamaDetay kiralamaDetay)
        {
            bool cevap;
            cevap = kdm.EkleKiralamaDetay(kiralamaDetay);
            return cevap;
        }
        public bool UpdateTeslimGuncelle(KiralamaDetay kiralamaDetay)
        {
            bool cevap;
            cevap = kdm.TeslimKmGuncelle(kiralamaDetay);
            return cevap;
        }

    }
}
