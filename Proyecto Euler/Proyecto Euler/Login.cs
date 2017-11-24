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

        public Login()
        {
            InitializeComponent();
        }

        #region JSON
        public void WJson()
        {
            //Objeto partir de la clase JavaScriptSerializer para acceder  funciones de serialización y deserialización.
            JavaScriptSerializer ser = new JavaScriptSerializer();
            //Crear un objeto Jugador a partir de la clase jugardor e inicializar sus atributos.
            Jugador p1 = new Jugador();
            //outputJSON (string), almacenará la cadena deserializada en formato JSON. 
            string outputJSON = ser.Serialize(p1);
            //WriteAllText de la clase File para escribir nuestro outputJSON al archivo que indicamos. 
            //parámetro pondremos el nombre del archivo, segundo pondremos la cadena a escribir.
            //File.WriteAllText(@"Files\MiPrimerJSON.json", outputJSON);

            using (StreamWriter file = new StreamWriter(@"Files\MiPrimerJSON.json", true))
            {
                file.WriteLine(outputJSON);
            }

        }

        public void RJson()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();
            string outputJSON = File.ReadAllText(@"Files\MiPrimerJSON.json");
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
            
        }

        private void btIniciarSesion_Click(object sender, EventArgs e)
        {
            //RWArchivoTexto();
            //WJson();
            //RJson();

            eMostrar(tbUsuario.Text, tbContraseña.Text);
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
