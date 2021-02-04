namespace Mini_Hava_İstasyonu
{
    partial class istatistikler
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(istatistikler));
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuCircleProgressbar2 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar3 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar4 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar6 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar10 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.ProgresBar_SicaklikOrt = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ProgresBar_OrtNem = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ProgresBar_OrtBasinc = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.lbl_SicaklikDeger = new System.Windows.Forms.Label();
            this.lbl_NemDeger = new System.Windows.Forms.Label();
            this.lbl_BasincDeger = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.Transparent;
            this.chart3.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart3.Legends.Add(legend1);
            this.chart3.Location = new System.Drawing.Point(210, 222);
            this.chart3.Name = "chart3";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(23)))), ((int)(((byte)(65)))));
            series1.Legend = "Legend1";
            series1.Name = "Sıcaklık";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(144)))));
            series2.Legend = "Legend1";
            series2.Name = "Nem";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(113)))));
            series3.Legend = "Legend1";
            series3.Name = "Basınc";
            this.chart3.Series.Add(series1);
            this.chart3.Series.Add(series2);
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(460, 196);
            this.chart3.TabIndex = 12;
            this.chart3.Text = "chart3";
            // 
            // bunifuCircleProgressbar2
            // 
            this.bunifuCircleProgressbar2.animated = true;
            this.bunifuCircleProgressbar2.animationIterval = 4;
            this.bunifuCircleProgressbar2.animationSpeed = 50;
            this.bunifuCircleProgressbar2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar2.BackgroundImage")));
            this.bunifuCircleProgressbar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuCircleProgressbar2.ForeColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar2.LabelVisible = true;
            this.bunifuCircleProgressbar2.LineProgressThickness = 4;
            this.bunifuCircleProgressbar2.LineThickness = 6;
            this.bunifuCircleProgressbar2.Location = new System.Drawing.Point(811, 13);
            this.bunifuCircleProgressbar2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.bunifuCircleProgressbar2.MaxValue = 100;
            this.bunifuCircleProgressbar2.Name = "bunifuCircleProgressbar2";
            this.bunifuCircleProgressbar2.ProgressBackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar2.ProgressColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar2.Size = new System.Drawing.Size(68, 68);
            this.bunifuCircleProgressbar2.TabIndex = 72;
            this.bunifuCircleProgressbar2.Value = 77;
            // 
            // bunifuCircleProgressbar3
            // 
            this.bunifuCircleProgressbar3.animated = true;
            this.bunifuCircleProgressbar3.animationIterval = 4;
            this.bunifuCircleProgressbar3.animationSpeed = 50;
            this.bunifuCircleProgressbar3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar3.BackgroundImage")));
            this.bunifuCircleProgressbar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuCircleProgressbar3.ForeColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar3.LabelVisible = true;
            this.bunifuCircleProgressbar3.LineProgressThickness = 4;
            this.bunifuCircleProgressbar3.LineThickness = 6;
            this.bunifuCircleProgressbar3.Location = new System.Drawing.Point(811, 241);
            this.bunifuCircleProgressbar3.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.bunifuCircleProgressbar3.MaxValue = 100;
            this.bunifuCircleProgressbar3.Name = "bunifuCircleProgressbar3";
            this.bunifuCircleProgressbar3.ProgressBackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar3.ProgressColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar3.Size = new System.Drawing.Size(68, 68);
            this.bunifuCircleProgressbar3.TabIndex = 73;
            this.bunifuCircleProgressbar3.Value = 56;
            // 
            // bunifuCircleProgressbar4
            // 
            this.bunifuCircleProgressbar4.animated = true;
            this.bunifuCircleProgressbar4.animationIterval = 4;
            this.bunifuCircleProgressbar4.animationSpeed = 50;
            this.bunifuCircleProgressbar4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar4.BackgroundImage")));
            this.bunifuCircleProgressbar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuCircleProgressbar4.ForeColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar4.LabelVisible = true;
            this.bunifuCircleProgressbar4.LineProgressThickness = 4;
            this.bunifuCircleProgressbar4.LineThickness = 6;
            this.bunifuCircleProgressbar4.Location = new System.Drawing.Point(811, 317);
            this.bunifuCircleProgressbar4.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.bunifuCircleProgressbar4.MaxValue = 100;
            this.bunifuCircleProgressbar4.Name = "bunifuCircleProgressbar4";
            this.bunifuCircleProgressbar4.ProgressBackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar4.ProgressColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar4.Size = new System.Drawing.Size(68, 68);
            this.bunifuCircleProgressbar4.TabIndex = 77;
            this.bunifuCircleProgressbar4.Value = 56;
            // 
            // bunifuCircleProgressbar6
            // 
            this.bunifuCircleProgressbar6.animated = true;
            this.bunifuCircleProgressbar6.animationIterval = 4;
            this.bunifuCircleProgressbar6.animationSpeed = 50;
            this.bunifuCircleProgressbar6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar6.BackgroundImage")));
            this.bunifuCircleProgressbar6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuCircleProgressbar6.ForeColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar6.LabelVisible = true;
            this.bunifuCircleProgressbar6.LineProgressThickness = 4;
            this.bunifuCircleProgressbar6.LineThickness = 6;
            this.bunifuCircleProgressbar6.Location = new System.Drawing.Point(811, 89);
            this.bunifuCircleProgressbar6.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.bunifuCircleProgressbar6.MaxValue = 100;
            this.bunifuCircleProgressbar6.Name = "bunifuCircleProgressbar6";
            this.bunifuCircleProgressbar6.ProgressBackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar6.ProgressColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar6.Size = new System.Drawing.Size(68, 68);
            this.bunifuCircleProgressbar6.TabIndex = 76;
            this.bunifuCircleProgressbar6.Value = 77;
            // 
            // bunifuCircleProgressbar10
            // 
            this.bunifuCircleProgressbar10.animated = true;
            this.bunifuCircleProgressbar10.animationIterval = 4;
            this.bunifuCircleProgressbar10.animationSpeed = 50;
            this.bunifuCircleProgressbar10.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar10.BackgroundImage")));
            this.bunifuCircleProgressbar10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuCircleProgressbar10.ForeColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar10.LabelVisible = true;
            this.bunifuCircleProgressbar10.LineProgressThickness = 4;
            this.bunifuCircleProgressbar10.LineThickness = 6;
            this.bunifuCircleProgressbar10.Location = new System.Drawing.Point(811, 165);
            this.bunifuCircleProgressbar10.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.bunifuCircleProgressbar10.MaxValue = 100;
            this.bunifuCircleProgressbar10.Name = "bunifuCircleProgressbar10";
            this.bunifuCircleProgressbar10.ProgressBackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar10.ProgressColor = System.Drawing.Color.White;
            this.bunifuCircleProgressbar10.Size = new System.Drawing.Size(68, 68);
            this.bunifuCircleProgressbar10.TabIndex = 80;
            this.bunifuCircleProgressbar10.Value = 77;
            // 
            // ProgresBar_SicaklikOrt
            // 
            this.ProgresBar_SicaklikOrt.animated = true;
            this.ProgresBar_SicaklikOrt.animationIterval = 4;
            this.ProgresBar_SicaklikOrt.animationSpeed = 50;
            this.ProgresBar_SicaklikOrt.BackColor = System.Drawing.Color.Transparent;
            this.ProgresBar_SicaklikOrt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProgresBar_SicaklikOrt.BackgroundImage")));
            this.ProgresBar_SicaklikOrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProgresBar_SicaklikOrt.ForeColor = System.Drawing.Color.White;
            this.ProgresBar_SicaklikOrt.LabelVisible = false;
            this.ProgresBar_SicaklikOrt.LineProgressThickness = 4;
            this.ProgresBar_SicaklikOrt.LineThickness = 6;
            this.ProgresBar_SicaklikOrt.Location = new System.Drawing.Point(19, 28);
            this.ProgresBar_SicaklikOrt.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.ProgresBar_SicaklikOrt.MaxValue = 100;
            this.ProgresBar_SicaklikOrt.Name = "ProgresBar_SicaklikOrt";
            this.ProgresBar_SicaklikOrt.ProgressBackColor = System.Drawing.Color.Transparent;
            this.ProgresBar_SicaklikOrt.ProgressColor = System.Drawing.Color.White;
            this.ProgresBar_SicaklikOrt.Size = new System.Drawing.Size(109, 109);
            this.ProgresBar_SicaklikOrt.TabIndex = 82;
            this.ProgresBar_SicaklikOrt.Value = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 83;
            this.label1.Text = "Ortalama Sıcaklık";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_SicaklikDeger);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ProgresBar_SicaklikOrt);
            this.panel1.Location = new System.Drawing.Point(207, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 141);
            this.panel1.TabIndex = 84;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbl_NemDeger);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ProgresBar_OrtNem);
            this.panel2.Location = new System.Drawing.Point(365, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 141);
            this.panel2.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 83;
            this.label2.Text = "Ortalama Nem";
            // 
            // ProgresBar_OrtNem
            // 
            this.ProgresBar_OrtNem.animated = true;
            this.ProgresBar_OrtNem.animationIterval = 4;
            this.ProgresBar_OrtNem.animationSpeed = 50;
            this.ProgresBar_OrtNem.BackColor = System.Drawing.Color.Transparent;
            this.ProgresBar_OrtNem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProgresBar_OrtNem.BackgroundImage")));
            this.ProgresBar_OrtNem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProgresBar_OrtNem.ForeColor = System.Drawing.Color.White;
            this.ProgresBar_OrtNem.LabelVisible = false;
            this.ProgresBar_OrtNem.LineProgressThickness = 4;
            this.ProgresBar_OrtNem.LineThickness = 6;
            this.ProgresBar_OrtNem.Location = new System.Drawing.Point(19, 28);
            this.ProgresBar_OrtNem.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.ProgresBar_OrtNem.MaxValue = 100;
            this.ProgresBar_OrtNem.Name = "ProgresBar_OrtNem";
            this.ProgresBar_OrtNem.ProgressBackColor = System.Drawing.Color.Transparent;
            this.ProgresBar_OrtNem.ProgressColor = System.Drawing.Color.White;
            this.ProgresBar_OrtNem.Size = new System.Drawing.Size(109, 109);
            this.ProgresBar_OrtNem.TabIndex = 82;
            this.ProgresBar_OrtNem.Value = 56;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbl_BasincDeger);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.ProgresBar_OrtBasinc);
            this.panel3.Location = new System.Drawing.Point(523, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 141);
            this.panel3.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 83;
            this.label3.Text = "Ortalama Basınç";
            // 
            // ProgresBar_OrtBasinc
            // 
            this.ProgresBar_OrtBasinc.animated = true;
            this.ProgresBar_OrtBasinc.animationIterval = 4;
            this.ProgresBar_OrtBasinc.animationSpeed = 50;
            this.ProgresBar_OrtBasinc.BackColor = System.Drawing.Color.Transparent;
            this.ProgresBar_OrtBasinc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProgresBar_OrtBasinc.BackgroundImage")));
            this.ProgresBar_OrtBasinc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProgresBar_OrtBasinc.ForeColor = System.Drawing.Color.White;
            this.ProgresBar_OrtBasinc.LabelVisible = false;
            this.ProgresBar_OrtBasinc.LineProgressThickness = 4;
            this.ProgresBar_OrtBasinc.LineThickness = 6;
            this.ProgresBar_OrtBasinc.Location = new System.Drawing.Point(19, 28);
            this.ProgresBar_OrtBasinc.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.ProgresBar_OrtBasinc.MaxValue = 100;
            this.ProgresBar_OrtBasinc.Name = "ProgresBar_OrtBasinc";
            this.ProgresBar_OrtBasinc.ProgressBackColor = System.Drawing.Color.Transparent;
            this.ProgresBar_OrtBasinc.ProgressColor = System.Drawing.Color.White;
            this.ProgresBar_OrtBasinc.Size = new System.Drawing.Size(109, 109);
            this.ProgresBar_OrtBasinc.TabIndex = 82;
            this.ProgresBar_OrtBasinc.Value = 56;
            // 
            // lbl_SicaklikDeger
            // 
            this.lbl_SicaklikDeger.AutoSize = true;
            this.lbl_SicaklikDeger.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_SicaklikDeger.ForeColor = System.Drawing.Color.White;
            this.lbl_SicaklikDeger.Location = new System.Drawing.Point(59, 75);
            this.lbl_SicaklikDeger.Name = "lbl_SicaklikDeger";
            this.lbl_SicaklikDeger.Size = new System.Drawing.Size(31, 15);
            this.lbl_SicaklikDeger.TabIndex = 87;
            this.lbl_SicaklikDeger.Text = "100";
            // 
            // lbl_NemDeger
            // 
            this.lbl_NemDeger.AutoSize = true;
            this.lbl_NemDeger.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_NemDeger.ForeColor = System.Drawing.Color.White;
            this.lbl_NemDeger.Location = new System.Drawing.Point(58, 75);
            this.lbl_NemDeger.Name = "lbl_NemDeger";
            this.lbl_NemDeger.Size = new System.Drawing.Size(31, 15);
            this.lbl_NemDeger.TabIndex = 88;
            this.lbl_NemDeger.Text = "100";
            // 
            // lbl_BasincDeger
            // 
            this.lbl_BasincDeger.AutoSize = true;
            this.lbl_BasincDeger.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_BasincDeger.ForeColor = System.Drawing.Color.White;
            this.lbl_BasincDeger.Location = new System.Drawing.Point(58, 75);
            this.lbl_BasincDeger.Name = "lbl_BasincDeger";
            this.lbl_BasincDeger.Size = new System.Drawing.Size(31, 15);
            this.lbl_BasincDeger.TabIndex = 89;
            this.lbl_BasincDeger.Text = "100";
            // 
            // istatistikler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(936, 444);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuCircleProgressbar10);
            this.Controls.Add(this.bunifuCircleProgressbar4);
            this.Controls.Add(this.bunifuCircleProgressbar6);
            this.Controls.Add(this.bunifuCircleProgressbar3);
            this.Controls.Add(this.bunifuCircleProgressbar2);
            this.Controls.Add(this.chart3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "istatistikler";
            this.Text = "istatistikler";
            this.Load += new System.EventHandler(this.istatistikler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar2;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar3;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar4;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar6;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar10;
        private Bunifu.Framework.UI.BunifuCircleProgressbar ProgresBar_SicaklikOrt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCircleProgressbar ProgresBar_OrtNem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCircleProgressbar ProgresBar_OrtBasinc;
        private System.Windows.Forms.Label lbl_SicaklikDeger;
        private System.Windows.Forms.Label lbl_NemDeger;
        private System.Windows.Forms.Label lbl_BasincDeger;
    }
}