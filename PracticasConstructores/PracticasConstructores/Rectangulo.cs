using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasConstructores
{
    public class Rectangulo
    {
        //valore por default
        private float ancho =5;
        private float alto =10;

        //este es un constructorrrrrrr y no tiene parametros
        public Rectangulo()
        {

        }


        //otro constructor que si recibe paramretros
        public Rectangulo(float valorAncho, float valorAlto)
        {//establezco el estado inicial del
            ancho = valorAncho;
            alto = valorAlto;
        }
        public void describir()
        {
            Console.WriteLine("rectangulo" + ancho + "X" + alto);
        }
        public float calArea()
        {
            float area = alto * ancho;
            return area;
        }

        public void setAlto(float valor)
        {
            alto =valor;
        }
    }
}
