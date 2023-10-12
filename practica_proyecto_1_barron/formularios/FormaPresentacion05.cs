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
    public partial class FormaPresentacion05 : Form
    {
        public FormaPresentacion05()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaPresentacionEntrevista1 home = new FormaPresentacionEntrevista1();
            home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormaPresentacionEntrevista2 home = new FormaPresentacionEntrevista2();
            home.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormaPresentacionEntrevista3 home = new FormaPresentacionEntrevista3();
            home.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormaPresentacion06 home = new FormaPresentacion06();
            home.Show();
            Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
