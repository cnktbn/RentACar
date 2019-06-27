using AracKiralama.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralama.DAL
{
   public class KiralamaDetayManagement
    {

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader rdr;
        public KiralamaDetayManagement()
        {
            conn = new SqlConnection("server=.;database=arackiralamadb;integrated security=true;");
        }
           

        public List<KiralamaDetay> GetirKiralamaDetay()
        {
            List<KiralamaDetay> kDetaylar = new List<KiralamaDetay>();
            cmd = new SqlCommand("select ID,MusteriID,AracID,ToplamFiyat,AlinanTarih,GetirilenTarih,AlinanKM,TeslimKM,YapilanKM from KiralamaDetaylari", conn);

            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();

                }
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    KiralamaDetay kd;
                    while (rdr.Read())
                    {
                        kd = new KiralamaDetay();
                        kd.Id = Convert.ToInt32(rdr["id"]);
                        kd.MusteriId = Convert.ToInt32(rdr["musteriid"]);
                        kd.AracId = Convert.ToInt32(rdr["aracid"]);
                        kd.ToplamFiyat = Convert.ToDecimal(rdr["toplamfiyat"]);
                        kd.AlinanTarih = Convert.ToDateTime(rdr["alinantarih"]);
                        kd.GetirilenTarih = Convert.ToDateTime(rdr["getirilentarih"]);
                        kd.AlinanKm = Convert.ToInt32(rdr["alinankm"]);
                        kd.TeslimKm = Convert.ToInt32(rdr["teslimkm"]);
                        kd.YapilanKm = Convert.ToInt32(rdr["yapilankm"]);

                        kDetaylar.Add(kd);
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

            return kDetaylar;
        }


        public  bool EkleKiralamaDetay(KiralamaDetay kiralamaDetay)
        {
            bool cevap = false;
            cmd = new SqlCommand("insert into KiralamaDetaylari(MusteriID, AracID, ToplamFiyat, AlinanTarih, GetirilenTarih, AlinanKM) values(@musteriId, @aracId, @toplamFiyat, @alinanTarih, @getirilenTarih, @alinanKm",conn);
            cmd.Parameters.AddWithValue("@musteriId",kiralamaDetay.MusteriId);
            cmd.Parameters.AddWithValue("@aracId", kiralamaDetay.AracId);
            cmd.Parameters.AddWithValue("@toplamFiyat", kiralamaDetay.ToplamFiyat);
            cmd.Parameters.AddWithValue("@alinanTarih", kiralamaDetay.AlinanTarih);
            cmd.Parameters.AddWithValue("@getirilenTarih", kiralamaDetay.GetirilenTarih);
            cmd.Parameters.AddWithValue("@alinanKm", kiralamaDetay.AlinanKm);

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


        public bool TeslimKmGuncelle(KiralamaDetay kiralamaDetay)
        {
            bool cevap = false;
            cmd = new SqlCommand("update KiralamaDetaylari set TeslimKM=@teslimKm where ID=@kdId",conn);
            cmd.Parameters.AddWithValue("@teslimKm",kiralamaDetay.TeslimKm);
            cmd.Parameters.AddWithValue("@kdId",kiralamaDetay.Id);
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
