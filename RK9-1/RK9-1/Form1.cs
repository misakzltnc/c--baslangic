using System.Windows.Forms;

namespace RK9_1
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
            int[] puanla = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] adet = { 0, 0, 0, 0, 4, 0, 0, 0, 0, 0 };
            for (int i = 0; i < puanla.Length; i++)
            {
                string sonuc = puanla[i] + "-" + adet[i];
                listBox1.Items.Add(sonuc);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] puanla = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] adet = { 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                int gelenSayi = Convert.ToInt32(listBox2.Items[i]);
                adet[gelenSayi - 1]++;    //????? anlamadým
            }
            for (int i = 0; i < 10; i++)
            {
                listBox2.Items.Add(puanla[i] + "  alan  " + adet[i] + "  kiþi var. ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string satir;
            int toplam = 0;
            int topla = 0;
            listBox3.Items.Clear();
            int[,] matris = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                satir = "";
                for (int j = 0; j < 3; j++)
                {
                    matris[i, j] = rnd.Next(0, 11);
                    satir += matris[i, j] + "     ";
                }
                listBox3.Items.Add(satir);
            }
            // birinci ve ikinci sütunu topla
            for (int i = 0; i < 3; i++)
            {
                toplam += matris[i, 0] + matris[i, 1];
            }
            label2.Text = toplam.ToString();
            for (int i = 0; i < 3; i++)
            {
                topla += matris[0, i] + matris[1, i];
            }
            label4.Text = topla.ToString();
        }
    }
}
