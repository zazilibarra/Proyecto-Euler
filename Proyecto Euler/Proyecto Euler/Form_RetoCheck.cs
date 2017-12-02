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
        int cantRetos;

        Jugador currentJugador;

        //Delegado
        public delegate void mostrar(Jugador j);

        //Evento hará lo que corresponde al delegado
        public event mostrar eMostrar;
        Form_RetoSeleccionar sigNivel;

        Thread tHilo;
        delegate void delegado(int iValor);

        public Form_RetoCheck()
        {
            InitializeComponent();
            reto = new RetoUnica();
            rand = new Random();
            sigR = 1;
            cantRetos = 1;

            sigNivel = new Form_RetoSeleccionar();
            eMostrar = sigNivel.ejecutar;
        }

        private void Form_RetoCheck_Load(object sender, EventArgs e)
        {
            pb2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.Controls.Add(pb2);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        public void ejecutar(Jugador j)
        {
            lblUsuario.Text = j.sNombre;
            currentJugador = j;
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
            if (sigR == 4)
            {
                this.Hide();
                eMostrar(currentJugador);
                sigNivel.ShowDialog();
                pBTimeFacil.Value = 0;
            }
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

        private void Form_RetoCheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            tHilo.Abort();
            Application.Exit();
        }

        private void Form_RetoCheck_Activated(object sender, EventArgs e)
        {
            tHilo = new Thread(new ThreadStart(Progreso));
            tHilo.Start();
        }

        public void Progreso()
        {
            for (int i = 0; i < 101; i++)
            {
                delegado MD = new delegado(Actualizar1);
                this.Invoke(MD, new object[] { i });
                Thread.Sleep(70);
            }
            MessageBox.Show("Se termino el tiempo");
        }

        public void Actualizar1(int v)
        {
            pBTimeFacil.Value = v;
            if(v == 100)
            {
                pBTimeFacil.Value = 0;
            }
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {

        }
    }
}
