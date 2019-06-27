using AracKiralama.DAL;
using AracKiralama.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.BAL
{
    public class ArabaController
    {
        ArabaManagement am = new ArabaManagement();
        public List<Araba>GetArabalar()
        {
            List<Araba> arabalar = new List<Araba>();
            arabalar = am.GetirArabalar();

            List<Araba> filtreliArabalar = new List<Araba>();
            foreach (Araba araba in arabalar)
            {
                if (araba.KiradaMi==false)
                {
                    filtreliArabalar.Add(araba);
                }
            }

            return filtreliArabalar;
            
        }

        public List<Resim> GetResimler()
        {
            List<Resim> resimler = new List<Resim>();
            resimler = am.GetirResimler();
            return resimler;

        }

        public List<ArabaSinif> GetArabaSinif()
        {
            List<ArabaSinif> arabaSiniflari = new List<ArabaSinif>();
            arabaSiniflari = am.GetirArabasiniflari();
            return arabaSiniflari;
        }
        
        public bool GetArabaDurum(KiralamaDetay kiralamaDetay, bool kiradaMi)
        {
            bool cevap;

            cevap=am.ArabaGetirilmeDurum(kiralamaDetay,kiradaMi);
            return cevap;
        }

    }
}
