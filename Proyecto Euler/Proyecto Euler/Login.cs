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
        //Delegado
        public delegate void mostrar(string n, string p);

        //Evento hará lo que corresponde al delegado
        public event mostrar eMostrar;
        Form_RetoCheck d;

        public Login()
        {
            InitializeComponent();

            //d = new DatosUsuario();
            d = new Form_RetoCheck();
            eMostrar = d.ejecutar;
        }

        private void btIniciarSesion_Click(object sender, EventArgs e)
        {
            //RWArchivoTexto();

            eMostrar(tbUsuario.Text, tbContraseña.Text);
            d.ShowDialog();
        }

        #region JSON
        public void WriteUsers()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();
            Jugador p1 = new Jugador();
            string outputJSON = ser.Serialize(p1);
            File.WriteAllText(@"Files\Usuarios.json", outputJSON);
        }

        //public void WriteUsers(Jugador jUser)
        //{
        //    JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
        //    string outputJSON = jsSerializer.Serialize(jUser);
        //    File.WriteAllText(@"Files\Usuarios.json", outputJSON);
        //}

        public void ReadUsers()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string outputJSON = File.ReadAllText(@"Files\Usuarios.json");
            Jugador [] p1 = ser.Deserialize<Jugador[]>(outputJSON);
            MessageBox.Show(p1.ToString());
        }
        #endregion

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
            Menu formMenu = new Menu();
            formMenu.Visible = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CreateFileOrFolder();            
        }

        public void CreateFileOrFolder()
        {
            string folderName = @"Files";
            string pathString = System.IO.Path.Combine(folderName, "SubFolder");

            System.IO.Directory.CreateDirectory(pathString);

            string fileName = "Usuarios.json";

            pathString = System.IO.Path.Combine(pathString, fileName);
            MessageBox.Show("Ruta: " + pathString);

            if (!System.IO.File.Exists(pathString))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(pathString))
                {
                    for (byte i = 0; i < 10; i++)
                    {
                        fs.WriteByte(i);
                    }
                }
            }
            else
            {
                MessageBox.Show("File" + fileName+ " already exists.");
                return;
            }

            // Read and display the data from your file.
            try
            {
                byte[] readBuffer = System.IO.File.ReadAllBytes(pathString);
                foreach (byte b in readBuffer)
                {
                    MessageBox.Show(b + " ");
                }
            }
            catch (System.IO.IOException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Login_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

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
