using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RK4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int basla, bitir;
            basla = Convert.ToInt16(textBox1.Text);
            bitir = Convert.ToInt16(textBox2.Text);
            for (int i = basla; i <= bitir; i++)
            {
                if (radioButton1.Checked == true)
                {
                    if (i % 2 == 0)
                    {
                        listBox1.Items.Add(i.ToString());
                    }
                }
                if (radioButton2.Checked == true)
                {
                    if (i % 3 == 0)
                    {
                        listBox1.Items.Add(i.ToString());
                    }
                }
                if (radioButton3.Checked == true)
                {
                    if (i % 5 == 0)
                    {
                        listBox1.Items.Add(i.ToString());
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            Random rnd = new Random();
            int sayi;
            int enk = Convert.ToInt16(textBox3.Text);
            int enb = Convert.ToInt16(textBox5.Text) + 1;
            int minSayi = enb;
            int maxSayi = enk;

            for (int i = 0; i <= 10; i++)
            {
                sayi = rnd.Next(enk, enb);
                listBox2.Items.Add(sayi);
                if (sayi < minSayi) minSayi = sayi;
                if (sayi > maxSayi) maxSayi = sayi;
            }
            label11.Text = maxSayi.ToString();
            label12.Text = minSayi.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi;
            if (int.TryParse(textBox6.Text, out sayi))
            {
                int toplam = 0;
                string bolenler = "";
                for (int i = 1; i <= sayi / 2; i++)
                {
                    if (sayi % i == 0)
                    {
                        toplam += i;
                        if (bolenler != "")
                            bolenler += "+";
                        bolenler += i.ToString();
                    }
                }
                label13.Text = $"{bolenler} = {toplam}";
                if (toplam == sayi)
                {
                    label14.Text = "mükemmel bir sayıdır";
                }
                else
                {
                    label14.Text = "mükemmel sayı değildir";
                }
            }
        }
    }
}
 