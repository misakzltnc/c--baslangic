using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programlama_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int [] dizi = { 5, 4, 56, 82, 1, 45, 63, 98, 47, 50, 26 };
            int min = dizi[0];
            int max = dizi[0];
            int i = 1;
            while (i < dizi.Length)
            {
                if (dizi[i] < min)
                    min= dizi[i];
                if (dizi[i] > max)
                    max= dizi[i];
                i++;
            }
            label3.Text=min.ToString();
            label5.Text=max.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            int bsmk = 0;
            while (sayi > 0)
            {
                bsmk++;
                sayi /= 10;
            }
            label6.Text=bsmk.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] dizi = { 5, 4, 56, 82, 1, 45, 63, 98, 47, 50, 26 };
            string ters = "";
            int i = dizi.Length - 1;
            while(i >= 0)
            {
                ters = ters + dizi[i];
                if (i>0) { ters += ","; }
                i--;
            }
            label8.Text=ters.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string metin = textBox2.Text;
            string kelime = "";
            int i = 0;
            int kelimebaslangic = 0;
            while (i < metin.Length)
            {
                while ( i< metin.Length && metin[i] != ' ') 
                {
                    kelime += metin[i];
                    i++;
                }
                listBox1.Items.Add(kelime);
                kelime = "";
                kelimebaslangic = i + 1;
                i++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string satir;
            listBox2.Items.Clear();
            int[,] matris = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                satir = "";
                for (int j = 0; j < 4; j++)
                {
                    matris[i, j] = rnd.Next(0, 11);
                    satir += matris[i, j]+ "        ";
                    
                }
                listBox2.Items.Add(satir);
            }
            // random 4x4 matris oluşturdum enb-enk bul
            int[] enBuyukler = new int[4];
            int[] enKucukler = new int[4];
            for ( int i = 0;i < 4; i++)
            {
                enBuyukler[i] = matris[i,0];
                enKucukler[i] = matris[i, 0];

                for (int j = 0;j < 4; j++)
                {
                    if (matris[i,j] > enBuyukler[i])
                        enBuyukler[i] = matris[i,j];
                    if (matris[i, j] < enKucukler[i])
                        enKucukler[i] = matris[i,j];
                }
            }
            label12.Text = enBuyukler[0].ToString();
            label11.Text = enKucukler[0].ToString();
            label14.Text = enBuyukler[1].ToString();
            label13.Text = enKucukler[1].ToString();
            label16.Text = enBuyukler[2].ToString();
            label15.Text = enKucukler[2].ToString();
            label18.Text = enBuyukler[3].ToString();
            label17.Text = enKucukler[3].ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[,] kisivgorev =
            {
                { "Ahmet Yılmazer" , "Büro Personeli" },
                 {"Ferdi Can Sağlam","Mühendis" },
                {"Ali Kaan Yeşil", "Yazılım Geliştirici" }
            };
            listBox3.Items.Clear();
            for (int i = 0; i<kisivgorev.GetLength(0); i++)
            {
                string satir = kisivgorev[i,0] + "     "  + kisivgorev[i,1];
                listBox3.Items.Add(satir);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilen = comboBox1.SelectedItem.ToString();

            string[,] kisivgorev =
            {
                { "Ahmet Yılmazer" , "Büro Personeli" },
                 {"Ferdi Can Sağlam","Mühendis" },
                {"Ali Kaan Yeşil", "Yazılım Geliştirici" }
            };

            listBox4.Items.Clear();
            for (int i = 0; i < kisivgorev.GetLength(0); i++)
            {
                if (kisivgorev[i,1] == secilen)
                {
                    string satir = kisivgorev[i, 0] + "     " + kisivgorev[i, 1];
                    listBox4.Items.Add(satir);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string satir;
            int toplaSatir = 0;
            int toplaSutun = 0;
            listBox5.Items.Clear();
            int[,] matris = new int [3,3];
            for (int i = 0; i<3 ; i++)
            {
                satir = "";
                for (int j = 0; j < 3 ; j++)
                {
                    matris[i, j] = rnd.Next(0, 11);
                    satir += matris[i, j] + "   ";

                }
                listBox5.Items.Add(satir);
            }

            //SÜTUN
            for(int i = 0;i<3 ; i++)
            {
                toplaSutun += matris[i, 0] + matris[i, 1];
            }
            label21.Text = toplaSutun.ToString();
            //SATIR
            for ( int i = 0; i<2 ; i++)
            {
                toplaSatir += matris[0, i] + matris[1, i];
            }
            label22.Text = toplaSatir.ToString();
        }
        int i = 0;

        private void button8_Click(object sender, EventArgs e)
        {
            string[,] soru = new string[,]
            {
                {"5+10 kaç eder?", "17", "15", "13"},
                {"İstiklal Marşı kaç kıtadır?", "10", "2", "8"},
                {"Atatürk kaç yılında doğmuştur?", "1938", "1881", "1883"},
                {"Romeo ve Juliet adlı eserin yazarı kimdir?", "Shakespeare", "Goethe", "Çehov"},
            };

            richTextBox1.Text = soru[i, 0];
            radioButton1.Text = soru[i, 1];
            radioButton2.Text = soru[i, 2];
            radioButton3.Text = soru[i, 3];
            button8.Text = "Sonraki Soru";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string cevap1, cevap2, cevap3, cevap4;
            cevap1 = "15";
            cevap2 = "10";
            cevap3 = "1881";
            cevap4 = "Shakespeare";
            string kullanıcıCevabı = "";
            if (radioButton1.Checked)
                kullanıcıCevabı = radioButton1.Text;
            else if (radioButton2.Checked)
                kullanıcıCevabı = radioButton2.Text;
            else if (radioButton3.Checked)
                kullanıcıCevabı = radioButton3.Text;

            if (kullanıcıCevabı == cevap1)
            {
                MessageBox.Show("Doğru");
                i++;
            }
            else if (kullanıcıCevabı == cevap2)
            {
                MessageBox.Show("Doğru");
                i++;
            }
            else if (kullanıcıCevabı == cevap3)
            {
                MessageBox.Show("Doğru");
                i++;
            }
            else if (kullanıcıCevabı == cevap4)
            {
                MessageBox.Show("Doğru, oyun bitti");
                button8.Enabled = false;
                i++;
            }
            else
            {
                MessageBox.Show("Yanlış");
            }
        }
    }
}
