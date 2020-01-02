using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordMemorization
{
    public partial class FormVideo : Form
    {
        public FormVideo()
        {
            InitializeComponent();
        }

        private void axShockwaveFlash1_Enter(object sender, EventArgs e)
        {
            
        }

        private void FormVideo_Load(object sender, EventArgs e)

        {
            
            wpm1.URL = @"C:\Users\fatih\Desktop\Yeni klasör\FFF.mp4";
        }
    }
}
