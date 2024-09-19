using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona p1 = new Persona();
            //Developer d1 = new Developer();
            //Lider l1 = new Lider();
            //Camioneta c1 = new Camioneta();
            //Camioneta c2 = new Camioneta();
            //Camioneta c3 = new Camioneta();
            //c1.color = "Amarillo";
            //c2.color = "Roja";
            //c3.color = "Blanca";

            //List<Camioneta> listaCamionetas = new List<Camioneta>();
            //listaCamionetas.Add(c1);
            //listaCamionetas.Add(c2);
            //listaCamionetas.Add(c3);

            //Console.WriteLine("La cantidad de camionetas es: " + listaCamionetas.Count);
            //listaCamionetas[1].color = "Negra";
            //c2.color = "Verde";//al ser los objetos de tipo referencial si lo volvemos definir la primer referencia queda obsoleta y queda unicamente nuestro segundo valor asignado. Por lo tanto en la lista no importa en que momento guardemos el item, si lo volvemos a cambiar por fuera, tambien cambia en la lista ya que son todos valores guardados por referencia.

            //Console.WriteLine("El color es" + listaCamionetas[1].color);
            //listaCamionetas.Remove(c3);//eliminamos el tercer item de la lista.

            //foreach (Camioneta item in listaCamionetas)//este ciclo gira la cantidad de vueltas que tenga nuesta lista.
            //{
            //    Console.WriteLine("El colore es: " + item.color);

            //}

            Auto a1 = new Auto();
            a1.Motor = new Motor();

            Console.ReadKey(); 

            
        }
    }
}
