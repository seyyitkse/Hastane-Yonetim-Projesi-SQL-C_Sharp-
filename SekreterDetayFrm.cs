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
using System.Net.Http.Headers;

namespace _68_Hastane_Yonetim_Projesi_SQL_C_Sharp_
{
    public partial class SekreterDetayFrm : Form
    {
        public string sekretertc;
        public SekreterDetayFrm()
        {
            InitializeComponent();
        }
        SqlBaglantisi sekreterislem=new SqlBaglantisi();

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    //Form yuklenirken sekreterin bilgileri formda yazdirildi.
        private void SekreterDetayFrm_Load(object sender, EventArgs e)
        {
            LblSekreterTC.Text=sekretertc;
            sekreterislem.baglanti();

            //yolladigimiz tc degerine gore bana sekreterin adini getir diyoruz.

            SqlCommand kmtsekretergiris=new SqlCommand("Select SekreterAdSoyad From Tablo_Sekreter where SekreterTC=@d1",sekreterislem.baglanti());
            kmtsekretergiris.Parameters.AddWithValue("@d1", sekretertc);
            
            SqlDataReader verioku4=kmtsekretergiris.ExecuteReader();

            while (verioku4.Read())
            {
                LblSekreterAd.Text = verioku4[0].ToString();
            }
            sekreterislem.baglanti().Close();

            //Branslari datagride aktarma
            DataTable yenitablo2=new DataTable();
            SqlDataAdapter veri2=new SqlDataAdapter("Select * from Tablo_Brans",sekreterislem.baglanti());
            veri2.Fill(yenitablo2);
            dataGridView1.DataSource=yenitablo2;

            //Doktorlari datagride aktarma
            DataTable yenitablo3=new DataTable();
            SqlDataAdapter veri3 = new SqlDataAdapter("Select (DoktorAd+' '+DoktorSoyad)as 'Doktorlar',DoktorBrans from Tablo_Doktor", sekreterislem.baglanti());
            veri3.Fill(yenitablo3);
            dataGridView2.DataSource=yenitablo3;

            //Branslari randevu comboboxina aktarma
            sekreterislem.baglanti();
            SqlCommand kmtbrans = new SqlCommand("Select BransAd from Tablo_Brans", sekreterislem.baglanti());
            SqlDataReader kmtoku = kmtbrans.ExecuteReader();

            while (kmtoku.Read())
            {
                CmbRandevuBrans.Items.Add(kmtoku[0]);
            }
            sekreterislem.baglanti().Close();

        }

        //Randevu olusturma islemi
        private void BtnRandevuKayit_Click(object sender, EventArgs e)
        {
            sekreterislem.baglanti();
            SqlCommand kmtrandevu = new SqlCommand("insert into Tablo_Randevu (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,RandevuDurum) values(@d1,@d2,@d3,@d4,0)", sekreterislem.baglanti());
            kmtrandevu.Parameters.AddWithValue("@d1", MskRandevuTarih.Text);
            kmtrandevu.Parameters.AddWithValue("@d2", MskRandevuSaat.Text);
            kmtrandevu.Parameters.AddWithValue("@d3",CmbRandevuBrans.Text); 
            kmtrandevu.Parameters.AddWithValue("@d4",CmbRandevuDoktor.Text);
            kmtrandevu.ExecuteNonQuery();
            MessageBox.Show("Randevu Oluşturma Başarılı", "Bilgi ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //Bransa gore comboboxa doktorlar eklendi.
        private void CmbRandevuBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbRandevuDoktor.Items.Clear();
            sekreterislem.baglanti();

            SqlCommand kmtdoktor = new SqlCommand("Select DoktorAd,DoktorSoyad from Tablo_Doktor where DoktorBrans=@d1", sekreterislem.baglanti());
            kmtdoktor.Parameters.AddWithValue("@d1", CmbRandevuBrans.Text);
            SqlDataReader doktoroku= kmtdoktor.ExecuteReader();

            while (doktoroku.Read())
            {
                CmbRandevuDoktor.Items.Add(doktoroku[0] + " "+doktoroku[1]);
            }

            sekreterislem.baglanti().Close();
        }

        private void CmbRandevuDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        //Duyuru olusturma islemi
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand kmtduyuru = new SqlCommand("Insert into  Tablo_Duyuru (Duyuru) values(@d1)", sekreterislem.baglanti());
            kmtduyuru.Parameters.AddWithValue("@d1", richTextBox1.Text);
            kmtduyuru.ExecuteNonQuery();
            MessageBox.Show("Duyuru Oluşturma Başarılı", "Bilgi ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        //Islemler icin ilgili formlara yonlendirildi.
        private void BtnDoktorKayit_Click(object sender, EventArgs e)
        {
            DoktorBilgiDuzenleFrm sekreterislem = new DoktorBilgiDuzenleFrm();
            sekreterislem.Show();
        }

        private void BtnBransKayit_Click(object sender, EventArgs e)
        {
            BransFrm branskayitfrm=new BransFrm();
            branskayitfrm.Show();
        }

        private void BtnRandevuGoruntule_Click(object sender, EventArgs e)
        {
            RandevuFrm randevuislemfrm=new RandevuFrm();
            randevuislemfrm.Show();
        }

        private void BtnRandevuGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand kmtguncelle = new SqlCommand("Update Tablo_Randevu ", sekreterislem.baglanti());
        }

        private void BtnDuyuru_Click(object sender, EventArgs e)
        {
            DuyuruFrm duyuru=new DuyuruFrm();
            duyuru.Show();
        }
    }
}
