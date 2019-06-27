using AracKiralama.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.DAL
{

    public class ArabaManagement
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;
        public ArabaManagement()
        {

            //Configuration manager kullanıcaksak  açtıgımızprojenin dosyalarındaki app.configinde içine connection string yazmamız gerekiyor.
            //conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AracKiralamaDBconn"].ConnectionString);
            conn = new SqlConnection("server=.;database=arackiralamadb;integrated security=true;");

        }

        public List<Araba> GetirArabalar()
        {
            List<Araba> arabalar = new List<Araba>();
            cmd = new SqlCommand("select id,Marka,model,ModelYili,Plaka,ManuelMi,SinifID,km,kiradami from Arabalar",conn);

            try
            {
                if (conn.State!=System.Data.ConnectionState.Open)
                {
                    conn.Open();

                }
                 rdr = cmd.ExecuteReader();
                 if (rdr.HasRows)
                 {
                    Araba arb;
                     while (rdr.Read())
                     {
                        arb = new Araba();
                        arb.Id = Convert.ToInt32(rdr["id"]);
                         arb.Marka = rdr["marka"].ToString();
                         arb.Model = rdr["model"].ToString();
                         arb.ModelYili = Convert.ToInt32(rdr["modelyili"]);
                         arb.Plaka = rdr["plaka"].ToString();
                         arb.ManuelMi = Convert.ToBoolean(rdr["manuelmi"]);
                         arb.SinifId = Convert.ToInt32(rdr["sinifid"]);
                         arb.KiradaMi = Convert.ToBoolean(rdr["kiradami"]);
                        arb.Km = Convert.ToInt32(rdr["km"]);
                        arabalar.Add(arb);
                     }

                 }
            
            }
            catch (Exception)
            {
               

            }
            finally
            {
                rdr.Close();
                conn.Close();
            }
           
            return arabalar;
        }



        public List<Resim> GetirResimler()
        {
            List<Resim> resimler = new List<Resim>();
            cmd = new SqlCommand("select aracid,resimyolu from Resimler", conn);

            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();

                }
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    Resim rsm;
                    while (rdr.Read())
                    {
                        rsm = new Resim();
                        rsm.AracId = Convert.ToInt32(rdr["aracid"]);
                        rsm.ResimYolu = rdr["resimyolu"].ToString();

                        resimler.Add(rsm);
                    }

                }

            }
            catch (Exception)
            {


            }
            finally
            {
                rdr.Close();
                conn.Close();
            }

            return resimler;
        }

        public List<ArabaSinif> GetirArabasiniflari()
        {
            List<ArabaSinif> arabaSiniflari = new List<ArabaSinif>();
            cmd = new SqlCommand("select id,sinif,fiyat from Arabasiniflari", conn);

            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();

                }
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    ArabaSinif arbsnf;
                    while (rdr.Read())
                    {
                        arbsnf = new ArabaSinif();
                        arbsnf.Id = Convert.ToInt32(rdr["id"]);
                        arbsnf.Sinif = rdr["sinif"].ToString();
                        arbsnf.Fiyat = Convert.ToDecimal(rdr["fiyat"]);

                        arabaSiniflari.Add(arbsnf);
                    }

                }

            }
            catch (Exception)
            {


            }
            finally
            {
                rdr.Close();
                conn.Close();
            }

            return arabaSiniflari;
        }

        public bool ArabaGetirilmeDurum(KiralamaDetay kiralamaDetay, bool kiradaMi)
        {
            bool cevap = false;
            cmd = new SqlCommand("update Arabalar set KiradaMi=@kiradami where id = @aracId", conn);
            cmd.Parameters.AddWithValue("@kiradami", kiradaMi);
            cmd.Parameters.AddWithValue("@aracId", kiralamaDetay.AracId);
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();

                }
                int eklendimi;
                eklendimi = cmd.ExecuteNonQuery();
                if (eklendimi > 0)
                {
                    cevap = true;
                }

            }
            catch (Exception)
            {


            }
            finally
            {

                conn.Close();
            }
            return cevap;
        }
    }
}
