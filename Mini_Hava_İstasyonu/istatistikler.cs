using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Mini_Hava_İstasyonu
{
    public partial class istatistikler : Form
    {
        public istatistikler()
        {
            InitializeComponent();
        }
        VerilerDal verilerDal = VerilerDal.Getİnstace();
        ConnectionString Connection = ConnectionString.Getİnstance();
        public void İstatistikler()
        {
            //verilerDal.connection.Open();
            //OleDbCommand komut = new OleDbCommand("Select  Basınc,Nem,Sıcaklık,Tarih,Yagmur from Veriler ", verilerDal.connection);

            //OleDbDataReader oku = komut.ExecuteReader();
            //while (oku.Read())
            //{
            //    chart1.Series["Sıcaklık"].Points.AddXY(oku[3].ToString(),oku[2].ToString());
            //    chart1.Series["Nem"].Points.AddXY(oku[3].ToString(), oku[1].ToString());



            //    chart3.Series["Basınc"].Points.AddXY(oku[3].ToString(), oku[0].ToString());
            //    chart4.Series["Yagmur"].Points.AddXY(oku[3].ToString(), oku[4].ToString());
            //}
            //verilerDal.connection.Close();
        }

        private void istatistikler_Load(object sender, EventArgs e)
        {

            try
            {
                ProgresBar_SicaklikOrt.Value = verilerDal.Ort("Select avg(Sicaklik) from Veriler ");
                lbl_SicaklikDeger.Text = ProgresBar_SicaklikOrt.Value.ToString() + " °C";

                ProgresBar_OrtNem.Value = verilerDal.Ort("Select avg(Nem) from Veriler ");
                lbl_NemDeger.Text = ProgresBar_OrtNem.Value.ToString() + "%";

                ProgresBar_OrtBasinc.Value = verilerDal.Ort("Select avg(Basinc) from Veriler ");
                lbl_BasincDeger.Text = ProgresBar_OrtBasinc.Value.ToString() + " Pa";
            }
            catch (Exception)
            {
                MessageBox.Show("Value Average Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         


        }

        private void bunifuGradientPanel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
