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

        public void ejecutar(string u, string p)
        {
            lblUsuario.Text = u;
            lblContraseña.Text = p;
        }

        private void DatosUsuario_Load(object sender, EventArgs e)
        {
            Login FormLogin = new Login();
            FormLogin.eMostrar += new Login.mostrar(ejecutar);
        }
    }
}
