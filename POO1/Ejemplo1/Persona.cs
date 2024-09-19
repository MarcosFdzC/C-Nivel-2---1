using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Persona //la clase es la definicion/plano/estructura que tendrá cada objeto que creemos
    {
        //Persona: Edad, Sueldo, Nombre (datos que conforman a mi clase persona)

        //ATRIBUTOS o MIEMBROS
        private int edad;
        private float sueldo;
        private string nombre;

        //CONSTRUCTOR:
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        //metodo: son pseudo funciones pero se conocen como metodo por razones conceptuales.
        public void setEdad(int e) 
        {
            edad = e;
        }
        public int getEdad()
        {
            return edad;  
        }
        //Modificadores de visibilidad: private, public, protected, internal
        public string saludar() 
        {
            return "hola soy..." + nombre;
        }
        public string saludar(string personaje) 
        {
            return "Hola " + personaje + ", soy... " + nombre;
        }

    }
}
