using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Pez : AnimalDomestico
    {
        public Pez (string nombre) : base (nombre) { }//INVOCACIÓN DE MÉTODO DE LA CLASE BASE.
    }
}
