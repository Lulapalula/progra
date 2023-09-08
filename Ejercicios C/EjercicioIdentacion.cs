/*
INSTRUCCIONES

1. En cada una de las líneas del siguiente código
deberás colocar un comentario al final de la línea en el que 
indiques  el nivel de identación de la siguiente manera: //Identacion: #
donde # es el nivel de identación.

2. Adicional al nivel de identación, en cada línea donde 
haya una llave de apertura deberás colocar un comentario 
que diga: //Inicio de bloque ... 
donde los 3 puntos indican a qué le pertenece, por ejemplo:
inicio de bloque de metodo1, inicio de bloque de claseA, 
inicio de ciclo for, etc.
Y, donde haya una llave de cierre, deberás colocar lo mismo, 
pero indicando //Fin de bloque ...

Observa algunas líneas de ejemplo que ya lo tienen.
Debes hacerlo para cada una de las líneas, excepto las que 
estén vacías.
*/
using System;//Identacion: 3, Comunicacion con el sistema 

namespace ClasesYMetodosAnidados//Identacion: 0
{//Identacion: 0, Inicio de bloque de namespace ClasesYMetodosAnidados
	class Program //Identacion: 1, Inicio de bloque de clase "Program"
	{//Identacion: 1
		static void Main(string[] args)//Identacion: 2, Inicio de metodo
		{//Identacion: 2
			ClaseA objetoA = new ClaseA();//Identacion: 3
			ClaseB objetoB = new ClaseB();//Identacion: 3

			objetoA.Metodo1();//Identacion: 3
			objetoA.Metodo2();//Identacion: 3

			objetoB.Metodo1();//Identacion: 3
			objetoB.Metodo2();//Identacion: 3
		}////Identacion: 2, Fin de bloque metodo
	}////Identacion: 1, Fin de bloque de clase "Program"

	class ClaseA //Identacion: 1, inicion de bloque de clase "ClaseA"
	{
		public void Metodo1() //Identacion: 2, inicio de bloque "Metodo1"
		{//Identacion: 2
			for (int i = 0; i < 3; i++)//Indentacion: 3, inicio de bloque ciclo for 
			{//Identacion: 3
				Console.WriteLine("Método 1 de ClaseA - Iteración: " + i);//Identacion: 4

				for (int j = 0; j < 2; j++) //identacion: 4, inicio de bloque ciclo for 
				{//Identacion: 4
					Console.WriteLine("Ciclo anidado - Iteración: " + j);//Identacion: 5
				}////Identacion: 4, Fin de bloque ciclo for 
			}////Identacion: 3, Fin de bloque ciclo for 
		}////Identacion: 2, Fin de bloque "Metodo1"

		public void Metodo2()//Identacion: 2, inicio de bloque "Metodo2"
		{//Identacion: 2
			if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)//Identacion: 3, incio de bloque condicionante if
			{//Identacion: 3
				Console.WriteLine("Es fin de semana en Método 2 de ClaseA");//Identacion: 4
			}////Identacion: 3, Fin de bloque condicionante if 
			else//Identacion: 3, inicio de bloque condicionante else 
			{//Identacion: 3
				Console.WriteLine("No es fin de semana en Método 2 de ClaseA");//Identacion: 4
			}////Identacion: 3, Fin de condicionante else 
		}////Identacion: 2, Fin de bloque "Metodo2"
	}////Identacion: 1, Fin de bloque de clase "ClaseA"

	class ClaseB//Identacion 1, inicio de bloque de clase "ClaseB"
	{//Identacion: 1
		public void Metodo1()//Identacion: 2, inicio de bloque "Metodo1" 
		{//Identacion: 2
			for (int i = 5; i > 0; i--)//Idenacion: 3, inicio de bloque ciclo for 
			{//Identacion: 3 
				Console.WriteLine("Método 1 de ClaseB - Iteración: " + i);//Identacion: 4

				for (int j = 0; j < i; j++)//Identacion: 4, inicio de bloque ciclo for
				{//Identacion: 4
					Console.WriteLine("Ciclo anidado - Iteración: " + j);//Identacion: 5
				}////Identacion: 4, Fin de bloque ciclco for 
			}////Identacion: 4, Fin de bloque ciclo for 
		}////Identacion: 3, Fin de bloque "Metodo1" 

		public void Metodo2()//Identacion: 1, inicion de bloque "Metodo2" 
		{//Identacion: 2
			int numero = 10;//Identacion: 2

			if (numero % 2 == 0)//Identacion: 2, inicio de bloque condicionante if 
			{//Identacion: 3
				Console.WriteLine("El número es par en Método 2 de ClaseB");//Identacion: 3
			}//Fin de  condicionante if
			else////Identacion: 3, Inicio de bloque condicionante else
			{//Identacion: 3
				Console.WriteLine("El número es impar en Método 2 de ClaseB");//Identacion: 3
			}////Identacion: 3, Fin de condicionante else 
		}////Identacion: 2, Fin de bloque Metodo2
	}////Identacion: 1, Finde bloque de clase "ClaseB"
}//Identacion:0, Fin de bloque de namespace ClasesYMetodosAnidados