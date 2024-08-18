using System.Windows.Forms;

namespace RK11_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string satir;
            listBox1.Items.Clear();
            int[,] matris = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                satir = "";
                for (int j = 0; j < 4; j++)
                {
                    matris[i, j] = rnd.Next(0, 11);
                    satir += matris[i, j] + "     ";
                }
                listBox1.Items.Add(satir);
            }
            int[] enBuyukler = new int[4];
            int[] enKucukler = new int[4];
            for (int i = 0; i < 4; i++)
            {
                enBuyukler[i] = matris[i, 0];
                enKucukler[i] = matris[i, 0];

                for (int j = 1; j < 4; j++)
                {
                    if (matris[i, j] > enBuyukler[i])
                        enBuyukler[i] = matris[i, j];

                    if (matris[i, j] < enKucukler[i])
                        enKucukler[i] = matris[i, j];
                }
            }
            label3.Text = enBuyukler[0].ToString();
            label4.Text = enKucukler[0].ToString();
            label5.Text = enBuyukler[1].ToString();
            label6.Text = enKucukler[1].ToString();
            label7.Text = enBuyukler[2].ToString();
            label8.Text = enKucukler[2].ToString();
            label9.Text = enBuyukler[3].ToString();
            label10.Text = enKucukler[3].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[,] kisilerVePozisyonu =
            {
                {"Ahmet Yýlmazer", "Büro Personeli" },
                {"Merve Çelikdar", "Yazýlým Geliþtirici" },
                {"Fatma Korkmaz", "Mühendis" },
                {"Tayfun Görmez", "Yazýlým Geliþtirici" },
                {"Selçuk Korkmaz", "Pazarlama Uzmaný" },
                {"Büþra Kýlýçatar" , "Yönetici" },
                {"Ferdi Can Saðlam","Mühendis" },
                {"Ali Kaan Yeþil", "Yazýlým Geliþtirici" }
            };
            listBox2.Items.Clear();
            for (int i = 0; i < kisilerVePozisyonu.GetLength(0); i++)
            {
                string satir = kisilerVePozisyonu[i, 0] + "        " + kisilerVePozisyonu[i, 1];
                listBox2.Items.Add(satir);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenPozisyon = comboBox1.SelectedItem.ToString();
            string[,] kisilerVePozisyonu =
            {
                {"Ahmet Yýlmazer", "Büro Personeli" },
                {"Merve Çelikdar", "Yazýlým Geliþtirici" },
                {"Fatma Korkmaz", "Mühendis" },
                {"Tayfun Görmez", "Yazýlým Geliþtirici" },
                {"Selçuk Korkmaz", "Pazarlama Uzmaný" },
                {"Büþra Kýlýçatar" , "Yönetici" },
                {"Ferdi Can Saðlam","Mühendis" },
                {"Ali Kaan Yeþil", "Yazýlým Geliþtirici" }
            };
            listBox3.Items.Clear();
            for (int i = 0; i < kisilerVePozisyonu.GetLength(0); i++)
            {
                if (kisilerVePozisyonu[i, 1] == secilenPozisyon)
                {
                    string satir = kisilerVePozisyonu[i, 0] + "        " + kisilerVePozisyonu[i, 1];
                    listBox3.Items.Add(satir);
                }
            }
        }
    }
}

