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
    public partial class FormaEntrevista3 : Form
    {
        public FormaEntrevista3()
        {
            InitializeComponent();
        }

        private void FormaEntrevista3_Load(object sender, EventArgs e)
        {
            string videoUr1 = "https://drive.google.com/file/d/1mlcxrWdZdyJlaKjgVHkmC2yE43TwSI6U/view?usp=drive_link";
            webBrowser1.Navigate(videoUr1);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
