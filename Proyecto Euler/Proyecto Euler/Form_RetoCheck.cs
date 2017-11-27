using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Euler
{
    public partial class Form_RetoCheck : Form
    {
        Graphics lienzo;
        PictureBox pb2 = new PictureBox();
        Reto reto;
        Random rand;
        int r;
        public Form_RetoCheck()
        {
            InitializeComponent();
             reto = new Reto();
            rand = new Random();
           
        }

        private void Form_RetoCheck_Load(object sender, EventArgs e)
        {
            pb2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.Controls.Add(pb2);

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {
            r = rand.Next(0, 3);
            lienzo.DrawImage(reto.lRetosFacil[r], 0, 0);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            lienzo = pictureBox1.CreateGraphics();
            r = rand.Next(0, 3);
            lienzo.DrawImage(reto.lRetosFacil[r], 0, 0);
        }

        private void cBVerdadero_CheckedChanged(object sender, EventArgs e)
        {
            btSiguiente.Enabled = true;
                      
        }

        private void cBFalso_CheckedChanged(object sender, EventArgs e)
        {
            btSiguiente.Enabled = true;
           
        }
    }
}
