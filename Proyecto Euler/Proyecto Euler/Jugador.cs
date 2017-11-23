using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Euler
{
    class Jugador
    {
        private int iID;
        private int iIDReto;
        private string sNombre;
        private string sContraseña;

        public Jugador(string n, string p)
        {
            sNombre = n;
            sContraseña = p;
            iID = 1;
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
