using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _68_Hastane_Yonetim_Projesi_SQL_C_Sharp_
{
    public partial class HastaIslemForm : Form
    {
        public HastaIslemForm()
        {
            InitializeComponent();
        }
        public string tc;
        SqlBaglantisi hastaislem=new SqlBaglantisi();
        
        //while listeleme icin
        //if ise verinin dogru olup olmadigini kontrol ediyor

        //bu bolumde ad-soyadi veri tabanindan cekiyoruz.
       private void HastaIslemForm_Load(object sender, EventArgs e)
        {
           
            LblTc.Text = tc;
            hastaislem.baglanti();
            SqlCommand kmtbilgi=new SqlCommand("Select HastaAd,HastaSoyad From Tablo_Hasta where HastaTC=@d1",hastaislem.baglanti());
           
            kmtbilgi.Parameters.AddWithValue("@d1", LblTc.Text);
            SqlDataReader verioku = kmtbilgi.ExecuteReader();
            while (verioku.Read())
            {
                LblAdSoyad.Text = verioku[0] + " " + verioku[1];
            }

            hastaislem.baglanti().Close();
            
            //randevu gecmisi goruntuleme
            //datagridview'da baglantiyi kapatmamiz gerekmez.
            //DataAdapterda parametre kullanmıyoruz.Asagida ornek bir kullanim yapilmistir.
            //Hastanin almis oldugu randevulari goruntulenmesi saglandi.
            DataTable yenitablo = new DataTable();
            SqlDataAdapter veri=new SqlDataAdapter("Select * From Tablo_Randevu where HastaTC="+tc,hastaislem.baglanti());
            veri.Fill(yenitablo);
            dataGridView1.DataSource=yenitablo;


            //Branslari comboboxa aktarma
            hastaislem.baglanti();

            SqlCommand veriCek = new SqlCommand("Select BransAd from Tablo_Brans", hastaislem.baglanti());
            SqlDataReader verioku2=veriCek.ExecuteReader();

            while (verioku2.Read())
            {
                CmbBrans.Items.Add(verioku2[0]);
            }

            hastaislem.baglanti().Close();



        }

        //Hastanin bilgilerini duzenleyebilmesi icin ilgili forma yonlendirilmesi saglandi.
        //Diger formda hastanin bilgilerine erisebilmek icin, hastanin TCsi ilgili forma yollandi.
            private void LinkLblBilgi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HastaBilgiDuzenleForm duzenlefrm=new HastaBilgiDuzenleForm();
            duzenlefrm.tcno = LblTc.Text;
            duzenlefrm.Show();
        }

        //Hastanin , -sekreterin tanimlamis oldugu- randevuyu secerek randevu almasi saglandi.
        private void BtnRandevu_Click(object sender, EventArgs e)
        {
            hastaislem.baglanti();

            SqlCommand kmthastarandevu = new SqlCommand("Update  Tablo_Randevu set  HastaTC=@d1,HastaSikayet=@d2,RandevuDurum=1 where Randevuid=@d3", hastaislem.baglanti());

            kmthastarandevu.Parameters.AddWithValue("@d1", LblTc.Text);
            kmthastarandevu.Parameters.AddWithValue("@d2",RicTxtSikayet.Text);
            kmthastarandevu.Parameters.AddWithValue("@d3", Txtid.Text);
            kmthastarandevu.ExecuteNonQuery();

            hastaislem.baglanti().Close();
            MessageBox.Show("Randevu Oluşturma Başarılı", "Bilgi ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Bu bolumde secilen bransa ait doktorlari comboboxlara ekliyoruz.

            //Clear bolumunu su sebepten dolayi ekliyoruz;
            //Biz cmbye her tikladigimizda altina yeni degerleri ekleyecek ancak eski degerler kalacak.
            //Bunun onune gecmek icin her seferinde temizleme islemi yapiyoruz
            CmbDoktor.Items.Clear();
            
            hastaislem.baglanti();
            SqlCommand kmtDoktor = new SqlCommand("Select DoktorAd,DoktorSoyad from Tablo_Doktor where DoktorBrans=@d1", hastaislem.baglanti());
            kmtDoktor.Parameters.AddWithValue("@d1", CmbBrans.Text);
            SqlDataReader verioku3 = kmtDoktor.ExecuteReader();

            //Burda ise bizim cektigimiz degerler sirasiyla 0 ve 1. indexlerden gelecegi icin ona gore kayit islemi yapiyoruz
            while (verioku3.Read())
            {
                CmbDoktor.Items.Add(verioku3[0]+" " + verioku3[1]);
            }
            hastaislem.baglanti().Close();


        }
        //Hastanin sectigi brans ve doktora gore randevulari goruntuleyebilmesi saglandi.
        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Sqlde arama yaparken string ifadeler tek tirnak icinde yazilir.
            DataTable dt2= new DataTable();
            SqlDataAdapter veri2 = new SqlDataAdapter("Select * From Tablo_Randevu where RandevuBrans='" + CmbBrans.Text + "'"+ "and RandevuDoktor='"+CmbDoktor.Text+"' and RandevuDurum=0", hastaislem.baglanti());
            veri2.Fill(dt2);
            dataGridView2.DataSource=dt2;
        }

        //Secilen randevuya cift tiklandiginda bunlarin gerekli araclara tasinmasi saglandi.
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString() ;
            CmbBrans.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString() ;
            CmbDoktor.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString() ;

        }
    }
}
