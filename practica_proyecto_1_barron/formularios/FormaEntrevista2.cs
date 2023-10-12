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
    public partial class FormaEntrevista2 : Form
    {
        public FormaEntrevista2()
        {
            InitializeComponent();
        }

        private void FormaEntrevista2_Load(object sender, EventArgs e)
        {
            string videoUr2 = "https://drive.google.com/file/d/1YZSEC1Le97tKdaIOQHEQ6c2WIOqjks6Q/view?usp=drive_link";
            webBrowser1.Navigate(videoUr2);
        }
    }
}
