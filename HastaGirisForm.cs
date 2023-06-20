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
    public partial class HastaGirisForm : Form
    {
        public HastaGirisForm()
        {
            InitializeComponent();
        }

        //Kayitli olmayan hastalarin kaydolmasi icin eklendi.
        private void LinkLblYeniHasta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            HastaKayitForm yenihastafrm=new HastaKayitForm();
            yenihastafrm.Show();
            
        }
        SqlBaglantisi hastagiris = new SqlBaglantisi();

        //Sifre ve tcsini giren hastanin verileri dogruysa islem formuna yonlendirilmesi saglandi.
        //Ayrica hastanin TCsi ilgili forma gonderildi.
        
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            hastagiris.baglanti();
            SqlCommand kmtgiris = new SqlCommand("Select * from Tablo_Hasta where HastaTc=@d1 and HastaSifre=@d2 ", hastagiris.baglanti());
            kmtgiris.Parameters.AddWithValue("@d1", TxtHastaTC.Text);
            kmtgiris.Parameters.AddWithValue("@d2", TxtHastaSifre.Text);
            SqlDataReader bilgikontrol = kmtgiris.ExecuteReader();

            if (bilgikontrol.Read())
            {
                HastaIslemForm hastaFrm=new HastaIslemForm();
                hastaFrm.tc = TxtHastaTC.Text;
                hastaFrm.Show();
                this.Hide();
                
            }
            //Hatali sifre ya da TC girildiginde hasta tekrar denemek isterse kutucuklarin temizlenmesi saglandi.
            else
            {
                DialogResult secim =MessageBox.Show("Hatalı Şifre ya da TC Kimlik Numarasi Girdiniz.Tekrar Denemek ister misiniz?\n ", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (secim==DialogResult.Yes)
                {
                    TxtHastaSifre.Text = "";
                    TxtHastaTC.Text = "";
                }
                else if (secim==DialogResult.Cancel)
                {
                    this.Close();
                }
            }



            hastagiris.baglanti().Close();

   
        }

        //Hastanin ana sayfaya geri donebilmesi icin buton eklendi.
        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaGirisForm gerifrm=new AnaGirisForm();
            gerifrm.Show();
            this.Hide();
        }

        // TC no yazilan textboxa harf girisi engellendi.
        private void TxtHastaTC_KeyPress(object sender, KeyPressEventArgs e)
        {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
