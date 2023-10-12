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
    public partial class FormaLpm : Form
    {
        public FormaLpm()
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
                float lat;
                float res;
                lat = float.Parse(textLpm.Text);
                if(lat > 0)
                {
                    if (lat < 121)
                    {
                        res = 220 - lat;
                        textSalida.Text = (res.ToString() + " Lpm");
                    }
                    else
                    {
                        MessageBox.Show("Error, Edad no valida");
                    }
                }
                

                else
                {
                    MessageBox.Show("Error, Ingresa una edad positiva");
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Error, el dato es incorrecto");
            }

        }
    }
}
