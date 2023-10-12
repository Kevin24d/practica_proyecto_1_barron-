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
    public partial class FormaHome : Form
    {
        public FormaHome()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void presentacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaPresentacion01 home = new FormaPresentacion01();
            home.Show();
        }

        private void entrevistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaEntrevistas home = new FormaEntrevistas();
            home.Show();
        }

        private void registrateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaRegistrarse home = new FormaRegistrarse();
            home.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaCalculadoraArea home = new FormaCalculadoraArea();
            home.Show();
        }

        private void calculToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaCalculadorDolares home = new FormaCalculadorDolares();
            home.Show();
        }

        private void calculadorDeLpmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaLpm home = new FormaLpm();
            home.Show();
        }

        private void calcudorDeIncrementoDeSalarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaSalario home = new FormaSalario();
            home.Show();
        }

        private void calculadorDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaEcuaciones home = new FormaEcuaciones();
            home.Show();
        }

        private void FormaHome_Load(object sender, EventArgs e)
        {

        }

        private void visorDeImagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureViewer home = new pictureViewer();
            home.Show();
        }
    }
}
