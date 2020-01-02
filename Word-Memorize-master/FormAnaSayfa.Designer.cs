namespace WordMemorization
{
    partial class FormAnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnaSayfa));
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnTumKelimeler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnKelimeSil = new DevExpress.XtraBars.BarButtonItem();
            this.BtnYazarakEzber = new DevExpress.XtraBars.BarButtonItem();
            this.BtnEskiKelimeler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnKelimeEkle = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.BtnIstatistik = new DevExpress.XtraBars.BarButtonItem();
            this.BtnİngilizceDüşünmek = new DevExpress.XtraBars.BarButtonItem();
            this.RibbonMainPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.BtnTumKelimeler,
            this.BtnKelimeSil,
            this.BtnYazarakEzber,
            this.BtnEskiKelimeler,
            this.BtnKelimeEkle,
            this.barButtonItem1,
            this.BtnIstatistik,
            this.BtnİngilizceDüşünmek});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.RibbonMainPage});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.TabletOffice;
            this.ribbonControl1.Size = new System.Drawing.Size(1072, 111);
            // 
            // BtnTumKelimeler
            // 
            this.BtnTumKelimeler.Caption = "Favori Kelimeler";
            this.BtnTumKelimeler.Id = 3;
            this.BtnTumKelimeler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnTumKelimeler.ImageOptions.Image")));
            this.BtnTumKelimeler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnTumKelimeler.ImageOptions.LargeImage")));
            this.BtnTumKelimeler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTumKelimeler.ItemAppearance.Normal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnTumKelimeler.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnTumKelimeler.ItemAppearance.Normal.Options.UseForeColor = true;
            this.BtnTumKelimeler.Name = "BtnTumKelimeler";
//            this.BtnTumKelimeler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnTumKelimeler_ItemClick);
            // 
            // BtnKelimeSil
            // 
            this.BtnKelimeSil.Caption = "Kelime Güncelle";
            this.BtnKelimeSil.Id = 4;
            this.BtnKelimeSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnKelimeGuncelle.ImageOptions.SvgImage")));
            this.BtnKelimeSil.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKelimeSil.ItemAppearance.Normal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnKelimeSil.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnKelimeSil.ItemAppearance.Normal.Options.UseForeColor = true;
            this.BtnKelimeSil.Name = "BtnKelimeSil";
            // 
            // BtnYazarakEzber
            // 
            this.BtnYazarakEzber.Caption = "Yazarak Ezber";
            this.BtnYazarakEzber.Id = 5;
            this.BtnYazarakEzber.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnYazarakEzber.ImageOptions.SvgImage")));
            this.BtnYazarakEzber.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYazarakEzber.ItemAppearance.Normal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnYazarakEzber.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnYazarakEzber.ItemAppearance.Normal.Options.UseForeColor = true;
            this.BtnYazarakEzber.Name = "BtnYazarakEzber";
            this.BtnYazarakEzber.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnYazarakEzber_ItemClick);
            // 
            // BtnEskiKelimeler
            // 
            this.BtnEskiKelimeler.Caption = "Eski Kelimeler";
            this.BtnEskiKelimeler.Id = 6;
            this.BtnEskiKelimeler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEskiKelimeler.ImageOptions.Image")));
            this.BtnEskiKelimeler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnEskiKelimeler.ImageOptions.LargeImage")));
            this.BtnEskiKelimeler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEskiKelimeler.ItemAppearance.Normal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnEskiKelimeler.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnEskiKelimeler.ItemAppearance.Normal.Options.UseForeColor = true;
            this.BtnEskiKelimeler.Name = "BtnEskiKelimeler";
            this.BtnEskiKelimeler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnEskiKelimeler_ItemClick);
            // 
            // BtnKelimeEkle
            // 
            this.BtnKelimeEkle.Caption = "Kelime Ekle";
            this.BtnKelimeEkle.Id = 7;
            this.BtnKelimeEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKelimeEkle.ImageOptions.Image")));
            this.BtnKelimeEkle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnKelimeEkle.ImageOptions.LargeImage")));
            this.BtnKelimeEkle.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKelimeEkle.ItemAppearance.Normal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnKelimeEkle.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnKelimeEkle.ItemAppearance.Normal.Options.UseForeColor = true;
            this.BtnKelimeEkle.Name = "BtnKelimeEkle";
            this.BtnKelimeEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnKelimeEkle_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // BtnIstatistik
            // 
            this.BtnIstatistik.Caption = "İstatistik";
            this.BtnIstatistik.Id = 9;
            this.BtnIstatistik.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnIstatistik.ImageOptions.Image")));
            this.BtnIstatistik.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnIstatistik.ImageOptions.LargeImage")));
            this.BtnIstatistik.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnIstatistik.ItemAppearance.Normal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnIstatistik.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnIstatistik.ItemAppearance.Normal.Options.UseForeColor = true;
            this.BtnIstatistik.Name = "BtnIstatistik";
            this.BtnIstatistik.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnIstatistik_ItemClick);
            // 
            // BtnİngilizceDüşünmek
            // 
            this.BtnİngilizceDüşünmek.Caption = "İngilizce Düşünmek ";
            this.BtnİngilizceDüşünmek.Id = 10;
            this.BtnİngilizceDüşünmek.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnİngilizceDüşünmek.ImageOptions.SvgImage")));
            this.BtnİngilizceDüşünmek.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnİngilizceDüşünmek.ItemAppearance.Normal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnİngilizceDüşünmek.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnİngilizceDüşünmek.ItemAppearance.Normal.Options.UseForeColor = true;
            this.BtnİngilizceDüşünmek.Name = "BtnİngilizceDüşünmek";
            this.BtnİngilizceDüşünmek.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // RibbonMainPage
            // 
            this.RibbonMainPage.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RibbonMainPage.Appearance.Options.UseFont = true;
            this.RibbonMainPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.RibbonMainPage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("RibbonMainPage.ImageOptions.Image")));
            this.RibbonMainPage.Name = "RibbonMainPage";
            this.RibbonMainPage.Text = "Ana Menü";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnYazarakEzber);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnEskiKelimeler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnIstatistik);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Ezber Yöntemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnKelimeEkle);
            this.ribbonPageGroup2.ItemLinks.Add(this.BtnİngilizceDüşünmek);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Yönetim";
            // 
            // FormAnaSayfa
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.Appearance.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 592);
            this.Controls.Add(this.ribbonControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAnaSayfa";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Word Memorization";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage RibbonMainPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem BtnTumKelimeler;
        private DevExpress.XtraBars.BarButtonItem BtnKelimeSil;
        private DevExpress.XtraBars.BarButtonItem BtnYazarakEzber;
        private DevExpress.XtraBars.BarButtonItem BtnEskiKelimeler;
        private DevExpress.XtraBars.BarButtonItem BtnKelimeEkle;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem BtnIstatistik;
        private DevExpress.XtraBars.BarButtonItem BtnİngilizceDüşünmek;
    }
}

