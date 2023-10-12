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
    public partial class FormaEcuaciones : Form
    {
        public FormaEcuaciones()
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
                string v1 = txt1.Text;
                double a = float.Parse(v1);

                string v2 = txt2.Text;
                double b = float.Parse(v2);

                string v3 = txt3.Text;
                double c = float.Parse(v3);
                double x1 = ((b * b) - (4 * a * c));
                double r = Math.Sqrt(x1);
                double b2 = -b;

                double X1 = (b2 + r) / (2 * a);



                double x2 = ((b * b) - (4 * a * c));
                double r2 = Math.Sqrt(x2);
                double b3 = -b;

                double X2 = (b3 - r2) / (2 * a);

                textBox5.Text = X2.ToString();
                textBox4.Text = X1.ToString();


            }
            catch
            {
                MessageBox.Show("No se puede resorver esta ecuacion");
            }


        }
    }
}
