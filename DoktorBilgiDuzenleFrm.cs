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
using static System.Net.Mime.MediaTypeNames;

namespace _68_Hastane_Yonetim_Projesi_SQL_C_Sharp_
{
    public partial class DoktorBilgiDuzenleFrm : Form
    {
        public string doktorTC;
        public DoktorBilgiDuzenleFrm()
        {
            InitializeComponent();
        }

        SqlBaglantisi doktorislem=new SqlBaglantisi();
        private void DoktorIslemFrm_Load(object sender, EventArgs e)
        {
            //doktorlarin bilgilerini datagride aktariyoruz
            DataTable doktortablo=new DataTable();
            SqlDataAdapter veri1=new SqlDataAdapter("Select *  from Tablo_Doktor",doktorislem.baglanti());
            veri1.Fill(doktortablo);
            dataGridView1.DataSource= doktortablo;


            //branslari comboboxa aktariyoruz.

            SqlCommand bransekle=new SqlCommand("Select BransAd from Tablo_Brans",doktorislem.baglanti());

            SqlDataReader kayit=bransekle.ExecuteReader();

            while (kayit.Read())
            {
                CmbDoktorBrans.Items.Add(kayit[0]);
            }
            
            //doktorun bilgileri duzenleme formuna  tasindi.
            MskDoktorTC.Text= doktorTC;
            
            doktorislem.baglanti();
            
            SqlCommand kmtbilgi=new SqlCommand("Select * from Tablo_Doktor where DoktorTC=@d1",doktorislem.baglanti());
            kmtbilgi.Parameters.AddWithValue("@d1", MskDoktorTC.Text);

            SqlDataReader kmtoku=kmtbilgi.ExecuteReader();

            while (kmtoku.Read())
            {
                TxtDoktorAd.Text = kmtoku[1].ToString();
                TxtDoktorSoyad.Text= kmtoku[2].ToString();
                CmbDoktorBrans.Text= kmtoku[3].ToString();
                TxtDoktorSifre.Text= kmtoku[5].ToString();
            }

            doktorislem.baglanti().Close();
            
        }

      
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //Doktor kaydetme islemi
            doktorislem.baglanti();

            SqlCommand kmtdoktorekle = new SqlCommand("Insert into Tablo_Doktor (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values(@d1,@d2,@d3,@d4,@d5)", doktorislem.baglanti());

            kmtdoktorekle.Parameters.AddWithValue("@d1", TxtDoktorAd.Text);
            kmtdoktorekle.Parameters.AddWithValue("@d2", TxtDoktorSoyad.Text);
            kmtdoktorekle.Parameters.AddWithValue("@d3",CmbDoktorBrans.Text);
            kmtdoktorekle.Parameters.AddWithValue("@d4",MskDoktorTC.Text);  
            kmtdoktorekle.Parameters.AddWithValue("@d5",TxtDoktorSifre.Text);   

            kmtdoktorekle.ExecuteNonQuery();
            MessageBox.Show("Kayıt başarılı.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridde secilen satiri kutucuklara tasidik.
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            TxtDoktorAd.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            TxtDoktorSoyad.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            CmbDoktorBrans.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            MskDoktorTC.Text = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            TxtDoktorSifre.Text = dataGridView1.Rows[secim].Cells[5].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //Doktor silme islemi
            doktorislem.baglanti();
            SqlCommand kmtsil = new SqlCommand("Delete from Tablo_Doktor where DoktorTC=@d1", doktorislem.baglanti());
            kmtsil.Parameters.AddWithValue("@d1", MskDoktorTC.Text);
            kmtsil.ExecuteNonQuery();
            doktorislem.baglanti().Close();
            MessageBox.Show("Silme başarılı !","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //doktor guncelleme islemi
            doktorislem.baglanti();

            SqlCommand kmtguncelle = new SqlCommand("Update  Tablo_Doktor set DoktorAd=@d1,DoktorSoyad=@d2,DoktorBrans=@d3,DoktorSifre=@d5 where DoktorTC=@d4", doktorislem.baglanti());
            kmtguncelle.Parameters.AddWithValue("@d1", TxtDoktorAd.Text);
            kmtguncelle.Parameters.AddWithValue("@d2",TxtDoktorSoyad.Text);
            kmtguncelle.Parameters.AddWithValue("@d3", CmbDoktorBrans.Text);
            kmtguncelle.Parameters.AddWithValue("@d4", MskDoktorTC.Text);
            kmtguncelle.Parameters.AddWithValue("@d5",TxtDoktorSifre.Text);
            kmtguncelle.ExecuteNonQuery();
            doktorislem.baglanti().Close();

           MessageBox.Show("Bilgi", "Doktor güncelleme başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
        }
    }
}
