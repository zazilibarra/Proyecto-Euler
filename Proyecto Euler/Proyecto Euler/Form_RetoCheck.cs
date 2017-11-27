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
        Reto reto;
        Random rand;
        int r;
        public Form_RetoCheck()
        {
            InitializeComponent();
            lienzo = pictureBox1.CreateGraphics();
            reto = new Reto();
            rand = new Random();
           
        }

        private void Form_RetoCheck_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            r = rand.Next(0, 3);
            lienzo.DrawImage(reto.lRetosFacil[r], 0, 0);
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
