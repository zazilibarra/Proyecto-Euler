using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto_Euler
{
    class Jugador
    {
        public static int iID = 0;
        public int iIDReto;
        public string sNombre { get; set; }
        public string sContraseña { get; set; }

        public Jugador(string n, string p)
        {
            sNombre = n;
            sContraseña = p;
            iID++;
            iIDReto = 1;
        }

        public Jugador()
        {
            
        }

        public void contestar()
        {

        }

        public void registrarAvance()
        {

        }

        public override string ToString()
        {
            return "iDUsuario: " + iID + "\nNombre: " + sNombre + "\nContraseña: " + sContraseña +"\nReto: " +iIDReto;
        }

        #region METODOS DE ACCESO
        public int ID
        {
            get
            {
                return iID;
            }
            set
            {
                iID = value;
            }
        }

        public int Reto
        {
            get
            {
                return iIDReto;
            }
            set
            {
                iIDReto = value;
            }
        }

        public string Nombre
        {
            get
            {
                return sNombre;
            }
            set
            {
                sNombre = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return sContraseña;
            }
            set
            {
                sContraseña = value;
            }
        }
        #endregion
    }
}
