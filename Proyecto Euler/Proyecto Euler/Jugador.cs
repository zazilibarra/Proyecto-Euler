using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto_Euler
{
    public class Jugador
    {
        private static int iID = 0;
        private int iIDReto;
        public string sNombre { get; set; } //Publico para poder acceder a él con delegado
        private string sContraseña;

        public Jugador(string n, string p)
        {
            sNombre = n;
            sContraseña = p;
            iID++;
            iIDReto = 0;
        }

        //Constructor vacio para manejar con JSON
        public Jugador()
        {

        }

        //Sobrecarga de metodo 'ToString' para Jugador
        public override string ToString()
        {
            return "iDUsuario: " + iID + "\nNombre: " + sNombre + "\nContraseña: " + sContraseña + "\nReto: " + iIDReto;
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
