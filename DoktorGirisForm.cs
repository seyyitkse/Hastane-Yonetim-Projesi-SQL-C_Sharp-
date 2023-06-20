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
    public partial class DoktorGirisForm : Form
    {
        SqlBaglantisi doktorislem= new SqlBaglantisi();
        public DoktorGirisForm()
        {
            InitializeComponent();
        }

        //tc ve sifresini giren doktorun ilgili forma yonlendirilmesi saglandi.
        private void button1_Click(object sender, EventArgs e)
        {
            doktorislem.baglanti();
            SqlCommand kmtdoktor= new SqlCommand("Select * from Tablo_Doktor where DoktorTC=@d1 and DoktorSifre=@d2",doktorislem.baglanti());
            kmtdoktor.Parameters.AddWithValue("@d1", MskDoktorTC.Text);
            kmtdoktor.Parameters.AddWithValue("@d2", TxtDoktorSifre.Text);
            SqlDataReader verioku=kmtdoktor.ExecuteReader();
            if (verioku.Read()) 
            {
                DoktorBilgiForm doktorfrm=new DoktorBilgiForm();
                doktorfrm.doktortc=MskDoktorTC.Text; 
                doktorfrm.Show();
                this.Close();

            }
            //doktor hatali sifre yada TC girdigi zaman kutularin otomatik temizlenmesi saglandi.
            else
            {
                DialogResult secim = MessageBox.Show("Hatalı Şifre ya da TC Kimlik Numarasi Girdiniz.Tekrar Denemek ister misiniz?\n ", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (secim == DialogResult.OK)
                {
                    TxtDoktorSifre.Text = "";
                    MskDoktorTC.Text = "";
                }
                else if (secim == DialogResult.Cancel)
                {
                    this.Close();
                }
            }



            doktorislem.baglanti().Close();
        }

        private void BtnAnaSayfa_Click(object sender, EventArgs e)
        {
            AnaGirisForm gerifrm = new AnaGirisForm();
            gerifrm.Show();
            this.Hide();
        }
    }
}
