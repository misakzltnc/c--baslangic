namespace RK13_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         // kare , küp , çarpma , toplama fonksiyonlarýný kullan

        int kare (int a)
        {
            return a * a;
        }
        
        int küp (int b)
        {
            return b * b * b;
        }

        int topla (int x , int y )
        {
           return kare(kare(x) + kare(y));
        }

        int carp (int x , int y , int z)
        {
            return topla(x, y) + (küp(küp(x) + küp(y)) * z);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int birinciSayi = Convert.ToInt32(textBox1.Text);
            int ikinciSayi = Convert.ToInt32(textBox2.Text);
            int ucuncuSayi = Convert.ToInt32(textBox3.Text);
            label5.Text = "Sonuç  " +  carp (birinciSayi , ikinciSayi , ucuncuSayi);
        }
    }
}
