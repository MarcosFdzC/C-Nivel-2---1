using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class AnimalDomestico : Animal
    {
        public AnimalDomestico(string nombre) 
        {
            this.nombre = nombre;
        }
        public AnimalDomestico() { }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; } 
        }


        //sobreescritura de método deflault "ToString();"
        public override string ToString()
        {
            return Nombre;
        }
    }
}
