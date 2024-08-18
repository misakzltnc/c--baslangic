using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayiA = Convert.ToInt32(textBox1.Text);
            int sayiB = Convert.ToInt32(textBox2.Text);
            int sonuc = 0;
            for (int i = 0; i < sayiB; i++)
            {
                sonuc += sayiA;
            }
            label4.Text = sonuc.ToString();
        }
        int toplam = 0;
        int sayac = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox3.Text);
            if (sayi != 0)
            {
                toplam += sayi;
                sayac++;
                int sonuc = toplam / sayac;
                label7.Text = sonuc.ToString();
            }
            else
            {
                toplam = 0;
                sayac = 0;
                label7.Text = "0";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int[] sayilar = new int[20];
            Random rnd = new Random();
            int pozitifToplam = 0;
            int negatifToplam = 0;
            for (int i =0; i < 20; i++)
            {
                sayilar[i] = rnd.Next(-100, 100);
                if (sayilar[i] > 0)
                {
                    listBox1.Items.Add(sayilar[i]);
                    pozitifToplam += sayilar[i];
                }
                else 
                { 
                    listBox2.Items.Add(sayilar[i]);
                    negatifToplam += sayilar[i];
                }
                /*if (sayilar[i] > 0)
                {
                    pozitifToplam += sayilar[i];
                }
                else
                {
                    negatifToplam += sayilar[i];
                }*/
            }
            label10.Text = negatifToplam.ToString();
            label11.Text = pozitifToplam.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            sayi1 = Convert.ToInt32(textBox4.Text);
            sayi2 = Convert.ToInt32(textBox5.Text);
            int ekok = 0;
            int max = sayi1 * sayi2;
            for (int i = max; i>0; i--)
            {
                if (i%sayi1==0 && i % sayi2 == 0)
                {
                    ekok = i;
                }
            }
            label15.Text = ekok.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string sayi = textBox6.Text;
            string ters = "";
            for (int i = sayi.Length - 1; i >= 0; i--)
            {
                ters = ters + sayi[i];
            }
            label18.Text = ters;
            if (textBox6.Text == ters)
            {
                label20.Text = "EVET";
            }
            else { label20.Text = "HAYIR"; }
        }
    }
}
