using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Euler
{
    class Reto
    {
        private int iID;
        public  List<Image> lRetosFacil;
        private List<Image> lRetosIntermedio;
        private List<Image> lRetosDificil;
        private List<Respuesta> lRespuestas;

        public Reto()
        {
            lRetosFacil = new List<Image>();
            lRetosIntermedio = new List<Image>();
            lRetosDificil = new List<Image>();
            agregarRetos();

        }

        public void agregarRetos()
        {
            lRetosFacil.Add(Image.FromFile("RFF1.png"));
            lRetosFacil.Add(Image.FromFile("RFV1.png"));
            lRetosFacil.Add(Image.FromFile("RFF2.png"));
            lRetosFacil.Add(Image.FromFile("RFV2.png"));

        }
        
        public void iniciar()
        {

        }

        public bool evaluar()
        {
            return true;
        }

        public void avanzar()
        {

        }
    }

}
