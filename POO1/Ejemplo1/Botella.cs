using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Botella
    {
        public Botella (string color, string material)//CONSTRUCTOR
        {
            this.color = color;
            this.material = material;
            capacidad = 100;//esto demuestra que en un constructor puedo iniciar datos sin necesidad de pedirselos al usuario.
            cantidadActual = 0;
        }

        //ATRIBUTOS
        private int capacidad;
        private int cantidadActual;
        private string color;
        private string material;

        //propiedad: es un pseudométodo pero con funcionalidad y sintaxis de c#.
        public string Material 
        {
            get { return material; }
        }
        //public int Capacidad 
        //{
        //    get 
        //    { return capacidad; }
        //}
        public int CantidadActual
        {
            get { return cantidadActual; }
        }
        //public int capacidad
        //{
        //    get { return capacidad; }
        //    set { capacidad = value; }
        //}//asi se escribe una propiedad en c#

        //      en el caso de otro lenguaje normalmente se escribe un método para setear y otro para leer el atributo.
        //      de la siguiente forma:
        //      public void setcapacidad(int c)
        //      {
        //          capacidad = c;
        //      }
        //      public int getcapacidad()
        //      {
        //          return capacidad;
        //      }

        //METODO
        public float recargar()
        {
            if (cantidadActual > 0)
            {
                int dif = capacidad - cantidadActual;
                float monto = (dif * 50) / capacidad;
                cantidadActual += dif;
                return monto;
            }
            else
            {
                return 50;

            }
        }public float recargar(int cantidad)
        {
            cantidadActual += cantidad;
            return ((cantidad * 50) / 100);
        }
    } 
}
