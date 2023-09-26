using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasConstructores
{
    public class Zapato
    {
        private float talla;
        private string color;

        public Zapato(float valorTalla, string valorColor)
        {
            talla = valorTalla;
            color = valorColor;

        }

        public void describir()
        {
            Console.WriteLine("El zapato es de la talla " + talla + " y del color " + color);
        }
    }


}
