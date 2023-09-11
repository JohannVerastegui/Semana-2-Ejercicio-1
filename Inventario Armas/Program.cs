using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_Armas
{
    class Program
    {
        static void Main(string[] args)
        {
            int indice;
            Arma Espada = new Espada(10, 2, 50, "Espada de Hierro");
            Arma Hacha = new Hacha(30, 1, 70, "Hacha de Oro");
            Arma Arco = new Arco(8, 1, 50, "Arco Corto", 0);
            Arma Pistola = new Pistola(15, 3, 100, "Revolver", 0);
            Proyectil Flecha = new Flecha(7, 15, "Flecha pequeña");
            Proyectil Bala = new Bala(12, 30, "Municion");
            Console.WriteLine("¿Qué quiere comprar?");
            Console.WriteLine("1.- Espada");
            Console.WriteLine("2.- Arco");
            Console.WriteLine("3.- Pistola");
            Console.WriteLine("4.- Flecha");
            Console.WriteLine("5.- Bala");
            Console.WriteLine("6.- Hacha");

            indice = Convert.ToInt32(Console.ReadLine());


            //void AgregarArma(List<Arma> inventario)
            //{
            //    Console.WriteLine("¿Qué tipo de arma desea agregar?");
            //    Console.WriteLine("1. Arma de cuerpo a cuerpo");
            //    Console.WriteLine("2. Arma a distancia")

            //}
            switch (indice)
            {
                case 1:
                    Console.WriteLine("Estas son las caracteristicas de la Espada");
                    Console.WriteLine(Espada.dmg);
                    Console.WriteLine(Espada.aVelocidad);
                    Console.WriteLine(Espada.precio);

                    break;

                case 2:
                    Console.WriteLine("Estas son las caracteristicas del Arco");
                    Console.WriteLine(Arco.dmg);
                    Console.WriteLine(Arco.aVelocidad);
                    Console.WriteLine(Arco.precio);
                    Console.WriteLine(Arco.flecha);
                    break;

                case 3:
                    Console.WriteLine("Estas son las caracteristicas de la Pistola");
                    Console.WriteLine(Pistola.dmg);
                    Console.WriteLine(Pistola.aVelocidad);
                    Console.WriteLine(Pistola.precio);
                    Console.WriteLine(Pistola.bala);
                    break;

                case 4:
                    Console.WriteLine("Estas son las caracteristicas de la Flecha");
                    Console.WriteLine(Flecha.dmg);
                    Console.WriteLine(Flecha.precio);
                    break;

                case 5:
                    Console.WriteLine("Estas son las caracteristicas de la Bala");
                    Console.WriteLine(Bala.dmg);
                    Console.WriteLine(Bala.precio);
                    break;

                case 6:
                    Console.WriteLine("Estas son las caracteristicas de la Hacha");
                    Console.WriteLine(Hacha.dmg);
                    Console.WriteLine(Hacha.aVelocidad);
                    Console.WriteLine(Hacha.precio);
                    break;



            }
        }
    }
}
