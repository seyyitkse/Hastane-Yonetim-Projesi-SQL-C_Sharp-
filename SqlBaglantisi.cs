using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _68_Hastane_Yonetim_Projesi_SQL_C_Sharp_
{
    public class SqlBaglantisi
    {
        //Sql connection sinifin ad
        //baglanti() metodun adi
        //baglan olusturdugumuz nesnenin adresini tutan nesne
        //.open() baska bir metod
        //returnde geriye dondurulen deger oluyor

        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=MSI-BRAVO\\SQLEXPRESS;Initial Catalog=Hastane-Veri-Tabani;Integrated Security=True");
            baglan.Open();
            return baglan;
        }

    }
}
