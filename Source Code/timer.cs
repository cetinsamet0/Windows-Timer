using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Döngüler
{
    public partial class timer : Form
    {
        public timer()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        int saat = 0, dakika = 0, saniye = 0;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu uygulamanın amacı; siz işlerinizle ilgilenirken sizi rahatsız etmeden masaüstünüze yapışık bir şekilde, hiçbir simge göstermeden çalıştığı andan itibaren geçen zamanı saniye, dakika ve saat cinsinden ölçmeniz için tasarlanmış bir zamanlayıcıdır.", "Merhaba sayın kullanıcı");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            string webSayfasiURL = "https://github.com/cetinsamet0";
            Process.Start(webSayfasiURL);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label1.Text = saniye.ToString();
            if(saniye == 60)
            {
                dakika++;
                label2.Text = dakika.ToString();
                saniye = 0;
                if(dakika == 60)
                {
                    saat++;
                    label3.Text = saat.ToString();
                    dakika = 0;
                }
            }

        }
    }
}
