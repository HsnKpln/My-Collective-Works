using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("TC KİMLİK NO", 150);
            listView1.Columns.Add("ADI SOYADI", 200);
            listView1.Columns.Add("YAŞI", 70);
            listView1.Columns.Add("MEZUNİYETİ", 150);
            listView1.Columns.Add("CİNSİYET", 125);
            listView1.Columns.Add("DOĞUM YERİ", 150);
            listView1.Columns.Add("TELEFON", 130);

            string[] mezuniyet = { "İlköğretim", "Ortaöğretim", "Lisan", "Yüksek Lisans", "Doktora" };
            comboBox1.Items.Add(mezuniyet);
        }

        private void KayitSayisiYaz()
        {
            int kayitSayisi = listView1.Items.Count;
            txtKayitSayisi.Text = Convert.ToString(kayitSayisi);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
