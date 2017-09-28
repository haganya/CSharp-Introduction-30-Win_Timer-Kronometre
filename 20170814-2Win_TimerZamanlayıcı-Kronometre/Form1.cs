using System;
using System.Windows.Forms;

namespace _20170814_2Win_TimerZamanlayıcı_Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        byte saniye = 0, dakika = 0 , saat = 0 , gun = 0;
         

        private void timer1_Tick(object sender, EventArgs e)
        {

            lblSaniye.Text = saniye.ToString();
            lblDakika.Text = dakika.ToString();
            lblSaat.Text = saat.ToString();
            lblGun.Text = gun.ToString();

            saniye++;
            if (saniye >= 60)
            {
                saniye = 0;
                dakika++;
                if (dakika >= 60)
                {
                    dakika = 0;
                    saat++;
                    if (saat >= 24)
                    {
                        saat = 0;
                        gun++;
                    }
                }
            }
        }
    }
}
