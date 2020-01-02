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
    public partial class FormEskiKelimeler : Form
    {
        public FormEskiKelimeler()
        {
            InitializeComponent();
        }

        private void BtnYeniKelime_Click(object sender, EventArgs e)
        {
            KelimeGetir();
        }
        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (TxtKelime2.Text == lblTemp.Text)
            {
                LevelArttir();
                TarihGuncelle();
                MessageBox.Show("TEBRİKLER KELİMEYİ BİLDİNİZ");
            }
            else if(TxtKelime2.Text != lblTemp.Text)
            {
                LevelAzalt();
                MessageBox.Show("KELİMEYİ BİLEMEDİNİZ :(");
            }
            
        }
        SqlBaglantisi sb = new SqlBaglantisi();
        void KelimeGetir()
        {
            SqlCommand komut = new SqlCommand("SELECT TOP 1 Word_Ingilizce,Word_Turkce,Word_Level FROM Tbl_Word " +
                "WHERE Word_Level>=1 and Word_Date=CONVERT(DATE,GETDATE(),104) ORDER BY NEWID() ", 
                sb.Baglanti());
            komut.ExecuteNonQuery();
            SqlDataReader drr = komut.ExecuteReader();
            if (drr.Read())
            {
                TxtKelime1.Text = drr["Word_Ingilizce"].ToString();
                lblTemp.Text = drr["Word_Turkce"].ToString();
                lblAsamaNo.Text = drr["Word_Level"].ToString();
            }
            sb.Baglanti().Dispose();
            sb.Baglanti().Close();
        }
        void TarihGuncelle()
        {
            if (Convert.ToInt32(lblAsamaNo.Text) == 0)
            {
                SqlCommand sc = new SqlCommand("UPDATE Tbl_Word SET Word_Date=DATEADD(DAY,1,Word_Date) WHERE Word_Turkce='" + TxtKelime2.Text + "'", sb.Baglanti());
                sc.ExecuteNonQuery();
            }
            if (Convert.ToInt32(lblAsamaNo.Text) == 1)
            {
                SqlCommand sc = new SqlCommand("UPDATE Tbl_Word SET Word_Date=DATEADD(DAY,7,Word_Date) WHERE Word_Turkce='" + TxtKelime2.Text + "'", sb.Baglanti());
                sc.ExecuteNonQuery();
            }
            if (Convert.ToInt32(lblAsamaNo.Text) == 2)
            {
                SqlCommand sc = new SqlCommand("UPDATE Tbl_Word SET Word_Date=DATEADD(DAY,30,Word_Date) WHERE Word_Turkce='" + TxtKelime2.Text + "'", sb.Baglanti());
                sc.ExecuteNonQuery();
            }
            if (Convert.ToInt32(lblAsamaNo.Text) == 3)
            {
                SqlCommand sc = new SqlCommand("UPDATE Tbl_Word SET Word_Date=DATEADD(DAY,180,Word_Date) WHERE Word_Turkce='" + TxtKelime2.Text + "'", sb.Baglanti());
                sc.ExecuteNonQuery();
            }
            if (Convert.ToInt32(lblAsamaNo.Text) == 4)
            {
                SqlCommand sc = new SqlCommand("UPDATE Tbl_Word SET Word_Date=DATEADD(DAY,360,Word_Date) WHERE Word_Turkce='" + TxtKelime2.Text + "'", sb.Baglanti());
                sc.ExecuteNonQuery();
            }
            sb.Baglanti().Dispose();
            sb.Baglanti().Close();
        }
        void LevelArttir()
        {
            SqlCommand sc = new SqlCommand("UPDATE Tbl_Word SET Word_Level +=1	WHERE Word_Turkce='" + TxtKelime2.Text + "'", sb.Baglanti());
            sc.ExecuteNonQuery();
            sb.Baglanti().Dispose();
            sb.Baglanti().Close();
        }
        void LevelAzalt()
        {
            SqlCommand sc = new SqlCommand("UPDATE Tbl_Word SET Word_Level =0	WHERE Word_Ingilizce='" + TxtKelime1.Text + "'", sb.Baglanti());
            sc.ExecuteNonQuery();
            sb.Baglanti().Dispose();
            sb.Baglanti().Close();
        }

        private void FormEskiKelimeler_Load(object sender, EventArgs e)
        {

        }

        private void BtnYeniKelime_MouseEnter(object sender, EventArgs e)
        {
            BtnYeniKelime.ForeColor = Color.Tomato;
        }

        private void BtnYeniKelime_MouseLeave(object sender, EventArgs e)
        {
            BtnYeniKelime.ForeColor = Color.Transparent;
        }

        private void btnGonder_MouseEnter(object sender, EventArgs e)
        {
            btnGonder.ForeColor = Color.Green;
        }

        private void btnGonder_MouseLeave(object sender, EventArgs e)
        {
            btnGonder.ForeColor = Color.Transparent;
        }
    }
}
