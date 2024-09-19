using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalDomestico a1 = new AnimalDomestico();
            a1.Nombre = "Pepe";
            //Console.WriteLine(a1.ToString());
            Console.WriteLine(a1.comunicarse());

            Gato g1 = new Gato();
            g1.Nombre = "Pepe";
            Console.WriteLine(g1.comunicarse());

            /*List<Animal> animales = new List<Animal>();
            animales.Add(a1);
            animales.Add(g1);
            //en vez de crear una variable y luego guardar el nuevo objeto en la variable
            //aca crearemos un nuevo elemento de la lista y dentro de los paréntesis agregaraemos un nuevo objeto con new objeto()
            animales.Add(new Pez("Pecesito"));
            animales.Add(new Canario("Juancho"));
            animales.Add(new Aguila());

            foreach (Animal item in animales)
            {
                if (item is AnimalDomestico)
                    Console.WriteLine(item.ToString());
                else
                    Console.WriteLine("Es un animal salvaje.");
            }*/

//                                                          INTERFAZ:
        
            


            Console.ReadKey();
        }
    }
}
