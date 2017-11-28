using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Euler
{
    class RetoUnica
    {
        public List<Image> lRetosFacil;
        public List<int> lRespuesta;

        public RetoUnica()
        {
            lRetosFacil = new List<Image>();
            lRespuesta = new List<int>();
            agregarRetos();
            agregarRespuesta();
        }

        public void agregarRespuesta()
        {
            lRespuesta.Add(0);
            lRespuesta.Add(1);
            lRespuesta.Add(0);
            lRespuesta.Add(1);
        }

        public void agregarRetos()
        {
            lRetosFacil.Add(Image.FromFile("RFF1.png"));
            lRetosFacil.Add(Image.FromFile("RFV1.png"));
            lRetosFacil.Add(Image.FromFile("RFF2.png"));
            lRetosFacil.Add(Image.FromFile("RFV2.png"));
        }
    }
}
