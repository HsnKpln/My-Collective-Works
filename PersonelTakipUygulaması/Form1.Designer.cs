
namespace PersonelTakipUygulaması
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTc = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblMezun = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblDogumYeri = new System.Windows.Forms.Label();
            this.lblKayitSayisi = new System.Windows.Forms.Label();
            this.grpCinsiyet = new System.Windows.Forms.GroupBox();
            this.radioBtnBayan = new System.Windows.Forms.RadioButton();
            this.radioBtnBay = new System.Windows.Forms.RadioButton();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.txtKayitSayisi = new System.Windows.Forms.TextBox();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.btnTümSil = new System.Windows.Forms.Button();
            this.btnSilNormal = new System.Windows.Forms.Button();
            this.btnsilCheckbox = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.grpCinsiyet.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(40, 43);
            this.lblTc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(134, 28);
            this.lblTc.TabIndex = 0;
            this.lblTc.Text = "TC KİMLİK NO";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(40, 97);
            this.lblAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(116, 28);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "ADI SOYADI";
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(40, 150);
            this.lblYas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(50, 28);
            this.lblYas.TabIndex = 2;
            this.lblYas.Text = "YAŞI";
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(190, 43);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(337, 34);
            this.txtTc.TabIndex = 3;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(190, 97);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(337, 34);
            this.txtAd.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(190, 147);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(337, 34);
            this.textBox3.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(190, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(337, 36);
            this.comboBox1.TabIndex = 6;
            // 
            // lblMezun
            // 
            this.lblMezun.AutoSize = true;
            this.lblMezun.Location = new System.Drawing.Point(40, 209);
            this.lblMezun.Name = "lblMezun";
            this.lblMezun.Size = new System.Drawing.Size(121, 28);
            this.lblMezun.TabIndex = 7;
            this.lblMezun.Text = "MEZUNİYETİ";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(668, 203);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(91, 28);
            this.lblTel.TabIndex = 8;
            this.lblTel.Text = "TELEFON";
            // 
            // lblDogumYeri
            // 
            this.lblDogumYeri.AutoSize = true;
            this.lblDogumYeri.Location = new System.Drawing.Point(665, 153);
            this.lblDogumYeri.Name = "lblDogumYeri";
            this.lblDogumYeri.Size = new System.Drawing.Size(130, 28);
            this.lblDogumYeri.TabIndex = 9;
            this.lblDogumYeri.Text = "DOĞUM YERİ";
            // 
            // lblKayitSayisi
            // 
            this.lblKayitSayisi.AutoSize = true;
            this.lblKayitSayisi.Location = new System.Drawing.Point(829, 275);
            this.lblKayitSayisi.Name = "lblKayitSayisi";
            this.lblKayitSayisi.Size = new System.Drawing.Size(110, 28);
            this.lblKayitSayisi.TabIndex = 10;
            this.lblKayitSayisi.Text = "Kayit Sayısı";
            // 
            // grpCinsiyet
            // 
            this.grpCinsiyet.Controls.Add(this.radioBtnBayan);
            this.grpCinsiyet.Controls.Add(this.radioBtnBay);
            this.grpCinsiyet.Location = new System.Drawing.Point(668, 43);
            this.grpCinsiyet.Name = "grpCinsiyet";
            this.grpCinsiyet.Size = new System.Drawing.Size(392, 97);
            this.grpCinsiyet.TabIndex = 11;
            this.grpCinsiyet.TabStop = false;
            this.grpCinsiyet.Text = "CİNSİYET";
            // 
            // radioBtnBayan
            // 
            this.radioBtnBayan.AutoSize = true;
            this.radioBtnBayan.Location = new System.Drawing.Point(216, 50);
            this.radioBtnBayan.Name = "radioBtnBayan";
            this.radioBtnBayan.Size = new System.Drawing.Size(85, 32);
            this.radioBtnBayan.TabIndex = 1;
            this.radioBtnBayan.TabStop = true;
            this.radioBtnBayan.Text = "Bayan";
            this.radioBtnBayan.UseVisualStyleBackColor = true;
            // 
            // radioBtnBay
            // 
            this.radioBtnBay.AutoSize = true;
            this.radioBtnBay.Location = new System.Drawing.Point(101, 50);
            this.radioBtnBay.Name = "radioBtnBay";
            this.radioBtnBay.Size = new System.Drawing.Size(64, 32);
            this.radioBtnBay.TabIndex = 0;
            this.radioBtnBay.TabStop = true;
            this.radioBtnBay.Text = "Bay";
            this.radioBtnBay.UseVisualStyleBackColor = true;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(824, 203);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(236, 34);
            this.txtTel.TabIndex = 12;
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Location = new System.Drawing.Point(824, 153);
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(236, 34);
            this.txtDogumYeri.TabIndex = 13;
            // 
            // txtKayitSayisi
            // 
            this.txtKayitSayisi.BackColor = System.Drawing.SystemColors.Control;
            this.txtKayitSayisi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKayitSayisi.Location = new System.Drawing.Point(945, 278);
            this.txtKayitSayisi.Name = "txtKayitSayisi";
            this.txtKayitSayisi.Size = new System.Drawing.Size(115, 27);
            this.txtKayitSayisi.TabIndex = 14;
            this.txtKayitSayisi.Text = "_____";
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(668, 269);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(147, 34);
            this.btnYeniKayit.TabIndex = 15;
            this.btnYeniKayit.Text = "YENİ KAYIT";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTümSil
            // 
            this.btnTümSil.Location = new System.Drawing.Point(496, 269);
            this.btnTümSil.Name = "btnTümSil";
            this.btnTümSil.Size = new System.Drawing.Size(151, 34);
            this.btnTümSil.TabIndex = 16;
            this.btnTümSil.Text = "TÜMÜNÜ SİL";
            this.btnTümSil.UseVisualStyleBackColor = true;
            // 
            // btnSilNormal
            // 
            this.btnSilNormal.Location = new System.Drawing.Point(330, 269);
            this.btnSilNormal.Name = "btnSilNormal";
            this.btnSilNormal.Size = new System.Drawing.Size(148, 34);
            this.btnSilNormal.TabIndex = 17;
            this.btnSilNormal.Text = "SİL(NORMAL)";
            this.btnSilNormal.UseVisualStyleBackColor = true;
            // 
            // btnsilCheckbox
            // 
            this.btnsilCheckbox.Location = new System.Drawing.Point(147, 269);
            this.btnsilCheckbox.Name = "btnsilCheckbox";
            this.btnsilCheckbox.Size = new System.Drawing.Size(159, 34);
            this.btnsilCheckbox.TabIndex = 18;
            this.btnsilCheckbox.Text = "SİL(CHECKBOX)";
            this.btnsilCheckbox.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(40, 269);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(86, 34);
            this.btnEkle.TabIndex = 19;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(552, 43);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(86, 34);
            this.btnAra.TabIndex = 20;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(40, 321);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1020, 270);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 630);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnsilCheckbox);
            this.Controls.Add(this.btnSilNormal);
            this.Controls.Add(this.btnTümSil);
            this.Controls.Add(this.btnYeniKayit);
            this.Controls.Add(this.txtKayitSayisi);
            this.Controls.Add(this.txtDogumYeri);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.grpCinsiyet);
            this.Controls.Add(this.lblKayitSayisi);
            this.Controls.Add(this.lblDogumYeri);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblMezun);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblTc);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCinsiyet.ResumeLayout(false);
            this.grpCinsiyet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblMezun;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblDogumYeri;
        private System.Windows.Forms.Label lblKayitSayisi;
        private System.Windows.Forms.GroupBox grpCinsiyet;
        private System.Windows.Forms.RadioButton radioBtnBayan;
        private System.Windows.Forms.RadioButton radioBtnBay;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.TextBox txtKayitSayisi;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.Button btnTümSil;
        private System.Windows.Forms.Button btnSilNormal;
        private System.Windows.Forms.Button btnsilCheckbox;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ListView listView1;
    }
}

