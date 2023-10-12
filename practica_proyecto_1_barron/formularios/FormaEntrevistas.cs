using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using practica_proyecto_1_barron.formularios;

namespace practica_proyecto_1_barron.formularios
{
    public partial class FormaEntrevistas : Form
    {
        public FormaEntrevistas()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaEntrevista1 video = new FormaEntrevista1();
            video.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormaEntrevista2 video = new FormaEntrevista2();
            video.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormaEntrevista3 video = new FormaEntrevista3();
            video.Show();
        }

        private void FormaEntrevistas_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
