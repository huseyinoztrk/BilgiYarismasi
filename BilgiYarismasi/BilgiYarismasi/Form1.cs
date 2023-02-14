using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sorunumarasi = 0, dogrusayisi = 0, yanlissayisi = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;


            label5.Text = BtnB.Text;
            if (label4.Text == label5.Text)
            {
                dogrusayisi++;
                LblSoruNumarasi.Text = dogrusayisi.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlissayisi++;
                LblYanlisSayisi.Text = yanlissayisi.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;


            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                dogrusayisi++;
                LblSoruNumarasi.Text = dogrusayisi.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlissayisi++;
                LblYanlisSayisi.Text = yanlissayisi.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;


            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                dogrusayisi++;
                LblSoruNumarasi.Text = dogrusayisi.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlissayisi++;
                LblYanlisSayisi.Text = yanlissayisi.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;


            label5.Text = BtnA.Text;
            if (label4.Text == label5.Text)
            {
                dogrusayisi++;
                LblSoruNumarasi.Text=dogrusayisi.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlissayisi++;
                LblYanlisSayisi.Text=yanlissayisi.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            sorunumarasi++;
            LblSoruNumarasi.Text = sorunumarasi.ToString();

            if (sorunumarasi == 1)
            {
                richTextBox1.Text = "Atatürk'ün doğum tarihi aşağıdaki şıklardan hangisinde doğru verilmiştir?";
                BtnA.Text = "1880";
                BtnB.Text = "1881";
                BtnC.Text = "1882";
                BtnD.Text = "1883";
                label4.Text = "1881";
            }
            if(sorunumarasi == 2)
            {
                richTextBox1.Text = "Türkiye'nin başkenti hangisidir?";
                BtnA.Text = "İstanbul";
                BtnB.Text = "Sakarya";
                BtnC.Text = "İzmir";
                BtnD.Text = "Ankara";
                label4.Text = "Ankara";
            }
            if (sorunumarasi == 3)
            {
                richTextBox1.Text = "İstiklal marşının yazarı kimdir?";
                BtnA.Text = "Mehmet Akif Ersoy";
                BtnB.Text = "Edgar Manas";
                BtnC.Text = "Osman Zeki Üngör";
                BtnD.Text = "Ali Rıfat Çağatay";
                label4.Text = "Mehmet Akif Ersoy";
                BtnSonraki.Text = "Sonuçlar";
            }
            if (sorunumarasi == 4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Doğru: " + dogrusayisi + "\n" + "Yanlış: " + yanlissayisi,"Sonuçlar");
            }
        }
    }
}
