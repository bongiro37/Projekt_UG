using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        private double x = 0;
        private double y = 0;
        private string dzialanie = "";
        private bool czyWykonane = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCyfry_Click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;

            if (txtWyswietlacz.Text == "0" || czyWykonane)
            {
                txtWyswietlacz.Clear();
                czyWykonane = false;
            }

            if (przycisk.Text == ",")
            {
                if (!txtWyswietlacz.Text.Contains(","))
                {
                    txtWyswietlacz.Text += przycisk.Text;
                }
            }
            else
            {
                txtWyswietlacz.Text += przycisk.Text;
            }
        }

        private void btnDzialania_Click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;

            if (string.IsNullOrEmpty(txtWyswietlacz.Text))
                return;

            if (x != 0)
            {
                btnWynik.PerformClick();
            }

            x = double.Parse(txtWyswietlacz.Text);
            dzialanie = przycisk.Text;
            czyWykonane = true;
        }

        private void btnWyczysc_Click(object sender, EventArgs e)
        {
            txtWyswietlacz.Text = "0";
            x = 0;
            y = 0;
            dzialanie = "";
            czyWykonane = false;
        }

        private void btnWynik_Click(object sender, EventArgs e)
        {
            if (dzialanie == "")
                return;

            y = double.Parse(txtWyswietlacz.Text);

            try
            {
                switch (dzialanie)
                {
                    case "+":
                        txtWyswietlacz.Text = (x + y).ToString();
                        break;
                    case "-":
                        txtWyswietlacz.Text = (x - y).ToString();
                        break;
                    case "*":
                        txtWyswietlacz.Text = (x * y).ToString();
                        break;
                    case "/":
                        if (y == 0)
                        {
                            MessageBox.Show("Nie można dzielić przez zero", "Błąd");
                            txtWyswietlacz.Text = "0";
                        }
                        else
                        {
                            txtWyswietlacz.Text = (x / y).ToString();
                        }
                        break;
                    case "√":
                        if (x < 0)
                        {
                            MessageBox.Show("Nie można pierwiastkować liczby ujemnej", "Błąd");
                            txtWyswietlacz.Text = "0";
                        }
                        else
                        {
                            txtWyswietlacz.Text = Math.Sqrt(x).ToString();
                        }
                        break;
                    case "x²":
                        txtWyswietlacz.Text = Math.Pow(x, 2).ToString();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd: " + ex.Message, "Błąd");
                txtWyswietlacz.Text = "0";
            }

            dzialanie = "";
            czyWykonane = true;
        }

        private void pierwiastekpotega_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtWyswietlacz.Text))
                return;

            Button przycisk = (Button)sender;
            x = double.Parse(txtWyswietlacz.Text);
            dzialanie = przycisk.Text;
            btnWynik.PerformClick();
        }
    }
}
