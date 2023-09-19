using System;

public class CuentaBancaria
{
    // Atributos privados
    private double saldo;            // Almacena el saldo de la cuenta bancaria como un entero.
    private int pin;              // Almacena el PIN de la cuenta bancaria como un entero.

    
    public int getPin()
    {
        Console.WriteLine("Pin establecido correctamente");
        return pin;
    }

    public void setPin(int nuevoPin)
    {
        pin = nuevoPin;
    }
    // Propiedad para el saldo
    public double getSaldo(int pinIngresado)
    {
        if (pin == pinIngresado)
        {
            Console.WriteLine($"Su saldo es: {saldo}");
            return saldo;
        }

        else
        {
            Console.WriteLine("PIN incorrecto, no puedes ver el saldo. Intenta de nuevo");
            return -1;
        }
        
    }

    public void setSaldo()
    {
        saldo = 10.50;
    }
}

