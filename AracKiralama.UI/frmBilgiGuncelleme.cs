using AracKiralama.BAL;
using AracKiralama.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralama.UI
{
    public partial class frmBilgiGuncelleme : Form
    {

        public int gelenId;
        public frmBilgiGuncelleme()
        {
            InitializeComponent();
        }
        Musteri guncellenecekMusteri = new Musteri();
        MusteriController mc = new MusteriController();
        private void frmBilgiGuncelleme_Load(object sender, EventArgs e)
        {
            
            List<Musteri> musteriler = new List<Musteri>();
            musteriler = mc.GetMusteriler();
            foreach (Musteri item in musteriler)
            {
                if (item.Id==gelenId)
                {  
                    txtAd.Text = item.Ad;
                    txtSoyad.Text = item.Soyad;
                    txtSehir.Text = item.Sehir;
                    txtTCNO.Text = item.TCKno;
                    txtSifre.Text = item.Sifre;
                    dtpDogumTarihi.Value = item.DogumTarihi;
                }


            }
         }

        private void button1_Click(object sender, EventArgs e)
        {
            guncellenecekMusteri.Id = gelenId;
            guncellenecekMusteri.Ad = txtAd.Text;
            guncellenecekMusteri.Soyad = txtSoyad.Text;
            guncellenecekMusteri.Sehir = txtSehir.Text;
            guncellenecekMusteri.TCKno = txtTCNO.Text;
            guncellenecekMusteri.DogumTarihi = dtpDogumTarihi.Value;
            guncellenecekMusteri.Sifre = txtSifre.Text;
            bool guncellendimi=mc.UpdateMusteri(guncellenecekMusteri);
            if (guncellendimi)
            {
                MessageBox.Show("Başarıyla Güncellendi");
            }
            else
            {
                MessageBox.Show("Güncelleme Hatası!");
            }
        }
    }
}
