using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Euler
{
    class RetoSeleccionar
    {
        public List<Image> lRetosIntermedios;
        public List<String> lRespuestas;
        public RetoSeleccionar()
        {
            lRespuestas = new List<string>();
            lRetosIntermedios = new List<Image>();

            agregarRetos();
            agregarRespuesta();
        }

        public void agregarRespuesta()
        {
            lRespuestas.Add("5");
            lRespuestas.Add("3");
            lRespuestas.Add("4242424242");
            lRespuestas.Add("16");
        }

        public void agregarRetos()
        {
            lRetosIntermedios.Add(Image.FromFile("RI1.png"));
            lRetosIntermedios.Add(Image.FromFile("RI2.png"));
            lRetosIntermedios.Add(Image.FromFile("RI3.png"));
            lRetosIntermedios.Add(Image.FromFile("RI4.png"));
        }


    }
}
