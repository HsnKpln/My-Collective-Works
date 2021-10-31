
namespace HesapMakinesi
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
            this.lblSnc = new System.Windows.Forms.Label();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnToplama = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnCikarma = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnCarpma = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnBölme = new System.Windows.Forms.Button();
            this.btnNokta = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnEsittir = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnSilme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSnc
            // 
            this.lblSnc.AutoSize = true;
            this.lblSnc.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSnc.Location = new System.Drawing.Point(24, 23);
            this.lblSnc.Name = "lblSnc";
            this.lblSnc.Size = new System.Drawing.Size(0, 31);
            this.lblSnc.TabIndex = 0;
            // 
            // txtSonuc
            // 
            this.txtSonuc.Enabled = false;
            this.txtSonuc.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSonuc.Location = new System.Drawing.Point(24, 57);
            this.txtSonuc.Multiline = true;
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(473, 65);
            this.txtSonuc.TabIndex = 1;
            this.txtSonuc.Text = "0";
            this.txtSonuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(24, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.rakamOlay);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(123, 164);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 75);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.rakamOlay);
            // 
            // btnToplama
            // 
            this.btnToplama.BackColor = System.Drawing.Color.Coral;
            this.btnToplama.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnToplama.ForeColor = System.Drawing.Color.White;
            this.btnToplama.Location = new System.Drawing.Point(323, 164);
            this.btnToplama.Name = "btnToplama";
            this.btnToplama.Size = new System.Drawing.Size(75, 75);
            this.btnToplama.TabIndex = 5;
            this.btnToplama.Text = "+";
            this.btnToplama.UseVisualStyleBackColor = false;
            this.btnToplama.Click += new System.EventHandler(this.optHesap);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(223, 164);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 75);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.rakamOlay);
            // 
            // btnCikarma
            // 
            this.btnCikarma.BackColor = System.Drawing.Color.Coral;
            this.btnCikarma.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCikarma.ForeColor = System.Drawing.Color.White;
            this.btnCikarma.Location = new System.Drawing.Point(323, 261);
            this.btnCikarma.Name = "btnCikarma";
            this.btnCikarma.Size = new System.Drawing.Size(75, 75);
            this.btnCikarma.TabIndex = 9;
            this.btnCikarma.Text = "-";
            this.btnCikarma.UseVisualStyleBackColor = false;
            this.btnCikarma.Click += new System.EventHandler(this.optHesap);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(223, 261);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 75);
            this.btn6.TabIndex = 8;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.rakamOlay);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(121, 261);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 75);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.rakamOlay);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(24, 261);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 75);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.rakamOlay);
            // 
            // btnCarpma
            // 
            this.btnCarpma.BackColor = System.Drawing.Color.Coral;
            this.btnCarpma.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCarpma.ForeColor = System.Drawing.Color.White;
            this.btnCarpma.Location = new System.Drawing.Point(323, 354);
            this.btnCarpma.Name = "btnCarpma";
            this.btnCarpma.Size = new System.Drawing.Size(75, 75);
            this.btnCarpma.TabIndex = 13;
            this.btnCarpma.Text = "*";
            this.btnCarpma.UseVisualStyleBackColor = false;
            this.btnCarpma.Click += new System.EventHandler(this.optHesap);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(223, 354);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 75);
            this.btn9.TabIndex = 12;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.rakamOlay);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(123, 354);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 75);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.rakamOlay);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(24, 354);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 75);
            this.btn7.TabIndex = 10;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.rakamOlay);
            // 
            // btnBölme
            // 
            this.btnBölme.BackColor = System.Drawing.Color.Coral;
            this.btnBölme.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBölme.ForeColor = System.Drawing.Color.White;
            this.btnBölme.Location = new System.Drawing.Point(323, 450);
            this.btnBölme.Name = "btnBölme";
            this.btnBölme.Size = new System.Drawing.Size(75, 75);
            this.btnBölme.TabIndex = 17;
            this.btnBölme.Text = "/";
            this.btnBölme.UseVisualStyleBackColor = false;
            this.btnBölme.Click += new System.EventHandler(this.optHesap);
            // 
            // btnNokta
            // 
            this.btnNokta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNokta.Location = new System.Drawing.Point(223, 450);
            this.btnNokta.Name = "btnNokta";
            this.btnNokta.Size = new System.Drawing.Size(75, 75);
            this.btnNokta.TabIndex = 16;
            this.btnNokta.Text = ".";
            this.btnNokta.UseVisualStyleBackColor = true;
            this.btnNokta.Click += new System.EventHandler(this.btnNokta_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(24, 450);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(174, 75);
            this.btn0.TabIndex = 15;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.rakamOlay);
            // 
            // btnEsittir
            // 
            this.btnEsittir.BackColor = System.Drawing.Color.SandyBrown;
            this.btnEsittir.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEsittir.ForeColor = System.Drawing.Color.White;
            this.btnEsittir.Location = new System.Drawing.Point(422, 354);
            this.btnEsittir.Name = "btnEsittir";
            this.btnEsittir.Size = new System.Drawing.Size(75, 171);
            this.btnEsittir.TabIndex = 20;
            this.btnEsittir.Text = "=";
            this.btnEsittir.UseVisualStyleBackColor = false;
            this.btnEsittir.Click += new System.EventHandler(this.btnEsittir_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.Red;
            this.btnCE.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCE.ForeColor = System.Drawing.Color.White;
            this.btnCE.Location = new System.Drawing.Point(422, 261);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(75, 75);
            this.btnCE.TabIndex = 19;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnSilme
            // 
            this.btnSilme.BackColor = System.Drawing.Color.Red;
            this.btnSilme.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSilme.ForeColor = System.Drawing.Color.White;
            this.btnSilme.Location = new System.Drawing.Point(422, 164);
            this.btnSilme.Name = "btnSilme";
            this.btnSilme.Size = new System.Drawing.Size(75, 75);
            this.btnSilme.TabIndex = 18;
            this.btnSilme.Text = "C";
            this.btnSilme.UseVisualStyleBackColor = false;
            this.btnSilme.Click += new System.EventHandler(this.btnSilme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(528, 569);
            this.Controls.Add(this.btnEsittir);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnSilme);
            this.Controls.Add(this.btnBölme);
            this.Controls.Add(this.btnNokta);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnCarpma);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnCikarma);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnToplama);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.lblSnc);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.optHesap);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSnc;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnToplama;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnCikarma;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnCarpma;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnBölme;
        private System.Windows.Forms.Button btnNokta;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnEsittir;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnSilme;
    }
}

