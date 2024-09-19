using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    internal class Telefono
    {
    //CONSTRUCTOR
        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }
    //ATRIBUTOS
        private string modelo;
        private string marca;
        private string numTelefonico;
        private int codOperador;
    //PROPIEDADES
    public string Modelo { get { return modelo; } }
        public string Marca { get { return marca; } }
        public string NumTelefonico { get; set; }
        public int CodOperador 
        { 
            get { return codOperador; }
            set 
            {
                if (value > 0 && value < 4)
                    codOperador = value;
                else
                    codOperador = 0;
            }
        }

        public string llamar() 
        {
            return "Realizando llamada...";
        }
        public string llamar(string contacto)
        {
            return "LLamando a " + contacto + ".";
        }


    }
}
