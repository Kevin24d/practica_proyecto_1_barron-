using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_proyecto_1_barron.formularios
{
    public partial class FormaCalculadorDolares : Form
    {
        public FormaCalculadorDolares()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double pesos;
                double resul1;
                double resul2;
                pesos = float.Parse(textPesos.Text);

                if (pesos > 0)
                {
                    resul1 = pesos / 16.5 / 2;
                    resul2 = pesos / 18.5 / 2;
                    textDolares.Text = ("$" + resul1.ToString());
                    textEuros.Text = ("€" + resul2.ToString());
                }
                else
                {
                    MessageBox.Show("Ingresa un dato positivo");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error, el dato es incorrecto");
            }


        }
    }
}
