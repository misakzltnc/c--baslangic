using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme5mart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hak, sayi;
        private void button1_Click(object sender, EventArgs e)
        {
            double vize, final, ortalama;
            vize = Convert.ToDouble(textBox1.Text);
            final = Convert.ToDouble(textBox2.Text);
            ortalama = vize * 0.4 + final * 0.6;
            label5.Text = Convert.ToString(ortalama);
            if (ortalama<50 &&final<50)
            { 
                label6.Text = Convert.ToString("KALDI");
                tabPage1.BackColor = Color.Red;
            }
           else
            { 
                label6.Text = Convert.ToString("GEÇTİ");
                tabPage1.BackColor = Color.Green;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            sayi = rnd.Next(0, 11);
            hak = 3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int tahmin = Convert.ToInt16(textBox3.Text);
            if(hak>0)
            {
                hak = hak - 1;
                label13.Text = hak.ToString();
                if(tahmin==sayi)
                {
                    MessageBox.Show("Bildiniz");
                }
                if (tahmin > sayi)
                {
                    label11.Text = tahmin.ToString();
                }
                if (tahmin < sayi) 
                {
                    label7.Text = tahmin.ToString();
                }
            }
            if (hak == 0)
            {
                MessageBox.Show("Game_Over");
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
