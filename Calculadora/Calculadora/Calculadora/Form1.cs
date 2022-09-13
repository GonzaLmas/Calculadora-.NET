using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        double n1, n2;
        string operador;


        public frmCalculadora()
        {
            InitializeComponent();
        }

        ClsSuma sum = new ClsSuma();
        ClsResta res = new ClsResta();
        ClsMultiplicacion mul = new ClsMultiplicacion();
        ClsDivision div = new ClsDivision();

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "1";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "0";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "9";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            n1 = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnResto_Click(object sender, EventArgs e)
        {
            operador = "-";
            n1 = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            n1 = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            n1 = double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            n2 = double.Parse(txtDisplay.Text);

            double suma, resta, multi, division;

            switch (operador)
            {
                case "+":
                    suma = sum.Sumar(n1, n2);
                    txtDisplay.Text = suma.ToString();
                    break;

                case "-":
                    resta = res.Restar(n1, n2);
                    txtDisplay.Text = resta.ToString();
                    break;

                case "*":
                    multi = mul.Multiplicar(n1, n2);
                    txtDisplay.Text = multi.ToString();
                    break;

                case "/":
                    division = div.Dividir(n1, n2);
                    txtDisplay.Text = division.ToString();
                    break;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length == 1)
                txtDisplay.Text = "";
            else
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + ".";
        }
    }
}
