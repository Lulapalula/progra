using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasConstructores
{
    public class Triangulo
    {
        //valore por default
        private float primerLado;
        private float segundoLado;
        private float tercerLado;


        //otro constructor que si recibe paramretros
        public Triangulo(float valorPrimerLado, float valorSegundoLado, float valorTercerLado)
        {//establezco el estado inicial del
            primerLado = valorPrimerLado;
            segundoLado = valorSegundoLado;
            tercerLado = valorTercerLado;
        }

        public void describir()
        {
            Console.WriteLine("Triangulo de " + primerLado + " X " + segundoLado + " X " + tercerLado);
        }
        public float calPeri()
        {
            float perimetro = primerLado * segundoLado * tercerLado;
            return perimetro;
        }

    }

}

