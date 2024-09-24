using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Application.Exit();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out float peso) && float.TryParse(textBox2.Text, out float altura) && altura > 0)
                {


                float imc = peso / (altura * altura);

                label4.Text = $" Seu imc é de: {imc:F2}" ;

                if (imc < 18.5)
                {
                    label5.Text = "ta abaixo do peso";
                }
                else if (imc >= 18.5 && imc < 25)
                {
                    label5.Text = "você peso ideal";
                }
                else if (imc >= 25 && imc < 30)
                {
                    label5.Text = "você está acima do peso";
                }
                else
                {
                    label5.Text = "obesidade";
                };
            }
            else 
            {
                MessageBox.Show("Coloque um valor válido ");
            }
            label1.Text = "programa feio do daniel dos amorim";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            label4.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            label1.Text = "bem vindo ao programa de calculo imc";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
