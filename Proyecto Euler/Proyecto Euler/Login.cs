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
    public partial class Login : Form
    {
        //Delegado para mostrar nombre de Usurio en los retos
        public delegate void mostrar(Jugador j);

        //Evento hará lo que corresponde al delegado
        public event mostrar eMostrar;

        //Pantalla siguiente de entrar
        Form_RetoCheck d;

        //Arreglo de Jugadores para leer JSON
        Jugador[] jugadores = new Jugador[100];

        //item para saber ultima posicion usada
        int jugRegistrados;

        public Login()
        {
            InitializeComponent();

            //Se crea siguiente pantalla
            d = new Form_RetoCheck();

            //Asocia el evento con una funcion de la siguiente pantalla
            eMostrar = d.ejecutar;
        }

        //Escribir en archivo de usuarios
        public void WriteUsers(Jugador newJugador)
        {
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            jugadores[jugRegistrados] = newJugador;
            string outputJSON = jsSerializer.Serialize(jugadores);
            File.WriteAllText(@"Files\Usuarios.json", outputJSON);
            eMostrar(jugadores[jugRegistrados]);
        }

        //Leer archivo de usuarios registrados
        public void ReadUsers()
        {
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            string outputJSON = File.ReadAllText(@"Files\Usuarios.json");
            Jugador[] strJugadores = jsSerializer.Deserialize<Jugador[]>(outputJSON);

            getUsuariosRegistrados(strJugadores);

            MessageBox.Show(jugRegistrados.ToString());
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

        //Valida si no existe un usuario ya registrado
        public bool validaNewUser(Jugador[] strJugadores)
        {
            if (jugRegistrados != 0)
            {
                foreach (Jugador item in strJugadores)
                {
                    if (item != null && item.sNombre == tbUsuario.Text)
                    {
                        MessageBox.Show("Intente de nuevo, ese Usuario ya existe");
                        tbUsuario.Text = "";
                        tbContraseña.Text = "";
                        return false;
                    }
                }
            }
            return true;
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

        #region Events
        private void btIniciarSesion_Click(object sender, EventArgs e)
        {
            //RWArchivoTexto();

            if (!string.IsNullOrEmpty(tbUsuario.Text) && !string.IsNullOrEmpty(tbContraseña.Text))
            {
                if (validaNewUser(jugadores))
                {
                    WriteUsers(new Jugador(tbUsuario.Text, tbContraseña.Text));
                    d.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Debe completar la informacion");
            }
        }

        private void Login_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CreateFileOrFolder();
        }
        #endregion

        #region ARCHIVOS DE TEXTO
        //public void RWArchivoTexto()
        //{
        //    #region WRITE
        //    try
        //    {
        //        string[] lines = { "First line", "Second line", "Third line" };

        //        using (StreamWriter file = new StreamWriter(@"Files\WriteLines.txt"))
        //        {
        //            foreach (string line in lines)
        //            {
        //                //if (!line.Contains("Second"))
        //                file.WriteLine(line);
        //            }
        //        }

        //        using (StreamWriter file = new StreamWriter(@"Files\WriteLines.txt", true))
        //        {
        //            file.WriteLine("Fourth line");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Exception: " + ex.Message);
        //    }
        //    #endregion

        //    #region READ
        //    try
        //    {
        //        int counter = 0;
        //        string oneline;

        //        // Read the file and display it line by line.  
        //        StreamReader fileRead = new StreamReader(@"Files\WriteLines.txt");
        //        while ((oneline = fileRead.ReadLine()) != null)
        //        {
        //            MessageBox.Show(oneline);
        //            counter++;
        //        }

        //        fileRead.Close();
        //        MessageBox.Show("There were " + counter + " lines.");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Exception: " + ex.Message);
        //    }
        //    #endregion
        //}
        #endregion
    }
}
