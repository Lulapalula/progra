using System;

namespace PracticasConstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            //este rectangulo se quedò con sus valores x default
            Rectangulo rect1 = new Rectangulo();
            rect1.describir();
            float area1 = rect1.calArea();
            Console.WriteLine("area=" + area1);

            //este se quedó con su altura
            Rectangulo rect2 = new Rectangulo();
            rect2.setAlto(12);
            rect2.describir();
            float area2 = rect2.calArea();
            Console.WriteLine("area=" + area2);

            //construyo un rectangulo definiendo los valores desde el constructor
            Rectangulo rect3 = new Rectangulo(3, 2);
            rect3.describir();
            float area3 = rect3.calArea();
            Console.WriteLine("Area=" + area3);

            //triangulete -------------------------------------------------------------
            Triangulo tri1 = new Triangulo(3, 2, 2);
            tri1.describir();
            tri1.calPeri();
            float perimetro1 = tri1.calPeri();
            Console.WriteLine("Perimetro=" + perimetro1);

            Triangulo tri2 = new Triangulo(3, 4, 4);
            tri2.describir();
            tri2.calPeri();
            float perimetro2 = tri2.calPeri();
            Console.WriteLine("Perimetro=" + perimetro2);

            //circulete--------------------------------------------------------------------
            Circulo cir1 = new Circulo(3);
            cir1.describir();
            cir1.calculoPerimetro();
            float peri1 = cir1.calculoPerimetro();
            Console.WriteLine("Perimetro=" + peri1);

            Circulo cir2 = new Circulo(7);
            cir2.describir();
            cir2.calculoPerimetro();
            float peri2 = cir2.calculoPerimetro();
            Console.WriteLine("Perimetro=" + peri2);


            //MAS CLASES
            //PRODUCTO
            Producto pr1 = new Producto(10);
            pr1.describir();
            pr1.calIVA();
            float precio = pr1.calIVA();
            Console.WriteLine("Precio con IVA =" + precio);

            //ZAPATO
            Zapato zap1 = new Zapato(10, "azul");
            zap1.describir();

            //Persona
            Persona per1 = new Persona(1993);
            per1.describir();
            per1.calEdad();
            float añoNacimiento = per1.calEdad();
            Console.WriteLine("Tu edad es de " + añoNacimiento);

            //Email

            Console.ReadLine();

        }
    }
}
