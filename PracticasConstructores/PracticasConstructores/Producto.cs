using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasConstructores
{
    public class Producto
    {
        //atributo
        private float precio;


        public Producto(float valorPrecio)
        {
            precio = valorPrecio;
        }

        public void describir()
        {
            Console.WriteLine("El precio sin IVA es " + precio);
        }


        public float calIVA()
        {
            float calculo = (float)(precio*1.16);
            return calculo;
        }
    }



}
