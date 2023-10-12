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
    public partial class pictureViewer : Form
    {
        public pictureViewer()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Muestra el cuadro de diálogo Abrir archivo. Si el usuario hace clic en Aceptar, cargara la +
             //imagen que eligió el usuario.
            if (openFileDialog1.ShowDialog() == DialogResult.OK) ;
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Quitara la imagen
            pictureBox1.Image = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Muestra el cuadro de diálogo de color. Si el usuario hace clic en Aceptar, cambie el 
            //fondo del control PictureBox al color que eligió el usuario.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Si el usuario selecciona la casilla de verificación Estirar, cambie la
            //propiedad SizeMode del PictureBox a 
            //"Estirar". Si el usuario desactiva la casilla de verificación, cámbiela a "Normal". 
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
