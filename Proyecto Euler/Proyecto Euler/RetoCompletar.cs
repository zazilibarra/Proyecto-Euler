using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Euler
{
    class RetoCompletar
    {
        public List<Image> lRetosDificiles;
        public List<String> lRespuestas;

        public RetoCompletar()
        {
            lRetosDificiles = new List<Image>();
            lRespuestas = new List<string>();

            agregarRetos();
            agregarRespuesta();
            
        }

        public void agregarRespuesta()
        {
            lRespuestas.Add("limite");
            lRespuestas.Add("aux++");
            lRespuestas.Add("if");
            lRespuestas.Add("i");
            lRespuestas.Add("Add");
            lRespuestas.Add("sum");
            lRespuestas.Add("<");
            lRespuestas.Add("%");
            lRespuestas.Add("+=");
        }

        public void agregarRetos()
        {
            lRetosDificiles.Add(Image.FromFile("RD1.png"));
            lRetosDificiles.Add(Image.FromFile("RD2.png"));
            lRetosDificiles.Add(Image.FromFile("RD3.png"));
            
        }
    }
}
