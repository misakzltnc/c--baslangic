using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using System.Data.OleDb;


namespace RK14_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb; Persist Security Info=False;");


        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select * From ogrenciListe ");
            OleDbDataReader oku = komut.ExecuteReader();
            listView1.Items.Clear();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ÖğrenciNo"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Bölüm"].ToString());
                ekle.SubItems.Add(oku["Sınıf"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string ogrenciNo = textBox1.Text;
            string ad = textBox2.Text;
            string soyad = textBox3.Text;
            string bolum = textBox4.Text;
            string sinif = textBox5.Text;

            OleDbCommand komut = new OleDbCommand( " insert into ogrenciListe(ÖğrenciNo,Ad,Soyad,Bölüm,Sınıf)  values  (  '" +ogrenciNo+"', '" +ad+"', '"+soyad+"', '"+bolum+"' , '"+sinif+"' ) " , baglanti );
            komut.ExecuteNonQuery();
            komut.CommandText = (" Select  * From ogrenciListe ");
            OleDbDataReader oku = komut.ExecuteReader();
            listView1.Items.Clear();
            while (oku.Read())
            {
               ListViewItem ekle = new ListViewItem();
                ekle.Text = oku[ "ÖğrenciNo" ].ToString();
                ekle.SubItems.Add( oku[ "Ad" ].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Bölüm"].ToString());
                ekle.SubItems.Add(oku["Sınıf"].ToString());
                listView1.Items.Add(ekle);

            }
            baglanti.Close();

        }
    }
}
