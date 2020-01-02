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
using System.Data.OleDb;

namespace WordMemorization
{
    public partial class FormYazarak : Form
    {
        public FormYazarak()
        {
            InitializeComponent();
        }
        SqlBaglantisi sb = new SqlBaglantisi();
        private void BtnBasla_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Başlamak İstediğine Emin misin ?? :) ", "BİLGİ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Visible();
            }
            if (dr == DialogResult.No)
            {
                MessageBox.Show("Hazır Olduğunda Tekrar Gel Biz Bekliyor Olacağız :D", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (TxtKelime2.Text == lblTemp.Text && TxtKelime2.Text != "")
            {
                AsamaNoGuncelle();
                TarihGuncelle();
                IstatistikArttir("Word_Dogru");
                ////////////////////////
                MessageBox.Show("TEBRİKLER KELİMEYİ BİLDİNİZ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtKelime1.Text = "";
                TxtKelime2.Text = "";
            }
            else if(TxtKelime2.Text=="" || TxtKelime1.Text == "")
            {
                MessageBox.Show("Lütfen Veri Giriniz");
            }
            else
            {
                IstatistikArttir("Word_Yanlis");
                MessageBox.Show("YANLIŞ CEVAP LÜTFEN DOĞRUSUN YAZINIZ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BtnYeniKelime_Click(object sender, EventArgs e)
        {
            KelimeGetir();
        }
        
        void KelimeGetir()
        {
            SqlCommand komut = new SqlCommand("SELECT TOP 1 Word_Ingilizce,Word_Turkce,Word_Level FROM Tbl_Word WHERE Word_Level=0 ORDER BY NEWID() ", sb.Baglanti());
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
        void Visible()
        {
            label2.Visible = false;
            TxtKelime1.Visible = true;
            TxtKelime2.Visible = true;
            btnGonder.Visible = true;
            BtnYeniKelime.Visible = true;
            BtnBasla.Visible = false;
            pictureBox1.Visible = false;
            label1.Visible = false;
            label3.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
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
                SqlCommand sc = new SqlCommand("UPDATE Tbl_Word SET Word_Date=DATEADD(DAY,365,Word_Date) WHERE Word_Turkce='" + TxtKelime2.Text + "'", sb.Baglanti());
                sc.ExecuteNonQuery();
            }
            sb.Baglanti().Dispose();
            sb.Baglanti().Close();
        }
        void AsamaNoGuncelle()
        {
            SqlCommand sc = new SqlCommand("UPDATE Tbl_Word SET Word_Level +=1	WHERE Word_Turkce='" + TxtKelime2.Text + "'", sb.Baglanti());
            sc.ExecuteNonQuery();
            sb.Baglanti().Dispose();
            sb.Baglanti().Close();
        }
        void IstatistikArttir(string p1)
        {
            SqlCommand sc = new SqlCommand("UPDATE Tbl_Istatistik SET "+p1+"+=1", sb.Baglanti());
            sc.ExecuteNonQuery();
            sb.Baglanti().Dispose();
            sb.Baglanti().Close();
        }
        

        private void btnGonder_MouseEnter(object sender, EventArgs e)
        {
            btnGonder.ForeColor = Color.Green;
        }

        private void btnGonder_MouseLeave(object sender, EventArgs e)
        {
            btnGonder.ForeColor = Color.Transparent;
        }

        private void BtnYeniKelime_MouseEnter(object sender, EventArgs e)
        {
            BtnYeniKelime.ForeColor = Color.HotPink;
        }

        private void BtnYeniKelime_MouseLeave(object sender, EventArgs e)
        {
            BtnYeniKelime.ForeColor = Color.Transparent;
        }

        private void BtnFavorilereEkle_MouseEnter(object sender, EventArgs e)
        {
            BtnFavorilereEkle.ForeColor = Color.Tomato;
        }

        private void BtnFavorilereEkle_MouseLeave(object sender, EventArgs e)
        {
            BtnFavorilereEkle.ForeColor = Color.Transparent;
        }

    }
}
