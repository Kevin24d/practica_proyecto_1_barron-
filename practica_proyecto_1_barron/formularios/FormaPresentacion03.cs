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
    public partial class FormaPresentacion03 : Form
    {
        public FormaPresentacion03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaPresentacion04 home = new FormaPresentacion04();
            home.Show();
            Hide();
        }
    }
}
