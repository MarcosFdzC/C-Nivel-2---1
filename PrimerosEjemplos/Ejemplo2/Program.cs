using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables 
            //int float bool char
            //double, decimal,long, short, string, datetime 
            int a = 10, b, c;
            float f;



            Console.WriteLine("Hola Marcos!");
            Console.WriteLine("Ingrese un bro ");
            a = int.Parse(Console.ReadLine());
            c = a + b;
            
            console.readkey(); //Pide una letra


            //Condicionales:

            if (a  == b && b != c || !(a==20))
            {
                
            }
            else if ()
            {

            }
            else if ()
            {

            }
            else if () 
            {

            }

            switch (a)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }


            //Ciclos:
            for (int x = 0; x < 10; x++)
            {
                while (a !== 0)
                {
                
                }   
            }

            do
            {
            } while (a == 0);


            //vectores
            //int, float, char, bool, struct

            int[] vector = new int[10];
            Console.WriteLine(vector[2]);
            Console.WriteLine(vector[0]);

                //todolo lo que va entre "" es un string, en este caso "marcos" es un string que contiene el nombre marcos.
            Console.WriteLine("Marcos");
            sumar(2, ref b); 
        }
        static int sumar(int a,ref int b)
        {
            return a + b;
        }
        static string saludar(string nombre)
        {
            return "hola" + nombre;
        }


    }
}
