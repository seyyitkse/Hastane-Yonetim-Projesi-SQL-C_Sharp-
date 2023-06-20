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
    public partial class DuyuruFrm : Form
    {
        public DuyuruFrm()
        {
            InitializeComponent();
        }

        private void BtnDoktorEkran_Click(object sender, EventArgs e)
        {
            DoktorGirisForm gerifrm=new DoktorGirisForm();
            this.Hide();
            gerifrm.Show();
        }
        SqlBaglantisi duyuruislem=new SqlBaglantisi();

        //duyurularin getirilmesi saglandi.
        private void DuyuruFrm_Load(object sender, EventArgs e)
        {
            DataTable yenitablo=new DataTable();
            SqlDataAdapter vericek=new SqlDataAdapter("Select * from Tablo_Duyuru",duyuruislem.baglanti());
            vericek.Fill(yenitablo);
            dataGridView1.DataSource= yenitablo;
        }
    }
}
