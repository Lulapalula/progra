using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDeEstudioCSharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //punto de inicio o entrada de mi programa 


            //tipo  indentificador inicializacion 
            //declaracion / instanciacion 
            DispositivoMovil miIphone = new DispositivoMovil();
            //int              edad   = 30; Representa la declaracion de un objeto 

            miIphone.almacenamiento = 64;
            miIphone.ram = 128;
            miIphone.resoluAlto = 1080;
            miIphone.resoluAncho = 1920;

            miIphone.color = new Color(); 
            miIphone.color.rojo = 100;
            miIphone.color.verde = 255;
            miIphone.color.azul = 145;

            DispositivoMovil tabletSamsung = new DispositivoMovil();

            tabletSamsung.almacenamiento= 250;
            tabletSamsung.ram= 124;
            tabletSamsung.resoluAlto = 1080;
            tabletSamsung.resoluAncho = 1920;


            miIphone.color = new Color();
            miIphone.color.rojo = 130;
            miIphone.color.verde = 220;
            miIphone.color.azul = 78;

            DispositivoMovil smartwatch = new DispositivoMovil();

            smartwatch.almacenamiento = 64;
            smartwatch.ram = 4;
            smartwatch.resoluAlto = 540;
            smartwatch.resoluAncho = 540;

            smartwatch.color = new Color();
            smartwatch.color.rojo = 130;
            smartwatch.color.verde = 220;
            smartwatch.color.azul = 78;

        }
    }
}
