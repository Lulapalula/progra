using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombreDeJugador
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneradorDeNombres int1 = new GeneradorDeNombres();//invocacion de la clase
            int1.generar(6,2);//invocacion del metodo
            Console.ReadLine();
        }

    }

}
