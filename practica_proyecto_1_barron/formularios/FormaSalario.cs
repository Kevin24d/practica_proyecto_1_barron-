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
    public partial class FormaSalario : Form
    {
        public FormaSalario()
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
                float sal;
                float inc;
                float tota;
                sal = float.Parse(textSalario.Text);

                if (sal > 0)
                {
                    inc = 25 * sal / 100;
                    tota = inc + sal;
                    textIncremento.Text = ("$" + inc.ToString());
                    textTotal.Text = ("$" + tota.ToString());
                }
                else
                {
                    MessageBox.Show("Error, Ingresa un valor positivo");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error, El dato es incorrecto");
            }
        }
    }
}
