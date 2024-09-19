using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Auto : Vehiculo
    {
        public Auto() 
        {
            Chasis = new Chasis();
        }

        public int Anio {  get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }


        //Asocicación es mal conocida como composición.
        //La diferencia de asociación por composición o agregación es meramente conceptual teniendo en cuenta la cercania de la reclación del objeto, basandonos si el nuevo objeto pude ser creado sin él o no.

        //Composición:
        //  Define una relación cercana donde el objeto debe nacer con ese otro objeto que lo compone.
        //  Es un objeto como tipo de dato en un parámetro o atributo.
        public Chasis Chasis { get; }

        
        //Agregación:
        public Motor Motor { get; set; }//el auto se puede crear sin el motor.

    }
}
