using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Euler
{
    public partial class Form_RetoSeleccionar : Form
    {
        Graphics lienzo;
        PictureBox pb2 = new PictureBox();
        RetoSeleccionar reto;
        Random rand;
        Point p1 = new Point(696, 179);
        Point p2 = new Point(696, 121);
        Point p3 = new Point(696, 150);
        int r, r2;
        string res;
        int ans, aux, aux2;

        public Form_RetoSeleccionar()
        {
            InitializeComponent();
            reto = new RetoSeleccionar();
            rand = new Random();
            aux = 1;
            aux2 = 1;
        }

        private void Form_RetoSeleccionar_Load(object sender, EventArgs e)
        {
            pb2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.Controls.Add(pb2);

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            bt1.BackColor = Color.Aqua;
            btSiguiente.Enabled = true;
            ans = 1;

        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {
            if (ans == 1 && aux < 4)
            {
                res = reto.lRespuestas[aux];
                lienzo.DrawImage(reto.lRetosIntermedios[aux], 0, 0, 569, 507);
                switchRes(aux2);
                r2 = rand.Next(0, 3);
                switchPos(r2);
                aux2++;
                aux++;
                ans = 0;
                limpiar();
            }
            else
            {
                if(aux != 4)
                {
                    MessageBox.Show("Respuesta Incorrecta");
                    limpiar();
                }
                
            }
        }

        public void limpiar()
        {
            bt1.BackColor = Color.White;
            bt2.BackColor = Color.White;
            bt3.BackColor = Color.White;
            btSiguiente.Enabled = false;

        }

        private void bt2_Click(object sender, EventArgs e)
        {
            bt2.BackColor = Color.Aqua;
            btSiguiente.Enabled = true;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            bt3.BackColor = Color.Aqua;
            btSiguiente.Enabled = true;
        }

        public void switchPos(int r)
        {
            switch (r)
            {
                case 0:
                    bt1.Location = p1;
                    bt3.Location = p2;
                    bt2.Location = p3;
                    break;
                case 1:
                    bt1.Location = p2;
                    bt2.Location = p1;
                    bt3.Location = p3;
                    break;
                case 2:
                    bt1.Location = p2;
                    bt2.Location = p3;
                    bt3.Location = p1;
                    break;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            lienzo = pictureBox1.CreateGraphics();
            res = reto.lRespuestas[0];
            switchRes(0);
            lienzo.DrawImage(reto.lRetosIntermedios[0], 0, 0, 569, 507);
                               
         }    
        public void switchRes(int a)
        {
            switch (a)
            {
                case 0:
                    bt1.Text = res;
                    bt2.Text = "18";
                    bt3.Text = "6";
                    break;
                case 1:
                    bt1.Text = res;
                    bt2.Text = "1";
                    bt3.Text = "10";
                    break;
                case 2:
                    bt1.Text = res;
                    bt2.Text = "55555";
                    bt3.Text = "1010101010";
                    break;
                case 3:
                    bt1.Text = res;
                    bt2.Text = "15";
                    bt3.Text = "8";
                    break;
            }

        }
                   
    }
}
