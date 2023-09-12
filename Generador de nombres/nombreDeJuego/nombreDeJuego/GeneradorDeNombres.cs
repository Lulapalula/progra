using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombreDeJugador
{
     class GeneradorDeNombres//clase 
    {
        //atributos
        string[] nombres = {"Ninja ", "Tanque ", "Guardian ", "Gorila ", "Mutante ", "Capitan ",
        "Cabra ", "Guerrero ", "Angel ", "doctor ", "Niño ", "Espadachin ", "Fontanero ", "Robot ",
        "Ninja ", "Superviviente ", "Criatura ", "Jugador ", "Dios ", "Abogado ", "Bruja ", "rana ",
        "Caracol ", "ave ", "Vaca ", "perro "};

        string[] apellidos = { "Saltarin ", "Veloz ", "Espacial ", "llameante ", "Nobato ", "Asesino ",
        "Censurado ", "Artista ", "Troll ", "Cuadrado ", "Melodìa ", "Sensual ", "Valiente ",
        "Extraño ", "Friki ", "Campeon ", " ", "Salvaje ", "Fornida ", "Colosal ",
        "Feroz ", "del Abismo ", "Rocosa ", "Fiestera ", "Fantasmal ", "Voladora " };

        public void generar(int dia, int mes)//metodo
        {
            Console.WriteLine("Tu nombre de jugardor es: " + nombres [ dia ] + apellidos [ mes ]);
        }
        
        
     }
    
    

    
}
