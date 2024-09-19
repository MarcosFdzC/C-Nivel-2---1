using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Maxi";
            nombre = "hola como estas??" + nombre;

            int cant = nombre.Length;

            nombre = nombre.ToUpper();
            nombre = nombre.ToLower();
            nombre = nombre.Replace('a', 'e');//cambia el primer caracter 'a' por el segundo 'b'.
                                              //dicho de manera correcta el viejo caracter por el nuevo.
                                              //siempre entre comillas simples '' si ponemos comillas dobles "" es para definir un              dato de tipo string en vez de char.
            nombre = nombre.Replace("hola", "chau");//en este caso cambiaremos una cadena de caracteres por otra.
            
            Console.WriteLine(nombre);
            Console.ReadKey();
        }
    }
}
