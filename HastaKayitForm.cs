using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _68_Hastane_Yonetim_Projesi_SQL_C_Sharp_
{
    public partial class HastaKayitForm : Form
    {
        public HastaKayitForm()
        {
            InitializeComponent();
        }


        SqlBaglantisi Hasta =new SqlBaglantisi();

        private void BtnKaydol_Click(object sender, EventArgs e)
        {

            //insert komutu ile veritabanina kayit islemi gerceklestirildi.


            Hasta.baglanti();
            
            SqlCommand KmtHastaKayit=new SqlCommand("insert into  Tablo_Hasta (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values(@d1,@d2,@d3,@d4,@d5,@d6); ",Hasta.baglanti());
            KmtHastaKayit.Parameters.AddWithValue("@d1", TxtHastaAd.Text);
            KmtHastaKayit.Parameters.AddWithValue("@d2", TxtHastaSoyad.Text);
            KmtHastaKayit.Parameters.AddWithValue("@d3", TxtHastaTC.Text);
            KmtHastaKayit.Parameters.AddWithValue("@d4", MskHastaTel.Text);
            KmtHastaKayit.Parameters.AddWithValue("@d5", TxtHastaSifre.Text);

            if (RadioErkek.Checked==true)
            {
                KmtHastaKayit.Parameters.AddWithValue("@d6", "Erkek");
            }
            else if (RadioKadin.Checked==true)
            {
                KmtHastaKayit.Parameters.AddWithValue("@d6", "Kadın");
            }


            KmtHastaKayit.ExecuteNonQuery();
            Hasta.baglanti().Close();

            HastaGirisForm hastafrm1 = new HastaGirisForm();

            //Hastanin uyari ekraninda yaptigi secimlere gore ilgili formlara yonlendirilmesi saglandi.
            DialogResult secim= MessageBox.Show("Kaydınız yapıldı.Artık giriş yapabilirsiniz.\nŞifreniz: "+TxtHastaSifre.Text, "Bilgi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (secim==DialogResult.Yes)
            {
                this.Close();                
                hastafrm1.Show();
            }
            else
            {
                MessageBox.Show("Kayıt yaptınız. Ana sayfaya yönlendiriliyorsunuz.\n " , "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                hastafrm1.Show();
            }
            
        }
       


        //Geriye donmek isteyenler icin eklenmis ana sayfa ve giris ekrani butonlari

        private void BtnHastaEkran_Click(object sender, EventArgs e)
        {
            HastaGirisForm hastafrm = new HastaGirisForm();
            hastafrm.Show();
            this.Hide();
        }

        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaGirisForm girisfrm = new AnaGirisForm();
            girisfrm.Show();
            this.Hide();
        }




        //Bu bolumde sirasiyla
        //tc textboxuna-> harf
        //ad-soyad tectboxlarına-> sayi girisi engellendi.

        private void TxtHastaTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtHastaAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)&& !char.IsSeparator(e.KeyChar);
        }

        private void TxtHastaSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}
