using System;

namespace BancoCuenta
{
    public class CuentaBancaria
    {
        private int pin;
        private int saldo;

        public int getPin()
        {
            return pin;
        }
        public void setPin(int valor)
        {
            pin = valor;
            if (pin != 0)
            {
                return pin;
            }
            else
            {
                Console.WriteLine
            }
        }

        public int getSaldo()
        {
            return saldo;
        }
        public void setSaldo(int valor)
        {
            saldo = valor;
        }

    }
}