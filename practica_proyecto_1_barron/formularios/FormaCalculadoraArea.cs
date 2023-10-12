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
    public partial class FormaCalculadoraArea : Form
    {
        public FormaCalculadoraArea()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void butonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float bas;
                float alt;
                float res;
                bas = float.Parse(textoBase.Text);
                alt = float.Parse(textoAltura.Text);

                if (bas > 0 && alt > 0)
                {
                    res = bas * alt / 2;
                    textoResultado.Text = res.ToString();
                }
                else 
                {
                    MessageBox.Show("Error, Ingresa un valor positivo");
                }
            }

            catch (Exception error)
            {
                MessageBox.Show("Error, el dato es Incorrecto");
            }


        }
    }
}
