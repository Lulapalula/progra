using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//me daré el lujo de explicar todo para que yo tambien PUEDA ENTENDER
namespace CarreraDeCoches //declaraciòn de espacio de nombres CarreraDeCoches
{
    public class Auto //Declaración de clase Auto dentro de namespace
    {
        public string Modelo; //Declaración de atributo Modelo dentro de clase Auto
        public Color color;//Declaración de atributo Color dentro de clase Auto
        public float Velocidad;//Declaración de atributo Velocidad dentro de clase Auto
        public float Gasolina;//Declaración de atributo Gasolina dentro de clase Auto
        public float Km; //Declaración de atributo Km dentro de clase Auto


        //Declaración de método Arrancar dentro de clase Auto
        public void Arrancar()
        {
            if (Gasolina > 0)//inicio de bloque condicional if dentro del metodo arrancar; el coche si tiene gas
            {
                Gasolina = Gasolina - 0.1f;
                Console.WriteLine("Arrancando " + Modelo + ", le queda " + Gasolina + "L de gas.");
            }
            else//inicio de bloque condicional else dentro del metodo arrancar; No tiene gas 
            {
                Console.WriteLine(Modelo + " no tiene gas. No se puede arrancar.");
            }


        }
        //Declaración de método PonerGas dentro de clase Auto
        //Declaración de parametro cantidad dentro de método PonerGas
        public void PonerGas(float cantidad)
        {
            Gasolina = Gasolina + cantidad; //uso del atributo
            Console.WriteLine("Se puso gas a  " + Modelo + ". Ahora tiene " + Gasolina + "L.");
        }
        //Declaración de método Acelarar dentro de clase Auto
        //Declaración de parametro cantidad dentro de método Acelerar
        public void Acelerar(float cantidad)
        {
            if (Gasolina > 0) //inicio de bloque condicional if dentro del metodo arrancar; el coche si tiene gas
            {
                Gasolina = cantidad * 1/10f;
                Km = Km + cantidad;
                Console.WriteLine("El " + Modelo + " a pasado de 0 km/h a " + Km + "km/h" + " y a perdido " + Gasolina + " L de Gas");
            }

            else //inicio de bloque condicional else dentro del metodo arrancar; No tiene gas 
            { 
                Console.WriteLine("El vehiculo no ha podido Acelerar");
            }
        }

        //Declaración de método Frenar dentro de clase Auto
        public void Frenar()
        {
            Console.WriteLine("El " + Modelo + " a frenado repentinamente por fallas en el motor");
        }

    }//fin de la clase 
}
