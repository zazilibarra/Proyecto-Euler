﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.IO;

namespace Proyecto_Euler
{
    public partial class Form_RetoCompletar : Form
    {
        Graphics lienzo;
        PictureBox pb2 = new PictureBox();
        RetoCompletar reto;
        Random rand;
        Point p1 = new Point(609,95);
        Point p2 = new Point(669,95);
        Point p3 = new Point(732,95);
        int sigR,r; 
        int auxRes;

        Thread tHilo;
        delegate void delegado(int iValor);

        Jugador currentJugador;

        //Arreglo de Jugadores para leer JSON
        Jugador[] jugadores = new Jugador[100];

        public Form_RetoCompletar()
        {
            InitializeComponent();
            reto = new RetoCompletar();
            rand = new Random();
            sigR = 1;
            auxRes = 0;   
  
        }
        //Metodo para cambiar de posicion los labels
        public void switchPos(int r1)
        {
            switch (r1)
            {
                case 0:
                    label2.Location = p1;
                    label3.Location = p2;
                    label4.Location = p3;
                    break;
                case 1:
                    label2.Location = p2;
                    label3.Location = p1;
                    label4.Location = p3;
                    break;
                case 2:
                    label2.Location = p2;
                    label3.Location = p3;
                    label4.Location = p1;
                    break;
            }
        }
        //Evento para cargar una imagen en el picture box en el momento en el que se carga el form
        private void Form_RetoCompletar_Load(object sender, EventArgs e)
        {
            pb2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.Controls.Add(pb2);
        }

        public void ejecutar(Jugador j)
        {
            lblUsuario.Text = j.sNombre;
            currentJugador = j;
        }

        //Evento para cargar el primer Reto en el picturebox
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            lienzo = pictureBox1.CreateGraphics();
            lienzo.DrawImage(reto.lRetosDificiles[0], 0, 0, 569, 507);
            label2.Text = reto.lRespuestas[0];
            label3.Text = reto.lRespuestas[1];
            label4.Text = reto.lRespuestas[2];
            
        }
        
        //Evento para pasar al siguiente reto, se realizan las evaluaciones necesarias
        private void btSiguiente_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == reto.lRespuestas[auxRes] && textBox2.Text == reto.lRespuestas[auxRes + 1] && textBox3.Text == reto.lRespuestas[auxRes + 2])
            {
                r = rand.Next(0, 3);
                lienzo.DrawImage(reto.lRetosDificiles[sigR], 0, 0, 569, 507);
                sigR++;
                auxRes+=3;
                switchPos(r);
                actualizarLabels(auxRes);
                limpiar();
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta");
                limpiar();
            }
            
        }

        //Metodo para actualizar los labels de las respuestas
        public void actualizarLabels(int i)
        {
            label2.Text = reto.lRespuestas[i];
            label3.Text = reto.lRespuestas[i + 1];
            label4.Text = reto.lRespuestas[i + 2];
        }

        //Metodo para limpiar los textbox
        public void limpiar()
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            btSiguiente.Enabled = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        //Evento para habilitar textbox 2
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }
        //Evento para habilitar boton siguiente
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            btSiguiente.Enabled = true;
        }
        //Evento para habilitar text box 3
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = true;
        }

        private void Form_RetoCompletar_FormClosing(object sender, FormClosingEventArgs e)
        {
            tHilo.Abort();
            Application.Exit();
        }

        private void Form_RetoCompletar_Activated(object sender, EventArgs e)
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
                Thread.Sleep(140);
            }
        }

        public void Actualizar1(int v)
        {
            pbTimeDificil.Value = v;
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
                    strJugadores[i].Reto = 3;
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
