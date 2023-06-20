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
    public partial class RandevuFrm : Form
    {
        public RandevuFrm()
        {
            InitializeComponent();
        }
        SqlBaglantisi randevuislem=new SqlBaglantisi();

        //sekreterin tum randevulari goruntulemesi icin tum randevular datagride tasindi.
        private void RandevuFrm_Load(object sender, EventArgs e)
        {
            DataTable randevutablo= new DataTable();
            SqlDataAdapter randevucek = new SqlDataAdapter("Select * from Tablo_Randevu",randevuislem.baglanti());
            randevucek.Fill (randevutablo);
            dataGridView1.DataSource= randevutablo;
        }
        
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
