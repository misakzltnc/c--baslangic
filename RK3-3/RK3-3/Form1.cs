using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RK3_3
{
    public partial class Form1 : Form
       
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Text = "Seçenekler";
            comboBox1.Items.Add("İstanbul");
            comboBox1.Items.Add("Ankara");
            comboBox1.Items.Add("Adana");
            comboBox1.Items.Add("İzmir");
            //string [] sehir = { "İstanbul", "Ankara", "Adana", "İzmir"); comboBox1.Items.AddRange(sehir);
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 9;
            numericUpDown2.Minimum = 0;
            numericUpDown2.Maximum = 9;
            numericUpDown3.Minimum = 0;
            numericUpDown3.Maximum = 9;

        }
 

        private void button1_Click(object sender, EventArgs e)
        {
            int fiyat;
            fiyat = Convert.ToInt32(textBox1.Text);
            if (radioButton1.Checked == true) 
            {
                label3.Text = Convert.ToString(fiyat * 0.9);
                label3.BackColor = Color.Gold;
            }
            else if (radioButton2.Checked == true)
            {
                label3.Text = Convert.ToString(fiyat * 0.75);
                label3.ForeColor = Color.Red;
                label3.BackColor = Color.Gold;
            }
            else
            {
                label3.Text = Convert.ToString(fiyat * 0.5);
                label3.ForeColor = Color.Red;
                label3.BackColor = Color.Gold;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "İstanbul")
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Kadıköy");
                listBox1.Items.Add("Beşiktaş");
                listBox1.Items.Add("Şişli");
                listBox1.Items.Add("Ataşehir");
            }
            if (comboBox1.Text=="Ankara")
            {
                listBox1.Items.Clear();
                string[] ilce = { "Çankaya", "Yenimahalle", "Etimesgut", "Sincan"};
                listBox1.Items.AddRange(ilce);
            }
            if (comboBox1.Text == "İzmir")
            {
                listBox1.Items.Clear();
                string[] ilce = { "Bornova", "Buca", "Çeşme", "Karşıyaka" };
                listBox1.Items.AddRange(ilce);
            }
            if (comboBox1.Text=="Adana")
            {
                listBox1.Items.Clear();
                string[] ilce = { "Seyhan", "Yüreğir", "Çukurova", "Sarıçam" };
                listBox1.Items.AddRange(ilce);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label7.Text = numericUpDown1.Value.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            label8.Text = numericUpDown2.Value.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            label9.Text = numericUpDown3.Value.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

