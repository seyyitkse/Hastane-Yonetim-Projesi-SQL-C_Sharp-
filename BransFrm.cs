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
    public partial class BransFrm : Form
    {
        public BransFrm()
        {
            InitializeComponent();
        }
        SqlBaglantisi bransislem=new SqlBaglantisi();

        //form yuklendiginde tum branslarin yazdirilmasi saglandi.
        private void BransFrm_Load(object sender, EventArgs e)
        {
            DataTable branstablo=new DataTable();
            SqlDataAdapter vericek=new SqlDataAdapter("Select * from Tablo_Brans",bransislem.baglanti());
            vericek.Fill(branstablo);
            dataGridView1.DataSource= branstablo;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //secilen bransin bilgilerini kutucuklara tasidik.
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtBransAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //brans kayit islemi
            bransislem.baglanti();
            SqlCommand kmtkaydet= new SqlCommand("Insert into Tablo_Brans (BransAd) values(@d1) ",bransislem.baglanti());
            kmtkaydet.Parameters.AddWithValue("@d1",TxtBransAd.Text);
            kmtkaydet.ExecuteNonQuery();
            bransislem.baglanti().Close();
            MessageBox.Show("Branş kaydı başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //bransguncellemeislemi
            bransislem.baglanti();
            SqlCommand kmtguncelle = new SqlCommand("Update Tablo_Brans set BransAd=@d1 where Bransid=@d2", bransislem.baglanti());
            kmtguncelle.Parameters.AddWithValue("@d1", TxtBransAd.Text);
            kmtguncelle.Parameters.AddWithValue("@d2", TxtID.Text);
            kmtguncelle.ExecuteNonQuery();
            bransislem.baglanti().Close();
            MessageBox.Show( "Branş güncelleme başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            //Brans silme islemi
            bransislem.baglanti();
            SqlCommand kmtsil=new SqlCommand("Delete from Tablo_Brans where Bransid=@d1",bransislem.baglanti());
            kmtsil.Parameters.AddWithValue("@d1", TxtID.Text);
            kmtsil.ExecuteNonQuery();
            bransislem.baglanti().Close();
            MessageBox.Show("Branş silme başarılı!", "Uyarı",  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
