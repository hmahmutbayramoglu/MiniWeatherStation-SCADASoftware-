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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private int sayac;

        private void Form3_Load(object sender, EventArgs e)
        {

            TimerOpen.Enabled = true;
            this.Opacity = 0.0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            // bekleme Süresi
            if (sayac == 10)
            {
                TimerClose.Enabled = true;
            }
        }


        private void TimerClose_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                TimerClose.Enabled = false;
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
        }

        private void TimerOpen_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0)
                this.Opacity += 0.1;
            else
                TimerOpen.Enabled = false;

       
        }
    }
}
