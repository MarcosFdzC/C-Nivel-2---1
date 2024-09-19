using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //      Primer lote con 10 registros de productos, cada registro contiene:
            //      Cod articulo(3 dig no correlativos)
            //      Precio
            //      Código de marca (1 al 10)
            //      Segundo lote con las ventas de la semana, cada venta tiene:
            //      cod art 
            //      cantidad 
            //      cod cliente 
            //      Este lote corta con un cod de cliente igual a 0
            //          ARITUCULO 
            //Articulo[] articulos = new Articulo[10];
            //for (int x = 0; x < 5; x++)
            //{
            //    articulos[x] = new Articulo();
            //    Console.WriteLine("Ingres los datos del artículo: ");
            //    Console.WriteLine("Artículo");
            //    articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Precio");
            //    articulos[x].Precio = float.Parse(Console.ReadLine());
            //    Console.WriteLine("Marca");
            //    articulos[x].NombreMarca = Console.ReadLine();
            //}
            //Console.WriteLine(articulos[1].romper());
            //Console.ReadKey();


            //          PERSONA
            //Persona p1 = new Persona("Pepe");
            //p1.setEdad(20);
            //Console.WriteLine(p1.saludar());
            //Console.WriteLine(p1.saludar("MAXI"));


            //          BOTELLA
            Botella b1 = new Botella("rojo", "material");

            b1.recargar();
            Console.WriteLine("Luego de recargar, la cantidad actual es: " + b1.CantidadActual);
            b1.recargar(20); 
            Console.WriteLine("Luego de recargar, la cantidad actual es: " + b1.CantidadActual);
            
        }
    }
}
