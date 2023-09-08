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


        //Declaración de método competir dentro de clase PistaCarreras
        public void Competir(Auto auto1, Auto auto2) 
        {

            Console.WriteLine("Iniciando competencia entre " + auto1.Modelo + " contra " + auto2.Modelo);

            if (auto1.Velocidad > auto2.Velocidad)  //inicio de bloque condicional if dentro del metodo Competir
            {
                Console.WriteLine("Gano" + auto1.Modelo);
            }

            else if (auto2.Velocidad > auto1.Velocidad) //inicio de bloque condicional else dentro del metodo Competir
            {
                Console.WriteLine("Gano" + auto2.Modelo);
            }

            else //inicio de bloque condicional else dentro del metodo competir
            {
                Console.WriteLine("Hubo un empate");
            }

        }
    }
}
