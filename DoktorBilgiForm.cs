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
using System.Data.SqlClient;
namespace _68_Hastane_Yonetim_Projesi_SQL_C_Sharp_
{
    public partial class DoktorBilgiForm : Form
    {
        SqlBaglantisi doktorislem=new SqlBaglantisi();
        
        public DoktorBilgiForm()
        {
            InitializeComponent();
        }
        public string doktortc,doktoradsoyad;
    


        //Doktorun bilgi duzenleme formunu acmasi saglandi
        private void BtnBilgiDuzenle_Click(object sender, EventArgs e)
        {
            DoktorBilgiDuzenleFrm doktorbilgiFrm=new DoktorBilgiDuzenleFrm();
            doktorbilgiFrm.doktorTC = LblDoktorTc.Text;
            doktorbilgiFrm.Show();
        }

        //Doktorun sekreter tarafindan olusturulan duyurular bolmesini acmasi saglandi.
        private void BtnDuyuru_Click(object sender, EventArgs e)
        {
            DuyuruFrm duyuruFrm=new DuyuruFrm();
            duyuruFrm.Show();
        }


        //Doktorun formu kapatmasi saglandi
        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaGirisForm gerifrm=new AnaGirisForm();
            gerifrm.Show();
        }

        private void DoktorBilgiForm_Load(object sender, EventArgs e)
        {
            //Giris formundan gelen tc ile doktor bilgileri labellara yazdirildi.
            doktorislem.baglanti();
            SqlCommand kmtdoktorbilgi=new SqlCommand("Select DoktorAd,DoktorSoyad from Tablo_Doktor where DoktorTC=@d1",doktorislem.baglanti());
            kmtdoktorbilgi.Parameters.AddWithValue("@d1", doktortc);

            SqlDataReader vericek = kmtdoktorbilgi.ExecuteReader();
            while (vericek.Read())
            {
                LblDoktorTc.Text=doktortc.ToString();
                LblDoktorAd.Text = vericek[0] + " " + vericek[1];
            }
            doktorislem.baglanti().Close();

            //sadece giris yapan doktora ait randevular getirildi.
            DataTable randevu=new DataTable();
            SqlDataAdapter veri=new SqlDataAdapter("Select *  From Tablo_Randevu where RandevuDoktor='"+ LblDoktorAd.Text +"'",doktorislem.baglanti());
            veri.Fill(randevu);
            dataGridView1.DataSource= randevu;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //Doktorun sectigi randevudaki hastanin sikayeti richtextboxa tasindi
            int secilenrandevu = dataGridView1.SelectedCells[0].RowIndex;
            RchHasta.Text = dataGridView1.Rows[secilenrandevu].Cells[7].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
