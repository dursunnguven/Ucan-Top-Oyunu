using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UçanTopOyunuYapımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int yerX = 5, yerY = 5, can = 3;

        private void CarpmaOlayi()
        {
            //lblüst çarpması
            if (btntop.Top <= lblustkenar.Bottom)
                yerY = yerY * -1;
            //kontrollü çarpma olayı
            if (btntop.Bottom >= btntahta.Top && btntop.Left >= btntahta.Left && btntop.Right <= btntahta.Right)
                yerY = yerY * -1;
            //sag kenara carpma olayı
            else if (btntop.Right >= lblsagkenar.Left)
                yerX = yerX * -1;
            //sol kenara carpma olayı
            else if (btntop.Left <= lblsolkenar.Right)
                yerX = yerX * -1;            
        }
        private void YanmaOlayi(object sender, EventArgs e) 
        {
            if (btntop.Top >= lblsagkenar.Bottom)
            {
                if (can > 0)
                {
                    timer1.Stop();
                    can--;
                    MessageBox.Show("Yandınız kalan can >=" + can.ToString());
                    Form1_Load(sender, e);

                }
                if (can == 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Oyun Bitti","", MessageBoxButtons.OK );
                }
            }
            lblcan.Text = can.ToString();
        }
        private void TopBasa()
        {
            btntop.Location = new Point(467, 464);
        }

        private void lblcan_Click(object sender, EventArgs e)
        {

        }

        private void btntahta_Click(object sender, EventArgs e)
        {

        }

        private void btntahta_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TopBasa();
            timer1.Enabled = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            btntahta.Left = e.X;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CarpmaOlayi();
            YanmaOlayi(sender , e);
            btntop.Location = new Point(btntop.Location.X + yerX, btntop.Location.Y + yerY);
        }
    }
}
