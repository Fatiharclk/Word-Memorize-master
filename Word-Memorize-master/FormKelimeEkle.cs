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
    public partial class FormKelimeEkle : Form
    {
        public FormKelimeEkle()
        {
            InitializeComponent();
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlBaglantisi sb = new SqlBaglantisi();
                string date = DateTime.Now.ToShortDateString();
                SqlCommand sc = new SqlCommand("INSERT INTO Tbl_Word (Word_Ingilizce,Word_Turkce,Word_Level,Word_Date) values (@p1,@p2,@p3,@p4)", sb.Baglanti());
                sc.Parameters.AddWithValue("@p1", TxtIngilizce.Text);
                sc.Parameters.AddWithValue("@p2", TxtTurkce.Text);
                sc.Parameters.AddWithValue("@p3", '0');
                sc.Parameters.AddWithValue("@p4", Convert.ToDateTime(date));
                sc.ExecuteNonQuery();
                sb.Baglanti().Dispose();
                sb.Baglanti().Close();
                MessageBox.Show("Kelime Sisteme Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtIngilizce.Text = "";
                TxtTurkce.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEkle_MouseEnter(object sender, EventArgs e)
        {
            BtnEkle.ForeColor = Color.Yellow;
        }

        private void BtnEkle_MouseLeave(object sender, EventArgs e)
        {
            BtnEkle.ForeColor = Color.Transparent;
        }

        private void labelControl3_MouseEnter(object sender, EventArgs e)
        {
            labelControl3.ForeColor = Color.SteelBlue;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Green;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.HotPink;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.IndianRed;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Gold;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.Blue;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Purple;

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.BackColor = Color.Salmon;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.SeaShell;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.Tomato;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.Blue;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Purple;
        }

        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            pictureBox9.BackColor = Color.Salmon;
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.SeaShell;
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.BackColor = Color.Tomato;
        }
    }
}
