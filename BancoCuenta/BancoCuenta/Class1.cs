using System;

public class CuentaBancaria
{
    // Atributos privados
    private int saldo;            // Almacena el saldo de la cuenta bancaria como un entero.
    private int pin;              // Almacena el PIN de la cuenta bancaria como un entero.
    private bool pinEstablecido;  // Indica si el PIN de la cuenta bancaria está establecido.

    // Constructor
    public CuentaBancaria()
    {
        saldo = 0;               // Inicializa el saldo en 0 cuando se crea una instancia de la cuenta.
        pinEstablecido = false;  // Inicializa la variable que indica si el PIN está establecido en "false".
    }

    // Propiedad para el saldo
    public int Saldo
    {
        get
        {
            if (!pinEstablecido)
            {
                Console.WriteLine("El PIN no está establecido. No se puede acceder al saldo.");
                return 0;
            }
            return saldo;  // Devuelve el valor del saldo si el PIN está establecido.
        }
        set
        {
            if (pinEstablecido)
            {
                saldo = value;  // Establece el valor del saldo si el PIN está establecido.
            }
            else
            {
                Console.WriteLine("El PIN no está establecido. No se puede cambiar el saldo.");
            }
        }
    }

    // Método para establecer el PIN
    public void EstablecerPIN(int nuevoPIN)
    {
        pin = nuevoPIN;           // Asigna el nuevo PIN proporcionado al atributo "pin".
        pinEstablecido = true;    // Marca que el PIN está establecido como "true".
    }
}

