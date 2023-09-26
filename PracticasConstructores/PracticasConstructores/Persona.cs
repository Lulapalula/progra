using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasConstructores
{
    public class Persona
    {
        private float añoNacimiento;

        public Persona(float valorAño)
        {
            añoNacimiento = valorAño;
        }

        public void describir()
        {
            Console.WriteLine("tu año de nacimiento es " + añoNacimiento);
        }


        public float calEdad()
        {
            float Edad = (float)(2023 - añoNacimiento);
            return Edad;
        }
    }


}
