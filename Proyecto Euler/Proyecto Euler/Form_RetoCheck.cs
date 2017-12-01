using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Proyecto_Euler
{
    public partial class Form_RetoCheck : Form
    {
        Graphics lienzo;
        PictureBox pb2 = new PictureBox();
        RetoUnica reto;
        Random rand;
        int sigR;
        int r;
        int res, ans, aux;

        //Thread tHiloBarra;

        //delegate void delegado(int iValor);

        public Form_RetoCheck()
        {
            InitializeComponent();
            reto = new RetoUnica();
            rand = new Random();
            sigR = 1;

            //tHiloBarra = new Thread(new ThreadStart(barraTiempo));
        }

        private void Form_RetoCheck_Load(object sender, EventArgs e)
        {
            pb2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.Controls.Add(pb2);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        public void ejecutar(string u, string p)
        {
            lblUsuario.Text = u;
        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {
            if (res == ans && sigR < 4)
            {
                cBFalso.Enabled = true;
                cBVerdadero.Enabled = true;
                res = reto.lRespuesta[sigR];
                lienzo.DrawImage(reto.lRetosFacil[sigR], 0, 0, 569, 507);
                sigR++;
            }
            else
            {
                if(sigR !=4)
                {
                    MessageBox.Show("Respuesta Incorrecta");
                    ans = 2;
                }
                
            }
            clear();
        }

        public void clear()
        {
            cBFalso.Enabled = true;
            cBVerdadero.Enabled = true;
            cBFalso.Checked = false;
            cBVerdadero.Checked = false;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            lienzo = pictureBox1.CreateGraphics();
            res = reto.lRespuesta[0];
            lienzo.DrawImage(reto.lRetosFacil[0], 0, 0, 569, 507);
        }

        private void cBVerdadero_CheckedChanged(object sender, EventArgs e)
        {
            ans = 1;
            btSiguiente.Enabled = true;
            cBFalso.Checked = false;
        }

        private void cBFalso_CheckedChanged(object sender, EventArgs e)
        {
            ans = 0;
            btSiguiente.Enabled = true;
            cBVerdadero.Checked = false;
        }
    }
}
