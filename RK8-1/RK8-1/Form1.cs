using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RK8_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] dizi = { 5, 28, 3, 65, 41, 23, 84, 12, 38 };

            int min = dizi[0]; // Minimum değeri dizinin ilk elemanıyla başlat
            int max = dizi[0]; // Maksimum değeri dizinin ilk elemanıyla başlat
            int i = 1;
            while (i < dizi.Length)
            {
                if (dizi[i] < min)
                    min = dizi[i];
                if (dizi[i] > max)
                    max = dizi[i];
                i++;
            }
            label4.Text = max.ToString();
            label5.Text = min.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            int basamakSayisi = 0;
            while (sayi > 0 )
            {
                basamakSayisi++;
                sayi /= 10; // Sayıyı 10'a böler ve virgülden sonrasını atar,her döngü adımında sayi değişkeni 10'a bölünerek bir basamak azaltılır.
            }
            label7.Text = basamakSayisi.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] dizi = { 5, 28, 3, 65, 41, 23, 84, 12, 38 };
            string ters = "";
            int i = dizi.Length - 1;
            while (i >= 0)
            {
                ters = ters + dizi[i];
                if (i>0) { ters += ","; }
                i--;
            }
            label10.Text = ters.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string metin = textBox2.Text;
            string kelime = "";
            int i = 0;
            int kelimeBaslangic = 0;
            while (i < metin.Length) // Döngü, metin boyunca devam etmeli ve i değeri metin uzunluğunu aşmamalıdır
            {
                while (i<metin.Length && metin[i] != ' ') // Boşluk karakterine kadar olan her karakteri kelimeye ekle
                {
                    kelime += metin[i];
                    i++;
                }
                listBox1.Items.Add(kelime);
                kelime = "";
                kelimeBaslangic = i + 1;     // Bir sonraki kelimenin başlangıç indeksini güncelle
                i++;
            }
        }
    }
}
