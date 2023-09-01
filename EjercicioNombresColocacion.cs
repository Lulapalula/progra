/*
En este ejercicio practicarás el nombre de las cosas
y su ubicación dentro del código.
Por cada línea que tenga una declaración de namespace,
clase, método, atributo, parámetro, variable, así como 
en ciclos y bloques condicionales, deberás indicar con un comentario 
qué es lo que se está declarando y dentro de qué bloque está.

No copies y pegues, debes transcribir.
NO: class Elefante
SI: clase Elefante

Observa con atención los primeros ejemplos.
*/

using System;//El using no es una declaración

namespace Ejemplos//Declaración de espacio de nombres Ejemplos
{
    class Elefante//Declaración de clase Elefante dentro de namespace Ejemplos
    {
        public string Nombre;//Declaración de atributo Nombre dentro de clase Elefante
        public int Edad; //Declaración de atributo Edad dentro de la clase Elefante
        public float Peso; //Declaración de atributo Peso dentro de la clase Elefante

        //Declaración de método Comer dentro de clase Elefante
        //Declaración de parámetro comida dentro de método comer
        public void Comer(string comida)
        {
            
            for(int i = 0; i < 10; i++)//Ciclo for dentro de método Comer
            {
                int porcionesComidas = i + 1;//Declaración de variable local porcionesComidas dentro de ciclo for
            }
            Console.WriteLine($"{Nombre} está comiendo {comida}.");//Esta línea no llevará comentario
        }

        public void Rugir() //Declaración del método Rugir dentro de la clase Elefante
        {
            int distanciaEscuchante = 100; //Declaración de variable local distanciaEscuchante dentro de método rugir
            Console.WriteLine($"{Nombre} está rugiendo.");
        }


        //Declaración de método Dormir dentro de clase Elefante
        //Declaración de parametro horas dentro de método Dormir
        public void Dormir(int horas) 
        {
            if(horas > 10) //Declaración de bloque condicional if dentro del método Dormir
            {
                float energiaGanada = 15; //variable local energiaGanada dentro de bloque condicional if
            }
            Console.WriteLine($"{Nombre} está durmiendo durante {horas} horas.");
        }
    }

    class Zapatero //Declaración de clase Zapatero dentro de namespace ejemplos
    {
        public string Nombre; //Declaración de atributo Nombre dentro de clase Zapatero
        public string Especialidad; //Declaración de atributo Especialidad dentro de la clase Zapatero
        public int AñosExperiencia; //Delcaración de atributo AñosExperiencia dentro de la clase Zapatero

        public void RepararZapatos(string tipo, int cantidad) //Declaración de método RepararZapatos dentro de la clase Zapatero
        {
            int precio = 50; //declaración de variable local precio dentro de método RepararZapatos
            if (tipo == "tenis") //Declaración de bloque condicional if dentro del método RepararZapatos
            {
                precio = 100; //uso de la declaración de la variable local 
            }
            Console.WriteLine($"{Nombre} está reparando {cantidad} zapatos de tipo {tipo} a precio {precio}");
        }

        public void CrearZapato(string estilo, string material) //declaración del método CrearZapato dentro de la clase Zapatero
        {
            for(int i = 0; i < 100; i++) //declaración del ciclo for dentro del método CrearZapato 
            {
                if(estilo == "industrial") //Declaración de bloque condicional if dentro del ciclo for
                {
                    Console.WriteLine("Golpeando fuerte");
                }
                else 
                {
                    Console.WriteLine("Golpeando normal");

                }
            }
            Console.WriteLine($"{Nombre} está creando un zapato de estilo {estilo} con material {material}.");
        }

        public void MedirPie(int numeroPie) //declaración del método MedirPie dentro de la clase Zapatero
        {
            string cliente; //declaración de la vairable cliente dentro del método MedirPie
            if (numeroPie > 20) //Declaración del bloque condicional if dentro del método MedirPie
            {
                cliente = "Adulto"; //uso
            }
            else
            {
                cliente = "Niño"; //uso 
            }
            Console.WriteLine($"{Nombre} está midiendo el pie para el número {numeroPie}.");
        }
    }

    class Television //declaraciòn de la clase Televisión dentro de namespace Ejemplos
    {
        public string Marca; //Declaración de atributo Marca dentro de la clase Televisión
        public int Pulgadas; //Declaración de atributo Pulgadas dentro de la clase Televisiòn
        public bool Encendida; //Declaración de atributo Encendida dentro de la clase Televisión

        public void Encender() //Declaración del método Encender dentro de la clase Televisión
        {
            Encendida = true; //uso del atributo Encendida
            float consumoLuz = 0.05f; //Declaraciòn de variable local conzumo luz dentro del método Encender
            Console.WriteLine($"La televisión de {Pulgadas} pulgadas, marca {Marca}, está encendida.");
        }

        //Declaración del método CambiarCanal dentro de la clase Televisiòn
        //Declaración de parametro canal dentro de método Televison
        public void CambiarCanal(int canal)  
        {
            for(int i = 1; i < canal; i++) //declaración del ciclo for dentro del método CambiarCanal
            {
                Console.WriteLine($"Cambiando a canal {i}.");
            }            
        }

        public void AjustarVolumen(int nivel)  //Declaración del método AjustarVolumen dentro de la clase Televisiòn
        {
            if (nivel > 100) //Declaración del bloque condicional if dentro del método AjustarVolumen
            {
                nivel = 0; //Uso
            }
            Console.WriteLine($"Ajustando el volumen a nivel {nivel}.");
        }
    }

    class Guitarra //declaraciòn de la clase Guitarra dentro de namespace Ejemplos
    {
        public string Marca; //Declaración de atributo Marca dentro de la clase Guitarra
        public string Tipo; //Declaración de atributo Tipo dentro de la clase Guitarra
        public int Cuerdas; //Declaración de atributo Cuerdas dentro de la clase Guitarra

        public void TocarCuerda(int numeroCuerda) //Declaración del método TocarCuerda dentro de la clase Guitarra
        {
            if(numeroCuerda == 6) //declaraciòn de bloque condicional if dentro de Clase Guitarra
            {
                string nota = "Mi"; //uso 
            }
            else if (numeroCuerda == 5) //declaraciòn de bloque condicional else if dentro de Clase Guitarra
            {
                string nota = "La"; //uso
            }
            Console.WriteLine($"Tocando la cuerda {numeroCuerda} de la guitarra {Marca}.");
        }

        public void AfinarGuitarra(bool afinada) //Declaración del método AfinarGuitarra 
        {
            if (afinada)
            {
                Console.WriteLine($"La guitarra {Marca} está afinada.");
            }
            else
            {
                for(int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Afinando la guitarra {Marca}.");
                }                
            }
        }

        public void CambiarTipo(string nuevoTipo)
        {
            Tipo = nuevoTipo;
            Console.WriteLine($"Cambiando el tipo de la guitarra a {nuevoTipo}.");
        }
    }

}
