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
            miCuenta.EstablecerPIN(1234); 

            // Acceder al saldo (esto funcionará porque se estableció el PIN)
            int saldoActual = miCuenta.Saldo;
            Console.WriteLine($"Saldo actual: {saldoActual} dólares");

            // Intentar cambiar el saldo (esto mostrará un mensaje de error si el PIN no está establecido)
            miCuenta.Saldo = 1000; // Cambia el saldo si se estableció el PIN

            // Acceder al saldo nuevamente
            saldoActual = miCuenta.Saldo;
            Console.WriteLine($"Saldo actual: {saldoActual} dólares");

            Console.ReadLine(); // Esperar a que el usuario presione una tecla antes de cerrar la consola
        }
    }
}
