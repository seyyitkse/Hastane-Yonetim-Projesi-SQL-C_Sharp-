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
    public partial class SekreterGirisForm : Form
    {
        SqlConnection baglanti5 = new SqlConnection("Data Source=BRAVO-15\\SQL2019;Initial Catalog=HastaneVeriTabani;Integrated Security=True");
        public SekreterGirisForm()
        {
            InitializeComponent();
        }
        SqlBaglantisi sekretergiris=new SqlBaglantisi();


        //Bilgilerin kontrol edilmesi ve sekreterin ilgili forma yonlendirilmesi saglandi.
        //Ayrica sekreterin TCsi ilgili forma gonderildi.
        
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            sekretergiris.baglanti();
            
            SqlCommand kmtsekreter=new SqlCommand("Select * from Tablo_Sekreter where SekreterTC=@d1 and SekreterSifre=@d2",sekretergiris.baglanti());
            kmtsekreter.Parameters.AddWithValue("@d1", MskSekreterTC.Text);
            kmtsekreter.Parameters.AddWithValue("@d2", TxtSekreterSifre.Text);

            SqlDataReader verioku3=kmtsekreter.ExecuteReader();
            if (verioku3.Read())
            {
                SekreterDetayFrm sekreterfrm=new SekreterDetayFrm();
                sekreterfrm.sekretertc = MskSekreterTC.Text;
                sekreterfrm.Show();
                this.Close();
            }

            //Hatali bilgi giren sekreterin temizleme islemi ile vakit kaybetmemesi saglandi.
            else
            {
                DialogResult secim = MessageBox.Show("Hatalı Şifre ya da TC Kimlik Numarasi Girdiniz.Tekrar Denemek ister misiniz?\n ", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (secim == DialogResult.Yes)
                {
                    TxtSekreterSifre.Text = "";
                    MskSekreterTC.Text = "";
                }
                else if (secim == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
            sekretergiris.baglanti().Close();

            baglanti5.Close();
        }

        //Geri donmek isteyenler icin kisayol butonlari
        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaGirisForm gerifrm = new AnaGirisForm();
            gerifrm.Show();
            this.Hide();
        }
    }
}
