using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Web.Script.Serialization;
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
        int ans, aux, aux2, cantRetos;

        Jugador currentJugador;

        //Arreglo de Jugadores para leer JSON
        Jugador[] jugadores = new Jugador[100];

        Thread tHilo;
        delegate void delegado(int iValor);

        //Delegado
        public delegate void mostrar(Jugador j);

        //Evento hará lo que corresponde al delegado
        public event mostrar eMostrar;
        Form_RetoCompletar sigNivel;

        public Form_RetoSeleccionar()
        {
            InitializeComponent();
            reto = new RetoSeleccionar();
            rand = new Random();
            aux = 1;
            aux2 = 1;
            cantRetos = 1;

            sigNivel = new Form_RetoCompletar();
            eMostrar = sigNivel.ejecutar;
        }

        private void Form_RetoSeleccionar_Load(object sender, EventArgs e)
        {
            pb2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.Controls.Add(pb2);
        }

        public void ejecutar(Jugador j)
        {
            lblUsuario.Text = j.sNombre;
            currentJugador = j;
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
                cantRetos++;
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
            if (cantRetos == 4)
            {
                this.Hide();
                eMostrar(currentJugador);
                sigNivel.ShowDialog();
                pbTimeMedio.Value = 0;
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

        private void Form_RetoSeleccionar_FormClosing(object sender, FormClosingEventArgs e)
        {
            tHilo.Abort();
            Application.Exit();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form_RetoSeleccionar_Activated(object sender, EventArgs e)
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
                Thread.Sleep(180);
            }
        }

        public void Actualizar1(int v)
        {
            pbTimeMedio.Value = v;
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            ReadUsers();
            guardaProgreso(jugadores);
            WriteUsers();
            tHilo.Abort();
            this.Hide();
            Menu formMenu = new Menu();
            formMenu.ShowDialog();
        }

        public void ReadUsers()
        {
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            string outputJSON = File.ReadAllText(@"Files\Usuarios.json");
            Jugador[] strJugadores = jsSerializer.Deserialize<Jugador[]>(outputJSON);

            getUsuariosRegistrados(strJugadores);
        }

        //Obtener cantidad y arreglo de usuarios que ya estan en el archivo JSON
        public void getUsuariosRegistrados(Jugador[] strJugadores)
        {
            int i = 0;

            if (strJugadores != null)
            {
                foreach (Jugador item in strJugadores)
                {
                    if (item != null)
                    {
                        jugadores[i] = item;
                    }
                    i++;
                }
            }
        }

        public void guardaProgreso(Jugador[] strJugadores)
        {
            for (int i = 0; i < strJugadores.Length; i++)
            {
                if (strJugadores[i] != null && strJugadores[i].sNombre == currentJugador.sNombre)
                {
                    strJugadores[i].Reto = 2;
                }
            }
        }

        //Escribir en archivo de usuarios
        public void WriteUsers()
        {
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            string outputJSON = jsSerializer.Serialize(jugadores);
            File.WriteAllText(@"Files\Usuarios.json", outputJSON);
        }
                   
    }
}
