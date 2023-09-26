using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasConstructores
{
    class Circulo
    {
        private float radio;
        public Circulo(float valorRadio)
        {
            radio = valorRadio;
        }

        public void describir()
        {
            Console.WriteLine("Circulo de " + radio + "de radio");
        }

        public float calculoPerimetro()
        {
            float perimetro = (float) (2*3.14*radio);
            return perimetro;
        }
    }
}
