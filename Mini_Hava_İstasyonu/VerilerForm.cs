using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports; //kütüphaneyi dahil ediyoruz
using System.Data.OleDb; //Access Veri Tabanı Kütüphanesi

namespace Mini_Hava_İstasyonu
{
    public partial class VerilerForm : Form
    {
        public VerilerForm()
        {
            InitializeComponent();
        }

        private string[] portlar = SerialPort.GetPortNames(); //  bulduğu bütün portları portlar dizisine atar

        public void ConnectionSettings()
        {

            foreach (string port in portlar) //portlar dizisini foreach döngüsüyle taratıyoruz port değişkenine atıyoruz
            {
                comboBox1.Items.Add(port);
                comboBox1.SelectedIndex = 0;
            }
            try
            {
                comboBox2.Items.Add("4800");
                comboBox2.Items.Add("9600");
                comboBox2.SelectedIndex = 1;
                label20.Text = "Bağlantı Kapalı";
            }
            catch (Exception) { }

        }
        public bool YagisDurum = false;
        public void VerileriGetir()
        {
            try
            {
                string sonuc = serialPort1.ReadLine();
                string[] pot = sonuc.Split('*');
                lbl_sicak.Text = pot[0].ToString();
                lbl_nem.Text = pot[1].ToString();
                lbl_basinc.Text = pot[2].ToString();
                int yagmur = Convert.ToInt32(pot[3]);



                if (yagmur < 500)
                { lbl_yagmur.Text = "Yağmur Yağıyor"; YagisDurum = true; }
                else
                { lbl_yagmur.Text = "Yağmur Yok"; YagisDurum = false; }


                serialPort1.DiscardInBuffer(); // bağlantı kapatılırsa kalan veriyi çekmesini önler
            }
            catch (Exception)
            {
                timer1.Stop();
                MessageBox.Show("HATA !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); // Baudrate Seçiminiz Yanlışsa yeni veri geldikçe hata mesajı gelecektir!

            }
        }

        public void ArduinoConnection(ComboBox Portname, ComboBox BaudRate, Label label, Timer timer)
        {
            try
            {
                timer.Start();
                if (serialPort1.IsOpen == false)
                {
                    if (Portname.Text == "")
                        return;
                    serialPort1.PortName = Portname.Text;
                    serialPort1.BaudRate = Convert.ToInt32(BaudRate.Text);
                    try
                    {
                        serialPort1.Open();
                        label.Text = "Bağlantı Açık";
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("Hata Var" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    label.Text = "Bağlantı Kuruldu";
                }
            }
            catch (Exception)
            { }

        }

        public void DisConnection(Timer timer, Label baglantı)
        {
            try
            {
                timer.Stop();

                serialPort1.DiscardInBuffer();

                if (serialPort1.IsOpen == true)
                {
                    serialPort1.Close();
                    baglantı.Text = "Bağlantı Kapalı";
                }

                temizle();
            }
            catch (Exception)
            {

                MessageBox.Show("HATA!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        VerilerDal verilerDal = VerilerDal.Getİnstace();

        Form1 f1 = new Form1();



        public void VerilerAdd()
        {
            verilerDal.add(new Veriler
            {
                Tarih = DateTime.Now.ToLongDateString(),
                Sicaklik = int.Parse(lbl_sicak.Text),
                Nem = int.Parse(lbl_nem.Text),
                Basinc = Convert.ToDouble(lbl_basinc.Text),
                Yagis = YagisDurum
            });
        }

        public void temizle()
        {
            lbl_sicak.Text = "0";
            lbl_nem.Text = "0";
            lbl_basinc.Text = "0";
            lbl_yagmur.Text = "Yağmur yok";
        }

        public void Yenile()
        {
            dataGridView1.DataSource = verilerDal.Refresh();
        }

        public void SerialPortClose()
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();

            timer1.Stop();
        }

        public void ConnectionMenu()
        {

            if (panel_baglantı.Width == 0)
            {
                panel_baglantı.Visible = false;
                panel_baglantı.Width = 225;
                PanelAnimatorOpen.ShowSync(panel_baglantı);
            }
            else
            {
                panel_baglantı.Visible = false;
                panel_baglantı.Width = 0;
                PanelAnimatorOpen.ShowSync(panel_baglantı);
            }
        }


        private void VerilerForm_Load(object sender, EventArgs e)
        {
            Yenile();
            // SeriPort Ayarları Baudrate gibi
            ConnectionSettings();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Arduinodan Verileri Getirecek Method
            VerileriGetir();
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            //Veriler Tablosuna Kaydetme İşlemi 
            VerilerAdd();
            Yenile();
        }

        private void btn_baglanti_Click(object sender, EventArgs e)
        {
            //Arduino Bağlantısı
            ArduinoConnection(comboBox1, comboBox2, label20, timer1);
            VerileriGetir();
        }

        private void btn_BaglantiKapali_Click(object sender, EventArgs e)
        {
            //Arduino ile Bağlantıyı Kesme
            DisConnection(timer1, label20);
        }

        private void VerilerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //SerialPort Açıksa Kapat Timer i Durdur
            SerialPortClose();
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            //Verileri Komple Silme  /  Seçilen Veriyi Silmeye Gerek Olmadığını Düşündüm
            verilerDal.Delete();
            Yenile();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
