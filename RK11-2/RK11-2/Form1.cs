namespace RK11_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string[,] questions = new string[,]
            {
            {"5+10 kaç eder?", "17", "15", "13"},
            {"Ýstiklal Marþý kaç kýtadýr?", "10", "2", "8"},
            {"Atatürk kaç yýlýnda doðmuþtur?", "1938", "1881", "1883"},
            {"Romeo ve Juliet adlý eserin yazarý kimdir?", "Shakespeare", "Goethe", "Çehov"},
            };
            richTextBox1.Text = questions[i, 0];
            radioButton1.Text = questions[i, 1];
            radioButton2.Text = questions[i, 2];
            radioButton3.Text = questions[i, 3];
            button1.Text = "Sonraki Soru";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cevap1, cevap2, cevap3, cevap4;
            cevap1 = "15";
            cevap2 = "10";
            cevap3 = "1881";
            cevap4 = "Shakespeare";
            string userAnswer = "";
            if (radioButton1.Checked)
                userAnswer = radioButton1.Text;
            else if (radioButton2.Checked)
                userAnswer = radioButton2.Text;
            else if (radioButton3.Checked)
                userAnswer = radioButton3.Text;

            if (userAnswer == cevap1)
            {
                MessageBox.Show("Doðru");
                i++;
            }
            else if (userAnswer == cevap2)
            {
                MessageBox.Show("Doðru");
                i++;
            }
            else if (userAnswer == cevap3)
            {
                MessageBox.Show("Doðru");
                i++;
            }
            else if (userAnswer == cevap4)
            {
                MessageBox.Show("Doðru, oyun bitti");
                button1.Enabled = false;
                i++;
            }
            else
            {
                MessageBox.Show("Yanlýþ");
            }
        }
    }
}
