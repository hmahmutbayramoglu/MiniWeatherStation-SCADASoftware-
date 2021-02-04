namespace Mini_Hava_İstasyonu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_menu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_menu = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_bilgi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_istatistikler = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label21 = new System.Windows.Forms.Label();
            this.btn_baglantı = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_orta = new System.Windows.Forms.Panel();
            this.PanelAnimatorOpen = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelAnimatorClose = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimatorClose.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.bunifuImageButton1, "bunifuImageButton1");
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimatorClose.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.bunifuImageButton2, "bunifuImageButton2");
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Gray;
            this.PanelAnimatorOpen.SetDecoration(this.label19, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorClose.SetDecoration(this.label19, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // label44
            // 
            resources.ApplyResources(this.label44, "label44");
            this.PanelAnimatorOpen.SetDecoration(this.label44, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorClose.SetDecoration(this.label44, BunifuAnimatorNS.DecorationType.None);
            this.label44.ForeColor = System.Drawing.Color.White;
            this.label44.Name = "label44";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimatorOpen.SetDecoration(this.label14, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorClose.SetDecoration(this.label14, BunifuAnimatorNS.DecorationType.None);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Name = "label14";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.PanelAnimatorOpen.SetDecoration(this.label10, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorClose.SetDecoration(this.label10, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimatorOpen.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorClose.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // panel_menu
            // 
            resources.ApplyResources(this.panel_menu, "panel_menu");
            this.panel_menu.Controls.Add(this.btn_menu);
            this.panel_menu.Controls.Add(this.btn_bilgi);
            this.panel_menu.Controls.Add(this.btn_istatistikler);
            this.panel_menu.Controls.Add(this.label21);
            this.panel_menu.Controls.Add(this.btn_baglantı);
            this.panel_menu.Controls.Add(this.label1);
            this.panel_menu.Controls.Add(this.label10);
            this.panel_menu.Controls.Add(this.label14);
            this.PanelAnimatorClose.SetDecoration(this.panel_menu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.panel_menu, BunifuAnimatorNS.DecorationType.None);
            this.panel_menu.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel_menu.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel_menu.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel_menu.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Quality = 10;
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimatorClose.SetDecoration(this.btn_menu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.btn_menu, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.btn_menu, "btn_menu");
            this.btn_menu.ImageActive = null;
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.TabStop = false;
            this.btn_menu.Zoom = 10;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_bilgi
            // 
            this.btn_bilgi.Activecolor = System.Drawing.Color.Transparent;
            this.btn_bilgi.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_bilgi, "btn_bilgi");
            this.btn_bilgi.BorderRadius = 0;
            this.btn_bilgi.ButtonText = "Bilgi";
            this.btn_bilgi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimatorOpen.SetDecoration(this.btn_bilgi, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorClose.SetDecoration(this.btn_bilgi, BunifuAnimatorNS.DecorationType.None);
            this.btn_bilgi.DisabledColor = System.Drawing.Color.Gray;
            this.btn_bilgi.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_bilgi.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_bilgi.Iconimage")));
            this.btn_bilgi.Iconimage_right = null;
            this.btn_bilgi.Iconimage_right_Selected = null;
            this.btn_bilgi.Iconimage_Selected = null;
            this.btn_bilgi.IconMarginLeft = 0;
            this.btn_bilgi.IconMarginRight = 0;
            this.btn_bilgi.IconRightVisible = true;
            this.btn_bilgi.IconRightZoom = 0D;
            this.btn_bilgi.IconVisible = true;
            this.btn_bilgi.IconZoom = 40D;
            this.btn_bilgi.IsTab = false;
            this.btn_bilgi.Name = "btn_bilgi";
            this.btn_bilgi.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_bilgi.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_bilgi.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btn_bilgi.selected = false;
            this.btn_bilgi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_bilgi.Textcolor = System.Drawing.Color.White;
            this.btn_bilgi.TextFont = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bilgi.Click += new System.EventHandler(this.btn_bilgi_Click);
            // 
            // btn_istatistikler
            // 
            this.btn_istatistikler.Activecolor = System.Drawing.Color.Transparent;
            this.btn_istatistikler.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_istatistikler, "btn_istatistikler");
            this.btn_istatistikler.BorderRadius = 0;
            this.btn_istatistikler.ButtonText = "İstatistikler";
            this.btn_istatistikler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimatorOpen.SetDecoration(this.btn_istatistikler, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorClose.SetDecoration(this.btn_istatistikler, BunifuAnimatorNS.DecorationType.None);
            this.btn_istatistikler.DisabledColor = System.Drawing.Color.Gray;
            this.btn_istatistikler.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_istatistikler.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_istatistikler.Iconimage")));
            this.btn_istatistikler.Iconimage_right = null;
            this.btn_istatistikler.Iconimage_right_Selected = null;
            this.btn_istatistikler.Iconimage_Selected = null;
            this.btn_istatistikler.IconMarginLeft = 0;
            this.btn_istatistikler.IconMarginRight = 0;
            this.btn_istatistikler.IconRightVisible = true;
            this.btn_istatistikler.IconRightZoom = 0D;
            this.btn_istatistikler.IconVisible = true;
            this.btn_istatistikler.IconZoom = 40D;
            this.btn_istatistikler.IsTab = false;
            this.btn_istatistikler.Name = "btn_istatistikler";
            this.btn_istatistikler.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_istatistikler.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_istatistikler.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btn_istatistikler.selected = false;
            this.btn_istatistikler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_istatistikler.Textcolor = System.Drawing.Color.White;
            this.btn_istatistikler.TextFont = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_istatistikler.Click += new System.EventHandler(this.btn_istatistikler_Click);
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.White;
            this.PanelAnimatorOpen.SetDecoration(this.label21, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorClose.SetDecoration(this.label21, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // btn_baglantı
            // 
            this.btn_baglantı.Activecolor = System.Drawing.Color.Transparent;
            this.btn_baglantı.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_baglantı, "btn_baglantı");
            this.btn_baglantı.BorderRadius = 0;
            this.btn_baglantı.ButtonText = "Baglantı";
            this.btn_baglantı.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimatorOpen.SetDecoration(this.btn_baglantı, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorClose.SetDecoration(this.btn_baglantı, BunifuAnimatorNS.DecorationType.None);
            this.btn_baglantı.DisabledColor = System.Drawing.Color.Gray;
            this.btn_baglantı.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_baglantı.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_baglantı.Iconimage")));
            this.btn_baglantı.Iconimage_right = null;
            this.btn_baglantı.Iconimage_right_Selected = null;
            this.btn_baglantı.Iconimage_Selected = null;
            this.btn_baglantı.IconMarginLeft = 0;
            this.btn_baglantı.IconMarginRight = 0;
            this.btn_baglantı.IconRightVisible = true;
            this.btn_baglantı.IconRightZoom = 0D;
            this.btn_baglantı.IconVisible = true;
            this.btn_baglantı.IconZoom = 50D;
            this.btn_baglantı.IsTab = false;
            this.btn_baglantı.Name = "btn_baglantı";
            this.btn_baglantı.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_baglantı.OnHovercolor = System.Drawing.Color.Transparent;
            this.btn_baglantı.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(215)))), ((int)(((byte)(96)))));
            this.btn_baglantı.selected = false;
            this.btn_baglantı.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_baglantı.Textcolor = System.Drawing.Color.White;
            this.btn_baglantı.TextFont = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_baglantı.Click += new System.EventHandler(this.btn_baglantı_Click);
            // 
            // panel_orta
            // 
            this.panel_orta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.PanelAnimatorClose.SetDecoration(this.panel_orta, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.panel_orta, BunifuAnimatorNS.DecorationType.None);
            resources.ApplyResources(this.panel_orta, "panel_orta");
            this.panel_orta.Name = "panel_orta";
            // 
            // PanelAnimatorOpen
            // 
            this.PanelAnimatorOpen.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.PanelAnimatorOpen.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.PanelAnimatorOpen.DefaultAnimation = animation2;
            // 
            // PanelAnimatorClose
            // 
            this.PanelAnimatorClose.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.PanelAnimatorClose.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.PanelAnimatorClose.DefaultAnimation = animation1;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.panel_orta);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.PanelAnimatorClose.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Timer timer2;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuFlatButton btn_baglantı;
        private Bunifu.Framework.UI.BunifuFlatButton btn_bilgi;
        private Bunifu.Framework.UI.BunifuFlatButton btn_istatistikler;
        private System.Windows.Forms.Label label21;
        private Bunifu.Framework.UI.BunifuImageButton btn_menu;
        private System.Windows.Forms.Panel panel_orta;
        private BunifuAnimatorNS.BunifuTransition PanelAnimatorOpen;
        private BunifuAnimatorNS.BunifuTransition PanelAnimatorClose;
        public System.Windows.Forms.Label label44;
    }
}

