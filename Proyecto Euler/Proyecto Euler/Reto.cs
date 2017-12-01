using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;


namespace Proyecto_Euler
{
    class Reto
    {
        private int iID;
        public  List<Image> lRetosFacil;
        public List<Image> lRetosIntermedio;
        public List<Image> lRetosDificil;

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
