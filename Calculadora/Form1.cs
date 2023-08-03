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

    public partial class Form1 : Form
    {
        ModelCalculadora modelo;
        public Form1()
        {
            //conectando a control com o modelo
            InitializeComponent();
            this.modelo = new ModelCalculadora();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//fim da operação valor

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }//fim do resultado

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.modelo.somar(Convert.ToDouble(maskedTextBox1.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.modelo.raiz(Convert.ToDouble(maskedTextBox1.Text));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.modelo.potencia(Convert.ToDouble(maskedTextBox1.Text));
        }//potencia

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.modelo.subtrair(Convert.ToDouble(maskedTextBox1.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.modelo.multiplicacao(Convert.ToDouble(maskedTextBox1.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.modelo.divisao(Convert.ToDouble(maskedTextBox1.Text));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "" + this.modelo.clear(Convert.ToDouble(maskedTextBox1.Text));
        }
    }//fim da classe
}//fim do projeto
