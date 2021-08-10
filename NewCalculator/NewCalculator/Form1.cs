using System;
using System.Windows.Forms;

namespace NewCalculator
{
    public partial class Form1 : Form
    {
        double first;
        double second;
        double result;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + ".";
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            operation = "+";
            if (!pantalla.Text.Equals("")
            first = double.Parse(pantalla.Text);
            etiqueta.Text = first + " " + operation;

        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operation = "-";
            first = double.Parse(pantalla.Text);


        }

        private void btnmultiplication_Click(object sender, EventArgs e)
        {
            operation = "*";
            first = double.Parse(pantalla.Text);


        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            operation = "/";
            first = double.Parse(pantalla.Text);


        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            second = double.Parse(pantalla.Text);

            switch (operation)
            {
                case "+":
                    result = first + second;
                    pantalla.Text = result.ToString();

                    break;

                case "-":
                    result = first - second;
                    pantalla.Text = result.ToString();

                    break;

                case "*":
                    result = first * second;
                    pantalla.Text = result.ToString();

                    break;

                case "/":
                    result = first / second;
                    pantalla.Text = result.ToString();

                    break;


            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            pantalla.Text = " ";


        }

        private void btnraiz_Click(object sender, EventArgs e)
        {
            operation = "√";
            first = double.Parse(pantalla.Text);
            result = first;
            pantalla.Text = Math.Sqrt(first).ToString();


        }

        private void pantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
