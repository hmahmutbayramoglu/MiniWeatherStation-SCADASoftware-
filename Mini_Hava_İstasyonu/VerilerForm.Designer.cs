namespace Mini_Hava_İstasyonu
{
    partial class VerilerForm
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerilerForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_tahmin2 = new System.Windows.Forms.Label();
            this.lbl_tahmin3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_tahmin1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_yagmur = new System.Windows.Forms.Label();
            this.lbl_sicak = new System.Windows.Forms.Label();
            this.Btn_Sil = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.Btn_Kaydet = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_basinc = new System.Windows.Forms.Label();
            this.lbl_nem = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel_baglantı = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_baglanti = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_BaglantiKapali = new Bunifu.Framework.UI.BunifuImageButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PanelAnimatorClose = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Güncelle = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.PanelAnimatorOpen = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Sil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Kaydet)).BeginInit();
            this.panel_baglantı.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_baglanti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_BaglantiKapali)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimatorClose.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(46, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 65;
            this.label3.Text = "Sıcaklık C*";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.White;
            this.PanelAnimatorClose.SetDecoration(this.label15, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.label15, BunifuAnimatorNS.DecorationType.None);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(43, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 1);
            this.label15.TabIndex = 48;
            // 
            // lbl_tahmin2
            // 
            this.lbl_tahmin2.AutoSize = true;
            this.lbl_tahmin2.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimatorClose.SetDecoration(this.lbl_tahmin2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.lbl_tahmin2, BunifuAnimatorNS.DecorationType.None);
            this.lbl_tahmin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.lbl_tahmin2.ForeColor = System.Drawing.Color.White;
            this.lbl_tahmin2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_tahmin2.Location = new System.Drawing.Point(375, 140);
            this.lbl_tahmin2.Name = "lbl_tahmin2";
            this.lbl_tahmin2.Size = new System.Drawing.Size(62, 15);
            this.lbl_tahmin2.TabIndex = 63;
            this.lbl_tahmin2.Text = "-----------";
            // 
            // lbl_tahmin3
            // 
            this.lbl_tahmin3.AutoSize = true;
            this.lbl_tahmin3.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimatorClose.SetDecoration(this.lbl_tahmin3, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.lbl_tahmin3, BunifuAnimatorNS.DecorationType.None);
            this.lbl_tahmin3.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.lbl_tahmin3.ForeColor = System.Drawing.Color.White;
            this.lbl_tahmin3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_tahmin3.Location = new System.Drawing.Point(375, 167);
            this.lbl_tahmin3.Name = "lbl_tahmin3";
            this.lbl_tahmin3.Size = new System.Drawing.Size(57, 15);
            this.lbl_tahmin3.TabIndex = 62;
            this.lbl_tahmin3.Text = "----------";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.White;
            this.PanelAnimatorClose.SetDecoration(this.label16, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.label16, BunifuAnimatorNS.DecorationType.None);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(43, 134);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 1);
            this.label16.TabIndex = 50;
            // 
            // lbl_tahmin1
            // 
            this.lbl_tahmin1.AutoSize = true;
            this.lbl_tahmin1.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimatorClose.SetDecoration(this.lbl_tahmin1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.lbl_tahmin1, BunifuAnimatorNS.DecorationType.None);
            this.lbl_tahmin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.lbl_tahmin1.ForeColor = System.Drawing.Color.White;
            this.lbl_tahmin1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_tahmin1.Location = new System.Drawing.Point(375, 113);
            this.lbl_tahmin1.Name = "lbl_tahmin1";
            this.lbl_tahmin1.Size = new System.Drawing.Size(62, 15);
            this.lbl_tahmin1.TabIndex = 61;
            this.lbl_tahmin1.Text = "-----------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimatorClose.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(61, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Nem %";
            // 
            // lbl_yagmur
            // 
            this.lbl_yagmur.AutoSize = true;
            this.lbl_yagmur.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimatorClose.SetDecoration(this.lbl_yagmur, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.lbl_yagmur, BunifuAnimatorNS.DecorationType.None);
            this.lbl_yagmur.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.lbl_yagmur.ForeColor = System.Drawing.Color.White;
            this.lbl_yagmur.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_yagmur.Location = new System.Drawing.Point(170, 214);
            this.lbl_yagmur.Name = "lbl_yagmur";
            this.lbl_yagmur.Size = new System.Drawing.Size(81, 15);
            this.lbl_yagmur.TabIndex = 57;
            this.lbl_yagmur.Text = "Yağmur yok";
            // 
            // lbl_sicak
            // 
            this.lbl_sicak.AutoSize = true;
            this.lbl_sicak.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimatorClose.SetDecoration(this.lbl_sicak, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.lbl_sicak, BunifuAnimatorNS.DecorationType.None);
            this.lbl_sicak.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.lbl_sicak.ForeColor = System.Drawing.Color.White;
            this.lbl_sicak.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_sicak.Location = new System.Drawing.Point(170, 68);
            this.lbl_sicak.Name = "lbl_sicak";
            this.lbl_sicak.Size = new System.Drawing.Size(19, 20);
            this.lbl_sicak.TabIndex = 58;
            this.lbl_sicak.Text = "0";
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimatorOpen.SetDecoration(this.Btn_Sil, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorClose.SetDecoration(this.Btn_Sil, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Sil.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Sil.Image")));
            this.Btn_Sil.ImageActive = null;
            this.Btn_Sil.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_Sil.Location = new System.Drawing.Point(307, 167);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(45, 33);
            this.Btn_Sil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Sil.TabIndex = 56;
            this.Btn_Sil.TabStop = false;
            this.Btn_Sil.Zoom = 5;
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimatorOpen.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorClose.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuImageButton3.Location = new System.Drawing.Point(486, 193);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(43, 36);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 54;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // Btn_Kaydet
            // 
            this.Btn_Kaydet.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimatorOpen.SetDecoration(this.Btn_Kaydet, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorClose.SetDecoration(this.Btn_Kaydet, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Kaydet.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Kaydet.Image")));
            this.Btn_Kaydet.ImageActive = null;
            this.Btn_Kaydet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Btn_Kaydet.Location = new System.Drawing.Point(307, 206);
            this.Btn_Kaydet.Name = "Btn_Kaydet";
            this.Btn_Kaydet.Size = new System.Drawing.Size(45, 33);
            this.Btn_Kaydet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Kaydet.TabIndex = 55;
            this.Btn_Kaydet.TabStop = false;
            this.Btn_Kaydet.Zoom = 5;
            this.Btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // lbl_basinc
            // 
            this.lbl_basinc.AutoSize = true;
            this.lbl_basinc.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimatorClose.SetDecoration(this.lbl_basinc, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.lbl_basinc, BunifuAnimatorNS.DecorationType.None);
            this.lbl_basinc.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.lbl_basinc.ForeColor = System.Drawing.Color.White;
            this.lbl_basinc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_basinc.Location = new System.Drawing.Point(170, 163);
            this.lbl_basinc.Name = "lbl_basinc";
            this.lbl_basinc.Size = new System.Drawing.Size(19, 20);
            this.lbl_basinc.TabIndex = 59;
            this.lbl_basinc.Text = "0";
            // 
            // lbl_nem
            // 
            this.lbl_nem.AutoSize = true;
            this.lbl_nem.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimatorClose.SetDecoration(this.lbl_nem, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.lbl_nem, BunifuAnimatorNS.DecorationType.None);
            this.lbl_nem.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.lbl_nem.ForeColor = System.Drawing.Color.White;
            this.lbl_nem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_nem.Location = new System.Drawing.Point(170, 115);
            this.lbl_nem.Name = "lbl_nem";
            this.lbl_nem.Size = new System.Drawing.Size(19, 20);
            this.lbl_nem.TabIndex = 60;
            this.lbl_nem.Text = "0";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.PanelAnimatorClose.SetDecoration(this.label11, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.label11, BunifuAnimatorNS.DecorationType.None);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(358, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 1);
            this.label11.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimatorClose.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(43, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Basınç (Pa)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimatorClose.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Bauhaus 93", 11.25F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(357, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 16);
            this.label9.TabIndex = 52;
            this.label9.Text = "Tahminleri göster";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.White;
            this.PanelAnimatorClose.SetDecoration(this.label17, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.label17, BunifuAnimatorNS.DecorationType.None);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(43, 182);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 1);
            this.label17.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimatorClose.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(58, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Yağmur";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.White;
            this.PanelAnimatorClose.SetDecoration(this.label18, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.label18, BunifuAnimatorNS.DecorationType.None);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(43, 228);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 1);
            this.label18.TabIndex = 47;
            // 
            // panel_baglantı
            // 
            this.panel_baglantı.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_baglantı.BackgroundImage")));
            this.panel_baglantı.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_baglantı.Controls.Add(this.btn_baglanti);
            this.panel_baglantı.Controls.Add(this.btn_BaglantiKapali);
            this.panel_baglantı.Controls.Add(this.comboBox2);
            this.panel_baglantı.Controls.Add(this.label13);
            this.panel_baglantı.Controls.Add(this.label20);
            this.panel_baglantı.Controls.Add(this.label6);
            this.panel_baglantı.Controls.Add(this.label7);
            this.panel_baglantı.Controls.Add(this.comboBox1);
            this.panel_baglantı.Controls.Add(this.label12);
            this.PanelAnimatorOpen.SetDecoration(this.panel_baglantı, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorClose.SetDecoration(this.panel_baglantı, BunifuAnimatorNS.DecorationType.None);
            this.panel_baglantı.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_baglantı.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel_baglantı.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel_baglantı.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel_baglantı.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel_baglantı.Location = new System.Drawing.Point(0, 0);
            this.panel_baglantı.Name = "panel_baglantı";
            this.panel_baglantı.Quality = 10;
            this.panel_baglantı.Size = new System.Drawing.Size(223, 444);
            this.panel_baglantı.TabIndex = 66;
            // 
            // btn_baglanti
            // 
            this.btn_baglanti.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimatorOpen.SetDecoration(this.btn_baglanti, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorClose.SetDecoration(this.btn_baglanti, BunifuAnimatorNS.DecorationType.None);
            this.btn_baglanti.Image = ((System.Drawing.Image)(resources.GetObject("btn_baglanti.Image")));
            this.btn_baglanti.ImageActive = null;
            this.btn_baglanti.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_baglanti.Location = new System.Drawing.Point(60, 120);
            this.btn_baglanti.Name = "btn_baglanti";
            this.btn_baglanti.Size = new System.Drawing.Size(40, 37);
            this.btn_baglanti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_baglanti.TabIndex = 10;
            this.btn_baglanti.TabStop = false;
            this.btn_baglanti.Zoom = 10;
            this.btn_baglanti.Click += new System.EventHandler(this.btn_baglanti_Click);
            // 
            // btn_BaglantiKapali
            // 
            this.btn_BaglantiKapali.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimatorOpen.SetDecoration(this.btn_BaglantiKapali, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorClose.SetDecoration(this.btn_BaglantiKapali, BunifuAnimatorNS.DecorationType.None);
            this.btn_BaglantiKapali.Image = ((System.Drawing.Image)(resources.GetObject("btn_BaglantiKapali.Image")));
            this.btn_BaglantiKapali.ImageActive = null;
            this.btn_BaglantiKapali.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_BaglantiKapali.Location = new System.Drawing.Point(135, 120);
            this.btn_BaglantiKapali.Name = "btn_BaglantiKapali";
            this.btn_BaglantiKapali.Size = new System.Drawing.Size(40, 37);
            this.btn_BaglantiKapali.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_BaglantiKapali.TabIndex = 36;
            this.btn_BaglantiKapali.TabStop = false;
            this.btn_BaglantiKapali.Zoom = 10;
            this.btn_BaglantiKapali.Click += new System.EventHandler(this.btn_BaglantiKapali_Click);
            // 
            // comboBox2
            // 
            this.PanelAnimatorOpen.SetDecoration(this.comboBox2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorClose.SetDecoration(this.comboBox2, BunifuAnimatorNS.DecorationType.None);
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(91, 264);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Silver;
            this.PanelAnimatorClose.SetDecoration(this.label13, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.label13, BunifuAnimatorNS.DecorationType.None);
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(23, 289);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(190, 1);
            this.label13.TabIndex = 7;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimatorClose.SetDecoration(this.label20, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.label20, BunifuAnimatorNS.DecorationType.None);
            this.label20.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label20.Location = new System.Drawing.Point(79, 87);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 14);
            this.label20.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimatorClose.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.label6.ForeColor = System.Drawing.Color.GhostWhite;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(23, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "COM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimatorClose.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.label7.ForeColor = System.Drawing.Color.GhostWhite;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(22, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Budrate";
            // 
            // comboBox1
            // 
            this.PanelAnimatorOpen.SetDecoration(this.comboBox1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorClose.SetDecoration(this.comboBox1, BunifuAnimatorNS.DecorationType.None);
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 202);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Silver;
            this.PanelAnimatorClose.SetDecoration(this.label12, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.label12, BunifuAnimatorNS.DecorationType.None);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(22, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 1);
            this.label12.TabIndex = 7;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Güncelle);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.lbl_tahmin2);
            this.panel1.Controls.Add(this.Btn_Sil);
            this.panel1.Controls.Add(this.Btn_Kaydet);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbl_tahmin3);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.lbl_tahmin1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bunifuImageButton3);
            this.panel1.Controls.Add(this.lbl_nem);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lbl_basinc);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbl_sicak);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_yagmur);
            this.PanelAnimatorOpen.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorClose.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(223, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 444);
            this.panel1.TabIndex = 67;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_Güncelle
            // 
            this.btn_Güncelle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(189)))));
            this.btn_Güncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Güncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btn_Güncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Güncelle.BorderRadius = 0;
            this.btn_Güncelle.ButtonText = "Yenile";
            this.btn_Güncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimatorClose.SetDecoration(this.btn_Güncelle, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.btn_Güncelle, BunifuAnimatorNS.DecorationType.None);
            this.btn_Güncelle.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Güncelle.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Güncelle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Güncelle.Iconimage")));
            this.btn_Güncelle.Iconimage_right = null;
            this.btn_Güncelle.Iconimage_right_Selected = null;
            this.btn_Güncelle.Iconimage_Selected = null;
            this.btn_Güncelle.IconMarginLeft = 0;
            this.btn_Güncelle.IconMarginRight = 0;
            this.btn_Güncelle.IconRightVisible = true;
            this.btn_Güncelle.IconRightZoom = 0D;
            this.btn_Güncelle.IconVisible = true;
            this.btn_Güncelle.IconZoom = 90D;
            this.btn_Güncelle.IsTab = false;
            this.btn_Güncelle.Location = new System.Drawing.Point(263, 49);
            this.btn_Güncelle.Name = "btn_Güncelle";
            this.btn_Güncelle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btn_Güncelle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(189)))));
            this.btn_Güncelle.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Güncelle.selected = false;
            this.btn_Güncelle.Size = new System.Drawing.Size(129, 37);
            this.btn_Güncelle.TabIndex = 67;
            this.btn_Güncelle.Text = "Yenile";
            this.btn_Güncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Güncelle.Textcolor = System.Drawing.Color.White;
            this.btn_Güncelle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 22;
            this.PanelAnimatorClose.SetDecoration(this.dataGridView1, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorOpen.SetDecoration(this.dataGridView1, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.DimGray;
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 271);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(563, 173);
            this.dataGridView1.TabIndex = 66;
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
            // VerilerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(786, 444);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_baglantı);
            this.PanelAnimatorOpen.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimatorClose.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerilerForm";
            this.Text = "VerilerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VerilerForm_FormClosed);
            this.Load += new System.EventHandler(this.VerilerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Sil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Kaydet)).EndInit();
            this.panel_baglantı.ResumeLayout(false);
            this.panel_baglantı.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_baglanti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_BaglantiKapali)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_tahmin2;
        private System.Windows.Forms.Label lbl_tahmin3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_tahmin1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_yagmur;
        private System.Windows.Forms.Label lbl_sicak;
        private Bunifu.Framework.UI.BunifuImageButton Btn_Sil;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton Btn_Kaydet;
        private System.Windows.Forms.Label lbl_basinc;
        private System.Windows.Forms.Label lbl_nem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label18;
        private Bunifu.Framework.UI.BunifuGradientPanel panel_baglantı;
        private Bunifu.Framework.UI.BunifuImageButton btn_baglanti;
        private Bunifu.Framework.UI.BunifuImageButton btn_BaglantiKapali;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        protected System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private BunifuAnimatorNS.BunifuTransition PanelAnimatorClose;
        private BunifuAnimatorNS.BunifuTransition PanelAnimatorOpen;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Güncelle;
        public Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
    }
}