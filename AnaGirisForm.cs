using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _68_Hastane_Yonetim_Projesi_SQL_C_Sharp_
{
    //Projenin tamamlanma tarihi : 29 Aralik 2022 Perşembe 22:25
    public partial class AnaGirisForm : Form
    {
        public AnaGirisForm()
        {
            InitializeComponent();
        }
       
        //butonlara tiklayinca ilgili formlara yonlendirme yapildi.
        private void BtnHastaGiris_Click(object sender, EventArgs e)
        {
            HastaGirisForm hastafrm=new HastaGirisForm();
            hastafrm.Show();
            this.Hide();
        }


        private void BtnSekreterGiris_Click(object sender, EventArgs e)
        {
            SekreterGirisForm sekreterfrm=new SekreterGirisForm();
            sekreterfrm.Show();
            this.Hide();
        }


        private void BtnDoktorGiris_Click(object sender, EventArgs e)
        {
            DoktorGirisForm doktorfrm=new DoktorGirisForm();
            doktorfrm.Show();
            this.Hide();
        }
    }
}
