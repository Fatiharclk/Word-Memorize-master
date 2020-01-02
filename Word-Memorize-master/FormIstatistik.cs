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

namespace WordMemorization
{
    public partial class FormIstatistik : Form
    {
        public FormIstatistik()
        {
            InitializeComponent();
        }

        private void FormIstatistik_Load(object sender, EventArgs e)
        {
            IstatistikGetir();
        }
        void IstatistikGetir()
        {
                SqlBaglantisi sb = new SqlBaglantisi();
                SqlCommand komut = new SqlCommand("SELECT Word_Dogru,Word_Yanlis FROM Tbl_Istatistik ", sb.Baglanti());
                komut.ExecuteNonQuery();
                SqlDataReader drr = komut.ExecuteReader();
            if (drr.Read())
            {
                lblDogru.Text = drr["Word_Dogru"].ToString();
                lblYanlis.Text = drr["Word_Yanlis"].ToString();
                int dogru = Convert.ToInt32(drr["Word_Dogru"]);
                int yanlis = Convert.ToInt32(drr["Word_Yanlis"]);
                lblToplam.Text = (dogru + yanlis).ToString();
            }
                sb.Baglanti().Dispose();
                sb.Baglanti().Close();
        }
    }
}
