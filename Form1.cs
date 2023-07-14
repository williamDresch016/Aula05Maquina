using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula05maquina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {

            double valor = double.Parse(txtBox1.Text);
            //double conta = bolacha - bolacha1;


            if (valor < 0)
            {

                MessageBox.Show("Sua Compra Não Foi Realizada !");
            }
            else if (valor == 3.0)
            {
                MessageBox.Show("Voce comprou a Bolacha !");
            }
            else if (valor == 1.5)
            {
                MessageBox.Show("Voce Comprou a Bala");
            }
            else if (valor == 10.0)
            {
                MessageBox.Show("Voce Comprou a Coca!");
            }
            else 
            {
                MessageBox.Show("Valor Insuficiente");
            }








        }

        private void btnBolacha_Click(object sender, EventArgs e)
        {

        }
    }
}
