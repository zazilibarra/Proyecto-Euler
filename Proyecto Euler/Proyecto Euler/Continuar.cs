using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web.Script.Serialization;

namespace Proyecto_Euler
{
    public partial class Continuar : Form
    {
        //Delegado para mostrar nombre de Usurio en los retos
        public delegate void mostrar(Jugador j);

        //Evento hará lo que corresponde al delegado
        public event mostrar eMostrar;

        //Arreglo de Jugadores para leer JSON
        Jugador[] jugadores = new Jugador[100];

        //item para saber ultima posicion usada
        int jugRegistrados;

        public Continuar()
        {
            InitializeComponent();
        }

        //Leer archivo de usuarios registrados
        public void ReadUsers()
        {
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            string outputJSON = File.ReadAllText(@"Files\Usuarios.json");
            Jugador[] strJugadores = jsSerializer.Deserialize<Jugador[]>(outputJSON);

            getUsuariosRegistrados(strJugadores);

            //MessageBox.Show(jugRegistrados.ToString());
        }

        //Obtener cantidad y arreglo de usuarios que ya estan en el archivo JSON
        public void getUsuariosRegistrados(Jugador[] strJugadores)
        {
            jugRegistrados = 0;
            int i = 0;

            if (strJugadores != null)
            {
                foreach (Jugador item in strJugadores)
                {
                    if (item != null)
                    {
                        jugadores[i] = item;
                        jugRegistrados++;
                    }
                    i++;
                }
            }
        }

        //Metodo para validar si existe la carpeta y archivo donde se guardan los usuarios
        public void CreateFileOrFolder()
        {
            string folderName = @"Files";

            System.IO.Directory.CreateDirectory(folderName);

            string fileName = "Usuarios.json";

            string pathString = System.IO.Path.Combine(folderName, fileName);
            //MessageBox.Show("Ruta: " + pathString);

            if (!System.IO.File.Exists(pathString))
            {
                //Crea el archivo si no existe
                FileStream fs = File.Create(pathString);
            }
            else
            {
                //Si existe el documento lo lee
                ReadUsers();
                return;
            }
        }

        public Jugador validaUser()
        {
            if (jugRegistrados != 0)
            {
                foreach (Jugador item in jugadores)
                {
                    if (item != null && item.sNombre == tbUsuario.Text)
                    {
                        if (item.Contraseña == tbContraseña.Text)
                        {
                            return item;
                        }
                        else
                        {
                            MessageBox.Show("Validar datos. Contraseña incorrecta");
                            tbContraseña.Text = "";
                            return null;
                        }
                    }
                }
                MessageBox.Show("Validar datos. El usuario no existe");
                tbUsuario.Text = "";
                tbContraseña.Text = "";
            }
            return null;
        }

        private void Continuar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Continuar_Load(object sender, EventArgs e)
        {
            CreateFileOrFolder();
        }

        private void btIniciarSesion_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbUsuario.Text) && !string.IsNullOrEmpty(tbContraseña.Text))
            {
                Jugador current = validaUser();
                if (current.Reto == 0 || current.Reto == 1 && current != null)
                {
                    Form_RetoCheck sigForm = new Form_RetoCheck();
                    eMostrar = sigForm.ejecutar;
                    eMostrar(current);
                    this.Hide();
                    sigForm.ShowDialog();
                }
                else if (current.Reto == 2)
                {
                    Form_RetoSeleccionar sigForm = new Form_RetoSeleccionar();
                    eMostrar = sigForm.ejecutar;
                    eMostrar(current);
                    this.Hide();
                    sigForm.ShowDialog();
                }
                else
                {
                    Form_RetoCompletar sigForm = new Form_RetoCompletar();
                    eMostrar = sigForm.ejecutar;
                    eMostrar(current);
                    this.Hide();
                    sigForm.ShowDialog();
                }
                
                //form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe completar la información");
            }
        }
    }
}
