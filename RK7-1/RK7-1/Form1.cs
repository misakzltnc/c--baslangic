using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RK7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string isim = textBox1.Text;
            int puan = Convert.ToInt32(textBox2.Text);
            bool isimBulundu = false;
            for (int i = 0; i<listBox1.Items.Count; i++)
            {
                if (isim == listBox1.Items[i].ToString())
                {
                    int eskiPuan = Convert.ToInt32(listBox2.Items[i]);
                    listBox2.Items[i] = eskiPuan + puan;
                    isimBulundu = true;
                    break;
                }
            }
            if (isimBulundu==false)
            {
                listBox1.Items.Add(isim);
                listBox2.Items.Add(puan);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //chatgpt kullandım, çalışıyor ama z den sonra devam etmiyor
            /*string metin = textBox3.Text;
            string yeniMetin = KaydirHarfleri(metin);
            label5.Text = yeniMetin;
        }
        private string KaydirHarfleri(string metin)
        {
            return new string(metin.Select(c => char.IsLetter(c) ? (char)(c+2): c).ToArray())*/
            string[] alfabe = { "A" , "B", "C","Ç", "D","E" , "F", "G", "Ğ", "H","I","İ","J","K","L","M","N","O","Ö","P","R","S","Ş","T","U","Ü","V","Y","Z","A","B",
                                "a","b","c","ç","d","e","f","g","ğ","h","ı","i","j","k","l","m","n","o","ö","p","r","s","ş","t","u","ü","v","y","z","a","b"};
            string metin = textBox3.Text;
            string yeniMetin = "";
            for (int i = 0; i<metin.Length; i++)
            {
                bool harfBulundu = false;
                for ( int j =0; j< alfabe.Length; j++)
                {
                    if (metin[i].ToString() == alfabe[j])
                    {
                        int index = (j + 2) % alfabe.Length; // Dönüştürülen harf indeksinin alfabe dizisi boyutuna göre mod alınması gerekir
                        yeniMetin += alfabe[index];
                        harfBulundu = true;
                        break;
                    }
                }
                if (!harfBulundu) // Eğer harf alfabe dizisinde bulunamadıysa (örneğin bir noktalama işareti ya da boşluk gibi), doğrudan yeni metine ekle
                {
                    yeniMetin += metin[i];
                }
            }
            label5.Text = yeniMetin;
        }
    }
}
