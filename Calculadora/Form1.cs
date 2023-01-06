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
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        //Método CE
        private void button17_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            //lblOperacao.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        //Fazendo a lógica do IGUAL(=)
        private void button19_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            if(operacao == "SOMA")
            {
                //Para converter para String eu posso ou usar esse método ou atribuir a uma variável!
                txtResultado.Text = Convert.ToString(valor1 + valor2);

            }else if(operacao == "SUBTRACAO")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);

            }else if(operacao == "MULTIPLICACAO")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        //Método de SUBTRAÇÃO
        private void button8_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUBTRACAO";
                lblOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a subtração.");
            }
        }

        //Método de SUBTRAÇÃO 
        private void button12_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULTIPLICACAO";
                lblOperacao.Text = "x";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a multiplicação.");
            }
        }

        //Método de DIVISÃO
        private void button16_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIVISAO";
                lblOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a divisão.");
            }
        }

        //Método C
        private void button18_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        //Método de SOMAR
        private void button4_Click(object sender, EventArgs e)
        {
            if(txtResultado.Text != "")
            {
                //Convertendo para decimal (obs: 2,5)
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a soma.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
