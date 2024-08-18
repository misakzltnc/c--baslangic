using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RK15_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            Random rnd = new Random();
            int sayi;
            for (int i = 1; i <= 10; i++)
            {
                sayi = rnd.Next(0, 100);
                listBox1.Items.Add(sayi);
                if (sayi % 2 == 0)
                {
                    listBox2.Items.Add(sayi);
                }
                if (sayi % 2 == 1)
                {
                    listBox3.Items.Add(sayi);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan sayıyı al
            int girilenSayi = Convert.ToInt32(textBox1.Text);

            // Sayının basamak sayısını hesapla
            int basamakSayisi = girilenSayi.ToString().Length;

            // Sonucu label'a yazdır
            label3.Text = "Basamak Sayısı: " + basamakSayisi.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kenar1, kenar2, kenar3, kenar4;
            kenar1 = Convert.ToInt32(textBox2.Text);
            kenar2 = Convert.ToInt32(textBox3.Text);
            kenar3 = Convert.ToInt32(textBox4.Text);
            kenar4 = Convert.ToInt32(textBox5.Text);
            if (kenar1 == kenar2 && kenar2 == kenar3 && kenar3 == kenar4)
            {
                label9.Text = "Kenarları girilen dörtgen karedir.";
            }
            else
            {
                label9.Text = "Kenarları girilen dörtgen kare değildir.";
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int acı1, acı2, acı3;
            acı1 = Convert.ToInt32(textBox6.Text);
            acı2 = Convert.ToInt32(textBox7.Text);
            acı3 = Convert.ToInt32(textBox8.Text);
            if (acı1 == acı2 && acı2 == acı3)
            {
                label14.Text = "EŞKENAR ÜÇGEN";
            }
            else if (acı1 == acı2 || acı1 == acı3 || acı2 == acı3)
            {
                label14.Text = "İKİZKENAR ÜÇGEN";
            }
            else
            {
                label14.Text = "ÇEŞİTKENAR ÜÇGEN";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayiA = Convert.ToInt32(textBox9.Text);
            int sayiB = Convert.ToInt32(textBox10.Text);
            int kalan = sayiA;
            int bolum = 0;
            for (int i = 0; i <= kalan; i++)
            {
                if (kalan >= sayiB)
                {
                    kalan -= sayiB;
                    bolum++;
                }
            }
            label18.Text = kalan.ToString();
            label20.Text = bolum.ToString();
        }
    }
}
