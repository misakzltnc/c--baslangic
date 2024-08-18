using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RK15_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string karakter = textBox2.Text;
            char[] metin = textBox1.Text.ToCharArray();
            int sayac = 0;
            for (int i = 0; i< metin.Length; i++)
            {
                if (karakter == metin[i].ToString())
                {
                    sayac++;
                }
            }
            if (sayac != 0)
            {
                label4.Text = sayac.ToString();
            }
            if (sayac == 0)
            {
                label4.Text = "Karakter Bulunamadı";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
           //nt[] dizi = { 13, 34, 56, 86, 32, 89, 90, 36, 63, 42, 51, 18 };
           //istBox1.Items.Add(dizi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] dizi = { 13, 34, 56, 86, 32, 89, 90, 36, 63, 42, 51, 18 };
            listBox1.Items.Clear();
            for ( int i =0; i< dizi.Length; i++)
            {
                listBox1.Items.Add(dizi[i]);
            }
            int sayi = Convert.ToInt32(textBox3.Text);
            int sayac = 0;
            for (int i =0; i < dizi.Length; i++)
            {
                if (sayi<dizi[i])
                {
                    sayac++;
                }
            }
            label7.Text = sayac.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] seri = { 1, 45, 62, 36, 21, 48, 56, 58 };
            string ters = "";
            for (int i = seri.Length - 1; i >= 0; i--)
            {
                ters = ters + seri[i];
                if (i > 0) { ters += ","; }
            }
            label11.Text = ters;
        }
        int topla = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox4.Text);
            if ( sayi !=0)
            {
                topla += sayi;
                label14.Text = topla.ToString();
            }   
            else
            {
                topla = 0;
                label14.Text = topla.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int yil = Convert.ToInt32(textBox5.Text);
            if (yil % 4 == 0 && yil % 100 != 0)
            {
                label20.Text = "artık yıldır";
            }
            if (yil % 400 == 0)
            {
                label20.Text = "artık yıldır";
            }
            else
            {
                label20.Text =  "artık yıl değildir";
            }
        }
    }
}
