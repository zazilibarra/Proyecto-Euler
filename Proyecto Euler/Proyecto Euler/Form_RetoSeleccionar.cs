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
        Point p1 = new Point(696,179);
        Point p2 = new Point(696, 121);
        Point p3 = new Point(696, 150);
        int r, r2;
        string res;
        int ans, aux;

        public Form_RetoSeleccionar()
        {
            InitializeComponent();
            reto = new RetoSeleccionar();
            rand = new Random();
        }
        private void Form_RetoSeleccionar_Load(object sender, EventArgs e)
        {
            pb2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.Controls.Add(pb2);           
            
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            ans = 1;
        }

        private void btSiguiente_Click(object sender, EventArgs e)
        {
            if(ans == 1)
            {
                r = rand.Next(0, 3);
                res = reto.lRespuestas[r];
                lienzo.DrawImage(reto.lRetosIntermedios[r], 0, 0, 569, 507);
                bt1.Text = res;
                Thread.Sleep(10);
                r2 = rand.Next(0, 3);
                switch(r2)
                {
                    case 0: bt1.Location = p1;
                            bt3.Location = p2;
                            bt2.Location = p3;
                            break;
                    case 1: bt1.Location = p2;
                            bt2.Location = p1;
                            bt3.Location = p3;                            
                            break;
                    case 2: bt1.Location = p2;
                            bt2.Location = p3;
                            bt3.Location = p1;
                            break;
                }
                ans = 0;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            lienzo = pictureBox1.CreateGraphics();
            r = rand.Next(0, 3);
            res = reto.lRespuestas[r];
            lienzo.DrawImage(reto.lRetosIntermedios[r], 0, 0, 569, 507);
            bt1.Text = res;
        }    
                   
    }
}
