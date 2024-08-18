using Microsoft.VisualBasic;

namespace _10._05._24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string gonder;
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            int i = 1; int carpim = 1;
            while (i <= sayi)
            {
                carpim = carpim * i;
                i++;
            }
            label1.Text = carpim.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int maas = Convert.ToInt32(textBox2.Text);
            int yirmi, bes, bir;
            yirmi = maas / 20;
            bes = (maas % 20) / 5;
            bir = (maas % 20) % 5;
            label4.Text = Convert.ToString(maas + "Tutardaki maaþta \n " + yirmi + " adet 20 TL, \n "
               + bes + " adet 5 TL, \n" + bir + " adet 1 TL mevcuttur.");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                int sayi = Convert.ToInt32(label5.Text);
                sayi++;
                label5.Text = sayi.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label5.Text = "0";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            gonder = textBox3.Text;
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
