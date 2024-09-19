using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Articulo
    {
        //ATRIBUTOS:
        private string nombreMarca;
        private float precio;
        private int codArticulo;


        //PROPIEDADES:
        public string NombreMarca 
        {
            get { return nombreMarca; }
            set { nombreMarca  = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; } 
        }
        public int CodigoArticulo 
        {
            get { return codArticulo; }
            set { codArticulo = value; } 
        }

        //      CONSTRUCTOR: para inicializar manualmente los atributos en cada instancia de la clase.
        public Articulo(string nombreMarca)
        {
            this.nombreMarca = nombreMarca;
            //esto nos obliga a cargar inicialmente nuestro objeto.
            //iniciamos simpre con "this.atributo" para que el compilador haga targget especificamente al atributo en le constructor y no a cualquier otro.
        }
        //si no quisieramos que fuera obligatorio, tendriamos que aplicar el concepto de "SOBRE CARGA DE CONSTRUCTOR"
        public Articulo()
        {
            //este constructor vacio nos genera la opción de cargar nuestro objeto o no.
        }
        //      DESTRUCTOR:
        ~Articulo()
        {
            //Lógica del destructor, no son comumnente usados en c#
        }


        //      MÉTODO:
        public string romper()
        {
            return "El articulo se rompió";
        }


    }
}
