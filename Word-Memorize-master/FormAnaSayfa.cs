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
    public partial class FormAnaSayfa : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormAnaSayfa()
        {
            InitializeComponent();
        }
       
        FormKelimeEkle fk;
        private void BtnKelimeEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                fk=new FormKelimeEkle();
                fk.MdiParent = this;
                fk.Show();
        }
        
        FormYazarak fy;
        private void BtnYazarakEzber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fy = new FormYazarak();
            fy.MdiParent = this;
            fy.Show();
        }
        FormEskiKelimeler fek;
        private void BtnEskiKelimeler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fek = new FormEskiKelimeler();
            fek.MdiParent = this;
            fek.Show();
        }
        FormVideo frmvd;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmvd = new FormVideo();
            frmvd.MdiParent = this;
            frmvd.Show();
        }
        FormIstatistik fı;
        private void BtnIstatistik_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fı = new FormIstatistik();
            fı.MdiParent = this;
            fı.Show();
        }
    }
}
