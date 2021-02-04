using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Hava_İstasyonu
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Opacity =89;
        }

        private void Form2_Click(object sender, EventArgs e)
        {

        }

        LogınControl logınControl = new LogınControl();

        public void Logın()
        {
            try
            {
                string command = "Select *from Güvenlik where ad ='" + txt_user.Text + "' And sifre = '" + txt_password.Text + "'";
                if (logınControl.Control(command) == true)
                {
                    Form1 form1 = new Form1();
                    this.Hide();
                    form1.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş", "Tekrar Deneyiniz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
            }
        }

        private void Btn_Logın_Click(object sender, EventArgs e)
        {
            //Veri Tabanından Giriş İçin Bilgileri Kontrol Ediyor
            Logın();
        }

        #region FORM HAREKET ETTİRME
        bool move;
        int mouse_x;
        int mouse_y;

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {

            label1.BackColor = Color.FromArgb(234, 234, 234);

            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
                this.Opacity = 0.87;
            }
            else
            {
                this.Opacity = 0.95;
            }

        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }


        #endregion

        private void bunifuCustomLabel1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.BackColor = Color.FromArgb(0, 183, 159);
        }

    }
}
