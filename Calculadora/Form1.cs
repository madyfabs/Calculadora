using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        decimal primeiroValor = 0, segundoValor = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "0")
            {
                txtResultado.Text = "0";
            }
            else
            {
                txtResultado.Text += "0";
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                primeiroValor = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                txtResultado.Text = "";
                operacao = "divisao";
                txtOperacao.Text = "/";
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                try
                {
                    primeiroValor = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                    txtResultado.Text = "";
                    operacao = "multiplicacao";
                    txtOperacao.Text = "*";
                }
                catch
                {
                    txtResultado.Text = "Estouro!";
                }

            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                try
                {
                    primeiroValor = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                    txtResultado.Text = "";
                    operacao = "subtracao";
                    txtOperacao.Text = "-";
                }
                catch
                {
                    txtResultado.Text = "Estouro!";
                }
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {

            if (txtResultado.Text != "")
            {
                try
                {
                    primeiroValor = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                    txtResultado.Text = "";
                    operacao = "soma";
                    txtOperacao.Text = "+";
                }
                catch
                {
                    txtResultado.Text = "Estouro!";
                }
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            primeiroValor = 0;
            segundoValor = 0;
            txtOperacao.Text = "";

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "" || operacao == "quadrado")
            {
                try
                {
                    segundoValor = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                }
                catch
                {
                    txtResultado.Text = "Estouro!";
                }

                switch (operacao)
                {
                    case "soma":
                        try
                        {
                            txtResultado.Text = Convert.ToString(checked(primeiroValor + segundoValor));
                        }
                        catch
                        {
                            txtResultado.Text = "Estouro!";
                        }
                        break;
                    case "subtracao":
                        try
                        {
                            txtResultado.Text = Convert.ToString(checked(primeiroValor - segundoValor));
                        }
                        catch
                        {
                            txtResultado.Text = "Estouro!";
                        }
                        break;
                    case "divisao":

                        if (segundoValor == 0)
                        {
                            txtResultado.Text = "Divisão por zero!";
                        }
                        else
                        {
                            try
                            {
                                txtResultado.Text = Convert.ToString(primeiroValor / segundoValor);
                            }
                            catch
                            {
                                txtResultado.Text = "Estouro!";
                            }

                        }
                        break;
                    case "multiplicacao":
                        try
                        {
                            txtResultado.Text = Convert.ToString(primeiroValor * segundoValor);
                        }
                        catch
                        {
                            txtResultado.Text = "Estouro!";
                        }
                        break;
                    
                    default:
                        break;
                }
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }
    }
}
