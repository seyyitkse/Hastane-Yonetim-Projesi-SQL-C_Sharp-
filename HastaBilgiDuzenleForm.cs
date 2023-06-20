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
    public partial class HastaBilgiDuzenleForm : Form
    {
        SqlBaglantisi hastabilgiduzenle = new SqlBaglantisi();

        //Diger formdan gelen TC ile hastanin bilgileri ilgili araclara yazdirildi.
        private void HastaBilgiDuzenleForm_Load(object sender, EventArgs e)
        {
            TxtHastaTC.Text = tcno;
            hastabilgiduzenle.baglanti();
            SqlCommand bilgigetir=new SqlCommand("Select * from Tablo_Hasta where HastaTC=@d1 ",hastabilgiduzenle.baglanti());
            bilgigetir.Parameters.AddWithValue("@d1", TxtHastaTC.Text);

            SqlDataReader bilgioku=bilgigetir.ExecuteReader();
            while (bilgioku.Read())
            {
                TxtHastaAd.Text = bilgioku[1].ToString();
                TxtHastaSoyad.Text= bilgioku[2].ToString();
                MsHastaTel.Text = bilgioku[4].ToString();
                TxtHastaSifre.Text = bilgioku[5].ToString();
                TxtCinsiyet.Text = bilgioku[6].ToString();
            }

            hastabilgiduzenle.baglanti().Close();
        }
        public HastaBilgiDuzenleForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti3 = new SqlConnection("Data Source=BRAVO-15\\SQL2019;Initial Catalog=HastaneVeriTabani;Integrated Security=True");
        public string tcno;
    
        //Hastanin bilgilerini guncellemesi saglandi.
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            hastabilgiduzenle.baglanti();
            SqlCommand kmtduzenle = new SqlCommand("Update  Tablo_Hasta set HastaAd=@d1,HastaSoyad=@d2,HastaTC=@d3,HastaTelefon=@d4,HastaSifre=@d5,HastaCinsiyet=@d6", hastabilgiduzenle.baglanti());
            kmtduzenle.Parameters.AddWithValue("@d1", TxtHastaAd.Text);
            kmtduzenle.Parameters.AddWithValue("@d2", TxtHastaSoyad.Text);
            kmtduzenle.Parameters.AddWithValue("@d3", TxtHastaTC.Text);
            kmtduzenle.Parameters.AddWithValue("@d4", MsHastaTel.Text);
            kmtduzenle.Parameters.AddWithValue("@d5", TxtHastaSifre.Text);
            kmtduzenle.Parameters.AddWithValue("@d6",TxtCinsiyet.Text);
            kmtduzenle.ExecuteNonQuery();
            hastabilgiduzenle.baglanti().Close();
            MessageBox.Show("Bilgi Güncelleme Başarılı!","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Geri donmek isteyenler icin kisayol butonlari
        private void BtnHastaEkran_Click(object sender, EventArgs e)
        {
            HastaGirisForm hastagrs = new HastaGirisForm();
            hastagrs.Show();
            this.Close();
        }

        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaGirisForm gerifrm=new AnaGirisForm();
            gerifrm.Show();
            this.Hide();    
        }

    
    }
}
