using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCuenta
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la clase CuentaBancaria
            CuentaBancaria miCuenta = new CuentaBancaria();

            // Establecer el PIN
            miCuenta.setPin(123); // el PIN deseado
            miCuenta.getPin();

            miCuenta.setSaldo();
            miCuenta.getSaldo(129);
          
            Console.ReadLine(); // Esperar a que el usuario presione una tecla antes de cerrar la consola
        }
    }
}

