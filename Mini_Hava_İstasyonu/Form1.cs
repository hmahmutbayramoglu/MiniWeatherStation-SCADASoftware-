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
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private Form activeform = null;
        private void openchildform(Form childform)
        {
            if (activeform != null)
                activeform.Close();

            activeform = childform;

            childform.TopLevel = false;

            childform.FormBorderStyle = FormBorderStyle.None;

            childform.Dock = DockStyle.Fill;

            panel_orta.Controls.Add(childform);

            panel_orta.Tag = childform;

            childform.BringToFront();
            childform.Show();

        }

        public void MenuBtn()
        {
            if (panel_menu.Width == 221)
            {
                panel_menu.Visible = false;
                panel_menu.Width = 55;
                PanelAnimatorOpen.ShowSync(panel_menu);
            }
            else
            {
                panel_menu.Visible = false;
                panel_menu.Width = 221;
                PanelAnimatorOpen.ShowSync(panel_menu);
            }
        }

        //---------------------TASARIM-------------------------------

        #region FORMU HAREKET ETTİRME

        bool move;
        int mouse_x;
        int mouse_y;



        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }


        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }


        #endregion

        #region SİMGE KÜÇÜLTME BÜYÜLTME KAPATMA
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // this.WindowState = FormWindowState.Maximized;
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }




        #endregion

        //----------------------------------------------------------------------------------------------

            
        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            this.Opacity = 0.95;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Tarih
            label44.Text = DateTime.Now.ToString();
        }

        private void btn_baglantı_Click(object sender, EventArgs e)
        {
            openchildform(new VerilerForm());
            if (label21.Visible == false)
                label21.Visible = true;

            label21.Top = btn_baglantı.Top;
        }
       
        private void btn_menu_Click(object sender, EventArgs e)
        {
            //Sol Menünün açılış Kapanış animasyonunu gerçekleştiriyor
            MenuBtn();
        }

        private void btn_istatistikler_Click(object sender, EventArgs e)
        {
            openchildform(new istatistikler());
            if (label21.Visible == false)
                label21.Visible = true;

            label21.Top = btn_istatistikler.Top;
        }

        private void btn_bilgi_Click(object sender, EventArgs e)
        {
            openchildform(new BilgiForm());
            if (label21.Visible == false)
                label21.Visible = true;

            label21.Top = btn_bilgi.Top;
        }

    }
}
