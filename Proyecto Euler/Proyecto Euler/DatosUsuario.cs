using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Euler
{
    public partial class DatosUsuario : Form
    {
        

        public DatosUsuario()
        {
            InitializeComponent();
        }

        public void ejecutar(Jugador j)
        {
            lblUsuario.Text = j.sNombre;
            //lblContraseña.Text = j.Contraseña.ToString();
        }

        private void DatosUsuario_Load(object sender, EventArgs e)
        {
            //Login FormLogin = new Login();
            //FormLogin.eMostrar += new Login.mostrar(ejecutar);
        }
    }
}
