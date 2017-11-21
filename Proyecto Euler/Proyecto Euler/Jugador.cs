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
        public int iIDReto;
        public string sNombre {get; set;}
        private string sContraseña {get; set;}

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
            return "Nombre: " + sNombre + "\nReto: " +iIDReto;
        }
    }
}
