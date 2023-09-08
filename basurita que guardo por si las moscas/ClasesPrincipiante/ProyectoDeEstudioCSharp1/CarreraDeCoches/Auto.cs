using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraDeCoches
{
    public class Auto
    {
        public string Modelo;
        public Color color;
        public float Velocidad;
        public float Gasolina;
        public float Km; 

        

        public void Arrancar()// declaracion de metodo 
        {
            if (Gasolina > 0)//el coche si tiene gas
            {
                Gasolina = Gasolina - 0.1f;
                Console.WriteLine("Arrancando " + Modelo + ", le queda " + Gasolina + "L de gas.");
            }
            else//No tiene gas 
            {
                Console.WriteLine(Modelo + " no tiene gas. No se puede arrancar.");
            }


        }

        public void PonerGas(float cantidad)
        {
            Gasolina = Gasolina + cantidad;
            Console.WriteLine("Se puso gas a  " + Modelo + ". Ahora tiene " + Gasolina + "L.");
        }

        public void Acelerar(float cantidad)
        {
            if (Gasolina > 0)
            {
                Gasolina = cantidad * 1/10f;
                Km = Km + cantidad;
                Console.WriteLine("El " + Modelo + " a pasado de 0 km/h a " + Km + "km/h" + " y a perdido " + Gasolina + " L de Gas");
            }

            else
            { 
                Console.WriteLine("El vehiculo no ha podido Acelerar");
            }
        }

        public void Frenar()
        {
            Console.WriteLine("El " + Modelo + " a frenado repentinamente por fallas en el motor");
        }

    }//fin de la clase 
}
