using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraDeCoches
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto Ferrari = new Auto();
            Ferrari.Modelo = "FerratiOne";
            Ferrari.Velocidad = 120;

            Auto Lamborghini = new Auto();
            Lamborghini.Modelo = "SVJ 2018 V12";
            Lamborghini.Velocidad = 140; //Km/h

            PistaCarreras Pista1 = new PistaCarreras();
            Pista1.Nombre = "Legacy";
            Pista1.Longitud = 4.303f;//Km 

            Ferrari.PonerGas(30);
            Ferrari.Arrancar();//invocacion de metodo 

            Lamborghini.PonerGas(0);
            Lamborghini.Arrancar();
            Lamborghini.Acelerar(0);

            Ferrari.Acelerar(100);
            Ferrari.Frenar();


            Pista1.Competir(Ferrari, Lamborghini);

            //Esta linea espera que se presione enter para continuar
            Console.ReadLine();

        }
    }
}
