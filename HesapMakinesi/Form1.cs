using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        bool optDurum = false;
        double sonuc = 0;
        string eskiOpt = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rakamOlay(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0" || optDurum)
                txtSonuc.Clear();

            optDurum = false;
            Button btn = (Button)sender;
            txtSonuc.Text += btn.Text;
        }

        private void optHesap(object sender, EventArgs e)
        {
            Button btnOpt =  (Button) sender;
            optDurum = true;
            string yeniOpt = btnOpt.Text;
            //eskiOpt = btnOpt.Text;
            lblSnc.Text = lblSnc.Text + " " + txtSonuc.Text + " " + yeniOpt;
            switch (eskiOpt)
            {
                case "+": txtSonuc.Text = (sonuc + double.Parse(txtSonuc.Text)).ToString(); break;
                case "-": txtSonuc.Text = (sonuc - double.Parse(txtSonuc.Text)).ToString(); break;
                case "*": txtSonuc.Text = (sonuc * double.Parse(txtSonuc.Text)).ToString(); break;
                case "/": txtSonuc.Text = (sonuc / double.Parse(txtSonuc.Text)).ToString(); break;
            }
            sonuc = double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            eskiOpt = yeniOpt;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
            lblSnc.Text = "0";
            eskiOpt = "";
            sonuc = 0;
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            lblSnc.Text = "";
            optDurum = true;
            switch (eskiOpt)
            {
                case "+": txtSonuc.Text = (sonuc + double.Parse(txtSonuc.Text)).ToString(); break;
                case "-": txtSonuc.Text = (sonuc - double.Parse(txtSonuc.Text)).ToString(); break;
                case "*": txtSonuc.Text = (sonuc * double.Parse(txtSonuc.Text)).ToString(); break;
                case "/": txtSonuc.Text = (sonuc / double.Parse(txtSonuc.Text)).ToString(); break;
            }
            sonuc = double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            eskiOpt = "";
        }

        private void btnNokta_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text =="0")
            {
                txtSonuc.Text = "0";
            }
            else if (optDurum)
            {
                txtSonuc.Text = "0";
            }
            if (!txtSonuc.Text.Contains(","))
            {
                txtSonuc.Text += ",";
            }
            optDurum = false;
        }
    }
}
