using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculos_basicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResultado.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado; /*declaração de variáveis do tipo double
            num1 num2 e resultado */

            num1 = Convert.ToDouble(txtNum1.Text); /* num1 e num2 recebe conteúdo do textbox
            (txtNum1.Text e txtNum2.Text) 
            convert.ToDouble é necessário para que seja convertido o conteúdo
            do textbox */
            num2 = Convert.ToDouble(txtNum2.Text);
            //variavel resultado recebe o conteúdo de num1 e num1 e realiza o calculo
            resultado = num1 + num2;
            //txtResultado.Text recebe conteúdo da variavel resultado e converte para numero
            txtResultado.Text = resultado.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            resultado = num1 - num2;

            txtResultado.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            resultado = num1 * num2;

            txtResultado.Text = resultado.ToString();

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);

            resultado = num1 / num2;

            txtResultado.Text = resultado.ToString();
        }
    }
}
