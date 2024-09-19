using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla el estado del Telefono.

            Telefono t1 = new Telefono("Note 11s", "Xiaomi");
            Telefono t2 = new Telefono("Redmi 13", "Xiaomi");
            t1.NumTelefonico = "099 457444";
            t1.CodOperador = 3;

            t2.NumTelefonico = "099 526888";
            t2.CodOperador = 4;

            Console.WriteLine("Teléfono " + t1.Marca+ " " + t1.Modelo);
            if (t1.CodOperador > 0 && t1.CodOperador <= 3)
                Console.WriteLine("Número telefónico... " + t1.NumTelefonico + " con el op... " + t1.CodOperador);
            else
                Console.WriteLine("Número telefónico... " + t1.NumTelefonico + " el operador está mal ingresado = " + t1.CodOperador);
            Console.WriteLine(t1.llamar());

            Console.WriteLine("Teléfono " + t2.Marca + " " + t2.Modelo);
            if (t2.CodOperador > 0 && t2.CodOperador <= 3)
                Console.WriteLine("Número telefónico... " + t2.NumTelefonico + " con el op... " + t2.CodOperador);
            else
                Console.WriteLine("Número telefónico... " + t2.NumTelefonico + " el operador está mal ingresado = " + t2.CodOperador);
            Console.WriteLine(t2.llamar("MAXI"));


            Console.ReadKey();



        }
    }
}
