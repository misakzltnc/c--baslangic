namespace hafta12deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int sonuc = topla(sayi1, sayi2);
            label3.Text = sonuc.ToString();
        }
        int faktoriyel(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * faktoriyel(n - 1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int sonuc = faktoriyel(Convert.ToInt32(textBox3.Text));
            label5.Text = sonuc.ToString();
        }
        double ortalama(int[] sayilar)
        {
            /*if (sayilar.Length == 0)
                return 0;*/  //silince çalýþýyorsa neden var???!

            double toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];
            }

            return toplam / sayilar.Length;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 10, 20, 30, 40, 50 };
            double sonuc = ortalama(sayilar);
            label8.Text = sonuc.ToString();
        }
        bool asalSayi(int sayi)
        {
            if (sayi <= 1)
            {
                label9.Text = "asal sayý deðildir.";
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0)
                {
                    label9.Text = "asal sayý deðildir.";
                    return false;
                }
            }
            label9.Text = "asal sayýdýr.";
            return true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox4.Text);
            bool asal = asalSayi(sayi);
        }
    }
}
