namespace Kalkulator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtWyswietlacz = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnOdejmowanie = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPierwiastek = new System.Windows.Forms.Button();
            this.btnMnozenie = new System.Windows.Forms.Button();
            this.btnDodawanie = new System.Windows.Forms.Button();
            this.btnPotegowanie = new System.Windows.Forms.Button();
            this.btnDzielenie = new System.Windows.Forms.Button();
            this.btnWynik = new System.Windows.Forms.Button();
            this.btnWyczysc = new System.Windows.Forms.Button();
            this.btnPrzecinek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(185, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalkulator";
            // 
            // txtWyswietlacz
            // 
            this.txtWyswietlacz.Location = new System.Drawing.Point(58, 100);
            this.txtWyswietlacz.Name = "txtWyswietlacz";
            this.txtWyswietlacz.Size = new System.Drawing.Size(337, 20);
            this.txtWyswietlacz.TabIndex = 1;
            this.txtWyswietlacz.Text = "0";
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(58, 156);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(50, 50);
            this.btn7.TabIndex = 2;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnCyfry_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(58, 212);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(50, 50);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnCyfry_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(58, 268);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(50, 50);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnCyfry_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(114, 156);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(50, 50);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnCyfry_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(114, 212);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(50, 50);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnCyfry_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(114, 268);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(50, 50);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnCyfry_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(170, 156);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(50, 50);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnCyfry_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(170, 212);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(50, 50);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnCyfry_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(170, 268);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(50, 50);
            this.btn3.TabIndex = 10;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnCyfry_Click);
            // 
            // btnOdejmowanie
            // 
            this.btnOdejmowanie.Location = new System.Drawing.Point(345, 156);
            this.btnOdejmowanie.Name = "btnOdejmowanie";
            this.btnOdejmowanie.Size = new System.Drawing.Size(50, 50);
            this.btnOdejmowanie.TabIndex = 11;
            this.btnOdejmowanie.Text = "-";
            this.btnOdejmowanie.UseVisualStyleBackColor = true;
            this.btnOdejmowanie.Click += new System.EventHandler(this.btnDzialania_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(58, 324);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(106, 50);
            this.btn0.TabIndex = 12;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnCyfry_Click);
            // 
            // btnPierwiastek
            // 
            this.btnPierwiastek.Location = new System.Drawing.Point(289, 268);
            this.btnPierwiastek.Name = "btnPierwiastek";
            this.btnPierwiastek.Size = new System.Drawing.Size(50, 50);
            this.btnPierwiastek.TabIndex = 13;
            this.btnPierwiastek.Text = "√";
            this.btnPierwiastek.UseVisualStyleBackColor = true;
            this.btnPierwiastek.Click += new System.EventHandler(this.pierwiastekpotega_Click);
            // 
            // btnMnozenie
            // 
            this.btnMnozenie.Location = new System.Drawing.Point(289, 212);
            this.btnMnozenie.Name = "btnMnozenie";
            this.btnMnozenie.Size = new System.Drawing.Size(50, 50);
            this.btnMnozenie.TabIndex = 14;
            this.btnMnozenie.Text = "*";
            this.btnMnozenie.UseVisualStyleBackColor = true;
            this.btnMnozenie.Click += new System.EventHandler(this.btnDzialania_Click);
            // 
            // btnDodawanie
            // 
            this.btnDodawanie.Location = new System.Drawing.Point(289, 156);
            this.btnDodawanie.Name = "btnDodawanie";
            this.btnDodawanie.Size = new System.Drawing.Size(50, 50);
            this.btnDodawanie.TabIndex = 15;
            this.btnDodawanie.Text = "+";
            this.btnDodawanie.UseVisualStyleBackColor = true;
            this.btnDodawanie.Click += new System.EventHandler(this.btnDzialania_Click);
            // 
            // btnPotegowanie
            // 
            this.btnPotegowanie.Location = new System.Drawing.Point(345, 268);
            this.btnPotegowanie.Name = "btnPotegowanie";
            this.btnPotegowanie.Size = new System.Drawing.Size(50, 50);
            this.btnPotegowanie.TabIndex = 16;
            this.btnPotegowanie.Text = "x²";
            this.btnPotegowanie.UseVisualStyleBackColor = true;
            this.btnPotegowanie.Click += new System.EventHandler(this.pierwiastekpotega_Click);
            // 
            // btnDzielenie
            // 
            this.btnDzielenie.Location = new System.Drawing.Point(345, 212);
            this.btnDzielenie.Name = "btnDzielenie";
            this.btnDzielenie.Size = new System.Drawing.Size(50, 50);
            this.btnDzielenie.TabIndex = 17;
            this.btnDzielenie.Text = "/";
            this.btnDzielenie.UseVisualStyleBackColor = true;
            this.btnDzielenie.Click += new System.EventHandler(this.btnDzialania_Click);
            // 
            // btnWynik
            // 
            this.btnWynik.Location = new System.Drawing.Point(345, 324);
            this.btnWynik.Name = "btnWynik";
            this.btnWynik.Size = new System.Drawing.Size(50, 50);
            this.btnWynik.TabIndex = 18;
            this.btnWynik.Text = "=";
            this.btnWynik.UseVisualStyleBackColor = true;
            this.btnWynik.Click += new System.EventHandler(this.btnWynik_Click);
            // 
            // btnWyczysc
            // 
            this.btnWyczysc.Location = new System.Drawing.Point(289, 324);
            this.btnWyczysc.Name = "btnWyczysc";
            this.btnWyczysc.Size = new System.Drawing.Size(50, 50);
            this.btnWyczysc.TabIndex = 19;
            this.btnWyczysc.Text = "C";
            this.btnWyczysc.UseVisualStyleBackColor = true;
            this.btnWyczysc.Click += new System.EventHandler(this.btnWyczysc_Click);
            // 
            // btnPrzecinek
            // 
            this.btnPrzecinek.Location = new System.Drawing.Point(170, 324);
            this.btnPrzecinek.Name = "btnPrzecinek";
            this.btnPrzecinek.Size = new System.Drawing.Size(50, 50);
            this.btnPrzecinek.TabIndex = 20;
            this.btnPrzecinek.Text = ",";
            this.btnPrzecinek.UseVisualStyleBackColor = true;
            this.btnPrzecinek.Click += new System.EventHandler(this.btnCyfry_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnPrzecinek);
            this.Controls.Add(this.btnWyczysc);
            this.Controls.Add(this.btnWynik);
            this.Controls.Add(this.btnDzielenie);
            this.Controls.Add(this.btnPotegowanie);
            this.Controls.Add(this.btnDodawanie);
            this.Controls.Add(this.btnMnozenie);
            this.Controls.Add(this.btnPierwiastek);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnOdejmowanie);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.txtWyswietlacz);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWyswietlacz;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnOdejmowanie;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPierwiastek;
        private System.Windows.Forms.Button btnMnozenie;
        private System.Windows.Forms.Button btnDodawanie;
        private System.Windows.Forms.Button btnPotegowanie;
        private System.Windows.Forms.Button btnDzielenie;
        private System.Windows.Forms.Button btnWynik;
        private System.Windows.Forms.Button btnWyczysc;
        private System.Windows.Forms.Button btnPrzecinek;
    }
}

