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
    public partial class FormaEntrevista1 : Form
    {
        public FormaEntrevista1()
        {
            InitializeComponent();
        }

        private void FormaEntrevista1_Load(object sender, EventArgs e)
        {
            string videoUr3 = "https://drive.google.com/file/d/1ukG9BaJ7tajlHt4STQTklt6JItDnCbx2/view?usp=drive_link";
            webBrowser1.Navigate(videoUr3);
        }
    }
}
