using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraDeCoches
{
    public class PistaCarreras
    {
        public string Nombre;
        public float Longitud;


        //Metodo que recibe 2 parametros 
        public void Competir(Auto auto1, Auto auto2) 
        {//Metodo del bloque

            Console.WriteLine("Iniciando competencia entre " + auto1.Modelo + " contra " + auto2.Modelo);

            if (auto1.Velocidad > auto2.Velocidad)
            {
                Console.WriteLine("Gano" + auto1.Modelo);
            }

            else if (auto2.Velocidad > auto1.Velocidad)
            {
                Console.WriteLine("Gano" + auto2.Modelo);
            }

            else 
            {
                Console.WriteLine("Hubo un empate");
            }

        }
    }
}
